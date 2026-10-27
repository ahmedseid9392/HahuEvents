namespace HahuEvents.Desktop.Models
{
    public class Registration
    {
        public int Id { get; set; }

        public int EventId { get; set; }

        public int ParticipantId { get; set; }

        public DateTime RegistrationDate { get; set; } = DateTime.Now;

        public RegistrationStatus Status { get; set; }
            = RegistrationStatus.Active;

        public AttendanceStatus AttendanceStatus { get; set; }
            = AttendanceStatus.NotMarked;
    }
}