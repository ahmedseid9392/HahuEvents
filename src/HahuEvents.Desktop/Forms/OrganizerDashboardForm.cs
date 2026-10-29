
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
            pnlQuickActions.BackColor = canvasColor;
            pnlMyEvents.BackColor = Color.White;

            lblDashboardTitle.Font = new Font(
                "Segoe UI", 18F, FontStyle.Bold);
            lblDashboardTitle.Location = new Point(20, 14);
            lblDashboardTitle.Size = new Size(600, 36);
            lblSubtitle.Location = new Point(22, 52);

            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.Height = 48;
            btnLogout.Padding = new Padding(12, 0, 0, 0);
            btnLogout.Visible = true;
            btnLogout.ForeColor = Color.FromArgb(170, 55, 55);

            dgvMyEvents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                AnchorStyles.Left | AnchorStyles.Right;
            dgvMyEvents.Width = pnlMyEvents.ClientSize.Width;
            dgvMyEvents.Height = pnlMyEvents.ClientSize.Height - dgvMyEvents.Top;
        }

        private void ConfigureEventContextMenu()
        {
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
            pnlQuickActions.Visible = true;
            pnlMyEvents.Location = new Point(225, 325);
            pnlMyEvents.Size = new Size(967, 335);
            lblDashboardTitle.Text = "Organizer Dashboard";
            lblSubtitle.Text = "Manage Events and Participants";
            SetSelectedNavigationButton(btnDashboard);
        }

        private void ShowMyEventsView()
        {
            pnlSummary.Visible = false;
            pnlQuickActions.Visible = false;
            pnlMyEvents.Location = new Point(225, 115);
            pnlMyEvents.Size = new Size(967, 545);
            lblDashboardTitle.Text = "My Events";
            lblSubtitle.Text = "View, edit, and manage your events";
            SetSelectedNavigationButton(btnMyEvents);
            LoadOrganizerEvents();
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
                LoadOrganizerEvents();
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
            MessageBox.Show(
                "Connect this button to RegistrationsForm.");
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
            MessageBox.Show(
                "Connect this button to AttendanceForm.");
        }

        private void btnMyReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Connect this button to MyReportsForm.");
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
