USE AdventureWorks

SELECT
	ProductID,
	SUM(OrderQty) as summ_of_order
FROM
	Sales.SalesOrderDetail
GROUP BY
	ProductID
ORDER BY
	summ_of_order