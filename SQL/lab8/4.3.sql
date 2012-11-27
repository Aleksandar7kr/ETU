DECLARE
	@StartDate datetime,
	@EndDate   datetime,
	@NewId     int,
	@ReturnValue int
	
SET @StartDate = GETDATE()
SET @EndDate   = DATEADD(MONTH,1,@StartDate)

EXEC @ReturnValue = Sales.AddDiscount
	'HalfPriceTest',
	-0.5, 
	'Seasonal discount',
	'Customer',
	@StartDate,
	@EndDate,
	0,
	20,
	@NewId OUTPUT
	
IF (@ReturnValue = 0)
	SELECT @NewId
	
ELSE
	SELECT TOP 1 * 
	FROM dbo.ErrorLog
		ORDER By ErrorTime DESC