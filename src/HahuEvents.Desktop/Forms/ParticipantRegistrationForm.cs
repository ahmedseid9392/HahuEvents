using System.Net.Mail;
using HahuEvents.Desktop.Models;

namespace HahuEvents.Desktop.Forms
{
    public sealed class ParticipantRegistrationForm : Form
    {
        private readonly TextBox _fullNameTextBox = new();
        private readonly TextBox _emailTextBox = new();
        private readonly TextBox _phoneTextBox = new();

        public string ParticipantName => _fullNameTextBox.Text.Trim();
        public string Email => _emailTextBox.Text.Trim();
        public string Phone => _phoneTextBox.Text.Trim();

        public ParticipantRegistrationForm(Event eventItem)
        {
            Text = "Register Participant";
            ClientSize = new Size(430, 340);
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Font = new Font("Segoe UI", 10F);

            var eventLabel = new Label
            {
                Text = $"Register for: {eventItem.Title}",
                Location = new Point(24, 20),
                Size = new Size(380, 40),
                Font = new Font("Segoe UI", 12F, FontStyle.Bold)
            };

            Controls.Add(eventLabel);
            AddField("Participant name", _fullNameTextBox, 75);
            AddField("Email", _emailTextBox, 140);
            AddField("Phone (optional)", _phoneTextBox, 205);

            var registerButton = new Button
            {
                Text = "Register",
                Location = new Point(24, 275),
                Size = new Size(180, 40),
                DialogResult = DialogResult.None
            };
            registerButton.Click += RegisterButton_Click;

            var cancelButton = new Button
            {
                Text = "Cancel",
                Location = new Point(220, 275),
                Size = new Size(180, 40),
                DialogResult = DialogResult.Cancel
            };

            Controls.Add(registerButton);
            Controls.Add(cancelButton);
            AcceptButton = registerButton;
            CancelButton = cancelButton;
        }

        private void AddField(string labelText, TextBox textBox, int top)
        {
            Controls.Add(new Label
            {
                Text = labelText,
                Location = new Point(24, top),
                Size = new Size(380, 22)
            });

            textBox.Location = new Point(24, top + 24);
            textBox.Size = new Size(380, 28);
            Controls.Add(textBox);
        }

        private void RegisterButton_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ParticipantName))
            {
                MessageBox.Show(
                    this,
                    "Enter the participant's name.",
                    "Registration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                _fullNameTextBox.Focus();
                return;
            }

            

            DialogResult = DialogResult.OK;
            Close();
        }

        
    }
}
