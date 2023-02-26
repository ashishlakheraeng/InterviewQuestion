CREATE TABLE [dbo].[FileTable1]
	(
	Id int Primary key identity(1,1),
	testcol varchar ,
	createDate datetime default getdate(), 
    [updatedDate] DATETIME NULL DEFAULT getdate(),

	)
