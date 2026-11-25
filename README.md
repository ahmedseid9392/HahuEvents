# HahuEvents — Event Registration Management System

A desktop-based Event Registration Management System developed using C# Windows Forms. The system helps administrators manage organizer accounts and monitor system-wide events, while organizers manage their own events, participant registrations, and attendance.

## 1. Project Overview

HahuEvents is developed as a team software engineering project using a phased development approach.

### Project Objectives

- Provide secure login and role-based access.
- Allow administrators to manage organizer accounts and view all events.
- Allow organizers to create, publish, edit, and cancel their own events.
- Manage participant registrations and attendance.
- Generate reports based on user permissions.
- Develop a foundation that can later integrate with an ASP.NET Web API and a database.

### Technology Stack

| Component | Technology |
|---|---|
| Programming language | C# |
| Desktop interface | Windows Forms |
| Development environment | Visual Studio |
| Version control | Git and GitHub |
| Backend — Phase 2 | ASP.NET Web API |
| Database — Phase 2 | SQL Server or PostgreSQL |
| Web interface — Phase 3 | Web application connected to the same API |

## 2. Project Folder Structure

```text
HahuEvents/
├── HahuEvents.sln
├── README.md
├── src/
│   └── HahuEvents.Desktop/
│       ├── Forms/
│       ├── Models/
│       ├── Services/
│       ├── Program.cs
│       └── HahuEvents.Desktop.csproj
├── tests/
│   └── HahuEvents.Tests/
└── docs/
 ├── business-rules.md
    
    
```

## 3. Forms — User Interface

The `Forms/` folder contains the Windows Forms screens used by administrators and organizers.

| File | Responsibility |
|---|---|
| `LoginForm.cs` | User login |
| `AdminDashboardForm.cs` | Administrator dashboard |
| `OrganizerDashboardForm.cs` | Organizer dashboard |
| `ManageOrganizersForm.cs` | Manage organizer accounts |
| `AllEventsForm.cs` | View and filter all events |
| `EventDetailsForm.cs` | View event information |
| `EventForm.cs` | Create or edit an event |
| `MyEventsForm.cs` | Manage the current organizer's events |
| `RegistrationsForm.cs` | Manage participant registrations |
| `AttendanceForm.cs` | Mark and view attendance |
| `SystemReportsForm.cs` | View system-wide reports |
| `MyReportsForm.cs` | View reports for the organizer's events |
| `SystemSettingsForm.cs` | Manage system-wide settings |

**Naming convention:** Each form uses PascalCase and ends with `Form`. Visual Studio normally generates its associated `.Designer.cs` and `.resx` files.

## 4. Models — Shared Data Structures

The `Models/` folder defines the main entities and enumerations shared across the application.

| File | Responsibility |
|---|---|
| `User.cs` | User identity, credentials hash, role, and account status |
| `UserRole.cs` | Defines `Administrator` and `Organizer` |
| `Event.cs` | Event details and organizer ownership |
| `EventStatus.cs` | Defines `Draft`, `Published`, and `Cancelled` |
| `Participant.cs` | Participant contact information |
| `Registration.cs` | Event-participant registration information |
| `RegistrationStatus.cs` | Defines `Active` and `Cancelled` |
| `AttendanceStatus.cs` | Defines `NotMarked`, `Present`, and `Absent` |

All team members must use these shared model definitions rather than creating duplicate versions.

## 5. Services — Business Logic

The `Services/` folder contains the application operations and business rules.

| File | Responsibility |
|---|---|
| `AuthService.cs` | Authenticate users and validate account access |
| `OrganizerService.cs` | Manage organizer accounts |
| `EventService.cs` | Create, update, publish, cancel, and retrieve events |
| `RegistrationService.cs` | Register participants and manage cancellations |
| `AttendanceService.cs` | Record attendance for registered participants |
| `ReportService.cs` | Generate administrator and organizer reports |
| `SettingsService.cs` | Manage system settings |
| `InMemoryDataStore.cs` | Temporary shared data storage for Phase 1 |

Services should be called by forms rather than placing all business logic directly inside button-click event handlers.

`InMemoryDataStore.cs` is intended for the initial desktop phase. In Phase 2, the application can move to API-backed services and persistent database storage.

## 6. Helpers — Reusable Utilities

The `Helpers/` folder contains reusable supporting classes.

| File | Responsibility |
|---|---|
| `ValidationHelper.cs` | Validate required fields, email, phone, dates, and capacity |
| `SessionManager.cs` | Track the currently authenticated user |
| `FormNavigationHelper.cs` | Centralize navigation between forms when useful |
| `UiMessageHelper.cs` | Standardize success, warning, and error messages |

Helpers should contain reusable functionality rather than duplicate logic across multiple forms.

## 7. Program.cs — Application Entry Point

`Program.cs` initializes and starts the Windows Forms application.

### Responsibilities

- Configure and initialize the application.
- Start the Windows Forms message loop.
- Open `LoginForm` as the initial screen.
- Allow the authentication flow to select the appropriate dashboard after successful login.

### Expected application flow

```text
Program.cs
    |
    v
LoginForm
    |
    v
AuthService
    |
    v
Validate Credentials and Role
    |
    +-------------------------+
    |                         |
    v                         v
Administrator             Organizer
    |                         |
    v                         v
AdminDashboardForm      OrganizerDashboardForm
```

The application must enforce authentication and role permissions through its logic, not merely by hiding navigation buttons.


instructions:
- Use the develop branch as the integration branch.
- Do not rename shared models or enum values without agreement.
- Create a separate feature branch for each task.
- Do not commit directly to main.
- Build and test before opening a pull request.
- Follow the approved Figma designs and business rules.
