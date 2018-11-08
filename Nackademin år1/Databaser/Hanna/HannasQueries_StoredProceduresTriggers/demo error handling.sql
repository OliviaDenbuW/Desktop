ALTER PROCEDURE DemoErrorProcdure
@productId varchar(34)
 AS 
BEGIN
	BEGIN TRANSACTION;
		BEGIN TRY
			DELETE FROM Products WHERE ProductID = @productId;
		END TRY

		BEGIN CATCH 
			SELECT
			ERROR_NUMBER() AS ErrorNumber
			,ERROR_MESSAGE() AS ErrorMessage;
			ROLLBACK TRANSACTION; 
		END CATCH;

		if(@@ROWCOUNT = 1)
		
			BEGIN
				COMMIT TRANSACTION;
			END
END

exec DemoErrorProcdure 'asdasd'
