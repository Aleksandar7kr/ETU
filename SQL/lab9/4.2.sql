USE AdventureWorksDW

IF NOT EXISTS
(
	SELECT * FROM sys.database_principals
		WHERE 
			name = 'Adam' AND 
			type = 'U'
)
CREATE USER Adam FOR LOGIN [MIAMI\Adam]

GRANT AUTHENTICATE TO Adam
GRANT SELECT TO Adam

ALTER DATABASE AdventureWorks SET TRUSTWORTHY ON