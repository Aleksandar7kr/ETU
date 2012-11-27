CREATE PROCEDURE Sales.AddDiscount
	@Description   nvarchar(50),
	@DiscountPct   smallmoney,
	@Type          nvarchar(50),
	@Category      nvarchar(50),
	@StartDate     datetime,
	@EndDate       datetime,
	@MinQty        int,
	@MaxQty        int,
	@NewProductId  int OUTPUT
	
AS

BEGIN

BEGIN TRY
	INSERT INTO
	Sales.SpecialOffer
	( 
		Sales.SpecialOffer.Description,
		Sales.SpecialOffer.DiscountPct,
		Sales.SpecialOffer.Type,
		Sales.SpecialOffer.Category,
		Sales.SpecialOffer.StartDate,
		Sales.SpecialOffer.EndDate,
		Sales.SpecialOffer.MinQty,
		Sales.SpecialOffer.MaxQty
	)
	
	VALUES
	(
		@Description,
		@DiscountPct,
		@Type,
		@Category,
		@StartDate,
		@EndDate,
		@MinQty,
		@MaxQty
	)
	
	SET @NewProductId = SCOPE_IDENTITY()
	
END TRY

BEGIN CATCH
	INSERT INTO
	dbo.ErrorLog
	(
		UserName,
		ErrorNumber,
		ErrorSeverity,
		ErrorState,
		ErrorProcedure,
		ErrorLine,
		ErrorMessage
	)
	
	VALUES
	(
		SYSTEM_USER,
		ERROR_NUMBER(),
		ERROR_SEVERITY(),
		ERROR_STATE(),
		ERROR_PROCEDURE(),
		ERROR_LINE(),
		ERROR_MESSAGE()
	)
END CATCH
	
END
