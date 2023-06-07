CREATE TABLE [dbo].[Products] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
	[Company] VARCHAR(50) NULL,
    [Name]        VARCHAR (50) NOT NULL,
    [UnitPrice]   MONEY        NOT NULL,
    [StockAmount] INT          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

