This is part of library management system.
Developed  by Kir t Shah
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