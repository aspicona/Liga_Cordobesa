/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_PERSONA]    Script Date: 31/10/2021 22:20:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERTAR_PERSONA]
	@nro_doc int,
	@nombre varchar(50),
	@apellido varchar(50),
	@fecha_nac datetime
AS
BEGIN
	INSERT INTO PERSONAS(nro_doc,nombre,apellido,fecha_nac)
    VALUES (@nro_doc, @nombre, @apellido,@fecha_nac);

END
GO