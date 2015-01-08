
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/13/2014 10:48:33
-- Generated from EDMX file: C:\Users\vbidntc\Desktop\Calendar\Calendar\Calendar\Calendar\Models\CalendarModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Lv-129.VikBD];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Tasks'
CREATE TABLE [dbo].[Tasks] (
    [TaskId] int IDENTITY(1,1) NOT NULL,
    [TaskName] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Hours] int  NOT NULL,
    [CreateDate] datetime  NOT NULL
);
GO

-- Creating table 'Works'
CREATE TABLE [dbo].[Works] (
    [WorkId] int IDENTITY(1,1) NOT NULL,
    [WorkName] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [BeginDate] datetime  NOT NULL,
    [ReportedHours] int  NOT NULL,
    [TasksTaskId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [TaskId] in table 'Tasks'
ALTER TABLE [dbo].[Tasks]
ADD CONSTRAINT [PK_Tasks]
    PRIMARY KEY CLUSTERED ([TaskId] ASC);
GO

-- Creating primary key on [WorkId] in table 'Works'
ALTER TABLE [dbo].[Works]
ADD CONSTRAINT [PK_Works]
    PRIMARY KEY CLUSTERED ([WorkId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TasksTaskId] in table 'Works'
ALTER TABLE [dbo].[Works]
ADD CONSTRAINT [FK_TasksWorks]
    FOREIGN KEY ([TasksTaskId])
    REFERENCES [dbo].[Tasks]
        ([TaskId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TasksWorks'
CREATE INDEX [IX_FK_TasksWorks]
ON [dbo].[Works]
    ([TasksTaskId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------