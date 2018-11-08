--Tenta1 - Uppgift 2
SELECT SUM(p.UnitPrice) AS [Totala värdet] FROM Products p
med datum

--Tenta2 - Uppgift 3
CREATE PROCEDURE SupplierSearch
@CompanyName NVARCHAR(50),
@City NVARCHAR(50)
AS
BEGIN
	SELECT CompanyName FROM Suppliers s FULL JOIN Products p 
	ON s.CompanyName=p.ProductName
	WHERE CompanyName = @CompanyName AND City = @City

	SELECT Category FROM Categories c FULL JOIN Products p
	ON c.CategoryName=p.
END

Ta två inparam som heter companyName och City. Dessa ska sättas som sökvillkor
i tsq-frågn. Ta fram companyname för supplier, namn på alla produkter
den levererar samt namn på kategorin på varje produkt. Sökvill behövr
inte vara exakt. Visa även suppliers som har ett companyname elr city som
innehåller sökvillkoret.

T-SQL


--Tenta2 - Uppgift 4
Hämta companyName för alla kunder i db.  Visa samtidigt shippedate för de
orders som varje kund beställt samt namn på den shipp som leverar ordern

Visa t-sql-frågan för att ta fram detta

SELECT CompanyName FROM Customers

--Uppgift 5
Skapa en metod i C# som returnerar en lista med alla suppliers som har (
leverear) mer än 3 produ - ENFR


--Uppgift 6
Metod i c# som döper till UpdatedPrice(). Ska uppdatera priset på alla 
prod med 10%. ENBART prod i kateg BEVERAGES - ADO.NET

--Uppgift 7
Metod prodSearch. den ska ha inparameter
 namnet på produkten samt priset på produkten. 
 ska returnera en lista med prod som innehåller sökvillkoret. Produktens
 namn ska innehålla inparametern med namn och 
 produktens pris ska vara större än inparams pris

  EFR - C#

--Uppgift 8
Hämta companyname o productname för alla produkter som kunder
i settle usa beställt. T-SQL
SELECT CompanyName, ProductName FROM Customers c FULL JOIN Products p 
	ON c.CustomerID=p.
	WHERE CompanyName = @CompanyName AND City = @City

	SELECT Category FROM Categories c FULL JOIN Products p
	ON c.CategoryName=p.
