if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[caClientes]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[caClientes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[caClienteTipo]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[caClienteTipo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[caEmpresa]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[caEmpresa]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[caUsuarios]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[caUsuarios]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[caUsuariosTipo]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[caUsuariosTipo]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[caVehiculos]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[caVehiculos]
GO

CREATE TABLE [dbo].[caClientes] (
	[clientes_codigo] [int] NULL ,
	[clienteTipo_codigo] [int] NULL ,
	[clientes_apellidoP] [char] (20) NULL ,
	[clientes_apellidoM] [char] (20) NULL ,
	[clientes_nombres] [char] (30) NULL ,
	[clientes_fecha] [datetime] NULL ,
	[clientes_estado] [char] (1) NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[caClienteTipo] (
	[clienteTipo_codigo] [int] NULL ,
	[clienteTipo_letra] [char] (1) NULL ,
	[clienteTipo_descrip] [char] (30) NULL ,
	[clienteTipo_fecha] [datetime] NULL ,
	[clienteTipo_estado] [char] (1) NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[caEmpresa] (
	[empresa_codigo] [int] NULL ,
	[empresa_descrip] [char] (50) NULL ,
	[empresa_estado] [char] (1) NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[caUsuarios] (
	[usuarios_codigo] [int] NULL ,
	[empresas_codigo] [int] NULL ,
	[usuarios_nick] [char] (10) NULL ,
	[usuarios_apellidoP] [char] (20) NULL ,
	[usuarios_apellidoM] [char] (20) NULL ,
	[usuarios_nombres] [char] (30) NULL ,
	[usuarioTipo_codigo] [int] NULL ,
	[usuarios_fecha] [datetime] NULL ,
	[usuarios_estado] [char] (1) NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[caUsuariosTipo] (
	[usuarioTipo_codigo] [int] NULL ,
	[usuarioTipo_descripcion] [char] (30) NULL ,
	[usuarioTipo_estado] [char] (1) NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[caVehiculos] (
	[vehiculos_codgo] [numeric](18, 0) IDENTITY (1, 1) NOT NULL ,
	[vehiculos_marca] [char] (50) NULL ,
	[vehiculos_modelo] [char] (50) NULL ,
	[vehiculos_descripcion] [char] (300) NULL ,
	[vehiculos_cilindraje] [char] (50) NULL ,
	[vehiculos_transmision] [char] (50) NULL ,
	[vehiculos_seguridad] [char] (200) NULL ,
	[vehiculos_fecha] [datetime] NULL ,
	[vehiculos_estado] [char] (1) NULL ,
	[vehiculos_precio] [float] NULL 
) ON [PRIMARY]
GO

