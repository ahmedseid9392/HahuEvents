
using System;
using System.Windows.Forms;
using HahuEvents.Desktop.Models;

namespace HahuEvents.Desktop.Forms
{
    public partial class OrganizerEventForm : Form
    {
        private readonly int _organizerId;
        private readonly Event _existingEvent;

        private static int _nextEventId = 1;

        public Event SavedEvent { get; private set; }

        // Required for the Visual Studio Designer.
        public OrganizerEventForm()
        {
            InitializeComponent();
            ConfigureForm();
        }

        public OrganizerEventForm(int organizerId, Event existingEvent = null)
            : this()
        {
            if (organizerId <= 0)
            {
                throw new ArgumentException(
                    "A valid organizer ID is required.",
                    nameof(organizerId));
            }

            _organizerId = organizerId;
            _existingEvent = existingEvent;

            if (_existingEvent != null)
            {
                if (_existingEvent.OrganizerId != _organizerId)
                {
                    throw new UnauthorizedAccessException(
                        "You can only edit your own events.");
                }

                LoadEventDetails();
            }
        }

        private void ConfigureForm()
        {
            cmbEventStatus.Items.AddRange(new object[]
            {
                "Draft",
                "Published"
            });

            cmbEventStatus.SelectedIndex = 0;
            dtpEventDate.Format = DateTimePickerFormat.Custom;
            dtpEventDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpEventDate.ShowUpDown = true;

            if (_existingEvent == null)
            {
                Text = "Create Event";
                lblFormTitle.Text = "Create New Event";
                btnSaveEvent.Text = "Save Event";
            }
        }

        private void LoadEventDetails()
        {
            Text = "Edit Event";
            lblFormTitle.Text = "Edit Event";
            btnSaveEvent.Text = "Save Changes";

            txtEventTitle.Text = _existingEvent.Title;
            txtDescription.Text = _existingEvent.Description;
            txtLocation.Text = _existingEvent.Location;
            nudCapacity.Value = Math.Max(
                nudCapacity.Minimum,
                Math.Min(nudCapacity.Maximum, _existingEvent.Capacity));

            dtpEventDate.Value = _existingEvent.Date;

            cmbEventStatus.SelectedItem =
                _existingEvent.Status.ToString();

            // Keep cancelled events from being accidentally republished.
            if (_existingEvent.Status == EventStatus.Cancelled)
            {
                cmbEventStatus.Items.Add("Cancelled");
                cmbEventStatus.SelectedItem = "Cancelled";
                cmbEventStatus.Enabled = false;
            }
        }

        private void btnSaveEvent_Click(object sender, EventArgs e)
        {
            string title = txtEventTitle.Text.Trim();
            string description = txtDescription.Text.Trim();
            string location = txtLocation.Text.Trim();

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Enter an event title.");
                txtEventTitle.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(location))
            {
                MessageBox.Show("Enter the event location.");
                txtLocation.Focus();
                return;
            }

            if (nudCapacity.Value < 1)
            {
                MessageBox.Show("Capacity must be greater than zero.");
                nudCapacity.Focus();
                return;
            }

            if (cmbEventStatus.SelectedItem == null)
            {
                MessageBox.Show("Select an event status.");
                return;
            }

            EventStatus status = Enum.Parse<EventStatus>(
                cmbEventStatus.SelectedItem.ToString());

            // Do not allow this form to change event ownership.
            if (_existingEvent != null &&
                _existingEvent.OrganizerId != _organizerId)
            {
                MessageBox.Show(
                    "You cannot edit another organizer's event.");
                return;
            }

            Event result = _existingEvent ?? new Event
            {
                Id = _nextEventId++,
                OrganizerId = _organizerId
            };

            // The event owner is assigned from the authenticated organizer.
            result.OrganizerId = _organizerId;
            result.Title = title;
            result.Description = description;
            result.Date = dtpEventDate.Value;
            result.Location = location;
            result.Capacity = (int)nudCapacity.Value;
            result.Status = status;

            SavedEvent = result;

            MessageBox.Show(
                _existingEvent == null
                    ? "Event created successfully."
                    : "Event updated successfully.",
                "HahuEvents",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEventTitle.Clear();
            txtDescription.Clear();
            txtLocation.Clear();
            nudCapacity.Value = 1;
            dtpEventDate.Value = DateTime.Now;

            if (cmbEventStatus.Items.Count > 0)
                cmbEventStatus.SelectedIndex = 0;

            txtEventTitle.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
