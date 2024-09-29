CREATE TABLE [dbo].[User]
(
	[Email] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [Password] VARCHAR(100) NOT NULL, 
    [FirstName] NCHAR(30) NOT NULL, 
    [LastName] NCHAR(30) NOT NULL, 
    [RoleId] char NOT NULL Foreign key references [Role] ([RoleId])
)
