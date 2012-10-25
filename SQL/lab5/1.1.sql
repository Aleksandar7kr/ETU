USE Library

SELECT 
	adult.member_no,
	subtable.num_of_kids,
	adult.expr_date

FROM
	Library.dbo.adult
	 
INNER JOIN 
(
	SELECT
		juvenile.adult_member_no,
		COUNT(*) AS num_of_kids 

	FROM
		Library.dbo.juvenile

	GROUP BY
		juvenile.adult_member_no

	HAVING
		 COUNT(*)>2
) AS subtable
	ON adult.member_no = subtable.adult_member_no;
