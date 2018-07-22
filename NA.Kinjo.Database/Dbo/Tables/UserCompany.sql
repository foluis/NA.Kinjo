CREATE TABLE [dbo].[UserCompany]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[AppUserId] INT NOT NULL ,
	[CompanyId] INT NOT NULL ,     
    CONSTRAINT [FK_UserCompany_AppUser] FOREIGN KEY ([AppUserId]) REFERENCES [AppUser]([Id]),
	CONSTRAINT [FK_UserCompany_Company] FOREIGN KEY ([CompanyId]) REFERENCES [Company]([Id]),
	 CONSTRAINT [UQ_AppUserCompany] UNIQUE NONCLUSTERED
    (
        [AppUserId],[CompanyId]
    )
)
