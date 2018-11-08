
select adress,
from MWkund,
where namn = "Haile"


select anst�lld.namn, anst�lld.adress
from anst�lld, avdelning
where anst�lld.namn = 'haile'
and anst�lld.jobbarP� =  avdelning.avdnr


select sl�kten.namn, denbusDjur.antalDjur --information jag s�ker (kolumnerna) 1:a fr�gan jag st�ller mig
from sl�kten, denbusDjur --namnen p� tabell(er) jag s�ker
where sl�kten.namn = denbusDjur.namn --kopplingen mellan tv� tabeller (f�r JOIN)
and sl�kten.namn = 'Felicia'



insert into Sl�kt values (911122, 'Olivia')
insert into Sl�kt values (880608, 'Felicia')
insert into Sl�kt values (871113, 'Viktor')
insert into Sl�kt values (511217, 'Maarita')
update Sl�kt set Namn = 'Marita'
	where Personnummer = 511217;
delete from Sl�kt where Namn = 'Viktor'
insert into Sl�kt values (861231, 'Daniel')


create table Anst�lld
Nummer integer not null --Ska senare bli prim�rnyckel (m�ste ha v�rdet not null)
Namn varchar(10)
JobbarP� integer
primary key Nummer --Ber�ttar vad som i tabellen Anst�lld ska vara primary key
foreign key (JobbarP�) reference Avdelning(Nummer)



create table Konsult
(Nummer integer not null,
Namn varchar(10),
InhydAv integer,
primary key (Nummer),
foreign key (InhyrdAv) references Avdelning(Nummer)
on delete cascade);

insert into Konsult values (3, 'Sally', 2);
insert into Konsult values (4, 'Eva', 2);
delete from Avdelning where Namn = 'Considerit'; --M�jligt pga Kaskad


