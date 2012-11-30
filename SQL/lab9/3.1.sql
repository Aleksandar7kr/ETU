CREATE FUNCTION Sales.GetDiscountedProducts
(
	@IncludeHistory bit
) 
RETURNS @temp TABLE
(
	ProductID int,
	Name nvarchar(50),
	ListPrice money,
	DiscountDescription nvarchar(255),
	DiscountPercentage smallmoney,
	DiscountAmount money,
	DiscountedPrice money
)
AS
BEGIN
	IF(@IncludeHistory=0)
	BEGIN
	DECLARE @time datetime,
			@ProductID int,
			@Name nvarchar(50),
			@ListPrice money,
			@DiscountDescription nvarchar(255),
			@DiscountPercentage smallmoney,
			@DiscountAmount money,
			@DiscountedPrice money;
	SET @time=getdate();

	SELECT 
		@ProductID = ProductID, 
		@Name =Name,
		@ListPrice =ListPrice,
		@DiscountDescription =DiscountDescription,
		@DiscountPercentage =DiscountPercentage,
		@DiscountAmount =DiscountAmount,
		@DiscountedPrice =DiscountedPrice 
	FROM Sales.SpecialOffer
		WHERE @time <= EndDate;

	INSERT INTO @temp 
	VALUES
	(
		@ProductID,
		@Name,
		@ListPrice,
		@DiscountDescription,
		@DiscountPercentage,
		@DiscountAmount,
		@DiscountedPrice
		)
	END

	ELSE
	BEGIN
	SELECT 
		@ProductID =ProductID,
		@Name =Name,
		@ListPrice =ListPrice,
		@DiscountDescription =DiscountDescription,
		@DiscountPercentage =DiscountPercentage,
		@DiscountAmount =DiscountAmount,
		@DiscountedPrice =DiscountedPrice 
	FROM Sales.SpecialOffer 
		WHERE @time >= StartDate;
		
	INSERT INTO @temp
	VALUES
	(
		@ProductID,
		@Name,
		@ListPrice,
		@DiscountDescription,
		@DiscountPercentage,
		@DiscountAmount,
		@DiscountedPrice
	)
END
END