USE Library


SELECT
	firstname + ' ' + middleinitial + ' ' + lastname as Name,
	
	street,
	city,
	[state],
	zip

FROM
	Library.dbo.member

INNER JOIN 
	Library.dbo.adult
	ON member.member_no = adult.member_no

