using System.Net.Mail;
using HahuEvents.Desktop.Models;

namespace HahuEvents.Desktop.Forms
{
    public sealed partial class ParticipantRegistrationForm : Form
    {
        public string ParticipantName => txtFullName.Text.Trim();
        public string Email => txtEmail.Text.Trim();
        public string Phone => txtPhone.Text.Trim();

        public ParticipantRegistrationForm(Event eventItem)
        {
            ArgumentNullException.ThrowIfNull(eventItem);

            InitializeComponent();
            lblEventTitle.Text = $"Register for: {eventItem.Title}";
        }

        private void RegisterButton_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ParticipantName))
            {
                ShowValidationMessage("Enter the participant's name.", txtFullName);
                return;
            }

            if (string.IsNullOrWhiteSpace(Email))
            {
                ShowValidationMessage("Enter the participant's email.", txtEmail);
                return;
            }

            try
            {
                _ = new MailAddress(Email);
            }
            catch (FormatException)
            {
                ShowValidationMessage("Enter a valid email address.", txtEmail);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void ShowValidationMessage(string message, Control control)
        {
            MessageBox.Show(
                this,
                message,
                "Registration",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            control.Focus();
        }
    }
}
