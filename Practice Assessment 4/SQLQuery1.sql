-- 1
--CREATE DATABASE CompanyDb;
--Use CompanyDb;

-- 2
--CREATE TABLE Department (
--	Id INT PRIMARY KEY IDENTITY(1,1),
--	[Name] NVARCHAR(25) NOT NULL,
--	Hiring BIT,
--	Location NVARCHAR(50)
--);

--3
--INSERT INTO Department (Name, Hiring, Location)
--VALUES ('Technology', 1, '1570 Woodward Ave.'),
--('Shipping & Receiving', 0, 'Southfield');
--SELECT * FROM Department

--4
--CREATE TABLE Employee (
--	SSN NCHAR(9) PRIMARY KEY,
--	DOB DATE,
--	Phone NCHAR(10),
--	FirstName NVARCHAR(30) NOT NULL,
--	LastName NVARCHAR(30) NOT NULL,
--	DepartmentId INT FOREIGN KEY REFERENCES Department(Id)
--)

--5
--INSERT INTO Employee (SSN, DOB, Phone,FirstName, LastName, DepartmentId)
--VALUES ('123456789', '1/5/1975', '3135555505', 'Charles', 'Charleston', 2),