using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private Panel? _organizersPanel;
        private Panel? _reportsPanel;
        private DataGridView? _organizersGrid;
        private DataGridView? _reportsGrid;
        private readonly InMemoryEventService _eventService = InMemoryEventService.Instance;
        private IReadOnlyList<Event> _dashboardEvents => _eventService.Events;

        public AdminDashboardForm()
        {
            InitializeComponent();
            ConfigureDashboardFilters();
            ConfigureDashboardAppearance();
            button5.Click += button5_Click;
            button4.Click += button4_Click;
        }

        private void ConfigureDashboardAppearance()
        {
            Color canvasColor = Color.FromArgb(245, 247, 251);
            Color surfaceColor = Color.White;

            BackColor = canvasColor;
            pnlSidebar.BackColor = surfaceColor;
            pnlHeader.BackColor = canvasColor;
            pnlContent.BackColor = canvasColor;
            pnlSummaryCards.BackColor = canvasColor;
            pnlALLEvents.BackColor = surfaceColor;

            panel1.BackColor = surfaceColor;
            panel2.BackColor = surfaceColor;
            panel3.BackColor = surfaceColor;
            panel4.BackColor = surfaceColor;

            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(16, 5);
            label2.Size = new Size(420, 36);
            label3.Location = new Point(16, 46);

            foreach (Button button in new[] { button1, button2, button3, button4 })
            {
                button.Cursor = Cursors.Hand;
                button.FlatAppearance.BorderSize = 0;
                button.FlatStyle = FlatStyle.Flat;
                button.UseVisualStyleBackColor = false;
            }

            button5.Text = "Logout";
            button5.Dock = DockStyle.Bottom;
            button5.Height = 44;
            button5.Padding = new Padding(12, 0, 0, 0);
            button5.Visible = true;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.ForeColor = Color.FromArgb(170, 55, 55);
            button5.TextAlign = ContentAlignment.MiddleLeft;
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

            if (_organizersPanel != null)
            {
                _organizersPanel.Visible = false;
            }

            if (_reportsPanel != null)
            {
                _reportsPanel.Visible = false;
            }

            pnlALLEvents.Visible = true;
            pnlALLEvents.BringToFront();

            label2.Text = "Administrator Dashboard";
            label3.Text = "Monitor events,organizers and system activity";

            SetSelectedNavigationButton(button1);
        }

        public void ShowAllEventsView()
        {
            pnlALLEvents.Visible = false;
            HideManagementViews();

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

            SetSelectedNavigationButton(button2);
        }

        private void ShowOrganizerManagementView()
        {
            pnlALLEvents.Visible = false;
            HideManagementViews();

            _organizersPanel ??= CreateOrganizerManagementPanel();
            if (_organizersPanel.Parent != pnlContent)
            {
                pnlContent.Controls.Add(_organizersPanel);
            }

            RefreshOrganizerGrid();
            _organizersPanel.Visible = true;
            _organizersPanel.BringToFront();
            label2.Text = "Manage Organizers";
            label3.Text = "Create organizer accounts and manage access";
            SetSelectedNavigationButton(button3);
        }

        private void ShowSystemReportsView()
        {
            pnlALLEvents.Visible = false;
            HideManagementViews();

            _reportsPanel ??= CreateSystemReportsPanel();
            if (_reportsPanel.Parent != pnlContent)
            {
                pnlContent.Controls.Add(_reportsPanel);
            }

            RefreshSystemReport();
            _reportsPanel.Visible = true;
            _reportsPanel.BringToFront();
            label2.Text = "System Reports";
            label3.Text = "Review event activity and registration totals";
            SetSelectedNavigationButton(button4);
        }

        private void HideManagementViews()
        {
            if (_allEventsForm != null)
            {
                _allEventsForm.Visible = false;
            }

            if (_organizersPanel != null)
            {
                _organizersPanel.Visible = false;
            }

            if (_reportsPanel != null)
            {
                _reportsPanel.Visible = false;
            }
        }

        private void SetSelectedNavigationButton(Button selectedButton)
        {
            foreach (Button button in new[] { button1, button2, button3, button4 })
            {
                bool selected = button == selectedButton;
                button.BackColor = selected
                    ? Color.FromArgb(36, 87, 197)
                    : Color.White;
                button.ForeColor = selected
                    ? Color.White
                    : Color.FromArgb(102, 112, 133);
            }
        }

        private Panel CreateOrganizerManagementPanel()
        {
            var page = new Panel
            {
                BackColor = Color.White,
                Dock = DockStyle.Fill
            };
            var header = new Panel
            {
                BackColor = Color.White,
                Dock = DockStyle.Top,
                Height = 96
            };
            header.Controls.Add(new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.FromArgb(102, 112, 133),
                Location = new Point(20, 14),
                Text = "Organizer accounts can be activated or deactivated at any time."
            });

            var addOrganizerButton = new Button
            {
                BackColor = Color.FromArgb(36, 87, 197),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                Location = new Point(20, 49),
                Size = new Size(145, 34),
                Text = "Add Organizer",
                UseVisualStyleBackColor = false
            };
            addOrganizerButton.FlatAppearance.BorderSize = 0;
            addOrganizerButton.Click += AddOrganizerButton_Click;
            header.Controls.Add(addOrganizerButton);

            var grid = CreateAdminGrid();
            grid.Columns.Add("organizerId", "ID");
            grid.Columns.Add("organizerName", "Full Name");
            grid.Columns.Add("organizerUsername", "Username");
            grid.Columns.Add("organizerEvents", "Events");
            grid.Columns.Add("organizerStatus", "Account Status");
            grid.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "Access",
                Name = "organizerAction",
                Text = "Change Status",
                UseColumnTextForButtonValue = false
            });
            grid.CellContentClick += OrganizerGrid_CellContentClick;
            _organizersGrid = grid;

            var footer = new Label
            {
                Dock = DockStyle.Bottom,
                ForeColor = Color.FromArgb(102, 112, 133),
                Height = 36,
                Text = "Deactivated organizers cannot sign in. Existing events and registrations are preserved.",
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(16, 0, 0, 0)
            };

            page.Controls.Add(grid);
            page.Controls.Add(footer);
            page.Controls.Add(header);
            return page;
        }

        private void RefreshOrganizerGrid()
        {
            if (_organizersGrid == null)
            {
                return;
            }

            _organizersGrid.Rows.Clear();
            foreach (User organizer in AuthService.GetOrganizers())
            {
                int rowIndex = _organizersGrid.Rows.Add(
                    $"ORG-{organizer.Id:D3}",
                    organizer.FullName,
                    organizer.Username,
                    _dashboardEvents.Count(eventItem =>
                        eventItem.OrganizerId == organizer.Id),
                    organizer.IsActive ? "Active" : "Inactive",
                    organizer.IsActive ? "Deactivate" : "Activate");
                _organizersGrid.Rows[rowIndex].Tag = organizer.Id;
            }
        }

        private void AddOrganizerButton_Click(object? sender, EventArgs e)
        {
            using var dialog = new Form
            {
                AcceptButton = null,
                CancelButton = null,
                ClientSize = new Size(390, 250),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                StartPosition = FormStartPosition.CenterParent,
                Text = "Add Organizer"
            };

            var nameInput = new TextBox { Location = new Point(142, 25), Width = 220 };
            var usernameInput = new TextBox { Location = new Point(142, 70), Width = 220 };
            var passwordInput = new TextBox
            {
                Location = new Point(142, 115),
                UseSystemPasswordChar = true,
                Width = 220
            };
            dialog.Controls.AddRange(new Control[]
            {
                new Label { Location = new Point(24, 28), Text = "Full name", AutoSize = true },
                nameInput,
                new Label { Location = new Point(24, 73), Text = "Username", AutoSize = true },
                usernameInput,
                new Label { Location = new Point(24, 118), Text = "Password", AutoSize = true },
                passwordInput
            });

            var saveButton = new Button
            {
                Location = new Point(142, 170),
                Size = new Size(105, 34),
                Text = "Create"
            };
            saveButton.Click += (_, _) =>
            {
                if (!AuthService.RegisterOrganizer(
                    nameInput.Text,
                    usernameInput.Text,
                    passwordInput.Text,
                    out string message))
                {
                    MessageBox.Show(
                        dialog,
                        message,
                        "Could Not Create Organizer",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                dialog.DialogResult = DialogResult.OK;
                dialog.Close();
            };

            var cancelButton = new Button
            {
                Location = new Point(257, 170),
                Size = new Size(105, 34),
                Text = "Cancel"
            };
            cancelButton.Click += (_, _) =>
            {
                dialog.DialogResult = DialogResult.Cancel;
                dialog.Close();
            };
            dialog.Controls.Add(saveButton);
            dialog.Controls.Add(cancelButton);
            dialog.AcceptButton = saveButton;
            dialog.CancelButton = cancelButton;

            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                RefreshOrganizerGrid();
                UpdateSummaryCards();
            }
        }

        private void OrganizerGrid_CellContentClick(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            if (_organizersGrid == null ||
                e.RowIndex < 0 ||
                _organizersGrid.Columns[e.ColumnIndex].Name != "organizerAction" ||
                _organizersGrid.Rows[e.RowIndex].Tag is not int organizerId)
            {
                return;
            }

            User? organizer = AuthService.GetOrganizer(organizerId);
            if (organizer == null)
            {
                return;
            }

            bool newStatus = !organizer.IsActive;
            if (!newStatus &&
                MessageBox.Show(
                    this,
                    $"Deactivate {organizer.FullName}'s account?",
                    "Confirm Deactivation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            if (!AuthService.SetOrganizerActive(organizerId, newStatus))
            {
                MessageBox.Show(
                    this,
                    "The organizer account could not be updated.",
                    "Update Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            RefreshOrganizerGrid();
        }

        private Panel CreateSystemReportsPanel()
        {
            var page = new Panel
            {
                BackColor = Color.White,
                Dock = DockStyle.Fill
            };
            var header = new Panel
            {
                BackColor = Color.White,
                Dock = DockStyle.Top,
                Height = 112
            };
            header.Controls.Add(new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.FromArgb(102, 112, 133),
                Location = new Point(20, 12),
                Text = "Current totals across all events in the system."
            });

            var exportButton = new Button
            {
                Location = new Point(20, 48),
                Size = new Size(130, 32),
                Text = "Export CSV"
            };
            exportButton.Click += ExportSystemReport_Click;
            header.Controls.Add(exportButton);

            var metrics = new FlowLayoutPanel
            {
                BackColor = Color.FromArgb(245, 247, 251),
                Dock = DockStyle.Top,
                Height = 84,
                Padding = new Padding(14, 8, 0, 0),
                WrapContents = false
            };
            foreach (string title in new[]
                { "Organizer Accounts", "Total Events", "Registrations", "Published Events" })
            {
                var card = new Panel
                {
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(0, 0, 14, 0),
                    Size = new Size(190, 64),
                    Tag = title
                };
                card.Controls.Add(new Label
                {
                    AutoSize = true,
                    ForeColor = Color.FromArgb(102, 112, 133),
                    Location = new Point(12, 7),
                    Text = title
                });
                card.Controls.Add(new Label
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI", 15F, FontStyle.Bold),
                    Location = new Point(12, 29),
                    Name = "metricValue",
                    Text = "0"
                });
                metrics.Controls.Add(card);
            }

            var grid = CreateAdminGrid();
            grid.Columns.Add("reportEventId", "Event ID");
            grid.Columns.Add("reportTitle", "Event");
            grid.Columns.Add("reportOrganizer", "Organizer");
            grid.Columns.Add("reportDate", "Date");
            grid.Columns.Add("reportRegistrations", "Registrations");
            grid.Columns.Add("reportCapacity", "Capacity");
            grid.Columns.Add("reportStatus", "Status");
            _reportsGrid = grid;

            page.Controls.Add(grid);
            page.Controls.Add(metrics);
            page.Controls.Add(header);
            return page;
        }

        private static DataGridView CreateAdminGrid()
        {
            return new DataGridView
            {
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal,
                Dock = DockStyle.Fill,
                GridColor = Color.FromArgb(217, 223, 234),
                MultiSelect = false,
                ReadOnly = true,
                RowHeadersVisible = false,
                RowTemplate = { Height = 34 },
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };
        }

        private void RefreshSystemReport()
        {
            if (_reportsPanel == null || _reportsGrid == null)
            {
                return;
            }

            int[] values =
            {
                AuthService.GetOrganizers().Count,
                _dashboardEvents.Count,
                _dashboardEvents.Sum(eventItem =>
                    _eventService.GetRegistrationCount(eventItem.Id)),
                _dashboardEvents.Count(eventItem =>
                    eventItem.Status == EventStatus.Published)
            };
            int metricIndex = 0;
            foreach (Control control in _reportsPanel.Controls)
            {
                if (control is not FlowLayoutPanel metrics)
                {
                    continue;
                }

                foreach (Control card in metrics.Controls)
                {
                    Label? valueLabel = card.Controls
                        .OfType<Label>()
                        .FirstOrDefault(label => label.Name == "metricValue");
                    if (valueLabel != null && metricIndex < values.Length)
                    {
                        valueLabel.Text = values[metricIndex++].ToString();
                    }
                }
            }

            _reportsGrid.Rows.Clear();
            foreach (Event eventItem in _dashboardEvents.OrderBy(item => item.Date))
            {
                _reportsGrid.Rows.Add(
                    $"EVT-{eventItem.Id:D3}",
                    eventItem.Title,
                    _eventService.GetOrganizerName(eventItem.OrganizerId),
                    eventItem.Date.ToString("MMM dd, yyyy"),
                    _eventService.GetRegistrationCount(eventItem.Id),
                    eventItem.Capacity,
                    eventItem.Status);
            }
        }

        private void ExportSystemReport_Click(object? sender, EventArgs e)
        {
            using var dialog = new SaveFileDialog
            {
                AddExtension = true,
                DefaultExt = "csv",
                FileName = $"HahuEvents-System-Report-{DateTime.Today:yyyyMMdd}.csv",
                Filter = "CSV files (*.csv)|*.csv",
                OverwritePrompt = true
            };
            if (dialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            using var writer = new StreamWriter(dialog.FileName, false, new UTF8Encoding(true));
            writer.WriteLine("Event ID,Event,Organizer,Date,Registrations,Capacity,Status");
            foreach (Event eventItem in _dashboardEvents.OrderBy(item => item.Date))
            {
                writer.WriteLine(string.Join(",",
                    CsvEscape($"EVT-{eventItem.Id:D3}"),
                    CsvEscape(eventItem.Title),
                    CsvEscape(_eventService.GetOrganizerName(eventItem.OrganizerId)),
                    CsvEscape(eventItem.Date.ToString("yyyy-MM-dd")),
                    _eventService.GetRegistrationCount(eventItem.Id),
                    eventItem.Capacity,
                    eventItem.Status));
            }

            MessageBox.Show(
                this,
                "The system report was exported successfully.",
                "Export Complete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private static string CsvEscape(string value)
        {
            return $"\"{value.Replace("\"", "\"\"")}\"";
        }

        private void button4_Click(object? sender, EventArgs e)
        {
            ShowSystemReportsView();
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
            ShowOrganizerManagementView();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowDashboardView();
        }

        private void button5_Click(object? sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {
            ShowDashboardView();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ShowDashboardView();
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
            if (e.RowIndex < 0 ||
                dgvAllEvents.Columns[e.ColumnIndex].Name != "colViewDetails")
            {
                return;
            }

            string eventId = dgvAllEvents.Rows[e.RowIndex]
                .Cells["colEventId"].Value?.ToString() ?? string.Empty;
            Event? selectedEvent = _dashboardEvents.FirstOrDefault(row =>
                $"EVT-{row.Id:D3}" == eventId);

            if (selectedEvent == null)
            {
                return;
            }

            MessageBox.Show(
                $"Organizer: {_eventService.GetOrganizerName(selectedEvent.OrganizerId)}\n" +
                $"Date: {selectedEvent.Date:MMM dd, yyyy}\n" +
                $"Location: {selectedEvent.Location}\n" +
                $"Capacity: {selectedEvent.Capacity}\n" +
                $"Registrations: {_eventService.GetRegistrationCount(selectedEvent.Id)}\n" +
                $"Status: {selectedEvent.Status}",
                selectedEvent.Title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
