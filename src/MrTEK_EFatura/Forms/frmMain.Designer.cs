namespace MrTEK_EFatura
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition6 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition7 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition8 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.FirmConn = new NeoDAC.NeoConnection(this.components);
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnRefreshAll = new DevExpress.XtraEditors.SimpleButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cmdPrintXSLTSingle = new DevExpress.XtraEditors.SimpleButton();
            this.cmdPrintXSLTMulti = new DevExpress.XtraEditors.SimpleButton();
            this.cmdGeneralPrint = new DevExpress.XtraEditors.SimpleButton();
            this.userCntDateFilter1 = new MrTEK_EFatura.userCntDateFilter();
            this.btnListeleEFaturaMukellefleri = new DevExpress.XtraEditors.SimpleButton();
            this.btnDownloadEFaturaMukellef = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.grGelenKutusu = new DevExpress.XtraGrid.GridControl();
            this.conMenuGelen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.onaylaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.reddetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbInvoice_GelenKutusu = new NeoDAC.NeoTable(this.components);
            this.tbInvoice_GelenKutusu_InvoiceID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_Deleted = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_CreatedBy = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_CreatedDate = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ModifiedBy = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ModifiedDate = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_IOType = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_IntCode = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_LocalStatus = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_IntegratorID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_Status = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_StatusDescription = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_PostBox = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_XsltNo = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ProfileID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_UUID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_IssueDate = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_IssueTime = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_InvoiceTypeCode = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_DocumentCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_TaxCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_PricingCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_PaymentCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_PaymentAlternativeCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_LineCountNumeric = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_InvoicePeriod_StartDate = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_InvoicePeriod_EndDate = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_PartyIdentification1_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_PartyIdentification1_ID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_PartyIdentification2_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_PartyIdentification2_ID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_PartyIdentification3_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_PartyIdentification3_ID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_PartyIdentification4_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_PartyIdentification4_ID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_PartyIdentification5_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_PartyIdentification5_ID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_PartyName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_PostalAddress_StreetName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_PostalAddress_Room = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_PostalAddress_BuildingNumber = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_PostalAddress_BuildingName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_PostalAddress_CitySubdivisionName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_PostalAddress_CityName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_PostalAddress_Country = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_PartyTaxSchemeName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_PartyTaxSchemeTaxTypeCode = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_WebsiteURI = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_Contact_Telephone = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_Contact_Telefax = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_Contact_ElectronicMail = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_Person_FirstName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_Person_FamilyName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_Person_MiddleName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_Person_NameSuffix = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_Person_Title = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification1_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification1_ID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification2_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification2_ID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification3_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification3_ID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification4_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification4_ID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification5_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification5_ID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_StreetName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_Room = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_BuildingNumber = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_BuildingName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_CitySubdivisionName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_CityName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_Country = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyTaxSchemeName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyTaxSchemeTaxTypeCode = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_AgentParty_WebsiteURI = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_AgentParty_Contact_Telephone = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_AgentParty_Contact_Telefax = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_AgentParty_Contact_ElectronicMail = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_AgentParty_Person_FirstName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_AgentParty_Person_FamilyName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_AgentParty_Person_MiddleName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_AgentParty_Person_NameSuffix = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ASP_AgentParty_Person_Title = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_PartyIdentification1_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_PartyIdentification1_ID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_PartyIdentification2_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_PartyIdentification2_ID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_PartyIdentification3_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_PartyIdentification3_ID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_PartyIdentification4_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_PartyIdentification4_ID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_PartyIdentification5_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_PartyIdentification5_ID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_PartyName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_PostalAddress_StreetName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_PostalAddress_Room = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_PostalAddress_BuildingNumber = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_PostalAddress_BuildingName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_PostalAddress_CitySubdivisionName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_PostalAddress_CityName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_PostalAddress_Country = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_PartyTaxSchemeName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_PartyTaxSchemeTaxTypeCode = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_WebsiteURI = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_Contact_Telephone = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_Contact_Telefax = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_Contact_ElectronicMail = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_Person_FirstName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_Person_FamilyName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_Person_MiddleName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_Person_NameSuffix = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_Person_Title = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification1_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification1_ID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification2_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification2_ID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification3_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification3_ID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification4_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification4_ID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification5_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification5_ID = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_StreetName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_Room = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_BuildingNumber = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_BuildingName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_CitySubdivisionName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_CityName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_Country = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyTaxSchemeName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyTaxSchemeTaxTypeCode = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_AgentParty_WebsiteURI = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_AgentParty_Contact_Telephone = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_AgentParty_Contact_Telefax = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_AgentParty_Contact_ElectronicMail = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_AgentParty_Person_FirstName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_AgentParty_Person_FamilyName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_AgentParty_Person_MiddleName = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_AgentParty_Person_NameSuffix = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_ACP_AgentParty_Person_Title = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_TaxExchangeRate_SourceCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_TaxExchangeRate_TargetCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_TaxExchangeRate_CalculationRate = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_TaxExchangeRate_Date = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_PricingExchangeRate_SourceCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_PricingExchangeRate_TargetCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_PricingExchangeRate_CalculationRate = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_PricingExchangeRate_Date = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_PaymentExchangeRate_SourceCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_PaymentExchangeRate_TargetCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_PaymentExchangeRate_CalculationRate = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_PaymentExchangeRate_Date = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_PaymentAlternativeExchangeRate_SourceCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_PaymentAlternativeExchangeRate_TargetCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_PaymentAlternativeExchangeRate_CalculationRate = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_PaymentAlternativeExchangeRate_Date = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_TaxAmount = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_LegalMonetaryTotal_LineExtensionAmount = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_LegalMonetaryTotal_TaxExclusiveAmount = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_LegalMonetaryTotal_TaxInclusiveAmount = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_LegalMonetaryTotal_AllowanceTotalAmount = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_LegalMonetaryTotal_ChargeTotalAmount = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_LegalMonetaryTotal_PayableRoundingAmount = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_LegalMonetaryTotal_PayableAmount = new System.Data.DataColumn();
            this.tbInvoice_GelenKutusu_WithholdingTaxAmount = new System.Data.DataColumn();
            this.sqlCommand8 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand7 = new System.Data.SqlClient.SqlCommand();
            this.grGelenKutusuView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colInvoiceID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIntegratorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIOType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifiedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocalStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostBox = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProfileID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIssueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIssueTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceTypeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocumentCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPricingCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentAlternativeCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLineCountNumeric = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoicePeriod_StartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoicePeriod_EndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoicePeriod_DurationMeasure = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoicePeriod_Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_PartyIdentification1_schemeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_PartyIdentification1_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_PartyIdentification2_schemeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_PartyIdentification2_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_PartyIdentification3_schemeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_PartyIdentification3_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_PartyIdentification4_schemeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_PartyIdentification4_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_PartyIdentification5_schemeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_PartyIdentification5_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_PartyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_PostalAddress_StreetName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_PostalAddress_Room = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_PostalAddress_BuildingNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_PostalAddress_CitySubdivisionName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_PostalAddress_CityName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_PostalAddress_Country = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_PartyTaxScheme = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_Contact_Telephone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_Contact_Telefax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_Contact_ElectronicMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_Person_FirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_Person_FamilyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_AgentParty_PartyIdentification1_schemeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_AgentParty_PartyIdentification1_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_AgentParty_PartyIdentification2_schemeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_AgentParty_PartyIdentification2_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_AgentParty_PartyIdentification3_schemeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_AgentParty_PartyIdentification3_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_AgentParty_PartyIdentification4_schemeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_AgentParty_PartyIdentification4_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_AgentParty_PartyIdentification5_schemeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_AgentParty_PartyIdentification5_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_AgentParty_PartyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_AgentParty_PostalAddress_StreetName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_AgentParty_PostalAddress_Room = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_AgentParty_PostalAddress_BuildingNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_AgentParty_PostalAddress_CitySubdivisionName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_AgentParty_PostalAddress_CityName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_AgentParty_PostalAddress_Country = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_AgentParty_PartyTaxScheme = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_AgentParty_Contact_Telephone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_AgentParty_Contact_Telefax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASP_AgentParty_Contact_ElectronicMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_PartyIdentification1_schemeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_PartyIdentification1_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_PartyIdentification2_schemeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_PartyIdentification2_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_PartyIdentification3_schemeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_PartyIdentification3_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_PartyIdentification4_schemeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_PartyIdentification4_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_PartyIdentification5_schemeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_PartyIdentification5_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_PartyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_PostalAddress_StreetName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_PostalAddress_Room = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_PostalAddress_BuildingNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_PostalAddress_CitySubdivisionName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_PostalAddress_CityName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_PostalAddress_Country = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_PartyTaxScheme = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_Contact_Telephone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_Contact_Telefax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_Contact_ElectronicMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_Person_FirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_Person_FamilyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_AgentParty_PartyIdentification1_schemeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_AgentParty_PartyIdentification1_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_AgentParty_PartyIdentification2_schemeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_AgentParty_PartyIdentification2_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_AgentParty_PartyIdentification3_schemeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_AgentParty_PartyIdentification3_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_AgentParty_PartyIdentification4_schemeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_AgentParty_PartyIdentification4_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_AgentParty_PartyIdentification5_schemeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_AgentParty_PartyIdentification5_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_AgentParty_PartyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_AgentParty_PostalAddress_StreetName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_AgentParty_PostalAddress_Room = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_AgentParty_PostalAddress_BuildingNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_AgentParty_PostalAddress_CitySubdivisionName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_AgentParty_PostalAddress_CityName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_AgentParty_PostalAddress_Country = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_AgentParty_PartyTaxScheme = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_AgentParty_Contact_Telephone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_AgentParty_Contact_Telefax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACP_AgentParty_Contact_ElectronicMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxExchangeRate_SourceCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxExchangeRate_TargetCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxExchangeRate_CalculationRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxExchangeRate_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPricingExchangeRate_SourceCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPricingExchangeRate_TargetCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPricingExchangeRate_CalculationRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPricingExchangeRate_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentExchangeRate_SourceCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentExchangeRate_TargetCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentExchangeRate_CalculationRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentExchangeRate_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentAlternativeExchangeRate_SourceCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentAlternativeExchangeRate_TargetCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentAlternativeExchangeRate_CalculationRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentAlternativeExchangeRate_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLegalMonetaryTotal_LineExtensionAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLegalMonetaryTotal_TaxExclusiveAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLegalMonetaryTotal_TaxInclusiveAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLegalMonetaryTotal_AllowanceTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLegalMonetaryTotal_ChargeTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLegalMonetaryTotal_PayableRoundingAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLegalMonetaryTotal_PayableAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIntCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDownloadIncomingInvoice = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.grGidenKutusu = new DevExpress.XtraGrid.GridControl();
            this.conMenuGiden = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.faturayiAcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.gonderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.gonderilmisGibiİsaretleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbInvoice_GidenKutusu = new NeoDAC.NeoTable(this.components);
            this.tbInvoice_GidenKutusu_InvoiceID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_Deleted = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_CreatedBy = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_CreatedDate = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ModifiedBy = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ModifiedDate = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_IOType = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_IntCode = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_LocalStatus = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_IntegratorID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_Status = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_StatusDescription = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_PostBox = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_XsltNo = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ProfileID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_UUID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_IssueDate = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_IssueTime = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_InvoiceTypeCode = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_DocumentCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_TaxCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_PricingCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_PaymentCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_PaymentAlternativeCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_LineCountNumeric = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_InvoicePeriod_StartDate = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_InvoicePeriod_EndDate = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_PartyIdentification1_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_PartyIdentification1_ID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_PartyIdentification2_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_PartyIdentification2_ID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_PartyIdentification3_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_PartyIdentification3_ID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_PartyIdentification4_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_PartyIdentification4_ID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_PartyIdentification5_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_PartyIdentification5_ID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_PartyName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_PostalAddress_StreetName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_PostalAddress_Room = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_PostalAddress_BuildingNumber = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_PostalAddress_BuildingName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_PostalAddress_CitySubdivisionName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_PostalAddress_CityName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_PostalAddress_Country = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_PartyTaxSchemeName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_PartyTaxSchemeTaxTypeCode = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_WebsiteURI = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_Contact_Telephone = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_Contact_Telefax = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_Contact_ElectronicMail = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_Person_FirstName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_Person_FamilyName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_Person_MiddleName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_Person_NameSuffix = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_Person_Title = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification1_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification1_ID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification2_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification2_ID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification3_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification3_ID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification4_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification4_ID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification5_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification5_ID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_StreetName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_Room = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_BuildingNumber = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_BuildingName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_CitySubdivisionName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_CityName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_Country = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyTaxSchemeName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyTaxSchemeTaxTypeCode = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_AgentParty_WebsiteURI = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_AgentParty_Contact_Telephone = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_AgentParty_Contact_Telefax = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_AgentParty_Contact_ElectronicMail = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_AgentParty_Person_FirstName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_AgentParty_Person_FamilyName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_AgentParty_Person_MiddleName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_AgentParty_Person_NameSuffix = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ASP_AgentParty_Person_Title = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_PartyIdentification1_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_PartyIdentification1_ID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_PartyIdentification2_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_PartyIdentification2_ID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_PartyIdentification3_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_PartyIdentification3_ID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_PartyIdentification4_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_PartyIdentification4_ID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_PartyIdentification5_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_PartyIdentification5_ID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_PartyName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_PostalAddress_StreetName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_PostalAddress_Room = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_PostalAddress_BuildingNumber = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_PostalAddress_BuildingName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_PostalAddress_CitySubdivisionName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_PostalAddress_CityName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_PostalAddress_Country = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_PartyTaxSchemeName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_PartyTaxSchemeTaxTypeCode = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_WebsiteURI = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_Contact_Telephone = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_Contact_Telefax = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_Contact_ElectronicMail = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_Person_FirstName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_Person_FamilyName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_Person_MiddleName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_Person_NameSuffix = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_Person_Title = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification1_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification1_ID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification2_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification2_ID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification3_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification3_ID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification4_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification4_ID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification5_schemeID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification5_ID = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_StreetName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_Room = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_BuildingNumber = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_BuildingName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_CitySubdivisionName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_CityName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_Country = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyTaxSchemeName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyTaxSchemeTaxTypeCode = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_AgentParty_WebsiteURI = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_AgentParty_Contact_Telephone = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_AgentParty_Contact_Telefax = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_AgentParty_Contact_ElectronicMail = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_AgentParty_Person_FirstName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_AgentParty_Person_FamilyName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_AgentParty_Person_MiddleName = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_AgentParty_Person_NameSuffix = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_ACP_AgentParty_Person_Title = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_TaxExchangeRate_SourceCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_TaxExchangeRate_TargetCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_TaxExchangeRate_CalculationRate = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_TaxExchangeRate_Date = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_PricingExchangeRate_SourceCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_PricingExchangeRate_TargetCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_PricingExchangeRate_CalculationRate = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_PricingExchangeRate_Date = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_PaymentExchangeRate_SourceCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_PaymentExchangeRate_TargetCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_PaymentExchangeRate_CalculationRate = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_PaymentExchangeRate_Date = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_PaymentAlternativeExchangeRate_SourceCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_PaymentAlternativeExchangeRate_TargetCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_PaymentAlternativeExchangeRate_CalculationRate = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_PaymentAlternativeExchangeRate_Date = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_TaxAmount = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_LegalMonetaryTotal_LineExtensionAmount = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_LegalMonetaryTotal_TaxExclusiveAmount = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_LegalMonetaryTotal_TaxInclusiveAmount = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_LegalMonetaryTotal_AllowanceTotalAmount = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_LegalMonetaryTotal_ChargeTotalAmount = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_LegalMonetaryTotal_PayableRoundingAmount = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_LegalMonetaryTotal_PayableAmount = new System.Data.DataColumn();
            this.tbInvoice_GidenKutusu_WithholdingTaxAmount = new System.Data.DataColumn();
            this.sqlCommand12 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand10 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand9 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand11 = new System.Data.SqlClient.SqlCommand();
            this.grGidenKutusuView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn25 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn26 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn27 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn28 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn29 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn30 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn31 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn32 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn33 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn34 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn35 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn36 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn37 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn38 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn39 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn40 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn41 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn42 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn43 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn44 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn45 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn46 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn47 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn48 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn49 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn50 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn51 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn52 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn53 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn54 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn55 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn56 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn57 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn58 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn59 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn60 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn61 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn62 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn63 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn64 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn65 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn66 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn67 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn68 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn69 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn70 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn71 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn72 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn73 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn74 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn75 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn76 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn77 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn78 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn79 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn80 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn81 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn82 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn83 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn84 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn85 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn86 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn87 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn88 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn89 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn90 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn91 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn92 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn93 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn94 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn95 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn96 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn97 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn98 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn99 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn100 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn101 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn102 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn103 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn104 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn105 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn106 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn107 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn108 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn109 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn110 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn111 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn112 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn113 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn114 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn115 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn116 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn117 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn118 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn119 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn120 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn121 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn122 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn123 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn124 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn125 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn126 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn127 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn128 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn129 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn130 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn131 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn132 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn133 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn134 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn135 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn136 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLegalMonetaryTotal_ChargeTotalAmount1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn137 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn275 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn276 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGidecekFaturalariGonder = new DevExpress.XtraEditors.SimpleButton();
            this.btnSyncOutgoingInvoice = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.grGonderilmisler = new DevExpress.XtraGrid.GridControl();
            this.conMenuGonderilmis = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuGonderilmis_Gerial = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuGonderilmisSil = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.logGoruntuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbInvoice_Gonderilmisler = new NeoDAC.NeoTable(this.components);
            this.tbInvoice_Gonderilmisler_InvoiceID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_Deleted = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_CreatedBy = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_CreatedDate = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ModifiedBy = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ModifiedDate = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_IOType = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_IntCode = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_LocalStatus = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_IntegratorID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_Status = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_StatusDescription = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_PostBox = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_XsltNo = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ProfileID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_UUID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_IssueDate = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_IssueTime = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_InvoiceTypeCode = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_DocumentCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_TaxCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_PricingCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_PaymentCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_PaymentAlternativeCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_LineCountNumeric = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_InvoicePeriod_StartDate = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_InvoicePeriod_EndDate = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_PartyIdentification1_schemeID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_PartyIdentification1_ID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_PartyIdentification2_schemeID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_PartyIdentification2_ID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_PartyIdentification3_schemeID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_PartyIdentification3_ID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_PartyIdentification4_schemeID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_PartyIdentification4_ID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_PartyIdentification5_schemeID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_PartyIdentification5_ID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_PartyName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_PostalAddress_StreetName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_PostalAddress_Room = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_PostalAddress_BuildingNumber = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_PostalAddress_BuildingName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_PostalAddress_CitySubdivisionName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_PostalAddress_CityName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_PostalAddress_Country = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_PartyTaxSchemeName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_PartyTaxSchemeTaxTypeCode = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_WebsiteURI = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_Contact_Telephone = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_Contact_Telefax = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_Contact_ElectronicMail = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_Person_FirstName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_Person_FamilyName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_Person_MiddleName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_Person_NameSuffix = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_Person_Title = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification1_schemeID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification1_ID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification2_schemeID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification2_ID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification3_schemeID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification3_ID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification4_schemeID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification4_ID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification5_schemeID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification5_ID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_StreetName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_Room = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_BuildingNumber = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_BuildingName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_CitySubdivisionName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_CityName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_Country = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyTaxSchemeName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyTaxSchemeTaxTypeCode = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_WebsiteURI = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_Contact_Telephone = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_Contact_Telefax = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_Contact_ElectronicMail = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_Person_FirstName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_Person_FamilyName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_Person_MiddleName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_Person_NameSuffix = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_Person_Title = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_PartyIdentification1_schemeID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_PartyIdentification1_ID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_PartyIdentification2_schemeID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_PartyIdentification2_ID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_PartyIdentification3_schemeID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_PartyIdentification3_ID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_PartyIdentification4_schemeID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_PartyIdentification4_ID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_PartyIdentification5_schemeID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_PartyIdentification5_ID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_PartyName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_PostalAddress_StreetName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_PostalAddress_Room = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_PostalAddress_BuildingNumber = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_PostalAddress_BuildingName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_PostalAddress_CitySubdivisionName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_PostalAddress_CityName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_PostalAddress_Country = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_PartyTaxSchemeName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_PartyTaxSchemeTaxTypeCode = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_WebsiteURI = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_Contact_Telephone = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_Contact_Telefax = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_Contact_ElectronicMail = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_Person_FirstName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_Person_FamilyName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_Person_MiddleName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_Person_NameSuffix = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_Person_Title = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification1_schemeID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification1_ID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification2_schemeID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification2_ID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification3_schemeID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification3_ID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification4_schemeID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification4_ID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification5_schemeID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification5_ID = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_StreetName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_Room = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_BuildingNumber = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_BuildingName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_CitySubdivisionName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_CityName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_Country = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyTaxSchemeName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyTaxSchemeTaxTypeCode = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_WebsiteURI = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_Contact_Telephone = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_Contact_Telefax = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_Contact_ElectronicMail = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_Person_FirstName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_Person_FamilyName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_Person_MiddleName = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_Person_NameSuffix = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_Person_Title = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_TaxExchangeRate_SourceCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_TaxExchangeRate_TargetCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_TaxExchangeRate_CalculationRate = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_TaxExchangeRate_Date = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_PricingExchangeRate_SourceCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_PricingExchangeRate_TargetCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_PricingExchangeRate_CalculationRate = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_PricingExchangeRate_Date = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_PaymentExchangeRate_SourceCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_PaymentExchangeRate_TargetCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_PaymentExchangeRate_CalculationRate = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_PaymentExchangeRate_Date = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_PaymentAlternativeExchangeRate_SourceCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_PaymentAlternativeExchangeRate_TargetCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_PaymentAlternativeExchangeRate_CalculationRate = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_PaymentAlternativeExchangeRate_Date = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_TaxAmount = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_LegalMonetaryTotal_LineExtensionAmount = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_LegalMonetaryTotal_TaxExclusiveAmount = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_LegalMonetaryTotal_TaxInclusiveAmount = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_LegalMonetaryTotal_AllowanceTotalAmount = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_LegalMonetaryTotal_ChargeTotalAmount = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_LegalMonetaryTotal_PayableRoundingAmount = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_LegalMonetaryTotal_PayableAmount = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_WithholdingTaxAmount = new System.Data.DataColumn();
            this.tbInvoice_Gonderilmisler_Message = new System.Data.DataColumn();
            this.sqlCommand16 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand14 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand13 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand15 = new System.Data.SqlClient.SqlCommand();
            this.grGonderilmislerView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn138 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn139 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn140 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn141 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn142 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn143 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn144 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn145 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn146 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn147 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn148 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn149 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn150 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn151 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn152 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn153 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn154 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn155 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn156 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn157 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn158 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn159 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn160 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn161 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn162 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn163 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn164 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn165 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn166 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn167 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn168 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn169 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn170 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn171 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn172 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn173 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn174 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn175 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn176 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn177 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn178 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn179 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn180 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn181 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn182 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn183 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn184 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn185 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn186 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn187 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn188 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn189 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn190 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn191 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn192 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn193 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn194 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn195 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn196 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn197 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn198 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn199 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn200 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn201 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn202 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn203 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn204 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn205 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn206 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn207 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn208 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn209 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn210 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn211 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn212 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn213 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn214 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn215 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn216 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn217 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn218 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn219 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn220 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn221 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn222 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn223 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn224 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn225 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn226 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn227 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn228 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn229 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn230 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn231 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn232 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn233 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn234 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn235 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn236 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn237 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn238 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn239 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn240 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn241 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn242 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn243 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn244 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn245 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn246 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn247 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn248 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn249 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn250 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn251 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn252 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn253 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn254 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn255 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn256 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn257 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn258 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn259 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn260 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn261 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn262 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn263 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn264 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn265 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn266 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn267 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn268 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn269 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn270 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn271 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn272 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn273 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLegalMonetaryTotal_ChargeTotalAmount2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn274 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn277 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn278 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUpdateStatus = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.panelWait = new DevExpress.XtraEditors.PanelControl();
            this.lblWait = new DevExpress.XtraEditors.LabelControl();
            this.txtDebug = new DevExpress.XtraEditors.MemoEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.grEFaturaMembers = new DevExpress.XtraGrid.GridControl();
            this.tbEFaturaMembers = new NeoDAC.NeoTable(this.components);
            this.tbEFaturaMembers_EFaturaMemberID = new System.Data.DataColumn();
            this.tbEFaturaMembers_VKN = new System.Data.DataColumn();
            this.tbEFaturaMembers_FirmTitle = new System.Data.DataColumn();
            this.tbEFaturaMembers_PostboxAlias = new System.Data.DataColumn();
            this.tbEFaturaMembers_SenderboxAlias = new System.Data.DataColumn();
            this.tbEFaturaMembers_SystemCreateDate = new System.Data.DataColumn();
            this.tbEFaturaMembers_FirmCode = new System.Data.DataColumn();
            this.tbEFaturaMembers_bDefault = new System.Data.DataColumn();
            this.sqlCommand20 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand18 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand17 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand19 = new System.Data.SqlClient.SqlCommand();
            this.grEFaturaMembersView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEFaturaMemberID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVKN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirmTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostboxAlias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSenderboxAlias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSystemCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirmCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbDefault = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnEFaturaMembers_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnEFaturaMembers_Save = new DevExpress.XtraEditors.SimpleButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnEFaturaMembers_ExportExcel = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage6 = new DevExpress.XtraTab.XtraTabPage();
            this.btnItems = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus_Server = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus_Database = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus_ProgramVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.doyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programHakkindaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ExportDialog = new System.Windows.Forms.SaveFileDialog();
            this.conMenuExport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.conMenuExport_XLSX = new System.Windows.Forms.ToolStripMenuItem();
            this.conMenuExport_XLS = new System.Windows.Forms.ToolStripMenuItem();
            this.conMenuExport_PDF = new System.Windows.Forms.ToolStripMenuItem();
            this.conMenuExport_TXT = new System.Windows.Forms.ToolStripMenuItem();
            this.conMenuExport_CSV = new System.Windows.Forms.ToolStripMenuItem();
            this.conMenuExport_HTML = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTop.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grGelenKutusu)).BeginInit();
            this.conMenuGelen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoice_GelenKutusu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grGelenKutusuView)).BeginInit();
            this.panel1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grGidenKutusu)).BeginInit();
            this.conMenuGiden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoice_GidenKutusu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grGidenKutusuView)).BeginInit();
            this.panel3.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grGonderilmisler)).BeginInit();
            this.conMenuGonderilmis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoice_Gonderilmisler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grGonderilmislerView)).BeginInit();
            this.panel4.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelWait)).BeginInit();
            this.panelWait.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebug.Properties)).BeginInit();
            this.xtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grEFaturaMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEFaturaMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grEFaturaMembersView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.xtraTabPage6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.conMenuExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirmConn
            // 
            this.FirmConn.ConnectionString = "Server=(local)\\Sql2008;Database=MrTEK_EFatura;User ID=sa;Password=;Trusted_Connec" +
    "tion=True;";
            this.FirmConn.Name = "FirmConn";
            this.FirmConn.UserInfo_AuthCodeFieldName = "AuthCode";
            this.FirmConn.UserInfo_CanDeleteAuthCode = "";
            this.FirmConn.UserInfo_CanReadAuthCode = "";
            this.FirmConn.UserInfo_CanWriteAuthCode = "";
            this.FirmConn.UserInfo_CreatedDateFieldName = "CreatedDate";
            this.FirmConn.UserInfo_CreatedUserFieldName = "CreatedBy";
            this.FirmConn.UserInfo_ModifiedDateFieldName = "ModifiedDate";
            this.FirmConn.UserInfo_ModifiedUserFieldName = "ModifiedBy";
            this.FirmConn.UserInfo_NewRecordAuthCode = "";
            this.FirmConn.UserInfo_UserID = null;
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = "DELETE FROM EntryHeader WHERE EntryHeaderID = @EntryHeaderID";
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = resources.GetString("sqlCommand2.CommandText");
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT * FROM Invoice WHERE IOType=1";
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = resources.GetString("sqlCommand3.CommandText");
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnRefreshAll);
            this.panelTop.Controls.Add(this.panel7);
            this.panelTop.Controls.Add(this.userCntDateFilter1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 24);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(984, 80);
            this.panelTop.TabIndex = 3;
            // 
            // btnRefreshAll
            // 
            this.btnRefreshAll.Location = new System.Drawing.Point(388, 10);
            this.btnRefreshAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshAll.Name = "btnRefreshAll";
            this.btnRefreshAll.Size = new System.Drawing.Size(102, 45);
            this.btnRefreshAll.TabIndex = 9;
            this.btnRefreshAll.Text = "Listele";
            this.btnRefreshAll.Click += new System.EventHandler(this.btnRefreshAll_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.cmdPrintXSLTSingle);
            this.panel7.Controls.Add(this.cmdPrintXSLTMulti);
            this.panel7.Controls.Add(this.cmdGeneralPrint);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(687, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(297, 80);
            this.panel7.TabIndex = 8;
            // 
            // cmdPrintXSLTSingle
            // 
            this.cmdPrintXSLTSingle.Image = global::MrTEK_EFatura.Properties.Resources.xsl32;
            this.cmdPrintXSLTSingle.Location = new System.Drawing.Point(5, 10);
            this.cmdPrintXSLTSingle.Name = "cmdPrintXSLTSingle";
            this.cmdPrintXSLTSingle.Size = new System.Drawing.Size(90, 45);
            this.cmdPrintXSLTSingle.TabIndex = 41;
            this.cmdPrintXSLTSingle.Text = "Tek (F9)";
            this.cmdPrintXSLTSingle.ToolTip = "Secili fatura XSLT goruntuler";
            this.cmdPrintXSLTSingle.Click += new System.EventHandler(this.cmdPrintXSLTSingle_Click);
            // 
            // cmdPrintXSLTMulti
            // 
            this.cmdPrintXSLTMulti.Image = global::MrTEK_EFatura.Properties.Resources.xsl32;
            this.cmdPrintXSLTMulti.Location = new System.Drawing.Point(101, 10);
            this.cmdPrintXSLTMulti.Name = "cmdPrintXSLTMulti";
            this.cmdPrintXSLTMulti.Size = new System.Drawing.Size(90, 45);
            this.cmdPrintXSLTMulti.TabIndex = 40;
            this.cmdPrintXSLTMulti.Text = "Coklu";
            this.cmdPrintXSLTMulti.ToolTip = "Listedeki tum faturalari yazicidan yazdirir";
            this.cmdPrintXSLTMulti.Click += new System.EventHandler(this.cmdPrintXSLTMulti_Click);
            // 
            // cmdGeneralPrint
            // 
            this.cmdGeneralPrint.Image = global::MrTEK_EFatura.Properties.Resources.printer_blue_icon32;
            this.cmdGeneralPrint.Location = new System.Drawing.Point(197, 10);
            this.cmdGeneralPrint.Name = "cmdGeneralPrint";
            this.cmdGeneralPrint.Size = new System.Drawing.Size(90, 45);
            this.cmdGeneralPrint.TabIndex = 4;
            this.cmdGeneralPrint.Text = "Yazdır";
            this.cmdGeneralPrint.Click += new System.EventHandler(this.cmdGeneralPrint_Click);
            // 
            // userCntDateFilter1
            // 
            this.userCntDateFilter1.Date1 = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.userCntDateFilter1.Date2 = new System.DateTime(2024, 1, 31, 23, 59, 59, 0);
            this.userCntDateFilter1.DateFilter = true;
            this.userCntDateFilter1.Location = new System.Drawing.Point(9, 10);
            this.userCntDateFilter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userCntDateFilter1.Name = "userCntDateFilter1";
            this.userCntDateFilter1.Size = new System.Drawing.Size(375, 54);
            this.userCntDateFilter1.TabIndex = 7;
            // 
            // btnListeleEFaturaMukellefleri
            // 
            this.btnListeleEFaturaMukellefleri.Location = new System.Drawing.Point(8, 13);
            this.btnListeleEFaturaMukellefleri.Margin = new System.Windows.Forms.Padding(2);
            this.btnListeleEFaturaMukellefleri.Name = "btnListeleEFaturaMukellefleri";
            this.btnListeleEFaturaMukellefleri.Size = new System.Drawing.Size(102, 32);
            this.btnListeleEFaturaMukellefleri.TabIndex = 5;
            this.btnListeleEFaturaMukellefleri.Text = "Listele";
            this.btnListeleEFaturaMukellefleri.Click += new System.EventHandler(this.btnListeleEFaturaMukellefleri_Click);
            // 
            // btnDownloadEFaturaMukellef
            // 
            this.btnDownloadEFaturaMukellef.Location = new System.Drawing.Point(276, 13);
            this.btnDownloadEFaturaMukellef.Margin = new System.Windows.Forms.Padding(2);
            this.btnDownloadEFaturaMukellef.Name = "btnDownloadEFaturaMukellef";
            this.btnDownloadEFaturaMukellef.Size = new System.Drawing.Size(176, 32);
            this.btnDownloadEFaturaMukellef.TabIndex = 8;
            this.btnDownloadEFaturaMukellef.Text = "E-Fatura Mukellef Download";
            this.btnDownloadEFaturaMukellef.Click += new System.EventHandler(this.btnDownloadEFaturaMukellef_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 104);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(984, 376);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4,
            this.xtraTabPage5,
            this.xtraTabPage6});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.grGelenKutusu);
            this.xtraTabPage1.Controls.Add(this.panel1);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(978, 348);
            this.xtraTabPage1.Text = "Gelen kutusu";
            // 
            // grGelenKutusu
            // 
            this.grGelenKutusu.ContextMenuStrip = this.conMenuGelen;
            this.grGelenKutusu.DataSource = this.tbInvoice_GelenKutusu;
            this.grGelenKutusu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grGelenKutusu.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grGelenKutusu.Location = new System.Drawing.Point(0, 50);
            this.grGelenKutusu.MainView = this.grGelenKutusuView;
            this.grGelenKutusu.Margin = new System.Windows.Forms.Padding(2);
            this.grGelenKutusu.Name = "grGelenKutusu";
            this.grGelenKutusu.Size = new System.Drawing.Size(978, 298);
            this.grGelenKutusu.TabIndex = 0;
            this.grGelenKutusu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grGelenKutusuView});
            this.grGelenKutusu.DoubleClick += new System.EventHandler(this.grGelenKutusu_DoubleClick);
            // 
            // conMenuGelen
            // 
            this.conMenuGelen.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.conMenuGelen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onaylaToolStripMenuItem,
            this.toolStripMenuItem3,
            this.reddetToolStripMenuItem});
            this.conMenuGelen.Name = "conMenuGelen";
            this.conMenuGelen.Size = new System.Drawing.Size(112, 54);
            this.conMenuGelen.Opening += new System.ComponentModel.CancelEventHandler(this.conMenuGelen_Opening);
            // 
            // onaylaToolStripMenuItem
            // 
            this.onaylaToolStripMenuItem.Name = "onaylaToolStripMenuItem";
            this.onaylaToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.onaylaToolStripMenuItem.Text = "Onayla";
            this.onaylaToolStripMenuItem.Click += new System.EventHandler(this.onaylaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(108, 6);
            // 
            // reddetToolStripMenuItem
            // 
            this.reddetToolStripMenuItem.Name = "reddetToolStripMenuItem";
            this.reddetToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.reddetToolStripMenuItem.Text = "Reddet";
            this.reddetToolStripMenuItem.Click += new System.EventHandler(this.reddetToolStripMenuItem_Click);
            // 
            // tbInvoice_GelenKutusu
            // 
            this.tbInvoice_GelenKutusu.Columns.AddRange(new System.Data.DataColumn[] {
            this.tbInvoice_GelenKutusu_InvoiceID,
            this.tbInvoice_GelenKutusu_Deleted,
            this.tbInvoice_GelenKutusu_CreatedBy,
            this.tbInvoice_GelenKutusu_CreatedDate,
            this.tbInvoice_GelenKutusu_ModifiedBy,
            this.tbInvoice_GelenKutusu_ModifiedDate,
            this.tbInvoice_GelenKutusu_IOType,
            this.tbInvoice_GelenKutusu_IntCode,
            this.tbInvoice_GelenKutusu_LocalStatus,
            this.tbInvoice_GelenKutusu_IntegratorID,
            this.tbInvoice_GelenKutusu_Status,
            this.tbInvoice_GelenKutusu_StatusDescription,
            this.tbInvoice_GelenKutusu_PostBox,
            this.tbInvoice_GelenKutusu_XsltNo,
            this.tbInvoice_GelenKutusu_ProfileID,
            this.tbInvoice_GelenKutusu_ID,
            this.tbInvoice_GelenKutusu_UUID,
            this.tbInvoice_GelenKutusu_IssueDate,
            this.tbInvoice_GelenKutusu_IssueTime,
            this.tbInvoice_GelenKutusu_InvoiceTypeCode,
            this.tbInvoice_GelenKutusu_DocumentCurrencyCode,
            this.tbInvoice_GelenKutusu_TaxCurrencyCode,
            this.tbInvoice_GelenKutusu_PricingCurrencyCode,
            this.tbInvoice_GelenKutusu_PaymentCurrencyCode,
            this.tbInvoice_GelenKutusu_PaymentAlternativeCurrencyCode,
            this.tbInvoice_GelenKutusu_LineCountNumeric,
            this.tbInvoice_GelenKutusu_InvoicePeriod_StartDate,
            this.tbInvoice_GelenKutusu_InvoicePeriod_EndDate,
            this.tbInvoice_GelenKutusu_ASP_PartyIdentification1_schemeID,
            this.tbInvoice_GelenKutusu_ASP_PartyIdentification1_ID,
            this.tbInvoice_GelenKutusu_ASP_PartyIdentification2_schemeID,
            this.tbInvoice_GelenKutusu_ASP_PartyIdentification2_ID,
            this.tbInvoice_GelenKutusu_ASP_PartyIdentification3_schemeID,
            this.tbInvoice_GelenKutusu_ASP_PartyIdentification3_ID,
            this.tbInvoice_GelenKutusu_ASP_PartyIdentification4_schemeID,
            this.tbInvoice_GelenKutusu_ASP_PartyIdentification4_ID,
            this.tbInvoice_GelenKutusu_ASP_PartyIdentification5_schemeID,
            this.tbInvoice_GelenKutusu_ASP_PartyIdentification5_ID,
            this.tbInvoice_GelenKutusu_ASP_PartyName,
            this.tbInvoice_GelenKutusu_ASP_PostalAddress_StreetName,
            this.tbInvoice_GelenKutusu_ASP_PostalAddress_Room,
            this.tbInvoice_GelenKutusu_ASP_PostalAddress_BuildingNumber,
            this.tbInvoice_GelenKutusu_ASP_PostalAddress_BuildingName,
            this.tbInvoice_GelenKutusu_ASP_PostalAddress_CitySubdivisionName,
            this.tbInvoice_GelenKutusu_ASP_PostalAddress_CityName,
            this.tbInvoice_GelenKutusu_ASP_PostalAddress_Country,
            this.tbInvoice_GelenKutusu_ASP_PartyTaxSchemeName,
            this.tbInvoice_GelenKutusu_ASP_PartyTaxSchemeTaxTypeCode,
            this.tbInvoice_GelenKutusu_ASP_WebsiteURI,
            this.tbInvoice_GelenKutusu_ASP_Contact_Telephone,
            this.tbInvoice_GelenKutusu_ASP_Contact_Telefax,
            this.tbInvoice_GelenKutusu_ASP_Contact_ElectronicMail,
            this.tbInvoice_GelenKutusu_ASP_Person_FirstName,
            this.tbInvoice_GelenKutusu_ASP_Person_FamilyName,
            this.tbInvoice_GelenKutusu_ASP_Person_MiddleName,
            this.tbInvoice_GelenKutusu_ASP_Person_NameSuffix,
            this.tbInvoice_GelenKutusu_ASP_Person_Title,
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification1_schemeID,
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification1_ID,
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification2_schemeID,
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification2_ID,
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification3_schemeID,
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification3_ID,
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification4_schemeID,
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification4_ID,
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification5_schemeID,
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification5_ID,
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyName,
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_StreetName,
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_Room,
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_BuildingNumber,
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_BuildingName,
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_CitySubdivisionName,
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_CityName,
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_Country,
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyTaxSchemeName,
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyTaxSchemeTaxTypeCode,
            this.tbInvoice_GelenKutusu_ASP_AgentParty_WebsiteURI,
            this.tbInvoice_GelenKutusu_ASP_AgentParty_Contact_Telephone,
            this.tbInvoice_GelenKutusu_ASP_AgentParty_Contact_Telefax,
            this.tbInvoice_GelenKutusu_ASP_AgentParty_Contact_ElectronicMail,
            this.tbInvoice_GelenKutusu_ASP_AgentParty_Person_FirstName,
            this.tbInvoice_GelenKutusu_ASP_AgentParty_Person_FamilyName,
            this.tbInvoice_GelenKutusu_ASP_AgentParty_Person_MiddleName,
            this.tbInvoice_GelenKutusu_ASP_AgentParty_Person_NameSuffix,
            this.tbInvoice_GelenKutusu_ASP_AgentParty_Person_Title,
            this.tbInvoice_GelenKutusu_ACP_PartyIdentification1_schemeID,
            this.tbInvoice_GelenKutusu_ACP_PartyIdentification1_ID,
            this.tbInvoice_GelenKutusu_ACP_PartyIdentification2_schemeID,
            this.tbInvoice_GelenKutusu_ACP_PartyIdentification2_ID,
            this.tbInvoice_GelenKutusu_ACP_PartyIdentification3_schemeID,
            this.tbInvoice_GelenKutusu_ACP_PartyIdentification3_ID,
            this.tbInvoice_GelenKutusu_ACP_PartyIdentification4_schemeID,
            this.tbInvoice_GelenKutusu_ACP_PartyIdentification4_ID,
            this.tbInvoice_GelenKutusu_ACP_PartyIdentification5_schemeID,
            this.tbInvoice_GelenKutusu_ACP_PartyIdentification5_ID,
            this.tbInvoice_GelenKutusu_ACP_PartyName,
            this.tbInvoice_GelenKutusu_ACP_PostalAddress_StreetName,
            this.tbInvoice_GelenKutusu_ACP_PostalAddress_Room,
            this.tbInvoice_GelenKutusu_ACP_PostalAddress_BuildingNumber,
            this.tbInvoice_GelenKutusu_ACP_PostalAddress_BuildingName,
            this.tbInvoice_GelenKutusu_ACP_PostalAddress_CitySubdivisionName,
            this.tbInvoice_GelenKutusu_ACP_PostalAddress_CityName,
            this.tbInvoice_GelenKutusu_ACP_PostalAddress_Country,
            this.tbInvoice_GelenKutusu_ACP_PartyTaxSchemeName,
            this.tbInvoice_GelenKutusu_ACP_PartyTaxSchemeTaxTypeCode,
            this.tbInvoice_GelenKutusu_ACP_WebsiteURI,
            this.tbInvoice_GelenKutusu_ACP_Contact_Telephone,
            this.tbInvoice_GelenKutusu_ACP_Contact_Telefax,
            this.tbInvoice_GelenKutusu_ACP_Contact_ElectronicMail,
            this.tbInvoice_GelenKutusu_ACP_Person_FirstName,
            this.tbInvoice_GelenKutusu_ACP_Person_FamilyName,
            this.tbInvoice_GelenKutusu_ACP_Person_MiddleName,
            this.tbInvoice_GelenKutusu_ACP_Person_NameSuffix,
            this.tbInvoice_GelenKutusu_ACP_Person_Title,
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification1_schemeID,
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification1_ID,
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification2_schemeID,
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification2_ID,
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification3_schemeID,
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification3_ID,
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification4_schemeID,
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification4_ID,
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification5_schemeID,
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification5_ID,
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyName,
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_StreetName,
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_Room,
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_BuildingNumber,
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_BuildingName,
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_CitySubdivisionName,
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_CityName,
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_Country,
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyTaxSchemeName,
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyTaxSchemeTaxTypeCode,
            this.tbInvoice_GelenKutusu_ACP_AgentParty_WebsiteURI,
            this.tbInvoice_GelenKutusu_ACP_AgentParty_Contact_Telephone,
            this.tbInvoice_GelenKutusu_ACP_AgentParty_Contact_Telefax,
            this.tbInvoice_GelenKutusu_ACP_AgentParty_Contact_ElectronicMail,
            this.tbInvoice_GelenKutusu_ACP_AgentParty_Person_FirstName,
            this.tbInvoice_GelenKutusu_ACP_AgentParty_Person_FamilyName,
            this.tbInvoice_GelenKutusu_ACP_AgentParty_Person_MiddleName,
            this.tbInvoice_GelenKutusu_ACP_AgentParty_Person_NameSuffix,
            this.tbInvoice_GelenKutusu_ACP_AgentParty_Person_Title,
            this.tbInvoice_GelenKutusu_TaxExchangeRate_SourceCurrencyCode,
            this.tbInvoice_GelenKutusu_TaxExchangeRate_TargetCurrencyCode,
            this.tbInvoice_GelenKutusu_TaxExchangeRate_CalculationRate,
            this.tbInvoice_GelenKutusu_TaxExchangeRate_Date,
            this.tbInvoice_GelenKutusu_PricingExchangeRate_SourceCurrencyCode,
            this.tbInvoice_GelenKutusu_PricingExchangeRate_TargetCurrencyCode,
            this.tbInvoice_GelenKutusu_PricingExchangeRate_CalculationRate,
            this.tbInvoice_GelenKutusu_PricingExchangeRate_Date,
            this.tbInvoice_GelenKutusu_PaymentExchangeRate_SourceCurrencyCode,
            this.tbInvoice_GelenKutusu_PaymentExchangeRate_TargetCurrencyCode,
            this.tbInvoice_GelenKutusu_PaymentExchangeRate_CalculationRate,
            this.tbInvoice_GelenKutusu_PaymentExchangeRate_Date,
            this.tbInvoice_GelenKutusu_PaymentAlternativeExchangeRate_SourceCurrencyCode,
            this.tbInvoice_GelenKutusu_PaymentAlternativeExchangeRate_TargetCurrencyCode,
            this.tbInvoice_GelenKutusu_PaymentAlternativeExchangeRate_CalculationRate,
            this.tbInvoice_GelenKutusu_PaymentAlternativeExchangeRate_Date,
            this.tbInvoice_GelenKutusu_TaxAmount,
            this.tbInvoice_GelenKutusu_LegalMonetaryTotal_LineExtensionAmount,
            this.tbInvoice_GelenKutusu_LegalMonetaryTotal_TaxExclusiveAmount,
            this.tbInvoice_GelenKutusu_LegalMonetaryTotal_TaxInclusiveAmount,
            this.tbInvoice_GelenKutusu_LegalMonetaryTotal_AllowanceTotalAmount,
            this.tbInvoice_GelenKutusu_LegalMonetaryTotal_ChargeTotalAmount,
            this.tbInvoice_GelenKutusu_LegalMonetaryTotal_PayableRoundingAmount,
            this.tbInvoice_GelenKutusu_LegalMonetaryTotal_PayableAmount,
            this.tbInvoice_GelenKutusu_WithholdingTaxAmount});
            this.tbInvoice_GelenKutusu.Connection = this.FirmConn;
            this.tbInvoice_GelenKutusu.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "InvoiceID"}, true)});
            this.tbInvoice_GelenKutusu.CurrentRow = null;
            this.tbInvoice_GelenKutusu.DataSourceLink = null;
            this.tbInvoice_GelenKutusu.DeleteCommand = this.sqlCommand8;
            this.tbInvoice_GelenKutusu.Filter = "";
            this.tbInvoice_GelenKutusu.InsertCommand = this.sqlCommand6;
            this.tbInvoice_GelenKutusu.LiveSave = false;
            this.tbInvoice_GelenKutusu.MaxRecords = ((long)(0));
            this.tbInvoice_GelenKutusu.Name = "tbInvoice_GelenKutusu";
            this.tbInvoice_GelenKutusu.ParentRelation_ChildColumns = null;
            this.tbInvoice_GelenKutusu.ParentRelation_ParentColumns = null;
            this.tbInvoice_GelenKutusu.ParentRelation_Table = null;
            this.tbInvoice_GelenKutusu.Position = ((long)(-1));
            this.tbInvoice_GelenKutusu.PrimaryKey = new System.Data.DataColumn[] {
        this.tbInvoice_GelenKutusu_InvoiceID};
            this.tbInvoice_GelenKutusu.Quoted = false;
            this.tbInvoice_GelenKutusu.SelectCommand = this.sqlCommand5;
            this.tbInvoice_GelenKutusu.TableName = "neoTable1";
            this.tbInvoice_GelenKutusu.Transaction = null;
            this.tbInvoice_GelenKutusu.UpdateCommand = this.sqlCommand7;
            // 
            // tbInvoice_GelenKutusu_InvoiceID
            // 
            this.tbInvoice_GelenKutusu_InvoiceID.AllowDBNull = false;
            this.tbInvoice_GelenKutusu_InvoiceID.AutoIncrement = true;
            this.tbInvoice_GelenKutusu_InvoiceID.ColumnName = "InvoiceID";
            this.tbInvoice_GelenKutusu_InvoiceID.DataType = typeof(int);
            // 
            // tbInvoice_GelenKutusu_Deleted
            // 
            this.tbInvoice_GelenKutusu_Deleted.ColumnName = "Deleted";
            this.tbInvoice_GelenKutusu_Deleted.DataType = typeof(int);
            // 
            // tbInvoice_GelenKutusu_CreatedBy
            // 
            this.tbInvoice_GelenKutusu_CreatedBy.ColumnName = "CreatedBy";
            this.tbInvoice_GelenKutusu_CreatedBy.DataType = typeof(int);
            // 
            // tbInvoice_GelenKutusu_CreatedDate
            // 
            this.tbInvoice_GelenKutusu_CreatedDate.ColumnName = "CreatedDate";
            this.tbInvoice_GelenKutusu_CreatedDate.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_GelenKutusu_ModifiedBy
            // 
            this.tbInvoice_GelenKutusu_ModifiedBy.ColumnName = "ModifiedBy";
            this.tbInvoice_GelenKutusu_ModifiedBy.DataType = typeof(int);
            // 
            // tbInvoice_GelenKutusu_ModifiedDate
            // 
            this.tbInvoice_GelenKutusu_ModifiedDate.ColumnName = "ModifiedDate";
            this.tbInvoice_GelenKutusu_ModifiedDate.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_GelenKutusu_IOType
            // 
            this.tbInvoice_GelenKutusu_IOType.ColumnName = "IOType";
            this.tbInvoice_GelenKutusu_IOType.DataType = typeof(int);
            // 
            // tbInvoice_GelenKutusu_IntCode
            // 
            this.tbInvoice_GelenKutusu_IntCode.ColumnName = "IntCode";
            // 
            // tbInvoice_GelenKutusu_LocalStatus
            // 
            this.tbInvoice_GelenKutusu_LocalStatus.ColumnName = "LocalStatus";
            this.tbInvoice_GelenKutusu_LocalStatus.DataType = typeof(int);
            // 
            // tbInvoice_GelenKutusu_IntegratorID
            // 
            this.tbInvoice_GelenKutusu_IntegratorID.ColumnName = "IntegratorID";
            // 
            // tbInvoice_GelenKutusu_Status
            // 
            this.tbInvoice_GelenKutusu_Status.ColumnName = "Status";
            this.tbInvoice_GelenKutusu_Status.DataType = typeof(int);
            // 
            // tbInvoice_GelenKutusu_StatusDescription
            // 
            this.tbInvoice_GelenKutusu_StatusDescription.ColumnName = "StatusDescription";
            // 
            // tbInvoice_GelenKutusu_PostBox
            // 
            this.tbInvoice_GelenKutusu_PostBox.ColumnName = "PostBox";
            // 
            // tbInvoice_GelenKutusu_XsltNo
            // 
            this.tbInvoice_GelenKutusu_XsltNo.ColumnName = "XsltNo";
            this.tbInvoice_GelenKutusu_XsltNo.DataType = typeof(int);
            // 
            // tbInvoice_GelenKutusu_ProfileID
            // 
            this.tbInvoice_GelenKutusu_ProfileID.ColumnName = "ProfileID";
            // 
            // tbInvoice_GelenKutusu_ID
            // 
            this.tbInvoice_GelenKutusu_ID.ColumnName = "ID";
            // 
            // tbInvoice_GelenKutusu_UUID
            // 
            this.tbInvoice_GelenKutusu_UUID.ColumnName = "UUID";
            // 
            // tbInvoice_GelenKutusu_IssueDate
            // 
            this.tbInvoice_GelenKutusu_IssueDate.ColumnName = "IssueDate";
            this.tbInvoice_GelenKutusu_IssueDate.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_GelenKutusu_IssueTime
            // 
            this.tbInvoice_GelenKutusu_IssueTime.ColumnName = "IssueTime";
            this.tbInvoice_GelenKutusu_IssueTime.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_GelenKutusu_InvoiceTypeCode
            // 
            this.tbInvoice_GelenKutusu_InvoiceTypeCode.ColumnName = "InvoiceTypeCode";
            // 
            // tbInvoice_GelenKutusu_DocumentCurrencyCode
            // 
            this.tbInvoice_GelenKutusu_DocumentCurrencyCode.ColumnName = "DocumentCurrencyCode";
            // 
            // tbInvoice_GelenKutusu_TaxCurrencyCode
            // 
            this.tbInvoice_GelenKutusu_TaxCurrencyCode.ColumnName = "TaxCurrencyCode";
            // 
            // tbInvoice_GelenKutusu_PricingCurrencyCode
            // 
            this.tbInvoice_GelenKutusu_PricingCurrencyCode.ColumnName = "PricingCurrencyCode";
            // 
            // tbInvoice_GelenKutusu_PaymentCurrencyCode
            // 
            this.tbInvoice_GelenKutusu_PaymentCurrencyCode.ColumnName = "PaymentCurrencyCode";
            // 
            // tbInvoice_GelenKutusu_PaymentAlternativeCurrencyCode
            // 
            this.tbInvoice_GelenKutusu_PaymentAlternativeCurrencyCode.ColumnName = "PaymentAlternativeCurrencyCode";
            // 
            // tbInvoice_GelenKutusu_LineCountNumeric
            // 
            this.tbInvoice_GelenKutusu_LineCountNumeric.ColumnName = "LineCountNumeric";
            this.tbInvoice_GelenKutusu_LineCountNumeric.DataType = typeof(int);
            // 
            // tbInvoice_GelenKutusu_InvoicePeriod_StartDate
            // 
            this.tbInvoice_GelenKutusu_InvoicePeriod_StartDate.ColumnName = "InvoicePeriod_StartDate";
            this.tbInvoice_GelenKutusu_InvoicePeriod_StartDate.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_GelenKutusu_InvoicePeriod_EndDate
            // 
            this.tbInvoice_GelenKutusu_InvoicePeriod_EndDate.ColumnName = "InvoicePeriod_EndDate";
            this.tbInvoice_GelenKutusu_InvoicePeriod_EndDate.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_GelenKutusu_ASP_PartyIdentification1_schemeID
            // 
            this.tbInvoice_GelenKutusu_ASP_PartyIdentification1_schemeID.ColumnName = "ASP_PartyIdentification1_schemeID";
            // 
            // tbInvoice_GelenKutusu_ASP_PartyIdentification1_ID
            // 
            this.tbInvoice_GelenKutusu_ASP_PartyIdentification1_ID.ColumnName = "ASP_PartyIdentification1_ID";
            // 
            // tbInvoice_GelenKutusu_ASP_PartyIdentification2_schemeID
            // 
            this.tbInvoice_GelenKutusu_ASP_PartyIdentification2_schemeID.ColumnName = "ASP_PartyIdentification2_schemeID";
            // 
            // tbInvoice_GelenKutusu_ASP_PartyIdentification2_ID
            // 
            this.tbInvoice_GelenKutusu_ASP_PartyIdentification2_ID.ColumnName = "ASP_PartyIdentification2_ID";
            // 
            // tbInvoice_GelenKutusu_ASP_PartyIdentification3_schemeID
            // 
            this.tbInvoice_GelenKutusu_ASP_PartyIdentification3_schemeID.ColumnName = "ASP_PartyIdentification3_schemeID";
            // 
            // tbInvoice_GelenKutusu_ASP_PartyIdentification3_ID
            // 
            this.tbInvoice_GelenKutusu_ASP_PartyIdentification3_ID.ColumnName = "ASP_PartyIdentification3_ID";
            // 
            // tbInvoice_GelenKutusu_ASP_PartyIdentification4_schemeID
            // 
            this.tbInvoice_GelenKutusu_ASP_PartyIdentification4_schemeID.ColumnName = "ASP_PartyIdentification4_schemeID";
            // 
            // tbInvoice_GelenKutusu_ASP_PartyIdentification4_ID
            // 
            this.tbInvoice_GelenKutusu_ASP_PartyIdentification4_ID.ColumnName = "ASP_PartyIdentification4_ID";
            // 
            // tbInvoice_GelenKutusu_ASP_PartyIdentification5_schemeID
            // 
            this.tbInvoice_GelenKutusu_ASP_PartyIdentification5_schemeID.ColumnName = "ASP_PartyIdentification5_schemeID";
            // 
            // tbInvoice_GelenKutusu_ASP_PartyIdentification5_ID
            // 
            this.tbInvoice_GelenKutusu_ASP_PartyIdentification5_ID.ColumnName = "ASP_PartyIdentification5_ID";
            // 
            // tbInvoice_GelenKutusu_ASP_PartyName
            // 
            this.tbInvoice_GelenKutusu_ASP_PartyName.ColumnName = "ASP_PartyName";
            // 
            // tbInvoice_GelenKutusu_ASP_PostalAddress_StreetName
            // 
            this.tbInvoice_GelenKutusu_ASP_PostalAddress_StreetName.ColumnName = "ASP_PostalAddress_StreetName";
            // 
            // tbInvoice_GelenKutusu_ASP_PostalAddress_Room
            // 
            this.tbInvoice_GelenKutusu_ASP_PostalAddress_Room.ColumnName = "ASP_PostalAddress_Room";
            // 
            // tbInvoice_GelenKutusu_ASP_PostalAddress_BuildingNumber
            // 
            this.tbInvoice_GelenKutusu_ASP_PostalAddress_BuildingNumber.ColumnName = "ASP_PostalAddress_BuildingNumber";
            // 
            // tbInvoice_GelenKutusu_ASP_PostalAddress_BuildingName
            // 
            this.tbInvoice_GelenKutusu_ASP_PostalAddress_BuildingName.ColumnName = "ASP_PostalAddress_BuildingName";
            // 
            // tbInvoice_GelenKutusu_ASP_PostalAddress_CitySubdivisionName
            // 
            this.tbInvoice_GelenKutusu_ASP_PostalAddress_CitySubdivisionName.ColumnName = "ASP_PostalAddress_CitySubdivisionName";
            // 
            // tbInvoice_GelenKutusu_ASP_PostalAddress_CityName
            // 
            this.tbInvoice_GelenKutusu_ASP_PostalAddress_CityName.ColumnName = "ASP_PostalAddress_CityName";
            // 
            // tbInvoice_GelenKutusu_ASP_PostalAddress_Country
            // 
            this.tbInvoice_GelenKutusu_ASP_PostalAddress_Country.ColumnName = "ASP_PostalAddress_Country";
            // 
            // tbInvoice_GelenKutusu_ASP_PartyTaxSchemeName
            // 
            this.tbInvoice_GelenKutusu_ASP_PartyTaxSchemeName.ColumnName = "ASP_PartyTaxSchemeName";
            // 
            // tbInvoice_GelenKutusu_ASP_PartyTaxSchemeTaxTypeCode
            // 
            this.tbInvoice_GelenKutusu_ASP_PartyTaxSchemeTaxTypeCode.ColumnName = "ASP_PartyTaxSchemeTaxTypeCode";
            // 
            // tbInvoice_GelenKutusu_ASP_WebsiteURI
            // 
            this.tbInvoice_GelenKutusu_ASP_WebsiteURI.ColumnName = "ASP_WebsiteURI";
            // 
            // tbInvoice_GelenKutusu_ASP_Contact_Telephone
            // 
            this.tbInvoice_GelenKutusu_ASP_Contact_Telephone.ColumnName = "ASP_Contact_Telephone";
            // 
            // tbInvoice_GelenKutusu_ASP_Contact_Telefax
            // 
            this.tbInvoice_GelenKutusu_ASP_Contact_Telefax.ColumnName = "ASP_Contact_Telefax";
            // 
            // tbInvoice_GelenKutusu_ASP_Contact_ElectronicMail
            // 
            this.tbInvoice_GelenKutusu_ASP_Contact_ElectronicMail.ColumnName = "ASP_Contact_ElectronicMail";
            // 
            // tbInvoice_GelenKutusu_ASP_Person_FirstName
            // 
            this.tbInvoice_GelenKutusu_ASP_Person_FirstName.ColumnName = "ASP_Person_FirstName";
            // 
            // tbInvoice_GelenKutusu_ASP_Person_FamilyName
            // 
            this.tbInvoice_GelenKutusu_ASP_Person_FamilyName.ColumnName = "ASP_Person_FamilyName";
            // 
            // tbInvoice_GelenKutusu_ASP_Person_MiddleName
            // 
            this.tbInvoice_GelenKutusu_ASP_Person_MiddleName.ColumnName = "ASP_Person_MiddleName";
            // 
            // tbInvoice_GelenKutusu_ASP_Person_NameSuffix
            // 
            this.tbInvoice_GelenKutusu_ASP_Person_NameSuffix.ColumnName = "ASP_Person_NameSuffix";
            // 
            // tbInvoice_GelenKutusu_ASP_Person_Title
            // 
            this.tbInvoice_GelenKutusu_ASP_Person_Title.ColumnName = "ASP_Person_Title";
            // 
            // tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification1_schemeID
            // 
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification1_schemeID.ColumnName = "ASP_AgentParty_PartyIdentification1_schemeID";
            // 
            // tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification1_ID
            // 
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification1_ID.ColumnName = "ASP_AgentParty_PartyIdentification1_ID";
            // 
            // tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification2_schemeID
            // 
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification2_schemeID.ColumnName = "ASP_AgentParty_PartyIdentification2_schemeID";
            // 
            // tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification2_ID
            // 
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification2_ID.ColumnName = "ASP_AgentParty_PartyIdentification2_ID";
            // 
            // tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification3_schemeID
            // 
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification3_schemeID.ColumnName = "ASP_AgentParty_PartyIdentification3_schemeID";
            // 
            // tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification3_ID
            // 
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification3_ID.ColumnName = "ASP_AgentParty_PartyIdentification3_ID";
            // 
            // tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification4_schemeID
            // 
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification4_schemeID.ColumnName = "ASP_AgentParty_PartyIdentification4_schemeID";
            // 
            // tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification4_ID
            // 
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification4_ID.ColumnName = "ASP_AgentParty_PartyIdentification4_ID";
            // 
            // tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification5_schemeID
            // 
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification5_schemeID.ColumnName = "ASP_AgentParty_PartyIdentification5_schemeID";
            // 
            // tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification5_ID
            // 
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification5_ID.ColumnName = "ASP_AgentParty_PartyIdentification5_ID";
            // 
            // tbInvoice_GelenKutusu_ASP_AgentParty_PartyName
            // 
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyName.ColumnName = "ASP_AgentParty_PartyName";
            // 
            // tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_StreetName
            // 
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_StreetName.ColumnName = "ASP_AgentParty_PostalAddress_StreetName";
            // 
            // tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_Room
            // 
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_Room.ColumnName = "ASP_AgentParty_PostalAddress_Room";
            // 
            // tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_BuildingNumber
            // 
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_BuildingNumber.ColumnName = "ASP_AgentParty_PostalAddress_BuildingNumber";
            // 
            // tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_BuildingName
            // 
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_BuildingName.ColumnName = "ASP_AgentParty_PostalAddress_BuildingName";
            // 
            // tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_CitySubdivisionName
            // 
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_CitySubdivisionName.ColumnName = "ASP_AgentParty_PostalAddress_CitySubdivisionName";
            // 
            // tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_CityName
            // 
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_CityName.ColumnName = "ASP_AgentParty_PostalAddress_CityName";
            // 
            // tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_Country
            // 
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_Country.ColumnName = "ASP_AgentParty_PostalAddress_Country";
            // 
            // tbInvoice_GelenKutusu_ASP_AgentParty_PartyTaxSchemeName
            // 
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyTaxSchemeName.ColumnName = "ASP_AgentParty_PartyTaxSchemeName";
            // 
            // tbInvoice_GelenKutusu_ASP_AgentParty_PartyTaxSchemeTaxTypeCode
            // 
            this.tbInvoice_GelenKutusu_ASP_AgentParty_PartyTaxSchemeTaxTypeCode.ColumnName = "ASP_AgentParty_PartyTaxSchemeTaxTypeCode";
            // 
            // tbInvoice_GelenKutusu_ASP_AgentParty_WebsiteURI
            // 
            this.tbInvoice_GelenKutusu_ASP_AgentParty_WebsiteURI.ColumnName = "ASP_AgentParty_WebsiteURI";
            // 
            // tbInvoice_GelenKutusu_ASP_AgentParty_Contact_Telephone
            // 
            this.tbInvoice_GelenKutusu_ASP_AgentParty_Contact_Telephone.ColumnName = "ASP_AgentParty_Contact_Telephone";
            // 
            // tbInvoice_GelenKutusu_ASP_AgentParty_Contact_Telefax
            // 
            this.tbInvoice_GelenKutusu_ASP_AgentParty_Contact_Telefax.ColumnName = "ASP_AgentParty_Contact_Telefax";
            // 
            // tbInvoice_GelenKutusu_ASP_AgentParty_Contact_ElectronicMail
            // 
            this.tbInvoice_GelenKutusu_ASP_AgentParty_Contact_ElectronicMail.ColumnName = "ASP_AgentParty_Contact_ElectronicMail";
            // 
            // tbInvoice_GelenKutusu_ASP_AgentParty_Person_FirstName
            // 
            this.tbInvoice_GelenKutusu_ASP_AgentParty_Person_FirstName.ColumnName = "ASP_AgentParty_Person_FirstName";
            // 
            // tbInvoice_GelenKutusu_ASP_AgentParty_Person_FamilyName
            // 
            this.tbInvoice_GelenKutusu_ASP_AgentParty_Person_FamilyName.ColumnName = "ASP_AgentParty_Person_FamilyName";
            // 
            // tbInvoice_GelenKutusu_ASP_AgentParty_Person_MiddleName
            // 
            this.tbInvoice_GelenKutusu_ASP_AgentParty_Person_MiddleName.ColumnName = "ASP_AgentParty_Person_MiddleName";
            // 
            // tbInvoice_GelenKutusu_ASP_AgentParty_Person_NameSuffix
            // 
            this.tbInvoice_GelenKutusu_ASP_AgentParty_Person_NameSuffix.ColumnName = "ASP_AgentParty_Person_NameSuffix";
            // 
            // tbInvoice_GelenKutusu_ASP_AgentParty_Person_Title
            // 
            this.tbInvoice_GelenKutusu_ASP_AgentParty_Person_Title.ColumnName = "ASP_AgentParty_Person_Title";
            // 
            // tbInvoice_GelenKutusu_ACP_PartyIdentification1_schemeID
            // 
            this.tbInvoice_GelenKutusu_ACP_PartyIdentification1_schemeID.ColumnName = "ACP_PartyIdentification1_schemeID";
            // 
            // tbInvoice_GelenKutusu_ACP_PartyIdentification1_ID
            // 
            this.tbInvoice_GelenKutusu_ACP_PartyIdentification1_ID.ColumnName = "ACP_PartyIdentification1_ID";
            // 
            // tbInvoice_GelenKutusu_ACP_PartyIdentification2_schemeID
            // 
            this.tbInvoice_GelenKutusu_ACP_PartyIdentification2_schemeID.ColumnName = "ACP_PartyIdentification2_schemeID";
            // 
            // tbInvoice_GelenKutusu_ACP_PartyIdentification2_ID
            // 
            this.tbInvoice_GelenKutusu_ACP_PartyIdentification2_ID.ColumnName = "ACP_PartyIdentification2_ID";
            // 
            // tbInvoice_GelenKutusu_ACP_PartyIdentification3_schemeID
            // 
            this.tbInvoice_GelenKutusu_ACP_PartyIdentification3_schemeID.ColumnName = "ACP_PartyIdentification3_schemeID";
            // 
            // tbInvoice_GelenKutusu_ACP_PartyIdentification3_ID
            // 
            this.tbInvoice_GelenKutusu_ACP_PartyIdentification3_ID.ColumnName = "ACP_PartyIdentification3_ID";
            // 
            // tbInvoice_GelenKutusu_ACP_PartyIdentification4_schemeID
            // 
            this.tbInvoice_GelenKutusu_ACP_PartyIdentification4_schemeID.ColumnName = "ACP_PartyIdentification4_schemeID";
            // 
            // tbInvoice_GelenKutusu_ACP_PartyIdentification4_ID
            // 
            this.tbInvoice_GelenKutusu_ACP_PartyIdentification4_ID.ColumnName = "ACP_PartyIdentification4_ID";
            // 
            // tbInvoice_GelenKutusu_ACP_PartyIdentification5_schemeID
            // 
            this.tbInvoice_GelenKutusu_ACP_PartyIdentification5_schemeID.ColumnName = "ACP_PartyIdentification5_schemeID";
            // 
            // tbInvoice_GelenKutusu_ACP_PartyIdentification5_ID
            // 
            this.tbInvoice_GelenKutusu_ACP_PartyIdentification5_ID.ColumnName = "ACP_PartyIdentification5_ID";
            // 
            // tbInvoice_GelenKutusu_ACP_PartyName
            // 
            this.tbInvoice_GelenKutusu_ACP_PartyName.ColumnName = "ACP_PartyName";
            // 
            // tbInvoice_GelenKutusu_ACP_PostalAddress_StreetName
            // 
            this.tbInvoice_GelenKutusu_ACP_PostalAddress_StreetName.ColumnName = "ACP_PostalAddress_StreetName";
            // 
            // tbInvoice_GelenKutusu_ACP_PostalAddress_Room
            // 
            this.tbInvoice_GelenKutusu_ACP_PostalAddress_Room.ColumnName = "ACP_PostalAddress_Room";
            // 
            // tbInvoice_GelenKutusu_ACP_PostalAddress_BuildingNumber
            // 
            this.tbInvoice_GelenKutusu_ACP_PostalAddress_BuildingNumber.ColumnName = "ACP_PostalAddress_BuildingNumber";
            // 
            // tbInvoice_GelenKutusu_ACP_PostalAddress_BuildingName
            // 
            this.tbInvoice_GelenKutusu_ACP_PostalAddress_BuildingName.ColumnName = "ACP_PostalAddress_BuildingName";
            // 
            // tbInvoice_GelenKutusu_ACP_PostalAddress_CitySubdivisionName
            // 
            this.tbInvoice_GelenKutusu_ACP_PostalAddress_CitySubdivisionName.ColumnName = "ACP_PostalAddress_CitySubdivisionName";
            // 
            // tbInvoice_GelenKutusu_ACP_PostalAddress_CityName
            // 
            this.tbInvoice_GelenKutusu_ACP_PostalAddress_CityName.ColumnName = "ACP_PostalAddress_CityName";
            // 
            // tbInvoice_GelenKutusu_ACP_PostalAddress_Country
            // 
            this.tbInvoice_GelenKutusu_ACP_PostalAddress_Country.ColumnName = "ACP_PostalAddress_Country";
            // 
            // tbInvoice_GelenKutusu_ACP_PartyTaxSchemeName
            // 
            this.tbInvoice_GelenKutusu_ACP_PartyTaxSchemeName.ColumnName = "ACP_PartyTaxSchemeName";
            // 
            // tbInvoice_GelenKutusu_ACP_PartyTaxSchemeTaxTypeCode
            // 
            this.tbInvoice_GelenKutusu_ACP_PartyTaxSchemeTaxTypeCode.ColumnName = "ACP_PartyTaxSchemeTaxTypeCode";
            // 
            // tbInvoice_GelenKutusu_ACP_WebsiteURI
            // 
            this.tbInvoice_GelenKutusu_ACP_WebsiteURI.ColumnName = "ACP_WebsiteURI";
            // 
            // tbInvoice_GelenKutusu_ACP_Contact_Telephone
            // 
            this.tbInvoice_GelenKutusu_ACP_Contact_Telephone.ColumnName = "ACP_Contact_Telephone";
            // 
            // tbInvoice_GelenKutusu_ACP_Contact_Telefax
            // 
            this.tbInvoice_GelenKutusu_ACP_Contact_Telefax.ColumnName = "ACP_Contact_Telefax";
            // 
            // tbInvoice_GelenKutusu_ACP_Contact_ElectronicMail
            // 
            this.tbInvoice_GelenKutusu_ACP_Contact_ElectronicMail.ColumnName = "ACP_Contact_ElectronicMail";
            // 
            // tbInvoice_GelenKutusu_ACP_Person_FirstName
            // 
            this.tbInvoice_GelenKutusu_ACP_Person_FirstName.ColumnName = "ACP_Person_FirstName";
            // 
            // tbInvoice_GelenKutusu_ACP_Person_FamilyName
            // 
            this.tbInvoice_GelenKutusu_ACP_Person_FamilyName.ColumnName = "ACP_Person_FamilyName";
            // 
            // tbInvoice_GelenKutusu_ACP_Person_MiddleName
            // 
            this.tbInvoice_GelenKutusu_ACP_Person_MiddleName.ColumnName = "ACP_Person_MiddleName";
            // 
            // tbInvoice_GelenKutusu_ACP_Person_NameSuffix
            // 
            this.tbInvoice_GelenKutusu_ACP_Person_NameSuffix.ColumnName = "ACP_Person_NameSuffix";
            // 
            // tbInvoice_GelenKutusu_ACP_Person_Title
            // 
            this.tbInvoice_GelenKutusu_ACP_Person_Title.ColumnName = "ACP_Person_Title";
            // 
            // tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification1_schemeID
            // 
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification1_schemeID.ColumnName = "ACP_AgentParty_PartyIdentification1_schemeID";
            // 
            // tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification1_ID
            // 
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification1_ID.ColumnName = "ACP_AgentParty_PartyIdentification1_ID";
            // 
            // tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification2_schemeID
            // 
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification2_schemeID.ColumnName = "ACP_AgentParty_PartyIdentification2_schemeID";
            // 
            // tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification2_ID
            // 
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification2_ID.ColumnName = "ACP_AgentParty_PartyIdentification2_ID";
            // 
            // tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification3_schemeID
            // 
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification3_schemeID.ColumnName = "ACP_AgentParty_PartyIdentification3_schemeID";
            // 
            // tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification3_ID
            // 
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification3_ID.ColumnName = "ACP_AgentParty_PartyIdentification3_ID";
            // 
            // tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification4_schemeID
            // 
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification4_schemeID.ColumnName = "ACP_AgentParty_PartyIdentification4_schemeID";
            // 
            // tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification4_ID
            // 
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification4_ID.ColumnName = "ACP_AgentParty_PartyIdentification4_ID";
            // 
            // tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification5_schemeID
            // 
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification5_schemeID.ColumnName = "ACP_AgentParty_PartyIdentification5_schemeID";
            // 
            // tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification5_ID
            // 
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification5_ID.ColumnName = "ACP_AgentParty_PartyIdentification5_ID";
            // 
            // tbInvoice_GelenKutusu_ACP_AgentParty_PartyName
            // 
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyName.ColumnName = "ACP_AgentParty_PartyName";
            // 
            // tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_StreetName
            // 
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_StreetName.ColumnName = "ACP_AgentParty_PostalAddress_StreetName";
            // 
            // tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_Room
            // 
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_Room.ColumnName = "ACP_AgentParty_PostalAddress_Room";
            // 
            // tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_BuildingNumber
            // 
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_BuildingNumber.ColumnName = "ACP_AgentParty_PostalAddress_BuildingNumber";
            // 
            // tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_BuildingName
            // 
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_BuildingName.ColumnName = "ACP_AgentParty_PostalAddress_BuildingName";
            // 
            // tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_CitySubdivisionName
            // 
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_CitySubdivisionName.ColumnName = "ACP_AgentParty_PostalAddress_CitySubdivisionName";
            // 
            // tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_CityName
            // 
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_CityName.ColumnName = "ACP_AgentParty_PostalAddress_CityName";
            // 
            // tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_Country
            // 
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_Country.ColumnName = "ACP_AgentParty_PostalAddress_Country";
            // 
            // tbInvoice_GelenKutusu_ACP_AgentParty_PartyTaxSchemeName
            // 
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyTaxSchemeName.ColumnName = "ACP_AgentParty_PartyTaxSchemeName";
            // 
            // tbInvoice_GelenKutusu_ACP_AgentParty_PartyTaxSchemeTaxTypeCode
            // 
            this.tbInvoice_GelenKutusu_ACP_AgentParty_PartyTaxSchemeTaxTypeCode.ColumnName = "ACP_AgentParty_PartyTaxSchemeTaxTypeCode";
            // 
            // tbInvoice_GelenKutusu_ACP_AgentParty_WebsiteURI
            // 
            this.tbInvoice_GelenKutusu_ACP_AgentParty_WebsiteURI.ColumnName = "ACP_AgentParty_WebsiteURI";
            // 
            // tbInvoice_GelenKutusu_ACP_AgentParty_Contact_Telephone
            // 
            this.tbInvoice_GelenKutusu_ACP_AgentParty_Contact_Telephone.ColumnName = "ACP_AgentParty_Contact_Telephone";
            // 
            // tbInvoice_GelenKutusu_ACP_AgentParty_Contact_Telefax
            // 
            this.tbInvoice_GelenKutusu_ACP_AgentParty_Contact_Telefax.ColumnName = "ACP_AgentParty_Contact_Telefax";
            // 
            // tbInvoice_GelenKutusu_ACP_AgentParty_Contact_ElectronicMail
            // 
            this.tbInvoice_GelenKutusu_ACP_AgentParty_Contact_ElectronicMail.ColumnName = "ACP_AgentParty_Contact_ElectronicMail";
            // 
            // tbInvoice_GelenKutusu_ACP_AgentParty_Person_FirstName
            // 
            this.tbInvoice_GelenKutusu_ACP_AgentParty_Person_FirstName.ColumnName = "ACP_AgentParty_Person_FirstName";
            // 
            // tbInvoice_GelenKutusu_ACP_AgentParty_Person_FamilyName
            // 
            this.tbInvoice_GelenKutusu_ACP_AgentParty_Person_FamilyName.ColumnName = "ACP_AgentParty_Person_FamilyName";
            // 
            // tbInvoice_GelenKutusu_ACP_AgentParty_Person_MiddleName
            // 
            this.tbInvoice_GelenKutusu_ACP_AgentParty_Person_MiddleName.ColumnName = "ACP_AgentParty_Person_MiddleName";
            // 
            // tbInvoice_GelenKutusu_ACP_AgentParty_Person_NameSuffix
            // 
            this.tbInvoice_GelenKutusu_ACP_AgentParty_Person_NameSuffix.ColumnName = "ACP_AgentParty_Person_NameSuffix";
            // 
            // tbInvoice_GelenKutusu_ACP_AgentParty_Person_Title
            // 
            this.tbInvoice_GelenKutusu_ACP_AgentParty_Person_Title.ColumnName = "ACP_AgentParty_Person_Title";
            // 
            // tbInvoice_GelenKutusu_TaxExchangeRate_SourceCurrencyCode
            // 
            this.tbInvoice_GelenKutusu_TaxExchangeRate_SourceCurrencyCode.ColumnName = "TaxExchangeRate_SourceCurrencyCode";
            // 
            // tbInvoice_GelenKutusu_TaxExchangeRate_TargetCurrencyCode
            // 
            this.tbInvoice_GelenKutusu_TaxExchangeRate_TargetCurrencyCode.ColumnName = "TaxExchangeRate_TargetCurrencyCode";
            // 
            // tbInvoice_GelenKutusu_TaxExchangeRate_CalculationRate
            // 
            this.tbInvoice_GelenKutusu_TaxExchangeRate_CalculationRate.ColumnName = "TaxExchangeRate_CalculationRate";
            this.tbInvoice_GelenKutusu_TaxExchangeRate_CalculationRate.DataType = typeof(double);
            // 
            // tbInvoice_GelenKutusu_TaxExchangeRate_Date
            // 
            this.tbInvoice_GelenKutusu_TaxExchangeRate_Date.ColumnName = "TaxExchangeRate_Date";
            this.tbInvoice_GelenKutusu_TaxExchangeRate_Date.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_GelenKutusu_PricingExchangeRate_SourceCurrencyCode
            // 
            this.tbInvoice_GelenKutusu_PricingExchangeRate_SourceCurrencyCode.ColumnName = "PricingExchangeRate_SourceCurrencyCode";
            // 
            // tbInvoice_GelenKutusu_PricingExchangeRate_TargetCurrencyCode
            // 
            this.tbInvoice_GelenKutusu_PricingExchangeRate_TargetCurrencyCode.ColumnName = "PricingExchangeRate_TargetCurrencyCode";
            // 
            // tbInvoice_GelenKutusu_PricingExchangeRate_CalculationRate
            // 
            this.tbInvoice_GelenKutusu_PricingExchangeRate_CalculationRate.ColumnName = "PricingExchangeRate_CalculationRate";
            this.tbInvoice_GelenKutusu_PricingExchangeRate_CalculationRate.DataType = typeof(double);
            // 
            // tbInvoice_GelenKutusu_PricingExchangeRate_Date
            // 
            this.tbInvoice_GelenKutusu_PricingExchangeRate_Date.ColumnName = "PricingExchangeRate_Date";
            this.tbInvoice_GelenKutusu_PricingExchangeRate_Date.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_GelenKutusu_PaymentExchangeRate_SourceCurrencyCode
            // 
            this.tbInvoice_GelenKutusu_PaymentExchangeRate_SourceCurrencyCode.ColumnName = "PaymentExchangeRate_SourceCurrencyCode";
            // 
            // tbInvoice_GelenKutusu_PaymentExchangeRate_TargetCurrencyCode
            // 
            this.tbInvoice_GelenKutusu_PaymentExchangeRate_TargetCurrencyCode.ColumnName = "PaymentExchangeRate_TargetCurrencyCode";
            // 
            // tbInvoice_GelenKutusu_PaymentExchangeRate_CalculationRate
            // 
            this.tbInvoice_GelenKutusu_PaymentExchangeRate_CalculationRate.ColumnName = "PaymentExchangeRate_CalculationRate";
            this.tbInvoice_GelenKutusu_PaymentExchangeRate_CalculationRate.DataType = typeof(double);
            // 
            // tbInvoice_GelenKutusu_PaymentExchangeRate_Date
            // 
            this.tbInvoice_GelenKutusu_PaymentExchangeRate_Date.ColumnName = "PaymentExchangeRate_Date";
            this.tbInvoice_GelenKutusu_PaymentExchangeRate_Date.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_GelenKutusu_PaymentAlternativeExchangeRate_SourceCurrencyCode
            // 
            this.tbInvoice_GelenKutusu_PaymentAlternativeExchangeRate_SourceCurrencyCode.ColumnName = "PaymentAlternativeExchangeRate_SourceCurrencyCode";
            // 
            // tbInvoice_GelenKutusu_PaymentAlternativeExchangeRate_TargetCurrencyCode
            // 
            this.tbInvoice_GelenKutusu_PaymentAlternativeExchangeRate_TargetCurrencyCode.ColumnName = "PaymentAlternativeExchangeRate_TargetCurrencyCode";
            // 
            // tbInvoice_GelenKutusu_PaymentAlternativeExchangeRate_CalculationRate
            // 
            this.tbInvoice_GelenKutusu_PaymentAlternativeExchangeRate_CalculationRate.ColumnName = "PaymentAlternativeExchangeRate_CalculationRate";
            this.tbInvoice_GelenKutusu_PaymentAlternativeExchangeRate_CalculationRate.DataType = typeof(double);
            // 
            // tbInvoice_GelenKutusu_PaymentAlternativeExchangeRate_Date
            // 
            this.tbInvoice_GelenKutusu_PaymentAlternativeExchangeRate_Date.ColumnName = "PaymentAlternativeExchangeRate_Date";
            this.tbInvoice_GelenKutusu_PaymentAlternativeExchangeRate_Date.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_GelenKutusu_TaxAmount
            // 
            this.tbInvoice_GelenKutusu_TaxAmount.ColumnName = "TaxAmount";
            this.tbInvoice_GelenKutusu_TaxAmount.DataType = typeof(double);
            // 
            // tbInvoice_GelenKutusu_LegalMonetaryTotal_LineExtensionAmount
            // 
            this.tbInvoice_GelenKutusu_LegalMonetaryTotal_LineExtensionAmount.ColumnName = "LegalMonetaryTotal_LineExtensionAmount";
            this.tbInvoice_GelenKutusu_LegalMonetaryTotal_LineExtensionAmount.DataType = typeof(double);
            // 
            // tbInvoice_GelenKutusu_LegalMonetaryTotal_TaxExclusiveAmount
            // 
            this.tbInvoice_GelenKutusu_LegalMonetaryTotal_TaxExclusiveAmount.ColumnName = "LegalMonetaryTotal_TaxExclusiveAmount";
            this.tbInvoice_GelenKutusu_LegalMonetaryTotal_TaxExclusiveAmount.DataType = typeof(double);
            // 
            // tbInvoice_GelenKutusu_LegalMonetaryTotal_TaxInclusiveAmount
            // 
            this.tbInvoice_GelenKutusu_LegalMonetaryTotal_TaxInclusiveAmount.ColumnName = "LegalMonetaryTotal_TaxInclusiveAmount";
            this.tbInvoice_GelenKutusu_LegalMonetaryTotal_TaxInclusiveAmount.DataType = typeof(double);
            // 
            // tbInvoice_GelenKutusu_LegalMonetaryTotal_AllowanceTotalAmount
            // 
            this.tbInvoice_GelenKutusu_LegalMonetaryTotal_AllowanceTotalAmount.ColumnName = "LegalMonetaryTotal_AllowanceTotalAmount";
            this.tbInvoice_GelenKutusu_LegalMonetaryTotal_AllowanceTotalAmount.DataType = typeof(double);
            // 
            // tbInvoice_GelenKutusu_LegalMonetaryTotal_ChargeTotalAmount
            // 
            this.tbInvoice_GelenKutusu_LegalMonetaryTotal_ChargeTotalAmount.ColumnName = "LegalMonetaryTotal_ChargeTotalAmount";
            this.tbInvoice_GelenKutusu_LegalMonetaryTotal_ChargeTotalAmount.DataType = typeof(double);
            // 
            // tbInvoice_GelenKutusu_LegalMonetaryTotal_PayableRoundingAmount
            // 
            this.tbInvoice_GelenKutusu_LegalMonetaryTotal_PayableRoundingAmount.ColumnName = "LegalMonetaryTotal_PayableRoundingAmount";
            this.tbInvoice_GelenKutusu_LegalMonetaryTotal_PayableRoundingAmount.DataType = typeof(double);
            // 
            // tbInvoice_GelenKutusu_LegalMonetaryTotal_PayableAmount
            // 
            this.tbInvoice_GelenKutusu_LegalMonetaryTotal_PayableAmount.ColumnName = "LegalMonetaryTotal_PayableAmount";
            this.tbInvoice_GelenKutusu_LegalMonetaryTotal_PayableAmount.DataType = typeof(double);
            // 
            // tbInvoice_GelenKutusu_WithholdingTaxAmount
            // 
            this.tbInvoice_GelenKutusu_WithholdingTaxAmount.ColumnName = "WithholdingTaxAmount";
            this.tbInvoice_GelenKutusu_WithholdingTaxAmount.DataType = typeof(double);
            // 
            // sqlCommand5
            // 
            this.sqlCommand5.CommandText = "SELECT * FROM Invoice WHERE Deleted = 0 AND IOType=1\r\nAND IssueDate BETWEEN @Form" +
    "Date1 AND @FormDate2 ";
            this.sqlCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FormDate1", System.Data.SqlDbType.DateTime),
            new System.Data.SqlClient.SqlParameter("@FormDate2", System.Data.SqlDbType.DateTime)});
            // 
            // grGelenKutusuView
            // 
            this.grGelenKutusuView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInvoiceID,
            this.colIntegratorID,
            this.colIOType,
            this.colCreatedBy,
            this.colCreatedDate,
            this.colModifiedBy,
            this.colModifiedDate,
            this.colLocalStatus,
            this.colStatus,
            this.colStatusDescription,
            this.colPostBox,
            this.colProfileID,
            this.colID,
            this.colIssueDate,
            this.colIssueTime,
            this.colInvoiceTypeCode,
            this.colDocumentCurrencyCode,
            this.colTaxCurrencyCode,
            this.colPricingCurrencyCode,
            this.colPaymentCurrencyCode,
            this.colPaymentAlternativeCurrencyCode,
            this.colLineCountNumeric,
            this.colInvoicePeriod_StartDate,
            this.colInvoicePeriod_EndDate,
            this.colInvoicePeriod_DurationMeasure,
            this.colInvoicePeriod_Description,
            this.colASP_PartyIdentification1_schemeID,
            this.colASP_PartyIdentification1_ID,
            this.colASP_PartyIdentification2_schemeID,
            this.colASP_PartyIdentification2_ID,
            this.colASP_PartyIdentification3_schemeID,
            this.colASP_PartyIdentification3_ID,
            this.colASP_PartyIdentification4_schemeID,
            this.colASP_PartyIdentification4_ID,
            this.colASP_PartyIdentification5_schemeID,
            this.colASP_PartyIdentification5_ID,
            this.colASP_PartyName,
            this.colASP_PostalAddress_StreetName,
            this.colASP_PostalAddress_Room,
            this.colASP_PostalAddress_BuildingNumber,
            this.colASP_PostalAddress_CitySubdivisionName,
            this.colASP_PostalAddress_CityName,
            this.colASP_PostalAddress_Country,
            this.colASP_PartyTaxScheme,
            this.colASP_Contact_Telephone,
            this.colASP_Contact_Telefax,
            this.colASP_Contact_ElectronicMail,
            this.colASP_Person_FirstName,
            this.colASP_Person_FamilyName,
            this.colASP_AgentParty_PartyIdentification1_schemeID,
            this.colASP_AgentParty_PartyIdentification1_ID,
            this.colASP_AgentParty_PartyIdentification2_schemeID,
            this.colASP_AgentParty_PartyIdentification2_ID,
            this.colASP_AgentParty_PartyIdentification3_schemeID,
            this.colASP_AgentParty_PartyIdentification3_ID,
            this.colASP_AgentParty_PartyIdentification4_schemeID,
            this.colASP_AgentParty_PartyIdentification4_ID,
            this.colASP_AgentParty_PartyIdentification5_schemeID,
            this.colASP_AgentParty_PartyIdentification5_ID,
            this.colASP_AgentParty_PartyName,
            this.colASP_AgentParty_PostalAddress_StreetName,
            this.colASP_AgentParty_PostalAddress_Room,
            this.colASP_AgentParty_PostalAddress_BuildingNumber,
            this.colASP_AgentParty_PostalAddress_CitySubdivisionName,
            this.colASP_AgentParty_PostalAddress_CityName,
            this.colASP_AgentParty_PostalAddress_Country,
            this.colASP_AgentParty_PartyTaxScheme,
            this.colASP_AgentParty_Contact_Telephone,
            this.colASP_AgentParty_Contact_Telefax,
            this.colASP_AgentParty_Contact_ElectronicMail,
            this.colACP_PartyIdentification1_schemeID,
            this.colACP_PartyIdentification1_ID,
            this.colACP_PartyIdentification2_schemeID,
            this.colACP_PartyIdentification2_ID,
            this.colACP_PartyIdentification3_schemeID,
            this.colACP_PartyIdentification3_ID,
            this.colACP_PartyIdentification4_schemeID,
            this.colACP_PartyIdentification4_ID,
            this.colACP_PartyIdentification5_schemeID,
            this.colACP_PartyIdentification5_ID,
            this.colACP_PartyName,
            this.colACP_PostalAddress_StreetName,
            this.colACP_PostalAddress_Room,
            this.colACP_PostalAddress_BuildingNumber,
            this.colACP_PostalAddress_CitySubdivisionName,
            this.colACP_PostalAddress_CityName,
            this.colACP_PostalAddress_Country,
            this.colACP_PartyTaxScheme,
            this.colACP_Contact_Telephone,
            this.colACP_Contact_Telefax,
            this.colACP_Contact_ElectronicMail,
            this.colACP_Person_FirstName,
            this.colACP_Person_FamilyName,
            this.colACP_AgentParty_PartyIdentification1_schemeID,
            this.colACP_AgentParty_PartyIdentification1_ID,
            this.colACP_AgentParty_PartyIdentification2_schemeID,
            this.colACP_AgentParty_PartyIdentification2_ID,
            this.colACP_AgentParty_PartyIdentification3_schemeID,
            this.colACP_AgentParty_PartyIdentification3_ID,
            this.colACP_AgentParty_PartyIdentification4_schemeID,
            this.colACP_AgentParty_PartyIdentification4_ID,
            this.colACP_AgentParty_PartyIdentification5_schemeID,
            this.colACP_AgentParty_PartyIdentification5_ID,
            this.colACP_AgentParty_PartyName,
            this.colACP_AgentParty_PostalAddress_StreetName,
            this.colACP_AgentParty_PostalAddress_Room,
            this.colACP_AgentParty_PostalAddress_BuildingNumber,
            this.colACP_AgentParty_PostalAddress_CitySubdivisionName,
            this.colACP_AgentParty_PostalAddress_CityName,
            this.colACP_AgentParty_PostalAddress_Country,
            this.colACP_AgentParty_PartyTaxScheme,
            this.colACP_AgentParty_Contact_Telephone,
            this.colACP_AgentParty_Contact_Telefax,
            this.colACP_AgentParty_Contact_ElectronicMail,
            this.colTaxExchangeRate_SourceCurrencyCode,
            this.colTaxExchangeRate_TargetCurrencyCode,
            this.colTaxExchangeRate_CalculationRate,
            this.colTaxExchangeRate_Date,
            this.colPricingExchangeRate_SourceCurrencyCode,
            this.colPricingExchangeRate_TargetCurrencyCode,
            this.colPricingExchangeRate_CalculationRate,
            this.colPricingExchangeRate_Date,
            this.colPaymentExchangeRate_SourceCurrencyCode,
            this.colPaymentExchangeRate_TargetCurrencyCode,
            this.colPaymentExchangeRate_CalculationRate,
            this.colPaymentExchangeRate_Date,
            this.colPaymentAlternativeExchangeRate_SourceCurrencyCode,
            this.colPaymentAlternativeExchangeRate_TargetCurrencyCode,
            this.colPaymentAlternativeExchangeRate_CalculationRate,
            this.colPaymentAlternativeExchangeRate_Date,
            this.colTaxAmount,
            this.colUUID,
            this.colLegalMonetaryTotal_LineExtensionAmount,
            this.colLegalMonetaryTotal_TaxExclusiveAmount,
            this.colLegalMonetaryTotal_TaxInclusiveAmount,
            this.colLegalMonetaryTotal_AllowanceTotal,
            this.colLegalMonetaryTotal_ChargeTotalAmount,
            this.colLegalMonetaryTotal_PayableRoundingAmount,
            this.colLegalMonetaryTotal_PayableAmount,
            this.colIntCode});
            styleFormatCondition6.Appearance.ForeColor = System.Drawing.Color.Blue;
            styleFormatCondition6.Appearance.Options.UseForeColor = true;
            styleFormatCondition6.ApplyToRow = true;
            styleFormatCondition6.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition6.Expression = "[Status] == 5";
            styleFormatCondition7.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition7.Appearance.Options.UseForeColor = true;
            styleFormatCondition7.ApplyToRow = true;
            styleFormatCondition7.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition7.Expression = "[Status] == 7";
            this.grGelenKutusuView.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition6,
            styleFormatCondition7});
            this.grGelenKutusuView.GridControl = this.grGelenKutusu;
            this.grGelenKutusuView.Name = "grGelenKutusuView";
            this.grGelenKutusuView.OptionsBehavior.Editable = false;
            this.grGelenKutusuView.OptionsLayout.LayoutVersion = "1.2";
            this.grGelenKutusuView.OptionsSelection.MultiSelect = true;
            this.grGelenKutusuView.OptionsView.ColumnAutoWidth = false;
            this.grGelenKutusuView.OptionsView.ShowAutoFilterRow = true;
            this.grGelenKutusuView.OptionsView.ShowFooter = true;
            // 
            // colInvoiceID
            // 
            this.colInvoiceID.FieldName = "InvoiceID";
            this.colInvoiceID.Name = "colInvoiceID";
            // 
            // colIntegratorID
            // 
            this.colIntegratorID.FieldName = "IntegratorID";
            this.colIntegratorID.Name = "colIntegratorID";
            this.colIntegratorID.Width = 159;
            // 
            // colIOType
            // 
            this.colIOType.FieldName = "IOType";
            this.colIOType.Name = "colIOType";
            this.colIOType.Width = 81;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.FieldName = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.FieldName = "CreatedDate";
            this.colCreatedDate.Name = "colCreatedDate";
            // 
            // colModifiedBy
            // 
            this.colModifiedBy.FieldName = "ModifiedBy";
            this.colModifiedBy.Name = "colModifiedBy";
            // 
            // colModifiedDate
            // 
            this.colModifiedDate.FieldName = "ModifiedDate";
            this.colModifiedDate.Name = "colModifiedDate";
            // 
            // colLocalStatus
            // 
            this.colLocalStatus.FieldName = "LocalStatus";
            this.colLocalStatus.Name = "colLocalStatus";
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Durum";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Width = 64;
            // 
            // colStatusDescription
            // 
            this.colStatusDescription.Caption = "Durum aciklama";
            this.colStatusDescription.FieldName = "StatusDescription";
            this.colStatusDescription.Name = "colStatusDescription";
            this.colStatusDescription.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "StatusDescription", "{0}")});
            this.colStatusDescription.Visible = true;
            this.colStatusDescription.VisibleIndex = 2;
            this.colStatusDescription.Width = 159;
            // 
            // colPostBox
            // 
            this.colPostBox.Caption = "Posta kutusu";
            this.colPostBox.FieldName = "PostBox";
            this.colPostBox.Name = "colPostBox";
            this.colPostBox.Width = 142;
            // 
            // colProfileID
            // 
            this.colProfileID.Caption = "Senaryo";
            this.colProfileID.FieldName = "ProfileID";
            this.colProfileID.Name = "colProfileID";
            this.colProfileID.Visible = true;
            this.colProfileID.VisibleIndex = 3;
            this.colProfileID.Width = 107;
            // 
            // colID
            // 
            this.colID.Caption = "ID (Fatura no)";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 4;
            this.colID.Width = 166;
            // 
            // colIssueDate
            // 
            this.colIssueDate.Caption = "Fatura tarihi";
            this.colIssueDate.DisplayFormat.FormatString = "dd.MM.yyyy";
            this.colIssueDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colIssueDate.FieldName = "IssueDate";
            this.colIssueDate.Name = "colIssueDate";
            this.colIssueDate.Visible = true;
            this.colIssueDate.VisibleIndex = 5;
            // 
            // colIssueTime
            // 
            this.colIssueTime.Caption = "Saati";
            this.colIssueTime.DisplayFormat.FormatString = "HH:mm";
            this.colIssueTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colIssueTime.FieldName = "IssueTime";
            this.colIssueTime.Name = "colIssueTime";
            this.colIssueTime.Visible = true;
            this.colIssueTime.VisibleIndex = 17;
            // 
            // colInvoiceTypeCode
            // 
            this.colInvoiceTypeCode.Caption = "Türü";
            this.colInvoiceTypeCode.FieldName = "InvoiceTypeCode";
            this.colInvoiceTypeCode.Name = "colInvoiceTypeCode";
            this.colInvoiceTypeCode.Visible = true;
            this.colInvoiceTypeCode.VisibleIndex = 6;
            // 
            // colDocumentCurrencyCode
            // 
            this.colDocumentCurrencyCode.Caption = "Para birimi";
            this.colDocumentCurrencyCode.FieldName = "DocumentCurrencyCode";
            this.colDocumentCurrencyCode.Name = "colDocumentCurrencyCode";
            this.colDocumentCurrencyCode.Visible = true;
            this.colDocumentCurrencyCode.VisibleIndex = 7;
            // 
            // colTaxCurrencyCode
            // 
            this.colTaxCurrencyCode.FieldName = "TaxCurrencyCode";
            this.colTaxCurrencyCode.Name = "colTaxCurrencyCode";
            // 
            // colPricingCurrencyCode
            // 
            this.colPricingCurrencyCode.FieldName = "PricingCurrencyCode";
            this.colPricingCurrencyCode.Name = "colPricingCurrencyCode";
            // 
            // colPaymentCurrencyCode
            // 
            this.colPaymentCurrencyCode.FieldName = "PaymentCurrencyCode";
            this.colPaymentCurrencyCode.Name = "colPaymentCurrencyCode";
            // 
            // colPaymentAlternativeCurrencyCode
            // 
            this.colPaymentAlternativeCurrencyCode.FieldName = "PaymentAlternativeCurrencyCode";
            this.colPaymentAlternativeCurrencyCode.Name = "colPaymentAlternativeCurrencyCode";
            // 
            // colLineCountNumeric
            // 
            this.colLineCountNumeric.Caption = "#Satır";
            this.colLineCountNumeric.FieldName = "LineCountNumeric";
            this.colLineCountNumeric.Name = "colLineCountNumeric";
            this.colLineCountNumeric.Visible = true;
            this.colLineCountNumeric.VisibleIndex = 8;
            this.colLineCountNumeric.Width = 93;
            // 
            // colInvoicePeriod_StartDate
            // 
            this.colInvoicePeriod_StartDate.FieldName = "InvoicePeriod_StartDate";
            this.colInvoicePeriod_StartDate.Name = "colInvoicePeriod_StartDate";
            // 
            // colInvoicePeriod_EndDate
            // 
            this.colInvoicePeriod_EndDate.FieldName = "InvoicePeriod_EndDate";
            this.colInvoicePeriod_EndDate.Name = "colInvoicePeriod_EndDate";
            // 
            // colInvoicePeriod_DurationMeasure
            // 
            this.colInvoicePeriod_DurationMeasure.FieldName = "InvoicePeriod_DurationMeasure";
            this.colInvoicePeriod_DurationMeasure.Name = "colInvoicePeriod_DurationMeasure";
            // 
            // colInvoicePeriod_Description
            // 
            this.colInvoicePeriod_Description.FieldName = "InvoicePeriod_Description";
            this.colInvoicePeriod_Description.Name = "colInvoicePeriod_Description";
            // 
            // colASP_PartyIdentification1_schemeID
            // 
            this.colASP_PartyIdentification1_schemeID.Caption = "Tedarikci VKTuru";
            this.colASP_PartyIdentification1_schemeID.FieldName = "ASP_PartyIdentification1_schemeID";
            this.colASP_PartyIdentification1_schemeID.Name = "colASP_PartyIdentification1_schemeID";
            this.colASP_PartyIdentification1_schemeID.Visible = true;
            this.colASP_PartyIdentification1_schemeID.VisibleIndex = 21;
            this.colASP_PartyIdentification1_schemeID.Width = 109;
            // 
            // colASP_PartyIdentification1_ID
            // 
            this.colASP_PartyIdentification1_ID.Caption = "Tedarikci  Vergi No";
            this.colASP_PartyIdentification1_ID.FieldName = "ASP_PartyIdentification1_ID";
            this.colASP_PartyIdentification1_ID.Name = "colASP_PartyIdentification1_ID";
            this.colASP_PartyIdentification1_ID.Visible = true;
            this.colASP_PartyIdentification1_ID.VisibleIndex = 22;
            this.colASP_PartyIdentification1_ID.Width = 126;
            // 
            // colASP_PartyIdentification2_schemeID
            // 
            this.colASP_PartyIdentification2_schemeID.FieldName = "ASP_PartyIdentification2_schemeID";
            this.colASP_PartyIdentification2_schemeID.Name = "colASP_PartyIdentification2_schemeID";
            // 
            // colASP_PartyIdentification2_ID
            // 
            this.colASP_PartyIdentification2_ID.FieldName = "ASP_PartyIdentification2_ID";
            this.colASP_PartyIdentification2_ID.Name = "colASP_PartyIdentification2_ID";
            // 
            // colASP_PartyIdentification3_schemeID
            // 
            this.colASP_PartyIdentification3_schemeID.FieldName = "ASP_PartyIdentification3_schemeID";
            this.colASP_PartyIdentification3_schemeID.Name = "colASP_PartyIdentification3_schemeID";
            // 
            // colASP_PartyIdentification3_ID
            // 
            this.colASP_PartyIdentification3_ID.FieldName = "ASP_PartyIdentification3_ID";
            this.colASP_PartyIdentification3_ID.Name = "colASP_PartyIdentification3_ID";
            // 
            // colASP_PartyIdentification4_schemeID
            // 
            this.colASP_PartyIdentification4_schemeID.FieldName = "ASP_PartyIdentification4_schemeID";
            this.colASP_PartyIdentification4_schemeID.Name = "colASP_PartyIdentification4_schemeID";
            // 
            // colASP_PartyIdentification4_ID
            // 
            this.colASP_PartyIdentification4_ID.FieldName = "ASP_PartyIdentification4_ID";
            this.colASP_PartyIdentification4_ID.Name = "colASP_PartyIdentification4_ID";
            // 
            // colASP_PartyIdentification5_schemeID
            // 
            this.colASP_PartyIdentification5_schemeID.FieldName = "ASP_PartyIdentification5_schemeID";
            this.colASP_PartyIdentification5_schemeID.Name = "colASP_PartyIdentification5_schemeID";
            // 
            // colASP_PartyIdentification5_ID
            // 
            this.colASP_PartyIdentification5_ID.FieldName = "ASP_PartyIdentification5_ID";
            this.colASP_PartyIdentification5_ID.Name = "colASP_PartyIdentification5_ID";
            // 
            // colASP_PartyName
            // 
            this.colASP_PartyName.Caption = "Tedarikçi ünvan";
            this.colASP_PartyName.FieldName = "ASP_PartyName";
            this.colASP_PartyName.Name = "colASP_PartyName";
            this.colASP_PartyName.Visible = true;
            this.colASP_PartyName.VisibleIndex = 0;
            this.colASP_PartyName.Width = 119;
            // 
            // colASP_PostalAddress_StreetName
            // 
            this.colASP_PostalAddress_StreetName.FieldName = "ASP_PostalAddress_StreetName";
            this.colASP_PostalAddress_StreetName.Name = "colASP_PostalAddress_StreetName";
            // 
            // colASP_PostalAddress_Room
            // 
            this.colASP_PostalAddress_Room.FieldName = "ASP_PostalAddress_Room";
            this.colASP_PostalAddress_Room.Name = "colASP_PostalAddress_Room";
            // 
            // colASP_PostalAddress_BuildingNumber
            // 
            this.colASP_PostalAddress_BuildingNumber.FieldName = "ASP_PostalAddress_BuildingNumber";
            this.colASP_PostalAddress_BuildingNumber.Name = "colASP_PostalAddress_BuildingNumber";
            // 
            // colASP_PostalAddress_CitySubdivisionName
            // 
            this.colASP_PostalAddress_CitySubdivisionName.FieldName = "ASP_PostalAddress_CitySubdivisionName";
            this.colASP_PostalAddress_CitySubdivisionName.Name = "colASP_PostalAddress_CitySubdivisionName";
            // 
            // colASP_PostalAddress_CityName
            // 
            this.colASP_PostalAddress_CityName.FieldName = "ASP_PostalAddress_CityName";
            this.colASP_PostalAddress_CityName.Name = "colASP_PostalAddress_CityName";
            // 
            // colASP_PostalAddress_Country
            // 
            this.colASP_PostalAddress_Country.FieldName = "ASP_PostalAddress_Country";
            this.colASP_PostalAddress_Country.Name = "colASP_PostalAddress_Country";
            // 
            // colASP_PartyTaxScheme
            // 
            this.colASP_PartyTaxScheme.Caption = "Tedarikci Vergi D.";
            this.colASP_PartyTaxScheme.FieldName = "ASP_PartyTaxScheme";
            this.colASP_PartyTaxScheme.Name = "colASP_PartyTaxScheme";
            this.colASP_PartyTaxScheme.Visible = true;
            this.colASP_PartyTaxScheme.VisibleIndex = 23;
            this.colASP_PartyTaxScheme.Width = 114;
            // 
            // colASP_Contact_Telephone
            // 
            this.colASP_Contact_Telephone.FieldName = "ASP_Contact_Telephone";
            this.colASP_Contact_Telephone.Name = "colASP_Contact_Telephone";
            // 
            // colASP_Contact_Telefax
            // 
            this.colASP_Contact_Telefax.FieldName = "ASP_Contact_Telefax";
            this.colASP_Contact_Telefax.Name = "colASP_Contact_Telefax";
            // 
            // colASP_Contact_ElectronicMail
            // 
            this.colASP_Contact_ElectronicMail.FieldName = "ASP_Contact_ElectronicMail";
            this.colASP_Contact_ElectronicMail.Name = "colASP_Contact_ElectronicMail";
            // 
            // colASP_Person_FirstName
            // 
            this.colASP_Person_FirstName.FieldName = "ASP_Person_FirstName";
            this.colASP_Person_FirstName.Name = "colASP_Person_FirstName";
            // 
            // colASP_Person_FamilyName
            // 
            this.colASP_Person_FamilyName.FieldName = "ASP_Person_FamilyName";
            this.colASP_Person_FamilyName.Name = "colASP_Person_FamilyName";
            // 
            // colASP_AgentParty_PartyIdentification1_schemeID
            // 
            this.colASP_AgentParty_PartyIdentification1_schemeID.FieldName = "ASP_AgentParty_PartyIdentification1_schemeID";
            this.colASP_AgentParty_PartyIdentification1_schemeID.Name = "colASP_AgentParty_PartyIdentification1_schemeID";
            // 
            // colASP_AgentParty_PartyIdentification1_ID
            // 
            this.colASP_AgentParty_PartyIdentification1_ID.FieldName = "ASP_AgentParty_PartyIdentification1_ID";
            this.colASP_AgentParty_PartyIdentification1_ID.Name = "colASP_AgentParty_PartyIdentification1_ID";
            // 
            // colASP_AgentParty_PartyIdentification2_schemeID
            // 
            this.colASP_AgentParty_PartyIdentification2_schemeID.FieldName = "ASP_AgentParty_PartyIdentification2_schemeID";
            this.colASP_AgentParty_PartyIdentification2_schemeID.Name = "colASP_AgentParty_PartyIdentification2_schemeID";
            // 
            // colASP_AgentParty_PartyIdentification2_ID
            // 
            this.colASP_AgentParty_PartyIdentification2_ID.FieldName = "ASP_AgentParty_PartyIdentification2_ID";
            this.colASP_AgentParty_PartyIdentification2_ID.Name = "colASP_AgentParty_PartyIdentification2_ID";
            // 
            // colASP_AgentParty_PartyIdentification3_schemeID
            // 
            this.colASP_AgentParty_PartyIdentification3_schemeID.FieldName = "ASP_AgentParty_PartyIdentification3_schemeID";
            this.colASP_AgentParty_PartyIdentification3_schemeID.Name = "colASP_AgentParty_PartyIdentification3_schemeID";
            // 
            // colASP_AgentParty_PartyIdentification3_ID
            // 
            this.colASP_AgentParty_PartyIdentification3_ID.FieldName = "ASP_AgentParty_PartyIdentification3_ID";
            this.colASP_AgentParty_PartyIdentification3_ID.Name = "colASP_AgentParty_PartyIdentification3_ID";
            // 
            // colASP_AgentParty_PartyIdentification4_schemeID
            // 
            this.colASP_AgentParty_PartyIdentification4_schemeID.FieldName = "ASP_AgentParty_PartyIdentification4_schemeID";
            this.colASP_AgentParty_PartyIdentification4_schemeID.Name = "colASP_AgentParty_PartyIdentification4_schemeID";
            // 
            // colASP_AgentParty_PartyIdentification4_ID
            // 
            this.colASP_AgentParty_PartyIdentification4_ID.FieldName = "ASP_AgentParty_PartyIdentification4_ID";
            this.colASP_AgentParty_PartyIdentification4_ID.Name = "colASP_AgentParty_PartyIdentification4_ID";
            // 
            // colASP_AgentParty_PartyIdentification5_schemeID
            // 
            this.colASP_AgentParty_PartyIdentification5_schemeID.FieldName = "ASP_AgentParty_PartyIdentification5_schemeID";
            this.colASP_AgentParty_PartyIdentification5_schemeID.Name = "colASP_AgentParty_PartyIdentification5_schemeID";
            // 
            // colASP_AgentParty_PartyIdentification5_ID
            // 
            this.colASP_AgentParty_PartyIdentification5_ID.FieldName = "ASP_AgentParty_PartyIdentification5_ID";
            this.colASP_AgentParty_PartyIdentification5_ID.Name = "colASP_AgentParty_PartyIdentification5_ID";
            // 
            // colASP_AgentParty_PartyName
            // 
            this.colASP_AgentParty_PartyName.FieldName = "ASP_AgentParty_PartyName";
            this.colASP_AgentParty_PartyName.Name = "colASP_AgentParty_PartyName";
            // 
            // colASP_AgentParty_PostalAddress_StreetName
            // 
            this.colASP_AgentParty_PostalAddress_StreetName.FieldName = "ASP_AgentParty_PostalAddress_StreetName";
            this.colASP_AgentParty_PostalAddress_StreetName.Name = "colASP_AgentParty_PostalAddress_StreetName";
            // 
            // colASP_AgentParty_PostalAddress_Room
            // 
            this.colASP_AgentParty_PostalAddress_Room.FieldName = "ASP_AgentParty_PostalAddress_Room";
            this.colASP_AgentParty_PostalAddress_Room.Name = "colASP_AgentParty_PostalAddress_Room";
            // 
            // colASP_AgentParty_PostalAddress_BuildingNumber
            // 
            this.colASP_AgentParty_PostalAddress_BuildingNumber.FieldName = "ASP_AgentParty_PostalAddress_BuildingNumber";
            this.colASP_AgentParty_PostalAddress_BuildingNumber.Name = "colASP_AgentParty_PostalAddress_BuildingNumber";
            // 
            // colASP_AgentParty_PostalAddress_CitySubdivisionName
            // 
            this.colASP_AgentParty_PostalAddress_CitySubdivisionName.FieldName = "ASP_AgentParty_PostalAddress_CitySubdivisionName";
            this.colASP_AgentParty_PostalAddress_CitySubdivisionName.Name = "colASP_AgentParty_PostalAddress_CitySubdivisionName";
            // 
            // colASP_AgentParty_PostalAddress_CityName
            // 
            this.colASP_AgentParty_PostalAddress_CityName.FieldName = "ASP_AgentParty_PostalAddress_CityName";
            this.colASP_AgentParty_PostalAddress_CityName.Name = "colASP_AgentParty_PostalAddress_CityName";
            // 
            // colASP_AgentParty_PostalAddress_Country
            // 
            this.colASP_AgentParty_PostalAddress_Country.FieldName = "ASP_AgentParty_PostalAddress_Country";
            this.colASP_AgentParty_PostalAddress_Country.Name = "colASP_AgentParty_PostalAddress_Country";
            // 
            // colASP_AgentParty_PartyTaxScheme
            // 
            this.colASP_AgentParty_PartyTaxScheme.FieldName = "ASP_AgentParty_PartyTaxScheme";
            this.colASP_AgentParty_PartyTaxScheme.Name = "colASP_AgentParty_PartyTaxScheme";
            // 
            // colASP_AgentParty_Contact_Telephone
            // 
            this.colASP_AgentParty_Contact_Telephone.FieldName = "ASP_AgentParty_Contact_Telephone";
            this.colASP_AgentParty_Contact_Telephone.Name = "colASP_AgentParty_Contact_Telephone";
            // 
            // colASP_AgentParty_Contact_Telefax
            // 
            this.colASP_AgentParty_Contact_Telefax.FieldName = "ASP_AgentParty_Contact_Telefax";
            this.colASP_AgentParty_Contact_Telefax.Name = "colASP_AgentParty_Contact_Telefax";
            // 
            // colASP_AgentParty_Contact_ElectronicMail
            // 
            this.colASP_AgentParty_Contact_ElectronicMail.FieldName = "ASP_AgentParty_Contact_ElectronicMail";
            this.colASP_AgentParty_Contact_ElectronicMail.Name = "colASP_AgentParty_Contact_ElectronicMail";
            // 
            // colACP_PartyIdentification1_schemeID
            // 
            this.colACP_PartyIdentification1_schemeID.Caption = "Musteri VKTuru";
            this.colACP_PartyIdentification1_schemeID.FieldName = "ACP_PartyIdentification1_schemeID";
            this.colACP_PartyIdentification1_schemeID.Name = "colACP_PartyIdentification1_schemeID";
            this.colACP_PartyIdentification1_schemeID.Visible = true;
            this.colACP_PartyIdentification1_schemeID.VisibleIndex = 19;
            this.colACP_PartyIdentification1_schemeID.Width = 101;
            // 
            // colACP_PartyIdentification1_ID
            // 
            this.colACP_PartyIdentification1_ID.Caption = "Musteri Vergi No";
            this.colACP_PartyIdentification1_ID.FieldName = "ACP_PartyIdentification1_ID";
            this.colACP_PartyIdentification1_ID.Name = "colACP_PartyIdentification1_ID";
            this.colACP_PartyIdentification1_ID.Visible = true;
            this.colACP_PartyIdentification1_ID.VisibleIndex = 20;
            this.colACP_PartyIdentification1_ID.Width = 114;
            // 
            // colACP_PartyIdentification2_schemeID
            // 
            this.colACP_PartyIdentification2_schemeID.FieldName = "ACP_PartyIdentification2_schemeID";
            this.colACP_PartyIdentification2_schemeID.Name = "colACP_PartyIdentification2_schemeID";
            // 
            // colACP_PartyIdentification2_ID
            // 
            this.colACP_PartyIdentification2_ID.FieldName = "ACP_PartyIdentification2_ID";
            this.colACP_PartyIdentification2_ID.Name = "colACP_PartyIdentification2_ID";
            // 
            // colACP_PartyIdentification3_schemeID
            // 
            this.colACP_PartyIdentification3_schemeID.FieldName = "ACP_PartyIdentification3_schemeID";
            this.colACP_PartyIdentification3_schemeID.Name = "colACP_PartyIdentification3_schemeID";
            // 
            // colACP_PartyIdentification3_ID
            // 
            this.colACP_PartyIdentification3_ID.FieldName = "ACP_PartyIdentification3_ID";
            this.colACP_PartyIdentification3_ID.Name = "colACP_PartyIdentification3_ID";
            // 
            // colACP_PartyIdentification4_schemeID
            // 
            this.colACP_PartyIdentification4_schemeID.FieldName = "ACP_PartyIdentification4_schemeID";
            this.colACP_PartyIdentification4_schemeID.Name = "colACP_PartyIdentification4_schemeID";
            // 
            // colACP_PartyIdentification4_ID
            // 
            this.colACP_PartyIdentification4_ID.FieldName = "ACP_PartyIdentification4_ID";
            this.colACP_PartyIdentification4_ID.Name = "colACP_PartyIdentification4_ID";
            // 
            // colACP_PartyIdentification5_schemeID
            // 
            this.colACP_PartyIdentification5_schemeID.FieldName = "ACP_PartyIdentification5_schemeID";
            this.colACP_PartyIdentification5_schemeID.Name = "colACP_PartyIdentification5_schemeID";
            // 
            // colACP_PartyIdentification5_ID
            // 
            this.colACP_PartyIdentification5_ID.FieldName = "ACP_PartyIdentification5_ID";
            this.colACP_PartyIdentification5_ID.Name = "colACP_PartyIdentification5_ID";
            // 
            // colACP_PartyName
            // 
            this.colACP_PartyName.Caption = "Müşteri ünvan";
            this.colACP_PartyName.FieldName = "ACP_PartyName";
            this.colACP_PartyName.Name = "colACP_PartyName";
            this.colACP_PartyName.Visible = true;
            this.colACP_PartyName.VisibleIndex = 1;
            this.colACP_PartyName.Width = 115;
            // 
            // colACP_PostalAddress_StreetName
            // 
            this.colACP_PostalAddress_StreetName.FieldName = "ACP_PostalAddress_StreetName";
            this.colACP_PostalAddress_StreetName.Name = "colACP_PostalAddress_StreetName";
            // 
            // colACP_PostalAddress_Room
            // 
            this.colACP_PostalAddress_Room.FieldName = "ACP_PostalAddress_Room";
            this.colACP_PostalAddress_Room.Name = "colACP_PostalAddress_Room";
            // 
            // colACP_PostalAddress_BuildingNumber
            // 
            this.colACP_PostalAddress_BuildingNumber.FieldName = "ACP_PostalAddress_BuildingNumber";
            this.colACP_PostalAddress_BuildingNumber.Name = "colACP_PostalAddress_BuildingNumber";
            // 
            // colACP_PostalAddress_CitySubdivisionName
            // 
            this.colACP_PostalAddress_CitySubdivisionName.FieldName = "ACP_PostalAddress_CitySubdivisionName";
            this.colACP_PostalAddress_CitySubdivisionName.Name = "colACP_PostalAddress_CitySubdivisionName";
            // 
            // colACP_PostalAddress_CityName
            // 
            this.colACP_PostalAddress_CityName.FieldName = "ACP_PostalAddress_CityName";
            this.colACP_PostalAddress_CityName.Name = "colACP_PostalAddress_CityName";
            // 
            // colACP_PostalAddress_Country
            // 
            this.colACP_PostalAddress_Country.FieldName = "ACP_PostalAddress_Country";
            this.colACP_PostalAddress_Country.Name = "colACP_PostalAddress_Country";
            // 
            // colACP_PartyTaxScheme
            // 
            this.colACP_PartyTaxScheme.Caption = "Musteri Veri D.";
            this.colACP_PartyTaxScheme.FieldName = "ACP_PartyTaxScheme";
            this.colACP_PartyTaxScheme.Name = "colACP_PartyTaxScheme";
            this.colACP_PartyTaxScheme.Visible = true;
            this.colACP_PartyTaxScheme.VisibleIndex = 18;
            this.colACP_PartyTaxScheme.Width = 140;
            // 
            // colACP_Contact_Telephone
            // 
            this.colACP_Contact_Telephone.FieldName = "ACP_Contact_Telephone";
            this.colACP_Contact_Telephone.Name = "colACP_Contact_Telephone";
            // 
            // colACP_Contact_Telefax
            // 
            this.colACP_Contact_Telefax.FieldName = "ACP_Contact_Telefax";
            this.colACP_Contact_Telefax.Name = "colACP_Contact_Telefax";
            // 
            // colACP_Contact_ElectronicMail
            // 
            this.colACP_Contact_ElectronicMail.FieldName = "ACP_Contact_ElectronicMail";
            this.colACP_Contact_ElectronicMail.Name = "colACP_Contact_ElectronicMail";
            // 
            // colACP_Person_FirstName
            // 
            this.colACP_Person_FirstName.FieldName = "ACP_Person_FirstName";
            this.colACP_Person_FirstName.Name = "colACP_Person_FirstName";
            // 
            // colACP_Person_FamilyName
            // 
            this.colACP_Person_FamilyName.FieldName = "ACP_Person_FamilyName";
            this.colACP_Person_FamilyName.Name = "colACP_Person_FamilyName";
            // 
            // colACP_AgentParty_PartyIdentification1_schemeID
            // 
            this.colACP_AgentParty_PartyIdentification1_schemeID.FieldName = "ACP_AgentParty_PartyIdentification1_schemeID";
            this.colACP_AgentParty_PartyIdentification1_schemeID.Name = "colACP_AgentParty_PartyIdentification1_schemeID";
            // 
            // colACP_AgentParty_PartyIdentification1_ID
            // 
            this.colACP_AgentParty_PartyIdentification1_ID.FieldName = "ACP_AgentParty_PartyIdentification1_ID";
            this.colACP_AgentParty_PartyIdentification1_ID.Name = "colACP_AgentParty_PartyIdentification1_ID";
            // 
            // colACP_AgentParty_PartyIdentification2_schemeID
            // 
            this.colACP_AgentParty_PartyIdentification2_schemeID.FieldName = "ACP_AgentParty_PartyIdentification2_schemeID";
            this.colACP_AgentParty_PartyIdentification2_schemeID.Name = "colACP_AgentParty_PartyIdentification2_schemeID";
            // 
            // colACP_AgentParty_PartyIdentification2_ID
            // 
            this.colACP_AgentParty_PartyIdentification2_ID.FieldName = "ACP_AgentParty_PartyIdentification2_ID";
            this.colACP_AgentParty_PartyIdentification2_ID.Name = "colACP_AgentParty_PartyIdentification2_ID";
            // 
            // colACP_AgentParty_PartyIdentification3_schemeID
            // 
            this.colACP_AgentParty_PartyIdentification3_schemeID.FieldName = "ACP_AgentParty_PartyIdentification3_schemeID";
            this.colACP_AgentParty_PartyIdentification3_schemeID.Name = "colACP_AgentParty_PartyIdentification3_schemeID";
            // 
            // colACP_AgentParty_PartyIdentification3_ID
            // 
            this.colACP_AgentParty_PartyIdentification3_ID.FieldName = "ACP_AgentParty_PartyIdentification3_ID";
            this.colACP_AgentParty_PartyIdentification3_ID.Name = "colACP_AgentParty_PartyIdentification3_ID";
            // 
            // colACP_AgentParty_PartyIdentification4_schemeID
            // 
            this.colACP_AgentParty_PartyIdentification4_schemeID.FieldName = "ACP_AgentParty_PartyIdentification4_schemeID";
            this.colACP_AgentParty_PartyIdentification4_schemeID.Name = "colACP_AgentParty_PartyIdentification4_schemeID";
            // 
            // colACP_AgentParty_PartyIdentification4_ID
            // 
            this.colACP_AgentParty_PartyIdentification4_ID.FieldName = "ACP_AgentParty_PartyIdentification4_ID";
            this.colACP_AgentParty_PartyIdentification4_ID.Name = "colACP_AgentParty_PartyIdentification4_ID";
            // 
            // colACP_AgentParty_PartyIdentification5_schemeID
            // 
            this.colACP_AgentParty_PartyIdentification5_schemeID.FieldName = "ACP_AgentParty_PartyIdentification5_schemeID";
            this.colACP_AgentParty_PartyIdentification5_schemeID.Name = "colACP_AgentParty_PartyIdentification5_schemeID";
            // 
            // colACP_AgentParty_PartyIdentification5_ID
            // 
            this.colACP_AgentParty_PartyIdentification5_ID.FieldName = "ACP_AgentParty_PartyIdentification5_ID";
            this.colACP_AgentParty_PartyIdentification5_ID.Name = "colACP_AgentParty_PartyIdentification5_ID";
            // 
            // colACP_AgentParty_PartyName
            // 
            this.colACP_AgentParty_PartyName.FieldName = "ACP_AgentParty_PartyName";
            this.colACP_AgentParty_PartyName.Name = "colACP_AgentParty_PartyName";
            // 
            // colACP_AgentParty_PostalAddress_StreetName
            // 
            this.colACP_AgentParty_PostalAddress_StreetName.FieldName = "ACP_AgentParty_PostalAddress_StreetName";
            this.colACP_AgentParty_PostalAddress_StreetName.Name = "colACP_AgentParty_PostalAddress_StreetName";
            // 
            // colACP_AgentParty_PostalAddress_Room
            // 
            this.colACP_AgentParty_PostalAddress_Room.FieldName = "ACP_AgentParty_PostalAddress_Room";
            this.colACP_AgentParty_PostalAddress_Room.Name = "colACP_AgentParty_PostalAddress_Room";
            // 
            // colACP_AgentParty_PostalAddress_BuildingNumber
            // 
            this.colACP_AgentParty_PostalAddress_BuildingNumber.FieldName = "ACP_AgentParty_PostalAddress_BuildingNumber";
            this.colACP_AgentParty_PostalAddress_BuildingNumber.Name = "colACP_AgentParty_PostalAddress_BuildingNumber";
            // 
            // colACP_AgentParty_PostalAddress_CitySubdivisionName
            // 
            this.colACP_AgentParty_PostalAddress_CitySubdivisionName.FieldName = "ACP_AgentParty_PostalAddress_CitySubdivisionName";
            this.colACP_AgentParty_PostalAddress_CitySubdivisionName.Name = "colACP_AgentParty_PostalAddress_CitySubdivisionName";
            // 
            // colACP_AgentParty_PostalAddress_CityName
            // 
            this.colACP_AgentParty_PostalAddress_CityName.FieldName = "ACP_AgentParty_PostalAddress_CityName";
            this.colACP_AgentParty_PostalAddress_CityName.Name = "colACP_AgentParty_PostalAddress_CityName";
            // 
            // colACP_AgentParty_PostalAddress_Country
            // 
            this.colACP_AgentParty_PostalAddress_Country.FieldName = "ACP_AgentParty_PostalAddress_Country";
            this.colACP_AgentParty_PostalAddress_Country.Name = "colACP_AgentParty_PostalAddress_Country";
            // 
            // colACP_AgentParty_PartyTaxScheme
            // 
            this.colACP_AgentParty_PartyTaxScheme.FieldName = "ACP_AgentParty_PartyTaxScheme";
            this.colACP_AgentParty_PartyTaxScheme.Name = "colACP_AgentParty_PartyTaxScheme";
            // 
            // colACP_AgentParty_Contact_Telephone
            // 
            this.colACP_AgentParty_Contact_Telephone.FieldName = "ACP_AgentParty_Contact_Telephone";
            this.colACP_AgentParty_Contact_Telephone.Name = "colACP_AgentParty_Contact_Telephone";
            // 
            // colACP_AgentParty_Contact_Telefax
            // 
            this.colACP_AgentParty_Contact_Telefax.FieldName = "ACP_AgentParty_Contact_Telefax";
            this.colACP_AgentParty_Contact_Telefax.Name = "colACP_AgentParty_Contact_Telefax";
            // 
            // colACP_AgentParty_Contact_ElectronicMail
            // 
            this.colACP_AgentParty_Contact_ElectronicMail.FieldName = "ACP_AgentParty_Contact_ElectronicMail";
            this.colACP_AgentParty_Contact_ElectronicMail.Name = "colACP_AgentParty_Contact_ElectronicMail";
            // 
            // colTaxExchangeRate_SourceCurrencyCode
            // 
            this.colTaxExchangeRate_SourceCurrencyCode.FieldName = "TaxExchangeRate_SourceCurrencyCode";
            this.colTaxExchangeRate_SourceCurrencyCode.Name = "colTaxExchangeRate_SourceCurrencyCode";
            // 
            // colTaxExchangeRate_TargetCurrencyCode
            // 
            this.colTaxExchangeRate_TargetCurrencyCode.FieldName = "TaxExchangeRate_TargetCurrencyCode";
            this.colTaxExchangeRate_TargetCurrencyCode.Name = "colTaxExchangeRate_TargetCurrencyCode";
            // 
            // colTaxExchangeRate_CalculationRate
            // 
            this.colTaxExchangeRate_CalculationRate.FieldName = "TaxExchangeRate_CalculationRate";
            this.colTaxExchangeRate_CalculationRate.Name = "colTaxExchangeRate_CalculationRate";
            // 
            // colTaxExchangeRate_Date
            // 
            this.colTaxExchangeRate_Date.FieldName = "TaxExchangeRate_Date";
            this.colTaxExchangeRate_Date.Name = "colTaxExchangeRate_Date";
            // 
            // colPricingExchangeRate_SourceCurrencyCode
            // 
            this.colPricingExchangeRate_SourceCurrencyCode.FieldName = "PricingExchangeRate_SourceCurrencyCode";
            this.colPricingExchangeRate_SourceCurrencyCode.Name = "colPricingExchangeRate_SourceCurrencyCode";
            // 
            // colPricingExchangeRate_TargetCurrencyCode
            // 
            this.colPricingExchangeRate_TargetCurrencyCode.FieldName = "PricingExchangeRate_TargetCurrencyCode";
            this.colPricingExchangeRate_TargetCurrencyCode.Name = "colPricingExchangeRate_TargetCurrencyCode";
            // 
            // colPricingExchangeRate_CalculationRate
            // 
            this.colPricingExchangeRate_CalculationRate.FieldName = "PricingExchangeRate_CalculationRate";
            this.colPricingExchangeRate_CalculationRate.Name = "colPricingExchangeRate_CalculationRate";
            // 
            // colPricingExchangeRate_Date
            // 
            this.colPricingExchangeRate_Date.FieldName = "PricingExchangeRate_Date";
            this.colPricingExchangeRate_Date.Name = "colPricingExchangeRate_Date";
            // 
            // colPaymentExchangeRate_SourceCurrencyCode
            // 
            this.colPaymentExchangeRate_SourceCurrencyCode.FieldName = "PaymentExchangeRate_SourceCurrencyCode";
            this.colPaymentExchangeRate_SourceCurrencyCode.Name = "colPaymentExchangeRate_SourceCurrencyCode";
            // 
            // colPaymentExchangeRate_TargetCurrencyCode
            // 
            this.colPaymentExchangeRate_TargetCurrencyCode.FieldName = "PaymentExchangeRate_TargetCurrencyCode";
            this.colPaymentExchangeRate_TargetCurrencyCode.Name = "colPaymentExchangeRate_TargetCurrencyCode";
            // 
            // colPaymentExchangeRate_CalculationRate
            // 
            this.colPaymentExchangeRate_CalculationRate.FieldName = "PaymentExchangeRate_CalculationRate";
            this.colPaymentExchangeRate_CalculationRate.Name = "colPaymentExchangeRate_CalculationRate";
            // 
            // colPaymentExchangeRate_Date
            // 
            this.colPaymentExchangeRate_Date.FieldName = "PaymentExchangeRate_Date";
            this.colPaymentExchangeRate_Date.Name = "colPaymentExchangeRate_Date";
            // 
            // colPaymentAlternativeExchangeRate_SourceCurrencyCode
            // 
            this.colPaymentAlternativeExchangeRate_SourceCurrencyCode.FieldName = "PaymentAlternativeExchangeRate_SourceCurrencyCode";
            this.colPaymentAlternativeExchangeRate_SourceCurrencyCode.Name = "colPaymentAlternativeExchangeRate_SourceCurrencyCode";
            // 
            // colPaymentAlternativeExchangeRate_TargetCurrencyCode
            // 
            this.colPaymentAlternativeExchangeRate_TargetCurrencyCode.FieldName = "PaymentAlternativeExchangeRate_TargetCurrencyCode";
            this.colPaymentAlternativeExchangeRate_TargetCurrencyCode.Name = "colPaymentAlternativeExchangeRate_TargetCurrencyCode";
            // 
            // colPaymentAlternativeExchangeRate_CalculationRate
            // 
            this.colPaymentAlternativeExchangeRate_CalculationRate.FieldName = "PaymentAlternativeExchangeRate_CalculationRate";
            this.colPaymentAlternativeExchangeRate_CalculationRate.Name = "colPaymentAlternativeExchangeRate_CalculationRate";
            // 
            // colPaymentAlternativeExchangeRate_Date
            // 
            this.colPaymentAlternativeExchangeRate_Date.FieldName = "PaymentAlternativeExchangeRate_Date";
            this.colPaymentAlternativeExchangeRate_Date.Name = "colPaymentAlternativeExchangeRate_Date";
            // 
            // colTaxAmount
            // 
            this.colTaxAmount.Caption = "Vergi Toplamı";
            this.colTaxAmount.FieldName = "TaxAmount";
            this.colTaxAmount.Name = "colTaxAmount";
            this.colTaxAmount.Visible = true;
            this.colTaxAmount.VisibleIndex = 9;
            // 
            // colUUID
            // 
            this.colUUID.FieldName = "UUID";
            this.colUUID.Name = "colUUID";
            this.colUUID.Width = 230;
            // 
            // colLegalMonetaryTotal_LineExtensionAmount
            // 
            this.colLegalMonetaryTotal_LineExtensionAmount.Caption = "Satır toplamı";
            this.colLegalMonetaryTotal_LineExtensionAmount.FieldName = "LegalMonetaryTotal_LineExtensionAmount";
            this.colLegalMonetaryTotal_LineExtensionAmount.Name = "colLegalMonetaryTotal_LineExtensionAmount";
            this.colLegalMonetaryTotal_LineExtensionAmount.Visible = true;
            this.colLegalMonetaryTotal_LineExtensionAmount.VisibleIndex = 10;
            // 
            // colLegalMonetaryTotal_TaxExclusiveAmount
            // 
            this.colLegalMonetaryTotal_TaxExclusiveAmount.Caption = "Vergi hariç toplam";
            this.colLegalMonetaryTotal_TaxExclusiveAmount.FieldName = "LegalMonetaryTotal_TaxExclusiveAmount";
            this.colLegalMonetaryTotal_TaxExclusiveAmount.Name = "colLegalMonetaryTotal_TaxExclusiveAmount";
            this.colLegalMonetaryTotal_TaxExclusiveAmount.Visible = true;
            this.colLegalMonetaryTotal_TaxExclusiveAmount.VisibleIndex = 11;
            // 
            // colLegalMonetaryTotal_TaxInclusiveAmount
            // 
            this.colLegalMonetaryTotal_TaxInclusiveAmount.Caption = "Vergi dahil toplam";
            this.colLegalMonetaryTotal_TaxInclusiveAmount.FieldName = "LegalMonetaryTotal_TaxInclusiveAmount";
            this.colLegalMonetaryTotal_TaxInclusiveAmount.Name = "colLegalMonetaryTotal_TaxInclusiveAmount";
            this.colLegalMonetaryTotal_TaxInclusiveAmount.Visible = true;
            this.colLegalMonetaryTotal_TaxInclusiveAmount.VisibleIndex = 12;
            // 
            // colLegalMonetaryTotal_AllowanceTotal
            // 
            this.colLegalMonetaryTotal_AllowanceTotal.Caption = "Toplam indirim";
            this.colLegalMonetaryTotal_AllowanceTotal.FieldName = "LegalMonetaryTotal_AllowanceTotalAmount";
            this.colLegalMonetaryTotal_AllowanceTotal.Name = "colLegalMonetaryTotal_AllowanceTotal";
            this.colLegalMonetaryTotal_AllowanceTotal.Visible = true;
            this.colLegalMonetaryTotal_AllowanceTotal.VisibleIndex = 13;
            // 
            // colLegalMonetaryTotal_ChargeTotalAmount
            // 
            this.colLegalMonetaryTotal_ChargeTotalAmount.Caption = "Toplam Masraf";
            this.colLegalMonetaryTotal_ChargeTotalAmount.FieldName = "LegalMonetaryTotal_ChargeTotalAmount";
            this.colLegalMonetaryTotal_ChargeTotalAmount.Name = "colLegalMonetaryTotal_ChargeTotalAmount";
            this.colLegalMonetaryTotal_ChargeTotalAmount.Visible = true;
            this.colLegalMonetaryTotal_ChargeTotalAmount.VisibleIndex = 14;
            // 
            // colLegalMonetaryTotal_PayableRoundingAmount
            // 
            this.colLegalMonetaryTotal_PayableRoundingAmount.Caption = "Yuvarlama";
            this.colLegalMonetaryTotal_PayableRoundingAmount.FieldName = "LegalMonetaryTotal_PayableRoundingAmount";
            this.colLegalMonetaryTotal_PayableRoundingAmount.Name = "colLegalMonetaryTotal_PayableRoundingAmount";
            this.colLegalMonetaryTotal_PayableRoundingAmount.Visible = true;
            this.colLegalMonetaryTotal_PayableRoundingAmount.VisibleIndex = 15;
            // 
            // colLegalMonetaryTotal_PayableAmount
            // 
            this.colLegalMonetaryTotal_PayableAmount.Caption = "Ödenecek tutar";
            this.colLegalMonetaryTotal_PayableAmount.FieldName = "LegalMonetaryTotal_PayableAmount";
            this.colLegalMonetaryTotal_PayableAmount.Name = "colLegalMonetaryTotal_PayableAmount";
            this.colLegalMonetaryTotal_PayableAmount.Visible = true;
            this.colLegalMonetaryTotal_PayableAmount.VisibleIndex = 16;
            // 
            // colIntCode
            // 
            this.colIntCode.FieldName = "IntCode";
            this.colIntCode.Name = "colIntCode";
            this.colIntCode.Visible = true;
            this.colIntCode.VisibleIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDownloadIncomingInvoice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 50);
            this.panel1.TabIndex = 1;
            // 
            // btnDownloadIncomingInvoice
            // 
            this.btnDownloadIncomingInvoice.Location = new System.Drawing.Point(10, 14);
            this.btnDownloadIncomingInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.btnDownloadIncomingInvoice.Name = "btnDownloadIncomingInvoice";
            this.btnDownloadIncomingInvoice.Size = new System.Drawing.Size(111, 32);
            this.btnDownloadIncomingInvoice.TabIndex = 1;
            this.btnDownloadIncomingInvoice.Text = "Gelen faturalari cek";
            this.btnDownloadIncomingInvoice.Click += new System.EventHandler(this.btnDownloadIncomingInvoice_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.grGidenKutusu);
            this.xtraTabPage2.Controls.Add(this.panel3);
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(978, 348);
            this.xtraTabPage2.Text = "Giden kutusu";
            // 
            // grGidenKutusu
            // 
            this.grGidenKutusu.ContextMenuStrip = this.conMenuGiden;
            this.grGidenKutusu.DataSource = this.tbInvoice_GidenKutusu;
            this.grGidenKutusu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grGidenKutusu.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grGidenKutusu.Location = new System.Drawing.Point(0, 50);
            this.grGidenKutusu.MainView = this.grGidenKutusuView;
            this.grGidenKutusu.Margin = new System.Windows.Forms.Padding(2);
            this.grGidenKutusu.Name = "grGidenKutusu";
            this.grGidenKutusu.Size = new System.Drawing.Size(978, 298);
            this.grGidenKutusu.TabIndex = 2;
            this.grGidenKutusu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grGidenKutusuView});
            this.grGidenKutusu.Click += new System.EventHandler(this.grGidenKutusu_Click);
            this.grGidenKutusu.DoubleClick += new System.EventHandler(this.grGidenKutusu_DoubleClick);
            // 
            // conMenuGiden
            // 
            this.conMenuGiden.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.conMenuGiden.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faturayiAcToolStripMenuItem,
            this.toolStripMenuItem1,
            this.gonderToolStripMenuItem,
            this.toolStripMenuItem2,
            this.silToolStripMenuItem,
            this.toolStripMenuItem4,
            this.gonderilmisGibiİsaretleToolStripMenuItem});
            this.conMenuGiden.Name = "conMenuGiden";
            this.conMenuGiden.Size = new System.Drawing.Size(202, 110);
            // 
            // faturayiAcToolStripMenuItem
            // 
            this.faturayiAcToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.faturayiAcToolStripMenuItem.Name = "faturayiAcToolStripMenuItem";
            this.faturayiAcToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.faturayiAcToolStripMenuItem.Text = "Faturayi ac";
            this.faturayiAcToolStripMenuItem.Click += new System.EventHandler(this.faturayiAcToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(198, 6);
            // 
            // gonderToolStripMenuItem
            // 
            this.gonderToolStripMenuItem.Name = "gonderToolStripMenuItem";
            this.gonderToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.gonderToolStripMenuItem.Text = "Gonder";
            this.gonderToolStripMenuItem.Click += new System.EventHandler(this.gonderToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(198, 6);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(198, 6);
            // 
            // gonderilmisGibiİsaretleToolStripMenuItem
            // 
            this.gonderilmisGibiİsaretleToolStripMenuItem.Name = "gonderilmisGibiİsaretleToolStripMenuItem";
            this.gonderilmisGibiİsaretleToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.gonderilmisGibiİsaretleToolStripMenuItem.Text = "Gonderilmis gibi isaretle";
            this.gonderilmisGibiİsaretleToolStripMenuItem.Click += new System.EventHandler(this.gonderilmisGibiİsaretleToolStripMenuItem_Click);
            // 
            // tbInvoice_GidenKutusu
            // 
            this.tbInvoice_GidenKutusu.Columns.AddRange(new System.Data.DataColumn[] {
            this.tbInvoice_GidenKutusu_InvoiceID,
            this.tbInvoice_GidenKutusu_Deleted,
            this.tbInvoice_GidenKutusu_CreatedBy,
            this.tbInvoice_GidenKutusu_CreatedDate,
            this.tbInvoice_GidenKutusu_ModifiedBy,
            this.tbInvoice_GidenKutusu_ModifiedDate,
            this.tbInvoice_GidenKutusu_IOType,
            this.tbInvoice_GidenKutusu_IntCode,
            this.tbInvoice_GidenKutusu_LocalStatus,
            this.tbInvoice_GidenKutusu_IntegratorID,
            this.tbInvoice_GidenKutusu_Status,
            this.tbInvoice_GidenKutusu_StatusDescription,
            this.tbInvoice_GidenKutusu_PostBox,
            this.tbInvoice_GidenKutusu_XsltNo,
            this.tbInvoice_GidenKutusu_ProfileID,
            this.tbInvoice_GidenKutusu_ID,
            this.tbInvoice_GidenKutusu_UUID,
            this.tbInvoice_GidenKutusu_IssueDate,
            this.tbInvoice_GidenKutusu_IssueTime,
            this.tbInvoice_GidenKutusu_InvoiceTypeCode,
            this.tbInvoice_GidenKutusu_DocumentCurrencyCode,
            this.tbInvoice_GidenKutusu_TaxCurrencyCode,
            this.tbInvoice_GidenKutusu_PricingCurrencyCode,
            this.tbInvoice_GidenKutusu_PaymentCurrencyCode,
            this.tbInvoice_GidenKutusu_PaymentAlternativeCurrencyCode,
            this.tbInvoice_GidenKutusu_LineCountNumeric,
            this.tbInvoice_GidenKutusu_InvoicePeriod_StartDate,
            this.tbInvoice_GidenKutusu_InvoicePeriod_EndDate,
            this.tbInvoice_GidenKutusu_ASP_PartyIdentification1_schemeID,
            this.tbInvoice_GidenKutusu_ASP_PartyIdentification1_ID,
            this.tbInvoice_GidenKutusu_ASP_PartyIdentification2_schemeID,
            this.tbInvoice_GidenKutusu_ASP_PartyIdentification2_ID,
            this.tbInvoice_GidenKutusu_ASP_PartyIdentification3_schemeID,
            this.tbInvoice_GidenKutusu_ASP_PartyIdentification3_ID,
            this.tbInvoice_GidenKutusu_ASP_PartyIdentification4_schemeID,
            this.tbInvoice_GidenKutusu_ASP_PartyIdentification4_ID,
            this.tbInvoice_GidenKutusu_ASP_PartyIdentification5_schemeID,
            this.tbInvoice_GidenKutusu_ASP_PartyIdentification5_ID,
            this.tbInvoice_GidenKutusu_ASP_PartyName,
            this.tbInvoice_GidenKutusu_ASP_PostalAddress_StreetName,
            this.tbInvoice_GidenKutusu_ASP_PostalAddress_Room,
            this.tbInvoice_GidenKutusu_ASP_PostalAddress_BuildingNumber,
            this.tbInvoice_GidenKutusu_ASP_PostalAddress_BuildingName,
            this.tbInvoice_GidenKutusu_ASP_PostalAddress_CitySubdivisionName,
            this.tbInvoice_GidenKutusu_ASP_PostalAddress_CityName,
            this.tbInvoice_GidenKutusu_ASP_PostalAddress_Country,
            this.tbInvoice_GidenKutusu_ASP_PartyTaxSchemeName,
            this.tbInvoice_GidenKutusu_ASP_PartyTaxSchemeTaxTypeCode,
            this.tbInvoice_GidenKutusu_ASP_WebsiteURI,
            this.tbInvoice_GidenKutusu_ASP_Contact_Telephone,
            this.tbInvoice_GidenKutusu_ASP_Contact_Telefax,
            this.tbInvoice_GidenKutusu_ASP_Contact_ElectronicMail,
            this.tbInvoice_GidenKutusu_ASP_Person_FirstName,
            this.tbInvoice_GidenKutusu_ASP_Person_FamilyName,
            this.tbInvoice_GidenKutusu_ASP_Person_MiddleName,
            this.tbInvoice_GidenKutusu_ASP_Person_NameSuffix,
            this.tbInvoice_GidenKutusu_ASP_Person_Title,
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification1_schemeID,
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification1_ID,
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification2_schemeID,
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification2_ID,
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification3_schemeID,
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification3_ID,
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification4_schemeID,
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification4_ID,
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification5_schemeID,
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification5_ID,
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyName,
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_StreetName,
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_Room,
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_BuildingNumber,
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_BuildingName,
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_CitySubdivisionName,
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_CityName,
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_Country,
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyTaxSchemeName,
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyTaxSchemeTaxTypeCode,
            this.tbInvoice_GidenKutusu_ASP_AgentParty_WebsiteURI,
            this.tbInvoice_GidenKutusu_ASP_AgentParty_Contact_Telephone,
            this.tbInvoice_GidenKutusu_ASP_AgentParty_Contact_Telefax,
            this.tbInvoice_GidenKutusu_ASP_AgentParty_Contact_ElectronicMail,
            this.tbInvoice_GidenKutusu_ASP_AgentParty_Person_FirstName,
            this.tbInvoice_GidenKutusu_ASP_AgentParty_Person_FamilyName,
            this.tbInvoice_GidenKutusu_ASP_AgentParty_Person_MiddleName,
            this.tbInvoice_GidenKutusu_ASP_AgentParty_Person_NameSuffix,
            this.tbInvoice_GidenKutusu_ASP_AgentParty_Person_Title,
            this.tbInvoice_GidenKutusu_ACP_PartyIdentification1_schemeID,
            this.tbInvoice_GidenKutusu_ACP_PartyIdentification1_ID,
            this.tbInvoice_GidenKutusu_ACP_PartyIdentification2_schemeID,
            this.tbInvoice_GidenKutusu_ACP_PartyIdentification2_ID,
            this.tbInvoice_GidenKutusu_ACP_PartyIdentification3_schemeID,
            this.tbInvoice_GidenKutusu_ACP_PartyIdentification3_ID,
            this.tbInvoice_GidenKutusu_ACP_PartyIdentification4_schemeID,
            this.tbInvoice_GidenKutusu_ACP_PartyIdentification4_ID,
            this.tbInvoice_GidenKutusu_ACP_PartyIdentification5_schemeID,
            this.tbInvoice_GidenKutusu_ACP_PartyIdentification5_ID,
            this.tbInvoice_GidenKutusu_ACP_PartyName,
            this.tbInvoice_GidenKutusu_ACP_PostalAddress_StreetName,
            this.tbInvoice_GidenKutusu_ACP_PostalAddress_Room,
            this.tbInvoice_GidenKutusu_ACP_PostalAddress_BuildingNumber,
            this.tbInvoice_GidenKutusu_ACP_PostalAddress_BuildingName,
            this.tbInvoice_GidenKutusu_ACP_PostalAddress_CitySubdivisionName,
            this.tbInvoice_GidenKutusu_ACP_PostalAddress_CityName,
            this.tbInvoice_GidenKutusu_ACP_PostalAddress_Country,
            this.tbInvoice_GidenKutusu_ACP_PartyTaxSchemeName,
            this.tbInvoice_GidenKutusu_ACP_PartyTaxSchemeTaxTypeCode,
            this.tbInvoice_GidenKutusu_ACP_WebsiteURI,
            this.tbInvoice_GidenKutusu_ACP_Contact_Telephone,
            this.tbInvoice_GidenKutusu_ACP_Contact_Telefax,
            this.tbInvoice_GidenKutusu_ACP_Contact_ElectronicMail,
            this.tbInvoice_GidenKutusu_ACP_Person_FirstName,
            this.tbInvoice_GidenKutusu_ACP_Person_FamilyName,
            this.tbInvoice_GidenKutusu_ACP_Person_MiddleName,
            this.tbInvoice_GidenKutusu_ACP_Person_NameSuffix,
            this.tbInvoice_GidenKutusu_ACP_Person_Title,
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification1_schemeID,
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification1_ID,
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification2_schemeID,
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification2_ID,
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification3_schemeID,
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification3_ID,
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification4_schemeID,
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification4_ID,
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification5_schemeID,
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification5_ID,
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyName,
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_StreetName,
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_Room,
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_BuildingNumber,
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_BuildingName,
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_CitySubdivisionName,
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_CityName,
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_Country,
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyTaxSchemeName,
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyTaxSchemeTaxTypeCode,
            this.tbInvoice_GidenKutusu_ACP_AgentParty_WebsiteURI,
            this.tbInvoice_GidenKutusu_ACP_AgentParty_Contact_Telephone,
            this.tbInvoice_GidenKutusu_ACP_AgentParty_Contact_Telefax,
            this.tbInvoice_GidenKutusu_ACP_AgentParty_Contact_ElectronicMail,
            this.tbInvoice_GidenKutusu_ACP_AgentParty_Person_FirstName,
            this.tbInvoice_GidenKutusu_ACP_AgentParty_Person_FamilyName,
            this.tbInvoice_GidenKutusu_ACP_AgentParty_Person_MiddleName,
            this.tbInvoice_GidenKutusu_ACP_AgentParty_Person_NameSuffix,
            this.tbInvoice_GidenKutusu_ACP_AgentParty_Person_Title,
            this.tbInvoice_GidenKutusu_TaxExchangeRate_SourceCurrencyCode,
            this.tbInvoice_GidenKutusu_TaxExchangeRate_TargetCurrencyCode,
            this.tbInvoice_GidenKutusu_TaxExchangeRate_CalculationRate,
            this.tbInvoice_GidenKutusu_TaxExchangeRate_Date,
            this.tbInvoice_GidenKutusu_PricingExchangeRate_SourceCurrencyCode,
            this.tbInvoice_GidenKutusu_PricingExchangeRate_TargetCurrencyCode,
            this.tbInvoice_GidenKutusu_PricingExchangeRate_CalculationRate,
            this.tbInvoice_GidenKutusu_PricingExchangeRate_Date,
            this.tbInvoice_GidenKutusu_PaymentExchangeRate_SourceCurrencyCode,
            this.tbInvoice_GidenKutusu_PaymentExchangeRate_TargetCurrencyCode,
            this.tbInvoice_GidenKutusu_PaymentExchangeRate_CalculationRate,
            this.tbInvoice_GidenKutusu_PaymentExchangeRate_Date,
            this.tbInvoice_GidenKutusu_PaymentAlternativeExchangeRate_SourceCurrencyCode,
            this.tbInvoice_GidenKutusu_PaymentAlternativeExchangeRate_TargetCurrencyCode,
            this.tbInvoice_GidenKutusu_PaymentAlternativeExchangeRate_CalculationRate,
            this.tbInvoice_GidenKutusu_PaymentAlternativeExchangeRate_Date,
            this.tbInvoice_GidenKutusu_TaxAmount,
            this.tbInvoice_GidenKutusu_LegalMonetaryTotal_LineExtensionAmount,
            this.tbInvoice_GidenKutusu_LegalMonetaryTotal_TaxExclusiveAmount,
            this.tbInvoice_GidenKutusu_LegalMonetaryTotal_TaxInclusiveAmount,
            this.tbInvoice_GidenKutusu_LegalMonetaryTotal_AllowanceTotalAmount,
            this.tbInvoice_GidenKutusu_LegalMonetaryTotal_ChargeTotalAmount,
            this.tbInvoice_GidenKutusu_LegalMonetaryTotal_PayableRoundingAmount,
            this.tbInvoice_GidenKutusu_LegalMonetaryTotal_PayableAmount,
            this.tbInvoice_GidenKutusu_WithholdingTaxAmount});
            this.tbInvoice_GidenKutusu.Connection = this.FirmConn;
            this.tbInvoice_GidenKutusu.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "InvoiceID"}, true)});
            this.tbInvoice_GidenKutusu.CurrentRow = null;
            this.tbInvoice_GidenKutusu.DataSourceLink = null;
            this.tbInvoice_GidenKutusu.DeleteCommand = this.sqlCommand12;
            this.tbInvoice_GidenKutusu.Filter = "";
            this.tbInvoice_GidenKutusu.InsertCommand = this.sqlCommand10;
            this.tbInvoice_GidenKutusu.LiveSave = false;
            this.tbInvoice_GidenKutusu.MaxRecords = ((long)(0));
            this.tbInvoice_GidenKutusu.Name = "tbInvoice_GidenKutusu";
            this.tbInvoice_GidenKutusu.ParentRelation_ChildColumns = null;
            this.tbInvoice_GidenKutusu.ParentRelation_ParentColumns = null;
            this.tbInvoice_GidenKutusu.ParentRelation_Table = null;
            this.tbInvoice_GidenKutusu.Position = ((long)(-1));
            this.tbInvoice_GidenKutusu.PrimaryKey = new System.Data.DataColumn[] {
        this.tbInvoice_GidenKutusu_InvoiceID};
            this.tbInvoice_GidenKutusu.Quoted = false;
            this.tbInvoice_GidenKutusu.SelectCommand = this.sqlCommand9;
            this.tbInvoice_GidenKutusu.TableName = "neoTable1";
            this.tbInvoice_GidenKutusu.Transaction = null;
            this.tbInvoice_GidenKutusu.UpdateCommand = this.sqlCommand11;
            // 
            // tbInvoice_GidenKutusu_InvoiceID
            // 
            this.tbInvoice_GidenKutusu_InvoiceID.AllowDBNull = false;
            this.tbInvoice_GidenKutusu_InvoiceID.AutoIncrement = true;
            this.tbInvoice_GidenKutusu_InvoiceID.ColumnName = "InvoiceID";
            this.tbInvoice_GidenKutusu_InvoiceID.DataType = typeof(int);
            // 
            // tbInvoice_GidenKutusu_Deleted
            // 
            this.tbInvoice_GidenKutusu_Deleted.ColumnName = "Deleted";
            this.tbInvoice_GidenKutusu_Deleted.DataType = typeof(int);
            // 
            // tbInvoice_GidenKutusu_CreatedBy
            // 
            this.tbInvoice_GidenKutusu_CreatedBy.ColumnName = "CreatedBy";
            this.tbInvoice_GidenKutusu_CreatedBy.DataType = typeof(int);
            // 
            // tbInvoice_GidenKutusu_CreatedDate
            // 
            this.tbInvoice_GidenKutusu_CreatedDate.ColumnName = "CreatedDate";
            this.tbInvoice_GidenKutusu_CreatedDate.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_GidenKutusu_ModifiedBy
            // 
            this.tbInvoice_GidenKutusu_ModifiedBy.ColumnName = "ModifiedBy";
            this.tbInvoice_GidenKutusu_ModifiedBy.DataType = typeof(int);
            // 
            // tbInvoice_GidenKutusu_ModifiedDate
            // 
            this.tbInvoice_GidenKutusu_ModifiedDate.ColumnName = "ModifiedDate";
            this.tbInvoice_GidenKutusu_ModifiedDate.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_GidenKutusu_IOType
            // 
            this.tbInvoice_GidenKutusu_IOType.ColumnName = "IOType";
            this.tbInvoice_GidenKutusu_IOType.DataType = typeof(int);
            // 
            // tbInvoice_GidenKutusu_IntCode
            // 
            this.tbInvoice_GidenKutusu_IntCode.ColumnName = "IntCode";
            // 
            // tbInvoice_GidenKutusu_LocalStatus
            // 
            this.tbInvoice_GidenKutusu_LocalStatus.ColumnName = "LocalStatus";
            this.tbInvoice_GidenKutusu_LocalStatus.DataType = typeof(int);
            // 
            // tbInvoice_GidenKutusu_IntegratorID
            // 
            this.tbInvoice_GidenKutusu_IntegratorID.ColumnName = "IntegratorID";
            // 
            // tbInvoice_GidenKutusu_Status
            // 
            this.tbInvoice_GidenKutusu_Status.ColumnName = "Status";
            this.tbInvoice_GidenKutusu_Status.DataType = typeof(int);
            // 
            // tbInvoice_GidenKutusu_StatusDescription
            // 
            this.tbInvoice_GidenKutusu_StatusDescription.ColumnName = "StatusDescription";
            // 
            // tbInvoice_GidenKutusu_PostBox
            // 
            this.tbInvoice_GidenKutusu_PostBox.ColumnName = "PostBox";
            // 
            // tbInvoice_GidenKutusu_XsltNo
            // 
            this.tbInvoice_GidenKutusu_XsltNo.ColumnName = "XsltNo";
            this.tbInvoice_GidenKutusu_XsltNo.DataType = typeof(int);
            // 
            // tbInvoice_GidenKutusu_ProfileID
            // 
            this.tbInvoice_GidenKutusu_ProfileID.ColumnName = "ProfileID";
            // 
            // tbInvoice_GidenKutusu_ID
            // 
            this.tbInvoice_GidenKutusu_ID.ColumnName = "ID";
            // 
            // tbInvoice_GidenKutusu_UUID
            // 
            this.tbInvoice_GidenKutusu_UUID.ColumnName = "UUID";
            // 
            // tbInvoice_GidenKutusu_IssueDate
            // 
            this.tbInvoice_GidenKutusu_IssueDate.ColumnName = "IssueDate";
            this.tbInvoice_GidenKutusu_IssueDate.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_GidenKutusu_IssueTime
            // 
            this.tbInvoice_GidenKutusu_IssueTime.ColumnName = "IssueTime";
            this.tbInvoice_GidenKutusu_IssueTime.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_GidenKutusu_InvoiceTypeCode
            // 
            this.tbInvoice_GidenKutusu_InvoiceTypeCode.ColumnName = "InvoiceTypeCode";
            // 
            // tbInvoice_GidenKutusu_DocumentCurrencyCode
            // 
            this.tbInvoice_GidenKutusu_DocumentCurrencyCode.ColumnName = "DocumentCurrencyCode";
            // 
            // tbInvoice_GidenKutusu_TaxCurrencyCode
            // 
            this.tbInvoice_GidenKutusu_TaxCurrencyCode.ColumnName = "TaxCurrencyCode";
            // 
            // tbInvoice_GidenKutusu_PricingCurrencyCode
            // 
            this.tbInvoice_GidenKutusu_PricingCurrencyCode.ColumnName = "PricingCurrencyCode";
            // 
            // tbInvoice_GidenKutusu_PaymentCurrencyCode
            // 
            this.tbInvoice_GidenKutusu_PaymentCurrencyCode.ColumnName = "PaymentCurrencyCode";
            // 
            // tbInvoice_GidenKutusu_PaymentAlternativeCurrencyCode
            // 
            this.tbInvoice_GidenKutusu_PaymentAlternativeCurrencyCode.ColumnName = "PaymentAlternativeCurrencyCode";
            // 
            // tbInvoice_GidenKutusu_LineCountNumeric
            // 
            this.tbInvoice_GidenKutusu_LineCountNumeric.ColumnName = "LineCountNumeric";
            this.tbInvoice_GidenKutusu_LineCountNumeric.DataType = typeof(int);
            // 
            // tbInvoice_GidenKutusu_InvoicePeriod_StartDate
            // 
            this.tbInvoice_GidenKutusu_InvoicePeriod_StartDate.ColumnName = "InvoicePeriod_StartDate";
            this.tbInvoice_GidenKutusu_InvoicePeriod_StartDate.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_GidenKutusu_InvoicePeriod_EndDate
            // 
            this.tbInvoice_GidenKutusu_InvoicePeriod_EndDate.ColumnName = "InvoicePeriod_EndDate";
            this.tbInvoice_GidenKutusu_InvoicePeriod_EndDate.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_GidenKutusu_ASP_PartyIdentification1_schemeID
            // 
            this.tbInvoice_GidenKutusu_ASP_PartyIdentification1_schemeID.ColumnName = "ASP_PartyIdentification1_schemeID";
            // 
            // tbInvoice_GidenKutusu_ASP_PartyIdentification1_ID
            // 
            this.tbInvoice_GidenKutusu_ASP_PartyIdentification1_ID.ColumnName = "ASP_PartyIdentification1_ID";
            // 
            // tbInvoice_GidenKutusu_ASP_PartyIdentification2_schemeID
            // 
            this.tbInvoice_GidenKutusu_ASP_PartyIdentification2_schemeID.ColumnName = "ASP_PartyIdentification2_schemeID";
            // 
            // tbInvoice_GidenKutusu_ASP_PartyIdentification2_ID
            // 
            this.tbInvoice_GidenKutusu_ASP_PartyIdentification2_ID.ColumnName = "ASP_PartyIdentification2_ID";
            // 
            // tbInvoice_GidenKutusu_ASP_PartyIdentification3_schemeID
            // 
            this.tbInvoice_GidenKutusu_ASP_PartyIdentification3_schemeID.ColumnName = "ASP_PartyIdentification3_schemeID";
            // 
            // tbInvoice_GidenKutusu_ASP_PartyIdentification3_ID
            // 
            this.tbInvoice_GidenKutusu_ASP_PartyIdentification3_ID.ColumnName = "ASP_PartyIdentification3_ID";
            // 
            // tbInvoice_GidenKutusu_ASP_PartyIdentification4_schemeID
            // 
            this.tbInvoice_GidenKutusu_ASP_PartyIdentification4_schemeID.ColumnName = "ASP_PartyIdentification4_schemeID";
            // 
            // tbInvoice_GidenKutusu_ASP_PartyIdentification4_ID
            // 
            this.tbInvoice_GidenKutusu_ASP_PartyIdentification4_ID.ColumnName = "ASP_PartyIdentification4_ID";
            // 
            // tbInvoice_GidenKutusu_ASP_PartyIdentification5_schemeID
            // 
            this.tbInvoice_GidenKutusu_ASP_PartyIdentification5_schemeID.ColumnName = "ASP_PartyIdentification5_schemeID";
            // 
            // tbInvoice_GidenKutusu_ASP_PartyIdentification5_ID
            // 
            this.tbInvoice_GidenKutusu_ASP_PartyIdentification5_ID.ColumnName = "ASP_PartyIdentification5_ID";
            // 
            // tbInvoice_GidenKutusu_ASP_PartyName
            // 
            this.tbInvoice_GidenKutusu_ASP_PartyName.ColumnName = "ASP_PartyName";
            // 
            // tbInvoice_GidenKutusu_ASP_PostalAddress_StreetName
            // 
            this.tbInvoice_GidenKutusu_ASP_PostalAddress_StreetName.ColumnName = "ASP_PostalAddress_StreetName";
            // 
            // tbInvoice_GidenKutusu_ASP_PostalAddress_Room
            // 
            this.tbInvoice_GidenKutusu_ASP_PostalAddress_Room.ColumnName = "ASP_PostalAddress_Room";
            // 
            // tbInvoice_GidenKutusu_ASP_PostalAddress_BuildingNumber
            // 
            this.tbInvoice_GidenKutusu_ASP_PostalAddress_BuildingNumber.ColumnName = "ASP_PostalAddress_BuildingNumber";
            // 
            // tbInvoice_GidenKutusu_ASP_PostalAddress_BuildingName
            // 
            this.tbInvoice_GidenKutusu_ASP_PostalAddress_BuildingName.ColumnName = "ASP_PostalAddress_BuildingName";
            // 
            // tbInvoice_GidenKutusu_ASP_PostalAddress_CitySubdivisionName
            // 
            this.tbInvoice_GidenKutusu_ASP_PostalAddress_CitySubdivisionName.ColumnName = "ASP_PostalAddress_CitySubdivisionName";
            // 
            // tbInvoice_GidenKutusu_ASP_PostalAddress_CityName
            // 
            this.tbInvoice_GidenKutusu_ASP_PostalAddress_CityName.ColumnName = "ASP_PostalAddress_CityName";
            // 
            // tbInvoice_GidenKutusu_ASP_PostalAddress_Country
            // 
            this.tbInvoice_GidenKutusu_ASP_PostalAddress_Country.ColumnName = "ASP_PostalAddress_Country";
            // 
            // tbInvoice_GidenKutusu_ASP_PartyTaxSchemeName
            // 
            this.tbInvoice_GidenKutusu_ASP_PartyTaxSchemeName.ColumnName = "ASP_PartyTaxSchemeName";
            // 
            // tbInvoice_GidenKutusu_ASP_PartyTaxSchemeTaxTypeCode
            // 
            this.tbInvoice_GidenKutusu_ASP_PartyTaxSchemeTaxTypeCode.ColumnName = "ASP_PartyTaxSchemeTaxTypeCode";
            // 
            // tbInvoice_GidenKutusu_ASP_WebsiteURI
            // 
            this.tbInvoice_GidenKutusu_ASP_WebsiteURI.ColumnName = "ASP_WebsiteURI";
            // 
            // tbInvoice_GidenKutusu_ASP_Contact_Telephone
            // 
            this.tbInvoice_GidenKutusu_ASP_Contact_Telephone.ColumnName = "ASP_Contact_Telephone";
            // 
            // tbInvoice_GidenKutusu_ASP_Contact_Telefax
            // 
            this.tbInvoice_GidenKutusu_ASP_Contact_Telefax.ColumnName = "ASP_Contact_Telefax";
            // 
            // tbInvoice_GidenKutusu_ASP_Contact_ElectronicMail
            // 
            this.tbInvoice_GidenKutusu_ASP_Contact_ElectronicMail.ColumnName = "ASP_Contact_ElectronicMail";
            // 
            // tbInvoice_GidenKutusu_ASP_Person_FirstName
            // 
            this.tbInvoice_GidenKutusu_ASP_Person_FirstName.ColumnName = "ASP_Person_FirstName";
            // 
            // tbInvoice_GidenKutusu_ASP_Person_FamilyName
            // 
            this.tbInvoice_GidenKutusu_ASP_Person_FamilyName.ColumnName = "ASP_Person_FamilyName";
            // 
            // tbInvoice_GidenKutusu_ASP_Person_MiddleName
            // 
            this.tbInvoice_GidenKutusu_ASP_Person_MiddleName.ColumnName = "ASP_Person_MiddleName";
            // 
            // tbInvoice_GidenKutusu_ASP_Person_NameSuffix
            // 
            this.tbInvoice_GidenKutusu_ASP_Person_NameSuffix.ColumnName = "ASP_Person_NameSuffix";
            // 
            // tbInvoice_GidenKutusu_ASP_Person_Title
            // 
            this.tbInvoice_GidenKutusu_ASP_Person_Title.ColumnName = "ASP_Person_Title";
            // 
            // tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification1_schemeID
            // 
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification1_schemeID.ColumnName = "ASP_AgentParty_PartyIdentification1_schemeID";
            // 
            // tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification1_ID
            // 
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification1_ID.ColumnName = "ASP_AgentParty_PartyIdentification1_ID";
            // 
            // tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification2_schemeID
            // 
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification2_schemeID.ColumnName = "ASP_AgentParty_PartyIdentification2_schemeID";
            // 
            // tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification2_ID
            // 
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification2_ID.ColumnName = "ASP_AgentParty_PartyIdentification2_ID";
            // 
            // tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification3_schemeID
            // 
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification3_schemeID.ColumnName = "ASP_AgentParty_PartyIdentification3_schemeID";
            // 
            // tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification3_ID
            // 
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification3_ID.ColumnName = "ASP_AgentParty_PartyIdentification3_ID";
            // 
            // tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification4_schemeID
            // 
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification4_schemeID.ColumnName = "ASP_AgentParty_PartyIdentification4_schemeID";
            // 
            // tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification4_ID
            // 
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification4_ID.ColumnName = "ASP_AgentParty_PartyIdentification4_ID";
            // 
            // tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification5_schemeID
            // 
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification5_schemeID.ColumnName = "ASP_AgentParty_PartyIdentification5_schemeID";
            // 
            // tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification5_ID
            // 
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification5_ID.ColumnName = "ASP_AgentParty_PartyIdentification5_ID";
            // 
            // tbInvoice_GidenKutusu_ASP_AgentParty_PartyName
            // 
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyName.ColumnName = "ASP_AgentParty_PartyName";
            // 
            // tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_StreetName
            // 
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_StreetName.ColumnName = "ASP_AgentParty_PostalAddress_StreetName";
            // 
            // tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_Room
            // 
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_Room.ColumnName = "ASP_AgentParty_PostalAddress_Room";
            // 
            // tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_BuildingNumber
            // 
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_BuildingNumber.ColumnName = "ASP_AgentParty_PostalAddress_BuildingNumber";
            // 
            // tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_BuildingName
            // 
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_BuildingName.ColumnName = "ASP_AgentParty_PostalAddress_BuildingName";
            // 
            // tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_CitySubdivisionName
            // 
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_CitySubdivisionName.ColumnName = "ASP_AgentParty_PostalAddress_CitySubdivisionName";
            // 
            // tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_CityName
            // 
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_CityName.ColumnName = "ASP_AgentParty_PostalAddress_CityName";
            // 
            // tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_Country
            // 
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_Country.ColumnName = "ASP_AgentParty_PostalAddress_Country";
            // 
            // tbInvoice_GidenKutusu_ASP_AgentParty_PartyTaxSchemeName
            // 
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyTaxSchemeName.ColumnName = "ASP_AgentParty_PartyTaxSchemeName";
            // 
            // tbInvoice_GidenKutusu_ASP_AgentParty_PartyTaxSchemeTaxTypeCode
            // 
            this.tbInvoice_GidenKutusu_ASP_AgentParty_PartyTaxSchemeTaxTypeCode.ColumnName = "ASP_AgentParty_PartyTaxSchemeTaxTypeCode";
            // 
            // tbInvoice_GidenKutusu_ASP_AgentParty_WebsiteURI
            // 
            this.tbInvoice_GidenKutusu_ASP_AgentParty_WebsiteURI.ColumnName = "ASP_AgentParty_WebsiteURI";
            // 
            // tbInvoice_GidenKutusu_ASP_AgentParty_Contact_Telephone
            // 
            this.tbInvoice_GidenKutusu_ASP_AgentParty_Contact_Telephone.ColumnName = "ASP_AgentParty_Contact_Telephone";
            // 
            // tbInvoice_GidenKutusu_ASP_AgentParty_Contact_Telefax
            // 
            this.tbInvoice_GidenKutusu_ASP_AgentParty_Contact_Telefax.ColumnName = "ASP_AgentParty_Contact_Telefax";
            // 
            // tbInvoice_GidenKutusu_ASP_AgentParty_Contact_ElectronicMail
            // 
            this.tbInvoice_GidenKutusu_ASP_AgentParty_Contact_ElectronicMail.ColumnName = "ASP_AgentParty_Contact_ElectronicMail";
            // 
            // tbInvoice_GidenKutusu_ASP_AgentParty_Person_FirstName
            // 
            this.tbInvoice_GidenKutusu_ASP_AgentParty_Person_FirstName.ColumnName = "ASP_AgentParty_Person_FirstName";
            // 
            // tbInvoice_GidenKutusu_ASP_AgentParty_Person_FamilyName
            // 
            this.tbInvoice_GidenKutusu_ASP_AgentParty_Person_FamilyName.ColumnName = "ASP_AgentParty_Person_FamilyName";
            // 
            // tbInvoice_GidenKutusu_ASP_AgentParty_Person_MiddleName
            // 
            this.tbInvoice_GidenKutusu_ASP_AgentParty_Person_MiddleName.ColumnName = "ASP_AgentParty_Person_MiddleName";
            // 
            // tbInvoice_GidenKutusu_ASP_AgentParty_Person_NameSuffix
            // 
            this.tbInvoice_GidenKutusu_ASP_AgentParty_Person_NameSuffix.ColumnName = "ASP_AgentParty_Person_NameSuffix";
            // 
            // tbInvoice_GidenKutusu_ASP_AgentParty_Person_Title
            // 
            this.tbInvoice_GidenKutusu_ASP_AgentParty_Person_Title.ColumnName = "ASP_AgentParty_Person_Title";
            // 
            // tbInvoice_GidenKutusu_ACP_PartyIdentification1_schemeID
            // 
            this.tbInvoice_GidenKutusu_ACP_PartyIdentification1_schemeID.ColumnName = "ACP_PartyIdentification1_schemeID";
            // 
            // tbInvoice_GidenKutusu_ACP_PartyIdentification1_ID
            // 
            this.tbInvoice_GidenKutusu_ACP_PartyIdentification1_ID.ColumnName = "ACP_PartyIdentification1_ID";
            // 
            // tbInvoice_GidenKutusu_ACP_PartyIdentification2_schemeID
            // 
            this.tbInvoice_GidenKutusu_ACP_PartyIdentification2_schemeID.ColumnName = "ACP_PartyIdentification2_schemeID";
            // 
            // tbInvoice_GidenKutusu_ACP_PartyIdentification2_ID
            // 
            this.tbInvoice_GidenKutusu_ACP_PartyIdentification2_ID.ColumnName = "ACP_PartyIdentification2_ID";
            // 
            // tbInvoice_GidenKutusu_ACP_PartyIdentification3_schemeID
            // 
            this.tbInvoice_GidenKutusu_ACP_PartyIdentification3_schemeID.ColumnName = "ACP_PartyIdentification3_schemeID";
            // 
            // tbInvoice_GidenKutusu_ACP_PartyIdentification3_ID
            // 
            this.tbInvoice_GidenKutusu_ACP_PartyIdentification3_ID.ColumnName = "ACP_PartyIdentification3_ID";
            // 
            // tbInvoice_GidenKutusu_ACP_PartyIdentification4_schemeID
            // 
            this.tbInvoice_GidenKutusu_ACP_PartyIdentification4_schemeID.ColumnName = "ACP_PartyIdentification4_schemeID";
            // 
            // tbInvoice_GidenKutusu_ACP_PartyIdentification4_ID
            // 
            this.tbInvoice_GidenKutusu_ACP_PartyIdentification4_ID.ColumnName = "ACP_PartyIdentification4_ID";
            // 
            // tbInvoice_GidenKutusu_ACP_PartyIdentification5_schemeID
            // 
            this.tbInvoice_GidenKutusu_ACP_PartyIdentification5_schemeID.ColumnName = "ACP_PartyIdentification5_schemeID";
            // 
            // tbInvoice_GidenKutusu_ACP_PartyIdentification5_ID
            // 
            this.tbInvoice_GidenKutusu_ACP_PartyIdentification5_ID.ColumnName = "ACP_PartyIdentification5_ID";
            // 
            // tbInvoice_GidenKutusu_ACP_PartyName
            // 
            this.tbInvoice_GidenKutusu_ACP_PartyName.ColumnName = "ACP_PartyName";
            // 
            // tbInvoice_GidenKutusu_ACP_PostalAddress_StreetName
            // 
            this.tbInvoice_GidenKutusu_ACP_PostalAddress_StreetName.ColumnName = "ACP_PostalAddress_StreetName";
            // 
            // tbInvoice_GidenKutusu_ACP_PostalAddress_Room
            // 
            this.tbInvoice_GidenKutusu_ACP_PostalAddress_Room.ColumnName = "ACP_PostalAddress_Room";
            // 
            // tbInvoice_GidenKutusu_ACP_PostalAddress_BuildingNumber
            // 
            this.tbInvoice_GidenKutusu_ACP_PostalAddress_BuildingNumber.ColumnName = "ACP_PostalAddress_BuildingNumber";
            // 
            // tbInvoice_GidenKutusu_ACP_PostalAddress_BuildingName
            // 
            this.tbInvoice_GidenKutusu_ACP_PostalAddress_BuildingName.ColumnName = "ACP_PostalAddress_BuildingName";
            // 
            // tbInvoice_GidenKutusu_ACP_PostalAddress_CitySubdivisionName
            // 
            this.tbInvoice_GidenKutusu_ACP_PostalAddress_CitySubdivisionName.ColumnName = "ACP_PostalAddress_CitySubdivisionName";
            // 
            // tbInvoice_GidenKutusu_ACP_PostalAddress_CityName
            // 
            this.tbInvoice_GidenKutusu_ACP_PostalAddress_CityName.ColumnName = "ACP_PostalAddress_CityName";
            // 
            // tbInvoice_GidenKutusu_ACP_PostalAddress_Country
            // 
            this.tbInvoice_GidenKutusu_ACP_PostalAddress_Country.ColumnName = "ACP_PostalAddress_Country";
            // 
            // tbInvoice_GidenKutusu_ACP_PartyTaxSchemeName
            // 
            this.tbInvoice_GidenKutusu_ACP_PartyTaxSchemeName.ColumnName = "ACP_PartyTaxSchemeName";
            // 
            // tbInvoice_GidenKutusu_ACP_PartyTaxSchemeTaxTypeCode
            // 
            this.tbInvoice_GidenKutusu_ACP_PartyTaxSchemeTaxTypeCode.ColumnName = "ACP_PartyTaxSchemeTaxTypeCode";
            // 
            // tbInvoice_GidenKutusu_ACP_WebsiteURI
            // 
            this.tbInvoice_GidenKutusu_ACP_WebsiteURI.ColumnName = "ACP_WebsiteURI";
            // 
            // tbInvoice_GidenKutusu_ACP_Contact_Telephone
            // 
            this.tbInvoice_GidenKutusu_ACP_Contact_Telephone.ColumnName = "ACP_Contact_Telephone";
            // 
            // tbInvoice_GidenKutusu_ACP_Contact_Telefax
            // 
            this.tbInvoice_GidenKutusu_ACP_Contact_Telefax.ColumnName = "ACP_Contact_Telefax";
            // 
            // tbInvoice_GidenKutusu_ACP_Contact_ElectronicMail
            // 
            this.tbInvoice_GidenKutusu_ACP_Contact_ElectronicMail.ColumnName = "ACP_Contact_ElectronicMail";
            // 
            // tbInvoice_GidenKutusu_ACP_Person_FirstName
            // 
            this.tbInvoice_GidenKutusu_ACP_Person_FirstName.ColumnName = "ACP_Person_FirstName";
            // 
            // tbInvoice_GidenKutusu_ACP_Person_FamilyName
            // 
            this.tbInvoice_GidenKutusu_ACP_Person_FamilyName.ColumnName = "ACP_Person_FamilyName";
            // 
            // tbInvoice_GidenKutusu_ACP_Person_MiddleName
            // 
            this.tbInvoice_GidenKutusu_ACP_Person_MiddleName.ColumnName = "ACP_Person_MiddleName";
            // 
            // tbInvoice_GidenKutusu_ACP_Person_NameSuffix
            // 
            this.tbInvoice_GidenKutusu_ACP_Person_NameSuffix.ColumnName = "ACP_Person_NameSuffix";
            // 
            // tbInvoice_GidenKutusu_ACP_Person_Title
            // 
            this.tbInvoice_GidenKutusu_ACP_Person_Title.ColumnName = "ACP_Person_Title";
            // 
            // tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification1_schemeID
            // 
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification1_schemeID.ColumnName = "ACP_AgentParty_PartyIdentification1_schemeID";
            // 
            // tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification1_ID
            // 
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification1_ID.ColumnName = "ACP_AgentParty_PartyIdentification1_ID";
            // 
            // tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification2_schemeID
            // 
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification2_schemeID.ColumnName = "ACP_AgentParty_PartyIdentification2_schemeID";
            // 
            // tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification2_ID
            // 
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification2_ID.ColumnName = "ACP_AgentParty_PartyIdentification2_ID";
            // 
            // tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification3_schemeID
            // 
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification3_schemeID.ColumnName = "ACP_AgentParty_PartyIdentification3_schemeID";
            // 
            // tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification3_ID
            // 
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification3_ID.ColumnName = "ACP_AgentParty_PartyIdentification3_ID";
            // 
            // tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification4_schemeID
            // 
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification4_schemeID.ColumnName = "ACP_AgentParty_PartyIdentification4_schemeID";
            // 
            // tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification4_ID
            // 
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification4_ID.ColumnName = "ACP_AgentParty_PartyIdentification4_ID";
            // 
            // tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification5_schemeID
            // 
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification5_schemeID.ColumnName = "ACP_AgentParty_PartyIdentification5_schemeID";
            // 
            // tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification5_ID
            // 
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification5_ID.ColumnName = "ACP_AgentParty_PartyIdentification5_ID";
            // 
            // tbInvoice_GidenKutusu_ACP_AgentParty_PartyName
            // 
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyName.ColumnName = "ACP_AgentParty_PartyName";
            // 
            // tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_StreetName
            // 
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_StreetName.ColumnName = "ACP_AgentParty_PostalAddress_StreetName";
            // 
            // tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_Room
            // 
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_Room.ColumnName = "ACP_AgentParty_PostalAddress_Room";
            // 
            // tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_BuildingNumber
            // 
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_BuildingNumber.ColumnName = "ACP_AgentParty_PostalAddress_BuildingNumber";
            // 
            // tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_BuildingName
            // 
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_BuildingName.ColumnName = "ACP_AgentParty_PostalAddress_BuildingName";
            // 
            // tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_CitySubdivisionName
            // 
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_CitySubdivisionName.ColumnName = "ACP_AgentParty_PostalAddress_CitySubdivisionName";
            // 
            // tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_CityName
            // 
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_CityName.ColumnName = "ACP_AgentParty_PostalAddress_CityName";
            // 
            // tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_Country
            // 
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_Country.ColumnName = "ACP_AgentParty_PostalAddress_Country";
            // 
            // tbInvoice_GidenKutusu_ACP_AgentParty_PartyTaxSchemeName
            // 
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyTaxSchemeName.ColumnName = "ACP_AgentParty_PartyTaxSchemeName";
            // 
            // tbInvoice_GidenKutusu_ACP_AgentParty_PartyTaxSchemeTaxTypeCode
            // 
            this.tbInvoice_GidenKutusu_ACP_AgentParty_PartyTaxSchemeTaxTypeCode.ColumnName = "ACP_AgentParty_PartyTaxSchemeTaxTypeCode";
            // 
            // tbInvoice_GidenKutusu_ACP_AgentParty_WebsiteURI
            // 
            this.tbInvoice_GidenKutusu_ACP_AgentParty_WebsiteURI.ColumnName = "ACP_AgentParty_WebsiteURI";
            // 
            // tbInvoice_GidenKutusu_ACP_AgentParty_Contact_Telephone
            // 
            this.tbInvoice_GidenKutusu_ACP_AgentParty_Contact_Telephone.ColumnName = "ACP_AgentParty_Contact_Telephone";
            // 
            // tbInvoice_GidenKutusu_ACP_AgentParty_Contact_Telefax
            // 
            this.tbInvoice_GidenKutusu_ACP_AgentParty_Contact_Telefax.ColumnName = "ACP_AgentParty_Contact_Telefax";
            // 
            // tbInvoice_GidenKutusu_ACP_AgentParty_Contact_ElectronicMail
            // 
            this.tbInvoice_GidenKutusu_ACP_AgentParty_Contact_ElectronicMail.ColumnName = "ACP_AgentParty_Contact_ElectronicMail";
            // 
            // tbInvoice_GidenKutusu_ACP_AgentParty_Person_FirstName
            // 
            this.tbInvoice_GidenKutusu_ACP_AgentParty_Person_FirstName.ColumnName = "ACP_AgentParty_Person_FirstName";
            // 
            // tbInvoice_GidenKutusu_ACP_AgentParty_Person_FamilyName
            // 
            this.tbInvoice_GidenKutusu_ACP_AgentParty_Person_FamilyName.ColumnName = "ACP_AgentParty_Person_FamilyName";
            // 
            // tbInvoice_GidenKutusu_ACP_AgentParty_Person_MiddleName
            // 
            this.tbInvoice_GidenKutusu_ACP_AgentParty_Person_MiddleName.ColumnName = "ACP_AgentParty_Person_MiddleName";
            // 
            // tbInvoice_GidenKutusu_ACP_AgentParty_Person_NameSuffix
            // 
            this.tbInvoice_GidenKutusu_ACP_AgentParty_Person_NameSuffix.ColumnName = "ACP_AgentParty_Person_NameSuffix";
            // 
            // tbInvoice_GidenKutusu_ACP_AgentParty_Person_Title
            // 
            this.tbInvoice_GidenKutusu_ACP_AgentParty_Person_Title.ColumnName = "ACP_AgentParty_Person_Title";
            // 
            // tbInvoice_GidenKutusu_TaxExchangeRate_SourceCurrencyCode
            // 
            this.tbInvoice_GidenKutusu_TaxExchangeRate_SourceCurrencyCode.ColumnName = "TaxExchangeRate_SourceCurrencyCode";
            // 
            // tbInvoice_GidenKutusu_TaxExchangeRate_TargetCurrencyCode
            // 
            this.tbInvoice_GidenKutusu_TaxExchangeRate_TargetCurrencyCode.ColumnName = "TaxExchangeRate_TargetCurrencyCode";
            // 
            // tbInvoice_GidenKutusu_TaxExchangeRate_CalculationRate
            // 
            this.tbInvoice_GidenKutusu_TaxExchangeRate_CalculationRate.ColumnName = "TaxExchangeRate_CalculationRate";
            this.tbInvoice_GidenKutusu_TaxExchangeRate_CalculationRate.DataType = typeof(double);
            // 
            // tbInvoice_GidenKutusu_TaxExchangeRate_Date
            // 
            this.tbInvoice_GidenKutusu_TaxExchangeRate_Date.ColumnName = "TaxExchangeRate_Date";
            this.tbInvoice_GidenKutusu_TaxExchangeRate_Date.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_GidenKutusu_PricingExchangeRate_SourceCurrencyCode
            // 
            this.tbInvoice_GidenKutusu_PricingExchangeRate_SourceCurrencyCode.ColumnName = "PricingExchangeRate_SourceCurrencyCode";
            // 
            // tbInvoice_GidenKutusu_PricingExchangeRate_TargetCurrencyCode
            // 
            this.tbInvoice_GidenKutusu_PricingExchangeRate_TargetCurrencyCode.ColumnName = "PricingExchangeRate_TargetCurrencyCode";
            // 
            // tbInvoice_GidenKutusu_PricingExchangeRate_CalculationRate
            // 
            this.tbInvoice_GidenKutusu_PricingExchangeRate_CalculationRate.ColumnName = "PricingExchangeRate_CalculationRate";
            this.tbInvoice_GidenKutusu_PricingExchangeRate_CalculationRate.DataType = typeof(double);
            // 
            // tbInvoice_GidenKutusu_PricingExchangeRate_Date
            // 
            this.tbInvoice_GidenKutusu_PricingExchangeRate_Date.ColumnName = "PricingExchangeRate_Date";
            this.tbInvoice_GidenKutusu_PricingExchangeRate_Date.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_GidenKutusu_PaymentExchangeRate_SourceCurrencyCode
            // 
            this.tbInvoice_GidenKutusu_PaymentExchangeRate_SourceCurrencyCode.ColumnName = "PaymentExchangeRate_SourceCurrencyCode";
            // 
            // tbInvoice_GidenKutusu_PaymentExchangeRate_TargetCurrencyCode
            // 
            this.tbInvoice_GidenKutusu_PaymentExchangeRate_TargetCurrencyCode.ColumnName = "PaymentExchangeRate_TargetCurrencyCode";
            // 
            // tbInvoice_GidenKutusu_PaymentExchangeRate_CalculationRate
            // 
            this.tbInvoice_GidenKutusu_PaymentExchangeRate_CalculationRate.ColumnName = "PaymentExchangeRate_CalculationRate";
            this.tbInvoice_GidenKutusu_PaymentExchangeRate_CalculationRate.DataType = typeof(double);
            // 
            // tbInvoice_GidenKutusu_PaymentExchangeRate_Date
            // 
            this.tbInvoice_GidenKutusu_PaymentExchangeRate_Date.ColumnName = "PaymentExchangeRate_Date";
            this.tbInvoice_GidenKutusu_PaymentExchangeRate_Date.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_GidenKutusu_PaymentAlternativeExchangeRate_SourceCurrencyCode
            // 
            this.tbInvoice_GidenKutusu_PaymentAlternativeExchangeRate_SourceCurrencyCode.ColumnName = "PaymentAlternativeExchangeRate_SourceCurrencyCode";
            // 
            // tbInvoice_GidenKutusu_PaymentAlternativeExchangeRate_TargetCurrencyCode
            // 
            this.tbInvoice_GidenKutusu_PaymentAlternativeExchangeRate_TargetCurrencyCode.ColumnName = "PaymentAlternativeExchangeRate_TargetCurrencyCode";
            // 
            // tbInvoice_GidenKutusu_PaymentAlternativeExchangeRate_CalculationRate
            // 
            this.tbInvoice_GidenKutusu_PaymentAlternativeExchangeRate_CalculationRate.ColumnName = "PaymentAlternativeExchangeRate_CalculationRate";
            this.tbInvoice_GidenKutusu_PaymentAlternativeExchangeRate_CalculationRate.DataType = typeof(double);
            // 
            // tbInvoice_GidenKutusu_PaymentAlternativeExchangeRate_Date
            // 
            this.tbInvoice_GidenKutusu_PaymentAlternativeExchangeRate_Date.ColumnName = "PaymentAlternativeExchangeRate_Date";
            this.tbInvoice_GidenKutusu_PaymentAlternativeExchangeRate_Date.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_GidenKutusu_TaxAmount
            // 
            this.tbInvoice_GidenKutusu_TaxAmount.ColumnName = "TaxAmount";
            this.tbInvoice_GidenKutusu_TaxAmount.DataType = typeof(double);
            // 
            // tbInvoice_GidenKutusu_LegalMonetaryTotal_LineExtensionAmount
            // 
            this.tbInvoice_GidenKutusu_LegalMonetaryTotal_LineExtensionAmount.ColumnName = "LegalMonetaryTotal_LineExtensionAmount";
            this.tbInvoice_GidenKutusu_LegalMonetaryTotal_LineExtensionAmount.DataType = typeof(double);
            // 
            // tbInvoice_GidenKutusu_LegalMonetaryTotal_TaxExclusiveAmount
            // 
            this.tbInvoice_GidenKutusu_LegalMonetaryTotal_TaxExclusiveAmount.ColumnName = "LegalMonetaryTotal_TaxExclusiveAmount";
            this.tbInvoice_GidenKutusu_LegalMonetaryTotal_TaxExclusiveAmount.DataType = typeof(double);
            // 
            // tbInvoice_GidenKutusu_LegalMonetaryTotal_TaxInclusiveAmount
            // 
            this.tbInvoice_GidenKutusu_LegalMonetaryTotal_TaxInclusiveAmount.ColumnName = "LegalMonetaryTotal_TaxInclusiveAmount";
            this.tbInvoice_GidenKutusu_LegalMonetaryTotal_TaxInclusiveAmount.DataType = typeof(double);
            // 
            // tbInvoice_GidenKutusu_LegalMonetaryTotal_AllowanceTotalAmount
            // 
            this.tbInvoice_GidenKutusu_LegalMonetaryTotal_AllowanceTotalAmount.ColumnName = "LegalMonetaryTotal_AllowanceTotalAmount";
            this.tbInvoice_GidenKutusu_LegalMonetaryTotal_AllowanceTotalAmount.DataType = typeof(double);
            // 
            // tbInvoice_GidenKutusu_LegalMonetaryTotal_ChargeTotalAmount
            // 
            this.tbInvoice_GidenKutusu_LegalMonetaryTotal_ChargeTotalAmount.ColumnName = "LegalMonetaryTotal_ChargeTotalAmount";
            this.tbInvoice_GidenKutusu_LegalMonetaryTotal_ChargeTotalAmount.DataType = typeof(double);
            // 
            // tbInvoice_GidenKutusu_LegalMonetaryTotal_PayableRoundingAmount
            // 
            this.tbInvoice_GidenKutusu_LegalMonetaryTotal_PayableRoundingAmount.ColumnName = "LegalMonetaryTotal_PayableRoundingAmount";
            this.tbInvoice_GidenKutusu_LegalMonetaryTotal_PayableRoundingAmount.DataType = typeof(double);
            // 
            // tbInvoice_GidenKutusu_LegalMonetaryTotal_PayableAmount
            // 
            this.tbInvoice_GidenKutusu_LegalMonetaryTotal_PayableAmount.ColumnName = "LegalMonetaryTotal_PayableAmount";
            this.tbInvoice_GidenKutusu_LegalMonetaryTotal_PayableAmount.DataType = typeof(double);
            // 
            // tbInvoice_GidenKutusu_WithholdingTaxAmount
            // 
            this.tbInvoice_GidenKutusu_WithholdingTaxAmount.ColumnName = "WithholdingTaxAmount";
            this.tbInvoice_GidenKutusu_WithholdingTaxAmount.DataType = typeof(double);
            // 
            // sqlCommand9
            // 
            this.sqlCommand9.CommandText = "SELECT * FROM Invoice WHERE Deleted = 0 AND IOType=0 AND LocalStatus<=0\r\nAND Issu" +
    "eDate BETWEEN @FormDate1 AND @FormDate2 ";
            this.sqlCommand9.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FormDate1", System.Data.SqlDbType.DateTime),
            new System.Data.SqlClient.SqlParameter("@FormDate2", System.Data.SqlDbType.DateTime)});
            // 
            // grGidenKutusuView
            // 
            this.grGidenKutusuView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn19,
            this.gridColumn20,
            this.gridColumn21,
            this.gridColumn22,
            this.gridColumn23,
            this.gridColumn24,
            this.gridColumn25,
            this.gridColumn26,
            this.gridColumn27,
            this.gridColumn28,
            this.gridColumn29,
            this.gridColumn30,
            this.gridColumn31,
            this.gridColumn32,
            this.gridColumn33,
            this.gridColumn34,
            this.gridColumn35,
            this.gridColumn36,
            this.gridColumn37,
            this.gridColumn38,
            this.gridColumn39,
            this.gridColumn40,
            this.gridColumn41,
            this.gridColumn42,
            this.gridColumn43,
            this.gridColumn44,
            this.gridColumn45,
            this.gridColumn46,
            this.gridColumn47,
            this.gridColumn48,
            this.gridColumn49,
            this.gridColumn50,
            this.gridColumn51,
            this.gridColumn52,
            this.gridColumn53,
            this.gridColumn54,
            this.gridColumn55,
            this.gridColumn56,
            this.gridColumn57,
            this.gridColumn58,
            this.gridColumn59,
            this.gridColumn60,
            this.gridColumn61,
            this.gridColumn62,
            this.gridColumn63,
            this.gridColumn64,
            this.gridColumn65,
            this.gridColumn66,
            this.gridColumn67,
            this.gridColumn68,
            this.gridColumn69,
            this.gridColumn70,
            this.gridColumn71,
            this.gridColumn72,
            this.gridColumn73,
            this.gridColumn74,
            this.gridColumn75,
            this.gridColumn76,
            this.gridColumn77,
            this.gridColumn78,
            this.gridColumn79,
            this.gridColumn80,
            this.gridColumn81,
            this.gridColumn82,
            this.gridColumn83,
            this.gridColumn84,
            this.gridColumn85,
            this.gridColumn86,
            this.gridColumn87,
            this.gridColumn88,
            this.gridColumn89,
            this.gridColumn90,
            this.gridColumn91,
            this.gridColumn92,
            this.gridColumn93,
            this.gridColumn94,
            this.gridColumn95,
            this.gridColumn96,
            this.gridColumn97,
            this.gridColumn98,
            this.gridColumn99,
            this.gridColumn100,
            this.gridColumn101,
            this.gridColumn102,
            this.gridColumn103,
            this.gridColumn104,
            this.gridColumn105,
            this.gridColumn106,
            this.gridColumn107,
            this.gridColumn108,
            this.gridColumn109,
            this.gridColumn110,
            this.gridColumn111,
            this.gridColumn112,
            this.gridColumn113,
            this.gridColumn114,
            this.gridColumn115,
            this.gridColumn116,
            this.gridColumn117,
            this.gridColumn118,
            this.gridColumn119,
            this.gridColumn120,
            this.gridColumn121,
            this.gridColumn122,
            this.gridColumn123,
            this.gridColumn124,
            this.gridColumn125,
            this.gridColumn126,
            this.gridColumn127,
            this.gridColumn128,
            this.gridColumn129,
            this.gridColumn130,
            this.gridColumn131,
            this.gridColumn132,
            this.gridColumn133,
            this.gridColumn134,
            this.gridColumn135,
            this.gridColumn136,
            this.colLegalMonetaryTotal_ChargeTotalAmount1,
            this.gridColumn137,
            this.gridColumn275,
            this.gridColumn276});
            this.grGidenKutusuView.GridControl = this.grGidenKutusu;
            this.grGidenKutusuView.Name = "grGidenKutusuView";
            this.grGidenKutusuView.OptionsBehavior.Editable = false;
            this.grGidenKutusuView.OptionsLayout.LayoutVersion = "1.2";
            this.grGidenKutusuView.OptionsSelection.MultiSelect = true;
            this.grGidenKutusuView.OptionsView.ColumnAutoWidth = false;
            this.grGidenKutusuView.OptionsView.ShowAutoFilterRow = true;
            this.grGidenKutusuView.OptionsView.ShowFooter = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "InvoiceID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "IntegratorID";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Width = 159;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "IOType";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Width = 81;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "CreatedBy";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "CreatedDate";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "ModifiedBy";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "ModifiedDate";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // gridColumn8
            // 
            this.gridColumn8.FieldName = "LocalStatus";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Durum";
            this.gridColumn9.FieldName = "Status";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Width = 74;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Durum aciklama";
            this.gridColumn10.FieldName = "StatusDescription";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "StatusDescription", "{0}")});
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 3;
            this.gridColumn10.Width = 159;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Posta kutusu";
            this.gridColumn11.FieldName = "PostBox";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Width = 142;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Senaryo";
            this.gridColumn12.FieldName = "ProfileID";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 4;
            this.gridColumn12.Width = 107;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "ID (Fatura no)";
            this.gridColumn13.FieldName = "ID";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 5;
            this.gridColumn13.Width = 166;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Fatura tarihi";
            this.gridColumn14.DisplayFormat.FormatString = "dd.MM.yyyy";
            this.gridColumn14.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn14.FieldName = "IssueDate";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 6;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Saati";
            this.gridColumn15.DisplayFormat.FormatString = "HH:mm";
            this.gridColumn15.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn15.FieldName = "IssueTime";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 18;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Türü";
            this.gridColumn16.FieldName = "InvoiceTypeCode";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 7;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Para birimi";
            this.gridColumn17.FieldName = "DocumentCurrencyCode";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 8;
            // 
            // gridColumn18
            // 
            this.gridColumn18.FieldName = "TaxCurrencyCode";
            this.gridColumn18.Name = "gridColumn18";
            // 
            // gridColumn19
            // 
            this.gridColumn19.FieldName = "PricingCurrencyCode";
            this.gridColumn19.Name = "gridColumn19";
            // 
            // gridColumn20
            // 
            this.gridColumn20.FieldName = "PaymentCurrencyCode";
            this.gridColumn20.Name = "gridColumn20";
            // 
            // gridColumn21
            // 
            this.gridColumn21.FieldName = "PaymentAlternativeCurrencyCode";
            this.gridColumn21.Name = "gridColumn21";
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "#Satır";
            this.gridColumn22.FieldName = "LineCountNumeric";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 9;
            this.gridColumn22.Width = 93;
            // 
            // gridColumn23
            // 
            this.gridColumn23.FieldName = "InvoicePeriod_StartDate";
            this.gridColumn23.Name = "gridColumn23";
            // 
            // gridColumn24
            // 
            this.gridColumn24.FieldName = "InvoicePeriod_EndDate";
            this.gridColumn24.Name = "gridColumn24";
            // 
            // gridColumn25
            // 
            this.gridColumn25.FieldName = "InvoicePeriod_DurationMeasure";
            this.gridColumn25.Name = "gridColumn25";
            // 
            // gridColumn26
            // 
            this.gridColumn26.FieldName = "InvoicePeriod_Description";
            this.gridColumn26.Name = "gridColumn26";
            // 
            // gridColumn27
            // 
            this.gridColumn27.Caption = "Tedarikci VKTuru";
            this.gridColumn27.FieldName = "ASP_PartyIdentification1_schemeID";
            this.gridColumn27.Name = "gridColumn27";
            this.gridColumn27.Visible = true;
            this.gridColumn27.VisibleIndex = 22;
            this.gridColumn27.Width = 109;
            // 
            // gridColumn28
            // 
            this.gridColumn28.Caption = "Tedarikci  Vergi No";
            this.gridColumn28.FieldName = "ASP_PartyIdentification1_ID";
            this.gridColumn28.Name = "gridColumn28";
            this.gridColumn28.Visible = true;
            this.gridColumn28.VisibleIndex = 23;
            this.gridColumn28.Width = 126;
            // 
            // gridColumn29
            // 
            this.gridColumn29.FieldName = "ASP_PartyIdentification2_schemeID";
            this.gridColumn29.Name = "gridColumn29";
            // 
            // gridColumn30
            // 
            this.gridColumn30.FieldName = "ASP_PartyIdentification2_ID";
            this.gridColumn30.Name = "gridColumn30";
            // 
            // gridColumn31
            // 
            this.gridColumn31.FieldName = "ASP_PartyIdentification3_schemeID";
            this.gridColumn31.Name = "gridColumn31";
            // 
            // gridColumn32
            // 
            this.gridColumn32.FieldName = "ASP_PartyIdentification3_ID";
            this.gridColumn32.Name = "gridColumn32";
            // 
            // gridColumn33
            // 
            this.gridColumn33.FieldName = "ASP_PartyIdentification4_schemeID";
            this.gridColumn33.Name = "gridColumn33";
            // 
            // gridColumn34
            // 
            this.gridColumn34.FieldName = "ASP_PartyIdentification4_ID";
            this.gridColumn34.Name = "gridColumn34";
            // 
            // gridColumn35
            // 
            this.gridColumn35.FieldName = "ASP_PartyIdentification5_schemeID";
            this.gridColumn35.Name = "gridColumn35";
            // 
            // gridColumn36
            // 
            this.gridColumn36.FieldName = "ASP_PartyIdentification5_ID";
            this.gridColumn36.Name = "gridColumn36";
            // 
            // gridColumn37
            // 
            this.gridColumn37.Caption = "Tedarikçi ünvan";
            this.gridColumn37.FieldName = "ASP_PartyName";
            this.gridColumn37.Name = "gridColumn37";
            this.gridColumn37.Visible = true;
            this.gridColumn37.VisibleIndex = 0;
            // 
            // gridColumn38
            // 
            this.gridColumn38.FieldName = "ASP_PostalAddress_StreetName";
            this.gridColumn38.Name = "gridColumn38";
            // 
            // gridColumn39
            // 
            this.gridColumn39.FieldName = "ASP_PostalAddress_Room";
            this.gridColumn39.Name = "gridColumn39";
            // 
            // gridColumn40
            // 
            this.gridColumn40.FieldName = "ASP_PostalAddress_BuildingNumber";
            this.gridColumn40.Name = "gridColumn40";
            // 
            // gridColumn41
            // 
            this.gridColumn41.FieldName = "ASP_PostalAddress_CitySubdivisionName";
            this.gridColumn41.Name = "gridColumn41";
            // 
            // gridColumn42
            // 
            this.gridColumn42.FieldName = "ASP_PostalAddress_CityName";
            this.gridColumn42.Name = "gridColumn42";
            // 
            // gridColumn43
            // 
            this.gridColumn43.FieldName = "ASP_PostalAddress_Country";
            this.gridColumn43.Name = "gridColumn43";
            // 
            // gridColumn44
            // 
            this.gridColumn44.Caption = "Tedarikci Vergi D.";
            this.gridColumn44.FieldName = "ASP_PartyTaxScheme";
            this.gridColumn44.Name = "gridColumn44";
            this.gridColumn44.Visible = true;
            this.gridColumn44.VisibleIndex = 24;
            // 
            // gridColumn45
            // 
            this.gridColumn45.FieldName = "ASP_Contact_Telephone";
            this.gridColumn45.Name = "gridColumn45";
            // 
            // gridColumn46
            // 
            this.gridColumn46.FieldName = "ASP_Contact_Telefax";
            this.gridColumn46.Name = "gridColumn46";
            // 
            // gridColumn47
            // 
            this.gridColumn47.FieldName = "ASP_Contact_ElectronicMail";
            this.gridColumn47.Name = "gridColumn47";
            // 
            // gridColumn48
            // 
            this.gridColumn48.FieldName = "ASP_Person_FirstName";
            this.gridColumn48.Name = "gridColumn48";
            // 
            // gridColumn49
            // 
            this.gridColumn49.FieldName = "ASP_Person_FamilyName";
            this.gridColumn49.Name = "gridColumn49";
            // 
            // gridColumn50
            // 
            this.gridColumn50.FieldName = "ASP_AgentParty_PartyIdentification1_schemeID";
            this.gridColumn50.Name = "gridColumn50";
            // 
            // gridColumn51
            // 
            this.gridColumn51.FieldName = "ASP_AgentParty_PartyIdentification1_ID";
            this.gridColumn51.Name = "gridColumn51";
            // 
            // gridColumn52
            // 
            this.gridColumn52.FieldName = "ASP_AgentParty_PartyIdentification2_schemeID";
            this.gridColumn52.Name = "gridColumn52";
            // 
            // gridColumn53
            // 
            this.gridColumn53.FieldName = "ASP_AgentParty_PartyIdentification2_ID";
            this.gridColumn53.Name = "gridColumn53";
            // 
            // gridColumn54
            // 
            this.gridColumn54.FieldName = "ASP_AgentParty_PartyIdentification3_schemeID";
            this.gridColumn54.Name = "gridColumn54";
            // 
            // gridColumn55
            // 
            this.gridColumn55.FieldName = "ASP_AgentParty_PartyIdentification3_ID";
            this.gridColumn55.Name = "gridColumn55";
            // 
            // gridColumn56
            // 
            this.gridColumn56.FieldName = "ASP_AgentParty_PartyIdentification4_schemeID";
            this.gridColumn56.Name = "gridColumn56";
            // 
            // gridColumn57
            // 
            this.gridColumn57.FieldName = "ASP_AgentParty_PartyIdentification4_ID";
            this.gridColumn57.Name = "gridColumn57";
            // 
            // gridColumn58
            // 
            this.gridColumn58.FieldName = "ASP_AgentParty_PartyIdentification5_schemeID";
            this.gridColumn58.Name = "gridColumn58";
            // 
            // gridColumn59
            // 
            this.gridColumn59.FieldName = "ASP_AgentParty_PartyIdentification5_ID";
            this.gridColumn59.Name = "gridColumn59";
            // 
            // gridColumn60
            // 
            this.gridColumn60.FieldName = "ASP_AgentParty_PartyName";
            this.gridColumn60.Name = "gridColumn60";
            // 
            // gridColumn61
            // 
            this.gridColumn61.FieldName = "ASP_AgentParty_PostalAddress_StreetName";
            this.gridColumn61.Name = "gridColumn61";
            // 
            // gridColumn62
            // 
            this.gridColumn62.FieldName = "ASP_AgentParty_PostalAddress_Room";
            this.gridColumn62.Name = "gridColumn62";
            // 
            // gridColumn63
            // 
            this.gridColumn63.FieldName = "ASP_AgentParty_PostalAddress_BuildingNumber";
            this.gridColumn63.Name = "gridColumn63";
            // 
            // gridColumn64
            // 
            this.gridColumn64.FieldName = "ASP_AgentParty_PostalAddress_CitySubdivisionName";
            this.gridColumn64.Name = "gridColumn64";
            // 
            // gridColumn65
            // 
            this.gridColumn65.FieldName = "ASP_AgentParty_PostalAddress_CityName";
            this.gridColumn65.Name = "gridColumn65";
            // 
            // gridColumn66
            // 
            this.gridColumn66.FieldName = "ASP_AgentParty_PostalAddress_Country";
            this.gridColumn66.Name = "gridColumn66";
            // 
            // gridColumn67
            // 
            this.gridColumn67.FieldName = "ASP_AgentParty_PartyTaxScheme";
            this.gridColumn67.Name = "gridColumn67";
            // 
            // gridColumn68
            // 
            this.gridColumn68.FieldName = "ASP_AgentParty_Contact_Telephone";
            this.gridColumn68.Name = "gridColumn68";
            // 
            // gridColumn69
            // 
            this.gridColumn69.FieldName = "ASP_AgentParty_Contact_Telefax";
            this.gridColumn69.Name = "gridColumn69";
            // 
            // gridColumn70
            // 
            this.gridColumn70.FieldName = "ASP_AgentParty_Contact_ElectronicMail";
            this.gridColumn70.Name = "gridColumn70";
            // 
            // gridColumn71
            // 
            this.gridColumn71.Caption = "Musteri VKTuru";
            this.gridColumn71.FieldName = "ACP_PartyIdentification1_schemeID";
            this.gridColumn71.Name = "gridColumn71";
            this.gridColumn71.Visible = true;
            this.gridColumn71.VisibleIndex = 20;
            this.gridColumn71.Width = 101;
            // 
            // gridColumn72
            // 
            this.gridColumn72.Caption = "Musteri Vergi No";
            this.gridColumn72.FieldName = "ACP_PartyIdentification1_ID";
            this.gridColumn72.Name = "gridColumn72";
            this.gridColumn72.Visible = true;
            this.gridColumn72.VisibleIndex = 21;
            this.gridColumn72.Width = 114;
            // 
            // gridColumn73
            // 
            this.gridColumn73.FieldName = "ACP_PartyIdentification2_schemeID";
            this.gridColumn73.Name = "gridColumn73";
            // 
            // gridColumn74
            // 
            this.gridColumn74.FieldName = "ACP_PartyIdentification2_ID";
            this.gridColumn74.Name = "gridColumn74";
            // 
            // gridColumn75
            // 
            this.gridColumn75.FieldName = "ACP_PartyIdentification3_schemeID";
            this.gridColumn75.Name = "gridColumn75";
            // 
            // gridColumn76
            // 
            this.gridColumn76.FieldName = "ACP_PartyIdentification3_ID";
            this.gridColumn76.Name = "gridColumn76";
            // 
            // gridColumn77
            // 
            this.gridColumn77.FieldName = "ACP_PartyIdentification4_schemeID";
            this.gridColumn77.Name = "gridColumn77";
            // 
            // gridColumn78
            // 
            this.gridColumn78.FieldName = "ACP_PartyIdentification4_ID";
            this.gridColumn78.Name = "gridColumn78";
            // 
            // gridColumn79
            // 
            this.gridColumn79.FieldName = "ACP_PartyIdentification5_schemeID";
            this.gridColumn79.Name = "gridColumn79";
            // 
            // gridColumn80
            // 
            this.gridColumn80.FieldName = "ACP_PartyIdentification5_ID";
            this.gridColumn80.Name = "gridColumn80";
            // 
            // gridColumn81
            // 
            this.gridColumn81.Caption = "Müşteri ünvan";
            this.gridColumn81.FieldName = "ACP_PartyName";
            this.gridColumn81.Name = "gridColumn81";
            this.gridColumn81.Visible = true;
            this.gridColumn81.VisibleIndex = 1;
            this.gridColumn81.Width = 222;
            // 
            // gridColumn82
            // 
            this.gridColumn82.FieldName = "ACP_PostalAddress_StreetName";
            this.gridColumn82.Name = "gridColumn82";
            // 
            // gridColumn83
            // 
            this.gridColumn83.FieldName = "ACP_PostalAddress_Room";
            this.gridColumn83.Name = "gridColumn83";
            // 
            // gridColumn84
            // 
            this.gridColumn84.FieldName = "ACP_PostalAddress_BuildingNumber";
            this.gridColumn84.Name = "gridColumn84";
            // 
            // gridColumn85
            // 
            this.gridColumn85.FieldName = "ACP_PostalAddress_CitySubdivisionName";
            this.gridColumn85.Name = "gridColumn85";
            // 
            // gridColumn86
            // 
            this.gridColumn86.FieldName = "ACP_PostalAddress_CityName";
            this.gridColumn86.Name = "gridColumn86";
            // 
            // gridColumn87
            // 
            this.gridColumn87.FieldName = "ACP_PostalAddress_Country";
            this.gridColumn87.Name = "gridColumn87";
            // 
            // gridColumn88
            // 
            this.gridColumn88.Caption = "Musteri Veri D.";
            this.gridColumn88.FieldName = "ACP_PartyTaxScheme";
            this.gridColumn88.Name = "gridColumn88";
            this.gridColumn88.Visible = true;
            this.gridColumn88.VisibleIndex = 19;
            // 
            // gridColumn89
            // 
            this.gridColumn89.FieldName = "ACP_Contact_Telephone";
            this.gridColumn89.Name = "gridColumn89";
            // 
            // gridColumn90
            // 
            this.gridColumn90.FieldName = "ACP_Contact_Telefax";
            this.gridColumn90.Name = "gridColumn90";
            // 
            // gridColumn91
            // 
            this.gridColumn91.FieldName = "ACP_Contact_ElectronicMail";
            this.gridColumn91.Name = "gridColumn91";
            // 
            // gridColumn92
            // 
            this.gridColumn92.FieldName = "ACP_Person_FirstName";
            this.gridColumn92.Name = "gridColumn92";
            // 
            // gridColumn93
            // 
            this.gridColumn93.FieldName = "ACP_Person_FamilyName";
            this.gridColumn93.Name = "gridColumn93";
            // 
            // gridColumn94
            // 
            this.gridColumn94.FieldName = "ACP_AgentParty_PartyIdentification1_schemeID";
            this.gridColumn94.Name = "gridColumn94";
            // 
            // gridColumn95
            // 
            this.gridColumn95.FieldName = "ACP_AgentParty_PartyIdentification1_ID";
            this.gridColumn95.Name = "gridColumn95";
            // 
            // gridColumn96
            // 
            this.gridColumn96.FieldName = "ACP_AgentParty_PartyIdentification2_schemeID";
            this.gridColumn96.Name = "gridColumn96";
            // 
            // gridColumn97
            // 
            this.gridColumn97.FieldName = "ACP_AgentParty_PartyIdentification2_ID";
            this.gridColumn97.Name = "gridColumn97";
            // 
            // gridColumn98
            // 
            this.gridColumn98.FieldName = "ACP_AgentParty_PartyIdentification3_schemeID";
            this.gridColumn98.Name = "gridColumn98";
            // 
            // gridColumn99
            // 
            this.gridColumn99.FieldName = "ACP_AgentParty_PartyIdentification3_ID";
            this.gridColumn99.Name = "gridColumn99";
            // 
            // gridColumn100
            // 
            this.gridColumn100.FieldName = "ACP_AgentParty_PartyIdentification4_schemeID";
            this.gridColumn100.Name = "gridColumn100";
            // 
            // gridColumn101
            // 
            this.gridColumn101.FieldName = "ACP_AgentParty_PartyIdentification4_ID";
            this.gridColumn101.Name = "gridColumn101";
            // 
            // gridColumn102
            // 
            this.gridColumn102.FieldName = "ACP_AgentParty_PartyIdentification5_schemeID";
            this.gridColumn102.Name = "gridColumn102";
            // 
            // gridColumn103
            // 
            this.gridColumn103.FieldName = "ACP_AgentParty_PartyIdentification5_ID";
            this.gridColumn103.Name = "gridColumn103";
            // 
            // gridColumn104
            // 
            this.gridColumn104.FieldName = "ACP_AgentParty_PartyName";
            this.gridColumn104.Name = "gridColumn104";
            // 
            // gridColumn105
            // 
            this.gridColumn105.FieldName = "ACP_AgentParty_PostalAddress_StreetName";
            this.gridColumn105.Name = "gridColumn105";
            // 
            // gridColumn106
            // 
            this.gridColumn106.FieldName = "ACP_AgentParty_PostalAddress_Room";
            this.gridColumn106.Name = "gridColumn106";
            // 
            // gridColumn107
            // 
            this.gridColumn107.FieldName = "ACP_AgentParty_PostalAddress_BuildingNumber";
            this.gridColumn107.Name = "gridColumn107";
            // 
            // gridColumn108
            // 
            this.gridColumn108.FieldName = "ACP_AgentParty_PostalAddress_CitySubdivisionName";
            this.gridColumn108.Name = "gridColumn108";
            // 
            // gridColumn109
            // 
            this.gridColumn109.FieldName = "ACP_AgentParty_PostalAddress_CityName";
            this.gridColumn109.Name = "gridColumn109";
            // 
            // gridColumn110
            // 
            this.gridColumn110.FieldName = "ACP_AgentParty_PostalAddress_Country";
            this.gridColumn110.Name = "gridColumn110";
            // 
            // gridColumn111
            // 
            this.gridColumn111.FieldName = "ACP_AgentParty_PartyTaxScheme";
            this.gridColumn111.Name = "gridColumn111";
            // 
            // gridColumn112
            // 
            this.gridColumn112.FieldName = "ACP_AgentParty_Contact_Telephone";
            this.gridColumn112.Name = "gridColumn112";
            // 
            // gridColumn113
            // 
            this.gridColumn113.FieldName = "ACP_AgentParty_Contact_Telefax";
            this.gridColumn113.Name = "gridColumn113";
            // 
            // gridColumn114
            // 
            this.gridColumn114.FieldName = "ACP_AgentParty_Contact_ElectronicMail";
            this.gridColumn114.Name = "gridColumn114";
            // 
            // gridColumn115
            // 
            this.gridColumn115.FieldName = "TaxExchangeRate_SourceCurrencyCode";
            this.gridColumn115.Name = "gridColumn115";
            // 
            // gridColumn116
            // 
            this.gridColumn116.FieldName = "TaxExchangeRate_TargetCurrencyCode";
            this.gridColumn116.Name = "gridColumn116";
            // 
            // gridColumn117
            // 
            this.gridColumn117.FieldName = "TaxExchangeRate_CalculationRate";
            this.gridColumn117.Name = "gridColumn117";
            // 
            // gridColumn118
            // 
            this.gridColumn118.FieldName = "TaxExchangeRate_Date";
            this.gridColumn118.Name = "gridColumn118";
            // 
            // gridColumn119
            // 
            this.gridColumn119.FieldName = "PricingExchangeRate_SourceCurrencyCode";
            this.gridColumn119.Name = "gridColumn119";
            // 
            // gridColumn120
            // 
            this.gridColumn120.FieldName = "PricingExchangeRate_TargetCurrencyCode";
            this.gridColumn120.Name = "gridColumn120";
            // 
            // gridColumn121
            // 
            this.gridColumn121.FieldName = "PricingExchangeRate_CalculationRate";
            this.gridColumn121.Name = "gridColumn121";
            // 
            // gridColumn122
            // 
            this.gridColumn122.FieldName = "PricingExchangeRate_Date";
            this.gridColumn122.Name = "gridColumn122";
            // 
            // gridColumn123
            // 
            this.gridColumn123.FieldName = "PaymentExchangeRate_SourceCurrencyCode";
            this.gridColumn123.Name = "gridColumn123";
            // 
            // gridColumn124
            // 
            this.gridColumn124.FieldName = "PaymentExchangeRate_TargetCurrencyCode";
            this.gridColumn124.Name = "gridColumn124";
            // 
            // gridColumn125
            // 
            this.gridColumn125.FieldName = "PaymentExchangeRate_CalculationRate";
            this.gridColumn125.Name = "gridColumn125";
            // 
            // gridColumn126
            // 
            this.gridColumn126.FieldName = "PaymentExchangeRate_Date";
            this.gridColumn126.Name = "gridColumn126";
            // 
            // gridColumn127
            // 
            this.gridColumn127.FieldName = "PaymentAlternativeExchangeRate_SourceCurrencyCode";
            this.gridColumn127.Name = "gridColumn127";
            // 
            // gridColumn128
            // 
            this.gridColumn128.FieldName = "PaymentAlternativeExchangeRate_TargetCurrencyCode";
            this.gridColumn128.Name = "gridColumn128";
            // 
            // gridColumn129
            // 
            this.gridColumn129.FieldName = "PaymentAlternativeExchangeRate_CalculationRate";
            this.gridColumn129.Name = "gridColumn129";
            // 
            // gridColumn130
            // 
            this.gridColumn130.FieldName = "PaymentAlternativeExchangeRate_Date";
            this.gridColumn130.Name = "gridColumn130";
            // 
            // gridColumn131
            // 
            this.gridColumn131.Caption = "Vergi Toplamı";
            this.gridColumn131.FieldName = "TaxAmount";
            this.gridColumn131.Name = "gridColumn131";
            this.gridColumn131.Visible = true;
            this.gridColumn131.VisibleIndex = 10;
            // 
            // gridColumn132
            // 
            this.gridColumn132.FieldName = "UUID";
            this.gridColumn132.Name = "gridColumn132";
            this.gridColumn132.Width = 230;
            // 
            // gridColumn133
            // 
            this.gridColumn133.Caption = "Satır toplamı";
            this.gridColumn133.FieldName = "LegalMonetaryTotal_LineExtensionAmount";
            this.gridColumn133.Name = "gridColumn133";
            this.gridColumn133.Visible = true;
            this.gridColumn133.VisibleIndex = 11;
            // 
            // gridColumn134
            // 
            this.gridColumn134.Caption = "Vergi hariç toplam";
            this.gridColumn134.FieldName = "LegalMonetaryTotal_TaxExclusiveAmount";
            this.gridColumn134.Name = "gridColumn134";
            this.gridColumn134.Visible = true;
            this.gridColumn134.VisibleIndex = 12;
            // 
            // gridColumn135
            // 
            this.gridColumn135.Caption = "Vergi dahil toplam";
            this.gridColumn135.FieldName = "LegalMonetaryTotal_TaxInclusiveAmount";
            this.gridColumn135.Name = "gridColumn135";
            this.gridColumn135.Visible = true;
            this.gridColumn135.VisibleIndex = 13;
            // 
            // gridColumn136
            // 
            this.gridColumn136.Caption = "Toplam indirim";
            this.gridColumn136.FieldName = "LegalMonetaryTotal_AllowanceTotalAmount";
            this.gridColumn136.Name = "gridColumn136";
            this.gridColumn136.Visible = true;
            this.gridColumn136.VisibleIndex = 14;
            // 
            // colLegalMonetaryTotal_ChargeTotalAmount1
            // 
            this.colLegalMonetaryTotal_ChargeTotalAmount1.Caption = "Toplam Masraf";
            this.colLegalMonetaryTotal_ChargeTotalAmount1.FieldName = "LegalMonetaryTotal_ChargeTotalAmount";
            this.colLegalMonetaryTotal_ChargeTotalAmount1.Name = "colLegalMonetaryTotal_ChargeTotalAmount1";
            this.colLegalMonetaryTotal_ChargeTotalAmount1.Visible = true;
            this.colLegalMonetaryTotal_ChargeTotalAmount1.VisibleIndex = 15;
            // 
            // gridColumn137
            // 
            this.gridColumn137.Caption = "Yuvarlama";
            this.gridColumn137.FieldName = "LegalMonetaryTotal_PayableRoundingAmount";
            this.gridColumn137.Name = "gridColumn137";
            this.gridColumn137.Visible = true;
            this.gridColumn137.VisibleIndex = 16;
            // 
            // gridColumn275
            // 
            this.gridColumn275.Caption = "Ödenecek tutar";
            this.gridColumn275.FieldName = "LegalMonetaryTotal_PayableAmount";
            this.gridColumn275.Name = "gridColumn275";
            this.gridColumn275.Visible = true;
            this.gridColumn275.VisibleIndex = 17;
            // 
            // gridColumn276
            // 
            this.gridColumn276.FieldName = "IntCode";
            this.gridColumn276.Name = "gridColumn276";
            this.gridColumn276.Visible = true;
            this.gridColumn276.VisibleIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGidecekFaturalariGonder);
            this.panel3.Controls.Add(this.btnSyncOutgoingInvoice);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(978, 50);
            this.panel3.TabIndex = 3;
            // 
            // btnGidecekFaturalariGonder
            // 
            this.btnGidecekFaturalariGonder.Location = new System.Drawing.Point(272, 12);
            this.btnGidecekFaturalariGonder.Margin = new System.Windows.Forms.Padding(2);
            this.btnGidecekFaturalariGonder.Name = "btnGidecekFaturalariGonder";
            this.btnGidecekFaturalariGonder.Size = new System.Drawing.Size(208, 32);
            this.btnGidecekFaturalariGonder.TabIndex = 5;
            this.btnGidecekFaturalariGonder.Text = "Listedeki tum faturalari gonder ->>";
            this.btnGidecekFaturalariGonder.Click += new System.EventHandler(this.btnGidecekFaturalariGonder_Click);
            // 
            // btnSyncOutgoingInvoice
            // 
            this.btnSyncOutgoingInvoice.Location = new System.Drawing.Point(8, 12);
            this.btnSyncOutgoingInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.btnSyncOutgoingInvoice.Name = "btnSyncOutgoingInvoice";
            this.btnSyncOutgoingInvoice.Size = new System.Drawing.Size(153, 32);
            this.btnSyncOutgoingInvoice.TabIndex = 1;
            this.btnSyncOutgoingInvoice.Text = "Gidecek faturalari al";
            this.btnSyncOutgoingInvoice.Click += new System.EventHandler(this.btnSyncOutgoingInvoice_Click);
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.grGonderilmisler);
            this.xtraTabPage3.Controls.Add(this.panel4);
            this.xtraTabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(978, 348);
            this.xtraTabPage3.Text = "Gönderilmişler";
            // 
            // grGonderilmisler
            // 
            this.grGonderilmisler.ContextMenuStrip = this.conMenuGonderilmis;
            this.grGonderilmisler.DataSource = this.tbInvoice_Gonderilmisler;
            this.grGonderilmisler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grGonderilmisler.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grGonderilmisler.Location = new System.Drawing.Point(0, 50);
            this.grGonderilmisler.MainView = this.grGonderilmislerView;
            this.grGonderilmisler.Margin = new System.Windows.Forms.Padding(2);
            this.grGonderilmisler.Name = "grGonderilmisler";
            this.grGonderilmisler.Size = new System.Drawing.Size(978, 298);
            this.grGonderilmisler.TabIndex = 4;
            this.grGonderilmisler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grGonderilmislerView});
            this.grGonderilmisler.DoubleClick += new System.EventHandler(this.grGonderilmisler_DoubleClick);
            // 
            // conMenuGonderilmis
            // 
            this.conMenuGonderilmis.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.conMenuGonderilmis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGonderilmis_Gerial,
            this.toolStripSeparator1,
            this.mnuGonderilmisSil,
            this.toolStripMenuItem5,
            this.logGoruntuleToolStripMenuItem});
            this.conMenuGonderilmis.Name = "conMenuGelen";
            this.conMenuGonderilmis.Size = new System.Drawing.Size(229, 82);
            // 
            // mnuGonderilmis_Gerial
            // 
            this.mnuGonderilmis_Gerial.Name = "mnuGonderilmis_Gerial";
            this.mnuGonderilmis_Gerial.Size = new System.Drawing.Size(228, 22);
            this.mnuGonderilmis_Gerial.Text = "Gonderilmemis olarak geri al.";
            this.mnuGonderilmis_Gerial.Click += new System.EventHandler(this.mnuGonderilmis_Gerial_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(225, 6);
            // 
            // mnuGonderilmisSil
            // 
            this.mnuGonderilmisSil.Name = "mnuGonderilmisSil";
            this.mnuGonderilmisSil.Size = new System.Drawing.Size(228, 22);
            this.mnuGonderilmisSil.Text = "Sil";
            this.mnuGonderilmisSil.Click += new System.EventHandler(this.mnuGonderilmisSil_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(225, 6);
            // 
            // logGoruntuleToolStripMenuItem
            // 
            this.logGoruntuleToolStripMenuItem.Name = "logGoruntuleToolStripMenuItem";
            this.logGoruntuleToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.logGoruntuleToolStripMenuItem.Text = "Log goruntule";
            this.logGoruntuleToolStripMenuItem.Click += new System.EventHandler(this.logGoruntuleToolStripMenuItem_Click);
            // 
            // tbInvoice_Gonderilmisler
            // 
            this.tbInvoice_Gonderilmisler.Columns.AddRange(new System.Data.DataColumn[] {
            this.tbInvoice_Gonderilmisler_InvoiceID,
            this.tbInvoice_Gonderilmisler_Deleted,
            this.tbInvoice_Gonderilmisler_CreatedBy,
            this.tbInvoice_Gonderilmisler_CreatedDate,
            this.tbInvoice_Gonderilmisler_ModifiedBy,
            this.tbInvoice_Gonderilmisler_ModifiedDate,
            this.tbInvoice_Gonderilmisler_IOType,
            this.tbInvoice_Gonderilmisler_IntCode,
            this.tbInvoice_Gonderilmisler_LocalStatus,
            this.tbInvoice_Gonderilmisler_IntegratorID,
            this.tbInvoice_Gonderilmisler_Status,
            this.tbInvoice_Gonderilmisler_StatusDescription,
            this.tbInvoice_Gonderilmisler_PostBox,
            this.tbInvoice_Gonderilmisler_XsltNo,
            this.tbInvoice_Gonderilmisler_ProfileID,
            this.tbInvoice_Gonderilmisler_ID,
            this.tbInvoice_Gonderilmisler_UUID,
            this.tbInvoice_Gonderilmisler_IssueDate,
            this.tbInvoice_Gonderilmisler_IssueTime,
            this.tbInvoice_Gonderilmisler_InvoiceTypeCode,
            this.tbInvoice_Gonderilmisler_DocumentCurrencyCode,
            this.tbInvoice_Gonderilmisler_TaxCurrencyCode,
            this.tbInvoice_Gonderilmisler_PricingCurrencyCode,
            this.tbInvoice_Gonderilmisler_PaymentCurrencyCode,
            this.tbInvoice_Gonderilmisler_PaymentAlternativeCurrencyCode,
            this.tbInvoice_Gonderilmisler_LineCountNumeric,
            this.tbInvoice_Gonderilmisler_InvoicePeriod_StartDate,
            this.tbInvoice_Gonderilmisler_InvoicePeriod_EndDate,
            this.tbInvoice_Gonderilmisler_ASP_PartyIdentification1_schemeID,
            this.tbInvoice_Gonderilmisler_ASP_PartyIdentification1_ID,
            this.tbInvoice_Gonderilmisler_ASP_PartyIdentification2_schemeID,
            this.tbInvoice_Gonderilmisler_ASP_PartyIdentification2_ID,
            this.tbInvoice_Gonderilmisler_ASP_PartyIdentification3_schemeID,
            this.tbInvoice_Gonderilmisler_ASP_PartyIdentification3_ID,
            this.tbInvoice_Gonderilmisler_ASP_PartyIdentification4_schemeID,
            this.tbInvoice_Gonderilmisler_ASP_PartyIdentification4_ID,
            this.tbInvoice_Gonderilmisler_ASP_PartyIdentification5_schemeID,
            this.tbInvoice_Gonderilmisler_ASP_PartyIdentification5_ID,
            this.tbInvoice_Gonderilmisler_ASP_PartyName,
            this.tbInvoice_Gonderilmisler_ASP_PostalAddress_StreetName,
            this.tbInvoice_Gonderilmisler_ASP_PostalAddress_Room,
            this.tbInvoice_Gonderilmisler_ASP_PostalAddress_BuildingNumber,
            this.tbInvoice_Gonderilmisler_ASP_PostalAddress_BuildingName,
            this.tbInvoice_Gonderilmisler_ASP_PostalAddress_CitySubdivisionName,
            this.tbInvoice_Gonderilmisler_ASP_PostalAddress_CityName,
            this.tbInvoice_Gonderilmisler_ASP_PostalAddress_Country,
            this.tbInvoice_Gonderilmisler_ASP_PartyTaxSchemeName,
            this.tbInvoice_Gonderilmisler_ASP_PartyTaxSchemeTaxTypeCode,
            this.tbInvoice_Gonderilmisler_ASP_WebsiteURI,
            this.tbInvoice_Gonderilmisler_ASP_Contact_Telephone,
            this.tbInvoice_Gonderilmisler_ASP_Contact_Telefax,
            this.tbInvoice_Gonderilmisler_ASP_Contact_ElectronicMail,
            this.tbInvoice_Gonderilmisler_ASP_Person_FirstName,
            this.tbInvoice_Gonderilmisler_ASP_Person_FamilyName,
            this.tbInvoice_Gonderilmisler_ASP_Person_MiddleName,
            this.tbInvoice_Gonderilmisler_ASP_Person_NameSuffix,
            this.tbInvoice_Gonderilmisler_ASP_Person_Title,
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification1_schemeID,
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification1_ID,
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification2_schemeID,
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification2_ID,
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification3_schemeID,
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification3_ID,
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification4_schemeID,
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification4_ID,
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification5_schemeID,
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification5_ID,
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyName,
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_StreetName,
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_Room,
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_BuildingNumber,
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_BuildingName,
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_CitySubdivisionName,
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_CityName,
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_Country,
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyTaxSchemeName,
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyTaxSchemeTaxTypeCode,
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_WebsiteURI,
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_Contact_Telephone,
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_Contact_Telefax,
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_Contact_ElectronicMail,
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_Person_FirstName,
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_Person_FamilyName,
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_Person_MiddleName,
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_Person_NameSuffix,
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_Person_Title,
            this.tbInvoice_Gonderilmisler_ACP_PartyIdentification1_schemeID,
            this.tbInvoice_Gonderilmisler_ACP_PartyIdentification1_ID,
            this.tbInvoice_Gonderilmisler_ACP_PartyIdentification2_schemeID,
            this.tbInvoice_Gonderilmisler_ACP_PartyIdentification2_ID,
            this.tbInvoice_Gonderilmisler_ACP_PartyIdentification3_schemeID,
            this.tbInvoice_Gonderilmisler_ACP_PartyIdentification3_ID,
            this.tbInvoice_Gonderilmisler_ACP_PartyIdentification4_schemeID,
            this.tbInvoice_Gonderilmisler_ACP_PartyIdentification4_ID,
            this.tbInvoice_Gonderilmisler_ACP_PartyIdentification5_schemeID,
            this.tbInvoice_Gonderilmisler_ACP_PartyIdentification5_ID,
            this.tbInvoice_Gonderilmisler_ACP_PartyName,
            this.tbInvoice_Gonderilmisler_ACP_PostalAddress_StreetName,
            this.tbInvoice_Gonderilmisler_ACP_PostalAddress_Room,
            this.tbInvoice_Gonderilmisler_ACP_PostalAddress_BuildingNumber,
            this.tbInvoice_Gonderilmisler_ACP_PostalAddress_BuildingName,
            this.tbInvoice_Gonderilmisler_ACP_PostalAddress_CitySubdivisionName,
            this.tbInvoice_Gonderilmisler_ACP_PostalAddress_CityName,
            this.tbInvoice_Gonderilmisler_ACP_PostalAddress_Country,
            this.tbInvoice_Gonderilmisler_ACP_PartyTaxSchemeName,
            this.tbInvoice_Gonderilmisler_ACP_PartyTaxSchemeTaxTypeCode,
            this.tbInvoice_Gonderilmisler_ACP_WebsiteURI,
            this.tbInvoice_Gonderilmisler_ACP_Contact_Telephone,
            this.tbInvoice_Gonderilmisler_ACP_Contact_Telefax,
            this.tbInvoice_Gonderilmisler_ACP_Contact_ElectronicMail,
            this.tbInvoice_Gonderilmisler_ACP_Person_FirstName,
            this.tbInvoice_Gonderilmisler_ACP_Person_FamilyName,
            this.tbInvoice_Gonderilmisler_ACP_Person_MiddleName,
            this.tbInvoice_Gonderilmisler_ACP_Person_NameSuffix,
            this.tbInvoice_Gonderilmisler_ACP_Person_Title,
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification1_schemeID,
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification1_ID,
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification2_schemeID,
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification2_ID,
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification3_schemeID,
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification3_ID,
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification4_schemeID,
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification4_ID,
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification5_schemeID,
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification5_ID,
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyName,
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_StreetName,
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_Room,
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_BuildingNumber,
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_BuildingName,
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_CitySubdivisionName,
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_CityName,
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_Country,
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyTaxSchemeName,
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyTaxSchemeTaxTypeCode,
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_WebsiteURI,
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_Contact_Telephone,
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_Contact_Telefax,
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_Contact_ElectronicMail,
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_Person_FirstName,
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_Person_FamilyName,
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_Person_MiddleName,
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_Person_NameSuffix,
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_Person_Title,
            this.tbInvoice_Gonderilmisler_TaxExchangeRate_SourceCurrencyCode,
            this.tbInvoice_Gonderilmisler_TaxExchangeRate_TargetCurrencyCode,
            this.tbInvoice_Gonderilmisler_TaxExchangeRate_CalculationRate,
            this.tbInvoice_Gonderilmisler_TaxExchangeRate_Date,
            this.tbInvoice_Gonderilmisler_PricingExchangeRate_SourceCurrencyCode,
            this.tbInvoice_Gonderilmisler_PricingExchangeRate_TargetCurrencyCode,
            this.tbInvoice_Gonderilmisler_PricingExchangeRate_CalculationRate,
            this.tbInvoice_Gonderilmisler_PricingExchangeRate_Date,
            this.tbInvoice_Gonderilmisler_PaymentExchangeRate_SourceCurrencyCode,
            this.tbInvoice_Gonderilmisler_PaymentExchangeRate_TargetCurrencyCode,
            this.tbInvoice_Gonderilmisler_PaymentExchangeRate_CalculationRate,
            this.tbInvoice_Gonderilmisler_PaymentExchangeRate_Date,
            this.tbInvoice_Gonderilmisler_PaymentAlternativeExchangeRate_SourceCurrencyCode,
            this.tbInvoice_Gonderilmisler_PaymentAlternativeExchangeRate_TargetCurrencyCode,
            this.tbInvoice_Gonderilmisler_PaymentAlternativeExchangeRate_CalculationRate,
            this.tbInvoice_Gonderilmisler_PaymentAlternativeExchangeRate_Date,
            this.tbInvoice_Gonderilmisler_TaxAmount,
            this.tbInvoice_Gonderilmisler_LegalMonetaryTotal_LineExtensionAmount,
            this.tbInvoice_Gonderilmisler_LegalMonetaryTotal_TaxExclusiveAmount,
            this.tbInvoice_Gonderilmisler_LegalMonetaryTotal_TaxInclusiveAmount,
            this.tbInvoice_Gonderilmisler_LegalMonetaryTotal_AllowanceTotalAmount,
            this.tbInvoice_Gonderilmisler_LegalMonetaryTotal_ChargeTotalAmount,
            this.tbInvoice_Gonderilmisler_LegalMonetaryTotal_PayableRoundingAmount,
            this.tbInvoice_Gonderilmisler_LegalMonetaryTotal_PayableAmount,
            this.tbInvoice_Gonderilmisler_WithholdingTaxAmount,
            this.tbInvoice_Gonderilmisler_Message});
            this.tbInvoice_Gonderilmisler.Connection = this.FirmConn;
            this.tbInvoice_Gonderilmisler.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "InvoiceID"}, true)});
            this.tbInvoice_Gonderilmisler.CurrentRow = null;
            this.tbInvoice_Gonderilmisler.DataSourceLink = null;
            this.tbInvoice_Gonderilmisler.DeleteCommand = this.sqlCommand16;
            this.tbInvoice_Gonderilmisler.Filter = "";
            this.tbInvoice_Gonderilmisler.InsertCommand = this.sqlCommand14;
            this.tbInvoice_Gonderilmisler.LiveSave = false;
            this.tbInvoice_Gonderilmisler.MaxRecords = ((long)(0));
            this.tbInvoice_Gonderilmisler.Name = "tbInvoice_Gonderilmisler";
            this.tbInvoice_Gonderilmisler.ParentRelation_ChildColumns = null;
            this.tbInvoice_Gonderilmisler.ParentRelation_ParentColumns = null;
            this.tbInvoice_Gonderilmisler.ParentRelation_Table = null;
            this.tbInvoice_Gonderilmisler.Position = ((long)(-1));
            this.tbInvoice_Gonderilmisler.PrimaryKey = new System.Data.DataColumn[] {
        this.tbInvoice_Gonderilmisler_InvoiceID};
            this.tbInvoice_Gonderilmisler.Quoted = false;
            this.tbInvoice_Gonderilmisler.SelectCommand = this.sqlCommand13;
            this.tbInvoice_Gonderilmisler.TableName = "neoTable1";
            this.tbInvoice_Gonderilmisler.Transaction = null;
            this.tbInvoice_Gonderilmisler.UpdateCommand = this.sqlCommand15;
            // 
            // tbInvoice_Gonderilmisler_InvoiceID
            // 
            this.tbInvoice_Gonderilmisler_InvoiceID.AllowDBNull = false;
            this.tbInvoice_Gonderilmisler_InvoiceID.AutoIncrement = true;
            this.tbInvoice_Gonderilmisler_InvoiceID.ColumnName = "InvoiceID";
            this.tbInvoice_Gonderilmisler_InvoiceID.DataType = typeof(int);
            // 
            // tbInvoice_Gonderilmisler_Deleted
            // 
            this.tbInvoice_Gonderilmisler_Deleted.ColumnName = "Deleted";
            this.tbInvoice_Gonderilmisler_Deleted.DataType = typeof(int);
            // 
            // tbInvoice_Gonderilmisler_CreatedBy
            // 
            this.tbInvoice_Gonderilmisler_CreatedBy.ColumnName = "CreatedBy";
            this.tbInvoice_Gonderilmisler_CreatedBy.DataType = typeof(int);
            // 
            // tbInvoice_Gonderilmisler_CreatedDate
            // 
            this.tbInvoice_Gonderilmisler_CreatedDate.ColumnName = "CreatedDate";
            this.tbInvoice_Gonderilmisler_CreatedDate.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_Gonderilmisler_ModifiedBy
            // 
            this.tbInvoice_Gonderilmisler_ModifiedBy.ColumnName = "ModifiedBy";
            this.tbInvoice_Gonderilmisler_ModifiedBy.DataType = typeof(int);
            // 
            // tbInvoice_Gonderilmisler_ModifiedDate
            // 
            this.tbInvoice_Gonderilmisler_ModifiedDate.ColumnName = "ModifiedDate";
            this.tbInvoice_Gonderilmisler_ModifiedDate.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_Gonderilmisler_IOType
            // 
            this.tbInvoice_Gonderilmisler_IOType.ColumnName = "IOType";
            this.tbInvoice_Gonderilmisler_IOType.DataType = typeof(int);
            // 
            // tbInvoice_Gonderilmisler_IntCode
            // 
            this.tbInvoice_Gonderilmisler_IntCode.ColumnName = "IntCode";
            // 
            // tbInvoice_Gonderilmisler_LocalStatus
            // 
            this.tbInvoice_Gonderilmisler_LocalStatus.ColumnName = "LocalStatus";
            this.tbInvoice_Gonderilmisler_LocalStatus.DataType = typeof(int);
            // 
            // tbInvoice_Gonderilmisler_IntegratorID
            // 
            this.tbInvoice_Gonderilmisler_IntegratorID.ColumnName = "IntegratorID";
            // 
            // tbInvoice_Gonderilmisler_Status
            // 
            this.tbInvoice_Gonderilmisler_Status.ColumnName = "Status";
            this.tbInvoice_Gonderilmisler_Status.DataType = typeof(int);
            // 
            // tbInvoice_Gonderilmisler_StatusDescription
            // 
            this.tbInvoice_Gonderilmisler_StatusDescription.ColumnName = "StatusDescription";
            // 
            // tbInvoice_Gonderilmisler_PostBox
            // 
            this.tbInvoice_Gonderilmisler_PostBox.ColumnName = "PostBox";
            // 
            // tbInvoice_Gonderilmisler_XsltNo
            // 
            this.tbInvoice_Gonderilmisler_XsltNo.ColumnName = "XsltNo";
            this.tbInvoice_Gonderilmisler_XsltNo.DataType = typeof(int);
            // 
            // tbInvoice_Gonderilmisler_ProfileID
            // 
            this.tbInvoice_Gonderilmisler_ProfileID.ColumnName = "ProfileID";
            // 
            // tbInvoice_Gonderilmisler_ID
            // 
            this.tbInvoice_Gonderilmisler_ID.ColumnName = "ID";
            // 
            // tbInvoice_Gonderilmisler_UUID
            // 
            this.tbInvoice_Gonderilmisler_UUID.ColumnName = "UUID";
            // 
            // tbInvoice_Gonderilmisler_IssueDate
            // 
            this.tbInvoice_Gonderilmisler_IssueDate.ColumnName = "IssueDate";
            this.tbInvoice_Gonderilmisler_IssueDate.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_Gonderilmisler_IssueTime
            // 
            this.tbInvoice_Gonderilmisler_IssueTime.ColumnName = "IssueTime";
            this.tbInvoice_Gonderilmisler_IssueTime.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_Gonderilmisler_InvoiceTypeCode
            // 
            this.tbInvoice_Gonderilmisler_InvoiceTypeCode.ColumnName = "InvoiceTypeCode";
            // 
            // tbInvoice_Gonderilmisler_DocumentCurrencyCode
            // 
            this.tbInvoice_Gonderilmisler_DocumentCurrencyCode.ColumnName = "DocumentCurrencyCode";
            // 
            // tbInvoice_Gonderilmisler_TaxCurrencyCode
            // 
            this.tbInvoice_Gonderilmisler_TaxCurrencyCode.ColumnName = "TaxCurrencyCode";
            // 
            // tbInvoice_Gonderilmisler_PricingCurrencyCode
            // 
            this.tbInvoice_Gonderilmisler_PricingCurrencyCode.ColumnName = "PricingCurrencyCode";
            // 
            // tbInvoice_Gonderilmisler_PaymentCurrencyCode
            // 
            this.tbInvoice_Gonderilmisler_PaymentCurrencyCode.ColumnName = "PaymentCurrencyCode";
            // 
            // tbInvoice_Gonderilmisler_PaymentAlternativeCurrencyCode
            // 
            this.tbInvoice_Gonderilmisler_PaymentAlternativeCurrencyCode.ColumnName = "PaymentAlternativeCurrencyCode";
            // 
            // tbInvoice_Gonderilmisler_LineCountNumeric
            // 
            this.tbInvoice_Gonderilmisler_LineCountNumeric.ColumnName = "LineCountNumeric";
            this.tbInvoice_Gonderilmisler_LineCountNumeric.DataType = typeof(int);
            // 
            // tbInvoice_Gonderilmisler_InvoicePeriod_StartDate
            // 
            this.tbInvoice_Gonderilmisler_InvoicePeriod_StartDate.ColumnName = "InvoicePeriod_StartDate";
            this.tbInvoice_Gonderilmisler_InvoicePeriod_StartDate.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_Gonderilmisler_InvoicePeriod_EndDate
            // 
            this.tbInvoice_Gonderilmisler_InvoicePeriod_EndDate.ColumnName = "InvoicePeriod_EndDate";
            this.tbInvoice_Gonderilmisler_InvoicePeriod_EndDate.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_Gonderilmisler_ASP_PartyIdentification1_schemeID
            // 
            this.tbInvoice_Gonderilmisler_ASP_PartyIdentification1_schemeID.ColumnName = "ASP_PartyIdentification1_schemeID";
            // 
            // tbInvoice_Gonderilmisler_ASP_PartyIdentification1_ID
            // 
            this.tbInvoice_Gonderilmisler_ASP_PartyIdentification1_ID.ColumnName = "ASP_PartyIdentification1_ID";
            // 
            // tbInvoice_Gonderilmisler_ASP_PartyIdentification2_schemeID
            // 
            this.tbInvoice_Gonderilmisler_ASP_PartyIdentification2_schemeID.ColumnName = "ASP_PartyIdentification2_schemeID";
            // 
            // tbInvoice_Gonderilmisler_ASP_PartyIdentification2_ID
            // 
            this.tbInvoice_Gonderilmisler_ASP_PartyIdentification2_ID.ColumnName = "ASP_PartyIdentification2_ID";
            // 
            // tbInvoice_Gonderilmisler_ASP_PartyIdentification3_schemeID
            // 
            this.tbInvoice_Gonderilmisler_ASP_PartyIdentification3_schemeID.ColumnName = "ASP_PartyIdentification3_schemeID";
            // 
            // tbInvoice_Gonderilmisler_ASP_PartyIdentification3_ID
            // 
            this.tbInvoice_Gonderilmisler_ASP_PartyIdentification3_ID.ColumnName = "ASP_PartyIdentification3_ID";
            // 
            // tbInvoice_Gonderilmisler_ASP_PartyIdentification4_schemeID
            // 
            this.tbInvoice_Gonderilmisler_ASP_PartyIdentification4_schemeID.ColumnName = "ASP_PartyIdentification4_schemeID";
            // 
            // tbInvoice_Gonderilmisler_ASP_PartyIdentification4_ID
            // 
            this.tbInvoice_Gonderilmisler_ASP_PartyIdentification4_ID.ColumnName = "ASP_PartyIdentification4_ID";
            // 
            // tbInvoice_Gonderilmisler_ASP_PartyIdentification5_schemeID
            // 
            this.tbInvoice_Gonderilmisler_ASP_PartyIdentification5_schemeID.ColumnName = "ASP_PartyIdentification5_schemeID";
            // 
            // tbInvoice_Gonderilmisler_ASP_PartyIdentification5_ID
            // 
            this.tbInvoice_Gonderilmisler_ASP_PartyIdentification5_ID.ColumnName = "ASP_PartyIdentification5_ID";
            // 
            // tbInvoice_Gonderilmisler_ASP_PartyName
            // 
            this.tbInvoice_Gonderilmisler_ASP_PartyName.ColumnName = "ASP_PartyName";
            // 
            // tbInvoice_Gonderilmisler_ASP_PostalAddress_StreetName
            // 
            this.tbInvoice_Gonderilmisler_ASP_PostalAddress_StreetName.ColumnName = "ASP_PostalAddress_StreetName";
            // 
            // tbInvoice_Gonderilmisler_ASP_PostalAddress_Room
            // 
            this.tbInvoice_Gonderilmisler_ASP_PostalAddress_Room.ColumnName = "ASP_PostalAddress_Room";
            // 
            // tbInvoice_Gonderilmisler_ASP_PostalAddress_BuildingNumber
            // 
            this.tbInvoice_Gonderilmisler_ASP_PostalAddress_BuildingNumber.ColumnName = "ASP_PostalAddress_BuildingNumber";
            // 
            // tbInvoice_Gonderilmisler_ASP_PostalAddress_BuildingName
            // 
            this.tbInvoice_Gonderilmisler_ASP_PostalAddress_BuildingName.ColumnName = "ASP_PostalAddress_BuildingName";
            // 
            // tbInvoice_Gonderilmisler_ASP_PostalAddress_CitySubdivisionName
            // 
            this.tbInvoice_Gonderilmisler_ASP_PostalAddress_CitySubdivisionName.ColumnName = "ASP_PostalAddress_CitySubdivisionName";
            // 
            // tbInvoice_Gonderilmisler_ASP_PostalAddress_CityName
            // 
            this.tbInvoice_Gonderilmisler_ASP_PostalAddress_CityName.ColumnName = "ASP_PostalAddress_CityName";
            // 
            // tbInvoice_Gonderilmisler_ASP_PostalAddress_Country
            // 
            this.tbInvoice_Gonderilmisler_ASP_PostalAddress_Country.ColumnName = "ASP_PostalAddress_Country";
            // 
            // tbInvoice_Gonderilmisler_ASP_PartyTaxSchemeName
            // 
            this.tbInvoice_Gonderilmisler_ASP_PartyTaxSchemeName.ColumnName = "ASP_PartyTaxSchemeName";
            // 
            // tbInvoice_Gonderilmisler_ASP_PartyTaxSchemeTaxTypeCode
            // 
            this.tbInvoice_Gonderilmisler_ASP_PartyTaxSchemeTaxTypeCode.ColumnName = "ASP_PartyTaxSchemeTaxTypeCode";
            // 
            // tbInvoice_Gonderilmisler_ASP_WebsiteURI
            // 
            this.tbInvoice_Gonderilmisler_ASP_WebsiteURI.ColumnName = "ASP_WebsiteURI";
            // 
            // tbInvoice_Gonderilmisler_ASP_Contact_Telephone
            // 
            this.tbInvoice_Gonderilmisler_ASP_Contact_Telephone.ColumnName = "ASP_Contact_Telephone";
            // 
            // tbInvoice_Gonderilmisler_ASP_Contact_Telefax
            // 
            this.tbInvoice_Gonderilmisler_ASP_Contact_Telefax.ColumnName = "ASP_Contact_Telefax";
            // 
            // tbInvoice_Gonderilmisler_ASP_Contact_ElectronicMail
            // 
            this.tbInvoice_Gonderilmisler_ASP_Contact_ElectronicMail.ColumnName = "ASP_Contact_ElectronicMail";
            // 
            // tbInvoice_Gonderilmisler_ASP_Person_FirstName
            // 
            this.tbInvoice_Gonderilmisler_ASP_Person_FirstName.ColumnName = "ASP_Person_FirstName";
            // 
            // tbInvoice_Gonderilmisler_ASP_Person_FamilyName
            // 
            this.tbInvoice_Gonderilmisler_ASP_Person_FamilyName.ColumnName = "ASP_Person_FamilyName";
            // 
            // tbInvoice_Gonderilmisler_ASP_Person_MiddleName
            // 
            this.tbInvoice_Gonderilmisler_ASP_Person_MiddleName.ColumnName = "ASP_Person_MiddleName";
            // 
            // tbInvoice_Gonderilmisler_ASP_Person_NameSuffix
            // 
            this.tbInvoice_Gonderilmisler_ASP_Person_NameSuffix.ColumnName = "ASP_Person_NameSuffix";
            // 
            // tbInvoice_Gonderilmisler_ASP_Person_Title
            // 
            this.tbInvoice_Gonderilmisler_ASP_Person_Title.ColumnName = "ASP_Person_Title";
            // 
            // tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification1_schemeID
            // 
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification1_schemeID.ColumnName = "ASP_AgentParty_PartyIdentification1_schemeID";
            // 
            // tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification1_ID
            // 
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification1_ID.ColumnName = "ASP_AgentParty_PartyIdentification1_ID";
            // 
            // tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification2_schemeID
            // 
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification2_schemeID.ColumnName = "ASP_AgentParty_PartyIdentification2_schemeID";
            // 
            // tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification2_ID
            // 
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification2_ID.ColumnName = "ASP_AgentParty_PartyIdentification2_ID";
            // 
            // tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification3_schemeID
            // 
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification3_schemeID.ColumnName = "ASP_AgentParty_PartyIdentification3_schemeID";
            // 
            // tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification3_ID
            // 
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification3_ID.ColumnName = "ASP_AgentParty_PartyIdentification3_ID";
            // 
            // tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification4_schemeID
            // 
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification4_schemeID.ColumnName = "ASP_AgentParty_PartyIdentification4_schemeID";
            // 
            // tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification4_ID
            // 
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification4_ID.ColumnName = "ASP_AgentParty_PartyIdentification4_ID";
            // 
            // tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification5_schemeID
            // 
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification5_schemeID.ColumnName = "ASP_AgentParty_PartyIdentification5_schemeID";
            // 
            // tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification5_ID
            // 
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification5_ID.ColumnName = "ASP_AgentParty_PartyIdentification5_ID";
            // 
            // tbInvoice_Gonderilmisler_ASP_AgentParty_PartyName
            // 
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyName.ColumnName = "ASP_AgentParty_PartyName";
            // 
            // tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_StreetName
            // 
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_StreetName.ColumnName = "ASP_AgentParty_PostalAddress_StreetName";
            // 
            // tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_Room
            // 
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_Room.ColumnName = "ASP_AgentParty_PostalAddress_Room";
            // 
            // tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_BuildingNumber
            // 
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_BuildingNumber.ColumnName = "ASP_AgentParty_PostalAddress_BuildingNumber";
            // 
            // tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_BuildingName
            // 
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_BuildingName.ColumnName = "ASP_AgentParty_PostalAddress_BuildingName";
            // 
            // tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_CitySubdivisionName
            // 
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_CitySubdivisionName.ColumnName = "ASP_AgentParty_PostalAddress_CitySubdivisionName";
            // 
            // tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_CityName
            // 
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_CityName.ColumnName = "ASP_AgentParty_PostalAddress_CityName";
            // 
            // tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_Country
            // 
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_Country.ColumnName = "ASP_AgentParty_PostalAddress_Country";
            // 
            // tbInvoice_Gonderilmisler_ASP_AgentParty_PartyTaxSchemeName
            // 
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyTaxSchemeName.ColumnName = "ASP_AgentParty_PartyTaxSchemeName";
            // 
            // tbInvoice_Gonderilmisler_ASP_AgentParty_PartyTaxSchemeTaxTypeCode
            // 
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_PartyTaxSchemeTaxTypeCode.ColumnName = "ASP_AgentParty_PartyTaxSchemeTaxTypeCode";
            // 
            // tbInvoice_Gonderilmisler_ASP_AgentParty_WebsiteURI
            // 
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_WebsiteURI.ColumnName = "ASP_AgentParty_WebsiteURI";
            // 
            // tbInvoice_Gonderilmisler_ASP_AgentParty_Contact_Telephone
            // 
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_Contact_Telephone.ColumnName = "ASP_AgentParty_Contact_Telephone";
            // 
            // tbInvoice_Gonderilmisler_ASP_AgentParty_Contact_Telefax
            // 
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_Contact_Telefax.ColumnName = "ASP_AgentParty_Contact_Telefax";
            // 
            // tbInvoice_Gonderilmisler_ASP_AgentParty_Contact_ElectronicMail
            // 
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_Contact_ElectronicMail.ColumnName = "ASP_AgentParty_Contact_ElectronicMail";
            // 
            // tbInvoice_Gonderilmisler_ASP_AgentParty_Person_FirstName
            // 
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_Person_FirstName.ColumnName = "ASP_AgentParty_Person_FirstName";
            // 
            // tbInvoice_Gonderilmisler_ASP_AgentParty_Person_FamilyName
            // 
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_Person_FamilyName.ColumnName = "ASP_AgentParty_Person_FamilyName";
            // 
            // tbInvoice_Gonderilmisler_ASP_AgentParty_Person_MiddleName
            // 
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_Person_MiddleName.ColumnName = "ASP_AgentParty_Person_MiddleName";
            // 
            // tbInvoice_Gonderilmisler_ASP_AgentParty_Person_NameSuffix
            // 
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_Person_NameSuffix.ColumnName = "ASP_AgentParty_Person_NameSuffix";
            // 
            // tbInvoice_Gonderilmisler_ASP_AgentParty_Person_Title
            // 
            this.tbInvoice_Gonderilmisler_ASP_AgentParty_Person_Title.ColumnName = "ASP_AgentParty_Person_Title";
            // 
            // tbInvoice_Gonderilmisler_ACP_PartyIdentification1_schemeID
            // 
            this.tbInvoice_Gonderilmisler_ACP_PartyIdentification1_schemeID.ColumnName = "ACP_PartyIdentification1_schemeID";
            // 
            // tbInvoice_Gonderilmisler_ACP_PartyIdentification1_ID
            // 
            this.tbInvoice_Gonderilmisler_ACP_PartyIdentification1_ID.ColumnName = "ACP_PartyIdentification1_ID";
            // 
            // tbInvoice_Gonderilmisler_ACP_PartyIdentification2_schemeID
            // 
            this.tbInvoice_Gonderilmisler_ACP_PartyIdentification2_schemeID.ColumnName = "ACP_PartyIdentification2_schemeID";
            // 
            // tbInvoice_Gonderilmisler_ACP_PartyIdentification2_ID
            // 
            this.tbInvoice_Gonderilmisler_ACP_PartyIdentification2_ID.ColumnName = "ACP_PartyIdentification2_ID";
            // 
            // tbInvoice_Gonderilmisler_ACP_PartyIdentification3_schemeID
            // 
            this.tbInvoice_Gonderilmisler_ACP_PartyIdentification3_schemeID.ColumnName = "ACP_PartyIdentification3_schemeID";
            // 
            // tbInvoice_Gonderilmisler_ACP_PartyIdentification3_ID
            // 
            this.tbInvoice_Gonderilmisler_ACP_PartyIdentification3_ID.ColumnName = "ACP_PartyIdentification3_ID";
            // 
            // tbInvoice_Gonderilmisler_ACP_PartyIdentification4_schemeID
            // 
            this.tbInvoice_Gonderilmisler_ACP_PartyIdentification4_schemeID.ColumnName = "ACP_PartyIdentification4_schemeID";
            // 
            // tbInvoice_Gonderilmisler_ACP_PartyIdentification4_ID
            // 
            this.tbInvoice_Gonderilmisler_ACP_PartyIdentification4_ID.ColumnName = "ACP_PartyIdentification4_ID";
            // 
            // tbInvoice_Gonderilmisler_ACP_PartyIdentification5_schemeID
            // 
            this.tbInvoice_Gonderilmisler_ACP_PartyIdentification5_schemeID.ColumnName = "ACP_PartyIdentification5_schemeID";
            // 
            // tbInvoice_Gonderilmisler_ACP_PartyIdentification5_ID
            // 
            this.tbInvoice_Gonderilmisler_ACP_PartyIdentification5_ID.ColumnName = "ACP_PartyIdentification5_ID";
            // 
            // tbInvoice_Gonderilmisler_ACP_PartyName
            // 
            this.tbInvoice_Gonderilmisler_ACP_PartyName.ColumnName = "ACP_PartyName";
            // 
            // tbInvoice_Gonderilmisler_ACP_PostalAddress_StreetName
            // 
            this.tbInvoice_Gonderilmisler_ACP_PostalAddress_StreetName.ColumnName = "ACP_PostalAddress_StreetName";
            // 
            // tbInvoice_Gonderilmisler_ACP_PostalAddress_Room
            // 
            this.tbInvoice_Gonderilmisler_ACP_PostalAddress_Room.ColumnName = "ACP_PostalAddress_Room";
            // 
            // tbInvoice_Gonderilmisler_ACP_PostalAddress_BuildingNumber
            // 
            this.tbInvoice_Gonderilmisler_ACP_PostalAddress_BuildingNumber.ColumnName = "ACP_PostalAddress_BuildingNumber";
            // 
            // tbInvoice_Gonderilmisler_ACP_PostalAddress_BuildingName
            // 
            this.tbInvoice_Gonderilmisler_ACP_PostalAddress_BuildingName.ColumnName = "ACP_PostalAddress_BuildingName";
            // 
            // tbInvoice_Gonderilmisler_ACP_PostalAddress_CitySubdivisionName
            // 
            this.tbInvoice_Gonderilmisler_ACP_PostalAddress_CitySubdivisionName.ColumnName = "ACP_PostalAddress_CitySubdivisionName";
            // 
            // tbInvoice_Gonderilmisler_ACP_PostalAddress_CityName
            // 
            this.tbInvoice_Gonderilmisler_ACP_PostalAddress_CityName.ColumnName = "ACP_PostalAddress_CityName";
            // 
            // tbInvoice_Gonderilmisler_ACP_PostalAddress_Country
            // 
            this.tbInvoice_Gonderilmisler_ACP_PostalAddress_Country.ColumnName = "ACP_PostalAddress_Country";
            // 
            // tbInvoice_Gonderilmisler_ACP_PartyTaxSchemeName
            // 
            this.tbInvoice_Gonderilmisler_ACP_PartyTaxSchemeName.ColumnName = "ACP_PartyTaxSchemeName";
            // 
            // tbInvoice_Gonderilmisler_ACP_PartyTaxSchemeTaxTypeCode
            // 
            this.tbInvoice_Gonderilmisler_ACP_PartyTaxSchemeTaxTypeCode.ColumnName = "ACP_PartyTaxSchemeTaxTypeCode";
            // 
            // tbInvoice_Gonderilmisler_ACP_WebsiteURI
            // 
            this.tbInvoice_Gonderilmisler_ACP_WebsiteURI.ColumnName = "ACP_WebsiteURI";
            // 
            // tbInvoice_Gonderilmisler_ACP_Contact_Telephone
            // 
            this.tbInvoice_Gonderilmisler_ACP_Contact_Telephone.ColumnName = "ACP_Contact_Telephone";
            // 
            // tbInvoice_Gonderilmisler_ACP_Contact_Telefax
            // 
            this.tbInvoice_Gonderilmisler_ACP_Contact_Telefax.ColumnName = "ACP_Contact_Telefax";
            // 
            // tbInvoice_Gonderilmisler_ACP_Contact_ElectronicMail
            // 
            this.tbInvoice_Gonderilmisler_ACP_Contact_ElectronicMail.ColumnName = "ACP_Contact_ElectronicMail";
            // 
            // tbInvoice_Gonderilmisler_ACP_Person_FirstName
            // 
            this.tbInvoice_Gonderilmisler_ACP_Person_FirstName.ColumnName = "ACP_Person_FirstName";
            // 
            // tbInvoice_Gonderilmisler_ACP_Person_FamilyName
            // 
            this.tbInvoice_Gonderilmisler_ACP_Person_FamilyName.ColumnName = "ACP_Person_FamilyName";
            // 
            // tbInvoice_Gonderilmisler_ACP_Person_MiddleName
            // 
            this.tbInvoice_Gonderilmisler_ACP_Person_MiddleName.ColumnName = "ACP_Person_MiddleName";
            // 
            // tbInvoice_Gonderilmisler_ACP_Person_NameSuffix
            // 
            this.tbInvoice_Gonderilmisler_ACP_Person_NameSuffix.ColumnName = "ACP_Person_NameSuffix";
            // 
            // tbInvoice_Gonderilmisler_ACP_Person_Title
            // 
            this.tbInvoice_Gonderilmisler_ACP_Person_Title.ColumnName = "ACP_Person_Title";
            // 
            // tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification1_schemeID
            // 
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification1_schemeID.ColumnName = "ACP_AgentParty_PartyIdentification1_schemeID";
            // 
            // tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification1_ID
            // 
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification1_ID.ColumnName = "ACP_AgentParty_PartyIdentification1_ID";
            // 
            // tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification2_schemeID
            // 
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification2_schemeID.ColumnName = "ACP_AgentParty_PartyIdentification2_schemeID";
            // 
            // tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification2_ID
            // 
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification2_ID.ColumnName = "ACP_AgentParty_PartyIdentification2_ID";
            // 
            // tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification3_schemeID
            // 
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification3_schemeID.ColumnName = "ACP_AgentParty_PartyIdentification3_schemeID";
            // 
            // tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification3_ID
            // 
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification3_ID.ColumnName = "ACP_AgentParty_PartyIdentification3_ID";
            // 
            // tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification4_schemeID
            // 
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification4_schemeID.ColumnName = "ACP_AgentParty_PartyIdentification4_schemeID";
            // 
            // tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification4_ID
            // 
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification4_ID.ColumnName = "ACP_AgentParty_PartyIdentification4_ID";
            // 
            // tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification5_schemeID
            // 
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification5_schemeID.ColumnName = "ACP_AgentParty_PartyIdentification5_schemeID";
            // 
            // tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification5_ID
            // 
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification5_ID.ColumnName = "ACP_AgentParty_PartyIdentification5_ID";
            // 
            // tbInvoice_Gonderilmisler_ACP_AgentParty_PartyName
            // 
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyName.ColumnName = "ACP_AgentParty_PartyName";
            // 
            // tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_StreetName
            // 
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_StreetName.ColumnName = "ACP_AgentParty_PostalAddress_StreetName";
            // 
            // tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_Room
            // 
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_Room.ColumnName = "ACP_AgentParty_PostalAddress_Room";
            // 
            // tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_BuildingNumber
            // 
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_BuildingNumber.ColumnName = "ACP_AgentParty_PostalAddress_BuildingNumber";
            // 
            // tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_BuildingName
            // 
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_BuildingName.ColumnName = "ACP_AgentParty_PostalAddress_BuildingName";
            // 
            // tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_CitySubdivisionName
            // 
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_CitySubdivisionName.ColumnName = "ACP_AgentParty_PostalAddress_CitySubdivisionName";
            // 
            // tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_CityName
            // 
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_CityName.ColumnName = "ACP_AgentParty_PostalAddress_CityName";
            // 
            // tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_Country
            // 
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_Country.ColumnName = "ACP_AgentParty_PostalAddress_Country";
            // 
            // tbInvoice_Gonderilmisler_ACP_AgentParty_PartyTaxSchemeName
            // 
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyTaxSchemeName.ColumnName = "ACP_AgentParty_PartyTaxSchemeName";
            // 
            // tbInvoice_Gonderilmisler_ACP_AgentParty_PartyTaxSchemeTaxTypeCode
            // 
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_PartyTaxSchemeTaxTypeCode.ColumnName = "ACP_AgentParty_PartyTaxSchemeTaxTypeCode";
            // 
            // tbInvoice_Gonderilmisler_ACP_AgentParty_WebsiteURI
            // 
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_WebsiteURI.ColumnName = "ACP_AgentParty_WebsiteURI";
            // 
            // tbInvoice_Gonderilmisler_ACP_AgentParty_Contact_Telephone
            // 
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_Contact_Telephone.ColumnName = "ACP_AgentParty_Contact_Telephone";
            // 
            // tbInvoice_Gonderilmisler_ACP_AgentParty_Contact_Telefax
            // 
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_Contact_Telefax.ColumnName = "ACP_AgentParty_Contact_Telefax";
            // 
            // tbInvoice_Gonderilmisler_ACP_AgentParty_Contact_ElectronicMail
            // 
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_Contact_ElectronicMail.ColumnName = "ACP_AgentParty_Contact_ElectronicMail";
            // 
            // tbInvoice_Gonderilmisler_ACP_AgentParty_Person_FirstName
            // 
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_Person_FirstName.ColumnName = "ACP_AgentParty_Person_FirstName";
            // 
            // tbInvoice_Gonderilmisler_ACP_AgentParty_Person_FamilyName
            // 
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_Person_FamilyName.ColumnName = "ACP_AgentParty_Person_FamilyName";
            // 
            // tbInvoice_Gonderilmisler_ACP_AgentParty_Person_MiddleName
            // 
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_Person_MiddleName.ColumnName = "ACP_AgentParty_Person_MiddleName";
            // 
            // tbInvoice_Gonderilmisler_ACP_AgentParty_Person_NameSuffix
            // 
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_Person_NameSuffix.ColumnName = "ACP_AgentParty_Person_NameSuffix";
            // 
            // tbInvoice_Gonderilmisler_ACP_AgentParty_Person_Title
            // 
            this.tbInvoice_Gonderilmisler_ACP_AgentParty_Person_Title.ColumnName = "ACP_AgentParty_Person_Title";
            // 
            // tbInvoice_Gonderilmisler_TaxExchangeRate_SourceCurrencyCode
            // 
            this.tbInvoice_Gonderilmisler_TaxExchangeRate_SourceCurrencyCode.ColumnName = "TaxExchangeRate_SourceCurrencyCode";
            // 
            // tbInvoice_Gonderilmisler_TaxExchangeRate_TargetCurrencyCode
            // 
            this.tbInvoice_Gonderilmisler_TaxExchangeRate_TargetCurrencyCode.ColumnName = "TaxExchangeRate_TargetCurrencyCode";
            // 
            // tbInvoice_Gonderilmisler_TaxExchangeRate_CalculationRate
            // 
            this.tbInvoice_Gonderilmisler_TaxExchangeRate_CalculationRate.ColumnName = "TaxExchangeRate_CalculationRate";
            this.tbInvoice_Gonderilmisler_TaxExchangeRate_CalculationRate.DataType = typeof(double);
            // 
            // tbInvoice_Gonderilmisler_TaxExchangeRate_Date
            // 
            this.tbInvoice_Gonderilmisler_TaxExchangeRate_Date.ColumnName = "TaxExchangeRate_Date";
            this.tbInvoice_Gonderilmisler_TaxExchangeRate_Date.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_Gonderilmisler_PricingExchangeRate_SourceCurrencyCode
            // 
            this.tbInvoice_Gonderilmisler_PricingExchangeRate_SourceCurrencyCode.ColumnName = "PricingExchangeRate_SourceCurrencyCode";
            // 
            // tbInvoice_Gonderilmisler_PricingExchangeRate_TargetCurrencyCode
            // 
            this.tbInvoice_Gonderilmisler_PricingExchangeRate_TargetCurrencyCode.ColumnName = "PricingExchangeRate_TargetCurrencyCode";
            // 
            // tbInvoice_Gonderilmisler_PricingExchangeRate_CalculationRate
            // 
            this.tbInvoice_Gonderilmisler_PricingExchangeRate_CalculationRate.ColumnName = "PricingExchangeRate_CalculationRate";
            this.tbInvoice_Gonderilmisler_PricingExchangeRate_CalculationRate.DataType = typeof(double);
            // 
            // tbInvoice_Gonderilmisler_PricingExchangeRate_Date
            // 
            this.tbInvoice_Gonderilmisler_PricingExchangeRate_Date.ColumnName = "PricingExchangeRate_Date";
            this.tbInvoice_Gonderilmisler_PricingExchangeRate_Date.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_Gonderilmisler_PaymentExchangeRate_SourceCurrencyCode
            // 
            this.tbInvoice_Gonderilmisler_PaymentExchangeRate_SourceCurrencyCode.ColumnName = "PaymentExchangeRate_SourceCurrencyCode";
            // 
            // tbInvoice_Gonderilmisler_PaymentExchangeRate_TargetCurrencyCode
            // 
            this.tbInvoice_Gonderilmisler_PaymentExchangeRate_TargetCurrencyCode.ColumnName = "PaymentExchangeRate_TargetCurrencyCode";
            // 
            // tbInvoice_Gonderilmisler_PaymentExchangeRate_CalculationRate
            // 
            this.tbInvoice_Gonderilmisler_PaymentExchangeRate_CalculationRate.ColumnName = "PaymentExchangeRate_CalculationRate";
            this.tbInvoice_Gonderilmisler_PaymentExchangeRate_CalculationRate.DataType = typeof(double);
            // 
            // tbInvoice_Gonderilmisler_PaymentExchangeRate_Date
            // 
            this.tbInvoice_Gonderilmisler_PaymentExchangeRate_Date.ColumnName = "PaymentExchangeRate_Date";
            this.tbInvoice_Gonderilmisler_PaymentExchangeRate_Date.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_Gonderilmisler_PaymentAlternativeExchangeRate_SourceCurrencyCode
            // 
            this.tbInvoice_Gonderilmisler_PaymentAlternativeExchangeRate_SourceCurrencyCode.ColumnName = "PaymentAlternativeExchangeRate_SourceCurrencyCode";
            // 
            // tbInvoice_Gonderilmisler_PaymentAlternativeExchangeRate_TargetCurrencyCode
            // 
            this.tbInvoice_Gonderilmisler_PaymentAlternativeExchangeRate_TargetCurrencyCode.ColumnName = "PaymentAlternativeExchangeRate_TargetCurrencyCode";
            // 
            // tbInvoice_Gonderilmisler_PaymentAlternativeExchangeRate_CalculationRate
            // 
            this.tbInvoice_Gonderilmisler_PaymentAlternativeExchangeRate_CalculationRate.ColumnName = "PaymentAlternativeExchangeRate_CalculationRate";
            this.tbInvoice_Gonderilmisler_PaymentAlternativeExchangeRate_CalculationRate.DataType = typeof(double);
            // 
            // tbInvoice_Gonderilmisler_PaymentAlternativeExchangeRate_Date
            // 
            this.tbInvoice_Gonderilmisler_PaymentAlternativeExchangeRate_Date.ColumnName = "PaymentAlternativeExchangeRate_Date";
            this.tbInvoice_Gonderilmisler_PaymentAlternativeExchangeRate_Date.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_Gonderilmisler_TaxAmount
            // 
            this.tbInvoice_Gonderilmisler_TaxAmount.ColumnName = "TaxAmount";
            this.tbInvoice_Gonderilmisler_TaxAmount.DataType = typeof(double);
            // 
            // tbInvoice_Gonderilmisler_LegalMonetaryTotal_LineExtensionAmount
            // 
            this.tbInvoice_Gonderilmisler_LegalMonetaryTotal_LineExtensionAmount.ColumnName = "LegalMonetaryTotal_LineExtensionAmount";
            this.tbInvoice_Gonderilmisler_LegalMonetaryTotal_LineExtensionAmount.DataType = typeof(double);
            // 
            // tbInvoice_Gonderilmisler_LegalMonetaryTotal_TaxExclusiveAmount
            // 
            this.tbInvoice_Gonderilmisler_LegalMonetaryTotal_TaxExclusiveAmount.ColumnName = "LegalMonetaryTotal_TaxExclusiveAmount";
            this.tbInvoice_Gonderilmisler_LegalMonetaryTotal_TaxExclusiveAmount.DataType = typeof(double);
            // 
            // tbInvoice_Gonderilmisler_LegalMonetaryTotal_TaxInclusiveAmount
            // 
            this.tbInvoice_Gonderilmisler_LegalMonetaryTotal_TaxInclusiveAmount.ColumnName = "LegalMonetaryTotal_TaxInclusiveAmount";
            this.tbInvoice_Gonderilmisler_LegalMonetaryTotal_TaxInclusiveAmount.DataType = typeof(double);
            // 
            // tbInvoice_Gonderilmisler_LegalMonetaryTotal_AllowanceTotalAmount
            // 
            this.tbInvoice_Gonderilmisler_LegalMonetaryTotal_AllowanceTotalAmount.ColumnName = "LegalMonetaryTotal_AllowanceTotalAmount";
            this.tbInvoice_Gonderilmisler_LegalMonetaryTotal_AllowanceTotalAmount.DataType = typeof(double);
            // 
            // tbInvoice_Gonderilmisler_LegalMonetaryTotal_ChargeTotalAmount
            // 
            this.tbInvoice_Gonderilmisler_LegalMonetaryTotal_ChargeTotalAmount.ColumnName = "LegalMonetaryTotal_ChargeTotalAmount";
            this.tbInvoice_Gonderilmisler_LegalMonetaryTotal_ChargeTotalAmount.DataType = typeof(double);
            // 
            // tbInvoice_Gonderilmisler_LegalMonetaryTotal_PayableRoundingAmount
            // 
            this.tbInvoice_Gonderilmisler_LegalMonetaryTotal_PayableRoundingAmount.ColumnName = "LegalMonetaryTotal_PayableRoundingAmount";
            this.tbInvoice_Gonderilmisler_LegalMonetaryTotal_PayableRoundingAmount.DataType = typeof(double);
            // 
            // tbInvoice_Gonderilmisler_LegalMonetaryTotal_PayableAmount
            // 
            this.tbInvoice_Gonderilmisler_LegalMonetaryTotal_PayableAmount.ColumnName = "LegalMonetaryTotal_PayableAmount";
            this.tbInvoice_Gonderilmisler_LegalMonetaryTotal_PayableAmount.DataType = typeof(double);
            // 
            // tbInvoice_Gonderilmisler_WithholdingTaxAmount
            // 
            this.tbInvoice_Gonderilmisler_WithholdingTaxAmount.ColumnName = "WithholdingTaxAmount";
            this.tbInvoice_Gonderilmisler_WithholdingTaxAmount.DataType = typeof(double);
            // 
            // tbInvoice_Gonderilmisler_Message
            // 
            this.tbInvoice_Gonderilmisler_Message.ColumnName = "Message";
            // 
            // sqlCommand13
            // 
            this.sqlCommand13.CommandText = "SELECT * FROM Invoice WHERE Deleted = 0 AND IOType=0 AND LocalStatus>0\r\nAND Issue" +
    "Date BETWEEN @FormDate1 AND @FormDate2 \r\n";
            this.sqlCommand13.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@FormDate1", System.Data.SqlDbType.DateTime),
            new System.Data.SqlClient.SqlParameter("@FormDate2", System.Data.SqlDbType.DateTime)});
            // 
            // grGonderilmislerView
            // 
            this.grGonderilmislerView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn138,
            this.gridColumn139,
            this.gridColumn140,
            this.gridColumn141,
            this.gridColumn142,
            this.gridColumn143,
            this.gridColumn144,
            this.gridColumn145,
            this.gridColumn146,
            this.gridColumn147,
            this.colMessage,
            this.gridColumn148,
            this.gridColumn149,
            this.gridColumn150,
            this.gridColumn151,
            this.gridColumn152,
            this.gridColumn153,
            this.gridColumn154,
            this.gridColumn155,
            this.gridColumn156,
            this.gridColumn157,
            this.gridColumn158,
            this.gridColumn159,
            this.gridColumn160,
            this.gridColumn161,
            this.gridColumn162,
            this.gridColumn163,
            this.gridColumn164,
            this.gridColumn165,
            this.gridColumn166,
            this.gridColumn167,
            this.gridColumn168,
            this.gridColumn169,
            this.gridColumn170,
            this.gridColumn171,
            this.gridColumn172,
            this.gridColumn173,
            this.gridColumn174,
            this.gridColumn175,
            this.gridColumn176,
            this.gridColumn177,
            this.gridColumn178,
            this.gridColumn179,
            this.gridColumn180,
            this.gridColumn181,
            this.gridColumn182,
            this.gridColumn183,
            this.gridColumn184,
            this.gridColumn185,
            this.gridColumn186,
            this.gridColumn187,
            this.gridColumn188,
            this.gridColumn189,
            this.gridColumn190,
            this.gridColumn191,
            this.gridColumn192,
            this.gridColumn193,
            this.gridColumn194,
            this.gridColumn195,
            this.gridColumn196,
            this.gridColumn197,
            this.gridColumn198,
            this.gridColumn199,
            this.gridColumn200,
            this.gridColumn201,
            this.gridColumn202,
            this.gridColumn203,
            this.gridColumn204,
            this.gridColumn205,
            this.gridColumn206,
            this.gridColumn207,
            this.gridColumn208,
            this.gridColumn209,
            this.gridColumn210,
            this.gridColumn211,
            this.gridColumn212,
            this.gridColumn213,
            this.gridColumn214,
            this.gridColumn215,
            this.gridColumn216,
            this.gridColumn217,
            this.gridColumn218,
            this.gridColumn219,
            this.gridColumn220,
            this.gridColumn221,
            this.gridColumn222,
            this.gridColumn223,
            this.gridColumn224,
            this.gridColumn225,
            this.gridColumn226,
            this.gridColumn227,
            this.gridColumn228,
            this.gridColumn229,
            this.gridColumn230,
            this.gridColumn231,
            this.gridColumn232,
            this.gridColumn233,
            this.gridColumn234,
            this.gridColumn235,
            this.gridColumn236,
            this.gridColumn237,
            this.gridColumn238,
            this.gridColumn239,
            this.gridColumn240,
            this.gridColumn241,
            this.gridColumn242,
            this.gridColumn243,
            this.gridColumn244,
            this.gridColumn245,
            this.gridColumn246,
            this.gridColumn247,
            this.gridColumn248,
            this.gridColumn249,
            this.gridColumn250,
            this.gridColumn251,
            this.gridColumn252,
            this.gridColumn253,
            this.gridColumn254,
            this.gridColumn255,
            this.gridColumn256,
            this.gridColumn257,
            this.gridColumn258,
            this.gridColumn259,
            this.gridColumn260,
            this.gridColumn261,
            this.gridColumn262,
            this.gridColumn263,
            this.gridColumn264,
            this.gridColumn265,
            this.gridColumn266,
            this.gridColumn267,
            this.gridColumn268,
            this.gridColumn269,
            this.gridColumn270,
            this.gridColumn271,
            this.gridColumn272,
            this.gridColumn273,
            this.colLegalMonetaryTotal_ChargeTotalAmount2,
            this.gridColumn274,
            this.gridColumn277,
            this.gridColumn278});
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Blue;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition1.Expression = "[Status] == 5";
            styleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition2.Appearance.Options.UseForeColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition2.Expression = "[Status] == 7";
            styleFormatCondition8.Appearance.ForeColor = System.Drawing.Color.Maroon;
            styleFormatCondition8.Appearance.Options.UseForeColor = true;
            styleFormatCondition8.ApplyToRow = true;
            styleFormatCondition8.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression;
            styleFormatCondition8.Expression = "[Status] == 10";
            this.grGonderilmislerView.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2,
            styleFormatCondition8});
            this.grGonderilmislerView.GridControl = this.grGonderilmisler;
            this.grGonderilmislerView.Name = "grGonderilmislerView";
            this.grGonderilmislerView.OptionsBehavior.Editable = false;
            this.grGonderilmislerView.OptionsLayout.LayoutVersion = "1.2";
            this.grGonderilmislerView.OptionsSelection.MultiSelect = true;
            this.grGonderilmislerView.OptionsView.ColumnAutoWidth = false;
            this.grGonderilmislerView.OptionsView.ShowAutoFilterRow = true;
            this.grGonderilmislerView.OptionsView.ShowFooter = true;
            // 
            // gridColumn138
            // 
            this.gridColumn138.FieldName = "InvoiceID";
            this.gridColumn138.Name = "gridColumn138";
            // 
            // gridColumn139
            // 
            this.gridColumn139.FieldName = "IntegratorID";
            this.gridColumn139.Name = "gridColumn139";
            this.gridColumn139.Width = 159;
            // 
            // gridColumn140
            // 
            this.gridColumn140.FieldName = "IOType";
            this.gridColumn140.Name = "gridColumn140";
            this.gridColumn140.Width = 81;
            // 
            // gridColumn141
            // 
            this.gridColumn141.FieldName = "CreatedBy";
            this.gridColumn141.Name = "gridColumn141";
            // 
            // gridColumn142
            // 
            this.gridColumn142.FieldName = "CreatedDate";
            this.gridColumn142.Name = "gridColumn142";
            // 
            // gridColumn143
            // 
            this.gridColumn143.FieldName = "ModifiedBy";
            this.gridColumn143.Name = "gridColumn143";
            // 
            // gridColumn144
            // 
            this.gridColumn144.FieldName = "ModifiedDate";
            this.gridColumn144.Name = "gridColumn144";
            // 
            // gridColumn145
            // 
            this.gridColumn145.FieldName = "LocalStatus";
            this.gridColumn145.Name = "gridColumn145";
            // 
            // gridColumn146
            // 
            this.gridColumn146.Caption = "Durum";
            this.gridColumn146.FieldName = "Status";
            this.gridColumn146.Name = "gridColumn146";
            this.gridColumn146.Width = 64;
            // 
            // gridColumn147
            // 
            this.gridColumn147.Caption = "Durum aciklama";
            this.gridColumn147.FieldName = "StatusDescription";
            this.gridColumn147.Name = "gridColumn147";
            this.gridColumn147.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "StatusDescription", "{0}")});
            this.gridColumn147.Visible = true;
            this.gridColumn147.VisibleIndex = 3;
            this.gridColumn147.Width = 159;
            // 
            // colMessage
            // 
            this.colMessage.FieldName = "Message";
            this.colMessage.Name = "colMessage";
            this.colMessage.Visible = true;
            this.colMessage.VisibleIndex = 4;
            this.colMessage.Width = 109;
            // 
            // gridColumn148
            // 
            this.gridColumn148.Caption = "Posta kutusu";
            this.gridColumn148.FieldName = "PostBox";
            this.gridColumn148.Name = "gridColumn148";
            this.gridColumn148.Width = 142;
            // 
            // gridColumn149
            // 
            this.gridColumn149.Caption = "Senaryo";
            this.gridColumn149.FieldName = "ProfileID";
            this.gridColumn149.Name = "gridColumn149";
            this.gridColumn149.Visible = true;
            this.gridColumn149.VisibleIndex = 5;
            this.gridColumn149.Width = 107;
            // 
            // gridColumn150
            // 
            this.gridColumn150.Caption = "ID (Fatura no)";
            this.gridColumn150.FieldName = "ID";
            this.gridColumn150.Name = "gridColumn150";
            this.gridColumn150.Visible = true;
            this.gridColumn150.VisibleIndex = 6;
            this.gridColumn150.Width = 166;
            // 
            // gridColumn151
            // 
            this.gridColumn151.Caption = "Fatura tarihi";
            this.gridColumn151.DisplayFormat.FormatString = "dd.MM.yyyy";
            this.gridColumn151.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn151.FieldName = "IssueDate";
            this.gridColumn151.Name = "gridColumn151";
            this.gridColumn151.Visible = true;
            this.gridColumn151.VisibleIndex = 7;
            // 
            // gridColumn152
            // 
            this.gridColumn152.Caption = "Saati";
            this.gridColumn152.DisplayFormat.FormatString = "HH:mm";
            this.gridColumn152.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn152.FieldName = "IssueTime";
            this.gridColumn152.Name = "gridColumn152";
            this.gridColumn152.Visible = true;
            this.gridColumn152.VisibleIndex = 19;
            // 
            // gridColumn153
            // 
            this.gridColumn153.Caption = "Türü";
            this.gridColumn153.FieldName = "InvoiceTypeCode";
            this.gridColumn153.Name = "gridColumn153";
            this.gridColumn153.Visible = true;
            this.gridColumn153.VisibleIndex = 8;
            // 
            // gridColumn154
            // 
            this.gridColumn154.Caption = "Para birimi";
            this.gridColumn154.FieldName = "DocumentCurrencyCode";
            this.gridColumn154.Name = "gridColumn154";
            this.gridColumn154.Visible = true;
            this.gridColumn154.VisibleIndex = 9;
            // 
            // gridColumn155
            // 
            this.gridColumn155.FieldName = "TaxCurrencyCode";
            this.gridColumn155.Name = "gridColumn155";
            // 
            // gridColumn156
            // 
            this.gridColumn156.FieldName = "PricingCurrencyCode";
            this.gridColumn156.Name = "gridColumn156";
            // 
            // gridColumn157
            // 
            this.gridColumn157.FieldName = "PaymentCurrencyCode";
            this.gridColumn157.Name = "gridColumn157";
            // 
            // gridColumn158
            // 
            this.gridColumn158.FieldName = "PaymentAlternativeCurrencyCode";
            this.gridColumn158.Name = "gridColumn158";
            // 
            // gridColumn159
            // 
            this.gridColumn159.Caption = "#Satır";
            this.gridColumn159.FieldName = "LineCountNumeric";
            this.gridColumn159.Name = "gridColumn159";
            this.gridColumn159.Visible = true;
            this.gridColumn159.VisibleIndex = 10;
            this.gridColumn159.Width = 93;
            // 
            // gridColumn160
            // 
            this.gridColumn160.FieldName = "InvoicePeriod_StartDate";
            this.gridColumn160.Name = "gridColumn160";
            // 
            // gridColumn161
            // 
            this.gridColumn161.FieldName = "InvoicePeriod_EndDate";
            this.gridColumn161.Name = "gridColumn161";
            // 
            // gridColumn162
            // 
            this.gridColumn162.FieldName = "InvoicePeriod_DurationMeasure";
            this.gridColumn162.Name = "gridColumn162";
            // 
            // gridColumn163
            // 
            this.gridColumn163.FieldName = "InvoicePeriod_Description";
            this.gridColumn163.Name = "gridColumn163";
            // 
            // gridColumn164
            // 
            this.gridColumn164.Caption = "Tedarikci VKTuru";
            this.gridColumn164.FieldName = "ASP_PartyIdentification1_schemeID";
            this.gridColumn164.Name = "gridColumn164";
            this.gridColumn164.Visible = true;
            this.gridColumn164.VisibleIndex = 23;
            this.gridColumn164.Width = 109;
            // 
            // gridColumn165
            // 
            this.gridColumn165.Caption = "Tedarikci  Vergi No";
            this.gridColumn165.FieldName = "ASP_PartyIdentification1_ID";
            this.gridColumn165.Name = "gridColumn165";
            this.gridColumn165.Visible = true;
            this.gridColumn165.VisibleIndex = 24;
            this.gridColumn165.Width = 126;
            // 
            // gridColumn166
            // 
            this.gridColumn166.FieldName = "ASP_PartyIdentification2_schemeID";
            this.gridColumn166.Name = "gridColumn166";
            // 
            // gridColumn167
            // 
            this.gridColumn167.FieldName = "ASP_PartyIdentification2_ID";
            this.gridColumn167.Name = "gridColumn167";
            // 
            // gridColumn168
            // 
            this.gridColumn168.FieldName = "ASP_PartyIdentification3_schemeID";
            this.gridColumn168.Name = "gridColumn168";
            // 
            // gridColumn169
            // 
            this.gridColumn169.FieldName = "ASP_PartyIdentification3_ID";
            this.gridColumn169.Name = "gridColumn169";
            // 
            // gridColumn170
            // 
            this.gridColumn170.FieldName = "ASP_PartyIdentification4_schemeID";
            this.gridColumn170.Name = "gridColumn170";
            // 
            // gridColumn171
            // 
            this.gridColumn171.FieldName = "ASP_PartyIdentification4_ID";
            this.gridColumn171.Name = "gridColumn171";
            // 
            // gridColumn172
            // 
            this.gridColumn172.FieldName = "ASP_PartyIdentification5_schemeID";
            this.gridColumn172.Name = "gridColumn172";
            // 
            // gridColumn173
            // 
            this.gridColumn173.FieldName = "ASP_PartyIdentification5_ID";
            this.gridColumn173.Name = "gridColumn173";
            // 
            // gridColumn174
            // 
            this.gridColumn174.Caption = "Tedarikçi ünvan";
            this.gridColumn174.FieldName = "ASP_PartyName";
            this.gridColumn174.Name = "gridColumn174";
            this.gridColumn174.Visible = true;
            this.gridColumn174.VisibleIndex = 0;
            this.gridColumn174.Width = 93;
            // 
            // gridColumn175
            // 
            this.gridColumn175.FieldName = "ASP_PostalAddress_StreetName";
            this.gridColumn175.Name = "gridColumn175";
            // 
            // gridColumn176
            // 
            this.gridColumn176.FieldName = "ASP_PostalAddress_Room";
            this.gridColumn176.Name = "gridColumn176";
            // 
            // gridColumn177
            // 
            this.gridColumn177.FieldName = "ASP_PostalAddress_BuildingNumber";
            this.gridColumn177.Name = "gridColumn177";
            // 
            // gridColumn178
            // 
            this.gridColumn178.FieldName = "ASP_PostalAddress_CitySubdivisionName";
            this.gridColumn178.Name = "gridColumn178";
            // 
            // gridColumn179
            // 
            this.gridColumn179.FieldName = "ASP_PostalAddress_CityName";
            this.gridColumn179.Name = "gridColumn179";
            // 
            // gridColumn180
            // 
            this.gridColumn180.FieldName = "ASP_PostalAddress_Country";
            this.gridColumn180.Name = "gridColumn180";
            // 
            // gridColumn181
            // 
            this.gridColumn181.Caption = "Tedarikci Vergi D.";
            this.gridColumn181.FieldName = "ASP_PartyTaxScheme";
            this.gridColumn181.Name = "gridColumn181";
            this.gridColumn181.Visible = true;
            this.gridColumn181.VisibleIndex = 25;
            // 
            // gridColumn182
            // 
            this.gridColumn182.FieldName = "ASP_Contact_Telephone";
            this.gridColumn182.Name = "gridColumn182";
            // 
            // gridColumn183
            // 
            this.gridColumn183.FieldName = "ASP_Contact_Telefax";
            this.gridColumn183.Name = "gridColumn183";
            // 
            // gridColumn184
            // 
            this.gridColumn184.FieldName = "ASP_Contact_ElectronicMail";
            this.gridColumn184.Name = "gridColumn184";
            // 
            // gridColumn185
            // 
            this.gridColumn185.FieldName = "ASP_Person_FirstName";
            this.gridColumn185.Name = "gridColumn185";
            // 
            // gridColumn186
            // 
            this.gridColumn186.FieldName = "ASP_Person_FamilyName";
            this.gridColumn186.Name = "gridColumn186";
            // 
            // gridColumn187
            // 
            this.gridColumn187.FieldName = "ASP_AgentParty_PartyIdentification1_schemeID";
            this.gridColumn187.Name = "gridColumn187";
            // 
            // gridColumn188
            // 
            this.gridColumn188.FieldName = "ASP_AgentParty_PartyIdentification1_ID";
            this.gridColumn188.Name = "gridColumn188";
            // 
            // gridColumn189
            // 
            this.gridColumn189.FieldName = "ASP_AgentParty_PartyIdentification2_schemeID";
            this.gridColumn189.Name = "gridColumn189";
            // 
            // gridColumn190
            // 
            this.gridColumn190.FieldName = "ASP_AgentParty_PartyIdentification2_ID";
            this.gridColumn190.Name = "gridColumn190";
            // 
            // gridColumn191
            // 
            this.gridColumn191.FieldName = "ASP_AgentParty_PartyIdentification3_schemeID";
            this.gridColumn191.Name = "gridColumn191";
            // 
            // gridColumn192
            // 
            this.gridColumn192.FieldName = "ASP_AgentParty_PartyIdentification3_ID";
            this.gridColumn192.Name = "gridColumn192";
            // 
            // gridColumn193
            // 
            this.gridColumn193.FieldName = "ASP_AgentParty_PartyIdentification4_schemeID";
            this.gridColumn193.Name = "gridColumn193";
            // 
            // gridColumn194
            // 
            this.gridColumn194.FieldName = "ASP_AgentParty_PartyIdentification4_ID";
            this.gridColumn194.Name = "gridColumn194";
            // 
            // gridColumn195
            // 
            this.gridColumn195.FieldName = "ASP_AgentParty_PartyIdentification5_schemeID";
            this.gridColumn195.Name = "gridColumn195";
            // 
            // gridColumn196
            // 
            this.gridColumn196.FieldName = "ASP_AgentParty_PartyIdentification5_ID";
            this.gridColumn196.Name = "gridColumn196";
            // 
            // gridColumn197
            // 
            this.gridColumn197.FieldName = "ASP_AgentParty_PartyName";
            this.gridColumn197.Name = "gridColumn197";
            // 
            // gridColumn198
            // 
            this.gridColumn198.FieldName = "ASP_AgentParty_PostalAddress_StreetName";
            this.gridColumn198.Name = "gridColumn198";
            // 
            // gridColumn199
            // 
            this.gridColumn199.FieldName = "ASP_AgentParty_PostalAddress_Room";
            this.gridColumn199.Name = "gridColumn199";
            // 
            // gridColumn200
            // 
            this.gridColumn200.FieldName = "ASP_AgentParty_PostalAddress_BuildingNumber";
            this.gridColumn200.Name = "gridColumn200";
            // 
            // gridColumn201
            // 
            this.gridColumn201.FieldName = "ASP_AgentParty_PostalAddress_CitySubdivisionName";
            this.gridColumn201.Name = "gridColumn201";
            // 
            // gridColumn202
            // 
            this.gridColumn202.FieldName = "ASP_AgentParty_PostalAddress_CityName";
            this.gridColumn202.Name = "gridColumn202";
            // 
            // gridColumn203
            // 
            this.gridColumn203.FieldName = "ASP_AgentParty_PostalAddress_Country";
            this.gridColumn203.Name = "gridColumn203";
            // 
            // gridColumn204
            // 
            this.gridColumn204.FieldName = "ASP_AgentParty_PartyTaxScheme";
            this.gridColumn204.Name = "gridColumn204";
            // 
            // gridColumn205
            // 
            this.gridColumn205.FieldName = "ASP_AgentParty_Contact_Telephone";
            this.gridColumn205.Name = "gridColumn205";
            // 
            // gridColumn206
            // 
            this.gridColumn206.FieldName = "ASP_AgentParty_Contact_Telefax";
            this.gridColumn206.Name = "gridColumn206";
            // 
            // gridColumn207
            // 
            this.gridColumn207.FieldName = "ASP_AgentParty_Contact_ElectronicMail";
            this.gridColumn207.Name = "gridColumn207";
            // 
            // gridColumn208
            // 
            this.gridColumn208.Caption = "Musteri VKTuru";
            this.gridColumn208.FieldName = "ACP_PartyIdentification1_schemeID";
            this.gridColumn208.Name = "gridColumn208";
            this.gridColumn208.Visible = true;
            this.gridColumn208.VisibleIndex = 21;
            this.gridColumn208.Width = 101;
            // 
            // gridColumn209
            // 
            this.gridColumn209.Caption = "Musteri Vergi No";
            this.gridColumn209.FieldName = "ACP_PartyIdentification1_ID";
            this.gridColumn209.Name = "gridColumn209";
            this.gridColumn209.Visible = true;
            this.gridColumn209.VisibleIndex = 22;
            this.gridColumn209.Width = 114;
            // 
            // gridColumn210
            // 
            this.gridColumn210.FieldName = "ACP_PartyIdentification2_schemeID";
            this.gridColumn210.Name = "gridColumn210";
            // 
            // gridColumn211
            // 
            this.gridColumn211.FieldName = "ACP_PartyIdentification2_ID";
            this.gridColumn211.Name = "gridColumn211";
            // 
            // gridColumn212
            // 
            this.gridColumn212.FieldName = "ACP_PartyIdentification3_schemeID";
            this.gridColumn212.Name = "gridColumn212";
            // 
            // gridColumn213
            // 
            this.gridColumn213.FieldName = "ACP_PartyIdentification3_ID";
            this.gridColumn213.Name = "gridColumn213";
            // 
            // gridColumn214
            // 
            this.gridColumn214.FieldName = "ACP_PartyIdentification4_schemeID";
            this.gridColumn214.Name = "gridColumn214";
            // 
            // gridColumn215
            // 
            this.gridColumn215.FieldName = "ACP_PartyIdentification4_ID";
            this.gridColumn215.Name = "gridColumn215";
            // 
            // gridColumn216
            // 
            this.gridColumn216.FieldName = "ACP_PartyIdentification5_schemeID";
            this.gridColumn216.Name = "gridColumn216";
            // 
            // gridColumn217
            // 
            this.gridColumn217.FieldName = "ACP_PartyIdentification5_ID";
            this.gridColumn217.Name = "gridColumn217";
            // 
            // gridColumn218
            // 
            this.gridColumn218.Caption = "Müşteri ünvan";
            this.gridColumn218.FieldName = "ACP_PartyName";
            this.gridColumn218.Name = "gridColumn218";
            this.gridColumn218.Visible = true;
            this.gridColumn218.VisibleIndex = 1;
            this.gridColumn218.Width = 229;
            // 
            // gridColumn219
            // 
            this.gridColumn219.FieldName = "ACP_PostalAddress_StreetName";
            this.gridColumn219.Name = "gridColumn219";
            // 
            // gridColumn220
            // 
            this.gridColumn220.FieldName = "ACP_PostalAddress_Room";
            this.gridColumn220.Name = "gridColumn220";
            // 
            // gridColumn221
            // 
            this.gridColumn221.FieldName = "ACP_PostalAddress_BuildingNumber";
            this.gridColumn221.Name = "gridColumn221";
            // 
            // gridColumn222
            // 
            this.gridColumn222.FieldName = "ACP_PostalAddress_CitySubdivisionName";
            this.gridColumn222.Name = "gridColumn222";
            // 
            // gridColumn223
            // 
            this.gridColumn223.FieldName = "ACP_PostalAddress_CityName";
            this.gridColumn223.Name = "gridColumn223";
            // 
            // gridColumn224
            // 
            this.gridColumn224.FieldName = "ACP_PostalAddress_Country";
            this.gridColumn224.Name = "gridColumn224";
            // 
            // gridColumn225
            // 
            this.gridColumn225.Caption = "Musteri Veri D.";
            this.gridColumn225.FieldName = "ACP_PartyTaxScheme";
            this.gridColumn225.Name = "gridColumn225";
            this.gridColumn225.Visible = true;
            this.gridColumn225.VisibleIndex = 20;
            // 
            // gridColumn226
            // 
            this.gridColumn226.FieldName = "ACP_Contact_Telephone";
            this.gridColumn226.Name = "gridColumn226";
            // 
            // gridColumn227
            // 
            this.gridColumn227.FieldName = "ACP_Contact_Telefax";
            this.gridColumn227.Name = "gridColumn227";
            // 
            // gridColumn228
            // 
            this.gridColumn228.FieldName = "ACP_Contact_ElectronicMail";
            this.gridColumn228.Name = "gridColumn228";
            // 
            // gridColumn229
            // 
            this.gridColumn229.FieldName = "ACP_Person_FirstName";
            this.gridColumn229.Name = "gridColumn229";
            // 
            // gridColumn230
            // 
            this.gridColumn230.FieldName = "ACP_Person_FamilyName";
            this.gridColumn230.Name = "gridColumn230";
            // 
            // gridColumn231
            // 
            this.gridColumn231.FieldName = "ACP_AgentParty_PartyIdentification1_schemeID";
            this.gridColumn231.Name = "gridColumn231";
            // 
            // gridColumn232
            // 
            this.gridColumn232.FieldName = "ACP_AgentParty_PartyIdentification1_ID";
            this.gridColumn232.Name = "gridColumn232";
            // 
            // gridColumn233
            // 
            this.gridColumn233.FieldName = "ACP_AgentParty_PartyIdentification2_schemeID";
            this.gridColumn233.Name = "gridColumn233";
            // 
            // gridColumn234
            // 
            this.gridColumn234.FieldName = "ACP_AgentParty_PartyIdentification2_ID";
            this.gridColumn234.Name = "gridColumn234";
            // 
            // gridColumn235
            // 
            this.gridColumn235.FieldName = "ACP_AgentParty_PartyIdentification3_schemeID";
            this.gridColumn235.Name = "gridColumn235";
            // 
            // gridColumn236
            // 
            this.gridColumn236.FieldName = "ACP_AgentParty_PartyIdentification3_ID";
            this.gridColumn236.Name = "gridColumn236";
            // 
            // gridColumn237
            // 
            this.gridColumn237.FieldName = "ACP_AgentParty_PartyIdentification4_schemeID";
            this.gridColumn237.Name = "gridColumn237";
            // 
            // gridColumn238
            // 
            this.gridColumn238.FieldName = "ACP_AgentParty_PartyIdentification4_ID";
            this.gridColumn238.Name = "gridColumn238";
            // 
            // gridColumn239
            // 
            this.gridColumn239.FieldName = "ACP_AgentParty_PartyIdentification5_schemeID";
            this.gridColumn239.Name = "gridColumn239";
            // 
            // gridColumn240
            // 
            this.gridColumn240.FieldName = "ACP_AgentParty_PartyIdentification5_ID";
            this.gridColumn240.Name = "gridColumn240";
            // 
            // gridColumn241
            // 
            this.gridColumn241.FieldName = "ACP_AgentParty_PartyName";
            this.gridColumn241.Name = "gridColumn241";
            // 
            // gridColumn242
            // 
            this.gridColumn242.FieldName = "ACP_AgentParty_PostalAddress_StreetName";
            this.gridColumn242.Name = "gridColumn242";
            // 
            // gridColumn243
            // 
            this.gridColumn243.FieldName = "ACP_AgentParty_PostalAddress_Room";
            this.gridColumn243.Name = "gridColumn243";
            // 
            // gridColumn244
            // 
            this.gridColumn244.FieldName = "ACP_AgentParty_PostalAddress_BuildingNumber";
            this.gridColumn244.Name = "gridColumn244";
            // 
            // gridColumn245
            // 
            this.gridColumn245.FieldName = "ACP_AgentParty_PostalAddress_CitySubdivisionName";
            this.gridColumn245.Name = "gridColumn245";
            // 
            // gridColumn246
            // 
            this.gridColumn246.FieldName = "ACP_AgentParty_PostalAddress_CityName";
            this.gridColumn246.Name = "gridColumn246";
            // 
            // gridColumn247
            // 
            this.gridColumn247.FieldName = "ACP_AgentParty_PostalAddress_Country";
            this.gridColumn247.Name = "gridColumn247";
            // 
            // gridColumn248
            // 
            this.gridColumn248.FieldName = "ACP_AgentParty_PartyTaxScheme";
            this.gridColumn248.Name = "gridColumn248";
            // 
            // gridColumn249
            // 
            this.gridColumn249.FieldName = "ACP_AgentParty_Contact_Telephone";
            this.gridColumn249.Name = "gridColumn249";
            // 
            // gridColumn250
            // 
            this.gridColumn250.FieldName = "ACP_AgentParty_Contact_Telefax";
            this.gridColumn250.Name = "gridColumn250";
            // 
            // gridColumn251
            // 
            this.gridColumn251.FieldName = "ACP_AgentParty_Contact_ElectronicMail";
            this.gridColumn251.Name = "gridColumn251";
            // 
            // gridColumn252
            // 
            this.gridColumn252.FieldName = "TaxExchangeRate_SourceCurrencyCode";
            this.gridColumn252.Name = "gridColumn252";
            // 
            // gridColumn253
            // 
            this.gridColumn253.FieldName = "TaxExchangeRate_TargetCurrencyCode";
            this.gridColumn253.Name = "gridColumn253";
            // 
            // gridColumn254
            // 
            this.gridColumn254.FieldName = "TaxExchangeRate_CalculationRate";
            this.gridColumn254.Name = "gridColumn254";
            // 
            // gridColumn255
            // 
            this.gridColumn255.FieldName = "TaxExchangeRate_Date";
            this.gridColumn255.Name = "gridColumn255";
            // 
            // gridColumn256
            // 
            this.gridColumn256.FieldName = "PricingExchangeRate_SourceCurrencyCode";
            this.gridColumn256.Name = "gridColumn256";
            // 
            // gridColumn257
            // 
            this.gridColumn257.FieldName = "PricingExchangeRate_TargetCurrencyCode";
            this.gridColumn257.Name = "gridColumn257";
            // 
            // gridColumn258
            // 
            this.gridColumn258.FieldName = "PricingExchangeRate_CalculationRate";
            this.gridColumn258.Name = "gridColumn258";
            // 
            // gridColumn259
            // 
            this.gridColumn259.FieldName = "PricingExchangeRate_Date";
            this.gridColumn259.Name = "gridColumn259";
            // 
            // gridColumn260
            // 
            this.gridColumn260.FieldName = "PaymentExchangeRate_SourceCurrencyCode";
            this.gridColumn260.Name = "gridColumn260";
            // 
            // gridColumn261
            // 
            this.gridColumn261.FieldName = "PaymentExchangeRate_TargetCurrencyCode";
            this.gridColumn261.Name = "gridColumn261";
            // 
            // gridColumn262
            // 
            this.gridColumn262.FieldName = "PaymentExchangeRate_CalculationRate";
            this.gridColumn262.Name = "gridColumn262";
            // 
            // gridColumn263
            // 
            this.gridColumn263.FieldName = "PaymentExchangeRate_Date";
            this.gridColumn263.Name = "gridColumn263";
            // 
            // gridColumn264
            // 
            this.gridColumn264.FieldName = "PaymentAlternativeExchangeRate_SourceCurrencyCode";
            this.gridColumn264.Name = "gridColumn264";
            // 
            // gridColumn265
            // 
            this.gridColumn265.FieldName = "PaymentAlternativeExchangeRate_TargetCurrencyCode";
            this.gridColumn265.Name = "gridColumn265";
            // 
            // gridColumn266
            // 
            this.gridColumn266.FieldName = "PaymentAlternativeExchangeRate_CalculationRate";
            this.gridColumn266.Name = "gridColumn266";
            // 
            // gridColumn267
            // 
            this.gridColumn267.FieldName = "PaymentAlternativeExchangeRate_Date";
            this.gridColumn267.Name = "gridColumn267";
            // 
            // gridColumn268
            // 
            this.gridColumn268.Caption = "Vergi Toplamı";
            this.gridColumn268.FieldName = "TaxAmount";
            this.gridColumn268.Name = "gridColumn268";
            this.gridColumn268.Visible = true;
            this.gridColumn268.VisibleIndex = 11;
            // 
            // gridColumn269
            // 
            this.gridColumn269.FieldName = "UUID";
            this.gridColumn269.Name = "gridColumn269";
            this.gridColumn269.Width = 230;
            // 
            // gridColumn270
            // 
            this.gridColumn270.Caption = "Satır toplamı";
            this.gridColumn270.FieldName = "LegalMonetaryTotal_LineExtensionAmount";
            this.gridColumn270.Name = "gridColumn270";
            this.gridColumn270.Visible = true;
            this.gridColumn270.VisibleIndex = 12;
            // 
            // gridColumn271
            // 
            this.gridColumn271.Caption = "Vergi hariç toplam";
            this.gridColumn271.FieldName = "LegalMonetaryTotal_TaxExclusiveAmount";
            this.gridColumn271.Name = "gridColumn271";
            this.gridColumn271.Visible = true;
            this.gridColumn271.VisibleIndex = 13;
            // 
            // gridColumn272
            // 
            this.gridColumn272.Caption = "Vergi dahil toplam";
            this.gridColumn272.FieldName = "LegalMonetaryTotal_TaxInclusiveAmount";
            this.gridColumn272.Name = "gridColumn272";
            this.gridColumn272.Visible = true;
            this.gridColumn272.VisibleIndex = 14;
            // 
            // gridColumn273
            // 
            this.gridColumn273.Caption = "Toplam indirim";
            this.gridColumn273.FieldName = "LegalMonetaryTotal_AllowanceTotalAmount";
            this.gridColumn273.Name = "gridColumn273";
            this.gridColumn273.Visible = true;
            this.gridColumn273.VisibleIndex = 15;
            // 
            // colLegalMonetaryTotal_ChargeTotalAmount2
            // 
            this.colLegalMonetaryTotal_ChargeTotalAmount2.Caption = "Toplam masraf";
            this.colLegalMonetaryTotal_ChargeTotalAmount2.FieldName = "LegalMonetaryTotal_ChargeTotalAmount";
            this.colLegalMonetaryTotal_ChargeTotalAmount2.Name = "colLegalMonetaryTotal_ChargeTotalAmount2";
            this.colLegalMonetaryTotal_ChargeTotalAmount2.Visible = true;
            this.colLegalMonetaryTotal_ChargeTotalAmount2.VisibleIndex = 16;
            // 
            // gridColumn274
            // 
            this.gridColumn274.Caption = "Yuvarlama";
            this.gridColumn274.FieldName = "LegalMonetaryTotal_PayableRoundingAmount";
            this.gridColumn274.Name = "gridColumn274";
            this.gridColumn274.Visible = true;
            this.gridColumn274.VisibleIndex = 17;
            // 
            // gridColumn277
            // 
            this.gridColumn277.Caption = "Ödenecek tutar";
            this.gridColumn277.FieldName = "LegalMonetaryTotal_PayableAmount";
            this.gridColumn277.Name = "gridColumn277";
            this.gridColumn277.Visible = true;
            this.gridColumn277.VisibleIndex = 18;
            // 
            // gridColumn278
            // 
            this.gridColumn278.FieldName = "IntCode";
            this.gridColumn278.Name = "gridColumn278";
            this.gridColumn278.Visible = true;
            this.gridColumn278.VisibleIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnUpdateStatus);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(978, 50);
            this.panel4.TabIndex = 5;
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Location = new System.Drawing.Point(10, 12);
            this.btnUpdateStatus.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(183, 32);
            this.btnUpdateStatus.TabIndex = 6;
            this.btnUpdateStatus.Text = "Durum guncelle/kontrol et";
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.panelWait);
            this.xtraTabPage4.Controls.Add(this.txtDebug);
            this.xtraTabPage4.Controls.Add(this.button1);
            this.xtraTabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.PageVisible = false;
            this.xtraTabPage4.Size = new System.Drawing.Size(978, 348);
            this.xtraTabPage4.Text = "xtraTabPage4";
            // 
            // panelWait
            // 
            this.panelWait.Controls.Add(this.lblWait);
            this.panelWait.Location = new System.Drawing.Point(328, 34);
            this.panelWait.Margin = new System.Windows.Forms.Padding(2);
            this.panelWait.Name = "panelWait";
            this.panelWait.Size = new System.Drawing.Size(316, 119);
            this.panelWait.TabIndex = 10;
            // 
            // lblWait
            // 
            this.lblWait.Location = new System.Drawing.Point(70, 67);
            this.lblWait.Margin = new System.Windows.Forms.Padding(2);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(92, 13);
            this.lblWait.TabIndex = 0;
            this.lblWait.Text = "Lutfen bekleyiniz...";
            // 
            // txtDebug
            // 
            this.txtDebug.Location = new System.Drawing.Point(16, 131);
            this.txtDebug.Margin = new System.Windows.Forms.Padding(2);
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDebug.Properties.WordWrap = false;
            this.txtDebug.Size = new System.Drawing.Size(643, 293);
            this.txtDebug.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 53);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.grEFaturaMembers);
            this.xtraTabPage5.Controls.Add(this.panel6);
            this.xtraTabPage5.Controls.Add(this.panel5);
            this.xtraTabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.PageVisible = false;
            this.xtraTabPage5.Size = new System.Drawing.Size(978, 348);
            this.xtraTabPage5.Text = "EFatura Mukellefleri";
            // 
            // grEFaturaMembers
            // 
            this.grEFaturaMembers.DataSource = this.tbEFaturaMembers;
            this.grEFaturaMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grEFaturaMembers.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grEFaturaMembers.Location = new System.Drawing.Point(0, 50);
            this.grEFaturaMembers.MainView = this.grEFaturaMembersView;
            this.grEFaturaMembers.Margin = new System.Windows.Forms.Padding(2);
            this.grEFaturaMembers.Name = "grEFaturaMembers";
            this.grEFaturaMembers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.grEFaturaMembers.Size = new System.Drawing.Size(978, 237);
            this.grEFaturaMembers.TabIndex = 6;
            this.grEFaturaMembers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grEFaturaMembersView});
            // 
            // tbEFaturaMembers
            // 
            this.tbEFaturaMembers.Columns.AddRange(new System.Data.DataColumn[] {
            this.tbEFaturaMembers_EFaturaMemberID,
            this.tbEFaturaMembers_VKN,
            this.tbEFaturaMembers_FirmTitle,
            this.tbEFaturaMembers_PostboxAlias,
            this.tbEFaturaMembers_SenderboxAlias,
            this.tbEFaturaMembers_SystemCreateDate,
            this.tbEFaturaMembers_FirmCode,
            this.tbEFaturaMembers_bDefault});
            this.tbEFaturaMembers.Connection = this.FirmConn;
            this.tbEFaturaMembers.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "EFaturaMemberID"}, true)});
            this.tbEFaturaMembers.CurrentRow = null;
            this.tbEFaturaMembers.DataSourceLink = null;
            this.tbEFaturaMembers.DeleteCommand = this.sqlCommand20;
            this.tbEFaturaMembers.Filter = "";
            this.tbEFaturaMembers.InsertCommand = this.sqlCommand18;
            this.tbEFaturaMembers.LiveSave = false;
            this.tbEFaturaMembers.MaxRecords = ((long)(0));
            this.tbEFaturaMembers.Name = "tbEFaturaMembers";
            this.tbEFaturaMembers.ParentRelation_ChildColumns = null;
            this.tbEFaturaMembers.ParentRelation_ParentColumns = null;
            this.tbEFaturaMembers.ParentRelation_Table = null;
            this.tbEFaturaMembers.Position = ((long)(-1));
            this.tbEFaturaMembers.PrimaryKey = new System.Data.DataColumn[] {
        this.tbEFaturaMembers_EFaturaMemberID};
            this.tbEFaturaMembers.Quoted = false;
            this.tbEFaturaMembers.SelectCommand = this.sqlCommand17;
            this.tbEFaturaMembers.TableName = "neoTable1";
            this.tbEFaturaMembers.Transaction = null;
            this.tbEFaturaMembers.UpdateCommand = this.sqlCommand19;
            // 
            // tbEFaturaMembers_EFaturaMemberID
            // 
            this.tbEFaturaMembers_EFaturaMemberID.AllowDBNull = false;
            this.tbEFaturaMembers_EFaturaMemberID.AutoIncrement = true;
            this.tbEFaturaMembers_EFaturaMemberID.ColumnName = "EFaturaMemberID";
            this.tbEFaturaMembers_EFaturaMemberID.DataType = typeof(int);
            // 
            // tbEFaturaMembers_VKN
            // 
            this.tbEFaturaMembers_VKN.ColumnName = "VKN";
            // 
            // tbEFaturaMembers_FirmTitle
            // 
            this.tbEFaturaMembers_FirmTitle.ColumnName = "FirmTitle";
            // 
            // tbEFaturaMembers_PostboxAlias
            // 
            this.tbEFaturaMembers_PostboxAlias.ColumnName = "PostboxAlias";
            // 
            // tbEFaturaMembers_SenderboxAlias
            // 
            this.tbEFaturaMembers_SenderboxAlias.ColumnName = "SenderboxAlias";
            // 
            // tbEFaturaMembers_SystemCreateDate
            // 
            this.tbEFaturaMembers_SystemCreateDate.ColumnName = "SystemCreateDate";
            // 
            // tbEFaturaMembers_FirmCode
            // 
            this.tbEFaturaMembers_FirmCode.ColumnName = "FirmCode";
            // 
            // tbEFaturaMembers_bDefault
            // 
            this.tbEFaturaMembers_bDefault.ColumnName = "bDefault";
            this.tbEFaturaMembers_bDefault.DataType = typeof(int);
            // 
            // sqlCommand20
            // 
            this.sqlCommand20.CommandText = "DELETE FROM EFaturaMembers WHERE EFaturaMemberID = @EFaturaMemberID";
            // 
            // sqlCommand18
            // 
            this.sqlCommand18.CommandText = resources.GetString("sqlCommand18.CommandText");
            // 
            // sqlCommand17
            // 
            this.sqlCommand17.CommandText = "SELECT * FROM EFaturaMembers";
            // 
            // sqlCommand19
            // 
            this.sqlCommand19.CommandText = resources.GetString("sqlCommand19.CommandText");
            // 
            // grEFaturaMembersView
            // 
            this.grEFaturaMembersView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEFaturaMemberID,
            this.colVKN,
            this.colFirmTitle,
            this.colPostboxAlias,
            this.colSenderboxAlias,
            this.colSystemCreateDate,
            this.colFirmCode,
            this.colbDefault});
            this.grEFaturaMembersView.GridControl = this.grEFaturaMembers;
            this.grEFaturaMembersView.Name = "grEFaturaMembersView";
            this.grEFaturaMembersView.OptionsLayout.LayoutVersion = "1.2";
            this.grEFaturaMembersView.OptionsView.ColumnAutoWidth = false;
            this.grEFaturaMembersView.OptionsView.ShowAutoFilterRow = true;
            this.grEFaturaMembersView.OptionsView.ShowFooter = true;
            // 
            // colEFaturaMemberID
            // 
            this.colEFaturaMemberID.FieldName = "EFaturaMemberID";
            this.colEFaturaMemberID.Name = "colEFaturaMemberID";
            // 
            // colVKN
            // 
            this.colVKN.FieldName = "VKN";
            this.colVKN.Name = "colVKN";
            this.colVKN.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "VKN", "{0}")});
            this.colVKN.Visible = true;
            this.colVKN.VisibleIndex = 0;
            this.colVKN.Width = 107;
            // 
            // colFirmTitle
            // 
            this.colFirmTitle.FieldName = "FirmTitle";
            this.colFirmTitle.Name = "colFirmTitle";
            this.colFirmTitle.Visible = true;
            this.colFirmTitle.VisibleIndex = 1;
            this.colFirmTitle.Width = 205;
            // 
            // colPostboxAlias
            // 
            this.colPostboxAlias.FieldName = "PostboxAlias";
            this.colPostboxAlias.Name = "colPostboxAlias";
            this.colPostboxAlias.Visible = true;
            this.colPostboxAlias.VisibleIndex = 2;
            this.colPostboxAlias.Width = 115;
            // 
            // colSenderboxAlias
            // 
            this.colSenderboxAlias.FieldName = "SenderboxAlias";
            this.colSenderboxAlias.Name = "colSenderboxAlias";
            this.colSenderboxAlias.Visible = true;
            this.colSenderboxAlias.VisibleIndex = 3;
            this.colSenderboxAlias.Width = 116;
            // 
            // colSystemCreateDate
            // 
            this.colSystemCreateDate.FieldName = "SystemCreateDate";
            this.colSystemCreateDate.Name = "colSystemCreateDate";
            this.colSystemCreateDate.Visible = true;
            this.colSystemCreateDate.VisibleIndex = 4;
            this.colSystemCreateDate.Width = 144;
            // 
            // colFirmCode
            // 
            this.colFirmCode.FieldName = "FirmCode";
            this.colFirmCode.Name = "colFirmCode";
            this.colFirmCode.Visible = true;
            this.colFirmCode.VisibleIndex = 5;
            this.colFirmCode.Width = 130;
            // 
            // colbDefault
            // 
            this.colbDefault.Caption = "Varsayilan";
            this.colbDefault.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colbDefault.FieldName = "bDefault";
            this.colbDefault.Name = "colbDefault";
            this.colbDefault.Visible = true;
            this.colbDefault.VisibleIndex = 6;
            this.colbDefault.Width = 106;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnEFaturaMembers_Cancel);
            this.panel6.Controls.Add(this.btnEFaturaMembers_Save);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 287);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(978, 61);
            this.panel6.TabIndex = 8;
            // 
            // btnEFaturaMembers_Cancel
            // 
            this.btnEFaturaMembers_Cancel.Location = new System.Drawing.Point(140, 5);
            this.btnEFaturaMembers_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnEFaturaMembers_Cancel.Name = "btnEFaturaMembers_Cancel";
            this.btnEFaturaMembers_Cancel.Size = new System.Drawing.Size(102, 32);
            this.btnEFaturaMembers_Cancel.TabIndex = 7;
            this.btnEFaturaMembers_Cancel.Text = "Vazgec";
            this.btnEFaturaMembers_Cancel.Click += new System.EventHandler(this.btnEFaturaMembers_Cancel_Click);
            // 
            // btnEFaturaMembers_Save
            // 
            this.btnEFaturaMembers_Save.Location = new System.Drawing.Point(8, 5);
            this.btnEFaturaMembers_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btnEFaturaMembers_Save.Name = "btnEFaturaMembers_Save";
            this.btnEFaturaMembers_Save.Size = new System.Drawing.Size(102, 32);
            this.btnEFaturaMembers_Save.TabIndex = 6;
            this.btnEFaturaMembers_Save.Text = "Kaydet";
            this.btnEFaturaMembers_Save.Click += new System.EventHandler(this.btnEFaturaMembers_Save_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnDownloadEFaturaMukellef);
            this.panel5.Controls.Add(this.btnEFaturaMembers_ExportExcel);
            this.panel5.Controls.Add(this.btnListeleEFaturaMukellefleri);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(978, 50);
            this.panel5.TabIndex = 7;
            // 
            // btnEFaturaMembers_ExportExcel
            // 
            this.btnEFaturaMembers_ExportExcel.Location = new System.Drawing.Point(125, 13);
            this.btnEFaturaMembers_ExportExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnEFaturaMembers_ExportExcel.Name = "btnEFaturaMembers_ExportExcel";
            this.btnEFaturaMembers_ExportExcel.Size = new System.Drawing.Size(102, 32);
            this.btnEFaturaMembers_ExportExcel.TabIndex = 6;
            this.btnEFaturaMembers_ExportExcel.Text = "Excel Export";
            // 
            // xtraTabPage6
            // 
            this.xtraTabPage6.Controls.Add(this.btnItems);
            this.xtraTabPage6.Name = "xtraTabPage6";
            this.xtraTabPage6.Size = new System.Drawing.Size(978, 348);
            this.xtraTabPage6.Text = "Diger Islemler";
            // 
            // btnItems
            // 
            this.btnItems.Location = new System.Drawing.Point(10, 13);
            this.btnItems.Margin = new System.Windows.Forms.Padding(2);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(153, 38);
            this.btnItems.TabIndex = 10;
            this.btnItems.Text = "Items ve GTIPNO Listesi";
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.xtraTabControl1);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.panelBottom);
            this.panel2.Controls.Add(this.statusStrip1);
            this.panel2.Controls.Add(this.panelTop);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 544);
            this.panel2.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.Location = new System.Drawing.Point(0, 480);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(984, 19);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "---";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.progressBar1);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 499);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(2);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(984, 23);
            this.panelBottom.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 4);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(984, 19);
            this.progressBar1.TabIndex = 11;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblStatus_Server,
            this.toolStripStatusLabel2,
            this.lblStatus_Database,
            this.toolStripStatusLabel3,
            this.lblStatus_ProgramVersion});
            this.statusStrip1.Location = new System.Drawing.Point(0, 522);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Server";
            // 
            // lblStatus_Server
            // 
            this.lblStatus_Server.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus_Server.Name = "lblStatus_Server";
            this.lblStatus_Server.Size = new System.Drawing.Size(24, 17);
            this.lblStatus_Server.Text = "srv";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabel2.Text = "Database";
            // 
            // lblStatus_Database
            // 
            this.lblStatus_Database.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus_Database.Name = "lblStatus_Database";
            this.lblStatus_Database.Size = new System.Drawing.Size(21, 17);
            this.lblStatus_Database.Text = "db";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(94, 17);
            this.toolStripStatusLabel3.Text = "Program version";
            // 
            // lblStatus_ProgramVersion
            // 
            this.lblStatus_ProgramVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus_ProgramVersion.Name = "lblStatus_ProgramVersion";
            this.lblStatus_ProgramVersion.Size = new System.Drawing.Size(34, 17);
            this.lblStatus_ProgramVersion.Text = "1.1.1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doyaToolStripMenuItem,
            this.yardimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // doyaToolStripMenuItem
            // 
            this.doyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.doyaToolStripMenuItem.Name = "doyaToolStripMenuItem";
            this.doyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.doyaToolStripMenuItem.Text = "Dosya";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // yardimToolStripMenuItem
            // 
            this.yardimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programHakkindaToolStripMenuItem});
            this.yardimToolStripMenuItem.Name = "yardimToolStripMenuItem";
            this.yardimToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardimToolStripMenuItem.Text = "Yardim";
            // 
            // programHakkindaToolStripMenuItem
            // 
            this.programHakkindaToolStripMenuItem.Name = "programHakkindaToolStripMenuItem";
            this.programHakkindaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.programHakkindaToolStripMenuItem.Text = "Program hakkinda";
            this.programHakkindaToolStripMenuItem.Click += new System.EventHandler(this.programHakkindaToolStripMenuItem_Click);
            // 
            // conMenuExport
            // 
            this.conMenuExport.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.conMenuExport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conMenuExport_XLSX,
            this.conMenuExport_XLS,
            this.conMenuExport_PDF,
            this.conMenuExport_TXT,
            this.conMenuExport_CSV,
            this.conMenuExport_HTML});
            this.conMenuExport.Name = "conMenuExport";
            this.conMenuExport.Size = new System.Drawing.Size(126, 136);
            // 
            // conMenuExport_XLSX
            // 
            this.conMenuExport_XLSX.Name = "conMenuExport_XLSX";
            this.conMenuExport_XLSX.Size = new System.Drawing.Size(125, 22);
            this.conMenuExport_XLSX.Text = "Excel Xslx";
            this.conMenuExport_XLSX.Click += new System.EventHandler(this.conMenuExport_XLSX_Click);
            // 
            // conMenuExport_XLS
            // 
            this.conMenuExport_XLS.Name = "conMenuExport_XLS";
            this.conMenuExport_XLS.Size = new System.Drawing.Size(125, 22);
            this.conMenuExport_XLS.Text = "Excel";
            // 
            // conMenuExport_PDF
            // 
            this.conMenuExport_PDF.Name = "conMenuExport_PDF";
            this.conMenuExport_PDF.Size = new System.Drawing.Size(125, 22);
            this.conMenuExport_PDF.Text = "Pdf";
            // 
            // conMenuExport_TXT
            // 
            this.conMenuExport_TXT.Name = "conMenuExport_TXT";
            this.conMenuExport_TXT.Size = new System.Drawing.Size(125, 22);
            this.conMenuExport_TXT.Text = "Txt";
            // 
            // conMenuExport_CSV
            // 
            this.conMenuExport_CSV.Name = "conMenuExport_CSV";
            this.conMenuExport_CSV.Size = new System.Drawing.Size(125, 22);
            this.conMenuExport_CSV.Text = "Csv";
            // 
            // conMenuExport_HTML
            // 
            this.conMenuExport_HTML.Name = "conMenuExport_HTML";
            this.conMenuExport_HTML.Size = new System.Drawing.Size(125, 22);
            this.conMenuExport_HTML.Text = "Html";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 544);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MrTEK E-Fatura Adaptor Programi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.panelTop.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grGelenKutusu)).EndInit();
            this.conMenuGelen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoice_GelenKutusu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grGelenKutusuView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grGidenKutusu)).EndInit();
            this.conMenuGiden.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoice_GidenKutusu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grGidenKutusuView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grGonderilmisler)).EndInit();
            this.conMenuGonderilmis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoice_Gonderilmisler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grGonderilmislerView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelWait)).EndInit();
            this.panelWait.ResumeLayout(false);
            this.panelWait.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebug.Properties)).EndInit();
            this.xtraTabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grEFaturaMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEFaturaMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grEFaturaMembersView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.xtraTabPage6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.conMenuExport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NeoDAC.NeoConnection FirmConn;
        private System.Data.SqlClient.SqlCommand sqlCommand4;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private System.Windows.Forms.Panel panelTop;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl grGelenKutusu;
        private DevExpress.XtraGrid.Views.Grid.GridView grGelenKutusuView;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.Panel panel2;
        private userCntDateFilter userCntDateFilter1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraEditors.SimpleButton btnDownloadEFaturaMukellef;
        private NeoDAC.NeoTable tbInvoice_GelenKutusu;
        private System.Data.SqlClient.SqlCommand sqlCommand8;
        private System.Data.SqlClient.SqlCommand sqlCommand6;
        private System.Data.SqlClient.SqlCommand sqlCommand5;
        private System.Data.SqlClient.SqlCommand sqlCommand7;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceID;
        private DevExpress.XtraGrid.Columns.GridColumn colIOType;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colModifiedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colLocalStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colPostBox;
        private DevExpress.XtraGrid.Columns.GridColumn colProfileID;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colIssueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIssueTime;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceTypeCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumentCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPricingCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentAlternativeCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colLineCountNumeric;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoicePeriod_StartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoicePeriod_EndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoicePeriod_DurationMeasure;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoicePeriod_Description;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_PartyIdentification1_schemeID;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_PartyIdentification1_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_PartyIdentification2_schemeID;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_PartyIdentification2_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_PartyIdentification3_schemeID;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_PartyIdentification3_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_PartyIdentification4_schemeID;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_PartyIdentification4_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_PartyIdentification5_schemeID;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_PartyIdentification5_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_PartyName;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_PostalAddress_StreetName;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_PostalAddress_Room;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_PostalAddress_BuildingNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_PostalAddress_CitySubdivisionName;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_PostalAddress_CityName;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_PostalAddress_Country;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_PartyTaxScheme;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_Contact_Telephone;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_Contact_Telefax;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_Contact_ElectronicMail;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_Person_FirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_Person_FamilyName;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_AgentParty_PartyIdentification1_schemeID;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_AgentParty_PartyIdentification1_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_AgentParty_PartyIdentification2_schemeID;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_AgentParty_PartyIdentification2_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_AgentParty_PartyIdentification3_schemeID;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_AgentParty_PartyIdentification3_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_AgentParty_PartyIdentification4_schemeID;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_AgentParty_PartyIdentification4_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_AgentParty_PartyIdentification5_schemeID;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_AgentParty_PartyIdentification5_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_AgentParty_PartyName;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_AgentParty_PostalAddress_StreetName;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_AgentParty_PostalAddress_Room;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_AgentParty_PostalAddress_BuildingNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_AgentParty_PostalAddress_CitySubdivisionName;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_AgentParty_PostalAddress_CityName;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_AgentParty_PostalAddress_Country;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_AgentParty_PartyTaxScheme;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_AgentParty_Contact_Telephone;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_AgentParty_Contact_Telefax;
        private DevExpress.XtraGrid.Columns.GridColumn colASP_AgentParty_Contact_ElectronicMail;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_PartyIdentification1_schemeID;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_PartyIdentification1_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_PartyIdentification2_schemeID;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_PartyIdentification2_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_PartyIdentification3_schemeID;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_PartyIdentification3_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_PartyIdentification4_schemeID;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_PartyIdentification4_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_PartyIdentification5_schemeID;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_PartyIdentification5_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_PartyName;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_PostalAddress_StreetName;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_PostalAddress_Room;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_PostalAddress_BuildingNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_PostalAddress_CitySubdivisionName;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_PostalAddress_CityName;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_PostalAddress_Country;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_PartyTaxScheme;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_Contact_Telephone;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_Contact_Telefax;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_Contact_ElectronicMail;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_Person_FirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_Person_FamilyName;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_AgentParty_PartyIdentification1_schemeID;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_AgentParty_PartyIdentification1_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_AgentParty_PartyIdentification2_schemeID;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_AgentParty_PartyIdentification2_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_AgentParty_PartyIdentification3_schemeID;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_AgentParty_PartyIdentification3_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_AgentParty_PartyIdentification4_schemeID;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_AgentParty_PartyIdentification4_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_AgentParty_PartyIdentification5_schemeID;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_AgentParty_PartyIdentification5_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_AgentParty_PartyName;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_AgentParty_PostalAddress_StreetName;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_AgentParty_PostalAddress_Room;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_AgentParty_PostalAddress_BuildingNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_AgentParty_PostalAddress_CitySubdivisionName;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_AgentParty_PostalAddress_CityName;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_AgentParty_PostalAddress_Country;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_AgentParty_PartyTaxScheme;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_AgentParty_Contact_Telephone;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_AgentParty_Contact_Telefax;
        private DevExpress.XtraGrid.Columns.GridColumn colACP_AgentParty_Contact_ElectronicMail;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxExchangeRate_SourceCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxExchangeRate_TargetCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxExchangeRate_CalculationRate;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxExchangeRate_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colPricingExchangeRate_SourceCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPricingExchangeRate_TargetCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPricingExchangeRate_CalculationRate;
        private DevExpress.XtraGrid.Columns.GridColumn colPricingExchangeRate_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentExchangeRate_SourceCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentExchangeRate_TargetCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentExchangeRate_CalculationRate;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentExchangeRate_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentAlternativeExchangeRate_SourceCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentAlternativeExchangeRate_TargetCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentAlternativeExchangeRate_CalculationRate;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentAlternativeExchangeRate_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colLegalMonetaryTotal_LineExtensionAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colLegalMonetaryTotal_TaxExclusiveAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colLegalMonetaryTotal_TaxInclusiveAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colLegalMonetaryTotal_AllowanceTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colLegalMonetaryTotal_PayableRoundingAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colLegalMonetaryTotal_PayableAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colIntegratorID;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraEditors.MemoEdit txtDebug;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.PanelControl panelWait;
        private DevExpress.XtraEditors.LabelControl lblWait;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnDownloadIncomingInvoice;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.ProgressBar progressBar1;
        private DevExpress.XtraGrid.GridControl grGidenKutusu;
        private DevExpress.XtraGrid.Views.Grid.GridView grGidenKutusuView;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnSyncOutgoingInvoice;
        private DevExpress.XtraGrid.GridControl grGonderilmisler;
        private DevExpress.XtraGrid.Views.Grid.GridView grGonderilmislerView;
        private System.Windows.Forms.Panel panel4;
        private NeoDAC.NeoTable tbInvoice_GidenKutusu;
        private System.Data.SqlClient.SqlCommand sqlCommand12;
        private System.Data.SqlClient.SqlCommand sqlCommand10;
        private System.Data.SqlClient.SqlCommand sqlCommand9;
        private System.Data.SqlClient.SqlCommand sqlCommand11;
        private NeoDAC.NeoTable tbInvoice_Gonderilmisler;
        private System.Data.SqlClient.SqlCommand sqlCommand16;
        private System.Data.SqlClient.SqlCommand sqlCommand14;
        private System.Data.SqlClient.SqlCommand sqlCommand13;
        private System.Data.SqlClient.SqlCommand sqlCommand15;
        private System.Windows.Forms.ContextMenuStrip conMenuGiden;
        private System.Windows.Forms.ToolStripMenuItem faturayiAcToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gonderToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colUUID;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private DevExpress.XtraGrid.GridControl grEFaturaMembers;
        private DevExpress.XtraGrid.Views.Grid.GridView grEFaturaMembersView;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.SimpleButton btnListeleEFaturaMukellefleri;
        private NeoDAC.NeoTable tbEFaturaMembers;
        private System.Data.SqlClient.SqlCommand sqlCommand20;
        private System.Data.SqlClient.SqlCommand sqlCommand18;
        private System.Data.SqlClient.SqlCommand sqlCommand17;
        private System.Data.SqlClient.SqlCommand sqlCommand19;
        private DevExpress.XtraGrid.Columns.GridColumn colEFaturaMemberID;
        private DevExpress.XtraGrid.Columns.GridColumn colVKN;
        private DevExpress.XtraGrid.Columns.GridColumn colFirmTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colPostboxAlias;
        private DevExpress.XtraGrid.Columns.GridColumn colSenderboxAlias;
        private DevExpress.XtraGrid.Columns.GridColumn colSystemCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colFirmCode;
        private DevExpress.XtraEditors.SimpleButton btnEFaturaMembers_Save;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraEditors.SimpleButton btnEFaturaMembers_Cancel;
        private DevExpress.XtraEditors.SimpleButton btnEFaturaMembers_ExportExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Data.DataColumn tbEFaturaMembers_EFaturaMemberID;
        private System.Data.DataColumn tbEFaturaMembers_VKN;
        private System.Data.DataColumn tbEFaturaMembers_FirmTitle;
        private System.Data.DataColumn tbEFaturaMembers_PostboxAlias;
        private System.Data.DataColumn tbEFaturaMembers_SenderboxAlias;
        private System.Data.DataColumn tbEFaturaMembers_SystemCreateDate;
        private System.Data.DataColumn tbEFaturaMembers_FirmCode;
        private System.Data.DataColumn tbEFaturaMembers_bDefault;
        private DevExpress.XtraGrid.Columns.GridColumn colbDefault;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.SimpleButton btnGidecekFaturalariGonder;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Label lblStatus;
        public DevExpress.XtraBars.PopupMenu popupMenu1;
        private System.Windows.Forms.SaveFileDialog ExportDialog;
        private System.Windows.Forms.ContextMenuStrip conMenuGelen;
        private System.Windows.Forms.ToolStripMenuItem onaylaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem reddetToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colIntCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn25;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn26;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn27;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn28;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn29;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn30;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn31;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn32;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn33;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn34;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn35;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn36;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn37;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn38;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn39;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn40;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn41;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn42;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn43;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn44;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn45;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn46;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn47;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn48;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn49;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn50;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn51;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn52;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn53;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn54;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn55;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn56;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn57;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn58;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn59;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn60;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn61;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn62;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn63;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn64;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn65;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn66;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn67;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn68;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn69;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn70;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn71;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn72;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn73;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn74;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn75;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn76;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn77;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn78;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn79;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn80;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn81;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn82;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn83;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn84;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn85;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn86;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn87;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn88;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn89;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn90;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn91;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn92;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn93;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn94;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn95;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn96;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn97;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn98;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn99;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn100;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn101;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn102;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn103;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn104;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn105;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn106;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn107;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn108;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn109;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn110;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn111;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn112;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn113;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn114;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn115;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn116;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn117;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn118;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn119;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn120;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn121;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn122;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn123;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn124;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn125;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn126;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn127;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn128;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn129;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn130;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn131;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn132;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn133;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn134;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn135;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn136;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn137;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn275;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn276;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn138;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn139;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn140;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn141;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn142;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn143;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn144;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn145;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn146;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn147;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn148;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn149;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn150;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn151;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn152;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn153;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn154;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn155;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn156;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn157;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn158;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn159;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn160;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn161;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn162;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn163;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn164;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn165;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn166;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn167;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn168;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn169;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn170;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn171;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn172;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn173;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn174;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn175;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn176;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn177;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn178;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn179;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn180;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn181;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn182;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn183;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn184;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn185;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn186;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn187;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn188;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn189;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn190;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn191;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn192;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn193;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn194;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn195;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn196;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn197;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn198;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn199;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn200;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn201;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn202;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn203;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn204;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn205;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn206;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn207;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn208;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn209;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn210;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn211;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn212;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn213;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn214;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn215;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn216;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn217;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn218;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn219;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn220;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn221;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn222;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn223;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn224;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn225;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn226;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn227;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn228;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn229;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn230;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn231;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn232;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn233;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn234;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn235;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn236;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn237;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn238;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn239;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn240;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn241;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn242;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn243;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn244;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn245;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn246;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn247;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn248;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn249;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn250;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn251;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn252;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn253;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn254;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn255;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn256;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn257;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn258;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn259;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn260;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn261;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn262;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn263;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn264;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn265;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn266;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn267;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn268;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn269;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn270;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn271;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn272;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn273;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn274;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn277;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn278;
        internal System.Windows.Forms.ContextMenuStrip conMenuExport;
        internal System.Windows.Forms.ToolStripMenuItem conMenuExport_XLSX;
        internal System.Windows.Forms.ToolStripMenuItem conMenuExport_XLS;
        internal System.Windows.Forms.ToolStripMenuItem conMenuExport_PDF;
        internal System.Windows.Forms.ToolStripMenuItem conMenuExport_TXT;
        internal System.Windows.Forms.ToolStripMenuItem conMenuExport_CSV;
        internal System.Windows.Forms.ToolStripMenuItem conMenuExport_HTML;
        internal System.Windows.Forms.Panel panel7;
        internal DevExpress.XtraEditors.SimpleButton cmdPrintXSLTSingle;
        internal DevExpress.XtraEditors.SimpleButton cmdPrintXSLTMulti;
        internal DevExpress.XtraEditors.SimpleButton cmdGeneralPrint;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus_Server;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus_Database;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus_ProgramVersion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programHakkindaToolStripMenuItem;
        private System.Data.DataColumn tbInvoice_GelenKutusu_InvoiceID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_Deleted;
        private System.Data.DataColumn tbInvoice_GelenKutusu_CreatedBy;
        private System.Data.DataColumn tbInvoice_GelenKutusu_CreatedDate;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ModifiedBy;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ModifiedDate;
        private System.Data.DataColumn tbInvoice_GelenKutusu_IOType;
        private System.Data.DataColumn tbInvoice_GelenKutusu_IntCode;
        private System.Data.DataColumn tbInvoice_GelenKutusu_LocalStatus;
        private System.Data.DataColumn tbInvoice_GelenKutusu_IntegratorID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_Status;
        private System.Data.DataColumn tbInvoice_GelenKutusu_StatusDescription;
        private System.Data.DataColumn tbInvoice_GelenKutusu_PostBox;
        private System.Data.DataColumn tbInvoice_GelenKutusu_XsltNo;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ProfileID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_UUID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_IssueDate;
        private System.Data.DataColumn tbInvoice_GelenKutusu_IssueTime;
        private System.Data.DataColumn tbInvoice_GelenKutusu_InvoiceTypeCode;
        private System.Data.DataColumn tbInvoice_GelenKutusu_DocumentCurrencyCode;
        private System.Data.DataColumn tbInvoice_GelenKutusu_TaxCurrencyCode;
        private System.Data.DataColumn tbInvoice_GelenKutusu_PricingCurrencyCode;
        private System.Data.DataColumn tbInvoice_GelenKutusu_PaymentCurrencyCode;
        private System.Data.DataColumn tbInvoice_GelenKutusu_PaymentAlternativeCurrencyCode;
        private System.Data.DataColumn tbInvoice_GelenKutusu_LineCountNumeric;
        private System.Data.DataColumn tbInvoice_GelenKutusu_InvoicePeriod_StartDate;
        private System.Data.DataColumn tbInvoice_GelenKutusu_InvoicePeriod_EndDate;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_PartyIdentification1_schemeID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_PartyIdentification1_ID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_PartyIdentification2_schemeID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_PartyIdentification2_ID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_PartyIdentification3_schemeID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_PartyIdentification3_ID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_PartyIdentification4_schemeID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_PartyIdentification4_ID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_PartyIdentification5_schemeID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_PartyIdentification5_ID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_PartyName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_PostalAddress_StreetName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_PostalAddress_Room;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_PostalAddress_BuildingNumber;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_PostalAddress_BuildingName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_PostalAddress_CitySubdivisionName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_PostalAddress_CityName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_PostalAddress_Country;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_PartyTaxSchemeName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_PartyTaxSchemeTaxTypeCode;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_WebsiteURI;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_Contact_Telephone;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_Contact_Telefax;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_Contact_ElectronicMail;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_Person_FirstName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_Person_FamilyName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_Person_MiddleName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_Person_NameSuffix;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_Person_Title;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification1_schemeID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification1_ID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification2_schemeID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification2_ID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification3_schemeID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification3_ID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification4_schemeID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification4_ID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification5_schemeID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_AgentParty_PartyIdentification5_ID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_AgentParty_PartyName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_StreetName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_Room;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_BuildingNumber;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_BuildingName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_CitySubdivisionName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_CityName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_AgentParty_PostalAddress_Country;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_AgentParty_PartyTaxSchemeName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_AgentParty_PartyTaxSchemeTaxTypeCode;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_AgentParty_WebsiteURI;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_AgentParty_Contact_Telephone;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_AgentParty_Contact_Telefax;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_AgentParty_Contact_ElectronicMail;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_AgentParty_Person_FirstName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_AgentParty_Person_FamilyName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_AgentParty_Person_MiddleName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_AgentParty_Person_NameSuffix;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ASP_AgentParty_Person_Title;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_PartyIdentification1_schemeID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_PartyIdentification1_ID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_PartyIdentification2_schemeID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_PartyIdentification2_ID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_PartyIdentification3_schemeID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_PartyIdentification3_ID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_PartyIdentification4_schemeID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_PartyIdentification4_ID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_PartyIdentification5_schemeID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_PartyIdentification5_ID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_PartyName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_PostalAddress_StreetName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_PostalAddress_Room;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_PostalAddress_BuildingNumber;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_PostalAddress_BuildingName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_PostalAddress_CitySubdivisionName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_PostalAddress_CityName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_PostalAddress_Country;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_PartyTaxSchemeName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_PartyTaxSchemeTaxTypeCode;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_WebsiteURI;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_Contact_Telephone;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_Contact_Telefax;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_Contact_ElectronicMail;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_Person_FirstName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_Person_FamilyName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_Person_MiddleName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_Person_NameSuffix;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_Person_Title;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification1_schemeID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification1_ID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification2_schemeID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification2_ID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification3_schemeID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification3_ID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification4_schemeID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification4_ID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification5_schemeID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_AgentParty_PartyIdentification5_ID;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_AgentParty_PartyName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_StreetName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_Room;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_BuildingNumber;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_BuildingName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_CitySubdivisionName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_CityName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_AgentParty_PostalAddress_Country;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_AgentParty_PartyTaxSchemeName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_AgentParty_PartyTaxSchemeTaxTypeCode;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_AgentParty_WebsiteURI;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_AgentParty_Contact_Telephone;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_AgentParty_Contact_Telefax;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_AgentParty_Contact_ElectronicMail;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_AgentParty_Person_FirstName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_AgentParty_Person_FamilyName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_AgentParty_Person_MiddleName;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_AgentParty_Person_NameSuffix;
        private System.Data.DataColumn tbInvoice_GelenKutusu_ACP_AgentParty_Person_Title;
        private System.Data.DataColumn tbInvoice_GelenKutusu_TaxExchangeRate_SourceCurrencyCode;
        private System.Data.DataColumn tbInvoice_GelenKutusu_TaxExchangeRate_TargetCurrencyCode;
        private System.Data.DataColumn tbInvoice_GelenKutusu_TaxExchangeRate_CalculationRate;
        private System.Data.DataColumn tbInvoice_GelenKutusu_TaxExchangeRate_Date;
        private System.Data.DataColumn tbInvoice_GelenKutusu_PricingExchangeRate_SourceCurrencyCode;
        private System.Data.DataColumn tbInvoice_GelenKutusu_PricingExchangeRate_TargetCurrencyCode;
        private System.Data.DataColumn tbInvoice_GelenKutusu_PricingExchangeRate_CalculationRate;
        private System.Data.DataColumn tbInvoice_GelenKutusu_PricingExchangeRate_Date;
        private System.Data.DataColumn tbInvoice_GelenKutusu_PaymentExchangeRate_SourceCurrencyCode;
        private System.Data.DataColumn tbInvoice_GelenKutusu_PaymentExchangeRate_TargetCurrencyCode;
        private System.Data.DataColumn tbInvoice_GelenKutusu_PaymentExchangeRate_CalculationRate;
        private System.Data.DataColumn tbInvoice_GelenKutusu_PaymentExchangeRate_Date;
        private System.Data.DataColumn tbInvoice_GelenKutusu_PaymentAlternativeExchangeRate_SourceCurrencyCode;
        private System.Data.DataColumn tbInvoice_GelenKutusu_PaymentAlternativeExchangeRate_TargetCurrencyCode;
        private System.Data.DataColumn tbInvoice_GelenKutusu_PaymentAlternativeExchangeRate_CalculationRate;
        private System.Data.DataColumn tbInvoice_GelenKutusu_PaymentAlternativeExchangeRate_Date;
        private System.Data.DataColumn tbInvoice_GelenKutusu_TaxAmount;
        private System.Data.DataColumn tbInvoice_GelenKutusu_LegalMonetaryTotal_LineExtensionAmount;
        private System.Data.DataColumn tbInvoice_GelenKutusu_LegalMonetaryTotal_TaxExclusiveAmount;
        private System.Data.DataColumn tbInvoice_GelenKutusu_LegalMonetaryTotal_TaxInclusiveAmount;
        private System.Data.DataColumn tbInvoice_GelenKutusu_LegalMonetaryTotal_AllowanceTotalAmount;
        private System.Data.DataColumn tbInvoice_GelenKutusu_LegalMonetaryTotal_ChargeTotalAmount;
        private System.Data.DataColumn tbInvoice_GelenKutusu_LegalMonetaryTotal_PayableRoundingAmount;
        private System.Data.DataColumn tbInvoice_GelenKutusu_LegalMonetaryTotal_PayableAmount;
        private System.Data.DataColumn tbInvoice_GelenKutusu_WithholdingTaxAmount;
        private System.Data.DataColumn tbInvoice_GidenKutusu_InvoiceID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_Deleted;
        private System.Data.DataColumn tbInvoice_GidenKutusu_CreatedBy;
        private System.Data.DataColumn tbInvoice_GidenKutusu_CreatedDate;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ModifiedBy;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ModifiedDate;
        private System.Data.DataColumn tbInvoice_GidenKutusu_IOType;
        private System.Data.DataColumn tbInvoice_GidenKutusu_IntCode;
        private System.Data.DataColumn tbInvoice_GidenKutusu_LocalStatus;
        private System.Data.DataColumn tbInvoice_GidenKutusu_IntegratorID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_Status;
        private System.Data.DataColumn tbInvoice_GidenKutusu_StatusDescription;
        private System.Data.DataColumn tbInvoice_GidenKutusu_PostBox;
        private System.Data.DataColumn tbInvoice_GidenKutusu_XsltNo;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ProfileID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_UUID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_IssueDate;
        private System.Data.DataColumn tbInvoice_GidenKutusu_IssueTime;
        private System.Data.DataColumn tbInvoice_GidenKutusu_InvoiceTypeCode;
        private System.Data.DataColumn tbInvoice_GidenKutusu_DocumentCurrencyCode;
        private System.Data.DataColumn tbInvoice_GidenKutusu_TaxCurrencyCode;
        private System.Data.DataColumn tbInvoice_GidenKutusu_PricingCurrencyCode;
        private System.Data.DataColumn tbInvoice_GidenKutusu_PaymentCurrencyCode;
        private System.Data.DataColumn tbInvoice_GidenKutusu_PaymentAlternativeCurrencyCode;
        private System.Data.DataColumn tbInvoice_GidenKutusu_LineCountNumeric;
        private System.Data.DataColumn tbInvoice_GidenKutusu_InvoicePeriod_StartDate;
        private System.Data.DataColumn tbInvoice_GidenKutusu_InvoicePeriod_EndDate;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_PartyIdentification1_schemeID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_PartyIdentification1_ID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_PartyIdentification2_schemeID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_PartyIdentification2_ID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_PartyIdentification3_schemeID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_PartyIdentification3_ID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_PartyIdentification4_schemeID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_PartyIdentification4_ID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_PartyIdentification5_schemeID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_PartyIdentification5_ID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_PartyName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_PostalAddress_StreetName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_PostalAddress_Room;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_PostalAddress_BuildingNumber;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_PostalAddress_BuildingName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_PostalAddress_CitySubdivisionName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_PostalAddress_CityName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_PostalAddress_Country;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_PartyTaxSchemeName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_PartyTaxSchemeTaxTypeCode;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_WebsiteURI;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_Contact_Telephone;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_Contact_Telefax;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_Contact_ElectronicMail;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_Person_FirstName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_Person_FamilyName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_Person_MiddleName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_Person_NameSuffix;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_Person_Title;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification1_schemeID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification1_ID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification2_schemeID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification2_ID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification3_schemeID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification3_ID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification4_schemeID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification4_ID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification5_schemeID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_AgentParty_PartyIdentification5_ID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_AgentParty_PartyName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_StreetName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_Room;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_BuildingNumber;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_BuildingName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_CitySubdivisionName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_CityName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_AgentParty_PostalAddress_Country;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_AgentParty_PartyTaxSchemeName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_AgentParty_PartyTaxSchemeTaxTypeCode;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_AgentParty_WebsiteURI;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_AgentParty_Contact_Telephone;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_AgentParty_Contact_Telefax;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_AgentParty_Contact_ElectronicMail;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_AgentParty_Person_FirstName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_AgentParty_Person_FamilyName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_AgentParty_Person_MiddleName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_AgentParty_Person_NameSuffix;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ASP_AgentParty_Person_Title;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_PartyIdentification1_schemeID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_PartyIdentification1_ID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_PartyIdentification2_schemeID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_PartyIdentification2_ID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_PartyIdentification3_schemeID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_PartyIdentification3_ID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_PartyIdentification4_schemeID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_PartyIdentification4_ID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_PartyIdentification5_schemeID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_PartyIdentification5_ID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_PartyName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_PostalAddress_StreetName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_PostalAddress_Room;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_PostalAddress_BuildingNumber;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_PostalAddress_BuildingName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_PostalAddress_CitySubdivisionName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_PostalAddress_CityName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_PostalAddress_Country;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_PartyTaxSchemeName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_PartyTaxSchemeTaxTypeCode;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_WebsiteURI;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_Contact_Telephone;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_Contact_Telefax;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_Contact_ElectronicMail;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_Person_FirstName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_Person_FamilyName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_Person_MiddleName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_Person_NameSuffix;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_Person_Title;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification1_schemeID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification1_ID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification2_schemeID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification2_ID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification3_schemeID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification3_ID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification4_schemeID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification4_ID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification5_schemeID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_AgentParty_PartyIdentification5_ID;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_AgentParty_PartyName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_StreetName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_Room;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_BuildingNumber;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_BuildingName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_CitySubdivisionName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_CityName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_AgentParty_PostalAddress_Country;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_AgentParty_PartyTaxSchemeName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_AgentParty_PartyTaxSchemeTaxTypeCode;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_AgentParty_WebsiteURI;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_AgentParty_Contact_Telephone;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_AgentParty_Contact_Telefax;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_AgentParty_Contact_ElectronicMail;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_AgentParty_Person_FirstName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_AgentParty_Person_FamilyName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_AgentParty_Person_MiddleName;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_AgentParty_Person_NameSuffix;
        private System.Data.DataColumn tbInvoice_GidenKutusu_ACP_AgentParty_Person_Title;
        private System.Data.DataColumn tbInvoice_GidenKutusu_TaxExchangeRate_SourceCurrencyCode;
        private System.Data.DataColumn tbInvoice_GidenKutusu_TaxExchangeRate_TargetCurrencyCode;
        private System.Data.DataColumn tbInvoice_GidenKutusu_TaxExchangeRate_CalculationRate;
        private System.Data.DataColumn tbInvoice_GidenKutusu_TaxExchangeRate_Date;
        private System.Data.DataColumn tbInvoice_GidenKutusu_PricingExchangeRate_SourceCurrencyCode;
        private System.Data.DataColumn tbInvoice_GidenKutusu_PricingExchangeRate_TargetCurrencyCode;
        private System.Data.DataColumn tbInvoice_GidenKutusu_PricingExchangeRate_CalculationRate;
        private System.Data.DataColumn tbInvoice_GidenKutusu_PricingExchangeRate_Date;
        private System.Data.DataColumn tbInvoice_GidenKutusu_PaymentExchangeRate_SourceCurrencyCode;
        private System.Data.DataColumn tbInvoice_GidenKutusu_PaymentExchangeRate_TargetCurrencyCode;
        private System.Data.DataColumn tbInvoice_GidenKutusu_PaymentExchangeRate_CalculationRate;
        private System.Data.DataColumn tbInvoice_GidenKutusu_PaymentExchangeRate_Date;
        private System.Data.DataColumn tbInvoice_GidenKutusu_PaymentAlternativeExchangeRate_SourceCurrencyCode;
        private System.Data.DataColumn tbInvoice_GidenKutusu_PaymentAlternativeExchangeRate_TargetCurrencyCode;
        private System.Data.DataColumn tbInvoice_GidenKutusu_PaymentAlternativeExchangeRate_CalculationRate;
        private System.Data.DataColumn tbInvoice_GidenKutusu_PaymentAlternativeExchangeRate_Date;
        private System.Data.DataColumn tbInvoice_GidenKutusu_TaxAmount;
        private System.Data.DataColumn tbInvoice_GidenKutusu_LegalMonetaryTotal_LineExtensionAmount;
        private System.Data.DataColumn tbInvoice_GidenKutusu_LegalMonetaryTotal_TaxExclusiveAmount;
        private System.Data.DataColumn tbInvoice_GidenKutusu_LegalMonetaryTotal_TaxInclusiveAmount;
        private System.Data.DataColumn tbInvoice_GidenKutusu_LegalMonetaryTotal_AllowanceTotalAmount;
        private System.Data.DataColumn tbInvoice_GidenKutusu_LegalMonetaryTotal_ChargeTotalAmount;
        private System.Data.DataColumn tbInvoice_GidenKutusu_LegalMonetaryTotal_PayableRoundingAmount;
        private System.Data.DataColumn tbInvoice_GidenKutusu_LegalMonetaryTotal_PayableAmount;
        private System.Data.DataColumn tbInvoice_GidenKutusu_WithholdingTaxAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colLegalMonetaryTotal_ChargeTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colLegalMonetaryTotal_ChargeTotalAmount1;
        private DevExpress.XtraEditors.SimpleButton btnUpdateStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colLegalMonetaryTotal_ChargeTotalAmount2;
        private System.Windows.Forms.ContextMenuStrip conMenuGonderilmis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuGonderilmis_Gerial;
        private System.Windows.Forms.ToolStripMenuItem mnuGonderilmisSil;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem gonderilmisGibiİsaretleToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton btnRefreshAll;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem logGoruntuleToolStripMenuItem;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_InvoiceID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_Deleted;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_CreatedBy;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_CreatedDate;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ModifiedBy;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ModifiedDate;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_IOType;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_IntCode;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_LocalStatus;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_IntegratorID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_Status;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_StatusDescription;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_PostBox;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_XsltNo;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ProfileID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_UUID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_IssueDate;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_IssueTime;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_InvoiceTypeCode;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_DocumentCurrencyCode;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_TaxCurrencyCode;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_PricingCurrencyCode;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_PaymentCurrencyCode;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_PaymentAlternativeCurrencyCode;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_LineCountNumeric;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_InvoicePeriod_StartDate;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_InvoicePeriod_EndDate;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_PartyIdentification1_schemeID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_PartyIdentification1_ID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_PartyIdentification2_schemeID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_PartyIdentification2_ID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_PartyIdentification3_schemeID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_PartyIdentification3_ID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_PartyIdentification4_schemeID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_PartyIdentification4_ID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_PartyIdentification5_schemeID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_PartyIdentification5_ID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_PartyName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_PostalAddress_StreetName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_PostalAddress_Room;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_PostalAddress_BuildingNumber;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_PostalAddress_BuildingName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_PostalAddress_CitySubdivisionName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_PostalAddress_CityName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_PostalAddress_Country;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_PartyTaxSchemeName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_PartyTaxSchemeTaxTypeCode;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_WebsiteURI;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_Contact_Telephone;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_Contact_Telefax;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_Contact_ElectronicMail;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_Person_FirstName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_Person_FamilyName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_Person_MiddleName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_Person_NameSuffix;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_Person_Title;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification1_schemeID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification1_ID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification2_schemeID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification2_ID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification3_schemeID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification3_ID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification4_schemeID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification4_ID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification5_schemeID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_AgentParty_PartyIdentification5_ID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_AgentParty_PartyName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_StreetName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_Room;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_BuildingNumber;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_BuildingName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_CitySubdivisionName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_CityName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_AgentParty_PostalAddress_Country;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_AgentParty_PartyTaxSchemeName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_AgentParty_PartyTaxSchemeTaxTypeCode;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_AgentParty_WebsiteURI;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_AgentParty_Contact_Telephone;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_AgentParty_Contact_Telefax;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_AgentParty_Contact_ElectronicMail;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_AgentParty_Person_FirstName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_AgentParty_Person_FamilyName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_AgentParty_Person_MiddleName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_AgentParty_Person_NameSuffix;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ASP_AgentParty_Person_Title;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_PartyIdentification1_schemeID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_PartyIdentification1_ID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_PartyIdentification2_schemeID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_PartyIdentification2_ID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_PartyIdentification3_schemeID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_PartyIdentification3_ID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_PartyIdentification4_schemeID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_PartyIdentification4_ID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_PartyIdentification5_schemeID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_PartyIdentification5_ID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_PartyName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_PostalAddress_StreetName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_PostalAddress_Room;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_PostalAddress_BuildingNumber;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_PostalAddress_BuildingName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_PostalAddress_CitySubdivisionName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_PostalAddress_CityName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_PostalAddress_Country;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_PartyTaxSchemeName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_PartyTaxSchemeTaxTypeCode;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_WebsiteURI;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_Contact_Telephone;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_Contact_Telefax;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_Contact_ElectronicMail;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_Person_FirstName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_Person_FamilyName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_Person_MiddleName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_Person_NameSuffix;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_Person_Title;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification1_schemeID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification1_ID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification2_schemeID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification2_ID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification3_schemeID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification3_ID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification4_schemeID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification4_ID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification5_schemeID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_AgentParty_PartyIdentification5_ID;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_AgentParty_PartyName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_StreetName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_Room;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_BuildingNumber;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_BuildingName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_CitySubdivisionName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_CityName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_AgentParty_PostalAddress_Country;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_AgentParty_PartyTaxSchemeName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_AgentParty_PartyTaxSchemeTaxTypeCode;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_AgentParty_WebsiteURI;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_AgentParty_Contact_Telephone;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_AgentParty_Contact_Telefax;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_AgentParty_Contact_ElectronicMail;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_AgentParty_Person_FirstName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_AgentParty_Person_FamilyName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_AgentParty_Person_MiddleName;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_AgentParty_Person_NameSuffix;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_ACP_AgentParty_Person_Title;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_TaxExchangeRate_SourceCurrencyCode;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_TaxExchangeRate_TargetCurrencyCode;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_TaxExchangeRate_CalculationRate;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_TaxExchangeRate_Date;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_PricingExchangeRate_SourceCurrencyCode;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_PricingExchangeRate_TargetCurrencyCode;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_PricingExchangeRate_CalculationRate;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_PricingExchangeRate_Date;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_PaymentExchangeRate_SourceCurrencyCode;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_PaymentExchangeRate_TargetCurrencyCode;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_PaymentExchangeRate_CalculationRate;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_PaymentExchangeRate_Date;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_PaymentAlternativeExchangeRate_SourceCurrencyCode;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_PaymentAlternativeExchangeRate_TargetCurrencyCode;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_PaymentAlternativeExchangeRate_CalculationRate;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_PaymentAlternativeExchangeRate_Date;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_TaxAmount;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_LegalMonetaryTotal_LineExtensionAmount;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_LegalMonetaryTotal_TaxExclusiveAmount;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_LegalMonetaryTotal_TaxInclusiveAmount;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_LegalMonetaryTotal_AllowanceTotalAmount;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_LegalMonetaryTotal_ChargeTotalAmount;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_LegalMonetaryTotal_PayableRoundingAmount;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_LegalMonetaryTotal_PayableAmount;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_WithholdingTaxAmount;
        private System.Data.DataColumn tbInvoice_Gonderilmisler_Message;
        private DevExpress.XtraGrid.Columns.GridColumn colMessage;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage6;
        private DevExpress.XtraEditors.SimpleButton btnItems;
    }
}