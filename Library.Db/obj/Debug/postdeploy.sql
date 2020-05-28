INSERT INTO [dbo].[Publisher] ([Id], [Name])
VALUES
    ('693FC1B3-B252-4F8F-8500-E07BD862B201', N'Packt Publishing'),
    ('1B2ED9AE-A231-439E-BB37-3A461A224542', N'Manning Publications'),
    ('FE794B2E-7531-4F59-9C15-BCC391757752', N'Apress'),
    ('FC89106F-CB00-4B47-8568-155DB6304E74', N'Wrox');
INSERT INTO [dbo].[Book] ([Id], [Title], [PublisherId], [Description], [PublishingDate], [Rating], [CoverUrl])
VALUES
    ('BFCBBEC9-0023-4A6F-B466-A099F11F3B09', N'ASP.NET Core 2 High Performance', '693FC1B3-B252-4F8F-8500-E07BD862B201', N'Learn how to develop web applications that deploy cross-platform and are optimized for high performance using ASP.NET Core 2', '20171011', 2, N'/images/BFCBBEC9-0023-4A6F-B466-A099F11F3B09/cover.jpg'),
    ('F7E42B20-9F4F-44FF-A7E3-C65C4772B308', N'ASP.NET Core 3 and Angular 9', '693FC1B3-B252-4F8F-8500-E07BD862B201', N'Build a simple, yet fully-functional modern web application using .NET Core 3.1, Entity Framework Core and Angular 9', '20200214', 5, N'/images/F7E42B20-9F4F-44FF-A7E3-C65C4772B308/cover.jpg'),
    ('24BB1407-9AEC-4AF5-A065-F9F088E24DD1', N'ASP.NET Core 3 and React', '693FC1B3-B252-4F8F-8500-E07BD862B201', N'Build modern, scalable, and cloud-ready single-page applications using ASP.NET Core, React, TypeScript, and Azure', '20191227', 5, N'/images/24BB1407-9AEC-4AF5-A065-F9F088E24DD1/cover.jpg'),
    ('D3BC9C40-14FE-4B39-9A9E-1F9F0B4E8D24', N'ASP.NET Core in Action', '1B2ED9AE-A231-439E-BB37-3A461A224542', N'ASP.NET Core in Action is for C# developers without any web development experience who want to get started and productive fast using ASP.NET Core 2.0 to build web applications.', '20180713', 4, N'/images/D3BC9C40-14FE-4B39-9A9E-1F9F0B4E8D24/cover.jpg'),
    ('44980B31-B382-4578-A83E-0706B94348B7', N'ASP.NET Core MVC 2.0 Cookbook', NULL, N'Learn to implement ASP.NET Core features to build effective software that can be scaled and maintained easily', '20180227', NULL, N'/images/44980B31-B382-4578-A83E-0706B94348B7/cover.jpg'),
    ('B904F6F0-530E-4B8A-82C5-5FD1AB85644D', N'ASP.NET Core Recipes', 'FE794B2E-7531-4F59-9C15-BCC391757752', N'Quickly find solutions to common web development problems. Content is presented in the popular problem-solution format. Look up the problem that you want to solve. Read the solution. Apply the solution directly in your own code. Problem solved!', NULL, 5, N'/images/B904F6F0-530E-4B8A-82C5-5FD1AB85644D/cover.jpg'),
    ('07706A1C-93B4-41F3-B2CC-2505E8ADD10F', N'Beginning Database Programming Using ASP.NET Core 3', 'FE794B2E-7531-4F59-9C15-BCC391757752', N'Hit the ground running with this book to quickly learn the fundamentals of HTML form processing, user authentication, and database CRUD (Create, Read, Update, and Delete) operations using the ASP.NET Core family of technologies. You will utilize cutting-edge and popular technology options from both the server side and client side to help you achieve your web application goals as quickly as possible. Developers who want to learn ASP.NET Core and complementary technologies are often overwhelmed by the large number of options involved in building modern web applications. This book introduces you to the most popular options so that you can confidently begin working on projects in no time. You will learn by example, building a sample application that demonstrates how the same application can be built using different options. This experiential approach will give you the basic skills and knowledge to understand how the options work together so that you can make an informed decision about the available choices, their trade-offs, and code level comparison. After reading this book, you will be able to choose your selected learning path.', '20191213', 3.9, NULL),
    ('C3F12A65-846F-4CEB-B0B1-4AFCEA715725', N'C# 8 and .NET Core 3 Projects Using Azure', '693FC1B3-B252-4F8F-8500-E07BD862B201', N'Get up to speed with using C# 8 and .NET Core 3.0 features to build real-world .NET Core applications', '20191231', 5, N'/images/C3F12A65-846F-4CEB-B0B1-4AFCEA715725/cover.jpg'),
    ('2E1CDB79-2F96-4B07-86D4-8AE686359E52', N'C# 8.0 and .NET Core 3.0 - Modern Cross-Platform Development', '693FC1B3-B252-4F8F-8500-E07BD862B201', N'Learn the fundamentals, practical applications, and latest features of C# 8.0 and .NET Core 3.0 from expert teacher Mark J. Price.', '20191030', 4.3, N'/images/2E1CDB79-2F96-4B07-86D4-8AE686359E52/cover.jpg'),
    ('E383EBFF-D03B-49BE-8F51-DE2D977F3E2F', N'Dependency Injection Principles, Practices, and Patterns', '1B2ED9AE-A231-439E-BB37-3A461A224542', N'Dependency Injection Principles, Practices, and Patterns teaches you to use DI to reduce hard-coded dependencies between application components. You''ll start by learning what DI is and what types of applications will benefit from it. Then, you''ll work through concrete scenarios using C# and the .NET framework to implement DI in your own projects. As you dive into the thoroughly-explained examples, you''ll develop a foundation you can apply to any of the many DI libraries for .NET and .NET Core.', '20190316', 4.8, N'/images/E383EBFF-D03B-49BE-8F51-DE2D977F3E2F/cover.jpg'),
    ('233D3A46-087E-42CE-9630-B95D9AE81AB8', N'Exploring Advanced Features in C#', 'FE794B2E-7531-4F59-9C15-BCC391757752', NULL, '20190530', 5, N'/images/233D3A46-087E-42CE-9630-B95D9AE81AB8/cover.jpg'),
    ('B20E91B7-29E7-405D-B876-0304EEE160E4', N'Pro C# 7', 'FE794B2E-7531-4F59-9C15-BCC391757752', N'This essential classic title provides a comprehensive foundation in the C# programming language and the frameworks it lives in. Now in its 8th edition, you’ll find all the very latest C# 7.1 and .NET 4.7 features here, along with four brand new chapters on Microsoft’s lightweight, cross-platform framework, .NET Core, up to and including .NET Core 2.0. Coverage of ASP.NET Core, Entity Framework (EF) Core, and more, sits alongside the latest updates to .NET, including Windows Presentation Foundation (WPF), Windows Communication Foundation (WCF), and ASP.NET MVC.', '20171121', 4.5, N'/images/B20E91B7-29E7-405D-B876-0304EEE160E4/cover.jpg');
INSERT INTO [dbo].[Author] ([Id], [FirstName], [LastName])
VALUES
    ('C12C49AB-1BD0-4EC6-AB35-1DE1566C670D', N'James', N'Singleton'),
    ('0E1257D6-9661-4D54-9C30-E924B4CF1B72', N'Valerio de', N'Sanctis'),
    ('CA1A7854-48FF-40A8-AA64-1529B3ED8C64', N'Carl', N'Rippon'),
    ('D70FAE92-F1F9-41F5-9DA4-0D16541B2810', N'Andrew', N'Lock'),
    ('F2BC8170-CEF3-4BFE-B3F2-C25C6E1AA206', N'Stephane', N'Belkeheraz'),
    ('CB1BE868-075E-467D-BFE5-71CD75B83DE4', N'John', N'Ciliberti'),
    ('00ED48C2-D073-48A8-98B1-DD68FA0E2FF4', N'Bipin', N'Joshi'),
    ('B150B748-F175-4779-96C6-70C7E4FCCE31', N'Paul', N'Michaels'),
    ('36FF6930-31DB-4295-BB06-B38520A6BDAB', N'Dirk', N'Strauss'),
    ('68D29187-9243-4E77-9ECF-5612984368DA', N'Jas', N'Rademeyer'),
    ('BAD3A770-A234-406F-B4C2-78F827630CA9', N'Mark J.', N'Price'),
    ('288DB2D7-D00D-479D-8DE4-2E7F4C5D42D2', N'Adam', N'Freeman'),
    ('5C5048A8-193A-4390-AB88-50DC75D3473C', N'Mark', N'Seemann');
INSERT INTO [dbo].[BookAuthor] ([BookId], [AuthorId])
VALUES
    ('BFCBBEC9-0023-4A6F-B466-A099F11F3B09', 'C12C49AB-1BD0-4EC6-AB35-1DE1566C670D'),
    ('F7E42B20-9F4F-44FF-A7E3-C65C4772B308', '0E1257D6-9661-4D54-9C30-E924B4CF1B72'),
    ('24BB1407-9AEC-4AF5-A065-F9F088E24DD1', 'CA1A7854-48FF-40A8-AA64-1529B3ED8C64'),
    ('D3BC9C40-14FE-4B39-9A9E-1F9F0B4E8D24', 'D70FAE92-F1F9-41F5-9DA4-0D16541B2810'),
    ('44980B31-B382-4578-A83E-0706B94348B7', 'F2BC8170-CEF3-4BFE-B3F2-C25C6E1AA206'),
    ('B904F6F0-530E-4B8A-82C5-5FD1AB85644D', 'CB1BE868-075E-467D-BFE5-71CD75B83DE4'),
    ('07706A1C-93B4-41F3-B2CC-2505E8ADD10F', '00ED48C2-D073-48A8-98B1-DD68FA0E2FF4'),
    ('C3F12A65-846F-4CEB-B0B1-4AFCEA715725', 'B150B748-F175-4779-96C6-70C7E4FCCE31'),
    ('C3F12A65-846F-4CEB-B0B1-4AFCEA715725', '36FF6930-31DB-4295-BB06-B38520A6BDAB'),
    ('C3F12A65-846F-4CEB-B0B1-4AFCEA715725', '68D29187-9243-4E77-9ECF-5612984368DA'),
    ('2E1CDB79-2F96-4B07-86D4-8AE686359E52', 'BAD3A770-A234-406F-B4C2-78F827630CA9'),
    ('E383EBFF-D03B-49BE-8F51-DE2D977F3E2F', '5C5048A8-193A-4390-AB88-50DC75D3473C'),
    ('233D3A46-087E-42CE-9630-B95D9AE81AB8', '36FF6930-31DB-4295-BB06-B38520A6BDAB');
INSERT INTO [dbo].[Role] (Id, [Name])
VALUES
    (1, N'Admin'),
    (2, N'Editor'),
    (3, N'User');
INSERT INTO [dbo].[User] ([Id], [Email], [PasswordHash], [FirstName], [LastName], [IsActive])
VALUES
    ('18f63087-80fa-45ba-b623-1da170c90071', N'admin@admin.com', N'12345', N'Admin', N'Admin', 1),
    ('5a289601-00d1-452a-b803-ae143f087111', N'alexanderpatuk@coherentsolutions.com', N'12345', N'Alexander', N'Patuk', 1),
    ('e6cf13a7-d155-41e2-ba32-64b97f88d4ad', N'alexanderzhevnyak@coherentsolutions.com', N'12345', N'Alexander', N'Zhevnyak', 1),
    ('95ec68e9-fc14-4806-98a2-b0a1c411cabd', N'alexeykravchenko@coherentsolutions.com', N'12345', N'Alexey', N'Kravchenko', 1),
    ('c157ccb6-e444-4aec-a7c3-57fa9e1125a8', N'alexeyvolosevich@coherentsolutions.com', N'12345', N'Alexey', N'Volosevich', 1),
    ('d55c4277-9163-499e-9e8f-ee8389c828b5', N'andreyfrantov@coherentsolutions.com', N'12345', N'Andrey', N'Frantov', 0),
    ('c690b2c4-6f72-47e9-b0a8-7f9a1232477b', N'andreylapitsky@coherentsolutions.com', N'12345', N'Andrey', N'Lapitsky', 1),
    ('dab9e880-4d88-4e55-b05f-d6034b08d6a2', N'andreyp@coherentsolutions.com', N'12345', N'Andrey', N'Protas', 1),
    ('779e0ba9-892e-4359-b1ff-5ca0ff9de766', N'andreyvershadov@coherentsolutions.com', N'12345', N'Andrey', N'Vershadov', 1),
    ('46c0f7c6-cb46-4c55-ab60-919fb08385f0', N'antonkovalevsky@coherentsolutions.com', N'12345', N'Anton', N'Kovalevsky', 0),
    ('d84816fc-cb27-468f-964b-8a2eb65280e9', N'dmitrybardt@coherentsolutions.com', N'12345', N'Dmitry', N'Bardt', 1),
    ('613e726c-6c56-48b6-9eb2-7defaebcc29f', N'dmitrykavtur@coherentsolutions.com', N'12345', N'Dmitry', N'Kavtur', 1),
    ('ec122aed-39a4-42c0-9ca8-877343a2eebd', N'dmitrypetruchenya@coherentsolutions.com', N'12345', N'Dmitry', N'Petruchenya', 1);

INSERT INTO [dbo].[UserRole] ([UserId], [RoleId])
VALUES
    ('18f63087-80fa-45ba-b623-1da170c90071', 1),
    ('18f63087-80fa-45ba-b623-1da170c90071', 2),
    ('5A289601-00D1-452A-B803-AE143F087111', 2),
    ('95EC68E9-FC14-4806-98A2-B0A1C411CABD', 2),
    ('C157CCB6-E444-4AEC-A7C3-57FA9E1125A8', 3),
    ('D55C4277-9163-499E-9E8F-EE8389C828B5', 2),
    ('D55C4277-9163-499E-9E8F-EE8389C828B5', 3),
    ('C690B2C4-6F72-47E9-B0A8-7F9A1232477B', 2),
    ('DAB9E880-4D88-4E55-B05F-D6034B08D6A2', 2),
    ('779E0BA9-892E-4359-B1FF-5CA0FF9DE766', 1),
    ('779E0BA9-892E-4359-B1FF-5CA0FF9DE766', 2),
    ('779E0BA9-892E-4359-B1FF-5CA0FF9DE766', 3),
    ('46C0F7C6-CB46-4C55-AB60-919FB08385F0', 2),
    ('D84816FC-CB27-468F-964B-8A2EB65280E9', 3),
    ('613E726C-6C56-48B6-9EB2-7DEFAEBCC29F', 2),
    ('613E726C-6C56-48B6-9EB2-7DEFAEBCC29F', 3),
    ('EC122AED-39A4-42C0-9CA8-877343A2EEBD', 2);
GO
