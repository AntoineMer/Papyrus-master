use Papyrus

GO
CREATE PROCEDURE select_all (@NOMFOU VARCHAR(64))
AS
BEGIN TRANSACTION select_fournis
GO
SELECT ENTCOM.NUMCOM, ENTCOM.DATECOM, ENTCOM.OBSCOM FROM FOURNIS INNER JOIN ENTCOM ON ENTCOM.NUMCOM = FOURNIS.NUMFOU WHERE FOURNIS.NOMFOU = @NOMFOU
GO
COMMIT TRANSACTION select_fournis
GO;


EXEC select_all 'GROBRIGAN';