/****** Object:  StoredProcedure [dbo].[SP_EQUIPO_BY_ID]    Script Date: 31/10/2021 22:20:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EQUIPO_BY_ID]
@id int 
AS
BEGIN
	SELECT *
	FROM EQUIPOS Where id_equipo = @id
END	
GO