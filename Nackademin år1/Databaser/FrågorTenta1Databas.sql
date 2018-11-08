--Tenta1 - Uppgift 2
SELECT SUM(p.UnitPrice) AS [Totala v�rdet] FROM Products p
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

Ta tv� inparam som heter companyName och City. Dessa ska s�ttas som s�kvillkor
i tsq-fr�gn. Ta fram companyname f�r supplier, namn p� alla produkter
den levererar samt namn p� kategorin p� varje produkt. S�kvill beh�vr
inte vara exakt. Visa �ven suppliers som har ett companyname elr city som
inneh�ller s�kvillkoret.

T-SQL


--Tenta2 - Uppgift 4
H�mta companyName f�r alla kunder i db.  Visa samtidigt shippedate f�r de
orders som varje kund best�llt samt namn p� den shipp som leverar ordern

Visa t-sql-fr�gan f�r att ta fram detta

SELECT CompanyName FROM Customers

--Uppgift 5
Skapa en metod i C# som returnerar en lista med alla suppliers som har (
leverear) mer �n 3 produ - ENFR


--Uppgift 6
Metod i c# som d�per till UpdatedPrice(). Ska uppdatera priset p� alla 
prod med 10%. ENBART prod i kateg BEVERAGES - ADO.NET

--Uppgift 7
Metod prodSearch. den ska ha inparameter
 namnet p� produkten samt priset p� produkten. 
 ska returnera en lista med prod som inneh�ller s�kvillkoret. Produktens
 namn ska inneh�lla inparametern med namn och 
 produktens pris ska vara st�rre �n inparams pris

  EFR - C#

--Uppgift 8
H�mta companyname o productname f�r alla produkter som kunder
i settle usa best�llt. T-SQL
SELECT CompanyName, ProductName FROM Customers c FULL JOIN Products p 
	ON c.CustomerID=p.
	WHERE CompanyName = @CompanyName AND City = @City

	SELECT Category FROM Categories c FULL JOIN Products p
	ON c.CategoryName=p.
