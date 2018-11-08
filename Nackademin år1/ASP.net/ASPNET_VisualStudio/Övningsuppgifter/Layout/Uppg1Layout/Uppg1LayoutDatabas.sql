create database Nackademin

create table Utbildningar (
UtbildningsID int identity(1,1) primary key not null,
Namn nvarchar(50),
Beskrivning nvarchar (500)
)

insert into Utbildningar(Namn, Beskrivning)
values ('Programutvecklare .NET', 'Programutvecklare .NET. Fördjupa dig i programmering genom ett av världens mest använda programmeringsspråk. Vill du få en kompetens som gör dig attraktiv på arbetsmarknaden och som kan ge dig en central position i ett framgångsrikt utvecklingsteam är Programutvecklare .NET en utbildning för dig!');

insert into Utbildningar(Namn, Beskrivning)
values ('Programutvecklare Java', 'Programutvecklare Java är en utbildning som är kul om man vill bli som min syster');

insert into Utbildningar(Namn, Beskrivning)
values ('Dev-Ops integrerare', 'Vi använder och kopplar ihop allt fler digitala enheter – inte bara datorn, plattan och mobilen, utan också bilar och olika typer av hemelektronik. Det ställer krav på snabbare, mer lättillgängliga men också effektivare och säkrare system. Det är där DevOps-integrerare kommer in i bilden, eller snarare in i företagen. Är du en självständig och ansvarsfull person som vill ha en vägledande och rådgivande yrkesroll kan DevOps-integrerare vara utbildningen för dig');

select * from Utbildningar