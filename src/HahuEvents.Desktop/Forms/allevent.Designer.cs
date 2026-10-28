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
            pnlSidebar = new Panel();
            btnReports = new Button();
            btnRegistrations = new Button();
            btnOrganizers = new Button();
            btnAllEvents = new Button();
            btnDashboard = new Button();
            lblAdministration = new Label();
            lblBrand = new Label();
            pnlMain = new Panel();
            lblEventCount = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlFilters = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblOrganizer = new Label();
            cmbOrganizer = new ComboBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            lblStartDate = new Label();
            dtpStartDate = new DateTimePicker();
            lblEndDate = new Label();
            dtpEndDate = new DateTimePicker();
            btnSearch = new Button();
            btnReset = new Button();
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
            lblFooter = new Label();
            pnlSidebar.SuspendLayout();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(230, 237, 245);
            pnlSidebar.Controls.Add(btnReports);
            pnlSidebar.Controls.Add(btnRegistrations);
            pnlSidebar.Controls.Add(btnOrganizers);
            pnlSidebar.Controls.Add(btnAllEvents);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblAdministration);
            pnlSidebar.Controls.Add(lblBrand);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(180, 703);
            pnlSidebar.TabIndex = 0;
            // 
            // btnReports
            // 
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Location = new Point(7, 230);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(145, 32);
            btnReports.TabIndex = 6;
            btnReports.Text = "Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnRegistrations
            // 
            btnRegistrations.FlatAppearance.BorderSize = 0;
            btnRegistrations.FlatStyle = FlatStyle.Flat;
            btnRegistrations.Location = new Point(7, 194);
            btnRegistrations.Name = "btnRegistrations";
            btnRegistrations.Size = new Size(145, 32);
            btnRegistrations.TabIndex = 5;
            btnRegistrations.Text = "Registrations";
            btnRegistrations.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistrations.UseVisualStyleBackColor = true;
            // 
            // btnOrganizers
            // 
            btnOrganizers.FlatAppearance.BorderSize = 0;
            btnOrganizers.FlatStyle = FlatStyle.Flat;
            btnOrganizers.Location = new Point(7, 158);
            btnOrganizers.Name = "btnOrganizers";
            btnOrganizers.Size = new Size(145, 32);
            btnOrganizers.TabIndex = 4;
            btnOrganizers.Text = "Organizers";
            btnOrganizers.TextAlign = ContentAlignment.MiddleLeft;
            btnOrganizers.UseVisualStyleBackColor = true;
            // 
            // btnAllEvents
            // 
            btnAllEvents.BackColor = Color.FromArgb(36, 87, 197);
            btnAllEvents.FlatAppearance.BorderSize = 0;
            btnAllEvents.FlatStyle = FlatStyle.Flat;
            btnAllEvents.ForeColor = Color.White;
            btnAllEvents.Location = new Point(7, 122);
            btnAllEvents.Name = "btnAllEvents";
            btnAllEvents.Size = new Size(145, 32);
            btnAllEvents.TabIndex = 3;
            btnAllEvents.Text = "All Events";
            btnAllEvents.TextAlign = ContentAlignment.MiddleLeft;
            btnAllEvents.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Location = new Point(7, 86);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(145, 32);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // lblAdministration
            // 
            lblAdministration.AutoSize = true;
            lblAdministration.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblAdministration.ForeColor = Color.FromArgb(102, 112, 133);
            lblAdministration.Location = new Point(12, 46);
            lblAdministration.Name = "lblAdministration";
            lblAdministration.Size = new Size(110, 15);
            lblAdministration.TabIndex = 1;
            lblAdministration.Text = "ADMINISTRATION";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBrand.ForeColor = Color.FromArgb(23, 32, 51);
            lblBrand.Location = new Point(12, 14);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(103, 23);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "HahuEvents";
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
            pnlMain.Location = new Point(180, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1002, 703);
            pnlMain.TabIndex = 1;
            // 
            // lblEventCount
            // 
            lblEventCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEventCount.AutoSize = true;
            lblEventCount.ForeColor = Color.FromArgb(102, 112, 133);
            lblEventCount.Location = new Point(890, 31);
            lblEventCount.Name = "lblEventCount";
            lblEventCount.Size = new Size(98, 20);
            lblEventCount.TabIndex = 2;
            lblEventCount.Text = "0 total events";
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
            pnlFilters.Location = new Point(18, 106);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Size = new Size(960, 88);
            pnlFilters.TabIndex = 3;
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(10, 10);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(57, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            txtSearch.Location = new Point(10, 35);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search events...";
            txtSearch.Size = new Size(190, 27);
            txtSearch.TabIndex = 1;
            lblOrganizer.AutoSize = true;
            lblOrganizer.Location = new Point(215, 10);
            lblOrganizer.Name = "lblOrganizer";
            lblOrganizer.Size = new Size(76, 20);
            lblOrganizer.TabIndex = 2;
            lblOrganizer.Text = "Organizer";
            cmbOrganizer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrganizer.FormattingEnabled = true;
            cmbOrganizer.Items.AddRange(new object[] { "All Organizers" });
            cmbOrganizer.Location = new Point(215, 35);
            cmbOrganizer.Name = "cmbOrganizer";
            cmbOrganizer.Size = new Size(135, 28);
            cmbOrganizer.TabIndex = 3;
            cmbOrganizer.SelectedIndex = 0;
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(365, 10);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status";
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "All", "Draft", "Published", "Cancelled" });
            cmbStatus.Location = new Point(365, 35);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(110, 28);
            cmbStatus.TabIndex = 5;
            cmbStatus.SelectedIndex = 0;
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(490, 10);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(75, 20);
            lblStartDate.TabIndex = 6;
            lblStartDate.Text = "Start Date";
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.ShowCheckBox = true;
            dtpStartDate.Location = new Point(490, 35);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(105, 27);
            dtpStartDate.TabIndex = 7;
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(605, 10);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(69, 20);
            lblEndDate.TabIndex = 8;
            lblEndDate.Text = "End Date";
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.ShowCheckBox = true;
            dtpEndDate.Location = new Point(605, 35);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(105, 27);
            dtpEndDate.TabIndex = 9;
            btnSearch.BackColor = Color.FromArgb(36, 87, 197);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(725, 34);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(70, 30);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            btnReset.BackColor = Color.White;
            btnReset.FlatAppearance.BorderColor = Color.FromArgb(217, 223, 234);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.ForeColor = Color.FromArgb(23, 32, 51);
            btnReset.Location = new Point(805, 34);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(70, 30);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
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
            dgvAllEvents.Location = new Point(18, 210);
            dgvAllEvents.MultiSelect = false;
            dgvAllEvents.Name = "dgvAllEvents";
            dgvAllEvents.ReadOnly = true;
            dgvAllEvents.RowHeadersVisible = false;
            dgvAllEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllEvents.Size = new Size(960, 420);
            dgvAllEvents.TabIndex = 4;
            dgvAllEvents.CellFormatting += dgvAllEvents_CellFormatting;
            colEventId.HeaderText = "Event ID";
            colEventId.Name = "colEventId";
            colTitle.HeaderText = "Title";
            colTitle.Name = "colTitle";
            colOrganizer.HeaderText = "Organizer";
            colOrganizer.Name = "colOrganizer";
            colEventDate.HeaderText = "Date";
            colEventDate.Name = "colEventDate";
            colLocation.HeaderText = "Location";
            colLocation.Name = "colLocation";
            colCapacity.HeaderText = "Capacity";
            colCapacity.Name = "colCapacity";
            colRegistrations.HeaderText = "Registrations";
            colRegistrations.Name = "colRegistrations";
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colViewDetails.HeaderText = "View Details";
            colViewDetails.Name = "colViewDetails";
            colViewDetails.Text = "View Details";
            colViewDetails.UseColumnTextForButtonValue = true;
            lblFooter.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblFooter.ForeColor = Color.FromArgb(102, 112, 133);
            lblFooter.Location = new Point(18, 650);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(960, 32);
            lblFooter.TabIndex = 5;
            lblFooter.Text = "HahuEvents | Event Registration Management System";
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.FromArgb(102, 112, 133);
            lblSubtitle.Location = new Point(20, 61);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(354, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "View and filter events from all registered organizers.";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(23, 32, 51);
            lblTitle.Location = new Point(18, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(142, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "All Events";
            // 
            // allevent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1182, 703);
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            Name = "allevent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "All Events";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Button btnDashboard;
        private Button btnAllEvents;
        private Button btnOrganizers;
        private Button btnRegistrations;
        private Button btnReports;
        private Label lblBrand;
        private Label lblAdministration;
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