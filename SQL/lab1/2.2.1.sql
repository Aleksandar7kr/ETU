SELECT member_no, isbn, fine_assessed
FROM Library.dbo.loanhist 
WHERE fine_assessed IS NOT NULL