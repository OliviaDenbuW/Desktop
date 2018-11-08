USE master
GO

IF EXISTS(SELECT name FROM sys.databases WHERE name = 'UnicornTheSchool')
     DROP DATABASE UnicornTheSchool
GO

create database UnicornTheSchool;

USE UnicornTheSchool;
GO

create table Adress(
	Id int identity(1,1) primary key,
	Gata varchar(70) not null,
	Postnummer char(5) not null,
	Stad varchar(50) not null,
	Land varchar(50) not null
);

create table Telefonnummer(
	Id int identity(1,1) primary key,
	Landsnummer char(2) not null,
	Riktnummer char(4) not null,
	Nummer char(8) not null
);

create table Person(
	Id int identity(1,1) primary key,
	Personnummer char(12) not null,
	Namn varchar(100) not null,
	AdressId int,
	TelefonId int,
	constraint FK_Adress_Id
	foreign key (AdressId) references Adress(Id)
	on delete set null,
	constraint FK_Telefon_Id
	foreign key (TelefonId) references Telefonnummer(Id)
	on delete set null
);

create table Avdelning(
	Id int identity(1,1) primary key,
	Avdelningsnamn varchar(50) not null
);

create table Larare(
	Id int identity(1,1) primary key,
	PersonId int  not null,
	AvdelningsId int,
	constraint FK_PersonLar_PersonId
	foreign key (PersonId) references Person (Id)
	on delete cascade, 
	constraint FK_Avdelning_Id
	foreign key (AvdelningsId) references Avdelning (Id)
	on delete set null
);

create table Klass(
	Id int identity(1,1) primary key,
	Klassnamn varchar(50) not null
);

create table Student(
	Id int identity(1,1) primary key,
	PersonId int not null,
	Betyg char(2),
	constraint FK_PersonStud_PersonId
	foreign key (PersonId) references Person (Id)
	on delete cascade,
	KlassId int,
	constraint FK_Klass1_Id
	foreign key (KlassId) references Klass (Id)
	on delete set null
);

create table Kurs(
	Id int identity(1,1) primary key,
	Kursnamn varchar(50) not null
);

create table Lokal(
	Id int identity(1,1) primary key,
	Namn varchar(50) not null
);

create table KlassKursLokalKoppling(
	Id int identity(1,1) primary key,
	KlassId int not null,
	KursId int not null,
	LokalId int not null,
	Datum date not null,
	Tid time not null,
	constraint FK_Klass2_Id
	foreign key (KlassId) references Klass (Id)
	on delete cascade,
	constraint FK_Kurs1_Id
	foreign key (KursId) references Kurs (Id)
	on delete cascade,
	constraint FK_Lokal_Id
	foreign key (LokalId) references Lokal (Id)
	on delete cascade
);

create table LararKursKoppling(
	Id int identity(1,1) primary key,
	LararId int not null,
	KursId int not null,
	constraint FK_Larare_Id
	foreign key (LararId) references Larare (Id)
	on delete cascade,
	constraint FK_Kurs2_Id
	foreign key (KursId) references Kurs (Id)
	on delete cascade
);

create table Betyg(
	Id int identity(1,1) primary key,
	StudentId int not null,
	KursId int not null,
	Betyg char(2) not null,
	constraint FK_Student_Id
	foreign key (StudentId) references Student (Id),
	constraint FK_Kurs3_Id
	foreign key (KursId) references Kurs (Id)
);