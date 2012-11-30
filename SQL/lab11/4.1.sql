USE AdventureWorks
GO

CREATE TRIGGER OrderDetailNotDiscontinued ON Sales.SalesOrderDetail
FOR INSERT, UPDATE
AS
IF EXISTS
(
	SELECT 'True'
	FROM Inserted i
	JOIN Products p
	ON i.ProductID = p.ProductID
	WHERE p.Discontinued = 1
)
BEGIN
RAISERROR('Transaction Failed.',16,1)
ROLLBACK TRAN
END