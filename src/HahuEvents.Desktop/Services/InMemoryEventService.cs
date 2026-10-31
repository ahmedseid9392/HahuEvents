using HahuEvents.Desktop.Models;

namespace HahuEvents.Desktop.Services
{
    public sealed class InMemoryEventService
    {
        private readonly List<Event> _events;
        private readonly List<User> _organizers;
        private readonly List<Registration> _registrations;
        private readonly List<Participant> _participants;
        private int _nextEventId;
        private int _nextParticipantId;
        private int _nextRegistrationId;

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
            _participants = new List<Participant>();
            _nextParticipantId = _registrations.Max(
                registration => registration.ParticipantId) + 1;
            _nextRegistrationId = _registrations.Count + 1;
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

        public IReadOnlyList<Registration> GetRegistrationsForEvent(
            int eventId,
            int organizerId)
        {
            if (!_events.Any(eventItem =>
                eventItem.Id == eventId &&
                eventItem.OrganizerId == organizerId))
            {
                return Array.Empty<Registration>();
            }

            return _registrations
                .Where(registration =>
                    registration.EventId == eventId &&
                    registration.Status == RegistrationStatus.Active)
                .OrderByDescending(registration => registration.RegistrationDate)
                .ToArray();
        }

        public Participant? GetParticipant(int participantId)
        {
            return _participants.FirstOrDefault(
                participant => participant.Id == participantId);
        }

        public bool SetAttendanceStatus(
            int eventId,
            int organizerId,
            int registrationId,
            AttendanceStatus attendanceStatus)
        {
            bool ownsEvent = _events.Any(eventItem =>
                eventItem.Id == eventId &&
                eventItem.OrganizerId == organizerId);
            if (!ownsEvent)
            {
                return false;
            }

            Registration? registration = _registrations.FirstOrDefault(item =>
                item.Id == registrationId &&
                item.EventId == eventId &&
                item.Status == RegistrationStatus.Active);
            if (registration == null)
            {
                return false;
            }

            registration.AttendanceStatus = attendanceStatus;
            return true;
        }

        public bool RegisterParticipant(
            int eventId,
            int organizerId,
            string fullName,
            string email,
            string phone,
            out string message)
        {
            Event? eventItem = _events.FirstOrDefault(item =>
                item.Id == eventId && item.OrganizerId == organizerId);

            if (eventItem == null)
            {
                message = "The selected event is unavailable.";
                return false;
            }

            if (eventItem.Status != EventStatus.Published)
            {
                message = "Participants can only register for published events.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(email))
            {
                message = "Participant name and email are required.";
                return false;
            }

            string normalizedEmail = email.Trim();
            bool alreadyRegistered = _registrations
                .Where(registration =>
                    registration.EventId == eventId &&
                    registration.Status == RegistrationStatus.Active)
                .Select(registration => GetParticipant(registration.ParticipantId))
                .Any(participant => participant?.Email.Equals(
                    normalizedEmail,
                    StringComparison.OrdinalIgnoreCase) == true);

            if (alreadyRegistered)
            {
                message = "This participant is already registered for the event.";
                return false;
            }

            if (GetRegistrationCount(eventId) >= eventItem.Capacity)
            {
                message = "This event has reached its registration capacity.";
                return false;
            }

            var participant = new Participant
            {
                Id = _nextParticipantId++,
                FullName = fullName.Trim(),
                Email = normalizedEmail,
                Phone = phone.Trim()
            };

            _participants.Add(participant);
            _registrations.Add(new Registration
            {
                Id = _nextRegistrationId++,
                EventId = eventId,
                ParticipantId = participant.Id
            });

            message = "Participant registered successfully.";
            return true;
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