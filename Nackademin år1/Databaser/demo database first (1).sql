use UnicornTheSchool
go

insert into Klass (Klassnamn) values ('Klass Ett');
insert into Klass (Klassnamn) values ('Klass Tv�');
insert into Klass (Klassnamn) values ('Klass Tre');

create table LokalAdress(
	Id int identity(1,1) primary key,
	Gata varchar(100) not null,
	Stad varchar(100) not null,
	Postnummer char(5) not null,
	LokalId int,
	constraint FK_Lokal2_Id
	foreign key (LokalId) references Lokal (Id)
);

insert into Lokal (Ben�mning) values ('Lokal Ett')
insert into Lokal (Ben�mning) values ('Lokal Tv�')
insert into Lokal (Ben�mning) values ('Lokal Tre')

insert into LokalAdress (Gata, Stad, Postnummer, LokalId)
values ('Gata Ett', 'Stad Ett', '11111', 1);

insert into LokalAdress (Gata, Stad, Postnummer, LokalId)
values ('Gata Tv�', 'Stad Tv�', '22222', 2);

insert into LokalAdress (Gata, Stad, Postnummer, LokalId)
values ('Gata Tre', 'Stad Tre', '33333', 3);

