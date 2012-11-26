USE [AdventureWorks]
GO
ALTER TABLE [HumanResources].JobCandidateHistory
NOCHECK CONSTRAINT [Check_JobCandidateHistory_Rating]
GO

ALTER TABLE [HumanResources].JobCandidateHistory
NOCHECK CONSTRAINT [Default_JobCandidateHistory_Rating]
GO