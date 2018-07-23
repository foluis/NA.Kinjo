CREATE PROCEDURE [dbo].[DeleteCompany]
	@Id int
AS
BEGIN

	SET NOCOUNT ON;

	UPDATE Company
	SET IsActive = 0
	WHERE Id = @Id
END
GO