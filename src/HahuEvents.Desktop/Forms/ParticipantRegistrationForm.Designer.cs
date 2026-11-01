namespace HahuEvents.Desktop.Forms
{
    partial class ParticipantRegistrationForm
    {
        private Label lblEventTitle = null!;
        private Label lblFullName = null!;
        private Label lblEmail = null!;
        private Label lblPhone = null!;
        private TextBox txtFullName = null!;
        private TextBox txtEmail = null!;
        private TextBox txtPhone = null!;
        private Button btnRegister = null!;
        private Button btnCancel = null!;

        private void InitializeComponent()
        {
            lblEventTitle = new Label();
            lblFullName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            btnRegister = new Button();
            btnCancel = new Button();
            SuspendLayout();

            lblEventTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEventTitle.Location = new Point(24, 20);
            lblEventTitle.Size = new Size(380, 40);
            lblEventTitle.Text = "Register for event";

            lblFullName.Location = new Point(24, 75);
            lblFullName.Size = new Size(380, 22);
            lblFullName.Text = "Participant name";
            txtFullName.Location = new Point(24, 99);
            txtFullName.Size = new Size(380, 28);

            lblEmail.Location = new Point(24, 140);
            lblEmail.Size = new Size(380, 22);
            lblEmail.Text = "Email";
            txtEmail.Location = new Point(24, 164);
            txtEmail.Size = new Size(380, 28);

            lblPhone.Location = new Point(24, 205);
            lblPhone.Size = new Size(380, 22);
            lblPhone.Text = "Phone (optional)";
            txtPhone.Location = new Point(24, 229);
            txtPhone.Size = new Size(380, 28);

            btnRegister.Location = new Point(24, 275);
            btnRegister.Size = new Size(180, 40);
            btnRegister.Text = "Register";
            btnRegister.Click += RegisterButton_Click;

            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(220, 275);
            btnCancel.Size = new Size(180, 40);
            btnCancel.Text = "Cancel";

            AcceptButton = btnRegister;
            CancelButton = btnCancel;
            ClientSize = new Size(430, 340);
            Controls.AddRange(new Control[]
            {
                lblEventTitle,
                lblFullName,
                txtFullName,
                lblEmail,
                txtEmail,
                lblPhone,
                txtPhone,
                btnRegister,
                btnCancel
            });
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Register Participant";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
