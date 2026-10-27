# HahuEvents Business Rules

## Authentication
- Only Administrators and Organizers can access the desktop app.
- Organizers can register their own accounts.
- Public registration must never grant Administrator privileges.

## Event Management
- Organizers can create and manage their own events.
- Each event must have an OrganizerId.
- New events belong to the authenticated Organizer.
- Administrators can view and filter all events.
- Administrators cannot create, edit, publish, or cancel events.

## Registrations
- Organizers can manage registrations for their own events.
- Cancelled events cannot accept new registrations.
- Registrations must not exceed event capacity.
- Duplicate active registrations are not allowed.

## Attendance
- Only the Organizer who owns an event can mark attendance.
- Attendance can be recorded only for registered participants.

## Reports and Settings
- Administrators can view system-wide reports.
- Organizers can view reports for their own events.
- Only Administrators can change system-wide settings.