CREATE TABLE [dbo].[AppUser]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	--[FullName] VARCHAR(100) NOT NULL, 
	--[Username] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NOT NULL, 
    [Password] VARCHAR(100) NOT NULL, 
	--[Phone] VARCHAR(20) NOT NULL, 
    [EmailConfirmed] BIT NOT NULL DEFAULT 0
)