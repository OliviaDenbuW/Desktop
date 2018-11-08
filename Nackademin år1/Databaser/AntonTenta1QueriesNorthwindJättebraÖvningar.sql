--Select CategoryName and Description from the Categories table
--sorted by CategoryName.

select CategoryName, [Description] from Categories
order by CategoryName

--Create a query showing employees' first and last names and hire dates
--sorted from newest to oldest employee.
select FirstName, LastName, HireDate from Employees
order by HireDate desc

--Select CompanyName, Fax, Phone, HomePage and Country from
--the Suppliers table sorted by Country in descending order and then
--by CompanyName in ascending order.
select CompanyName, Fax, Phone, HomePage, Country from Suppliers
order by Country desc, CompanyName


--Ta tv� inparam som heter companyName och City. Dessa ska s�ttas som s�kvillkor
--i tsq-fr�gn. Ta fram companyname f�r supplier, namn p� alla produkter
--den levererar samt namn p� kategorin p� varje produkt. S�kvill beh�vr
--inte vara exakt. Visa �ven suppliers som har ett companyname elr city som
--inneh�ller s�kvillkoret.
select * from Suppliers
select * from Products
select * from Categories

select companyName, ProductName, CategoryName from Suppliers
inner join Products on
Suppliers.SupplierId = Products.SupplierID
inner join Categories on
Products.CategoryID = Categories.CategoryID
where Suppliers.City = 'London' or Suppliers.CompanyName = 'Exotic Liquids'

--Tenta2 - Uppgift 4
--H�mta companyName f�r alla kunder i db.  Visa samtidigt shippedate f�r de
--orders som varje kund best�llt samt namn p� den shipp som leverar ordern

--companyname f�r kunder
--shippingdate f�r orders
--name p� shipping

select * from Orders 
select * from Customers

select companyName, ShippedDate, ShipName from Customers
inner join Orders on
Customers.CustomerID = Orders.CustomerID

--Uppgift 8
--H�mta companyname o productname f�r alla produkter som kunder
--i settle usa best�llt.
select * from Customers
where city = 'seattle'
select * from Orders
select * from Products
select * from Suppliers
select * from [Order Details]

select suppliers.CompanyName, ProductName from Customers
inner join Orders on Customers.CustomerID = Orders.CustomerID
inner join [Order Details] on Orders.OrderID = [Order Details].OrderID
inner join Products on [Order Details].ProductID = Products.ProductID
inner join Suppliers on Products.SupplierID = Suppliers.SupplierID
where Customers.City = 'Seattle'

--Create a query showing the first name, last name, and country of
--all employees not in the UnitedStates.
select FirstName, LastName, Country from Employees
where Country <> 'USA'

--Create a query that shows the city, company name, and contact
--name of all customers who are in cities that begin with "A" or "B."
select city, CompanyName, ContactName, City from Customers
where city like '[AB]%'

--Get the top 3 products which has more orders
select * from Products
select* from Orders
select* from [Order Details]

select top 3 ProductName, Quantity from [Order Details]
inner join Products on [Order Details].ProductID = Products.ProductID
order by Quantity desc

--Get the list of the employees and the count of orders they
--processed in the month of �march �across all the years

--name of employees
--processed orders in march

select * from Employees
select * from Orders

select EmployeeID, count(*) from Orders
where month(OrderDate) = 3
group by EmployeeID

--select * from Orders
--where month(OrderDate) = 3
--and EmployeeID = 1

--select * from Orders
--where month(OrderDate) = 3 

--select OrderDate, month(OrderDate) from Orders

--Get category name , count of orders processed by the USA
--employees

--employees in USA
--

select * from Orders
select * from [Order Details]

select Categories.CategoryName, count(*) from Categories
inner join Products on Categories.CategoryID = Products.CategoryID
inner join [Order Details] on Products.ProductID = [Order Details].ProductID 
inner join Orders on [Order Details].OrderID = Orders.OrderID
inner join Employees on Orders.EmployeeID = Employees.EmployeeID
where Employees.Country = 'USA'
group by Categories.CategoryName
--Create a query that shows the first and last names and birth date of all
--employees born in the 1950s.

select FirstName, LastName, BirthDate from Employees
where year(BirthDate) >= 1950 and year(BirthDate) < 1960


--Create a query that shows the product name and supplier id for all
--products supplied by ExoticLiquids, Grandma Kelly's Homestead,
--and Tokyo Traders.
--Hint :
--you will need to first do a separate SELECT on the Suppliers table to find the
--supplier ids of these three companies

select ProductName, Suppliers.SupplierID from Products
inner join Suppliers on Products.SupplierID = Suppliers.SupplierID
where CompanyName = 'Exotic Liquids' or CompanyName = 'Grandma Kelly''s Homestead'
 or CompanyName ='Tokyo Traders'

--Create a query that shows the company name, contact title, city
--and country of all customers in Mexico or in any city in Spain except
--Madrid

select CompanyName, ContactTitle, city, country from Customers
where Country = 'Mexico' or Country = 'Spain' and city <> 'Madrid'

--Create a query that shows the contact name and title and the
--company name for all customers whose contact title does not
--contain the word "Sales".

select CompanyName, ContactName, ContactTitle from customers
where ContactTitle not like '%Sales%'




