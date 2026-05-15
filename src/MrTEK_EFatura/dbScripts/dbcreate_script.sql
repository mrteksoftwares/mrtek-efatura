/****** Object:  UserDefinedFunction [dbo].[fnOnlyNumber]    Script Date: 02/09/2015 13:44:19 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnOnlyNumber]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fnOnlyNumber]
GO

/****** Object:  UserDefinedFunction [dbo].[fnOnlyNumber]    Script Date: 02/09/2015 13:44:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [dbo].[fnOnlyNumber] ( @strAlphaNumeric nVARCHAR(50) )  
RETURNS nVARCHAR(50)  AS  
 BEGIN
 DECLARE @intAlpha INT
 SET @intAlpha = PATINDEX('%[^0-9]%', @strAlphaNumeric)
 BEGIN
 WHILE @intAlpha > 0
 BEGIN
 SET @strAlphaNumeric = STUFF(@strAlphaNumeric, @intAlpha, 1, '' )
 SET @intAlpha = PATINDEX('%[^0-9]%', @strAlphaNumeric )
 END
 END
 RETURN ISNULL(@strAlphaNumeric,0)
 END


GO


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
	
	PRINT '';
	
END

GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Variants]') AND type in (N'U'))
DROP TABLE [dbo].[Variants]

GO

CREATE TABLE [dbo].[Variants] (
	VariantID INT IDENTITY(1,1) PRIMARY KEY  ,
	VariantName NVARCHAR(100) NULL DEFAULT ''  ,
	VariantValue NVARCHAR(255) NULL DEFAULT ''  
) 
                
GO



IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PrintDesigns]') AND type in (N'U'))
DROP TABLE [dbo].[PrintDesigns]

GO

CREATE TABLE [dbo].[PrintDesigns] (
	ReportID INT IDENTITY(1,1) PRIMARY KEY  ,
	CreatedBy INT NULL DEFAULT 0  , 
	CreatedDate DATETIME NULL DEFAULT 0  ,
	ModifiedBy INT NULL DEFAULT 0  , 
	ModifiedDate DATETIME NULL DEFAULT 0  , 
	FormCode NVARCHAR(30) NULL DEFAULT ''  ,
	ReportName NVARCHAR(100) NULL DEFAULT ''  , 
	ReportData IMAGE NULL  , 
	ReportSQL IMAGE NULL  ,
	bDefault INT NULL DEFAULT 0  , 
	ReportType INT NULL DEFAULT 0 
) 
                
GO



IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnYaziTura]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fnYaziTura]
GO

CREATE FUNCTION [dbo].[fnYaziTura](@num AS numeric(18,2), @isMoney as bit,@ParaBirim NVARCHAR(20),@KucukBirim NVARCHAR(20))
RETURNS NVARCHAR(255)
AS
BEGIN
DECLARE @Split tinyint
DECLARE @iSplit tinyint
DECLARE @sNum NVARCHAR(20)
DECLARE @NumSet NVARCHAR(3)
DECLARE @Char char(1)
DECLARE @NumText NVARCHAR(255)
DECLARE @SetText NVARCHAR(100)
DECLARE @HunText NVARCHAR(100)
DECLARE @CharText NVARCHAR(50)
DECLARE @Match bit
DECLARE @Point tinyint
DECLARE @Cents NVARCHAR(2)
DECLARE @CentText NVARCHAR(100)
DECLARE @NumStrings TABLE (Num int, NumStr NVARCHAR(20))
INSERT INTO @NumStrings
SELECT 1, 'Bir'
UNION SELECT 2, 'İki'
UNION SELECT 3, 'Üç'
UNION SELECT 4, 'Dört'
UNION SELECT 5, 'Beş'
UNION SELECT 6, 'Altı'
UNION SELECT 7, 'Yedi'
UNION SELECT 8, 'Sekiz'
UNION SELECT 9, 'Dokuz'
UNION SELECT 10, 'On'
UNION SELECT 11, 'Onbir'
UNION SELECT 12, 'Oniki'
UNION SELECT 13, 'Onüç'
UNION SELECT 14, 'Ondört'
UNION SELECT 15, 'Onbeş'
UNION SELECT 16, 'Onaltı'
UNION SELECT 17, 'Onyedi'
UNION SELECT 18, 'Onsekiz'
UNION SELECT 19, 'Ondokuz'
UNION SELECT 20, 'Yirmi'
UNION SELECT 30, 'Otuz'
UNION SELECT 40, 'Kırk'
UNION SELECT 50, 'Elli'
UNION SELECT 60, 'Altmış'
UNION SELECT 70, 'Yetmiş'
UNION SELECT 80, 'Seksen'
UNION SELECT 90, 'Doksan'
SET @sNum = cast(@num as NVARCHAR(20))
--convert any cent text first, then the
-- whole number
SET @Point = charindex('.', @sNum)
IF @Point > 0
BEGIN
SET @Cents = substring(@sNum, @Point + 1, 2)
SET @sNum = left(@sNum, @Point-1)
--if isMoney THEN combine the two digits (eg 11 = eleven)
IF @isMoney = 1
BEGIN --look FOR matches WITH the RIGHT İki characters
SET @Match = (select count(*) FROM @NumStrings WHERE Num = @Cents)
IF @Match <> 0
BEGIN
SET @CentText = (select NumStr FROM @NumStrings WHERE Num = @Cents)
END
ELSE
BEGIN
SET @CentText = isnull((select NumStr FROM @NumStrings WHERE Num = left(@Cents, 1) + '0'),'') + (select NumStr from @NumStrings where Num = right(@Cents, 1))
END
END
ELSE --if NOT isMBiry THEN treat each digit seperately (eg 11 = Bir Bir)
BEGIN
SET @CentText = isnull((select NumStr FROM @NumStrings WHERE Num = left(@Cents, 1)),'') + isnull((select NumStr from @NumStrings where Num = right(@Cents, 1)),'')
END
END
IF @CentText IS NULL
SET @CentText = ''
--break the number into blocks of 3 characters
SET @Split = ((len(@sNum)-1) / 3) + 1
SET @iSplit = 0
SET @NumText = ''
WHILE @iSplit < @Split
BEGIN
SET @CharText = ''
SET @HunText = ''
SET @SetText = ''
SET @NumSet = right(left(@sNum, len(@sNum) - @iSplit * 3), 3)
IF len(@Numset) = 3 --Calculate ANY hundreds
BEGIN
SET @Char = left(@NumSet, 1)
if @Char='1' 
SET @HunText = 'Yüz'
ELSE
SET @HunText = isnull((select NumStr FROM @NumStrings WHERE Num = @Char) + 'Yüz', '')
SET @SetText = @HunText
END
--look FOR matches WITH the RIGHT two characters
SET @Match = (select count(*) FROM @NumStrings WHERE Num = right(@NumSet, 2))
IF @Match <> 0
BEGIN
SET @CharText = (select NumStr FROM @NumStrings WHERE Num = right(@NumSet, 2))
END
ELSE
BEGIN
SET @CharText = isnull((select NumStr FROM @NumStrings WHERE Num = left(right(@NumSet, 2), 1) + '0'),'') + (select NumStr from @NumStrings where Num = right(@NumSet, 1))
END
--make sure there IS something in @CharText AND @SetText (ie IF @NumSet = x00, x000)
IF @CharText IS NULL SET @CharText = ''
IF @SetText IS NULL set @SetText = ''
--seperate ANY hundreds FROM Ons/units WITH an 'and'
IF @HunText <> '' AND @CharText <> ''
SET @SetText = @SetText + ''
--if there are no hundreds, it's the smallest SET AND there are other sets, ADD an 'and' before
IF @HunText = '' AND @CharText <> '' and @iSplit = 0 and @Split > 1 and @CentText = ''
SET @SetText = '' + @SetText
SET @SetText = @SetText + @CharText
--append the SET suffix text. ADD a ',' AS long as there IS something in the lowest set
if @iSplit = 1 AND @SetText='Bir' BEGIN 
SET @SetText=''
SET @SetText = @SetText + CASE @iSplit
WHEN 0 THEN ''
WHEN 1 THEN 'Bin'
WHEN 2 THEN 'Milyon'
WHEN 3 THEN 'Milyar'
WHEN 4 THEN 'Trilyon'
WHEN 5 THEN 'Katrilyon'
END + CASE WHEN len(@NumText) > 0 THEN '' ELSE '' end
END
ELSE
BEGIN
IF @SetText <> ''
SET @SetText = @SetText + CASE @iSplit
WHEN 0 THEN ''
WHEN 1 THEN 'Bin'
WHEN 2 THEN 'Milyon'
WHEN 3 THEN 'Milyar'
WHEN 4 THEN 'Trilyon'
WHEN 5 THEN 'Katrilyon'
END + CASE WHEN len(@NumText) > 0 THEN '' ELSE '' end
END
SET @NumText = @SetText + @NumText
SET @iSplit = @iSplit + 1
END
--add any dollars and cent text
IF @isMoney = 1 AND @NumText <> '' and rtrim(ltrim(@NumText)) <> 'Bir'
SET @NumText = @NumText + ' ' + @ParaBirim
IF @isMoney = 1 AND rtrim(ltrim(@NumText)) = 'Bir'
SET @NumText = @NumText + ' ' + @ParaBirim
IF @isMoney = 1 AND @CentText <> '' and rtrim(ltrim(@CentText)) <> 'Bir'
SET @CentText = @CentText + ' ' + @KucukBirim
IF @isMoney = 1 AND rtrim(ltrim(@CentText)) = 'Bir'
SET @CentText = @CentText + ' ' + @KucukBirim
IF @isMoney = 0 AND @CentText <> ''
SET @CentText = ' Point' + @CentText
IF @isMoney = 1 AND @NumText <> '' and @CentText <> ''
SET @CentText = ' ' + @CentText
--combine dollars and cents
SET @NumText = @NumText + @CentText
--add 'Minus' for negative numbers
IF left(@sNum, 1) = '-'
SET @NumText = 'virgül' + @NumText
RETURN @NumText
END


GO




IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EFaturaMembers]') AND type in (N'U'))
DROP TABLE [dbo].[EFaturaMembers]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EFaturaMembers](
	[EFaturaMemberID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[VKN] [nvarchar](50) NULL DEFAULT '',
	[FirmTitle] [nvarchar](255) NULL DEFAULT '',
	[PostboxAlias] [nvarchar](255) NULL DEFAULT '',
	[SenderboxAlias] [nvarchar](255) NULL DEFAULT '',
	[SystemCreateDate] [nvarchar](50) NULL DEFAULT '',
	[FirmCode] [nvarchar](50) NULL DEFAULT '',
	[bDefault] [int] NULL DEFAULT 0 
)

GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Invoice]') AND type in (N'U'))
DROP TABLE [dbo].[Invoice]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Invoice](
	[InvoiceID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Deleted] [int] NULL DEFAULT 0,
	[CreatedBy] [int] NULL DEFAULT 0,
	[CreatedDate] [datetime] NULL DEFAULT 0,
	[ModifiedBy] [int] NULL DEFAULT 0,
	[ModifiedDate] [datetime] NULL DEFAULT 0,
	[IOType] [int] NULL DEFAULT 0,
	[IntCode] [nvarchar](50) NULL DEFAULT '',
	[LocalStatus] [int] NULL DEFAULT 0,
	[IntegratorID] [nvarchar](50) NULL DEFAULT '',
	[Status] [int] NULL DEFAULT 0,
	[StatusDescription] [nvarchar](50) NULL DEFAULT '',
	[PostBox] [nvarchar](100) NULL DEFAULT '',
	[XsltNo] [int] NULL DEFAULT 0,
	[ProfileID] [nvarchar](50) NULL DEFAULT '',
	[ID] [nvarchar](16) NULL DEFAULT '',
	[UUID] [nvarchar](50) NULL DEFAULT '',
	[IssueDate] [datetime] NULL DEFAULT 0,
	[IssueTime] [datetime] NULL DEFAULT 0,
	[InvoiceTypeCode] [nvarchar](15) NULL DEFAULT '',
	[DocumentCurrencyCode] [nvarchar](5) NULL DEFAULT '',
	[TaxCurrencyCode] [nvarchar](5) NULL DEFAULT '',
	[PricingCurrencyCode] [nvarchar](5) NULL DEFAULT '',
	[PaymentCurrencyCode] [nvarchar](5) NULL DEFAULT '',
	[PaymentAlternativeCurrencyCode] [nvarchar](5) NULL DEFAULT '',
	[LineCountNumeric] [int] NULL DEFAULT 0,
	[InvoicePeriod_StartDate] [datetime] NULL DEFAULT 0,
	[InvoicePeriod_EndDate] [datetime] NULL DEFAULT 0,
	[ASP_PartyIdentification1_schemeID] [nvarchar](50) NULL DEFAULT '',
	[ASP_PartyIdentification1_ID] [nvarchar](50) NULL DEFAULT '',
	[ASP_PartyIdentification2_schemeID] [nvarchar](50) NULL DEFAULT '',
	[ASP_PartyIdentification2_ID] [nvarchar](50) NULL DEFAULT '',
	[ASP_PartyIdentification3_schemeID] [nvarchar](50) NULL DEFAULT '',
	[ASP_PartyIdentification3_ID] [nvarchar](50) NULL DEFAULT '',
	[ASP_PartyIdentification4_schemeID] [nvarchar](50) NULL DEFAULT '',
	[ASP_PartyIdentification4_ID] [nvarchar](50) NULL DEFAULT '',
	[ASP_PartyIdentification5_schemeID] [nvarchar](50) NULL DEFAULT '',
	[ASP_PartyIdentification5_ID] [nvarchar](50) NULL DEFAULT '',
	[ASP_PartyName] [nvarchar](255) NULL DEFAULT '',
	[ASP_PostalAddress_StreetName] [nvarchar](255) NULL DEFAULT '',
	[ASP_PostalAddress_Room] [nvarchar](50) NULL DEFAULT '',
	[ASP_PostalAddress_BuildingNumber] [nvarchar](255) NULL DEFAULT '',
	[ASP_PostalAddress_BuildingName] [nvarchar](255) NULL DEFAULT '',
	[ASP_PostalAddress_CitySubdivisionName] [nvarchar](255) NULL DEFAULT '',
	[ASP_PostalAddress_CityName] [nvarchar](50) NULL DEFAULT '',
	[ASP_PostalAddress_Country] [nvarchar](50) NULL DEFAULT '',
	[ASP_PartyTaxSchemeName] [nvarchar](255) NULL DEFAULT '',
	[ASP_PartyTaxSchemeTaxTypeCode] [nvarchar](255) NULL DEFAULT '',
	[ASP_WebsiteURI] [nvarchar](255) NULL DEFAULT '',
	[ASP_Contact_Telephone] [nvarchar](50) NULL DEFAULT '',
	[ASP_Contact_Telefax] [nvarchar](50) NULL DEFAULT '',
	[ASP_Contact_ElectronicMail] [nvarchar](100) NULL,
	[ASP_Person_FirstName] [nvarchar](50) NULL DEFAULT '',
	[ASP_Person_FamilyName] [nvarchar](50) NULL DEFAULT '',
	[ASP_Person_MiddleName] [nvarchar](50) NULL DEFAULT '',
	[ASP_Person_NameSuffix] [nvarchar](50) NULL DEFAULT '',
	[ASP_Person_Title] [nvarchar](50) NULL DEFAULT '',
	[ASP_AgentParty_PartyIdentification1_schemeID] [nvarchar](50) NULL DEFAULT '',
	[ASP_AgentParty_PartyIdentification1_ID] [nvarchar](50) NULL DEFAULT '',
	[ASP_AgentParty_PartyIdentification2_schemeID] [nvarchar](50) NULL DEFAULT '',
	[ASP_AgentParty_PartyIdentification2_ID] [nvarchar](50) NULL DEFAULT '',
	[ASP_AgentParty_PartyIdentification3_schemeID] [nvarchar](50) NULL DEFAULT '',
	[ASP_AgentParty_PartyIdentification3_ID] [nvarchar](50) NULL DEFAULT '',
	[ASP_AgentParty_PartyIdentification4_schemeID] [nvarchar](50) NULL DEFAULT '',
	[ASP_AgentParty_PartyIdentification4_ID] [nvarchar](50) NULL DEFAULT '',
	[ASP_AgentParty_PartyIdentification5_schemeID] [nvarchar](50) NULL DEFAULT '',
	[ASP_AgentParty_PartyIdentification5_ID] [nvarchar](50) NULL DEFAULT '',
	[ASP_AgentParty_PartyName] [nvarchar](255) NULL DEFAULT '',
	[ASP_AgentParty_PostalAddress_StreetName] [nvarchar](255) NULL DEFAULT '',
	[ASP_AgentParty_PostalAddress_Room] [nvarchar](50) NULL DEFAULT '',
	[ASP_AgentParty_PostalAddress_BuildingNumber] [nvarchar](255) NULL DEFAULT '',
	[ASP_AgentParty_PostalAddress_BuildingName] [nvarchar](255) NULL DEFAULT '',
	[ASP_AgentParty_PostalAddress_CitySubdivisionName] [nvarchar](255) NULL DEFAULT '',
	[ASP_AgentParty_PostalAddress_CityName] [nvarchar](50) NULL DEFAULT '',
	[ASP_AgentParty_PostalAddress_Country] [nvarchar](50) NULL DEFAULT '',
	[ASP_AgentParty_PartyTaxSchemeName] [nvarchar](255) NULL DEFAULT '',
	[ASP_AgentParty_PartyTaxSchemeTaxTypeCode] [nvarchar](255) NULL DEFAULT '',
	[ASP_AgentParty_WebsiteURI] [nvarchar](255) NULL DEFAULT '',
	[ASP_AgentParty_Contact_Telephone] [nvarchar](50) NULL DEFAULT '',
	[ASP_AgentParty_Contact_Telefax] [nvarchar](50) NULL DEFAULT '',
	[ASP_AgentParty_Contact_ElectronicMail] [nvarchar](100) NULL,
	[ASP_AgentParty_Person_FirstName] [nvarchar](50) NULL DEFAULT '',
	[ASP_AgentParty_Person_FamilyName] [nvarchar](50) NULL DEFAULT '',
	[ASP_AgentParty_Person_MiddleName] [nvarchar](50) NULL DEFAULT '',
	[ASP_AgentParty_Person_NameSuffix] [nvarchar](50) NULL DEFAULT '',
	[ASP_AgentParty_Person_Title] [nvarchar](50) NULL DEFAULT '',
	[ACP_PartyIdentification1_schemeID] [nvarchar](50) NULL DEFAULT '',
	[ACP_PartyIdentification1_ID] [nvarchar](50) NULL DEFAULT '',
	[ACP_PartyIdentification2_schemeID] [nvarchar](50) NULL DEFAULT '',
	[ACP_PartyIdentification2_ID] [nvarchar](50) NULL DEFAULT '',
	[ACP_PartyIdentification3_schemeID] [nvarchar](50) NULL DEFAULT '',
	[ACP_PartyIdentification3_ID] [nvarchar](50) NULL DEFAULT '',
	[ACP_PartyIdentification4_schemeID] [nvarchar](50) NULL DEFAULT '',
	[ACP_PartyIdentification4_ID] [nvarchar](50) NULL DEFAULT '',
	[ACP_PartyIdentification5_schemeID] [nvarchar](50) NULL DEFAULT '',
	[ACP_PartyIdentification5_ID] [nvarchar](50) NULL DEFAULT '',
	[ACP_PartyName] [nvarchar](255) NULL DEFAULT '',
	[ACP_PostalAddress_StreetName] [nvarchar](255) NULL DEFAULT '',
	[ACP_PostalAddress_Room] [nvarchar](50) NULL DEFAULT '',
	[ACP_PostalAddress_BuildingNumber] [nvarchar](255) NULL DEFAULT '',
	[ACP_PostalAddress_BuildingName] [nvarchar](255) NULL DEFAULT '',
	[ACP_PostalAddress_CitySubdivisionName] [nvarchar](255) NULL DEFAULT '',
	[ACP_PostalAddress_CityName] [nvarchar](50) NULL DEFAULT '',
	[ACP_PostalAddress_Country] [nvarchar](50) NULL DEFAULT '',
	[ACP_PartyTaxSchemeName] [nvarchar](255) NULL DEFAULT '',
	[ACP_PartyTaxSchemeTaxTypeCode] [nvarchar](255) NULL DEFAULT '',
	[ACP_WebsiteURI] [nvarchar](255) NULL DEFAULT '',
	[ACP_Contact_Telephone] [nvarchar](50) NULL DEFAULT '',
	[ACP_Contact_Telefax] [nvarchar](50) NULL DEFAULT '',
	[ACP_Contact_ElectronicMail] [nvarchar](100) NULL,
	[ACP_Person_FirstName] [nvarchar](50) NULL DEFAULT '',
	[ACP_Person_FamilyName] [nvarchar](50) NULL DEFAULT '',
	[ACP_Person_MiddleName] [nvarchar](50) NULL DEFAULT '',
	[ACP_Person_NameSuffix] [nvarchar](50) NULL DEFAULT '',
	[ACP_Person_Title] [nvarchar](50) NULL DEFAULT '',
	[ACP_AgentParty_PartyIdentification1_schemeID] [nvarchar](50) NULL DEFAULT '',
	[ACP_AgentParty_PartyIdentification1_ID] [nvarchar](50) NULL DEFAULT '',
	[ACP_AgentParty_PartyIdentification2_schemeID] [nvarchar](50) NULL DEFAULT '',
	[ACP_AgentParty_PartyIdentification2_ID] [nvarchar](50) NULL DEFAULT '',
	[ACP_AgentParty_PartyIdentification3_schemeID] [nvarchar](50) NULL DEFAULT '',
	[ACP_AgentParty_PartyIdentification3_ID] [nvarchar](50) NULL DEFAULT '',
	[ACP_AgentParty_PartyIdentification4_schemeID] [nvarchar](50) NULL DEFAULT '',
	[ACP_AgentParty_PartyIdentification4_ID] [nvarchar](50) NULL DEFAULT '',
	[ACP_AgentParty_PartyIdentification5_schemeID] [nvarchar](50) NULL DEFAULT '',
	[ACP_AgentParty_PartyIdentification5_ID] [nvarchar](50) NULL DEFAULT '',
	[ACP_AgentParty_PartyName] [nvarchar](255) NULL DEFAULT '',
	[ACP_AgentParty_PostalAddress_StreetName] [nvarchar](255) NULL DEFAULT '',
	[ACP_AgentParty_PostalAddress_Room] [nvarchar](50) NULL DEFAULT '',
	[ACP_AgentParty_PostalAddress_BuildingNumber] [nvarchar](255) NULL DEFAULT '',
	[ACP_AgentParty_PostalAddress_BuildingName] [nvarchar](255) NULL DEFAULT '',
	[ACP_AgentParty_PostalAddress_CitySubdivisionName] [nvarchar](255) NULL DEFAULT '',
	[ACP_AgentParty_PostalAddress_CityName] [nvarchar](50) NULL DEFAULT '',
	[ACP_AgentParty_PostalAddress_Country] [nvarchar](50) NULL DEFAULT '',
	[ACP_AgentParty_PartyTaxSchemeName] [nvarchar](255) NULL DEFAULT '',
	[ACP_AgentParty_PartyTaxSchemeTaxTypeCode] [nvarchar](255) NULL DEFAULT '',
	[ACP_AgentParty_WebsiteURI] [nvarchar](255) NULL DEFAULT '',
	[ACP_AgentParty_Contact_Telephone] [nvarchar](50) NULL DEFAULT '',
	[ACP_AgentParty_Contact_Telefax] [nvarchar](50) NULL DEFAULT '',
	[ACP_AgentParty_Contact_ElectronicMail] [nvarchar](100) NULL,
	[ACP_AgentParty_Person_FirstName] [nvarchar](50) NULL DEFAULT '',
	[ACP_AgentParty_Person_FamilyName] [nvarchar](50) NULL DEFAULT '',
	[ACP_AgentParty_Person_MiddleName] [nvarchar](50) NULL DEFAULT '',
	[ACP_AgentParty_Person_NameSuffix] [nvarchar](50) NULL DEFAULT '',
	[ACP_AgentParty_Person_Title] [nvarchar](50) NULL DEFAULT '',
	[TaxExchangeRate_SourceCurrencyCode] [nvarchar](5) NULL DEFAULT '',
	[TaxExchangeRate_TargetCurrencyCode] [nvarchar](5) NULL DEFAULT '',
	[TaxExchangeRate_CalculationRate] [float] NULL DEFAULT 0,
	[TaxExchangeRate_Date] [datetime] NULL DEFAULT 0,
	[PricingExchangeRate_SourceCurrencyCode] [nvarchar](5) NULL DEFAULT '',
	[PricingExchangeRate_TargetCurrencyCode] [nvarchar](5) NULL DEFAULT '',
	[PricingExchangeRate_CalculationRate] [float] NULL DEFAULT 0,
	[PricingExchangeRate_Date] [datetime] NULL DEFAULT 0,
	[PaymentExchangeRate_SourceCurrencyCode] [nvarchar](5) NULL DEFAULT '',
	[PaymentExchangeRate_TargetCurrencyCode] [nvarchar](5) NULL DEFAULT '',
	[PaymentExchangeRate_CalculationRate] [float] NULL DEFAULT 0,
	[PaymentExchangeRate_Date] [datetime] NULL DEFAULT 0,
	[PaymentAlternativeExchangeRate_SourceCurrencyCode] [nvarchar](5) NULL DEFAULT '',
	[PaymentAlternativeExchangeRate_TargetCurrencyCode] [nvarchar](5) NULL DEFAULT '',
	[PaymentAlternativeExchangeRate_CalculationRate] [float] NULL DEFAULT 0,
	[PaymentAlternativeExchangeRate_Date] [datetime] NULL DEFAULT 0,
	[TaxAmount] [float] NULL DEFAULT 0,
	[LegalMonetaryTotal_LineExtensionAmount] [float] NULL DEFAULT 0,
	[LegalMonetaryTotal_TaxExclusiveAmount] [float] NULL DEFAULT 0,
	[LegalMonetaryTotal_TaxInclusiveAmount] [float] NULL DEFAULT 0,
	[LegalMonetaryTotal_AllowanceTotalAmount] [float] NULL DEFAULT 0,
	[LegalMonetaryTotal_ChargeTotalAmount] [float] NULL DEFAULT 0,
	[LegalMonetaryTotal_PayableRoundingAmount] [float] NULL DEFAULT 0,
	[LegalMonetaryTotal_PayableAmount] [float] NULL DEFAULT 0
)

GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Invoice_AdditionalDocumentReference]') AND type in (N'U'))
DROP TABLE [dbo].[Invoice_AdditionalDocumentReference]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Invoice_AdditionalDocumentReference](
	[nID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[InvoiceID] [int] NULL DEFAULT 0,
	[ID] [nvarchar](50) NULL DEFAULT '',
	[IssueDate] [datetime] NULL DEFAULT 0,
	[DocumentTypeCode] [nvarchar](50) NULL DEFAULT '',
	[DocumentType] [nvarchar](50) NULL DEFAULT '',
	[Attachment] [image] NULL
)

GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Invoice_AllowanceCharge]') AND type in (N'U'))
DROP TABLE [dbo].[Invoice_AllowanceCharge]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Invoice_AllowanceCharge](
	[nID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[InvoiceID] [int] NOT NULL DEFAULT 0,
	[ChargeIndicator] [bit] NULL,
	[AllowanceChargeReason] [nvarchar](255) NULL DEFAULT '',
	[MultiplierFactorNumeric] [float] NULL DEFAULT 0,
	[Amount] [float] NULL DEFAULT 0,
	[Amount_currencyID] [nvarchar](5) NULL DEFAULT '',
	[BaseAmount] [float] NULL DEFAULT 0,
	[BaseAmount_currencyID] [nvarchar](5) NULL  DEFAULT ''
)

GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Invoice_DespatchDocumentReference]') AND type in (N'U'))
DROP TABLE [dbo].[Invoice_DespatchDocumentReference]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Invoice_DespatchDocumentReference](
	[nID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[InvoiceID] [int] NOT NULL DEFAULT 0,
	[ID] [nvarchar](50) NULL DEFAULT '',
	[IssueDate] [datetime] NULL  DEFAULT 0
)

GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Invoice_Note]') AND type in (N'U'))
DROP TABLE [dbo].[Invoice_Note]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Invoice_Note](
	[nID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[InvoiceID] [int] NOT NULL DEFAULT 0,
	[Note] [nvarchar](255) NULL DEFAULT ''
)

GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Invoice_OrderReference]') AND type in (N'U'))
DROP TABLE [dbo].[Invoice_OrderReference]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Invoice_OrderReference](
	[nID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[InvoiceID] [int] NOT NULL DEFAULT 0,
	[ID] [nvarchar](50) NULL DEFAULT '',
	[IssueDate] [datetime] NULL DEFAULT 0
)

GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Invoice_PaymentMeans]') AND type in (N'U'))
DROP TABLE [dbo].[Invoice_PaymentMeans]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Invoice_PaymentMeans](
	[nID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[InvoiceID] [int] NOT NULL DEFAULT 0,
	[PaymentMeansCode] [nvarchar](50) NULL DEFAULT '',
	[PaymentDueDate] [datetime] NULL DEFAULT 0,
	[PaymentChannelCode] [nvarchar](50) NULL DEFAULT '',
	[InstructionNote] [nvarchar](255) NULL DEFAULT '',
	[PayeeFinancialAccount_ID] [nvarchar](50) NULL DEFAULT '',
	[PayeeFinancialAccount_CurrencyCode] [nvarchar](5) NULL DEFAULT '',
	[PayeeFinancialAccount_PaymentNote] [nvarchar](255) NULL  DEFAULT ''
)

GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Invoice_PaymentTerms]') AND type in (N'U'))
DROP TABLE [dbo].[Invoice_PaymentTerms]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Invoice_PaymentTerms](
	[nID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[InvoiceID] [int] NOT NULL DEFAULT 0,
	[Note] [nvarchar](500) NULL,
	[PenaltySurchargePercent] [float] NULL DEFAULT 0,
	[Amount] [float] NULL DEFAULT 0,
	[Amount_currencyID] [nvarchar](5) NULL  DEFAULT ''
)

GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Invoice_ReceiptDocumentReference]') AND type in (N'U'))
DROP TABLE [dbo].[Invoice_ReceiptDocumentReference]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Invoice_ReceiptDocumentReference](
	[nID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[InvoiceID] [int] NOT NULL DEFAULT 0,
	[ID] [nvarchar](50) NULL DEFAULT '',
	[IssueDate] [datetime] NULL  DEFAULT 0
)

GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Invoice_TaxSubtotal]') AND type in (N'U'))
DROP TABLE [dbo].[Invoice_TaxSubtotal]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Invoice_TaxSubtotal](
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
	[TaxCategory_TaxExemptionReason] [nvarchar](255) NULL  DEFAULT ''
)

GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvoiceLine]') AND type in (N'U'))
DROP TABLE [dbo].[InvoiceLine]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[InvoiceLine](
	[InvoiceLineID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[InvoiceID] [int] NOT NULL DEFAULT 0,
	[ID] [nvarchar](50) NULL DEFAULT '',
	[Note] [nvarchar](255) NULL DEFAULT '',
	[InvoicedQuantity] [float] NULL DEFAULT 0,
	[InvoicedQuantity_unitCode] [nvarchar](5) NULL DEFAULT '',
	[LineExtensionAmount] [float] NULL DEFAULT 0,
	[currencyID] [nvarchar](5) NULL DEFAULT '',
	[AllowanceCharge_ChargeIndicator] [bit] NULL,
	[AllowanceCharge_AllowanceChargeReason] [nvarchar](255) NULL DEFAULT '',
	[AllowanceCharge_Amount] [float] NULL DEFAULT 0,
	[AllowanceCharge_BaseAmount] [float] NULL DEFAULT 0,
	[AllowanceCharge_MultiplierFactorNumeric] [float] NULL DEFAULT 0,
	[Item_Name] [nvarchar](255) NULL DEFAULT '',
	[Item_Description] [nvarchar](255) NULL DEFAULT '',
	[Item_BrandName] [nvarchar](255) NULL DEFAULT '',
	[Item_ModelName] [nvarchar](255) NULL DEFAULT '',
	[Item_ItemClassificationCode] [nvarchar](255) NULL DEFAULT '',
	[Item_BuyersItemIdentification_ID] [nvarchar](255) NULL DEFAULT '',
	[Item_SellersItemIdentification_ID] [nvarchar](255) NULL DEFAULT '',
	[Item_ManufacturersItemIdentification_ID] [nvarchar](255) NULL DEFAULT '',
	[PriceAmount] [float] NULL DEFAULT 0,
	[TaxAmount] [float] NULL  DEFAULT 0
)

GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InvoiceLine_TaxSubtotal]') AND type in (N'U'))
DROP TABLE [dbo].[InvoiceLine_TaxSubtotal]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[InvoiceLine_TaxSubtotal](
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
	[TaxCategory_TaxExemptionReason] [nvarchar](255) NULL  DEFAULT ''
)

GO
