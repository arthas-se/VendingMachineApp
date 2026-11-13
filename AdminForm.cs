//AdminForm.cs
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using VendingMachineApp.Core.Interfaces;
using VendingMachineApp.Core.Models;
using VendingMachineApp.BusinessLogic;

namespace VendingMachineApp;

public partial class AdminForm : Form
{
    private const string OrderDateFormat = "dd.MM.yyyy HH:mm";

    private readonly VendingMachine _vendingMachine;
    private readonly JsonHelper _jsonHelper;

    private readonly List<ISortAlgorithm> _sortAlgorithms = new List<ISortAlgorithm>
    {
        new SortByDate(),
        new SortByPrice()
    };

    private readonly List<IFilterAlgorithm> _filterAlgorithms = new List<IFilterAlgorithm>
    {
        new FilterByType(),
        new FilterByName()
    };

    private List<OrderHistoryItem> _history = new List<OrderHistoryItem>();
    private List<OrderHistoryItem> _displayedHistory = new List<OrderHistoryItem>();

    public AdminForm(VendingMachine vendingMachine, JsonHelper jsonHelper)
    {
        InitializeComponent();

        _vendingMachine = vendingMachine ?? throw new ArgumentNullException(nameof(vendingMachine));
        _jsonHelper = jsonHelper ?? throw new ArgumentNullException(nameof(jsonHelper));

        cmbSortField.DataSource = _sortAlgorithms;
        cmbFilterType.DataSource = _filterAlgorithms;
    }

    private void AdminForm_Load(object? sender, EventArgs e)
    {
        nudMonth.Value = DateTime.Now.Month;
        nudYear.Value = Math.Clamp(DateTime.Now.Year, (int)nudYear.Minimum, (int)nudYear.Maximum);

        LoadHistory();
        ShowAllHistory();
        ShowPendingAlert();
    }

    private void ShowPendingAlert()
    {
        try
        {
            if (!File.Exists(AppPaths.AdminAlert)) return;

            string message = File.ReadAllText(AppPaths.AdminAlert);

            if (string.IsNullOrWhiteSpace(message)) return;

            File.WriteAllText(AppPaths.AdminAlert, string.Empty);

            MessageBox.Show(message, "Resource shortage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error reading alert: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void BtnSortAsc_Click(object? sender, EventArgs e) => ApplySort(descending: false);

    private void BtnSortDesc_Click(object? sender, EventArgs e) => ApplySort(descending: true);

    private void ApplySort(bool descending)
    {
        if (cmbSortField.SelectedItem is not ISortAlgorithm sorter) return;

        try
        {
            _displayedHistory = descending
                ? sorter.SortDesc(_displayedHistory)
                : sorter.SortAsc(_displayedHistory);

            RenderHistory();
            lblDisplay.Text = $"SORTED BY {sorter.Name.ToUpper()} {(descending ? "DESC" : "ASC")}";
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Cannot sort the history: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void BtnApplyFilter_Click(object? sender, EventArgs e)
    {
        if (cmbFilterType.SelectedItem is not IFilterAlgorithm filter) return;

        string criteria = txtFilterCriteria.Text.Trim();

        _displayedHistory = filter.Filter(_history, criteria);

        RenderHistory();
        lblDisplay.Text = string.IsNullOrEmpty(criteria)
            ? "SALES HISTORY"
            : $"FILTER: {criteria.ToUpper()}";
    }

    private void BtnResetFilter_Click(object? sender, EventArgs e)
    {
        txtFilterCriteria.Clear();
        ShowAllHistory();
    }

    private void BtnMonthlyTotal_Click(object? sender, EventArgs e)
    {
        int month = (int)nudMonth.Value;
        int year = (int)nudYear.Value;

        decimal totalSum = 0;
        var monthlyHistory = new List<OrderHistoryItem>();

        foreach (OrderHistoryItem item in _history)
        {
            if (item.Drink == null) continue;

            if (DateTime.TryParseExact(item.OrderDate, OrderDateFormat, CultureInfo.InvariantCulture,
                                       DateTimeStyles.None, out DateTime orderDate)
                && orderDate.Month == month && orderDate.Year == year)
            {
                totalSum += item.Drink.Price;
                monthlyHistory.Add(item);
            }
        }

        _displayedHistory = monthlyHistory;
        RenderHistory();

        lblDisplay.Text = $"{month:00}/{year} TOTAL: {totalSum} UAH";
        MessageBox.Show($"Total sales for {month:00}.{year}: {totalSum} UAH", "Monthly Report",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void BtnReplenish_Click(object? sender, EventArgs e)
    {
        try
        {
            Supplier supplier = CreateSupplier();
            var maintenanceOperator = new MaintenanceOperator("Ivan Petrenko", supplier, _vendingMachine);

            Dictionary<string, int> delivered = maintenanceOperator.ReplenishContents(_vendingMachine);

            _jsonHelper.WriteToFile(AppPaths.Resources, _vendingMachine.Contents);

            lblDisplay.Text = delivered.Count == 0 ? "ALREADY FULL" : "REPLENISHED";
            MessageBox.Show(BuildReplenishReport(maintenanceOperator, delivered), "Replenishment",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private static Supplier CreateSupplier()
    {
        return new Supplier("Fresh Supplies Ltd.", "Kyiv", "Industrialna St.", "15", new Dictionary<string, int>
        {
            { "Water", 20000 },
            { "CoffeeBeans", 5000 },
            { "Milk", 10000 },
            { "TeaBag_Black", 200 },
            { "TeaBag_Green", 200 },
            { "Sugar", 5000 },
            { "Ice", 2000 }
        });
    }

    private string BuildReplenishReport(MaintenanceOperator maintenanceOperator, Dictionary<string, int> delivered)
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Operator: {maintenanceOperator.FullName}");
        sb.AppendLine($"Supplier: {maintenanceOperator.Supplier.Name} ({maintenanceOperator.Supplier.Address})");
        sb.AppendLine($"Machine: {_vendingMachine.Address}");
        sb.AppendLine();

        if (delivered.Count == 0)
        {
            sb.Append("The machine is already fully stocked.");
        }
        else
        {
            sb.AppendLine("Delivered:");
            foreach (KeyValuePair<string, int> item in delivered)
            {
                sb.AppendLine($"  {item.Key}: +{item.Value}  (now {_vendingMachine.Contents[item.Key]})");
            }
        }

        return sb.ToString();
    }

    private void BtnBack_Click(object? sender, EventArgs e)
    {
        Close();
    }

    private void LoadHistory()
    {
        try
        {
            _history = _jsonHelper.ReadFromFile<List<OrderHistoryItem>>(AppPaths.History);
        }
        catch (Exception ex)
        {
            _history = new List<OrderHistoryItem>();
            MessageBox.Show($"Error reading history: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ShowAllHistory()
    {
        _displayedHistory = _history;
        RenderHistory();
        lblDisplay.Text = "SALES HISTORY";
    }

    private void RenderHistory()
    {
        dgvHistory.Rows.Clear();

        int count = 0;
        decimal total = 0;

        foreach (OrderHistoryItem record in _displayedHistory)
        {
            if (record.Drink == null) continue;

            dgvHistory.Rows.Add(
                record.OrderDate,
                record.Drink.Name,
                $"{record.Drink.Price} UAH",
                $"{record.Drink.VolumeMl} ml",
                record.Drink.GetType().Name);

            count++;
            total += record.Drink.Price;
        }

        lblDataGridTitle.Text = $"Sales History: {count} record(s), total {total} UAH";
    }
}
