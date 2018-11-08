DECLARE @personnummer char(10),
@fornamn nvarchar(50),
@allnames nvarchar(max);

SET @allnames = '';
DECLARE person_cursor CURSOR
	FOR SELECT Personnummer, Namn FROM Person
OPEN person_cursor
FETCH NEXT FROM person_cursor 
	INTO @personnummer, @fornamn;
WHILE @@FETCH_STATUS = 0 
BEGIN
	SET @allnames = @allnames + ' ' + @fornamn  
	FETCH NEXT FROM person_cursor
		INTO @personnummer, @fornamn;
END
SELECT @allnames as [All Names]; 
CLOSE person_cursor;
DEALLOCATE person_cursor;
