/****** Object:  StoredProcedure [dbo].[SP_UPDATE_PERSONA   Script Date: 31/10/2021 22:20:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UPDATE_PERSONA] 
	@nro_doc int,
	@nombre varchar(50),
	@apellido varchar(50),
	@fecha_nac datetime,
	@id_pers int
AS
BEGIN
	UPDATE PERSONAS SET nro_doc = @nro_doc, nombre = @nombre, apellido = @apellido, 
	fecha_nac = @fecha_nac WHERE id_persona = @id_pers;
  
END
GO