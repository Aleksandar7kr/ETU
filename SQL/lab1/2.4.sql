SELECT
	'The title is: ' 
	+ title 
	+ ', title number ' 
	+ CONVERT(char, title_no) as the_title_is
	
FROM
	Library.dbo.title