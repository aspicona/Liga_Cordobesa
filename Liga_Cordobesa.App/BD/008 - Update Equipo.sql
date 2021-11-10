/****** Object:  StoredProcedure [dbo].[SP_UPDATE_EQUIPO]    Script Date: 31/10/2021 22:20:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UPDATE_EQUIPO]
	@nombre_equipo varchar(50),
	@dt varchar(500),
	@nro int
AS
BEGIN
	UPDATE EQUIPOS SET nombre_equipo = @nombre_equipo, dt = @dt 
	WHERE id_equipo = @nro

END
GO