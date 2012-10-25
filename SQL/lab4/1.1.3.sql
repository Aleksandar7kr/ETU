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
	isbn IN (10001, 10100)