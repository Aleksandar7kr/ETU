SELECT
	LOWER(firstname + '_' + middleinitial + '_' + SUBSTRING(lastname, 1, 2) + '@gmail.com') as email_name

FROM
	Library.dbo.member

WHERE 
	lastname = 'Anderson'