create database LoginDB

create table UserLogin (
UserID int identity(1,1) primary key, 
[Name] nvarchar(30), 
[Password] nvarchar(20), 
Email nvarchar(30), 
City nvarchar(20)
);

drop table UserLogin

select * from UserLogin

insert into UserLogin([Name], [Password], Email, City)
values ('test', 'test', 'test', 'test');

insert into UserLogin([Name], [Password], Email, City)
values ('Olivia', 'test', 'test', 'test');

insert into UserLogin([Name], [Password], Email, City)
values ('Olivia', 'test123', 'test', 'test');