USE [SIIFMF01]
GO
/****** Object:  StoredProcedure [dbo].[sp_C_VerificaCLABE]    Script Date: 08/02/2018 01:53:18 p.m. ******/
DROP PROCEDURE [dbo].[sp_C_VerificaCLABE]
GO
/****** Object:  StoredProcedure [dbo].[sp_C_VerificaCLABE]    Script Date: 08/02/2018 01:53:18 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Bernardo Ricardo Ostos Córdova
-- Create date: 08/02/2018
-- Description:	Verifico si ya esta verificada la cuenta
-- =============================================
CREATE PROCEDURE [dbo].[sp_C_VerificaCLABE] 
	-- Add the parameters for the stored procedure here
	@strContrato_Id varchar(10) , 
	@strCuentaCLABE nvarchar(18),
	@strResultado varchar(1) OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	IF EXISTS (
			SELECT COUNT(CCV.Id)
			FROM SPEI.dbo.Cuenta_CLABE_Verificada AS CCV
			WHERE CCV.Cuenta_CLABE_Verificada_contrato_Id = @strContrato_Id
				AND CCV.Cuenta_CLABE_Verificada_CLABE = @strCuentaCLABE
			)
		SELECT @strResultado = CCV.Cuenta_CLABE_Verificada_Verificada
		FROM SPEI.dbo.Cuenta_CLABE_Verificada AS CCV
		WHERE CCV.Cuenta_CLABE_Verificada_contrato_Id = @strContrato_Id
			AND CCV.Cuenta_CLABE_Verificada_CLABE = @strCuentaCLABE
	ELSE
		SELECT @strResultado = 0

	RETURN
END


GO
