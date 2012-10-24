USE AdventureWorks

SELECT 
	SalesPersonID, 
	CustomerID, 
	OrderDate, 
	SubTotal, 
	TotalDue
	
FROM 
	Sales.SalesOrderHeader

ORDER BY
	SalesPersonID,
	OrderDate