/****** Object:  StoredProcedure [dbo].[SP_DELETE_JUGADOR]    Script Date: 31/10/2021 22:20:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DELETE_JUGADOR] 
	@id int
AS
BEGIN
	DELETE JUGADORES
    Where id_jugador = @id
  
END
GO