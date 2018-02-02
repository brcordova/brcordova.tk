SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Bernardo Ricardo Ostos Córdova
-- Create date: 30/01/2018
-- Description:	Verifica si existe el DV en la tabla de Contrato_Digito
-- =============================================
CREATE PROCEDURE sp_In_AgregaCuentaBancaria
	-- Add the parameters for the stored procedure here
	@pstrContratoId VARCHAR(6),
	@pintDV AS INT OUTPUT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	-- Parametros requeridos
	DECLARE @pintRegistros AS INT
	

	-- Obtengo el DV de la cuenta.
	SELECT TOP 1 @pintDV = Digito
	FROM SIIFMF01.dbo.Contrato_Digito
	WHERE Contrato_Id = @pstrContratoId

	-- Verifico 
	SELECT @pintRegistros = COUNT(CD.Digito)
	FROM SIIFMF01.dbo.Contrato_Digito AS CD
	WHERE CD.Banco_Id = 646
		AND CD.Contrato_Id = @pstrContratoId
	

	IF (@pintRegistros = 0)
	BEGIN
		INSERT INTO [SIIFMF01].[dbo].[Contrato_Digito] (
			[Contrato_Id]
			,[Banco_Id]
			,[Cuenta_Id]
			,[Digito]
			)
		VALUES (
			@pstrContratoId
			,646
			,9999
			,@pintDV
			)
	END
END
GO
