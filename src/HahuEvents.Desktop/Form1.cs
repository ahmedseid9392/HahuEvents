using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HahuEvents.Desktop
{
    public partial class Form1 : Form
    {
        private const string UsernamePlaceholder = "Enter your username";
        private const string PasswordPlaceholder = "Enter your password";

        private readonly Color placeholderColor = Color.FromArgb(133, 139, 150);
        private readonly Color activeTextColor = Color.FromArgb(23, 28, 39);

        private bool isPasswordPlaceholderActive = true;

        public Form1()
        {
            InitializeComponent();
            ApplyRoundedCorners();
        }

        private void ApplyRoundedCorners()
        {
            // Applies rounded corners to standard controls without custom Paint overrides
            SetCurvedRegion(pnlMainCard, 20);
            SetCurvedRegion(pnlBrandIcon, 13);
            SetCurvedRegion(pnlEventCard, 13);
            SetCurvedRegion(pnlDateBox, 10);
            SetCurvedRegion(pnlCardLine1, 6);
            SetCurvedRegion(pnlCardLine2, 6);
            SetCurvedRegion(pnlCardLine3, 6);
            SetCurvedRegion(pnlUsernameBorder, 10);
            SetCurvedRegion(pnlPasswordBorder, 10);
            SetCurvedRegion(btnSignIn, 11);
        }

        private static void SetCurvedRegion(Control control, int radius)
        {
            if (control == null) return;

            using (GraphicsPath path = new GraphicsPath())
            {
                int diameter = radius * 2;
                Rectangle bounds = control.ClientRectangle;

                path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
                path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
                path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
                path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();

                control.Region = new Region(path);
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == UsernamePlaceholder)
            {
                txtUsername.Text = string.Empty;
                txtUsername.ForeColor = activeTextColor;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = UsernamePlaceholder;
                txtUsername.ForeColor = placeholderColor;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (isPasswordPlaceholderActive)
            {
                txtPassword.Text = string.Empty;
                txtPassword.ForeColor = activeTextColor;
                isPasswordPlaceholderActive = false;
                txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                isPasswordPlaceholderActive = true;
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = PasswordPlaceholder;
                txtPassword.ForeColor = placeholderColor;
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (!isPasswordPlaceholderActive)
            {
                txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtUsername.Text.Trim();
            string enteredPassword = txtPassword.Text;

            bool isUsernameEmpty = string.IsNullOrWhiteSpace(enteredUsername) || enteredUsername == UsernamePlaceholder;
            bool isPasswordEmpty = string.IsNullOrWhiteSpace(enteredPassword) || isPasswordPlaceholderActive;

            if (isUsernameEmpty && isPasswordEmpty)
            {
                MessageBox.Show(
                    "Please enter both your username and password.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtUsername.Focus();
                return;
            }

            if (isUsernameEmpty)
            {
                MessageBox.Show(
                    "Please enter your username.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtUsername.Focus();
                return;
            }

            if (isPasswordEmpty)
            {
                MessageBox.Show(
                    "Please enter your password.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtPassword.Focus();
                return;
            }

            MessageBox.Show(
                $"Sign in attempted for '{enteredUsername}'.",
                "Sign In",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void pnlLeft_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}