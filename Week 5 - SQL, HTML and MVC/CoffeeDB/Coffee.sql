--use CoffeeDB;

--CREATE TABLE Customer(
--	ID INT PRIMARY KEY IDENTITY(1,1),
--	[Name] NVARCHAR(255),
--	FavDrink INT FOREIGN KEY REFERENCES Coffee(ID)
--);



--INSERT INTO Customer ([Name], FavDrink)
--VALUES ('Justin', 9),
--('Austin', 1),
--('Bustin', 3),
--('Rustin', 4),
--('Dustin', 2),
--('Mustin', 9),
--('Lustin', 4),
--('Hustin', 5),
--('Gustin', 7),
--('Pustin', 8);

--SELECT * FROM Customer;

--SELECT * FROM Customer
--ORDER BY [Name];

--SELECT * FROM Customer
--INNER JOIN Coffee ON Customer.FavDrink = Coffee.ID;

--SELECT * FROM Customer
--INNER JOIN Coffee ON Customer.FavDrink = Coffee.ID
--WHERE FavDrink = 1;

--UPDATE Customer
--SET FavDrink = 5
--WHERE ID = 10;

--SELECT * FROM Customer
--INNER JOIN Coffee ON Customer.FavDrink = Coffee.ID
--WHERE FavDrink > 2;

--DELETE FROM Customer
--WHERE ID = 10;