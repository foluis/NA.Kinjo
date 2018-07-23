CREATE PROCEDURE [dbo].[UpdateCompany]
	@Id int,
	@Email varchar(100), 	
	@Name varchar(50), 
	@Address varchar(200), 
	@Phone varchar(20)
AS
BEGIN

	SET NOCOUNT ON;

	UPDATE Company
	SET Email = @Email,
		[Name] = @Name,
		[Address] = @Address,
		Phone = @Phone
	WHERE Id = @Id
END
GO