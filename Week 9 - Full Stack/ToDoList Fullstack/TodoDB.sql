--Create database ToDoList; 

--create table Employee(
--id int primary key identity(1,1), 
--[name] nvarchar(20), 
--[hours] int, 
--title nvarchar(40)
--);

--insert into Employee
--values(
--	'Jimmy Scrambes', 
--	30, 
--	'Accountant'
--),
--(
--	'Sarah Grapes', 
--	40, 
--	'Developer'
--), 
--(
--	'Guy Fieri', 
--	40,
--	'Mayor of Flavortown');

--select * from Employee; 

--create table ToDos
--(
--	id int primary key identity(1,1), 
--	[name] nvarchar(25), 
--	[description] nvarchar(100), 
--	assignedTo int foreign key references Employee(id), 
--	hoursNeeded int, 
--	isComplete bit
--);

--insert into ToDos 
--values('Water Plants', 'Plants need water', 13, 1, 0),
--('Cheat on Taxes', 'Dont let the irs know', 13, 10, 0),
--('Hack into the FBI', 'We need some case files deleted', 13, 25, 1)

select * from employee;
select * from ToDos;