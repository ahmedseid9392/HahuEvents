
using System;
using System.Windows.Forms;
using HahuEvents.Desktop.Services;

namespace HahuEvents.Desktop.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void chkShowPassword_CheckedChanged(
            object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar =
                !chkShowPassword.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Enter your username and password.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!AuthService.Login(
                username, password, out string message))
            {
                MessageBox.Show(
                    message, "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            Hide();

            try
            {
                if (AuthService.CurrentUser.Role ==
                    HahuEvents.Desktop.Models.UserRole.Administrator)
                {
                    using var dashboard =
                        new AdminDashboardForm();

                    dashboard.ShowDialog();
                }
                else
                {
                    using var dashboard =
                        new OrganizerDashboardForm();

                    dashboard.CurrentOrganizerId =
                        AuthService.CurrentUser.Id;

                    dashboard.ShowDialog();
                }
            }
            finally
            {
                AuthService.Logout();
                txtPassword.Clear();
                Show();
            }
        }

        private void btnOpenRegister_Click(
            object sender, EventArgs e)
        {
            using var registerForm = new RegisterForm();

            Hide();
            registerForm.ShowDialog();
            Show();
        }
    }
}
