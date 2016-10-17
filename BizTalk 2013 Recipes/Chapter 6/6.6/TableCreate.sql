CREATE TABLE [dbo].[Customer] (
    [CustomerID][int] IDENTITY (1,1) NOT NULL,
    [CustomerName][nvarchar](30) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [Address][nvarchar](60) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [City][nvarchar](30) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [Region][nvarchar](30) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [PostalCode][nvarchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
) ON [PRIMARY]
