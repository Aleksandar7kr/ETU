USE Library

SELECT
	copy.isbn,
	copy_no,
	on_loan,
	title,
	translation,
	cover

FROM
	Library.dbo.copy
	
	INNER JOIN Library.dbo.title as _title
		on _title.title_no = copy.title_no
	
	INNER JOIN Library.dbo.item as _item
		on _item.isbn = copy.isbn

WHERE 
	copy.isbn = 1 
	OR copy.isbn = 500 
	OR copy.isbn = 1000
	
ORDER BY
	copy.isbn
		