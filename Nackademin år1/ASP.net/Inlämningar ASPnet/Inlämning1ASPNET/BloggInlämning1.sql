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
values ('Mammas trädgård', 'Här finns många fina blommor att fotografera', 1)

insert into Posts (HeadLine, BreadText, CategoryID)
values ('Nyckelpigan på fältet', 'Hon satt i timmar för att slutligen fånga den fina nyckelpigan på bild', 2)

insert into Posts (HeadLine, BreadText, CategoryID)
values ('Frostade grässtrån', 'Gräsmattans frysta strån får små fina kristaller. Det ser ut som ett grönt fält fullt med glänsande diamanter', 1)

delete from Posts
where HeadLine = 'Nyckelpigan på fältet'