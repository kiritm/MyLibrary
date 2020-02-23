This is part of library management system.
Developed  by Kirit Shah
email:- kiritshah234@gmail.com

ASP.NETCore 2.2

https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/2.2.6
Install-Package Microsoft.EntityFrameworkCore -Version 2.2.6

Add-Migration "InitialCreate"
update-Database

//DB created  CREATE TABLE [Books] (
          [Id] int NOT NULL IDENTITY,
          [BookTitle] nvarchar(100) NOT NULL,
          [BookEdition] nvarchar(20) NULL,
          [BookAuthor1] nvarchar(50) NULL,
          [BookAuthor2] nvarchar(50) NULL,
          [BookCategory] nvarchar(50) NULL,
          [BookPurchasePrice] decimal(6,2) NOT NULL,
          [BookPublisher] nvarchar(50) NULL,
          [BookISBN] nvarchar(50) NULL,
          [BookStatus] nvarchar(50) NULL,
          [BookStorage_Code] nvarchar(50) NULL,
          [BookStorage_Type] nvarchar(50) NULL,
          CONSTRAINT [PK_Books] PRIMARY KEY ([Id])
      );

/*
USE [MyLibraryDB]
GO

/****** Object: Table [dbo].[Books] Script Date: 2/23/2020 1:22:21 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Books] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [BookTitle]         NVARCHAR (100) NOT NULL,
    [BookEdition]       NVARCHAR (20)  NULL,
    [BookAuthor1]       NVARCHAR (50)  NULL,
    [BookAuthor2]       NVARCHAR (50)  NULL,
    [BookCategory]      NVARCHAR (50)  NULL,
    [BookPurchasePrice] DECIMAL (6, 2) NOT NULL,
    [BookPublisher]     NVARCHAR (50)  NULL,
    [BookISBN]          NVARCHAR (50)  NULL,
    [BookStatus]        NVARCHAR (50)  NULL,
    [BookStorage_Code]  NVARCHAR (50)  NULL,
    [BookStorage_Type]  NVARCHAR (50)  NULL
);

SET IDENTITY_INSERT [dbo].[Books] ON
INSERT INTO [dbo].[Books] ([Id], [BookTitle], [BookEdition], [BookAuthor1], [BookAuthor2], [BookCategory], [BookPurchasePrice], [BookPublisher], [BookISBN], [BookStatus], [BookStorage_Code], [BookStorage_Type]) VALUES (1, N'Visual Basic 6 Black Book', N'First Edition', N'Steven Holzner', N'', N'Programming Languages', CAST(5.59 AS Decimal(6, 2)), N'Coriolis Group Books (1998)', N'1576102831', N'Available', N'978-1576102831', N'Paperback – 1998')
INSERT INTO [dbo].[Books] ([Id], [BookTitle], [BookEdition], [BookAuthor1], [BookAuthor2], [BookCategory], [BookPurchasePrice], [BookPublisher], [BookISBN], [BookStatus], [BookStorage_Code], [BookStorage_Type]) VALUES (3, N'Pascal Precisely for Engineers and Scientists', N'First Edition', N'Judy Bishop', N'Nigel Bishop', N'Programming Languages', CAST(8.95 AS Decimal(6, 2)), N'Addison-Wesley (September 1, 1990)', N'0201416921', N'Available', N'978-0201416923', N'Paperback')
SET IDENTITY_INSERT [dbo].[Books] OFF


*/