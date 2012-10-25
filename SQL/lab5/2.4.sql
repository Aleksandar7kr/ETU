USE Library

SELECT DISTINCT
	title.title_no,
	title,
	reservation.isbn,
	loan.copy_no as total_reserved
	
FROM
	Library.dbo.title
	
	INNER JOIN Library.dbo.loan
		on title.title_no = loan.title_no
		
	INNER JOIN Library.dbo.reservation
		on reservation.isbn = loan.isbn
		
	WHERE reservation.isbn IN
	(
		SELECT
			reservation.isbn
		FROM
			Library.dbo.reservation
			INNER JOIN Library.dbo.loan
				on reservation.isbn = loan.isbn
				
			WHERE copy_no < 5
	)