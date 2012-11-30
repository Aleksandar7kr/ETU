USE AdventureWorks
GO

SELECT 
	ProductID, 
	Name
FROM
	Production.Product
	WHERE DiscontinuedDate IS NOT NULL