
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
        private System.Windows.Forms.Label lblFooter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlLogin = new System.Windows.Forms.Panel();
            lblAppName = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            lblSubtitle = new System.Windows.Forms.Label();
            lblUsername = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            chkShowPassword = new System.Windows.Forms.CheckBox();
            btnLogin = new System.Windows.Forms.Button();
            btnOpenRegister = new System.Windows.Forms.Button();
            lblFooter = new System.Windows.Forms.Label();

            SuspendLayout();

            Text = "HahuEvents - Login";
            ClientSize = new System.Drawing.Size(500, 580);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            BackColor = System.Drawing.Color.FromArgb(245, 247, 251);
            Font = new System.Drawing.Font("Segoe UI", 10F);

            pnlLogin.Location = new System.Drawing.Point(45, 25);
            pnlLogin.Size = new System.Drawing.Size(410, 500);
            pnlLogin.BackColor = System.Drawing.Color.White;

            lblAppName.Text = "▦  HahuEvents";
            lblAppName.Font = new System.Drawing.Font("Segoe UI", 18F);
            lblAppName.ForeColor = System.Drawing.Color.FromArgb(36, 87, 197);
            lblAppName.Location = new System.Drawing.Point(35, 25);
            lblAppName.Size = new System.Drawing.Size(340, 40);

            lblTitle.Text = "Welcome Back";
            lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(35, 95);
            lblTitle.Size = new System.Drawing.Size(340, 45);

            lblSubtitle.Text = "Sign in to manage your events.";
            lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            lblSubtitle.Location = new System.Drawing.Point(35, 140);
            lblSubtitle.Size = new System.Drawing.Size(340, 28);

            lblUsername.Text = "Username";
            lblUsername.Location = new System.Drawing.Point(35, 190);
            lblUsername.Size = new System.Drawing.Size(330, 25);

            txtUsername.Location = new System.Drawing.Point(35, 217);
            txtUsername.Size = new System.Drawing.Size(340, 32);

            lblPassword.Text = "Password";
            lblPassword.Location = new System.Drawing.Point(35, 263);
            lblPassword.Size = new System.Drawing.Size(330, 25);

            txtPassword.Location = new System.Drawing.Point(35, 290);
            txtPassword.Size = new System.Drawing.Size(340, 32);
            txtPassword.UseSystemPasswordChar = true;

            chkShowPassword.Text = "Show password";
            chkShowPassword.Location = new System.Drawing.Point(35, 330);
            chkShowPassword.Size = new System.Drawing.Size(200, 27);
            chkShowPassword.CheckedChanged +=
                chkShowPassword_CheckedChanged;

            btnLogin.Text = "Sign In";
            btnLogin.Location = new System.Drawing.Point(35, 375);
            btnLogin.Size = new System.Drawing.Size(340, 42);
            btnLogin.BackColor = System.Drawing.Color.FromArgb(36, 87, 197);
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;

            btnOpenRegister.Text = "Create Organizer Account";
            btnOpenRegister.Location = new System.Drawing.Point(35, 425);
            btnOpenRegister.Size = new System.Drawing.Size(340, 35);
            btnOpenRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOpenRegister.Click += btnOpenRegister_Click;

            lblFooter.Text = "HahuEvents | Event Registration Management";
            lblFooter.ForeColor = System.Drawing.Color.Gray;
            lblFooter.Location = new System.Drawing.Point(25, 465);
            lblFooter.Size = new System.Drawing.Size(360, 25);
            lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            pnlLogin.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                lblAppName, lblTitle, lblSubtitle, lblUsername,
                txtUsername, lblPassword, txtPassword, chkShowPassword,
                btnLogin, btnOpenRegister, lblFooter
            });

            Controls.Add(pnlLogin);
            AcceptButton = btnLogin;

            ResumeLayout(false);
        }
    }
}
