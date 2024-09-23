CREATE TABLE [dbo].[Position]
(
	[PositionId] INT NOT NULL PRIMARY KEY, 
    [PositionName] VARCHAR(30) NOT NULL, 
    [PositionDescription] VARCHAR(MAX) NOT NULL, 
    [PayPeriod] VARCHAR(50) NOT NULL, 
    [PayRate] CHAR(1) NOT NULL

)
