using System.Drawing;
using System.Windows.Forms;

namespace Task2;

partial class RoleSelectionForm
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
        lblTitle = new Label();
        lblSubtitle = new Label();
        btnClient = new Button();
        btnAdmin = new Button();
        pnlPassword = new Panel();
        lblPassword = new Label();
        txtPassword = new TextBox();
        lblPasswordError = new Label();
        btnLogin = new Button();
        btnCancelLogin = new Button();
        pnlPassword.SuspendLayout();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(20, 20);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(400, 50);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "☕ Vending Machine";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblSubtitle
        // 
        lblSubtitle.Font = new Font("Segoe UI", 11F);
        lblSubtitle.ForeColor = Color.Silver;
        lblSubtitle.Location = new Point(20, 72);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(400, 28);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "Select your role";
        lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnClient
        // 
        btnClient.BackColor = Color.FromArgb(70, 50, 40);
        btnClient.FlatStyle = FlatStyle.Flat;
        btnClient.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnClient.ForeColor = Color.White;
        btnClient.Location = new Point(60, 115);
        btnClient.Name = "btnClient";
        btnClient.Size = new Size(320, 55);
        btnClient.TabIndex = 2;
        btnClient.Text = "☕ Client";
        btnClient.UseVisualStyleBackColor = false;
        btnClient.Click += BtnClient_Click;
        // 
        // btnAdmin
        // 
        btnAdmin.BackColor = Color.FromArgb(50, 90, 140);
        btnAdmin.FlatStyle = FlatStyle.Flat;
        btnAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        btnAdmin.ForeColor = Color.White;
        btnAdmin.Location = new Point(60, 185);
        btnAdmin.Name = "btnAdmin";
        btnAdmin.Size = new Size(320, 55);
        btnAdmin.TabIndex = 3;
        btnAdmin.Text = "🔧 Administrator";
        btnAdmin.UseVisualStyleBackColor = false;
        btnAdmin.Click += BtnAdmin_Click;
        // 
        // pnlPassword
        // 
        pnlPassword.BackColor = Color.FromArgb(60, 60, 64);
        pnlPassword.Controls.Add(lblPassword);
        pnlPassword.Controls.Add(txtPassword);
        pnlPassword.Controls.Add(lblPasswordError);
        pnlPassword.Controls.Add(btnLogin);
        pnlPassword.Controls.Add(btnCancelLogin);
        pnlPassword.Location = new Point(60, 255);
        pnlPassword.Name = "pnlPassword";
        pnlPassword.Size = new Size(320, 130);
        pnlPassword.TabIndex = 4;
        pnlPassword.Visible = false;
        // 
        // lblPassword
        // 
        lblPassword.ForeColor = Color.White;
        lblPassword.Location = new Point(10, 8);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(300, 20);
        lblPassword.TabIndex = 0;
        lblPassword.Text = "Administrator password:";
        // 
        // txtPassword
        // 
        txtPassword.BackColor = Color.White;
        txtPassword.ForeColor = Color.Black;
        txtPassword.Location = new Point(10, 30);
        txtPassword.MaxLength = 32;
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(300, 23);
        txtPassword.TabIndex = 1;
        txtPassword.UseSystemPasswordChar = true;
        // 
        // lblPasswordError
        // 
        lblPasswordError.ForeColor = Color.Tomato;
        lblPasswordError.Location = new Point(10, 58);
        lblPasswordError.Name = "lblPasswordError";
        lblPasswordError.Size = new Size(300, 18);
        lblPasswordError.TabIndex = 2;
        // 
        // btnLogin
        // 
        btnLogin.BackColor = Color.FromArgb(60, 120, 60);
        btnLogin.FlatStyle = FlatStyle.Flat;
        btnLogin.ForeColor = Color.White;
        btnLogin.Location = new Point(10, 85);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(145, 34);
        btnLogin.TabIndex = 3;
        btnLogin.Text = "Login";
        btnLogin.UseVisualStyleBackColor = false;
        btnLogin.Click += BtnLogin_Click;
        // 
        // btnCancelLogin
        // 
        btnCancelLogin.BackColor = Color.FromArgb(140, 50, 50);
        btnCancelLogin.FlatStyle = FlatStyle.Flat;
        btnCancelLogin.ForeColor = Color.White;
        btnCancelLogin.Location = new Point(165, 85);
        btnCancelLogin.Name = "btnCancelLogin";
        btnCancelLogin.Size = new Size(145, 34);
        btnCancelLogin.TabIndex = 4;
        btnCancelLogin.Text = "Cancel";
        btnCancelLogin.UseVisualStyleBackColor = false;
        btnCancelLogin.Click += BtnCancelLogin_Click;
        // 
        // RoleSelectionForm
        // 
        AcceptButton = btnLogin;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(45, 45, 48);
        ClientSize = new Size(440, 405);
        Controls.Add(pnlPassword);
        Controls.Add(btnAdmin);
        Controls.Add(btnClient);
        Controls.Add(lblSubtitle);
        Controls.Add(lblTitle);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "RoleSelectionForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Vending Machine - Select Role";
        pnlPassword.ResumeLayout(false);
        pnlPassword.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Label lblTitle;
    private Label lblSubtitle;
    private Button btnClient;
    private Button btnAdmin;
    private Panel pnlPassword;
    private Label lblPassword;
    private TextBox txtPassword;
    private Label lblPasswordError;
    private Button btnLogin;
    private Button btnCancelLogin;
}
