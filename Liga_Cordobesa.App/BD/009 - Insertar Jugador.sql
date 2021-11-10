/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_JUGADOR]    Script Date: 31/10/2021 22:20:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERTAR_JUGADOR] 
	@id_persona int,
	@camiseta int, 
	@id_posicion int, 
	@id_equipo int
AS
BEGIN
	INSERT INTO JUGADORES(id_persona, camiseta, id_posicion, id_equipo)
    VALUES (@id_persona, @camiseta, @id_posicion, @id_equipo);
  
END
GO