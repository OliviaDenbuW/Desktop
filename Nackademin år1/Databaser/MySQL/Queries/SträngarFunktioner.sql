use Northwind

-------------------------------------------		SQL str�ngar funktioner -----------------------------------------SELECT * FROM CustomersORDER BY CompanyName ASC--1. Ta fram alla kunder som saknar region dvs. d�r v�rdet �r NULL. SELECT CompanyName, Region FROM CustomersWHERE Region IS NULL;--2. Ta ist�llet fram alla kunder som har en angiven region dvs d�r v�rdet inte �r NULL. En tom
--   textstr�ng r�knas som ett v�rde.SELECT * FROM Customers--3. Ta fram alla kunders namn och region. I de fall d�r region �r NULL, returnera ist�llet texten
--   �Region saknas� i svaret p� fr�gan. ALTER TABLE CustomersADD CONSTRAINT DF_Customers_RegionDEFAULT 'Region saknas' FOR RegionSELECT CompanyName, Region FROM Customers--