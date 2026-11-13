using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VendingMachineApp.Core.Interfaces;
using VendingMachineApp.Core.Models;
using VendingMachineApp.BusinessLogic;

namespace VendingMachineApp;

public partial class RoleSelectionForm : Form
{
    private const string AdminPassword = "1234";

    private readonly VendingMachine _vendingMachine;
    private readonly JsonHelper _jsonHelper;

    public RoleSelectionForm()
    {
        InitializeComponent();

        _jsonHelper = new JsonHelper();
        _vendingMachine = new VendingMachine("Kyiv", "Khreshchatyk St.", "1")
        {
            PriceStrategy = PriceStrategies.FridayDiscountPrice
        };

        LoadResources();
    }

    private void BtnClient_Click(object? sender, EventArgs e)
    {
        HidePasswordPanel();
        OpenForm(new UserForm(_vendingMachine, _jsonHelper));
    }

    private void BtnAdmin_Click(object? sender, EventArgs e)
    {
        lblPasswordError.Text = string.Empty;
        txtPassword.Clear();
        pnlPassword.Visible = true;
        txtPassword.Focus();
    }

    private void BtnLogin_Click(object? sender, EventArgs e)
    {
        if (txtPassword.Text != AdminPassword)
        {
            lblPasswordError.Text = "Incorrect password. Try again.";
            txtPassword.Clear();
            txtPassword.Focus();
            return;
        }

        HidePasswordPanel();
        OpenForm(new AdminForm(_vendingMachine, _jsonHelper));
    }

    private void BtnCancelLogin_Click(object? sender, EventArgs e)
    {
        HidePasswordPanel();
    }

    private void HidePasswordPanel()
    {
        txtPassword.Clear();
        lblPasswordError.Text = string.Empty;
        pnlPassword.Visible = false;
    }

    private void OpenForm(Form form)
    {
        Hide();

        using (form)
        {
            form.ShowDialog();
        }

        Show();
    }

    private void LoadResources()
    {
        try
        {
            var saved = _jsonHelper.ReadFromFile<Dictionary<string, int>>(AppPaths.Resources);

            foreach (KeyValuePair<string, int> item in saved)
            {
                _vendingMachine.Contents[item.Key] = item.Value;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
