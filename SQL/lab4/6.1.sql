USE Library

BEGIN TRANSACTION
SET IDENTITY_INSERT member ON
INSERT member(member_no, lastname, firstname, middleinitial)
VALUES (16101, 'Walters', 'B.', 'L')
SET IDENTITY_INSERT member OFF
INSERT juvenile
VALUES (16101, 1,
		 DATEADD(YY, -18, DATEADD(DD, -1, GETDATE())))
COMMIT TRANSACTION