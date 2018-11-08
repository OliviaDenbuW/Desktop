use UnicornTheSchool
go

DECLARE @i int = 0;

WHILE @i < 23
BEGIN
    SET @i = @i + 1

	INSERT INTO Adress (Gata, Postnummer, Stad, Land)
	VALUES ('Gata' + CAST(@i AS VARCHAR(2)), 'PNr' + CAST(@i AS VARCHAR(2)), 'Stad' + CAST(@i AS VARCHAR(2)), 'Land' + CAST(@i AS VARCHAR(2)));

	INSERT INTO Telefonnummer (Landsnummer, Riktnummer, Nummer)
	VALUES (CAST(@i AS CHAR(2)), CAST(@i AS CHAR(2)), CAST(@i AS CHAR(2)));

	INSERT INTO Person(Personnummer, Namn, AdressId, TelefonId)
	VALUES ('PersonNr' + CAST(@i AS VARCHAR(2)), 'Namn' + CAST(@i AS VARCHAR(2)), @i, @i);
END

select * from Adress
select * from Telefonnummer
select * from Person

USE UnicornTheSchool

DECLARE @j int = 0;

WHILE @j < 23
BEGIN
     SET @j = @j + 1

	 INSERT INTO Avdelning (Avdelningsnamn)
	 VALUES ('Avdelning' + CAST(@j AS VARCHAR(2)));

	 INSERT INTO Larare (PersonId, AvdelningsId)
	 VALUES (@j, @j);

	 INSERT INTO Klass (Klassnamn)
	 VALUES ('Klass'  + CAST(@j AS VARCHAR(2)));

	 INSERT INTO Student (PersonId, Betyg, KlassId)
	 VALUES (@j, 'VG', @j);
END

select * from Avdelning
select * from Larare
select * from Klass
select * from Student

USE UnicornTheSchool

DECLARE @k int = 0;

WHILE @k < 23
BEGIN
     SET @k = @k + 1

	 INSERT INTO Kurs (Kursnamn)
	 VALUES('Kurs' + CAST(@k AS VARCHAR(2)));

	 INSERT INTO Lokal (Namn)
	 VALUES ('Lokal' + CAST(@k AS VARCHAR(2)));

	 INSERT INTO KlassKursLokalKoppling(KlassId, KursId, LokalId, Datum, Tid)
	 VALUES (@k, @k, @k, GETDATE() - @k, GETDATE());

	 INSERT INTO  LararKursKoppling(LararId, KursId)
	 VALUES (@k, @k);

	INSERT INTO Betyg (StudentId, KursId, Betyg)
	 VALUES (@k, @k, 'VG')

END