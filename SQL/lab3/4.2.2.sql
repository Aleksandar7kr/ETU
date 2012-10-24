USE library


SELECT 
	adult.member_no,
	count(*) as num_of_kids
	
 FROM 
	Library.dbo.juvenile
 
	INNER JOIN adult
		ON  juvenile.adult_member_no = adult.member_no
			WHERE adult.[state] = 'AZ'
 
 GROUP BY
  adult.member_no
	HAVING COUNT(*) > 2


UNION

SELECT 
	adult.member_no,
	count(*) as num_of_kids
	
 FROM 
	Library.dbo.juvenile
 
	INNER JOIN adult
		ON  juvenile.adult_member_no = adult.member_no
			WHERE adult.[state] = 'CA'
 
 GROUP BY
  adult.member_no
	HAVING COUNT(*) > 3