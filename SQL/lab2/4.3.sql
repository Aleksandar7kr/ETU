USE AdventureWorks

SELECT 
	SalesPersonID, 
	CustomerID, 
	OrderDate, 
	SubTotal, 
	TotalDue
	
FROM 
	AdventureWorks.Sales.SalesOrderHeader

ORDER BY
	SalesPersonID,
	OrderDate
	
COMPUTE
	SUM(SubTotal),
	SUM(TotalDue) BY SalesPersonID;