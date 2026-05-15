
IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Invoice_TaxSubtotal') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'TaxCategory_TaxExemptionReasonCode'))
ALTER TABLE Invoice_TaxSubtotal ADD TaxCategory_TaxExemptionReasonCode NVARCHAR(50) NULL DEFAULT ''

GO

UPDATE Invoice_TaxSubtotal SET TaxCategory_TaxExemptionReasonCode = '' WHERE TaxCategory_TaxExemptionReasonCode IS NULL

GO




IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'InvoiceLine_TaxSubtotal') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'TaxCategory_TaxExemptionReasonCode'))
ALTER TABLE InvoiceLine_TaxSubtotal ADD TaxCategory_TaxExemptionReasonCode NVARCHAR(50) NULL DEFAULT ''

GO

UPDATE InvoiceLine_TaxSubtotal SET TaxCategory_TaxExemptionReasonCode = '' WHERE TaxCategory_TaxExemptionReasonCode IS NULL

GO

