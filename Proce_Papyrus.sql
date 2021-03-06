USE [Papyrus]
GO
/****** Object:  StoredProcedure [dbo].[add_fourni]    Script Date: 30/01/2018 16:53:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_fourni](@num INT, @name VARCHAR(30), @street VARCHAR(40), @CP VARCHAR(5), @city VARCHAR(30), @cont VARCHAR(15), @satis INT)
AS 
BEGIN TRANSACTION adder
INSERT INTO FOURNIS 
(NUMFOU, NOMFOU, RUEFOU, POSFOU, VILFOU, CONFOU, SATISF)
VALUES 
(@num ,@name, @street, @CP, @city, @cont, @satis)
COMMIT TRANSACTION 
GO;

GO
/****** Object:  StoredProcedure [dbo].[del_fourni]    Script Date: 30/01/2018 16:53:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[del_fourni] (@num INT)
AS 
BEGIN TRANSACTION deleter
DELETE FOURNIS WHERE NUMFOU LIKE @num
COMMIT TRANSACTION
GO;
GO
/****** Object:  StoredProcedure [dbo].[find_NOM]    Script Date: 30/01/2018 16:53:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[find_NOM] (@num_four INT)
AS
BEGIN TRANSACTION name

SELECT * FROM [dbo].[FOURNIS] WHERE @num_four = NUMFOU

COMMIT TRANSACTION 
GO;


GO
/****** Object:  StoredProcedure [dbo].[GetEntCom]    Script Date: 30/01/2018 16:53:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetEntCom] 
@NomFou VARCHAR(30)
AS
BEGIN
  IF (@NomFou='')
  BEGIN
	SELECT NUMCOM,DATECOM,OBSCOM FROM ENTCOM
  END
 ELSE
  BEGIN
	SELECT NUMCOM, DATECOM, OBSCOM FROM ENTCOM JOIN FOURNIS ON ENTCOM.NUMFOU=FOURNIS.NUMFOU
	WHERE FOURNIS.NOMFOU=@NomFou
 END
END

GO
/****** Object:  StoredProcedure [dbo].[ListFournisseurs]    Script Date: 30/01/2018 16:53:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListFournisseurs]
AS
SELECT * FROM dbo.Fournis


GO
/****** Object:  StoredProcedure [dbo].[select_all]    Script Date: 30/01/2018 16:53:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_all] (@NOMFOU VARCHAR(64))
AS
BEGIN TRANSACTION select_fournis

GO
/****** Object:  StoredProcedure [dbo].[select_comm]    Script Date: 30/01/2018 16:53:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_comm] (@fourni_nom VARCHAR(30))
AS
BEGIN TRANSACTION comm
SELECT ENTCOM.NUMCOM, ENTCOM.DATECOM, ENTCOM.OBSCOM 
FROM ENTCOM 
INNER JOIN FOURNIS
	ON ENTCOM.NUMFOU = FOURNIS.NUMFOU
WHERE FOURNIS.NOMFOU LIKE @fourni_nom
COMMIT TRANSACTION
GO;


GO
/****** Object:  StoredProcedure [dbo].[test]    Script Date: 30/01/2018 16:53:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[test] 
@NomFou VARCHAR(30)
AS
BEGIN
  IF (@NomFou='')
  BEGIN
	SELECT NUMCOM,DATECOM,OBSCOM FROM ENTCOM
  END
 ELSE
  BEGIN
	SELECT NUMCOM, DATECOM, OBSCOM FROM ENTCOM JOIN FOURNIS ON ENTCOM.NUMFOU=FOURNIS.NUMFOU
	WHERE FOURNIS.NOMFOU=@NomFou
 END
END

GO
