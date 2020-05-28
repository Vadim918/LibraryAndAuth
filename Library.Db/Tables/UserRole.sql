CREATE TABLE [dbo].[UserRole]
(
    [UserId] UNIQUEIDENTIFIER 
        CONSTRAINT [FK_UserRole_User] FOREIGN KEY
        REFERENCES [dbo].[User]([Id]) ON DELETE CASCADE NOT NULL,
    [RoleId] INT 
        CONSTRAINT [FK_UserRole_Role] FOREIGN KEY
        REFERENCES [dbo].[Role]([Id]) ON DELETE CASCADE NOT NULL,
    CONSTRAINT [PK_Membership_UserRole] PRIMARY KEY ([UserId], [RoleId])
)