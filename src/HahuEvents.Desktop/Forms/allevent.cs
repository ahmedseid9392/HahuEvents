using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HahuEvents.Desktop.Models;
using HahuEvents.Desktop.Services;

namespace HahuEvents.Desktop.Forms
{
    public partial class allevent : Form
    {
        private readonly InMemoryEventService _eventService = InMemoryEventService.Instance;
        private IReadOnlyList<Event> eventRows => _eventService.Events;

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

            foreach (string organizer in eventRows
                .Select(row => _eventService.GetOrganizerName(row.OrganizerId))
                .Distinct())
            {
                cmbOrganizer.Items.Add(organizer);
            }

            cmbOrganizer.SelectedIndex = 0;
        }

        private void DisplayEvents(IEnumerable<Event> rows)
        {
            dgvAllEvents.Rows.Clear();

            foreach (Event row in rows)
            {
                dgvAllEvents.Rows.Add(
                    $"EVT-{row.Id:D3}",
                    row.Title,
                    _eventService.GetOrganizerName(row.OrganizerId),
                    row.Date.ToString("MMM dd, yyyy"),
                    row.Location,
                    row.Capacity,
                    _eventService.GetRegistrationCount(row.Id),
                    row.Status);
            }

            lblEventCount.Text = $"{dgvAllEvents.Rows.Count} total events";
            lblFooter.Text = $"Showing {dgvAllEvents.Rows.Count} of {eventRows.Count} events";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            string organizer = cmbOrganizer.SelectedItem?.ToString() ?? "All Organizers";
            string status = cmbStatus.SelectedItem?.ToString() ?? "All";

            IEnumerable<Event> filteredRows = eventRows.Where(row =>
                (string.IsNullOrWhiteSpace(search) || row.Title.Contains(search, StringComparison.OrdinalIgnoreCase) || row.Location.Contains(search, StringComparison.OrdinalIgnoreCase)) &&
                (organizer == "All Organizers" || _eventService.GetOrganizerName(row.OrganizerId) == organizer) &&
                (status == "All" || row.Status.ToString() == status) &&
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
    }
}
