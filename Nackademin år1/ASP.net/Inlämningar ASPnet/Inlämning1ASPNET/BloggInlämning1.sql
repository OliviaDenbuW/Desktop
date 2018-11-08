create database OliviasBlog

create table Categories(
CategoryID int identity(1,1) primary key,
CategoryName nvarchar(15) not null
);

create table Posts(
PostID int identity(1,1) primary key,
HeadLine nvarchar(50) not null,
BreadText nvarchar(2000) not null,
CategoryID int not null,
DatePosted datetime default(getdate()) not null,
foreign key (CategoryID) references Categories(CategoryID)
);


insert into Categories (CategoryName)
values ('Nature')

insert into Categories (CategoryName)
values ('Animals')

select * from Categories
select * from Posts

insert into Posts (HeadLine, BreadText, CategoryID)
values ('Mammas tr�dg�rd', 'H�r finns m�nga fina blommor att fotografera', 1)

insert into Posts (HeadLine, BreadText, CategoryID)
values ('Nyckelpigan p� f�ltet', 'Hon satt i timmar f�r att slutligen f�nga den fina nyckelpigan p� bild', 2)

insert into Posts (HeadLine, BreadText, CategoryID)
values ('Frostade gr�sstr�n', 'Gr�smattans frysta str�n f�r sm� fina kristaller. Det ser ut som ett gr�nt f�lt fullt med gl�nsande diamanter', 1)

delete from Posts
where HeadLine = 'Nyckelpigan p� f�ltet'