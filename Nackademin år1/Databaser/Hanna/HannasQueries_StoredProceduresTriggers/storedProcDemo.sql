alter procedure DeleteStudentStoredProc
 @personId int
 --@StatusCode INT OUTPUT
as
begin
	
	delete from dbo.Person where Id = @personId
	--set @StatusCode = 12
end

exec DeleteStudentStoredProc 7

--declare @SPStatusCode int
--exec DeleteStudentStoredProc 3, @StatusCode = @SPStatusCode output

--print @SPStatusCode

