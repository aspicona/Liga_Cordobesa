/****** Object:  StoredProcedure [dbo].[SP_DELETE_EQUIPO]    Script Date: 31/10/2021 22:20:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DELETE_Equipo] 
	@id int
AS
BEGIN
	DELETE JUGADORES WHERE id_jugador IN (
		SELECT j.id_jugador
		FROM JUGADORES j
		WHERE j.id_equipo = @id)

	DELETE EQUIPOS WHERE id_equipo = @id
  
END
GO