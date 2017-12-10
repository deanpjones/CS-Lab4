USE Northwind;

SELECT * FROM Orders;
SELECT * FROM [Order Details];

SELECT OrderID, CustomerID, OrderDate, RequiredDate, ShippedDate FROM Orders;
SELECT * FROM [Order Details];

--Get first OrderID
SELECT TOP 1 OrderID FROM Orders ORDER BY OrderID ASC;

--Get OrderID column...
SELECT OrderID FROM Orders ORDER BY OrderID ASC;

--Get all Order_Details by OrderID#
SELECT * FROM [Order Details]
	WHERE OrderID = 10248
	ORDER BY ProductID;

SELECT * FROM[Order Details] WHERE OrderID = 10250;

--UPDATE
SELECT OrderID, CustomerID, OrderDate, RequiredDate, ShippedDate FROM Orders WHERE OrderID = 10248;
UPDATE Orders SET ShippedDate='1996-07-17 00:00:00.000' WHERE OrderID = 10248;