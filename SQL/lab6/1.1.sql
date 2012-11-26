CREATE TABLE [HumanResources].[JobCandidateHistory]
(
	JobCandidateID int 
		NOT NULL
		unique, 
	Resume xml
		NULL, 
    Rating int 
		NOT NULL 
		Constraint [Default_JobCandidateHistory_Rating] 
			Default (5)
		Constraint [Check_JobCandidateHistory_Rating] 
			Check (Rating>=0 AND Rating<=10),
    RejectiveDate datetime 
		NOT NULL, 
    ContactID int 
		NULL,
		Constraint [FK_JobCandidateHistory_Contact_ContactID]
			Foreign key (ContactID) References [Person].[Contact](ContactID)
) 

