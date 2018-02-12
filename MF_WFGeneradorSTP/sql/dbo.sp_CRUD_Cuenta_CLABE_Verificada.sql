dbo.sp_CRUD_Cuenta_CLABE_Verificada.sql


USE SPEI
GO
IF EXISTS (SELECT * FROM sysobjects WHERE name = 'sp_Se_LeerCuenta_CLABE_Verificada' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].sp_Se_LeerCuenta_CLABE_Verificada
GO

CREATE PROCEDURE [dbo].sp_Se_LeerCuenta_CLABE_Verificada
AS
	SET NOCOUNT ON;
SELECT [Id]
      ,[Cuenta_CLABE_Verificada_contrato_Id]
      ,[Cuenta_CLABE_Verificada_CLABE]
      ,[Cuenta_CLABE_Verificada_fechaRegistro]
      ,[Cuenta_CLABE_Verificada_fechaVerificacion]
      ,[Cuenta_CLABE_Verificada_Verificada]
      ,[Cuenta_CLABE_Verificada_IdVerificacion]
      ,[Cuenta_CLABE_Verificada_ErrorVerificacion]
  FROM [dbo].[Cuenta_CLABE_Verificada]
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'sp_In_AgregarCuenta_CLABE_Verificada' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].sp_In_AgregarCuenta_CLABE_Verificada
GO

CREATE PROCEDURE [dbo].sp_In_AgregarCuenta_CLABE_Verificada
(
	@Cuenta_CLABE_Verificada_contrato_Id varchar(10),
	@Cuenta_CLABE_Verificada_CLABE nchar(18),
	@Cuenta_CLABE_Verificada_fechaRegistro datetime,
	@Cuenta_CLABE_Verificada_fechaVerificacion datetime,
	@Cuenta_CLABE_Verificada_Verificada bit,
	@Cuenta_CLABE_Verificada_IdVerificacion nchar(12),
	@Cuenta_CLABE_Verificada_ErrorVerificacion nchar(256)
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[Cuenta_CLABE_Verificada] ([Cuenta_CLABE_Verificada_contrato_Id], [Cuenta_CLABE_Verificada_CLABE], [Cuenta_CLABE_Verificada_fechaRegistro], [Cuenta_CLABE_Verificada_fechaVerificacion], [Cuenta_CLABE_Verificada_Verificada], [Cuenta_CLABE_Verificada_IdVerificacion], [Cuenta_CLABE_Verificada_ErrorVerificacion]) VALUES (@Cuenta_CLABE_Verificada_contrato_Id, @Cuenta_CLABE_Verificada_CLABE, @Cuenta_CLABE_Verificada_fechaRegistro, @Cuenta_CLABE_Verificada_fechaVerificacion, @Cuenta_CLABE_Verificada_Verificada, @Cuenta_CLABE_Verificada_IdVerificacion, @Cuenta_CLABE_Verificada_ErrorVerificacion);
	
SELECT Id, Cuenta_CLABE_Verificada_contrato_Id, Cuenta_CLABE_Verificada_CLABE, Cuenta_CLABE_Verificada_fechaRegistro, Cuenta_CLABE_Verificada_fechaVerificacion, Cuenta_CLABE_Verificada_Verificada, Cuenta_CLABE_Verificada_IdVerificacion, Cuenta_CLABE_Verificada_ErrorVerificacion FROM Cuenta_CLABE_Verificada WHERE (Id = SCOPE_IDENTITY())
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'sp_Up_ActualizarCuenta_CLABE_Verificada' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].sp_Up_ActualizarCuenta_CLABE_Verificada
GO

CREATE PROCEDURE [dbo].sp_Up_ActualizarCuenta_CLABE_Verificada
(
	@Cuenta_CLABE_Verificada_contrato_Id varchar(10),
	@Cuenta_CLABE_Verificada_CLABE nchar(18),
	@Cuenta_CLABE_Verificada_fechaRegistro datetime,
	@Cuenta_CLABE_Verificada_fechaVerificacion datetime,
	@Cuenta_CLABE_Verificada_Verificada bit,
	@Cuenta_CLABE_Verificada_IdVerificacion nchar(12),
	@Cuenta_CLABE_Verificada_ErrorVerificacion nchar(256),
	@Original_Id int,
	@Original_Cuenta_CLABE_Verificada_contrato_Id varchar(10),
	@Original_Cuenta_CLABE_Verificada_CLABE nchar(18),
	@Original_Cuenta_CLABE_Verificada_fechaRegistro datetime,
	@IsNull_Cuenta_CLABE_Verificada_fechaVerificacion Int,
	@Original_Cuenta_CLABE_Verificada_fechaVerificacion datetime,
	@IsNull_Cuenta_CLABE_Verificada_Verificada Int,
	@Original_Cuenta_CLABE_Verificada_Verificada bit,
	@IsNull_Cuenta_CLABE_Verificada_IdVerificacion Int,
	@Original_Cuenta_CLABE_Verificada_IdVerificacion nchar(12),
	@IsNull_Cuenta_CLABE_Verificada_ErrorVerificacion Int,
	@Original_Cuenta_CLABE_Verificada_ErrorVerificacion nchar(256),
	@Id int
)
AS
	SET NOCOUNT OFF;
UPDATE [dbo].[Cuenta_CLABE_Verificada] SET [Cuenta_CLABE_Verificada_contrato_Id] = @Cuenta_CLABE_Verificada_contrato_Id, [Cuenta_CLABE_Verificada_CLABE] = @Cuenta_CLABE_Verificada_CLABE, [Cuenta_CLABE_Verificada_fechaRegistro] = @Cuenta_CLABE_Verificada_fechaRegistro, [Cuenta_CLABE_Verificada_fechaVerificacion] = @Cuenta_CLABE_Verificada_fechaVerificacion, [Cuenta_CLABE_Verificada_Verificada] = @Cuenta_CLABE_Verificada_Verificada, [Cuenta_CLABE_Verificada_IdVerificacion] = @Cuenta_CLABE_Verificada_IdVerificacion, [Cuenta_CLABE_Verificada_ErrorVerificacion] = @Cuenta_CLABE_Verificada_ErrorVerificacion WHERE (([Id] = @Original_Id) AND ([Cuenta_CLABE_Verificada_contrato_Id] = @Original_Cuenta_CLABE_Verificada_contrato_Id) AND ([Cuenta_CLABE_Verificada_CLABE] = @Original_Cuenta_CLABE_Verificada_CLABE) AND ([Cuenta_CLABE_Verificada_fechaRegistro] = @Original_Cuenta_CLABE_Verificada_fechaRegistro) AND ((@IsNull_Cuenta_CLABE_Verificada_fechaVerificacion = 1 AND [Cuenta_CLABE_Verificada_fechaVerificacion] IS NULL) OR ([Cuenta_CLABE_Verificada_fechaVerificacion] = @Original_Cuenta_CLABE_Verificada_fechaVerificacion)) AND ((@IsNull_Cuenta_CLABE_Verificada_Verificada = 1 AND [Cuenta_CLABE_Verificada_Verificada] IS NULL) OR ([Cuenta_CLABE_Verificada_Verificada] = @Original_Cuenta_CLABE_Verificada_Verificada)) AND ((@IsNull_Cuenta_CLABE_Verificada_IdVerificacion = 1 AND [Cuenta_CLABE_Verificada_IdVerificacion] IS NULL) OR ([Cuenta_CLABE_Verificada_IdVerificacion] = @Original_Cuenta_CLABE_Verificada_IdVerificacion)) AND ((@IsNull_Cuenta_CLABE_Verificada_ErrorVerificacion = 1 AND [Cuenta_CLABE_Verificada_ErrorVerificacion] IS NULL) OR ([Cuenta_CLABE_Verificada_ErrorVerificacion] = @Original_Cuenta_CLABE_Verificada_ErrorVerificacion)));
	
SELECT Id, Cuenta_CLABE_Verificada_contrato_Id, Cuenta_CLABE_Verificada_CLABE, Cuenta_CLABE_Verificada_fechaRegistro, Cuenta_CLABE_Verificada_fechaVerificacion, Cuenta_CLABE_Verificada_Verificada, Cuenta_CLABE_Verificada_IdVerificacion, Cuenta_CLABE_Verificada_ErrorVerificacion FROM Cuenta_CLABE_Verificada WHERE (Id = @Id)
GO

IF EXISTS (SELECT * FROM sysobjects WHERE name = 'sp_De_BorrarCuenta_CLABE_Verificada' AND user_name(uid) = 'dbo')
	DROP PROCEDURE [dbo].sp_De_BorrarCuenta_CLABE_Verificada
GO

CREATE PROCEDURE [dbo].sp_De_BorrarCuenta_CLABE_Verificada
(
	@Original_Id int,
	@Original_Cuenta_CLABE_Verificada_contrato_Id varchar(10),
	@Original_Cuenta_CLABE_Verificada_CLABE nchar(18),
	@Original_Cuenta_CLABE_Verificada_fechaRegistro datetime,
	@IsNull_Cuenta_CLABE_Verificada_fechaVerificacion Int,
	@Original_Cuenta_CLABE_Verificada_fechaVerificacion datetime,
	@IsNull_Cuenta_CLABE_Verificada_Verificada Int,
	@Original_Cuenta_CLABE_Verificada_Verificada bit,
	@IsNull_Cuenta_CLABE_Verificada_IdVerificacion Int,
	@Original_Cuenta_CLABE_Verificada_IdVerificacion nchar(12),
	@IsNull_Cuenta_CLABE_Verificada_ErrorVerificacion Int,
	@Original_Cuenta_CLABE_Verificada_ErrorVerificacion nchar(256)
)
AS
	SET NOCOUNT OFF;
DELETE FROM [dbo].[Cuenta_CLABE_Verificada] WHERE (([Id] = @Original_Id) AND ([Cuenta_CLABE_Verificada_contrato_Id] = @Original_Cuenta_CLABE_Verificada_contrato_Id) AND ([Cuenta_CLABE_Verificada_CLABE] = @Original_Cuenta_CLABE_Verificada_CLABE) AND ([Cuenta_CLABE_Verificada_fechaRegistro] = @Original_Cuenta_CLABE_Verificada_fechaRegistro) AND ((@IsNull_Cuenta_CLABE_Verificada_fechaVerificacion = 1 AND [Cuenta_CLABE_Verificada_fechaVerificacion] IS NULL) OR ([Cuenta_CLABE_Verificada_fechaVerificacion] = @Original_Cuenta_CLABE_Verificada_fechaVerificacion)) AND ((@IsNull_Cuenta_CLABE_Verificada_Verificada = 1 AND [Cuenta_CLABE_Verificada_Verificada] IS NULL) OR ([Cuenta_CLABE_Verificada_Verificada] = @Original_Cuenta_CLABE_Verificada_Verificada)) AND ((@IsNull_Cuenta_CLABE_Verificada_IdVerificacion = 1 AND [Cuenta_CLABE_Verificada_IdVerificacion] IS NULL) OR ([Cuenta_CLABE_Verificada_IdVerificacion] = @Original_Cuenta_CLABE_Verificada_IdVerificacion)) AND ((@IsNull_Cuenta_CLABE_Verificada_ErrorVerificacion = 1 AND [Cuenta_CLABE_Verificada_ErrorVerificacion] IS NULL) OR ([Cuenta_CLABE_Verificada_ErrorVerificacion] = @Original_Cuenta_CLABE_Verificada_ErrorVerificacion)))
GO

