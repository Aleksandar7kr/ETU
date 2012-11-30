USE AdventureWorks 
GO 
CREATE TRIGGER [dJobCandidate] ON [HumanResources].[JobCandidate] 
AFTER DELETE AS 
BEGIN 
	SET NOCOUNT ON; 
	INSERT INTO [HumanResources].[JobCandidateHistory] 
	(
		JobCandidateID, 
		Resume, 
		RejectiveDate
	) 
  
	SELECT 
		JobCandidateID,
		Resume,
		getdate() 
	FROM 
		deleted 
END; 