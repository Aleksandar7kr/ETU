USE AdventureWorks

SELECT
	COUNT(*) as number_of_employees_with_manager

FROM
	AdventureWorks.HumanResources.Employee
WHERE
	ManagerID IS NOT NULL