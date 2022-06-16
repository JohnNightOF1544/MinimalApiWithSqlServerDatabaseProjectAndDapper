CREATE TABLE [dbo].[Person]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Firstname] NVARCHAR(50) NOT NULL, 
    [Middlename] NVARCHAR(50) NOT NULL, 
    [Lastname] NVARCHAR(50) NOT NULL, 
    [Birthdate] DATETIME2 NOT NULL, 
    [Address] NVARCHAR(255) NOT NULL, 
    [Active] BIT NOT NULL
)
