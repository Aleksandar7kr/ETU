USE Library

SELECT
	isbn,
	title_no,
	translation,
	cover,
	loanable
	
FROM
	Library.dbo.item
WHERE
	isbn = 10100
	

DELETE FROM
	Library.dbo.item
WHERE
	isbn = 10100