use Northwind

-------------------------------------------		SQL strängar funktioner -----------------------------------------SELECT * FROM CustomersORDER BY CompanyName ASC--1. Ta fram alla kunder som saknar region dvs. där värdet är NULL. SELECT CompanyName, Region FROM CustomersWHERE Region IS NULL;--2. Ta istället fram alla kunder som har en angiven region dvs där värdet inte är NULL. En tom
--   textsträng räknas som ett värde.SELECT * FROM Customers--3. Ta fram alla kunders namn och region. I de fall där region är NULL, returnera istället texten
--   ’Region saknas’ i svaret på frågan. ALTER TABLE CustomersADD CONSTRAINT DF_Customers_RegionDEFAULT 'Region saknas' FOR RegionSELECT CompanyName, Region FROM Customers--