CREATE TABLE [dbo].[Role]
(
    [Id] INT CONSTRAINT [PK_Membership_Role] PRIMARY KEY, 
    [Name] NVARCHAR(32) NOT NULL CONSTRAINT [UK_Membership_Catalog_Role_Name] UNIQUE
)
