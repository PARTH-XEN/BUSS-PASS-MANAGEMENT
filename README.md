# Bus Pass Management System (VB.NET 2010 Express Edition)

A complete, clean, and user-friendly **Bus Pass Management System** built with **VB.NET (Windows Forms)** for **Visual Studio 2010 Express Edition** using a server-side SQL Server `.mdf` database (`BusPassDB.mdf`).

---

## 🔑 Default Admin Login Credentials

- **Admin Username:** `admin`
- **Admin Password:** `admin123`

---

## 📁 Project Structure

```text
BusPASS/
│
├── BusPASS.sln                     <-- Open this Solution in Visual Studio 2010 Express
│
└── BusPASS/
    ├── BusPASS.vbproj              <-- VB.NET Project File (.NET Framework 4.0)
    ├── App.config                  <-- SQL Server connection strings
    ├── BusPassDB.mdf               <-- SQL Server primary database file
    ├── BusPassDB_log.ldf           <-- SQL Server database log file
    ├── BusPassDB_Setup.sql         <-- SQL setup script (tables & seed data)
    │
    ├── DBConnection.vb             <-- Database connection helper & SQL executor
    ├── LoginForm.vb                <-- Admin Login form (Startup Form)
    ├── MainDashboardForm.vb        <-- Admin Dashboard with live stats & quick table
    ├── NewPassForm.vb              <-- Issue New Bus Pass with automatic fare & discounts
    ├── ManagePassesForm.vb         <-- Search, filter, renew, cancel, or delete passes
    ├── RouteManagementForm.vb      <-- Manage bus routes, stops, and monthly fares
    ├── PrintPassForm.vb            <-- Official Bus Pass ID Card format with Print / Preview
    ├── ChangePasswordForm.vb       <-- Admin change password form
    │
    ├── My Project/                 <-- Application, Assembly, Resources, Settings
    └── bin/Debug/BusPASS.exe       <-- Compiled executable ready to run
```

---

## 🚀 How to Run the Project

### Method 1: Using Visual Studio 2010 Express (Recommended)
1. Double-click **`BusPASS.sln`** to open the project in **Visual Studio 2010 Express**.
2. Press **`F5`** (or click the green **Start Debugging** arrow).
3. The **Admin Login** screen will appear.
4. Enter `admin` / `admin123` and click **LOGIN**.

### Method 2: Direct Execution
1. Navigate to `BusPASS\bin\Debug\`.
2. Double-click **`BusPASS.exe`**.

---

## 🌟 Key Features & Highlights

### 1. Admin-Only Secure Login
- Big, clear username and password input boxes.
- "Show Password" toggle checkbox.
- "Test Database (.mdf)" button to verify connection status immediately.
- Keyboard support: Pressing `Enter` automatically submits the login.

### 2. Admin Dashboard
- **Top Summary Metric Cards:**
  - Total Passes Issued
  - Active Passes
  - Expired Passes
  - Total Bus Routes
- **Big Navigation Buttons:**
  - `+ ISSUE NEW PASS`
  - `MANAGE & RENEW PASSES`
  - `BUS ROUTES & FARES`
  - `PRINT / VIEW PASS`
  - `CHANGE PASSWORD`
  - `LOGOUT`
- **Recent Passes Data Table:**
  - Auto-updates expired passes on load.
  - Color-coded status (`Active` in green, `Expired` in red).

### 3. Issue New Bus Pass
- **Auto-generated Pass ID:** e.g., `BP-1004`.
- **Passenger Details:** Full Name, Gender, Age, Mobile No, Email, Address.
- **Verification Proof:** Dropdown for Aadhaar Card, College ID, Voter ID, Driving License, Passport + ID Number.
- **Passenger Categories & Concessions:**
  - **Student Pass:** 30% discount automatically applied.
  - **Senior Citizen Pass:** 50% discount automatically applied.
  - **Employee Pass:** 20% discount automatically applied.
  - **General Public:** Standard fare (0% discount).
- **Route Selection:** Linked directly to the `Routes` database table. Automatically loads Source Stop, Destination Stop, and base fare.
- **Validity Periods:** 1 Month, 3 Months, 6 Months, or 1 Year. Automatically calculates start date and expiration date.
- **Instant Printable Card:** Option to preview and print the card immediately after saving.

### 4. Manage & Renew Passes
- **Multi-criteria Search:** Search by Pass Number, Passenger Name, Mobile Number, Category, or Stops.
- **Status Filter:** All Statuses, Active Only, Expired Only, or Cancelled Only.
- **Pass Renewal:** Select 1, 3, 6, or 12 months extension. Automatically adds to validity, updates status to `Active`, calculates renewal amount, and logs into the `PassRenewals` history table.
- **Pass Cancellation & Deletion:** Cancel passes or permanently delete records with confirmation safeguards.

### 5. Bus Routes & Fares Management
- Add new transit routes with Route Number, Route Name, Starting Stop, Ending Stop, and Monthly Fare.
- Update existing routes and fares.
- Set routes as `Active` or `Inactive`.
- Prevents accidental deletion of routes currently tied to issued passes.

### 6. Official Bus Pass ID Card & Printing
- Large horizontal commuter pass card layout (~760 x 435 px) featuring:
  - Header: *Municipal Transport Corporation - Official Commuter Bus Pass*
  - Active / Expired status badge
  - Passenger Photo / ID box
  - Passenger Full Name, Age, Gender, and Pass Number
  - Route details (*Source Stop <--> Destination Stop*)
  - Validity dates (*Valid From* and *Valid Till*)
  - Contact No & ID Proof Number
  - Total Fare Paid
  - Simulated barcode graphic
  - Authorized Signatory stamp line
- **Print Preview & Print:** Integrated with .NET `PrintDocument`, `PrintDialog`, and `PrintPreviewDialog` for live printer output.

---

## 🗄️ Database Schema (`BusPassDB.mdf`)

### 1. `AdminLogin`
- `AdminId` (INT, Primary Key, Identity)
- `Username` (NVARCHAR(50), Unique)
- `Password` (NVARCHAR(50))
- `FullName` (NVARCHAR(100))
- `CreatedDate` (DATETIME)

### 2. `Routes`
- `RouteId` (INT, Primary Key, Identity)
- `RouteNumber` (NVARCHAR(20), Unique)
- `RouteName` (NVARCHAR(100))
- `SourceStop` (NVARCHAR(100))
- `DestinationStop` (NVARCHAR(100))
- `MonthlyFare` (DECIMAL(10,2))
- `Status` (NVARCHAR(20))

### 3. `Passes`
- `PassId` (INT, Primary Key, Identity starting at 1001)
- `PassNumber` (NVARCHAR(30), Unique)
- `FullName` (NVARCHAR(100))
- `Gender` (NVARCHAR(10))
- `Age` (INT)
- `ContactNumber` (NVARCHAR(20))
- `Email` (NVARCHAR(100))
- `Address` (NVARCHAR(250))
- `PassCategory` (NVARCHAR(50))
- `IdProofType` (NVARCHAR(50))
- `IdProofNumber` (NVARCHAR(50))
- `RouteId` (INT, Foreign Key -> `Routes.RouteId`)
- `SourceStop` (NVARCHAR(100))
- `DestinationStop` (NVARCHAR(100))
- `ValidityPeriod` (NVARCHAR(30))
- `StartDate` (DATE)
- `ExpiryDate` (DATE)
- `FareAmount` (DECIMAL(10,2))
- `Discount` (DECIMAL(10,2))
- `TotalAmount` (DECIMAL(10,2))
- `Status` (NVARCHAR(20))
- `CreatedDate` (DATETIME)

### 4. `PassRenewals`
- `RenewalId` (INT, Primary Key, Identity)
- `PassId` (INT, Foreign Key -> `Passes.PassId`)
- `PassNumber` (NVARCHAR(30))
- `PreviousExpiryDate` (DATE)
- `NewExpiryDate` (DATE)
- `MonthsExtended` (INT)
- `RenewalAmount` (DECIMAL(10,2))
- `RenewalDate` (DATETIME)

---

## 🎨 Design Notes
- **Clear & Big UI**: Built with 11pt-13pt text for labels/inputs and 16pt-20pt bold headings for high visibility.
- **Clean Academic Aesthetics**: Simple, uncluttered forms with high-contrast buttons (Green for Save/Login, Blue for Primary Actions, Red for Exit/Cancel, Orange for Print).
