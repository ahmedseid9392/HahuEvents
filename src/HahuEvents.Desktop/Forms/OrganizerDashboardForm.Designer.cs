
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
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            pnlSidebar.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlMyEvents.SuspendLayout();
            pnlRegistrations.SuspendLayout();
            pnlAttendance.SuspendLayout();
            pnlReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyEvents).BeginInit();
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
            btnDashboard.Location = new Point(5, 140);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(175, 42);
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Padding = new Padding(12, 0, 0, 0);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.BackColor = Color.FromArgb(36, 87, 197);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Click += btnDashboard_Click;
            //
            // btnMyEvents
            //
            btnMyEvents.Location = new Point(5, 205);
            btnMyEvents.Name = "btnMyEvents";
            btnMyEvents.Size = new Size(175, 42);
            btnMyEvents.Text = "My Events";
            btnMyEvents.TextAlign = ContentAlignment.MiddleLeft;
            btnMyEvents.Padding = new Padding(12, 0, 0, 0);
            btnMyEvents.FlatStyle = FlatStyle.Flat;
            btnMyEvents.FlatAppearance.BorderSize = 0;
            btnMyEvents.BackColor = Color.White;
            btnMyEvents.ForeColor = Color.FromArgb(91, 111, 145);
            btnMyEvents.TabIndex = 3;
            btnMyEvents.Click += btnMyEvents_Click;
            //
            // btnCreateEvent
            //
            btnCreateEvent.Location = new Point(5, 270);
            btnCreateEvent.Name = "btnCreateEvent";
            btnCreateEvent.Size = new Size(175, 42);
            btnCreateEvent.Text = "Create Event";
            btnCreateEvent.TextAlign = ContentAlignment.MiddleLeft;
            btnCreateEvent.Padding = new Padding(12, 0, 0, 0);
            btnCreateEvent.FlatStyle = FlatStyle.Flat;
            btnCreateEvent.FlatAppearance.BorderSize = 0;
            btnCreateEvent.BackColor = Color.White;
            btnCreateEvent.ForeColor = Color.FromArgb(91, 111, 145);
            btnCreateEvent.TabIndex = 4;
            btnCreateEvent.Click += btnCreateEvent_Click;
            //
            // btnRegistrations
            //
            btnRegistrations.Location = new Point(5, 335);
            btnRegistrations.Name = "btnRegistrations";
            btnRegistrations.Size = new Size(175, 42);
            btnRegistrations.Text = "Registrations";
            btnRegistrations.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistrations.Padding = new Padding(12, 0, 0, 0);
            btnRegistrations.FlatStyle = FlatStyle.Flat;
            btnRegistrations.FlatAppearance.BorderSize = 0;
            btnRegistrations.BackColor = Color.White;
            btnRegistrations.ForeColor = Color.FromArgb(91, 111, 145);
            btnRegistrations.TabIndex = 5;
            btnRegistrations.Click += btnRegistrations_Click;
            //
            // btnAttendance
            //
            btnAttendance.Location = new Point(5, 400);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(175, 42);
            btnAttendance.Text = "Attendance";
            btnAttendance.TextAlign = ContentAlignment.MiddleLeft;
            btnAttendance.Padding = new Padding(12, 0, 0, 0);
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.BackColor = Color.White;
            btnAttendance.ForeColor = Color.FromArgb(91, 111, 145);
            btnAttendance.TabIndex = 6;
            btnAttendance.Click += btnAttendance_Click;
            //
            // btnMyReports
            //
            btnMyReports.Location = new Point(5, 465);
            btnMyReports.Name = "btnMyReports";
            btnMyReports.Size = new Size(175, 42);
            btnMyReports.Text = "My Reports";
            btnMyReports.TextAlign = ContentAlignment.MiddleLeft;
            btnMyReports.Padding = new Padding(12, 0, 0, 0);
            btnMyReports.FlatStyle = FlatStyle.Flat;
            btnMyReports.FlatAppearance.BorderSize = 0;
            btnMyReports.BackColor = Color.White;
            btnMyReports.ForeColor = Color.FromArgb(91, 111, 145);
            btnMyReports.TabIndex = 7;
            btnMyReports.Click += btnMyReports_Click;
            //
            // btnLogout
            //
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.ForeColor = Color.Firebrick;
            btnLogout.Location = new Point(5, 640);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(175, 42);
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.Padding = new Padding(12, 0, 0, 0);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.BackColor = Color.White;
            btnLogout.ForeColor = Color.Firebrick;
            btnLogout.TabIndex = 8;
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
            pnlRegistrations.Visible = false;
            //
            // lblRegistrationTitle
            //
            lblRegistrationTitle.Location = new Point(24, 20);
            lblRegistrationTitle.Size = new Size(600, 32);
            lblRegistrationTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblRegistrationTitle.Text = "Participant Registrations";
            //
            // lblRegistrationSubtitle
            //
            lblRegistrationSubtitle.Location = new Point(26, 56);
            lblRegistrationSubtitle.Size = new Size(800, 24);
            lblRegistrationSubtitle.Text = "Select one of your published events to view or register participants.";
            //
            // lblRegistrationEvent
            //
            lblRegistrationEvent.Location = new Point(26, 100);
            lblRegistrationEvent.Size = new Size(100, 24);
            lblRegistrationEvent.Text = "Event";
            //
            // cmbRegistrationEvent
            //
            cmbRegistrationEvent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRegistrationEvent.Location = new Point(26, 126);
            cmbRegistrationEvent.Size = new Size(440, 30);
            cmbRegistrationEvent.DisplayMember = "Title";
            cmbRegistrationEvent.SelectedIndexChanged += RegistrationEventSelector_SelectedIndexChanged;
            //
            // btnRegisterParticipant
            //
            btnRegisterParticipant.Location = new Point(750, 120);
            btnRegisterParticipant.Size = new Size(190, 38);
            btnRegisterParticipant.Text = "Register Participant";
            btnRegisterParticipant.BackColor = Color.FromArgb(36, 87, 197);
            btnRegisterParticipant.ForeColor = Color.White;
            btnRegisterParticipant.FlatStyle = FlatStyle.Flat;
            btnRegisterParticipant.FlatAppearance.BorderSize = 0;
            btnRegisterParticipant.Click += RegisterParticipant_Click;
            //
            // lblRegistrationSummary
            //
            lblRegistrationSummary.Location = new Point(26, 165);
            lblRegistrationSummary.Size = new Size(700, 24);
            lblRegistrationSummary.ForeColor = Color.FromArgb(91, 111, 145);
            //
            // dgvRegistrations
            //
            dgvRegistrations.Location = new Point(24, 195);
            dgvRegistrations.Size = new Size(916, 320);
            dgvRegistrations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRegistrations.BackgroundColor = Color.White;
            dgvRegistrations.BorderStyle = BorderStyle.FixedSingle;
            dgvRegistrations.AllowUserToAddRows = false;
            dgvRegistrations.AllowUserToDeleteRows = false;
            dgvRegistrations.ReadOnly = true;
            dgvRegistrations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRegistrations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRegistrations.MultiSelect = false;
            dgvRegistrations.RowHeadersVisible = false;
            dgvRegistrations.Columns.Add("Participant", "Participant");
            dgvRegistrations.Columns.Add("Email", "Email");
            dgvRegistrations.Columns.Add("Phone", "Phone");
            dgvRegistrations.Columns.Add("RegistrationDate", "Registered");
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
            pnlAttendance.Visible = false;
            //
            // lblAttendanceTitle
            //
            lblAttendanceTitle.Location = new Point(24, 20);
            lblAttendanceTitle.Size = new Size(600, 32);
            lblAttendanceTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblAttendanceTitle.Text = "Attendance";
            //
            // lblAttendanceSubtitle
            //
            lblAttendanceSubtitle.Location = new Point(26, 56);
            lblAttendanceSubtitle.Size = new Size(800, 24);
            lblAttendanceSubtitle.Text = "Select an event and mark a participant's attendance.";
            //
            // lblAttendanceEvent
            //
            lblAttendanceEvent.Location = new Point(26, 100);
            lblAttendanceEvent.Size = new Size(100, 24);
            lblAttendanceEvent.Text = "Event";
            //
            // cmbAttendanceEvent
            //
            cmbAttendanceEvent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAttendanceEvent.Location = new Point(26, 126);
            cmbAttendanceEvent.Size = new Size(440, 30);
            cmbAttendanceEvent.DisplayMember = "Title";
            cmbAttendanceEvent.SelectedIndexChanged += AttendanceEventSelector_SelectedIndexChanged;
            //
            // btnMarkPresent
            //
            btnMarkPresent.Location = new Point(590, 122);
            btnMarkPresent.Size = new Size(115, 36);
            btnMarkPresent.Text = "Mark Present";
            btnMarkPresent.Tag = HahuEvents.Desktop.Models.AttendanceStatus.Present;
            btnMarkPresent.BackColor = Color.FromArgb(36, 87, 197);
            btnMarkPresent.ForeColor = Color.White;
            btnMarkPresent.FlatStyle = FlatStyle.Flat;
            btnMarkPresent.Click += SetSelectedAttendance_Click;
            //
            // btnMarkAbsent
            //
            btnMarkAbsent.Location = new Point(715, 122);
            btnMarkAbsent.Size = new Size(115, 36);
            btnMarkAbsent.Text = "Mark Absent";
            btnMarkAbsent.Tag = HahuEvents.Desktop.Models.AttendanceStatus.Absent;
            btnMarkAbsent.BackColor = Color.FromArgb(36, 87, 197);
            btnMarkAbsent.ForeColor = Color.White;
            btnMarkAbsent.FlatStyle = FlatStyle.Flat;
            btnMarkAbsent.Click += SetSelectedAttendance_Click;
            //
            // btnClearAttendance
            //
            btnClearAttendance.Location = new Point(840, 122);
            btnClearAttendance.Size = new Size(100, 36);
            btnClearAttendance.Text = "Clear Mark";
            btnClearAttendance.Tag = HahuEvents.Desktop.Models.AttendanceStatus.NotMarked;
            btnClearAttendance.BackColor = Color.FromArgb(36, 87, 197);
            btnClearAttendance.ForeColor = Color.White;
            btnClearAttendance.FlatStyle = FlatStyle.Flat;
            btnClearAttendance.Click += SetSelectedAttendance_Click;
            //
            // lblAttendanceSummary
            //
            lblAttendanceSummary.Location = new Point(26, 165);
            lblAttendanceSummary.Size = new Size(900, 24);
            lblAttendanceSummary.ForeColor = Color.FromArgb(91, 111, 145);
            //
            // dgvAttendance
            //
            dgvAttendance.Location = new Point(24, 195);
            dgvAttendance.Size = new Size(916, 320);
            dgvAttendance.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAttendance.BackgroundColor = Color.White;
            dgvAttendance.BorderStyle = BorderStyle.FixedSingle;
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.AllowUserToDeleteRows = false;
            dgvAttendance.ReadOnly = true;
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.MultiSelect = false;
            dgvAttendance.RowHeadersVisible = false;
            dgvAttendance.Columns.Add("Participant", "Participant");
            dgvAttendance.Columns.Add("Email", "Email");
            dgvAttendance.Columns.Add("Attendance", "Attendance");
            dgvAttendance.Columns.Add("Registered", "Registered");
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
            pnlReports.Visible = false;
            //
            // lblReportsTitle
            //
            lblReportsTitle.Location = new Point(24, 20);
            lblReportsTitle.Size = new Size(600, 32);
            lblReportsTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblReportsTitle.Text = "My Reports";
            //
            // lblReportsSubtitle
            //
            lblReportsSubtitle.Location = new Point(26, 56);
            lblReportsSubtitle.Size = new Size(800, 24);
            lblReportsSubtitle.Text = "Registration and attendance totals for your events.";
            //
            // lblReportSummary
            //
            lblReportSummary.Location = new Point(26, 82);
            lblReportSummary.Size = new Size(900, 24);
            lblReportSummary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            //
            // dgvReports
            //
            dgvReports.Location = new Point(24, 115);
            dgvReports.Size = new Size(916, 400);
            dgvReports.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReports.BackgroundColor = Color.White;
            dgvReports.BorderStyle = BorderStyle.FixedSingle;
            dgvReports.AllowUserToAddRows = false;
            dgvReports.AllowUserToDeleteRows = false;
            dgvReports.ReadOnly = true;
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReports.MultiSelect = false;
            dgvReports.RowHeadersVisible = false;
            dgvReports.Columns.Add("Event", "Event");
            dgvReports.Columns.Add("Registrations", "Registrations");
            dgvReports.Columns.Add("Present", "Present");
            dgvReports.Columns.Add("Absent", "Absent");
            dgvReports.Columns.Add("NotMarked", "Not Marked");
            dgvReports.Columns.Add("AttendanceRate", "Attendance Rate");
            dgvReports.Columns.Add("Status", "Event Status");
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

            // lblMyEventsTitle

            lblMyEventsTitle.Location = new Point(0, 0);
            lblMyEventsTitle.Name = "lblMyEventsTitle";
            lblMyEventsTitle.Size = new Size(100, 23);
            lblMyEventsTitle.TabIndex = 0;

            // lblPublishedTitle

            lblPublishedTitle.Location = new Point(0, 0);
            lblPublishedTitle.Name = "lblPublishedTitle";
            lblPublishedTitle.Size = new Size(100, 23);
            lblPublishedTitle.TabIndex = 0;

            // lblRegistrationsTitle

            lblRegistrationsTitle.Location = new Point(0, 0);
            lblRegistrationsTitle.Name = "lblRegistrationsTitle";
            lblRegistrationsTitle.Size = new Size(100, 23);
            lblRegistrationsTitle.TabIndex = 0;

            // lblUpcomingTitle

            lblUpcomingTitle.Location = new Point(0, 0);
            lblUpcomingTitle.Name = "lblUpcomingTitle";
            lblUpcomingTitle.Size = new Size(100, 23);
            lblUpcomingTitle.TabIndex = 0;

            // lblMyEventsCount

            lblMyEventsCount.Location = new Point(0, 0);
            lblMyEventsCount.Name = "lblMyEventsCount";
            lblMyEventsCount.Size = new Size(100, 23);
            lblMyEventsCount.TabIndex = 0;

            // lblPublishedEventsCount

            lblPublishedEventsCount.Location = new Point(0, 0);
            lblPublishedEventsCount.Name = "lblPublishedEventsCount";
            lblPublishedEventsCount.Size = new Size(100, 23);
            lblPublishedEventsCount.TabIndex = 0;

            // lblTotalRegistrations

            lblTotalRegistrations.Location = new Point(0, 0);
            lblTotalRegistrations.Name = "lblTotalRegistrations";
            lblTotalRegistrations.Size = new Size(100, 23);
            lblTotalRegistrations.TabIndex = 0;

            // lblUpcomingEventsCount

            lblUpcomingEventsCount.Location = new Point(0, 0);
            lblUpcomingEventsCount.Name = "lblUpcomingEventsCount";
            lblUpcomingEventsCount.Size = new Size(100, 23);
            lblUpcomingEventsCount.TabIndex = 0;

            // dataGridViewTextBoxColumn1

            dataGridViewTextBoxColumn1.HeaderText = "Event ID";
            dataGridViewTextBoxColumn1.Name = "EventID";
            dataGridViewTextBoxColumn1.ReadOnly = true;

            // dataGridViewTextBoxColumn2

            dataGridViewTextBoxColumn2.HeaderText = "Event Title";
            dataGridViewTextBoxColumn2.Name = "EventTitle";
            dataGridViewTextBoxColumn2.ReadOnly = true;

            // dataGridViewTextBoxColumn3

            dataGridViewTextBoxColumn3.HeaderText = "Event Date";
            dataGridViewTextBoxColumn3.Name = "EventDate";
            dataGridViewTextBoxColumn3.ReadOnly = true;

            // dataGridViewTextBoxColumn4

            dataGridViewTextBoxColumn4.HeaderText = "Location";
            dataGridViewTextBoxColumn4.Name = "Location";
            dataGridViewTextBoxColumn4.ReadOnly = true;

            // dataGridViewTextBoxColumn5
            //
            dataGridViewTextBoxColumn5.HeaderText = "Capacity";
            dataGridViewTextBoxColumn5.Name = "Capacity";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            //
            // dataGridViewTextBoxColumn6
            //
            dataGridViewTextBoxColumn6.HeaderText = "Registered";
            dataGridViewTextBoxColumn6.Name = "Registered";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            //
            // dataGridViewTextBoxColumn7
            //
            dataGridViewTextBoxColumn7.HeaderText = "Status";
            dataGridViewTextBoxColumn7.Name = "Status";
            dataGridViewTextBoxColumn7.ReadOnly = true;
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
            pnlRegistrations.ResumeLayout(false);
            pnlAttendance.ResumeLayout(false);
            pnlReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMyEvents).EndInit();
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
    }
}
