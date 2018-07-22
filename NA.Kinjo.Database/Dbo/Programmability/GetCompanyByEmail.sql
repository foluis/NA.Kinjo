CREATE PROCEDURE [GetCompanyByEmail]		
	@Email varchar(100)
AS
BEGIN

	SET NOCOUNT ON;

	SELECT [Id],[Name],[Email],[Address],[Phone]
	FROM [Company]
	WHERE Email = @Email
END
GO