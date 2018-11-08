
-----------------------------------------
--   SELECT
-----------------------------------------

--1. Ta fram all information f�r alla kunder som finns (tabellen Customers). Sortera resultatet p�
--   kundnamnet . B�rja med �asc� och �ndra till �desc�. Vilken skillnad blir det ?
SELECT * FROM Customers
ORDER BY CompanyName ASC;

--2. Ta fram kundnamn, adress och postort f�r alla kunder.
SELECT ContactName, Address, Region FROM Customers

--3. Ta fram adress, postort och kontaktperson f�r alla kunder i London
SELECT ContactName, Address, Region, City FROM Customers
WHERE City = 'London'

--4. Ta fram alla kunder som har en kontaktperson som heter John Steel.
SELECT * FROM Customers
WHERE ContactTitle = 'John Steel'

--5. Ta fram alla unika st�der d�r det finns kunder dvs. fr�gan skall alltid ta bort alla dubbletter.

--6. Ta fram kundnamn , adress, postnummer och kontaktperson f�r alla kunder . Sortera dessa
--   p� postnr i stigande ordning dvs med det l�gsta postnumret f�rst. 
SELECT ContactName, Address, PostalCode, ContactTitle FROM Customers
ORDER BY PostalCode ASC;

--7. �ndra sorteringen f�r fr�ga 6 s� att resultatet sorteras i fallande ordning dvs med det h�gsta
--   postnumret f�rst.
SELECT ContactName, Address, PostalCode, ContactTitle FROM Customers
ORDER BY PostalCode DESC;

--8. Ta fram alla kunder som har ett postnr som �r st�rre �n 1010 och en region som �r lika med
--   WA.
SELECT * FROM Customers
WHERE PostalCode 

--9. Ta fram alla kunder som finns i London eller Paris.
SELECT * FROM Customers
WHERE City = 'London' or City = 'Paris'

--10. Skriv en fr�ga som returnerar en siffra som anger antalet rader i kundtabellen.
SELECT COUNT (*) FROM Customers
SELECT COUNT (*) AS [NUMBER OF ROWS] FROM Customers

--11. Ta fram alla kunder som inte har n�gon ifylld region dvs d�r detta saknas. 
SELECT * FROM Customers
WHERE Region IS NULL

--12. Ta fram namn, city och kontaktperson p� alla kunder d�r namnet inte �r lika med �Ernst
--    Handel�. Sortera dessa kunder p� namnet och i bokstavsordning.SELECT ContactName, City, ContactTitle FROM CustomersWHERE NOT ContactName = 'Ernst Handel'ORDER BY ContactName ASC--13. Ta fram alla kunder som har en omr�deskod som antingen �r lika med �BC� eller �SP� eller
--    �WA� eller� CA�. SELECT * FROM CustomersWHERE Region IN ('WA', 'BC', 'SP', 'CA')--14. Hur m�nga anst�llda kommer fr�n UK? Visa det med en siffra. SELECT COUNT (*) AS [Number of ppl hired in the UK] FROM CustomersWHERE Country = 'UK'--15. Ta fram alla kunder som antingen har kundnamn �Island Trading� och region � Isle of Wight�,
--    eller kundnamnet � White Clover Markets� och region �WA� . Fundera p� hur where delen
--    av fr�gan m�ste se ut f�r att detta villkor skall bli r�tt.
SELECT * FROM Customers
WHERE (CompanyName = 'Island Trading' AND Region = 'Isle of Wight')
OR (CompanyName = 'White Clover Markets' AND Region = 'WA')


-----------------------------------------
--   INSERT
-----------------------------------------
SELECT * FROM Customers
ORDER BY CompanyName ASC

-- 1. L�gg till en ny kund som heter Nackademin och ligger p� Tomtebodav 3A , 17156 i SOLNA.
--    Kunden har en kontaktperson som heter Per Svensson. Du m�ste �ven l�gga in ett kundid
--    och det skall vara NACK.
--INSERT INTO Customers VALUES ('Nackademin', 'Per Svensson', '', 'Tomtebodav 3A', '', 'SOLNA', 17156, 'Sweden', '', '')
INSERT INTO Customers (CompanyName, [Address], PostalCode, Region, ContactName, CustomerID)
VALUES ('Nackademin', 'Tomtebodav 3A', 17156, 'SOLNA', 'Per Svensson', 'MACK')

-- 2. L�gg till en ny kund som heter BR leksaker och har adressen Barkarby Handelsplats
--    postnummer 177 38 och ligger i J�RF�LLA. Kunden har en kontaktperson som heter Anna
--    Persson . Du m�ste �ven l�gga in ett kundid och det skall vara BRLE.
INSERT INTO Customers (CompanyName, [Address], PostalCode, Region, ContactTitle, CustomerID)
VALUES ('BR Leksaker', 'Barkarby Handelsplats', 17738, 'J�RF�LLA', 'Anna Persson', 'BRLE')

--3. L�gg till en ny kund som heter Elgiganten och har adressen Kungens Kurva
--   och ligger i KUNGENS KURVA . Kunden har en kontaktperson som heter Malin Lundkvist. Du
--   m�ste �ven l�gga in ett kundid och det skall vara ELGI.
INSERT INTO Customers (CompanyName, [Address], Region, ContactTitle, CustomerID)
VALUES ('Elgiganten', 'Kungens Kurva', 'KUNGENS KURVA', 'Malin Lundkvist', 'ELGI')

--4. F�rs�k att l�gga in en kund utan att ange kundnamn. Vad h�nder? Varf�r f�r du det
--   felmeddelande som dyker upp?INSERT INTO Customers (CustomerID, ContactName, ContactTitle)VALUES ('OLMA', 'Olivia', 'Mary')	--Cannot insert the value NULL into column 'CompanyName', table 'Northwind.dbo.Customers';
	--column does not allow nulls. INSERT fails.

--5. Fyll databasen som du skapat f�r en Sporthall med data. L�gg in nya kunder, banor och
--   bokningar.


-----------------------------------------
--   UPDATE
-----------------------------------------
SELECT * FROM Customers
ORDER BY CompanyName ASC

--   6. Du gl�mde l�gga in contact title f�r kunden �Nackademin�. Den skall vara �Program
--   Manager�. Uppdatera tabellen s� att den riktiga titeln kommer in.
UPDATE Customers SET ContactTitle = 'Program Manager'
WHERE CustomerID = 'MACK'

--7. Du gl�mde l�gga in region f�r kunden BR leksaker. Den skall vara SO. Uppdatera tabellen s�
--   att den riktiga regionen kommer in.UPDATE Customers SET Region = 'SO'WHERE CustomerID = 'BRLE'UPDATE Customers SET Region is nulWHERE CustomerID = 'BRLE'--8. Du gl�mde l�gga in postnummer och country f�r kunden Elgiganten. Postnummer skall vara
--   14175 och region skall vara KU. Uppdatera tabellen s� att dessa uppgifter kommer in.UPDATE Customers SET PostalCode = 14175, Region = 'KU', Country = 'Abudabi'WHERE CustomerID = 'ELGI'--9. Uppdatera alla de tre nya kunderna samtidigt ( Nackademin, BR leksaker , Elgiganten) och
--   s�tt land till �Sweden� f�r alla. G�r detta i en och samma query.
UPDATE Customers SET Country = 'Sweden'
WHERE [CustomerID] IN ('MACK', 'BRLE', 'ELGI')

-----------------------------------------
--   UPDATE
-----------------------------------------
SELECT * FROM Customers
ORDER BY CompanyName ASC

--10. Kunden med kundid �ELGI� skall ta bort. Radera denna kund fr�n tabellen. DELETE FROM CustomersWHERE CustomerID = 'ELGI'--11. Ta bort alla kunder som har kundnamn Nackademin. DELETE FROM CustomersWHERE [CompanyName = 'NackaDemin' or