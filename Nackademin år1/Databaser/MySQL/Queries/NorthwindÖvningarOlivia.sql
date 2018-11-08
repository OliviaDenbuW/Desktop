--1. Select CategoryName and Description from the Categories table
--sorted by CategoryName.

select CategoryName, [Description] from Categories
order by CategoryName

--2. Select ContactName, CompanyName, ContactTitle, and Phone from
--the Customers table sorted by Phone.

select ContactName, CompanyName, ContactTitle, Phone from Customers
order by Phone

--3. Create a query showing employees' first and last names and hire dates
--sorted from newest to oldest employee.

select FirstName, LastName, HireDate from Employees
order by HireDate desc

--4. Create a query showing Northwind's orders sorted by Freight from most
--expensive to cheapest. Show OrderID, OrderDate, ShippedDate,
--CustomerID, and Freight.

select Freight, OrderID, OrderDate, ShippedDate, CustomerID from Orders
order by Freight desc

--5. Select CompanyName, Fax, Phone, HomePage and Country from
--the Suppliers table sorted by Country in descending order and then
--by CompanyName in ascending order

select Country, CompanyName, Fax, Phone, HomePage from Suppliers
order by Country desc, CompanyName asc

--6. Create a query showing all the company names and contact names
--of Northwind's customers in Buenos Aires

select CompanyName, ContactName, City from Customers
where City = 'Buenos Aires'

--7. Create a query showing the order date, shipped date, customer id, and
--freight of all orders placed onMay 19, 1997.select OrderDate, ShippedDate, CustomerId, freight from Orderswhere ShippedDate = '1997-05-19'--8. Create a query showing the first name, last name, and country of
--all employees not in the UnitedStates.

select firstName, lastName, Country from Employees
where Country <> 'USA'


--9. Create a query that shows the employee id, order id, customer id,
--required date, and shipped date of all orders that were shipped
--later than they were required.

select employeeId, orderId, customerId, requiredDate, ShippedDate from Orders
where ShippedDate > RequiredDate

--10. Create a query that shows the city, company name, and contact
--name of all customers who are in cities that begin with "A" or "B."

select city, companyName, contactName from Customers
where city like '[AB]%'

--11-  Create a query that shows all orders that have a freight cost of
--more than $500.00.

select Freight from Orders
where Freight > 500

--12. Create a query that shows the product name, units in stock, units
--on order, and reorder level of all products that are up for reorder.

select ProductName, UnitsInStock, UnitsOnOrder, ReorderLevel from Products
where ReorderLevel != 0

--13. Get the top 3 products which has more orders

select * from Products
select* from [Order Details]

select top 3 Quantity, ProductName from [Order Details]
inner join Products on [Order Details].ProductID = Products.ProductID
order by Quantity desc

--14. --Get category name , count of orders processed by the USA
--employees
Quantity - Order Details
USA - country - Employees
Category name - Categories

select * from Orders
select * from [Order Details]
select * from Products
select * from Categories
select * from Employees

select Country, Quantity, Country from Employees
inner join Orders on Employees.EmployeeID = Orders.EmployeeID
inner join [Order Details] on Orders.OrderID = [Order Details].OrderID
inner join Products on [Order Details].ProductID = Products.ProductID
inner join Categories on Products.CategoryID = Categories.CategoryID
where employees.Country = 'USA'


