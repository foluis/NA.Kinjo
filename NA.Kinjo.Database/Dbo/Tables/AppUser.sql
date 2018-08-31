CREATE TABLE [dbo].[AppUser]
(
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[UserName] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NOT NULL, 
    [Password] VARCHAR(50) NOT NULL, 
    [EmailConfirmed] BIT NOT NULL DEFAULT 0,
	CONSTRAINT [UQ_[AppUser] UNIQUE NONCLUSTERED 
    (
        [UserName]
    )
)