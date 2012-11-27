DECLARE
	@StartDate datetime,
	@EndDate   datetime,
	@NewId     int
	
SET @StartDate = GETDATE()
SET @EndDate   = DATEADD(MONTH,1,@StartDate)

EXEC Sales.AddDiscount
	'HalfPriceTest',
	0.5,
	'Seasonal discount',
	'Customer',
	@StartDate,
	@EndDate,
	0,
	20,
	@NewId OUTPUT
	
SELECT @NewId