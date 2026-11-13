using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Task2;

public partial class UserForm : Form
{
    private readonly VendingMachine _vendingMachine;
    private readonly JsonHelper _jsonHelper;

    public UserForm(VendingMachine vendingMachine, JsonHelper jsonHelper)
    {
        InitializeComponent();

        _vendingMachine = vendingMachine ?? throw new ArgumentNullException(nameof(vendingMachine));
        _jsonHelper = jsonHelper ?? throw new ArgumentNullException(nameof(jsonHelper));

        UpdateDataGridView();
    }

    private void DrinkButton_Click(object? sender, EventArgs e)
    {
        if (sender is not Button btn) return;

        VendingMachineButtons selectedBtn = GetButtonType(btn);

        _vendingMachine.OnResourceShortage += ShowShortageMessage;
        _vendingMachine.OnResourceShortage += SaveAdminAlert;

        try
        {
            IDrink? preparedDrink = _vendingMachine.HandleClient(selectedBtn);

            if (preparedDrink == null) return;

            SaveDrinkToHistoryJson(preparedDrink);
            SaveResources();

            lblDisplay.Text = $"READY: {preparedDrink.Name.ToUpper()}";
            UpdateDataGridView(preparedDrink);
        }
        catch (Exception ex)
        {
            lblDisplay.Text = "ERROR!";
            MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        finally
        {
            _vendingMachine.OnResourceShortage -= ShowShortageMessage;
            _vendingMachine.OnResourceShortage -= SaveAdminAlert;
        }
    }

    private void ShowShortageMessage(string _)
    {
        lblDisplay.Text = "OUT OF STOCK";
        MessageBox.Show("Not enough ingredients to prepare this drink. Please choose another one.",
                        "Insufficient ingredients", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private void SaveAdminAlert(string message)
    {
        string alert = $"[{DateTime.Now:dd.MM.yyyy HH:mm}] {message}{Environment.NewLine}";
        File.AppendAllText(AppPaths.AdminAlert, alert);
    }

    private VendingMachineButtons GetButtonType(Button btn)
    {
        if (btn == btnEspresso) return VendingMachineButtons.Espresso;
        if (btn == btnLatte) return VendingMachineButtons.Latte;
        if (btn == btnCappuccino) return VendingMachineButtons.Cappuccino;
        if (btn == btnBlackTea) return VendingMachineButtons.BlackTea;
        if (btn == btnGreenTea) return VendingMachineButtons.GreenTea;
        if (btn == btnWaterStill) return VendingMachineButtons.WaterStill;
        if (btn == btnWaterSparkling) return VendingMachineButtons.WaterSparkling;

        throw new ArgumentOutOfRangeException(nameof(btn), "Unknown button clicked");
    }

    private void BtnBack_Click(object? sender, EventArgs e)
    {
        Close();
    }

    private void UpdateDataGridView(IDrink? lastDrink = null)
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("Ingredient", typeof(string));
        dt.Columns.Add("Value", typeof(string));

        if (lastDrink != null)
        {
            dt.Rows.Add("--- LAST DRINK ---", "----------------");
            dt.Rows.Add("Name", lastDrink.Name);
            dt.Rows.Add("Price", $"{lastDrink.Price} UAH");
            dt.Rows.Add("Volume", $"{lastDrink.VolumeMl} ml");
            dt.Rows.Add("Class Type", lastDrink.GetType().Name);
            dt.Rows.Add("--- STOCK STATUS ---", "----------------");
        }

        foreach (var item in _vendingMachine.Contents)
        {
            dt.Rows.Add(item.Key, item.Value.ToString());
        }

        dgvContents.DataSource = dt;
    }

    private void SaveDrinkToHistoryJson(IDrink drink)
    {
        var history = _jsonHelper.ReadFromFile<List<OrderHistoryItem>>(AppPaths.History);

        history.Add(new OrderHistoryItem
        {
            Drink = drink,
            OrderDate = DateTime.Now.ToString("dd.MM.yyyy HH:mm")
        });

        _jsonHelper.WriteToFile(AppPaths.History, history);
    }

    private void SaveResources()
    {
        _jsonHelper.WriteToFile(AppPaths.Resources, _vendingMachine.Contents);
    }

    private void UI_FormClosing(object? sender, FormClosingEventArgs e)
    {
        SaveResources();
    }
}
