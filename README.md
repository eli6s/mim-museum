# MIM Museum Management System

A VB.NET WinForms application built for the MIM Mineral Museum in Beirut, Lebanon. The system manages day-to-day museum operations alongside the in-house boutique, covering everything from cataloguing the mineral collection to processing point-of-sale transactions.

## Overview

The application covers two distinct sides of the institution:

- **Museum**: mineral catalog, exhibitions, events, donations, guest registry, equipment, maintenance
- **Boutique**: point-of-sale, inventory, customer records, transaction history

Three user roles are supported, each with its own permission scope:

- **Manager**: full access across both sides
- **Assistant**: museum operations and settings
- **Cashier**: boutique POS, inventory, customers, settings (with read-only transactions)

## Tech Stack

- **Language**: VB.NET (.NET Framework 4.7.2+)
- **UI**: Windows Forms with MetroFramework, CuoreUI, OxyPlot, Realtaiizor
- **Database**: SQL Server (LocalDB supported for development)
- **Reports**: RDLC via Microsoft ReportViewer
- **Auth**: BCrypt password hashing

> Windows only. WinForms does not run on macOS or Linux.

## Features

### Core
- Role-based access control with a centralized permission manager
- Hashed passwords (BCrypt) and a complete forgot-password / reset code flow
- Automatic schema creation on first launch, no manual SQL setup required
- Country data loaded from JSON for easy maintenance without recompilation

### Museum
- **Minerals catalog** with classifications, sections, country of origin, hardness, fluorescence/radioactivity flags, and optional descriptions
- **Events** with many-to-many staff assignment and guest registration, plus capacity enforcement
- **Donations** supporting anonymous donors and optional event linkage
- **Guests** directory shared across events and donations
- **Equipment** and **maintenance** with internal vs external service types and a join table for equipment-service associations with per-item costs

### Boutique
- **Point of Sale** with cart management, walk-in or registered customer support, cash/card payment methods, automatic change calculation, and instant receipt generation
- **Inventory** with image uploads (UUID-named with automatic cleanup), optional mineral references, low-stock highlighting, and soft deletion
- **Transactions** browser with line-item drill-down, manager-restricted deletion, and on-demand receipt viewing

### Reports (RDLC)
- **Receipt**: generated after every sale and viewable from the transactions browser
- **Inventory snapshot**: printable stock report with low-stock flags

### UI / UX
- Responsive sidebar navigation with collapsible museum / boutique sections
- Mode-aware forms with visual ADD / EDIT indicators
- Shared user controls for the museum / boutique split (DRY principle)
- Breadcrumb header reflecting the active view
- High-DPI support

## Project Structure

```
MimMuseum/
├── components/
│   ├── core/      (login, session, sidenav, settings, header, etc.)
│   ├── museum/    (minerals, events, donations, guests, equipment, ...)
│   ├── boutique/  (pos, inventory, transactions, customers, ...)
│   └── reports/   (receipt, inventory snapshot)
├── utils/         (db_controller, helpers, permission_manager, image_helpers, ...)
├── assets/        (boutique-items images, countries.json)
├── App.config     (database + email connection strings)
├── schema.sql     (auto-run on first launch)
├── seed.sql       (sample data)
└── *.rdlc         (report templates)
```

## Setup

### Prerequisites

- Visual Studio 2019 or later with the ".NET Desktop Development" workload
- SQL Server (Express or LocalDB)
- The **Microsoft RDLC Report Designer** Visual Studio extension (install from Extensions -> Manage Extensions if you plan to rebuild reports)

### Installation

1. **Clone the repo:**
   ```bash
   git clone <your-repo-url>
   cd mim-museum
   ```

2. **Open** `MimMuseum.sln` in Visual Studio.

3. **Restore NuGet packages**: Tools -> NuGet Package Manager -> Restore.

4. **Configure the database connection** in `App.config`:
   ```xml
   <connectionStrings>
     <add name="MimMuseum"
          connectionString="Server=(localdb)\MSSQLLocalDB;Database=mim_museum;Integrated Security=true;"
          providerName="System.Data.SqlClient"/>
   </connectionStrings>
   ```

5. **Configure SMTP credentials** in `App.config` for the forgot-password flow:
   ```xml
   <appSettings>
     <add key="smtp_host" value="smtp.gmail.com" />
     <add key="smtp_port" value="587" />
     <add key="smtp_email" value="your-email@gmail.com" />
     <add key="smtp_password" value="your-app-password" />
   </appSettings>
   ```

   For Gmail, you'll need to generate an [app password](https://myaccount.google.com/apppasswords) rather than using your account password. `App.config` is gitignored, so your credentials stay local.

6. **Run the seed script** (`seed.sql`) in SQL Server Management Studio or via `sqlcmd`. The schema itself is created automatically on first launch.

7. **Build and run** (F5). The schema is applied on launch, then the login screen appears.

### Default Login

After seeding, log in with the seeded manager account. Passwords are hashed before storage, so use the forgot-password flow to set a password if none was provided in the seed.

## Rebuilding Reports

The two RDLC reports (receipt and inventory snapshot) are embedded as resources. To rebuild or modify them:

1. Install the **Microsoft RDLC Report Designer** extension via Extensions -> Manage Extensions.
2. Install the **`Microsoft.ReportingServices.ReportViewerControl.Winforms`** NuGet package.
3. Right-click the project -> Add -> New Item -> Report (`.rdlc`).
4. Open the Report Data pane (View -> Report Data).
5. Add datasets matching the names expected by the viewer code:
   - **receipt.rdlc**: `ds_header` (one row) and `ds_items` (many rows)
   - **inventory_report.rdlc**: `ds_inventory` (many rows)
6. Drag tables, text boxes, and tablixes onto the layout surface.
7. Set the `.rdlc` file's **Build Action** to **Embedded Resource** so the runtime can resolve it via `MimMuseum.<filename>.rdlc`.

For datasets that don't map directly to schema tables (joined / computed columns), use a typed `DataSet` (`.xsd`) with custom `DataTable` definitions and bind via the field types each report expects.

## Architecture Notes

- **Price snapshots**: `transaction_items.item_price` is captured at sale time so historical reports remain accurate even if base prices change later.
- **Soft delete**: Boutique items use an `is_active` flag rather than hard deletion to preserve transaction history.
- **Shared controls**: Equipment, maintenance, and employees use a single user control with a `building_filter` property to scope the data to either the museum or the boutique side.
- **Image storage**: Uploaded item images are renamed with UUIDs and stored under `assets/boutique-items/`, with the filename persisted in the database.

## Limitations

- Windows only.
- Single-instance. Concurrent access works at the database level, but the UI does not push live updates between running clients.
