USE Library


SELECT
	member.member_no,
	firstname + ' ' + middleinitial + ' ' + lastname as Name,
	
	isbn,
	CONVERT(char, log_date)
	
FROM
	Library.dbo.member
	
	FULL OUTER JOIN Library.dbo.reservation as _reservation
		on _reservation.member_no = member.member_no
			WHERE member.member_no IN(250, 341, 1675)
			
ORDER BY
	member.member_no
	
	
	