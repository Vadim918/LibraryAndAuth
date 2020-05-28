CREATE TABLE [dbo].[User]
(
    [Id] UNIQUEIDENTIFIER CONSTRAINT [PK_Membership_User] PRIMARY KEY,
    [Email] NVARCHAR(128) NOT NULL CONSTRAINT [UK_Membership_User_Email] UNIQUE,
    [PasswordHash] NVARCHAR(128) NOT NULL,
    [FirstName] NVARCHAR(128) NOT NULL,
    [LastName] NVARCHAR(128) NOT NULL,
    [IsActive] BIT NOT NULL
)
