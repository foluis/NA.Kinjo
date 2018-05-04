CREATE TABLE [dbo].[AppUser]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[Username] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NOT NULL, 
    [Password] VARCHAR(100) NOT NULL, 
    [EmailConfirmed] BIT NOT NULL DEFAULT 0
)