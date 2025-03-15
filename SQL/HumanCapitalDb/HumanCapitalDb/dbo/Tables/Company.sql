CREATE TABLE [dbo].[Company] (
    [Id]      UNIQUEIDENTIFIER NOT NULL,
    [Name]    NVARCHAR (60)    NOT NULL,
    [Address] NVARCHAR (60)    NOT NULL,
    CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED ([Id] ASC)
);

