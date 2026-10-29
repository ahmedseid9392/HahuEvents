
using static System.Net.Mime.MediaTypeNames;

namespace HahuEvents.Desktop.Forms
{
    partial class EventForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblStatus;

        private System.Windows.Forms.TextBox txtEventTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.NumericUpDown nudCapacity;
        private System.Windows.Forms.ComboBox cmbEventStatus;

        private System.Windows.Forms.Button btnSaveEvent;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlForm = new System.Windows.Forms.Panel();
            lblFormTitle = new System.Windows.Forms.Label();
            lblSubtitle = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            lblDescription = new System.Windows.Forms.Label();
            lblDate = new System.Windows.Forms.Label();
            lblLocation = new System.Windows.Forms.Label();
            lblCapacity = new System.Windows.Forms.Label();
            lblStatus = new System.Windows.Forms.Label();

            txtEventTitle = new System.Windows.Forms.TextBox();
            txtDescription = new System.Windows.Forms.TextBox();
            txtLocation = new System.Windows.Forms.TextBox();
            dtpEventDate = new System.Windows.Forms.DateTimePicker();
            nudCapacity = new System.Windows.Forms.NumericUpDown();
            cmbEventStatus = new System.Windows.Forms.ComboBox();

            btnSaveEvent = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();

            SuspendLayout();

            // Form
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(650, 620);
            MinimumSize = new System.Drawing.Size(650, 620);
            MaximumSize = new System.Drawing.Size(650, 620);
            StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;
            FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            BackColor = System.Drawing.Color.FromArgb(245, 247, 251);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            Text = "Create Event";

            // Main white panel
            pnlForm.Location = new System.Drawing.Point(35, 25);
            pnlForm.Size = new System.Drawing.Size(565, 530);
            pnlForm.BackColor = System.Drawing.Color.White;
            pnlForm.Controls.Add(lblFormTitle);
            pnlForm.Controls.Add(lblSubtitle);
            pnlForm.Controls.Add(lblTitle);
            pnlForm.Controls.Add(txtEventTitle);
            pnlForm.Controls.Add(lblDescription);
            pnlForm.Controls.Add(txtDescription);
            pnlForm.Controls.Add(lblDate);
            pnlForm.Controls.Add(dtpEventDate);
            pnlForm.Controls.Add(lblLocation);
            pnlForm.Controls.Add(txtLocation);
            pnlForm.Controls.Add(lblCapacity);
            pnlForm.Controls.Add(nudCapacity);
            pnlForm.Controls.Add(lblStatus);
            pnlForm.Controls.Add(cmbEventStatus);
            pnlForm.Controls.Add(btnSaveEvent);
            pnlForm.Controls.Add(btnClear);
            pnlForm.Controls.Add(btnCancel);

            // Heading
            lblFormTitle.Text = "Create New Event";
            lblFormTitle.Font = new System.Drawing.Font(
                "Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            lblFormTitle.ForeColor =
                System.Drawing.Color.FromArgb(23, 32, 51);
            lblFormTitle.Location = new System.Drawing.Point(25, 18);
            lblFormTitle.Size = new System.Drawing.Size(500, 38);

            lblSubtitle.Text = "Enter your event details below.";
            lblSubtitle.ForeColor =
                System.Drawing.Color.FromArgb(102, 112, 133);
            lblSubtitle.Location = new System.Drawing.Point(28, 58);
            lblSubtitle.Size = new System.Drawing.Size(480, 25);

            // Event title
            lblTitle.Text = "Event Title";
            lblTitle.Location = new System.Drawing.Point(28, 100);
            lblTitle.Size = new System.Drawing.Size(200, 22);

            txtEventTitle.Location = new System.Drawing.Point(28, 124);
            txtEventTitle.Size = new System.Drawing.Size(500, 27);

            // Description
            lblDescription.Text = "Description";
            lblDescription.Location = new System.Drawing.Point(28, 160);
            lblDescription.Size = new System.Drawing.Size(200, 22);

            txtDescription.Location = new System.Drawing.Point(28, 184);
            txtDescription.Size = new System.Drawing.Size(500, 65);
            txtDescription.Multiline = true;
            txtDescription.ScrollBars =
                System.Windows.Forms.ScrollBars.Vertical;

            // Date and time
            lblDate.Text = "Event Date and Time";
            lblDate.Location = new System.Drawing.Point(28, 260);
            lblDate.Size = new System.Drawing.Size(200, 22);

            dtpEventDate.Location = new System.Drawing.Point(28, 284);
            dtpEventDate.Size = new System.Drawing.Size(500, 27);
            dtpEventDate.Format =
                System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpEventDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpEventDate.ShowUpDown = true;

            // Location
            lblLocation.Text = "Location";
            lblLocation.Location = new System.Drawing.Point(28, 320);
            lblLocation.Size = new System.Drawing.Size(200, 22);

            txtLocation.Location = new System.Drawing.Point(28, 344);
            txtLocation.Size = new System.Drawing.Size(500, 27);

            // Capacity
            lblCapacity.Text = "Capacity";
            lblCapacity.Location = new System.Drawing.Point(28, 380);
            lblCapacity.Size = new System.Drawing.Size(200, 22);

            nudCapacity.Location = new System.Drawing.Point(28, 404);
            nudCapacity.Size = new System.Drawing.Size(235, 27);
            nudCapacity.Minimum = 1;
            nudCapacity.Maximum = 100000;
            nudCapacity.Value = 1;

            // Status
            lblStatus.Text = "Status";
            lblStatus.Location = new System.Drawing.Point(290, 380);
            lblStatus.Size = new System.Drawing.Size(200, 22);

            cmbEventStatus.Location = new System.Drawing.Point(290, 404);
            cmbEventStatus.Size = new System.Drawing.Size(238, 27);
            cmbEventStatus.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Buttons
            btnSaveEvent.Text = "Save Event";
            btnSaveEvent.Location = new System.Drawing.Point(28, 465);
            btnSaveEvent.Size = new System.Drawing.Size(155, 40);
            btnSaveEvent.BackColor =
                System.Drawing.Color.FromArgb(36, 87, 197);
            btnSaveEvent.ForeColor = System.Drawing.Color.White;
            btnSaveEvent.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            btnSaveEvent.UseVisualStyleBackColor = false;
            btnSaveEvent.Click += btnSaveEvent_Click;

            btnClear.Text = "Clear";
            btnClear.Location = new System.Drawing.Point(200, 465);
            btnClear.Size = new System.Drawing.Size(140, 40);
            btnClear.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            btnClear.Click += btnClear_Click;

            btnCancel.Text = "Cancel";
            btnCancel.Location = new System.Drawing.Point(388, 465);
            btnCancel.Size = new System.Drawing.Size(140, 40);
            btnCancel.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Click += btnCancel_Click;

            Controls.Add(pnlForm);

            ResumeLayout(false);
        }
    }
}
