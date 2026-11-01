
namespace HahuEvents.Desktop.Forms
{
    partial class OrganizerDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Panel pnlMyEvents;
        private System.Windows.Forms.Panel pnlRegistrations;
        private System.Windows.Forms.Panel pnlAttendance;
        private System.Windows.Forms.Panel pnlReports;
        private System.Windows.Forms.Label lblRegistrationTitle;
        private System.Windows.Forms.Label lblRegistrationSubtitle;
        private System.Windows.Forms.Label lblRegistrationEvent;
        private System.Windows.Forms.Label lblAttendanceTitle;
        private System.Windows.Forms.Label lblAttendanceSubtitle;
        private System.Windows.Forms.Label lblAttendanceEvent;
        private System.Windows.Forms.Label lblReportsTitle;
        private System.Windows.Forms.Label lblReportsSubtitle;

        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnMyEvents;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.Button btnRegistrations;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnMyReports;
        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.Label lblMyEventsTitle;
        private System.Windows.Forms.Label lblPublishedTitle;
        private System.Windows.Forms.Label lblRegistrationsTitle;
        private System.Windows.Forms.Label lblUpcomingTitle;

        private System.Windows.Forms.Label lblMyEventsCount;
        private System.Windows.Forms.Label lblPublishedEventsCount;
        private System.Windows.Forms.Label lblTotalRegistrations;
        private System.Windows.Forms.Label lblUpcomingEventsCount;

        private System.Windows.Forms.Label lblMyEventsSection;
        private System.Windows.Forms.Label lblMyEventsDescription;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblStatus;

        private System.Windows.Forms.TextBox txtSearchEvent;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvMyEvents;
        private System.Windows.Forms.ComboBox cmbRegistrationEvent;
        private System.Windows.Forms.Button btnRegisterParticipant;
        private System.Windows.Forms.Label lblRegistrationSummary;
        private System.Windows.Forms.DataGridView dgvRegistrations;
        private System.Windows.Forms.ComboBox cmbAttendanceEvent;
        private System.Windows.Forms.Button btnMarkPresent;
        private System.Windows.Forms.Button btnMarkAbsent;
        private System.Windows.Forms.Button btnClearAttendance;
        private System.Windows.Forms.Label lblAttendanceSummary;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Label lblReportSummary;
        private System.Windows.Forms.DataGridView dgvReports;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlSidebar = new Panel();
            lblAppName = new Label();
            lblMenuTitle = new Label();
            btnDashboard = new Button();
            btnMyEvents = new Button();
            btnCreateEvent = new Button();
            btnRegistrations = new Button();
            btnAttendance = new Button();
            btnMyReports = new Button();
            btnLogout = new Button();
            pnlHeader = new Panel();
            lblDashboardTitle = new Label();
            lblSubtitle = new Label();
            lblWelcome = new Label();
            pnlSummary = new Panel();
            pnlMyEvents = new Panel();
            lblMyEventsSection = new Label();
            lblMyEventsDescription = new Label();
            lblSearch = new Label();
            txtSearchEvent = new TextBox();
            lblStatus = new Label();
            cmbStatusFilter = new ComboBox();
            btnSearch = new Button();
            btnReset = new Button();
            dgvMyEvents = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            pnlRegistrations = new Panel();
            lblRegistrationTitle = new Label();
            lblRegistrationSubtitle = new Label();
            lblRegistrationEvent = new Label();
            cmbRegistrationEvent = new ComboBox();
            btnRegisterParticipant = new Button();
            lblRegistrationSummary = new Label();
            dgvRegistrations = new DataGridView();
            pnlAttendance = new Panel();
            lblAttendanceTitle = new Label();
            lblAttendanceSubtitle = new Label();
            lblAttendanceEvent = new Label();
            cmbAttendanceEvent = new ComboBox();
            btnMarkPresent = new Button();
            btnMarkAbsent = new Button();
            btnClearAttendance = new Button();
            lblAttendanceSummary = new Label();
            dgvAttendance = new DataGridView();
            pnlReports = new Panel();
            lblReportsTitle = new Label();
            lblReportsSubtitle = new Label();
            lblReportSummary = new Label();
            dgvReports = new DataGridView();
            lblMyEventsTitle = new Label();
            lblPublishedTitle = new Label();
            lblRegistrationsTitle = new Label();
            lblUpcomingTitle = new Label();
            lblMyEventsCount = new Label();
            lblPublishedEventsCount = new Label();
            lblTotalRegistrations = new Label();
            lblUpcomingEventsCount = new Label();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn19 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn20 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn21 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn22 = new DataGridViewTextBoxColumn();
            pnlSidebar.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlMyEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyEvents).BeginInit();
            pnlRegistrations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistrations).BeginInit();
            pnlAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            pnlReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.White;
            pnlSidebar.Controls.Add(lblAppName);
            pnlSidebar.Controls.Add(lblMenuTitle);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(btnMyEvents);
            pnlSidebar.Controls.Add(btnCreateEvent);
            pnlSidebar.Controls.Add(btnRegistrations);
            pnlSidebar.Controls.Add(btnAttendance);
            pnlSidebar.Controls.Add(btnMyReports);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(200, 687);
            pnlSidebar.TabIndex = 0;
            // 
            // lblAppName
            // 
            lblAppName.Font = new Font("Segoe UI", 15F);
            lblAppName.ForeColor = Color.FromArgb(91, 111, 145);
            lblAppName.Location = new Point(12, 25);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(180, 42);
            lblAppName.TabIndex = 0;
            lblAppName.Text = " HahuEvents";
            // 
            // lblMenuTitle
            // 
            lblMenuTitle.Font = new Font("Segoe UI", 8F);
            lblMenuTitle.ForeColor = Color.FromArgb(102, 112, 133);
            lblMenuTitle.Location = new Point(8, 103);
            lblMenuTitle.Name = "lblMenuTitle";
            lblMenuTitle.Size = new Size(180, 25);
            lblMenuTitle.TabIndex = 1;
            lblMenuTitle.Text = "ORGANIZER MENU";
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.RoyalBlue;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(5, 140);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(12, 0, 0, 0);
            btnDashboard.Size = new Size(175, 42);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnMyEvents
            // 
            btnMyEvents.BackColor = Color.White;
            btnMyEvents.FlatAppearance.BorderSize = 0;
            btnMyEvents.FlatStyle = FlatStyle.Flat;
            btnMyEvents.ForeColor = Color.FromArgb(91, 111, 145);
            btnMyEvents.Location = new Point(5, 205);
            btnMyEvents.Name = "btnMyEvents";
            btnMyEvents.Padding = new Padding(12, 0, 0, 0);
            btnMyEvents.Size = new Size(175, 42);
            btnMyEvents.TabIndex = 3;
            btnMyEvents.Text = "My Events";
            btnMyEvents.TextAlign = ContentAlignment.MiddleLeft;
            btnMyEvents.UseVisualStyleBackColor = false;
            btnMyEvents.Click += btnMyEvents_Click;
            // 
            // btnCreateEvent
            // 
            btnCreateEvent.BackColor = Color.White;
            btnCreateEvent.FlatAppearance.BorderSize = 0;
            btnCreateEvent.FlatStyle = FlatStyle.Flat;
            btnCreateEvent.ForeColor = Color.FromArgb(91, 111, 145);
            btnCreateEvent.Location = new Point(5, 270);
            btnCreateEvent.Name = "btnCreateEvent";
            btnCreateEvent.Padding = new Padding(12, 0, 0, 0);
            btnCreateEvent.Size = new Size(175, 42);
            btnCreateEvent.TabIndex = 4;
            btnCreateEvent.Text = "Create Event";
            btnCreateEvent.TextAlign = ContentAlignment.MiddleLeft;
            btnCreateEvent.UseVisualStyleBackColor = false;
            btnCreateEvent.Click += btnCreateEvent_Click;
            // 
            // btnRegistrations
            // 
            btnRegistrations.BackColor = Color.White;
            btnRegistrations.FlatAppearance.BorderSize = 0;
            btnRegistrations.FlatStyle = FlatStyle.Flat;
            btnRegistrations.ForeColor = Color.FromArgb(91, 111, 145);
            btnRegistrations.Location = new Point(5, 335);
            btnRegistrations.Name = "btnRegistrations";
            btnRegistrations.Padding = new Padding(12, 0, 0, 0);
            btnRegistrations.Size = new Size(175, 42);
            btnRegistrations.TabIndex = 5;
            btnRegistrations.Text = "Registrations";
            btnRegistrations.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistrations.UseVisualStyleBackColor = false;
            btnRegistrations.Click += btnRegistrations_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.BackColor = Color.White;
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.ForeColor = Color.FromArgb(91, 111, 145);
            btnAttendance.Location = new Point(5, 400);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Padding = new Padding(12, 0, 0, 0);
            btnAttendance.Size = new Size(175, 42);
            btnAttendance.TabIndex = 6;
            btnAttendance.Text = "Attendance";
            btnAttendance.TextAlign = ContentAlignment.MiddleLeft;
            btnAttendance.UseVisualStyleBackColor = false;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // btnMyReports
            // 
            btnMyReports.BackColor = Color.White;
            btnMyReports.FlatAppearance.BorderSize = 0;
            btnMyReports.FlatStyle = FlatStyle.Flat;
            btnMyReports.ForeColor = Color.FromArgb(91, 111, 145);
            btnMyReports.Location = new Point(5, 465);
            btnMyReports.Name = "btnMyReports";
            btnMyReports.Padding = new Padding(12, 0, 0, 0);
            btnMyReports.Size = new Size(175, 42);
            btnMyReports.TabIndex = 7;
            btnMyReports.Text = "My Reports";
            btnMyReports.TextAlign = ContentAlignment.MiddleLeft;
            btnMyReports.UseVisualStyleBackColor = false;
            btnMyReports.Click += btnMyReports_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.BackColor = Color.White;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.Firebrick;
            btnLogout.Location = new Point(5, 640);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(12, 0, 0, 0);
            btnLogout.Size = new Size(175, 42);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(245, 247, 251);
            pnlHeader.Controls.Add(lblDashboardTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Location = new Point(200, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1139, 115);
            pnlHeader.TabIndex = 1;
            // 
            // lblDashboardTitle
            // 
            lblDashboardTitle.Font = new Font("Segoe UI", 25F);
            lblDashboardTitle.Location = new Point(95, 12);
            lblDashboardTitle.Name = "lblDashboardTitle";
            lblDashboardTitle.Size = new Size(600, 48);
            lblDashboardTitle.TabIndex = 0;
            lblDashboardTitle.Text = "Organizer Dashboard";
            // 
            // lblSubtitle
            // 
            lblSubtitle.Location = new Point(116, 65);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(350, 25);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Manage Events and Participants";
            // 
            // lblWelcome
            // 
            lblWelcome.Location = new Point(800, 25);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(300, 30);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Welcome, Organizer";
            lblWelcome.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlSummary
            // 
            pnlSummary.BackColor = Color.FromArgb(224, 224, 224);
            pnlSummary.Location = new Point(225, 115);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new Size(967, 114);
            pnlSummary.TabIndex = 2;
            // 
            // pnlMyEvents
            // 
            pnlMyEvents.BackColor = Color.FromArgb(245, 247, 251);
            pnlMyEvents.Controls.Add(lblMyEventsSection);
            pnlMyEvents.Controls.Add(lblMyEventsDescription);
            pnlMyEvents.Controls.Add(lblSearch);
            pnlMyEvents.Controls.Add(txtSearchEvent);
            pnlMyEvents.Controls.Add(lblStatus);
            pnlMyEvents.Controls.Add(cmbStatusFilter);
            pnlMyEvents.Controls.Add(btnSearch);
            pnlMyEvents.Controls.Add(btnReset);
            pnlMyEvents.Controls.Add(dgvMyEvents);
            pnlMyEvents.Location = new Point(225, 252);
            pnlMyEvents.Name = "pnlMyEvents";
            pnlMyEvents.Size = new Size(967, 408);
            pnlMyEvents.TabIndex = 4;
            // 
            // lblMyEventsSection
            // 
            lblMyEventsSection.Font = new Font("Segoe UI", 12F);
            lblMyEventsSection.Location = new Point(30, 8);
            lblMyEventsSection.Name = "lblMyEventsSection";
            lblMyEventsSection.Size = new Size(200, 28);
            lblMyEventsSection.TabIndex = 0;
            lblMyEventsSection.Text = "My Events";
            // 
            // lblMyEventsDescription
            // 
            lblMyEventsDescription.Location = new Point(38, 38);
            lblMyEventsDescription.Name = "lblMyEventsDescription";
            lblMyEventsDescription.Size = new Size(400, 23);
            lblMyEventsDescription.TabIndex = 1;
            lblMyEventsDescription.Text = "View and manage events created by your account";
            // 
            // lblSearch
            // 
            lblSearch.Location = new Point(10, 75);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(100, 22);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Search";
            // 
            // txtSearchEvent
            // 
            txtSearchEvent.Location = new Point(10, 100);
            txtSearchEvent.Name = "txtSearchEvent";
            txtSearchEvent.Size = new Size(197, 23);
            txtSearchEvent.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.Location = new Point(275, 75);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(100, 22);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status";
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusFilter.Location = new Point(275, 100);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(160, 23);
            cmbStatusFilter.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(465, 100);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(85, 27);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(650, 100);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(85, 27);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset";
            btnReset.Click += btnReset_Click;
            // 
            // dgvMyEvents
            // 
            dgvMyEvents.AllowUserToAddRows = false;
            dgvMyEvents.AllowUserToDeleteRows = false;
            dgvMyEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMyEvents.BackgroundColor = Color.White;
            dgvMyEvents.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7 });
            dgvMyEvents.Location = new Point(0, 140);
            dgvMyEvents.MultiSelect = false;
            dgvMyEvents.Name = "dgvMyEvents";
            dgvMyEvents.ReadOnly = true;
            dgvMyEvents.RowHeadersWidth = 30;
            dgvMyEvents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMyEvents.Size = new Size(930, 195);
            dgvMyEvents.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Event ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Event Title";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Event Date";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Location";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Capacity";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Registered";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Status";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // pnlRegistrations
            // 
            pnlRegistrations.BackColor = Color.White;
            pnlRegistrations.Controls.Add(lblRegistrationTitle);
            pnlRegistrations.Controls.Add(lblRegistrationSubtitle);
            pnlRegistrations.Controls.Add(lblRegistrationEvent);
            pnlRegistrations.Controls.Add(cmbRegistrationEvent);
            pnlRegistrations.Controls.Add(btnRegisterParticipant);
            pnlRegistrations.Controls.Add(lblRegistrationSummary);
            pnlRegistrations.Controls.Add(dgvRegistrations);
            pnlRegistrations.Location = new Point(225, 115);
            pnlRegistrations.Name = "pnlRegistrations";
            pnlRegistrations.Size = new Size(967, 545);
            pnlRegistrations.TabIndex = 5;
            pnlRegistrations.Visible = false;
            // 
            // lblRegistrationTitle
            // 
            lblRegistrationTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblRegistrationTitle.Location = new Point(24, 20);
            lblRegistrationTitle.Name = "lblRegistrationTitle";
            lblRegistrationTitle.Size = new Size(600, 32);
            lblRegistrationTitle.TabIndex = 0;
            lblRegistrationTitle.Text = "Participant Registrations";
            // 
            // lblRegistrationSubtitle
            // 
            lblRegistrationSubtitle.Location = new Point(26, 56);
            lblRegistrationSubtitle.Name = "lblRegistrationSubtitle";
            lblRegistrationSubtitle.Size = new Size(800, 24);
            lblRegistrationSubtitle.TabIndex = 1;
            lblRegistrationSubtitle.Text = "Select one of your published events to view or register participants.";
            // 
            // lblRegistrationEvent
            // 
            lblRegistrationEvent.Location = new Point(26, 100);
            lblRegistrationEvent.Name = "lblRegistrationEvent";
            lblRegistrationEvent.Size = new Size(100, 24);
            lblRegistrationEvent.TabIndex = 2;
            lblRegistrationEvent.Text = "Event";
            // 
            // cmbRegistrationEvent
            // 
            cmbRegistrationEvent.DisplayMember = "Title";
            cmbRegistrationEvent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRegistrationEvent.Location = new Point(26, 126);
            cmbRegistrationEvent.Name = "cmbRegistrationEvent";
            cmbRegistrationEvent.Size = new Size(440, 23);
            cmbRegistrationEvent.TabIndex = 3;
            cmbRegistrationEvent.SelectedIndexChanged += RegistrationEventSelector_SelectedIndexChanged;
            // 
            // btnRegisterParticipant
            // 
            btnRegisterParticipant.BackColor = Color.FromArgb(36, 87, 197);
            btnRegisterParticipant.FlatAppearance.BorderSize = 0;
            btnRegisterParticipant.FlatStyle = FlatStyle.Flat;
            btnRegisterParticipant.ForeColor = Color.White;
            btnRegisterParticipant.Location = new Point(750, 120);
            btnRegisterParticipant.Name = "btnRegisterParticipant";
            btnRegisterParticipant.Size = new Size(190, 38);
            btnRegisterParticipant.TabIndex = 4;
            btnRegisterParticipant.Text = "Register Participant";
            btnRegisterParticipant.UseVisualStyleBackColor = false;
            btnRegisterParticipant.Click += RegisterParticipant_Click;
            // 
            // lblRegistrationSummary
            // 
            lblRegistrationSummary.ForeColor = Color.FromArgb(91, 111, 145);
            lblRegistrationSummary.Location = new Point(26, 165);
            lblRegistrationSummary.Name = "lblRegistrationSummary";
            lblRegistrationSummary.Size = new Size(700, 24);
            lblRegistrationSummary.TabIndex = 5;
            // 
            // dgvRegistrations
            // 
            dgvRegistrations.AllowUserToAddRows = false;
            dgvRegistrations.AllowUserToDeleteRows = false;
            dgvRegistrations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRegistrations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRegistrations.BackgroundColor = Color.White;
            dgvRegistrations.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11 });
            dgvRegistrations.Location = new Point(24, 195);
            dgvRegistrations.MultiSelect = false;
            dgvRegistrations.Name = "dgvRegistrations";
            dgvRegistrations.ReadOnly = true;
            dgvRegistrations.RowHeadersVisible = false;
            dgvRegistrations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRegistrations.Size = new Size(916, 320);
            dgvRegistrations.TabIndex = 6;
            // 
            // pnlAttendance
            // 
            pnlAttendance.BackColor = Color.White;
            pnlAttendance.Controls.Add(lblAttendanceTitle);
            pnlAttendance.Controls.Add(lblAttendanceSubtitle);
            pnlAttendance.Controls.Add(lblAttendanceEvent);
            pnlAttendance.Controls.Add(cmbAttendanceEvent);
            pnlAttendance.Controls.Add(btnMarkPresent);
            pnlAttendance.Controls.Add(btnMarkAbsent);
            pnlAttendance.Controls.Add(btnClearAttendance);
            pnlAttendance.Controls.Add(lblAttendanceSummary);
            pnlAttendance.Controls.Add(dgvAttendance);
            pnlAttendance.Location = new Point(225, 115);
            pnlAttendance.Name = "pnlAttendance";
            pnlAttendance.Size = new Size(967, 545);
            pnlAttendance.TabIndex = 6;
            pnlAttendance.Visible = false;
            // 
            // lblAttendanceTitle
            // 
            lblAttendanceTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAttendanceTitle.Location = new Point(24, 20);
            lblAttendanceTitle.Name = "lblAttendanceTitle";
            lblAttendanceTitle.Size = new Size(600, 32);
            lblAttendanceTitle.TabIndex = 0;
            lblAttendanceTitle.Text = "Attendance";
            // 
            // lblAttendanceSubtitle
            // 
            lblAttendanceSubtitle.Location = new Point(26, 56);
            lblAttendanceSubtitle.Name = "lblAttendanceSubtitle";
            lblAttendanceSubtitle.Size = new Size(800, 24);
            lblAttendanceSubtitle.TabIndex = 1;
            lblAttendanceSubtitle.Text = "Select an event and mark a participant's attendance.";
            // 
            // lblAttendanceEvent
            // 
            lblAttendanceEvent.Location = new Point(26, 100);
            lblAttendanceEvent.Name = "lblAttendanceEvent";
            lblAttendanceEvent.Size = new Size(100, 24);
            lblAttendanceEvent.TabIndex = 2;
            lblAttendanceEvent.Text = "Event";
            // 
            // cmbAttendanceEvent
            // 
            cmbAttendanceEvent.DisplayMember = "Title";
            cmbAttendanceEvent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAttendanceEvent.Location = new Point(26, 126);
            cmbAttendanceEvent.Name = "cmbAttendanceEvent";
            cmbAttendanceEvent.Size = new Size(440, 23);
            cmbAttendanceEvent.TabIndex = 3;
            cmbAttendanceEvent.SelectedIndexChanged += AttendanceEventSelector_SelectedIndexChanged;
            // 
            // btnMarkPresent
            // 
            btnMarkPresent.BackColor = Color.FromArgb(36, 87, 197);
            btnMarkPresent.FlatStyle = FlatStyle.Flat;
            btnMarkPresent.ForeColor = Color.White;
            btnMarkPresent.Location = new Point(590, 122);
            btnMarkPresent.Name = "btnMarkPresent";
            btnMarkPresent.Size = new Size(115, 36);
            btnMarkPresent.TabIndex = 4;
            btnMarkPresent.Tag = Models.AttendanceStatus.Present;
            btnMarkPresent.Text = "Mark Present";
            btnMarkPresent.UseVisualStyleBackColor = false;
            btnMarkPresent.Click += SetSelectedAttendance_Click;
            // 
            // btnMarkAbsent
            // 
            btnMarkAbsent.BackColor = Color.FromArgb(36, 87, 197);
            btnMarkAbsent.FlatStyle = FlatStyle.Flat;
            btnMarkAbsent.ForeColor = Color.White;
            btnMarkAbsent.Location = new Point(715, 122);
            btnMarkAbsent.Name = "btnMarkAbsent";
            btnMarkAbsent.Size = new Size(115, 36);
            btnMarkAbsent.TabIndex = 5;
            btnMarkAbsent.Tag = Models.AttendanceStatus.Absent;
            btnMarkAbsent.Text = "Mark Absent";
            btnMarkAbsent.UseVisualStyleBackColor = false;
            btnMarkAbsent.Click += SetSelectedAttendance_Click;
            // 
            // btnClearAttendance
            // 
            btnClearAttendance.BackColor = Color.FromArgb(36, 87, 197);
            btnClearAttendance.FlatStyle = FlatStyle.Flat;
            btnClearAttendance.ForeColor = Color.White;
            btnClearAttendance.Location = new Point(840, 122);
            btnClearAttendance.Name = "btnClearAttendance";
            btnClearAttendance.Size = new Size(100, 36);
            btnClearAttendance.TabIndex = 6;
            btnClearAttendance.Tag = Models.AttendanceStatus.NotMarked;
            btnClearAttendance.Text = "Clear Mark";
            btnClearAttendance.UseVisualStyleBackColor = false;
            btnClearAttendance.Click += SetSelectedAttendance_Click;
            // 
            // lblAttendanceSummary
            // 
            lblAttendanceSummary.ForeColor = Color.FromArgb(91, 111, 145);
            lblAttendanceSummary.Location = new Point(26, 165);
            lblAttendanceSummary.Name = "lblAttendanceSummary";
            lblAttendanceSummary.Size = new Size(900, 24);
            lblAttendanceSummary.TabIndex = 7;
            // 
            // dgvAttendance
            // 
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.AllowUserToDeleteRows = false;
            dgvAttendance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.BackgroundColor = Color.White;
            dgvAttendance.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn15 });
            dgvAttendance.Location = new Point(24, 195);
            dgvAttendance.MultiSelect = false;
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.ReadOnly = true;
            dgvAttendance.RowHeadersVisible = false;
            dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.Size = new Size(916, 320);
            dgvAttendance.TabIndex = 8;
            // 
            // pnlReports
            // 
            pnlReports.BackColor = Color.White;
            pnlReports.Controls.Add(lblReportsTitle);
            pnlReports.Controls.Add(lblReportsSubtitle);
            pnlReports.Controls.Add(lblReportSummary);
            pnlReports.Controls.Add(dgvReports);
            pnlReports.Location = new Point(225, 115);
            pnlReports.Name = "pnlReports";
            pnlReports.Size = new Size(967, 545);
            pnlReports.TabIndex = 7;
            pnlReports.Visible = false;
            // 
            // lblReportsTitle
            // 
            lblReportsTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblReportsTitle.Location = new Point(24, 20);
            lblReportsTitle.Name = "lblReportsTitle";
            lblReportsTitle.Size = new Size(600, 32);
            lblReportsTitle.TabIndex = 0;
            lblReportsTitle.Text = "My Reports";
            // 
            // lblReportsSubtitle
            // 
            lblReportsSubtitle.Location = new Point(26, 56);
            lblReportsSubtitle.Name = "lblReportsSubtitle";
            lblReportsSubtitle.Size = new Size(800, 24);
            lblReportsSubtitle.TabIndex = 1;
            lblReportsSubtitle.Text = "Registration and attendance totals for your events.";
            // 
            // lblReportSummary
            // 
            lblReportSummary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblReportSummary.Location = new Point(26, 82);
            lblReportSummary.Name = "lblReportSummary";
            lblReportSummary.Size = new Size(900, 24);
            lblReportSummary.TabIndex = 2;
            // 
            // dgvReports
            // 
            dgvReports.AllowUserToAddRows = false;
            dgvReports.AllowUserToDeleteRows = false;
            dgvReports.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReports.BackgroundColor = Color.White;
            dgvReports.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn16, dataGridViewTextBoxColumn17, dataGridViewTextBoxColumn18, dataGridViewTextBoxColumn19, dataGridViewTextBoxColumn20, dataGridViewTextBoxColumn21, dataGridViewTextBoxColumn22 });
            dgvReports.Location = new Point(24, 115);
            dgvReports.MultiSelect = false;
            dgvReports.Name = "dgvReports";
            dgvReports.ReadOnly = true;
            dgvReports.RowHeadersVisible = false;
            dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReports.Size = new Size(916, 400);
            dgvReports.TabIndex = 3;
            // 
            // lblMyEventsTitle
            // 
            lblMyEventsTitle.Location = new Point(0, 0);
            lblMyEventsTitle.Name = "lblMyEventsTitle";
            lblMyEventsTitle.Size = new Size(100, 23);
            lblMyEventsTitle.TabIndex = 0;
            // 
            // lblPublishedTitle
            // 
            lblPublishedTitle.Location = new Point(0, 0);
            lblPublishedTitle.Name = "lblPublishedTitle";
            lblPublishedTitle.Size = new Size(100, 23);
            lblPublishedTitle.TabIndex = 0;
            // 
            // lblRegistrationsTitle
            // 
            lblRegistrationsTitle.Location = new Point(0, 0);
            lblRegistrationsTitle.Name = "lblRegistrationsTitle";
            lblRegistrationsTitle.Size = new Size(100, 23);
            lblRegistrationsTitle.TabIndex = 0;
            // 
            // lblUpcomingTitle
            // 
            lblUpcomingTitle.Location = new Point(0, 0);
            lblUpcomingTitle.Name = "lblUpcomingTitle";
            lblUpcomingTitle.Size = new Size(100, 23);
            lblUpcomingTitle.TabIndex = 0;
            // 
            // lblMyEventsCount
            // 
            lblMyEventsCount.Location = new Point(0, 0);
            lblMyEventsCount.Name = "lblMyEventsCount";
            lblMyEventsCount.Size = new Size(100, 23);
            lblMyEventsCount.TabIndex = 0;
            // 
            // lblPublishedEventsCount
            // 
            lblPublishedEventsCount.Location = new Point(0, 0);
            lblPublishedEventsCount.Name = "lblPublishedEventsCount";
            lblPublishedEventsCount.Size = new Size(100, 23);
            lblPublishedEventsCount.TabIndex = 0;
            // 
            // lblTotalRegistrations
            // 
            lblTotalRegistrations.Location = new Point(0, 0);
            lblTotalRegistrations.Name = "lblTotalRegistrations";
            lblTotalRegistrations.Size = new Size(100, 23);
            lblTotalRegistrations.TabIndex = 0;
            // 
            // lblUpcomingEventsCount
            // 
            lblUpcomingEventsCount.Location = new Point(0, 0);
            lblUpcomingEventsCount.Name = "lblUpcomingEventsCount";
            lblUpcomingEventsCount.Size = new Size(100, 23);
            lblUpcomingEventsCount.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Participant";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Email";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Phone";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Registered";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Participant";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.HeaderText = "Email";
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.HeaderText = "Attendance";
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.HeaderText = "Registered";
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.HeaderText = "Event";
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.HeaderText = "Registrations";
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            dataGridViewTextBoxColumn18.HeaderText = "Present";
            dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            dataGridViewTextBoxColumn19.HeaderText = "Absent";
            dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            dataGridViewTextBoxColumn20.HeaderText = "Not Marked";
            dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            dataGridViewTextBoxColumn21.HeaderText = "Attendance Rate";
            dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            dataGridViewTextBoxColumn22.HeaderText = "Event Status";
            dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // OrganizerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            ClientSize = new Size(1339, 687);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSummary);
            Controls.Add(pnlMyEvents);
            Controls.Add(pnlRegistrations);
            Controls.Add(pnlAttendance);
            Controls.Add(pnlReports);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1100, 650);
            Name = "OrganizerDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrganizerDashboardForm";
            pnlSidebar.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlMyEvents.ResumeLayout(false);
            pnlMyEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyEvents).EndInit();
            pnlRegistrations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRegistrations).EndInit();
            pnlAttendance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            pnlReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
        }

        private void AddSummaryCard(
            System.Windows.Forms.Panel parent,
            int left,
            string title,
            System.Windows.Forms.Label countLabel,
            string description)
        {
            var card = new System.Windows.Forms.Panel
            {
                Location = new System.Drawing.Point(left, 15),
                Size = new System.Drawing.Size(215, 82),
                BackColor = System.Drawing.Color.White
            };

            var titleLabel = new System.Windows.Forms.Label
            {
                Text = title,
                Location = new System.Drawing.Point(12, 8),
                Size = new System.Drawing.Size(190, 20),
                Font = new System.Drawing.Font("Segoe UI", 9F)
            };

            countLabel.Text = "0";
            countLabel.Location =
                new System.Drawing.Point(12, 30);
            countLabel.Size =
                new System.Drawing.Size(80, 25);
            countLabel.Font = new System.Drawing.Font(
                "Segoe UI", 12F, System.Drawing.FontStyle.Bold);

            var descriptionLabel = new System.Windows.Forms.Label
            {
                Text = description,
                Location = new System.Drawing.Point(12, 56),
                Size = new System.Drawing.Size(190, 20),
                Font = new System.Drawing.Font("Segoe UI", 8F)
            };

            card.Controls.Add(titleLabel);
            card.Controls.Add(countLabel);
            card.Controls.Add(descriptionLabel);

            parent.Controls.Add(card);
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
    }
}
