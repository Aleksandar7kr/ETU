USE Library

SELECT
	juvenile.member_no,
	
	street,
	city,
	[state],
	zip,
	phone_no,
	
	DATEADD(YY, 1, GETDATE()) as _date 
	
FROM 
	Library.dbo.juvenile
	
	INNER JOIN Library.dbo.adult
		ON juvenile.adult_member_no = adult.member_no
		
	WHERE 
		(DATEADD(YY, 18, juvenile.birth_date) < GETDATE())