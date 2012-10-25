USE Library

SELECT
	isbn,
	copy_no, 
	title_no, 
	on_loan
	
FROM
	Library.dbo.copy

WHERE
	isbn = 10001
	