USE master;
GO
IF DB_ID (N'DBShop') IS NOT NULL
	DROP DATABASE DBShop
CREATE DATABASE DBShop;
GO
USE DBShop;
CREATE TABLE [dbo].[Supplyers] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [SupplyerName] NVARCHAR (30) NOT NULL,
    CONSTRAINT [PK_dbo.Supplyers] PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO
CREATE TABLE [dbo].[Products] (
    [Id]              INT             IDENTITY (1, 1) NOT NULL,
    [ProductName]     NVARCHAR (30)   NOT NULL,
    [SupplyerId]      INT             NOT NULL,
    [ProductPrice]    DECIMAL (18, 2) NOT NULL,
    [ProductQuantity] INT             NOT NULL,
    CONSTRAINT [PK_dbo.Products] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_Products_ToSupplyers] FOREIGN KEY ([SupplyerId]) REFERENCES [dbo].[Supplyers] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE
);
GO
CREATE TABLE [dbo].[Sales] (
    [Id]              INT             IDENTITY (1, 1) NOT NULL,
    [ProductId]       INT             NOT NULL,
    [ProductPrice]    DECIMAL (18, 2) NOT NULL,
    [ProductQuantity] INT             NOT NULL,
    [SaleDatetime]    DATETIME        NOT NULL,
    CONSTRAINT [PK_dbo.Sales] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_Sales_ToProducts] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE
);
GO
CREATE TABLE [dbo].[Supplies] (
    [Id]              INT             IDENTITY (1, 1) NOT NULL,
    [SupplyerId]      INT             NOT NULL,
    [ProductId]       INT             NOT NULL,
    [ProductPrice]    DECIMAL (18, 2) NOT NULL,
    [ProductQuantity] INT             NOT NULL,
    [SupplyDatetime]  DATETIME        NOT NULL,
    CONSTRAINT [PK_dbo.Supplies] PRIMARY KEY CLUSTERED ([Id] ASC),
	CONSTRAINT [FK_Supplies_ToProducts] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([Id]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [FK_Supplies_ToSupplyers] FOREIGN KEY ([SupplyerId]) REFERENCES [dbo].[Supplyers] ([Id])

);