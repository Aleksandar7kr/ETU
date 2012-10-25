USE Library

DELETE Library.dbo.juvenile
	
FROM
	Library.dbo.juvenile
	
	INNER JOIN Library.dbo.adult
		ON juvenile.member_no = adult.member_no