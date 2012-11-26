USE AdventureWorks
GO
CREATE UNIQUE CLUSTERED INDEX ix_vEmployeeDetails
ON HumanResources.vEmployeeDetail(EmployeeID)
