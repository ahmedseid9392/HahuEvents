
using System;
using System.Windows.Forms;
using HahuEvents.Desktop.Models;

namespace HahuEvents.Desktop.Forms
{
    public partial class OrganizerDashboardForm : Form
    {
        private readonly int _currentOrganizerId;
        public OrganizerDashboardForm()

        {
            InitializeComponent();

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

            if (_currentOrganizerId <= 0)
            {
                MessageBox.Show("Please log in as an Organizer.");
                return;
            }

            var row = dgvMyEvents.Rows[e.RowIndex];
            Event? selectedEvent = row.Tag as Event;

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
                // Replace with your authentication/session logout logic.
                Close();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // Already on the dashboard.
        }
    }
}
