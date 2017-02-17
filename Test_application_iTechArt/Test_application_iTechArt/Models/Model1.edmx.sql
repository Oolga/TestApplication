
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/17/2017 14:54:04
-- Generated from EDMX file: D:\Project\Test_application_iTechArt\Test_application_iTechArt\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [olga.mikholenko];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__Depot__CountryId__33D4B598]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Depot] DROP CONSTRAINT [FK__Depot__CountryId__33D4B598];
GO
IF OBJECT_ID(N'[dbo].[FK__DrugUnit__DepotI__5CD6CB2B]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DrugUnit] DROP CONSTRAINT [FK__DrugUnit__DepotI__5CD6CB2B];
GO
IF OBJECT_ID(N'[dbo].[FK__DrugUnit__DrugTy__5DCAEF64]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DrugUnit] DROP CONSTRAINT [FK__DrugUnit__DrugTy__5DCAEF64];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Country]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Country];
GO
IF OBJECT_ID(N'[dbo].[Depot]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Depot];
GO
IF OBJECT_ID(N'[dbo].[DrugType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DrugType];
GO
IF OBJECT_ID(N'[dbo].[DrugUnit]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DrugUnit];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Country'
CREATE TABLE [dbo].[Country] (
    [CountryId] int  NOT NULL,
    [CountryName] varchar(100)  NOT NULL
);
GO

-- Creating table 'Depot'
CREATE TABLE [dbo].[Depot] (
    [DepotId] int  NOT NULL,
    [DepotName] varchar(100)  NOT NULL,
    [CountryId] int  NOT NULL
);
GO

-- Creating table 'DrugType'
CREATE TABLE [dbo].[DrugType] (
    [DrugTypeId] int  NOT NULL,
    [DrugTypeName] varchar(100)  NOT NULL,
    [Weight] float  NOT NULL
);
GO

-- Creating table 'DrugUnit'
CREATE TABLE [dbo].[DrugUnit] (
    [DrugUnitId] int  NOT NULL,
    [PickNumber] int  NULL,
    [DepotId] int  NULL,
    [DrugTypeId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CountryId] in table 'Country'
ALTER TABLE [dbo].[Country]
ADD CONSTRAINT [PK_Country]
    PRIMARY KEY CLUSTERED ([CountryId] ASC);
GO

-- Creating primary key on [DepotId] in table 'Depot'
ALTER TABLE [dbo].[Depot]
ADD CONSTRAINT [PK_Depot]
    PRIMARY KEY CLUSTERED ([DepotId] ASC);
GO

-- Creating primary key on [DrugTypeId] in table 'DrugType'
ALTER TABLE [dbo].[DrugType]
ADD CONSTRAINT [PK_DrugType]
    PRIMARY KEY CLUSTERED ([DrugTypeId] ASC);
GO

-- Creating primary key on [DrugUnitId] in table 'DrugUnit'
ALTER TABLE [dbo].[DrugUnit]
ADD CONSTRAINT [PK_DrugUnit]
    PRIMARY KEY CLUSTERED ([DrugUnitId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CountryId] in table 'Depot'
ALTER TABLE [dbo].[Depot]
ADD CONSTRAINT [FK__Depot__CountryId__33D4B598]
    FOREIGN KEY ([CountryId])
    REFERENCES [dbo].[Country]
        ([CountryId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Depot__CountryId__33D4B598'
CREATE INDEX [IX_FK__Depot__CountryId__33D4B598]
ON [dbo].[Depot]
    ([CountryId]);
GO

-- Creating foreign key on [DepotId] in table 'DrugUnit'
ALTER TABLE [dbo].[DrugUnit]
ADD CONSTRAINT [FK__DrugUnit__DepotI__5CD6CB2B]
    FOREIGN KEY ([DepotId])
    REFERENCES [dbo].[Depot]
        ([DepotId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__DrugUnit__DepotI__5CD6CB2B'
CREATE INDEX [IX_FK__DrugUnit__DepotI__5CD6CB2B]
ON [dbo].[DrugUnit]
    ([DepotId]);
GO

-- Creating foreign key on [DrugTypeId] in table 'DrugUnit'
ALTER TABLE [dbo].[DrugUnit]
ADD CONSTRAINT [FK__DrugUnit__DrugTy__5DCAEF64]
    FOREIGN KEY ([DrugTypeId])
    REFERENCES [dbo].[DrugType]
        ([DrugTypeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__DrugUnit__DrugTy__5DCAEF64'
CREATE INDEX [IX_FK__DrugUnit__DrugTy__5DCAEF64]
ON [dbo].[DrugUnit]
    ([DrugTypeId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------