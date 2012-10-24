USE AdventureWorks

SELECT
	SalesQuota,
	SUM(SalesYTD) as sumYTD

FROM
	AdventureWorks.Sales.SalesPerson
		
	GROUP BY
		SalesQuota