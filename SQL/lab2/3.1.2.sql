USE AdventureWorks

SELECT
	SalesQuota,
	SUM(SalesYTD) as sumYTD,
	GROUPING(SalesQuota) as [grouping]

FROM
	AdventureWorks.Sales.SalesPerson
		
GROUP BY
	SalesQuota WITH ROLLUP