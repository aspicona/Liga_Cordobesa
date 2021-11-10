CREATE DATABASE LigaCordobesa

USE LigaCordobesa

CREATE TABLE [dbo].[EQUIPOS](
	[id_equipo] [int] IDENTITY(1,1) NOT NULL,
	[nombre_equipo] [varchar](50) NULL,
	[dt] [varchar](50) NULL,
 CONSTRAINT [pk_id_equipo] PRIMARY KEY (id_equipo))

/****** Object:  Table [dbo].[JUGADORES]    Script Date: 31/10/2021 22:20:54 ******/
CREATE TABLE [dbo].[JUGADORES](
	[id_jugador] [int] IDENTITY(1,1) NOT NULL,
	[id_persona] [int] NOT NULL,
	[camiseta] [int] NOT NULL,
	[id_posicion] [int] NOT NULL,
	[id_equipo] [int] NULL,
 CONSTRAINT [pk_id_jugador] PRIMARY KEY (id_jugador)) 

/****** Object:  Table [dbo].[PERSONAS]    Script Date: 31/10/2021 22:20:54 ******/
CREATE TABLE [dbo].[PERSONAS](
	[id_persona] [int] IDENTITY(1,1) NOT NULL,
	[nro_doc] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[fecha_nac] [datetime] NOT NULL,
 CONSTRAINT [pk_id_persona] PRIMARY KEY (id_persona))

/****** Object:  Table [dbo].[POSICION]    Script Date: 31/10/2021 22:20:54 ******/
CREATE TABLE [dbo].[POSICION](
	[id_posicion] [int] IDENTITY(1,1) NOT NULL,
	[nombre_posicion] [varchar](50) NOT NULL,
 CONSTRAINT [pk_id_posicion] PRIMARY KEY (id_posicion))

/****** Object:  Table [dbo].[POSICION]    Script Date: 31/10/2021 22:20:54 ******/
 create table Usuarios(
	id_usuario int primary key identity,
	nombre_usuario nvarchar(100),
	contrasena nvarchar(100)
)

/*************** ALTER Tables - FK ******************/
ALTER TABLE [dbo].[JUGADORES]  WITH CHECK ADD  CONSTRAINT [fk_id_persona] FOREIGN KEY([id_persona])
REFERENCES [dbo].[PERSONAS] ([id_persona])
GO
ALTER TABLE [dbo].[JUGADORES] CHECK CONSTRAINT [fk_id_persona]
GO
ALTER TABLE [dbo].[JUGADORES]  WITH CHECK ADD  CONSTRAINT [fk_jugadores_equipos] FOREIGN KEY([id_equipo])
REFERENCES [dbo].[EQUIPOS] ([id_equipo])
GO
ALTER TABLE [dbo].[JUGADORES] CHECK CONSTRAINT [fk_jugadores_equipos]
GO
