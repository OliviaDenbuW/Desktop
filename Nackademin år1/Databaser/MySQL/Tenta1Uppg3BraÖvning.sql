--Uppgift 3
--Ta tv� inparam som heter companyName och City. Dessa ska s�ttas som s�kvillkor
--i tsq-fr�gn. Ta fram companyname f�r supplier, namn p� alla produkter
--den levererar samt namn p� kategorin p� varje produkt. S�kvill beh�vr
--inte vara exakt. Visa �ven suppliers som har ett companyname elr city som
--inneh�ller s�kvillkoret.

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






