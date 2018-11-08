--Inner join (Det de har gemensamt)

SELECT Orders.OrderID, Orders.OrderDate
FROM Orders
INNER JOIN Customers ON Orders.CustomerID=Customers.CustomerID;

--Left join
--Hämta companyName för alla kunder i databasen. Visa samtidigt shippedDate för de orders
--som varje kund beställt, samt namn på den shipper som levererar ordern
select * from Customers
select * from Orders
select * from Shippers

select Customers.CompanyName, Orders.ShippedDate, Shippers.CompanyName from Customers
left join Orders on Customers.CustomerID = Orders.CustomerID
left join Shippers on Orders.ShipVia = Shippers.ShipperID

--Inner join
--Hämta productName och companyName för alla produkter som kunder i Settle USA har beställt.
select * from Products
select * from Orders
select * from [Order Details]
select * from Customers

select Customers.CompanyName, Products.ProductName, Customers.City, Customers.Country from Customers
inner join Orders on Customers.CustomerID = Orders.CustomerID
inner join [Order Details] on Orders.OrderID = [Order Details].OrderID
inner join Products on [Order Details].ProductID = Products.ProductID
where Customers.City = 'Seattle'

--Ta fram totala värdet för alla produkter i Productstabellen. VIsa totalsumman för detta
--tillsammans med dagens datum. Datum ska visas med årtal, månad och dag, INTE tid. Koden
--ska fungera även om årtal, månad och dag ändras, dvs det är INTE tillåtet att hårdkoda datum.

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
--processed in the month of “march “across all the years



