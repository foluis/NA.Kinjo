CREATE PROCEDURE [dbo].[GetAppUsersByEmail]
	@Email varchar(200)
AS
BEGIN
	SELECT Id,Email
	FROM AppUser
	WHERE Email = @Email
END