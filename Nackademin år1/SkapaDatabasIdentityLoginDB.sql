--Du skall nu skapa en ny databas f�r att g�ra databaskopplingar med Entity Framework
	--D�p den till LoginDB.
CREATE DATABASE LoginDB
DROP DATABASE LoginDB
--L�gg till en ny tabell UserLogin.
	--Den skall ha f�ljande kolumner:
		--UserID (identity), Name, Password, Email och City

CREATE TABLE UserLogin (
	UserID INT IDENTITY(1,1) PRIMARY KEY,
	[Name] NVARCHAR(50) NOT NULL,
	[Password] NVARCHAR(50) NOT NULL,
	Email NVARCHAR(50) NOT NULL,
	City NVARCHAR(50) NOT NULL
);

SELECT * FROM UserLogin

--INSERT INTO table_name (column1, column2, column3, ...)
--VALUES (value1, value2, value3, ...);

INSERT INTO UserLogin
	VALUES ('Maria', '222', 'maria@gmail.com', 'Stockholm')
	 
