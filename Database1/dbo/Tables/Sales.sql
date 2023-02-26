CREATE TABLE [dbo].[Sales] (
    [SalesID]       INT IDENTITY (1, 1) NOT NULL,
    [SalesPersonID] INT NOT NULL,
    [CustomerID]    INT NOT NULL,
    [ProductID]     INT NOT NULL,
    [Quantity]      INT NOT NULL,
    CONSTRAINT [SalesPK] PRIMARY KEY CLUSTERED ([SalesID] ASC),
    CONSTRAINT [SalesCustomersFK] FOREIGN KEY ([CustomerID]) REFERENCES [dbo].[Customers] ([CustomerID]) ON UPDATE CASCADE,
    CONSTRAINT [SalesEmployeesFK] FOREIGN KEY ([SalesPersonID]) REFERENCES [dbo].[Employees] ([EmployeeID]) ON UPDATE CASCADE,
    CONSTRAINT [SalesProductsFK] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[Products] ([ProductID]) ON UPDATE CASCADE
);

