USE Library

SELECT
	title.title_no,
	title,
	loan.isbn,
	copy_no as total_reserved
	
FROM
	Library.dbo.title
	
	INNER JOIN Library.dbo.loan
		on title.title_no = loan.title_no
		
	INNER JOIN Library.dbo.reservation
		on reservation.isbn = loan.isbn
		
		WHERE loan.copy_no < 5 or loan.copy_no > 50