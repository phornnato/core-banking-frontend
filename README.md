# Core Banking System Frontend

ASP.NET Core MVC frontend application for the Core Banking System.

## Features

* ASP.NET Core MVC
* Bootstrap 5 Dashboard Layout
* DataTables Integration
* Role Management (CRUD)
* REST API Integration with Spring Boot Backend
* Responsive Admin Dashboard UI

---

## Prerequisites

Before running the project, make sure you have installed:

* .NET 8 SDK (or the version used by this project)
* Visual Studio 2022 or VS Code
* Git
* Spring Boot Backend API

Verify installation:

```bash
dotnet --version
```

---

## Clone Project

```bash
git clone https://github.com/YOUR_USERNAME/coreBankSystemFrontend.git
cd coreBankSystemFrontend
```

---

## Restore Dependencies

```bash
dotnet restore
```

---

## Configure Backend API

Open:

```text
Services/RoleApiService.cs
```

Update the API URL:

```csharp
private string apiUrl = "http://localhost:8080/api/roles";
```

Replace with your backend URL if different.

---

## Run Project

### Using CLI

```bash
dotnet watch run
```

or

```bash
dotnet run
```

### Using Visual Studio

1. Open solution file:

```text
coreBankSystemFrontend.sln
```

2. Press:

```text
F5
```

or

```text
Ctrl + F5
```

---

## Project Structure

```text
coreBankSystemFrontend
│
├── Controllers
│   └── RoleController.cs
│
├── Models
│   └── RoleViewModel.cs
│
├── Services
│   └── RoleApiService.cs
│
├── Views
│   ├── Shared
│   │   └── _Layout.cshtml
│   │
│   └── Role
│       ├── Index.cshtml
│       ├── Create.cshtml
│       └── Edit.cshtml
│
├── wwwroot
├── Program.cs
└── appsettings.json
```

---

## Available Pages

### Role List

```text
/Role
```

### Create Role

```text
/Role/Create
```

### Edit Role

```text
/Role/Edit/{id}
```

---

## Build Project

```bash
dotnet clean
dotnet build
```

---

## Publish Project

```bash
dotnet publish -c Release
```

Published files will be generated inside:

```text
bin/Release/net8.0/publish
```

---

## Technologies

* ASP.NET Core MVC
* Bootstrap 5
* jQuery
* DataTables
* C#
* REST API

---

## Author

Horm Sophorn (Ahpoji)
