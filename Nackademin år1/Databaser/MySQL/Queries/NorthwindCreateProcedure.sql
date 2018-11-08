--To get list of all the orders processed with category name as an input
--parameter

create procedure OrdersProcessed
@categoryName nvarchar(15)
as
	select Orders.OrderID, Categories.CategoryName from Orders
	inner join [Order Details] on Orders.OrderID = [Order Details].OrderID
	inner join Products on [Order Details].ProductID = Products.ProductID
	inner join Categories on Products.CategoryID = Categories.CategoryID
	where @categoryName != '' and Categories.CategoryName like '%' +
	@categoryName + '%'
go

exec OrdersProcessed 'Beverages'


--Get the product name, count of orders processed

select * from Products
select * from [Order Details]

create procedure GetProdNameAndQuantityOfOrders
as
begin
	select Products.ProductName, [Order Details].Quantity from Products
	inner join [Order Details] on Products.ProductID = [Order Details].ProductID
end

exec GetProdNameAndQuantityOfOrders


--Get the top 3 products which has more orders
select * from Products
select * from [Order Details]

select top 3 productName, Quantity from Products
inner join [Order Details] on Products.ProductID = [Order Details].ProductID
order by quantity desc

--Get the list of the months which doesn’t have any orders for product chai
select * from Products
select * from [Order Details]
select * from orders

select ProductName, month(OrderDate) from Orders
inner join [Order Details] on Orders.OrderID = [Order Details].OrderID
inner join Products on [Order Details].ProductID = Products.ProductID
where ProductName != 'chai'
order by month(OrderDate) asc

create procedure SupplierSearch
@companyName nvarchar(50),
@city nvarchar(15)
as
	select s.CompanyName, p.ProductName, c.CategoryName from Suppliers
	inner join Products p on Suppliers.SupplierID = Products.SupplierID
	inner join Categories c on Products.CategoryID = Categories.CategoryID
	where (@companyName != '' and Suppliers.CompanyName like '%' + @companyName +
	'%') or (@city != '' and Suppliers.City like '%' + @city + '%')
go