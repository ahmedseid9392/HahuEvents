namespace HahuEvents.Data.Entities;

public class Registration
{
    public int Id { get; set; }

    public int EventId { get; set; }

    public int ParticipantId { get; set; }

    public DateTime RegistrationDate { get; set; } = DateTime.UtcNow;

    public string Status { get; set; } = "Pending";

    public string AttendanceStatus { get; set; } = "NotMarked";

    // Navigation properties
    public Event Event { get; set; } = null!;

    public Participant Participant { get; set; } = null!;
}