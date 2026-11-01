
namespace HahuEvents.Desktop.Forms
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBackToLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlRegister = new Panel();
            lblAppName = new Label();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            chkShowPassword = new CheckBox();
            btnRegister = new Button();
            btnBackToLogin = new Button();
            pnlRegister.SuspendLayout();
            SuspendLayout();
            // 
            // pnlRegister
            // 
            pnlRegister.BackColor = Color.White;
            pnlRegister.Controls.Add(lblAppName);
            pnlRegister.Controls.Add(lblTitle);
            pnlRegister.Controls.Add(lblSubtitle);
            pnlRegister.Controls.Add(lblFullName);
            pnlRegister.Controls.Add(txtFullName);
            pnlRegister.Controls.Add(lblUsername);
            pnlRegister.Controls.Add(txtUsername);
            pnlRegister.Controls.Add(lblPassword);
            pnlRegister.Controls.Add(txtPassword);
            pnlRegister.Controls.Add(lblConfirmPassword);
            pnlRegister.Controls.Add(txtConfirmPassword);
            pnlRegister.Controls.Add(chkShowPassword);
            pnlRegister.Controls.Add(btnRegister);
            pnlRegister.Controls.Add(btnBackToLogin);
            pnlRegister.Location = new Point(45, 20);
            pnlRegister.Name = "pnlRegister";
            pnlRegister.Size = new Size(410, 595);
            pnlRegister.TabIndex = 0;
            // 
            // lblAppName
            // 
            lblAppName.Font = new Font("Segoe UI", 18F);
            lblAppName.ForeColor = Color.FromArgb(36, 87, 197);
            lblAppName.Location = new Point(35, 20);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(340, 40);
            lblAppName.TabIndex = 0;
            lblAppName.Text = " HahuEvents";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.Location = new Point(35, 75);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(340, 45);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Create Account";
            // 
            // lblSubtitle
            // 
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(35, 120);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(340, 28);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Register as an event organizer.";
            // 
            // lblFullName
            // 
            lblFullName.Location = new Point(35, 165);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(330, 25);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(35, 192);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(340, 25);
            txtFullName.TabIndex = 4;
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(35, 237);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(330, 25);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(35, 264);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(340, 25);
            txtUsername.TabIndex = 6;
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(35, 309);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(340, 25);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(35, 336);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(340, 25);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.Location = new Point(35, 381);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(340, 25);
            lblConfirmPassword.TabIndex = 9;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(35, 408);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(340, 25);
            txtConfirmPassword.TabIndex = 10;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // chkShowPassword
            // 
            chkShowPassword.Location = new Point(35, 449);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(200, 27);
            chkShowPassword.TabIndex = 11;
            chkShowPassword.Text = "Show password";
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.RoyalBlue;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(35, 490);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(340, 42);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Create Organizer Account";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.FlatStyle = FlatStyle.Flat;
            btnBackToLogin.Location = new Point(35, 540);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(340, 35);
            btnBackToLogin.TabIndex = 13;
            btnBackToLogin.Text = "Back to Login";
            btnBackToLogin.Click += btnBackToLogin_Click;
            // 
            // RegisterForm
            // 
            AcceptButton = btnRegister;
            BackColor = Color.White;
            ClientSize = new Size(500, 635);
            Controls.Add(pnlRegister);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HahuEvents - Organizer Registration";
            pnlRegister.ResumeLayout(false);
            pnlRegister.PerformLayout();
            ResumeLayout(false);
        }
    }
}
