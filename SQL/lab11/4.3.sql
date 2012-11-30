UPDATE Production.Product
SET DiscontinuedDate = GETDATE()
WHERE ProductID = 680