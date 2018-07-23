﻿CREATE TABLE [dbo].[Company]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(100) NOT NULL, 
    [Address] VARCHAR(200) NOT NULL, 
    [Phone] VARCHAR(20) NOT NULL, 
    [IsActive] BIT NOT NULL DEFAULT 1
)