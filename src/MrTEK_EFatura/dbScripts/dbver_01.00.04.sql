

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Invoice_Log]') AND type in (N'U'))
DROP TABLE [dbo].[Invoice_Log]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Invoice_Log](
	[LogID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[InvoiceID] [int] NOT NULL DEFAULT 0,
	[Message] [nvarchar](3000) NULL DEFAULT ''
)

GO



IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Invoice') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Message'))
ALTER TABLE Invoice ADD Message nVARCHAR(255) NULL DEFAULT ''

GO

UPDATE Invoice SET Message = '' WHERE Message IS NULL

GO
