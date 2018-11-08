create database Addressbook

CREATE TABLE Address
(AddressID INT IDENTITY(1,1) PRIMARY KEY,
StreetAddress NVARCHAR(50) NOT NULL,
PostalNumber INT NOT NULL,
PostalArea NVARCHAR(50) NOT NULL
)

CREATE TABLE Person
(PersonID INT IDENTITY(1,1) PRIMARY KEY,
[Name] NVARCHAR(50) NOT NULL,
AddressID INT NOT NULL,
FOREIGN KEY (AddressID) REFERENCES Address(AddressID)
)
--CONSTRAINT FK_AddressPerson FOREIGN KEY (AddressID) REFERENCES Address(AddressID)

CREATE TABLE Contact
(
Email NVARCHAR(50),
Telephone INT,
[Type] NVARCHAR(10) NOT NULL,
PersonID INT NOT NULL,
FOREIGN KEY (PersonID) REFERENCES Person(PersonID),
--CONSTRAINT FK_PersonContact FOREIGN KEY (PersonID) REFERENCES Person(PersonID),
PRIMARY KEY (Email, Telephone, [Type], PersonID)
)

USE Addressbook
GO

CREATE PROCEDURE AddAddress @Addr NVARCHAR(50), @Numb INT, @Area NVARCHAR(50)
AS
INSERT INTO Address(StreetAddress, PostalNumber, PostalArea)
OUTPUT INSERTED.AddressID
VALUES (@Addr, @Numb, @Area)
GO

CREATE PROCEDURE AddPerson @Name NVARCHAR(50), @AddressID INT
AS
INSERT INTO Person(Name, AddressID)
OUTPUT INSERTED.PersonID
VALUES (@Name, @AddressID)
GO

CREATE PROCEDURE AddContact @Email NVARCHAR(50), @Telephone INT, @Type NVARCHAR(10)
AS
INSERT INTO Contact(Email, Telephone, Type)
VALUES (@Email, @Telephone, @Type)
GO

--ONSDAG 15/11 jobbar utifrån Johannas hjälp
-- * Måste sätta in personer i db

select * from Person
INSERT INTO Person(PersonID, [Name], AddressID)
VALUES (1, 'Olivia', 1)

