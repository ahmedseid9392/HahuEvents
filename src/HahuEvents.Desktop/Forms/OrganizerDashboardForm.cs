
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using HahuEvents.Desktop.Models;
using HahuEvents.Desktop.Services;

namespace HahuEvents.Desktop.Forms
{
    public partial class OrganizerDashboardForm : Form
    {
        private readonly InMemoryEventService _eventService = InMemoryEventService.Instance;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CurrentOrganizerId { get; set; }

        public OrganizerDashboardForm()

        {
            InitializeComponent();
            ConfigureDashboardAppearance();
            ConfigureEventContextMenu();
            Load += OrganizerDashboardForm_Load;
            dgvMyEvents.CellDoubleClick += dgvMyEvents_CellDoubleClick;

            // Set initial filter values.
            cmbStatusFilter.Items.AddRange(new object[]
            {
                "All",
                "Draft",
                "Published",
                "Cancelled"
            });

            cmbStatusFilter.SelectedIndex = 0;

            // Prevent the user from manually adding rows.
            dgvMyEvents.AllowUserToAddRows = false;
            dgvMyEvents.ReadOnly = true;
            dgvMyEvents.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvMyEvents.MultiSelect = false;
            dgvMyEvents.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void OrganizerDashboardForm_Load(object? sender, EventArgs e)
        {
            PopulateEventSelectors();
            LoadOrganizerEvents();
        }

        private void LoadOrganizerEvents()
        {
            dgvMyEvents.Rows.Clear();

            if (CurrentOrganizerId <= 0)
            {
                UpdateSummaryCards(Array.Empty<Event>());
                return;
            }

            Event[] organizerEvents = _eventService.Events
                .Where(eventItem => eventItem.OrganizerId == CurrentOrganizerId)
                .OrderBy(eventItem => eventItem.Date)
                .ToArray();

            foreach (Event eventItem in organizerEvents)
            {
                int rowIndex = dgvMyEvents.Rows.Add(
                    $"EVT-{eventItem.Id:D3}",
                    eventItem.Title,
                    eventItem.Date.ToString("MMM dd, yyyy h:mm tt"),
                    eventItem.Location,
                    eventItem.Capacity,
                    _eventService.GetRegistrationCount(eventItem.Id),
                    eventItem.Status);
                dgvMyEvents.Rows[rowIndex].Tag = eventItem;
            }

            UpdateSummaryCards(organizerEvents);
            ApplyEventFilters();
        }

        private void UpdateSummaryCards(IEnumerable<Event> events)
        {
            Event[] organizerEvents = events.ToArray();
            lblMyEventsCount.Text = organizerEvents.Length.ToString();
            lblPublishedEventsCount.Text = organizerEvents
                .Count(eventItem => eventItem.Status == EventStatus.Published)
                .ToString();
            lblTotalRegistrations.Text = organizerEvents
                .Sum(eventItem => _eventService.GetRegistrationCount(eventItem.Id))
                .ToString();
            lblUpcomingEventsCount.Text = organizerEvents
                .Count(eventItem => eventItem.Date >= DateTime.Now)
                .ToString();
        }

        private void ConfigureDashboardAppearance()
        {
            Color canvasColor = Color.FromArgb(245, 247, 251);

            BackColor = canvasColor;
            pnlSidebar.BackColor = Color.White;
            pnlHeader.BackColor = canvasColor;
            pnlSummary.BackColor = canvasColor;
            pnlMyEvents.BackColor = Color.White;

            AddSummaryCard(
                pnlSummary, 15, "My Events",
                lblMyEventsCount, "Events you created");
            AddSummaryCard(
                pnlSummary, 254, "Published Events",
                lblPublishedEventsCount, "Your live events");
            AddSummaryCard(
                pnlSummary, 493, "Total Registrations",
                lblTotalRegistrations, "Across your events");
            AddSummaryCard(
                pnlSummary, 732, "Upcoming Events",
                lblUpcomingEventsCount, "Events scheduled");

            lblDashboardTitle.Font = new Font(
                "Segoe UI", 18F, FontStyle.Bold);
            lblDashboardTitle.Location = new Point(20, 14);
            lblDashboardTitle.Size = new Size(600, 36);
            lblSubtitle.Location = new Point(22, 52);

            btnLogout.Visible = true;
            btnLogout.ForeColor = Color.FromArgb(170, 55, 55);

            dgvMyEvents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                AnchorStyles.Left | AnchorStyles.Right;
        }

        private void PopulateEventSelectors()
        {
            List<Event> publishedEvents = _eventService.Events
                .Where(eventItem =>
                    eventItem.OrganizerId == CurrentOrganizerId &&
                    eventItem.Status == EventStatus.Published)
                .OrderBy(eventItem => eventItem.Date)
                .ToList();

            cmbRegistrationEvent.DataSource = publishedEvents.ToList();
            cmbAttendanceEvent.DataSource = publishedEvents.ToList();
        }

        private void ConfigureEventContextMenu()
        {
            components ??= new Container();
            var contextMenu = new ContextMenuStrip(components);
            var editItem = new ToolStripMenuItem("Edit event");
            var deleteItem = new ToolStripMenuItem("Delete event");

            editItem.Click += EditSelectedEvent_Click;
            deleteItem.Click += DeleteSelectedEvent_Click;
            contextMenu.Items.Add(editItem);
            contextMenu.Items.Add(deleteItem);
            contextMenu.Opening += (_, e) =>
            {
                e.Cancel = dgvMyEvents.CurrentRow?.Tag is not Event;
            };

            dgvMyEvents.ContextMenuStrip = contextMenu;
            dgvMyEvents.MouseDown += dgvMyEvents_MouseDown;
        }

        private void ShowDashboardView()
        {
            pnlSummary.Visible = true;
            pnlMyEvents.Location = new Point(225, 252);
            pnlMyEvents.Size = new Size(967, 408);
            pnlMyEvents.Visible = true;
            HideOtherContentPanels();
            lblDashboardTitle.Text = "Organizer Dashboard";
            lblSubtitle.Text = "Manage Events and Participants";
            SetSelectedNavigationButton(btnDashboard);
        }

        private void ShowMyEventsView()
        {
            pnlSummary.Visible = false;
            pnlMyEvents.Location = new Point(225, 115);
            pnlMyEvents.Size = new Size(967, 545);
            pnlMyEvents.Visible = true;
            HideOtherContentPanels();
            lblDashboardTitle.Text = "My Events";
            lblSubtitle.Text = "View, edit, and manage your events";
            SetSelectedNavigationButton(btnMyEvents);
            LoadOrganizerEvents();
        }

        private void HideOtherContentPanels()
        {
            pnlRegistrations.Visible = false;
            pnlAttendance.Visible = false;
            pnlReports.Visible = false;
        }

        private void SetSelectedNavigationButton(Button selectedButton)
        {
            Color selectedColor = Color.FromArgb(36, 87, 197);
            Color idleTextColor = Color.FromArgb(91, 111, 145);

            foreach (Button button in new[]
            {
                btnDashboard,
                btnMyEvents,
                btnCreateEvent,
                btnRegistrations,
                btnAttendance,
                btnMyReports
            })
            {
                bool selected = button == selectedButton;
                button.BackColor = selected ? selectedColor : Color.White;
                button.ForeColor = selected ? Color.White : idleTextColor;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ApplyEventFilters();
        }

        private void ApplyEventFilters()
        {
            string searchText = txtSearchEvent.Text.Trim();
            string selectedStatus = cmbStatusFilter.Text;

            foreach (DataGridViewRow row in dgvMyEvents.Rows)
            {
                string title = Convert.ToString(
                    row.Cells["EventTitle"].Value) ?? "";

                string location = Convert.ToString(
                    row.Cells["Location"].Value) ?? "";

                string status = Convert.ToString(
                    row.Cells["Status"].Value) ?? "";

                bool matchesText =
                    string.IsNullOrWhiteSpace(searchText) ||
                    title.Contains(
                        searchText,
                        StringComparison.OrdinalIgnoreCase) ||
                    location.Contains(
                        searchText,
                        StringComparison.OrdinalIgnoreCase);

                bool matchesStatus =
                    selectedStatus == "All" ||
                    status.Equals(
                        selectedStatus,
                        StringComparison.OrdinalIgnoreCase);

                row.Visible = matchesText && matchesStatus;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearchEvent.Clear();
            cmbStatusFilter.SelectedIndex = 0;
            ApplyEventFilters();
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            if (CurrentOrganizerId <= 0)
            {
                MessageBox.Show("Please log in as an Organizer.");
                return;
            }

            using var eventForm = new OrganizerEventForm(CurrentOrganizerId);
            if (eventForm.ShowDialog(this) == DialogResult.OK &&
                eventForm.SavedEvent is Event savedEvent)
            {
                _eventService.SaveEvent(savedEvent);
                ShowMyEventsView();
            }
        }

        private void btnMyEvents_Click(object sender, EventArgs e)
        {
            ShowMyEventsView();
        }

        private void dgvMyEvents_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            DataGridView.HitTestInfo hit = dgvMyEvents.HitTest(e.X, e.Y);
            if (hit.RowIndex < 0)
            {
                dgvMyEvents.ClearSelection();
                dgvMyEvents.CurrentCell = null;
                return;
            }

            dgvMyEvents.ClearSelection();
            dgvMyEvents.Rows[hit.RowIndex].Selected = true;
            dgvMyEvents.CurrentCell = dgvMyEvents.Rows[hit.RowIndex].Cells[0];
        }

        private void btnRegistrations_Click(object sender, EventArgs e)
        {
            ShowRegistrationSection();
        }

        private void ShowRegistrationSection()
        {
            pnlSummary.Visible = false;
            pnlMyEvents.Visible = false;
            HideOtherContentPanels();
            PopulateEventSelectors();
            pnlRegistrations.Visible = true;

            lblDashboardTitle.Text = "Participant Registrations";
            lblSubtitle.Text = "View and register participants for your events";
            SetSelectedNavigationButton(btnRegistrations);
            RefreshRegistrationList();
        }

        private void RegistrationEventSelector_SelectedIndexChanged(
            object? sender,
            EventArgs e)
        {
            RefreshRegistrationList();
        }

        private void RefreshRegistrationList()
        {
            Event? selectedEvent =
                cmbRegistrationEvent.SelectedItem as Event;
            dgvRegistrations.Rows.Clear();

            if (selectedEvent == null)
            {
                lblRegistrationSummary.Text =
                    "You have no published events available for registration.";
                return;
            }

            lblRegistrationSummary.Text =
                $"{_eventService.GetRegistrationCount(selectedEvent.Id)} / " +
                $"{selectedEvent.Capacity} participants registered for " +
                $"{selectedEvent.Title}.";

            foreach (Registration registration in
                _eventService.GetRegistrationsForEvent(
                    selectedEvent.Id,
                    CurrentOrganizerId))
            {
                Participant? participant =
                    _eventService.GetParticipant(registration.ParticipantId);
                if (participant == null)
                {
                    continue;
                }

                dgvRegistrations.Rows.Add(
                    participant.FullName,
                    participant.Email,
                    participant.Phone,
                    registration.RegistrationDate.ToString("g"));
            }
        }

        private void RegisterParticipant_Click(object? sender, EventArgs e)
        {
            if (cmbRegistrationEvent.SelectedItem is not Event selectedEvent)
            {
                MessageBox.Show(
                    this,
                    "Select a published event first.",
                    "Registration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            using var registrationForm =
                new ParticipantRegistrationForm(selectedEvent);
            if (registrationForm.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            if (!_eventService.RegisterParticipant(
                selectedEvent.Id,
                CurrentOrganizerId,
                registrationForm.ParticipantName,
                registrationForm.Email,
                registrationForm.Phone,
                out string message))
            {
                MessageBox.Show(
                    this,
                    message,
                    "Registration Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            RefreshRegistrationList();
            LoadOrganizerEvents();
            MessageBox.Show(
                this,
                message,
                "Registration",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void dgvMyEvents_CellDoubleClick(
    object? sender,
    DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (CurrentOrganizerId <= 0)
            {
                MessageBox.Show("Please log in as an Organizer.");
                return;
            }

            var row = dgvMyEvents.Rows[e.RowIndex];
            if (row.Tag is not Event selectedEvent)
            {
                MessageBox.Show("Event details are unavailable.");
                return;
            }

            if (selectedEvent.OrganizerId != CurrentOrganizerId)
            {
                MessageBox.Show("You can only view your own events.");
                return;
            }

            MessageBox.Show(
                $"Event ID: EVT-{selectedEvent.Id:D3}\n" +
                $"Date: {selectedEvent.Date:MMM dd, yyyy h:mm tt}\n" +
                $"Location: {selectedEvent.Location}\n" +
                $"Capacity: {selectedEvent.Capacity}\n" +
                $"Registrations: {_eventService.GetRegistrationCount(selectedEvent.Id)}\n" +
                $"Status: {selectedEvent.Status}\n\n" +
                selectedEvent.Description,
                "Event Details",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private Event? GetSelectedEvent()
        {
            if (dgvMyEvents.CurrentRow?.Tag is not Event selectedEvent ||
                selectedEvent.OrganizerId != CurrentOrganizerId)
            {
                return null;
            }

            return selectedEvent;
        }

        private void EditSelectedEvent_Click(object? sender, EventArgs e)
        {
            Event? selectedEvent = GetSelectedEvent();
            if (selectedEvent == null)
            {
                return;
            }

            using var eventForm = new OrganizerEventForm(
                CurrentOrganizerId,
                selectedEvent);

            if (eventForm.ShowDialog(this) == DialogResult.OK &&
                eventForm.SavedEvent is Event updatedEvent)
            {
                _eventService.SaveEvent(updatedEvent);
                LoadOrganizerEvents();
            }
        }

        private void DeleteSelectedEvent_Click(object? sender, EventArgs e)
        {
            Event? selectedEvent = GetSelectedEvent();
            if (selectedEvent == null)
            {
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Delete '{selectedEvent.Title}'? This cannot be undone.",
                "Delete Event",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes &&
                _eventService.DeleteEvent(selectedEvent.Id, CurrentOrganizerId))
            {
                LoadOrganizerEvents();
            }
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            ShowAttendanceSection();
        }

        private void btnMyReports_Click(object sender, EventArgs e)
        {
            ShowReportsSection();
        }

        private void ShowAttendanceSection()
        {
            pnlSummary.Visible = false;
            pnlMyEvents.Visible = false;
            HideOtherContentPanels();
            PopulateEventSelectors();
            pnlAttendance.Visible = true;

            lblDashboardTitle.Text = "Attendance";
            lblSubtitle.Text = "Track attendance for your event participants";
            SetSelectedNavigationButton(btnAttendance);
            RefreshAttendanceList();
        }

        private void AttendanceEventSelector_SelectedIndexChanged(
            object? sender,
            EventArgs e)
        {
            RefreshAttendanceList();
        }

        private void RefreshAttendanceList()
        {
            if (cmbAttendanceEvent.SelectedItem is not Event eventItem)
            {
                dgvAttendance.Rows.Clear();
                lblAttendanceSummary.Text =
                    "No published events are available for attendance tracking.";
                return;
            }

            IReadOnlyList<Registration> registrations =
                _eventService.GetRegistrationsForEvent(
                    eventItem.Id,
                    CurrentOrganizerId);
            dgvAttendance.Rows.Clear();

            foreach (Registration registration in registrations)
            {
                Participant? participant =
                    _eventService.GetParticipant(registration.ParticipantId);
                int rowIndex = dgvAttendance.Rows.Add(
                    participant?.FullName ??
                        $"Participant #{registration.ParticipantId}",
                    participant?.Email ?? "—",
                    registration.AttendanceStatus,
                    registration.RegistrationDate.ToString("g"));
                dgvAttendance.Rows[rowIndex].Tag = registration;
            }

            int presentCount = registrations.Count(item =>
                item.AttendanceStatus == AttendanceStatus.Present);
            int absentCount = registrations.Count(item =>
                item.AttendanceStatus == AttendanceStatus.Absent);
            int unmarkedCount = registrations.Count(item =>
                item.AttendanceStatus == AttendanceStatus.NotMarked);
            lblAttendanceSummary.Text =
                $"{eventItem.Title}: {presentCount} present, {absentCount} absent, " +
                $"{unmarkedCount} not marked.";
        }

        private void SetSelectedAttendance_Click(object? sender, EventArgs e)
        {
            if (sender is not Button { Tag: AttendanceStatus attendanceStatus } ||
                cmbAttendanceEvent.SelectedItem is not Event eventItem ||
                dgvAttendance.CurrentRow?.Tag is not Registration registration)
            {
                MessageBox.Show(
                    this,
                    "Select a registered participant first.",
                    "Attendance",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!_eventService.SetAttendanceStatus(
                eventItem.Id,
                CurrentOrganizerId,
                registration.Id,
                attendanceStatus))
            {
                MessageBox.Show(
                    this,
                    "The participant's attendance could not be updated.",
                    "Attendance",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            RefreshAttendanceList();
        }

        private void ShowReportsSection()
        {
            pnlSummary.Visible = false;
            pnlMyEvents.Visible = false;
            HideOtherContentPanels();
            pnlReports.Visible = true;

            Event[] organizerEvents = _eventService.Events
                .Where(item => item.OrganizerId == CurrentOrganizerId)
                .OrderBy(item => item.Date)
                .ToArray();
            int totalRegistrations = 0;
            int totalPresent = 0;
            int totalAbsent = 0;

            dgvReports.Rows.Clear();

            foreach (Event eventItem in organizerEvents)
            {
                IReadOnlyList<Registration> registrations =
                    _eventService.GetRegistrationsForEvent(
                        eventItem.Id,
                        CurrentOrganizerId);
                int presentCount = registrations.Count(item =>
                    item.AttendanceStatus == AttendanceStatus.Present);
                int absentCount = registrations.Count(item =>
                    item.AttendanceStatus == AttendanceStatus.Absent);
                int unmarkedCount = registrations.Count(item =>
                    item.AttendanceStatus == AttendanceStatus.NotMarked);
                double attendanceRate = registrations.Count == 0
                    ? 0
                    : presentCount * 100.0 / registrations.Count;

                totalRegistrations += registrations.Count;
                totalPresent += presentCount;
                totalAbsent += absentCount;
                dgvReports.Rows.Add(
                    eventItem.Title,
                    registrations.Count,
                    presentCount,
                    absentCount,
                    unmarkedCount,
                    $"{attendanceRate:F1}%",
                    eventItem.Status);
            }

            lblReportSummary.Text =
                $"Events: {organizerEvents.Length}    " +
                $"Registrations: {totalRegistrations}    " +
                $"Present: {totalPresent}    Absent: {totalAbsent}";

            lblDashboardTitle.Text = "My Reports";
            lblSubtitle.Text = "Event registration and attendance summary";
            SetSelectedNavigationButton(btnMyReports);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                AuthService.Logout();
                Close();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowDashboardView();
        }
    }
}
