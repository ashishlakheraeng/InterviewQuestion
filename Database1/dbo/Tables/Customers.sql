CREATE TABLE [dbo].[Customers] (
    [CustomerID]    INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]     NVARCHAR (40) NOT NULL,
    [MiddleInitial] NVARCHAR (40) NULL,
    [LastName]      NVARCHAR (40) NOT NULL,
    CONSTRAINT [CustomerPK] PRIMARY KEY CLUSTERED ([CustomerID] ASC)
);

