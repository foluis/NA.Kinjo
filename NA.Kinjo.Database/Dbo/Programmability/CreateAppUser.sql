﻿CREATE PROCEDURE CreateAppUser	
	@Email varchar(100), 
	@Password varchar(100) 
AS
BEGIN

	SET NOCOUNT ON;

    INSERT INTO AppUser 
		(Email, Password)
		OUTPUT INSERTED.Id
	VALUES 
		(@Email,@Password)
END
GO