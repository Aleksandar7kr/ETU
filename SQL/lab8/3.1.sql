CREATE PROCEDURE Sales.GetDiscountsForCategoryAndDate
	@Category nvarchar(50),
	@DateToCheck datetime = NULL
AS

IF @DateToCheck IS NULL
	SET @DateToCheck = GETDATE()

BEGIN

SELECT
	Sales.SpecialOffer.[Description],
	Sales.SpecialOffer.DiscountPct,
	Sales.SpecialOffer.[Type],
	Sales.SpecialOffer.Category,
	Sales.SpecialOffer.StartDate,
	Sales.SpecialOffer.EndDate,
	Sales.SpecialOffer.MinQty,
	Sales.SpecialOffer.MaxQty
	
FROM
	Sales.SpecialOffer

WHERE
	Category = @Category AND EndDate < @DateToCheck

ORDER BY 
	StartDate, 
	EndDate
	
END