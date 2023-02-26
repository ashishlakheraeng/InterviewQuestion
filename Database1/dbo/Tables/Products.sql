CREATE TABLE [dbo].[Products] (
    [ProductID] INT           IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (50) NOT NULL,
    [Price]     MONEY         NULL,
    CONSTRAINT [ProductsPK] PRIMARY KEY CLUSTERED ([ProductID] ASC)
);

