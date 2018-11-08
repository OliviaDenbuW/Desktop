--Get the list of the employees who processed the orders belongs to his own city--Get the list of the employees and the count of orders they processed in the month of “march “across all the yearsselect e.EmployeeID, e.FirstName, e.LastName, count(*) as NumberOfOrdersfrom Orders oinner join Employees eon o.EmployeeID = e.EmployeeIDwhere Month(o.OrderDate) = 3Group by e.EmployeeID, e.FirstName, e.LastNameOrder by NumberOfOrders descselect * from Employees--Get the list of employees who processed the order “chai”select distinct e.FirstName, e.LastNamefrom			Employees einner join		[Orders] oon				e.EmployeeID = o.EmployeeIDinner join		[Order Details] odon				o.OrderID = od.OrderIDinner join		Products pon				od.ProductID = p.ProductIDwhere			p.ProductName = 'Chai'--Get the list of the products which doesn’t have any orders across all the months and year asselect distinct p.ProductNamefrom			Products pinner join		[Order Details] odon				p.ProductID = od.ProductIDinner join		[Orders] oon				od.OrderID = o.OrderIDwhere			o.OrderDate = null--Get the list of the months which doesn’t have any orders for product chaiselect distinct	convert(varchar(7), o.OrderDate, 126) as [Date]from			Orders oinner join		[Order Details] odon				o.OrderID = od.OrderIDinner join		Products pon				od.ProductID = p.ProductIDwhere			p.ProductName <> 'Chai'order by		[Date]--Get the top 3 products which has more ordersselect top(3)	p.ProductName, count(*) as TotalOrdersfrom			[Order Details] odinner join		Products pon				od.ProductID = p.ProductIDgroup by		p.ProductNameorder by		count(*) desc--Create a query that shows the product name, units in stock, units on order, and reorder level of all products that are up for reorder.select ProductName, UnitsInStock, UnitsOnOrder, ReorderLevelfrom Productswhere ReorderLevel > 0;--Create a query that shows all orders that have a freight cost of more than $500.00.select *from OrdersWhere Freight < $500.00;--Create a query that shows the city, company name, and contact name of all customers who are incities that begin with "A" or "B."select City, CompanyName, ContactNamefrom Customerswhere City like 'A%' or City like 'B%';--Create a query that shows the employee id, order id, customer id, required date, and shipped date of all orders that were shipped later than they were required.select EmployeeID, OrderID, CustomerID, RequiredDate, ShippedDatefrom Orderswhere ShippedDate > RequiredDate;--Create a query showing the first name, last name, and country of all employees not in the UnitedStates.select FirstName, LastName, Countryfrom Employeeswhere Country <> 'USA';--Create a query showing the order date, shipped date, customer id, and freight of all orders placed onMay 19, 1997.select OrderDate, ShippedDate, CustomerID, Freightfrom Orderswhere OrderDate = '05/19/1997'--Create a query showing the product name, unit price and quantity per unit of all products that are out of stock.select ProductName, UnitPrice, QuantityPerUnit
from Products
where UnitsInStock = 0;


--Create a query showing all the company names and contact names of Northwind's customers in Buenos Aires.
select CompanyName, ContactName
from Customers
where City = 'Buenos Aires';


--Select CompanyName, Fax, Phone, HomePage and Country from the Suppliers table sorted by Country in descending order and then by CompanyName in ascending order.
select CompanyName, Fax, Phone, HomePage, Country
from Suppliers
order by Country desc, CompanyName asc;


--Create a query showing Northwind's orders sorted by Freight from most expensive to cheapest. Show OrderID, OrderDate, ShippedDate, CustomerID, and Freight.
select OrderID, OrderDate, ShippedDate, CustomerID, Freight
from Orders
order by Freight desc;


--Create a query showing employees' first and last names and hire dates sorted from newest to oldest employee.
select FirstName, LastName, HireDate
from Employees
order by HireDate desc;


--Select ContactName, CompanyName, ContactTitle, and Phone from the Customers table sorted by Phone.
select ContactName, CompanyName, ContactTitle, Phone
from Customers
order by Phone;


--Select CategoryName and Description from the Categories table sorted by CategoryName.
select CategoryName, [Description]
from Categories
order by CategoryName;
