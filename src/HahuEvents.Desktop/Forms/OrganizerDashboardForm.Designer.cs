
namespace HahuEvents.Desktop.Forms
{
    partial class OrganizerDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Panel pnlQuickActions;
        private System.Windows.Forms.Panel pnlMyEvents;

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

        private System.Windows.Forms.Label lblQuickActionTitle;
        private System.Windows.Forms.Button btnQuickCreateEvent;
        private System.Windows.Forms.Button btnManageRegistrations;
        private System.Windows.Forms.Button btnMarkAttendance;
        private System.Windows.Forms.Button btnViewMyReport;

        private System.Windows.Forms.Label lblMyEventsSection;
        private System.Windows.Forms.Label lblMyEventsDescription;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblStatus;

        private System.Windows.Forms.TextBox txtSearchEvent;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvMyEvents;

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
            components = new System.ComponentModel.Container();

            pnlSidebar = new System.Windows.Forms.Panel();
            pnlHeader = new System.Windows.Forms.Panel();
            pnlSummary = new System.Windows.Forms.Panel();
            pnlQuickActions = new System.Windows.Forms.Panel();
            pnlMyEvents = new System.Windows.Forms.Panel();

            lblAppName = new System.Windows.Forms.Label();
            lblMenuTitle = new System.Windows.Forms.Label();
            lblDashboardTitle = new System.Windows.Forms.Label();
            lblSubtitle = new System.Windows.Forms.Label();
            lblWelcome = new System.Windows.Forms.Label();

            btnDashboard = new System.Windows.Forms.Button();
            btnMyEvents = new System.Windows.Forms.Button();
            btnCreateEvent = new System.Windows.Forms.Button();
            btnRegistrations = new System.Windows.Forms.Button();
            btnAttendance = new System.Windows.Forms.Button();
            btnMyReports = new System.Windows.Forms.Button();
            btnLogout = new System.Windows.Forms.Button();

            lblMyEventsTitle = new System.Windows.Forms.Label();
            lblPublishedTitle = new System.Windows.Forms.Label();
            lblRegistrationsTitle = new System.Windows.Forms.Label();
            lblUpcomingTitle = new System.Windows.Forms.Label();

            lblMyEventsCount = new System.Windows.Forms.Label();
            lblPublishedEventsCount = new System.Windows.Forms.Label();
            lblTotalRegistrations = new System.Windows.Forms.Label();
            lblUpcomingEventsCount = new System.Windows.Forms.Label();

            lblQuickActionTitle = new System.Windows.Forms.Label();
            btnQuickCreateEvent = new System.Windows.Forms.Button();
            btnManageRegistrations = new System.Windows.Forms.Button();
            btnMarkAttendance = new System.Windows.Forms.Button();
            btnViewMyReport = new System.Windows.Forms.Button();

            lblMyEventsSection = new System.Windows.Forms.Label();
            lblMyEventsDescription = new System.Windows.Forms.Label();
            lblSearch = new System.Windows.Forms.Label();
            lblStatus = new System.Windows.Forms.Label();

            txtSearchEvent = new System.Windows.Forms.TextBox();
            cmbStatusFilter = new System.Windows.Forms.ComboBox();
            btnSearch = new System.Windows.Forms.Button();
            btnReset = new System.Windows.Forms.Button();
            dgvMyEvents = new System.Windows.Forms.DataGridView();

            pnlSidebar.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlSummary.SuspendLayout();
            pnlQuickActions.SuspendLayout();
            pnlMyEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMyEvents).BeginInit();

            SuspendLayout();

            // Form
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1339, 687);
            MinimumSize = new System.Drawing.Size(1100, 650);
            Name = "OrganizerDashboardForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "OrganizerDashboardForm";
            Font = new System.Drawing.Font("Segoe UI", 9F);
            BackColor = System.Drawing.Color.FromArgb(245, 247, 251);

            // Sidebar
            pnlSidebar.BackColor = System.Drawing.Color.White;
            pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            pnlSidebar.Width = 200;
            pnlSidebar.Controls.Add(lblAppName);
            pnlSidebar.Controls.Add(lblMenuTitle);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(btnMyEvents);
            pnlSidebar.Controls.Add(btnCreateEvent);
            pnlSidebar.Controls.Add(btnRegistrations);
            pnlSidebar.Controls.Add(btnAttendance);
            pnlSidebar.Controls.Add(btnMyReports);
            pnlSidebar.Controls.Add(btnLogout);

            // App name
            lblAppName.AutoSize = false;
            lblAppName.Text = "▦  HahuEvents";
            lblAppName.Font = new System.Drawing.Font(
                "Segoe UI", 15F);
            lblAppName.ForeColor =
                System.Drawing.Color.FromArgb(91, 111, 145);
            lblAppName.Location = new System.Drawing.Point(12, 25);
            lblAppName.Size = new System.Drawing.Size(180, 42);

            // Sidebar menu title
            lblMenuTitle.AutoSize = false;
            lblMenuTitle.Text = "ORGANIZER MENU";
            lblMenuTitle.Font = new System.Drawing.Font(
                "Segoe UI", 8F);
            lblMenuTitle.ForeColor =
                System.Drawing.Color.FromArgb(102, 112, 133);
            lblMenuTitle.Location = new System.Drawing.Point(8, 103);
            lblMenuTitle.Size = new System.Drawing.Size(180, 25);

            // Sidebar buttons
            ConfigureNavButton(btnDashboard, "▣  Dashboard", 140, true);
            ConfigureNavButton(btnMyEvents, "▦  My Events", 207, false);
            ConfigureNavButton(btnCreateEvent, "+  Create Event", 272, false);
            ConfigureNavButton(btnRegistrations, "♟  Registrations", 337, false);
            ConfigureNavButton(btnAttendance, "●  Attendance", 402, false);
            ConfigureNavButton(btnMyReports, "▤  My Reports", 467, false);

            btnDashboard.Click += btnDashboard_Click;
            btnMyEvents.Click += btnMyEvents_Click;
            btnCreateEvent.Click += btnCreateEvent_Click;
            btnRegistrations.Click += btnRegistrations_Click;
            btnAttendance.Click += btnAttendance_Click;
            btnMyReports.Click += btnMyReports_Click;

            ConfigureNavButton(btnLogout, "↪  Logout", 640, false);
            btnLogout.Anchor =
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Bottom;
            btnLogout.ForeColor = System.Drawing.Color.Firebrick;
            btnLogout.Click += btnLogout_Click;

            // Header
            pnlHeader.Location = new System.Drawing.Point(200, 0);
            pnlHeader.Size = new System.Drawing.Size(1139, 115);
            pnlHeader.BackColor =
                System.Drawing.Color.FromArgb(245, 247, 251);
            pnlHeader.Controls.Add(lblDashboardTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblWelcome);

            lblDashboardTitle.AutoSize = false;
            lblDashboardTitle.Text = "Organizer Dashboard";
            lblDashboardTitle.Font = new System.Drawing.Font(
                "Segoe UI", 25F, System.Drawing.FontStyle.Regular);
            lblDashboardTitle.Location = new System.Drawing.Point(95, 12);
            lblDashboardTitle.Size = new System.Drawing.Size(600, 48);

            lblSubtitle.AutoSize = false;
            lblSubtitle.Text = "Manage Events and Participants";
            lblSubtitle.Location = new System.Drawing.Point(116, 65);
            lblSubtitle.Size = new System.Drawing.Size(350, 25);

            lblWelcome.AutoSize = false;
            lblWelcome.Text = "Welcome, Organizer";
            lblWelcome.TextAlign =
                System.Drawing.ContentAlignment.MiddleRight;
            lblWelcome.Location = new System.Drawing.Point(800, 25);
            lblWelcome.Size = new System.Drawing.Size(300, 30);

            // Summary cards container
            pnlSummary.Location = new System.Drawing.Point(225, 115);
            pnlSummary.Size = new System.Drawing.Size(967, 114);
            pnlSummary.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);

            AddSummaryCard(
                pnlSummary,
                20,
                "My Events",
                lblMyEventsCount,
                "Events you created");

            AddSummaryCard(
                pnlSummary,
                270,
                "Published Events",
                lblPublishedEventsCount,
                "Your live events");

            AddSummaryCard(
                pnlSummary,
                520,
                "Total Registrations",
                lblTotalRegistrations,
                "Across your events");

            AddSummaryCard(
                pnlSummary,
                770,
                "Upcoming Events",
                lblUpcomingEventsCount,
                "Events scheduled");

            // Quick actions
            pnlQuickActions.Location =
                new System.Drawing.Point(225, 252);
            pnlQuickActions.Size =
                new System.Drawing.Size(967, 64);
            pnlQuickActions.BackColor =
                System.Drawing.Color.FromArgb(224, 224, 224);

            pnlQuickActions.Controls.Add(lblQuickActionTitle);
            pnlQuickActions.Controls.Add(btnQuickCreateEvent);
            pnlQuickActions.Controls.Add(btnManageRegistrations);
            pnlQuickActions.Controls.Add(btnMarkAttendance);
            pnlQuickActions.Controls.Add(btnViewMyReport);

            lblQuickActionTitle.Text = "Quick actions";
            lblQuickActionTitle.Location =
                new System.Drawing.Point(15, 8);
            lblQuickActionTitle.Size =
                new System.Drawing.Size(145, 22);

            ConfigureActionButton(
                btnQuickCreateEvent, "+  Create New Event",
                180, 10, 140);

            ConfigureActionButton(
                btnManageRegistrations, "♟  Manage Registrations",
                345, 10, 160);

            ConfigureActionButton(
                btnMarkAttendance, "●  Mark Attendance",
                525, 10, 150);

            ConfigureActionButton(
                btnViewMyReport, "▤  View My Report",
                725, 10, 135);

            btnQuickCreateEvent.Click += btnCreateEvent_Click;
            btnManageRegistrations.Click += btnRegistrations_Click;
            btnMarkAttendance.Click += btnAttendance_Click;
            btnViewMyReport.Click += btnMyReports_Click;

            // My Events section
            pnlMyEvents.Location =
                new System.Drawing.Point(225, 325);
            pnlMyEvents.Size =
                new System.Drawing.Size(967, 335);
            pnlMyEvents.BackColor =
                System.Drawing.Color.FromArgb(245, 247, 251);

            pnlMyEvents.Controls.Add(lblMyEventsSection);
            pnlMyEvents.Controls.Add(lblMyEventsDescription);
            pnlMyEvents.Controls.Add(lblSearch);
            pnlMyEvents.Controls.Add(txtSearchEvent);
            pnlMyEvents.Controls.Add(lblStatus);
            pnlMyEvents.Controls.Add(cmbStatusFilter);
            pnlMyEvents.Controls.Add(btnSearch);
            pnlMyEvents.Controls.Add(btnReset);
            pnlMyEvents.Controls.Add(dgvMyEvents);

            lblMyEventsSection.Text = "My Events";
            lblMyEventsSection.Font = new System.Drawing.Font(
                "Segoe UI", 12F, System.Drawing.FontStyle.Regular);
            lblMyEventsSection.Location =
                new System.Drawing.Point(30, 8);
            lblMyEventsSection.Size =
                new System.Drawing.Size(200, 28);

            lblMyEventsDescription.Text =
                "View and manage events created by your account";
            lblMyEventsDescription.Location =
                new System.Drawing.Point(38, 38);
            lblMyEventsDescription.Size =
                new System.Drawing.Size(400, 23);

            lblSearch.Text = "Search";
            lblSearch.Location =
                new System.Drawing.Point(10, 75);
            lblSearch.Size = new System.Drawing.Size(100, 22);

            txtSearchEvent.Location =
                new System.Drawing.Point(10, 100);
            txtSearchEvent.Size =
                new System.Drawing.Size(197, 27);

            lblStatus.Text = "Status";
            lblStatus.Location =
                new System.Drawing.Point(275, 75);
            lblStatus.Size =
                new System.Drawing.Size(100, 22);

            cmbStatusFilter.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbStatusFilter.Location =
                new System.Drawing.Point(275, 100);
            cmbStatusFilter.Size =
                new System.Drawing.Size(160, 27);

            btnSearch.Text = "Search";
            btnSearch.Location =
                new System.Drawing.Point(465, 100);
            btnSearch.Size =
                new System.Drawing.Size(85, 27);
            btnSearch.Click += btnSearch_Click;

            btnReset.Text = "Reset";
            btnReset.Location =
                new System.Drawing.Point(650, 100);
            btnReset.Size =
                new System.Drawing.Size(85, 27);
            btnReset.Click += btnReset_Click;

            // Events table
            dgvMyEvents.Location =
                new System.Drawing.Point(0, 140);
            dgvMyEvents.Size =
                new System.Drawing.Size(930, 195);
            dgvMyEvents.BackgroundColor =
                System.Drawing.Color.White;
            dgvMyEvents.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            dgvMyEvents.RowHeadersWidth = 30;
            dgvMyEvents.AllowUserToAddRows = false;
            dgvMyEvents.AllowUserToDeleteRows = false;
            dgvMyEvents.ReadOnly = true;
            dgvMyEvents.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvMyEvents.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMyEvents.MultiSelect = false;

            dgvMyEvents.Columns.Add("EventID", "Event ID");
            dgvMyEvents.Columns.Add("EventTitle", "Event Title");
            dgvMyEvents.Columns.Add("EventDate", "Event Date");
            dgvMyEvents.Columns.Add("Location", "Location");
            dgvMyEvents.Columns.Add("Capacity", "Capacity");
            dgvMyEvents.Columns.Add("Registered", "Registered");
            dgvMyEvents.Columns.Add("Status", "Status");

            // Add main controls to the form
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSummary);
            Controls.Add(pnlQuickActions);
            Controls.Add(pnlMyEvents);

            pnlSidebar.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlSummary.ResumeLayout(false);
            pnlQuickActions.ResumeLayout(false);
            pnlMyEvents.ResumeLayout(false);
            pnlMyEvents.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)dgvMyEvents).EndInit();
            ResumeLayout(false);
        }

        private void ConfigureNavButton(
            System.Windows.Forms.Button button,
            string text,
            int top,
            bool selected)
        {
            button.Text = text;
            button.Location = new System.Drawing.Point(5, top);
            button.Size = new System.Drawing.Size(145, 42);
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 1;
            button.Font = new System.Drawing.Font("Segoe UI", 10F);
            button.TextAlign =
                System.Drawing.ContentAlignment.MiddleLeft;
            button.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            button.BackColor = selected
                ? System.Drawing.Color.FromArgb(36, 87, 197)
                : System.Drawing.Color.White;
            button.ForeColor = selected
                ? System.Drawing.Color.White
                : System.Drawing.Color.FromArgb(91, 111, 145);

            pnlSidebar.Controls.Add(button);
        }

        private void ConfigureActionButton(
            System.Windows.Forms.Button button,
            string text,
            int left,
            int top,
            int width)
        {
            button.Text = text;
            button.Location = new System.Drawing.Point(left, top);
            button.Size = new System.Drawing.Size(width, 42);
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.BackColor = System.Drawing.Color.White;
            button.ForeColor = System.Drawing.Color.Black;
            button.Font = new System.Drawing.Font("Segoe UI", 9F);
            button.FlatAppearance.BorderColor =
                System.Drawing.Color.Silver;

            button.UseVisualStyleBackColor = false;
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
    }
}
