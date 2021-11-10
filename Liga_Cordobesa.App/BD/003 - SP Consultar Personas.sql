/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_PERSONA]    Script Date: 31/10/2021 22:20:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SP_CONSULTAR_PERSONA]
AS
BEGIN
	SELECT p.id_persona, p.nro_doc, nombre + ', ' + p.apellido + ' DNI Nº: ' + cast(p.nro_doc as varchar(10)) as nombre, apellido, fecha_nac 
	FROM PERSONAS p
END