CREATE TABLE [dbo].[Employees] (
    [EmployeeID]    INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]     NVARCHAR (40) NOT NULL,
    [MiddleInitial] NVARCHAR (40) NULL,
    [LastName]      NVARCHAR (40) NOT NULL,
    CONSTRAINT [EmployeePK] PRIMARY KEY CLUSTERED ([EmployeeID] ASC)
);

