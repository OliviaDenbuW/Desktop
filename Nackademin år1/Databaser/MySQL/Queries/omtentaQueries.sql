select companyName, phone from Customers

select * from Orders
select * from [Order Details]
select * from Customers
select * from Products
select * from Categories

	create view View2 (CompanyName, Country, ProductName, CategoryName)
	as select cu.companyName, cu.country, p.ProductName, ca.CategoryName from Customers cu
	left join Orders o on cu.CustomerID = o.CustomerID
	left join [Order Details] orDe on o.OrderID = orDe.OrderID
	left join Products p on orDe.ProductID = p.ProductID
	left join Categories ca on p.CategoryID = ca.CategoryID
	where cu.Country = 'USA'

create procedure StoredProcedure
@categoryID int,
@minimunStockValue
as
begin
	select CompanyName from View2
	where (categoryID like '%' + 
	@categoryID + '%') and (products.UnitsInStock < ('%' + @minimunStockValue + '%'))
end



--Uppg2
select * from Products
select * from Customers

--Uppg4
select * from products
select * from Categories

--Uppg5
select count(*) as Antal from Customers cwhere c.Fax IS NULLselect * from Customersinner join Employees eon o.EmployeeID = e.EmployeeIDwhere Month(o.OrderDate) = 3Group by e.EmployeeID, e.FirstName, e.LastNameOrder by NumberOfOrders desc--Uppg6select CategoryName, UnitPrice from Productsleft join Categories on Products.CategoryID = Categories.CategoryIDwhere CategoryName = 'Seafood'--Uppg7create table Toys (	ToyID int,	[Description] nvarchar(40),	MadeBySanta bit	);	select * from Toys	insert into Toys	values (2, 'hejdåååå', 0)	create table Toys (	ToyID int,	[Description] nvarchar(40),	MadeBySanta bit	);	select * from Toys	insert into Toys	values (2, 'hejdåååå', 0)--Uppg8create procedure AddToys1@Description nvarchar(40),@MadeBySanta bitasbegin	insert into Toys (ToyID, [Description], MadeBySanta)	values (@Description, @MadeBySanta)endexec AddToys 'Santas white angel', 1--Uppg7create table Toys1 (	ToyID int identity(1,1) PRIMARY KEY,	[Description] nvarchar(40),	MadeBySanta bit	);--Uppg 8create procedure AddToys3@Description nvarchar(40),@MadeBySanta bitasbegin	insert into Toys1 ([Description], MadeBySanta)	values (@Description, @MadeBySanta)endselect * from Toys1exec AddToys3 'Hejdåååååååå', 0