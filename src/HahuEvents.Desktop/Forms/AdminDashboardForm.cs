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
    public partial class AdminDashboardForm : Form
    {
        private allevent? _allEventsForm;
        private readonly InMemoryEventService _eventService = InMemoryEventService.Instance;
        private IReadOnlyList<Event> _dashboardEvents => _eventService.Events;

        public AdminDashboardForm()
        {
            InitializeComponent();
            ConfigureDashboardFilters();
        }

        private void ConfigureDashboardFilters()
        {
            pnlEventFilters.BackColor = Color.FromArgb(245, 248, 250);
            pnlEventFilters.BorderStyle = BorderStyle.FixedSingle;
            pnlEventFilters.Padding = new Padding(10);
            pnlEventFilters.Height = 88;

            txtSearchEvent.SetBounds(16, 39, 170, 27);
            cmbOrganizerFilter.SetBounds(194, 39, 150, 28);
            cmbStatusFilter.SetBounds(352, 39, 120, 28);
            dtpStartDate.SetBounds(480, 39, 115, 27);
            dtpEndDate.SetBounds(603, 39, 115, 27);
            dtpStartDate.ShowCheckBox = true;
            dtpEndDate.ShowCheckBox = true;
            btnSearch.SetBounds(726, 39, 80, 30);
            btnReset.SetBounds(814, 39, 80, 30);

            AddDashboardFilterLabel("Search:", new Point(16, 12));
            AddDashboardFilterLabel("Organizer", new Point(194, 12));
            AddDashboardFilterLabel("Status", new Point(352, 12));
            AddDashboardFilterLabel("Start Date", new Point(480, 12));
            AddDashboardFilterLabel("End Date", new Point(603, 12));

            label5.Text = "Total Organizers";
            label6.Text = "Total Events";
            label8.Text = "Cancelled Events";
        }

        private void AddDashboardFilterLabel(string text, Point location)
        {
            pnlEventFilters.Controls.Add(new Label
            {
                AutoSize = true,
                Location = location,
                Text = text
            });
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            LoadDashboardOrganizerOptions();
            DisplayDashboardEvents(_dashboardEvents);
            UpdateSummaryCards();
            ShowDashboardView();
        }

        private void UpdateSummaryCards()
        {
            int totalOrganizers = _dashboardEvents.Select(row => row.OrganizerId).Distinct().Count();
            int totalEvents = _dashboardEvents.Count;
            int publishedEvents = _dashboardEvents.Count(row => row.Status == EventStatus.Published);
            int cancelledEvents = _dashboardEvents.Count(row => row.Status == EventStatus.Cancelled);

            label9.Text = totalOrganizers.ToString();
            label10.Text = totalEvents.ToString();
            label11.Text = publishedEvents.ToString();
            label12.Text = cancelledEvents.ToString();
        }

        private void LoadDashboardOrganizerOptions()
        {
            cmbOrganizerFilter.Items.Clear();
            cmbOrganizerFilter.Items.Add("All Organizers");

            foreach (string organizer in _dashboardEvents
                .Select(row => _eventService.GetOrganizerName(row.OrganizerId))
                .Distinct())
            {
                cmbOrganizerFilter.Items.Add(organizer);
            }

            cmbOrganizerFilter.SelectedIndex = 0;
            if (cmbStatusFilter.Items.Count > 0)
            {
                cmbStatusFilter.SelectedIndex = 0;
            }
        }

        private void DisplayDashboardEvents(IEnumerable<Event> rows)
        {
            List<Event> displayedEvents = rows.ToList();
            dgvAllEvents.Rows.Clear();

            foreach (Event row in displayedEvents)
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

                    lblFooter.Text = $"Showing {displayedEvents.Count} of {_dashboardEvents.Count} events";
        }

        public void ShowDashboardView()
        {
            if (_allEventsForm != null)
            {
                _allEventsForm.Visible = false;
            }

            pnlALLEvents.Visible = true;
            pnlALLEvents.BringToFront();

            label2.Text = "Administrator Dashboard";
            label3.Text = "Monitor events,organizers and system activity";

            button1.BackColor = Color.FromArgb(36, 87, 197);
            button1.ForeColor = Color.White;

            button2.BackColor = Color.White;
            button2.ForeColor = Color.FromArgb(102, 112, 133);
        }

        public void ShowAllEventsView()
        {
            pnlALLEvents.Visible = false;

            if (_allEventsForm == null || _allEventsForm.IsDisposed)
            {
                _allEventsForm = new allevent
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                pnlContent.Controls.Add(_allEventsForm);
            }

            _allEventsForm.Visible = true;
            _allEventsForm.BringToFront();
            _allEventsForm.Show();

            label2.Text = "All Events";
            label3.Text = "View and filter all system events";

            button2.BackColor = Color.FromArgb(36, 87, 197);
            button2.ForeColor = Color.White;

            button1.BackColor = Color.White;
            button1.ForeColor = Color.FromArgb(102, 112, 133);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowDashboardView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowAllEventsView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // If the user clicks button3 or if labeled All Events / Organizers
            if (string.Equals(button3.Text, "All Events", StringComparison.OrdinalIgnoreCase))
            {
                ShowAllEventsView();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowDashboardView();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ShowDashboardView();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            ShowAllEventsView();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ShowAllEventsView();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            ShowAllEventsView();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearchEvent.Text.Trim();
            if (string.Equals(search, "Search title or location", StringComparison.OrdinalIgnoreCase))
            {
                search = string.Empty;
            }

            string organizer = cmbOrganizerFilter.SelectedItem?.ToString() ?? "All Organizers";
            string status = cmbStatusFilter.SelectedItem?.ToString() ?? "All";

            IEnumerable<Event> filteredRows = _dashboardEvents.Where(row =>
                (string.IsNullOrWhiteSpace(search) || row.Title.Contains(search, StringComparison.OrdinalIgnoreCase) || row.Location.Contains(search, StringComparison.OrdinalIgnoreCase)) &&
                (organizer == "All Organizers" || _eventService.GetOrganizerName(row.OrganizerId) == organizer) &&
                (status == "All" || row.Status.ToString() == status) &&
                (!dtpStartDate.Checked || row.Date.Date >= dtpStartDate.Value.Date) &&
                (!dtpEndDate.Checked || row.Date.Date <= dtpEndDate.Value.Date));

            DisplayDashboardEvents(filteredRows);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearchEvent.Text = string.Empty;
            cmbOrganizerFilter.SelectedIndex = 0;
            if (cmbStatusFilter.Items.Count > 0)
            {
                cmbStatusFilter.SelectedIndex = 0;
            }
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
            dtpStartDate.Checked = false;
            dtpEndDate.Checked = false;
            DisplayDashboardEvents(_dashboardEvents);
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

        private void dgvAllEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
