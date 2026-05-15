
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spSYNC_MukellefleriIsaretle]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spSYNC_MukellefleriIsaretle]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spSYNC_MukellefleriIsaretle] 

AS
BEGIN
	SET NOCOUNT ON;
	
	PRINT '';
	
END

GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spSYNC_EFaturalariCek]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spSYNC_EFaturalariCek]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spSYNC_EFaturalariCek] 

AS
BEGIN
	SET NOCOUNT ON;
	
	PRINT 'ETA';
	
END

GO
