USE AdventureWorks;
GO
CREATE VIEW HumanResources.vEmployeeDetail WITH SCHEMABINDING
AS
SELECT
    HumanResources.Employee.EmployeeID, 
    HumanResources.Employee.Title, 
    Person.Contact.FirstName, 
    Person.Contact.MiddleName, 
    Person.Contact.LastName,
    Person.Contact.Suffix, 
    HumanResources.Employee.Title AS JobTitle, 
    Person.Contact.Phone, 
    Person.Contact.EmailAddress, 
    Person.Contact.EmailPromotion, 
    Person.Address.AddressLine1, 
    Person.Address.AddressLine2, 
    Person.Address.City, 
    Person.StateProvince.Name AS StateProvinceName, 
    Person.Address.PostalCode, 
    Person.StateProvince.Name AS CountryRegionName, 
    Person.Contact.AdditionalContactInfo

FROM HumanResources.Employee 

	INNER JOIN Person.Contact 
	ON HumanResources.Employee.ContactID = Person.Contact.ContactID 
	INNER JOIN HumanResources.EmployeeAddress 
	ON HumanResources.Employee.EmployeeID = HumanResources.EmployeeAddress.EmployeeID 
	INNER JOIN Person.Address 
	ON HumanResources.EmployeeAddress.AddressID = Person.Address.AddressID 
	INNER JOIN Person.StateProvince 
	ON Person.Address.StateProvinceID = Person.StateProvince.StateProvinceID
	INNER JOIN Person.CountryRegion 
	ON Person.StateProvince.CountryRegionCode = Person.CountryRegion.CountryRegionCode

GO
