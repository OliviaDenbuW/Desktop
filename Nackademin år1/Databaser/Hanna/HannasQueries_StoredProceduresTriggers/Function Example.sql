create function GetNumberOfProducts()
returns int

begin

	return (select sum(p.UnitPrice * p.UnitsInStock) from Products p)
end

--select dbo.GetNumberOfProducts() as 'Total Number of Products'

--alter function GetNumberOfProducts(
--	@SupplierName varchar(40)
--)
--returns int

--begin

--	return (
--		select sum(p.UnitPrice * p.UnitsInStock) 
--		from Products p
--		inner join Suppliers s
--		on s.SupplierID = p.SupplierID
--		where s.CompanyName = @SupplierName
--	)
--end  


--select dbo.GetNumberOfProducts('Exotic Liquids') as 'Total Number of Products'

--select * from Products p
--		inner join Suppliers s
--		on s.SupplierID = p.SupplierID
--		where s.CompanyName = 'Exotic Liquids'