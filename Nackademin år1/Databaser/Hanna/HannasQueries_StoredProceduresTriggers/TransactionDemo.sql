alter procedure InsertNewStudentWithGrades
@name varchar(100),
@personnummer char(12),
@grade char(2)
as
BEGIN
	BEGIN TRAN

		insert into Person (Personnummer, Namn)
		values (@personnummer, @name);

		IF(@@ROWCOUNT = 1)

			BEGIN

				insert into Student (PersonId, Betyg)
				values (SCOPE_IDENTITY(), @grade);

					if(@@ROWCOUNT = 1)

						BEGIN
							COMMIT TRAN
							print 'Transaction OK'
						END

					ELSE
						BEGIN
							ROLLBACK TRAN
							print 'Rollback Transaction'
						END
			END

		ELSE
			BEGIN
				ROLLBACK TRAN
				print 'Rollback Transaction'
			END
END

EXECUTE InsertNewStudentWithGrades 'Hanna', '11111111', VG