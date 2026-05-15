

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Invoice_WithholdingTaxSubtotal]') AND type in (N'U'))
DROP TABLE [dbo].[Invoice_WithholdingTaxSubtotal]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Invoice_WithholdingTaxSubtotal](
	[nID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[InvoiceID] [int] NOT NULL DEFAULT 0,
	[TaxableAmount] [float] NULL DEFAULT 0,
	[currencyID] [nvarchar](5) NULL DEFAULT '',
	[TaxAmount] [float] NULL DEFAULT 0,
	[PerUnitAmount] [float] NULL DEFAULT 0,
	[CalculationSequenceNumeric] [int] NULL DEFAULT 0,
	[Percent_] [float] NULL DEFAULT 0,
	[TaxCategory_TaxScheme_Name] [nvarchar](255) NULL DEFAULT '',
	[TaxCategory_TaxScheme_TaxTypeCode] [nvarchar](15) NULL DEFAULT '',
	[TaxCategory_TaxExemptionReason] [nvarchar](255) NULL  DEFAULT '',
	[TaxCategory_TaxExemptionReasonCode] [nvarchar](50) NULL  DEFAULT ''
)

GO



IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvoiceLine_WithholdingTaxSubtotal]') AND type in (N'U'))
DROP TABLE [dbo].[InvoiceLine_WithholdingTaxSubtotal]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[InvoiceLine_WithholdingTaxSubtotal](
	[nID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[InvoiceLineID] [int] NOT NULL DEFAULT 0,
	[TaxableAmount] [float] NULL DEFAULT 0,
	[currencyID] [nvarchar](5) NULL DEFAULT '',
	[TaxAmount] [float] NULL DEFAULT 0,
	[PerUnitAmount] [float] NULL DEFAULT 0,
	[CalculationSequenceNumeric] [int] NULL DEFAULT 0,
	[Percent_] [float] NULL DEFAULT 0,
	[TaxCategory_TaxScheme_Name] [nvarchar](255) NULL DEFAULT '',
	[TaxCategory_TaxScheme_TaxTypeCode] [nvarchar](15) NULL DEFAULT '',
	[TaxCategory_TaxExemptionReason] [nvarchar](255) NULL  DEFAULT '',
	[TaxCategory_TaxExemptionReasonCode] [nvarchar](50) NULL  DEFAULT ''
)

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Invoice') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'WithholdingTaxAmount'))
ALTER TABLE Invoice ADD WithholdingTaxAmount FLOAT NULL DEFAULT 0

GO

UPDATE Invoice SET WithholdingTaxAmount = 0 WHERE WithholdingTaxAmount IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'InvoiceLine') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'WithholdingTaxAmount'))
ALTER TABLE InvoiceLine ADD WithholdingTaxAmount FLOAT NULL DEFAULT 0

GO

UPDATE InvoiceLine SET WithholdingTaxAmount = 0 WHERE WithholdingTaxAmount IS NULL

GO

