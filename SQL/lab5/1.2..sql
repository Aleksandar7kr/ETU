USE Library

SELECT 
	adult_member_no, 
	COUNT(member_no) as num_of_kids

FROM 
	Library.dbo.juvenile 
GROUP BY 
	adult_member_no
HAVING 
	COUNT(member_no)>2;


SELECT
	adult.expr_date
FROM
	Library.dbo.adult; 