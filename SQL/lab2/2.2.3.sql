USE AdventureWorks

SELECT
	ProductID,
	SUM(OrderQty) as summ_of_order
FROM
	Sales.SalesOrderDetail
GROUP BY
	ProductID
HAVING
	SUM(OrderQty) > 2000
	
ORDER BY
	summ_of_order