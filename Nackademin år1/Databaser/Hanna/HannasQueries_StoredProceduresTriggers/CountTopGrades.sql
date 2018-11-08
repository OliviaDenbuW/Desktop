alter function CountGrades(@studentId int)
returns int

begin

	return (
		select count(s.Betyg) from Student s
		inner join Betyg b
		on s.Id = b.StudentId
		where s.Id = @studentId
	)
end

select dbo.CountGrades(2) as 'Number of Top Grades'