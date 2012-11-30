CREATE FUNCTION Sales.GetDiscountsForDate 
(
	@DateToCheck datetime
) 

RETURNS TABLE 
AS 
RETURN 
( 
  SELECT   [Description], 
           DiscountPct, 
           [Type], 
           Category, 
           StartDate, 
           EndDate, 
           MinQty, 
           MaxQty 
  FROM     Sales.SpecialOffer 
  WHERE    @DateToCheck BETWEEN StartDate AND EndDate 
) 