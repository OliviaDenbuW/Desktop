--Inner join (Det de har gemensamt)

SELECT Orders.OrderID, Orders.OrderDate
FROM Orders
INNER JOIN Customers ON Orders.CustomerID=Customers.CustomerID;

--Left join
--H�mta companyName f�r alla kunder i databasen. Visa samtidigt shippedDate f�r de orders
--som varje kund best�llt, samt namn p� den shipper som levererar ordern
select * from Customers
select * from Orders
select * from Shippers

select Customers.CompanyName, Orders.ShippedDate, Shippers.CompanyName from Customers
left join Orders on Customers.CustomerID = Orders.CustomerID
left join Shippers on Orders.ShipVia = Shippers.ShipperID

--Inner join
--H�mta productName och companyName f�r alla produkter som kunder i Settle USA har best�llt.
select * from Products
select * from Orders
select * from [Order Details]
select * from Customers

select Customers.CompanyName, Products.ProductName, Customers.City, Customers.Country from Customers
inner join Orders on Customers.CustomerID = Orders.CustomerID
inner join [Order Details] on Orders.OrderID = [Order Details].OrderID
inner join Products on [Order Details].ProductID = Products.ProductID
where Customers.City = 'Seattle'

--Ta fram totala v�rdet f�r alla produkter i Productstabellen. VIsa totalsumman f�r detta
--tillsammans med dagens datum. Datum ska visas med �rtal, m�nad och dag, INTE tid. Koden
--ska fungera �ven om �rtal, m�nad och dag �ndras, dvs det �r INTE till�tet att h�rdkoda datum.

select sum(p.UnitPrice * p.UnitsInStock) [Total Stock Value], cast(current_timestamp as date) [Todays date]
from Products p

--GROUP BY - Aggregate functions
SELECT COUNT(CustomerID), Country
FROM Customers
GROUP BY Country;

SELECT COUNT(CustomerID), Country FROM Customers
GROUP BY Country
ORDER BY COUNT(CustomerID) DESC;

--Get the list of the employees and the count of orders they
--processed in the month of �march �across all the years



