CREATE TABLE [dbo].[Charity]
(
	[CharityId] INT NOT NULL PRIMARY KEY, 
    [ChatityName] VARCHAR(50) NOT NULL, 
    [CharityDescription] NVARCHAR(MAX) NOT NULL, 
    [CharityLogo] VARCHAR(50) NOT NULL
)
