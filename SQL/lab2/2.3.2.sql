USE AdventureWorks

SELECT
	ProductID,
	SpecialOfferID,
	AVG(UnitPrice) as average,
	SUM(LineTotal) as total
	
FROM
	AdventureWorks.Sales.SalesOrderDetail
	
GROUP BY
	SpecialOfferID, ProductID
ORDER BY 
	ProductID