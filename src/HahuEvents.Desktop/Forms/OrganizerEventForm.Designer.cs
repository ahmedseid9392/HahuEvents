
using static System.Net.Mime.MediaTypeNames;

namespace HahuEvents.Desktop.Forms
{
    partial class OrganizerEventForm
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
            pnlForm = new Panel();
            lblFormTitle = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            txtEventTitle = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblDate = new Label();
            dtpEventDate = new DateTimePicker();
            lblLocation = new Label();
            txtLocation = new TextBox();
            lblCapacity = new Label();
            nudCapacity = new NumericUpDown();
            lblStatus = new Label();
            cmbEventStatus = new ComboBox();
            btnSaveEvent = new Button();
            btnClear = new Button();
            btnCancel = new Button();
            pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCapacity).BeginInit();
            SuspendLayout();
            // 
            // pnlForm
            // 
            pnlForm.BackColor = Color.White;
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
            pnlForm.Location = new Point(35, 25);
            pnlForm.Name = "pnlForm";
            pnlForm.Size = new Size(565, 530);
            pnlForm.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 19F, FontStyle.Bold);
            lblFormTitle.ForeColor = Color.FromArgb(23, 32, 51);
            lblFormTitle.Location = new Point(25, 18);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(500, 38);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Create New Event";
            // 
            // lblSubtitle
            // 
            lblSubtitle.ForeColor = Color.FromArgb(102, 112, 133);
            lblSubtitle.Location = new Point(28, 58);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(480, 25);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Enter your event details below.";
            // 
            // lblTitle
            // 
            lblTitle.Location = new Point(28, 100);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 22);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Event Title";
            // 
            // txtEventTitle
            // 
            txtEventTitle.Location = new Point(28, 124);
            txtEventTitle.Name = "txtEventTitle";
            txtEventTitle.Size = new Size(500, 23);
            txtEventTitle.TabIndex = 3;
            // 
            // lblDescription
            // 
            lblDescription.Location = new Point(28, 160);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(200, 22);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(28, 184);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(500, 65);
            txtDescription.TabIndex = 5;
            // 
            // lblDate
            // 
            lblDate.Location = new Point(28, 260);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(200, 22);
            lblDate.TabIndex = 6;
            lblDate.Text = "Event Date and Time";
            // 
            // dtpEventDate
            // 
            dtpEventDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpEventDate.Format = DateTimePickerFormat.Custom;
            dtpEventDate.Location = new Point(28, 284);
            dtpEventDate.Name = "dtpEventDate";
            dtpEventDate.ShowUpDown = true;
            dtpEventDate.Size = new Size(500, 23);
            dtpEventDate.TabIndex = 7;
            // 
            // lblLocation
            // 
            lblLocation.Location = new Point(28, 320);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(200, 22);
            lblLocation.TabIndex = 8;
            lblLocation.Text = "Location";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(28, 344);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(500, 23);
            txtLocation.TabIndex = 9;
            // 
            // lblCapacity
            // 
            lblCapacity.Location = new Point(28, 380);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(200, 22);
            lblCapacity.TabIndex = 10;
            lblCapacity.Text = "Capacity";
            // 
            // nudCapacity
            // 
            nudCapacity.Location = new Point(28, 404);
            nudCapacity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudCapacity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCapacity.Name = "nudCapacity";
            nudCapacity.Size = new Size(235, 23);
            nudCapacity.TabIndex = 11;
            nudCapacity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblStatus
            // 
            lblStatus.Location = new Point(290, 380);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(200, 22);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Status";
            // 
            // cmbEventStatus
            // 
            cmbEventStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEventStatus.Location = new Point(290, 404);
            cmbEventStatus.Name = "cmbEventStatus";
            cmbEventStatus.Size = new Size(238, 23);
            cmbEventStatus.TabIndex = 13;
            // 
            // btnSaveEvent
            // 
            btnSaveEvent.BackColor = Color.RoyalBlue;
            btnSaveEvent.FlatStyle = FlatStyle.Flat;
            btnSaveEvent.ForeColor = Color.White;
            btnSaveEvent.Location = new Point(28, 465);
            btnSaveEvent.Name = "btnSaveEvent";
            btnSaveEvent.Size = new Size(155, 40);
            btnSaveEvent.TabIndex = 14;
            btnSaveEvent.Text = "Save Event";
            btnSaveEvent.UseVisualStyleBackColor = false;
            btnSaveEvent.Click += btnSaveEvent_Click;
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(200, 465);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 40);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(388, 465);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 40);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // OrganizerEventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            ClientSize = new Size(634, 581);
            Controls.Add(pnlForm);
            Font = new System.Drawing.Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MaximumSize = new Size(650, 620);
            MinimizeBox = false;
            MinimumSize = new Size(650, 620);
            Name = "OrganizerEventForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Create Event";
            pnlForm.ResumeLayout(false);
            pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCapacity).EndInit();
            ResumeLayout(false);
        }
    }
}
