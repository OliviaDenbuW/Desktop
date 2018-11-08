
-----------------------------------------
--   SELECT
-----------------------------------------

--1. Ta fram all information för alla kunder som finns (tabellen Customers). Sortera resultatet på
--   kundnamnet . Börja med ”asc” och ändra till ”desc”. Vilken skillnad blir det ?
SELECT * FROM Customers
ORDER BY CompanyName ASC;

--2. Ta fram kundnamn, adress och postort för alla kunder.
SELECT ContactName, Address, Region FROM Customers

--3. Ta fram adress, postort och kontaktperson för alla kunder i London
SELECT ContactName, Address, Region, City FROM Customers
WHERE City = 'London'

--4. Ta fram alla kunder som har en kontaktperson som heter John Steel.
SELECT * FROM Customers
WHERE ContactTitle = 'John Steel'

--5. Ta fram alla unika städer där det finns kunder dvs. frågan skall alltid ta bort alla dubbletter.

--6. Ta fram kundnamn , adress, postnummer och kontaktperson för alla kunder . Sortera dessa
--   på postnr i stigande ordning dvs med det lägsta postnumret först. 
SELECT ContactName, Address, PostalCode, ContactTitle FROM Customers
ORDER BY PostalCode ASC;

--7. Ändra sorteringen för fråga 6 så att resultatet sorteras i fallande ordning dvs med det högsta
--   postnumret först.
SELECT ContactName, Address, PostalCode, ContactTitle FROM Customers
ORDER BY PostalCode DESC;

--8. Ta fram alla kunder som har ett postnr som är större än 1010 och en region som är lika med
--   WA.
SELECT * FROM Customers
WHERE PostalCode 

--9. Ta fram alla kunder som finns i London eller Paris.
SELECT * FROM Customers
WHERE City = 'London' or City = 'Paris'

--10. Skriv en fråga som returnerar en siffra som anger antalet rader i kundtabellen.
SELECT COUNT (*) FROM Customers
SELECT COUNT (*) AS [NUMBER OF ROWS] FROM Customers

--11. Ta fram alla kunder som inte har någon ifylld region dvs där detta saknas. 
SELECT * FROM Customers
WHERE Region IS NULL

--12. Ta fram namn, city och kontaktperson på alla kunder där namnet inte är lika med ”Ernst
--    Handel”. Sortera dessa kunder på namnet och i bokstavsordning.SELECT ContactName, City, ContactTitle FROM CustomersWHERE NOT ContactName = 'Ernst Handel'ORDER BY ContactName ASC--13. Ta fram alla kunder som har en områdeskod som antingen är lika med ”BC” eller ”SP” eller
--    ”WA” eller” CA”. SELECT * FROM CustomersWHERE Region IN ('WA', 'BC', 'SP', 'CA')--14. Hur många anställda kommer från UK? Visa det med en siffra. SELECT COUNT (*) AS [Number of ppl hired in the UK] FROM CustomersWHERE Country = 'UK'--15. Ta fram alla kunder som antingen har kundnamn ”Island Trading” och region ” Isle of Wight”,
--    eller kundnamnet ” White Clover Markets” och region ”WA” . Fundera på hur where delen
--    av frågan måste se ut för att detta villkor skall bli rätt.
SELECT * FROM Customers
WHERE (CompanyName = 'Island Trading' AND Region = 'Isle of Wight')
OR (CompanyName = 'White Clover Markets' AND Region = 'WA')


-----------------------------------------
--   INSERT
-----------------------------------------
SELECT * FROM Customers
ORDER BY CompanyName ASC

-- 1. Lägg till en ny kund som heter Nackademin och ligger på Tomtebodav 3A , 17156 i SOLNA.
--    Kunden har en kontaktperson som heter Per Svensson. Du måste även lägga in ett kundid
--    och det skall vara NACK.
--INSERT INTO Customers VALUES ('Nackademin', 'Per Svensson', '', 'Tomtebodav 3A', '', 'SOLNA', 17156, 'Sweden', '', '')
INSERT INTO Customers (CompanyName, [Address], PostalCode, Region, ContactName, CustomerID)
VALUES ('Nackademin', 'Tomtebodav 3A', 17156, 'SOLNA', 'Per Svensson', 'MACK')

-- 2. Lägg till en ny kund som heter BR leksaker och har adressen Barkarby Handelsplats
--    postnummer 177 38 och ligger i JÄRFÄLLA. Kunden har en kontaktperson som heter Anna
--    Persson . Du måste även lägga in ett kundid och det skall vara BRLE.
INSERT INTO Customers (CompanyName, [Address], PostalCode, Region, ContactTitle, CustomerID)
VALUES ('BR Leksaker', 'Barkarby Handelsplats', 17738, 'JÄRFÄLLA', 'Anna Persson', 'BRLE')

--3. Lägg till en ny kund som heter Elgiganten och har adressen Kungens Kurva
--   och ligger i KUNGENS KURVA . Kunden har en kontaktperson som heter Malin Lundkvist. Du
--   måste även lägga in ett kundid och det skall vara ELGI.
INSERT INTO Customers (CompanyName, [Address], Region, ContactTitle, CustomerID)
VALUES ('Elgiganten', 'Kungens Kurva', 'KUNGENS KURVA', 'Malin Lundkvist', 'ELGI')

--4. Försök att lägga in en kund utan att ange kundnamn. Vad händer? Varför får du det
--   felmeddelande som dyker upp?INSERT INTO Customers (CustomerID, ContactName, ContactTitle)VALUES ('OLMA', 'Olivia', 'Mary')	--Cannot insert the value NULL into column 'CompanyName', table 'Northwind.dbo.Customers';
	--column does not allow nulls. INSERT fails.

--5. Fyll databasen som du skapat för en Sporthall med data. Lägg in nya kunder, banor och
--   bokningar.

