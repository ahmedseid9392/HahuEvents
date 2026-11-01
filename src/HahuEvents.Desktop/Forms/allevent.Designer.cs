namespace HahuEvents.Desktop.Forms
{
    partial class allevent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMain = new Panel();
            lblFooter = new Label();
            dgvAllEvents = new DataGridView();
            colEventId = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colOrganizer = new DataGridViewTextBoxColumn();
            colEventDate = new DataGridViewTextBoxColumn();
            colLocation = new DataGridViewTextBoxColumn();
            colCapacity = new DataGridViewTextBoxColumn();
            colRegistrations = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colViewDetails = new DataGridViewButtonColumn();
            pnlFilters = new Panel();
            btnReset = new Button();
            btnSearch = new Button();
            dtpEndDate = new DateTimePicker();
            lblEndDate = new Label();
            dtpStartDate = new DateTimePicker();
            lblStartDate = new Label();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            cmbOrganizer = new ComboBox();
            lblOrganizer = new Label();
            txtSearch = new TextBox();
            lblSearch = new Label();
            lblEventCount = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllEvents).BeginInit();
            pnlFilters.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(lblFooter);
            pnlMain.Controls.Add(dgvAllEvents);
            pnlMain.Controls.Add(pnlFilters);
            pnlMain.Controls.Add(lblEventCount);
            pnlMain.Controls.Add(lblSubtitle);
            pnlMain.Controls.Add(lblTitle);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Margin = new Padding(3, 2, 3, 2);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1034, 527);
            pnlMain.TabIndex = 0;
            // 
            // lblFooter
            // 
            lblFooter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblFooter.ForeColor = Color.FromArgb(102, 112, 133);
            lblFooter.Location = new Point(16, 488);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(1003, 24);
            lblFooter.TabIndex = 5;
            lblFooter.Text = "HahuEvents | Event Registration Management System";
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvAllEvents
            // 
            dgvAllEvents.AllowUserToAddRows = false;
            dgvAllEvents.AllowUserToDeleteRows = false;
            dgvAllEvents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAllEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAllEvents.BackgroundColor = Color.White;
            dgvAllEvents.BorderStyle = BorderStyle.None;
            dgvAllEvents.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAllEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllEvents.Columns.AddRange(new DataGridViewColumn[] { colEventId, colTitle, colOrganizer, colEventDate, colLocation, colCapacity, colRegistrations, colStatus, colViewDetails });
            dgvAllEvents.GridColor = Color.FromArgb(217, 223, 234);
            dgvAllEvents.Location = new Point(16, 158);
            dgvAllEvents.Margin = new Padding(3, 2, 3, 2);
            dgvAllEvents.MultiSelect = false;
            dgvAllEvents.Name = "dgvAllEvents";
            dgvAllEvents.ReadOnly = true;
            dgvAllEvents.RowHeadersVisible = false;
            dgvAllEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllEvents.Size = new Size(1003, 315);
            dgvAllEvents.TabIndex = 4;
            dgvAllEvents.CellFormatting += dgvAllEvents_CellFormatting;
            // 
            // colEventId
            // 
            colEventId.HeaderText = "Event ID";
            colEventId.Name = "colEventId";
            colEventId.ReadOnly = true;
            // 
            // colTitle
            // 
            colTitle.HeaderText = "Title";
            colTitle.Name = "colTitle";
            colTitle.ReadOnly = true;
            // 
            // colOrganizer
            // 
            colOrganizer.HeaderText = "Organizer";
            colOrganizer.Name = "colOrganizer";
            colOrganizer.ReadOnly = true;
            // 
            // colEventDate
            // 
            colEventDate.HeaderText = "Date";
            colEventDate.Name = "colEventDate";
            colEventDate.ReadOnly = true;
            // 
            // colLocation
            // 
            colLocation.HeaderText = "Location";
            colLocation.Name = "colLocation";
            colLocation.ReadOnly = true;
            // 
            // colCapacity
            // 
            colCapacity.HeaderText = "Capacity";
            colCapacity.Name = "colCapacity";
            colCapacity.ReadOnly = true;
            // 
            // colRegistrations
            // 
            colRegistrations.HeaderText = "Registrations";
            colRegistrations.Name = "colRegistrations";
            colRegistrations.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colViewDetails
            // 
            colViewDetails.HeaderText = "View Details";
            colViewDetails.Name = "colViewDetails";
            colViewDetails.ReadOnly = true;
            colViewDetails.Text = "View Details";
            colViewDetails.UseColumnTextForButtonValue = true;
            // 
            // pnlFilters
            // 
            pnlFilters.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlFilters.BackColor = Color.FromArgb(245, 248, 250);
            pnlFilters.BorderStyle = BorderStyle.FixedSingle;
            pnlFilters.Controls.Add(btnReset);
            pnlFilters.Controls.Add(btnSearch);
            pnlFilters.Controls.Add(dtpEndDate);
            pnlFilters.Controls.Add(lblEndDate);
            pnlFilters.Controls.Add(dtpStartDate);
            pnlFilters.Controls.Add(lblStartDate);
            pnlFilters.Controls.Add(cmbStatus);
            pnlFilters.Controls.Add(lblStatus);
            pnlFilters.Controls.Add(cmbOrganizer);
            pnlFilters.Controls.Add(lblOrganizer);
            pnlFilters.Controls.Add(txtSearch);
            pnlFilters.Controls.Add(lblSearch);
            pnlFilters.Location = new Point(16, 80);
            pnlFilters.Margin = new Padding(3, 2, 3, 2);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Size = new Size(1003, 66);
            pnlFilters.TabIndex = 3;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.White;
            btnReset.FlatAppearance.BorderColor = Color.FromArgb(217, 223, 234);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.ForeColor = Color.FromArgb(23, 32, 51);
            btnReset.Location = new Point(704, 26);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(61, 22);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.RoyalBlue;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(634, 26);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(61, 22);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(529, 26);
            dtpEndDate.Margin = new Padding(3, 2, 3, 2);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.ShowCheckBox = true;
            dtpEndDate.Size = new Size(92, 23);
            dtpEndDate.TabIndex = 9;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(529, 8);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(54, 15);
            lblEndDate.TabIndex = 8;
            lblEndDate.Text = "End Date";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(429, 26);
            dtpStartDate.Margin = new Padding(3, 2, 3, 2);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.ShowCheckBox = true;
            dtpStartDate.Size = new Size(92, 23);
            dtpStartDate.TabIndex = 7;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(429, 8);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(58, 15);
            lblStartDate.TabIndex = 6;
            lblStartDate.Text = "Start Date";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "All", "Draft", "Published", "Cancelled" });
            cmbStatus.Location = new Point(319, 26);
            cmbStatus.Margin = new Padding(3, 2, 3, 2);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(97, 23);
            cmbStatus.TabIndex = 5;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(319, 8);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status";
            // 
            // cmbOrganizer
            // 
            cmbOrganizer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrganizer.FormattingEnabled = true;
            cmbOrganizer.Items.AddRange(new object[] { "All Organizers" });
            cmbOrganizer.Location = new Point(188, 26);
            cmbOrganizer.Margin = new Padding(3, 2, 3, 2);
            cmbOrganizer.Name = "cmbOrganizer";
            cmbOrganizer.Size = new Size(119, 23);
            cmbOrganizer.TabIndex = 3;
            // 
            // lblOrganizer
            // 
            lblOrganizer.AutoSize = true;
            lblOrganizer.Location = new Point(188, 8);
            lblOrganizer.Name = "lblOrganizer";
            lblOrganizer.Size = new Size(58, 15);
            lblOrganizer.TabIndex = 2;
            lblOrganizer.Text = "Organizer";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(9, 26);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search events...";
            txtSearch.Size = new Size(167, 23);
            txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(9, 8);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 15);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            // 
            // lblEventCount
            // 
            lblEventCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEventCount.AutoSize = true;
            lblEventCount.ForeColor = Color.FromArgb(102, 112, 133);
            lblEventCount.Location = new Point(901, 23);
            lblEventCount.Name = "lblEventCount";
            lblEventCount.Size = new Size(77, 15);
            lblEventCount.TabIndex = 2;
            lblEventCount.Text = "0 total events";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.FromArgb(102, 112, 133);
            lblSubtitle.Location = new Point(18, 46);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(278, 15);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "View and filter events from all registered organizers.";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(23, 32, 51);
            lblTitle.Location = new Point(16, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(114, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "All Events";
            // 
            // allevent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1034, 527);
            Controls.Add(pnlMain);
            Margin = new Padding(3, 2, 3, 2);
            Name = "allevent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "All Events";
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllEvents).EndInit();
            pnlFilters.ResumeLayout(false);
            pnlFilters.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblEventCount;
        private Panel pnlFilters;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblOrganizer;
        private ComboBox cmbOrganizer;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Label lblStartDate;
        private DateTimePicker dtpStartDate;
        private Label lblEndDate;
        private DateTimePicker dtpEndDate;
        private Button btnSearch;
        private Button btnReset;
        private DataGridView dgvAllEvents;
        private DataGridViewTextBoxColumn colEventId;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colOrganizer;
        private DataGridViewTextBoxColumn colEventDate;
        private DataGridViewTextBoxColumn colLocation;
        private DataGridViewTextBoxColumn colCapacity;
        private DataGridViewTextBoxColumn colRegistrations;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewButtonColumn colViewDetails;
        private Label lblFooter;
    }
}
