
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
            pnlRegister = new System.Windows.Forms.Panel();
            lblAppName = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            lblSubtitle = new System.Windows.Forms.Label();
            lblFullName = new System.Windows.Forms.Label();
            lblUsername = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            lblConfirmPassword = new System.Windows.Forms.Label();
            txtFullName = new System.Windows.Forms.TextBox();
            txtUsername = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            txtConfirmPassword = new System.Windows.Forms.TextBox();
            chkShowPassword = new System.Windows.Forms.CheckBox();
            btnRegister = new System.Windows.Forms.Button();
            btnBackToLogin = new System.Windows.Forms.Button();

            SuspendLayout();

            Text = "HahuEvents - Organizer Registration";
            ClientSize = new System.Drawing.Size(500, 635);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            BackColor = System.Drawing.Color.FromArgb(245, 247, 251);
            Font = new System.Drawing.Font("Segoe UI", 10F);

            pnlRegister.Location = new System.Drawing.Point(45, 20);
            pnlRegister.Size = new System.Drawing.Size(410, 595);
            pnlRegister.BackColor = System.Drawing.Color.White;

            lblAppName.Text = " HahuEvents";
            lblAppName.Font = new System.Drawing.Font("Segoe UI", 18F);
            lblAppName.ForeColor = System.Drawing.Color.FromArgb(36, 87, 197);
            lblAppName.Location = new System.Drawing.Point(35, 20);
            lblAppName.Size = new System.Drawing.Size(340, 40);

            lblTitle.Text = "Create Account";
            lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(35, 75);
            lblTitle.Size = new System.Drawing.Size(340, 45);

            lblSubtitle.Text = "Register as an event organizer.";
            lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            lblSubtitle.Location = new System.Drawing.Point(35, 120);
            lblSubtitle.Size = new System.Drawing.Size(340, 28);

            lblFullName.Text = "Full Name";
            lblFullName.Location = new System.Drawing.Point(35, 165);
            lblFullName.Size = new System.Drawing.Size(330, 25);

            txtFullName.Location = new System.Drawing.Point(35, 192);
            txtFullName.Size = new System.Drawing.Size(340, 32);

            lblUsername.Text = "Username";
            lblUsername.Location = new System.Drawing.Point(35, 237);
            lblUsername.Size = new System.Drawing.Size(330, 25);

            txtUsername.Location = new System.Drawing.Point(35, 264);
            txtUsername.Size = new System.Drawing.Size(340, 32);

            lblPassword.Text = "Password";
            lblPassword.Location = new System.Drawing.Point(35, 309);
            lblPassword.Size = new System.Drawing.Size(340, 25);

            txtPassword.Location = new System.Drawing.Point(35, 336);
            txtPassword.Size = new System.Drawing.Size(340, 32);
            txtPassword.UseSystemPasswordChar = true;

            lblConfirmPassword.Text = "Confirm Password";
            lblConfirmPassword.Location = new System.Drawing.Point(35, 381);
            lblConfirmPassword.Size = new System.Drawing.Size(340, 25);

            txtConfirmPassword.Location =
                new System.Drawing.Point(35, 408);
            txtConfirmPassword.Size = new System.Drawing.Size(340, 32);
            txtConfirmPassword.UseSystemPasswordChar = true;

            chkShowPassword.Text = "Show password";
            chkShowPassword.Location = new System.Drawing.Point(35, 449);
            chkShowPassword.Size = new System.Drawing.Size(200, 27);
            chkShowPassword.CheckedChanged +=
                chkShowPassword_CheckedChanged;

            btnRegister.Text = "Create Organizer Account";
            btnRegister.Location = new System.Drawing.Point(35, 490);
            btnRegister.Size = new System.Drawing.Size(340, 42);
            btnRegister.BackColor =
                System.Drawing.Color.FromArgb(36, 87, 197);
            btnRegister.ForeColor = System.Drawing.Color.White;
            btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;

            btnBackToLogin.Text = "Back to Login";
            btnBackToLogin.Location = new System.Drawing.Point(35, 540);
            btnBackToLogin.Size = new System.Drawing.Size(340, 35);
            btnBackToLogin.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            btnBackToLogin.Click += btnBackToLogin_Click;

            pnlRegister.Controls.AddRange(
                new System.Windows.Forms.Control[]
                {
                    lblAppName, lblTitle, lblSubtitle,
                    lblFullName, txtFullName,
                    lblUsername, txtUsername,
                    lblPassword, txtPassword,
                    lblConfirmPassword, txtConfirmPassword,
                    chkShowPassword, btnRegister,
                    btnBackToLogin
                });

            Controls.Add(pnlRegister);
            AcceptButton = btnRegister;

            ResumeLayout(false);
        }
    }
}
