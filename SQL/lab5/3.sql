USE Library

SELECT DISTINCT 
	member.member_no, 
	member.lastname 
	
FROM 
	Library.dbo.member
	
	WHERE 5 < 
	(
		SELECT 
			SUM(loanhist.fine_assessed) 
		FROM Library.dbo.loanhist
		WHERE 
			member.member_no = loanhist.member_no
	);

