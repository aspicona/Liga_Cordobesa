/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_JUGADORES]    Script Date: 31/10/2021 22:20:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_CONSULTAR_JUGADORES]
AS
BEGIN
	SELECT j.id_jugador, pe.nombre, pe.apellido, pe.nro_doc, pe.fecha_nac, e.nombre_equipo, j.camiseta, po.nombre_posicion, pe.id_persona
	FROM JUGADORES j JOIN PERSONAS pe ON j.id_persona = pe.id_persona
		JOIN POSICION po ON po.id_posicion = j.id_posicion
		JOIN EQUIPOS e ON j.id_equipo = e.id_equipo
END

GO