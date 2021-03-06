GO
USE [LigaCordobesa]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[SP_VALIDAR_LOGIN]
	@nombreUsuario nvarchar(100),
	@contrasena nvarchar(100),
	@existe bit output
AS
BEGIN
	if ((SELECT id_usuario
		FROM Usuarios
		WHERE nombre_usuario = @nombreUsuario and
		contrasena = @contrasena) <> 0)
		set @existe = 1
		else
		set @existe = 0
END