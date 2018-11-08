--Uppgift 3
--Ta två inparam som heter companyName och City. Dessa ska sättas som sökvillkor
--i tsq-frågn. Ta fram companyname för supplier, namn på alla produkter
--den levererar samt namn på kategorin på varje produkt. Sökvill behövr
--inte vara exakt. Visa även suppliers som har ett companyname elr city som
--innehåller sökvillkoret.

select * from Suppliers
select * from Products
select * from Categories

companyName - Suppliers
city - Suppliers
productName - Products
supplierID - products
categoryID - Products
categoryName - Categories

create procedure SuppliersSearch
@companyName nvarchar(100),
@city nvarchar(100)
as
begin
	select companyName, city, ProductName, CategoryName from Suppliers s
	inner join Products p on s.SupplierID = p.SupplierID
	inner join Categories c on p.CategoryID = c.CategoryID
	where (@companyName != '' and s.CompanyName like '%' + @companyName + '%') or
	(@city != '' and s.City like '%' + @city + '%') 
end;






