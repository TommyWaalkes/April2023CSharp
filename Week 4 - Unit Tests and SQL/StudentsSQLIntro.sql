-- I tend to comment out lines I don't need rather than delete them 
-- that way if I find mistake in my database or I want to change my table columns 
-- or if, heaven forbid, something breaks, I can uncomment my old SQL lines 
--and rerun them. 

-- create database School;
-- Blue words are keywords in SQL 
--create table Students
--(
--	id int primary key identity(1,1),
--	[name] nvarchar(35),
--	age int, 
--	averageGrade float, 
--	isPassing bit
--);

-- You can't always trust SQL Error highlighting 
-- The true test of whether something will woek is running the query
--drop table Students; 

-- Think of values as similar to an object constructor
insert into Students 
values('Kenny Coleslaw', 45, 85.5, 1),
('Jimmy Scrambles', 22, 90, 1), 
('Joey Balooney', 38, 60, 0);

--update Students 
--set averageGrade = 70
--where isPassing = 1 ;

--delete from students 
--where isPassing = 1;

select * from Students;