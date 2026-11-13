using System.Drawing;
using System.Windows.Forms;

namespace VendingMachineApp;

partial class UserForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        pnlVendingMachine = new Panel();
        btnBack = new Button();
        grpDrinks = new GroupBox();
        btnWaterSparkling = new Button();
        btnWaterStill = new Button();
        btnGreenTea = new Button();
        btnBlackTea = new Button();
        btnCappuccino = new Button();
        btnLatte = new Button();
        btnEspresso = new Button();
        lblDisplay = new Label();
        pnlScreen = new Panel();
        dgvContents = new DataGridView();
        lblDataGridTitle = new Label();
        pnlVendingMachine.SuspendLayout();
        grpDrinks.SuspendLayout();
        pnlScreen.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvContents).BeginInit();
        SuspendLayout();
        // 
        // pnlVendingMachine
        // 
        pnlVendingMachine.BackColor = Color.FromArgb(45, 45, 48);
        pnlVendingMachine.BorderStyle = BorderStyle.Fixed3D;
        pnlVendingMachine.Controls.Add(btnBack);
        pnlVendingMachine.Controls.Add(grpDrinks);
        pnlVendingMachine.Controls.Add(lblDisplay);
        pnlVendingMachine.Dock = DockStyle.Left;
        pnlVendingMachine.Location = new Point(0, 0);
        pnlVendingMachine.Margin = new Padding(3, 4, 3, 4);
        pnlVendingMachine.Name = "pnlVendingMachine";
        pnlVendingMachine.Size = new Size(319, 748);
        pnlVendingMachine.TabIndex = 0;
        // 
        // btnBack
        // 
        btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnBack.BackColor = Color.FromArgb(140, 50, 50);
        btnBack.FlatStyle = FlatStyle.Flat;
        btnBack.ForeColor = Color.White;
        btnBack.Location = new Point(17, 678);
        btnBack.Margin = new Padding(3, 4, 3, 4);
        btnBack.Name = "btnBack";
        btnBack.Size = new Size(280, 45);
        btnBack.TabIndex = 2;
        btnBack.Text = "⬅ Back to Role Selection";
        btnBack.UseVisualStyleBackColor = false;
        btnBack.Click += BtnBack_Click;
        // 
        // grpDrinks
        // 
        grpDrinks.Controls.Add(btnWaterSparkling);
        grpDrinks.Controls.Add(btnWaterStill);
        grpDrinks.Controls.Add(btnGreenTea);
        grpDrinks.Controls.Add(btnBlackTea);
        grpDrinks.Controls.Add(btnCappuccino);
        grpDrinks.Controls.Add(btnLatte);
        grpDrinks.Controls.Add(btnEspresso);
        grpDrinks.ForeColor = Color.White;
        grpDrinks.Location = new Point(17, 95);
        grpDrinks.Margin = new Padding(3, 4, 3, 4);
        grpDrinks.Name = "grpDrinks";
        grpDrinks.Padding = new Padding(3, 4, 3, 4);
        grpDrinks.Size = new Size(280, 475);
        grpDrinks.TabIndex = 1;
        grpDrinks.TabStop = false;
        grpDrinks.Text = " Select Drink ";
        // 
        // btnWaterSparkling
        // 
        btnWaterSparkling.BackColor = Color.FromArgb(30, 80, 120);
        btnWaterSparkling.FlatStyle = FlatStyle.Flat;
        btnWaterSparkling.ForeColor = Color.White;
        btnWaterSparkling.Location = new Point(17, 400);
        btnWaterSparkling.Margin = new Padding(3, 4, 3, 4);
        btnWaterSparkling.Name = "btnWaterSparkling";
        btnWaterSparkling.Size = new Size(246, 45);
        btnWaterSparkling.TabIndex = 6;
        btnWaterSparkling.Text = "\U0001f9ca Sparkling Water";
        btnWaterSparkling.UseVisualStyleBackColor = false;
        btnWaterSparkling.Click += DrinkButton_Click;
        // 
        // btnWaterStill
        // 
        btnWaterStill.BackColor = Color.FromArgb(30, 80, 120);
        btnWaterStill.FlatStyle = FlatStyle.Flat;
        btnWaterStill.ForeColor = Color.White;
        btnWaterStill.Location = new Point(17, 340);
        btnWaterStill.Margin = new Padding(3, 4, 3, 4);
        btnWaterStill.Name = "btnWaterStill";
        btnWaterStill.Size = new Size(246, 45);
        btnWaterStill.TabIndex = 5;
        btnWaterStill.Text = "💧 Still Water";
        btnWaterStill.UseVisualStyleBackColor = false;
        btnWaterStill.Click += DrinkButton_Click;
        // 
        // btnGreenTea
        // 
        btnGreenTea.BackColor = Color.FromArgb(40, 100, 40);
        btnGreenTea.FlatStyle = FlatStyle.Flat;
        btnGreenTea.ForeColor = Color.White;
        btnGreenTea.Location = new Point(17, 280);
        btnGreenTea.Margin = new Padding(3, 4, 3, 4);
        btnGreenTea.Name = "btnGreenTea";
        btnGreenTea.Size = new Size(246, 45);
        btnGreenTea.TabIndex = 4;
        btnGreenTea.Text = "🍵 Green Tea";
        btnGreenTea.UseVisualStyleBackColor = false;
        btnGreenTea.Click += DrinkButton_Click;
        // 
        // btnBlackTea
        // 
        btnBlackTea.BackColor = Color.FromArgb(120, 60, 20);
        btnBlackTea.FlatStyle = FlatStyle.Flat;
        btnBlackTea.ForeColor = Color.White;
        btnBlackTea.Location = new Point(17, 240);
        btnBlackTea.Margin = new Padding(3, 4, 3, 4);
        btnBlackTea.Name = "btnBlackTea";
        btnBlackTea.Size = new Size(246, 45);
        btnBlackTea.TabIndex = 3;
        btnBlackTea.Text = "🍵 Black Tea";
        btnBlackTea.UseVisualStyleBackColor = false;
        btnBlackTea.Click += DrinkButton_Click;
        // 
        // btnCappuccino
        // 
        btnCappuccino.BackColor = Color.FromArgb(70, 50, 40);
        btnCappuccino.FlatStyle = FlatStyle.Flat;
        btnCappuccino.ForeColor = Color.White;
        btnCappuccino.Location = new Point(17, 160);
        btnCappuccino.Margin = new Padding(3, 4, 3, 4);
        btnCappuccino.Name = "btnCappuccino";
        btnCappuccino.Size = new Size(246, 45);
        btnCappuccino.TabIndex = 2;
        btnCappuccino.Text = "☕ Cappuccino";
        btnCappuccino.UseVisualStyleBackColor = false;
        btnCappuccino.Click += DrinkButton_Click;
        // 
        // btnLatte
        // 
        btnLatte.BackColor = Color.FromArgb(70, 50, 40);
        btnLatte.FlatStyle = FlatStyle.Flat;
        btnLatte.ForeColor = Color.White;
        btnLatte.Location = new Point(17, 100);
        btnLatte.Margin = new Padding(3, 4, 3, 4);
        btnLatte.Name = "btnLatte";
        btnLatte.Size = new Size(246, 45);
        btnLatte.TabIndex = 1;
        btnLatte.Text = "☕ Latte";
        btnLatte.UseVisualStyleBackColor = false;
        btnLatte.Click += DrinkButton_Click;
        // 
        // btnEspresso
        // 
        btnEspresso.BackColor = Color.FromArgb(70, 50, 40);
        btnEspresso.FlatStyle = FlatStyle.Flat;
        btnEspresso.ForeColor = Color.White;
        btnEspresso.Location = new Point(17, 40);
        btnEspresso.Margin = new Padding(3, 4, 3, 4);
        btnEspresso.Name = "btnEspresso";
        btnEspresso.Size = new Size(246, 45);
        btnEspresso.TabIndex = 0;
        btnEspresso.Text = "☕ Espresso";
        btnEspresso.UseVisualStyleBackColor = false;
        btnEspresso.Click += DrinkButton_Click;
        // 
        // lblDisplay
        // 
        lblDisplay.BackColor = Color.Black;
        lblDisplay.BorderStyle = BorderStyle.FixedSingle;
        lblDisplay.Font = new Font("Consolas", 12F, FontStyle.Bold);
        lblDisplay.ForeColor = Color.Lime;
        lblDisplay.Location = new Point(17, 20);
        lblDisplay.Name = "lblDisplay";
        lblDisplay.Size = new Size(280, 66);
        lblDisplay.TabIndex = 0;
        lblDisplay.Text = "READY FOR ORDER";
        lblDisplay.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pnlScreen
        // 
        pnlScreen.Controls.Add(dgvContents);
        pnlScreen.Controls.Add(lblDataGridTitle);
        pnlScreen.Dock = DockStyle.Fill;
        pnlScreen.Location = new Point(319, 0);
        pnlScreen.Margin = new Padding(3, 4, 3, 4);
        pnlScreen.Name = "pnlScreen";
        pnlScreen.Padding = new Padding(17, 20, 17, 20);
        pnlScreen.Size = new Size(577, 748);
        pnlScreen.TabIndex = 1;
        // 
        // dgvContents
        // 
        dgvContents.AllowUserToAddRows = false;
        dgvContents.AllowUserToDeleteRows = false;
        dgvContents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvContents.BackgroundColor = Color.White;
        dgvContents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvContents.Dock = DockStyle.Fill;
        dgvContents.Location = new Point(17, 60);
        dgvContents.Margin = new Padding(3, 4, 3, 4);
        dgvContents.Name = "dgvContents";
        dgvContents.ReadOnly = true;
        dgvContents.RowHeadersVisible = false;
        dgvContents.RowHeadersWidth = 51;
        dgvContents.RowTemplate.Height = 25;
        dgvContents.Size = new Size(543, 668);
        dgvContents.TabIndex = 1;
        // 
        // lblDataGridTitle
        // 
        lblDataGridTitle.Dock = DockStyle.Top;
        lblDataGridTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblDataGridTitle.Location = new Point(17, 20);
        lblDataGridTitle.Name = "lblDataGridTitle";
        lblDataGridTitle.Size = new Size(543, 40);
        lblDataGridTitle.TabIndex = 0;
        lblDataGridTitle.Text = "Current Ingredient Stock Levels:";
        // 
        // UI
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(896, 748);
        Controls.Add(pnlScreen);
        Controls.Add(pnlVendingMachine);
        Margin = new Padding(3, 4, 3, 4);
        MinimumSize = new Size(912, 784);
        Name = "UI";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Vending Machine System";
        WindowState = FormWindowState.Maximized;
        FormClosing += UI_FormClosing;
        pnlVendingMachine.ResumeLayout(false);
        grpDrinks.ResumeLayout(false);
        pnlScreen.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvContents).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel pnlVendingMachine;
    private Label lblDisplay;
    private GroupBox grpDrinks;
    private Button btnEspresso;
    private Button btnLatte;
    private Button btnCappuccino;
    private Button btnBlackTea;
    private Button btnGreenTea;
    private Button btnWaterStill;
    private Button btnWaterSparkling;
    private Button btnBack;
    private Panel pnlScreen;
    private Label lblDataGridTitle;
    private DataGridView dgvContents;
}
