USE [SIIFMF04]
GO

/****** Object:  StoredProcedure [dbo].[sp_C_ObtienePagos]    Script Date: 01/12/2017 04:49:49 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Bernardo Ricardo Ostos Córdova
-- Create date: 29/11/2017
-- Description:	Obtiene los pagos a realizarse para crear layout de STP
-- =============================================
CREATE PROCEDURE [dbo].[sp_C_ObtienePagos] 
	-- Add the parameters for the stored procedure here
	@fechaInicio nvarchar(10) = '', 
	@fechaSegunda nvarchar(10) = ''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF @fechaInicio IS NULL
	BEGIN
		SET @fechaInicio = CONVERT(nvarchar(10), GETDATE(), 101) 
		SET @fechaSegunda = CONVERT(nvarchar(10), GETDATE(), 101) 
	END
	

SELECT DISTINCT SPEI.dbo.fn_ObtenerClaveBanco(Orden_Tesoreria.Banco_Id)
	AS Institucion_Contraparte
	,CONCAT(Orden.Orden_Id , Orden.Contrato_Id) AS Clave_Rastreo
	,Contrato_Dsc AS Nombre_Beneficiario
	,Contrato.Contrato_RFC AS RFC_CURP_Beneficiario
	,'1' AS Tipo_Pago
	,'40' AS Tipo_Cuenta_Beneficiario

	,CASE 
		WHEN Orden.Tipo_Operacion_Id = 500
			THEN (Orden.Orden_Importe + Orden_TitImp.Orden_TitImp_Liquida_Efectivo)
		ELSE ((Orden.Orden_Importe + Orden_TitImp.Orden_TitImp_Liquida_Efectivo - ISNULL(Orden_Retiro_Anticipado.Orden_Retiro_Anticipado_Importe_Comision, 0) - Orden.Orden_ISR) * 1)
		END AS Monto

	,ISNULL(Contrato_Cta.Contrato_Cta_CLABE, 'SIN/CLABE') AS Cuenta_Beneficiario
	,'Pago contrato Más Fondos' AS Concepto_Pago
	,Orden.Contrato_Id AS Referencia_Numerica
	,Contrato.Contrato_Email AS Email_Beneficiario
	,'9046' AS Institucion_Operante
	,'MASFONDOS' AS Empresa

FROM Orden WITH (NOLOCK)

INNER JOIN Orden_Tesoreria WITH (NOLOCK)
INNER JOIN Tipo_Liquidacion WITH (NOLOCK) ON (Orden_Tesoreria.Tipo_Liquidacion_Id = Tipo_Liquidacion.Tipo_Liquidacion_Id)
INNER JOIN Tipo_Instr_Liquidacion WITH (NOLOCK) ON (
		Orden_Tesoreria.Tipo_Liquidacion_Id = Tipo_Instr_Liquidacion.Tipo_Liquidacion_Id
		AND Orden_Tesoreria.Tipo_Operacion_Id = Tipo_Instr_Liquidacion.Tipo_Operacion_Id
		AND Orden_Tesoreria.Tipo_Instr_Liquidacion_Id = Tipo_Instr_Liquidacion.Tipo_Instr_Liquidacion_Id
		) ON (
		Orden.Tipo_Mercado_Id = Orden_Tesoreria.Tipo_Mercado_Id
		AND Orden.Orden_Id = Orden_Tesoreria.Orden_Id
		) INNER JOIN Tipo_Orden WITH (NOLOCK) ON (
		Orden.Tipo_Mercado_Id = Tipo_Orden.Tipo_Mercado_Id
		AND Orden.Tipo_Orden_Id = Tipo_Orden.Tipo_Orden_Id
		) INNER JOIN Clasif_Orden WITH (NOLOCK) ON (Orden.Clasif_Orden_Id = Clasif_Orden.Clasif_Orden_Id) INNER JOIN Orden Orden_A WITH (NOLOCK)
INNER JOIN Orden_TitImp WITH (NOLOCK) ON (
		Orden_A.Tipo_Mercado_Id = Orden_TitImp.Tipo_Mercado_Id
		AND Orden_A.Orden_Id = Orden_TitImp.Orden_Id
		)
INNER JOIN Fondo WITH (NOLOCK) ON (Orden_A.Emision_Id = Fondo.Emision_Id)
INNER JOIN Tipo_Operacion WITH (NOLOCK) ON (Orden_A.Tipo_Operacion_Id = Tipo_Operacion.Tipo_Operacion_Id) ON (
		Orden_A.Tipo_Mercado_Id = 15
		AND Orden.Orden_Id = Orden_A.Orden_Id_Tesoreria
		) INNER JOIN Contrato WITH (NOLOCK)
INNER JOIN Sucursal WITH (NOLOCK)
INNER JOIN Zona WITH (NOLOCK) ON (Sucursal.Zona_Id = Zona.Zona_Id) ON (Contrato.Sucursal_Id = Sucursal.Sucursal_Id) INNER JOIN Promotor WITH (NOLOCK)
INNER JOIN Area WITH (NOLOCK) ON (Promotor.Area_Id = Area.Area_Id) ON (Contrato.Promotor_Id = Promotor.Promotor_Id) ON (Orden.Contrato_Id = Contrato.Contrato_Id) 
LEFT JOIN Orden_Retiro_Anticipado WITH (NOLOCK) ON (
		Orden.Tipo_Mercado_Id = Orden_Retiro_Anticipado.Tipo_Mercado_Id
		AND Orden.Orden_Id = Orden_Retiro_Anticipado.Orden_Id
		) 
LEFT JOIN Contrato_Cta WITH (NOLOCK) ON (
		Orden_Tesoreria.Contrato_Id = Contrato_Cta.Contrato_Id
		AND Orden_Tesoreria.Banco_Id_Cliente = Contrato_Cta.Banco_Id
		AND Orden_Tesoreria.Cuenta_Id_Cliente = Contrato_Cta.Contrato_Cta_Numero
		AND Contrato_Cta.Sts_Contrato_Cta_Id = 10
		AND LEN(RTRIM(Contrato_Cta.Contrato_Cta_CLABE)) = CASE 
			WHEN EXISTS (
					SELECT *
					FROM Contrato_Cta
					WHERE Orden_Tesoreria.Contrato_Id = Contrato_Cta.Contrato_Id
						AND Orden_Tesoreria.Banco_Id_Cliente = Contrato_Cta.Banco_Id
						AND Orden_Tesoreria.Cuenta_Id_Cliente = Contrato_Cta.Contrato_Cta_Numero
						AND Contrato_Cta.Sts_Contrato_Cta_Id = 10
						AND LEN(RTRIM(Contrato_Cta.Contrato_Cta_CLABE)) = 18
					)
				THEN 18
			ELSE 0
			END
		) 
WHERE Orden.Tipo_Mercado_Id = 20 AND Orden.Sts_Orden_Id NOT IN (20, 25, 10) AND Orden.Emision_Id = 'EFECTIVO'
	AND (
		(
			--DATEDIFF(day, Orden_A.Orden_Fecha_Operacion, '11/24/2017') = 0
			DATEDIFF(day, Orden_A.Orden_Fecha_Operacion, CONVERT(nvarchar(10), @fechaInicio, 101)) = 0
			AND Orden_A.Tipo_Operacion_Id = 5
			AND Orden_A.Sts_Orden_Id IN (3, 5)
			AND Fondo.Fondo_Requiere_Liquidacion_Anticipada = 1
			)
		OR (
			DATEDIFF(day, Orden_A.Orden_Fecha_Liquidacion, CONVERT(nvarchar(10), @fechaSegunda, 101)) = 0
			AND Orden_A.Tipo_Operacion_Id IN (5, 10)
			)
		)
	AND Orden.Divisa_Id = 5 AND Orden.Tipo_Operacion_Id IN (510, 500) AND Orden_A.Tipo_Operacion_Id = 10
	AND (
		LEN(RTRIM(Contrato_Cta.Contrato_Cta_CLABE)) = 18
		OR LEN(RTRIM(Contrato_Cta.Contrato_Cta_CLABE)) = 0
		OR Contrato_Cta.Contrato_Cta_CLABE IS NULL
		) 
ORDER BY Contrato_Dsc


END

GO



