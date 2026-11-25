namespace HahuEvents.Data.Entities;

public class Event
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public DateTime EventDate { get; set; }

    public string Location { get; set; } = string.Empty;

    public int Capacity { get; set; }

    public string Status { get; set; } = "Draft";

    // Foreign key
    public int OrganizerId { get; set; }

    // Navigation property
    public User Organizer { get; set; } = null!;

    public ICollection<Registration> Registrations { get; set; }
        = new List<Registration>();
}