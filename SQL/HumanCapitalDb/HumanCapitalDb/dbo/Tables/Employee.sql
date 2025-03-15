CREATE TABLE [dbo].[Employee] (
    [Id]        UNIQUEIDENTIFIER NOT NULL,
    [Name]      NVARCHAR (MAX)   NOT NULL,
    [Age]       INT              NOT NULL,
    [CompanyId] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Employee_Company_CompanyId] FOREIGN KEY ([CompanyId]) REFERENCES [dbo].[Company] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Employee_CompanyId]
    ON [dbo].[Employee]([CompanyId] ASC);

