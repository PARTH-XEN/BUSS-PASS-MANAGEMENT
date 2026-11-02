-- Bus Pass Management System Database Setup
-- For SQL Server / SQL Server Express (.mdf)

USE [master];
GO

-- Drop existing database if attached or in use
IF EXISTS (SELECT name FROM sys.databases WHERE name = N'BusPassDB')
BEGIN
    ALTER DATABASE [BusPassDB] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [BusPassDB];
END
GO

-- Create database with specific MDF and LDF files in the project folder
CREATE DATABASE [BusPassDB]
ON PRIMARY 
(
    NAME = N'BusPassDB',
    FILENAME = N'C:\Users\dell\OneDrive\Documents\Visual Studio 2010\Projects\BusPASS\BusPASS\BusPassDB.mdf'
)
LOG ON 
(
    NAME = N'BusPassDB_log',
    FILENAME = N'C:\Users\dell\OneDrive\Documents\Visual Studio 2010\Projects\BusPASS\BusPASS\BusPassDB_log.ldf'
);
GO

USE [BusPassDB];
GO

-- Table: AdminLogin
IF OBJECT_ID('dbo.AdminLogin', 'U') IS NOT NULL DROP TABLE dbo.AdminLogin;
CREATE TABLE dbo.AdminLogin (
    AdminId INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(50) NOT NULL,
    FullName NVARCHAR(100) NOT NULL,
    CreatedDate DATETIME DEFAULT GETDATE()
);
GO

-- Insert default admin account (Username: admin, Password: admin123)
INSERT INTO dbo.AdminLogin (Username, Password, FullName)
VALUES ('admin', 'admin123', 'Administrator');
GO

-- Table: Routes
IF OBJECT_ID('dbo.Routes', 'U') IS NOT NULL DROP TABLE dbo.Routes;
CREATE TABLE dbo.Routes (
    RouteId INT IDENTITY(1,1) PRIMARY KEY,
    RouteNumber NVARCHAR(20) NOT NULL UNIQUE,
    RouteName NVARCHAR(100) NOT NULL,
    SourceStop NVARCHAR(100) NOT NULL,
    DestinationStop NVARCHAR(100) NOT NULL,
    MonthlyFare DECIMAL(10,2) NOT NULL,
    Status NVARCHAR(20) DEFAULT 'Active'
);
GO

-- Sample Routes
INSERT INTO dbo.Routes (RouteNumber, RouteName, SourceStop, DestinationStop, MonthlyFare, Status)
VALUES 
('R-101', 'City Center Express', 'Main Bus Terminal', 'City Center Mall', 500.00, 'Active'),
('R-102', 'University Campus Route', 'Railway Station', 'Central University', 400.00, 'Active'),
('R-103', 'Tech Hub Corridor', 'Suburbs North', 'IT Park Complex', 750.00, 'Active'),
('R-104', 'Industrial Area Transit', 'Main Bus Terminal', 'Industrial Estate Phase 2', 600.00, 'Active'),
('R-105', 'Metro Ring Road', 'Airport Link', 'Outer Ring Road', 800.00, 'Active');
GO

-- Table: Passes
IF OBJECT_ID('dbo.Passes', 'U') IS NOT NULL DROP TABLE dbo.Passes;
CREATE TABLE dbo.Passes (
    PassId INT IDENTITY(1001,1) PRIMARY KEY,
    PassNumber NVARCHAR(30) NOT NULL UNIQUE,
    FullName NVARCHAR(100) NOT NULL,
    Gender NVARCHAR(10) NOT NULL,
    Age INT NOT NULL,
    ContactNumber NVARCHAR(20) NOT NULL,
    Email NVARCHAR(100) NULL,
    Address NVARCHAR(250) NULL,
    PassCategory NVARCHAR(50) NOT NULL, -- Student, General, Senior Citizen, Employee
    IdProofType NVARCHAR(50) NOT NULL,  -- Aadhaar, College ID, Voter ID, Passport
    IdProofNumber NVARCHAR(50) NOT NULL,
    RouteId INT NOT NULL FOREIGN KEY REFERENCES dbo.Routes(RouteId),
    SourceStop NVARCHAR(100) NOT NULL,
    DestinationStop NVARCHAR(100) NOT NULL,
    ValidityPeriod NVARCHAR(30) NOT NULL, -- 1 Month, 3 Months, 6 Months, 1 Year
    StartDate DATE NOT NULL,
    ExpiryDate DATE NOT NULL,
    FareAmount DECIMAL(10,2) NOT NULL,
    Discount DECIMAL(10,2) DEFAULT 0.00,
    TotalAmount DECIMAL(10,2) NOT NULL,
    Status NVARCHAR(20) DEFAULT 'Active', -- Active, Expired, Cancelled
    CreatedDate DATETIME DEFAULT GETDATE()
);
GO

-- Sample initial passes
INSERT INTO dbo.Passes (PassNumber, FullName, Gender, Age, ContactNumber, Email, Address, PassCategory, IdProofType, IdProofNumber, RouteId, SourceStop, DestinationStop, ValidityPeriod, StartDate, ExpiryDate, FareAmount, Discount, TotalAmount, Status)
VALUES 
('BP-1001', 'Rahul Sharma', 'Male', 21, '9876543210', 'rahul.s@example.com', 'Flat 402, Sunshine Apts, City Road', 'Student', 'College ID', 'CLG-2024-88', 2, 'Railway Station', 'Central University', '3 Months', CAST(GETDATE() AS DATE), CAST(DATEADD(month, 3, GETDATE()) AS DATE), 1200.00, 360.00, 840.00, 'Active'),
('BP-1002', 'Priya Patel', 'Female', 28, '9876501234', 'priya.p@example.com', '12 Lake View Residency', 'General', 'Aadhaar Card', '9123-4567-8901', 3, 'Suburbs North', 'IT Park Complex', '1 Month', CAST(GETDATE() AS DATE), CAST(DATEADD(month, 1, GETDATE()) AS DATE), 750.00, 0.00, 750.00, 'Active'),
('BP-1003', 'Ramesh Kumar Verma', 'Male', 66, '9812345678', 'ramesh.v@example.com', '54 Greenfield Colony', 'Senior Citizen', 'Aadhaar Card', '4521-8899-1234', 1, 'Main Bus Terminal', 'City Center Mall', '6 Months', CAST(GETDATE() AS DATE), CAST(DATEADD(month, 6, GETDATE()) AS DATE), 3000.00, 1500.00, 1500.00, 'Active');
GO

-- Table: PassRenewals (History of renewals)
IF OBJECT_ID('dbo.PassRenewals', 'U') IS NOT NULL DROP TABLE dbo.PassRenewals;
CREATE TABLE dbo.PassRenewals (
    RenewalId INT IDENTITY(1,1) PRIMARY KEY,
    PassId INT NOT NULL FOREIGN KEY REFERENCES dbo.Passes(PassId),
    PassNumber NVARCHAR(30) NOT NULL,
    PreviousExpiryDate DATE NOT NULL,
    NewExpiryDate DATE NOT NULL,
    MonthsExtended INT NOT NULL,
    RenewalAmount DECIMAL(10,2) NOT NULL,
    RenewalDate DATETIME DEFAULT GETDATE()
);
GO
