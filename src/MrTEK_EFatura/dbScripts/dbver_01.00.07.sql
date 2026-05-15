


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Invoice_BillingReference]') AND type in (N'U'))
DROP TABLE [dbo].[Invoice_BillingReference]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Invoice_BillingReference](
	[nID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[InvoiceID] [int] NOT NULL DEFAULT 0,
	[ID] [nvarchar](50) NULL DEFAULT '',
	[IssueDate] [datetime] NULL DEFAULT 0,
	[DocumentTypeCode] [nvarchar](50) NULL DEFAULT '',
	[DocumentType] [nvarchar](50) NULL DEFAULT ''
)

GO