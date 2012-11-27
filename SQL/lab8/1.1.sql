CREATE PROCEDURE Sales.GetDiscount
AS

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

ORDER BY 
	StartDate, 
	EndDate
	
END