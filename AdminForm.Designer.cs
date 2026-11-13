using System.Drawing;
using System.Windows.Forms;

namespace Task2;

partial class AdminForm
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
        pnlControls = new Panel();
        btnBack = new Button();
        btnReplenish = new Button();
        grpReport = new GroupBox();
        btnMonthlyTotal = new Button();
        nudYear = new NumericUpDown();
        nudMonth = new NumericUpDown();
        grpFilter = new GroupBox();
        btnResetFilter = new Button();
        btnApplyFilter = new Button();
        txtFilterCriteria = new TextBox();
        cmbFilterType = new ComboBox();
        grpSort = new GroupBox();
        btnSortDesc = new Button();
        btnSortAsc = new Button();
        cmbSortField = new ComboBox();
        lblDisplay = new Label();
        pnlScreen = new Panel();
        dgvHistory = new DataGridView();
        colOrderDate = new DataGridViewTextBoxColumn();
        colName = new DataGridViewTextBoxColumn();
        colPrice = new DataGridViewTextBoxColumn();
        colVolume = new DataGridViewTextBoxColumn();
        colType = new DataGridViewTextBoxColumn();
        lblDataGridTitle = new Label();
        pnlControls.SuspendLayout();
        grpReport.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudYear).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nudMonth).BeginInit();
        grpFilter.SuspendLayout();
        grpSort.SuspendLayout();
        pnlScreen.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
        SuspendLayout();
        // 
        // pnlControls
        // 
        pnlControls.BackColor = Color.FromArgb(45, 45, 48);
        pnlControls.BorderStyle = BorderStyle.Fixed3D;
        pnlControls.Controls.Add(btnBack);
        pnlControls.Controls.Add(btnReplenish);
        pnlControls.Controls.Add(grpReport);
        pnlControls.Controls.Add(grpFilter);
        pnlControls.Controls.Add(grpSort);
        pnlControls.Controls.Add(lblDisplay);
        pnlControls.Dock = DockStyle.Left;
        pnlControls.Location = new Point(0, 0);
        pnlControls.Name = "pnlControls";
        pnlControls.Size = new Size(319, 748);
        pnlControls.TabIndex = 0;
        // 
        // btnBack
        // 
        btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnBack.BackColor = Color.FromArgb(140, 50, 50);
        btnBack.FlatStyle = FlatStyle.Flat;
        btnBack.ForeColor = Color.White;
        btnBack.Location = new Point(17, 678);
        btnBack.Name = "btnBack";
        btnBack.Size = new Size(280, 45);
        btnBack.TabIndex = 5;
        btnBack.Text = "⬅ Back to Role Selection";
        btnBack.UseVisualStyleBackColor = false;
        btnBack.Click += BtnBack_Click;
        // 
        // btnReplenish
        // 
        btnReplenish.BackColor = Color.FromArgb(60, 120, 60);
        btnReplenish.FlatStyle = FlatStyle.Flat;
        btnReplenish.ForeColor = Color.White;
        btnReplenish.Location = new Point(17, 585);
        btnReplenish.Name = "btnReplenish";
        btnReplenish.Size = new Size(280, 45);
        btnReplenish.TabIndex = 4;
        btnReplenish.Text = "🔄 Replenish Resources";
        btnReplenish.UseVisualStyleBackColor = false;
        btnReplenish.Click += BtnReplenish_Click;
        // 
        // grpReport
        // 
        grpReport.Controls.Add(btnMonthlyTotal);
        grpReport.Controls.Add(nudYear);
        grpReport.Controls.Add(nudMonth);
        grpReport.ForeColor = Color.White;
        grpReport.Location = new Point(17, 455);
        grpReport.Name = "grpReport";
        grpReport.Size = new Size(280, 120);
        grpReport.TabIndex = 3;
        grpReport.TabStop = false;
        grpReport.Text = " Monthly Total (Month / Year) ";
        // 
        // btnMonthlyTotal
        // 
        btnMonthlyTotal.BackColor = Color.FromArgb(140, 90, 40);
        btnMonthlyTotal.FlatStyle = FlatStyle.Flat;
        btnMonthlyTotal.ForeColor = Color.White;
        btnMonthlyTotal.Location = new Point(15, 70);
        btnMonthlyTotal.Name = "btnMonthlyTotal";
        btnMonthlyTotal.Size = new Size(250, 34);
        btnMonthlyTotal.TabIndex = 2;
        btnMonthlyTotal.Text = "📊 Calculate Monthly Total";
        btnMonthlyTotal.UseVisualStyleBackColor = false;
        btnMonthlyTotal.Click += BtnMonthlyTotal_Click;
        // 
        // nudYear
        // 
        nudYear.BackColor = Color.White;
        nudYear.ForeColor = Color.Black;
        nudYear.Location = new Point(150, 30);
        nudYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
        nudYear.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
        nudYear.Name = "nudYear";
        nudYear.Size = new Size(115, 23);
        nudYear.TabIndex = 1;
        nudYear.Value = new decimal(new int[] { 2026, 0, 0, 0 });
        // 
        // nudMonth
        // 
        nudMonth.BackColor = Color.White;
        nudMonth.ForeColor = Color.Black;
        nudMonth.Location = new Point(15, 30);
        nudMonth.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
        nudMonth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudMonth.Name = "nudMonth";
        nudMonth.Size = new Size(115, 23);
        nudMonth.TabIndex = 0;
        nudMonth.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // grpFilter
        // 
        grpFilter.Controls.Add(btnResetFilter);
        grpFilter.Controls.Add(btnApplyFilter);
        grpFilter.Controls.Add(txtFilterCriteria);
        grpFilter.Controls.Add(cmbFilterType);
        grpFilter.ForeColor = Color.White;
        grpFilter.Location = new Point(17, 255);
        grpFilter.Name = "grpFilter";
        grpFilter.Size = new Size(280, 190);
        grpFilter.TabIndex = 2;
        grpFilter.TabStop = false;
        grpFilter.Text = " Filter History ";
        // 
        // btnResetFilter
        // 
        btnResetFilter.BackColor = Color.FromArgb(80, 80, 85);
        btnResetFilter.FlatStyle = FlatStyle.Flat;
        btnResetFilter.ForeColor = Color.White;
        btnResetFilter.Location = new Point(15, 140);
        btnResetFilter.Name = "btnResetFilter";
        btnResetFilter.Size = new Size(250, 34);
        btnResetFilter.TabIndex = 3;
        btnResetFilter.Text = "✖ Show All Records";
        btnResetFilter.UseVisualStyleBackColor = false;
        btnResetFilter.Click += BtnResetFilter_Click;
        // 
        // btnApplyFilter
        // 
        btnApplyFilter.BackColor = Color.FromArgb(40, 110, 110);
        btnApplyFilter.FlatStyle = FlatStyle.Flat;
        btnApplyFilter.ForeColor = Color.White;
        btnApplyFilter.Location = new Point(15, 100);
        btnApplyFilter.Name = "btnApplyFilter";
        btnApplyFilter.Size = new Size(250, 34);
        btnApplyFilter.TabIndex = 2;
        btnApplyFilter.Text = "🔍 Apply Filter";
        btnApplyFilter.UseVisualStyleBackColor = false;
        btnApplyFilter.Click += BtnApplyFilter_Click;
        // 
        // txtFilterCriteria
        // 
        txtFilterCriteria.BackColor = Color.White;
        txtFilterCriteria.ForeColor = Color.Black;
        txtFilterCriteria.Location = new Point(15, 65);
        txtFilterCriteria.Name = "txtFilterCriteria";
        txtFilterCriteria.PlaceholderText = "Coffee / Tea / Water or drink name";
        txtFilterCriteria.Size = new Size(250, 23);
        txtFilterCriteria.TabIndex = 1;
        // 
        // cmbFilterType
        // 
        cmbFilterType.BackColor = Color.White;
        cmbFilterType.DisplayMember = "Name";
        cmbFilterType.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbFilterType.ForeColor = Color.Black;
        cmbFilterType.FormattingEnabled = true;
        cmbFilterType.Location = new Point(15, 30);
        cmbFilterType.Name = "cmbFilterType";
        cmbFilterType.Size = new Size(250, 23);
        cmbFilterType.TabIndex = 0;
        // 
        // grpSort
        // 
        grpSort.Controls.Add(btnSortDesc);
        grpSort.Controls.Add(btnSortAsc);
        grpSort.Controls.Add(cmbSortField);
        grpSort.ForeColor = Color.White;
        grpSort.Location = new Point(17, 95);
        grpSort.Name = "grpSort";
        grpSort.Size = new Size(280, 150);
        grpSort.TabIndex = 1;
        grpSort.TabStop = false;
        grpSort.Text = " Sort History ";
        // 
        // btnSortDesc
        // 
        btnSortDesc.BackColor = Color.FromArgb(90, 50, 140);
        btnSortDesc.FlatStyle = FlatStyle.Flat;
        btnSortDesc.ForeColor = Color.White;
        btnSortDesc.Location = new Point(15, 105);
        btnSortDesc.Name = "btnSortDesc";
        btnSortDesc.Size = new Size(250, 34);
        btnSortDesc.TabIndex = 2;
        btnSortDesc.Text = "📑 Sort Descending ▼";
        btnSortDesc.UseVisualStyleBackColor = false;
        btnSortDesc.Click += BtnSortDesc_Click;
        // 
        // btnSortAsc
        // 
        btnSortAsc.BackColor = Color.FromArgb(90, 50, 140);
        btnSortAsc.FlatStyle = FlatStyle.Flat;
        btnSortAsc.ForeColor = Color.White;
        btnSortAsc.Location = new Point(15, 65);
        btnSortAsc.Name = "btnSortAsc";
        btnSortAsc.Size = new Size(250, 34);
        btnSortAsc.TabIndex = 1;
        btnSortAsc.Text = "📑 Sort Ascending ▲";
        btnSortAsc.UseVisualStyleBackColor = false;
        btnSortAsc.Click += BtnSortAsc_Click;
        // 
        // cmbSortField
        // 
        cmbSortField.BackColor = Color.White;
        cmbSortField.DisplayMember = "Name";
        cmbSortField.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbSortField.ForeColor = Color.Black;
        cmbSortField.FormattingEnabled = true;
        cmbSortField.Location = new Point(15, 30);
        cmbSortField.Name = "cmbSortField";
        cmbSortField.Size = new Size(250, 23);
        cmbSortField.TabIndex = 0;
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
        lblDisplay.Text = "ADMIN PANEL";
        lblDisplay.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pnlScreen
        // 
        pnlScreen.Controls.Add(dgvHistory);
        pnlScreen.Controls.Add(lblDataGridTitle);
        pnlScreen.Dock = DockStyle.Fill;
        pnlScreen.Location = new Point(319, 0);
        pnlScreen.Name = "pnlScreen";
        pnlScreen.Padding = new Padding(17, 20, 17, 20);
        pnlScreen.Size = new Size(577, 748);
        pnlScreen.TabIndex = 1;
        // 
        // dgvHistory
        // 
        dgvHistory.AllowUserToAddRows = false;
        dgvHistory.AllowUserToDeleteRows = false;
        dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvHistory.BackgroundColor = Color.White;
        dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvHistory.Columns.AddRange(new DataGridViewColumn[] { colOrderDate, colName, colPrice, colVolume, colType });
        dgvHistory.Dock = DockStyle.Fill;
        dgvHistory.Location = new Point(17, 60);
        dgvHistory.MultiSelect = false;
        dgvHistory.Name = "dgvHistory";
        dgvHistory.ReadOnly = true;
        dgvHistory.RowHeadersVisible = false;
        dgvHistory.RowHeadersWidth = 51;
        dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvHistory.Size = new Size(543, 668);
        dgvHistory.TabIndex = 1;
        // 
        // colOrderDate
        // 
        colOrderDate.HeaderText = "Order Date";
        colOrderDate.MinimumWidth = 6;
        colOrderDate.Name = "colOrderDate";
        colOrderDate.ReadOnly = true;
        colOrderDate.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // colName
        // 
        colName.HeaderText = "Name";
        colName.MinimumWidth = 6;
        colName.Name = "colName";
        colName.ReadOnly = true;
        colName.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // colPrice
        // 
        colPrice.HeaderText = "Price";
        colPrice.MinimumWidth = 6;
        colPrice.Name = "colPrice";
        colPrice.ReadOnly = true;
        colPrice.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // colVolume
        // 
        colVolume.HeaderText = "Volume";
        colVolume.MinimumWidth = 6;
        colVolume.Name = "colVolume";
        colVolume.ReadOnly = true;
        colVolume.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // colType
        // 
        colType.HeaderText = "Type";
        colType.MinimumWidth = 6;
        colType.Name = "colType";
        colType.ReadOnly = true;
        colType.SortMode = DataGridViewColumnSortMode.NotSortable;
        // 
        // lblDataGridTitle
        // 
        lblDataGridTitle.Dock = DockStyle.Top;
        lblDataGridTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        lblDataGridTitle.Location = new Point(17, 20);
        lblDataGridTitle.Name = "lblDataGridTitle";
        lblDataGridTitle.Size = new Size(543, 40);
        lblDataGridTitle.TabIndex = 0;
        lblDataGridTitle.Text = "Sales History:";
        // 
        // AdminForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(896, 748);
        Controls.Add(pnlScreen);
        Controls.Add(pnlControls);
        MinimumSize = new Size(912, 784);
        Name = "AdminForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Vending Machine - Administrator Panel";
        WindowState = FormWindowState.Maximized;
        Load += AdminForm_Load;
        pnlControls.ResumeLayout(false);
        grpReport.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)nudYear).EndInit();
        ((System.ComponentModel.ISupportInitialize)nudMonth).EndInit();
        grpFilter.ResumeLayout(false);
        grpFilter.PerformLayout();
        grpSort.ResumeLayout(false);
        pnlScreen.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel pnlControls;
    private Label lblDisplay;
    private GroupBox grpSort;
    private ComboBox cmbSortField;
    private Button btnSortAsc;
    private Button btnSortDesc;
    private GroupBox grpFilter;
    private ComboBox cmbFilterType;
    private TextBox txtFilterCriteria;
    private Button btnApplyFilter;
    private Button btnResetFilter;
    private GroupBox grpReport;
    private NumericUpDown nudMonth;
    private NumericUpDown nudYear;
    private Button btnMonthlyTotal;
    private Button btnReplenish;
    private Button btnBack;
    private Panel pnlScreen;
    private Label lblDataGridTitle;
    private DataGridView dgvHistory;
    private DataGridViewTextBoxColumn colOrderDate;
    private DataGridViewTextBoxColumn colName;
    private DataGridViewTextBoxColumn colPrice;
    private DataGridViewTextBoxColumn colVolume;
    private DataGridViewTextBoxColumn colType;
}
