/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_EQUIPO]    Script Date: 31/10/2021 22:20:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERTAR_EQUIPO]
	@nombre_equipo varchar(50),
	@dt varchar(500),
	@equipo_nro int OUTPUT
AS
BEGIN
	INSERT INTO EQUIPOS(nombre_equipo, dt)
    VALUES (@nombre_equipo, @dt)
	SET @equipo_nro = SCOPE_IDENTITY();

END
GO