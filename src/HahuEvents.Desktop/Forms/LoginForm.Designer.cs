
namespace HahuEvents.Desktop.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnOpenRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlLogin = new Panel();
            lblAppName = new Label();
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            chkShowPassword = new CheckBox();
            btnLogin = new Button();
            btnOpenRegister = new Button();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.White;
            pnlLogin.Controls.Add(lblAppName);
            pnlLogin.Controls.Add(lblTitle);
            pnlLogin.Controls.Add(lblSubtitle);
            pnlLogin.Controls.Add(lblUsername);
            pnlLogin.Controls.Add(txtUsername);
            pnlLogin.Controls.Add(lblPassword);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(chkShowPassword);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(btnOpenRegister);
            pnlLogin.Location = new Point(45, 25);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(410, 475);
            pnlLogin.TabIndex = 0;
            // 
            // lblAppName
            // 
            lblAppName.Font = new Font("Segoe UI", 18F);
            lblAppName.ForeColor = Color.FromArgb(36, 87, 197);
            lblAppName.Location = new Point(35, 25);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(340, 40);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "HahuEvents";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.Location = new Point(35, 95);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(340, 45);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Welcome Back";
            // 
            // lblSubtitle
            // 
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(35, 140);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(340, 28);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Sign in to manage your events.";
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(35, 190);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(330, 25);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(35, 217);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(340, 25);
            txtUsername.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(35, 263);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(330, 25);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(35, 290);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(340, 25);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // chkShowPassword
            // 
            chkShowPassword.Location = new Point(35, 330);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(200, 27);
            chkShowPassword.TabIndex = 7;
            chkShowPassword.Text = "Show password";
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.RoyalBlue;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(35, 375);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(340, 42);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Sign In";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnOpenRegister
            // 
            btnOpenRegister.FlatStyle = FlatStyle.Flat;
            btnOpenRegister.Location = new Point(35, 425);
            btnOpenRegister.Name = "btnOpenRegister";
            btnOpenRegister.Size = new Size(340, 35);
            btnOpenRegister.TabIndex = 9;
            btnOpenRegister.Text = "Create Organizer Account";
            btnOpenRegister.Click += btnOpenRegister_Click;
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            BackColor = Color.White;
            ClientSize = new Size(500, 525);
            Controls.Add(pnlLogin);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HahuEvents - Login";
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }
    }
}
