--Procedure for DELETE

CREATE PROC Production.DeleteSuppliers
@supplierid int
AS
DELETE FROM Production.Suppliers
WHERE supplierid = @supplierid

--Procedure for INSERT

GO

CREATE PROC Production.InsertSupplier
@companyname nvarchar(40),
@contactname nvarchar(30),
@contacttitle nvarchar(30),
@address nvarchar(60),
@city nvarchar(15),
@region nvarchar(15),
@postalcode nvarchar(10),
@country nvarchar(15),
@phone nvarchar(24),
@fax nvarchar(24)
AS
INSERT INTO Production.Suppliers
(
	companyname,
	contactname,
	contacttitle,
	address,
	city,
	region,
	postalcode,
	country,
	phone,
	fax
)
VALUES
(
	@companyname,
	@contactname,
	@contacttitle,
	@address,
	@city,
	@region,
	@postalcode,
	@country,
	@phone,
	@fax
)
GO

--Procedure for UPDATE
ALTER PROC Production.UpdateSupplier
@supplierid int,
@companyname nvarchar(40),
@contactname nvarchar(30),
@contacttitle nvarchar(30),
@address nvarchar(60),
@city nvarchar(15),
@region nvarchar(15),
@postalcode nvarchar(10),
@country nvarchar(15),
@phone nvarchar(24),
@fax nvarchar(24)
AS
UPDATE Production.Suppliers SET
companyname = @companyname,
contactname = @contactname,
contacttitle = @contacttitle ,
address = @address,
city = @city,
region = @region,
postalcode = @postalcode,
country = @country,
phone = @phone,
fax = @fax
WHERE supplierid = @supplierid