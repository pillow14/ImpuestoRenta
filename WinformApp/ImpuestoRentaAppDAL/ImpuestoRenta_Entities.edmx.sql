
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/30/2019 21:41:30
-- Generated from EDMX file: C:\Users\macbook\Proyectos\ImpuestoRenta\WinformApp\ImpuestoRentaAppDAL\ImpuestoRenta_Entities.edmx
-- --------------------------------------------------
CREATE DATABASE GSV_EnvioImpuestoRenta;
GO

SET QUOTED_IDENTIFIER OFF;
GO
USE [GSV_EnvioImpuestoRenta];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__ImpuestoR__impue__1ED998B2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ImpuestoRenta] DROP CONSTRAINT [FK__ImpuestoR__impue__1ED998B2];
GO
IF OBJECT_ID(N'[dbo].[FK__LogActivi__log_i__164452B1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LogActividad] DROP CONSTRAINT [FK__LogActivi__log_i__164452B1];
GO
IF OBJECT_ID(N'[dbo].[FK__LogActivi__usuar__15502E78]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LogActividad] DROP CONSTRAINT [FK__LogActivi__usuar__15502E78];
GO
IF OBJECT_ID(N'[dbo].[FK_impuestorenta_id]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LogActividad] DROP CONSTRAINT [FK_impuestorenta_id];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ImpuestoRenta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ImpuestoRenta];
GO
IF OBJECT_ID(N'[dbo].[ImpuestoRentaTipo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ImpuestoRentaTipo];
GO
IF OBJECT_ID(N'[dbo].[Log]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Log];
GO
IF OBJECT_ID(N'[dbo].[LogActividad]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LogActividad];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[Usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuario];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ImpuestoRenta'
CREATE TABLE [dbo].[ImpuestoRenta] (
    [impuestorenta_id] int IDENTITY(1,1) NOT NULL,
    [impuestorentatipo_id] int  NULL,
    [esta_activo] bit  NOT NULL
);
GO

-- Creating table 'ImpuestoRentaTipo'
CREATE TABLE [dbo].[ImpuestoRentaTipo] (
    [impuestorentatipo_id] int IDENTITY(1,1) NOT NULL,
    [descripcion_impuesto_renta_tipo] varchar(50)  NOT NULL,
    [esta_activo] bit  NOT NULL
);
GO

-- Creating table 'Log'
CREATE TABLE [dbo].[Log] (
    [log_id] int IDENTITY(1,1) NOT NULL,
    [descripcion_log] varchar(50)  NOT NULL,
    [esta_activo] bit  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'Usuario'
CREATE TABLE [dbo].[Usuario] (
    [usuario_id] int IDENTITY(1,1) NOT NULL,
    [nombre_usuario] varchar(50)  NOT NULL,
    [correo_electronico] varchar(50)  NOT NULL,
    [esta_activo] bit  NOT NULL,
    [rut] varchar(50)  NULL,
    [clave] varchar(50)  NULL
);
GO

-- Creating table 'LogActividad'
CREATE TABLE [dbo].[LogActividad] (
    [logactividad_id] int IDENTITY(1,1) NOT NULL,
    [usuario_id] int  NULL,
    [log_id] int  NULL,
    [descripcion_accion] varchar(500)  NULL,
    [nombre_usuario] varchar(50)  NOT NULL,
    [fecha_accion] datetime  NOT NULL,
    [condicion_accion] bit  NOT NULL,
    [esta_activo] bit  NOT NULL,
    [impuestorenta_id] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [impuestorenta_id] in table 'ImpuestoRenta'
ALTER TABLE [dbo].[ImpuestoRenta]
ADD CONSTRAINT [PK_ImpuestoRenta]
    PRIMARY KEY CLUSTERED ([impuestorenta_id] ASC);
GO

-- Creating primary key on [impuestorentatipo_id] in table 'ImpuestoRentaTipo'
ALTER TABLE [dbo].[ImpuestoRentaTipo]
ADD CONSTRAINT [PK_ImpuestoRentaTipo]
    PRIMARY KEY CLUSTERED ([impuestorentatipo_id] ASC);
GO

-- Creating primary key on [log_id] in table 'Log'
ALTER TABLE [dbo].[Log]
ADD CONSTRAINT [PK_Log]
    PRIMARY KEY CLUSTERED ([log_id] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [usuario_id] in table 'Usuario'
ALTER TABLE [dbo].[Usuario]
ADD CONSTRAINT [PK_Usuario]
    PRIMARY KEY CLUSTERED ([usuario_id] ASC);
GO

-- Creating primary key on [logactividad_id] in table 'LogActividad'
ALTER TABLE [dbo].[LogActividad]
ADD CONSTRAINT [PK_LogActividad]
    PRIMARY KEY CLUSTERED ([logactividad_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [impuestorentatipo_id] in table 'ImpuestoRenta'
ALTER TABLE [dbo].[ImpuestoRenta]
ADD CONSTRAINT [FK__ImpuestoR__impue__1ED998B2]
    FOREIGN KEY ([impuestorentatipo_id])
    REFERENCES [dbo].[ImpuestoRentaTipo]
        ([impuestorentatipo_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__ImpuestoR__impue__1ED998B2'
CREATE INDEX [IX_FK__ImpuestoR__impue__1ED998B2]
ON [dbo].[ImpuestoRenta]
    ([impuestorentatipo_id]);
GO

-- Creating foreign key on [impuestorenta_id] in table 'LogActividad'
ALTER TABLE [dbo].[LogActividad]
ADD CONSTRAINT [FK_impuestorenta_id]
    FOREIGN KEY ([impuestorenta_id])
    REFERENCES [dbo].[ImpuestoRenta]
        ([impuestorenta_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_impuestorenta_id'
CREATE INDEX [IX_FK_impuestorenta_id]
ON [dbo].[LogActividad]
    ([impuestorenta_id]);
GO

-- Creating foreign key on [log_id] in table 'LogActividad'
ALTER TABLE [dbo].[LogActividad]
ADD CONSTRAINT [FK__LogActivi__log_i__164452B1]
    FOREIGN KEY ([log_id])
    REFERENCES [dbo].[Log]
        ([log_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__LogActivi__log_i__164452B1'
CREATE INDEX [IX_FK__LogActivi__log_i__164452B1]
ON [dbo].[LogActividad]
    ([log_id]);
GO

-- Creating foreign key on [usuario_id] in table 'LogActividad'
ALTER TABLE [dbo].[LogActividad]
ADD CONSTRAINT [FK__LogActivi__usuar__15502E78]
    FOREIGN KEY ([usuario_id])
    REFERENCES [dbo].[Usuario]
        ([usuario_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__LogActivi__usuar__15502E78'
CREATE INDEX [IX_FK__LogActivi__usuar__15502E78]
ON [dbo].[LogActividad]
    ([usuario_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------