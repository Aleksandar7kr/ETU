USE Library

SELECT
	translation
	
FROM
	Library.dbo.item

WHERE
	isbn IN (10001, 10100)