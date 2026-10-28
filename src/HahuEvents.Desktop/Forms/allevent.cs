using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HahuEvents.Desktop.Forms
{
    public partial class allevent : Form
    {
        private readonly List<EventRow> eventRows = new()
        {
            new("EVT-001", "Addis Ababa Tech Summit", "Nile Business Hub", new DateTime(2025, 6, 28), "Millennium Hall, Addis Ababa", 300, 245, "Published"),
            new("EVT-002", "Young Entrepreneurs Forum", "Nile Business Hub", new DateTime(2025, 7, 4), "Skylight Hotel, Addis Ababa", 250, 198, "Published"),
            new("EVT-003", "Ethiopian Coffee Expo", "Aster Events", new DateTime(2025, 7, 12), "Millennium Hall, Addis Ababa", 500, 0, "Draft"),
            new("EVT-004", "Digital Finance Conference", "Sheba Digital", new DateTime(2025, 7, 19), "Hyatt Regency, Addis Ababa", 320, 273, "Published"),
            new("EVT-005", "Hawassa Music Weekend", "Aster Events", new DateTime(2025, 8, 2), "Tabor Park, Hawassa", 750, 412, "Published"),
            new("EVT-006", "Designers Community Night", "Blue Nile Technologies", new DateTime(2025, 8, 8), "The Urban Center, Addis Ababa", 120, 38, "Cancelled"),
            new("EVT-007", "Bahir Dar Tourism Workshop", "Go Ethiopia", new DateTime(2025, 8, 16), "Kuriftu Resort, Bahir Dar", 90, 24, "Draft"),
            new("EVT-008", "Women in Leadership Summit", "Nile Business Hub", new DateTime(2025, 9, 6), "UNECA Conference Center", 400, 327, "Published")
        };

        public allevent()
        {
            InitializeComponent();
            LoadOrganizerOptions();
            DisplayEvents(eventRows);
        }

        private void LoadOrganizerOptions()
        {
            cmbOrganizer.Items.Clear();
            cmbOrganizer.Items.Add("All Organizers");

            foreach (string organizer in eventRows.Select(row => row.Organizer).Distinct())
            {
                cmbOrganizer.Items.Add(organizer);
            }

            cmbOrganizer.SelectedIndex = 0;
        }

        private void DisplayEvents(IEnumerable<EventRow> rows)
        {
            dgvAllEvents.Rows.Clear();

            foreach (EventRow row in rows)
            {
                dgvAllEvents.Rows.Add(row.Id, row.Title, row.Organizer, row.Date.ToString("MMM dd, yyyy"), row.Location, row.Capacity, row.Registrations, row.Status);
            }

            lblEventCount.Text = $"{dgvAllEvents.Rows.Count} total events";
            lblFooter.Text = $"Showing {dgvAllEvents.Rows.Count} of {eventRows.Count} events";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            string organizer = cmbOrganizer.SelectedItem?.ToString() ?? "All Organizers";
            string status = cmbStatus.SelectedItem?.ToString() ?? "All";

            IEnumerable<EventRow> filteredRows = eventRows.Where(row =>
                (string.IsNullOrWhiteSpace(search) || row.Title.Contains(search, StringComparison.OrdinalIgnoreCase) || row.Location.Contains(search, StringComparison.OrdinalIgnoreCase)) &&
                (organizer == "All Organizers" || row.Organizer == organizer) &&
                (status == "All" || row.Status == status) &&
                (!dtpStartDate.Checked || row.Date.Date >= dtpStartDate.Value.Date) &&
                (!dtpEndDate.Checked || row.Date.Date <= dtpEndDate.Value.Date));

            DisplayEvents(filteredRows);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbOrganizer.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
            dtpStartDate.Checked = false;
            dtpEndDate.Checked = false;
            DisplayEvents(eventRows);
            dgvAllEvents.ClearSelection();
        }

        private void dgvAllEvents_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || dgvAllEvents.Columns[e.ColumnIndex].Name != "colStatus")
            {
                return;
            }

            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            e.CellStyle.ForeColor = e.Value?.ToString() switch
            {
                "Published" => Color.FromArgb(35, 122, 64),
                "Cancelled" => Color.FromArgb(170, 55, 55),
                _ => Color.FromArgb(102, 112, 133)
            };
        }

        private sealed record EventRow(string Id, string Title, string Organizer, DateTime Date, string Location, int Capacity, int Registrations, string Status);
    }
}
