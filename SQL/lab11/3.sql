USE AdventureWorks
GO
DELETE FROM [HumanResources].[JobCandidate]
	WHERE JobCandidateID = 
		(
			SELECT MIN(JobCandidateID)
			FROM [HumanResources].[JobCandidate]
		)
		
GO
SELECT * FROM [HumanResources].[JobCandidateHistory]
GO
TRUNCATE TABLE [HumanResources].[JobCandidateHistory]