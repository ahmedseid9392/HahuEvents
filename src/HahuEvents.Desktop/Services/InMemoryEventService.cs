using HahuEvents.Desktop.Models;

namespace HahuEvents.Desktop.Services
{
    public sealed class InMemoryEventService
    {
        private readonly List<Event> _events;
        private readonly List<User> _organizers;
        private readonly List<Registration> _registrations;
        private int _nextEventId;

        public static InMemoryEventService Instance { get; } = new();

        public IReadOnlyList<Event> Events => _events;

        private InMemoryEventService()
        {
            _organizers = new List<User>
            {
                new() { Id = 1, FullName = "Nile Business Hub", Username = "nile", Role = UserRole.Organizer },
                new() { Id = 2, FullName = "Aster Events", Username = "aster", Role = UserRole.Organizer },
                new() { Id = 3, FullName = "Sheba Digital", Username = "sheba", Role = UserRole.Organizer },
                new() { Id = 4, FullName = "Blue Nile Technologies", Username = "blue-nile", Role = UserRole.Organizer },
                new() { Id = 5, FullName = "Go Ethiopia", Username = "go-ethiopia", Role = UserRole.Organizer }
            };

            _events = new List<Event>
            {
                new() { Id = 1, OrganizerId = 1, Title = "Addis Ababa Tech Summit", Date = new DateTime(2026, 11, 12, 0, 0, 0, DateTimeKind.Local), Location = "Millennium Hall, Addis Ababa", Capacity = 300, Status = EventStatus.Published },
                new() { Id = 2, OrganizerId = 1, Title = "Young Entrepreneurs Forum", Date = new DateTime(2026, 11, 19, 0, 0, 0, DateTimeKind.Local), Location = "Skylight Hotel, Addis Ababa", Capacity = 250, Status = EventStatus.Published },
                new() { Id = 3, OrganizerId = 2, Title = "Ethiopian Coffee Expo", Date = new DateTime(2026, 12, 3, 0, 0, 0, DateTimeKind.Local), Location = "Millennium Hall, Addis Ababa", Capacity = 500, Status = EventStatus.Draft },
                new() { Id = 4, OrganizerId = 3, Title = "Digital Finance Conference", Date = new DateTime(2026, 12, 10, 0, 0, 0, DateTimeKind.Local), Location = "Hyatt Regency, Addis Ababa", Capacity = 320, Status = EventStatus.Published },
                new() { Id = 5, OrganizerId = 2, Title = "Hawassa Music Weekend", Date = new DateTime(2026, 12, 18, 0, 0, 0, DateTimeKind.Local), Location = "Tabor Park, Hawassa", Capacity = 750, Status = EventStatus.Published },
                new() { Id = 6, OrganizerId = 4, Title = "Designers Community Night", Date = new DateTime(2027, 1, 8, 0, 0, 0, DateTimeKind.Local), Location = "The Urban Center, Addis Ababa", Capacity = 120, Status = EventStatus.Cancelled },
                new() { Id = 7, OrganizerId = 5, Title = "Bahir Dar Tourism Workshop", Date = new DateTime(2027, 1, 16, 0, 0, 0, DateTimeKind.Local), Location = "Kuriftu Resort, Bahir Dar", Capacity = 90, Status = EventStatus.Draft },
                new() { Id = 8, OrganizerId = 1, Title = "Women in Leadership Summit", Date = new DateTime(2027, 2, 6, 0, 0, 0, DateTimeKind.Local), Location = "UNECA Conference Center", Capacity = 400, Status = EventStatus.Published }
            };

            _nextEventId = _events.Max(eventItem => eventItem.Id) + 1;
            _registrations = SeedRegistrations(new[] { 245, 198, 0, 273, 412, 38, 24, 327 });
        }

        public Event SaveEvent(Event eventToSave)
        {
            if (eventToSave.Id <= 0)
            {
                eventToSave.Id = _nextEventId++;
                _events.Add(eventToSave);
                return eventToSave;
            }

            int existingIndex = _events.FindIndex(
                eventItem => eventItem.Id == eventToSave.Id);

            if (existingIndex < 0)
            {
                throw new KeyNotFoundException(
                    $"Event {eventToSave.Id} was not found.");
            }

            _events[existingIndex] = eventToSave;
            return eventToSave;
        }

        public bool DeleteEvent(int eventId, int organizerId)
        {
            int eventIndex = _events.FindIndex(eventItem =>
                eventItem.Id == eventId && eventItem.OrganizerId == organizerId);

            if (eventIndex < 0)
            {
                return false;
            }

            _events.RemoveAt(eventIndex);
            _registrations.RemoveAll(registration => registration.EventId == eventId);
            return true;
        }

        public string GetOrganizerName(int organizerId)
        {
            return _organizers.FirstOrDefault(organizer => organizer.Id == organizerId)?.FullName ?? "Unknown Organizer";
        }

        public int GetRegistrationCount(int eventId)
        {
            return _registrations.Count(registration =>
                registration.EventId == eventId && registration.Status == RegistrationStatus.Active);
        }

        private static List<Registration> SeedRegistrations(IReadOnlyList<int> counts)
        {
            var registrations = new List<Registration>();
            int registrationId = 1;

            for (int eventIndex = 0; eventIndex < counts.Count; eventIndex++)
            {
                for (int participantIndex = 0; participantIndex < counts[eventIndex]; participantIndex++)
                {
                    registrations.Add(new Registration
                    {
                        Id = registrationId,
                        EventId = eventIndex + 1,
                        ParticipantId = participantIndex + 1,
                        Status = RegistrationStatus.Active
                    });
                    registrationId++;
                }
            }

            return registrations;
        }
    }
}