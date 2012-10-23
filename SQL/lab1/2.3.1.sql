SELECT
	(firstname + '_' + middleinitial + '_' + lastname + '@gmail.com') as email_name

FROM
	Library.dbo.member

WHERE 
	lastname = 'Anderson'