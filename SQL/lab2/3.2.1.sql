USE AdventureWorks

SELECT 
	ProductID,
	SUM(LineTotal) as total
	
FROM
	AdventureWorks.Sales.SalesOrderDetail
WHERE
	UnitPrice > 5.0
GROUP BY
	ProductID
ORDER BY
	ProductID