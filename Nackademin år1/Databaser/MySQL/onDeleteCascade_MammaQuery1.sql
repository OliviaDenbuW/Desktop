
select adress,
from MWkund,
where namn = "Haile"


select anställd.namn, anställd.adress
from anställd, avdelning
where anställd.namn = 'haile'
and anställd.jobbarPå =  avdelning.avdnr


select släkten.namn, denbusDjur.antalDjur --information jag söker (kolumnerna) 1:a frågan jag ställer mig
from släkten, denbusDjur --namnen på tabell(er) jag söker
where släkten.namn = denbusDjur.namn --kopplingen mellan två tabeller (för JOIN)
and släkten.namn = 'Felicia'



insert into Släkt values (911122, 'Olivia')
insert into Släkt values (880608, 'Felicia')
insert into Släkt values (871113, 'Viktor')
insert into Släkt values (511217, 'Maarita')
update Släkt set Namn = 'Marita'
	where Personnummer = 511217;
delete from Släkt where Namn = 'Viktor'
insert into Släkt values (861231, 'Daniel')


create table Anställd
Nummer integer not null --Ska senare bli primärnyckel (måste ha värdet not null)
Namn varchar(10)
JobbarPå integer
primary key Nummer --Berättar vad som i tabellen Anställd ska vara primary key
foreign key (JobbarPå) reference Avdelning(Nummer)



create table Konsult
(Nummer integer not null,
Namn varchar(10),
InhydAv integer,
primary key (Nummer),
foreign key (InhyrdAv) references Avdelning(Nummer)
on delete cascade);

insert into Konsult values (3, 'Sally', 2);
insert into Konsult values (4, 'Eva', 2);
delete from Avdelning where Namn = 'Considerit'; --Möjligt pga Kaskad


