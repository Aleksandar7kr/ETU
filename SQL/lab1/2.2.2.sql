SELECT 
	member_no, 
	isbn, 
	fine_assessed, 
	fine_assessed*2 as double_fine
	
FROM Library.dbo.loanhist 

WHERE fine_assessed IS NOT NULL