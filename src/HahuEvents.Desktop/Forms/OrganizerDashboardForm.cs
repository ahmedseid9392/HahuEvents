
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using HahuEvents.Desktop.Models;
using HahuEvents.Desktop.Services;

namespace HahuEvents.Desktop.Forms
{
    public partial class OrganizerDashboardForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CurrentOrganizerId { get; set; }

        public OrganizerDashboardForm()

        {
            InitializeComponent();
            ConfigureDashboardAppearance();
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

            // Example summary values for UI testing.
            // Replace these with real service data later.
            lblMyEventsCount.Text = "12";
            lblPublishedEventsCount.Text = "8";
            lblTotalRegistrations.Text = "103";
            lblUpcomingEventsCount.Text = "13";
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
        }

        private void btnSearch_Click(object sender, EventArgs e)
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

            foreach (DataGridViewRow row in dgvMyEvents.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            // Connect this button to EventForm when it is implemented.
            MessageBox.Show(
                "The Create Event form will open here.",
                "Create Event",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnMyEvents_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are viewing My Events.");
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

            MessageBox.Show(
                $"{selectedEvent.Title}\n{selectedEvent.Date:d}\n{selectedEvent.Location}",
                "Event Details",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
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
            // Already on the dashboard.
        }
    }
}
