namespace HahuEvents.Desktop.Forms
{
    partial class AdminDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardForm));
            pnlSidebar = new Panel();
            button6 = new Button();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            pnlHeader = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pnlContent = new Panel();
            pnlALLEvents = new Panel();
            dgvAllEvents = new DataGridView();
            colEventId = new DataGridViewTextBoxColumn();
            colEventTitle = new DataGridViewTextBoxColumn();
            colOrganizer = new DataGridViewTextBoxColumn();
            colEventDate = new DataGridViewTextBoxColumn();
            colLocation = new DataGridViewTextBoxColumn();
            colCapacity = new DataGridViewTextBoxColumn();
            colRegistrations = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colViewDetails = new DataGridViewButtonColumn();
            lblFooter = new Label();
            pnlEventFilters = new Panel();
            btnReset = new Button();
            btnSearch = new Button();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            cmbStatusFilter = new ComboBox();
            cmbOrganizerFilter = new ComboBox();
            txtSearchEvent = new TextBox();
            pnlSummaryCards = new Panel();
            panel3 = new Panel();
            label11 = new Label();
            label7 = new Label();
            panel4 = new Panel();
            label12 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            label10 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label9 = new Label();
            label5 = new Label();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlALLEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllEvents).BeginInit();
            pnlEventFilters.SuspendLayout();
            pnlSummaryCards.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.White;
            pnlSidebar.Controls.Add(button6);
            pnlSidebar.Controls.Add(pictureBox1);
            pnlSidebar.Controls.Add(button5);
            pnlSidebar.Controls.Add(button4);
            pnlSidebar.Controls.Add(button3);
            pnlSidebar.Controls.Add(button2);
            pnlSidebar.Controls.Add(button1);
            pnlSidebar.Controls.Add(label1);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 703);
            pnlSidebar.TabIndex = 0;
            // 
            // button6
            // 
            button6.BackColor = Color.DodgerBlue;
            button6.Cursor = Cursors.Hand;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(12, 24);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(47, 50);
            button6.TabIndex = 10;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 24);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.FromArgb(102, 112, 133);
            button5.Location = new Point(12, 291);
            button5.Name = "button5";
            button5.Size = new Size(196, 36);
            button5.TabIndex = 5;
            button5.Text = "System Settings";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.FromArgb(102, 112, 133);
            button4.Location = new Point(12, 240);
            button4.Name = "button4";
            button4.Size = new Size(196, 36);
            button4.TabIndex = 4;
            button4.Text = "System Reports";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(102, 112, 133);
            button3.Location = new Point(12, 189);
            button3.Name = "button3";
            button3.Size = new Size(196, 36);
            button3.TabIndex = 3;
            button3.Text = "Manage Organizers";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(102, 112, 133);
            button2.Location = new Point(12, 138);
            button2.Name = "button2";
            button2.Size = new Size(196, 36);
            button2.TabIndex = 2;
            button2.Text = "All Events";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(36, 87, 197);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(12, 89);
            button1.Name = "button1";
            button1.Size = new Size(196, 36);
            button1.TabIndex = 1;
            button1.Text = "Dashboard";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(61, 36);
            label1.Name = "label1";
            label1.Size = new Size(103, 23);
            label1.TabIndex = 0;
            label1.Text = "HahuEvents";
            label1.Click += label1_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(label4);
            pnlHeader.Controls.Add(label3);
            pnlHeader.Controls.Add(label2);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(220, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(962, 80);
            pnlHeader.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(23, 32, 51);
            label4.Location = new Point(770, 9);
            label4.Name = "label4";
            label4.Size = new Size(175, 20);
            label4.TabIndex = 2;
            label4.Text = "Welcome Administrator";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(102, 112, 133);
            label3.Location = new Point(16, 42);
            label3.Name = "label3";
            label3.Size = new Size(309, 20);
            label3.TabIndex = 1;
            label3.Text = "Monitor events,organizers and system activity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(23, 32, 51);
            label2.Location = new Point(16, 11);
            label2.Name = "label2";
            label2.Size = new Size(250, 28);
            label2.TabIndex = 0;
            label2.Text = "Administrator Dashboard";
            label2.Click += label2_Click;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(245, 247, 251);
            pnlContent.Controls.Add(pnlALLEvents);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(220, 80);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(962, 623);
            pnlContent.TabIndex = 2;
            // 
            // pnlALLEvents
            // 
            pnlALLEvents.BackColor = Color.White;
            pnlALLEvents.Controls.Add(dgvAllEvents);
            pnlALLEvents.Controls.Add(lblFooter);
            pnlALLEvents.Controls.Add(pnlEventFilters);
            pnlALLEvents.Controls.Add(pnlSummaryCards);
            pnlALLEvents.Dock = DockStyle.Fill;
            pnlALLEvents.Location = new Point(0, 0);
            pnlALLEvents.Name = "pnlALLEvents";
            pnlALLEvents.Size = new Size(962, 623);
            pnlALLEvents.TabIndex = 0;
            // 
            // dgvAllEvents
            // 
            dgvAllEvents.AllowUserToAddRows = false;
            dgvAllEvents.AllowUserToDeleteRows = false;
            dgvAllEvents.AllowUserToResizeRows = false;
            dgvAllEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAllEvents.BackgroundColor = Color.White;
            dgvAllEvents.BorderStyle = BorderStyle.None;
            dgvAllEvents.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAllEvents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllEvents.Columns.AddRange(new DataGridViewColumn[] { colEventId, colEventTitle, colOrganizer, colEventDate, colLocation, colCapacity, colRegistrations, colStatus, colViewDetails });
            dgvAllEvents.Dock = DockStyle.Fill;
            dgvAllEvents.GridColor = Color.FromArgb(217, 223, 234);
            dgvAllEvents.Location = new Point(0, 178);
            dgvAllEvents.MultiSelect = false;
            dgvAllEvents.Name = "dgvAllEvents";
            dgvAllEvents.ReadOnly = true;
            dgvAllEvents.RowHeadersVisible = false;
            dgvAllEvents.RowHeadersWidth = 51;
            dgvAllEvents.RowTemplate.Height = 30;
            dgvAllEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllEvents.Size = new Size(962, 409);
            dgvAllEvents.TabIndex = 2;
            // 
            // colEventId
            // 
            colEventId.HeaderText = "Event ID";
            colEventId.MinimumWidth = 6;
            colEventId.Name = "colEventId";
            colEventId.ReadOnly = true;
            // 
            // colEventTitle
            // 
            colEventTitle.HeaderText = "Event Title";
            colEventTitle.MinimumWidth = 6;
            colEventTitle.Name = "colEventTitle";
            colEventTitle.ReadOnly = true;
            // 
            // colOrganizer
            // 
            colOrganizer.HeaderText = "Organizer";
            colOrganizer.MinimumWidth = 6;
            colOrganizer.Name = "colOrganizer";
            colOrganizer.ReadOnly = true;
            // 
            // colEventDate
            // 
            colEventDate.HeaderText = "Event Date";
            colEventDate.MinimumWidth = 6;
            colEventDate.Name = "colEventDate";
            colEventDate.ReadOnly = true;
            // 
            // colLocation
            // 
            colLocation.HeaderText = "Location";
            colLocation.MinimumWidth = 6;
            colLocation.Name = "colLocation";
            colLocation.ReadOnly = true;
            // 
            // colCapacity
            // 
            colCapacity.HeaderText = "Capacity";
            colCapacity.MinimumWidth = 6;
            colCapacity.Name = "colCapacity";
            colCapacity.ReadOnly = true;
            // 
            // colRegistrations
            // 
            colRegistrations.HeaderText = "Registrations";
            colRegistrations.MinimumWidth = 6;
            colRegistrations.Name = "colRegistrations";
            colRegistrations.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colViewDetails
            // 
            colViewDetails.HeaderText = "View Details";
            colViewDetails.MinimumWidth = 6;
            colViewDetails.Name = "colViewDetails";
            colViewDetails.ReadOnly = true;
            colViewDetails.Text = "View Details";
            colViewDetails.UseColumnTextForButtonValue = true;
            // 
            // lblFooter
            // 
            lblFooter.Dock = DockStyle.Bottom;
            lblFooter.ForeColor = Color.FromArgb(102, 112, 133);
            lblFooter.Location = new Point(0, 587);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(962, 36);
            lblFooter.TabIndex = 3;
            lblFooter.Text = "HahuEvents | Event Registration Management System";
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlEventFilters
            // 
            pnlEventFilters.Controls.Add(btnReset);
            pnlEventFilters.Controls.Add(btnSearch);
            pnlEventFilters.Controls.Add(dtpEndDate);
            pnlEventFilters.Controls.Add(dtpStartDate);
            pnlEventFilters.Controls.Add(cmbStatusFilter);
            pnlEventFilters.Controls.Add(cmbOrganizerFilter);
            pnlEventFilters.Controls.Add(txtSearchEvent);
            pnlEventFilters.Dock = DockStyle.Top;
            pnlEventFilters.Location = new Point(0, 120);
            pnlEventFilters.Name = "pnlEventFilters";
            pnlEventFilters.Padding = new Padding(16, 10, 16, 10);
            pnlEventFilters.Size = new Size(962, 58);
            pnlEventFilters.TabIndex = 1;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.White;
            btnReset.FlatAppearance.BorderColor = Color.FromArgb(217, 223, 234);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.ForeColor = Color.FromArgb(23, 32, 51);
            btnReset.Location = new Point(870, 12);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(76, 30);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(36, 87, 197);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(786, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(76, 30);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(649, 13);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(125, 27);
            dtpEndDate.TabIndex = 4;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(512, 13);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(125, 27);
            dtpStartDate.TabIndex = 3;
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusFilter.FormattingEnabled = true;
            cmbStatusFilter.Items.AddRange(new object[] { "All", "Draft", "Published", "Cancelled" });
            cmbStatusFilter.Location = new Point(370, 13);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(130, 28);
            cmbStatusFilter.TabIndex = 2;
            // 
            // cmbOrganizerFilter
            // 
            cmbOrganizerFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrganizerFilter.FormattingEnabled = true;
            cmbOrganizerFilter.Location = new Point(208, 13);
            cmbOrganizerFilter.Name = "cmbOrganizerFilter";
            cmbOrganizerFilter.Size = new Size(150, 28);
            cmbOrganizerFilter.TabIndex = 1;
            // 
            // txtSearchEvent
            // 
            txtSearchEvent.Location = new Point(16, 14);
            txtSearchEvent.Name = "txtSearchEvent";
            txtSearchEvent.PlaceholderText = "Search title or location";
            txtSearchEvent.Size = new Size(180, 27);
            txtSearchEvent.TabIndex = 0;
            // 
            // pnlSummaryCards
            // 
            pnlSummaryCards.Controls.Add(panel3);
            pnlSummaryCards.Controls.Add(panel4);
            pnlSummaryCards.Controls.Add(panel2);
            pnlSummaryCards.Controls.Add(panel1);
            pnlSummaryCards.Dock = DockStyle.Top;
            pnlSummaryCards.Location = new Point(0, 0);
            pnlSummaryCards.Name = "pnlSummaryCards";
            pnlSummaryCards.Size = new Size(962, 120);
            pnlSummaryCards.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(511, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(159, 69);
            panel3.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(45, 36);
            label11.Name = "label11";
            label11.Size = new Size(24, 28);
            label11.TabIndex = 3;
            label11.Text = "5";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 6);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 1;
            label7.Text = "Published Events";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(744, 20);
            panel4.Name = "panel4";
            panel4.Size = new Size(159, 69);
            panel4.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(41, 36);
            label12.Name = "label12";
            label12.Size = new Size(24, 28);
            label12.TabIndex = 3;
            label12.Text = "1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 6);
            label8.Name = "label8";
            label8.Size = new Size(114, 20);
            label8.TabIndex = 2;
            label8.Text = "Cancelled Event";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label6);
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(276, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(159, 69);
            panel2.TabIndex = 1;
            panel2.Click += panel2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Cursor = Cursors.Hand;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(43, 39);
            label10.Name = "label10";
            label10.Size = new Size(24, 28);
            label10.TabIndex = 3;
            label10.Text = "8";
            label10.Click += label10_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Location = new Point(20, 6);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 0;
            label6.Text = "Total event";
            label6.Click += label6_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(47, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(159, 69);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(35, 36);
            label9.Name = "label9";
            label9.Size = new Size(24, 28);
            label9.TabIndex = 2;
            label9.Text = "5";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 6);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 0;
            label5.Text = "Total Organizer";
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            ClientSize = new Size(1182, 703);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HahuEvents - Administrator Dashboard";
            Load += AdminDashboardForm_Load;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlALLEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAllEvents).EndInit();
            pnlEventFilters.ResumeLayout(false);
            pnlEventFilters.PerformLayout();
            pnlSummaryCards.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Label label1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel pnlHeader;
        private Panel pnlContent;
        private Panel pnlALLEvents;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel pnlSummaryCards;
        private Panel pnlEventFilters;
        private TextBox txtSearchEvent;
        private ComboBox cmbOrganizerFilter;
        private ComboBox cmbStatusFilter;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Button btnSearch;
        private Button btnReset;
        private DataGridView dgvAllEvents;
        private DataGridViewTextBoxColumn colEventId;
        private DataGridViewTextBoxColumn colEventTitle;
        private DataGridViewTextBoxColumn colOrganizer;
        private DataGridViewTextBoxColumn colEventDate;
        private DataGridViewTextBoxColumn colLocation;
        private DataGridViewTextBoxColumn colCapacity;
        private DataGridViewTextBoxColumn colRegistrations;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewButtonColumn colViewDetails;
        private Label lblFooter;
        private Panel panel1;
        private Panel panel3;
        private Label label7;
        private Panel panel4;
        private Label label8;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private Label label11;
        private Label label12;
        private Label label10;
        private Label label9;
        private Button button6;
    }
}
