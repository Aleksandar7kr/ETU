DECLARE @DateToCheck datetime
SET @DateToCheck = DATEADD(MONTH,1,GETDATE())
EXEC Sales.GetDiscountsForCategoryAndDate 'Reseller', @DateToCheck