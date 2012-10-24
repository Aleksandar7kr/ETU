USE AdventureWorks

SELECT
	ProductID,
	SUM(LineTotal) AS total
FROM 
	AdventureWorks.sales.SalesOrderDetail
WHERE 
	UnitPrice < $5.00
GROUP BY 
	ProductID, OrderQty WITH CUBE
ORDER BY 
	ProductID
	
