
IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'InvoiceLine') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'GTIPNO'))
ALTER TABLE InvoiceLine ADD GTIPNO VARCHAR(50) NULL DEFAULT ''

GO

UPDATE InvoiceLine SET GTIPNO = '' WHERE GTIPNO IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'InvoiceLine') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'TransportModeCode'))
ALTER TABLE InvoiceLine ADD TransportModeCode VARCHAR(10) NULL DEFAULT ''

GO

UPDATE InvoiceLine SET TransportModeCode = '' WHERE TransportModeCode IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'InvoiceLine') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'DeliveryTerms'))
ALTER TABLE InvoiceLine ADD DeliveryTerms VARCHAR(10) NULL DEFAULT ''

GO

UPDATE InvoiceLine SET DeliveryTerms = '' WHERE DeliveryTerms IS NULL

GO



IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvoiceLine_Packages]') AND type in (N'U'))
DROP TABLE [dbo].[InvoiceLine_Packages]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[InvoiceLine_Packages](
	[nID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[InvoiceLineID] [int] NOT NULL DEFAULT 0,
	[ID] [nvarchar](50) NULL DEFAULT '',
	[Quantity] [float] NULL DEFAULT 0,
	[PackagingTypeCode] [nvarchar](50) NULL DEFAULT ''
)

GO

