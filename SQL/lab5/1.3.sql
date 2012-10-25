USE Library

SELECT 
	juvenile.adult_member_no, 
	COUNT(juvenile.member_no) as num_of_kids,
	expr_date 
	 
FROM 
	Library.dbo.juvenile
	
	INNER JOIN Library.dbo.adult
		ON adult.member_no = juvenile.adult_member_no
	GROUP BY 
		juvenile.adult_member_no,adult.expr_date
	HAVING COUNT(juvenile.member_no)>2;
