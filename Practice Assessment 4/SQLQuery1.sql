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
--VALUES ('123456789', '1/5/1975', '3135555505', 'Charles', 'Charleston', 2),--('987654321', '5/2/1990', '2489995555', 'Jimmy', 'Scrambles', 1),--('456789123', '8/6/2001', '7895555525', 'Vince', 'Jabowski', 1),--('654854632', '4/6/1988', '3139721400', 'John', 'Johnston', 2);--SELECT * FROM Employee;--6--UPDATE Employee--SET LastName = 'Spiderman'--WHERE DOB = (SELECT MAX(DOB) FROM Employee);--SELECT * FROM Employee;--7--SELECT * FROM Employee--WHERE LastName LIKE 'J%';--8--DELETE FROM Employee--WHERE DOB = (SELECT MIN(DOB) FROM Employee);--SELECT * FROM Employee;--9--SELECT * FROM Employee--WHERE Phone LIKE '(313)%';--10--SELECT * FROM Employee--WHERE DOB < '9/9/1999';----11--UPDATE Employee--SET Phone = NULL--WHERE YEAR(DOB) > '2000';--12--SELECT * FROM Employee--WHERE Phone IS NULL;-- 13--SELECT Employee.FirstName, Employee.LastName, Department.Name, Department.Location FROM Employee--JOIN Department ON Employee.DepartmentId = Department.Id;-- 14--DELETE FROM Employee;--SELECT * FROM Employee;--DELETE FROM Department;--SELECT * FROM Department;--DROP TABLE Employee;--DROP TABLE Department;