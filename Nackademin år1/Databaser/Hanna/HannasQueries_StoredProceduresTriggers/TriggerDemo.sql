--create trigger deletestudent
--on Person
--for delete
--as 
--DELETE FROM Students
--    WHERE Students.Person_Id IN (SELECT deleted.PersonId FROM deleted)
--go

--create trigger updatestudent
--on Person
--for insert, update
--as
--	declare @personId int;
--	set @personId = (select Id from inserted where id = inserted.Id);

--	IF NOT EXISTS (SELECT * FROM dbo.Student WHERE Id = @personId)

--		INSERT INTO dbo.Student(PersonId)
--		VALUES(@personId)

--	ELSE
--		UPDATE dbo.Student
--		SET Betyg = 5
--		WHERE ID = @personId
--GO