namespace MrTEK_EFatura
{
    partial class frmInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoice));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.dataLayoutSupplier = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.textEdit55 = new DevExpress.XtraEditors.TextEdit();
            this.tbInvoice = new NeoDAC.NeoTable(this.components);
            this.tbInvoice_InvoiceID = new System.Data.DataColumn();
            this.tbInvoice_Deleted = new System.Data.DataColumn();
            this.tbInvoice_CreatedBy = new System.Data.DataColumn();
            this.tbInvoice_CreatedDate = new System.Data.DataColumn();
            this.tbInvoice_ModifiedBy = new System.Data.DataColumn();
            this.tbInvoice_ModifiedDate = new System.Data.DataColumn();
            this.tbInvoice_IOType = new System.Data.DataColumn();
            this.tbInvoice_IntCode = new System.Data.DataColumn();
            this.tbInvoice_LocalStatus = new System.Data.DataColumn();
            this.tbInvoice_IntegratorID = new System.Data.DataColumn();
            this.tbInvoice_Status = new System.Data.DataColumn();
            this.tbInvoice_StatusDescription = new System.Data.DataColumn();
            this.tbInvoice_PostBox = new System.Data.DataColumn();
            this.tbInvoice_XsltNo = new System.Data.DataColumn();
            this.tbInvoice_ProfileID = new System.Data.DataColumn();
            this.tbInvoice_ID = new System.Data.DataColumn();
            this.tbInvoice_UUID = new System.Data.DataColumn();
            this.tbInvoice_IssueDate = new System.Data.DataColumn();
            this.tbInvoice_IssueTime = new System.Data.DataColumn();
            this.tbInvoice_InvoiceTypeCode = new System.Data.DataColumn();
            this.tbInvoice_DocumentCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_TaxCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_PricingCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_PaymentCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_PaymentAlternativeCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_LineCountNumeric = new System.Data.DataColumn();
            this.tbInvoice_InvoicePeriod_StartDate = new System.Data.DataColumn();
            this.tbInvoice_InvoicePeriod_EndDate = new System.Data.DataColumn();
            this.tbInvoice_ASP_PartyIdentification1_schemeID = new System.Data.DataColumn();
            this.tbInvoice_ASP_PartyIdentification1_ID = new System.Data.DataColumn();
            this.tbInvoice_ASP_PartyIdentification2_schemeID = new System.Data.DataColumn();
            this.tbInvoice_ASP_PartyIdentification2_ID = new System.Data.DataColumn();
            this.tbInvoice_ASP_PartyIdentification3_schemeID = new System.Data.DataColumn();
            this.tbInvoice_ASP_PartyIdentification3_ID = new System.Data.DataColumn();
            this.tbInvoice_ASP_PartyIdentification4_schemeID = new System.Data.DataColumn();
            this.tbInvoice_ASP_PartyIdentification4_ID = new System.Data.DataColumn();
            this.tbInvoice_ASP_PartyIdentification5_schemeID = new System.Data.DataColumn();
            this.tbInvoice_ASP_PartyIdentification5_ID = new System.Data.DataColumn();
            this.tbInvoice_ASP_PartyName = new System.Data.DataColumn();
            this.tbInvoice_ASP_PostalAddress_StreetName = new System.Data.DataColumn();
            this.tbInvoice_ASP_PostalAddress_Room = new System.Data.DataColumn();
            this.tbInvoice_ASP_PostalAddress_BuildingNumber = new System.Data.DataColumn();
            this.tbInvoice_ASP_PostalAddress_BuildingName = new System.Data.DataColumn();
            this.tbInvoice_ASP_PostalAddress_CitySubdivisionName = new System.Data.DataColumn();
            this.tbInvoice_ASP_PostalAddress_CityName = new System.Data.DataColumn();
            this.tbInvoice_ASP_PostalAddress_Country = new System.Data.DataColumn();
            this.tbInvoice_ASP_PartyTaxSchemeName = new System.Data.DataColumn();
            this.tbInvoice_ASP_PartyTaxSchemeTaxTypeCode = new System.Data.DataColumn();
            this.tbInvoice_ASP_WebsiteURI = new System.Data.DataColumn();
            this.tbInvoice_ASP_Contact_Telephone = new System.Data.DataColumn();
            this.tbInvoice_ASP_Contact_Telefax = new System.Data.DataColumn();
            this.tbInvoice_ASP_Contact_ElectronicMail = new System.Data.DataColumn();
            this.tbInvoice_ASP_Person_FirstName = new System.Data.DataColumn();
            this.tbInvoice_ASP_Person_FamilyName = new System.Data.DataColumn();
            this.tbInvoice_ASP_Person_MiddleName = new System.Data.DataColumn();
            this.tbInvoice_ASP_Person_NameSuffix = new System.Data.DataColumn();
            this.tbInvoice_ASP_Person_Title = new System.Data.DataColumn();
            this.tbInvoice_ASP_AgentParty_PartyIdentification1_schemeID = new System.Data.DataColumn();
            this.tbInvoice_ASP_AgentParty_PartyIdentification1_ID = new System.Data.DataColumn();
            this.tbInvoice_ASP_AgentParty_PartyIdentification2_schemeID = new System.Data.DataColumn();
            this.tbInvoice_ASP_AgentParty_PartyIdentification2_ID = new System.Data.DataColumn();
            this.tbInvoice_ASP_AgentParty_PartyIdentification3_schemeID = new System.Data.DataColumn();
            this.tbInvoice_ASP_AgentParty_PartyIdentification3_ID = new System.Data.DataColumn();
            this.tbInvoice_ASP_AgentParty_PartyIdentification4_schemeID = new System.Data.DataColumn();
            this.tbInvoice_ASP_AgentParty_PartyIdentification4_ID = new System.Data.DataColumn();
            this.tbInvoice_ASP_AgentParty_PartyIdentification5_schemeID = new System.Data.DataColumn();
            this.tbInvoice_ASP_AgentParty_PartyIdentification5_ID = new System.Data.DataColumn();
            this.tbInvoice_ASP_AgentParty_PartyName = new System.Data.DataColumn();
            this.tbInvoice_ASP_AgentParty_PostalAddress_StreetName = new System.Data.DataColumn();
            this.tbInvoice_ASP_AgentParty_PostalAddress_Room = new System.Data.DataColumn();
            this.tbInvoice_ASP_AgentParty_PostalAddress_BuildingNumber = new System.Data.DataColumn();
            this.tbInvoice_ASP_AgentParty_PostalAddress_BuildingName = new System.Data.DataColumn();
            this.tbInvoice_ASP_AgentParty_PostalAddress_CitySubdivisionName = new System.Data.DataColumn();
            this.tbInvoice_ASP_AgentParty_PostalAddress_CityName = new System.Data.DataColumn();
            this.tbInvoice_ASP_AgentParty_PostalAddress_Country = new System.Data.DataColumn();
            this.tbInvoice_ASP_AgentParty_PartyTaxSchemeName = new System.Data.DataColumn();
            this.tbInvoice_ASP_AgentParty_PartyTaxSchemeTaxTypeCode = new System.Data.DataColumn();
            this.tbInvoice_ASP_AgentParty_WebsiteURI = new System.Data.DataColumn();
            this.tbInvoice_ASP_AgentParty_Contact_Telephone = new System.Data.DataColumn();
            this.tbInvoice_ASP_AgentParty_Contact_Telefax = new System.Data.DataColumn();
            this.tbInvoice_ASP_AgentParty_Contact_ElectronicMail = new System.Data.DataColumn();
            this.tbInvoice_ASP_AgentParty_Person_FirstName = new System.Data.DataColumn();
            this.tbInvoice_ASP_AgentParty_Person_FamilyName = new System.Data.DataColumn();
            this.tbInvoice_ASP_AgentParty_Person_MiddleName = new System.Data.DataColumn();
            this.tbInvoice_ASP_AgentParty_Person_NameSuffix = new System.Data.DataColumn();
            this.tbInvoice_ASP_AgentParty_Person_Title = new System.Data.DataColumn();
            this.tbInvoice_ACP_PartyIdentification1_schemeID = new System.Data.DataColumn();
            this.tbInvoice_ACP_PartyIdentification1_ID = new System.Data.DataColumn();
            this.tbInvoice_ACP_PartyIdentification2_schemeID = new System.Data.DataColumn();
            this.tbInvoice_ACP_PartyIdentification2_ID = new System.Data.DataColumn();
            this.tbInvoice_ACP_PartyIdentification3_schemeID = new System.Data.DataColumn();
            this.tbInvoice_ACP_PartyIdentification3_ID = new System.Data.DataColumn();
            this.tbInvoice_ACP_PartyIdentification4_schemeID = new System.Data.DataColumn();
            this.tbInvoice_ACP_PartyIdentification4_ID = new System.Data.DataColumn();
            this.tbInvoice_ACP_PartyIdentification5_schemeID = new System.Data.DataColumn();
            this.tbInvoice_ACP_PartyIdentification5_ID = new System.Data.DataColumn();
            this.tbInvoice_ACP_PartyName = new System.Data.DataColumn();
            this.tbInvoice_ACP_PostalAddress_StreetName = new System.Data.DataColumn();
            this.tbInvoice_ACP_PostalAddress_Room = new System.Data.DataColumn();
            this.tbInvoice_ACP_PostalAddress_BuildingNumber = new System.Data.DataColumn();
            this.tbInvoice_ACP_PostalAddress_BuildingName = new System.Data.DataColumn();
            this.tbInvoice_ACP_PostalAddress_CitySubdivisionName = new System.Data.DataColumn();
            this.tbInvoice_ACP_PostalAddress_CityName = new System.Data.DataColumn();
            this.tbInvoice_ACP_PostalAddress_Country = new System.Data.DataColumn();
            this.tbInvoice_ACP_PartyTaxSchemeName = new System.Data.DataColumn();
            this.tbInvoice_ACP_PartyTaxSchemeTaxTypeCode = new System.Data.DataColumn();
            this.tbInvoice_ACP_WebsiteURI = new System.Data.DataColumn();
            this.tbInvoice_ACP_Contact_Telephone = new System.Data.DataColumn();
            this.tbInvoice_ACP_Contact_Telefax = new System.Data.DataColumn();
            this.tbInvoice_ACP_Contact_ElectronicMail = new System.Data.DataColumn();
            this.tbInvoice_ACP_Person_FirstName = new System.Data.DataColumn();
            this.tbInvoice_ACP_Person_FamilyName = new System.Data.DataColumn();
            this.tbInvoice_ACP_Person_MiddleName = new System.Data.DataColumn();
            this.tbInvoice_ACP_Person_NameSuffix = new System.Data.DataColumn();
            this.tbInvoice_ACP_Person_Title = new System.Data.DataColumn();
            this.tbInvoice_ACP_AgentParty_PartyIdentification1_schemeID = new System.Data.DataColumn();
            this.tbInvoice_ACP_AgentParty_PartyIdentification1_ID = new System.Data.DataColumn();
            this.tbInvoice_ACP_AgentParty_PartyIdentification2_schemeID = new System.Data.DataColumn();
            this.tbInvoice_ACP_AgentParty_PartyIdentification2_ID = new System.Data.DataColumn();
            this.tbInvoice_ACP_AgentParty_PartyIdentification3_schemeID = new System.Data.DataColumn();
            this.tbInvoice_ACP_AgentParty_PartyIdentification3_ID = new System.Data.DataColumn();
            this.tbInvoice_ACP_AgentParty_PartyIdentification4_schemeID = new System.Data.DataColumn();
            this.tbInvoice_ACP_AgentParty_PartyIdentification4_ID = new System.Data.DataColumn();
            this.tbInvoice_ACP_AgentParty_PartyIdentification5_schemeID = new System.Data.DataColumn();
            this.tbInvoice_ACP_AgentParty_PartyIdentification5_ID = new System.Data.DataColumn();
            this.tbInvoice_ACP_AgentParty_PartyName = new System.Data.DataColumn();
            this.tbInvoice_ACP_AgentParty_PostalAddress_StreetName = new System.Data.DataColumn();
            this.tbInvoice_ACP_AgentParty_PostalAddress_Room = new System.Data.DataColumn();
            this.tbInvoice_ACP_AgentParty_PostalAddress_BuildingNumber = new System.Data.DataColumn();
            this.tbInvoice_ACP_AgentParty_PostalAddress_BuildingName = new System.Data.DataColumn();
            this.tbInvoice_ACP_AgentParty_PostalAddress_CitySubdivisionName = new System.Data.DataColumn();
            this.tbInvoice_ACP_AgentParty_PostalAddress_CityName = new System.Data.DataColumn();
            this.tbInvoice_ACP_AgentParty_PostalAddress_Country = new System.Data.DataColumn();
            this.tbInvoice_ACP_AgentParty_PartyTaxSchemeName = new System.Data.DataColumn();
            this.tbInvoice_ACP_AgentParty_PartyTaxSchemeTaxTypeCode = new System.Data.DataColumn();
            this.tbInvoice_ACP_AgentParty_WebsiteURI = new System.Data.DataColumn();
            this.tbInvoice_ACP_AgentParty_Contact_Telephone = new System.Data.DataColumn();
            this.tbInvoice_ACP_AgentParty_Contact_Telefax = new System.Data.DataColumn();
            this.tbInvoice_ACP_AgentParty_Contact_ElectronicMail = new System.Data.DataColumn();
            this.tbInvoice_ACP_AgentParty_Person_FirstName = new System.Data.DataColumn();
            this.tbInvoice_ACP_AgentParty_Person_FamilyName = new System.Data.DataColumn();
            this.tbInvoice_ACP_AgentParty_Person_MiddleName = new System.Data.DataColumn();
            this.tbInvoice_ACP_AgentParty_Person_NameSuffix = new System.Data.DataColumn();
            this.tbInvoice_ACP_AgentParty_Person_Title = new System.Data.DataColumn();
            this.tbInvoice_TaxExchangeRate_SourceCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_TaxExchangeRate_TargetCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_TaxExchangeRate_CalculationRate = new System.Data.DataColumn();
            this.tbInvoice_TaxExchangeRate_Date = new System.Data.DataColumn();
            this.tbInvoice_PricingExchangeRate_SourceCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_PricingExchangeRate_TargetCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_PricingExchangeRate_CalculationRate = new System.Data.DataColumn();
            this.tbInvoice_PricingExchangeRate_Date = new System.Data.DataColumn();
            this.tbInvoice_PaymentExchangeRate_SourceCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_PaymentExchangeRate_TargetCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_PaymentExchangeRate_CalculationRate = new System.Data.DataColumn();
            this.tbInvoice_PaymentExchangeRate_Date = new System.Data.DataColumn();
            this.tbInvoice_PaymentAlternativeExchangeRate_SourceCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_PaymentAlternativeExchangeRate_TargetCurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_PaymentAlternativeExchangeRate_CalculationRate = new System.Data.DataColumn();
            this.tbInvoice_PaymentAlternativeExchangeRate_Date = new System.Data.DataColumn();
            this.tbInvoice_TaxAmount = new System.Data.DataColumn();
            this.tbInvoice_LegalMonetaryTotal_LineExtensionAmount = new System.Data.DataColumn();
            this.tbInvoice_LegalMonetaryTotal_TaxExclusiveAmount = new System.Data.DataColumn();
            this.tbInvoice_LegalMonetaryTotal_TaxInclusiveAmount = new System.Data.DataColumn();
            this.tbInvoice_LegalMonetaryTotal_AllowanceTotalAmount = new System.Data.DataColumn();
            this.tbInvoice_LegalMonetaryTotal_ChargeTotalAmount = new System.Data.DataColumn();
            this.tbInvoice_LegalMonetaryTotal_PayableRoundingAmount = new System.Data.DataColumn();
            this.tbInvoice_LegalMonetaryTotal_PayableAmount = new System.Data.DataColumn();
            this.FirmConn = new NeoDAC.NeoConnection(this.components);
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.textEdit54 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit49 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit48 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit8 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit9 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit10 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit11 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit12 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit13 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit14 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit15 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit16 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit17 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit18 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit19 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit20 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit21 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit22 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit23 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit38 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit24 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit25 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit26 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit27 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit28 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit29 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit30 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit31 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit32 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit33 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit34 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit35 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit36 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit37 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit39 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit40 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit41 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit42 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit43 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit44 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit45 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit46 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup11 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup12 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup13 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup14 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem16 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem17 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem18 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem19 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem20 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem21 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem22 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem23 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem24 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem45 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem46 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup15 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem25 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem26 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem27 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem28 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem29 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem30 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem31 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem32 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem33 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem34 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem35 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem37 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem38 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem39 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem40 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem41 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem156 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem51 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup16 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem42 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem43 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem44 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem52 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup17 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup18 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup19 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup20 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.dataLayoutCustomer = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.textEdit53 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit52 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit50 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit51 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit91 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit92 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit93 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit94 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit95 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit96 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit97 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit98 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit99 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit100 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit101 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit102 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit103 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit104 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit105 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit106 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit107 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit108 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit109 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit110 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit111 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit112 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit113 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit114 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit115 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit116 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit117 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit118 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit119 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit120 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit121 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit122 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit123 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit124 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit125 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit126 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit127 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit128 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit129 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit130 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit131 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit132 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit133 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit134 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup21 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup22 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup23 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup24 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup25 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup26 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem89 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem90 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem91 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem92 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem93 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem94 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem95 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem96 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem97 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem98 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem99 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem100 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem101 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem102 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup27 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem103 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem104 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem105 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem106 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem107 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem108 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem109 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem110 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem111 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem112 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem113 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem114 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem115 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem116 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem117 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem118 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem119 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem47 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem48 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup28 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem120 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem121 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem122 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem123 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem124 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem125 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem126 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem127 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem128 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem129 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem130 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem131 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem132 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem49 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem50 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup29 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup30 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl3 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage7 = new DevExpress.XtraTab.XtraTabPage();
            this.dataLayoutTotals = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.TaxAmountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.LegalMonetaryTotal_LineExtensionAmountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.LegalMonetaryTotal_TaxExclusiveAmountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.LegalMonetaryTotal_TaxInclusiveAmountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.LegalMonetaryTotal_AllowanceTotalSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.LegalMonetaryTotal_PayableRoundingAmountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.LegalMonetaryTotal_PayableAmountSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup7 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup8 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup9 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup10 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForTaxAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLegalMonetaryTotal_LineExtensionAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLegalMonetaryTotal_TaxExclusiveAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLegalMonetaryTotal_TaxInclusiveAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLegalMonetaryTotal_AllowanceTotal = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLegalMonetaryTotal_PayableRoundingAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLegalMonetaryTotal_PayableAmount = new DevExpress.XtraLayout.LayoutControlItem();
            this.xtraTabPage8 = new DevExpress.XtraTab.XtraTabPage();
            this.grInvoice_TaxSubTotal = new DevExpress.XtraGrid.GridControl();
            this.tbInvoice_TaxSubtotal = new NeoDAC.NeoTable(this.components);
            this.tbInvoice_TaxSubtotal_nID = new System.Data.DataColumn();
            this.tbInvoice_TaxSubtotal_InvoiceID = new System.Data.DataColumn();
            this.tbInvoice_TaxSubtotal_TaxableAmount = new System.Data.DataColumn();
            this.tbInvoice_TaxSubtotal_currencyID = new System.Data.DataColumn();
            this.tbInvoice_TaxSubtotal_TaxAmount = new System.Data.DataColumn();
            this.tbInvoice_TaxSubtotal_PerUnitAmount = new System.Data.DataColumn();
            this.tbInvoice_TaxSubtotal_CalculationSequenceNumeric = new System.Data.DataColumn();
            this.tbInvoice_TaxSubtotal_Percent_ = new System.Data.DataColumn();
            this.tbInvoice_TaxSubtotal_TaxCategory_TaxScheme_Name = new System.Data.DataColumn();
            this.tbInvoice_TaxSubtotal_TaxCategory_TaxScheme_TaxTypeCode = new System.Data.DataColumn();
            this.tbInvoice_TaxSubtotal_TaxCategory_TaxExemptionReason = new System.Data.DataColumn();
            this.tbInvoice_TaxSubtotal_TaxCategory_TaxExemptionReasonCode = new System.Data.DataColumn();
            this.sqlCommand16 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand14 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand13 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand15 = new System.Data.SqlClient.SqlCommand();
            this.grInvoice_TaxSubTotalView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn25 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn26 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn27 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn28 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn29 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.xtraTabPage16 = new DevExpress.XtraTab.XtraTabPage();
            this.grInvoice_WithholdingTaxSubTotal = new DevExpress.XtraGrid.GridControl();
            this.tbInvoice_WithholdingTaxSubtotal = new NeoDAC.NeoTable(this.components);
            this.tbInvoice_WithholdingTaxSubtotal_nID = new System.Data.DataColumn();
            this.tbInvoice_WithholdingTaxSubtotal_InvoiceID = new System.Data.DataColumn();
            this.tbInvoice_WithholdingTaxSubtotal_TaxableAmount = new System.Data.DataColumn();
            this.tbInvoice_WithholdingTaxSubtotal_currencyID = new System.Data.DataColumn();
            this.tbInvoice_WithholdingTaxSubtotal_TaxAmount = new System.Data.DataColumn();
            this.tbInvoice_WithholdingTaxSubtotal_PerUnitAmount = new System.Data.DataColumn();
            this.tbInvoice_WithholdingTaxSubtotal_CalculationSequenceNumeric = new System.Data.DataColumn();
            this.tbInvoice_WithholdingTaxSubtotal_Percent_ = new System.Data.DataColumn();
            this.tbInvoice_WithholdingTaxSubtotal_TaxCategory_TaxScheme_Name = new System.Data.DataColumn();
            this.tbInvoice_WithholdingTaxSubtotal_TaxCategory_TaxScheme_TaxTypeCode = new System.Data.DataColumn();
            this.tbInvoice_WithholdingTaxSubtotal_TaxCategory_TaxExemptionReason = new System.Data.DataColumn();
            this.tbInvoice_WithholdingTaxSubtotal_TaxCategory_TaxExemptionReasonCode = new System.Data.DataColumn();
            this.sqlCommand48 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand46 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand45 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand47 = new System.Data.SqlClient.SqlCommand();
            this.grInvoice_WithholdingTaxSubTotalView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn30 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.xtraTabPage9 = new DevExpress.XtraTab.XtraTabPage();
            this.grInvoice_AllowanceCharge = new DevExpress.XtraGrid.GridControl();
            this.tbInvoice_AllowanceCharge = new NeoDAC.NeoTable(this.components);
            this.tbInvoice_AllowanceCharge_nID = new System.Data.DataColumn();
            this.tbInvoice_AllowanceCharge_InvoiceID = new System.Data.DataColumn();
            this.tbInvoice_AllowanceCharge_ChargeIndicator = new System.Data.DataColumn();
            this.tbInvoice_AllowanceCharge_AllowanceChargeReason = new System.Data.DataColumn();
            this.tbInvoice_AllowanceCharge_MultiplierFactorNumeric = new System.Data.DataColumn();
            this.tbInvoice_AllowanceCharge_Amount = new System.Data.DataColumn();
            this.tbInvoice_AllowanceCharge_Amount_currencyID = new System.Data.DataColumn();
            this.tbInvoice_AllowanceCharge_BaseAmount = new System.Data.DataColumn();
            this.tbInvoice_AllowanceCharge_BaseAmount_currencyID = new System.Data.DataColumn();
            this.sqlCommand20 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand18 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand17 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand19 = new System.Data.SqlClient.SqlCommand();
            this.grInvoice_AllowanceChargeView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChargeIndicator = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAllowanceChargeReason = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMultiplierFactorNumeric = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount_currencyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaseAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBaseAmount_currencyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.xtraTabPage15 = new DevExpress.XtraTab.XtraTabPage();
            this.grInvoice_Note = new DevExpress.XtraGrid.GridControl();
            this.tbInvoice_Note = new NeoDAC.NeoTable(this.components);
            this.tbInvoice_Note_nID = new System.Data.DataColumn();
            this.tbInvoice_Note_InvoiceID = new System.Data.DataColumn();
            this.tbInvoice_Note_Note = new System.Data.DataColumn();
            this.sqlCommand44 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand42 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand41 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand43 = new System.Data.SqlClient.SqlCommand();
            this.grInvoice_NoteView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnID8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceID8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage6 = new DevExpress.XtraTab.XtraTabPage();
            this.grInvoice_OrderReference = new DevExpress.XtraGrid.GridControl();
            this.tbInvoice_OrderReference = new NeoDAC.NeoTable(this.components);
            this.tbInvoice_OrderReference_nID = new System.Data.DataColumn();
            this.tbInvoice_OrderReference_InvoiceID = new System.Data.DataColumn();
            this.tbInvoice_OrderReference_ID = new System.Data.DataColumn();
            this.tbInvoice_OrderReference_IssueDate = new System.Data.DataColumn();
            this.sqlCommand24 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand22 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand21 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand23 = new System.Data.SqlClient.SqlCommand();
            this.grInvoice_OrderReferenceView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnID3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceID3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIssueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.xtraTabPage10 = new DevExpress.XtraTab.XtraTabPage();
            this.grInvoice_DespatchDocumentReference = new DevExpress.XtraGrid.GridControl();
            this.tbInvoice_DespatchDocumentReference = new NeoDAC.NeoTable(this.components);
            this.tbInvoice_DespatchDocumentReference_nID = new System.Data.DataColumn();
            this.tbInvoice_DespatchDocumentReference_InvoiceID = new System.Data.DataColumn();
            this.tbInvoice_DespatchDocumentReference_ID = new System.Data.DataColumn();
            this.tbInvoice_DespatchDocumentReference_IssueDate = new System.Data.DataColumn();
            this.sqlCommand28 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand26 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand25 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand27 = new System.Data.SqlClient.SqlCommand();
            this.grInvoice_DespatchDocumentReferenceView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnID4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceID4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIssueDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage11 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl4 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage12 = new DevExpress.XtraTab.XtraTabPage();
            this.grInvoice_PaymentMeans = new DevExpress.XtraGrid.GridControl();
            this.tbInvoice_PaymentMeans = new NeoDAC.NeoTable(this.components);
            this.tbInvoice_PaymentMeans_nID = new System.Data.DataColumn();
            this.tbInvoice_PaymentMeans_InvoiceID = new System.Data.DataColumn();
            this.tbInvoice_PaymentMeans_PaymentMeansCode = new System.Data.DataColumn();
            this.tbInvoice_PaymentMeans_PaymentDueDate = new System.Data.DataColumn();
            this.tbInvoice_PaymentMeans_PaymentChannelCode = new System.Data.DataColumn();
            this.tbInvoice_PaymentMeans_InstructionNote = new System.Data.DataColumn();
            this.tbInvoice_PaymentMeans_PayeeFinancialAccount_ID = new System.Data.DataColumn();
            this.tbInvoice_PaymentMeans_PayeeFinancialAccount_CurrencyCode = new System.Data.DataColumn();
            this.tbInvoice_PaymentMeans_PayeeFinancialAccount_PaymentNote = new System.Data.DataColumn();
            this.sqlCommand32 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand30 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand29 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand31 = new System.Data.SqlClient.SqlCommand();
            this.grInvoice_PaymentMeansView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnID5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceID5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentMeansCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentDueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentChannelCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInstructionNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayeeFinancialAccount_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayeeFinancialAccount_CurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayeeFinancialAccount_PaymentNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage13 = new DevExpress.XtraTab.XtraTabPage();
            this.grInvoice_PaymentTerms = new DevExpress.XtraGrid.GridControl();
            this.tbInvoice_PaymentTerms = new NeoDAC.NeoTable(this.components);
            this.tbInvoice_PaymentTerms_nID = new System.Data.DataColumn();
            this.tbInvoice_PaymentTerms_InvoiceID = new System.Data.DataColumn();
            this.tbInvoice_PaymentTerms_Note = new System.Data.DataColumn();
            this.tbInvoice_PaymentTerms_PenaltySurchargePercent = new System.Data.DataColumn();
            this.tbInvoice_PaymentTerms_Amount = new System.Data.DataColumn();
            this.tbInvoice_PaymentTerms_Amount_currencyID = new System.Data.DataColumn();
            this.sqlCommand36 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand34 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand33 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand35 = new System.Data.SqlClient.SqlCommand();
            this.grInvoice_PaymentTermsView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnID6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceID6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPenaltySurchargePercent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount_currencyID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage14 = new DevExpress.XtraTab.XtraTabPage();
            this.grInvoice_ReceiptDocumentReference = new DevExpress.XtraGrid.GridControl();
            this.tbInvoice_ReceiptDocumentReference = new NeoDAC.NeoTable(this.components);
            this.tbInvoice_ReceiptDocumentReference_nID = new System.Data.DataColumn();
            this.tbInvoice_ReceiptDocumentReference_InvoiceID = new System.Data.DataColumn();
            this.tbInvoice_ReceiptDocumentReference_ID = new System.Data.DataColumn();
            this.tbInvoice_ReceiptDocumentReference_IssueDate = new System.Data.DataColumn();
            this.sqlCommand40 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand38 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand37 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand39 = new System.Data.SqlClient.SqlCommand();
            this.grInvoice_ReceiptDocumentReferenceView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnID7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceID7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIssueDate2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblBillingReference = new DevExpress.XtraEditors.LabelControl();
            this.grBillingReference = new DevExpress.XtraGrid.GridControl();
            this.tbInvoice_BillingReference = new NeoDAC.NeoTable(this.components);
            this.tbInvoice_BillingReference_nID = new System.Data.DataColumn();
            this.tbInvoice_BillingReference_InvoiceID = new System.Data.DataColumn();
            this.tbInvoice_BillingReference_ID = new System.Data.DataColumn();
            this.tbInvoice_BillingReference_IssueDate = new System.Data.DataColumn();
            this.tbInvoice_BillingReference_DocumentTypeCode = new System.Data.DataColumn();
            this.tbInvoice_BillingReference_DocumentType = new System.Data.DataColumn();
            this.sqlCommand60 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand58 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand57 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand59 = new System.Data.SqlClient.SqlCommand();
            this.gvBillingReference = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn31 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn33 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn34 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.btnNewGuid = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit3 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.InvoicePeriod_EndDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.InvoicePeriod_StartDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.PricingExchangeRate_CalculationRateSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.LineCountNumericSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.IDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.IssueDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.PostBoxTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.IntegratorIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.IssueTimeDateEdit = new DevExpress.XtraEditors.TimeEdit();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grInvoiceLine = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ihracatBilgileriniAltSatırlaraKopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gTIPNOBoşOlanlarıGeçmişKayıtlardanBulDoldurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbInvoiceLine = new NeoDAC.NeoTable(this.components);
            this.tbInvoiceLine_InvoiceLineID = new System.Data.DataColumn();
            this.tbInvoiceLine_InvoiceID = new System.Data.DataColumn();
            this.tbInvoiceLine_ID = new System.Data.DataColumn();
            this.tbInvoiceLine_Note = new System.Data.DataColumn();
            this.tbInvoiceLine_InvoicedQuantity = new System.Data.DataColumn();
            this.tbInvoiceLine_InvoicedQuantity_unitCode = new System.Data.DataColumn();
            this.tbInvoiceLine_LineExtensionAmount = new System.Data.DataColumn();
            this.tbInvoiceLine_currencyID = new System.Data.DataColumn();
            this.tbInvoiceLine_AllowanceCharge_ChargeIndicator = new System.Data.DataColumn();
            this.tbInvoiceLine_AllowanceCharge_AllowanceChargeReason = new System.Data.DataColumn();
            this.tbInvoiceLine_AllowanceCharge_Amount = new System.Data.DataColumn();
            this.tbInvoiceLine_AllowanceCharge_BaseAmount = new System.Data.DataColumn();
            this.tbInvoiceLine_AllowanceCharge_MultiplierFactorNumeric = new System.Data.DataColumn();
            this.tbInvoiceLine_Item_Name = new System.Data.DataColumn();
            this.tbInvoiceLine_Item_Description = new System.Data.DataColumn();
            this.tbInvoiceLine_Item_BrandName = new System.Data.DataColumn();
            this.tbInvoiceLine_Item_ModelName = new System.Data.DataColumn();
            this.tbInvoiceLine_Item_ItemClassificationCode = new System.Data.DataColumn();
            this.tbInvoiceLine_Item_BuyersItemIdentification_ID = new System.Data.DataColumn();
            this.tbInvoiceLine_Item_SellersItemIdentification_ID = new System.Data.DataColumn();
            this.tbInvoiceLine_Item_ManufacturersItemIdentification_ID = new System.Data.DataColumn();
            this.tbInvoiceLine_PriceAmount = new System.Data.DataColumn();
            this.tbInvoiceLine_TaxAmount = new System.Data.DataColumn();
            this.tbInvoiceLine_WithholdingTaxAmount = new System.Data.DataColumn();
            this.tbInvoiceLine_GTIPNO = new System.Data.DataColumn();
            this.tbInvoiceLine_TransportModeCode = new System.Data.DataColumn();
            this.tbInvoiceLine_DeliveryTerms = new System.Data.DataColumn();
            this.sqlCommand8 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand7 = new System.Data.SqlClient.SqlCommand();
            this.grInvoiceLineView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colInvoiceLineID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoicedQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoicedQuantity_unitCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLineExtensionAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcurrencyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAllowanceCharge_ChargeIndicator = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colAllowanceCharge_AllowanceChargeReason = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAllowanceCharge_Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAllowanceCharge_BaseAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItem_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItem_Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItem_BrandName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItem_ModelName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBuyersItemIdentification_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSellersItemIdentification_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManufacturersItemIdentification_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriceAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItem_ItemClassificationCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAllowanceCharge_MultiplierFactorNumeric = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeliveryTerms = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colGTIPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransportModeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboGridTransportModeCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.xtraTabControl6 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage19 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl5 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage17 = new DevExpress.XtraTab.XtraTabPage();
            this.grInvoiceLine_TaxSubTotal = new DevExpress.XtraGrid.GridControl();
            this.tbInvoiceLine_TaxSubTotal = new NeoDAC.NeoTable(this.components);
            this.tbInvoiceLine_TaxSubTotal_nID = new System.Data.DataColumn();
            this.tbInvoiceLine_TaxSubTotal_InvoiceLineID = new System.Data.DataColumn();
            this.tbInvoiceLine_TaxSubTotal_TaxableAmount = new System.Data.DataColumn();
            this.tbInvoiceLine_TaxSubTotal_currencyID = new System.Data.DataColumn();
            this.tbInvoiceLine_TaxSubTotal_TaxAmount = new System.Data.DataColumn();
            this.tbInvoiceLine_TaxSubTotal_PerUnitAmount = new System.Data.DataColumn();
            this.tbInvoiceLine_TaxSubTotal_CalculationSequenceNumeric = new System.Data.DataColumn();
            this.tbInvoiceLine_TaxSubTotal_Percent_ = new System.Data.DataColumn();
            this.tbInvoiceLine_TaxSubTotal_TaxCategory_TaxScheme_Name = new System.Data.DataColumn();
            this.tbInvoiceLine_TaxSubTotal_TaxCategory_TaxScheme_TaxTypeCode = new System.Data.DataColumn();
            this.tbInvoiceLine_TaxSubTotal_TaxCategory_TaxExemptionReason = new System.Data.DataColumn();
            this.tbInvoiceLine_TaxSubTotal_TaxCategory_TaxExemptionReasonCode = new System.Data.DataColumn();
            this.sqlCommand12 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand10 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand9 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand11 = new System.Data.SqlClient.SqlCommand();
            this.grInvoiceLine_TaxSubTotalView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceLineID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxableAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCalculationSequenceNumeric = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcurrencyID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxAmount1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPercent_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxCategory_TaxScheme_TaxTypeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxCategory_TaxScheme_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxCategory_TaxExemptionReason1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxCategory_TaxExemptionReasonCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage18 = new DevExpress.XtraTab.XtraTabPage();
            this.grInvoiceLine_WithholdingTaxSubTotal = new DevExpress.XtraGrid.GridControl();
            this.tbInvoiceLine_WithholdingTaxSubTotal = new NeoDAC.NeoTable(this.components);
            this.tbInvoiceLine_WithholdingTaxSubTotal_nID = new System.Data.DataColumn();
            this.tbInvoiceLine_WithholdingTaxSubTotal_InvoiceLineID = new System.Data.DataColumn();
            this.tbInvoiceLine_WithholdingTaxSubTotal_TaxableAmount = new System.Data.DataColumn();
            this.tbInvoiceLine_WithholdingTaxSubTotal_currencyID = new System.Data.DataColumn();
            this.tbInvoiceLine_WithholdingTaxSubTotal_TaxAmount = new System.Data.DataColumn();
            this.tbInvoiceLine_WithholdingTaxSubTotal_PerUnitAmount = new System.Data.DataColumn();
            this.tbInvoiceLine_WithholdingTaxSubTotal_CalculationSequenceNumeric = new System.Data.DataColumn();
            this.tbInvoiceLine_WithholdingTaxSubTotal_Percent_ = new System.Data.DataColumn();
            this.tbInvoiceLine_WithholdingTaxSubTotal_TaxCategory_TaxScheme_Name = new System.Data.DataColumn();
            this.tbInvoiceLine_WithholdingTaxSubTotal_TaxCategory_TaxScheme_TaxTypeCode = new System.Data.DataColumn();
            this.tbInvoiceLine_WithholdingTaxSubTotal_TaxCategory_TaxExemptionReason = new System.Data.DataColumn();
            this.tbInvoiceLine_WithholdingTaxSubTotal_TaxCategory_TaxExemptionReasonCode = new System.Data.DataColumn();
            this.sqlCommand52 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand50 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand49 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand51 = new System.Data.SqlClient.SqlCommand();
            this.grInvoiceLine_WithholdingTaxSubTotalView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxCategory_TaxExemptionReason2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaxCategory_TaxExemptionReasonCode2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLineTax_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnLineTax_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btnLineTax_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage20 = new DevExpress.XtraTab.XtraTabPage();
            this.grInvoiceLine_Packages = new DevExpress.XtraGrid.GridControl();
            this.tbInvoiceLine_Packages = new NeoDAC.NeoTable(this.components);
            this.tbInvoiceLine_Packages_nID = new System.Data.DataColumn();
            this.tbInvoiceLine_Packages_InvoiceLineID = new System.Data.DataColumn();
            this.tbInvoiceLine_Packages_ID = new System.Data.DataColumn();
            this.tbInvoiceLine_Packages_Quantity = new System.Data.DataColumn();
            this.tbInvoiceLine_Packages_PackagingTypeCode = new System.Data.DataColumn();
            this.sqlCommand56 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand54 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand53 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand55 = new System.Data.SqlClient.SqlCommand();
            this.grInvoiceLine_PackagesView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceLineID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPackagingTypeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cboGridPackagingTypeCode = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnIhracatPaketleriVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.btnIhracatPaketleriKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnIhracatPaketleriDegistir = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit47 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.StatusDescriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnXMLIndir = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowXslt = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem36 = new DevExpress.XtraLayout.LayoutControlItem();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutSupplier)).BeginInit();
            this.dataLayoutSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit55.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit54.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit49.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit48.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit10.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit11.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit12.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit13.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit14.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit15.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit16.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit17.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit18.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit19.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit20.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit21.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit22.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit23.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit38.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit24.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit25.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit26.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit27.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit28.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit29.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit30.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit31.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit32.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit33.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit34.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit35.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit36.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit37.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit39.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit40.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit41.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit42.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit43.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit44.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit45.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit46.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem156)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup20)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutCustomer)).BeginInit();
            this.dataLayoutCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit53.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit52.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit50.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit51.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit91.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit92.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit93.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit94.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit95.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit96.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit97.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit98.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit99.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit100.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit101.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit102.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit103.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit104.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit105.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit106.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit107.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit108.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit109.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit110.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit111.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit112.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit113.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit114.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit115.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit116.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit117.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit118.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit119.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit120.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit121.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit122.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit123.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit124.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit125.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit126.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit127.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit128.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit129.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit130.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit131.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit132.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit133.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit134.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem89)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem90)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem91)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem92)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem93)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem94)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem95)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem96)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem97)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem98)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem99)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem101)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem102)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem103)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem104)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem105)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem106)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem107)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem108)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem109)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem110)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem111)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem112)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem113)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem114)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem115)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem116)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem117)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem118)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem119)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem120)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem121)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem122)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem123)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem124)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem125)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem126)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem127)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem128)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem129)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem130)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem131)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem132)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup30)).BeginInit();
            this.xtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).BeginInit();
            this.xtraTabControl3.SuspendLayout();
            this.xtraTabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutTotals)).BeginInit();
            this.dataLayoutTotals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaxAmountSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LegalMonetaryTotal_LineExtensionAmountSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LegalMonetaryTotal_TaxExclusiveAmountSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LegalMonetaryTotal_TaxInclusiveAmountSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LegalMonetaryTotal_AllowanceTotalSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LegalMonetaryTotal_PayableRoundingAmountSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LegalMonetaryTotal_PayableAmountSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTaxAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLegalMonetaryTotal_LineExtensionAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLegalMonetaryTotal_TaxExclusiveAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLegalMonetaryTotal_TaxInclusiveAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLegalMonetaryTotal_AllowanceTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLegalMonetaryTotal_PayableRoundingAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLegalMonetaryTotal_PayableAmount)).BeginInit();
            this.xtraTabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_TaxSubTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoice_TaxSubtotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_TaxSubTotalView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            this.xtraTabPage16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_WithholdingTaxSubTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoice_WithholdingTaxSubtotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_WithholdingTaxSubTotalView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit5)).BeginInit();
            this.xtraTabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_AllowanceCharge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoice_AllowanceCharge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_AllowanceChargeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
            this.xtraTabPage15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_Note)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoice_Note)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_NoteView)).BeginInit();
            this.xtraTabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_OrderReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoice_OrderReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_OrderReferenceView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).BeginInit();
            this.xtraTabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_DespatchDocumentReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoice_DespatchDocumentReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_DespatchDocumentReferenceView)).BeginInit();
            this.xtraTabPage11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl4)).BeginInit();
            this.xtraTabControl4.SuspendLayout();
            this.xtraTabPage12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_PaymentMeans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoice_PaymentMeans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_PaymentMeansView)).BeginInit();
            this.xtraTabPage13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_PaymentTerms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoice_PaymentTerms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_PaymentTermsView)).BeginInit();
            this.xtraTabPage14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_ReceiptDocumentReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoice_ReceiptDocumentReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_ReceiptDocumentReferenceView)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grBillingReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoice_BillingReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBillingReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicePeriod_EndDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicePeriod_EndDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicePeriod_StartDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicePeriod_StartDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PricingExchangeRate_CalculationRateSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineCountNumericSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IssueDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IssueDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostBoxTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegratorIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IssueTimeDateEdit.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoiceLine)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoiceLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoiceLineView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGridTransportModeCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl6)).BeginInit();
            this.xtraTabControl6.SuspendLayout();
            this.xtraTabPage19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl5)).BeginInit();
            this.xtraTabControl5.SuspendLayout();
            this.xtraTabPage17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoiceLine_TaxSubTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoiceLine_TaxSubTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoiceLine_TaxSubTotalView)).BeginInit();
            this.xtraTabPage18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoiceLine_WithholdingTaxSubTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoiceLine_WithholdingTaxSubTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoiceLine_WithholdingTaxSubTotalView)).BeginInit();
            this.panel5.SuspendLayout();
            this.xtraTabPage20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoiceLine_Packages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoiceLine_Packages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoiceLine_PackagesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGridPackagingTypeCode)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit47.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusDescriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem36)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 46);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1184, 448);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.xtraTabControl2);
            this.xtraTabPage1.Controls.Add(this.panel6);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1178, 420);
            this.xtraTabPage1.Text = "Baslik bilgileri";
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl2.Location = new System.Drawing.Point(0, 154);
            this.xtraTabControl2.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.xtraTabPage3;
            this.xtraTabControl2.Size = new System.Drawing.Size(1178, 266);
            this.xtraTabControl2.TabIndex = 31;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3,
            this.xtraTabPage4,
            this.xtraTabPage5,
            this.xtraTabPage15,
            this.xtraTabPage6,
            this.xtraTabPage10,
            this.xtraTabPage11,
            this.xtraTabPage14});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.dataLayoutSupplier);
            this.xtraTabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1172, 238);
            this.xtraTabPage3.Text = "Tedarikci bilgileri";
            // 
            // dataLayoutSupplier
            // 
            this.dataLayoutSupplier.Controls.Add(this.textEdit55);
            this.dataLayoutSupplier.Controls.Add(this.textEdit54);
            this.dataLayoutSupplier.Controls.Add(this.textEdit49);
            this.dataLayoutSupplier.Controls.Add(this.textEdit48);
            this.dataLayoutSupplier.Controls.Add(this.textEdit3);
            this.dataLayoutSupplier.Controls.Add(this.textEdit4);
            this.dataLayoutSupplier.Controls.Add(this.textEdit5);
            this.dataLayoutSupplier.Controls.Add(this.textEdit6);
            this.dataLayoutSupplier.Controls.Add(this.textEdit7);
            this.dataLayoutSupplier.Controls.Add(this.textEdit8);
            this.dataLayoutSupplier.Controls.Add(this.textEdit9);
            this.dataLayoutSupplier.Controls.Add(this.textEdit10);
            this.dataLayoutSupplier.Controls.Add(this.textEdit11);
            this.dataLayoutSupplier.Controls.Add(this.textEdit12);
            this.dataLayoutSupplier.Controls.Add(this.textEdit13);
            this.dataLayoutSupplier.Controls.Add(this.textEdit14);
            this.dataLayoutSupplier.Controls.Add(this.textEdit15);
            this.dataLayoutSupplier.Controls.Add(this.textEdit16);
            this.dataLayoutSupplier.Controls.Add(this.textEdit17);
            this.dataLayoutSupplier.Controls.Add(this.textEdit18);
            this.dataLayoutSupplier.Controls.Add(this.textEdit19);
            this.dataLayoutSupplier.Controls.Add(this.textEdit20);
            this.dataLayoutSupplier.Controls.Add(this.textEdit21);
            this.dataLayoutSupplier.Controls.Add(this.textEdit22);
            this.dataLayoutSupplier.Controls.Add(this.textEdit23);
            this.dataLayoutSupplier.Controls.Add(this.textEdit38);
            this.dataLayoutSupplier.Controls.Add(this.textEdit24);
            this.dataLayoutSupplier.Controls.Add(this.textEdit25);
            this.dataLayoutSupplier.Controls.Add(this.textEdit26);
            this.dataLayoutSupplier.Controls.Add(this.textEdit27);
            this.dataLayoutSupplier.Controls.Add(this.textEdit28);
            this.dataLayoutSupplier.Controls.Add(this.textEdit29);
            this.dataLayoutSupplier.Controls.Add(this.textEdit30);
            this.dataLayoutSupplier.Controls.Add(this.textEdit31);
            this.dataLayoutSupplier.Controls.Add(this.textEdit32);
            this.dataLayoutSupplier.Controls.Add(this.textEdit33);
            this.dataLayoutSupplier.Controls.Add(this.textEdit34);
            this.dataLayoutSupplier.Controls.Add(this.textEdit35);
            this.dataLayoutSupplier.Controls.Add(this.textEdit36);
            this.dataLayoutSupplier.Controls.Add(this.textEdit37);
            this.dataLayoutSupplier.Controls.Add(this.textEdit39);
            this.dataLayoutSupplier.Controls.Add(this.textEdit40);
            this.dataLayoutSupplier.Controls.Add(this.textEdit41);
            this.dataLayoutSupplier.Controls.Add(this.textEdit42);
            this.dataLayoutSupplier.Controls.Add(this.textEdit43);
            this.dataLayoutSupplier.Controls.Add(this.textEdit44);
            this.dataLayoutSupplier.Controls.Add(this.textEdit45);
            this.dataLayoutSupplier.Controls.Add(this.textEdit46);
            this.dataLayoutSupplier.DataSource = this.tbInvoice;
            this.dataLayoutSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutSupplier.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.dataLayoutSupplier.Name = "dataLayoutSupplier";
            this.dataLayoutSupplier.Root = this.layoutControlGroup11;
            this.dataLayoutSupplier.Size = new System.Drawing.Size(1172, 238);
            this.dataLayoutSupplier.TabIndex = 1;
            this.dataLayoutSupplier.Text = "dataLayoutControl2";
            // 
            // textEdit55
            // 
            this.textEdit55.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_AgentParty_WebsiteURI", true));
            this.textEdit55.EnterMoveNextControl = true;
            this.textEdit55.Location = new System.Drawing.Point(287, 1069);
            this.textEdit55.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit55.Name = "textEdit55";
            this.textEdit55.Size = new System.Drawing.Size(856, 20);
            this.textEdit55.StyleController = this.dataLayoutSupplier;
            this.textEdit55.TabIndex = 71;
            // 
            // tbInvoice
            // 
            this.tbInvoice.Columns.AddRange(new System.Data.DataColumn[] {
            this.tbInvoice_InvoiceID,
            this.tbInvoice_Deleted,
            this.tbInvoice_CreatedBy,
            this.tbInvoice_CreatedDate,
            this.tbInvoice_ModifiedBy,
            this.tbInvoice_ModifiedDate,
            this.tbInvoice_IOType,
            this.tbInvoice_IntCode,
            this.tbInvoice_LocalStatus,
            this.tbInvoice_IntegratorID,
            this.tbInvoice_Status,
            this.tbInvoice_StatusDescription,
            this.tbInvoice_PostBox,
            this.tbInvoice_XsltNo,
            this.tbInvoice_ProfileID,
            this.tbInvoice_ID,
            this.tbInvoice_UUID,
            this.tbInvoice_IssueDate,
            this.tbInvoice_IssueTime,
            this.tbInvoice_InvoiceTypeCode,
            this.tbInvoice_DocumentCurrencyCode,
            this.tbInvoice_TaxCurrencyCode,
            this.tbInvoice_PricingCurrencyCode,
            this.tbInvoice_PaymentCurrencyCode,
            this.tbInvoice_PaymentAlternativeCurrencyCode,
            this.tbInvoice_LineCountNumeric,
            this.tbInvoice_InvoicePeriod_StartDate,
            this.tbInvoice_InvoicePeriod_EndDate,
            this.tbInvoice_ASP_PartyIdentification1_schemeID,
            this.tbInvoice_ASP_PartyIdentification1_ID,
            this.tbInvoice_ASP_PartyIdentification2_schemeID,
            this.tbInvoice_ASP_PartyIdentification2_ID,
            this.tbInvoice_ASP_PartyIdentification3_schemeID,
            this.tbInvoice_ASP_PartyIdentification3_ID,
            this.tbInvoice_ASP_PartyIdentification4_schemeID,
            this.tbInvoice_ASP_PartyIdentification4_ID,
            this.tbInvoice_ASP_PartyIdentification5_schemeID,
            this.tbInvoice_ASP_PartyIdentification5_ID,
            this.tbInvoice_ASP_PartyName,
            this.tbInvoice_ASP_PostalAddress_StreetName,
            this.tbInvoice_ASP_PostalAddress_Room,
            this.tbInvoice_ASP_PostalAddress_BuildingNumber,
            this.tbInvoice_ASP_PostalAddress_BuildingName,
            this.tbInvoice_ASP_PostalAddress_CitySubdivisionName,
            this.tbInvoice_ASP_PostalAddress_CityName,
            this.tbInvoice_ASP_PostalAddress_Country,
            this.tbInvoice_ASP_PartyTaxSchemeName,
            this.tbInvoice_ASP_PartyTaxSchemeTaxTypeCode,
            this.tbInvoice_ASP_WebsiteURI,
            this.tbInvoice_ASP_Contact_Telephone,
            this.tbInvoice_ASP_Contact_Telefax,
            this.tbInvoice_ASP_Contact_ElectronicMail,
            this.tbInvoice_ASP_Person_FirstName,
            this.tbInvoice_ASP_Person_FamilyName,
            this.tbInvoice_ASP_Person_MiddleName,
            this.tbInvoice_ASP_Person_NameSuffix,
            this.tbInvoice_ASP_Person_Title,
            this.tbInvoice_ASP_AgentParty_PartyIdentification1_schemeID,
            this.tbInvoice_ASP_AgentParty_PartyIdentification1_ID,
            this.tbInvoice_ASP_AgentParty_PartyIdentification2_schemeID,
            this.tbInvoice_ASP_AgentParty_PartyIdentification2_ID,
            this.tbInvoice_ASP_AgentParty_PartyIdentification3_schemeID,
            this.tbInvoice_ASP_AgentParty_PartyIdentification3_ID,
            this.tbInvoice_ASP_AgentParty_PartyIdentification4_schemeID,
            this.tbInvoice_ASP_AgentParty_PartyIdentification4_ID,
            this.tbInvoice_ASP_AgentParty_PartyIdentification5_schemeID,
            this.tbInvoice_ASP_AgentParty_PartyIdentification5_ID,
            this.tbInvoice_ASP_AgentParty_PartyName,
            this.tbInvoice_ASP_AgentParty_PostalAddress_StreetName,
            this.tbInvoice_ASP_AgentParty_PostalAddress_Room,
            this.tbInvoice_ASP_AgentParty_PostalAddress_BuildingNumber,
            this.tbInvoice_ASP_AgentParty_PostalAddress_BuildingName,
            this.tbInvoice_ASP_AgentParty_PostalAddress_CitySubdivisionName,
            this.tbInvoice_ASP_AgentParty_PostalAddress_CityName,
            this.tbInvoice_ASP_AgentParty_PostalAddress_Country,
            this.tbInvoice_ASP_AgentParty_PartyTaxSchemeName,
            this.tbInvoice_ASP_AgentParty_PartyTaxSchemeTaxTypeCode,
            this.tbInvoice_ASP_AgentParty_WebsiteURI,
            this.tbInvoice_ASP_AgentParty_Contact_Telephone,
            this.tbInvoice_ASP_AgentParty_Contact_Telefax,
            this.tbInvoice_ASP_AgentParty_Contact_ElectronicMail,
            this.tbInvoice_ASP_AgentParty_Person_FirstName,
            this.tbInvoice_ASP_AgentParty_Person_FamilyName,
            this.tbInvoice_ASP_AgentParty_Person_MiddleName,
            this.tbInvoice_ASP_AgentParty_Person_NameSuffix,
            this.tbInvoice_ASP_AgentParty_Person_Title,
            this.tbInvoice_ACP_PartyIdentification1_schemeID,
            this.tbInvoice_ACP_PartyIdentification1_ID,
            this.tbInvoice_ACP_PartyIdentification2_schemeID,
            this.tbInvoice_ACP_PartyIdentification2_ID,
            this.tbInvoice_ACP_PartyIdentification3_schemeID,
            this.tbInvoice_ACP_PartyIdentification3_ID,
            this.tbInvoice_ACP_PartyIdentification4_schemeID,
            this.tbInvoice_ACP_PartyIdentification4_ID,
            this.tbInvoice_ACP_PartyIdentification5_schemeID,
            this.tbInvoice_ACP_PartyIdentification5_ID,
            this.tbInvoice_ACP_PartyName,
            this.tbInvoice_ACP_PostalAddress_StreetName,
            this.tbInvoice_ACP_PostalAddress_Room,
            this.tbInvoice_ACP_PostalAddress_BuildingNumber,
            this.tbInvoice_ACP_PostalAddress_BuildingName,
            this.tbInvoice_ACP_PostalAddress_CitySubdivisionName,
            this.tbInvoice_ACP_PostalAddress_CityName,
            this.tbInvoice_ACP_PostalAddress_Country,
            this.tbInvoice_ACP_PartyTaxSchemeName,
            this.tbInvoice_ACP_PartyTaxSchemeTaxTypeCode,
            this.tbInvoice_ACP_WebsiteURI,
            this.tbInvoice_ACP_Contact_Telephone,
            this.tbInvoice_ACP_Contact_Telefax,
            this.tbInvoice_ACP_Contact_ElectronicMail,
            this.tbInvoice_ACP_Person_FirstName,
            this.tbInvoice_ACP_Person_FamilyName,
            this.tbInvoice_ACP_Person_MiddleName,
            this.tbInvoice_ACP_Person_NameSuffix,
            this.tbInvoice_ACP_Person_Title,
            this.tbInvoice_ACP_AgentParty_PartyIdentification1_schemeID,
            this.tbInvoice_ACP_AgentParty_PartyIdentification1_ID,
            this.tbInvoice_ACP_AgentParty_PartyIdentification2_schemeID,
            this.tbInvoice_ACP_AgentParty_PartyIdentification2_ID,
            this.tbInvoice_ACP_AgentParty_PartyIdentification3_schemeID,
            this.tbInvoice_ACP_AgentParty_PartyIdentification3_ID,
            this.tbInvoice_ACP_AgentParty_PartyIdentification4_schemeID,
            this.tbInvoice_ACP_AgentParty_PartyIdentification4_ID,
            this.tbInvoice_ACP_AgentParty_PartyIdentification5_schemeID,
            this.tbInvoice_ACP_AgentParty_PartyIdentification5_ID,
            this.tbInvoice_ACP_AgentParty_PartyName,
            this.tbInvoice_ACP_AgentParty_PostalAddress_StreetName,
            this.tbInvoice_ACP_AgentParty_PostalAddress_Room,
            this.tbInvoice_ACP_AgentParty_PostalAddress_BuildingNumber,
            this.tbInvoice_ACP_AgentParty_PostalAddress_BuildingName,
            this.tbInvoice_ACP_AgentParty_PostalAddress_CitySubdivisionName,
            this.tbInvoice_ACP_AgentParty_PostalAddress_CityName,
            this.tbInvoice_ACP_AgentParty_PostalAddress_Country,
            this.tbInvoice_ACP_AgentParty_PartyTaxSchemeName,
            this.tbInvoice_ACP_AgentParty_PartyTaxSchemeTaxTypeCode,
            this.tbInvoice_ACP_AgentParty_WebsiteURI,
            this.tbInvoice_ACP_AgentParty_Contact_Telephone,
            this.tbInvoice_ACP_AgentParty_Contact_Telefax,
            this.tbInvoice_ACP_AgentParty_Contact_ElectronicMail,
            this.tbInvoice_ACP_AgentParty_Person_FirstName,
            this.tbInvoice_ACP_AgentParty_Person_FamilyName,
            this.tbInvoice_ACP_AgentParty_Person_MiddleName,
            this.tbInvoice_ACP_AgentParty_Person_NameSuffix,
            this.tbInvoice_ACP_AgentParty_Person_Title,
            this.tbInvoice_TaxExchangeRate_SourceCurrencyCode,
            this.tbInvoice_TaxExchangeRate_TargetCurrencyCode,
            this.tbInvoice_TaxExchangeRate_CalculationRate,
            this.tbInvoice_TaxExchangeRate_Date,
            this.tbInvoice_PricingExchangeRate_SourceCurrencyCode,
            this.tbInvoice_PricingExchangeRate_TargetCurrencyCode,
            this.tbInvoice_PricingExchangeRate_CalculationRate,
            this.tbInvoice_PricingExchangeRate_Date,
            this.tbInvoice_PaymentExchangeRate_SourceCurrencyCode,
            this.tbInvoice_PaymentExchangeRate_TargetCurrencyCode,
            this.tbInvoice_PaymentExchangeRate_CalculationRate,
            this.tbInvoice_PaymentExchangeRate_Date,
            this.tbInvoice_PaymentAlternativeExchangeRate_SourceCurrencyCode,
            this.tbInvoice_PaymentAlternativeExchangeRate_TargetCurrencyCode,
            this.tbInvoice_PaymentAlternativeExchangeRate_CalculationRate,
            this.tbInvoice_PaymentAlternativeExchangeRate_Date,
            this.tbInvoice_TaxAmount,
            this.tbInvoice_LegalMonetaryTotal_LineExtensionAmount,
            this.tbInvoice_LegalMonetaryTotal_TaxExclusiveAmount,
            this.tbInvoice_LegalMonetaryTotal_TaxInclusiveAmount,
            this.tbInvoice_LegalMonetaryTotal_AllowanceTotalAmount,
            this.tbInvoice_LegalMonetaryTotal_ChargeTotalAmount,
            this.tbInvoice_LegalMonetaryTotal_PayableRoundingAmount,
            this.tbInvoice_LegalMonetaryTotal_PayableAmount});
            this.tbInvoice.Connection = this.FirmConn;
            this.tbInvoice.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "InvoiceID"}, true)});
            this.tbInvoice.CurrentRow = null;
            this.tbInvoice.DataSourceLink = null;
            this.tbInvoice.DeleteCommand = this.sqlCommand4;
            this.tbInvoice.Filter = "";
            this.tbInvoice.InsertCommand = this.sqlCommand2;
            this.tbInvoice.LiveSave = false;
            this.tbInvoice.MaxRecords = ((long)(0));
            this.tbInvoice.Name = "tbInvoice";
            this.tbInvoice.ParentRelation_ChildColumns = null;
            this.tbInvoice.ParentRelation_ParentColumns = null;
            this.tbInvoice.ParentRelation_Table = null;
            this.tbInvoice.Position = ((long)(-1));
            this.tbInvoice.PrimaryKey = new System.Data.DataColumn[] {
        this.tbInvoice_InvoiceID};
            this.tbInvoice.Quoted = false;
            this.tbInvoice.SelectCommand = this.sqlCommand1;
            this.tbInvoice.TableName = "neoTable1";
            this.tbInvoice.Transaction = null;
            this.tbInvoice.UpdateCommand = this.sqlCommand3;
            this.tbInvoice.ColumnChanged += new System.Data.DataColumnChangeEventHandler(this.tbInvoice_ColumnChanged);
            // 
            // tbInvoice_InvoiceID
            // 
            this.tbInvoice_InvoiceID.AllowDBNull = false;
            this.tbInvoice_InvoiceID.AutoIncrement = true;
            this.tbInvoice_InvoiceID.ColumnName = "InvoiceID";
            this.tbInvoice_InvoiceID.DataType = typeof(int);
            // 
            // tbInvoice_Deleted
            // 
            this.tbInvoice_Deleted.ColumnName = "Deleted";
            this.tbInvoice_Deleted.DataType = typeof(int);
            // 
            // tbInvoice_CreatedBy
            // 
            this.tbInvoice_CreatedBy.ColumnName = "CreatedBy";
            this.tbInvoice_CreatedBy.DataType = typeof(int);
            // 
            // tbInvoice_CreatedDate
            // 
            this.tbInvoice_CreatedDate.ColumnName = "CreatedDate";
            this.tbInvoice_CreatedDate.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_ModifiedBy
            // 
            this.tbInvoice_ModifiedBy.ColumnName = "ModifiedBy";
            this.tbInvoice_ModifiedBy.DataType = typeof(int);
            // 
            // tbInvoice_ModifiedDate
            // 
            this.tbInvoice_ModifiedDate.ColumnName = "ModifiedDate";
            this.tbInvoice_ModifiedDate.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_IOType
            // 
            this.tbInvoice_IOType.ColumnName = "IOType";
            this.tbInvoice_IOType.DataType = typeof(int);
            // 
            // tbInvoice_IntCode
            // 
            this.tbInvoice_IntCode.ColumnName = "IntCode";
            // 
            // tbInvoice_LocalStatus
            // 
            this.tbInvoice_LocalStatus.ColumnName = "LocalStatus";
            this.tbInvoice_LocalStatus.DataType = typeof(int);
            // 
            // tbInvoice_IntegratorID
            // 
            this.tbInvoice_IntegratorID.ColumnName = "IntegratorID";
            // 
            // tbInvoice_Status
            // 
            this.tbInvoice_Status.ColumnName = "Status";
            this.tbInvoice_Status.DataType = typeof(int);
            // 
            // tbInvoice_StatusDescription
            // 
            this.tbInvoice_StatusDescription.ColumnName = "StatusDescription";
            // 
            // tbInvoice_PostBox
            // 
            this.tbInvoice_PostBox.ColumnName = "PostBox";
            // 
            // tbInvoice_XsltNo
            // 
            this.tbInvoice_XsltNo.ColumnName = "XsltNo";
            this.tbInvoice_XsltNo.DataType = typeof(int);
            // 
            // tbInvoice_ProfileID
            // 
            this.tbInvoice_ProfileID.ColumnName = "ProfileID";
            // 
            // tbInvoice_ID
            // 
            this.tbInvoice_ID.ColumnName = "ID";
            // 
            // tbInvoice_UUID
            // 
            this.tbInvoice_UUID.ColumnName = "UUID";
            // 
            // tbInvoice_IssueDate
            // 
            this.tbInvoice_IssueDate.ColumnName = "IssueDate";
            this.tbInvoice_IssueDate.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_IssueTime
            // 
            this.tbInvoice_IssueTime.ColumnName = "IssueTime";
            this.tbInvoice_IssueTime.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_InvoiceTypeCode
            // 
            this.tbInvoice_InvoiceTypeCode.ColumnName = "InvoiceTypeCode";
            // 
            // tbInvoice_DocumentCurrencyCode
            // 
            this.tbInvoice_DocumentCurrencyCode.ColumnName = "DocumentCurrencyCode";
            // 
            // tbInvoice_TaxCurrencyCode
            // 
            this.tbInvoice_TaxCurrencyCode.ColumnName = "TaxCurrencyCode";
            // 
            // tbInvoice_PricingCurrencyCode
            // 
            this.tbInvoice_PricingCurrencyCode.ColumnName = "PricingCurrencyCode";
            // 
            // tbInvoice_PaymentCurrencyCode
            // 
            this.tbInvoice_PaymentCurrencyCode.ColumnName = "PaymentCurrencyCode";
            // 
            // tbInvoice_PaymentAlternativeCurrencyCode
            // 
            this.tbInvoice_PaymentAlternativeCurrencyCode.ColumnName = "PaymentAlternativeCurrencyCode";
            // 
            // tbInvoice_LineCountNumeric
            // 
            this.tbInvoice_LineCountNumeric.ColumnName = "LineCountNumeric";
            this.tbInvoice_LineCountNumeric.DataType = typeof(int);
            // 
            // tbInvoice_InvoicePeriod_StartDate
            // 
            this.tbInvoice_InvoicePeriod_StartDate.ColumnName = "InvoicePeriod_StartDate";
            this.tbInvoice_InvoicePeriod_StartDate.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_InvoicePeriod_EndDate
            // 
            this.tbInvoice_InvoicePeriod_EndDate.ColumnName = "InvoicePeriod_EndDate";
            this.tbInvoice_InvoicePeriod_EndDate.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_ASP_PartyIdentification1_schemeID
            // 
            this.tbInvoice_ASP_PartyIdentification1_schemeID.ColumnName = "ASP_PartyIdentification1_schemeID";
            // 
            // tbInvoice_ASP_PartyIdentification1_ID
            // 
            this.tbInvoice_ASP_PartyIdentification1_ID.ColumnName = "ASP_PartyIdentification1_ID";
            // 
            // tbInvoice_ASP_PartyIdentification2_schemeID
            // 
            this.tbInvoice_ASP_PartyIdentification2_schemeID.ColumnName = "ASP_PartyIdentification2_schemeID";
            // 
            // tbInvoice_ASP_PartyIdentification2_ID
            // 
            this.tbInvoice_ASP_PartyIdentification2_ID.ColumnName = "ASP_PartyIdentification2_ID";
            // 
            // tbInvoice_ASP_PartyIdentification3_schemeID
            // 
            this.tbInvoice_ASP_PartyIdentification3_schemeID.ColumnName = "ASP_PartyIdentification3_schemeID";
            // 
            // tbInvoice_ASP_PartyIdentification3_ID
            // 
            this.tbInvoice_ASP_PartyIdentification3_ID.ColumnName = "ASP_PartyIdentification3_ID";
            // 
            // tbInvoice_ASP_PartyIdentification4_schemeID
            // 
            this.tbInvoice_ASP_PartyIdentification4_schemeID.ColumnName = "ASP_PartyIdentification4_schemeID";
            // 
            // tbInvoice_ASP_PartyIdentification4_ID
            // 
            this.tbInvoice_ASP_PartyIdentification4_ID.ColumnName = "ASP_PartyIdentification4_ID";
            // 
            // tbInvoice_ASP_PartyIdentification5_schemeID
            // 
            this.tbInvoice_ASP_PartyIdentification5_schemeID.ColumnName = "ASP_PartyIdentification5_schemeID";
            // 
            // tbInvoice_ASP_PartyIdentification5_ID
            // 
            this.tbInvoice_ASP_PartyIdentification5_ID.ColumnName = "ASP_PartyIdentification5_ID";
            // 
            // tbInvoice_ASP_PartyName
            // 
            this.tbInvoice_ASP_PartyName.ColumnName = "ASP_PartyName";
            // 
            // tbInvoice_ASP_PostalAddress_StreetName
            // 
            this.tbInvoice_ASP_PostalAddress_StreetName.ColumnName = "ASP_PostalAddress_StreetName";
            // 
            // tbInvoice_ASP_PostalAddress_Room
            // 
            this.tbInvoice_ASP_PostalAddress_Room.ColumnName = "ASP_PostalAddress_Room";
            // 
            // tbInvoice_ASP_PostalAddress_BuildingNumber
            // 
            this.tbInvoice_ASP_PostalAddress_BuildingNumber.ColumnName = "ASP_PostalAddress_BuildingNumber";
            // 
            // tbInvoice_ASP_PostalAddress_BuildingName
            // 
            this.tbInvoice_ASP_PostalAddress_BuildingName.ColumnName = "ASP_PostalAddress_BuildingName";
            // 
            // tbInvoice_ASP_PostalAddress_CitySubdivisionName
            // 
            this.tbInvoice_ASP_PostalAddress_CitySubdivisionName.ColumnName = "ASP_PostalAddress_CitySubdivisionName";
            // 
            // tbInvoice_ASP_PostalAddress_CityName
            // 
            this.tbInvoice_ASP_PostalAddress_CityName.ColumnName = "ASP_PostalAddress_CityName";
            // 
            // tbInvoice_ASP_PostalAddress_Country
            // 
            this.tbInvoice_ASP_PostalAddress_Country.ColumnName = "ASP_PostalAddress_Country";
            // 
            // tbInvoice_ASP_PartyTaxSchemeName
            // 
            this.tbInvoice_ASP_PartyTaxSchemeName.ColumnName = "ASP_PartyTaxSchemeName";
            // 
            // tbInvoice_ASP_PartyTaxSchemeTaxTypeCode
            // 
            this.tbInvoice_ASP_PartyTaxSchemeTaxTypeCode.ColumnName = "ASP_PartyTaxSchemeTaxTypeCode";
            // 
            // tbInvoice_ASP_WebsiteURI
            // 
            this.tbInvoice_ASP_WebsiteURI.ColumnName = "ASP_WebsiteURI";
            // 
            // tbInvoice_ASP_Contact_Telephone
            // 
            this.tbInvoice_ASP_Contact_Telephone.ColumnName = "ASP_Contact_Telephone";
            // 
            // tbInvoice_ASP_Contact_Telefax
            // 
            this.tbInvoice_ASP_Contact_Telefax.ColumnName = "ASP_Contact_Telefax";
            // 
            // tbInvoice_ASP_Contact_ElectronicMail
            // 
            this.tbInvoice_ASP_Contact_ElectronicMail.ColumnName = "ASP_Contact_ElectronicMail";
            // 
            // tbInvoice_ASP_Person_FirstName
            // 
            this.tbInvoice_ASP_Person_FirstName.ColumnName = "ASP_Person_FirstName";
            // 
            // tbInvoice_ASP_Person_FamilyName
            // 
            this.tbInvoice_ASP_Person_FamilyName.ColumnName = "ASP_Person_FamilyName";
            // 
            // tbInvoice_ASP_Person_MiddleName
            // 
            this.tbInvoice_ASP_Person_MiddleName.ColumnName = "ASP_Person_MiddleName";
            // 
            // tbInvoice_ASP_Person_NameSuffix
            // 
            this.tbInvoice_ASP_Person_NameSuffix.ColumnName = "ASP_Person_NameSuffix";
            // 
            // tbInvoice_ASP_Person_Title
            // 
            this.tbInvoice_ASP_Person_Title.ColumnName = "ASP_Person_Title";
            // 
            // tbInvoice_ASP_AgentParty_PartyIdentification1_schemeID
            // 
            this.tbInvoice_ASP_AgentParty_PartyIdentification1_schemeID.ColumnName = "ASP_AgentParty_PartyIdentification1_schemeID";
            // 
            // tbInvoice_ASP_AgentParty_PartyIdentification1_ID
            // 
            this.tbInvoice_ASP_AgentParty_PartyIdentification1_ID.ColumnName = "ASP_AgentParty_PartyIdentification1_ID";
            // 
            // tbInvoice_ASP_AgentParty_PartyIdentification2_schemeID
            // 
            this.tbInvoice_ASP_AgentParty_PartyIdentification2_schemeID.ColumnName = "ASP_AgentParty_PartyIdentification2_schemeID";
            // 
            // tbInvoice_ASP_AgentParty_PartyIdentification2_ID
            // 
            this.tbInvoice_ASP_AgentParty_PartyIdentification2_ID.ColumnName = "ASP_AgentParty_PartyIdentification2_ID";
            // 
            // tbInvoice_ASP_AgentParty_PartyIdentification3_schemeID
            // 
            this.tbInvoice_ASP_AgentParty_PartyIdentification3_schemeID.ColumnName = "ASP_AgentParty_PartyIdentification3_schemeID";
            // 
            // tbInvoice_ASP_AgentParty_PartyIdentification3_ID
            // 
            this.tbInvoice_ASP_AgentParty_PartyIdentification3_ID.ColumnName = "ASP_AgentParty_PartyIdentification3_ID";
            // 
            // tbInvoice_ASP_AgentParty_PartyIdentification4_schemeID
            // 
            this.tbInvoice_ASP_AgentParty_PartyIdentification4_schemeID.ColumnName = "ASP_AgentParty_PartyIdentification4_schemeID";
            // 
            // tbInvoice_ASP_AgentParty_PartyIdentification4_ID
            // 
            this.tbInvoice_ASP_AgentParty_PartyIdentification4_ID.ColumnName = "ASP_AgentParty_PartyIdentification4_ID";
            // 
            // tbInvoice_ASP_AgentParty_PartyIdentification5_schemeID
            // 
            this.tbInvoice_ASP_AgentParty_PartyIdentification5_schemeID.ColumnName = "ASP_AgentParty_PartyIdentification5_schemeID";
            // 
            // tbInvoice_ASP_AgentParty_PartyIdentification5_ID
            // 
            this.tbInvoice_ASP_AgentParty_PartyIdentification5_ID.ColumnName = "ASP_AgentParty_PartyIdentification5_ID";
            // 
            // tbInvoice_ASP_AgentParty_PartyName
            // 
            this.tbInvoice_ASP_AgentParty_PartyName.ColumnName = "ASP_AgentParty_PartyName";
            // 
            // tbInvoice_ASP_AgentParty_PostalAddress_StreetName
            // 
            this.tbInvoice_ASP_AgentParty_PostalAddress_StreetName.ColumnName = "ASP_AgentParty_PostalAddress_StreetName";
            // 
            // tbInvoice_ASP_AgentParty_PostalAddress_Room
            // 
            this.tbInvoice_ASP_AgentParty_PostalAddress_Room.ColumnName = "ASP_AgentParty_PostalAddress_Room";
            // 
            // tbInvoice_ASP_AgentParty_PostalAddress_BuildingNumber
            // 
            this.tbInvoice_ASP_AgentParty_PostalAddress_BuildingNumber.ColumnName = "ASP_AgentParty_PostalAddress_BuildingNumber";
            // 
            // tbInvoice_ASP_AgentParty_PostalAddress_BuildingName
            // 
            this.tbInvoice_ASP_AgentParty_PostalAddress_BuildingName.ColumnName = "ASP_AgentParty_PostalAddress_BuildingName";
            // 
            // tbInvoice_ASP_AgentParty_PostalAddress_CitySubdivisionName
            // 
            this.tbInvoice_ASP_AgentParty_PostalAddress_CitySubdivisionName.ColumnName = "ASP_AgentParty_PostalAddress_CitySubdivisionName";
            // 
            // tbInvoice_ASP_AgentParty_PostalAddress_CityName
            // 
            this.tbInvoice_ASP_AgentParty_PostalAddress_CityName.ColumnName = "ASP_AgentParty_PostalAddress_CityName";
            // 
            // tbInvoice_ASP_AgentParty_PostalAddress_Country
            // 
            this.tbInvoice_ASP_AgentParty_PostalAddress_Country.ColumnName = "ASP_AgentParty_PostalAddress_Country";
            // 
            // tbInvoice_ASP_AgentParty_PartyTaxSchemeName
            // 
            this.tbInvoice_ASP_AgentParty_PartyTaxSchemeName.ColumnName = "ASP_AgentParty_PartyTaxSchemeName";
            // 
            // tbInvoice_ASP_AgentParty_PartyTaxSchemeTaxTypeCode
            // 
            this.tbInvoice_ASP_AgentParty_PartyTaxSchemeTaxTypeCode.ColumnName = "ASP_AgentParty_PartyTaxSchemeTaxTypeCode";
            // 
            // tbInvoice_ASP_AgentParty_WebsiteURI
            // 
            this.tbInvoice_ASP_AgentParty_WebsiteURI.ColumnName = "ASP_AgentParty_WebsiteURI";
            // 
            // tbInvoice_ASP_AgentParty_Contact_Telephone
            // 
            this.tbInvoice_ASP_AgentParty_Contact_Telephone.ColumnName = "ASP_AgentParty_Contact_Telephone";
            // 
            // tbInvoice_ASP_AgentParty_Contact_Telefax
            // 
            this.tbInvoice_ASP_AgentParty_Contact_Telefax.ColumnName = "ASP_AgentParty_Contact_Telefax";
            // 
            // tbInvoice_ASP_AgentParty_Contact_ElectronicMail
            // 
            this.tbInvoice_ASP_AgentParty_Contact_ElectronicMail.ColumnName = "ASP_AgentParty_Contact_ElectronicMail";
            // 
            // tbInvoice_ASP_AgentParty_Person_FirstName
            // 
            this.tbInvoice_ASP_AgentParty_Person_FirstName.ColumnName = "ASP_AgentParty_Person_FirstName";
            // 
            // tbInvoice_ASP_AgentParty_Person_FamilyName
            // 
            this.tbInvoice_ASP_AgentParty_Person_FamilyName.ColumnName = "ASP_AgentParty_Person_FamilyName";
            // 
            // tbInvoice_ASP_AgentParty_Person_MiddleName
            // 
            this.tbInvoice_ASP_AgentParty_Person_MiddleName.ColumnName = "ASP_AgentParty_Person_MiddleName";
            // 
            // tbInvoice_ASP_AgentParty_Person_NameSuffix
            // 
            this.tbInvoice_ASP_AgentParty_Person_NameSuffix.ColumnName = "ASP_AgentParty_Person_NameSuffix";
            // 
            // tbInvoice_ASP_AgentParty_Person_Title
            // 
            this.tbInvoice_ASP_AgentParty_Person_Title.ColumnName = "ASP_AgentParty_Person_Title";
            // 
            // tbInvoice_ACP_PartyIdentification1_schemeID
            // 
            this.tbInvoice_ACP_PartyIdentification1_schemeID.ColumnName = "ACP_PartyIdentification1_schemeID";
            // 
            // tbInvoice_ACP_PartyIdentification1_ID
            // 
            this.tbInvoice_ACP_PartyIdentification1_ID.ColumnName = "ACP_PartyIdentification1_ID";
            // 
            // tbInvoice_ACP_PartyIdentification2_schemeID
            // 
            this.tbInvoice_ACP_PartyIdentification2_schemeID.ColumnName = "ACP_PartyIdentification2_schemeID";
            // 
            // tbInvoice_ACP_PartyIdentification2_ID
            // 
            this.tbInvoice_ACP_PartyIdentification2_ID.ColumnName = "ACP_PartyIdentification2_ID";
            // 
            // tbInvoice_ACP_PartyIdentification3_schemeID
            // 
            this.tbInvoice_ACP_PartyIdentification3_schemeID.ColumnName = "ACP_PartyIdentification3_schemeID";
            // 
            // tbInvoice_ACP_PartyIdentification3_ID
            // 
            this.tbInvoice_ACP_PartyIdentification3_ID.ColumnName = "ACP_PartyIdentification3_ID";
            // 
            // tbInvoice_ACP_PartyIdentification4_schemeID
            // 
            this.tbInvoice_ACP_PartyIdentification4_schemeID.ColumnName = "ACP_PartyIdentification4_schemeID";
            // 
            // tbInvoice_ACP_PartyIdentification4_ID
            // 
            this.tbInvoice_ACP_PartyIdentification4_ID.ColumnName = "ACP_PartyIdentification4_ID";
            // 
            // tbInvoice_ACP_PartyIdentification5_schemeID
            // 
            this.tbInvoice_ACP_PartyIdentification5_schemeID.ColumnName = "ACP_PartyIdentification5_schemeID";
            // 
            // tbInvoice_ACP_PartyIdentification5_ID
            // 
            this.tbInvoice_ACP_PartyIdentification5_ID.ColumnName = "ACP_PartyIdentification5_ID";
            // 
            // tbInvoice_ACP_PartyName
            // 
            this.tbInvoice_ACP_PartyName.ColumnName = "ACP_PartyName";
            // 
            // tbInvoice_ACP_PostalAddress_StreetName
            // 
            this.tbInvoice_ACP_PostalAddress_StreetName.ColumnName = "ACP_PostalAddress_StreetName";
            // 
            // tbInvoice_ACP_PostalAddress_Room
            // 
            this.tbInvoice_ACP_PostalAddress_Room.ColumnName = "ACP_PostalAddress_Room";
            // 
            // tbInvoice_ACP_PostalAddress_BuildingNumber
            // 
            this.tbInvoice_ACP_PostalAddress_BuildingNumber.ColumnName = "ACP_PostalAddress_BuildingNumber";
            // 
            // tbInvoice_ACP_PostalAddress_BuildingName
            // 
            this.tbInvoice_ACP_PostalAddress_BuildingName.ColumnName = "ACP_PostalAddress_BuildingName";
            // 
            // tbInvoice_ACP_PostalAddress_CitySubdivisionName
            // 
            this.tbInvoice_ACP_PostalAddress_CitySubdivisionName.ColumnName = "ACP_PostalAddress_CitySubdivisionName";
            // 
            // tbInvoice_ACP_PostalAddress_CityName
            // 
            this.tbInvoice_ACP_PostalAddress_CityName.ColumnName = "ACP_PostalAddress_CityName";
            // 
            // tbInvoice_ACP_PostalAddress_Country
            // 
            this.tbInvoice_ACP_PostalAddress_Country.ColumnName = "ACP_PostalAddress_Country";
            // 
            // tbInvoice_ACP_PartyTaxSchemeName
            // 
            this.tbInvoice_ACP_PartyTaxSchemeName.ColumnName = "ACP_PartyTaxSchemeName";
            // 
            // tbInvoice_ACP_PartyTaxSchemeTaxTypeCode
            // 
            this.tbInvoice_ACP_PartyTaxSchemeTaxTypeCode.ColumnName = "ACP_PartyTaxSchemeTaxTypeCode";
            // 
            // tbInvoice_ACP_WebsiteURI
            // 
            this.tbInvoice_ACP_WebsiteURI.ColumnName = "ACP_WebsiteURI";
            // 
            // tbInvoice_ACP_Contact_Telephone
            // 
            this.tbInvoice_ACP_Contact_Telephone.ColumnName = "ACP_Contact_Telephone";
            // 
            // tbInvoice_ACP_Contact_Telefax
            // 
            this.tbInvoice_ACP_Contact_Telefax.ColumnName = "ACP_Contact_Telefax";
            // 
            // tbInvoice_ACP_Contact_ElectronicMail
            // 
            this.tbInvoice_ACP_Contact_ElectronicMail.ColumnName = "ACP_Contact_ElectronicMail";
            // 
            // tbInvoice_ACP_Person_FirstName
            // 
            this.tbInvoice_ACP_Person_FirstName.ColumnName = "ACP_Person_FirstName";
            // 
            // tbInvoice_ACP_Person_FamilyName
            // 
            this.tbInvoice_ACP_Person_FamilyName.ColumnName = "ACP_Person_FamilyName";
            // 
            // tbInvoice_ACP_Person_MiddleName
            // 
            this.tbInvoice_ACP_Person_MiddleName.ColumnName = "ACP_Person_MiddleName";
            // 
            // tbInvoice_ACP_Person_NameSuffix
            // 
            this.tbInvoice_ACP_Person_NameSuffix.ColumnName = "ACP_Person_NameSuffix";
            // 
            // tbInvoice_ACP_Person_Title
            // 
            this.tbInvoice_ACP_Person_Title.ColumnName = "ACP_Person_Title";
            // 
            // tbInvoice_ACP_AgentParty_PartyIdentification1_schemeID
            // 
            this.tbInvoice_ACP_AgentParty_PartyIdentification1_schemeID.ColumnName = "ACP_AgentParty_PartyIdentification1_schemeID";
            // 
            // tbInvoice_ACP_AgentParty_PartyIdentification1_ID
            // 
            this.tbInvoice_ACP_AgentParty_PartyIdentification1_ID.ColumnName = "ACP_AgentParty_PartyIdentification1_ID";
            // 
            // tbInvoice_ACP_AgentParty_PartyIdentification2_schemeID
            // 
            this.tbInvoice_ACP_AgentParty_PartyIdentification2_schemeID.ColumnName = "ACP_AgentParty_PartyIdentification2_schemeID";
            // 
            // tbInvoice_ACP_AgentParty_PartyIdentification2_ID
            // 
            this.tbInvoice_ACP_AgentParty_PartyIdentification2_ID.ColumnName = "ACP_AgentParty_PartyIdentification2_ID";
            // 
            // tbInvoice_ACP_AgentParty_PartyIdentification3_schemeID
            // 
            this.tbInvoice_ACP_AgentParty_PartyIdentification3_schemeID.ColumnName = "ACP_AgentParty_PartyIdentification3_schemeID";
            // 
            // tbInvoice_ACP_AgentParty_PartyIdentification3_ID
            // 
            this.tbInvoice_ACP_AgentParty_PartyIdentification3_ID.ColumnName = "ACP_AgentParty_PartyIdentification3_ID";
            // 
            // tbInvoice_ACP_AgentParty_PartyIdentification4_schemeID
            // 
            this.tbInvoice_ACP_AgentParty_PartyIdentification4_schemeID.ColumnName = "ACP_AgentParty_PartyIdentification4_schemeID";
            // 
            // tbInvoice_ACP_AgentParty_PartyIdentification4_ID
            // 
            this.tbInvoice_ACP_AgentParty_PartyIdentification4_ID.ColumnName = "ACP_AgentParty_PartyIdentification4_ID";
            // 
            // tbInvoice_ACP_AgentParty_PartyIdentification5_schemeID
            // 
            this.tbInvoice_ACP_AgentParty_PartyIdentification5_schemeID.ColumnName = "ACP_AgentParty_PartyIdentification5_schemeID";
            // 
            // tbInvoice_ACP_AgentParty_PartyIdentification5_ID
            // 
            this.tbInvoice_ACP_AgentParty_PartyIdentification5_ID.ColumnName = "ACP_AgentParty_PartyIdentification5_ID";
            // 
            // tbInvoice_ACP_AgentParty_PartyName
            // 
            this.tbInvoice_ACP_AgentParty_PartyName.ColumnName = "ACP_AgentParty_PartyName";
            // 
            // tbInvoice_ACP_AgentParty_PostalAddress_StreetName
            // 
            this.tbInvoice_ACP_AgentParty_PostalAddress_StreetName.ColumnName = "ACP_AgentParty_PostalAddress_StreetName";
            // 
            // tbInvoice_ACP_AgentParty_PostalAddress_Room
            // 
            this.tbInvoice_ACP_AgentParty_PostalAddress_Room.ColumnName = "ACP_AgentParty_PostalAddress_Room";
            // 
            // tbInvoice_ACP_AgentParty_PostalAddress_BuildingNumber
            // 
            this.tbInvoice_ACP_AgentParty_PostalAddress_BuildingNumber.ColumnName = "ACP_AgentParty_PostalAddress_BuildingNumber";
            // 
            // tbInvoice_ACP_AgentParty_PostalAddress_BuildingName
            // 
            this.tbInvoice_ACP_AgentParty_PostalAddress_BuildingName.ColumnName = "ACP_AgentParty_PostalAddress_BuildingName";
            // 
            // tbInvoice_ACP_AgentParty_PostalAddress_CitySubdivisionName
            // 
            this.tbInvoice_ACP_AgentParty_PostalAddress_CitySubdivisionName.ColumnName = "ACP_AgentParty_PostalAddress_CitySubdivisionName";
            // 
            // tbInvoice_ACP_AgentParty_PostalAddress_CityName
            // 
            this.tbInvoice_ACP_AgentParty_PostalAddress_CityName.ColumnName = "ACP_AgentParty_PostalAddress_CityName";
            // 
            // tbInvoice_ACP_AgentParty_PostalAddress_Country
            // 
            this.tbInvoice_ACP_AgentParty_PostalAddress_Country.ColumnName = "ACP_AgentParty_PostalAddress_Country";
            // 
            // tbInvoice_ACP_AgentParty_PartyTaxSchemeName
            // 
            this.tbInvoice_ACP_AgentParty_PartyTaxSchemeName.ColumnName = "ACP_AgentParty_PartyTaxSchemeName";
            // 
            // tbInvoice_ACP_AgentParty_PartyTaxSchemeTaxTypeCode
            // 
            this.tbInvoice_ACP_AgentParty_PartyTaxSchemeTaxTypeCode.ColumnName = "ACP_AgentParty_PartyTaxSchemeTaxTypeCode";
            // 
            // tbInvoice_ACP_AgentParty_WebsiteURI
            // 
            this.tbInvoice_ACP_AgentParty_WebsiteURI.ColumnName = "ACP_AgentParty_WebsiteURI";
            // 
            // tbInvoice_ACP_AgentParty_Contact_Telephone
            // 
            this.tbInvoice_ACP_AgentParty_Contact_Telephone.ColumnName = "ACP_AgentParty_Contact_Telephone";
            // 
            // tbInvoice_ACP_AgentParty_Contact_Telefax
            // 
            this.tbInvoice_ACP_AgentParty_Contact_Telefax.ColumnName = "ACP_AgentParty_Contact_Telefax";
            // 
            // tbInvoice_ACP_AgentParty_Contact_ElectronicMail
            // 
            this.tbInvoice_ACP_AgentParty_Contact_ElectronicMail.ColumnName = "ACP_AgentParty_Contact_ElectronicMail";
            // 
            // tbInvoice_ACP_AgentParty_Person_FirstName
            // 
            this.tbInvoice_ACP_AgentParty_Person_FirstName.ColumnName = "ACP_AgentParty_Person_FirstName";
            // 
            // tbInvoice_ACP_AgentParty_Person_FamilyName
            // 
            this.tbInvoice_ACP_AgentParty_Person_FamilyName.ColumnName = "ACP_AgentParty_Person_FamilyName";
            // 
            // tbInvoice_ACP_AgentParty_Person_MiddleName
            // 
            this.tbInvoice_ACP_AgentParty_Person_MiddleName.ColumnName = "ACP_AgentParty_Person_MiddleName";
            // 
            // tbInvoice_ACP_AgentParty_Person_NameSuffix
            // 
            this.tbInvoice_ACP_AgentParty_Person_NameSuffix.ColumnName = "ACP_AgentParty_Person_NameSuffix";
            // 
            // tbInvoice_ACP_AgentParty_Person_Title
            // 
            this.tbInvoice_ACP_AgentParty_Person_Title.ColumnName = "ACP_AgentParty_Person_Title";
            // 
            // tbInvoice_TaxExchangeRate_SourceCurrencyCode
            // 
            this.tbInvoice_TaxExchangeRate_SourceCurrencyCode.ColumnName = "TaxExchangeRate_SourceCurrencyCode";
            // 
            // tbInvoice_TaxExchangeRate_TargetCurrencyCode
            // 
            this.tbInvoice_TaxExchangeRate_TargetCurrencyCode.ColumnName = "TaxExchangeRate_TargetCurrencyCode";
            // 
            // tbInvoice_TaxExchangeRate_CalculationRate
            // 
            this.tbInvoice_TaxExchangeRate_CalculationRate.ColumnName = "TaxExchangeRate_CalculationRate";
            this.tbInvoice_TaxExchangeRate_CalculationRate.DataType = typeof(double);
            // 
            // tbInvoice_TaxExchangeRate_Date
            // 
            this.tbInvoice_TaxExchangeRate_Date.ColumnName = "TaxExchangeRate_Date";
            this.tbInvoice_TaxExchangeRate_Date.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_PricingExchangeRate_SourceCurrencyCode
            // 
            this.tbInvoice_PricingExchangeRate_SourceCurrencyCode.ColumnName = "PricingExchangeRate_SourceCurrencyCode";
            // 
            // tbInvoice_PricingExchangeRate_TargetCurrencyCode
            // 
            this.tbInvoice_PricingExchangeRate_TargetCurrencyCode.ColumnName = "PricingExchangeRate_TargetCurrencyCode";
            // 
            // tbInvoice_PricingExchangeRate_CalculationRate
            // 
            this.tbInvoice_PricingExchangeRate_CalculationRate.ColumnName = "PricingExchangeRate_CalculationRate";
            this.tbInvoice_PricingExchangeRate_CalculationRate.DataType = typeof(double);
            // 
            // tbInvoice_PricingExchangeRate_Date
            // 
            this.tbInvoice_PricingExchangeRate_Date.ColumnName = "PricingExchangeRate_Date";
            this.tbInvoice_PricingExchangeRate_Date.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_PaymentExchangeRate_SourceCurrencyCode
            // 
            this.tbInvoice_PaymentExchangeRate_SourceCurrencyCode.ColumnName = "PaymentExchangeRate_SourceCurrencyCode";
            // 
            // tbInvoice_PaymentExchangeRate_TargetCurrencyCode
            // 
            this.tbInvoice_PaymentExchangeRate_TargetCurrencyCode.ColumnName = "PaymentExchangeRate_TargetCurrencyCode";
            // 
            // tbInvoice_PaymentExchangeRate_CalculationRate
            // 
            this.tbInvoice_PaymentExchangeRate_CalculationRate.ColumnName = "PaymentExchangeRate_CalculationRate";
            this.tbInvoice_PaymentExchangeRate_CalculationRate.DataType = typeof(double);
            // 
            // tbInvoice_PaymentExchangeRate_Date
            // 
            this.tbInvoice_PaymentExchangeRate_Date.ColumnName = "PaymentExchangeRate_Date";
            this.tbInvoice_PaymentExchangeRate_Date.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_PaymentAlternativeExchangeRate_SourceCurrencyCode
            // 
            this.tbInvoice_PaymentAlternativeExchangeRate_SourceCurrencyCode.ColumnName = "PaymentAlternativeExchangeRate_SourceCurrencyCode";
            // 
            // tbInvoice_PaymentAlternativeExchangeRate_TargetCurrencyCode
            // 
            this.tbInvoice_PaymentAlternativeExchangeRate_TargetCurrencyCode.ColumnName = "PaymentAlternativeExchangeRate_TargetCurrencyCode";
            // 
            // tbInvoice_PaymentAlternativeExchangeRate_CalculationRate
            // 
            this.tbInvoice_PaymentAlternativeExchangeRate_CalculationRate.ColumnName = "PaymentAlternativeExchangeRate_CalculationRate";
            this.tbInvoice_PaymentAlternativeExchangeRate_CalculationRate.DataType = typeof(double);
            // 
            // tbInvoice_PaymentAlternativeExchangeRate_Date
            // 
            this.tbInvoice_PaymentAlternativeExchangeRate_Date.ColumnName = "PaymentAlternativeExchangeRate_Date";
            this.tbInvoice_PaymentAlternativeExchangeRate_Date.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_TaxAmount
            // 
            this.tbInvoice_TaxAmount.ColumnName = "TaxAmount";
            this.tbInvoice_TaxAmount.DataType = typeof(double);
            // 
            // tbInvoice_LegalMonetaryTotal_LineExtensionAmount
            // 
            this.tbInvoice_LegalMonetaryTotal_LineExtensionAmount.ColumnName = "LegalMonetaryTotal_LineExtensionAmount";
            this.tbInvoice_LegalMonetaryTotal_LineExtensionAmount.DataType = typeof(double);
            // 
            // tbInvoice_LegalMonetaryTotal_TaxExclusiveAmount
            // 
            this.tbInvoice_LegalMonetaryTotal_TaxExclusiveAmount.ColumnName = "LegalMonetaryTotal_TaxExclusiveAmount";
            this.tbInvoice_LegalMonetaryTotal_TaxExclusiveAmount.DataType = typeof(double);
            // 
            // tbInvoice_LegalMonetaryTotal_TaxInclusiveAmount
            // 
            this.tbInvoice_LegalMonetaryTotal_TaxInclusiveAmount.ColumnName = "LegalMonetaryTotal_TaxInclusiveAmount";
            this.tbInvoice_LegalMonetaryTotal_TaxInclusiveAmount.DataType = typeof(double);
            // 
            // tbInvoice_LegalMonetaryTotal_AllowanceTotalAmount
            // 
            this.tbInvoice_LegalMonetaryTotal_AllowanceTotalAmount.ColumnName = "LegalMonetaryTotal_AllowanceTotalAmount";
            this.tbInvoice_LegalMonetaryTotal_AllowanceTotalAmount.DataType = typeof(double);
            // 
            // tbInvoice_LegalMonetaryTotal_ChargeTotalAmount
            // 
            this.tbInvoice_LegalMonetaryTotal_ChargeTotalAmount.ColumnName = "LegalMonetaryTotal_ChargeTotalAmount";
            this.tbInvoice_LegalMonetaryTotal_ChargeTotalAmount.DataType = typeof(double);
            // 
            // tbInvoice_LegalMonetaryTotal_PayableRoundingAmount
            // 
            this.tbInvoice_LegalMonetaryTotal_PayableRoundingAmount.ColumnName = "LegalMonetaryTotal_PayableRoundingAmount";
            this.tbInvoice_LegalMonetaryTotal_PayableRoundingAmount.DataType = typeof(double);
            // 
            // tbInvoice_LegalMonetaryTotal_PayableAmount
            // 
            this.tbInvoice_LegalMonetaryTotal_PayableAmount.ColumnName = "LegalMonetaryTotal_PayableAmount";
            this.tbInvoice_LegalMonetaryTotal_PayableAmount.DataType = typeof(double);
            // 
            // FirmConn
            // 
            this.FirmConn.ConnectionString = "Server=(local)\\SQL2019;Database=MrTEK_EFatura;User ID=sa;Password=;Trusted_Connec" +
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
            this.sqlCommand4.CommandText = "UPDATE Invoice SET Deleted = InvoiceID  , ModifiedBy = @ModifiedBy , ModifiedDate" +
    " = GETDATE()   WHERE InvoiceID = @InvoiceID";
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = resources.GetString("sqlCommand2.CommandText");
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT * FROM Invoice WHERE 1=1 \r\nAND InvoiceID=@InvoiceID ";
            this.sqlCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@InvoiceID", System.Data.SqlDbType.Int, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "0")});
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = resources.GetString("sqlCommand3.CommandText");
            // 
            // textEdit54
            // 
            this.textEdit54.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_AgentParty_PartyTaxSchemeTaxTypeCode", true));
            this.textEdit54.EnterMoveNextControl = true;
            this.textEdit54.Location = new System.Drawing.Point(287, 1045);
            this.textEdit54.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit54.Name = "textEdit54";
            this.textEdit54.Size = new System.Drawing.Size(856, 20);
            this.textEdit54.StyleController = this.dataLayoutSupplier;
            this.textEdit54.TabIndex = 71;
            // 
            // textEdit49
            // 
            this.textEdit49.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_WebsiteURI", true));
            this.textEdit49.EnterMoveNextControl = true;
            this.textEdit49.Location = new System.Drawing.Point(287, 469);
            this.textEdit49.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit49.Name = "textEdit49";
            this.textEdit49.Size = new System.Drawing.Size(856, 20);
            this.textEdit49.StyleController = this.dataLayoutSupplier;
            this.textEdit49.TabIndex = 49;
            // 
            // textEdit48
            // 
            this.textEdit48.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_PartyTaxSchemeTaxTypeCode", true));
            this.textEdit48.EnterMoveNextControl = true;
            this.textEdit48.Location = new System.Drawing.Point(287, 445);
            this.textEdit48.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit48.Name = "textEdit48";
            this.textEdit48.Size = new System.Drawing.Size(856, 20);
            this.textEdit48.StyleController = this.dataLayoutSupplier;
            this.textEdit48.TabIndex = 48;
            // 
            // textEdit3
            // 
            this.textEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_PartyIdentification1_schemeID", true));
            this.textEdit3.EnterMoveNextControl = true;
            this.textEdit3.Location = new System.Drawing.Point(287, 13);
            this.textEdit3.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(856, 20);
            this.textEdit3.StyleController = this.dataLayoutSupplier;
            this.textEdit3.TabIndex = 30;
            // 
            // textEdit4
            // 
            this.textEdit4.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_PartyIdentification1_ID", true));
            this.textEdit4.EnterMoveNextControl = true;
            this.textEdit4.Location = new System.Drawing.Point(287, 37);
            this.textEdit4.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(856, 20);
            this.textEdit4.StyleController = this.dataLayoutSupplier;
            this.textEdit4.TabIndex = 31;
            // 
            // textEdit5
            // 
            this.textEdit5.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_PartyIdentification2_schemeID", true));
            this.textEdit5.EnterMoveNextControl = true;
            this.textEdit5.Location = new System.Drawing.Point(287, 61);
            this.textEdit5.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Size = new System.Drawing.Size(856, 20);
            this.textEdit5.StyleController = this.dataLayoutSupplier;
            this.textEdit5.TabIndex = 32;
            // 
            // textEdit6
            // 
            this.textEdit6.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_PartyIdentification2_ID", true));
            this.textEdit6.EnterMoveNextControl = true;
            this.textEdit6.Location = new System.Drawing.Point(287, 85);
            this.textEdit6.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Size = new System.Drawing.Size(856, 20);
            this.textEdit6.StyleController = this.dataLayoutSupplier;
            this.textEdit6.TabIndex = 33;
            // 
            // textEdit7
            // 
            this.textEdit7.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_PartyIdentification3_schemeID", true));
            this.textEdit7.EnterMoveNextControl = true;
            this.textEdit7.Location = new System.Drawing.Point(287, 109);
            this.textEdit7.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Size = new System.Drawing.Size(856, 20);
            this.textEdit7.StyleController = this.dataLayoutSupplier;
            this.textEdit7.TabIndex = 34;
            // 
            // textEdit8
            // 
            this.textEdit8.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_PartyIdentification3_ID", true));
            this.textEdit8.EnterMoveNextControl = true;
            this.textEdit8.Location = new System.Drawing.Point(287, 133);
            this.textEdit8.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit8.Name = "textEdit8";
            this.textEdit8.Size = new System.Drawing.Size(856, 20);
            this.textEdit8.StyleController = this.dataLayoutSupplier;
            this.textEdit8.TabIndex = 35;
            // 
            // textEdit9
            // 
            this.textEdit9.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_PartyIdentification4_schemeID", true));
            this.textEdit9.EnterMoveNextControl = true;
            this.textEdit9.Location = new System.Drawing.Point(287, 157);
            this.textEdit9.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit9.Name = "textEdit9";
            this.textEdit9.Size = new System.Drawing.Size(856, 20);
            this.textEdit9.StyleController = this.dataLayoutSupplier;
            this.textEdit9.TabIndex = 36;
            // 
            // textEdit10
            // 
            this.textEdit10.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_PartyIdentification4_ID", true));
            this.textEdit10.EnterMoveNextControl = true;
            this.textEdit10.Location = new System.Drawing.Point(287, 181);
            this.textEdit10.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit10.Name = "textEdit10";
            this.textEdit10.Size = new System.Drawing.Size(856, 20);
            this.textEdit10.StyleController = this.dataLayoutSupplier;
            this.textEdit10.TabIndex = 37;
            // 
            // textEdit11
            // 
            this.textEdit11.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_PartyIdentification5_schemeID", true));
            this.textEdit11.EnterMoveNextControl = true;
            this.textEdit11.Location = new System.Drawing.Point(287, 205);
            this.textEdit11.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit11.Name = "textEdit11";
            this.textEdit11.Size = new System.Drawing.Size(856, 20);
            this.textEdit11.StyleController = this.dataLayoutSupplier;
            this.textEdit11.TabIndex = 38;
            // 
            // textEdit12
            // 
            this.textEdit12.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_PartyIdentification5_ID", true));
            this.textEdit12.EnterMoveNextControl = true;
            this.textEdit12.Location = new System.Drawing.Point(287, 229);
            this.textEdit12.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit12.Name = "textEdit12";
            this.textEdit12.Size = new System.Drawing.Size(856, 20);
            this.textEdit12.StyleController = this.dataLayoutSupplier;
            this.textEdit12.TabIndex = 39;
            // 
            // textEdit13
            // 
            this.textEdit13.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_PartyName", true));
            this.textEdit13.EnterMoveNextControl = true;
            this.textEdit13.Location = new System.Drawing.Point(287, 253);
            this.textEdit13.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit13.Name = "textEdit13";
            this.textEdit13.Size = new System.Drawing.Size(856, 20);
            this.textEdit13.StyleController = this.dataLayoutSupplier;
            this.textEdit13.TabIndex = 40;
            // 
            // textEdit14
            // 
            this.textEdit14.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_PostalAddress_StreetName", true));
            this.textEdit14.EnterMoveNextControl = true;
            this.textEdit14.Location = new System.Drawing.Point(287, 277);
            this.textEdit14.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit14.Name = "textEdit14";
            this.textEdit14.Size = new System.Drawing.Size(856, 20);
            this.textEdit14.StyleController = this.dataLayoutSupplier;
            this.textEdit14.TabIndex = 41;
            // 
            // textEdit15
            // 
            this.textEdit15.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_PostalAddress_Room", true));
            this.textEdit15.EnterMoveNextControl = true;
            this.textEdit15.Location = new System.Drawing.Point(287, 301);
            this.textEdit15.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit15.Name = "textEdit15";
            this.textEdit15.Size = new System.Drawing.Size(856, 20);
            this.textEdit15.StyleController = this.dataLayoutSupplier;
            this.textEdit15.TabIndex = 42;
            // 
            // textEdit16
            // 
            this.textEdit16.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_PostalAddress_BuildingNumber", true));
            this.textEdit16.EnterMoveNextControl = true;
            this.textEdit16.Location = new System.Drawing.Point(287, 325);
            this.textEdit16.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit16.Name = "textEdit16";
            this.textEdit16.Size = new System.Drawing.Size(856, 20);
            this.textEdit16.StyleController = this.dataLayoutSupplier;
            this.textEdit16.TabIndex = 43;
            // 
            // textEdit17
            // 
            this.textEdit17.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_PostalAddress_CitySubdivisionName", true));
            this.textEdit17.EnterMoveNextControl = true;
            this.textEdit17.Location = new System.Drawing.Point(287, 349);
            this.textEdit17.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit17.Name = "textEdit17";
            this.textEdit17.Size = new System.Drawing.Size(856, 20);
            this.textEdit17.StyleController = this.dataLayoutSupplier;
            this.textEdit17.TabIndex = 44;
            // 
            // textEdit18
            // 
            this.textEdit18.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_PostalAddress_CityName", true));
            this.textEdit18.EnterMoveNextControl = true;
            this.textEdit18.Location = new System.Drawing.Point(287, 373);
            this.textEdit18.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit18.Name = "textEdit18";
            this.textEdit18.Size = new System.Drawing.Size(856, 20);
            this.textEdit18.StyleController = this.dataLayoutSupplier;
            this.textEdit18.TabIndex = 45;
            // 
            // textEdit19
            // 
            this.textEdit19.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_PostalAddress_Country", true));
            this.textEdit19.EnterMoveNextControl = true;
            this.textEdit19.Location = new System.Drawing.Point(287, 397);
            this.textEdit19.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit19.Name = "textEdit19";
            this.textEdit19.Size = new System.Drawing.Size(856, 20);
            this.textEdit19.StyleController = this.dataLayoutSupplier;
            this.textEdit19.TabIndex = 46;
            // 
            // textEdit20
            // 
            this.textEdit20.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_PartyTaxSchemeName", true));
            this.textEdit20.EnterMoveNextControl = true;
            this.textEdit20.Location = new System.Drawing.Point(287, 421);
            this.textEdit20.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit20.Name = "textEdit20";
            this.textEdit20.Size = new System.Drawing.Size(856, 20);
            this.textEdit20.StyleController = this.dataLayoutSupplier;
            this.textEdit20.TabIndex = 47;
            // 
            // textEdit21
            // 
            this.textEdit21.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_Contact_Telephone", true));
            this.textEdit21.EnterMoveNextControl = true;
            this.textEdit21.Location = new System.Drawing.Point(287, 493);
            this.textEdit21.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit21.Name = "textEdit21";
            this.textEdit21.Size = new System.Drawing.Size(856, 20);
            this.textEdit21.StyleController = this.dataLayoutSupplier;
            this.textEdit21.TabIndex = 48;
            // 
            // textEdit22
            // 
            this.textEdit22.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_Contact_Telefax", true));
            this.textEdit22.EnterMoveNextControl = true;
            this.textEdit22.Location = new System.Drawing.Point(287, 517);
            this.textEdit22.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit22.Name = "textEdit22";
            this.textEdit22.Size = new System.Drawing.Size(856, 20);
            this.textEdit22.StyleController = this.dataLayoutSupplier;
            this.textEdit22.TabIndex = 49;
            // 
            // textEdit23
            // 
            this.textEdit23.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_Contact_ElectronicMail", true));
            this.textEdit23.EnterMoveNextControl = true;
            this.textEdit23.Location = new System.Drawing.Point(287, 541);
            this.textEdit23.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit23.Name = "textEdit23";
            this.textEdit23.Size = new System.Drawing.Size(856, 20);
            this.textEdit23.StyleController = this.dataLayoutSupplier;
            this.textEdit23.TabIndex = 50;
            // 
            // textEdit38
            // 
            this.textEdit38.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_AgentParty_PostalAddress_Room", true));
            this.textEdit38.EnterMoveNextControl = true;
            this.textEdit38.Location = new System.Drawing.Point(287, 901);
            this.textEdit38.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit38.Name = "textEdit38";
            this.textEdit38.Size = new System.Drawing.Size(856, 20);
            this.textEdit38.StyleController = this.dataLayoutSupplier;
            this.textEdit38.TabIndex = 65;
            // 
            // textEdit24
            // 
            this.textEdit24.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_Person_FirstName", true));
            this.textEdit24.EnterMoveNextControl = true;
            this.textEdit24.Location = new System.Drawing.Point(287, 565);
            this.textEdit24.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit24.Name = "textEdit24";
            this.textEdit24.Size = new System.Drawing.Size(856, 20);
            this.textEdit24.StyleController = this.dataLayoutSupplier;
            this.textEdit24.TabIndex = 51;
            // 
            // textEdit25
            // 
            this.textEdit25.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_Person_FamilyName", true));
            this.textEdit25.EnterMoveNextControl = true;
            this.textEdit25.Location = new System.Drawing.Point(287, 589);
            this.textEdit25.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit25.Name = "textEdit25";
            this.textEdit25.Size = new System.Drawing.Size(856, 20);
            this.textEdit25.StyleController = this.dataLayoutSupplier;
            this.textEdit25.TabIndex = 52;
            // 
            // textEdit26
            // 
            this.textEdit26.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_AgentParty_PartyIdentification1_schemeID", true));
            this.textEdit26.EnterMoveNextControl = true;
            this.textEdit26.Location = new System.Drawing.Point(287, 613);
            this.textEdit26.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit26.Name = "textEdit26";
            this.textEdit26.Size = new System.Drawing.Size(856, 20);
            this.textEdit26.StyleController = this.dataLayoutSupplier;
            this.textEdit26.TabIndex = 53;
            // 
            // textEdit27
            // 
            this.textEdit27.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_AgentParty_PartyIdentification1_ID", true));
            this.textEdit27.EnterMoveNextControl = true;
            this.textEdit27.Location = new System.Drawing.Point(287, 637);
            this.textEdit27.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit27.Name = "textEdit27";
            this.textEdit27.Size = new System.Drawing.Size(856, 20);
            this.textEdit27.StyleController = this.dataLayoutSupplier;
            this.textEdit27.TabIndex = 54;
            // 
            // textEdit28
            // 
            this.textEdit28.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_AgentParty_PartyIdentification2_schemeID", true));
            this.textEdit28.EnterMoveNextControl = true;
            this.textEdit28.Location = new System.Drawing.Point(287, 661);
            this.textEdit28.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit28.Name = "textEdit28";
            this.textEdit28.Size = new System.Drawing.Size(856, 20);
            this.textEdit28.StyleController = this.dataLayoutSupplier;
            this.textEdit28.TabIndex = 55;
            // 
            // textEdit29
            // 
            this.textEdit29.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_AgentParty_PartyIdentification2_ID", true));
            this.textEdit29.EnterMoveNextControl = true;
            this.textEdit29.Location = new System.Drawing.Point(287, 685);
            this.textEdit29.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit29.Name = "textEdit29";
            this.textEdit29.Size = new System.Drawing.Size(856, 20);
            this.textEdit29.StyleController = this.dataLayoutSupplier;
            this.textEdit29.TabIndex = 56;
            // 
            // textEdit30
            // 
            this.textEdit30.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_AgentParty_PartyIdentification3_schemeID", true));
            this.textEdit30.EnterMoveNextControl = true;
            this.textEdit30.Location = new System.Drawing.Point(287, 709);
            this.textEdit30.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit30.Name = "textEdit30";
            this.textEdit30.Size = new System.Drawing.Size(856, 20);
            this.textEdit30.StyleController = this.dataLayoutSupplier;
            this.textEdit30.TabIndex = 57;
            // 
            // textEdit31
            // 
            this.textEdit31.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_AgentParty_PartyIdentification3_ID", true));
            this.textEdit31.EnterMoveNextControl = true;
            this.textEdit31.Location = new System.Drawing.Point(287, 733);
            this.textEdit31.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit31.Name = "textEdit31";
            this.textEdit31.Size = new System.Drawing.Size(856, 20);
            this.textEdit31.StyleController = this.dataLayoutSupplier;
            this.textEdit31.TabIndex = 58;
            // 
            // textEdit32
            // 
            this.textEdit32.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_AgentParty_PartyIdentification4_schemeID", true));
            this.textEdit32.EnterMoveNextControl = true;
            this.textEdit32.Location = new System.Drawing.Point(287, 757);
            this.textEdit32.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit32.Name = "textEdit32";
            this.textEdit32.Size = new System.Drawing.Size(856, 20);
            this.textEdit32.StyleController = this.dataLayoutSupplier;
            this.textEdit32.TabIndex = 59;
            // 
            // textEdit33
            // 
            this.textEdit33.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_AgentParty_PartyIdentification4_ID", true));
            this.textEdit33.EnterMoveNextControl = true;
            this.textEdit33.Location = new System.Drawing.Point(287, 781);
            this.textEdit33.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit33.Name = "textEdit33";
            this.textEdit33.Size = new System.Drawing.Size(856, 20);
            this.textEdit33.StyleController = this.dataLayoutSupplier;
            this.textEdit33.TabIndex = 60;
            // 
            // textEdit34
            // 
            this.textEdit34.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_AgentParty_PartyIdentification5_schemeID", true));
            this.textEdit34.EnterMoveNextControl = true;
            this.textEdit34.Location = new System.Drawing.Point(287, 805);
            this.textEdit34.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit34.Name = "textEdit34";
            this.textEdit34.Size = new System.Drawing.Size(856, 20);
            this.textEdit34.StyleController = this.dataLayoutSupplier;
            this.textEdit34.TabIndex = 61;
            // 
            // textEdit35
            // 
            this.textEdit35.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_AgentParty_PartyIdentification5_ID", true));
            this.textEdit35.EnterMoveNextControl = true;
            this.textEdit35.Location = new System.Drawing.Point(287, 829);
            this.textEdit35.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit35.Name = "textEdit35";
            this.textEdit35.Size = new System.Drawing.Size(856, 20);
            this.textEdit35.StyleController = this.dataLayoutSupplier;
            this.textEdit35.TabIndex = 62;
            // 
            // textEdit36
            // 
            this.textEdit36.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_AgentParty_PartyName", true));
            this.textEdit36.EnterMoveNextControl = true;
            this.textEdit36.Location = new System.Drawing.Point(287, 853);
            this.textEdit36.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit36.Name = "textEdit36";
            this.textEdit36.Size = new System.Drawing.Size(856, 20);
            this.textEdit36.StyleController = this.dataLayoutSupplier;
            this.textEdit36.TabIndex = 63;
            // 
            // textEdit37
            // 
            this.textEdit37.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_AgentParty_PostalAddress_StreetName", true));
            this.textEdit37.EnterMoveNextControl = true;
            this.textEdit37.Location = new System.Drawing.Point(287, 877);
            this.textEdit37.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit37.Name = "textEdit37";
            this.textEdit37.Size = new System.Drawing.Size(856, 20);
            this.textEdit37.StyleController = this.dataLayoutSupplier;
            this.textEdit37.TabIndex = 64;
            // 
            // textEdit39
            // 
            this.textEdit39.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_AgentParty_PostalAddress_BuildingNumber", true));
            this.textEdit39.EnterMoveNextControl = true;
            this.textEdit39.Location = new System.Drawing.Point(287, 925);
            this.textEdit39.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit39.Name = "textEdit39";
            this.textEdit39.Size = new System.Drawing.Size(856, 20);
            this.textEdit39.StyleController = this.dataLayoutSupplier;
            this.textEdit39.TabIndex = 66;
            // 
            // textEdit40
            // 
            this.textEdit40.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_AgentParty_PostalAddress_CitySubdivisionName", true));
            this.textEdit40.EnterMoveNextControl = true;
            this.textEdit40.Location = new System.Drawing.Point(287, 949);
            this.textEdit40.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit40.Name = "textEdit40";
            this.textEdit40.Size = new System.Drawing.Size(856, 20);
            this.textEdit40.StyleController = this.dataLayoutSupplier;
            this.textEdit40.TabIndex = 67;
            // 
            // textEdit41
            // 
            this.textEdit41.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_AgentParty_PostalAddress_CityName", true));
            this.textEdit41.EnterMoveNextControl = true;
            this.textEdit41.Location = new System.Drawing.Point(287, 973);
            this.textEdit41.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit41.Name = "textEdit41";
            this.textEdit41.Size = new System.Drawing.Size(856, 20);
            this.textEdit41.StyleController = this.dataLayoutSupplier;
            this.textEdit41.TabIndex = 68;
            // 
            // textEdit42
            // 
            this.textEdit42.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_AgentParty_PostalAddress_Country", true));
            this.textEdit42.EnterMoveNextControl = true;
            this.textEdit42.Location = new System.Drawing.Point(287, 997);
            this.textEdit42.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit42.Name = "textEdit42";
            this.textEdit42.Size = new System.Drawing.Size(856, 20);
            this.textEdit42.StyleController = this.dataLayoutSupplier;
            this.textEdit42.TabIndex = 69;
            // 
            // textEdit43
            // 
            this.textEdit43.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_AgentParty_PartyTaxSchemeName", true));
            this.textEdit43.EnterMoveNextControl = true;
            this.textEdit43.Location = new System.Drawing.Point(287, 1021);
            this.textEdit43.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit43.Name = "textEdit43";
            this.textEdit43.Size = new System.Drawing.Size(856, 20);
            this.textEdit43.StyleController = this.dataLayoutSupplier;
            this.textEdit43.TabIndex = 70;
            // 
            // textEdit44
            // 
            this.textEdit44.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_AgentParty_Contact_Telephone", true));
            this.textEdit44.EnterMoveNextControl = true;
            this.textEdit44.Location = new System.Drawing.Point(287, 1093);
            this.textEdit44.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit44.Name = "textEdit44";
            this.textEdit44.Size = new System.Drawing.Size(856, 20);
            this.textEdit44.StyleController = this.dataLayoutSupplier;
            this.textEdit44.TabIndex = 71;
            // 
            // textEdit45
            // 
            this.textEdit45.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_AgentParty_Contact_Telefax", true));
            this.textEdit45.EnterMoveNextControl = true;
            this.textEdit45.Location = new System.Drawing.Point(287, 1117);
            this.textEdit45.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit45.Name = "textEdit45";
            this.textEdit45.Size = new System.Drawing.Size(856, 20);
            this.textEdit45.StyleController = this.dataLayoutSupplier;
            this.textEdit45.TabIndex = 72;
            // 
            // textEdit46
            // 
            this.textEdit46.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_AgentParty_Contact_ElectronicMail", true));
            this.textEdit46.EnterMoveNextControl = true;
            this.textEdit46.Location = new System.Drawing.Point(287, 1141);
            this.textEdit46.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit46.Name = "textEdit46";
            this.textEdit46.Size = new System.Drawing.Size(856, 20);
            this.textEdit46.StyleController = this.dataLayoutSupplier;
            this.textEdit46.TabIndex = 73;
            // 
            // layoutControlGroup11
            // 
            this.layoutControlGroup11.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup11.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup11.GroupBordersVisible = false;
            this.layoutControlGroup11.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup12,
            this.layoutControlGroup13,
            this.layoutControlGroup14,
            this.layoutControlGroup15,
            this.layoutControlGroup16,
            this.layoutControlGroup17,
            this.layoutControlGroup18,
            this.layoutControlGroup19,
            this.layoutControlGroup20});
            this.layoutControlGroup11.Name = "layoutControlGroup1";
            this.layoutControlGroup11.Size = new System.Drawing.Size(1155, 1177);
            this.layoutControlGroup11.TextVisible = false;
            // 
            // layoutControlGroup12
            // 
            this.layoutControlGroup12.AllowDrawBackground = false;
            this.layoutControlGroup12.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup12.GroupBordersVisible = false;
            this.layoutControlGroup12.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup12.Name = "autoGeneratedGroup0";
            this.layoutControlGroup12.Size = new System.Drawing.Size(1135, 1);
            // 
            // layoutControlGroup13
            // 
            this.layoutControlGroup13.AllowDrawBackground = false;
            this.layoutControlGroup13.CustomizationFormText = "autoGeneratedGroup1";
            this.layoutControlGroup13.GroupBordersVisible = false;
            this.layoutControlGroup13.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutControlGroup13.Location = new System.Drawing.Point(0, 1);
            this.layoutControlGroup13.Name = "autoGeneratedGroup1";
            this.layoutControlGroup13.Size = new System.Drawing.Size(1135, 168);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit3;
            this.layoutControlItem1.CustomizationFormText = "ASP_Party Identification1_scheme ID";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "ItemForASP_PartyIdentification1_schemeID";
            this.layoutControlItem1.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem1.Text = "ASP_Party Identification1_scheme ID";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEdit4;
            this.layoutControlItem2.CustomizationFormText = "ASP_Party Identification1_ID";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "ItemForASP_PartyIdentification1_ID";
            this.layoutControlItem2.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem2.Text = "ASP_Party Identification1_ID";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.textEdit5;
            this.layoutControlItem3.CustomizationFormText = "ASP_Party Identification2_scheme ID";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "ItemForASP_PartyIdentification2_schemeID";
            this.layoutControlItem3.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem3.Text = "ASP_Party Identification2_scheme ID";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.textEdit6;
            this.layoutControlItem4.CustomizationFormText = "ASP_Party Identification2_ID";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "ItemForASP_PartyIdentification2_ID";
            this.layoutControlItem4.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem4.Text = "ASP_Party Identification2_ID";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.textEdit7;
            this.layoutControlItem5.CustomizationFormText = "ASP_Party Identification3_scheme ID";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "ItemForASP_PartyIdentification3_schemeID";
            this.layoutControlItem5.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem5.Text = "ASP_Party Identification3_scheme ID";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.textEdit8;
            this.layoutControlItem6.CustomizationFormText = "ASP_Party Identification3_ID";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem6.Name = "ItemForASP_PartyIdentification3_ID";
            this.layoutControlItem6.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem6.Text = "ASP_Party Identification3_ID";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.textEdit9;
            this.layoutControlItem7.CustomizationFormText = "ASP_Party Identification4_scheme ID";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem7.Name = "ItemForASP_PartyIdentification4_schemeID";
            this.layoutControlItem7.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem7.Text = "ASP_Party Identification4_scheme ID";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlGroup14
            // 
            this.layoutControlGroup14.AllowDrawBackground = false;
            this.layoutControlGroup14.CustomizationFormText = "autoGeneratedGroup2";
            this.layoutControlGroup14.GroupBordersVisible = false;
            this.layoutControlGroup14.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.layoutControlItem12,
            this.layoutControlItem13,
            this.layoutControlItem14,
            this.layoutControlItem15,
            this.layoutControlItem16,
            this.layoutControlItem17,
            this.layoutControlItem18,
            this.layoutControlItem19,
            this.layoutControlItem20,
            this.layoutControlItem21,
            this.layoutControlItem22,
            this.layoutControlItem23,
            this.layoutControlItem24,
            this.layoutControlItem45,
            this.layoutControlItem46});
            this.layoutControlGroup14.Location = new System.Drawing.Point(0, 169);
            this.layoutControlGroup14.Name = "autoGeneratedGroup2";
            this.layoutControlGroup14.Size = new System.Drawing.Size(1135, 456);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.textEdit10;
            this.layoutControlItem8.CustomizationFormText = "ASP_Party Identification4_ID";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "ItemForASP_PartyIdentification4_ID";
            this.layoutControlItem8.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem8.Text = "ASP_Party Identification4_ID";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.textEdit11;
            this.layoutControlItem9.CustomizationFormText = "ASP_Party Identification5_scheme ID";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem9.Name = "ItemForASP_PartyIdentification5_schemeID";
            this.layoutControlItem9.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem9.Text = "ASP_Party Identification5_scheme ID";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.textEdit12;
            this.layoutControlItem10.CustomizationFormText = "ASP_Party Identification5_ID";
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem10.Name = "ItemForASP_PartyIdentification5_ID";
            this.layoutControlItem10.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem10.Text = "ASP_Party Identification5_ID";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.textEdit13;
            this.layoutControlItem11.CustomizationFormText = "ASP_Party Name";
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem11.Name = "ItemForASP_PartyName";
            this.layoutControlItem11.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem11.Text = "ASP_Party Name";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.textEdit14;
            this.layoutControlItem12.CustomizationFormText = "ASP_Postal Address_Street Name";
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem12.Name = "ItemForASP_PostalAddress_StreetName";
            this.layoutControlItem12.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem12.Text = "ASP_Postal Address_Street Name";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.textEdit15;
            this.layoutControlItem13.CustomizationFormText = "ASP_Postal Address_Room";
            this.layoutControlItem13.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem13.Name = "ItemForASP_PostalAddress_Room";
            this.layoutControlItem13.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem13.Text = "ASP_Postal Address_Room";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.textEdit16;
            this.layoutControlItem14.CustomizationFormText = "ASP_Postal Address_Building Number";
            this.layoutControlItem14.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem14.Name = "ItemForASP_PostalAddress_BuildingNumber";
            this.layoutControlItem14.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem14.Text = "ASP_Postal Address_Building Number";
            this.layoutControlItem14.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.textEdit17;
            this.layoutControlItem15.CustomizationFormText = "ASP_Postal Address_City Subdivision Name";
            this.layoutControlItem15.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem15.Name = "ItemForASP_PostalAddress_CitySubdivisionName";
            this.layoutControlItem15.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem15.Text = "ASP_Postal Address_City Subdivision Name";
            this.layoutControlItem15.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem16
            // 
            this.layoutControlItem16.Control = this.textEdit18;
            this.layoutControlItem16.CustomizationFormText = "ASP_Postal Address_City Name";
            this.layoutControlItem16.Location = new System.Drawing.Point(0, 192);
            this.layoutControlItem16.Name = "ItemForASP_PostalAddress_CityName";
            this.layoutControlItem16.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem16.Text = "ASP_Postal Address_City Name";
            this.layoutControlItem16.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem17
            // 
            this.layoutControlItem17.Control = this.textEdit19;
            this.layoutControlItem17.CustomizationFormText = "ASP_Postal Address_Country";
            this.layoutControlItem17.Location = new System.Drawing.Point(0, 216);
            this.layoutControlItem17.Name = "ItemForASP_PostalAddress_Country";
            this.layoutControlItem17.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem17.Text = "ASP_Postal Address_Country";
            this.layoutControlItem17.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem18
            // 
            this.layoutControlItem18.Control = this.textEdit20;
            this.layoutControlItem18.CustomizationFormText = "ASP_Party Tax Scheme";
            this.layoutControlItem18.Location = new System.Drawing.Point(0, 240);
            this.layoutControlItem18.Name = "ItemForASP_PartyTaxScheme";
            this.layoutControlItem18.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem18.Text = "ASP_Party Tax Scheme";
            this.layoutControlItem18.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem19
            // 
            this.layoutControlItem19.Control = this.textEdit21;
            this.layoutControlItem19.CustomizationFormText = "ASP_Contact_Telephone";
            this.layoutControlItem19.Location = new System.Drawing.Point(0, 312);
            this.layoutControlItem19.Name = "ItemForASP_Contact_Telephone";
            this.layoutControlItem19.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem19.Text = "ASP_Contact_Telephone";
            this.layoutControlItem19.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem20
            // 
            this.layoutControlItem20.Control = this.textEdit22;
            this.layoutControlItem20.CustomizationFormText = "ASP_Contact_Telefax";
            this.layoutControlItem20.Location = new System.Drawing.Point(0, 336);
            this.layoutControlItem20.Name = "ItemForASP_Contact_Telefax";
            this.layoutControlItem20.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem20.Text = "ASP_Contact_Telefax";
            this.layoutControlItem20.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem21
            // 
            this.layoutControlItem21.Control = this.textEdit23;
            this.layoutControlItem21.CustomizationFormText = "ASP_Contact_Electronic Mail";
            this.layoutControlItem21.Location = new System.Drawing.Point(0, 360);
            this.layoutControlItem21.Name = "ItemForASP_Contact_ElectronicMail";
            this.layoutControlItem21.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem21.Text = "ASP_Contact_Electronic Mail";
            this.layoutControlItem21.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem22
            // 
            this.layoutControlItem22.Control = this.textEdit24;
            this.layoutControlItem22.CustomizationFormText = "ASP_Person_First Name";
            this.layoutControlItem22.Location = new System.Drawing.Point(0, 384);
            this.layoutControlItem22.Name = "ItemForASP_Person_FirstName";
            this.layoutControlItem22.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem22.Text = "ASP_Person_First Name";
            this.layoutControlItem22.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem23
            // 
            this.layoutControlItem23.Control = this.textEdit25;
            this.layoutControlItem23.CustomizationFormText = "ASP_Person_Family Name";
            this.layoutControlItem23.Location = new System.Drawing.Point(0, 408);
            this.layoutControlItem23.Name = "ItemForASP_Person_FamilyName";
            this.layoutControlItem23.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem23.Text = "ASP_Person_Family Name";
            this.layoutControlItem23.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem24
            // 
            this.layoutControlItem24.Control = this.textEdit26;
            this.layoutControlItem24.CustomizationFormText = "ASP_Agent Party_Party Identification1_scheme ID";
            this.layoutControlItem24.Location = new System.Drawing.Point(0, 432);
            this.layoutControlItem24.Name = "ItemForASP_AgentParty_PartyIdentification1_schemeID";
            this.layoutControlItem24.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem24.Text = "ASP_Agent Party_Party Identification1_scheme ID";
            this.layoutControlItem24.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem45
            // 
            this.layoutControlItem45.Control = this.textEdit48;
            this.layoutControlItem45.CustomizationFormText = "ASP_PartyTaxSchemeTaxTypeCode";
            this.layoutControlItem45.Location = new System.Drawing.Point(0, 264);
            this.layoutControlItem45.Name = "layoutControlItem45";
            this.layoutControlItem45.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem45.Text = "ASP_PartyTaxSchemeTaxTypeCode";
            this.layoutControlItem45.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem46
            // 
            this.layoutControlItem46.Control = this.textEdit49;
            this.layoutControlItem46.CustomizationFormText = "ASP_WebsiteURI";
            this.layoutControlItem46.Location = new System.Drawing.Point(0, 288);
            this.layoutControlItem46.Name = "layoutControlItem46";
            this.layoutControlItem46.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem46.Text = "ASP_WebsiteURI";
            this.layoutControlItem46.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlGroup15
            // 
            this.layoutControlGroup15.AllowDrawBackground = false;
            this.layoutControlGroup15.CustomizationFormText = "autoGeneratedGroup3";
            this.layoutControlGroup15.GroupBordersVisible = false;
            this.layoutControlGroup15.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem25,
            this.layoutControlItem26,
            this.layoutControlItem27,
            this.layoutControlItem28,
            this.layoutControlItem29,
            this.layoutControlItem30,
            this.layoutControlItem31,
            this.layoutControlItem32,
            this.layoutControlItem33,
            this.layoutControlItem34,
            this.layoutControlItem35,
            this.layoutControlItem37,
            this.layoutControlItem38,
            this.layoutControlItem39,
            this.layoutControlItem40,
            this.layoutControlItem41,
            this.layoutControlItem156,
            this.layoutControlItem51});
            this.layoutControlGroup15.Location = new System.Drawing.Point(0, 625);
            this.layoutControlGroup15.Name = "autoGeneratedGroup3";
            this.layoutControlGroup15.Size = new System.Drawing.Size(1135, 432);
            // 
            // layoutControlItem25
            // 
            this.layoutControlItem25.Control = this.textEdit27;
            this.layoutControlItem25.CustomizationFormText = "ASP_Agent Party_Party Identification1_ID";
            this.layoutControlItem25.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem25.Name = "ItemForASP_AgentParty_PartyIdentification1_ID";
            this.layoutControlItem25.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem25.Text = "ASP_Agent Party_Party Identification1_ID";
            this.layoutControlItem25.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem26
            // 
            this.layoutControlItem26.Control = this.textEdit28;
            this.layoutControlItem26.CustomizationFormText = "ASP_Agent Party_Party Identification2_scheme ID";
            this.layoutControlItem26.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem26.Name = "ItemForASP_AgentParty_PartyIdentification2_schemeID";
            this.layoutControlItem26.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem26.Text = "ASP_Agent Party_Party Identification2_scheme ID";
            this.layoutControlItem26.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem27
            // 
            this.layoutControlItem27.Control = this.textEdit29;
            this.layoutControlItem27.CustomizationFormText = "ASP_Agent Party_Party Identification2_ID";
            this.layoutControlItem27.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem27.Name = "ItemForASP_AgentParty_PartyIdentification2_ID";
            this.layoutControlItem27.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem27.Text = "ASP_Agent Party_Party Identification2_ID";
            this.layoutControlItem27.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem28
            // 
            this.layoutControlItem28.Control = this.textEdit30;
            this.layoutControlItem28.CustomizationFormText = "ASP_Agent Party_Party Identification3_scheme ID";
            this.layoutControlItem28.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem28.Name = "ItemForASP_AgentParty_PartyIdentification3_schemeID";
            this.layoutControlItem28.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem28.Text = "ASP_Agent Party_Party Identification3_scheme ID";
            this.layoutControlItem28.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem29
            // 
            this.layoutControlItem29.Control = this.textEdit31;
            this.layoutControlItem29.CustomizationFormText = "ASP_Agent Party_Party Identification3_ID";
            this.layoutControlItem29.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem29.Name = "ItemForASP_AgentParty_PartyIdentification3_ID";
            this.layoutControlItem29.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem29.Text = "ASP_Agent Party_Party Identification3_ID";
            this.layoutControlItem29.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem30
            // 
            this.layoutControlItem30.Control = this.textEdit32;
            this.layoutControlItem30.CustomizationFormText = "ASP_Agent Party_Party Identification4_scheme ID";
            this.layoutControlItem30.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem30.Name = "ItemForASP_AgentParty_PartyIdentification4_schemeID";
            this.layoutControlItem30.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem30.Text = "ASP_Agent Party_Party Identification4_scheme ID";
            this.layoutControlItem30.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem31
            // 
            this.layoutControlItem31.Control = this.textEdit33;
            this.layoutControlItem31.CustomizationFormText = "ASP_Agent Party_Party Identification4_ID";
            this.layoutControlItem31.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem31.Name = "ItemForASP_AgentParty_PartyIdentification4_ID";
            this.layoutControlItem31.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem31.Text = "ASP_Agent Party_Party Identification4_ID";
            this.layoutControlItem31.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem32
            // 
            this.layoutControlItem32.Control = this.textEdit34;
            this.layoutControlItem32.CustomizationFormText = "ASP_Agent Party_Party Identification5_scheme ID";
            this.layoutControlItem32.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem32.Name = "ItemForASP_AgentParty_PartyIdentification5_schemeID";
            this.layoutControlItem32.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem32.Text = "ASP_Agent Party_Party Identification5_scheme ID";
            this.layoutControlItem32.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem33
            // 
            this.layoutControlItem33.Control = this.textEdit35;
            this.layoutControlItem33.CustomizationFormText = "ASP_Agent Party_Party Identification5_ID";
            this.layoutControlItem33.Location = new System.Drawing.Point(0, 192);
            this.layoutControlItem33.Name = "ItemForASP_AgentParty_PartyIdentification5_ID";
            this.layoutControlItem33.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem33.Text = "ASP_Agent Party_Party Identification5_ID";
            this.layoutControlItem33.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem34
            // 
            this.layoutControlItem34.Control = this.textEdit36;
            this.layoutControlItem34.CustomizationFormText = "ASP_Agent Party_Party Name";
            this.layoutControlItem34.Location = new System.Drawing.Point(0, 216);
            this.layoutControlItem34.Name = "ItemForASP_AgentParty_PartyName";
            this.layoutControlItem34.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem34.Text = "ASP_Agent Party_Party Name";
            this.layoutControlItem34.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem35
            // 
            this.layoutControlItem35.Control = this.textEdit37;
            this.layoutControlItem35.CustomizationFormText = "ASP_Agent Party_Postal Address_Street Name";
            this.layoutControlItem35.Location = new System.Drawing.Point(0, 240);
            this.layoutControlItem35.Name = "ItemForASP_AgentParty_PostalAddress_StreetName";
            this.layoutControlItem35.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem35.Text = "ASP_Agent Party_Postal Address_Street Name";
            this.layoutControlItem35.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem37
            // 
            this.layoutControlItem37.Control = this.textEdit39;
            this.layoutControlItem37.CustomizationFormText = "ASP_Agent Party_Postal Address_Building Number";
            this.layoutControlItem37.Location = new System.Drawing.Point(0, 288);
            this.layoutControlItem37.Name = "ItemForASP_AgentParty_PostalAddress_BuildingNumber";
            this.layoutControlItem37.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem37.Text = "ASP_Agent Party_Postal Address_Building Number";
            this.layoutControlItem37.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem38
            // 
            this.layoutControlItem38.Control = this.textEdit40;
            this.layoutControlItem38.CustomizationFormText = "ASP_Agent Party_Postal Address_City Subdivision Name";
            this.layoutControlItem38.Location = new System.Drawing.Point(0, 312);
            this.layoutControlItem38.Name = "ItemForASP_AgentParty_PostalAddress_CitySubdivisionName";
            this.layoutControlItem38.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem38.Text = "ASP_Agent Party_Postal Address_City Subdivision Name";
            this.layoutControlItem38.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem39
            // 
            this.layoutControlItem39.Control = this.textEdit41;
            this.layoutControlItem39.CustomizationFormText = "ASP_Agent Party_Postal Address_City Name";
            this.layoutControlItem39.Location = new System.Drawing.Point(0, 336);
            this.layoutControlItem39.Name = "ItemForASP_AgentParty_PostalAddress_CityName";
            this.layoutControlItem39.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem39.Text = "ASP_Agent Party_Postal Address_City Name";
            this.layoutControlItem39.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem40
            // 
            this.layoutControlItem40.Control = this.textEdit42;
            this.layoutControlItem40.CustomizationFormText = "ASP_Agent Party_Postal Address_Country";
            this.layoutControlItem40.Location = new System.Drawing.Point(0, 360);
            this.layoutControlItem40.Name = "ItemForASP_AgentParty_PostalAddress_Country";
            this.layoutControlItem40.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem40.Text = "ASP_Agent Party_Postal Address_Country";
            this.layoutControlItem40.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem41
            // 
            this.layoutControlItem41.Control = this.textEdit43;
            this.layoutControlItem41.CustomizationFormText = "ASP_Agent Party_Party Tax Scheme";
            this.layoutControlItem41.Location = new System.Drawing.Point(0, 384);
            this.layoutControlItem41.Name = "ItemForASP_AgentParty_PartyTaxScheme";
            this.layoutControlItem41.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem41.Text = "ASP_Agent Party_Party Tax Scheme";
            this.layoutControlItem41.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem156
            // 
            this.layoutControlItem156.Control = this.textEdit38;
            this.layoutControlItem156.CustomizationFormText = "Room";
            this.layoutControlItem156.Location = new System.Drawing.Point(0, 264);
            this.layoutControlItem156.Name = "layoutControlItem156";
            this.layoutControlItem156.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem156.Text = "Room";
            this.layoutControlItem156.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem51
            // 
            this.layoutControlItem51.Control = this.textEdit54;
            this.layoutControlItem51.CustomizationFormText = "ASP_AgentParty_PartyTaxSchemeTaxTypeCode";
            this.layoutControlItem51.Location = new System.Drawing.Point(0, 408);
            this.layoutControlItem51.Name = "layoutControlItem51";
            this.layoutControlItem51.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem51.Text = "ASP_AgentParty_PartyTaxSchemeTaxTypeCode";
            this.layoutControlItem51.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlGroup16
            // 
            this.layoutControlGroup16.AllowDrawBackground = false;
            this.layoutControlGroup16.CustomizationFormText = "autoGeneratedGroup4";
            this.layoutControlGroup16.GroupBordersVisible = false;
            this.layoutControlGroup16.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem42,
            this.layoutControlItem43,
            this.layoutControlItem44,
            this.layoutControlItem52});
            this.layoutControlGroup16.Location = new System.Drawing.Point(0, 1057);
            this.layoutControlGroup16.Name = "autoGeneratedGroup4";
            this.layoutControlGroup16.Size = new System.Drawing.Size(1135, 96);
            // 
            // layoutControlItem42
            // 
            this.layoutControlItem42.Control = this.textEdit44;
            this.layoutControlItem42.CustomizationFormText = "ASP_Agent Party_Contact_Telephone";
            this.layoutControlItem42.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem42.Name = "ItemForASP_AgentParty_Contact_Telephone";
            this.layoutControlItem42.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem42.Text = "ASP_Agent Party_Contact_Telephone";
            this.layoutControlItem42.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem43
            // 
            this.layoutControlItem43.Control = this.textEdit45;
            this.layoutControlItem43.CustomizationFormText = "ASP_Agent Party_Contact_Telefax";
            this.layoutControlItem43.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem43.Name = "ItemForASP_AgentParty_Contact_Telefax";
            this.layoutControlItem43.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem43.Text = "ASP_Agent Party_Contact_Telefax";
            this.layoutControlItem43.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem44
            // 
            this.layoutControlItem44.Control = this.textEdit46;
            this.layoutControlItem44.CustomizationFormText = "ASP_Agent Party_Contact_Electronic Mail";
            this.layoutControlItem44.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem44.Name = "ItemForASP_AgentParty_Contact_ElectronicMail";
            this.layoutControlItem44.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem44.Text = "ASP_Agent Party_Contact_Electronic Mail";
            this.layoutControlItem44.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlItem52
            // 
            this.layoutControlItem52.Control = this.textEdit55;
            this.layoutControlItem52.CustomizationFormText = "ASP_AgentParty_WebsiteURI";
            this.layoutControlItem52.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem52.Name = "layoutControlItem52";
            this.layoutControlItem52.Size = new System.Drawing.Size(1135, 24);
            this.layoutControlItem52.Text = "ASP_AgentParty_WebsiteURI";
            this.layoutControlItem52.TextSize = new System.Drawing.Size(271, 13);
            // 
            // layoutControlGroup17
            // 
            this.layoutControlGroup17.AllowDrawBackground = false;
            this.layoutControlGroup17.CustomizationFormText = "autoGeneratedGroup5";
            this.layoutControlGroup17.GroupBordersVisible = false;
            this.layoutControlGroup17.Location = new System.Drawing.Point(0, 1153);
            this.layoutControlGroup17.Name = "autoGeneratedGroup5";
            this.layoutControlGroup17.Size = new System.Drawing.Size(1135, 1);
            // 
            // layoutControlGroup18
            // 
            this.layoutControlGroup18.AllowDrawBackground = false;
            this.layoutControlGroup18.CustomizationFormText = "autoGeneratedGroup6";
            this.layoutControlGroup18.GroupBordersVisible = false;
            this.layoutControlGroup18.Location = new System.Drawing.Point(0, 1154);
            this.layoutControlGroup18.Name = "autoGeneratedGroup6";
            this.layoutControlGroup18.Size = new System.Drawing.Size(1135, 1);
            // 
            // layoutControlGroup19
            // 
            this.layoutControlGroup19.AllowDrawBackground = false;
            this.layoutControlGroup19.CustomizationFormText = "autoGeneratedGroup7";
            this.layoutControlGroup19.GroupBordersVisible = false;
            this.layoutControlGroup19.Location = new System.Drawing.Point(0, 1155);
            this.layoutControlGroup19.Name = "autoGeneratedGroup7";
            this.layoutControlGroup19.Size = new System.Drawing.Size(1135, 1);
            // 
            // layoutControlGroup20
            // 
            this.layoutControlGroup20.AllowDrawBackground = false;
            this.layoutControlGroup20.CustomizationFormText = "autoGeneratedGroup8";
            this.layoutControlGroup20.GroupBordersVisible = false;
            this.layoutControlGroup20.Location = new System.Drawing.Point(0, 1156);
            this.layoutControlGroup20.Name = "autoGeneratedGroup8";
            this.layoutControlGroup20.Size = new System.Drawing.Size(1135, 1);
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.dataLayoutCustomer);
            this.xtraTabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(1172, 238);
            this.xtraTabPage4.Text = "Musteri bilgileri";
            // 
            // dataLayoutCustomer
            // 
            this.dataLayoutCustomer.Controls.Add(this.textEdit53);
            this.dataLayoutCustomer.Controls.Add(this.textEdit52);
            this.dataLayoutCustomer.Controls.Add(this.textEdit50);
            this.dataLayoutCustomer.Controls.Add(this.textEdit51);
            this.dataLayoutCustomer.Controls.Add(this.textEdit91);
            this.dataLayoutCustomer.Controls.Add(this.textEdit92);
            this.dataLayoutCustomer.Controls.Add(this.textEdit93);
            this.dataLayoutCustomer.Controls.Add(this.textEdit94);
            this.dataLayoutCustomer.Controls.Add(this.textEdit95);
            this.dataLayoutCustomer.Controls.Add(this.textEdit96);
            this.dataLayoutCustomer.Controls.Add(this.textEdit97);
            this.dataLayoutCustomer.Controls.Add(this.textEdit98);
            this.dataLayoutCustomer.Controls.Add(this.textEdit99);
            this.dataLayoutCustomer.Controls.Add(this.textEdit100);
            this.dataLayoutCustomer.Controls.Add(this.textEdit101);
            this.dataLayoutCustomer.Controls.Add(this.textEdit102);
            this.dataLayoutCustomer.Controls.Add(this.textEdit103);
            this.dataLayoutCustomer.Controls.Add(this.textEdit104);
            this.dataLayoutCustomer.Controls.Add(this.textEdit105);
            this.dataLayoutCustomer.Controls.Add(this.textEdit106);
            this.dataLayoutCustomer.Controls.Add(this.textEdit107);
            this.dataLayoutCustomer.Controls.Add(this.textEdit108);
            this.dataLayoutCustomer.Controls.Add(this.textEdit109);
            this.dataLayoutCustomer.Controls.Add(this.textEdit110);
            this.dataLayoutCustomer.Controls.Add(this.textEdit111);
            this.dataLayoutCustomer.Controls.Add(this.textEdit112);
            this.dataLayoutCustomer.Controls.Add(this.textEdit113);
            this.dataLayoutCustomer.Controls.Add(this.textEdit114);
            this.dataLayoutCustomer.Controls.Add(this.textEdit115);
            this.dataLayoutCustomer.Controls.Add(this.textEdit116);
            this.dataLayoutCustomer.Controls.Add(this.textEdit117);
            this.dataLayoutCustomer.Controls.Add(this.textEdit118);
            this.dataLayoutCustomer.Controls.Add(this.textEdit119);
            this.dataLayoutCustomer.Controls.Add(this.textEdit120);
            this.dataLayoutCustomer.Controls.Add(this.textEdit121);
            this.dataLayoutCustomer.Controls.Add(this.textEdit122);
            this.dataLayoutCustomer.Controls.Add(this.textEdit123);
            this.dataLayoutCustomer.Controls.Add(this.textEdit124);
            this.dataLayoutCustomer.Controls.Add(this.textEdit125);
            this.dataLayoutCustomer.Controls.Add(this.textEdit126);
            this.dataLayoutCustomer.Controls.Add(this.textEdit127);
            this.dataLayoutCustomer.Controls.Add(this.textEdit128);
            this.dataLayoutCustomer.Controls.Add(this.textEdit129);
            this.dataLayoutCustomer.Controls.Add(this.textEdit130);
            this.dataLayoutCustomer.Controls.Add(this.textEdit131);
            this.dataLayoutCustomer.Controls.Add(this.textEdit132);
            this.dataLayoutCustomer.Controls.Add(this.textEdit133);
            this.dataLayoutCustomer.Controls.Add(this.textEdit134);
            this.dataLayoutCustomer.DataSource = this.tbInvoice;
            this.dataLayoutCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutCustomer.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.dataLayoutCustomer.Name = "dataLayoutCustomer";
            this.dataLayoutCustomer.Root = this.layoutControlGroup21;
            this.dataLayoutCustomer.Size = new System.Drawing.Size(1172, 238);
            this.dataLayoutCustomer.TabIndex = 1;
            this.dataLayoutCustomer.Text = "dataLayoutControl3";
            // 
            // textEdit53
            // 
            this.textEdit53.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_AgentParty_WebsiteURI", true));
            this.textEdit53.EnterMoveNextControl = true;
            this.textEdit53.Location = new System.Drawing.Point(288, 1072);
            this.textEdit53.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit53.Name = "textEdit53";
            this.textEdit53.Size = new System.Drawing.Size(872, 20);
            this.textEdit53.StyleController = this.dataLayoutCustomer;
            this.textEdit53.TabIndex = 115;
            // 
            // textEdit52
            // 
            this.textEdit52.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_AgentParty_PartyTaxSchemeTaxTypeCode", true));
            this.textEdit52.EnterMoveNextControl = true;
            this.textEdit52.Location = new System.Drawing.Point(288, 1048);
            this.textEdit52.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit52.Name = "textEdit52";
            this.textEdit52.Size = new System.Drawing.Size(872, 20);
            this.textEdit52.StyleController = this.dataLayoutCustomer;
            this.textEdit52.TabIndex = 115;
            // 
            // textEdit50
            // 
            this.textEdit50.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_WebsiteURI", true));
            this.textEdit50.EnterMoveNextControl = true;
            this.textEdit50.Location = new System.Drawing.Point(288, 472);
            this.textEdit50.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit50.Name = "textEdit50";
            this.textEdit50.Size = new System.Drawing.Size(872, 20);
            this.textEdit50.StyleController = this.dataLayoutCustomer;
            this.textEdit50.TabIndex = 51;
            // 
            // textEdit51
            // 
            this.textEdit51.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_PartyTaxSchemeTaxTypeCode", true));
            this.textEdit51.EnterMoveNextControl = true;
            this.textEdit51.Location = new System.Drawing.Point(288, 448);
            this.textEdit51.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit51.Name = "textEdit51";
            this.textEdit51.Size = new System.Drawing.Size(872, 20);
            this.textEdit51.StyleController = this.dataLayoutCustomer;
            this.textEdit51.TabIndex = 50;
            // 
            // textEdit91
            // 
            this.textEdit91.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_PartyIdentification1_schemeID", true));
            this.textEdit91.EnterMoveNextControl = true;
            this.textEdit91.Location = new System.Drawing.Point(288, 16);
            this.textEdit91.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit91.Name = "textEdit91";
            this.textEdit91.Size = new System.Drawing.Size(872, 20);
            this.textEdit91.StyleController = this.dataLayoutCustomer;
            this.textEdit91.TabIndex = 74;
            // 
            // textEdit92
            // 
            this.textEdit92.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_PartyIdentification1_ID", true));
            this.textEdit92.EnterMoveNextControl = true;
            this.textEdit92.Location = new System.Drawing.Point(288, 40);
            this.textEdit92.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit92.Name = "textEdit92";
            this.textEdit92.Size = new System.Drawing.Size(872, 20);
            this.textEdit92.StyleController = this.dataLayoutCustomer;
            this.textEdit92.TabIndex = 75;
            // 
            // textEdit93
            // 
            this.textEdit93.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_PartyIdentification2_schemeID", true));
            this.textEdit93.EnterMoveNextControl = true;
            this.textEdit93.Location = new System.Drawing.Point(288, 64);
            this.textEdit93.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit93.Name = "textEdit93";
            this.textEdit93.Size = new System.Drawing.Size(872, 20);
            this.textEdit93.StyleController = this.dataLayoutCustomer;
            this.textEdit93.TabIndex = 76;
            // 
            // textEdit94
            // 
            this.textEdit94.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_PartyIdentification2_ID", true));
            this.textEdit94.EnterMoveNextControl = true;
            this.textEdit94.Location = new System.Drawing.Point(288, 88);
            this.textEdit94.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit94.Name = "textEdit94";
            this.textEdit94.Size = new System.Drawing.Size(872, 20);
            this.textEdit94.StyleController = this.dataLayoutCustomer;
            this.textEdit94.TabIndex = 77;
            // 
            // textEdit95
            // 
            this.textEdit95.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_PartyIdentification3_schemeID", true));
            this.textEdit95.EnterMoveNextControl = true;
            this.textEdit95.Location = new System.Drawing.Point(288, 112);
            this.textEdit95.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit95.Name = "textEdit95";
            this.textEdit95.Size = new System.Drawing.Size(872, 20);
            this.textEdit95.StyleController = this.dataLayoutCustomer;
            this.textEdit95.TabIndex = 78;
            // 
            // textEdit96
            // 
            this.textEdit96.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_PartyIdentification3_ID", true));
            this.textEdit96.EnterMoveNextControl = true;
            this.textEdit96.Location = new System.Drawing.Point(288, 136);
            this.textEdit96.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit96.Name = "textEdit96";
            this.textEdit96.Size = new System.Drawing.Size(872, 20);
            this.textEdit96.StyleController = this.dataLayoutCustomer;
            this.textEdit96.TabIndex = 79;
            // 
            // textEdit97
            // 
            this.textEdit97.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_PartyIdentification4_schemeID", true));
            this.textEdit97.EnterMoveNextControl = true;
            this.textEdit97.Location = new System.Drawing.Point(288, 160);
            this.textEdit97.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit97.Name = "textEdit97";
            this.textEdit97.Size = new System.Drawing.Size(872, 20);
            this.textEdit97.StyleController = this.dataLayoutCustomer;
            this.textEdit97.TabIndex = 80;
            // 
            // textEdit98
            // 
            this.textEdit98.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_PartyIdentification4_ID", true));
            this.textEdit98.EnterMoveNextControl = true;
            this.textEdit98.Location = new System.Drawing.Point(288, 184);
            this.textEdit98.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit98.Name = "textEdit98";
            this.textEdit98.Size = new System.Drawing.Size(872, 20);
            this.textEdit98.StyleController = this.dataLayoutCustomer;
            this.textEdit98.TabIndex = 81;
            // 
            // textEdit99
            // 
            this.textEdit99.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_PartyIdentification5_schemeID", true));
            this.textEdit99.EnterMoveNextControl = true;
            this.textEdit99.Location = new System.Drawing.Point(288, 208);
            this.textEdit99.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit99.Name = "textEdit99";
            this.textEdit99.Size = new System.Drawing.Size(872, 20);
            this.textEdit99.StyleController = this.dataLayoutCustomer;
            this.textEdit99.TabIndex = 82;
            // 
            // textEdit100
            // 
            this.textEdit100.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_PartyIdentification5_ID", true));
            this.textEdit100.EnterMoveNextControl = true;
            this.textEdit100.Location = new System.Drawing.Point(288, 232);
            this.textEdit100.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit100.Name = "textEdit100";
            this.textEdit100.Size = new System.Drawing.Size(872, 20);
            this.textEdit100.StyleController = this.dataLayoutCustomer;
            this.textEdit100.TabIndex = 83;
            // 
            // textEdit101
            // 
            this.textEdit101.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_PartyName", true));
            this.textEdit101.EnterMoveNextControl = true;
            this.textEdit101.Location = new System.Drawing.Point(288, 256);
            this.textEdit101.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit101.Name = "textEdit101";
            this.textEdit101.Size = new System.Drawing.Size(872, 20);
            this.textEdit101.StyleController = this.dataLayoutCustomer;
            this.textEdit101.TabIndex = 84;
            // 
            // textEdit102
            // 
            this.textEdit102.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_PostalAddress_StreetName", true));
            this.textEdit102.EnterMoveNextControl = true;
            this.textEdit102.Location = new System.Drawing.Point(288, 280);
            this.textEdit102.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit102.Name = "textEdit102";
            this.textEdit102.Size = new System.Drawing.Size(872, 20);
            this.textEdit102.StyleController = this.dataLayoutCustomer;
            this.textEdit102.TabIndex = 85;
            // 
            // textEdit103
            // 
            this.textEdit103.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_PostalAddress_Room", true));
            this.textEdit103.EnterMoveNextControl = true;
            this.textEdit103.Location = new System.Drawing.Point(288, 304);
            this.textEdit103.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit103.Name = "textEdit103";
            this.textEdit103.Size = new System.Drawing.Size(872, 20);
            this.textEdit103.StyleController = this.dataLayoutCustomer;
            this.textEdit103.TabIndex = 86;
            // 
            // textEdit104
            // 
            this.textEdit104.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_PostalAddress_BuildingNumber", true));
            this.textEdit104.EnterMoveNextControl = true;
            this.textEdit104.Location = new System.Drawing.Point(288, 328);
            this.textEdit104.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit104.Name = "textEdit104";
            this.textEdit104.Size = new System.Drawing.Size(872, 20);
            this.textEdit104.StyleController = this.dataLayoutCustomer;
            this.textEdit104.TabIndex = 87;
            // 
            // textEdit105
            // 
            this.textEdit105.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_PostalAddress_CitySubdivisionName", true));
            this.textEdit105.EnterMoveNextControl = true;
            this.textEdit105.Location = new System.Drawing.Point(288, 352);
            this.textEdit105.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit105.Name = "textEdit105";
            this.textEdit105.Size = new System.Drawing.Size(872, 20);
            this.textEdit105.StyleController = this.dataLayoutCustomer;
            this.textEdit105.TabIndex = 88;
            // 
            // textEdit106
            // 
            this.textEdit106.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_PostalAddress_CityName", true));
            this.textEdit106.EnterMoveNextControl = true;
            this.textEdit106.Location = new System.Drawing.Point(288, 376);
            this.textEdit106.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit106.Name = "textEdit106";
            this.textEdit106.Size = new System.Drawing.Size(872, 20);
            this.textEdit106.StyleController = this.dataLayoutCustomer;
            this.textEdit106.TabIndex = 89;
            // 
            // textEdit107
            // 
            this.textEdit107.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_PostalAddress_Country", true));
            this.textEdit107.EnterMoveNextControl = true;
            this.textEdit107.Location = new System.Drawing.Point(288, 400);
            this.textEdit107.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit107.Name = "textEdit107";
            this.textEdit107.Size = new System.Drawing.Size(872, 20);
            this.textEdit107.StyleController = this.dataLayoutCustomer;
            this.textEdit107.TabIndex = 90;
            // 
            // textEdit108
            // 
            this.textEdit108.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ASP_PartyTaxSchemeName", true));
            this.textEdit108.EnterMoveNextControl = true;
            this.textEdit108.Location = new System.Drawing.Point(288, 424);
            this.textEdit108.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit108.Name = "textEdit108";
            this.textEdit108.Size = new System.Drawing.Size(872, 20);
            this.textEdit108.StyleController = this.dataLayoutCustomer;
            this.textEdit108.TabIndex = 91;
            // 
            // textEdit109
            // 
            this.textEdit109.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_Contact_Telephone", true));
            this.textEdit109.EnterMoveNextControl = true;
            this.textEdit109.Location = new System.Drawing.Point(288, 496);
            this.textEdit109.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit109.Name = "textEdit109";
            this.textEdit109.Size = new System.Drawing.Size(872, 20);
            this.textEdit109.StyleController = this.dataLayoutCustomer;
            this.textEdit109.TabIndex = 92;
            // 
            // textEdit110
            // 
            this.textEdit110.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_Contact_Telefax", true));
            this.textEdit110.EnterMoveNextControl = true;
            this.textEdit110.Location = new System.Drawing.Point(288, 520);
            this.textEdit110.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit110.Name = "textEdit110";
            this.textEdit110.Size = new System.Drawing.Size(872, 20);
            this.textEdit110.StyleController = this.dataLayoutCustomer;
            this.textEdit110.TabIndex = 93;
            // 
            // textEdit111
            // 
            this.textEdit111.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_Contact_ElectronicMail", true));
            this.textEdit111.EnterMoveNextControl = true;
            this.textEdit111.Location = new System.Drawing.Point(288, 544);
            this.textEdit111.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit111.Name = "textEdit111";
            this.textEdit111.Size = new System.Drawing.Size(872, 20);
            this.textEdit111.StyleController = this.dataLayoutCustomer;
            this.textEdit111.TabIndex = 94;
            // 
            // textEdit112
            // 
            this.textEdit112.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_Person_FirstName", true));
            this.textEdit112.EnterMoveNextControl = true;
            this.textEdit112.Location = new System.Drawing.Point(288, 568);
            this.textEdit112.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit112.Name = "textEdit112";
            this.textEdit112.Size = new System.Drawing.Size(872, 20);
            this.textEdit112.StyleController = this.dataLayoutCustomer;
            this.textEdit112.TabIndex = 95;
            // 
            // textEdit113
            // 
            this.textEdit113.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_Person_FamilyName", true));
            this.textEdit113.EnterMoveNextControl = true;
            this.textEdit113.Location = new System.Drawing.Point(288, 592);
            this.textEdit113.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit113.Name = "textEdit113";
            this.textEdit113.Size = new System.Drawing.Size(872, 20);
            this.textEdit113.StyleController = this.dataLayoutCustomer;
            this.textEdit113.TabIndex = 96;
            // 
            // textEdit114
            // 
            this.textEdit114.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_AgentParty_PartyIdentification1_schemeID", true));
            this.textEdit114.EnterMoveNextControl = true;
            this.textEdit114.Location = new System.Drawing.Point(288, 616);
            this.textEdit114.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit114.Name = "textEdit114";
            this.textEdit114.Size = new System.Drawing.Size(872, 20);
            this.textEdit114.StyleController = this.dataLayoutCustomer;
            this.textEdit114.TabIndex = 97;
            // 
            // textEdit115
            // 
            this.textEdit115.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_AgentParty_PartyIdentification1_ID", true));
            this.textEdit115.EnterMoveNextControl = true;
            this.textEdit115.Location = new System.Drawing.Point(288, 640);
            this.textEdit115.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit115.Name = "textEdit115";
            this.textEdit115.Size = new System.Drawing.Size(872, 20);
            this.textEdit115.StyleController = this.dataLayoutCustomer;
            this.textEdit115.TabIndex = 98;
            // 
            // textEdit116
            // 
            this.textEdit116.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_AgentParty_PartyIdentification2_schemeID", true));
            this.textEdit116.EnterMoveNextControl = true;
            this.textEdit116.Location = new System.Drawing.Point(288, 664);
            this.textEdit116.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit116.Name = "textEdit116";
            this.textEdit116.Size = new System.Drawing.Size(872, 20);
            this.textEdit116.StyleController = this.dataLayoutCustomer;
            this.textEdit116.TabIndex = 99;
            // 
            // textEdit117
            // 
            this.textEdit117.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_AgentParty_PartyIdentification2_ID", true));
            this.textEdit117.EnterMoveNextControl = true;
            this.textEdit117.Location = new System.Drawing.Point(288, 688);
            this.textEdit117.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit117.Name = "textEdit117";
            this.textEdit117.Size = new System.Drawing.Size(872, 20);
            this.textEdit117.StyleController = this.dataLayoutCustomer;
            this.textEdit117.TabIndex = 100;
            // 
            // textEdit118
            // 
            this.textEdit118.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_AgentParty_PartyIdentification3_schemeID", true));
            this.textEdit118.EnterMoveNextControl = true;
            this.textEdit118.Location = new System.Drawing.Point(288, 712);
            this.textEdit118.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit118.Name = "textEdit118";
            this.textEdit118.Size = new System.Drawing.Size(872, 20);
            this.textEdit118.StyleController = this.dataLayoutCustomer;
            this.textEdit118.TabIndex = 101;
            // 
            // textEdit119
            // 
            this.textEdit119.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_AgentParty_PartyIdentification3_ID", true));
            this.textEdit119.EnterMoveNextControl = true;
            this.textEdit119.Location = new System.Drawing.Point(288, 736);
            this.textEdit119.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit119.Name = "textEdit119";
            this.textEdit119.Size = new System.Drawing.Size(872, 20);
            this.textEdit119.StyleController = this.dataLayoutCustomer;
            this.textEdit119.TabIndex = 102;
            // 
            // textEdit120
            // 
            this.textEdit120.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_AgentParty_PartyIdentification4_schemeID", true));
            this.textEdit120.EnterMoveNextControl = true;
            this.textEdit120.Location = new System.Drawing.Point(288, 760);
            this.textEdit120.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit120.Name = "textEdit120";
            this.textEdit120.Size = new System.Drawing.Size(872, 20);
            this.textEdit120.StyleController = this.dataLayoutCustomer;
            this.textEdit120.TabIndex = 103;
            // 
            // textEdit121
            // 
            this.textEdit121.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_AgentParty_PartyIdentification4_ID", true));
            this.textEdit121.EnterMoveNextControl = true;
            this.textEdit121.Location = new System.Drawing.Point(288, 784);
            this.textEdit121.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit121.Name = "textEdit121";
            this.textEdit121.Size = new System.Drawing.Size(872, 20);
            this.textEdit121.StyleController = this.dataLayoutCustomer;
            this.textEdit121.TabIndex = 104;
            // 
            // textEdit122
            // 
            this.textEdit122.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_AgentParty_PartyIdentification5_schemeID", true));
            this.textEdit122.EnterMoveNextControl = true;
            this.textEdit122.Location = new System.Drawing.Point(288, 808);
            this.textEdit122.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit122.Name = "textEdit122";
            this.textEdit122.Size = new System.Drawing.Size(872, 20);
            this.textEdit122.StyleController = this.dataLayoutCustomer;
            this.textEdit122.TabIndex = 105;
            // 
            // textEdit123
            // 
            this.textEdit123.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_AgentParty_PartyIdentification5_ID", true));
            this.textEdit123.EnterMoveNextControl = true;
            this.textEdit123.Location = new System.Drawing.Point(288, 832);
            this.textEdit123.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit123.Name = "textEdit123";
            this.textEdit123.Size = new System.Drawing.Size(872, 20);
            this.textEdit123.StyleController = this.dataLayoutCustomer;
            this.textEdit123.TabIndex = 106;
            // 
            // textEdit124
            // 
            this.textEdit124.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_AgentParty_PartyName", true));
            this.textEdit124.EnterMoveNextControl = true;
            this.textEdit124.Location = new System.Drawing.Point(288, 856);
            this.textEdit124.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit124.Name = "textEdit124";
            this.textEdit124.Size = new System.Drawing.Size(872, 20);
            this.textEdit124.StyleController = this.dataLayoutCustomer;
            this.textEdit124.TabIndex = 107;
            // 
            // textEdit125
            // 
            this.textEdit125.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_AgentParty_PostalAddress_StreetName", true));
            this.textEdit125.EnterMoveNextControl = true;
            this.textEdit125.Location = new System.Drawing.Point(288, 880);
            this.textEdit125.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit125.Name = "textEdit125";
            this.textEdit125.Size = new System.Drawing.Size(872, 20);
            this.textEdit125.StyleController = this.dataLayoutCustomer;
            this.textEdit125.TabIndex = 108;
            // 
            // textEdit126
            // 
            this.textEdit126.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_AgentParty_PostalAddress_Room", true));
            this.textEdit126.EnterMoveNextControl = true;
            this.textEdit126.Location = new System.Drawing.Point(288, 904);
            this.textEdit126.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit126.Name = "textEdit126";
            this.textEdit126.Size = new System.Drawing.Size(872, 20);
            this.textEdit126.StyleController = this.dataLayoutCustomer;
            this.textEdit126.TabIndex = 109;
            // 
            // textEdit127
            // 
            this.textEdit127.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_AgentParty_PostalAddress_BuildingNumber", true));
            this.textEdit127.EnterMoveNextControl = true;
            this.textEdit127.Location = new System.Drawing.Point(288, 928);
            this.textEdit127.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit127.Name = "textEdit127";
            this.textEdit127.Size = new System.Drawing.Size(872, 20);
            this.textEdit127.StyleController = this.dataLayoutCustomer;
            this.textEdit127.TabIndex = 110;
            // 
            // textEdit128
            // 
            this.textEdit128.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_AgentParty_PostalAddress_CitySubdivisionName", true));
            this.textEdit128.EnterMoveNextControl = true;
            this.textEdit128.Location = new System.Drawing.Point(288, 952);
            this.textEdit128.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit128.Name = "textEdit128";
            this.textEdit128.Size = new System.Drawing.Size(872, 20);
            this.textEdit128.StyleController = this.dataLayoutCustomer;
            this.textEdit128.TabIndex = 111;
            // 
            // textEdit129
            // 
            this.textEdit129.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_AgentParty_PostalAddress_CityName", true));
            this.textEdit129.EnterMoveNextControl = true;
            this.textEdit129.Location = new System.Drawing.Point(288, 976);
            this.textEdit129.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit129.Name = "textEdit129";
            this.textEdit129.Size = new System.Drawing.Size(872, 20);
            this.textEdit129.StyleController = this.dataLayoutCustomer;
            this.textEdit129.TabIndex = 112;
            // 
            // textEdit130
            // 
            this.textEdit130.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_AgentParty_PostalAddress_Country", true));
            this.textEdit130.EnterMoveNextControl = true;
            this.textEdit130.Location = new System.Drawing.Point(288, 1000);
            this.textEdit130.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit130.Name = "textEdit130";
            this.textEdit130.Size = new System.Drawing.Size(872, 20);
            this.textEdit130.StyleController = this.dataLayoutCustomer;
            this.textEdit130.TabIndex = 113;
            // 
            // textEdit131
            // 
            this.textEdit131.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_AgentParty_PartyTaxSchemeName", true));
            this.textEdit131.EnterMoveNextControl = true;
            this.textEdit131.Location = new System.Drawing.Point(288, 1024);
            this.textEdit131.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit131.Name = "textEdit131";
            this.textEdit131.Size = new System.Drawing.Size(872, 20);
            this.textEdit131.StyleController = this.dataLayoutCustomer;
            this.textEdit131.TabIndex = 114;
            // 
            // textEdit132
            // 
            this.textEdit132.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_AgentParty_Contact_Telephone", true));
            this.textEdit132.EnterMoveNextControl = true;
            this.textEdit132.Location = new System.Drawing.Point(288, 1096);
            this.textEdit132.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit132.Name = "textEdit132";
            this.textEdit132.Size = new System.Drawing.Size(872, 20);
            this.textEdit132.StyleController = this.dataLayoutCustomer;
            this.textEdit132.TabIndex = 115;
            // 
            // textEdit133
            // 
            this.textEdit133.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_AgentParty_Contact_Telefax", true));
            this.textEdit133.EnterMoveNextControl = true;
            this.textEdit133.Location = new System.Drawing.Point(288, 1120);
            this.textEdit133.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit133.Name = "textEdit133";
            this.textEdit133.Size = new System.Drawing.Size(872, 20);
            this.textEdit133.StyleController = this.dataLayoutCustomer;
            this.textEdit133.TabIndex = 116;
            // 
            // textEdit134
            // 
            this.textEdit134.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ACP_AgentParty_Contact_ElectronicMail", true));
            this.textEdit134.EnterMoveNextControl = true;
            this.textEdit134.Location = new System.Drawing.Point(288, 1144);
            this.textEdit134.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit134.Name = "textEdit134";
            this.textEdit134.Size = new System.Drawing.Size(872, 20);
            this.textEdit134.StyleController = this.dataLayoutCustomer;
            this.textEdit134.TabIndex = 117;
            // 
            // layoutControlGroup21
            // 
            this.layoutControlGroup21.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup21.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup21.GroupBordersVisible = false;
            this.layoutControlGroup21.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup22,
            this.layoutControlGroup23,
            this.layoutControlGroup24,
            this.layoutControlGroup25,
            this.layoutControlGroup26,
            this.layoutControlGroup27,
            this.layoutControlGroup28,
            this.layoutControlGroup29,
            this.layoutControlGroup30});
            this.layoutControlGroup21.Name = "layoutControlGroup1";
            this.layoutControlGroup21.Size = new System.Drawing.Size(1172, 1178);
            this.layoutControlGroup21.TextVisible = false;
            // 
            // layoutControlGroup22
            // 
            this.layoutControlGroup22.AllowDrawBackground = false;
            this.layoutControlGroup22.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup22.GroupBordersVisible = false;
            this.layoutControlGroup22.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup22.Name = "autoGeneratedGroup0";
            this.layoutControlGroup22.Size = new System.Drawing.Size(1152, 1);
            // 
            // layoutControlGroup23
            // 
            this.layoutControlGroup23.AllowDrawBackground = false;
            this.layoutControlGroup23.CustomizationFormText = "autoGeneratedGroup1";
            this.layoutControlGroup23.GroupBordersVisible = false;
            this.layoutControlGroup23.Location = new System.Drawing.Point(0, 1);
            this.layoutControlGroup23.Name = "autoGeneratedGroup1";
            this.layoutControlGroup23.Size = new System.Drawing.Size(1152, 1);
            // 
            // layoutControlGroup24
            // 
            this.layoutControlGroup24.AllowDrawBackground = false;
            this.layoutControlGroup24.CustomizationFormText = "autoGeneratedGroup2";
            this.layoutControlGroup24.GroupBordersVisible = false;
            this.layoutControlGroup24.Location = new System.Drawing.Point(0, 2);
            this.layoutControlGroup24.Name = "autoGeneratedGroup2";
            this.layoutControlGroup24.Size = new System.Drawing.Size(1152, 1);
            // 
            // layoutControlGroup25
            // 
            this.layoutControlGroup25.AllowDrawBackground = false;
            this.layoutControlGroup25.CustomizationFormText = "autoGeneratedGroup3";
            this.layoutControlGroup25.GroupBordersVisible = false;
            this.layoutControlGroup25.Location = new System.Drawing.Point(0, 3);
            this.layoutControlGroup25.Name = "autoGeneratedGroup3";
            this.layoutControlGroup25.Size = new System.Drawing.Size(1152, 1);
            // 
            // layoutControlGroup26
            // 
            this.layoutControlGroup26.AllowDrawBackground = false;
            this.layoutControlGroup26.CustomizationFormText = "autoGeneratedGroup4";
            this.layoutControlGroup26.GroupBordersVisible = false;
            this.layoutControlGroup26.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem89,
            this.layoutControlItem90,
            this.layoutControlItem91,
            this.layoutControlItem92,
            this.layoutControlItem93,
            this.layoutControlItem94,
            this.layoutControlItem95,
            this.layoutControlItem96,
            this.layoutControlItem97,
            this.layoutControlItem98,
            this.layoutControlItem99,
            this.layoutControlItem100,
            this.layoutControlItem101,
            this.layoutControlItem102});
            this.layoutControlGroup26.Location = new System.Drawing.Point(0, 4);
            this.layoutControlGroup26.Name = "autoGeneratedGroup4";
            this.layoutControlGroup26.Size = new System.Drawing.Size(1152, 336);
            // 
            // layoutControlItem89
            // 
            this.layoutControlItem89.Control = this.textEdit91;
            this.layoutControlItem89.CustomizationFormText = "ACP_Party Identification1_scheme ID";
            this.layoutControlItem89.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem89.Name = "ItemForACP_PartyIdentification1_schemeID";
            this.layoutControlItem89.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem89.Text = "ACP_Party Identification1_scheme ID";
            this.layoutControlItem89.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem90
            // 
            this.layoutControlItem90.Control = this.textEdit92;
            this.layoutControlItem90.CustomizationFormText = "ACP_Party Identification1_ID";
            this.layoutControlItem90.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem90.Name = "ItemForACP_PartyIdentification1_ID";
            this.layoutControlItem90.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem90.Text = "ACP_Party Identification1_ID";
            this.layoutControlItem90.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem91
            // 
            this.layoutControlItem91.Control = this.textEdit93;
            this.layoutControlItem91.CustomizationFormText = "ACP_Party Identification2_scheme ID";
            this.layoutControlItem91.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem91.Name = "ItemForACP_PartyIdentification2_schemeID";
            this.layoutControlItem91.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem91.Text = "ACP_Party Identification2_scheme ID";
            this.layoutControlItem91.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem92
            // 
            this.layoutControlItem92.Control = this.textEdit94;
            this.layoutControlItem92.CustomizationFormText = "ACP_Party Identification2_ID";
            this.layoutControlItem92.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem92.Name = "ItemForACP_PartyIdentification2_ID";
            this.layoutControlItem92.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem92.Text = "ACP_Party Identification2_ID";
            this.layoutControlItem92.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem93
            // 
            this.layoutControlItem93.Control = this.textEdit95;
            this.layoutControlItem93.CustomizationFormText = "ACP_Party Identification3_scheme ID";
            this.layoutControlItem93.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem93.Name = "ItemForACP_PartyIdentification3_schemeID";
            this.layoutControlItem93.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem93.Text = "ACP_Party Identification3_scheme ID";
            this.layoutControlItem93.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem94
            // 
            this.layoutControlItem94.Control = this.textEdit96;
            this.layoutControlItem94.CustomizationFormText = "ACP_Party Identification3_ID";
            this.layoutControlItem94.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem94.Name = "ItemForACP_PartyIdentification3_ID";
            this.layoutControlItem94.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem94.Text = "ACP_Party Identification3_ID";
            this.layoutControlItem94.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem95
            // 
            this.layoutControlItem95.Control = this.textEdit97;
            this.layoutControlItem95.CustomizationFormText = "ACP_Party Identification4_scheme ID";
            this.layoutControlItem95.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem95.Name = "ItemForACP_PartyIdentification4_schemeID";
            this.layoutControlItem95.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem95.Text = "ACP_Party Identification4_scheme ID";
            this.layoutControlItem95.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem96
            // 
            this.layoutControlItem96.Control = this.textEdit98;
            this.layoutControlItem96.CustomizationFormText = "ACP_Party Identification4_ID";
            this.layoutControlItem96.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem96.Name = "ItemForACP_PartyIdentification4_ID";
            this.layoutControlItem96.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem96.Text = "ACP_Party Identification4_ID";
            this.layoutControlItem96.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem97
            // 
            this.layoutControlItem97.Control = this.textEdit99;
            this.layoutControlItem97.CustomizationFormText = "ACP_Party Identification5_scheme ID";
            this.layoutControlItem97.Location = new System.Drawing.Point(0, 192);
            this.layoutControlItem97.Name = "ItemForACP_PartyIdentification5_schemeID";
            this.layoutControlItem97.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem97.Text = "ACP_Party Identification5_scheme ID";
            this.layoutControlItem97.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem98
            // 
            this.layoutControlItem98.Control = this.textEdit100;
            this.layoutControlItem98.CustomizationFormText = "ACP_Party Identification5_ID";
            this.layoutControlItem98.Location = new System.Drawing.Point(0, 216);
            this.layoutControlItem98.Name = "ItemForACP_PartyIdentification5_ID";
            this.layoutControlItem98.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem98.Text = "ACP_Party Identification5_ID";
            this.layoutControlItem98.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem99
            // 
            this.layoutControlItem99.Control = this.textEdit101;
            this.layoutControlItem99.CustomizationFormText = "ACP_Party Name";
            this.layoutControlItem99.Location = new System.Drawing.Point(0, 240);
            this.layoutControlItem99.Name = "ItemForACP_PartyName";
            this.layoutControlItem99.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem99.Text = "ACP_Party Name";
            this.layoutControlItem99.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem100
            // 
            this.layoutControlItem100.Control = this.textEdit102;
            this.layoutControlItem100.CustomizationFormText = "ACP_Postal Address_Street Name";
            this.layoutControlItem100.Location = new System.Drawing.Point(0, 264);
            this.layoutControlItem100.Name = "ItemForACP_PostalAddress_StreetName";
            this.layoutControlItem100.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem100.Text = "ACP_Postal Address_Street Name";
            this.layoutControlItem100.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem101
            // 
            this.layoutControlItem101.Control = this.textEdit103;
            this.layoutControlItem101.CustomizationFormText = "ACP_Postal Address_Room";
            this.layoutControlItem101.Location = new System.Drawing.Point(0, 288);
            this.layoutControlItem101.Name = "ItemForACP_PostalAddress_Room";
            this.layoutControlItem101.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem101.Text = "ACP_Postal Address_Room";
            this.layoutControlItem101.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem102
            // 
            this.layoutControlItem102.Control = this.textEdit104;
            this.layoutControlItem102.CustomizationFormText = "ACP_Postal Address_Building Number";
            this.layoutControlItem102.Location = new System.Drawing.Point(0, 312);
            this.layoutControlItem102.Name = "ItemForACP_PostalAddress_BuildingNumber";
            this.layoutControlItem102.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem102.Text = "ACP_Postal Address_Building Number";
            this.layoutControlItem102.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlGroup27
            // 
            this.layoutControlGroup27.AllowDrawBackground = false;
            this.layoutControlGroup27.CustomizationFormText = "autoGeneratedGroup5";
            this.layoutControlGroup27.GroupBordersVisible = false;
            this.layoutControlGroup27.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem103,
            this.layoutControlItem104,
            this.layoutControlItem105,
            this.layoutControlItem106,
            this.layoutControlItem107,
            this.layoutControlItem108,
            this.layoutControlItem109,
            this.layoutControlItem110,
            this.layoutControlItem111,
            this.layoutControlItem112,
            this.layoutControlItem113,
            this.layoutControlItem114,
            this.layoutControlItem115,
            this.layoutControlItem116,
            this.layoutControlItem117,
            this.layoutControlItem118,
            this.layoutControlItem119,
            this.layoutControlItem47,
            this.layoutControlItem48});
            this.layoutControlGroup27.Location = new System.Drawing.Point(0, 340);
            this.layoutControlGroup27.Name = "autoGeneratedGroup5";
            this.layoutControlGroup27.Size = new System.Drawing.Size(1152, 456);
            // 
            // layoutControlItem103
            // 
            this.layoutControlItem103.Control = this.textEdit105;
            this.layoutControlItem103.CustomizationFormText = "ACP_Postal Address_City Subdivision Name";
            this.layoutControlItem103.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem103.Name = "ItemForACP_PostalAddress_CitySubdivisionName";
            this.layoutControlItem103.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem103.Text = "ACP_Postal Address_City Subdivision Name";
            this.layoutControlItem103.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem104
            // 
            this.layoutControlItem104.Control = this.textEdit106;
            this.layoutControlItem104.CustomizationFormText = "ACP_Postal Address_City Name";
            this.layoutControlItem104.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem104.Name = "ItemForACP_PostalAddress_CityName";
            this.layoutControlItem104.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem104.Text = "ACP_Postal Address_City Name";
            this.layoutControlItem104.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem105
            // 
            this.layoutControlItem105.Control = this.textEdit107;
            this.layoutControlItem105.CustomizationFormText = "ACP_Postal Address_Country";
            this.layoutControlItem105.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem105.Name = "ItemForACP_PostalAddress_Country";
            this.layoutControlItem105.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem105.Text = "ACP_Postal Address_Country";
            this.layoutControlItem105.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem106
            // 
            this.layoutControlItem106.Control = this.textEdit108;
            this.layoutControlItem106.CustomizationFormText = "ACP_Party Tax Scheme";
            this.layoutControlItem106.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem106.Name = "ItemForACP_PartyTaxScheme";
            this.layoutControlItem106.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem106.Text = "ACP_Party Tax Scheme";
            this.layoutControlItem106.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem107
            // 
            this.layoutControlItem107.Control = this.textEdit109;
            this.layoutControlItem107.CustomizationFormText = "ACP_Contact_Telephone";
            this.layoutControlItem107.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem107.Name = "ItemForACP_Contact_Telephone";
            this.layoutControlItem107.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem107.Text = "ACP_Contact_Telephone";
            this.layoutControlItem107.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem108
            // 
            this.layoutControlItem108.Control = this.textEdit110;
            this.layoutControlItem108.CustomizationFormText = "ACP_Contact_Telefax";
            this.layoutControlItem108.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem108.Name = "ItemForACP_Contact_Telefax";
            this.layoutControlItem108.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem108.Text = "ACP_Contact_Telefax";
            this.layoutControlItem108.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem109
            // 
            this.layoutControlItem109.Control = this.textEdit111;
            this.layoutControlItem109.CustomizationFormText = "ACP_Contact_Electronic Mail";
            this.layoutControlItem109.Location = new System.Drawing.Point(0, 192);
            this.layoutControlItem109.Name = "ItemForACP_Contact_ElectronicMail";
            this.layoutControlItem109.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem109.Text = "ACP_Contact_Electronic Mail";
            this.layoutControlItem109.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem110
            // 
            this.layoutControlItem110.Control = this.textEdit112;
            this.layoutControlItem110.CustomizationFormText = "ACP_Person_First Name";
            this.layoutControlItem110.Location = new System.Drawing.Point(0, 216);
            this.layoutControlItem110.Name = "ItemForACP_Person_FirstName";
            this.layoutControlItem110.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem110.Text = "ACP_Person_First Name";
            this.layoutControlItem110.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem111
            // 
            this.layoutControlItem111.Control = this.textEdit113;
            this.layoutControlItem111.CustomizationFormText = "ACP_Person_Family Name";
            this.layoutControlItem111.Location = new System.Drawing.Point(0, 240);
            this.layoutControlItem111.Name = "ItemForACP_Person_FamilyName";
            this.layoutControlItem111.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem111.Text = "ACP_Person_Family Name";
            this.layoutControlItem111.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem112
            // 
            this.layoutControlItem112.Control = this.textEdit114;
            this.layoutControlItem112.CustomizationFormText = "ACP_Agent Party_Party Identification1_scheme ID";
            this.layoutControlItem112.Location = new System.Drawing.Point(0, 264);
            this.layoutControlItem112.Name = "ItemForACP_AgentParty_PartyIdentification1_schemeID";
            this.layoutControlItem112.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem112.Text = "ACP_Agent Party_Party Identification1_scheme ID";
            this.layoutControlItem112.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem113
            // 
            this.layoutControlItem113.Control = this.textEdit115;
            this.layoutControlItem113.CustomizationFormText = "ACP_Agent Party_Party Identification1_ID";
            this.layoutControlItem113.Location = new System.Drawing.Point(0, 288);
            this.layoutControlItem113.Name = "ItemForACP_AgentParty_PartyIdentification1_ID";
            this.layoutControlItem113.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem113.Text = "ACP_Agent Party_Party Identification1_ID";
            this.layoutControlItem113.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem114
            // 
            this.layoutControlItem114.Control = this.textEdit116;
            this.layoutControlItem114.CustomizationFormText = "ACP_Agent Party_Party Identification2_scheme ID";
            this.layoutControlItem114.Location = new System.Drawing.Point(0, 312);
            this.layoutControlItem114.Name = "ItemForACP_AgentParty_PartyIdentification2_schemeID";
            this.layoutControlItem114.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem114.Text = "ACP_Agent Party_Party Identification2_scheme ID";
            this.layoutControlItem114.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem115
            // 
            this.layoutControlItem115.Control = this.textEdit117;
            this.layoutControlItem115.CustomizationFormText = "ACP_Agent Party_Party Identification2_ID";
            this.layoutControlItem115.Location = new System.Drawing.Point(0, 336);
            this.layoutControlItem115.Name = "ItemForACP_AgentParty_PartyIdentification2_ID";
            this.layoutControlItem115.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem115.Text = "ACP_Agent Party_Party Identification2_ID";
            this.layoutControlItem115.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem116
            // 
            this.layoutControlItem116.Control = this.textEdit118;
            this.layoutControlItem116.CustomizationFormText = "ACP_Agent Party_Party Identification3_scheme ID";
            this.layoutControlItem116.Location = new System.Drawing.Point(0, 360);
            this.layoutControlItem116.Name = "ItemForACP_AgentParty_PartyIdentification3_schemeID";
            this.layoutControlItem116.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem116.Text = "ACP_Agent Party_Party Identification3_scheme ID";
            this.layoutControlItem116.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem117
            // 
            this.layoutControlItem117.Control = this.textEdit119;
            this.layoutControlItem117.CustomizationFormText = "ACP_Agent Party_Party Identification3_ID";
            this.layoutControlItem117.Location = new System.Drawing.Point(0, 384);
            this.layoutControlItem117.Name = "ItemForACP_AgentParty_PartyIdentification3_ID";
            this.layoutControlItem117.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem117.Text = "ACP_Agent Party_Party Identification3_ID";
            this.layoutControlItem117.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem118
            // 
            this.layoutControlItem118.Control = this.textEdit120;
            this.layoutControlItem118.CustomizationFormText = "ACP_Agent Party_Party Identification4_scheme ID";
            this.layoutControlItem118.Location = new System.Drawing.Point(0, 408);
            this.layoutControlItem118.Name = "ItemForACP_AgentParty_PartyIdentification4_schemeID";
            this.layoutControlItem118.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem118.Text = "ACP_Agent Party_Party Identification4_scheme ID";
            this.layoutControlItem118.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem119
            // 
            this.layoutControlItem119.Control = this.textEdit121;
            this.layoutControlItem119.CustomizationFormText = "ACP_Agent Party_Party Identification4_ID";
            this.layoutControlItem119.Location = new System.Drawing.Point(0, 432);
            this.layoutControlItem119.Name = "ItemForACP_AgentParty_PartyIdentification4_ID";
            this.layoutControlItem119.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem119.Text = "ACP_Agent Party_Party Identification4_ID";
            this.layoutControlItem119.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem47
            // 
            this.layoutControlItem47.Control = this.textEdit51;
            this.layoutControlItem47.CustomizationFormText = "ACP_PartyTaxSchemeTaxTypeCode";
            this.layoutControlItem47.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem47.Name = "layoutControlItem47";
            this.layoutControlItem47.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem47.Text = "ACP_PartyTaxSchemeTaxTypeCode";
            this.layoutControlItem47.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem48
            // 
            this.layoutControlItem48.Control = this.textEdit50;
            this.layoutControlItem48.CustomizationFormText = "ACP_WebsiteURI";
            this.layoutControlItem48.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem48.Name = "layoutControlItem48";
            this.layoutControlItem48.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem48.Text = "ACP_WebsiteURI";
            this.layoutControlItem48.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlGroup28
            // 
            this.layoutControlGroup28.AllowDrawBackground = false;
            this.layoutControlGroup28.CustomizationFormText = "autoGeneratedGroup6";
            this.layoutControlGroup28.GroupBordersVisible = false;
            this.layoutControlGroup28.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem120,
            this.layoutControlItem121,
            this.layoutControlItem122,
            this.layoutControlItem123,
            this.layoutControlItem124,
            this.layoutControlItem125,
            this.layoutControlItem126,
            this.layoutControlItem127,
            this.layoutControlItem128,
            this.layoutControlItem129,
            this.layoutControlItem130,
            this.layoutControlItem131,
            this.layoutControlItem132,
            this.layoutControlItem49,
            this.layoutControlItem50});
            this.layoutControlGroup28.Location = new System.Drawing.Point(0, 796);
            this.layoutControlGroup28.Name = "autoGeneratedGroup6";
            this.layoutControlGroup28.Size = new System.Drawing.Size(1152, 360);
            // 
            // layoutControlItem120
            // 
            this.layoutControlItem120.Control = this.textEdit122;
            this.layoutControlItem120.CustomizationFormText = "ACP_Agent Party_Party Identification5_scheme ID";
            this.layoutControlItem120.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem120.Name = "ItemForACP_AgentParty_PartyIdentification5_schemeID";
            this.layoutControlItem120.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem120.Text = "ACP_Agent Party_Party Identification5_scheme ID";
            this.layoutControlItem120.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem121
            // 
            this.layoutControlItem121.Control = this.textEdit123;
            this.layoutControlItem121.CustomizationFormText = "ACP_Agent Party_Party Identification5_ID";
            this.layoutControlItem121.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem121.Name = "ItemForACP_AgentParty_PartyIdentification5_ID";
            this.layoutControlItem121.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem121.Text = "ACP_Agent Party_Party Identification5_ID";
            this.layoutControlItem121.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem122
            // 
            this.layoutControlItem122.Control = this.textEdit124;
            this.layoutControlItem122.CustomizationFormText = "ACP_Agent Party_Party Name";
            this.layoutControlItem122.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem122.Name = "ItemForACP_AgentParty_PartyName";
            this.layoutControlItem122.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem122.Text = "ACP_Agent Party_Party Name";
            this.layoutControlItem122.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem123
            // 
            this.layoutControlItem123.Control = this.textEdit125;
            this.layoutControlItem123.CustomizationFormText = "ACP_Agent Party_Postal Address_Street Name";
            this.layoutControlItem123.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem123.Name = "ItemForACP_AgentParty_PostalAddress_StreetName";
            this.layoutControlItem123.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem123.Text = "ACP_Agent Party_Postal Address_Street Name";
            this.layoutControlItem123.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem124
            // 
            this.layoutControlItem124.Control = this.textEdit126;
            this.layoutControlItem124.CustomizationFormText = "ACP_Agent Party_Postal Address_Room";
            this.layoutControlItem124.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem124.Name = "ItemForACP_AgentParty_PostalAddress_Room";
            this.layoutControlItem124.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem124.Text = "ACP_Agent Party_Postal Address_Room";
            this.layoutControlItem124.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem125
            // 
            this.layoutControlItem125.Control = this.textEdit127;
            this.layoutControlItem125.CustomizationFormText = "ACP_Agent Party_Postal Address_Building Number";
            this.layoutControlItem125.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem125.Name = "ItemForACP_AgentParty_PostalAddress_BuildingNumber";
            this.layoutControlItem125.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem125.Text = "ACP_Agent Party_Postal Address_Building Number";
            this.layoutControlItem125.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem126
            // 
            this.layoutControlItem126.Control = this.textEdit128;
            this.layoutControlItem126.CustomizationFormText = "ACP_Agent Party_Postal Address_City Subdivision Name";
            this.layoutControlItem126.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem126.Name = "ItemForACP_AgentParty_PostalAddress_CitySubdivisionName";
            this.layoutControlItem126.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem126.Text = "ACP_Agent Party_Postal Address_City Subdivision Name";
            this.layoutControlItem126.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem127
            // 
            this.layoutControlItem127.Control = this.textEdit129;
            this.layoutControlItem127.CustomizationFormText = "ACP_Agent Party_Postal Address_City Name";
            this.layoutControlItem127.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem127.Name = "ItemForACP_AgentParty_PostalAddress_CityName";
            this.layoutControlItem127.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem127.Text = "ACP_Agent Party_Postal Address_City Name";
            this.layoutControlItem127.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem128
            // 
            this.layoutControlItem128.Control = this.textEdit130;
            this.layoutControlItem128.CustomizationFormText = "ACP_Agent Party_Postal Address_Country";
            this.layoutControlItem128.Location = new System.Drawing.Point(0, 192);
            this.layoutControlItem128.Name = "ItemForACP_AgentParty_PostalAddress_Country";
            this.layoutControlItem128.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem128.Text = "ACP_Agent Party_Postal Address_Country";
            this.layoutControlItem128.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem129
            // 
            this.layoutControlItem129.Control = this.textEdit131;
            this.layoutControlItem129.CustomizationFormText = "ACP_Agent Party_Party Tax Scheme";
            this.layoutControlItem129.Location = new System.Drawing.Point(0, 216);
            this.layoutControlItem129.Name = "ItemForACP_AgentParty_PartyTaxScheme";
            this.layoutControlItem129.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem129.Text = "ACP_Agent Party_Party Tax Scheme";
            this.layoutControlItem129.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem130
            // 
            this.layoutControlItem130.Control = this.textEdit132;
            this.layoutControlItem130.CustomizationFormText = "ACP_Agent Party_Contact_Telephone";
            this.layoutControlItem130.Location = new System.Drawing.Point(0, 288);
            this.layoutControlItem130.Name = "ItemForACP_AgentParty_Contact_Telephone";
            this.layoutControlItem130.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem130.Text = "ACP_Agent Party_Contact_Telephone";
            this.layoutControlItem130.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem131
            // 
            this.layoutControlItem131.Control = this.textEdit133;
            this.layoutControlItem131.CustomizationFormText = "ACP_Agent Party_Contact_Telefax";
            this.layoutControlItem131.Location = new System.Drawing.Point(0, 312);
            this.layoutControlItem131.Name = "ItemForACP_AgentParty_Contact_Telefax";
            this.layoutControlItem131.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem131.Text = "ACP_Agent Party_Contact_Telefax";
            this.layoutControlItem131.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem132
            // 
            this.layoutControlItem132.Control = this.textEdit134;
            this.layoutControlItem132.CustomizationFormText = "ACP_Agent Party_Contact_Electronic Mail";
            this.layoutControlItem132.Location = new System.Drawing.Point(0, 336);
            this.layoutControlItem132.Name = "ItemForACP_AgentParty_Contact_ElectronicMail";
            this.layoutControlItem132.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem132.Text = "ACP_Agent Party_Contact_Electronic Mail";
            this.layoutControlItem132.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem49
            // 
            this.layoutControlItem49.Control = this.textEdit52;
            this.layoutControlItem49.CustomizationFormText = "ACP_AgentParty_PartyTaxSchemeTaxTypeCode";
            this.layoutControlItem49.Location = new System.Drawing.Point(0, 240);
            this.layoutControlItem49.Name = "layoutControlItem49";
            this.layoutControlItem49.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem49.Text = "ACP_AgentParty_PartyTaxSchemeTaxTypeCode";
            this.layoutControlItem49.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlItem50
            // 
            this.layoutControlItem50.Control = this.textEdit53;
            this.layoutControlItem50.CustomizationFormText = "ACP_AgentParty_WebsiteURI";
            this.layoutControlItem50.Location = new System.Drawing.Point(0, 264);
            this.layoutControlItem50.Name = "layoutControlItem50";
            this.layoutControlItem50.Size = new System.Drawing.Size(1152, 24);
            this.layoutControlItem50.Text = "ACP_AgentParty_WebsiteURI";
            this.layoutControlItem50.TextSize = new System.Drawing.Size(272, 13);
            // 
            // layoutControlGroup29
            // 
            this.layoutControlGroup29.AllowDrawBackground = false;
            this.layoutControlGroup29.CustomizationFormText = "autoGeneratedGroup7";
            this.layoutControlGroup29.GroupBordersVisible = false;
            this.layoutControlGroup29.Location = new System.Drawing.Point(0, 1156);
            this.layoutControlGroup29.Name = "autoGeneratedGroup7";
            this.layoutControlGroup29.Size = new System.Drawing.Size(1152, 1);
            // 
            // layoutControlGroup30
            // 
            this.layoutControlGroup30.AllowDrawBackground = false;
            this.layoutControlGroup30.CustomizationFormText = "autoGeneratedGroup8";
            this.layoutControlGroup30.GroupBordersVisible = false;
            this.layoutControlGroup30.Location = new System.Drawing.Point(0, 1157);
            this.layoutControlGroup30.Name = "autoGeneratedGroup8";
            this.layoutControlGroup30.Size = new System.Drawing.Size(1152, 1);
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.xtraTabControl3);
            this.xtraTabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(1172, 238);
            this.xtraTabPage5.Text = "Toplamlar";
            // 
            // xtraTabControl3
            // 
            this.xtraTabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl3.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl3.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabControl3.Name = "xtraTabControl3";
            this.xtraTabControl3.SelectedTabPage = this.xtraTabPage7;
            this.xtraTabControl3.Size = new System.Drawing.Size(1172, 238);
            this.xtraTabControl3.TabIndex = 1;
            this.xtraTabControl3.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage7,
            this.xtraTabPage8,
            this.xtraTabPage16,
            this.xtraTabPage9});
            // 
            // xtraTabPage7
            // 
            this.xtraTabPage7.Controls.Add(this.dataLayoutTotals);
            this.xtraTabPage7.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPage7.Name = "xtraTabPage7";
            this.xtraTabPage7.Size = new System.Drawing.Size(1166, 210);
            this.xtraTabPage7.Text = "Fatura toplamlari";
            // 
            // dataLayoutTotals
            // 
            this.dataLayoutTotals.Controls.Add(this.TaxAmountSpinEdit);
            this.dataLayoutTotals.Controls.Add(this.LegalMonetaryTotal_LineExtensionAmountSpinEdit);
            this.dataLayoutTotals.Controls.Add(this.LegalMonetaryTotal_TaxExclusiveAmountSpinEdit);
            this.dataLayoutTotals.Controls.Add(this.LegalMonetaryTotal_TaxInclusiveAmountSpinEdit);
            this.dataLayoutTotals.Controls.Add(this.LegalMonetaryTotal_AllowanceTotalSpinEdit);
            this.dataLayoutTotals.Controls.Add(this.LegalMonetaryTotal_PayableRoundingAmountSpinEdit);
            this.dataLayoutTotals.Controls.Add(this.LegalMonetaryTotal_PayableAmountSpinEdit);
            this.dataLayoutTotals.DataSource = this.tbInvoice;
            this.dataLayoutTotals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutTotals.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutTotals.Margin = new System.Windows.Forms.Padding(2);
            this.dataLayoutTotals.Name = "dataLayoutTotals";
            this.dataLayoutTotals.Root = this.layoutControlGroup1;
            this.dataLayoutTotals.Size = new System.Drawing.Size(1166, 210);
            this.dataLayoutTotals.TabIndex = 0;
            this.dataLayoutTotals.Text = "dataLayoutControl1";
            // 
            // TaxAmountSpinEdit
            // 
            this.TaxAmountSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "TaxAmount", true));
            this.TaxAmountSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TaxAmountSpinEdit.EnterMoveNextControl = true;
            this.TaxAmountSpinEdit.Location = new System.Drawing.Point(249, 15);
            this.TaxAmountSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.TaxAmountSpinEdit.Name = "TaxAmountSpinEdit";
            this.TaxAmountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TaxAmountSpinEdit.Size = new System.Drawing.Size(905, 20);
            this.TaxAmountSpinEdit.StyleController = this.dataLayoutTotals;
            this.TaxAmountSpinEdit.TabIndex = 134;
            // 
            // LegalMonetaryTotal_LineExtensionAmountSpinEdit
            // 
            this.LegalMonetaryTotal_LineExtensionAmountSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "LegalMonetaryTotal_LineExtensionAmount", true));
            this.LegalMonetaryTotal_LineExtensionAmountSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.LegalMonetaryTotal_LineExtensionAmountSpinEdit.EnterMoveNextControl = true;
            this.LegalMonetaryTotal_LineExtensionAmountSpinEdit.Location = new System.Drawing.Point(249, 39);
            this.LegalMonetaryTotal_LineExtensionAmountSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.LegalMonetaryTotal_LineExtensionAmountSpinEdit.Name = "LegalMonetaryTotal_LineExtensionAmountSpinEdit";
            this.LegalMonetaryTotal_LineExtensionAmountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LegalMonetaryTotal_LineExtensionAmountSpinEdit.Size = new System.Drawing.Size(905, 20);
            this.LegalMonetaryTotal_LineExtensionAmountSpinEdit.StyleController = this.dataLayoutTotals;
            this.LegalMonetaryTotal_LineExtensionAmountSpinEdit.TabIndex = 135;
            // 
            // LegalMonetaryTotal_TaxExclusiveAmountSpinEdit
            // 
            this.LegalMonetaryTotal_TaxExclusiveAmountSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "LegalMonetaryTotal_TaxExclusiveAmount", true));
            this.LegalMonetaryTotal_TaxExclusiveAmountSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.LegalMonetaryTotal_TaxExclusiveAmountSpinEdit.EnterMoveNextControl = true;
            this.LegalMonetaryTotal_TaxExclusiveAmountSpinEdit.Location = new System.Drawing.Point(249, 63);
            this.LegalMonetaryTotal_TaxExclusiveAmountSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.LegalMonetaryTotal_TaxExclusiveAmountSpinEdit.Name = "LegalMonetaryTotal_TaxExclusiveAmountSpinEdit";
            this.LegalMonetaryTotal_TaxExclusiveAmountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LegalMonetaryTotal_TaxExclusiveAmountSpinEdit.Size = new System.Drawing.Size(905, 20);
            this.LegalMonetaryTotal_TaxExclusiveAmountSpinEdit.StyleController = this.dataLayoutTotals;
            this.LegalMonetaryTotal_TaxExclusiveAmountSpinEdit.TabIndex = 136;
            // 
            // LegalMonetaryTotal_TaxInclusiveAmountSpinEdit
            // 
            this.LegalMonetaryTotal_TaxInclusiveAmountSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "LegalMonetaryTotal_TaxInclusiveAmount", true));
            this.LegalMonetaryTotal_TaxInclusiveAmountSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.LegalMonetaryTotal_TaxInclusiveAmountSpinEdit.EnterMoveNextControl = true;
            this.LegalMonetaryTotal_TaxInclusiveAmountSpinEdit.Location = new System.Drawing.Point(249, 87);
            this.LegalMonetaryTotal_TaxInclusiveAmountSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.LegalMonetaryTotal_TaxInclusiveAmountSpinEdit.Name = "LegalMonetaryTotal_TaxInclusiveAmountSpinEdit";
            this.LegalMonetaryTotal_TaxInclusiveAmountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LegalMonetaryTotal_TaxInclusiveAmountSpinEdit.Size = new System.Drawing.Size(905, 20);
            this.LegalMonetaryTotal_TaxInclusiveAmountSpinEdit.StyleController = this.dataLayoutTotals;
            this.LegalMonetaryTotal_TaxInclusiveAmountSpinEdit.TabIndex = 137;
            // 
            // LegalMonetaryTotal_AllowanceTotalSpinEdit
            // 
            this.LegalMonetaryTotal_AllowanceTotalSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "LegalMonetaryTotal_AllowanceTotalAmount", true));
            this.LegalMonetaryTotal_AllowanceTotalSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.LegalMonetaryTotal_AllowanceTotalSpinEdit.EnterMoveNextControl = true;
            this.LegalMonetaryTotal_AllowanceTotalSpinEdit.Location = new System.Drawing.Point(249, 111);
            this.LegalMonetaryTotal_AllowanceTotalSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.LegalMonetaryTotal_AllowanceTotalSpinEdit.Name = "LegalMonetaryTotal_AllowanceTotalSpinEdit";
            this.LegalMonetaryTotal_AllowanceTotalSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LegalMonetaryTotal_AllowanceTotalSpinEdit.Size = new System.Drawing.Size(905, 20);
            this.LegalMonetaryTotal_AllowanceTotalSpinEdit.StyleController = this.dataLayoutTotals;
            this.LegalMonetaryTotal_AllowanceTotalSpinEdit.TabIndex = 138;
            // 
            // LegalMonetaryTotal_PayableRoundingAmountSpinEdit
            // 
            this.LegalMonetaryTotal_PayableRoundingAmountSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "LegalMonetaryTotal_PayableRoundingAmount", true));
            this.LegalMonetaryTotal_PayableRoundingAmountSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.LegalMonetaryTotal_PayableRoundingAmountSpinEdit.EnterMoveNextControl = true;
            this.LegalMonetaryTotal_PayableRoundingAmountSpinEdit.Location = new System.Drawing.Point(249, 135);
            this.LegalMonetaryTotal_PayableRoundingAmountSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.LegalMonetaryTotal_PayableRoundingAmountSpinEdit.Name = "LegalMonetaryTotal_PayableRoundingAmountSpinEdit";
            this.LegalMonetaryTotal_PayableRoundingAmountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LegalMonetaryTotal_PayableRoundingAmountSpinEdit.Size = new System.Drawing.Size(905, 20);
            this.LegalMonetaryTotal_PayableRoundingAmountSpinEdit.StyleController = this.dataLayoutTotals;
            this.LegalMonetaryTotal_PayableRoundingAmountSpinEdit.TabIndex = 139;
            // 
            // LegalMonetaryTotal_PayableAmountSpinEdit
            // 
            this.LegalMonetaryTotal_PayableAmountSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "LegalMonetaryTotal_PayableAmount", true));
            this.LegalMonetaryTotal_PayableAmountSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.LegalMonetaryTotal_PayableAmountSpinEdit.EnterMoveNextControl = true;
            this.LegalMonetaryTotal_PayableAmountSpinEdit.Location = new System.Drawing.Point(249, 159);
            this.LegalMonetaryTotal_PayableAmountSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.LegalMonetaryTotal_PayableAmountSpinEdit.Name = "LegalMonetaryTotal_PayableAmountSpinEdit";
            this.LegalMonetaryTotal_PayableAmountSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LegalMonetaryTotal_PayableAmountSpinEdit.Size = new System.Drawing.Size(905, 20);
            this.LegalMonetaryTotal_PayableAmountSpinEdit.StyleController = this.dataLayoutTotals;
            this.LegalMonetaryTotal_PayableAmountSpinEdit.TabIndex = 140;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlGroup4,
            this.layoutControlGroup7,
            this.layoutControlGroup8,
            this.layoutControlGroup9,
            this.layoutControlGroup10,
            this.ItemForTaxAmount,
            this.ItemForLegalMonetaryTotal_LineExtensionAmount,
            this.ItemForLegalMonetaryTotal_TaxExclusiveAmount,
            this.ItemForLegalMonetaryTotal_TaxInclusiveAmount,
            this.ItemForLegalMonetaryTotal_AllowanceTotal,
            this.ItemForLegalMonetaryTotal_PayableRoundingAmount,
            this.ItemForLegalMonetaryTotal_PayableAmount});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1166, 210);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1146, 1);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.AllowDrawBackground = false;
            this.layoutControlGroup3.CustomizationFormText = "autoGeneratedGroup1";
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 1);
            this.layoutControlGroup3.Name = "autoGeneratedGroup1";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1146, 1);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.AllowDrawBackground = false;
            this.layoutControlGroup4.CustomizationFormText = "autoGeneratedGroup2";
            this.layoutControlGroup4.GroupBordersVisible = false;
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 2);
            this.layoutControlGroup4.Name = "autoGeneratedGroup2";
            this.layoutControlGroup4.Size = new System.Drawing.Size(1146, 1);
            // 
            // layoutControlGroup7
            // 
            this.layoutControlGroup7.AllowDrawBackground = false;
            this.layoutControlGroup7.CustomizationFormText = "autoGeneratedGroup5";
            this.layoutControlGroup7.GroupBordersVisible = false;
            this.layoutControlGroup7.Location = new System.Drawing.Point(0, 171);
            this.layoutControlGroup7.Name = "autoGeneratedGroup5";
            this.layoutControlGroup7.Size = new System.Drawing.Size(1146, 4);
            // 
            // layoutControlGroup8
            // 
            this.layoutControlGroup8.AllowDrawBackground = false;
            this.layoutControlGroup8.CustomizationFormText = "autoGeneratedGroup6";
            this.layoutControlGroup8.GroupBordersVisible = false;
            this.layoutControlGroup8.Location = new System.Drawing.Point(0, 175);
            this.layoutControlGroup8.Name = "autoGeneratedGroup6";
            this.layoutControlGroup8.Size = new System.Drawing.Size(1146, 4);
            // 
            // layoutControlGroup9
            // 
            this.layoutControlGroup9.AllowDrawBackground = false;
            this.layoutControlGroup9.CustomizationFormText = "autoGeneratedGroup7";
            this.layoutControlGroup9.GroupBordersVisible = false;
            this.layoutControlGroup9.Location = new System.Drawing.Point(0, 179);
            this.layoutControlGroup9.Name = "autoGeneratedGroup7";
            this.layoutControlGroup9.Size = new System.Drawing.Size(1146, 5);
            // 
            // layoutControlGroup10
            // 
            this.layoutControlGroup10.AllowDrawBackground = false;
            this.layoutControlGroup10.CustomizationFormText = "autoGeneratedGroup8";
            this.layoutControlGroup10.GroupBordersVisible = false;
            this.layoutControlGroup10.Location = new System.Drawing.Point(0, 184);
            this.layoutControlGroup10.Name = "autoGeneratedGroup8";
            this.layoutControlGroup10.Size = new System.Drawing.Size(1146, 6);
            // 
            // ItemForTaxAmount
            // 
            this.ItemForTaxAmount.Control = this.TaxAmountSpinEdit;
            this.ItemForTaxAmount.CustomizationFormText = "Tax Amount";
            this.ItemForTaxAmount.Location = new System.Drawing.Point(0, 3);
            this.ItemForTaxAmount.Name = "ItemForTaxAmount";
            this.ItemForTaxAmount.Size = new System.Drawing.Size(1146, 24);
            this.ItemForTaxAmount.Text = "Tax Amount";
            this.ItemForTaxAmount.TextSize = new System.Drawing.Size(233, 13);
            // 
            // ItemForLegalMonetaryTotal_LineExtensionAmount
            // 
            this.ItemForLegalMonetaryTotal_LineExtensionAmount.Control = this.LegalMonetaryTotal_LineExtensionAmountSpinEdit;
            this.ItemForLegalMonetaryTotal_LineExtensionAmount.CustomizationFormText = "Legal Monetary Total_Line Extension Amount";
            this.ItemForLegalMonetaryTotal_LineExtensionAmount.Location = new System.Drawing.Point(0, 27);
            this.ItemForLegalMonetaryTotal_LineExtensionAmount.Name = "ItemForLegalMonetaryTotal_LineExtensionAmount";
            this.ItemForLegalMonetaryTotal_LineExtensionAmount.Size = new System.Drawing.Size(1146, 24);
            this.ItemForLegalMonetaryTotal_LineExtensionAmount.Text = "Legal Monetary Total_Line Extension Amount";
            this.ItemForLegalMonetaryTotal_LineExtensionAmount.TextSize = new System.Drawing.Size(233, 13);
            // 
            // ItemForLegalMonetaryTotal_TaxExclusiveAmount
            // 
            this.ItemForLegalMonetaryTotal_TaxExclusiveAmount.Control = this.LegalMonetaryTotal_TaxExclusiveAmountSpinEdit;
            this.ItemForLegalMonetaryTotal_TaxExclusiveAmount.CustomizationFormText = "Legal Monetary Total_Tax Exclusive Amount";
            this.ItemForLegalMonetaryTotal_TaxExclusiveAmount.Location = new System.Drawing.Point(0, 51);
            this.ItemForLegalMonetaryTotal_TaxExclusiveAmount.Name = "ItemForLegalMonetaryTotal_TaxExclusiveAmount";
            this.ItemForLegalMonetaryTotal_TaxExclusiveAmount.Size = new System.Drawing.Size(1146, 24);
            this.ItemForLegalMonetaryTotal_TaxExclusiveAmount.Text = "Legal Monetary Total_Tax Exclusive Amount";
            this.ItemForLegalMonetaryTotal_TaxExclusiveAmount.TextSize = new System.Drawing.Size(233, 13);
            // 
            // ItemForLegalMonetaryTotal_TaxInclusiveAmount
            // 
            this.ItemForLegalMonetaryTotal_TaxInclusiveAmount.Control = this.LegalMonetaryTotal_TaxInclusiveAmountSpinEdit;
            this.ItemForLegalMonetaryTotal_TaxInclusiveAmount.CustomizationFormText = "Legal Monetary Total_Tax Inclusive Amount";
            this.ItemForLegalMonetaryTotal_TaxInclusiveAmount.Location = new System.Drawing.Point(0, 75);
            this.ItemForLegalMonetaryTotal_TaxInclusiveAmount.Name = "ItemForLegalMonetaryTotal_TaxInclusiveAmount";
            this.ItemForLegalMonetaryTotal_TaxInclusiveAmount.Size = new System.Drawing.Size(1146, 24);
            this.ItemForLegalMonetaryTotal_TaxInclusiveAmount.Text = "Legal Monetary Total_Tax Inclusive Amount";
            this.ItemForLegalMonetaryTotal_TaxInclusiveAmount.TextSize = new System.Drawing.Size(233, 13);
            // 
            // ItemForLegalMonetaryTotal_AllowanceTotal
            // 
            this.ItemForLegalMonetaryTotal_AllowanceTotal.Control = this.LegalMonetaryTotal_AllowanceTotalSpinEdit;
            this.ItemForLegalMonetaryTotal_AllowanceTotal.CustomizationFormText = "Legal Monetary Total_Allowance Total";
            this.ItemForLegalMonetaryTotal_AllowanceTotal.Location = new System.Drawing.Point(0, 99);
            this.ItemForLegalMonetaryTotal_AllowanceTotal.Name = "ItemForLegalMonetaryTotal_AllowanceTotal";
            this.ItemForLegalMonetaryTotal_AllowanceTotal.Size = new System.Drawing.Size(1146, 24);
            this.ItemForLegalMonetaryTotal_AllowanceTotal.Text = "Legal Monetary Total_Allowance Total";
            this.ItemForLegalMonetaryTotal_AllowanceTotal.TextSize = new System.Drawing.Size(233, 13);
            // 
            // ItemForLegalMonetaryTotal_PayableRoundingAmount
            // 
            this.ItemForLegalMonetaryTotal_PayableRoundingAmount.Control = this.LegalMonetaryTotal_PayableRoundingAmountSpinEdit;
            this.ItemForLegalMonetaryTotal_PayableRoundingAmount.CustomizationFormText = "Legal Monetary Total_Payable Rounding Amount";
            this.ItemForLegalMonetaryTotal_PayableRoundingAmount.Location = new System.Drawing.Point(0, 123);
            this.ItemForLegalMonetaryTotal_PayableRoundingAmount.Name = "ItemForLegalMonetaryTotal_PayableRoundingAmount";
            this.ItemForLegalMonetaryTotal_PayableRoundingAmount.Size = new System.Drawing.Size(1146, 24);
            this.ItemForLegalMonetaryTotal_PayableRoundingAmount.Text = "Legal Monetary Total_Payable Rounding Amount";
            this.ItemForLegalMonetaryTotal_PayableRoundingAmount.TextSize = new System.Drawing.Size(233, 13);
            // 
            // ItemForLegalMonetaryTotal_PayableAmount
            // 
            this.ItemForLegalMonetaryTotal_PayableAmount.Control = this.LegalMonetaryTotal_PayableAmountSpinEdit;
            this.ItemForLegalMonetaryTotal_PayableAmount.CustomizationFormText = "Legal Monetary Total_Payable Amount";
            this.ItemForLegalMonetaryTotal_PayableAmount.Location = new System.Drawing.Point(0, 147);
            this.ItemForLegalMonetaryTotal_PayableAmount.Name = "ItemForLegalMonetaryTotal_PayableAmount";
            this.ItemForLegalMonetaryTotal_PayableAmount.Size = new System.Drawing.Size(1146, 24);
            this.ItemForLegalMonetaryTotal_PayableAmount.Text = "Legal Monetary Total_Payable Amount";
            this.ItemForLegalMonetaryTotal_PayableAmount.TextSize = new System.Drawing.Size(233, 13);
            // 
            // xtraTabPage8
            // 
            this.xtraTabPage8.Controls.Add(this.grInvoice_TaxSubTotal);
            this.xtraTabPage8.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPage8.Name = "xtraTabPage8";
            this.xtraTabPage8.Size = new System.Drawing.Size(1166, 210);
            this.xtraTabPage8.Text = "Vergi toplamlari";
            // 
            // grInvoice_TaxSubTotal
            // 
            this.grInvoice_TaxSubTotal.DataSource = this.tbInvoice_TaxSubtotal;
            this.grInvoice_TaxSubTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grInvoice_TaxSubTotal.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grInvoice_TaxSubTotal.Location = new System.Drawing.Point(0, 0);
            this.grInvoice_TaxSubTotal.MainView = this.grInvoice_TaxSubTotalView;
            this.grInvoice_TaxSubTotal.Margin = new System.Windows.Forms.Padding(2);
            this.grInvoice_TaxSubTotal.Name = "grInvoice_TaxSubTotal";
            this.grInvoice_TaxSubTotal.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2});
            this.grInvoice_TaxSubTotal.Size = new System.Drawing.Size(1166, 210);
            this.grInvoice_TaxSubTotal.TabIndex = 1;
            this.grInvoice_TaxSubTotal.UseEmbeddedNavigator = true;
            this.grInvoice_TaxSubTotal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grInvoice_TaxSubTotalView});
            // 
            // tbInvoice_TaxSubtotal
            // 
            this.tbInvoice_TaxSubtotal.Columns.AddRange(new System.Data.DataColumn[] {
            this.tbInvoice_TaxSubtotal_nID,
            this.tbInvoice_TaxSubtotal_InvoiceID,
            this.tbInvoice_TaxSubtotal_TaxableAmount,
            this.tbInvoice_TaxSubtotal_currencyID,
            this.tbInvoice_TaxSubtotal_TaxAmount,
            this.tbInvoice_TaxSubtotal_PerUnitAmount,
            this.tbInvoice_TaxSubtotal_CalculationSequenceNumeric,
            this.tbInvoice_TaxSubtotal_Percent_,
            this.tbInvoice_TaxSubtotal_TaxCategory_TaxScheme_Name,
            this.tbInvoice_TaxSubtotal_TaxCategory_TaxScheme_TaxTypeCode,
            this.tbInvoice_TaxSubtotal_TaxCategory_TaxExemptionReason,
            this.tbInvoice_TaxSubtotal_TaxCategory_TaxExemptionReasonCode});
            this.tbInvoice_TaxSubtotal.Connection = this.FirmConn;
            this.tbInvoice_TaxSubtotal.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "nID"}, true)});
            this.tbInvoice_TaxSubtotal.CurrentRow = null;
            this.tbInvoice_TaxSubtotal.DataSourceLink = null;
            this.tbInvoice_TaxSubtotal.DeleteCommand = this.sqlCommand16;
            this.tbInvoice_TaxSubtotal.Filter = "";
            this.tbInvoice_TaxSubtotal.InsertCommand = this.sqlCommand14;
            this.tbInvoice_TaxSubtotal.LiveSave = false;
            this.tbInvoice_TaxSubtotal.MaxRecords = ((long)(0));
            this.tbInvoice_TaxSubtotal.Name = "tbInvoice_TaxSubtotal";
            this.tbInvoice_TaxSubtotal.ParentRelation_ChildColumns = null;
            this.tbInvoice_TaxSubtotal.ParentRelation_ParentColumns = null;
            this.tbInvoice_TaxSubtotal.ParentRelation_Table = null;
            this.tbInvoice_TaxSubtotal.Position = ((long)(-1));
            this.tbInvoice_TaxSubtotal.PrimaryKey = new System.Data.DataColumn[] {
        this.tbInvoice_TaxSubtotal_nID};
            this.tbInvoice_TaxSubtotal.Quoted = false;
            this.tbInvoice_TaxSubtotal.SelectCommand = this.sqlCommand13;
            this.tbInvoice_TaxSubtotal.TableName = "neoTable1";
            this.tbInvoice_TaxSubtotal.Transaction = null;
            this.tbInvoice_TaxSubtotal.UpdateCommand = this.sqlCommand15;
            // 
            // tbInvoice_TaxSubtotal_nID
            // 
            this.tbInvoice_TaxSubtotal_nID.AllowDBNull = false;
            this.tbInvoice_TaxSubtotal_nID.AutoIncrement = true;
            this.tbInvoice_TaxSubtotal_nID.ColumnName = "nID";
            this.tbInvoice_TaxSubtotal_nID.DataType = typeof(int);
            // 
            // tbInvoice_TaxSubtotal_InvoiceID
            // 
            this.tbInvoice_TaxSubtotal_InvoiceID.ColumnName = "InvoiceID";
            this.tbInvoice_TaxSubtotal_InvoiceID.DataType = typeof(int);
            // 
            // tbInvoice_TaxSubtotal_TaxableAmount
            // 
            this.tbInvoice_TaxSubtotal_TaxableAmount.ColumnName = "TaxableAmount";
            this.tbInvoice_TaxSubtotal_TaxableAmount.DataType = typeof(double);
            // 
            // tbInvoice_TaxSubtotal_currencyID
            // 
            this.tbInvoice_TaxSubtotal_currencyID.ColumnName = "currencyID";
            // 
            // tbInvoice_TaxSubtotal_TaxAmount
            // 
            this.tbInvoice_TaxSubtotal_TaxAmount.ColumnName = "TaxAmount";
            this.tbInvoice_TaxSubtotal_TaxAmount.DataType = typeof(double);
            // 
            // tbInvoice_TaxSubtotal_PerUnitAmount
            // 
            this.tbInvoice_TaxSubtotal_PerUnitAmount.ColumnName = "PerUnitAmount";
            this.tbInvoice_TaxSubtotal_PerUnitAmount.DataType = typeof(double);
            // 
            // tbInvoice_TaxSubtotal_CalculationSequenceNumeric
            // 
            this.tbInvoice_TaxSubtotal_CalculationSequenceNumeric.ColumnName = "CalculationSequenceNumeric";
            this.tbInvoice_TaxSubtotal_CalculationSequenceNumeric.DataType = typeof(int);
            // 
            // tbInvoice_TaxSubtotal_Percent_
            // 
            this.tbInvoice_TaxSubtotal_Percent_.ColumnName = "Percent_";
            this.tbInvoice_TaxSubtotal_Percent_.DataType = typeof(double);
            // 
            // tbInvoice_TaxSubtotal_TaxCategory_TaxScheme_Name
            // 
            this.tbInvoice_TaxSubtotal_TaxCategory_TaxScheme_Name.ColumnName = "TaxCategory_TaxScheme_Name";
            // 
            // tbInvoice_TaxSubtotal_TaxCategory_TaxScheme_TaxTypeCode
            // 
            this.tbInvoice_TaxSubtotal_TaxCategory_TaxScheme_TaxTypeCode.ColumnName = "TaxCategory_TaxScheme_TaxTypeCode";
            // 
            // tbInvoice_TaxSubtotal_TaxCategory_TaxExemptionReason
            // 
            this.tbInvoice_TaxSubtotal_TaxCategory_TaxExemptionReason.ColumnName = "TaxCategory_TaxExemptionReason";
            // 
            // tbInvoice_TaxSubtotal_TaxCategory_TaxExemptionReasonCode
            // 
            this.tbInvoice_TaxSubtotal_TaxCategory_TaxExemptionReasonCode.ColumnName = "TaxCategory_TaxExemptionReasonCode";
            // 
            // sqlCommand16
            // 
            this.sqlCommand16.CommandText = "DELETE FROM Invoice_TaxSubtotal WHERE nID = @nID";
            // 
            // sqlCommand14
            // 
            this.sqlCommand14.CommandText = resources.GetString("sqlCommand14.CommandText");
            this.sqlCommand14.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, true, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, 0)});
            // 
            // sqlCommand13
            // 
            this.sqlCommand13.CommandText = "SELECT * FROM Invoice_TaxSubtotal \r\nWHERE InvoiceID = @InvoiceID \r\n";
            this.sqlCommand13.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@InvoiceID", System.Data.SqlDbType.Int, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "0")});
            // 
            // sqlCommand15
            // 
            this.sqlCommand15.CommandText = resources.GetString("sqlCommand15.CommandText");
            // 
            // grInvoice_TaxSubTotalView
            // 
            this.grInvoice_TaxSubTotalView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn19,
            this.colInvoiceID1,
            this.gridColumn21,
            this.gridColumn22,
            this.gridColumn23,
            this.gridColumn24,
            this.gridColumn25,
            this.gridColumn26,
            this.gridColumn27,
            this.gridColumn28,
            this.gridColumn29});
            this.grInvoice_TaxSubTotalView.GridControl = this.grInvoice_TaxSubTotal;
            this.grInvoice_TaxSubTotalView.Name = "grInvoice_TaxSubTotalView";
            this.grInvoice_TaxSubTotalView.OptionsView.ColumnAutoWidth = false;
            this.grInvoice_TaxSubTotalView.OptionsView.ShowFooter = true;
            this.grInvoice_TaxSubTotalView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn19
            // 
            this.gridColumn19.FieldName = "nID";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.OptionsColumn.AllowEdit = false;
            // 
            // colInvoiceID1
            // 
            this.colInvoiceID1.FieldName = "InvoiceID";
            this.colInvoiceID1.Name = "colInvoiceID1";
            this.colInvoiceID1.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "Matrah";
            this.gridColumn21.FieldName = "TaxableAmount";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 0;
            this.gridColumn21.Width = 110;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "Hesap Sira";
            this.gridColumn22.FieldName = "CalculationSequenceNumeric";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 2;
            this.gridColumn22.Width = 70;
            // 
            // gridColumn23
            // 
            this.gridColumn23.FieldName = "currencyID";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn24
            // 
            this.gridColumn24.Caption = "Vergi";
            this.gridColumn24.FieldName = "TaxAmount";
            this.gridColumn24.Name = "gridColumn24";
            this.gridColumn24.Visible = true;
            this.gridColumn24.VisibleIndex = 1;
            this.gridColumn24.Width = 106;
            // 
            // gridColumn25
            // 
            this.gridColumn25.Caption = "Vergi yuzde";
            this.gridColumn25.FieldName = "Percent_";
            this.gridColumn25.Name = "gridColumn25";
            this.gridColumn25.Visible = true;
            this.gridColumn25.VisibleIndex = 3;
            // 
            // gridColumn26
            // 
            this.gridColumn26.Caption = "Vergi kod";
            this.gridColumn26.FieldName = "TaxCategory_TaxScheme_TaxTypeCode";
            this.gridColumn26.Name = "gridColumn26";
            this.gridColumn26.Visible = true;
            this.gridColumn26.VisibleIndex = 5;
            // 
            // gridColumn27
            // 
            this.gridColumn27.Caption = "Vergi aciklama";
            this.gridColumn27.FieldName = "TaxCategory_TaxScheme_Name";
            this.gridColumn27.Name = "gridColumn27";
            this.gridColumn27.Visible = true;
            this.gridColumn27.VisibleIndex = 4;
            this.gridColumn27.Width = 130;
            // 
            // gridColumn28
            // 
            this.gridColumn28.Caption = "Kdv muhafiyet sebebi";
            this.gridColumn28.FieldName = "TaxCategory_TaxExemptionReason";
            this.gridColumn28.Name = "gridColumn28";
            this.gridColumn28.Visible = true;
            this.gridColumn28.VisibleIndex = 6;
            this.gridColumn28.Width = 174;
            // 
            // gridColumn29
            // 
            this.gridColumn29.Caption = "Kdv muhafiyet sebep kodu";
            this.gridColumn29.FieldName = "TaxCategory_TaxExemptionReasonCode";
            this.gridColumn29.Name = "gridColumn29";
            this.gridColumn29.Visible = true;
            this.gridColumn29.VisibleIndex = 7;
            this.gridColumn29.Width = 159;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Caption = "Check";
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // xtraTabPage16
            // 
            this.xtraTabPage16.Controls.Add(this.grInvoice_WithholdingTaxSubTotal);
            this.xtraTabPage16.Name = "xtraTabPage16";
            this.xtraTabPage16.Size = new System.Drawing.Size(1166, 210);
            this.xtraTabPage16.Text = "Tevkifat toplamlar";
            // 
            // grInvoice_WithholdingTaxSubTotal
            // 
            this.grInvoice_WithholdingTaxSubTotal.DataSource = this.tbInvoice_WithholdingTaxSubtotal;
            this.grInvoice_WithholdingTaxSubTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grInvoice_WithholdingTaxSubTotal.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grInvoice_WithholdingTaxSubTotal.Location = new System.Drawing.Point(0, 0);
            this.grInvoice_WithholdingTaxSubTotal.MainView = this.grInvoice_WithholdingTaxSubTotalView;
            this.grInvoice_WithholdingTaxSubTotal.Margin = new System.Windows.Forms.Padding(2);
            this.grInvoice_WithholdingTaxSubTotal.Name = "grInvoice_WithholdingTaxSubTotal";
            this.grInvoice_WithholdingTaxSubTotal.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit5});
            this.grInvoice_WithholdingTaxSubTotal.Size = new System.Drawing.Size(1166, 210);
            this.grInvoice_WithholdingTaxSubTotal.TabIndex = 2;
            this.grInvoice_WithholdingTaxSubTotal.UseEmbeddedNavigator = true;
            this.grInvoice_WithholdingTaxSubTotal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grInvoice_WithholdingTaxSubTotalView});
            // 
            // tbInvoice_WithholdingTaxSubtotal
            // 
            this.tbInvoice_WithholdingTaxSubtotal.Columns.AddRange(new System.Data.DataColumn[] {
            this.tbInvoice_WithholdingTaxSubtotal_nID,
            this.tbInvoice_WithholdingTaxSubtotal_InvoiceID,
            this.tbInvoice_WithholdingTaxSubtotal_TaxableAmount,
            this.tbInvoice_WithholdingTaxSubtotal_currencyID,
            this.tbInvoice_WithholdingTaxSubtotal_TaxAmount,
            this.tbInvoice_WithholdingTaxSubtotal_PerUnitAmount,
            this.tbInvoice_WithholdingTaxSubtotal_CalculationSequenceNumeric,
            this.tbInvoice_WithholdingTaxSubtotal_Percent_,
            this.tbInvoice_WithholdingTaxSubtotal_TaxCategory_TaxScheme_Name,
            this.tbInvoice_WithholdingTaxSubtotal_TaxCategory_TaxScheme_TaxTypeCode,
            this.tbInvoice_WithholdingTaxSubtotal_TaxCategory_TaxExemptionReason,
            this.tbInvoice_WithholdingTaxSubtotal_TaxCategory_TaxExemptionReasonCode});
            this.tbInvoice_WithholdingTaxSubtotal.Connection = this.FirmConn;
            this.tbInvoice_WithholdingTaxSubtotal.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "nID"}, true)});
            this.tbInvoice_WithholdingTaxSubtotal.CurrentRow = null;
            this.tbInvoice_WithholdingTaxSubtotal.DataSourceLink = null;
            this.tbInvoice_WithholdingTaxSubtotal.DeleteCommand = this.sqlCommand48;
            this.tbInvoice_WithholdingTaxSubtotal.Filter = "";
            this.tbInvoice_WithholdingTaxSubtotal.InsertCommand = this.sqlCommand46;
            this.tbInvoice_WithholdingTaxSubtotal.LiveSave = false;
            this.tbInvoice_WithholdingTaxSubtotal.MaxRecords = ((long)(0));
            this.tbInvoice_WithholdingTaxSubtotal.Name = "tbInvoice_WithholdingTaxSubtotal";
            this.tbInvoice_WithholdingTaxSubtotal.ParentRelation_ChildColumns = null;
            this.tbInvoice_WithholdingTaxSubtotal.ParentRelation_ParentColumns = null;
            this.tbInvoice_WithholdingTaxSubtotal.ParentRelation_Table = null;
            this.tbInvoice_WithholdingTaxSubtotal.Position = ((long)(-1));
            this.tbInvoice_WithholdingTaxSubtotal.PrimaryKey = new System.Data.DataColumn[] {
        this.tbInvoice_WithholdingTaxSubtotal_nID};
            this.tbInvoice_WithholdingTaxSubtotal.Quoted = false;
            this.tbInvoice_WithholdingTaxSubtotal.SelectCommand = this.sqlCommand45;
            this.tbInvoice_WithholdingTaxSubtotal.TableName = "neoTable1";
            this.tbInvoice_WithholdingTaxSubtotal.Transaction = null;
            this.tbInvoice_WithholdingTaxSubtotal.UpdateCommand = this.sqlCommand47;
            // 
            // tbInvoice_WithholdingTaxSubtotal_nID
            // 
            this.tbInvoice_WithholdingTaxSubtotal_nID.AllowDBNull = false;
            this.tbInvoice_WithholdingTaxSubtotal_nID.AutoIncrement = true;
            this.tbInvoice_WithholdingTaxSubtotal_nID.ColumnName = "nID";
            this.tbInvoice_WithholdingTaxSubtotal_nID.DataType = typeof(int);
            // 
            // tbInvoice_WithholdingTaxSubtotal_InvoiceID
            // 
            this.tbInvoice_WithholdingTaxSubtotal_InvoiceID.ColumnName = "InvoiceID";
            this.tbInvoice_WithholdingTaxSubtotal_InvoiceID.DataType = typeof(int);
            // 
            // tbInvoice_WithholdingTaxSubtotal_TaxableAmount
            // 
            this.tbInvoice_WithholdingTaxSubtotal_TaxableAmount.ColumnName = "TaxableAmount";
            this.tbInvoice_WithholdingTaxSubtotal_TaxableAmount.DataType = typeof(double);
            // 
            // tbInvoice_WithholdingTaxSubtotal_currencyID
            // 
            this.tbInvoice_WithholdingTaxSubtotal_currencyID.ColumnName = "currencyID";
            // 
            // tbInvoice_WithholdingTaxSubtotal_TaxAmount
            // 
            this.tbInvoice_WithholdingTaxSubtotal_TaxAmount.ColumnName = "TaxAmount";
            this.tbInvoice_WithholdingTaxSubtotal_TaxAmount.DataType = typeof(double);
            // 
            // tbInvoice_WithholdingTaxSubtotal_PerUnitAmount
            // 
            this.tbInvoice_WithholdingTaxSubtotal_PerUnitAmount.ColumnName = "PerUnitAmount";
            this.tbInvoice_WithholdingTaxSubtotal_PerUnitAmount.DataType = typeof(double);
            // 
            // tbInvoice_WithholdingTaxSubtotal_CalculationSequenceNumeric
            // 
            this.tbInvoice_WithholdingTaxSubtotal_CalculationSequenceNumeric.ColumnName = "CalculationSequenceNumeric";
            this.tbInvoice_WithholdingTaxSubtotal_CalculationSequenceNumeric.DataType = typeof(int);
            // 
            // tbInvoice_WithholdingTaxSubtotal_Percent_
            // 
            this.tbInvoice_WithholdingTaxSubtotal_Percent_.ColumnName = "Percent_";
            this.tbInvoice_WithholdingTaxSubtotal_Percent_.DataType = typeof(double);
            // 
            // tbInvoice_WithholdingTaxSubtotal_TaxCategory_TaxScheme_Name
            // 
            this.tbInvoice_WithholdingTaxSubtotal_TaxCategory_TaxScheme_Name.ColumnName = "TaxCategory_TaxScheme_Name";
            // 
            // tbInvoice_WithholdingTaxSubtotal_TaxCategory_TaxScheme_TaxTypeCode
            // 
            this.tbInvoice_WithholdingTaxSubtotal_TaxCategory_TaxScheme_TaxTypeCode.ColumnName = "TaxCategory_TaxScheme_TaxTypeCode";
            // 
            // tbInvoice_WithholdingTaxSubtotal_TaxCategory_TaxExemptionReason
            // 
            this.tbInvoice_WithholdingTaxSubtotal_TaxCategory_TaxExemptionReason.ColumnName = "TaxCategory_TaxExemptionReason";
            // 
            // tbInvoice_WithholdingTaxSubtotal_TaxCategory_TaxExemptionReasonCode
            // 
            this.tbInvoice_WithholdingTaxSubtotal_TaxCategory_TaxExemptionReasonCode.ColumnName = "TaxCategory_TaxExemptionReasonCode";
            // 
            // sqlCommand48
            // 
            this.sqlCommand48.CommandText = "DELETE FROM Invoice_WithholdingTaxSubtotal WHERE nID = @nID";
            // 
            // sqlCommand46
            // 
            this.sqlCommand46.CommandText = resources.GetString("sqlCommand46.CommandText");
            this.sqlCommand46.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, true, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, 0)});
            // 
            // sqlCommand45
            // 
            this.sqlCommand45.CommandText = "SELECT * FROM Invoice_WithholdingTaxSubtotal \r\nWHERE InvoiceID = @InvoiceID \r\n";
            this.sqlCommand45.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@InvoiceID", System.Data.SqlDbType.Int, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "0")});
            // 
            // sqlCommand47
            // 
            this.sqlCommand47.CommandText = resources.GetString("sqlCommand47.CommandText");
            // 
            // grInvoice_WithholdingTaxSubTotalView
            // 
            this.grInvoice_WithholdingTaxSubTotalView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn20,
            this.gridColumn30});
            this.grInvoice_WithholdingTaxSubTotalView.GridControl = this.grInvoice_WithholdingTaxSubTotal;
            this.grInvoice_WithholdingTaxSubTotalView.Name = "grInvoice_WithholdingTaxSubTotalView";
            this.grInvoice_WithholdingTaxSubTotalView.OptionsView.ColumnAutoWidth = false;
            this.grInvoice_WithholdingTaxSubTotalView.OptionsView.ShowFooter = true;
            this.grInvoice_WithholdingTaxSubTotalView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "nID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "InvoiceID";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Matrah";
            this.gridColumn3.FieldName = "TaxableAmount";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 110;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Hesap Sira";
            this.gridColumn4.FieldName = "CalculationSequenceNumeric";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 70;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "currencyID";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Vergi";
            this.gridColumn6.FieldName = "TaxAmount";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 106;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Vergi yuzde";
            this.gridColumn7.FieldName = "Percent_";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Vergi kod";
            this.gridColumn8.FieldName = "TaxCategory_TaxScheme_TaxTypeCode";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 5;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Vergi aciklama";
            this.gridColumn9.FieldName = "TaxCategory_TaxScheme_Name";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 4;
            this.gridColumn9.Width = 130;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "Kdv muhafiyet sebebi";
            this.gridColumn20.FieldName = "TaxCategory_TaxExemptionReason";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 6;
            this.gridColumn20.Width = 174;
            // 
            // gridColumn30
            // 
            this.gridColumn30.Caption = "Kdv muhafiyet sebep kodu";
            this.gridColumn30.FieldName = "TaxCategory_TaxExemptionReasonCode";
            this.gridColumn30.Name = "gridColumn30";
            this.gridColumn30.Visible = true;
            this.gridColumn30.VisibleIndex = 7;
            this.gridColumn30.Width = 159;
            // 
            // repositoryItemCheckEdit5
            // 
            this.repositoryItemCheckEdit5.AutoHeight = false;
            this.repositoryItemCheckEdit5.Caption = "Check";
            this.repositoryItemCheckEdit5.Name = "repositoryItemCheckEdit5";
            this.repositoryItemCheckEdit5.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // xtraTabPage9
            // 
            this.xtraTabPage9.Controls.Add(this.grInvoice_AllowanceCharge);
            this.xtraTabPage9.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPage9.Name = "xtraTabPage9";
            this.xtraTabPage9.Size = new System.Drawing.Size(1166, 210);
            this.xtraTabPage9.Text = "Fatura Indirim/Masraf";
            // 
            // grInvoice_AllowanceCharge
            // 
            this.grInvoice_AllowanceCharge.DataSource = this.tbInvoice_AllowanceCharge;
            this.grInvoice_AllowanceCharge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grInvoice_AllowanceCharge.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grInvoice_AllowanceCharge.Location = new System.Drawing.Point(0, 0);
            this.grInvoice_AllowanceCharge.MainView = this.grInvoice_AllowanceChargeView;
            this.grInvoice_AllowanceCharge.Margin = new System.Windows.Forms.Padding(2);
            this.grInvoice_AllowanceCharge.Name = "grInvoice_AllowanceCharge";
            this.grInvoice_AllowanceCharge.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit3});
            this.grInvoice_AllowanceCharge.Size = new System.Drawing.Size(1166, 210);
            this.grInvoice_AllowanceCharge.TabIndex = 2;
            this.grInvoice_AllowanceCharge.UseEmbeddedNavigator = true;
            this.grInvoice_AllowanceCharge.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grInvoice_AllowanceChargeView});
            // 
            // tbInvoice_AllowanceCharge
            // 
            this.tbInvoice_AllowanceCharge.Columns.AddRange(new System.Data.DataColumn[] {
            this.tbInvoice_AllowanceCharge_nID,
            this.tbInvoice_AllowanceCharge_InvoiceID,
            this.tbInvoice_AllowanceCharge_ChargeIndicator,
            this.tbInvoice_AllowanceCharge_AllowanceChargeReason,
            this.tbInvoice_AllowanceCharge_MultiplierFactorNumeric,
            this.tbInvoice_AllowanceCharge_Amount,
            this.tbInvoice_AllowanceCharge_Amount_currencyID,
            this.tbInvoice_AllowanceCharge_BaseAmount,
            this.tbInvoice_AllowanceCharge_BaseAmount_currencyID});
            this.tbInvoice_AllowanceCharge.Connection = this.FirmConn;
            this.tbInvoice_AllowanceCharge.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "nID"}, true)});
            this.tbInvoice_AllowanceCharge.CurrentRow = null;
            this.tbInvoice_AllowanceCharge.DataSourceLink = null;
            this.tbInvoice_AllowanceCharge.DeleteCommand = this.sqlCommand20;
            this.tbInvoice_AllowanceCharge.Filter = "";
            this.tbInvoice_AllowanceCharge.InsertCommand = this.sqlCommand18;
            this.tbInvoice_AllowanceCharge.LiveSave = false;
            this.tbInvoice_AllowanceCharge.MaxRecords = ((long)(0));
            this.tbInvoice_AllowanceCharge.Name = "tbInvoice_AllowanceCharge";
            this.tbInvoice_AllowanceCharge.ParentRelation_ChildColumns = null;
            this.tbInvoice_AllowanceCharge.ParentRelation_ParentColumns = null;
            this.tbInvoice_AllowanceCharge.ParentRelation_Table = null;
            this.tbInvoice_AllowanceCharge.Position = ((long)(-1));
            this.tbInvoice_AllowanceCharge.PrimaryKey = new System.Data.DataColumn[] {
        this.tbInvoice_AllowanceCharge_nID};
            this.tbInvoice_AllowanceCharge.Quoted = false;
            this.tbInvoice_AllowanceCharge.SelectCommand = this.sqlCommand17;
            this.tbInvoice_AllowanceCharge.TableName = "neoTable1";
            this.tbInvoice_AllowanceCharge.Transaction = null;
            this.tbInvoice_AllowanceCharge.UpdateCommand = this.sqlCommand19;
            // 
            // tbInvoice_AllowanceCharge_nID
            // 
            this.tbInvoice_AllowanceCharge_nID.AllowDBNull = false;
            this.tbInvoice_AllowanceCharge_nID.AutoIncrement = true;
            this.tbInvoice_AllowanceCharge_nID.ColumnName = "nID";
            this.tbInvoice_AllowanceCharge_nID.DataType = typeof(int);
            // 
            // tbInvoice_AllowanceCharge_InvoiceID
            // 
            this.tbInvoice_AllowanceCharge_InvoiceID.ColumnName = "InvoiceID";
            this.tbInvoice_AllowanceCharge_InvoiceID.DataType = typeof(int);
            // 
            // tbInvoice_AllowanceCharge_ChargeIndicator
            // 
            this.tbInvoice_AllowanceCharge_ChargeIndicator.ColumnName = "ChargeIndicator";
            this.tbInvoice_AllowanceCharge_ChargeIndicator.DataType = typeof(bool);
            // 
            // tbInvoice_AllowanceCharge_AllowanceChargeReason
            // 
            this.tbInvoice_AllowanceCharge_AllowanceChargeReason.ColumnName = "AllowanceChargeReason";
            // 
            // tbInvoice_AllowanceCharge_MultiplierFactorNumeric
            // 
            this.tbInvoice_AllowanceCharge_MultiplierFactorNumeric.ColumnName = "MultiplierFactorNumeric";
            this.tbInvoice_AllowanceCharge_MultiplierFactorNumeric.DataType = typeof(double);
            // 
            // tbInvoice_AllowanceCharge_Amount
            // 
            this.tbInvoice_AllowanceCharge_Amount.ColumnName = "Amount";
            this.tbInvoice_AllowanceCharge_Amount.DataType = typeof(double);
            // 
            // tbInvoice_AllowanceCharge_Amount_currencyID
            // 
            this.tbInvoice_AllowanceCharge_Amount_currencyID.ColumnName = "Amount_currencyID";
            // 
            // tbInvoice_AllowanceCharge_BaseAmount
            // 
            this.tbInvoice_AllowanceCharge_BaseAmount.ColumnName = "BaseAmount";
            this.tbInvoice_AllowanceCharge_BaseAmount.DataType = typeof(double);
            // 
            // tbInvoice_AllowanceCharge_BaseAmount_currencyID
            // 
            this.tbInvoice_AllowanceCharge_BaseAmount_currencyID.ColumnName = "BaseAmount_currencyID";
            // 
            // sqlCommand20
            // 
            this.sqlCommand20.CommandText = "DELETE FROM Invoice_AllowanceCharge WHERE nID = @nID";
            // 
            // sqlCommand18
            // 
            this.sqlCommand18.CommandText = resources.GetString("sqlCommand18.CommandText");
            this.sqlCommand18.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, true, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, 0)});
            // 
            // sqlCommand17
            // 
            this.sqlCommand17.CommandText = "SELECT * FROM Invoice_AllowanceCharge WHERE 1=1 \r\nAND InvoiceID = @InvoiceID ";
            this.sqlCommand17.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@InvoiceID", System.Data.SqlDbType.Int, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "0")});
            // 
            // sqlCommand19
            // 
            this.sqlCommand19.CommandText = resources.GetString("sqlCommand19.CommandText");
            // 
            // grInvoice_AllowanceChargeView
            // 
            this.grInvoice_AllowanceChargeView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnID2,
            this.colInvoiceID2,
            this.colChargeIndicator,
            this.colAllowanceChargeReason,
            this.colMultiplierFactorNumeric,
            this.colAmount,
            this.colAmount_currencyID,
            this.colBaseAmount,
            this.colBaseAmount_currencyID});
            this.grInvoice_AllowanceChargeView.GridControl = this.grInvoice_AllowanceCharge;
            this.grInvoice_AllowanceChargeView.Name = "grInvoice_AllowanceChargeView";
            this.grInvoice_AllowanceChargeView.OptionsView.ColumnAutoWidth = false;
            this.grInvoice_AllowanceChargeView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grInvoice_AllowanceChargeView.OptionsView.ShowFooter = true;
            this.grInvoice_AllowanceChargeView.OptionsView.ShowGroupPanel = false;
            // 
            // colnID2
            // 
            this.colnID2.FieldName = "nID";
            this.colnID2.Name = "colnID2";
            // 
            // colInvoiceID2
            // 
            this.colInvoiceID2.FieldName = "InvoiceID";
            this.colInvoiceID2.Name = "colInvoiceID2";
            // 
            // colChargeIndicator
            // 
            this.colChargeIndicator.FieldName = "ChargeIndicator";
            this.colChargeIndicator.Name = "colChargeIndicator";
            this.colChargeIndicator.Visible = true;
            this.colChargeIndicator.VisibleIndex = 0;
            // 
            // colAllowanceChargeReason
            // 
            this.colAllowanceChargeReason.FieldName = "AllowanceChargeReason";
            this.colAllowanceChargeReason.Name = "colAllowanceChargeReason";
            this.colAllowanceChargeReason.Visible = true;
            this.colAllowanceChargeReason.VisibleIndex = 1;
            this.colAllowanceChargeReason.Width = 131;
            // 
            // colMultiplierFactorNumeric
            // 
            this.colMultiplierFactorNumeric.FieldName = "MultiplierFactorNumeric";
            this.colMultiplierFactorNumeric.Name = "colMultiplierFactorNumeric";
            this.colMultiplierFactorNumeric.Visible = true;
            this.colMultiplierFactorNumeric.VisibleIndex = 2;
            this.colMultiplierFactorNumeric.Width = 229;
            // 
            // colAmount
            // 
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 3;
            // 
            // colAmount_currencyID
            // 
            this.colAmount_currencyID.FieldName = "Amount_currencyID";
            this.colAmount_currencyID.Name = "colAmount_currencyID";
            this.colAmount_currencyID.Visible = true;
            this.colAmount_currencyID.VisibleIndex = 4;
            this.colAmount_currencyID.Width = 160;
            // 
            // colBaseAmount
            // 
            this.colBaseAmount.FieldName = "BaseAmount";
            this.colBaseAmount.Name = "colBaseAmount";
            this.colBaseAmount.Visible = true;
            this.colBaseAmount.VisibleIndex = 5;
            this.colBaseAmount.Width = 157;
            // 
            // colBaseAmount_currencyID
            // 
            this.colBaseAmount_currencyID.FieldName = "BaseAmount_currencyID";
            this.colBaseAmount_currencyID.Name = "colBaseAmount_currencyID";
            this.colBaseAmount_currencyID.Visible = true;
            this.colBaseAmount_currencyID.VisibleIndex = 6;
            this.colBaseAmount_currencyID.Width = 176;
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Caption = "Check";
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            this.repositoryItemCheckEdit3.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // xtraTabPage15
            // 
            this.xtraTabPage15.Controls.Add(this.grInvoice_Note);
            this.xtraTabPage15.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPage15.Name = "xtraTabPage15";
            this.xtraTabPage15.Size = new System.Drawing.Size(1172, 238);
            this.xtraTabPage15.Text = "Fatura Notlari";
            // 
            // grInvoice_Note
            // 
            this.grInvoice_Note.DataSource = this.tbInvoice_Note;
            this.grInvoice_Note.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grInvoice_Note.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grInvoice_Note.Location = new System.Drawing.Point(0, 0);
            this.grInvoice_Note.MainView = this.grInvoice_NoteView;
            this.grInvoice_Note.Margin = new System.Windows.Forms.Padding(2);
            this.grInvoice_Note.Name = "grInvoice_Note";
            this.grInvoice_Note.Size = new System.Drawing.Size(1172, 238);
            this.grInvoice_Note.TabIndex = 8;
            this.grInvoice_Note.UseEmbeddedNavigator = true;
            this.grInvoice_Note.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grInvoice_NoteView});
            this.grInvoice_Note.EditorKeyDown += new System.Windows.Forms.KeyEventHandler(this.grInvoice_Note_EditorKeyDown);
            this.grInvoice_Note.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grInvoice_Note_KeyDown);
            // 
            // tbInvoice_Note
            // 
            this.tbInvoice_Note.Columns.AddRange(new System.Data.DataColumn[] {
            this.tbInvoice_Note_nID,
            this.tbInvoice_Note_InvoiceID,
            this.tbInvoice_Note_Note});
            this.tbInvoice_Note.Connection = this.FirmConn;
            this.tbInvoice_Note.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "nID"}, true)});
            this.tbInvoice_Note.CurrentRow = null;
            this.tbInvoice_Note.DataSourceLink = null;
            this.tbInvoice_Note.DeleteCommand = this.sqlCommand44;
            this.tbInvoice_Note.Filter = "";
            this.tbInvoice_Note.InsertCommand = this.sqlCommand42;
            this.tbInvoice_Note.LiveSave = false;
            this.tbInvoice_Note.MaxRecords = ((long)(0));
            this.tbInvoice_Note.Name = "tbInvoice_Note";
            this.tbInvoice_Note.ParentRelation_ChildColumns = null;
            this.tbInvoice_Note.ParentRelation_ParentColumns = null;
            this.tbInvoice_Note.ParentRelation_Table = null;
            this.tbInvoice_Note.Position = ((long)(-1));
            this.tbInvoice_Note.PrimaryKey = new System.Data.DataColumn[] {
        this.tbInvoice_Note_nID};
            this.tbInvoice_Note.Quoted = false;
            this.tbInvoice_Note.SelectCommand = this.sqlCommand41;
            this.tbInvoice_Note.TableName = "neoTable1";
            this.tbInvoice_Note.Transaction = null;
            this.tbInvoice_Note.UpdateCommand = this.sqlCommand43;
            // 
            // tbInvoice_Note_nID
            // 
            this.tbInvoice_Note_nID.AllowDBNull = false;
            this.tbInvoice_Note_nID.AutoIncrement = true;
            this.tbInvoice_Note_nID.ColumnName = "nID";
            this.tbInvoice_Note_nID.DataType = typeof(int);
            // 
            // tbInvoice_Note_InvoiceID
            // 
            this.tbInvoice_Note_InvoiceID.ColumnName = "InvoiceID";
            this.tbInvoice_Note_InvoiceID.DataType = typeof(int);
            // 
            // tbInvoice_Note_Note
            // 
            this.tbInvoice_Note_Note.ColumnName = "Note";
            // 
            // sqlCommand44
            // 
            this.sqlCommand44.CommandText = "DELETE FROM Invoice_Note WHERE nID = @nID";
            // 
            // sqlCommand42
            // 
            this.sqlCommand42.CommandText = "INSERT INTO Invoice_Note (\r\nInvoiceID , Note)\r\n VALUES (\r\n@InvoiceID , @Note)\r\nSE" +
    "LECT @PRIMARYFIELD_nID = SCOPE_IDENTITY() \r\n";
            this.sqlCommand42.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, true, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, 0)});
            // 
            // sqlCommand41
            // 
            this.sqlCommand41.CommandText = "SELECT * FROM Invoice_Note WHERE 1=1 \r\nAND InvoiceID = @InvoiceID \r\n";
            this.sqlCommand41.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@InvoiceID", System.Data.SqlDbType.Int, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "0")});
            // 
            // sqlCommand43
            // 
            this.sqlCommand43.CommandText = "UPDATE Invoice_Note SET \r\nInvoiceID = @InvoiceID , Note = @Note\r\nWHERE nID = @nID" +
    "";
            // 
            // grInvoice_NoteView
            // 
            this.grInvoice_NoteView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnID8,
            this.colInvoiceID8,
            this.colNote2});
            this.grInvoice_NoteView.GridControl = this.grInvoice_Note;
            this.grInvoice_NoteView.Name = "grInvoice_NoteView";
            this.grInvoice_NoteView.OptionsView.ColumnAutoWidth = false;
            this.grInvoice_NoteView.OptionsView.ShowFooter = true;
            this.grInvoice_NoteView.OptionsView.ShowGroupPanel = false;
            // 
            // colnID8
            // 
            this.colnID8.FieldName = "nID";
            this.colnID8.Name = "colnID8";
            // 
            // colInvoiceID8
            // 
            this.colInvoiceID8.FieldName = "InvoiceID";
            this.colInvoiceID8.Name = "colInvoiceID8";
            // 
            // colNote2
            // 
            this.colNote2.FieldName = "Note";
            this.colNote2.Name = "colNote2";
            this.colNote2.Visible = true;
            this.colNote2.VisibleIndex = 0;
            this.colNote2.Width = 694;
            // 
            // xtraTabPage6
            // 
            this.xtraTabPage6.Controls.Add(this.grInvoice_OrderReference);
            this.xtraTabPage6.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPage6.Name = "xtraTabPage6";
            this.xtraTabPage6.Size = new System.Drawing.Size(1172, 238);
            this.xtraTabPage6.Text = "Siparis";
            // 
            // grInvoice_OrderReference
            // 
            this.grInvoice_OrderReference.DataSource = this.tbInvoice_OrderReference;
            this.grInvoice_OrderReference.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grInvoice_OrderReference.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grInvoice_OrderReference.Location = new System.Drawing.Point(0, 0);
            this.grInvoice_OrderReference.MainView = this.grInvoice_OrderReferenceView;
            this.grInvoice_OrderReference.Margin = new System.Windows.Forms.Padding(2);
            this.grInvoice_OrderReference.Name = "grInvoice_OrderReference";
            this.grInvoice_OrderReference.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit4});
            this.grInvoice_OrderReference.Size = new System.Drawing.Size(1172, 238);
            this.grInvoice_OrderReference.TabIndex = 3;
            this.grInvoice_OrderReference.UseEmbeddedNavigator = true;
            this.grInvoice_OrderReference.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grInvoice_OrderReferenceView});
            // 
            // tbInvoice_OrderReference
            // 
            this.tbInvoice_OrderReference.Columns.AddRange(new System.Data.DataColumn[] {
            this.tbInvoice_OrderReference_nID,
            this.tbInvoice_OrderReference_InvoiceID,
            this.tbInvoice_OrderReference_ID,
            this.tbInvoice_OrderReference_IssueDate});
            this.tbInvoice_OrderReference.Connection = this.FirmConn;
            this.tbInvoice_OrderReference.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "nID"}, true)});
            this.tbInvoice_OrderReference.CurrentRow = null;
            this.tbInvoice_OrderReference.DataSourceLink = null;
            this.tbInvoice_OrderReference.DeleteCommand = this.sqlCommand24;
            this.tbInvoice_OrderReference.Filter = "";
            this.tbInvoice_OrderReference.InsertCommand = this.sqlCommand22;
            this.tbInvoice_OrderReference.LiveSave = false;
            this.tbInvoice_OrderReference.MaxRecords = ((long)(0));
            this.tbInvoice_OrderReference.Name = "tbInvoice_OrderReference";
            this.tbInvoice_OrderReference.ParentRelation_ChildColumns = null;
            this.tbInvoice_OrderReference.ParentRelation_ParentColumns = null;
            this.tbInvoice_OrderReference.ParentRelation_Table = null;
            this.tbInvoice_OrderReference.Position = ((long)(-1));
            this.tbInvoice_OrderReference.PrimaryKey = new System.Data.DataColumn[] {
        this.tbInvoice_OrderReference_nID};
            this.tbInvoice_OrderReference.Quoted = false;
            this.tbInvoice_OrderReference.SelectCommand = this.sqlCommand21;
            this.tbInvoice_OrderReference.TableName = "neoTable1";
            this.tbInvoice_OrderReference.Transaction = null;
            this.tbInvoice_OrderReference.UpdateCommand = this.sqlCommand23;
            // 
            // tbInvoice_OrderReference_nID
            // 
            this.tbInvoice_OrderReference_nID.AllowDBNull = false;
            this.tbInvoice_OrderReference_nID.AutoIncrement = true;
            this.tbInvoice_OrderReference_nID.ColumnName = "nID";
            this.tbInvoice_OrderReference_nID.DataType = typeof(int);
            // 
            // tbInvoice_OrderReference_InvoiceID
            // 
            this.tbInvoice_OrderReference_InvoiceID.ColumnName = "InvoiceID";
            this.tbInvoice_OrderReference_InvoiceID.DataType = typeof(int);
            // 
            // tbInvoice_OrderReference_ID
            // 
            this.tbInvoice_OrderReference_ID.ColumnName = "ID";
            // 
            // tbInvoice_OrderReference_IssueDate
            // 
            this.tbInvoice_OrderReference_IssueDate.ColumnName = "IssueDate";
            this.tbInvoice_OrderReference_IssueDate.DataType = typeof(System.DateTime);
            // 
            // sqlCommand24
            // 
            this.sqlCommand24.CommandText = "DELETE FROM Invoice_OrderReference WHERE nID = @nID";
            // 
            // sqlCommand22
            // 
            this.sqlCommand22.CommandText = "INSERT INTO Invoice_OrderReference (\r\nInvoiceID , ID , IssueDate)\r\n VALUES (\r\n@In" +
    "voiceID , @ID , @IssueDate)\r\nSELECT @PRIMARYFIELD_nID = SCOPE_IDENTITY() \r\n";
            this.sqlCommand22.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, true, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, 0)});
            // 
            // sqlCommand21
            // 
            this.sqlCommand21.CommandText = "SELECT * FROM Invoice_OrderReference WHERE 1=1 \r\nAND InvoiceID = @InvoiceID \r\n";
            this.sqlCommand21.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@InvoiceID", System.Data.SqlDbType.Int, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "0")});
            // 
            // sqlCommand23
            // 
            this.sqlCommand23.CommandText = "UPDATE Invoice_OrderReference SET \r\nInvoiceID = @InvoiceID , ID = @ID , IssueDate" +
    " = @IssueDate\r\nWHERE nID = @nID";
            // 
            // grInvoice_OrderReferenceView
            // 
            this.grInvoice_OrderReferenceView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnID3,
            this.colInvoiceID3,
            this.colID1,
            this.colIssueDate});
            this.grInvoice_OrderReferenceView.GridControl = this.grInvoice_OrderReference;
            this.grInvoice_OrderReferenceView.Name = "grInvoice_OrderReferenceView";
            this.grInvoice_OrderReferenceView.OptionsView.ColumnAutoWidth = false;
            this.grInvoice_OrderReferenceView.OptionsView.ShowFooter = true;
            this.grInvoice_OrderReferenceView.OptionsView.ShowGroupPanel = false;
            // 
            // colnID3
            // 
            this.colnID3.FieldName = "nID";
            this.colnID3.Name = "colnID3";
            // 
            // colInvoiceID3
            // 
            this.colInvoiceID3.FieldName = "InvoiceID";
            this.colInvoiceID3.Name = "colInvoiceID3";
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            this.colID1.Visible = true;
            this.colID1.VisibleIndex = 0;
            this.colID1.Width = 167;
            // 
            // colIssueDate
            // 
            this.colIssueDate.FieldName = "IssueDate";
            this.colIssueDate.Name = "colIssueDate";
            this.colIssueDate.Visible = true;
            this.colIssueDate.VisibleIndex = 1;
            this.colIssueDate.Width = 143;
            // 
            // repositoryItemCheckEdit4
            // 
            this.repositoryItemCheckEdit4.AutoHeight = false;
            this.repositoryItemCheckEdit4.Caption = "Check";
            this.repositoryItemCheckEdit4.Name = "repositoryItemCheckEdit4";
            this.repositoryItemCheckEdit4.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // xtraTabPage10
            // 
            this.xtraTabPage10.Controls.Add(this.grInvoice_DespatchDocumentReference);
            this.xtraTabPage10.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPage10.Name = "xtraTabPage10";
            this.xtraTabPage10.Size = new System.Drawing.Size(1172, 238);
            this.xtraTabPage10.Text = "Irsaliyeler";
            // 
            // grInvoice_DespatchDocumentReference
            // 
            this.grInvoice_DespatchDocumentReference.DataSource = this.tbInvoice_DespatchDocumentReference;
            this.grInvoice_DespatchDocumentReference.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grInvoice_DespatchDocumentReference.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grInvoice_DespatchDocumentReference.Location = new System.Drawing.Point(0, 0);
            this.grInvoice_DespatchDocumentReference.MainView = this.grInvoice_DespatchDocumentReferenceView;
            this.grInvoice_DespatchDocumentReference.Margin = new System.Windows.Forms.Padding(2);
            this.grInvoice_DespatchDocumentReference.Name = "grInvoice_DespatchDocumentReference";
            this.grInvoice_DespatchDocumentReference.Size = new System.Drawing.Size(1172, 238);
            this.grInvoice_DespatchDocumentReference.TabIndex = 4;
            this.grInvoice_DespatchDocumentReference.UseEmbeddedNavigator = true;
            this.grInvoice_DespatchDocumentReference.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grInvoice_DespatchDocumentReferenceView});
            // 
            // tbInvoice_DespatchDocumentReference
            // 
            this.tbInvoice_DespatchDocumentReference.Columns.AddRange(new System.Data.DataColumn[] {
            this.tbInvoice_DespatchDocumentReference_nID,
            this.tbInvoice_DespatchDocumentReference_InvoiceID,
            this.tbInvoice_DespatchDocumentReference_ID,
            this.tbInvoice_DespatchDocumentReference_IssueDate});
            this.tbInvoice_DespatchDocumentReference.Connection = this.FirmConn;
            this.tbInvoice_DespatchDocumentReference.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "nID"}, true)});
            this.tbInvoice_DespatchDocumentReference.CurrentRow = null;
            this.tbInvoice_DespatchDocumentReference.DataSourceLink = null;
            this.tbInvoice_DespatchDocumentReference.DeleteCommand = this.sqlCommand28;
            this.tbInvoice_DespatchDocumentReference.Filter = "";
            this.tbInvoice_DespatchDocumentReference.InsertCommand = this.sqlCommand26;
            this.tbInvoice_DespatchDocumentReference.LiveSave = false;
            this.tbInvoice_DespatchDocumentReference.MaxRecords = ((long)(0));
            this.tbInvoice_DespatchDocumentReference.Name = "tbInvoice_DespatchDocumentReference";
            this.tbInvoice_DespatchDocumentReference.ParentRelation_ChildColumns = null;
            this.tbInvoice_DespatchDocumentReference.ParentRelation_ParentColumns = null;
            this.tbInvoice_DespatchDocumentReference.ParentRelation_Table = null;
            this.tbInvoice_DespatchDocumentReference.Position = ((long)(-1));
            this.tbInvoice_DespatchDocumentReference.PrimaryKey = new System.Data.DataColumn[] {
        this.tbInvoice_DespatchDocumentReference_nID};
            this.tbInvoice_DespatchDocumentReference.Quoted = false;
            this.tbInvoice_DespatchDocumentReference.SelectCommand = this.sqlCommand25;
            this.tbInvoice_DespatchDocumentReference.TableName = "neoTable1";
            this.tbInvoice_DespatchDocumentReference.Transaction = null;
            this.tbInvoice_DespatchDocumentReference.UpdateCommand = this.sqlCommand27;
            // 
            // tbInvoice_DespatchDocumentReference_nID
            // 
            this.tbInvoice_DespatchDocumentReference_nID.AllowDBNull = false;
            this.tbInvoice_DespatchDocumentReference_nID.AutoIncrement = true;
            this.tbInvoice_DespatchDocumentReference_nID.ColumnName = "nID";
            this.tbInvoice_DespatchDocumentReference_nID.DataType = typeof(int);
            // 
            // tbInvoice_DespatchDocumentReference_InvoiceID
            // 
            this.tbInvoice_DespatchDocumentReference_InvoiceID.ColumnName = "InvoiceID";
            this.tbInvoice_DespatchDocumentReference_InvoiceID.DataType = typeof(int);
            // 
            // tbInvoice_DespatchDocumentReference_ID
            // 
            this.tbInvoice_DespatchDocumentReference_ID.ColumnName = "ID";
            // 
            // tbInvoice_DespatchDocumentReference_IssueDate
            // 
            this.tbInvoice_DespatchDocumentReference_IssueDate.ColumnName = "IssueDate";
            this.tbInvoice_DespatchDocumentReference_IssueDate.DataType = typeof(System.DateTime);
            // 
            // sqlCommand28
            // 
            this.sqlCommand28.CommandText = "DELETE FROM Invoice_DespatchDocumentReference WHERE nID = @nID";
            // 
            // sqlCommand26
            // 
            this.sqlCommand26.CommandText = "INSERT INTO Invoice_DespatchDocumentReference (\r\nInvoiceID , ID , IssueDate)\r\n VA" +
    "LUES (\r\n@InvoiceID , @ID , @IssueDate)\r\nSELECT @PRIMARYFIELD_nID = SCOPE_IDENTIT" +
    "Y() \r\n";
            this.sqlCommand26.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, true, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, 0)});
            // 
            // sqlCommand25
            // 
            this.sqlCommand25.CommandText = "SELECT * FROM Invoice_DespatchDocumentReference WHERE 1=1 \r\nAND InvoiceID = @Invo" +
    "iceID \r\n";
            this.sqlCommand25.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@InvoiceID", System.Data.SqlDbType.Int, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "0")});
            // 
            // sqlCommand27
            // 
            this.sqlCommand27.CommandText = "UPDATE Invoice_DespatchDocumentReference SET \r\nInvoiceID = @InvoiceID , ID = @ID " +
    ", IssueDate = @IssueDate\r\nWHERE nID = @nID";
            // 
            // grInvoice_DespatchDocumentReferenceView
            // 
            this.grInvoice_DespatchDocumentReferenceView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnID4,
            this.colInvoiceID4,
            this.colID2,
            this.colIssueDate1});
            this.grInvoice_DespatchDocumentReferenceView.GridControl = this.grInvoice_DespatchDocumentReference;
            this.grInvoice_DespatchDocumentReferenceView.Name = "grInvoice_DespatchDocumentReferenceView";
            this.grInvoice_DespatchDocumentReferenceView.OptionsView.ColumnAutoWidth = false;
            this.grInvoice_DespatchDocumentReferenceView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grInvoice_DespatchDocumentReferenceView.OptionsView.ShowFooter = true;
            this.grInvoice_DespatchDocumentReferenceView.OptionsView.ShowGroupPanel = false;
            // 
            // colnID4
            // 
            this.colnID4.FieldName = "nID";
            this.colnID4.Name = "colnID4";
            // 
            // colInvoiceID4
            // 
            this.colInvoiceID4.FieldName = "InvoiceID";
            this.colInvoiceID4.Name = "colInvoiceID4";
            // 
            // colID2
            // 
            this.colID2.FieldName = "ID";
            this.colID2.Name = "colID2";
            this.colID2.Visible = true;
            this.colID2.VisibleIndex = 0;
            this.colID2.Width = 140;
            // 
            // colIssueDate1
            // 
            this.colIssueDate1.FieldName = "IssueDate";
            this.colIssueDate1.Name = "colIssueDate1";
            this.colIssueDate1.Visible = true;
            this.colIssueDate1.VisibleIndex = 1;
            this.colIssueDate1.Width = 148;
            // 
            // xtraTabPage11
            // 
            this.xtraTabPage11.Controls.Add(this.xtraTabControl4);
            this.xtraTabPage11.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPage11.Name = "xtraTabPage11";
            this.xtraTabPage11.Size = new System.Drawing.Size(1172, 238);
            this.xtraTabPage11.Text = "Odemeler";
            // 
            // xtraTabControl4
            // 
            this.xtraTabControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl4.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl4.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabControl4.Name = "xtraTabControl4";
            this.xtraTabControl4.SelectedTabPage = this.xtraTabPage12;
            this.xtraTabControl4.Size = new System.Drawing.Size(1172, 238);
            this.xtraTabControl4.TabIndex = 6;
            this.xtraTabControl4.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage12,
            this.xtraTabPage13});
            // 
            // xtraTabPage12
            // 
            this.xtraTabPage12.Controls.Add(this.grInvoice_PaymentMeans);
            this.xtraTabPage12.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPage12.Name = "xtraTabPage12";
            this.xtraTabPage12.Size = new System.Drawing.Size(1166, 210);
            this.xtraTabPage12.Text = "Odemeler";
            // 
            // grInvoice_PaymentMeans
            // 
            this.grInvoice_PaymentMeans.DataSource = this.tbInvoice_PaymentMeans;
            this.grInvoice_PaymentMeans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grInvoice_PaymentMeans.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grInvoice_PaymentMeans.Location = new System.Drawing.Point(0, 0);
            this.grInvoice_PaymentMeans.MainView = this.grInvoice_PaymentMeansView;
            this.grInvoice_PaymentMeans.Margin = new System.Windows.Forms.Padding(2);
            this.grInvoice_PaymentMeans.Name = "grInvoice_PaymentMeans";
            this.grInvoice_PaymentMeans.Size = new System.Drawing.Size(1166, 210);
            this.grInvoice_PaymentMeans.TabIndex = 5;
            this.grInvoice_PaymentMeans.UseEmbeddedNavigator = true;
            this.grInvoice_PaymentMeans.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grInvoice_PaymentMeansView});
            // 
            // tbInvoice_PaymentMeans
            // 
            this.tbInvoice_PaymentMeans.Columns.AddRange(new System.Data.DataColumn[] {
            this.tbInvoice_PaymentMeans_nID,
            this.tbInvoice_PaymentMeans_InvoiceID,
            this.tbInvoice_PaymentMeans_PaymentMeansCode,
            this.tbInvoice_PaymentMeans_PaymentDueDate,
            this.tbInvoice_PaymentMeans_PaymentChannelCode,
            this.tbInvoice_PaymentMeans_InstructionNote,
            this.tbInvoice_PaymentMeans_PayeeFinancialAccount_ID,
            this.tbInvoice_PaymentMeans_PayeeFinancialAccount_CurrencyCode,
            this.tbInvoice_PaymentMeans_PayeeFinancialAccount_PaymentNote});
            this.tbInvoice_PaymentMeans.Connection = this.FirmConn;
            this.tbInvoice_PaymentMeans.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "nID"}, true)});
            this.tbInvoice_PaymentMeans.CurrentRow = null;
            this.tbInvoice_PaymentMeans.DataSourceLink = null;
            this.tbInvoice_PaymentMeans.DeleteCommand = this.sqlCommand32;
            this.tbInvoice_PaymentMeans.Filter = "";
            this.tbInvoice_PaymentMeans.InsertCommand = this.sqlCommand30;
            this.tbInvoice_PaymentMeans.LiveSave = false;
            this.tbInvoice_PaymentMeans.MaxRecords = ((long)(0));
            this.tbInvoice_PaymentMeans.Name = "tbInvoice_PaymentMeans";
            this.tbInvoice_PaymentMeans.ParentRelation_ChildColumns = null;
            this.tbInvoice_PaymentMeans.ParentRelation_ParentColumns = null;
            this.tbInvoice_PaymentMeans.ParentRelation_Table = null;
            this.tbInvoice_PaymentMeans.Position = ((long)(-1));
            this.tbInvoice_PaymentMeans.PrimaryKey = new System.Data.DataColumn[] {
        this.tbInvoice_PaymentMeans_nID};
            this.tbInvoice_PaymentMeans.Quoted = false;
            this.tbInvoice_PaymentMeans.SelectCommand = this.sqlCommand29;
            this.tbInvoice_PaymentMeans.TableName = "neoTable1";
            this.tbInvoice_PaymentMeans.Transaction = null;
            this.tbInvoice_PaymentMeans.UpdateCommand = this.sqlCommand31;
            // 
            // tbInvoice_PaymentMeans_nID
            // 
            this.tbInvoice_PaymentMeans_nID.AllowDBNull = false;
            this.tbInvoice_PaymentMeans_nID.AutoIncrement = true;
            this.tbInvoice_PaymentMeans_nID.ColumnName = "nID";
            this.tbInvoice_PaymentMeans_nID.DataType = typeof(int);
            // 
            // tbInvoice_PaymentMeans_InvoiceID
            // 
            this.tbInvoice_PaymentMeans_InvoiceID.ColumnName = "InvoiceID";
            this.tbInvoice_PaymentMeans_InvoiceID.DataType = typeof(int);
            // 
            // tbInvoice_PaymentMeans_PaymentMeansCode
            // 
            this.tbInvoice_PaymentMeans_PaymentMeansCode.ColumnName = "PaymentMeansCode";
            // 
            // tbInvoice_PaymentMeans_PaymentDueDate
            // 
            this.tbInvoice_PaymentMeans_PaymentDueDate.ColumnName = "PaymentDueDate";
            this.tbInvoice_PaymentMeans_PaymentDueDate.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_PaymentMeans_PaymentChannelCode
            // 
            this.tbInvoice_PaymentMeans_PaymentChannelCode.ColumnName = "PaymentChannelCode";
            // 
            // tbInvoice_PaymentMeans_InstructionNote
            // 
            this.tbInvoice_PaymentMeans_InstructionNote.ColumnName = "InstructionNote";
            // 
            // tbInvoice_PaymentMeans_PayeeFinancialAccount_ID
            // 
            this.tbInvoice_PaymentMeans_PayeeFinancialAccount_ID.ColumnName = "PayeeFinancialAccount_ID";
            // 
            // tbInvoice_PaymentMeans_PayeeFinancialAccount_CurrencyCode
            // 
            this.tbInvoice_PaymentMeans_PayeeFinancialAccount_CurrencyCode.ColumnName = "PayeeFinancialAccount_CurrencyCode";
            // 
            // tbInvoice_PaymentMeans_PayeeFinancialAccount_PaymentNote
            // 
            this.tbInvoice_PaymentMeans_PayeeFinancialAccount_PaymentNote.ColumnName = "PayeeFinancialAccount_PaymentNote";
            // 
            // sqlCommand32
            // 
            this.sqlCommand32.CommandText = "DELETE FROM Invoice_PaymentMeans WHERE nID = @nID";
            // 
            // sqlCommand30
            // 
            this.sqlCommand30.CommandText = resources.GetString("sqlCommand30.CommandText");
            this.sqlCommand30.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, true, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, 0)});
            // 
            // sqlCommand29
            // 
            this.sqlCommand29.CommandText = "SELECT * FROM Invoice_PaymentMeans WHERE 1=1 \r\nAND InvoiceID = @InvoiceID \r\n";
            this.sqlCommand29.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@InvoiceID", System.Data.SqlDbType.Int, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "0")});
            // 
            // sqlCommand31
            // 
            this.sqlCommand31.CommandText = resources.GetString("sqlCommand31.CommandText");
            // 
            // grInvoice_PaymentMeansView
            // 
            this.grInvoice_PaymentMeansView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnID5,
            this.colInvoiceID5,
            this.colPaymentMeansCode,
            this.colPaymentDueDate,
            this.colPaymentChannelCode,
            this.colInstructionNote,
            this.colPayeeFinancialAccount_ID,
            this.colPayeeFinancialAccount_CurrencyCode,
            this.colPayeeFinancialAccount_PaymentNote});
            this.grInvoice_PaymentMeansView.GridControl = this.grInvoice_PaymentMeans;
            this.grInvoice_PaymentMeansView.Name = "grInvoice_PaymentMeansView";
            this.grInvoice_PaymentMeansView.OptionsView.ColumnAutoWidth = false;
            this.grInvoice_PaymentMeansView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grInvoice_PaymentMeansView.OptionsView.ShowFooter = true;
            this.grInvoice_PaymentMeansView.OptionsView.ShowGroupPanel = false;
            // 
            // colnID5
            // 
            this.colnID5.FieldName = "nID";
            this.colnID5.Name = "colnID5";
            // 
            // colInvoiceID5
            // 
            this.colInvoiceID5.FieldName = "InvoiceID";
            this.colInvoiceID5.Name = "colInvoiceID5";
            // 
            // colPaymentMeansCode
            // 
            this.colPaymentMeansCode.FieldName = "PaymentMeansCode";
            this.colPaymentMeansCode.Name = "colPaymentMeansCode";
            this.colPaymentMeansCode.Visible = true;
            this.colPaymentMeansCode.VisibleIndex = 0;
            this.colPaymentMeansCode.Width = 155;
            // 
            // colPaymentDueDate
            // 
            this.colPaymentDueDate.FieldName = "PaymentDueDate";
            this.colPaymentDueDate.Name = "colPaymentDueDate";
            this.colPaymentDueDate.Visible = true;
            this.colPaymentDueDate.VisibleIndex = 1;
            this.colPaymentDueDate.Width = 161;
            // 
            // colPaymentChannelCode
            // 
            this.colPaymentChannelCode.FieldName = "PaymentChannelCode";
            this.colPaymentChannelCode.Name = "colPaymentChannelCode";
            this.colPaymentChannelCode.Visible = true;
            this.colPaymentChannelCode.VisibleIndex = 2;
            this.colPaymentChannelCode.Width = 158;
            // 
            // colInstructionNote
            // 
            this.colInstructionNote.FieldName = "InstructionNote";
            this.colInstructionNote.Name = "colInstructionNote";
            this.colInstructionNote.Visible = true;
            this.colInstructionNote.VisibleIndex = 3;
            this.colInstructionNote.Width = 178;
            // 
            // colPayeeFinancialAccount_ID
            // 
            this.colPayeeFinancialAccount_ID.FieldName = "PayeeFinancialAccount_ID";
            this.colPayeeFinancialAccount_ID.Name = "colPayeeFinancialAccount_ID";
            this.colPayeeFinancialAccount_ID.Visible = true;
            this.colPayeeFinancialAccount_ID.VisibleIndex = 4;
            this.colPayeeFinancialAccount_ID.Width = 188;
            // 
            // colPayeeFinancialAccount_CurrencyCode
            // 
            this.colPayeeFinancialAccount_CurrencyCode.FieldName = "PayeeFinancialAccount_CurrencyCode";
            this.colPayeeFinancialAccount_CurrencyCode.Name = "colPayeeFinancialAccount_CurrencyCode";
            this.colPayeeFinancialAccount_CurrencyCode.Visible = true;
            this.colPayeeFinancialAccount_CurrencyCode.VisibleIndex = 5;
            this.colPayeeFinancialAccount_CurrencyCode.Width = 169;
            // 
            // colPayeeFinancialAccount_PaymentNote
            // 
            this.colPayeeFinancialAccount_PaymentNote.FieldName = "PayeeFinancialAccount_PaymentNote";
            this.colPayeeFinancialAccount_PaymentNote.Name = "colPayeeFinancialAccount_PaymentNote";
            this.colPayeeFinancialAccount_PaymentNote.Visible = true;
            this.colPayeeFinancialAccount_PaymentNote.VisibleIndex = 6;
            this.colPayeeFinancialAccount_PaymentNote.Width = 174;
            // 
            // xtraTabPage13
            // 
            this.xtraTabPage13.Controls.Add(this.grInvoice_PaymentTerms);
            this.xtraTabPage13.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPage13.Name = "xtraTabPage13";
            this.xtraTabPage13.Size = new System.Drawing.Size(1166, 210);
            this.xtraTabPage13.Text = "Odeme kosullari";
            // 
            // grInvoice_PaymentTerms
            // 
            this.grInvoice_PaymentTerms.DataSource = this.tbInvoice_PaymentTerms;
            this.grInvoice_PaymentTerms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grInvoice_PaymentTerms.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grInvoice_PaymentTerms.Location = new System.Drawing.Point(0, 0);
            this.grInvoice_PaymentTerms.MainView = this.grInvoice_PaymentTermsView;
            this.grInvoice_PaymentTerms.Margin = new System.Windows.Forms.Padding(2);
            this.grInvoice_PaymentTerms.Name = "grInvoice_PaymentTerms";
            this.grInvoice_PaymentTerms.Size = new System.Drawing.Size(1166, 210);
            this.grInvoice_PaymentTerms.TabIndex = 6;
            this.grInvoice_PaymentTerms.UseEmbeddedNavigator = true;
            this.grInvoice_PaymentTerms.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grInvoice_PaymentTermsView});
            // 
            // tbInvoice_PaymentTerms
            // 
            this.tbInvoice_PaymentTerms.Columns.AddRange(new System.Data.DataColumn[] {
            this.tbInvoice_PaymentTerms_nID,
            this.tbInvoice_PaymentTerms_InvoiceID,
            this.tbInvoice_PaymentTerms_Note,
            this.tbInvoice_PaymentTerms_PenaltySurchargePercent,
            this.tbInvoice_PaymentTerms_Amount,
            this.tbInvoice_PaymentTerms_Amount_currencyID});
            this.tbInvoice_PaymentTerms.Connection = this.FirmConn;
            this.tbInvoice_PaymentTerms.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "nID"}, true)});
            this.tbInvoice_PaymentTerms.CurrentRow = null;
            this.tbInvoice_PaymentTerms.DataSourceLink = null;
            this.tbInvoice_PaymentTerms.DeleteCommand = this.sqlCommand36;
            this.tbInvoice_PaymentTerms.Filter = "";
            this.tbInvoice_PaymentTerms.InsertCommand = this.sqlCommand34;
            this.tbInvoice_PaymentTerms.LiveSave = false;
            this.tbInvoice_PaymentTerms.MaxRecords = ((long)(0));
            this.tbInvoice_PaymentTerms.Name = "tbInvoice_PaymentTerms";
            this.tbInvoice_PaymentTerms.ParentRelation_ChildColumns = null;
            this.tbInvoice_PaymentTerms.ParentRelation_ParentColumns = null;
            this.tbInvoice_PaymentTerms.ParentRelation_Table = null;
            this.tbInvoice_PaymentTerms.Position = ((long)(-1));
            this.tbInvoice_PaymentTerms.PrimaryKey = new System.Data.DataColumn[] {
        this.tbInvoice_PaymentTerms_nID};
            this.tbInvoice_PaymentTerms.Quoted = false;
            this.tbInvoice_PaymentTerms.SelectCommand = this.sqlCommand33;
            this.tbInvoice_PaymentTerms.TableName = "neoTable1";
            this.tbInvoice_PaymentTerms.Transaction = null;
            this.tbInvoice_PaymentTerms.UpdateCommand = this.sqlCommand35;
            // 
            // tbInvoice_PaymentTerms_nID
            // 
            this.tbInvoice_PaymentTerms_nID.AllowDBNull = false;
            this.tbInvoice_PaymentTerms_nID.AutoIncrement = true;
            this.tbInvoice_PaymentTerms_nID.ColumnName = "nID";
            this.tbInvoice_PaymentTerms_nID.DataType = typeof(int);
            // 
            // tbInvoice_PaymentTerms_InvoiceID
            // 
            this.tbInvoice_PaymentTerms_InvoiceID.ColumnName = "InvoiceID";
            this.tbInvoice_PaymentTerms_InvoiceID.DataType = typeof(int);
            // 
            // tbInvoice_PaymentTerms_Note
            // 
            this.tbInvoice_PaymentTerms_Note.ColumnName = "Note";
            // 
            // tbInvoice_PaymentTerms_PenaltySurchargePercent
            // 
            this.tbInvoice_PaymentTerms_PenaltySurchargePercent.ColumnName = "PenaltySurchargePercent";
            this.tbInvoice_PaymentTerms_PenaltySurchargePercent.DataType = typeof(double);
            // 
            // tbInvoice_PaymentTerms_Amount
            // 
            this.tbInvoice_PaymentTerms_Amount.ColumnName = "Amount";
            this.tbInvoice_PaymentTerms_Amount.DataType = typeof(double);
            // 
            // tbInvoice_PaymentTerms_Amount_currencyID
            // 
            this.tbInvoice_PaymentTerms_Amount_currencyID.ColumnName = "Amount_currencyID";
            // 
            // sqlCommand36
            // 
            this.sqlCommand36.CommandText = "DELETE FROM Invoice_PaymentTerms WHERE nID = @nID";
            // 
            // sqlCommand34
            // 
            this.sqlCommand34.CommandText = resources.GetString("sqlCommand34.CommandText");
            this.sqlCommand34.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, true, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, 0)});
            // 
            // sqlCommand33
            // 
            this.sqlCommand33.CommandText = "SELECT * FROM Invoice_PaymentTerms WHERE 1=1 \r\nAND InvoiceID = @InvoiceID ";
            this.sqlCommand33.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@InvoiceID", System.Data.SqlDbType.Int, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "0")});
            // 
            // sqlCommand35
            // 
            this.sqlCommand35.CommandText = resources.GetString("sqlCommand35.CommandText");
            // 
            // grInvoice_PaymentTermsView
            // 
            this.grInvoice_PaymentTermsView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnID6,
            this.colInvoiceID6,
            this.colNote1,
            this.colPenaltySurchargePercent,
            this.colAmount1,
            this.colAmount_currencyID1});
            this.grInvoice_PaymentTermsView.GridControl = this.grInvoice_PaymentTerms;
            this.grInvoice_PaymentTermsView.Name = "grInvoice_PaymentTermsView";
            this.grInvoice_PaymentTermsView.OptionsView.ColumnAutoWidth = false;
            this.grInvoice_PaymentTermsView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grInvoice_PaymentTermsView.OptionsView.ShowFooter = true;
            this.grInvoice_PaymentTermsView.OptionsView.ShowGroupPanel = false;
            // 
            // colnID6
            // 
            this.colnID6.FieldName = "nID";
            this.colnID6.Name = "colnID6";
            // 
            // colInvoiceID6
            // 
            this.colInvoiceID6.FieldName = "InvoiceID";
            this.colInvoiceID6.Name = "colInvoiceID6";
            // 
            // colNote1
            // 
            this.colNote1.FieldName = "Note";
            this.colNote1.Name = "colNote1";
            this.colNote1.Visible = true;
            this.colNote1.VisibleIndex = 0;
            this.colNote1.Width = 207;
            // 
            // colPenaltySurchargePercent
            // 
            this.colPenaltySurchargePercent.FieldName = "PenaltySurchargePercent";
            this.colPenaltySurchargePercent.Name = "colPenaltySurchargePercent";
            this.colPenaltySurchargePercent.Visible = true;
            this.colPenaltySurchargePercent.VisibleIndex = 1;
            this.colPenaltySurchargePercent.Width = 214;
            // 
            // colAmount1
            // 
            this.colAmount1.FieldName = "Amount";
            this.colAmount1.Name = "colAmount1";
            this.colAmount1.Visible = true;
            this.colAmount1.VisibleIndex = 2;
            // 
            // colAmount_currencyID1
            // 
            this.colAmount_currencyID1.FieldName = "Amount_currencyID";
            this.colAmount_currencyID1.Name = "colAmount_currencyID1";
            this.colAmount_currencyID1.Visible = true;
            this.colAmount_currencyID1.VisibleIndex = 3;
            this.colAmount_currencyID1.Width = 111;
            // 
            // xtraTabPage14
            // 
            this.xtraTabPage14.Controls.Add(this.grInvoice_ReceiptDocumentReference);
            this.xtraTabPage14.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPage14.Name = "xtraTabPage14";
            this.xtraTabPage14.Size = new System.Drawing.Size(1172, 238);
            this.xtraTabPage14.Text = "Alindi bilgileri";
            // 
            // grInvoice_ReceiptDocumentReference
            // 
            this.grInvoice_ReceiptDocumentReference.DataSource = this.tbInvoice_ReceiptDocumentReference;
            this.grInvoice_ReceiptDocumentReference.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grInvoice_ReceiptDocumentReference.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grInvoice_ReceiptDocumentReference.Location = new System.Drawing.Point(0, 0);
            this.grInvoice_ReceiptDocumentReference.MainView = this.grInvoice_ReceiptDocumentReferenceView;
            this.grInvoice_ReceiptDocumentReference.Margin = new System.Windows.Forms.Padding(2);
            this.grInvoice_ReceiptDocumentReference.Name = "grInvoice_ReceiptDocumentReference";
            this.grInvoice_ReceiptDocumentReference.Size = new System.Drawing.Size(1172, 238);
            this.grInvoice_ReceiptDocumentReference.TabIndex = 7;
            this.grInvoice_ReceiptDocumentReference.UseEmbeddedNavigator = true;
            this.grInvoice_ReceiptDocumentReference.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grInvoice_ReceiptDocumentReferenceView});
            // 
            // tbInvoice_ReceiptDocumentReference
            // 
            this.tbInvoice_ReceiptDocumentReference.Columns.AddRange(new System.Data.DataColumn[] {
            this.tbInvoice_ReceiptDocumentReference_nID,
            this.tbInvoice_ReceiptDocumentReference_InvoiceID,
            this.tbInvoice_ReceiptDocumentReference_ID,
            this.tbInvoice_ReceiptDocumentReference_IssueDate});
            this.tbInvoice_ReceiptDocumentReference.Connection = this.FirmConn;
            this.tbInvoice_ReceiptDocumentReference.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "nID"}, true)});
            this.tbInvoice_ReceiptDocumentReference.CurrentRow = null;
            this.tbInvoice_ReceiptDocumentReference.DataSourceLink = null;
            this.tbInvoice_ReceiptDocumentReference.DeleteCommand = this.sqlCommand40;
            this.tbInvoice_ReceiptDocumentReference.Filter = "";
            this.tbInvoice_ReceiptDocumentReference.InsertCommand = this.sqlCommand38;
            this.tbInvoice_ReceiptDocumentReference.LiveSave = false;
            this.tbInvoice_ReceiptDocumentReference.MaxRecords = ((long)(0));
            this.tbInvoice_ReceiptDocumentReference.Name = "tbInvoice_ReceiptDocumentReference";
            this.tbInvoice_ReceiptDocumentReference.ParentRelation_ChildColumns = null;
            this.tbInvoice_ReceiptDocumentReference.ParentRelation_ParentColumns = null;
            this.tbInvoice_ReceiptDocumentReference.ParentRelation_Table = null;
            this.tbInvoice_ReceiptDocumentReference.Position = ((long)(-1));
            this.tbInvoice_ReceiptDocumentReference.PrimaryKey = new System.Data.DataColumn[] {
        this.tbInvoice_ReceiptDocumentReference_nID};
            this.tbInvoice_ReceiptDocumentReference.Quoted = false;
            this.tbInvoice_ReceiptDocumentReference.SelectCommand = this.sqlCommand37;
            this.tbInvoice_ReceiptDocumentReference.TableName = "neoTable1";
            this.tbInvoice_ReceiptDocumentReference.Transaction = null;
            this.tbInvoice_ReceiptDocumentReference.UpdateCommand = this.sqlCommand39;
            // 
            // tbInvoice_ReceiptDocumentReference_nID
            // 
            this.tbInvoice_ReceiptDocumentReference_nID.AllowDBNull = false;
            this.tbInvoice_ReceiptDocumentReference_nID.AutoIncrement = true;
            this.tbInvoice_ReceiptDocumentReference_nID.ColumnName = "nID";
            this.tbInvoice_ReceiptDocumentReference_nID.DataType = typeof(int);
            // 
            // tbInvoice_ReceiptDocumentReference_InvoiceID
            // 
            this.tbInvoice_ReceiptDocumentReference_InvoiceID.ColumnName = "InvoiceID";
            this.tbInvoice_ReceiptDocumentReference_InvoiceID.DataType = typeof(int);
            // 
            // tbInvoice_ReceiptDocumentReference_ID
            // 
            this.tbInvoice_ReceiptDocumentReference_ID.ColumnName = "ID";
            // 
            // tbInvoice_ReceiptDocumentReference_IssueDate
            // 
            this.tbInvoice_ReceiptDocumentReference_IssueDate.ColumnName = "IssueDate";
            this.tbInvoice_ReceiptDocumentReference_IssueDate.DataType = typeof(System.DateTime);
            // 
            // sqlCommand40
            // 
            this.sqlCommand40.CommandText = "DELETE FROM Invoice_ReceiptDocumentReference WHERE nID = @nID";
            // 
            // sqlCommand38
            // 
            this.sqlCommand38.CommandText = "INSERT INTO Invoice_ReceiptDocumentReference (\r\nInvoiceID , ID , IssueDate)\r\n VAL" +
    "UES (\r\n@InvoiceID , @ID , @IssueDate)\r\nSELECT @PRIMARYFIELD_nID = SCOPE_IDENTITY" +
    "() \r\n";
            this.sqlCommand38.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, true, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, 0)});
            // 
            // sqlCommand37
            // 
            this.sqlCommand37.CommandText = "SELECT * FROM Invoice_ReceiptDocumentReference WHERE 1=1 \r\nAND InvoiceID=@Invoice" +
    "ID \r\n";
            this.sqlCommand37.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@InvoiceID", System.Data.SqlDbType.Int, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "0")});
            // 
            // sqlCommand39
            // 
            this.sqlCommand39.CommandText = "UPDATE Invoice_ReceiptDocumentReference SET \r\nInvoiceID = @InvoiceID , ID = @ID ," +
    " IssueDate = @IssueDate\r\nWHERE nID = @nID";
            // 
            // grInvoice_ReceiptDocumentReferenceView
            // 
            this.grInvoice_ReceiptDocumentReferenceView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnID7,
            this.colInvoiceID7,
            this.colID3,
            this.colIssueDate2});
            this.grInvoice_ReceiptDocumentReferenceView.GridControl = this.grInvoice_ReceiptDocumentReference;
            this.grInvoice_ReceiptDocumentReferenceView.Name = "grInvoice_ReceiptDocumentReferenceView";
            this.grInvoice_ReceiptDocumentReferenceView.OptionsView.ColumnAutoWidth = false;
            this.grInvoice_ReceiptDocumentReferenceView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grInvoice_ReceiptDocumentReferenceView.OptionsView.ShowFooter = true;
            this.grInvoice_ReceiptDocumentReferenceView.OptionsView.ShowGroupPanel = false;
            // 
            // colnID7
            // 
            this.colnID7.FieldName = "nID";
            this.colnID7.Name = "colnID7";
            // 
            // colInvoiceID7
            // 
            this.colInvoiceID7.FieldName = "InvoiceID";
            this.colInvoiceID7.Name = "colInvoiceID7";
            // 
            // colID3
            // 
            this.colID3.FieldName = "ID";
            this.colID3.Name = "colID3";
            this.colID3.Visible = true;
            this.colID3.VisibleIndex = 0;
            this.colID3.Width = 145;
            // 
            // colIssueDate2
            // 
            this.colIssueDate2.FieldName = "IssueDate";
            this.colIssueDate2.Name = "colIssueDate2";
            this.colIssueDate2.Visible = true;
            this.colIssueDate2.VisibleIndex = 1;
            this.colIssueDate2.Width = 140;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblBillingReference);
            this.panel6.Controls.Add(this.grBillingReference);
            this.panel6.Controls.Add(this.btnNewGuid);
            this.panel6.Controls.Add(this.labelControl17);
            this.panel6.Controls.Add(this.labelControl16);
            this.panel6.Controls.Add(this.labelControl15);
            this.panel6.Controls.Add(this.labelControl14);
            this.panel6.Controls.Add(this.labelControl13);
            this.panel6.Controls.Add(this.labelControl12);
            this.panel6.Controls.Add(this.comboBoxEdit3);
            this.panel6.Controls.Add(this.InvoicePeriod_EndDateDateEdit);
            this.panel6.Controls.Add(this.InvoicePeriod_StartDateDateEdit);
            this.panel6.Controls.Add(this.labelControl11);
            this.panel6.Controls.Add(this.PricingExchangeRate_CalculationRateSpinEdit);
            this.panel6.Controls.Add(this.LineCountNumericSpinEdit);
            this.panel6.Controls.Add(this.comboBoxEdit2);
            this.panel6.Controls.Add(this.labelControl10);
            this.panel6.Controls.Add(this.IDTextEdit);
            this.panel6.Controls.Add(this.labelControl9);
            this.panel6.Controls.Add(this.labelControl6);
            this.panel6.Controls.Add(this.comboBoxEdit1);
            this.panel6.Controls.Add(this.labelControl5);
            this.panel6.Controls.Add(this.IssueDateDateEdit);
            this.panel6.Controls.Add(this.labelControl1);
            this.panel6.Controls.Add(this.PostBoxTextEdit);
            this.panel6.Controls.Add(this.IntegratorIDTextEdit);
            this.panel6.Controls.Add(this.IssueTimeDateEdit);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1178, 154);
            this.panel6.TabIndex = 126;
            // 
            // lblBillingReference
            // 
            this.lblBillingReference.Location = new System.Drawing.Point(778, 12);
            this.lblBillingReference.Margin = new System.Windows.Forms.Padding(2);
            this.lblBillingReference.Name = "lblBillingReference";
            this.lblBillingReference.Size = new System.Drawing.Size(182, 13);
            this.lblBillingReference.TabIndex = 128;
            this.lblBillingReference.Text = "Iade Edilecek Fatura(lar) ve Tarih(ler)i";
            // 
            // grBillingReference
            // 
            this.grBillingReference.DataSource = this.tbInvoice_BillingReference;
            this.grBillingReference.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grBillingReference.Location = new System.Drawing.Point(778, 29);
            this.grBillingReference.MainView = this.gvBillingReference;
            this.grBillingReference.Margin = new System.Windows.Forms.Padding(2);
            this.grBillingReference.Name = "grBillingReference";
            this.grBillingReference.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.grBillingReference.Size = new System.Drawing.Size(325, 108);
            this.grBillingReference.TabIndex = 127;
            this.grBillingReference.UseEmbeddedNavigator = true;
            this.grBillingReference.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBillingReference});
            // 
            // tbInvoice_BillingReference
            // 
            this.tbInvoice_BillingReference.Columns.AddRange(new System.Data.DataColumn[] {
            this.tbInvoice_BillingReference_nID,
            this.tbInvoice_BillingReference_InvoiceID,
            this.tbInvoice_BillingReference_ID,
            this.tbInvoice_BillingReference_IssueDate,
            this.tbInvoice_BillingReference_DocumentTypeCode,
            this.tbInvoice_BillingReference_DocumentType});
            this.tbInvoice_BillingReference.Connection = this.FirmConn;
            this.tbInvoice_BillingReference.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "nID"}, true)});
            this.tbInvoice_BillingReference.CurrentRow = null;
            this.tbInvoice_BillingReference.DataSourceLink = null;
            this.tbInvoice_BillingReference.DeleteCommand = this.sqlCommand60;
            this.tbInvoice_BillingReference.Filter = "";
            this.tbInvoice_BillingReference.InsertCommand = this.sqlCommand58;
            this.tbInvoice_BillingReference.LiveSave = false;
            this.tbInvoice_BillingReference.MaxRecords = ((long)(0));
            this.tbInvoice_BillingReference.Name = "tbInvoice_BillingReference";
            this.tbInvoice_BillingReference.ParentRelation_ChildColumns = null;
            this.tbInvoice_BillingReference.ParentRelation_ParentColumns = null;
            this.tbInvoice_BillingReference.ParentRelation_Table = null;
            this.tbInvoice_BillingReference.Position = ((long)(-1));
            this.tbInvoice_BillingReference.PrimaryKey = new System.Data.DataColumn[] {
        this.tbInvoice_BillingReference_nID};
            this.tbInvoice_BillingReference.Quoted = false;
            this.tbInvoice_BillingReference.SelectCommand = this.sqlCommand57;
            this.tbInvoice_BillingReference.TableName = "neoTable1";
            this.tbInvoice_BillingReference.Transaction = null;
            this.tbInvoice_BillingReference.UpdateCommand = this.sqlCommand59;
            this.tbInvoice_BillingReference.ColumnChanged += new System.Data.DataColumnChangeEventHandler(this.tbInvoice_BillingReference_ColumnChanged);
            // 
            // tbInvoice_BillingReference_nID
            // 
            this.tbInvoice_BillingReference_nID.AllowDBNull = false;
            this.tbInvoice_BillingReference_nID.AutoIncrement = true;
            this.tbInvoice_BillingReference_nID.ColumnName = "nID";
            this.tbInvoice_BillingReference_nID.DataType = typeof(int);
            // 
            // tbInvoice_BillingReference_InvoiceID
            // 
            this.tbInvoice_BillingReference_InvoiceID.ColumnName = "InvoiceID";
            this.tbInvoice_BillingReference_InvoiceID.DataType = typeof(int);
            // 
            // tbInvoice_BillingReference_ID
            // 
            this.tbInvoice_BillingReference_ID.ColumnName = "ID";
            // 
            // tbInvoice_BillingReference_IssueDate
            // 
            this.tbInvoice_BillingReference_IssueDate.ColumnName = "IssueDate";
            this.tbInvoice_BillingReference_IssueDate.DataType = typeof(System.DateTime);
            // 
            // tbInvoice_BillingReference_DocumentTypeCode
            // 
            this.tbInvoice_BillingReference_DocumentTypeCode.ColumnName = "DocumentTypeCode";
            // 
            // tbInvoice_BillingReference_DocumentType
            // 
            this.tbInvoice_BillingReference_DocumentType.ColumnName = "DocumentType";
            // 
            // sqlCommand60
            // 
            this.sqlCommand60.CommandText = "DELETE FROM Invoice_BillingReference WHERE nID = @nID";
            // 
            // sqlCommand58
            // 
            this.sqlCommand58.CommandText = resources.GetString("sqlCommand58.CommandText");
            this.sqlCommand58.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText)});
            // 
            // sqlCommand57
            // 
            this.sqlCommand57.CommandText = "SELECT * FROM Invoice_BillingReference WHERE 1=1\r\nAND InvoiceID = @InvoiceID ";
            this.sqlCommand57.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@InvoiceID", System.Data.SqlDbType.Int, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "0")});
            // 
            // sqlCommand59
            // 
            this.sqlCommand59.CommandText = "UPDATE Invoice_BillingReference SET \r\nInvoiceID = @InvoiceID , ID = @ID , IssueDa" +
    "te = @IssueDate , DocumentTypeCode = @DocumentTypeCode , DocumentType = @Documen" +
    "tType\r\nWHERE nID = @nID";
            // 
            // gvBillingReference
            // 
            this.gvBillingReference.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn31,
            this.gridColumn33,
            this.gridColumn34});
            this.gvBillingReference.GridControl = this.grBillingReference;
            this.gvBillingReference.Name = "gvBillingReference";
            this.gvBillingReference.OptionsView.ColumnAutoWidth = false;
            this.gvBillingReference.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvBillingReference.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn31
            // 
            this.gridColumn31.FieldName = "nID";
            this.gridColumn31.Name = "gridColumn31";
            // 
            // gridColumn33
            // 
            this.gridColumn33.Caption = "Fatura No";
            this.gridColumn33.FieldName = "ID";
            this.gridColumn33.Name = "gridColumn33";
            this.gridColumn33.Visible = true;
            this.gridColumn33.VisibleIndex = 0;
            this.gridColumn33.Width = 154;
            // 
            // gridColumn34
            // 
            this.gridColumn34.Caption = "Tarihi";
            this.gridColumn34.DisplayFormat.FormatString = "d";
            this.gridColumn34.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn34.FieldName = "IssueDate";
            this.gridColumn34.Name = "gridColumn34";
            this.gridColumn34.Visible = true;
            this.gridColumn34.VisibleIndex = 1;
            this.gridColumn34.Width = 108;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Name3", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name4")});
            this.repositoryItemLookUpEdit1.DisplayMember = "Name";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ShowHeader = false;
            this.repositoryItemLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.repositoryItemLookUpEdit1.ValueMember = "ID";
            // 
            // btnNewGuid
            // 
            this.btnNewGuid.Location = new System.Drawing.Point(268, 40);
            this.btnNewGuid.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewGuid.Name = "btnNewGuid";
            this.btnNewGuid.Size = new System.Drawing.Size(36, 21);
            this.btnNewGuid.TabIndex = 126;
            this.btnNewGuid.Text = "<<<";
            this.btnNewGuid.Click += new System.EventHandler(this.btnNewGuid_Click);
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(479, 92);
            this.labelControl17.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(50, 13);
            this.labelControl17.TabIndex = 125;
            this.labelControl17.Text = "Doviz kuru";
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(176, 89);
            this.labelControl16.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(4, 13);
            this.labelControl16.TabIndex = 30;
            this.labelControl16.Text = "-";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(8, 89);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(71, 13);
            this.labelControl15.TabIndex = 29;
            this.labelControl15.Text = "Fatura periodu";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(308, 67);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(51, 13);
            this.labelControl14.TabIndex = 28;
            this.labelControl14.Text = "Satir sayisi";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(8, 14);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(69, 13);
            this.labelControl13.TabIndex = 27;
            this.labelControl13.Text = "ID (Fatura no)";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(309, 92);
            this.labelControl12.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(49, 13);
            this.labelControl12.TabIndex = 26;
            this.labelControl12.Text = "Para birimi";
            // 
            // comboBoxEdit3
            // 
            this.comboBoxEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "DocumentCurrencyCode", true));
            this.comboBoxEdit3.Location = new System.Drawing.Point(378, 89);
            this.comboBoxEdit3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxEdit3.Name = "comboBoxEdit3";
            this.comboBoxEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit3.Properties.Items.AddRange(new object[] {
            "TRY",
            "USD",
            "EUR",
            "GBP",
            "JPY",
            "DKK"});
            this.comboBoxEdit3.Size = new System.Drawing.Size(75, 20);
            this.comboBoxEdit3.TabIndex = 3;
            // 
            // InvoicePeriod_EndDateDateEdit
            // 
            this.InvoicePeriod_EndDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "InvoicePeriod_EndDate", true));
            this.InvoicePeriod_EndDateDateEdit.EditValue = null;
            this.InvoicePeriod_EndDateDateEdit.Location = new System.Drawing.Point(195, 87);
            this.InvoicePeriod_EndDateDateEdit.Margin = new System.Windows.Forms.Padding(2);
            this.InvoicePeriod_EndDateDateEdit.Name = "InvoicePeriod_EndDateDateEdit";
            this.InvoicePeriod_EndDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.InvoicePeriod_EndDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.InvoicePeriod_EndDateDateEdit.Size = new System.Drawing.Size(86, 20);
            this.InvoicePeriod_EndDateDateEdit.TabIndex = 27;
            // 
            // InvoicePeriod_StartDateDateEdit
            // 
            this.InvoicePeriod_StartDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "InvoicePeriod_StartDate", true));
            this.InvoicePeriod_StartDateDateEdit.EditValue = null;
            this.InvoicePeriod_StartDateDateEdit.Location = new System.Drawing.Point(79, 87);
            this.InvoicePeriod_StartDateDateEdit.Margin = new System.Windows.Forms.Padding(2);
            this.InvoicePeriod_StartDateDateEdit.Name = "InvoicePeriod_StartDateDateEdit";
            this.InvoicePeriod_StartDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.InvoicePeriod_StartDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.InvoicePeriod_StartDateDateEdit.Size = new System.Drawing.Size(86, 20);
            this.InvoicePeriod_StartDateDateEdit.TabIndex = 26;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(574, 14);
            this.labelControl11.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(22, 13);
            this.labelControl11.TabIndex = 24;
            this.labelControl11.Text = "Turu";
            // 
            // PricingExchangeRate_CalculationRateSpinEdit
            // 
            this.PricingExchangeRate_CalculationRateSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "PricingExchangeRate_CalculationRate", true));
            this.PricingExchangeRate_CalculationRateSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PricingExchangeRate_CalculationRateSpinEdit.Location = new System.Drawing.Point(545, 89);
            this.PricingExchangeRate_CalculationRateSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.PricingExchangeRate_CalculationRateSpinEdit.Name = "PricingExchangeRate_CalculationRateSpinEdit";
            this.PricingExchangeRate_CalculationRateSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PricingExchangeRate_CalculationRateSpinEdit.Size = new System.Drawing.Size(83, 20);
            this.PricingExchangeRate_CalculationRateSpinEdit.TabIndex = 124;
            // 
            // LineCountNumericSpinEdit
            // 
            this.LineCountNumericSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "LineCountNumeric", true));
            this.LineCountNumericSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.LineCountNumericSpinEdit.Location = new System.Drawing.Point(378, 64);
            this.LineCountNumericSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.LineCountNumericSpinEdit.Name = "LineCountNumericSpinEdit";
            this.LineCountNumericSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LineCountNumericSpinEdit.Properties.IsFloatValue = false;
            this.LineCountNumericSpinEdit.Properties.Mask.EditMask = "N00";
            this.LineCountNumericSpinEdit.Properties.ReadOnly = true;
            this.LineCountNumericSpinEdit.Size = new System.Drawing.Size(59, 20);
            this.LineCountNumericSpinEdit.TabIndex = 25;
            // 
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "InvoiceTypeCode", true));
            this.comboBoxEdit2.Location = new System.Drawing.Point(611, 11);
            this.comboBoxEdit2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Properties.Items.AddRange(new object[] {
            "SATIS",
            "IADE",
            "TEVKIFAT",
            "ISTISNA",
            "OZELMATRAH",
            "IHRACKAYITLI"});
            this.comboBoxEdit2.Size = new System.Drawing.Size(141, 20);
            this.comboBoxEdit2.TabIndex = 2;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(169, 67);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(24, 13);
            this.labelControl10.TabIndex = 22;
            this.labelControl10.Text = "Saati";
            // 
            // IDTextEdit
            // 
            this.IDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ID", true));
            this.IDTextEdit.Location = new System.Drawing.Point(79, 13);
            this.IDTextEdit.Margin = new System.Windows.Forms.Padding(2);
            this.IDTextEdit.Name = "IDTextEdit";
            this.IDTextEdit.Size = new System.Drawing.Size(144, 20);
            this.IDTextEdit.TabIndex = 0;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(8, 67);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(59, 13);
            this.labelControl9.TabIndex = 21;
            this.labelControl9.Text = "Fatura tarihi";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(309, 14);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(40, 13);
            this.labelControl6.TabIndex = 20;
            this.labelControl6.Text = "Senaryo";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "ProfileID", true));
            this.comboBoxEdit1.Location = new System.Drawing.Point(378, 11);
            this.comboBoxEdit1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "TICARIFATURA",
            "TEMELFATURA",
            "IHRACAT",
            "EARSIVFATURA",
            "YOLCUBERABERFATURA"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(173, 20);
            this.comboBoxEdit1.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(308, 44);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(62, 13);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "Posta kutusu";
            // 
            // IssueDateDateEdit
            // 
            this.IssueDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "IssueDate", true));
            this.IssueDateDateEdit.EditValue = null;
            this.IssueDateDateEdit.Location = new System.Drawing.Point(79, 64);
            this.IssueDateDateEdit.Margin = new System.Windows.Forms.Padding(2);
            this.IssueDateDateEdit.Name = "IssueDateDateEdit";
            this.IssueDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IssueDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IssueDateDateEdit.Size = new System.Drawing.Size(86, 20);
            this.IssueDateDateEdit.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 44);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "UUID";
            // 
            // PostBoxTextEdit
            // 
            this.PostBoxTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "PostBox", true));
            this.PostBoxTextEdit.Location = new System.Drawing.Point(378, 41);
            this.PostBoxTextEdit.Margin = new System.Windows.Forms.Padding(2);
            this.PostBoxTextEdit.Name = "PostBoxTextEdit";
            this.PostBoxTextEdit.Size = new System.Drawing.Size(259, 20);
            this.PostBoxTextEdit.TabIndex = 5;
            // 
            // IntegratorIDTextEdit
            // 
            this.IntegratorIDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "UUID", true));
            this.IntegratorIDTextEdit.Location = new System.Drawing.Point(79, 41);
            this.IntegratorIDTextEdit.Margin = new System.Windows.Forms.Padding(2);
            this.IntegratorIDTextEdit.Name = "IntegratorIDTextEdit";
            this.IntegratorIDTextEdit.Size = new System.Drawing.Size(185, 20);
            this.IntegratorIDTextEdit.TabIndex = 4;
            // 
            // IssueTimeDateEdit
            // 
            this.IssueTimeDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "IssueTime", true));
            this.IssueTimeDateEdit.EditValue = null;
            this.IssueTimeDateEdit.Location = new System.Drawing.Point(195, 64);
            this.IssueTimeDateEdit.Margin = new System.Windows.Forms.Padding(2);
            this.IssueTimeDateEdit.Name = "IssueTimeDateEdit";
            this.IssueTimeDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.IssueTimeDateEdit.Properties.DisplayFormat.FormatString = "d";
            this.IssueTimeDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.IssueTimeDateEdit.Properties.EditFormat.FormatString = "d";
            this.IssueTimeDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.IssueTimeDateEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.IssueTimeDateEdit.Properties.Mask.EditMask = "d";
            this.IssueTimeDateEdit.Size = new System.Drawing.Size(50, 20);
            this.IssueTimeDateEdit.TabIndex = 7;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.splitContainer1);
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1178, 420);
            this.xtraTabPage2.Text = "Fatura Satirlari";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grInvoiceLine);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.xtraTabControl6);
            this.splitContainer1.Size = new System.Drawing.Size(1178, 420);
            this.splitContainer1.SplitterDistance = 513;
            this.splitContainer1.TabIndex = 3;
            // 
            // grInvoiceLine
            // 
            this.grInvoiceLine.ContextMenuStrip = this.contextMenuStrip1;
            this.grInvoiceLine.DataSource = this.tbInvoiceLine;
            this.grInvoiceLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grInvoiceLine.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grInvoiceLine.Location = new System.Drawing.Point(0, 0);
            this.grInvoiceLine.MainView = this.grInvoiceLineView;
            this.grInvoiceLine.Margin = new System.Windows.Forms.Padding(2);
            this.grInvoiceLine.Name = "grInvoiceLine";
            this.grInvoiceLine.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemComboBox1,
            this.cboGridTransportModeCode});
            this.grInvoiceLine.Size = new System.Drawing.Size(513, 420);
            this.grInvoiceLine.TabIndex = 0;
            this.grInvoiceLine.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grInvoiceLineView});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ihracatBilgileriniAltSatırlaraKopyalaToolStripMenuItem,
            this.gTIPNOBoşOlanlarıGeçmişKayıtlardanBulDoldurToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(342, 48);
            // 
            // ihracatBilgileriniAltSatırlaraKopyalaToolStripMenuItem
            // 
            this.ihracatBilgileriniAltSatırlaraKopyalaToolStripMenuItem.Name = "ihracatBilgileriniAltSatırlaraKopyalaToolStripMenuItem";
            this.ihracatBilgileriniAltSatırlaraKopyalaToolStripMenuItem.Size = new System.Drawing.Size(341, 22);
            this.ihracatBilgileriniAltSatırlaraKopyalaToolStripMenuItem.Text = "Bu satirdaki ihracat bilgilerini alt satırlara kopyala";
            this.ihracatBilgileriniAltSatırlaraKopyalaToolStripMenuItem.Click += new System.EventHandler(this.ihracatBilgileriniAltSatırlaraKopyalaToolStripMenuItem_Click);
            // 
            // gTIPNOBoşOlanlarıGeçmişKayıtlardanBulDoldurToolStripMenuItem
            // 
            this.gTIPNOBoşOlanlarıGeçmişKayıtlardanBulDoldurToolStripMenuItem.Name = "gTIPNOBoşOlanlarıGeçmişKayıtlardanBulDoldurToolStripMenuItem";
            this.gTIPNOBoşOlanlarıGeçmişKayıtlardanBulDoldurToolStripMenuItem.Size = new System.Drawing.Size(341, 22);
            this.gTIPNOBoşOlanlarıGeçmişKayıtlardanBulDoldurToolStripMenuItem.Text = "GTIPNO boş olanları geçmiş kayıtlardan bul doldur";
            this.gTIPNOBoşOlanlarıGeçmişKayıtlardanBulDoldurToolStripMenuItem.Click += new System.EventHandler(this.gTIPNOBoşOlanlarıGeçmişKayıtlardanBulDoldurToolStripMenuItem_Click);
            // 
            // tbInvoiceLine
            // 
            this.tbInvoiceLine.Columns.AddRange(new System.Data.DataColumn[] {
            this.tbInvoiceLine_InvoiceLineID,
            this.tbInvoiceLine_InvoiceID,
            this.tbInvoiceLine_ID,
            this.tbInvoiceLine_Note,
            this.tbInvoiceLine_InvoicedQuantity,
            this.tbInvoiceLine_InvoicedQuantity_unitCode,
            this.tbInvoiceLine_LineExtensionAmount,
            this.tbInvoiceLine_currencyID,
            this.tbInvoiceLine_AllowanceCharge_ChargeIndicator,
            this.tbInvoiceLine_AllowanceCharge_AllowanceChargeReason,
            this.tbInvoiceLine_AllowanceCharge_Amount,
            this.tbInvoiceLine_AllowanceCharge_BaseAmount,
            this.tbInvoiceLine_AllowanceCharge_MultiplierFactorNumeric,
            this.tbInvoiceLine_Item_Name,
            this.tbInvoiceLine_Item_Description,
            this.tbInvoiceLine_Item_BrandName,
            this.tbInvoiceLine_Item_ModelName,
            this.tbInvoiceLine_Item_ItemClassificationCode,
            this.tbInvoiceLine_Item_BuyersItemIdentification_ID,
            this.tbInvoiceLine_Item_SellersItemIdentification_ID,
            this.tbInvoiceLine_Item_ManufacturersItemIdentification_ID,
            this.tbInvoiceLine_PriceAmount,
            this.tbInvoiceLine_TaxAmount,
            this.tbInvoiceLine_WithholdingTaxAmount,
            this.tbInvoiceLine_GTIPNO,
            this.tbInvoiceLine_TransportModeCode,
            this.tbInvoiceLine_DeliveryTerms});
            this.tbInvoiceLine.Connection = this.FirmConn;
            this.tbInvoiceLine.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "InvoiceLineID"}, true)});
            this.tbInvoiceLine.CurrentRow = null;
            this.tbInvoiceLine.DataSourceLink = null;
            this.tbInvoiceLine.DeleteCommand = this.sqlCommand8;
            this.tbInvoiceLine.Filter = "";
            this.tbInvoiceLine.InsertCommand = this.sqlCommand6;
            this.tbInvoiceLine.LiveSave = false;
            this.tbInvoiceLine.MaxRecords = ((long)(0));
            this.tbInvoiceLine.Name = "tbInvoiceLine";
            this.tbInvoiceLine.ParentRelation_ChildColumns = null;
            this.tbInvoiceLine.ParentRelation_ParentColumns = null;
            this.tbInvoiceLine.ParentRelation_Table = null;
            this.tbInvoiceLine.Position = ((long)(-1));
            this.tbInvoiceLine.PrimaryKey = new System.Data.DataColumn[] {
        this.tbInvoiceLine_InvoiceLineID};
            this.tbInvoiceLine.Quoted = false;
            this.tbInvoiceLine.SelectCommand = this.sqlCommand5;
            this.tbInvoiceLine.TableName = "neoTable1";
            this.tbInvoiceLine.Transaction = null;
            this.tbInvoiceLine.UpdateCommand = this.sqlCommand7;
            this.tbInvoiceLine.ColumnChanged += new System.Data.DataColumnChangeEventHandler(this.tbInvoiceLine_ColumnChanged);
            // 
            // tbInvoiceLine_InvoiceLineID
            // 
            this.tbInvoiceLine_InvoiceLineID.AllowDBNull = false;
            this.tbInvoiceLine_InvoiceLineID.AutoIncrement = true;
            this.tbInvoiceLine_InvoiceLineID.ColumnName = "InvoiceLineID";
            this.tbInvoiceLine_InvoiceLineID.DataType = typeof(int);
            // 
            // tbInvoiceLine_InvoiceID
            // 
            this.tbInvoiceLine_InvoiceID.ColumnName = "InvoiceID";
            this.tbInvoiceLine_InvoiceID.DataType = typeof(int);
            // 
            // tbInvoiceLine_ID
            // 
            this.tbInvoiceLine_ID.ColumnName = "ID";
            // 
            // tbInvoiceLine_Note
            // 
            this.tbInvoiceLine_Note.ColumnName = "Note";
            // 
            // tbInvoiceLine_InvoicedQuantity
            // 
            this.tbInvoiceLine_InvoicedQuantity.ColumnName = "InvoicedQuantity";
            this.tbInvoiceLine_InvoicedQuantity.DataType = typeof(double);
            // 
            // tbInvoiceLine_InvoicedQuantity_unitCode
            // 
            this.tbInvoiceLine_InvoicedQuantity_unitCode.ColumnName = "InvoicedQuantity_unitCode";
            // 
            // tbInvoiceLine_LineExtensionAmount
            // 
            this.tbInvoiceLine_LineExtensionAmount.ColumnName = "LineExtensionAmount";
            this.tbInvoiceLine_LineExtensionAmount.DataType = typeof(double);
            // 
            // tbInvoiceLine_currencyID
            // 
            this.tbInvoiceLine_currencyID.ColumnName = "currencyID";
            // 
            // tbInvoiceLine_AllowanceCharge_ChargeIndicator
            // 
            this.tbInvoiceLine_AllowanceCharge_ChargeIndicator.ColumnName = "AllowanceCharge_ChargeIndicator";
            this.tbInvoiceLine_AllowanceCharge_ChargeIndicator.DataType = typeof(bool);
            // 
            // tbInvoiceLine_AllowanceCharge_AllowanceChargeReason
            // 
            this.tbInvoiceLine_AllowanceCharge_AllowanceChargeReason.ColumnName = "AllowanceCharge_AllowanceChargeReason";
            // 
            // tbInvoiceLine_AllowanceCharge_Amount
            // 
            this.tbInvoiceLine_AllowanceCharge_Amount.ColumnName = "AllowanceCharge_Amount";
            this.tbInvoiceLine_AllowanceCharge_Amount.DataType = typeof(double);
            // 
            // tbInvoiceLine_AllowanceCharge_BaseAmount
            // 
            this.tbInvoiceLine_AllowanceCharge_BaseAmount.ColumnName = "AllowanceCharge_BaseAmount";
            this.tbInvoiceLine_AllowanceCharge_BaseAmount.DataType = typeof(double);
            // 
            // tbInvoiceLine_AllowanceCharge_MultiplierFactorNumeric
            // 
            this.tbInvoiceLine_AllowanceCharge_MultiplierFactorNumeric.ColumnName = "AllowanceCharge_MultiplierFactorNumeric";
            this.tbInvoiceLine_AllowanceCharge_MultiplierFactorNumeric.DataType = typeof(double);
            // 
            // tbInvoiceLine_Item_Name
            // 
            this.tbInvoiceLine_Item_Name.ColumnName = "Item_Name";
            // 
            // tbInvoiceLine_Item_Description
            // 
            this.tbInvoiceLine_Item_Description.ColumnName = "Item_Description";
            // 
            // tbInvoiceLine_Item_BrandName
            // 
            this.tbInvoiceLine_Item_BrandName.ColumnName = "Item_BrandName";
            // 
            // tbInvoiceLine_Item_ModelName
            // 
            this.tbInvoiceLine_Item_ModelName.ColumnName = "Item_ModelName";
            // 
            // tbInvoiceLine_Item_ItemClassificationCode
            // 
            this.tbInvoiceLine_Item_ItemClassificationCode.ColumnName = "Item_ItemClassificationCode";
            // 
            // tbInvoiceLine_Item_BuyersItemIdentification_ID
            // 
            this.tbInvoiceLine_Item_BuyersItemIdentification_ID.ColumnName = "Item_BuyersItemIdentification_ID";
            // 
            // tbInvoiceLine_Item_SellersItemIdentification_ID
            // 
            this.tbInvoiceLine_Item_SellersItemIdentification_ID.ColumnName = "Item_SellersItemIdentification_ID";
            // 
            // tbInvoiceLine_Item_ManufacturersItemIdentification_ID
            // 
            this.tbInvoiceLine_Item_ManufacturersItemIdentification_ID.ColumnName = "Item_ManufacturersItemIdentification_ID";
            // 
            // tbInvoiceLine_PriceAmount
            // 
            this.tbInvoiceLine_PriceAmount.ColumnName = "PriceAmount";
            this.tbInvoiceLine_PriceAmount.DataType = typeof(double);
            // 
            // tbInvoiceLine_TaxAmount
            // 
            this.tbInvoiceLine_TaxAmount.ColumnName = "TaxAmount";
            this.tbInvoiceLine_TaxAmount.DataType = typeof(double);
            // 
            // tbInvoiceLine_WithholdingTaxAmount
            // 
            this.tbInvoiceLine_WithholdingTaxAmount.ColumnName = "WithholdingTaxAmount";
            this.tbInvoiceLine_WithholdingTaxAmount.DataType = typeof(double);
            // 
            // tbInvoiceLine_GTIPNO
            // 
            this.tbInvoiceLine_GTIPNO.ColumnName = "GTIPNO";
            // 
            // tbInvoiceLine_TransportModeCode
            // 
            this.tbInvoiceLine_TransportModeCode.ColumnName = "TransportModeCode";
            // 
            // tbInvoiceLine_DeliveryTerms
            // 
            this.tbInvoiceLine_DeliveryTerms.ColumnName = "DeliveryTerms";
            // 
            // sqlCommand8
            // 
            this.sqlCommand8.CommandText = "DELETE FROM InvoiceLine WHERE InvoiceLineID = @InvoiceLineID";
            // 
            // sqlCommand6
            // 
            this.sqlCommand6.CommandText = resources.GetString("sqlCommand6.CommandText");
            this.sqlCommand6.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_InvoiceLineID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, true, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, 0)});
            // 
            // sqlCommand5
            // 
            this.sqlCommand5.CommandText = "SELECT * FROM InvoiceLine WHERE 1=1 \r\nAND InvoiceID = @InvoiceID \r\n";
            this.sqlCommand5.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@InvoiceID", System.Data.SqlDbType.Int, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "0")});
            // 
            // sqlCommand7
            // 
            this.sqlCommand7.CommandText = resources.GetString("sqlCommand7.CommandText");
            // 
            // grInvoiceLineView
            // 
            this.grInvoiceLineView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInvoiceLineID,
            this.colInvoiceID,
            this.colID,
            this.colNote,
            this.colInvoicedQuantity,
            this.colInvoicedQuantity_unitCode,
            this.colLineExtensionAmount,
            this.colcurrencyID,
            this.colAllowanceCharge_ChargeIndicator,
            this.colAllowanceCharge_AllowanceChargeReason,
            this.colAllowanceCharge_Amount,
            this.colAllowanceCharge_BaseAmount,
            this.colItem_Name,
            this.colItem_Description,
            this.colItem_BrandName,
            this.colItem_ModelName,
            this.colBuyersItemIdentification_ID,
            this.colSellersItemIdentification_ID,
            this.colManufacturersItemIdentification_ID,
            this.colPriceAmount,
            this.colTaxAmount,
            this.colItem_ItemClassificationCode,
            this.colAllowanceCharge_MultiplierFactorNumeric,
            this.colDeliveryTerms,
            this.colGTIPNO,
            this.colTransportModeCode});
            this.grInvoiceLineView.GridControl = this.grInvoiceLine;
            this.grInvoiceLineView.Name = "grInvoiceLineView";
            this.grInvoiceLineView.OptionsView.ColumnAutoWidth = false;
            this.grInvoiceLineView.OptionsView.ShowFooter = true;
            this.grInvoiceLineView.OptionsView.ShowGroupPanel = false;
            this.grInvoiceLineView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grInvoiceLineView_FocusedRowChanged);
            // 
            // colInvoiceLineID
            // 
            this.colInvoiceLineID.FieldName = "InvoiceLineID";
            this.colInvoiceLineID.Name = "colInvoiceLineID";
            this.colInvoiceLineID.OptionsColumn.AllowEdit = false;
            // 
            // colInvoiceID
            // 
            this.colInvoiceID.FieldName = "InvoiceID";
            this.colInvoiceID.Name = "colInvoiceID";
            this.colInvoiceID.OptionsColumn.AllowEdit = false;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 114;
            // 
            // colNote
            // 
            this.colNote.Caption = "Not";
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 7;
            this.colNote.Width = 118;
            // 
            // colInvoicedQuantity
            // 
            this.colInvoicedQuantity.Caption = "Miktar";
            this.colInvoicedQuantity.FieldName = "InvoicedQuantity";
            this.colInvoicedQuantity.Name = "colInvoicedQuantity";
            this.colInvoicedQuantity.Visible = true;
            this.colInvoicedQuantity.VisibleIndex = 9;
            this.colInvoicedQuantity.Width = 181;
            // 
            // colInvoicedQuantity_unitCode
            // 
            this.colInvoicedQuantity_unitCode.Caption = "Birim";
            this.colInvoicedQuantity_unitCode.FieldName = "InvoicedQuantity_unitCode";
            this.colInvoicedQuantity_unitCode.Name = "colInvoicedQuantity_unitCode";
            this.colInvoicedQuantity_unitCode.Visible = true;
            this.colInvoicedQuantity_unitCode.VisibleIndex = 10;
            this.colInvoicedQuantity_unitCode.Width = 184;
            // 
            // colLineExtensionAmount
            // 
            this.colLineExtensionAmount.Caption = "Tutar";
            this.colLineExtensionAmount.FieldName = "LineExtensionAmount";
            this.colLineExtensionAmount.Name = "colLineExtensionAmount";
            this.colLineExtensionAmount.Visible = true;
            this.colLineExtensionAmount.VisibleIndex = 11;
            this.colLineExtensionAmount.Width = 142;
            // 
            // colcurrencyID
            // 
            this.colcurrencyID.FieldName = "currencyID";
            this.colcurrencyID.Name = "colcurrencyID";
            this.colcurrencyID.Width = 92;
            // 
            // colAllowanceCharge_ChargeIndicator
            // 
            this.colAllowanceCharge_ChargeIndicator.Caption = "Indirim/Masraf?";
            this.colAllowanceCharge_ChargeIndicator.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colAllowanceCharge_ChargeIndicator.FieldName = "AllowanceCharge_ChargeIndicator";
            this.colAllowanceCharge_ChargeIndicator.Name = "colAllowanceCharge_ChargeIndicator";
            this.colAllowanceCharge_ChargeIndicator.Visible = true;
            this.colAllowanceCharge_ChargeIndicator.VisibleIndex = 12;
            this.colAllowanceCharge_ChargeIndicator.Width = 147;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // colAllowanceCharge_AllowanceChargeReason
            // 
            this.colAllowanceCharge_AllowanceChargeReason.Caption = "Ind/Mas sebebi ";
            this.colAllowanceCharge_AllowanceChargeReason.FieldName = "AllowanceCharge_AllowanceChargeReason";
            this.colAllowanceCharge_AllowanceChargeReason.Name = "colAllowanceCharge_AllowanceChargeReason";
            this.colAllowanceCharge_AllowanceChargeReason.Visible = true;
            this.colAllowanceCharge_AllowanceChargeReason.VisibleIndex = 13;
            this.colAllowanceCharge_AllowanceChargeReason.Width = 117;
            // 
            // colAllowanceCharge_Amount
            // 
            this.colAllowanceCharge_Amount.Caption = "Ind/Mas Tutari";
            this.colAllowanceCharge_Amount.FieldName = "AllowanceCharge_Amount";
            this.colAllowanceCharge_Amount.Name = "colAllowanceCharge_Amount";
            this.colAllowanceCharge_Amount.Visible = true;
            this.colAllowanceCharge_Amount.VisibleIndex = 14;
            // 
            // colAllowanceCharge_BaseAmount
            // 
            this.colAllowanceCharge_BaseAmount.Caption = "Ind/Mas Baz tutar";
            this.colAllowanceCharge_BaseAmount.FieldName = "AllowanceCharge_BaseAmount";
            this.colAllowanceCharge_BaseAmount.Name = "colAllowanceCharge_BaseAmount";
            this.colAllowanceCharge_BaseAmount.Visible = true;
            this.colAllowanceCharge_BaseAmount.VisibleIndex = 15;
            // 
            // colItem_Name
            // 
            this.colItem_Name.Caption = "Adı";
            this.colItem_Name.FieldName = "Item_Name";
            this.colItem_Name.Name = "colItem_Name";
            this.colItem_Name.Visible = true;
            this.colItem_Name.VisibleIndex = 1;
            // 
            // colItem_Description
            // 
            this.colItem_Description.Caption = "Açıklama";
            this.colItem_Description.FieldName = "Item_Description";
            this.colItem_Description.Name = "colItem_Description";
            this.colItem_Description.Visible = true;
            this.colItem_Description.VisibleIndex = 2;
            // 
            // colItem_BrandName
            // 
            this.colItem_BrandName.Caption = "Marka";
            this.colItem_BrandName.FieldName = "Item_BrandName";
            this.colItem_BrandName.Name = "colItem_BrandName";
            this.colItem_BrandName.Visible = true;
            this.colItem_BrandName.VisibleIndex = 3;
            // 
            // colItem_ModelName
            // 
            this.colItem_ModelName.Caption = "Model";
            this.colItem_ModelName.FieldName = "Item_ModelName";
            this.colItem_ModelName.Name = "colItem_ModelName";
            this.colItem_ModelName.Visible = true;
            this.colItem_ModelName.VisibleIndex = 4;
            // 
            // colBuyersItemIdentification_ID
            // 
            this.colBuyersItemIdentification_ID.Caption = "Alıcı item kodu";
            this.colBuyersItemIdentification_ID.FieldName = "Item_BuyersItemIdentification_ID";
            this.colBuyersItemIdentification_ID.Name = "colBuyersItemIdentification_ID";
            this.colBuyersItemIdentification_ID.Visible = true;
            this.colBuyersItemIdentification_ID.VisibleIndex = 5;
            this.colBuyersItemIdentification_ID.Width = 128;
            // 
            // colSellersItemIdentification_ID
            // 
            this.colSellersItemIdentification_ID.Caption = "Tedarikci item kodu";
            this.colSellersItemIdentification_ID.FieldName = "Item_SellersItemIdentification_ID";
            this.colSellersItemIdentification_ID.Name = "colSellersItemIdentification_ID";
            this.colSellersItemIdentification_ID.Visible = true;
            this.colSellersItemIdentification_ID.VisibleIndex = 6;
            this.colSellersItemIdentification_ID.Width = 153;
            // 
            // colManufacturersItemIdentification_ID
            // 
            this.colManufacturersItemIdentification_ID.Caption = "Üretici item kodu";
            this.colManufacturersItemIdentification_ID.FieldName = "Item_ManufacturersItemIdentification_ID";
            this.colManufacturersItemIdentification_ID.Name = "colManufacturersItemIdentification_ID";
            this.colManufacturersItemIdentification_ID.Visible = true;
            this.colManufacturersItemIdentification_ID.VisibleIndex = 16;
            // 
            // colPriceAmount
            // 
            this.colPriceAmount.Caption = "Fiyat";
            this.colPriceAmount.FieldName = "PriceAmount";
            this.colPriceAmount.Name = "colPriceAmount";
            this.colPriceAmount.Visible = true;
            this.colPriceAmount.VisibleIndex = 8;
            this.colPriceAmount.Width = 152;
            // 
            // colTaxAmount
            // 
            this.colTaxAmount.Caption = "Vergi tutar";
            this.colTaxAmount.FieldName = "TaxAmount";
            this.colTaxAmount.Name = "colTaxAmount";
            this.colTaxAmount.OptionsColumn.AllowEdit = false;
            this.colTaxAmount.Visible = true;
            this.colTaxAmount.VisibleIndex = 17;
            // 
            // colItem_ItemClassificationCode
            // 
            this.colItem_ItemClassificationCode.FieldName = "Item_ItemClassificationCode";
            this.colItem_ItemClassificationCode.Name = "colItem_ItemClassificationCode";
            this.colItem_ItemClassificationCode.Visible = true;
            this.colItem_ItemClassificationCode.VisibleIndex = 18;
            // 
            // colAllowanceCharge_MultiplierFactorNumeric
            // 
            this.colAllowanceCharge_MultiplierFactorNumeric.FieldName = "AllowanceCharge_MultiplierFactorNumeric";
            this.colAllowanceCharge_MultiplierFactorNumeric.Name = "colAllowanceCharge_MultiplierFactorNumeric";
            this.colAllowanceCharge_MultiplierFactorNumeric.Visible = true;
            this.colAllowanceCharge_MultiplierFactorNumeric.VisibleIndex = 19;
            // 
            // colDeliveryTerms
            // 
            this.colDeliveryTerms.ColumnEdit = this.repositoryItemComboBox1;
            this.colDeliveryTerms.FieldName = "DeliveryTerms";
            this.colDeliveryTerms.Name = "colDeliveryTerms";
            this.colDeliveryTerms.Visible = true;
            this.colDeliveryTerms.VisibleIndex = 20;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "",
            "FOB",
            "CIF",
            "DAF",
            "EXW",
            "FCA",
            "FAS",
            "CFR",
            "CPT",
            "CIP",
            "DES",
            "DEQ",
            "DDU",
            "DDP"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // colGTIPNO
            // 
            this.colGTIPNO.FieldName = "GTIPNO";
            this.colGTIPNO.Name = "colGTIPNO";
            this.colGTIPNO.Visible = true;
            this.colGTIPNO.VisibleIndex = 21;
            // 
            // colTransportModeCode
            // 
            this.colTransportModeCode.ColumnEdit = this.cboGridTransportModeCode;
            this.colTransportModeCode.FieldName = "TransportModeCode";
            this.colTransportModeCode.Name = "colTransportModeCode";
            this.colTransportModeCode.Visible = true;
            this.colTransportModeCode.VisibleIndex = 22;
            // 
            // cboGridTransportModeCode
            // 
            this.cboGridTransportModeCode.AutoHeight = false;
            this.cboGridTransportModeCode.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.cboGridTransportModeCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboGridTransportModeCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name1"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Name2", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.cboGridTransportModeCode.DisplayMember = "Name";
            this.cboGridTransportModeCode.Name = "cboGridTransportModeCode";
            this.cboGridTransportModeCode.NullText = "";
            this.cboGridTransportModeCode.ShowHeader = false;
            this.cboGridTransportModeCode.ValueMember = "ID";
            // 
            // xtraTabControl6
            // 
            this.xtraTabControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl6.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl6.Name = "xtraTabControl6";
            this.xtraTabControl6.SelectedTabPage = this.xtraTabPage19;
            this.xtraTabControl6.Size = new System.Drawing.Size(661, 420);
            this.xtraTabControl6.TabIndex = 4;
            this.xtraTabControl6.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage19,
            this.xtraTabPage20});
            // 
            // xtraTabPage19
            // 
            this.xtraTabPage19.Controls.Add(this.xtraTabControl5);
            this.xtraTabPage19.Controls.Add(this.panel5);
            this.xtraTabPage19.Name = "xtraTabPage19";
            this.xtraTabPage19.Size = new System.Drawing.Size(655, 392);
            this.xtraTabPage19.Text = "Vergiler";
            // 
            // xtraTabControl5
            // 
            this.xtraTabControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl5.Location = new System.Drawing.Point(0, 44);
            this.xtraTabControl5.Name = "xtraTabControl5";
            this.xtraTabControl5.SelectedTabPage = this.xtraTabPage17;
            this.xtraTabControl5.Size = new System.Drawing.Size(655, 348);
            this.xtraTabControl5.TabIndex = 3;
            this.xtraTabControl5.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage17,
            this.xtraTabPage18});
            // 
            // xtraTabPage17
            // 
            this.xtraTabPage17.Controls.Add(this.grInvoiceLine_TaxSubTotal);
            this.xtraTabPage17.Name = "xtraTabPage17";
            this.xtraTabPage17.Size = new System.Drawing.Size(649, 320);
            this.xtraTabPage17.Text = "Vergiler";
            // 
            // grInvoiceLine_TaxSubTotal
            // 
            this.grInvoiceLine_TaxSubTotal.DataSource = this.tbInvoiceLine_TaxSubTotal;
            this.grInvoiceLine_TaxSubTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grInvoiceLine_TaxSubTotal.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grInvoiceLine_TaxSubTotal.Location = new System.Drawing.Point(0, 0);
            this.grInvoiceLine_TaxSubTotal.MainView = this.grInvoiceLine_TaxSubTotalView;
            this.grInvoiceLine_TaxSubTotal.Margin = new System.Windows.Forms.Padding(2);
            this.grInvoiceLine_TaxSubTotal.Name = "grInvoiceLine_TaxSubTotal";
            this.grInvoiceLine_TaxSubTotal.Size = new System.Drawing.Size(649, 320);
            this.grInvoiceLine_TaxSubTotal.TabIndex = 1;
            this.grInvoiceLine_TaxSubTotal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grInvoiceLine_TaxSubTotalView});
            // 
            // tbInvoiceLine_TaxSubTotal
            // 
            this.tbInvoiceLine_TaxSubTotal.Columns.AddRange(new System.Data.DataColumn[] {
            this.tbInvoiceLine_TaxSubTotal_nID,
            this.tbInvoiceLine_TaxSubTotal_InvoiceLineID,
            this.tbInvoiceLine_TaxSubTotal_TaxableAmount,
            this.tbInvoiceLine_TaxSubTotal_currencyID,
            this.tbInvoiceLine_TaxSubTotal_TaxAmount,
            this.tbInvoiceLine_TaxSubTotal_PerUnitAmount,
            this.tbInvoiceLine_TaxSubTotal_CalculationSequenceNumeric,
            this.tbInvoiceLine_TaxSubTotal_Percent_,
            this.tbInvoiceLine_TaxSubTotal_TaxCategory_TaxScheme_Name,
            this.tbInvoiceLine_TaxSubTotal_TaxCategory_TaxScheme_TaxTypeCode,
            this.tbInvoiceLine_TaxSubTotal_TaxCategory_TaxExemptionReason,
            this.tbInvoiceLine_TaxSubTotal_TaxCategory_TaxExemptionReasonCode});
            this.tbInvoiceLine_TaxSubTotal.Connection = this.FirmConn;
            this.tbInvoiceLine_TaxSubTotal.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "nID"}, true)});
            this.tbInvoiceLine_TaxSubTotal.CurrentRow = null;
            this.tbInvoiceLine_TaxSubTotal.DataSourceLink = null;
            this.tbInvoiceLine_TaxSubTotal.DeleteCommand = this.sqlCommand12;
            this.tbInvoiceLine_TaxSubTotal.Filter = "";
            this.tbInvoiceLine_TaxSubTotal.InsertCommand = this.sqlCommand10;
            this.tbInvoiceLine_TaxSubTotal.LiveSave = false;
            this.tbInvoiceLine_TaxSubTotal.MaxRecords = ((long)(0));
            this.tbInvoiceLine_TaxSubTotal.Name = "tbInvoiceLine_TaxSubTotal";
            this.tbInvoiceLine_TaxSubTotal.ParentRelation_ChildColumns = null;
            this.tbInvoiceLine_TaxSubTotal.ParentRelation_ParentColumns = null;
            this.tbInvoiceLine_TaxSubTotal.ParentRelation_Table = null;
            this.tbInvoiceLine_TaxSubTotal.Position = ((long)(-1));
            this.tbInvoiceLine_TaxSubTotal.PrimaryKey = new System.Data.DataColumn[] {
        this.tbInvoiceLine_TaxSubTotal_nID};
            this.tbInvoiceLine_TaxSubTotal.Quoted = false;
            this.tbInvoiceLine_TaxSubTotal.SelectCommand = this.sqlCommand9;
            this.tbInvoiceLine_TaxSubTotal.TableName = "neoTable1";
            this.tbInvoiceLine_TaxSubTotal.Transaction = null;
            this.tbInvoiceLine_TaxSubTotal.UpdateCommand = this.sqlCommand11;
            this.tbInvoiceLine_TaxSubTotal.ColumnChanged += new System.Data.DataColumnChangeEventHandler(this.tbInvoiceLine_TaxSubTotal_ColumnChanged);
            // 
            // tbInvoiceLine_TaxSubTotal_nID
            // 
            this.tbInvoiceLine_TaxSubTotal_nID.AllowDBNull = false;
            this.tbInvoiceLine_TaxSubTotal_nID.AutoIncrement = true;
            this.tbInvoiceLine_TaxSubTotal_nID.ColumnName = "nID";
            this.tbInvoiceLine_TaxSubTotal_nID.DataType = typeof(int);
            // 
            // tbInvoiceLine_TaxSubTotal_InvoiceLineID
            // 
            this.tbInvoiceLine_TaxSubTotal_InvoiceLineID.ColumnName = "InvoiceLineID";
            this.tbInvoiceLine_TaxSubTotal_InvoiceLineID.DataType = typeof(int);
            // 
            // tbInvoiceLine_TaxSubTotal_TaxableAmount
            // 
            this.tbInvoiceLine_TaxSubTotal_TaxableAmount.ColumnName = "TaxableAmount";
            this.tbInvoiceLine_TaxSubTotal_TaxableAmount.DataType = typeof(double);
            // 
            // tbInvoiceLine_TaxSubTotal_currencyID
            // 
            this.tbInvoiceLine_TaxSubTotal_currencyID.ColumnName = "currencyID";
            // 
            // tbInvoiceLine_TaxSubTotal_TaxAmount
            // 
            this.tbInvoiceLine_TaxSubTotal_TaxAmount.ColumnName = "TaxAmount";
            this.tbInvoiceLine_TaxSubTotal_TaxAmount.DataType = typeof(double);
            // 
            // tbInvoiceLine_TaxSubTotal_PerUnitAmount
            // 
            this.tbInvoiceLine_TaxSubTotal_PerUnitAmount.ColumnName = "PerUnitAmount";
            this.tbInvoiceLine_TaxSubTotal_PerUnitAmount.DataType = typeof(double);
            // 
            // tbInvoiceLine_TaxSubTotal_CalculationSequenceNumeric
            // 
            this.tbInvoiceLine_TaxSubTotal_CalculationSequenceNumeric.ColumnName = "CalculationSequenceNumeric";
            this.tbInvoiceLine_TaxSubTotal_CalculationSequenceNumeric.DataType = typeof(int);
            // 
            // tbInvoiceLine_TaxSubTotal_Percent_
            // 
            this.tbInvoiceLine_TaxSubTotal_Percent_.ColumnName = "Percent_";
            this.tbInvoiceLine_TaxSubTotal_Percent_.DataType = typeof(double);
            // 
            // tbInvoiceLine_TaxSubTotal_TaxCategory_TaxScheme_Name
            // 
            this.tbInvoiceLine_TaxSubTotal_TaxCategory_TaxScheme_Name.ColumnName = "TaxCategory_TaxScheme_Name";
            // 
            // tbInvoiceLine_TaxSubTotal_TaxCategory_TaxScheme_TaxTypeCode
            // 
            this.tbInvoiceLine_TaxSubTotal_TaxCategory_TaxScheme_TaxTypeCode.ColumnName = "TaxCategory_TaxScheme_TaxTypeCode";
            // 
            // tbInvoiceLine_TaxSubTotal_TaxCategory_TaxExemptionReason
            // 
            this.tbInvoiceLine_TaxSubTotal_TaxCategory_TaxExemptionReason.ColumnName = "TaxCategory_TaxExemptionReason";
            // 
            // tbInvoiceLine_TaxSubTotal_TaxCategory_TaxExemptionReasonCode
            // 
            this.tbInvoiceLine_TaxSubTotal_TaxCategory_TaxExemptionReasonCode.ColumnName = "TaxCategory_TaxExemptionReasonCode";
            // 
            // sqlCommand12
            // 
            this.sqlCommand12.CommandText = "DELETE FROM InvoiceLine_TaxSubtotal WHERE nID = @nID";
            // 
            // sqlCommand10
            // 
            this.sqlCommand10.CommandText = resources.GetString("sqlCommand10.CommandText");
            // 
            // sqlCommand9
            // 
            this.sqlCommand9.CommandText = "SELECT * FROM InvoiceLine_TaxSubtotal WHERE 1=1\r\nAND InvoiceLineID =  @InvoiceLin" +
    "eID\r\n";
            this.sqlCommand9.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@InvoiceLineID", System.Data.SqlDbType.Int, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "0")});
            // 
            // sqlCommand11
            // 
            this.sqlCommand11.CommandText = resources.GetString("sqlCommand11.CommandText");
            // 
            // grInvoiceLine_TaxSubTotalView
            // 
            this.grInvoiceLine_TaxSubTotalView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnID,
            this.colInvoiceLineID1,
            this.colTaxableAmount,
            this.colCalculationSequenceNumeric,
            this.colcurrencyID1,
            this.colTaxAmount1,
            this.colPercent_,
            this.colTaxCategory_TaxScheme_TaxTypeCode,
            this.colTaxCategory_TaxScheme_Name,
            this.colTaxCategory_TaxExemptionReason1,
            this.colTaxCategory_TaxExemptionReasonCode1});
            this.grInvoiceLine_TaxSubTotalView.GridControl = this.grInvoiceLine_TaxSubTotal;
            this.grInvoiceLine_TaxSubTotalView.Name = "grInvoiceLine_TaxSubTotalView";
            this.grInvoiceLine_TaxSubTotalView.OptionsView.ColumnAutoWidth = false;
            this.grInvoiceLine_TaxSubTotalView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grInvoiceLine_TaxSubTotalView.OptionsView.ShowFooter = true;
            this.grInvoiceLine_TaxSubTotalView.OptionsView.ShowGroupPanel = false;
            // 
            // colnID
            // 
            this.colnID.FieldName = "nID";
            this.colnID.Name = "colnID";
            this.colnID.OptionsColumn.AllowEdit = false;
            // 
            // colInvoiceLineID1
            // 
            this.colInvoiceLineID1.FieldName = "InvoiceLineID";
            this.colInvoiceLineID1.Name = "colInvoiceLineID1";
            this.colInvoiceLineID1.OptionsColumn.AllowEdit = false;
            // 
            // colTaxableAmount
            // 
            this.colTaxableAmount.Caption = "Matrah";
            this.colTaxableAmount.FieldName = "TaxableAmount";
            this.colTaxableAmount.Name = "colTaxableAmount";
            this.colTaxableAmount.Visible = true;
            this.colTaxableAmount.VisibleIndex = 0;
            this.colTaxableAmount.Width = 110;
            // 
            // colCalculationSequenceNumeric
            // 
            this.colCalculationSequenceNumeric.Caption = "Hesap Sira";
            this.colCalculationSequenceNumeric.FieldName = "CalculationSequenceNumeric";
            this.colCalculationSequenceNumeric.Name = "colCalculationSequenceNumeric";
            this.colCalculationSequenceNumeric.Visible = true;
            this.colCalculationSequenceNumeric.VisibleIndex = 2;
            this.colCalculationSequenceNumeric.Width = 70;
            // 
            // colcurrencyID1
            // 
            this.colcurrencyID1.FieldName = "currencyID";
            this.colcurrencyID1.Name = "colcurrencyID1";
            this.colcurrencyID1.OptionsColumn.AllowEdit = false;
            // 
            // colTaxAmount1
            // 
            this.colTaxAmount1.Caption = "Vergi";
            this.colTaxAmount1.FieldName = "TaxAmount";
            this.colTaxAmount1.Name = "colTaxAmount1";
            this.colTaxAmount1.Visible = true;
            this.colTaxAmount1.VisibleIndex = 1;
            this.colTaxAmount1.Width = 106;
            // 
            // colPercent_
            // 
            this.colPercent_.Caption = "Vergi yuzde";
            this.colPercent_.FieldName = "Percent_";
            this.colPercent_.Name = "colPercent_";
            this.colPercent_.Visible = true;
            this.colPercent_.VisibleIndex = 3;
            // 
            // colTaxCategory_TaxScheme_TaxTypeCode
            // 
            this.colTaxCategory_TaxScheme_TaxTypeCode.Caption = "Vergi kod";
            this.colTaxCategory_TaxScheme_TaxTypeCode.FieldName = "TaxCategory_TaxScheme_TaxTypeCode";
            this.colTaxCategory_TaxScheme_TaxTypeCode.Name = "colTaxCategory_TaxScheme_TaxTypeCode";
            this.colTaxCategory_TaxScheme_TaxTypeCode.Visible = true;
            this.colTaxCategory_TaxScheme_TaxTypeCode.VisibleIndex = 5;
            // 
            // colTaxCategory_TaxScheme_Name
            // 
            this.colTaxCategory_TaxScheme_Name.Caption = "Vergi aciklama";
            this.colTaxCategory_TaxScheme_Name.FieldName = "TaxCategory_TaxScheme_Name";
            this.colTaxCategory_TaxScheme_Name.Name = "colTaxCategory_TaxScheme_Name";
            this.colTaxCategory_TaxScheme_Name.Visible = true;
            this.colTaxCategory_TaxScheme_Name.VisibleIndex = 4;
            this.colTaxCategory_TaxScheme_Name.Width = 130;
            // 
            // colTaxCategory_TaxExemptionReason1
            // 
            this.colTaxCategory_TaxExemptionReason1.Caption = "Kdv muhafiyet sebebi";
            this.colTaxCategory_TaxExemptionReason1.FieldName = "TaxCategory_TaxExemptionReason";
            this.colTaxCategory_TaxExemptionReason1.Name = "colTaxCategory_TaxExemptionReason1";
            this.colTaxCategory_TaxExemptionReason1.Visible = true;
            this.colTaxCategory_TaxExemptionReason1.VisibleIndex = 6;
            this.colTaxCategory_TaxExemptionReason1.Width = 174;
            // 
            // colTaxCategory_TaxExemptionReasonCode1
            // 
            this.colTaxCategory_TaxExemptionReasonCode1.Caption = "Kdv muhafiyet sebep kodu";
            this.colTaxCategory_TaxExemptionReasonCode1.FieldName = "TaxCategory_TaxExemptionReasonCode";
            this.colTaxCategory_TaxExemptionReasonCode1.Name = "colTaxCategory_TaxExemptionReasonCode1";
            this.colTaxCategory_TaxExemptionReasonCode1.Visible = true;
            this.colTaxCategory_TaxExemptionReasonCode1.VisibleIndex = 7;
            this.colTaxCategory_TaxExemptionReasonCode1.Width = 159;
            // 
            // xtraTabPage18
            // 
            this.xtraTabPage18.Controls.Add(this.grInvoiceLine_WithholdingTaxSubTotal);
            this.xtraTabPage18.Name = "xtraTabPage18";
            this.xtraTabPage18.Size = new System.Drawing.Size(649, 320);
            this.xtraTabPage18.Text = "Tevkifat";
            // 
            // grInvoiceLine_WithholdingTaxSubTotal
            // 
            this.grInvoiceLine_WithholdingTaxSubTotal.DataSource = this.tbInvoiceLine_WithholdingTaxSubTotal;
            this.grInvoiceLine_WithholdingTaxSubTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grInvoiceLine_WithholdingTaxSubTotal.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grInvoiceLine_WithholdingTaxSubTotal.Location = new System.Drawing.Point(0, 0);
            this.grInvoiceLine_WithholdingTaxSubTotal.MainView = this.grInvoiceLine_WithholdingTaxSubTotalView;
            this.grInvoiceLine_WithholdingTaxSubTotal.Margin = new System.Windows.Forms.Padding(2);
            this.grInvoiceLine_WithholdingTaxSubTotal.Name = "grInvoiceLine_WithholdingTaxSubTotal";
            this.grInvoiceLine_WithholdingTaxSubTotal.Size = new System.Drawing.Size(649, 320);
            this.grInvoiceLine_WithholdingTaxSubTotal.TabIndex = 2;
            this.grInvoiceLine_WithholdingTaxSubTotal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grInvoiceLine_WithholdingTaxSubTotalView});
            // 
            // tbInvoiceLine_WithholdingTaxSubTotal
            // 
            this.tbInvoiceLine_WithholdingTaxSubTotal.Columns.AddRange(new System.Data.DataColumn[] {
            this.tbInvoiceLine_WithholdingTaxSubTotal_nID,
            this.tbInvoiceLine_WithholdingTaxSubTotal_InvoiceLineID,
            this.tbInvoiceLine_WithholdingTaxSubTotal_TaxableAmount,
            this.tbInvoiceLine_WithholdingTaxSubTotal_currencyID,
            this.tbInvoiceLine_WithholdingTaxSubTotal_TaxAmount,
            this.tbInvoiceLine_WithholdingTaxSubTotal_PerUnitAmount,
            this.tbInvoiceLine_WithholdingTaxSubTotal_CalculationSequenceNumeric,
            this.tbInvoiceLine_WithholdingTaxSubTotal_Percent_,
            this.tbInvoiceLine_WithholdingTaxSubTotal_TaxCategory_TaxScheme_Name,
            this.tbInvoiceLine_WithholdingTaxSubTotal_TaxCategory_TaxScheme_TaxTypeCode,
            this.tbInvoiceLine_WithholdingTaxSubTotal_TaxCategory_TaxExemptionReason,
            this.tbInvoiceLine_WithholdingTaxSubTotal_TaxCategory_TaxExemptionReasonCode});
            this.tbInvoiceLine_WithholdingTaxSubTotal.Connection = this.FirmConn;
            this.tbInvoiceLine_WithholdingTaxSubTotal.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "nID"}, true)});
            this.tbInvoiceLine_WithholdingTaxSubTotal.CurrentRow = null;
            this.tbInvoiceLine_WithholdingTaxSubTotal.DataSourceLink = null;
            this.tbInvoiceLine_WithholdingTaxSubTotal.DeleteCommand = this.sqlCommand52;
            this.tbInvoiceLine_WithholdingTaxSubTotal.Filter = "";
            this.tbInvoiceLine_WithholdingTaxSubTotal.InsertCommand = this.sqlCommand50;
            this.tbInvoiceLine_WithholdingTaxSubTotal.LiveSave = false;
            this.tbInvoiceLine_WithholdingTaxSubTotal.MaxRecords = ((long)(0));
            this.tbInvoiceLine_WithholdingTaxSubTotal.Name = "tbInvoiceLine_WithholdingTaxSubTotal";
            this.tbInvoiceLine_WithholdingTaxSubTotal.ParentRelation_ChildColumns = null;
            this.tbInvoiceLine_WithholdingTaxSubTotal.ParentRelation_ParentColumns = null;
            this.tbInvoiceLine_WithholdingTaxSubTotal.ParentRelation_Table = null;
            this.tbInvoiceLine_WithholdingTaxSubTotal.Position = ((long)(-1));
            this.tbInvoiceLine_WithholdingTaxSubTotal.PrimaryKey = new System.Data.DataColumn[] {
        this.tbInvoiceLine_WithholdingTaxSubTotal_nID};
            this.tbInvoiceLine_WithholdingTaxSubTotal.Quoted = false;
            this.tbInvoiceLine_WithholdingTaxSubTotal.SelectCommand = this.sqlCommand49;
            this.tbInvoiceLine_WithholdingTaxSubTotal.TableName = "neoTable1";
            this.tbInvoiceLine_WithholdingTaxSubTotal.Transaction = null;
            this.tbInvoiceLine_WithholdingTaxSubTotal.UpdateCommand = this.sqlCommand51;
            this.tbInvoiceLine_WithholdingTaxSubTotal.ColumnChanged += new System.Data.DataColumnChangeEventHandler(this.tbInvoiceLine_WithholdingTaxSubTotal_ColumnChanged);
            // 
            // tbInvoiceLine_WithholdingTaxSubTotal_nID
            // 
            this.tbInvoiceLine_WithholdingTaxSubTotal_nID.AllowDBNull = false;
            this.tbInvoiceLine_WithholdingTaxSubTotal_nID.AutoIncrement = true;
            this.tbInvoiceLine_WithholdingTaxSubTotal_nID.ColumnName = "nID";
            this.tbInvoiceLine_WithholdingTaxSubTotal_nID.DataType = typeof(int);
            // 
            // tbInvoiceLine_WithholdingTaxSubTotal_InvoiceLineID
            // 
            this.tbInvoiceLine_WithholdingTaxSubTotal_InvoiceLineID.ColumnName = "InvoiceLineID";
            this.tbInvoiceLine_WithholdingTaxSubTotal_InvoiceLineID.DataType = typeof(int);
            // 
            // tbInvoiceLine_WithholdingTaxSubTotal_TaxableAmount
            // 
            this.tbInvoiceLine_WithholdingTaxSubTotal_TaxableAmount.ColumnName = "TaxableAmount";
            this.tbInvoiceLine_WithholdingTaxSubTotal_TaxableAmount.DataType = typeof(double);
            // 
            // tbInvoiceLine_WithholdingTaxSubTotal_currencyID
            // 
            this.tbInvoiceLine_WithholdingTaxSubTotal_currencyID.ColumnName = "currencyID";
            // 
            // tbInvoiceLine_WithholdingTaxSubTotal_TaxAmount
            // 
            this.tbInvoiceLine_WithholdingTaxSubTotal_TaxAmount.ColumnName = "TaxAmount";
            this.tbInvoiceLine_WithholdingTaxSubTotal_TaxAmount.DataType = typeof(double);
            // 
            // tbInvoiceLine_WithholdingTaxSubTotal_PerUnitAmount
            // 
            this.tbInvoiceLine_WithholdingTaxSubTotal_PerUnitAmount.ColumnName = "PerUnitAmount";
            this.tbInvoiceLine_WithholdingTaxSubTotal_PerUnitAmount.DataType = typeof(double);
            // 
            // tbInvoiceLine_WithholdingTaxSubTotal_CalculationSequenceNumeric
            // 
            this.tbInvoiceLine_WithholdingTaxSubTotal_CalculationSequenceNumeric.ColumnName = "CalculationSequenceNumeric";
            this.tbInvoiceLine_WithholdingTaxSubTotal_CalculationSequenceNumeric.DataType = typeof(int);
            // 
            // tbInvoiceLine_WithholdingTaxSubTotal_Percent_
            // 
            this.tbInvoiceLine_WithholdingTaxSubTotal_Percent_.ColumnName = "Percent_";
            this.tbInvoiceLine_WithholdingTaxSubTotal_Percent_.DataType = typeof(double);
            // 
            // tbInvoiceLine_WithholdingTaxSubTotal_TaxCategory_TaxScheme_Name
            // 
            this.tbInvoiceLine_WithholdingTaxSubTotal_TaxCategory_TaxScheme_Name.ColumnName = "TaxCategory_TaxScheme_Name";
            // 
            // tbInvoiceLine_WithholdingTaxSubTotal_TaxCategory_TaxScheme_TaxTypeCode
            // 
            this.tbInvoiceLine_WithholdingTaxSubTotal_TaxCategory_TaxScheme_TaxTypeCode.ColumnName = "TaxCategory_TaxScheme_TaxTypeCode";
            // 
            // tbInvoiceLine_WithholdingTaxSubTotal_TaxCategory_TaxExemptionReason
            // 
            this.tbInvoiceLine_WithholdingTaxSubTotal_TaxCategory_TaxExemptionReason.ColumnName = "TaxCategory_TaxExemptionReason";
            // 
            // tbInvoiceLine_WithholdingTaxSubTotal_TaxCategory_TaxExemptionReasonCode
            // 
            this.tbInvoiceLine_WithholdingTaxSubTotal_TaxCategory_TaxExemptionReasonCode.ColumnName = "TaxCategory_TaxExemptionReasonCode";
            // 
            // sqlCommand52
            // 
            this.sqlCommand52.CommandText = "DELETE FROM InvoiceLine_WithholdingTaxSubtotal WHERE nID = @nID";
            // 
            // sqlCommand50
            // 
            this.sqlCommand50.CommandText = resources.GetString("sqlCommand50.CommandText");
            this.sqlCommand50.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@PRIMARYFIELD_nID", System.Data.SqlDbType.NText, 4, System.Data.ParameterDirection.InputOutput, true, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, 0)});
            // 
            // sqlCommand49
            // 
            this.sqlCommand49.CommandText = "SELECT * FROM InvoiceLine_WithholdingTaxSubtotal WHERE 1=1\r\n AND InvoiceLineID = " +
    " @InvoiceLineID\r\n";
            this.sqlCommand49.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@InvoiceLineID", System.Data.SqlDbType.Int, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "0")});
            // 
            // sqlCommand51
            // 
            this.sqlCommand51.CommandText = resources.GetString("sqlCommand51.CommandText");
            // 
            // grInvoiceLine_WithholdingTaxSubTotalView
            // 
            this.grInvoiceLine_WithholdingTaxSubTotalView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18,
            this.colTaxCategory_TaxExemptionReason2,
            this.colTaxCategory_TaxExemptionReasonCode2});
            this.grInvoiceLine_WithholdingTaxSubTotalView.GridControl = this.grInvoiceLine_WithholdingTaxSubTotal;
            this.grInvoiceLine_WithholdingTaxSubTotalView.Name = "grInvoiceLine_WithholdingTaxSubTotalView";
            this.grInvoiceLine_WithholdingTaxSubTotalView.OptionsView.ColumnAutoWidth = false;
            this.grInvoiceLine_WithholdingTaxSubTotalView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grInvoiceLine_WithholdingTaxSubTotalView.OptionsView.ShowFooter = true;
            this.grInvoiceLine_WithholdingTaxSubTotalView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn10
            // 
            this.gridColumn10.FieldName = "nID";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn11
            // 
            this.gridColumn11.FieldName = "InvoiceLineID";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Matrah";
            this.gridColumn12.FieldName = "TaxableAmount";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 0;
            this.gridColumn12.Width = 110;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Hesap Sira";
            this.gridColumn13.FieldName = "CalculationSequenceNumeric";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 2;
            this.gridColumn13.Width = 70;
            // 
            // gridColumn14
            // 
            this.gridColumn14.FieldName = "currencyID";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Vergi";
            this.gridColumn15.FieldName = "TaxAmount";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 1;
            this.gridColumn15.Width = 106;
            // 
            // gridColumn16
            // 
            this.gridColumn16.Caption = "Vergi yuzde";
            this.gridColumn16.FieldName = "Percent_";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 3;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "Vergi kod";
            this.gridColumn17.FieldName = "TaxCategory_TaxScheme_TaxTypeCode";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 5;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Vergi aciklama";
            this.gridColumn18.FieldName = "TaxCategory_TaxScheme_Name";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 4;
            this.gridColumn18.Width = 130;
            // 
            // colTaxCategory_TaxExemptionReason2
            // 
            this.colTaxCategory_TaxExemptionReason2.Caption = "Kdv muhafiyet sebebi";
            this.colTaxCategory_TaxExemptionReason2.FieldName = "TaxCategory_TaxExemptionReason";
            this.colTaxCategory_TaxExemptionReason2.Name = "colTaxCategory_TaxExemptionReason2";
            this.colTaxCategory_TaxExemptionReason2.Visible = true;
            this.colTaxCategory_TaxExemptionReason2.VisibleIndex = 6;
            this.colTaxCategory_TaxExemptionReason2.Width = 150;
            // 
            // colTaxCategory_TaxExemptionReasonCode2
            // 
            this.colTaxCategory_TaxExemptionReasonCode2.Caption = "Kdv muhafiyet sebep kodu";
            this.colTaxCategory_TaxExemptionReasonCode2.FieldName = "TaxCategory_TaxExemptionReasonCode";
            this.colTaxCategory_TaxExemptionReasonCode2.Name = "colTaxCategory_TaxExemptionReasonCode2";
            this.colTaxCategory_TaxExemptionReasonCode2.Visible = true;
            this.colTaxCategory_TaxExemptionReasonCode2.VisibleIndex = 7;
            this.colTaxCategory_TaxExemptionReasonCode2.Width = 160;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnLineTax_Cancel);
            this.panel5.Controls.Add(this.btnLineTax_Save);
            this.panel5.Controls.Add(this.btnLineTax_Edit);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(655, 44);
            this.panel5.TabIndex = 2;
            // 
            // btnLineTax_Cancel
            // 
            this.btnLineTax_Cancel.Enabled = false;
            this.btnLineTax_Cancel.Location = new System.Drawing.Point(216, 10);
            this.btnLineTax_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnLineTax_Cancel.Name = "btnLineTax_Cancel";
            this.btnLineTax_Cancel.Size = new System.Drawing.Size(88, 28);
            this.btnLineTax_Cancel.TabIndex = 3;
            this.btnLineTax_Cancel.Text = "Vazgec";
            this.btnLineTax_Cancel.Click += new System.EventHandler(this.btnLineTax_Cancel_Click);
            // 
            // btnLineTax_Save
            // 
            this.btnLineTax_Save.Enabled = false;
            this.btnLineTax_Save.Location = new System.Drawing.Point(115, 10);
            this.btnLineTax_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btnLineTax_Save.Name = "btnLineTax_Save";
            this.btnLineTax_Save.Size = new System.Drawing.Size(97, 28);
            this.btnLineTax_Save.TabIndex = 2;
            this.btnLineTax_Save.Text = "Vergileri Kaydet";
            this.btnLineTax_Save.Click += new System.EventHandler(this.btnLineTax_Save_Click);
            // 
            // btnLineTax_Edit
            // 
            this.btnLineTax_Edit.Location = new System.Drawing.Point(5, 10);
            this.btnLineTax_Edit.Margin = new System.Windows.Forms.Padding(2);
            this.btnLineTax_Edit.Name = "btnLineTax_Edit";
            this.btnLineTax_Edit.Size = new System.Drawing.Size(97, 28);
            this.btnLineTax_Edit.TabIndex = 1;
            this.btnLineTax_Edit.Text = "Vergileri degistir";
            this.btnLineTax_Edit.Click += new System.EventHandler(this.btnLineTax_Edit_Click);
            // 
            // xtraTabPage20
            // 
            this.xtraTabPage20.Controls.Add(this.grInvoiceLine_Packages);
            this.xtraTabPage20.Controls.Add(this.panel7);
            this.xtraTabPage20.Name = "xtraTabPage20";
            this.xtraTabPage20.Size = new System.Drawing.Size(655, 392);
            this.xtraTabPage20.Text = "Ihracat Paketler";
            // 
            // grInvoiceLine_Packages
            // 
            this.grInvoiceLine_Packages.DataSource = this.tbInvoiceLine_Packages;
            this.grInvoiceLine_Packages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grInvoiceLine_Packages.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.grInvoiceLine_Packages.Location = new System.Drawing.Point(0, 44);
            this.grInvoiceLine_Packages.MainView = this.grInvoiceLine_PackagesView;
            this.grInvoiceLine_Packages.Margin = new System.Windows.Forms.Padding(2);
            this.grInvoiceLine_Packages.Name = "grInvoiceLine_Packages";
            this.grInvoiceLine_Packages.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboGridPackagingTypeCode});
            this.grInvoiceLine_Packages.Size = new System.Drawing.Size(655, 348);
            this.grInvoiceLine_Packages.TabIndex = 2;
            this.grInvoiceLine_Packages.UseEmbeddedNavigator = true;
            this.grInvoiceLine_Packages.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grInvoiceLine_PackagesView});
            // 
            // tbInvoiceLine_Packages
            // 
            this.tbInvoiceLine_Packages.Columns.AddRange(new System.Data.DataColumn[] {
            this.tbInvoiceLine_Packages_nID,
            this.tbInvoiceLine_Packages_InvoiceLineID,
            this.tbInvoiceLine_Packages_ID,
            this.tbInvoiceLine_Packages_Quantity,
            this.tbInvoiceLine_Packages_PackagingTypeCode});
            this.tbInvoiceLine_Packages.Connection = this.FirmConn;
            this.tbInvoiceLine_Packages.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "nID"}, true)});
            this.tbInvoiceLine_Packages.CurrentRow = null;
            this.tbInvoiceLine_Packages.DataSourceLink = null;
            this.tbInvoiceLine_Packages.DeleteCommand = this.sqlCommand56;
            this.tbInvoiceLine_Packages.Filter = "";
            this.tbInvoiceLine_Packages.InsertCommand = this.sqlCommand54;
            this.tbInvoiceLine_Packages.LiveSave = false;
            this.tbInvoiceLine_Packages.MaxRecords = ((long)(0));
            this.tbInvoiceLine_Packages.Name = "tbInvoiceLine_Packages";
            this.tbInvoiceLine_Packages.ParentRelation_ChildColumns = null;
            this.tbInvoiceLine_Packages.ParentRelation_ParentColumns = null;
            this.tbInvoiceLine_Packages.ParentRelation_Table = null;
            this.tbInvoiceLine_Packages.Position = ((long)(-1));
            this.tbInvoiceLine_Packages.PrimaryKey = new System.Data.DataColumn[] {
        this.tbInvoiceLine_Packages_nID};
            this.tbInvoiceLine_Packages.Quoted = false;
            this.tbInvoiceLine_Packages.SelectCommand = this.sqlCommand53;
            this.tbInvoiceLine_Packages.TableName = "neoTable1";
            this.tbInvoiceLine_Packages.Transaction = null;
            this.tbInvoiceLine_Packages.UpdateCommand = this.sqlCommand55;
            // 
            // tbInvoiceLine_Packages_nID
            // 
            this.tbInvoiceLine_Packages_nID.AllowDBNull = false;
            this.tbInvoiceLine_Packages_nID.AutoIncrement = true;
            this.tbInvoiceLine_Packages_nID.ColumnName = "nID";
            this.tbInvoiceLine_Packages_nID.DataType = typeof(int);
            // 
            // tbInvoiceLine_Packages_InvoiceLineID
            // 
            this.tbInvoiceLine_Packages_InvoiceLineID.ColumnName = "InvoiceLineID";
            this.tbInvoiceLine_Packages_InvoiceLineID.DataType = typeof(int);
            // 
            // tbInvoiceLine_Packages_ID
            // 
            this.tbInvoiceLine_Packages_ID.ColumnName = "ID";
            // 
            // tbInvoiceLine_Packages_Quantity
            // 
            this.tbInvoiceLine_Packages_Quantity.ColumnName = "Quantity";
            this.tbInvoiceLine_Packages_Quantity.DataType = typeof(double);
            // 
            // tbInvoiceLine_Packages_PackagingTypeCode
            // 
            this.tbInvoiceLine_Packages_PackagingTypeCode.ColumnName = "PackagingTypeCode";
            // 
            // sqlCommand56
            // 
            this.sqlCommand56.CommandText = "DELETE FROM InvoiceLine_Packages WHERE nID = @nID";
            // 
            // sqlCommand54
            // 
            this.sqlCommand54.CommandText = resources.GetString("sqlCommand54.CommandText");
            // 
            // sqlCommand53
            // 
            this.sqlCommand53.CommandText = "SELECT * FROM InvoiceLine_Packages WHERE InvoiceLineID = @InvoiceLineID ";
            this.sqlCommand53.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@InvoiceLineID", System.Data.SqlDbType.Int, 1, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "0")});
            // 
            // sqlCommand55
            // 
            this.sqlCommand55.CommandText = "UPDATE InvoiceLine_Packages SET \r\nInvoiceLineID = @InvoiceLineID , ID = @ID , Qua" +
    "ntity = @Quantity , PackagingTypeCode = @PackagingTypeCode\r\nWHERE nID = @nID";
            // 
            // grInvoiceLine_PackagesView
            // 
            this.grInvoiceLine_PackagesView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnID1,
            this.colInvoiceLineID2,
            this.colID4,
            this.colQuantity,
            this.colPackagingTypeCode});
            this.grInvoiceLine_PackagesView.GridControl = this.grInvoiceLine_Packages;
            this.grInvoiceLine_PackagesView.Name = "grInvoiceLine_PackagesView";
            this.grInvoiceLine_PackagesView.OptionsView.ColumnAutoWidth = false;
            this.grInvoiceLine_PackagesView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.grInvoiceLine_PackagesView.OptionsView.ShowFooter = true;
            this.grInvoiceLine_PackagesView.OptionsView.ShowGroupPanel = false;
            // 
            // colnID1
            // 
            this.colnID1.FieldName = "nID";
            this.colnID1.Name = "colnID1";
            // 
            // colInvoiceLineID2
            // 
            this.colInvoiceLineID2.FieldName = "InvoiceLineID";
            this.colInvoiceLineID2.Name = "colInvoiceLineID2";
            // 
            // colID4
            // 
            this.colID4.FieldName = "ID";
            this.colID4.Name = "colID4";
            this.colID4.Visible = true;
            this.colID4.VisibleIndex = 0;
            this.colID4.Width = 98;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 1;
            // 
            // colPackagingTypeCode
            // 
            this.colPackagingTypeCode.ColumnEdit = this.cboGridPackagingTypeCode;
            this.colPackagingTypeCode.FieldName = "PackagingTypeCode";
            this.colPackagingTypeCode.Name = "colPackagingTypeCode";
            this.colPackagingTypeCode.Visible = true;
            this.colPackagingTypeCode.VisibleIndex = 2;
            this.colPackagingTypeCode.Width = 336;
            // 
            // cboGridPackagingTypeCode
            // 
            this.cboGridPackagingTypeCode.AutoHeight = false;
            this.cboGridPackagingTypeCode.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.cboGridPackagingTypeCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboGridPackagingTypeCode.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Name3", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name4")});
            this.cboGridPackagingTypeCode.DisplayMember = "Name";
            this.cboGridPackagingTypeCode.Name = "cboGridPackagingTypeCode";
            this.cboGridPackagingTypeCode.NullText = "";
            this.cboGridPackagingTypeCode.ShowHeader = false;
            this.cboGridPackagingTypeCode.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cboGridPackagingTypeCode.ValueMember = "ID";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnIhracatPaketleriVazgec);
            this.panel7.Controls.Add(this.btnIhracatPaketleriKaydet);
            this.panel7.Controls.Add(this.btnIhracatPaketleriDegistir);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(655, 44);
            this.panel7.TabIndex = 3;
            // 
            // btnIhracatPaketleriVazgec
            // 
            this.btnIhracatPaketleriVazgec.Enabled = false;
            this.btnIhracatPaketleriVazgec.Location = new System.Drawing.Point(216, 10);
            this.btnIhracatPaketleriVazgec.Margin = new System.Windows.Forms.Padding(2);
            this.btnIhracatPaketleriVazgec.Name = "btnIhracatPaketleriVazgec";
            this.btnIhracatPaketleriVazgec.Size = new System.Drawing.Size(88, 28);
            this.btnIhracatPaketleriVazgec.TabIndex = 3;
            this.btnIhracatPaketleriVazgec.Text = "Vazgec";
            this.btnIhracatPaketleriVazgec.Click += new System.EventHandler(this.btnIhracatPaketleriVazgec_Click);
            // 
            // btnIhracatPaketleriKaydet
            // 
            this.btnIhracatPaketleriKaydet.Enabled = false;
            this.btnIhracatPaketleriKaydet.Location = new System.Drawing.Point(115, 10);
            this.btnIhracatPaketleriKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnIhracatPaketleriKaydet.Name = "btnIhracatPaketleriKaydet";
            this.btnIhracatPaketleriKaydet.Size = new System.Drawing.Size(97, 28);
            this.btnIhracatPaketleriKaydet.TabIndex = 2;
            this.btnIhracatPaketleriKaydet.Text = "Paketleri Kaydet";
            this.btnIhracatPaketleriKaydet.Click += new System.EventHandler(this.btnIhracatPaketleriKaydet_Click);
            // 
            // btnIhracatPaketleriDegistir
            // 
            this.btnIhracatPaketleriDegistir.Location = new System.Drawing.Point(5, 10);
            this.btnIhracatPaketleriDegistir.Margin = new System.Windows.Forms.Padding(2);
            this.btnIhracatPaketleriDegistir.Name = "btnIhracatPaketleriDegistir";
            this.btnIhracatPaketleriDegistir.Size = new System.Drawing.Size(97, 28);
            this.btnIhracatPaketleriDegistir.TabIndex = 1;
            this.btnIhracatPaketleriDegistir.Text = "Paketleri degistir";
            this.btnIhracatPaketleriDegistir.Click += new System.EventHandler(this.btnIhracatPaketleriDegistir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelControl18);
            this.panel1.Controls.Add(this.textEdit47);
            this.panel1.Controls.Add(this.labelControl8);
            this.panel1.Controls.Add(this.labelControl7);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.StatusDescriptionTextEdit);
            this.panel1.Controls.Add(this.textEdit1);
            this.panel1.Controls.Add(this.textEdit2);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 46);
            this.panel1.TabIndex = 1;
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(196, 2);
            this.labelControl18.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(115, 13);
            this.labelControl18.TabIndex = 24;
            this.labelControl18.Text = "Ticari entegrasyon kodu";
            // 
            // textEdit47
            // 
            this.textEdit47.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "IntCode", true));
            this.textEdit47.Location = new System.Drawing.Point(218, 18);
            this.textEdit47.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit47.Name = "textEdit47";
            this.textEdit47.Size = new System.Drawing.Size(56, 20);
            this.textEdit47.TabIndex = 23;
            // 
            // labelControl8
            // 
            this.labelControl8.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.tbInvoice, "InvoiceID", true));
            this.labelControl8.Location = new System.Drawing.Point(60, 10);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(12, 13);
            this.labelControl8.TabIndex = 22;
            this.labelControl8.Text = "---";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(9, 10);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(53, 13);
            this.labelControl7.TabIndex = 21;
            this.labelControl7.Text = "Invoice ID:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(334, 2);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Local Durum";
            // 
            // StatusDescriptionTextEdit
            // 
            this.StatusDescriptionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "StatusDescription", true));
            this.StatusDescriptionTextEdit.Location = new System.Drawing.Point(478, 18);
            this.StatusDescriptionTextEdit.Margin = new System.Windows.Forms.Padding(2);
            this.StatusDescriptionTextEdit.Name = "StatusDescriptionTextEdit";
            this.StatusDescriptionTextEdit.Size = new System.Drawing.Size(188, 20);
            this.StatusDescriptionTextEdit.TabIndex = 13;
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "LocalStatus", true));
            this.textEdit1.Location = new System.Drawing.Point(334, 18);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(56, 20);
            this.textEdit1.TabIndex = 13;
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbInvoice, "Status", true));
            this.textEdit2.Location = new System.Drawing.Point(411, 18);
            this.textEdit2.Margin = new System.Windows.Forms.Padding(2);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(56, 20);
            this.textEdit2.TabIndex = 15;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(411, 2);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Durum";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(478, 2);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(74, 13);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Durum aciklama";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 494);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1184, 46);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnXMLIndir);
            this.panel3.Controls.Add(this.btnShowXslt);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(689, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(495, 46);
            this.panel3.TabIndex = 0;
            // 
            // btnXMLIndir
            // 
            this.btnXMLIndir.ImageOptions.Image = global::MrTEK_EFatura.Properties.Resources.XML32;
            this.btnXMLIndir.Location = new System.Drawing.Point(141, 2);
            this.btnXMLIndir.Margin = new System.Windows.Forms.Padding(2);
            this.btnXMLIndir.Name = "btnXMLIndir";
            this.btnXMLIndir.Size = new System.Drawing.Size(108, 37);
            this.btnXMLIndir.TabIndex = 3;
            this.btnXMLIndir.Text = "XML Indir";
            this.btnXMLIndir.Click += new System.EventHandler(this.btnXMLIndir_Click);
            // 
            // btnShowXslt
            // 
            this.btnShowXslt.ImageOptions.Image = global::MrTEK_EFatura.Properties.Resources.printer_blue_icon32;
            this.btnShowXslt.Location = new System.Drawing.Point(6, 2);
            this.btnShowXslt.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowXslt.Name = "btnShowXslt";
            this.btnShowXslt.Size = new System.Drawing.Size(110, 37);
            this.btnShowXslt.TabIndex = 2;
            this.btnShowXslt.Text = "Yazdir";
            this.btnShowXslt.Click += new System.EventHandler(this.btnShowXslt_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(411, 2);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 37);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Vazgec";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(325, 2);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 37);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // layoutControlItem36
            // 
            this.layoutControlItem36.Control = this.textEdit38;
            this.layoutControlItem36.CustomizationFormText = "ASP_Agent Party_Postal Address_Room";
            this.layoutControlItem36.Location = new System.Drawing.Point(0, 286);
            this.layoutControlItem36.Name = "ItemForASP_AgentParty_PostalAddress_Room";
            this.layoutControlItem36.Size = new System.Drawing.Size(649, 26);
            this.layoutControlItem36.Text = "ASP_Agent Party_Postal Address_Room";
            this.layoutControlItem36.TextSize = new System.Drawing.Size(337, 16);
            // 
            // SaveFileDialog1
            // 
            this.SaveFileDialog1.DefaultExt = "xml";
            this.SaveFileDialog1.Filter = "Xml dosyalar|*.xml|Tum dosyalar|*.*";
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 540);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura";
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutSupplier)).EndInit();
            this.dataLayoutSupplier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit55.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit54.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit49.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit48.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit10.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit11.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit12.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit13.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit14.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit15.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit16.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit17.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit18.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit19.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit20.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit21.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit22.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit23.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit38.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit24.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit25.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit26.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit27.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit28.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit29.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit30.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit31.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit32.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit33.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit34.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit35.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit36.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit37.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit39.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit40.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit41.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit42.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit43.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit44.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit45.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit46.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem156)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup20)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutCustomer)).EndInit();
            this.dataLayoutCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit53.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit52.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit50.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit51.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit91.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit92.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit93.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit94.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit95.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit96.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit97.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit98.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit99.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit100.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit101.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit102.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit103.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit104.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit105.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit106.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit107.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit108.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit109.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit110.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit111.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit112.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit113.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit114.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit115.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit116.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit117.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit118.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit119.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit120.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit121.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit122.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit123.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit124.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit125.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit126.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit127.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit128.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit129.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit130.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit131.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit132.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit133.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit134.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem89)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem90)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem91)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem92)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem93)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem94)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem95)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem96)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem97)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem98)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem99)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem101)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem102)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem103)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem104)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem105)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem106)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem107)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem108)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem109)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem110)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem111)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem112)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem113)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem114)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem115)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem116)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem117)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem118)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem119)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem120)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem121)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem122)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem123)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem124)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem125)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem126)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem127)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem128)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem129)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem130)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem131)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem132)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup30)).EndInit();
            this.xtraTabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl3)).EndInit();
            this.xtraTabControl3.ResumeLayout(false);
            this.xtraTabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutTotals)).EndInit();
            this.dataLayoutTotals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TaxAmountSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LegalMonetaryTotal_LineExtensionAmountSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LegalMonetaryTotal_TaxExclusiveAmountSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LegalMonetaryTotal_TaxInclusiveAmountSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LegalMonetaryTotal_AllowanceTotalSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LegalMonetaryTotal_PayableRoundingAmountSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LegalMonetaryTotal_PayableAmountSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTaxAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLegalMonetaryTotal_LineExtensionAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLegalMonetaryTotal_TaxExclusiveAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLegalMonetaryTotal_TaxInclusiveAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLegalMonetaryTotal_AllowanceTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLegalMonetaryTotal_PayableRoundingAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLegalMonetaryTotal_PayableAmount)).EndInit();
            this.xtraTabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_TaxSubTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoice_TaxSubtotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_TaxSubTotalView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            this.xtraTabPage16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_WithholdingTaxSubTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoice_WithholdingTaxSubtotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_WithholdingTaxSubTotalView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit5)).EndInit();
            this.xtraTabPage9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_AllowanceCharge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoice_AllowanceCharge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_AllowanceChargeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            this.xtraTabPage15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_Note)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoice_Note)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_NoteView)).EndInit();
            this.xtraTabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_OrderReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoice_OrderReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_OrderReferenceView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).EndInit();
            this.xtraTabPage10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_DespatchDocumentReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoice_DespatchDocumentReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_DespatchDocumentReferenceView)).EndInit();
            this.xtraTabPage11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl4)).EndInit();
            this.xtraTabControl4.ResumeLayout(false);
            this.xtraTabPage12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_PaymentMeans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoice_PaymentMeans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_PaymentMeansView)).EndInit();
            this.xtraTabPage13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_PaymentTerms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoice_PaymentTerms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_PaymentTermsView)).EndInit();
            this.xtraTabPage14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_ReceiptDocumentReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoice_ReceiptDocumentReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoice_ReceiptDocumentReferenceView)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grBillingReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoice_BillingReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBillingReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicePeriod_EndDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicePeriod_EndDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicePeriod_StartDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicePeriod_StartDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PricingExchangeRate_CalculationRateSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineCountNumericSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IssueDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IssueDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PostBoxTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegratorIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IssueTimeDateEdit.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grInvoiceLine)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoiceLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoiceLineView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGridTransportModeCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl6)).EndInit();
            this.xtraTabControl6.ResumeLayout(false);
            this.xtraTabPage19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl5)).EndInit();
            this.xtraTabControl5.ResumeLayout(false);
            this.xtraTabPage17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grInvoiceLine_TaxSubTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoiceLine_TaxSubTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoiceLine_TaxSubTotalView)).EndInit();
            this.xtraTabPage18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grInvoiceLine_WithholdingTaxSubTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoiceLine_WithholdingTaxSubTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoiceLine_WithholdingTaxSubTotalView)).EndInit();
            this.panel5.ResumeLayout(false);
            this.xtraTabPage20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grInvoiceLine_Packages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInvoiceLine_Packages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grInvoiceLine_PackagesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGridPackagingTypeCode)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit47.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusDescriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem36)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private NeoDAC.NeoConnection FirmConn;
        private NeoDAC.NeoTable tbInvoice;
        private System.Data.SqlClient.SqlCommand sqlCommand4;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnShowXslt;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit IDTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit IssueDateDateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit PostBoxTextEdit;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutTotals;
        private DevExpress.XtraEditors.SpinEdit LineCountNumericSpinEdit;
        private DevExpress.XtraEditors.DateEdit InvoicePeriod_StartDateDateEdit;
        private DevExpress.XtraEditors.DateEdit InvoicePeriod_EndDateDateEdit;
        private DevExpress.XtraEditors.SpinEdit PricingExchangeRate_CalculationRateSpinEdit;
        private DevExpress.XtraEditors.SpinEdit TaxAmountSpinEdit;
        private DevExpress.XtraEditors.SpinEdit LegalMonetaryTotal_LineExtensionAmountSpinEdit;
        private DevExpress.XtraEditors.SpinEdit LegalMonetaryTotal_TaxExclusiveAmountSpinEdit;
        private DevExpress.XtraEditors.SpinEdit LegalMonetaryTotal_TaxInclusiveAmountSpinEdit;
        private DevExpress.XtraEditors.SpinEdit LegalMonetaryTotal_AllowanceTotalSpinEdit;
        private DevExpress.XtraEditors.SpinEdit LegalMonetaryTotal_PayableRoundingAmountSpinEdit;
        private DevExpress.XtraEditors.SpinEdit LegalMonetaryTotal_PayableAmountSpinEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup7;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup8;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup9;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTaxAmount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLegalMonetaryTotal_LineExtensionAmount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLegalMonetaryTotal_TaxExclusiveAmount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLegalMonetaryTotal_TaxInclusiveAmount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLegalMonetaryTotal_AllowanceTotal;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup10;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLegalMonetaryTotal_PayableRoundingAmount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLegalMonetaryTotal_PayableAmount;
        private DevExpress.XtraEditors.TextEdit IntegratorIDTextEdit;
        private DevExpress.XtraEditors.TimeEdit IssueTimeDateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit StatusDescriptionTextEdit;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutCustomer;
        private DevExpress.XtraEditors.TextEdit textEdit91;
        private DevExpress.XtraEditors.TextEdit textEdit92;
        private DevExpress.XtraEditors.TextEdit textEdit93;
        private DevExpress.XtraEditors.TextEdit textEdit94;
        private DevExpress.XtraEditors.TextEdit textEdit95;
        private DevExpress.XtraEditors.TextEdit textEdit96;
        private DevExpress.XtraEditors.TextEdit textEdit97;
        private DevExpress.XtraEditors.TextEdit textEdit98;
        private DevExpress.XtraEditors.TextEdit textEdit99;
        private DevExpress.XtraEditors.TextEdit textEdit100;
        private DevExpress.XtraEditors.TextEdit textEdit101;
        private DevExpress.XtraEditors.TextEdit textEdit102;
        private DevExpress.XtraEditors.TextEdit textEdit103;
        private DevExpress.XtraEditors.TextEdit textEdit104;
        private DevExpress.XtraEditors.TextEdit textEdit105;
        private DevExpress.XtraEditors.TextEdit textEdit106;
        private DevExpress.XtraEditors.TextEdit textEdit107;
        private DevExpress.XtraEditors.TextEdit textEdit108;
        private DevExpress.XtraEditors.TextEdit textEdit109;
        private DevExpress.XtraEditors.TextEdit textEdit110;
        private DevExpress.XtraEditors.TextEdit textEdit111;
        private DevExpress.XtraEditors.TextEdit textEdit112;
        private DevExpress.XtraEditors.TextEdit textEdit113;
        private DevExpress.XtraEditors.TextEdit textEdit114;
        private DevExpress.XtraEditors.TextEdit textEdit115;
        private DevExpress.XtraEditors.TextEdit textEdit116;
        private DevExpress.XtraEditors.TextEdit textEdit117;
        private DevExpress.XtraEditors.TextEdit textEdit118;
        private DevExpress.XtraEditors.TextEdit textEdit119;
        private DevExpress.XtraEditors.TextEdit textEdit120;
        private DevExpress.XtraEditors.TextEdit textEdit121;
        private DevExpress.XtraEditors.TextEdit textEdit122;
        private DevExpress.XtraEditors.TextEdit textEdit123;
        private DevExpress.XtraEditors.TextEdit textEdit124;
        private DevExpress.XtraEditors.TextEdit textEdit125;
        private DevExpress.XtraEditors.TextEdit textEdit126;
        private DevExpress.XtraEditors.TextEdit textEdit127;
        private DevExpress.XtraEditors.TextEdit textEdit128;
        private DevExpress.XtraEditors.TextEdit textEdit129;
        private DevExpress.XtraEditors.TextEdit textEdit130;
        private DevExpress.XtraEditors.TextEdit textEdit131;
        private DevExpress.XtraEditors.TextEdit textEdit132;
        private DevExpress.XtraEditors.TextEdit textEdit133;
        private DevExpress.XtraEditors.TextEdit textEdit134;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup21;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup22;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup23;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup24;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup25;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup26;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem89;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem90;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem91;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem92;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem93;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem94;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem95;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem96;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem97;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem98;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem99;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem100;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem101;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem102;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup27;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem103;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem104;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem105;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem106;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem107;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem108;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem109;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem110;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem111;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem112;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem113;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem114;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem115;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem116;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem117;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem118;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem119;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup28;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem120;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem121;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem122;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem123;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem124;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem125;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem126;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem127;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem128;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem129;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem130;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem131;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem132;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup29;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup30;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutSupplier;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.TextEdit textEdit8;
        private DevExpress.XtraEditors.TextEdit textEdit9;
        private DevExpress.XtraEditors.TextEdit textEdit10;
        private DevExpress.XtraEditors.TextEdit textEdit11;
        private DevExpress.XtraEditors.TextEdit textEdit12;
        private DevExpress.XtraEditors.TextEdit textEdit13;
        private DevExpress.XtraEditors.TextEdit textEdit14;
        private DevExpress.XtraEditors.TextEdit textEdit15;
        private DevExpress.XtraEditors.TextEdit textEdit16;
        private DevExpress.XtraEditors.TextEdit textEdit17;
        private DevExpress.XtraEditors.TextEdit textEdit18;
        private DevExpress.XtraEditors.TextEdit textEdit19;
        private DevExpress.XtraEditors.TextEdit textEdit20;
        private DevExpress.XtraEditors.TextEdit textEdit21;
        private DevExpress.XtraEditors.TextEdit textEdit22;
        private DevExpress.XtraEditors.TextEdit textEdit23;
        private DevExpress.XtraEditors.TextEdit textEdit24;
        private DevExpress.XtraEditors.TextEdit textEdit25;
        private DevExpress.XtraEditors.TextEdit textEdit26;
        private DevExpress.XtraEditors.TextEdit textEdit27;
        private DevExpress.XtraEditors.TextEdit textEdit28;
        private DevExpress.XtraEditors.TextEdit textEdit29;
        private DevExpress.XtraEditors.TextEdit textEdit30;
        private DevExpress.XtraEditors.TextEdit textEdit31;
        private DevExpress.XtraEditors.TextEdit textEdit32;
        private DevExpress.XtraEditors.TextEdit textEdit33;
        private DevExpress.XtraEditors.TextEdit textEdit34;
        private DevExpress.XtraEditors.TextEdit textEdit35;
        private DevExpress.XtraEditors.TextEdit textEdit36;
        private DevExpress.XtraEditors.TextEdit textEdit37;
        private DevExpress.XtraEditors.TextEdit textEdit38;
        private DevExpress.XtraEditors.TextEdit textEdit39;
        private DevExpress.XtraEditors.TextEdit textEdit40;
        private DevExpress.XtraEditors.TextEdit textEdit41;
        private DevExpress.XtraEditors.TextEdit textEdit42;
        private DevExpress.XtraEditors.TextEdit textEdit43;
        private DevExpress.XtraEditors.TextEdit textEdit44;
        private DevExpress.XtraEditors.TextEdit textEdit45;
        private DevExpress.XtraEditors.TextEdit textEdit46;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup11;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup12;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup14;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem16;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem17;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem18;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem19;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem20;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem21;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem22;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem23;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem24;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup15;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem25;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem26;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem27;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem28;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem29;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem30;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem31;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem32;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem33;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem34;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem35;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem37;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem38;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem39;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem40;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem41;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup16;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem42;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem43;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem44;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup17;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup18;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup19;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup20;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem36;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem156;
        private DevExpress.XtraGrid.GridControl grInvoiceLine;
        private DevExpress.XtraGrid.Views.Grid.GridView grInvoiceLineView;
        private NeoDAC.NeoTable tbInvoiceLine;
        private System.Data.SqlClient.SqlCommand sqlCommand8;
        private System.Data.SqlClient.SqlCommand sqlCommand6;
        private System.Data.SqlClient.SqlCommand sqlCommand5;
        private System.Data.SqlClient.SqlCommand sqlCommand7;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceLineID;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceID;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoicedQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoicedQuantity_unitCode;
        private DevExpress.XtraGrid.Columns.GridColumn colLineExtensionAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colcurrencyID;
        private DevExpress.XtraGrid.Columns.GridColumn colAllowanceCharge_ChargeIndicator;
        private DevExpress.XtraGrid.Columns.GridColumn colAllowanceCharge_AllowanceChargeReason;
        private DevExpress.XtraGrid.Columns.GridColumn colAllowanceCharge_Amount;
        private DevExpress.XtraGrid.Columns.GridColumn colAllowanceCharge_BaseAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colItem_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colItem_Description;
        private DevExpress.XtraGrid.Columns.GridColumn colItem_BrandName;
        private DevExpress.XtraGrid.Columns.GridColumn colItem_ModelName;
        private DevExpress.XtraGrid.Columns.GridColumn colBuyersItemIdentification_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colSellersItemIdentification_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturersItemIdentification_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPriceAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxAmount;
        private DevExpress.XtraGrid.GridControl grInvoiceLine_TaxSubTotal;
        private NeoDAC.NeoTable tbInvoiceLine_TaxSubTotal;
        private System.Data.SqlClient.SqlCommand sqlCommand12;
        private System.Data.SqlClient.SqlCommand sqlCommand10;
        private System.Data.SqlClient.SqlCommand sqlCommand9;
        private System.Data.SqlClient.SqlCommand sqlCommand11;
        private DevExpress.XtraGrid.Views.Grid.GridView grInvoiceLine_TaxSubTotalView;
        private DevExpress.XtraGrid.Columns.GridColumn colnID;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceLineID1;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxableAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colCalculationSequenceNumeric;
        private DevExpress.XtraGrid.Columns.GridColumn colcurrencyID1;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxAmount1;
        private DevExpress.XtraGrid.Columns.GridColumn colPercent_;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxCategory_TaxScheme_TaxTypeCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxCategory_TaxScheme_Name;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.SimpleButton btnLineTax_Cancel;
        private DevExpress.XtraEditors.SimpleButton btnLineTax_Save;
        private DevExpress.XtraEditors.SimpleButton btnLineTax_Edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.TextEdit textEdit47;
        private NeoDAC.NeoTable tbInvoice_TaxSubtotal;
        private System.Data.SqlClient.SqlCommand sqlCommand16;
        private System.Data.SqlClient.SqlCommand sqlCommand14;
        private System.Data.SqlClient.SqlCommand sqlCommand13;
        private System.Data.SqlClient.SqlCommand sqlCommand15;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage7;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage8;
        private DevExpress.XtraGrid.GridControl grInvoice_TaxSubTotal;
        private DevExpress.XtraGrid.Views.Grid.GridView grInvoice_TaxSubTotalView;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage6;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage9;
        private DevExpress.XtraGrid.GridControl grInvoice_AllowanceCharge;
        private NeoDAC.NeoTable tbInvoice_AllowanceCharge;
        private System.Data.DataColumn tbInvoice_AllowanceCharge_nID;
        private System.Data.DataColumn tbInvoice_AllowanceCharge_InvoiceID;
        private System.Data.DataColumn tbInvoice_AllowanceCharge_ChargeIndicator;
        private System.Data.DataColumn tbInvoice_AllowanceCharge_AllowanceChargeReason;
        private System.Data.DataColumn tbInvoice_AllowanceCharge_MultiplierFactorNumeric;
        private System.Data.DataColumn tbInvoice_AllowanceCharge_Amount;
        private System.Data.DataColumn tbInvoice_AllowanceCharge_Amount_currencyID;
        private System.Data.DataColumn tbInvoice_AllowanceCharge_BaseAmount;
        private System.Data.DataColumn tbInvoice_AllowanceCharge_BaseAmount_currencyID;
        private System.Data.SqlClient.SqlCommand sqlCommand20;
        private System.Data.SqlClient.SqlCommand sqlCommand18;
        private System.Data.SqlClient.SqlCommand sqlCommand17;
        private System.Data.SqlClient.SqlCommand sqlCommand19;
        private DevExpress.XtraGrid.Views.Grid.GridView grInvoice_AllowanceChargeView;
        private DevExpress.XtraGrid.Columns.GridColumn colnID2;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceID2;
        private DevExpress.XtraGrid.Columns.GridColumn colChargeIndicator;
        private DevExpress.XtraGrid.Columns.GridColumn colAllowanceChargeReason;
        private DevExpress.XtraGrid.Columns.GridColumn colMultiplierFactorNumeric;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount_currencyID;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseAmount_currencyID;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private DevExpress.XtraGrid.GridControl grInvoice_OrderReference;
        private DevExpress.XtraGrid.Views.Grid.GridView grInvoice_OrderReferenceView;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit4;
        private NeoDAC.NeoTable tbInvoice_OrderReference;
        private System.Data.DataColumn tbInvoice_OrderReference_nID;
        private System.Data.DataColumn tbInvoice_OrderReference_InvoiceID;
        private System.Data.DataColumn tbInvoice_OrderReference_ID;
        private System.Data.DataColumn tbInvoice_OrderReference_IssueDate;
        private System.Data.SqlClient.SqlCommand sqlCommand24;
        private System.Data.SqlClient.SqlCommand sqlCommand22;
        private System.Data.SqlClient.SqlCommand sqlCommand21;
        private System.Data.SqlClient.SqlCommand sqlCommand23;
        private DevExpress.XtraGrid.Columns.GridColumn colnID3;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceID3;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colIssueDate;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage10;
        private DevExpress.XtraGrid.GridControl grInvoice_DespatchDocumentReference;
        private NeoDAC.NeoTable tbInvoice_DespatchDocumentReference;
        private System.Data.DataColumn tbInvoice_DespatchDocumentReference_nID;
        private System.Data.DataColumn tbInvoice_DespatchDocumentReference_InvoiceID;
        private System.Data.DataColumn tbInvoice_DespatchDocumentReference_ID;
        private System.Data.DataColumn tbInvoice_DespatchDocumentReference_IssueDate;
        private System.Data.SqlClient.SqlCommand sqlCommand28;
        private System.Data.SqlClient.SqlCommand sqlCommand26;
        private System.Data.SqlClient.SqlCommand sqlCommand25;
        private System.Data.SqlClient.SqlCommand sqlCommand27;
        private DevExpress.XtraGrid.Views.Grid.GridView grInvoice_DespatchDocumentReferenceView;
        private DevExpress.XtraGrid.Columns.GridColumn colnID4;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceID4;
        private DevExpress.XtraGrid.Columns.GridColumn colID2;
        private DevExpress.XtraGrid.Columns.GridColumn colIssueDate1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage11;
        private DevExpress.XtraGrid.GridControl grInvoice_PaymentMeans;
        private NeoDAC.NeoTable tbInvoice_PaymentMeans;
        private System.Data.DataColumn tbInvoice_PaymentMeans_nID;
        private System.Data.DataColumn tbInvoice_PaymentMeans_InvoiceID;
        private System.Data.DataColumn tbInvoice_PaymentMeans_PaymentMeansCode;
        private System.Data.DataColumn tbInvoice_PaymentMeans_PaymentDueDate;
        private System.Data.DataColumn tbInvoice_PaymentMeans_PaymentChannelCode;
        private System.Data.DataColumn tbInvoice_PaymentMeans_InstructionNote;
        private System.Data.DataColumn tbInvoice_PaymentMeans_PayeeFinancialAccount_ID;
        private System.Data.DataColumn tbInvoice_PaymentMeans_PayeeFinancialAccount_CurrencyCode;
        private System.Data.DataColumn tbInvoice_PaymentMeans_PayeeFinancialAccount_PaymentNote;
        private System.Data.SqlClient.SqlCommand sqlCommand32;
        private System.Data.SqlClient.SqlCommand sqlCommand30;
        private System.Data.SqlClient.SqlCommand sqlCommand29;
        private System.Data.SqlClient.SqlCommand sqlCommand31;
        private DevExpress.XtraGrid.Views.Grid.GridView grInvoice_PaymentMeansView;
        private DevExpress.XtraGrid.Columns.GridColumn colnID5;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceID5;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentMeansCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentDueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentChannelCode;
        private DevExpress.XtraGrid.Columns.GridColumn colInstructionNote;
        private DevExpress.XtraGrid.Columns.GridColumn colPayeeFinancialAccount_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colPayeeFinancialAccount_CurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPayeeFinancialAccount_PaymentNote;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage12;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage13;
        private DevExpress.XtraGrid.GridControl grInvoice_PaymentTerms;
        private NeoDAC.NeoTable tbInvoice_PaymentTerms;
        private System.Data.DataColumn tbInvoice_PaymentTerms_nID;
        private System.Data.DataColumn tbInvoice_PaymentTerms_InvoiceID;
        private System.Data.DataColumn tbInvoice_PaymentTerms_Note;
        private System.Data.DataColumn tbInvoice_PaymentTerms_PenaltySurchargePercent;
        private System.Data.DataColumn tbInvoice_PaymentTerms_Amount;
        private System.Data.DataColumn tbInvoice_PaymentTerms_Amount_currencyID;
        private System.Data.SqlClient.SqlCommand sqlCommand36;
        private System.Data.SqlClient.SqlCommand sqlCommand34;
        private System.Data.SqlClient.SqlCommand sqlCommand33;
        private System.Data.SqlClient.SqlCommand sqlCommand35;
        private DevExpress.XtraGrid.Views.Grid.GridView grInvoice_PaymentTermsView;
        private DevExpress.XtraGrid.Columns.GridColumn colnID6;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceID6;
        private DevExpress.XtraGrid.Columns.GridColumn colNote1;
        private DevExpress.XtraGrid.Columns.GridColumn colPenaltySurchargePercent;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount1;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount_currencyID1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage14;
        private DevExpress.XtraGrid.GridControl grInvoice_ReceiptDocumentReference;
        private NeoDAC.NeoTable tbInvoice_ReceiptDocumentReference;
        private System.Data.DataColumn tbInvoice_ReceiptDocumentReference_nID;
        private System.Data.DataColumn tbInvoice_ReceiptDocumentReference_InvoiceID;
        private System.Data.DataColumn tbInvoice_ReceiptDocumentReference_ID;
        private System.Data.DataColumn tbInvoice_ReceiptDocumentReference_IssueDate;
        private System.Data.SqlClient.SqlCommand sqlCommand40;
        private System.Data.SqlClient.SqlCommand sqlCommand38;
        private System.Data.SqlClient.SqlCommand sqlCommand37;
        private System.Data.SqlClient.SqlCommand sqlCommand39;
        private DevExpress.XtraGrid.Views.Grid.GridView grInvoice_ReceiptDocumentReferenceView;
        private DevExpress.XtraGrid.Columns.GridColumn colnID7;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceID7;
        private DevExpress.XtraGrid.Columns.GridColumn colID3;
        private DevExpress.XtraGrid.Columns.GridColumn colIssueDate2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage15;
        private DevExpress.XtraGrid.GridControl grInvoice_Note;
        private NeoDAC.NeoTable tbInvoice_Note;
        private System.Data.DataColumn tbInvoice_Note_nID;
        private System.Data.DataColumn tbInvoice_Note_InvoiceID;
        private System.Data.DataColumn tbInvoice_Note_Note;
        private System.Data.SqlClient.SqlCommand sqlCommand44;
        private System.Data.SqlClient.SqlCommand sqlCommand42;
        private System.Data.SqlClient.SqlCommand sqlCommand41;
        private System.Data.SqlClient.SqlCommand sqlCommand43;
        private DevExpress.XtraGrid.Views.Grid.GridView grInvoice_NoteView;
        private DevExpress.XtraGrid.Columns.GridColumn colnID8;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceID8;
        private DevExpress.XtraGrid.Columns.GridColumn colNote2;
        private DevExpress.XtraEditors.TextEdit textEdit49;
        private DevExpress.XtraEditors.TextEdit textEdit48;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem45;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem46;
        private DevExpress.XtraEditors.TextEdit textEdit50;
        private DevExpress.XtraEditors.TextEdit textEdit51;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem47;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem48;
        private DevExpress.XtraEditors.TextEdit textEdit55;
        private DevExpress.XtraEditors.TextEdit textEdit54;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem51;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem52;
        private DevExpress.XtraEditors.TextEdit textEdit53;
        private DevExpress.XtraEditors.TextEdit textEdit52;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem49;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem50;
        private DevExpress.XtraGrid.Columns.GridColumn colItem_ItemClassificationCode;
        private DevExpress.XtraGrid.Columns.GridColumn colAllowanceCharge_MultiplierFactorNumeric;
        private System.Data.DataColumn tbInvoice_InvoiceID;
        private System.Data.DataColumn tbInvoice_Deleted;
        private System.Data.DataColumn tbInvoice_CreatedBy;
        private System.Data.DataColumn tbInvoice_CreatedDate;
        private System.Data.DataColumn tbInvoice_ModifiedBy;
        private System.Data.DataColumn tbInvoice_ModifiedDate;
        private System.Data.DataColumn tbInvoice_IOType;
        private System.Data.DataColumn tbInvoice_IntCode;
        private System.Data.DataColumn tbInvoice_LocalStatus;
        private System.Data.DataColumn tbInvoice_IntegratorID;
        private System.Data.DataColumn tbInvoice_Status;
        private System.Data.DataColumn tbInvoice_StatusDescription;
        private System.Data.DataColumn tbInvoice_PostBox;
        private System.Data.DataColumn tbInvoice_XsltNo;
        private System.Data.DataColumn tbInvoice_ProfileID;
        private System.Data.DataColumn tbInvoice_ID;
        private System.Data.DataColumn tbInvoice_UUID;
        private System.Data.DataColumn tbInvoice_IssueDate;
        private System.Data.DataColumn tbInvoice_IssueTime;
        private System.Data.DataColumn tbInvoice_InvoiceTypeCode;
        private System.Data.DataColumn tbInvoice_DocumentCurrencyCode;
        private System.Data.DataColumn tbInvoice_TaxCurrencyCode;
        private System.Data.DataColumn tbInvoice_PricingCurrencyCode;
        private System.Data.DataColumn tbInvoice_PaymentCurrencyCode;
        private System.Data.DataColumn tbInvoice_PaymentAlternativeCurrencyCode;
        private System.Data.DataColumn tbInvoice_LineCountNumeric;
        private System.Data.DataColumn tbInvoice_InvoicePeriod_StartDate;
        private System.Data.DataColumn tbInvoice_InvoicePeriod_EndDate;
        private System.Data.DataColumn tbInvoice_ASP_PartyIdentification1_schemeID;
        private System.Data.DataColumn tbInvoice_ASP_PartyIdentification1_ID;
        private System.Data.DataColumn tbInvoice_ASP_PartyIdentification2_schemeID;
        private System.Data.DataColumn tbInvoice_ASP_PartyIdentification2_ID;
        private System.Data.DataColumn tbInvoice_ASP_PartyIdentification3_schemeID;
        private System.Data.DataColumn tbInvoice_ASP_PartyIdentification3_ID;
        private System.Data.DataColumn tbInvoice_ASP_PartyIdentification4_schemeID;
        private System.Data.DataColumn tbInvoice_ASP_PartyIdentification4_ID;
        private System.Data.DataColumn tbInvoice_ASP_PartyIdentification5_schemeID;
        private System.Data.DataColumn tbInvoice_ASP_PartyIdentification5_ID;
        private System.Data.DataColumn tbInvoice_ASP_PartyName;
        private System.Data.DataColumn tbInvoice_ASP_PostalAddress_StreetName;
        private System.Data.DataColumn tbInvoice_ASP_PostalAddress_Room;
        private System.Data.DataColumn tbInvoice_ASP_PostalAddress_BuildingNumber;
        private System.Data.DataColumn tbInvoice_ASP_PostalAddress_BuildingName;
        private System.Data.DataColumn tbInvoice_ASP_PostalAddress_CitySubdivisionName;
        private System.Data.DataColumn tbInvoice_ASP_PostalAddress_CityName;
        private System.Data.DataColumn tbInvoice_ASP_PostalAddress_Country;
        private System.Data.DataColumn tbInvoice_ASP_PartyTaxSchemeName;
        private System.Data.DataColumn tbInvoice_ASP_PartyTaxSchemeTaxTypeCode;
        private System.Data.DataColumn tbInvoice_ASP_WebsiteURI;
        private System.Data.DataColumn tbInvoice_ASP_Contact_Telephone;
        private System.Data.DataColumn tbInvoice_ASP_Contact_Telefax;
        private System.Data.DataColumn tbInvoice_ASP_Contact_ElectronicMail;
        private System.Data.DataColumn tbInvoice_ASP_Person_FirstName;
        private System.Data.DataColumn tbInvoice_ASP_Person_FamilyName;
        private System.Data.DataColumn tbInvoice_ASP_Person_MiddleName;
        private System.Data.DataColumn tbInvoice_ASP_Person_NameSuffix;
        private System.Data.DataColumn tbInvoice_ASP_Person_Title;
        private System.Data.DataColumn tbInvoice_ASP_AgentParty_PartyIdentification1_schemeID;
        private System.Data.DataColumn tbInvoice_ASP_AgentParty_PartyIdentification1_ID;
        private System.Data.DataColumn tbInvoice_ASP_AgentParty_PartyIdentification2_schemeID;
        private System.Data.DataColumn tbInvoice_ASP_AgentParty_PartyIdentification2_ID;
        private System.Data.DataColumn tbInvoice_ASP_AgentParty_PartyIdentification3_schemeID;
        private System.Data.DataColumn tbInvoice_ASP_AgentParty_PartyIdentification3_ID;
        private System.Data.DataColumn tbInvoice_ASP_AgentParty_PartyIdentification4_schemeID;
        private System.Data.DataColumn tbInvoice_ASP_AgentParty_PartyIdentification4_ID;
        private System.Data.DataColumn tbInvoice_ASP_AgentParty_PartyIdentification5_schemeID;
        private System.Data.DataColumn tbInvoice_ASP_AgentParty_PartyIdentification5_ID;
        private System.Data.DataColumn tbInvoice_ASP_AgentParty_PartyName;
        private System.Data.DataColumn tbInvoice_ASP_AgentParty_PostalAddress_StreetName;
        private System.Data.DataColumn tbInvoice_ASP_AgentParty_PostalAddress_Room;
        private System.Data.DataColumn tbInvoice_ASP_AgentParty_PostalAddress_BuildingNumber;
        private System.Data.DataColumn tbInvoice_ASP_AgentParty_PostalAddress_BuildingName;
        private System.Data.DataColumn tbInvoice_ASP_AgentParty_PostalAddress_CitySubdivisionName;
        private System.Data.DataColumn tbInvoice_ASP_AgentParty_PostalAddress_CityName;
        private System.Data.DataColumn tbInvoice_ASP_AgentParty_PostalAddress_Country;
        private System.Data.DataColumn tbInvoice_ASP_AgentParty_PartyTaxSchemeName;
        private System.Data.DataColumn tbInvoice_ASP_AgentParty_PartyTaxSchemeTaxTypeCode;
        private System.Data.DataColumn tbInvoice_ASP_AgentParty_WebsiteURI;
        private System.Data.DataColumn tbInvoice_ASP_AgentParty_Contact_Telephone;
        private System.Data.DataColumn tbInvoice_ASP_AgentParty_Contact_Telefax;
        private System.Data.DataColumn tbInvoice_ASP_AgentParty_Contact_ElectronicMail;
        private System.Data.DataColumn tbInvoice_ASP_AgentParty_Person_FirstName;
        private System.Data.DataColumn tbInvoice_ASP_AgentParty_Person_FamilyName;
        private System.Data.DataColumn tbInvoice_ASP_AgentParty_Person_MiddleName;
        private System.Data.DataColumn tbInvoice_ASP_AgentParty_Person_NameSuffix;
        private System.Data.DataColumn tbInvoice_ASP_AgentParty_Person_Title;
        private System.Data.DataColumn tbInvoice_ACP_PartyIdentification1_schemeID;
        private System.Data.DataColumn tbInvoice_ACP_PartyIdentification1_ID;
        private System.Data.DataColumn tbInvoice_ACP_PartyIdentification2_schemeID;
        private System.Data.DataColumn tbInvoice_ACP_PartyIdentification2_ID;
        private System.Data.DataColumn tbInvoice_ACP_PartyIdentification3_schemeID;
        private System.Data.DataColumn tbInvoice_ACP_PartyIdentification3_ID;
        private System.Data.DataColumn tbInvoice_ACP_PartyIdentification4_schemeID;
        private System.Data.DataColumn tbInvoice_ACP_PartyIdentification4_ID;
        private System.Data.DataColumn tbInvoice_ACP_PartyIdentification5_schemeID;
        private System.Data.DataColumn tbInvoice_ACP_PartyIdentification5_ID;
        private System.Data.DataColumn tbInvoice_ACP_PartyName;
        private System.Data.DataColumn tbInvoice_ACP_PostalAddress_StreetName;
        private System.Data.DataColumn tbInvoice_ACP_PostalAddress_Room;
        private System.Data.DataColumn tbInvoice_ACP_PostalAddress_BuildingNumber;
        private System.Data.DataColumn tbInvoice_ACP_PostalAddress_BuildingName;
        private System.Data.DataColumn tbInvoice_ACP_PostalAddress_CitySubdivisionName;
        private System.Data.DataColumn tbInvoice_ACP_PostalAddress_CityName;
        private System.Data.DataColumn tbInvoice_ACP_PostalAddress_Country;
        private System.Data.DataColumn tbInvoice_ACP_PartyTaxSchemeName;
        private System.Data.DataColumn tbInvoice_ACP_PartyTaxSchemeTaxTypeCode;
        private System.Data.DataColumn tbInvoice_ACP_WebsiteURI;
        private System.Data.DataColumn tbInvoice_ACP_Contact_Telephone;
        private System.Data.DataColumn tbInvoice_ACP_Contact_Telefax;
        private System.Data.DataColumn tbInvoice_ACP_Contact_ElectronicMail;
        private System.Data.DataColumn tbInvoice_ACP_Person_FirstName;
        private System.Data.DataColumn tbInvoice_ACP_Person_FamilyName;
        private System.Data.DataColumn tbInvoice_ACP_Person_MiddleName;
        private System.Data.DataColumn tbInvoice_ACP_Person_NameSuffix;
        private System.Data.DataColumn tbInvoice_ACP_Person_Title;
        private System.Data.DataColumn tbInvoice_ACP_AgentParty_PartyIdentification1_schemeID;
        private System.Data.DataColumn tbInvoice_ACP_AgentParty_PartyIdentification1_ID;
        private System.Data.DataColumn tbInvoice_ACP_AgentParty_PartyIdentification2_schemeID;
        private System.Data.DataColumn tbInvoice_ACP_AgentParty_PartyIdentification2_ID;
        private System.Data.DataColumn tbInvoice_ACP_AgentParty_PartyIdentification3_schemeID;
        private System.Data.DataColumn tbInvoice_ACP_AgentParty_PartyIdentification3_ID;
        private System.Data.DataColumn tbInvoice_ACP_AgentParty_PartyIdentification4_schemeID;
        private System.Data.DataColumn tbInvoice_ACP_AgentParty_PartyIdentification4_ID;
        private System.Data.DataColumn tbInvoice_ACP_AgentParty_PartyIdentification5_schemeID;
        private System.Data.DataColumn tbInvoice_ACP_AgentParty_PartyIdentification5_ID;
        private System.Data.DataColumn tbInvoice_ACP_AgentParty_PartyName;
        private System.Data.DataColumn tbInvoice_ACP_AgentParty_PostalAddress_StreetName;
        private System.Data.DataColumn tbInvoice_ACP_AgentParty_PostalAddress_Room;
        private System.Data.DataColumn tbInvoice_ACP_AgentParty_PostalAddress_BuildingNumber;
        private System.Data.DataColumn tbInvoice_ACP_AgentParty_PostalAddress_BuildingName;
        private System.Data.DataColumn tbInvoice_ACP_AgentParty_PostalAddress_CitySubdivisionName;
        private System.Data.DataColumn tbInvoice_ACP_AgentParty_PostalAddress_CityName;
        private System.Data.DataColumn tbInvoice_ACP_AgentParty_PostalAddress_Country;
        private System.Data.DataColumn tbInvoice_ACP_AgentParty_PartyTaxSchemeName;
        private System.Data.DataColumn tbInvoice_ACP_AgentParty_PartyTaxSchemeTaxTypeCode;
        private System.Data.DataColumn tbInvoice_ACP_AgentParty_WebsiteURI;
        private System.Data.DataColumn tbInvoice_ACP_AgentParty_Contact_Telephone;
        private System.Data.DataColumn tbInvoice_ACP_AgentParty_Contact_Telefax;
        private System.Data.DataColumn tbInvoice_ACP_AgentParty_Contact_ElectronicMail;
        private System.Data.DataColumn tbInvoice_ACP_AgentParty_Person_FirstName;
        private System.Data.DataColumn tbInvoice_ACP_AgentParty_Person_FamilyName;
        private System.Data.DataColumn tbInvoice_ACP_AgentParty_Person_MiddleName;
        private System.Data.DataColumn tbInvoice_ACP_AgentParty_Person_NameSuffix;
        private System.Data.DataColumn tbInvoice_ACP_AgentParty_Person_Title;
        private System.Data.DataColumn tbInvoice_TaxExchangeRate_SourceCurrencyCode;
        private System.Data.DataColumn tbInvoice_TaxExchangeRate_TargetCurrencyCode;
        private System.Data.DataColumn tbInvoice_TaxExchangeRate_CalculationRate;
        private System.Data.DataColumn tbInvoice_TaxExchangeRate_Date;
        private System.Data.DataColumn tbInvoice_PricingExchangeRate_SourceCurrencyCode;
        private System.Data.DataColumn tbInvoice_PricingExchangeRate_TargetCurrencyCode;
        private System.Data.DataColumn tbInvoice_PricingExchangeRate_CalculationRate;
        private System.Data.DataColumn tbInvoice_PricingExchangeRate_Date;
        private System.Data.DataColumn tbInvoice_PaymentExchangeRate_SourceCurrencyCode;
        private System.Data.DataColumn tbInvoice_PaymentExchangeRate_TargetCurrencyCode;
        private System.Data.DataColumn tbInvoice_PaymentExchangeRate_CalculationRate;
        private System.Data.DataColumn tbInvoice_PaymentExchangeRate_Date;
        private System.Data.DataColumn tbInvoice_PaymentAlternativeExchangeRate_SourceCurrencyCode;
        private System.Data.DataColumn tbInvoice_PaymentAlternativeExchangeRate_TargetCurrencyCode;
        private System.Data.DataColumn tbInvoice_PaymentAlternativeExchangeRate_CalculationRate;
        private System.Data.DataColumn tbInvoice_PaymentAlternativeExchangeRate_Date;
        private System.Data.DataColumn tbInvoice_TaxAmount;
        private System.Data.DataColumn tbInvoice_LegalMonetaryTotal_LineExtensionAmount;
        private System.Data.DataColumn tbInvoice_LegalMonetaryTotal_TaxExclusiveAmount;
        private System.Data.DataColumn tbInvoice_LegalMonetaryTotal_TaxInclusiveAmount;
        private System.Data.DataColumn tbInvoice_LegalMonetaryTotal_AllowanceTotalAmount;
        private System.Data.DataColumn tbInvoice_LegalMonetaryTotal_ChargeTotalAmount;
        private System.Data.DataColumn tbInvoice_LegalMonetaryTotal_PayableRoundingAmount;
        private System.Data.DataColumn tbInvoice_LegalMonetaryTotal_PayableAmount;
        private DevExpress.XtraEditors.SimpleButton btnXMLIndir;
        internal System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        private DevExpress.XtraEditors.SimpleButton btnNewGuid;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage16;
        private DevExpress.XtraGrid.GridControl grInvoice_WithholdingTaxSubTotal;
        private DevExpress.XtraGrid.Views.Grid.GridView grInvoice_WithholdingTaxSubTotalView;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit5;
        private NeoDAC.NeoTable tbInvoice_WithholdingTaxSubtotal;
        private System.Data.SqlClient.SqlCommand sqlCommand48;
        private System.Data.SqlClient.SqlCommand sqlCommand46;
        private System.Data.SqlClient.SqlCommand sqlCommand45;
        private System.Data.SqlClient.SqlCommand sqlCommand47;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl5;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage17;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage18;
        private DevExpress.XtraGrid.GridControl grInvoiceLine_WithholdingTaxSubTotal;
        private DevExpress.XtraGrid.Views.Grid.GridView grInvoiceLine_WithholdingTaxSubTotalView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private NeoDAC.NeoTable tbInvoiceLine_WithholdingTaxSubTotal;
        private System.Data.DataColumn tbInvoiceLine_WithholdingTaxSubTotal_nID;
        private System.Data.DataColumn tbInvoiceLine_WithholdingTaxSubTotal_InvoiceLineID;
        private System.Data.DataColumn tbInvoiceLine_WithholdingTaxSubTotal_TaxableAmount;
        private System.Data.DataColumn tbInvoiceLine_WithholdingTaxSubTotal_currencyID;
        private System.Data.DataColumn tbInvoiceLine_WithholdingTaxSubTotal_TaxAmount;
        private System.Data.DataColumn tbInvoiceLine_WithholdingTaxSubTotal_PerUnitAmount;
        private System.Data.DataColumn tbInvoiceLine_WithholdingTaxSubTotal_CalculationSequenceNumeric;
        private System.Data.DataColumn tbInvoiceLine_WithholdingTaxSubTotal_Percent_;
        private System.Data.DataColumn tbInvoiceLine_WithholdingTaxSubTotal_TaxCategory_TaxScheme_Name;
        private System.Data.DataColumn tbInvoiceLine_WithholdingTaxSubTotal_TaxCategory_TaxScheme_TaxTypeCode;
        private System.Data.DataColumn tbInvoiceLine_WithholdingTaxSubTotal_TaxCategory_TaxExemptionReason;
        private System.Data.DataColumn tbInvoiceLine_WithholdingTaxSubTotal_TaxCategory_TaxExemptionReasonCode;
        private System.Data.SqlClient.SqlCommand sqlCommand52;
        private System.Data.SqlClient.SqlCommand sqlCommand50;
        private System.Data.SqlClient.SqlCommand sqlCommand49;
        private System.Data.SqlClient.SqlCommand sqlCommand51;
        private System.Data.DataColumn tbInvoice_TaxSubtotal_nID;
        private System.Data.DataColumn tbInvoice_TaxSubtotal_InvoiceID;
        private System.Data.DataColumn tbInvoice_TaxSubtotal_TaxableAmount;
        private System.Data.DataColumn tbInvoice_TaxSubtotal_currencyID;
        private System.Data.DataColumn tbInvoice_TaxSubtotal_TaxAmount;
        private System.Data.DataColumn tbInvoice_TaxSubtotal_PerUnitAmount;
        private System.Data.DataColumn tbInvoice_TaxSubtotal_CalculationSequenceNumeric;
        private System.Data.DataColumn tbInvoice_TaxSubtotal_Percent_;
        private System.Data.DataColumn tbInvoice_TaxSubtotal_TaxCategory_TaxScheme_Name;
        private System.Data.DataColumn tbInvoice_TaxSubtotal_TaxCategory_TaxScheme_TaxTypeCode;
        private System.Data.DataColumn tbInvoice_TaxSubtotal_TaxCategory_TaxExemptionReason;
        private System.Data.DataColumn tbInvoice_TaxSubtotal_TaxCategory_TaxExemptionReasonCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceID1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn25;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn26;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn27;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn28;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn29;
        private System.Data.DataColumn tbInvoice_WithholdingTaxSubtotal_nID;
        private System.Data.DataColumn tbInvoice_WithholdingTaxSubtotal_InvoiceID;
        private System.Data.DataColumn tbInvoice_WithholdingTaxSubtotal_TaxableAmount;
        private System.Data.DataColumn tbInvoice_WithholdingTaxSubtotal_currencyID;
        private System.Data.DataColumn tbInvoice_WithholdingTaxSubtotal_TaxAmount;
        private System.Data.DataColumn tbInvoice_WithholdingTaxSubtotal_PerUnitAmount;
        private System.Data.DataColumn tbInvoice_WithholdingTaxSubtotal_CalculationSequenceNumeric;
        private System.Data.DataColumn tbInvoice_WithholdingTaxSubtotal_Percent_;
        private System.Data.DataColumn tbInvoice_WithholdingTaxSubtotal_TaxCategory_TaxScheme_Name;
        private System.Data.DataColumn tbInvoice_WithholdingTaxSubtotal_TaxCategory_TaxScheme_TaxTypeCode;
        private System.Data.DataColumn tbInvoice_WithholdingTaxSubtotal_TaxCategory_TaxExemptionReason;
        private System.Data.DataColumn tbInvoice_WithholdingTaxSubtotal_TaxCategory_TaxExemptionReasonCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn30;
        private System.Data.DataColumn tbInvoiceLine_TaxSubTotal_nID;
        private System.Data.DataColumn tbInvoiceLine_TaxSubTotal_InvoiceLineID;
        private System.Data.DataColumn tbInvoiceLine_TaxSubTotal_TaxableAmount;
        private System.Data.DataColumn tbInvoiceLine_TaxSubTotal_currencyID;
        private System.Data.DataColumn tbInvoiceLine_TaxSubTotal_TaxAmount;
        private System.Data.DataColumn tbInvoiceLine_TaxSubTotal_PerUnitAmount;
        private System.Data.DataColumn tbInvoiceLine_TaxSubTotal_CalculationSequenceNumeric;
        private System.Data.DataColumn tbInvoiceLine_TaxSubTotal_Percent_;
        private System.Data.DataColumn tbInvoiceLine_TaxSubTotal_TaxCategory_TaxScheme_Name;
        private System.Data.DataColumn tbInvoiceLine_TaxSubTotal_TaxCategory_TaxScheme_TaxTypeCode;
        private System.Data.DataColumn tbInvoiceLine_TaxSubTotal_TaxCategory_TaxExemptionReason;
        private System.Data.DataColumn tbInvoiceLine_TaxSubTotal_TaxCategory_TaxExemptionReasonCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxCategory_TaxExemptionReason1;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxCategory_TaxExemptionReasonCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxCategory_TaxExemptionReason2;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxCategory_TaxExemptionReasonCode2;
        private System.Data.DataColumn tbInvoiceLine_WithholdingTaxAmount;
        private System.Data.DataColumn tbInvoiceLine_GTIPNO;
        private System.Data.DataColumn tbInvoiceLine_TransportModeCode;
        private System.Data.DataColumn tbInvoiceLine_DeliveryTerms;
        private System.Data.DataColumn tbInvoiceLine_TaxAmount;
        private System.Data.DataColumn tbInvoiceLine_PriceAmount;
        private System.Data.DataColumn tbInvoiceLine_Item_ManufacturersItemIdentification_ID;
        private System.Data.DataColumn tbInvoiceLine_Item_SellersItemIdentification_ID;
        private System.Data.DataColumn tbInvoiceLine_Item_BuyersItemIdentification_ID;
        private System.Data.DataColumn tbInvoiceLine_Item_ItemClassificationCode;
        private System.Data.DataColumn tbInvoiceLine_Item_ModelName;
        private System.Data.DataColumn tbInvoiceLine_Item_BrandName;
        private System.Data.DataColumn tbInvoiceLine_Item_Description;
        private System.Data.DataColumn tbInvoiceLine_Item_Name;
        private System.Data.DataColumn tbInvoiceLine_AllowanceCharge_MultiplierFactorNumeric;
        private System.Data.DataColumn tbInvoiceLine_AllowanceCharge_BaseAmount;
        private System.Data.DataColumn tbInvoiceLine_AllowanceCharge_Amount;
        private System.Data.DataColumn tbInvoiceLine_AllowanceCharge_AllowanceChargeReason;
        private System.Data.DataColumn tbInvoiceLine_AllowanceCharge_ChargeIndicator;
        private System.Data.DataColumn tbInvoiceLine_currencyID;
        private System.Data.DataColumn tbInvoiceLine_LineExtensionAmount;
        private System.Data.DataColumn tbInvoiceLine_InvoicedQuantity_unitCode;
        private System.Data.DataColumn tbInvoiceLine_InvoicedQuantity;
        private System.Data.DataColumn tbInvoiceLine_Note;
        private System.Data.DataColumn tbInvoiceLine_ID;
        private System.Data.DataColumn tbInvoiceLine_InvoiceID;
        private System.Data.DataColumn tbInvoiceLine_InvoiceLineID;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl6;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage19;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage20;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliveryTerms;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colGTIPNO;
        private DevExpress.XtraGrid.Columns.GridColumn colTransportModeCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboGridTransportModeCode;
        private DevExpress.XtraGrid.GridControl grInvoiceLine_Packages;
        private DevExpress.XtraGrid.Views.Grid.GridView grInvoiceLine_PackagesView;
        private System.Windows.Forms.Panel panel7;
        private DevExpress.XtraEditors.SimpleButton btnIhracatPaketleriVazgec;
        private DevExpress.XtraEditors.SimpleButton btnIhracatPaketleriKaydet;
        private DevExpress.XtraEditors.SimpleButton btnIhracatPaketleriDegistir;
        private NeoDAC.NeoTable tbInvoiceLine_Packages;
        private System.Data.SqlClient.SqlCommand sqlCommand56;
        private System.Data.SqlClient.SqlCommand sqlCommand54;
        private System.Data.SqlClient.SqlCommand sqlCommand53;
        private System.Data.SqlClient.SqlCommand sqlCommand55;
        private DevExpress.XtraGrid.Columns.GridColumn colnID1;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceLineID2;
        private DevExpress.XtraGrid.Columns.GridColumn colID4;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colPackagingTypeCode;
        private System.Data.DataColumn tbInvoiceLine_Packages_PackagingTypeCode;
        private System.Data.DataColumn tbInvoiceLine_Packages_Quantity;
        private System.Data.DataColumn tbInvoiceLine_Packages_ID;
        private System.Data.DataColumn tbInvoiceLine_Packages_InvoiceLineID;
        private System.Data.DataColumn tbInvoiceLine_Packages_nID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboGridPackagingTypeCode;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ihracatBilgileriniAltSatırlaraKopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gTIPNOBoşOlanlarıGeçmişKayıtlardanBulDoldurToolStripMenuItem;
        private DevExpress.XtraGrid.GridControl grBillingReference;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBillingReference;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn31;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn33;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn34;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private NeoDAC.NeoTable tbInvoice_BillingReference;
        private System.Data.SqlClient.SqlCommand sqlCommand60;
        private System.Data.SqlClient.SqlCommand sqlCommand58;
        private System.Data.SqlClient.SqlCommand sqlCommand57;
        private System.Data.SqlClient.SqlCommand sqlCommand59;
        private DevExpress.XtraEditors.LabelControl lblBillingReference;
        private System.Data.DataColumn tbInvoice_BillingReference_nID;
        private System.Data.DataColumn tbInvoice_BillingReference_InvoiceID;
        private System.Data.DataColumn tbInvoice_BillingReference_ID;
        private System.Data.DataColumn tbInvoice_BillingReference_IssueDate;
        private System.Data.DataColumn tbInvoice_BillingReference_DocumentTypeCode;
        private System.Data.DataColumn tbInvoice_BillingReference_DocumentType;
    }
}