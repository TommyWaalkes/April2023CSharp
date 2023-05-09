--CREATE DATABASE AdvDB;
--USE AdvDB;

--CREATE TABLE Student (
--	id INT PRIMARY KEY IDENTITY(1,1),
--	FName NVARCHAR(25),
--	LName NVARCHAR(25)
--);

--INSERT INTO Student (FName, LName)
--VALUES ('Justin', 'Jones'),
--('Harry', 'Nguyen'),
--('Mikael', 'Addae'),
--('Daniel', 'Larsen'),
--('Tim', 'Holleque'),
--('Yiding','Wang'),
--('Chris','Angotti');

--SELECT * FROM Student;

--DELETE FROM Student
--WHERE id = 1;

--CREATE TABLE Tickets (
--	id int PRIMARY KEY IDENTITY(1,1),
--	Seat NVARCHAR(20),
--	Price int,
--	Num_sold int
--);

--INSERT INTO Tickets (Seat, Price, Num_sold)
--VALUES ('Box Level', 105, 4),
--('Dress Circle', 75, 2),
--('Main Floor', 58, 10),
--('Mid Balcony', 38, 0),
--('Upper Balcony', 19 ,3);

--How many rows
--SELECT COUNT(*) AS TicketTypes FROM Tickets;

--SELECT COUNT(*) FROM Tickets
--WHERE Num_sold <> 0;

--Add numbers together
--SELECT SUM(num_sold) AS TicketsSold FROM Tickets;

--Find the average value
--SELECT AVG(price) AS Average FROM Tickets;

--Find the highest value
--SELECT MAX(num_sold) AS MaxSold FROM Tickets

--Find the lowest value
--SELECT MIN(Price) FROM Tickets;

--Combo together
--SELECT SUM(num_sold) AS 'Total Sold', SUM(price * num_sold) AS 'Total Revenue'
--FROM Tickets;

--CREATE TABLE Child (
--	ID INT PRIMARY KEY IDENTITY(1,1),
--	[Name] NVARCHAR(255),
--	Student_ID INT FOREIGN KEY REFERENCES Student(id)
--);

--SELECT * FROM Student;
--SELECT * FROM Child;

--INSERT INTO Child ([Name], Student_ID)
--VALUES ('Clifford', Null),
--('Yumi the cat', 8),
--('Layla the Cat',5)

--Default = Inner
--Only brings back matches
--SELECT * FROM Student
--INNER JOIN Child ON Student.id = Child.Student_ID;

--Left join brings all from left table
--SELECT * FROM Student
--LEFT JOIN Child ON Student.id = Child.Student_ID;

--Right join brings all from right table
--SELECT * FROM Student
--RIGHT JOIN Child ON Student.id = Child.Student_ID;

--FULL join brings all back
--SELECT * FROM Student
--FULL JOIN Child ON Student.id = Child.Student_ID;

--Connects everything
--SELECT * FROM Student
--CROSS JOIN Child;