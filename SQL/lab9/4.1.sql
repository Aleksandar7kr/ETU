CREATE FUNCTION Sales.GetCurrencyRate 
(
	@CurrencyCode nchar(3)
) 
RETURNS float 
AS 
BEGIN 
  DECLARE @CurrencyRate float 
  SELECT 
	@CurrencyRate = (SELECT TOP (1) EndOfDayRate 
	FROM AdventureWorksDW.dbo.DimCurrency C 
		INNER JOIN AdventureWorksDW.dbo.FactCurrencyRate CR 
		ON C.CurrencyKey = CR.CurrencyKey 
	WHERE C.CurrencyAlternateKey = @CurrencyCode 
	ORDER BY  CR.TimeKey DESC)
	 
  IF (@CurrencyRate IS NULL) 
    SET @CurrencyRate = 1.0 
  
  RETURN @CurrencyRate 
END 