CREATE FUNCTION Salas.GetMaximumDiscountForCategory
(
	@Category	nvarchar(50)
)

RETURNS smallmoney
AS
BEGIN
  DECLARE @res smallmoney 
  
  SELECT   @res = MAX(DiscountPct) 
	FROM Sales.SpecialOffer 
		WHERE
			Category = @Category 
			AND GetDate() BETWEEN StartDate AND EndDate 
		GROUP BY Category 
  
  IF (@res IS NULL) 
    SET @res = 0 
  
  RETURN @res 
END 