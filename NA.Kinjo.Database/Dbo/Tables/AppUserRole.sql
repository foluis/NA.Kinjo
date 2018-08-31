CREATE TABLE [dbo].[AppUserRoles]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[AppUserId] INT NOT NULL,
	[RoleId] INT NOT NULL,
	CONSTRAINT [FK_AppUserRoles_AppUser] FOREIGN KEY ([AppUserId]) REFERENCES [AppUser]([Id]),
	CONSTRAINT [FK_AppUserRoles_Role] FOREIGN KEY ([RoleId]) REFERENCES [Role]([Id]),
	CONSTRAINT [UQ_[AppUserRoles] UNIQUE NONCLUSTERED 
    (
        [AppUserId], [RoleId]
    )
)
