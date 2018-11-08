create database Nackademin

create table Utbildningar (
UtbildningsID int identity(1,1) primary key not null,
Namn nvarchar(50),
Beskrivning nvarchar (500)
)

insert into Utbildningar(Namn, Beskrivning)
values ('Programutvecklare .NET', 'Programutvecklare .NET. F�rdjupa dig i programmering genom ett av v�rldens mest anv�nda programmeringsspr�k. Vill du f� en kompetens som g�r dig attraktiv p� arbetsmarknaden och som kan ge dig en central position i ett framg�ngsrikt utvecklingsteam �r Programutvecklare .NET en utbildning f�r dig!');

insert into Utbildningar(Namn, Beskrivning)
values ('Programutvecklare Java', 'Programutvecklare Java �r en utbildning som �r kul om man vill bli som min syster');

insert into Utbildningar(Namn, Beskrivning)
values ('Dev-Ops integrerare', 'Vi anv�nder och kopplar ihop allt fler digitala enheter � inte bara datorn, plattan och mobilen, utan ocks� bilar och olika typer av hemelektronik. Det st�ller krav p� snabbare, mer l�ttillg�ngliga men ocks� effektivare och s�krare system. Det �r d�r DevOps-integrerare kommer in i bilden, eller snarare in i f�retagen. �r du en sj�lvst�ndig och ansvarsfull person som vill ha en v�gledande och r�dgivande yrkesroll kan DevOps-integrerare vara utbildningen f�r dig');

select * from Utbildningar