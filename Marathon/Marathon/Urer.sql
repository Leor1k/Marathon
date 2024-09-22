CREATE TABLE [dbo].[User]
(
	[Email] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [Password] VARCHAR(50) NOT NULL, 
    [FirstName] NCHAR(10) NOT NULL, 
    [LastName] NCHAR(10) NOT NULL, 
    [RoleId] char NOT NULL Foreign key references [Role] ([RoleId])
)
