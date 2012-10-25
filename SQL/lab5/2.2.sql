USE Library

SELECT DISTINCT
	firstname, 
	lastname, 
	isbn, 
	fine_paid
	
FROM 
	Library.dbo.member
	INNER JOIN  Library.dbo.loanhist 
		ON member.member_no = loanhist.member_no

	WHERE fine_paid = 
	(
		SELECT 
			MAX(loanhist.fine_paid) 
		FROM 
			Library.dbo.loanhist
	)
