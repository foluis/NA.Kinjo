CREATE TABLE [dbo].[ModuleRole]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[ModuleId] INT NOT NULL,
	[RoleId] INT NOT NULL,
	CONSTRAINT [FK_ModuleRole_Role] FOREIGN KEY ([RoleId]) REFERENCES [Role]([Id]),
	CONSTRAINT [FK_ModuleRole_Module] FOREIGN KEY ([ModuleId]) REFERENCES [Module]([Id]),
	CONSTRAINT [UQ_[ModuleRole] UNIQUE NONCLUSTERED 
    (
        [ModuleId], [RoleId]
    )
)
