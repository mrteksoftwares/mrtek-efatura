using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrTEK_EFatura
{
    public static class EFaturaConvertor
    {
        public static Invoice Convert_UyumsoftToDBInvoice(Uyumsoft.InvoiceInfo uInvoiceInfo)
        {

            Uyumsoft.InvoiceType uInvoice = uInvoiceInfo.Invoice;
            //uInvoice.WithholdingTaxTotal[0].TaxSubtotal[0]

            Invoice dbInvoice = new Invoice();
            dbInvoice.IOType = 1;
            dbInvoice.IntCode = "";
            dbInvoice.LocalStatus = 0;
            dbInvoice.IntegratorID = uInvoice.UUID.Value;
            dbInvoice.Status = 0;
            dbInvoice.StatusDescription = "";
            dbInvoice.PostBox = uInvoiceInfo.TargetCustomer.Alias;
            dbInvoice.XsltNo = 0;
            dbInvoice.ProfileID = uInvoice.ProfileID.Value;
            dbInvoice.ID = uInvoice.ID.Value;
            dbInvoice.UUID = uInvoice.UUID.Value;
            dbInvoice.IssueDate = uInvoice.IssueDate.Value;
            dbInvoice.IssueTime = uInvoice.IssueTime != null ? FixIssueTime(uInvoice.IssueTime.Value) : (new DateTime(1900, 1, 1, 1, 0, 0));
            dbInvoice.InvoiceTypeCode = uInvoice.InvoiceTypeCode.Value;
            dbInvoice.DocumentCurrencyCode = uInvoice.DocumentCurrencyCode != null ? uInvoice.DocumentCurrencyCode.Value.ToString() : "TRY";
            dbInvoice.TaxCurrencyCode = uInvoice.TaxCurrencyCode != null ? UT.IfNull(uInvoice.TaxCurrencyCode.Value, dbInvoice.DocumentCurrencyCode).ToString() : dbInvoice.DocumentCurrencyCode;
            dbInvoice.PricingCurrencyCode = uInvoice.PricingCurrencyCode != null ? UT.IfNull(uInvoice.PricingCurrencyCode.Value, dbInvoice.DocumentCurrencyCode).ToString() : dbInvoice.DocumentCurrencyCode;

            dbInvoice.PaymentCurrencyCode = uInvoice.PaymentCurrencyCode != null ? UT.IfNull(uInvoice.PaymentCurrencyCode.Value, dbInvoice.DocumentCurrencyCode).ToString() : dbInvoice.DocumentCurrencyCode;
            dbInvoice.PaymentAlternativeCurrencyCode = uInvoice.PaymentAlternativeCurrencyCode != null ? UT.IfNull(uInvoice.PaymentAlternativeCurrencyCode.Value, dbInvoice.DocumentCurrencyCode).ToString() : dbInvoice.DocumentCurrencyCode;
            dbInvoice.LineCountNumeric = uInvoice.LineCountNumeric != null ? (int)uInvoice.LineCountNumeric.Value : 0;

            if (uInvoice.InvoicePeriod != null)
            {
                dbInvoice.InvoicePeriod_StartDate = uInvoice.InvoicePeriod.StartDate != null ? FixIssueTime(uInvoice.InvoicePeriod.StartDate.Value) : (new DateTime(1900, 1, 1));
                dbInvoice.InvoicePeriod_EndDate = FixIssueTime(uInvoice.InvoicePeriod.EndDate.Value);
            }

            if (uInvoice.Note != null)
            {
                if (uInvoice.Note.Length > 0)
                {
                    dbInvoice.Note = new Invoice_Note[uInvoice.Note.Length];
                    for (int i = 0; i < uInvoice.Note.Length; i++)
                    {
                        dbInvoice.Note[i] = new Invoice_Note();
                        dbInvoice.Note[i].Note = uInvoice.Note[i] != null ? UT.IfNull(uInvoice.Note[i].Value, "").ToString() : "";
                    }
                }
                if (uInvoice.InvoicePeriod != null)
                {
                    dbInvoice.InvoicePeriod_StartDate = uInvoice.InvoicePeriod.StartDate != null ? FixIssueTime(uInvoice.InvoicePeriod.StartDate.Value) : (new DateTime(1900, 1, 1));
                    dbInvoice.InvoicePeriod_EndDate = FixIssueTime(uInvoice.InvoicePeriod.EndDate.Value);
                }
                else
                {
                    dbInvoice.InvoicePeriod_StartDate = dbInvoice.IssueDate;
                    dbInvoice.InvoicePeriod_EndDate = dbInvoice.IssueDate;
                }

            }

            if (uInvoice.AccountingSupplierParty != null)
            {
                if (uInvoice.AccountingSupplierParty.Party != null)
                {
                    if (uInvoice.AccountingSupplierParty.Party != null)
                    {
                        if (uInvoice.AccountingSupplierParty.Party.PartyIdentification != null)
                        {
                            for (int i = 0; i < uInvoice.AccountingSupplierParty.Party.PartyIdentification.Length; i++)
                            {
                                switch (i)
                                {
                                    case 0:
                                        dbInvoice.ASP_PartyIdentification1_ID = uInvoice.AccountingSupplierParty.Party.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.PartyIdentification[i].ID.Value, "").ToString() : "";
                                        dbInvoice.ASP_PartyIdentification1_schemeID = uInvoice.AccountingSupplierParty.Party.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.PartyIdentification[i].ID.schemeID, "").ToString() : "";

                                        break;
                                    case 1:
                                        dbInvoice.ASP_PartyIdentification2_ID = uInvoice.AccountingSupplierParty.Party.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.PartyIdentification[i].ID.Value, "").ToString() : "";
                                        dbInvoice.ASP_PartyIdentification2_schemeID = uInvoice.AccountingSupplierParty.Party.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.PartyIdentification[i].ID.schemeID, "").ToString() : "";

                                        break;
                                    case 2:
                                        dbInvoice.ASP_PartyIdentification3_ID = uInvoice.AccountingSupplierParty.Party.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.PartyIdentification[i].ID.Value, "").ToString() : "";
                                        dbInvoice.ASP_PartyIdentification3_schemeID = uInvoice.AccountingSupplierParty.Party.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.PartyIdentification[i].ID.schemeID, "").ToString() : "";

                                        break;
                                    case 3:
                                        dbInvoice.ASP_PartyIdentification4_ID = uInvoice.AccountingSupplierParty.Party.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.PartyIdentification[i].ID.Value, "").ToString() : "";
                                        dbInvoice.ASP_PartyIdentification4_schemeID = uInvoice.AccountingSupplierParty.Party.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.PartyIdentification[i].ID.schemeID, "").ToString() : "";

                                        break;
                                    case 4:
                                        dbInvoice.ASP_PartyIdentification5_ID = uInvoice.AccountingSupplierParty.Party.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.PartyIdentification[i].ID.Value, "").ToString() : "";
                                        dbInvoice.ASP_PartyIdentification5_schemeID = uInvoice.AccountingSupplierParty.Party.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.PartyIdentification[i].ID.schemeID, "").ToString() : "";

                                        break;
                                }
                            }
                        }
                        dbInvoice.ASP_PartyName = uInvoice.AccountingSupplierParty.Party.PartyName.Name != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.PartyName.Name.Value, "").ToString() : "";
                        if (uInvoice.AccountingSupplierParty.Party.PostalAddress != null)
                        {
                            dbInvoice.ASP_PostalAddress_StreetName = uInvoice.AccountingSupplierParty.Party.PostalAddress.StreetName != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.PostalAddress.StreetName.Value, "").ToString() : "";
                            dbInvoice.ASP_PostalAddress_Room = uInvoice.AccountingSupplierParty.Party.PostalAddress.Room != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.PostalAddress.Room.Value, "").ToString() : "";
                            dbInvoice.ASP_PostalAddress_BuildingNumber = uInvoice.AccountingSupplierParty.Party.PostalAddress.BuildingNumber != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.PostalAddress.BuildingNumber.Value, "").ToString() : "";
                            dbInvoice.ASP_PostalAddress_BuildingName = uInvoice.AccountingSupplierParty.Party.PostalAddress.BuildingName != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.PostalAddress.BuildingName.Value, "").ToString() : "";
                            dbInvoice.ASP_PostalAddress_CitySubdivisionName = uInvoice.AccountingSupplierParty.Party.PostalAddress.CitySubdivisionName != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.PostalAddress.CitySubdivisionName.Value, "").ToString() : "";
                            dbInvoice.ASP_PostalAddress_CityName = uInvoice.AccountingSupplierParty.Party.PostalAddress.CityName != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.PostalAddress.CityName.Value, "").ToString() : "";
                            dbInvoice.ASP_PostalAddress_Country = uInvoice.AccountingSupplierParty.Party.PostalAddress.Country.Name != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.PostalAddress.Country.Name.Value, "").ToString() : "";

                        }
                        if (uInvoice.AccountingSupplierParty.Party.PartyTaxScheme != null)
                        {
                            if (uInvoice.AccountingSupplierParty.Party.PartyTaxScheme.TaxScheme != null)
                            {
                                dbInvoice.ASP_PartyTaxSchemeName = uInvoice.AccountingSupplierParty.Party.PartyTaxScheme.TaxScheme.Name != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.PartyTaxScheme.TaxScheme.Name.Value, "").ToString() : "";
                                dbInvoice.ASP_PartyTaxSchemeTaxTypeCode = uInvoice.AccountingSupplierParty.Party.PartyTaxScheme.TaxScheme.TaxTypeCode != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.PartyTaxScheme.TaxScheme.TaxTypeCode.Value, "").ToString() : "";
                            }
                        }
                        dbInvoice.ASP_WebsiteURI = uInvoice.AccountingSupplierParty.Party.WebsiteURI != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.WebsiteURI.Value, "").ToString() : "";

                        if (uInvoice.AccountingSupplierParty.Party.Contact != null)
                        {
                            dbInvoice.ASP_Contact_Telephone = uInvoice.AccountingSupplierParty.Party.Contact.Telephone != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.Contact.Telephone.Value, "").ToString() : "";
                            dbInvoice.ASP_Contact_Telefax = uInvoice.AccountingSupplierParty.Party.Contact.Telefax != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.Contact.Telefax.Value, "").ToString() : "";
                            dbInvoice.ASP_Contact_ElectronicMail = uInvoice.AccountingSupplierParty.Party.Contact.ElectronicMail != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.Contact.ElectronicMail.Value, "").ToString() : "";

                        }
                        if (uInvoice.AccountingSupplierParty.Party.Person != null)
                        {
                            dbInvoice.ASP_Person_FirstName = uInvoice.AccountingSupplierParty.Party.Person.FirstName != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.Person.FirstName.Value, "").ToString() : "";
                            dbInvoice.ASP_Person_FamilyName = uInvoice.AccountingSupplierParty.Party.Person.FamilyName != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.Person.FamilyName.Value, "").ToString() : "";
                            dbInvoice.ASP_Person_MiddleName = uInvoice.AccountingSupplierParty.Party.Person.MiddleName != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.Person.MiddleName.Value, "").ToString() : "";
                            dbInvoice.ASP_Person_NameSuffix = uInvoice.AccountingSupplierParty.Party.Person.NameSuffix != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.Person.NameSuffix.Value, "").ToString() : "";
                            dbInvoice.ASP_Person_Title = uInvoice.AccountingSupplierParty.Party.Person.Title != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.Person.Title.Value, "").ToString() : "";
                        }
                        if (uInvoice.AccountingSupplierParty.Party.AgentParty != null)
                        {
                            if (uInvoice.AccountingSupplierParty.Party.AgentParty.PartyIdentification != null)
                            {
                                for (int i = 0; i < uInvoice.AccountingSupplierParty.Party.AgentParty.PartyIdentification.Length; i++)
                                {
                                    switch (i)
                                    {
                                        case 0:
                                            dbInvoice.ASP_AgentParty_PartyIdentification1_ID = uInvoice.AccountingSupplierParty.Party.AgentParty.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.AgentParty.PartyIdentification[i].ID.Value, "").ToString() : "";
                                            dbInvoice.ASP_AgentParty_PartyIdentification1_schemeID = uInvoice.AccountingSupplierParty.Party.AgentParty.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.AgentParty.PartyIdentification[i].ID.schemeID, "").ToString() : "";

                                            break;
                                        case 1:
                                            dbInvoice.ASP_AgentParty_PartyIdentification2_ID = uInvoice.AccountingSupplierParty.Party.AgentParty.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.AgentParty.PartyIdentification[i].ID.Value, "").ToString() : "";
                                            dbInvoice.ASP_AgentParty_PartyIdentification2_schemeID = uInvoice.AccountingSupplierParty.Party.AgentParty.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.AgentParty.PartyIdentification[i].ID.schemeID, "").ToString() : "";

                                            break;
                                        case 2:
                                            dbInvoice.ASP_AgentParty_PartyIdentification3_ID = uInvoice.AccountingSupplierParty.Party.AgentParty.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.AgentParty.PartyIdentification[i].ID.Value, "").ToString() : "";
                                            dbInvoice.ASP_AgentParty_PartyIdentification3_schemeID = uInvoice.AccountingSupplierParty.Party.AgentParty.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.AgentParty.PartyIdentification[i].ID.schemeID, "").ToString() : "";

                                            break;
                                        case 3:
                                            dbInvoice.ASP_AgentParty_PartyIdentification4_ID = uInvoice.AccountingSupplierParty.Party.AgentParty.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.AgentParty.PartyIdentification[i].ID.Value, "").ToString() : "";
                                            dbInvoice.ASP_AgentParty_PartyIdentification4_schemeID = uInvoice.AccountingSupplierParty.Party.AgentParty.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.AgentParty.PartyIdentification[i].ID.schemeID, "").ToString() : "";

                                            break;
                                        case 4:
                                            dbInvoice.ASP_AgentParty_PartyIdentification5_ID = uInvoice.AccountingSupplierParty.Party.AgentParty.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.AgentParty.PartyIdentification[i].ID.Value, "").ToString() : "";
                                            dbInvoice.ASP_AgentParty_PartyIdentification5_schemeID = uInvoice.AccountingSupplierParty.Party.AgentParty.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.AgentParty.PartyIdentification[i].ID.schemeID, "").ToString() : "";

                                            break;
                                    }
                                }
                            }
                            if (uInvoice.AccountingSupplierParty.Party.AgentParty.PartyName != null)
                                dbInvoice.ASP_AgentParty_PartyName = uInvoice.AccountingSupplierParty.Party.AgentParty.PartyName.Name != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.AgentParty.PartyName.Name.Value, "").ToString() : "";
                            if (uInvoice.AccountingSupplierParty.Party.AgentParty.PostalAddress != null)
                            {
                                dbInvoice.ASP_AgentParty_PostalAddress_StreetName = uInvoice.AccountingSupplierParty.Party.AgentParty.PostalAddress.StreetName != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.AgentParty.PostalAddress.StreetName.Value, "").ToString() : "";
                                dbInvoice.ASP_AgentParty_PostalAddress_Room = uInvoice.AccountingSupplierParty.Party.AgentParty.PostalAddress.Room != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.AgentParty.PostalAddress.Room.Value, "").ToString() : "";
                                dbInvoice.ASP_AgentParty_PostalAddress_BuildingNumber = uInvoice.AccountingSupplierParty.Party.PostalAddress.BuildingNumber != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.PostalAddress.BuildingNumber.Value, "").ToString() : "";
                                dbInvoice.ASP_AgentParty_PostalAddress_BuildingName = uInvoice.AccountingSupplierParty.Party.PostalAddress.BuildingName != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.PostalAddress.BuildingName.Value, "").ToString() : "";
                                dbInvoice.ASP_AgentParty_PostalAddress_CitySubdivisionName = uInvoice.AccountingSupplierParty.Party.PostalAddress.CitySubdivisionName != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.PostalAddress.CitySubdivisionName.Value, "").ToString() : "";
                                dbInvoice.ASP_AgentParty_PostalAddress_CityName = uInvoice.AccountingSupplierParty.Party.PostalAddress.CityName != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.PostalAddress.CityName.Value, "").ToString() : "";
                                dbInvoice.ASP_AgentParty_PostalAddress_Country = uInvoice.AccountingSupplierParty.Party.PostalAddress.Country.Name != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.PostalAddress.Country.Name.Value, "").ToString() : "";

                            }
                            if (uInvoice.AccountingSupplierParty.Party.AgentParty.PartyTaxScheme != null)
                            {
                                if (uInvoice.AccountingSupplierParty.Party.AgentParty.PartyTaxScheme.TaxScheme != null)
                                {
                                    dbInvoice.ASP_AgentParty_PartyTaxSchemeName = uInvoice.AccountingSupplierParty.Party.AgentParty.PartyTaxScheme.TaxScheme.Name != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.AgentParty.PartyTaxScheme.TaxScheme.Name.Value, "").ToString() : "";
                                    dbInvoice.ASP_AgentParty_PartyTaxSchemeTaxTypeCode = uInvoice.AccountingSupplierParty.Party.AgentParty.PartyTaxScheme.TaxScheme.TaxTypeCode != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.AgentParty.PartyTaxScheme.TaxScheme.TaxTypeCode.Value, "").ToString() : "";
                                }

                            }
                            dbInvoice.ASP_AgentParty_WebsiteURI = uInvoice.AccountingSupplierParty.Party.AgentParty.WebsiteURI != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.AgentParty.WebsiteURI.Value, "").ToString() : "";

                            if (uInvoice.AccountingSupplierParty.Party.AgentParty.Contact != null)
                            {
                                dbInvoice.ASP_AgentParty_Contact_Telephone = uInvoice.AccountingSupplierParty.Party.AgentParty.Contact.Telephone != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.AgentParty.Contact.Telephone.Value, "").ToString() : "";
                                dbInvoice.ASP_AgentParty_Contact_Telefax = uInvoice.AccountingSupplierParty.Party.AgentParty.Contact.Telefax != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.AgentParty.Contact.Telefax.Value, "").ToString() : "";
                                dbInvoice.ASP_AgentParty_Contact_ElectronicMail = uInvoice.AccountingSupplierParty.Party.AgentParty.Contact.ElectronicMail != null ? UT.IfNull(uInvoice.AccountingSupplierParty.Party.AgentParty.Contact.ElectronicMail.Value, "").ToString() : "";
                            }
                        }
                    }
                }
            }

            //Customer party
            if (uInvoice.AccountingCustomerParty != null)
            {
                if (uInvoice.AccountingCustomerParty.Party != null)
                {
                    if (uInvoice.AccountingCustomerParty.Party != null)
                    {
                        if (uInvoice.AccountingCustomerParty.Party.PartyIdentification != null)
                        {
                            for (int i = 0; i < uInvoice.AccountingCustomerParty.Party.PartyIdentification.Length; i++)
                            {
                                switch (i)
                                {
                                    case 0:
                                        dbInvoice.ACP_PartyIdentification1_ID = uInvoice.AccountingCustomerParty.Party.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.PartyIdentification[i].ID.Value, "").ToString() : "";
                                        dbInvoice.ACP_PartyIdentification1_schemeID = uInvoice.AccountingCustomerParty.Party.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.PartyIdentification[i].ID.schemeID, "").ToString() : "";

                                        break;
                                    case 1:
                                        dbInvoice.ACP_PartyIdentification2_ID = uInvoice.AccountingCustomerParty.Party.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.PartyIdentification[i].ID.Value, "").ToString() : "";
                                        dbInvoice.ACP_PartyIdentification2_schemeID = uInvoice.AccountingCustomerParty.Party.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.PartyIdentification[i].ID.schemeID, "").ToString() : "";

                                        break;
                                    case 2:
                                        dbInvoice.ACP_PartyIdentification3_ID = uInvoice.AccountingCustomerParty.Party.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.PartyIdentification[i].ID.Value, "").ToString() : "";
                                        dbInvoice.ACP_PartyIdentification3_schemeID = uInvoice.AccountingCustomerParty.Party.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.PartyIdentification[i].ID.schemeID, "").ToString() : "";

                                        break;
                                    case 3:
                                        dbInvoice.ACP_PartyIdentification4_ID = uInvoice.AccountingCustomerParty.Party.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.PartyIdentification[i].ID.Value, "").ToString() : "";
                                        dbInvoice.ACP_PartyIdentification4_schemeID = uInvoice.AccountingCustomerParty.Party.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.PartyIdentification[i].ID.schemeID, "").ToString() : "";

                                        break;
                                    case 4:
                                        dbInvoice.ACP_PartyIdentification5_ID = uInvoice.AccountingCustomerParty.Party.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.PartyIdentification[i].ID.Value, "").ToString() : "";
                                        dbInvoice.ACP_PartyIdentification5_schemeID = uInvoice.AccountingCustomerParty.Party.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.PartyIdentification[i].ID.schemeID, "").ToString() : "";

                                        break;
                                }
                            }
                        }
                        dbInvoice.ACP_PartyName = uInvoice.AccountingCustomerParty.Party.PartyName.Name != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.PartyName.Name.Value, "").ToString() : "";
                        if (uInvoice.AccountingCustomerParty.Party.PostalAddress != null)
                        {
                            dbInvoice.ACP_PostalAddress_StreetName = uInvoice.AccountingCustomerParty.Party.PostalAddress.StreetName != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.PostalAddress.StreetName.Value, "").ToString() : "";
                            dbInvoice.ACP_PostalAddress_Room = uInvoice.AccountingCustomerParty.Party.PostalAddress.Room != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.PostalAddress.Room.Value, "").ToString() : "";
                            dbInvoice.ACP_PostalAddress_BuildingNumber = uInvoice.AccountingCustomerParty.Party.PostalAddress.BuildingNumber != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.PostalAddress.BuildingNumber.Value, "").ToString() : "";
                            dbInvoice.ACP_PostalAddress_BuildingName = uInvoice.AccountingCustomerParty.Party.PostalAddress.BuildingName != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.PostalAddress.BuildingName.Value, "").ToString() : "";
                            dbInvoice.ACP_PostalAddress_CitySubdivisionName = uInvoice.AccountingCustomerParty.Party.PostalAddress.CitySubdivisionName != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.PostalAddress.CitySubdivisionName.Value, "").ToString() : "";
                            dbInvoice.ACP_PostalAddress_CityName = uInvoice.AccountingCustomerParty.Party.PostalAddress.CityName != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.PostalAddress.CityName.Value, "").ToString() : "";
                            dbInvoice.ACP_PostalAddress_Country = uInvoice.AccountingCustomerParty.Party.PostalAddress.Country.Name != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.PostalAddress.Country.Name.Value, "").ToString() : "";


                        }
                        if (uInvoice.AccountingCustomerParty.Party.AgentParty != null)
                        {
                            if (uInvoice.AccountingCustomerParty.Party.AgentParty.PartyTaxScheme != null)
                            {
                                if (uInvoice.AccountingCustomerParty.Party.AgentParty.PartyTaxScheme.TaxScheme != null)
                                {
                                    dbInvoice.ACP_AgentParty_PartyTaxSchemeName = uInvoice.AccountingCustomerParty.Party.AgentParty.PartyTaxScheme.TaxScheme.Name != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.AgentParty.PartyTaxScheme.TaxScheme.Name.Value, "").ToString() : "";
                                    dbInvoice.ACP_AgentParty_PartyTaxSchemeTaxTypeCode = uInvoice.AccountingCustomerParty.Party.AgentParty.PartyTaxScheme.TaxScheme.TaxTypeCode != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.AgentParty.PartyTaxScheme.TaxScheme.TaxTypeCode.Value, "").ToString() : "";
                                }

                            }
                            dbInvoice.ACP_AgentParty_WebsiteURI = uInvoice.AccountingCustomerParty.Party.AgentParty.WebsiteURI != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.AgentParty.WebsiteURI.Value, "").ToString() : "";

                            if (uInvoice.AccountingCustomerParty.Party.Contact != null)
                            {
                                dbInvoice.ACP_Contact_Telephone = uInvoice.AccountingCustomerParty.Party.Contact.Telephone != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.Contact.Telephone.Value, "").ToString() : "";
                                dbInvoice.ACP_Contact_Telefax = uInvoice.AccountingCustomerParty.Party.Contact.Telefax != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.Contact.Telefax.Value, "").ToString() : "";
                                dbInvoice.ACP_Contact_ElectronicMail = uInvoice.AccountingCustomerParty.Party.Contact.ElectronicMail != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.Contact.ElectronicMail.Value, "").ToString() : "";

                            }
                            if (uInvoice.AccountingCustomerParty.Party.Person != null)
                            {
                                dbInvoice.ACP_Person_FirstName = uInvoice.AccountingCustomerParty.Party.Person.FirstName != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.Person.FirstName.Value, "").ToString() : "";
                                dbInvoice.ACP_Person_FamilyName = uInvoice.AccountingCustomerParty.Party.Person.FamilyName != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.Person.FamilyName.Value, "").ToString() : "";
                                dbInvoice.ACP_Person_MiddleName = uInvoice.AccountingCustomerParty.Party.Person.MiddleName != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.Person.MiddleName.Value, "").ToString() : "";
                                dbInvoice.ACP_Person_NameSuffix = uInvoice.AccountingCustomerParty.Party.Person.NameSuffix != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.Person.NameSuffix.Value, "").ToString() : "";
                                dbInvoice.ACP_Person_Title = uInvoice.AccountingCustomerParty.Party.Person.Title != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.Person.Title.Value, "").ToString() : "";
                            }
                            if (uInvoice.AccountingCustomerParty.Party.AgentParty != null)
                            {
                                if (uInvoice.AccountingCustomerParty.Party.AgentParty.PartyIdentification != null)
                                {
                                    for (int i = 0; i < uInvoice.AccountingCustomerParty.Party.AgentParty.PartyIdentification.Length; i++)
                                    {
                                        switch (i)
                                        {
                                            case 0:
                                                dbInvoice.ACP_AgentParty_PartyIdentification1_ID = uInvoice.AccountingCustomerParty.Party.AgentParty.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.AgentParty.PartyIdentification[i].ID.Value, "").ToString() : "";
                                                dbInvoice.ACP_AgentParty_PartyIdentification1_schemeID = uInvoice.AccountingCustomerParty.Party.AgentParty.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.AgentParty.PartyIdentification[i].ID.schemeID, "").ToString() : "";

                                                break;
                                            case 1:
                                                dbInvoice.ACP_AgentParty_PartyIdentification2_ID = uInvoice.AccountingCustomerParty.Party.AgentParty.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.AgentParty.PartyIdentification[i].ID.Value, "").ToString() : "";
                                                dbInvoice.ACP_AgentParty_PartyIdentification2_schemeID = uInvoice.AccountingCustomerParty.Party.AgentParty.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.AgentParty.PartyIdentification[i].ID.schemeID, "").ToString() : "";

                                                break;
                                            case 2:
                                                dbInvoice.ACP_AgentParty_PartyIdentification3_ID = uInvoice.AccountingCustomerParty.Party.AgentParty.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.AgentParty.PartyIdentification[i].ID.Value, "").ToString() : "";
                                                dbInvoice.ACP_AgentParty_PartyIdentification3_schemeID = uInvoice.AccountingCustomerParty.Party.AgentParty.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.AgentParty.PartyIdentification[i].ID.schemeID, "").ToString() : "";

                                                break;
                                            case 3:
                                                dbInvoice.ACP_AgentParty_PartyIdentification4_ID = uInvoice.AccountingCustomerParty.Party.AgentParty.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.AgentParty.PartyIdentification[i].ID.Value, "").ToString() : "";
                                                dbInvoice.ACP_AgentParty_PartyIdentification4_schemeID = uInvoice.AccountingCustomerParty.Party.AgentParty.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.AgentParty.PartyIdentification[i].ID.schemeID, "").ToString() : "";

                                                break;
                                            case 4:
                                                dbInvoice.ACP_AgentParty_PartyIdentification5_ID = uInvoice.AccountingCustomerParty.Party.AgentParty.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.AgentParty.PartyIdentification[i].ID.Value, "").ToString() : "";
                                                dbInvoice.ACP_AgentParty_PartyIdentification5_schemeID = uInvoice.AccountingCustomerParty.Party.AgentParty.PartyIdentification[i].ID != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.AgentParty.PartyIdentification[i].ID.schemeID, "").ToString() : "";

                                                break;
                                        }
                                    }
                                }
                                if (uInvoice.AccountingCustomerParty.Party.AgentParty.PartyName != null)
                                    dbInvoice.ACP_AgentParty_PartyName = uInvoice.AccountingCustomerParty.Party.AgentParty.PartyName.Name != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.AgentParty.PartyName.Name.Value, "").ToString() : "";
                                if (uInvoice.AccountingCustomerParty.Party.AgentParty.PostalAddress != null)
                                {
                                    dbInvoice.ACP_AgentParty_PostalAddress_StreetName = uInvoice.AccountingCustomerParty.Party.AgentParty.PostalAddress.StreetName != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.AgentParty.PostalAddress.StreetName.Value, "").ToString() : "";
                                    dbInvoice.ACP_AgentParty_PostalAddress_Room = uInvoice.AccountingCustomerParty.Party.AgentParty.PostalAddress.Room != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.AgentParty.PostalAddress.Room.Value, "").ToString() : "";
                                    dbInvoice.ACP_AgentParty_PostalAddress_BuildingNumber = uInvoice.AccountingCustomerParty.Party.PostalAddress.BuildingNumber != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.PostalAddress.BuildingNumber.Value, "").ToString() : "";
                                    dbInvoice.ACP_AgentParty_PostalAddress_BuildingName = uInvoice.AccountingCustomerParty.Party.PostalAddress.BuildingName != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.PostalAddress.BuildingName.Value, "").ToString() : "";
                                    dbInvoice.ACP_AgentParty_PostalAddress_CitySubdivisionName = uInvoice.AccountingCustomerParty.Party.PostalAddress.CitySubdivisionName != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.PostalAddress.CitySubdivisionName.Value, "").ToString() : "";
                                    dbInvoice.ACP_AgentParty_PostalAddress_CityName = uInvoice.AccountingCustomerParty.Party.PostalAddress.CityName != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.PostalAddress.CityName.Value, "").ToString() : "";
                                    dbInvoice.ACP_AgentParty_PostalAddress_Country = uInvoice.AccountingCustomerParty.Party.PostalAddress.Country.Name != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.PostalAddress.Country.Name.Value, "").ToString() : "";

                                }
                                if (uInvoice.AccountingCustomerParty.Party.AgentParty.PartyTaxScheme != null)
                                {
                                    if (uInvoice.AccountingCustomerParty.Party.AgentParty.PartyTaxScheme.TaxScheme != null)
                                    {
                                        dbInvoice.ACP_AgentParty_PartyTaxSchemeName = uInvoice.AccountingCustomerParty.Party.AgentParty.PartyTaxScheme.TaxScheme.Name != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.AgentParty.PartyTaxScheme.TaxScheme.Name.Value, "").ToString() : "";
                                        dbInvoice.ACP_AgentParty_PartyTaxSchemeTaxTypeCode = uInvoice.AccountingCustomerParty.Party.AgentParty.PartyTaxScheme.TaxScheme.TaxTypeCode != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.AgentParty.PartyTaxScheme.TaxScheme.TaxTypeCode.Value, "").ToString() : "";
                                    }

                                }
                                dbInvoice.ACP_AgentParty_WebsiteURI = uInvoice.AccountingCustomerParty.Party.AgentParty.WebsiteURI != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.AgentParty.WebsiteURI.Value, "").ToString() : "";

                                if (uInvoice.AccountingCustomerParty.Party.AgentParty.Contact != null)
                                {
                                    dbInvoice.ACP_AgentParty_Contact_Telephone = uInvoice.AccountingCustomerParty.Party.AgentParty.Contact.Telephone != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.AgentParty.Contact.Telephone.Value, "").ToString() : "";
                                    dbInvoice.ACP_AgentParty_Contact_Telefax = uInvoice.AccountingCustomerParty.Party.AgentParty.Contact.Telefax != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.AgentParty.Contact.Telefax.Value, "").ToString() : "";
                                    dbInvoice.ACP_AgentParty_Contact_ElectronicMail = uInvoice.AccountingCustomerParty.Party.AgentParty.Contact.ElectronicMail != null ? UT.IfNull(uInvoice.AccountingCustomerParty.Party.AgentParty.Contact.ElectronicMail.Value, "").ToString() : "";
                                }
                            }
                        }
                    }
                }
            }




            if (uInvoice.TaxExchangeRate != null)
            {
                dbInvoice.TaxExchangeRate_SourceCurrencyCode = uInvoice.TaxExchangeRate.SourceCurrencyCode != null ? UT.IfNull(uInvoice.TaxExchangeRate.SourceCurrencyCode.Value, "TRY").ToString() : "TRY";
                dbInvoice.TaxExchangeRate_TargetCurrencyCode = uInvoice.TaxExchangeRate.TargetCurrencyCode != null ? UT.IfNull(uInvoice.TaxExchangeRate.TargetCurrencyCode.Value, "TRY").ToString() : "TRY";
                dbInvoice.TaxExchangeRate_CalculationRate = uInvoice.TaxExchangeRate.CalculationRate != null ? UT.If0Null(uInvoice.TaxExchangeRate.CalculationRate.Value) : 0;
                dbInvoice.TaxExchangeRate_Date = uInvoice.TaxExchangeRate.Date != null ? (DateTime)UT.IfNull(uInvoice.TaxExchangeRate.Date.Value, (new DateTime(1900, 1, 1))) : (new DateTime(1900, 1, 1));

            }
            if (uInvoice.PricingExchangeRate != null)
            {
                dbInvoice.PricingExchangeRate_SourceCurrencyCode = uInvoice.PricingExchangeRate.SourceCurrencyCode != null ? UT.IfNull(uInvoice.PricingExchangeRate.SourceCurrencyCode.Value, "TRY").ToString() : "TRY";
                dbInvoice.PricingExchangeRate_TargetCurrencyCode = uInvoice.PricingExchangeRate.TargetCurrencyCode != null ? UT.IfNull(uInvoice.PricingExchangeRate.TargetCurrencyCode.Value, "TRY").ToString() : "TRY";
                dbInvoice.PricingExchangeRate_CalculationRate = uInvoice.PricingExchangeRate.CalculationRate != null ? UT.If0Null(uInvoice.PricingExchangeRate.CalculationRate.Value) : 0;
                dbInvoice.PricingExchangeRate_Date = uInvoice.PricingExchangeRate.Date != null ? (DateTime)UT.IfNull(uInvoice.PricingExchangeRate.Date.Value, (new DateTime(1900, 1, 1))) : (new DateTime(1900, 1, 1));
            }
            if (uInvoice.PaymentExchangeRate != null)
            {
                dbInvoice.PaymentExchangeRate_SourceCurrencyCode = uInvoice.PaymentExchangeRate.SourceCurrencyCode != null ? UT.IfNull(uInvoice.PaymentExchangeRate.SourceCurrencyCode.Value, "TRY").ToString() : "TRY";
                dbInvoice.PaymentExchangeRate_TargetCurrencyCode = uInvoice.PaymentExchangeRate.TargetCurrencyCode != null ? UT.IfNull(uInvoice.PaymentExchangeRate.TargetCurrencyCode.Value, "TRY").ToString() : "TRY";
                dbInvoice.PaymentExchangeRate_CalculationRate = uInvoice.PaymentExchangeRate.CalculationRate != null ? UT.If0Null(uInvoice.PaymentExchangeRate.CalculationRate.Value) : 0;
                dbInvoice.PaymentExchangeRate_Date = uInvoice.PaymentExchangeRate.Date != null ? (DateTime)UT.IfNull(uInvoice.PaymentExchangeRate.Date.Value, (new DateTime(1900, 1, 1))) : (new DateTime(1900, 1, 1));

            }
            if (uInvoice.PaymentAlternativeExchangeRate != null)
            {
                dbInvoice.PaymentAlternativeExchangeRate_SourceCurrencyCode = uInvoice.PaymentAlternativeExchangeRate.SourceCurrencyCode != null ? UT.IfNull(uInvoice.PaymentAlternativeExchangeRate.SourceCurrencyCode.Value, "TRY").ToString() : "TRY";
                dbInvoice.PaymentAlternativeExchangeRate_TargetCurrencyCode = uInvoice.PaymentAlternativeExchangeRate.TargetCurrencyCode != null ? UT.IfNull(uInvoice.PaymentAlternativeExchangeRate.TargetCurrencyCode.Value, "TRY").ToString() : "TRY";
                dbInvoice.PaymentAlternativeExchangeRate_CalculationRate = uInvoice.PaymentAlternativeExchangeRate.CalculationRate != null ? UT.If0Null(uInvoice.PaymentAlternativeExchangeRate.CalculationRate.Value) : 0;
                dbInvoice.PaymentAlternativeExchangeRate_Date = uInvoice.PaymentAlternativeExchangeRate.Date != null ? (DateTime)UT.IfNull(uInvoice.PaymentAlternativeExchangeRate.Date.Value, (new DateTime(1900, 1, 1))) : (new DateTime(1900, 1, 1));

            }

            //dbInvoice.TaxAmount    //qwerty
            if (uInvoice.LegalMonetaryTotal != null)
            {
                dbInvoice.LegalMonetaryTotal_LineExtensionAmount = uInvoice.LegalMonetaryTotal.LineExtensionAmount != null ? UT.If0Null(uInvoice.LegalMonetaryTotal.LineExtensionAmount.Value) : 0;
                dbInvoice.LegalMonetaryTotal_TaxExclusiveAmount = uInvoice.LegalMonetaryTotal.TaxExclusiveAmount != null ? UT.If0Null(uInvoice.LegalMonetaryTotal.TaxExclusiveAmount.Value) : 0;
                dbInvoice.LegalMonetaryTotal_TaxInclusiveAmount = uInvoice.LegalMonetaryTotal.TaxInclusiveAmount != null ? UT.If0Null(uInvoice.LegalMonetaryTotal.TaxInclusiveAmount.Value) : 0;
                dbInvoice.LegalMonetaryTotal_AllowanceTotalAmount = uInvoice.LegalMonetaryTotal.AllowanceTotalAmount != null ? UT.If0Null(uInvoice.LegalMonetaryTotal.AllowanceTotalAmount.Value) : 0;
                dbInvoice.LegalMonetaryTotal_PayableRoundingAmount = uInvoice.LegalMonetaryTotal.PayableRoundingAmount != null ? UT.If0Null(uInvoice.LegalMonetaryTotal.PayableRoundingAmount.Value) : 0;
                dbInvoice.LegalMonetaryTotal_PayableAmount = uInvoice.LegalMonetaryTotal.PayableAmount != null ? UT.If0Null(uInvoice.LegalMonetaryTotal.PayableAmount.Value) : 0;
            }


            // INVOICE . TAX SUB TOTAL

            if (uInvoice.TaxTotal != null)
            {
                if (uInvoice.TaxTotal.Length > 0)
                {
                    dbInvoice.TaxAmount = UT.If0Null(uInvoice.TaxTotal[0].TaxAmount.Value);
                    if (uInvoice.TaxTotal[0].TaxSubtotal.Length > 0)
                    {
                        dbInvoice.TaxSubtotal = new Invoice_TaxSubtotal[uInvoice.TaxTotal[0].TaxSubtotal.Length];
                        for (int i = 0; i < uInvoice.TaxTotal[0].TaxSubtotal.Length; i++)
                        {
                            dbInvoice.TaxSubtotal[i] = new Invoice_TaxSubtotal();
                            dbInvoice.TaxSubtotal[i].TaxableAmount = uInvoice.TaxTotal[0].TaxSubtotal[i].TaxableAmount != null ? UT.If0Null(uInvoice.TaxTotal[0].TaxSubtotal[i].TaxableAmount.Value) : 0;
                            dbInvoice.TaxSubtotal[i].TaxAmount = uInvoice.TaxTotal[0].TaxSubtotal[i].TaxAmount != null ? UT.If0Null(uInvoice.TaxTotal[0].TaxSubtotal[i].TaxAmount.Value) : 0;
                            dbInvoice.TaxSubtotal[i].Percent_ = uInvoice.TaxTotal[0].TaxSubtotal[i].Percent != null ? UT.If0Null(uInvoice.TaxTotal[0].TaxSubtotal[i].Percent.Value) : 0;
                            if (uInvoice.TaxTotal[0].TaxSubtotal[i].TaxCategory != null)
                            {
                                if (uInvoice.TaxTotal[0].TaxSubtotal[i].TaxCategory.TaxScheme != null)
                                {
                                    dbInvoice.TaxSubtotal[i].TaxCategory_TaxScheme_Name = uInvoice.TaxTotal[0].TaxSubtotal[i].TaxCategory.TaxScheme.Name != null ? UT.IfNull(uInvoice.TaxTotal[0].TaxSubtotal[i].TaxCategory.TaxScheme.Name.Value, "").ToString() : "";
                                    dbInvoice.TaxSubtotal[i].TaxCategory_TaxScheme_TaxTypeCode = uInvoice.TaxTotal[0].TaxSubtotal[i].TaxCategory.TaxScheme.TaxTypeCode != null ? UT.IfNull(uInvoice.TaxTotal[0].TaxSubtotal[i].TaxCategory.TaxScheme.TaxTypeCode.Value, "").ToString() : "";
                                }
                                dbInvoice.TaxSubtotal[i].TaxCategory_TaxExemptionReason = uInvoice.TaxTotal[0].TaxSubtotal[i].TaxCategory.TaxExemptionReason != null ? UT.IfNull(uInvoice.TaxTotal[0].TaxSubtotal[i].TaxCategory.TaxExemptionReason.Value, "").ToString() : "";

                            }
                            dbInvoice.TaxSubtotal[i].CalculationSequenceNumeric = uInvoice.TaxTotal[0].TaxSubtotal[i].CalculationSequenceNumeric != null ? (int)UT.If0Null(uInvoice.TaxTotal[0].TaxSubtotal[i].CalculationSequenceNumeric.Value) : 0;
                            dbInvoice.TaxSubtotal[i].currencyID = uInvoice.TaxTotal[0].TaxSubtotal[i].TaxAmount != null ? UT.IfNull(uInvoice.TaxTotal[0].TaxSubtotal[i].TaxAmount.currencyID, "TRY").ToString() : "TRY";
                            dbInvoice.TaxSubtotal[i].PerUnitAmount = uInvoice.TaxTotal[0].TaxSubtotal[i].PerUnitAmount != null ? UT.If0Null(uInvoice.TaxTotal[0].TaxSubtotal[i].PerUnitAmount.Value) : 0;


                        }
                    }
                }
            }
            //---------------------
            if (uInvoice.WithholdingTaxTotal != null)
            {
                if (uInvoice.WithholdingTaxTotal.Length > 0)
                {
                    dbInvoice.WithholdingTaxAmount = UT.If0Null(uInvoice.WithholdingTaxTotal[0].TaxAmount.Value);
                    if (uInvoice.WithholdingTaxTotal[0].TaxSubtotal.Length > 0)
                    {
                        dbInvoice.WithholdingTaxSubtotal = new Invoice_WithholdingTaxSubtotal[uInvoice.WithholdingTaxTotal[0].TaxSubtotal.Length];
                        for (int i = 0; i < uInvoice.WithholdingTaxTotal[0].TaxSubtotal.Length; i++)
                        {
                            dbInvoice.WithholdingTaxSubtotal[i] = new Invoice_WithholdingTaxSubtotal();
                            dbInvoice.WithholdingTaxSubtotal[i].TaxableAmount = uInvoice.WithholdingTaxTotal[0].TaxSubtotal[i].TaxableAmount != null ? UT.If0Null(uInvoice.WithholdingTaxTotal[0].TaxSubtotal[i].TaxableAmount.Value) : 0;
                            dbInvoice.WithholdingTaxSubtotal[i].TaxAmount = uInvoice.WithholdingTaxTotal[0].TaxSubtotal[i].TaxAmount != null ? UT.If0Null(uInvoice.WithholdingTaxTotal[0].TaxSubtotal[i].TaxAmount.Value) : 0;
                            dbInvoice.WithholdingTaxSubtotal[i].Percent_ = uInvoice.WithholdingTaxTotal[0].TaxSubtotal[i].Percent != null ? UT.If0Null(uInvoice.WithholdingTaxTotal[0].TaxSubtotal[i].Percent.Value) : 0;
                            if (uInvoice.WithholdingTaxTotal[0].TaxSubtotal[i].TaxCategory != null)
                            {
                                if (uInvoice.WithholdingTaxTotal[0].TaxSubtotal[i].TaxCategory.TaxScheme != null)
                                {
                                    dbInvoice.WithholdingTaxSubtotal[i].TaxCategory_TaxScheme_Name = uInvoice.WithholdingTaxTotal[0].TaxSubtotal[i].TaxCategory.TaxScheme.Name != null ? UT.IfNull(uInvoice.WithholdingTaxTotal[0].TaxSubtotal[i].TaxCategory.TaxScheme.Name.Value, "").ToString() : "";
                                    dbInvoice.WithholdingTaxSubtotal[i].TaxCategory_TaxScheme_TaxTypeCode = uInvoice.WithholdingTaxTotal[0].TaxSubtotal[i].TaxCategory.TaxScheme.TaxTypeCode != null ? UT.IfNull(uInvoice.WithholdingTaxTotal[0].TaxSubtotal[i].TaxCategory.TaxScheme.TaxTypeCode.Value, "").ToString() : "";
                                }
                                dbInvoice.WithholdingTaxSubtotal[i].TaxCategory_TaxExemptionReason = uInvoice.WithholdingTaxTotal[0].TaxSubtotal[i].TaxCategory.TaxExemptionReason != null ? UT.IfNull(uInvoice.WithholdingTaxTotal[0].TaxSubtotal[i].TaxCategory.TaxExemptionReason.Value, "").ToString() : "";

                            }
                            dbInvoice.WithholdingTaxSubtotal[i].CalculationSequenceNumeric = uInvoice.WithholdingTaxTotal[0].TaxSubtotal[i].CalculationSequenceNumeric != null ? (int)UT.If0Null(uInvoice.WithholdingTaxTotal[0].TaxSubtotal[i].CalculationSequenceNumeric.Value) : 0;
                            dbInvoice.WithholdingTaxSubtotal[i].currencyID = uInvoice.WithholdingTaxTotal[0].TaxSubtotal[i].TaxAmount != null ? UT.IfNull(uInvoice.WithholdingTaxTotal[0].TaxSubtotal[i].TaxAmount.currencyID, "TRY").ToString() : "TRY";
                            dbInvoice.WithholdingTaxSubtotal[i].PerUnitAmount = uInvoice.WithholdingTaxTotal[0].TaxSubtotal[i].PerUnitAmount != null ? UT.If0Null(uInvoice.WithholdingTaxTotal[0].TaxSubtotal[i].PerUnitAmount.Value) : 0;

                        }
                    }
                }
            }
            //---------------------
            if (uInvoice.OrderReference != null)
            {
                dbInvoice.OrderReference = new Invoice_OrderReference[1];
                dbInvoice.OrderReference[0] = new Invoice_OrderReference();
                dbInvoice.OrderReference[0].ID = uInvoice.OrderReference.ID != null ? UT.IfNull(uInvoice.OrderReference.ID.Value, "").ToString() : "";
                dbInvoice.OrderReference[0].IssueDate = uInvoice.OrderReference.IssueDate != null ? (DateTime)UT.IfNull(uInvoice.OrderReference.IssueDate.Value, (new DateTime(1900, 1, 1))) : (new DateTime(1900, 1, 1));
            }
            if (uInvoice.AllowanceCharge != null)
            {
                if (uInvoice.AllowanceCharge != null)
                {
                    dbInvoice.AllowanceCharge = new Invoice_AllowanceCharge[uInvoice.AllowanceCharge.Length];
                    for (int i = 0; i < uInvoice.AllowanceCharge.Length; i++)
                    {
                        dbInvoice.AllowanceCharge[i] = new Invoice_AllowanceCharge();

                        dbInvoice.AllowanceCharge[i].AllowanceChargeReason = uInvoice.AllowanceCharge[i].AllowanceChargeReason != null ? UT.IfNull(uInvoice.AllowanceCharge[i].AllowanceChargeReason.Value, "").ToString() : "";
                        dbInvoice.AllowanceCharge[i].Amount = uInvoice.AllowanceCharge[i].Amount != null ? UT.If0Null(uInvoice.AllowanceCharge[i].Amount.Value) : 0;
                        dbInvoice.AllowanceCharge[i].Amount_currencyID = uInvoice.AllowanceCharge[i].Amount != null ? UT.IfNull(uInvoice.AllowanceCharge[i].Amount.currencyID, "TRY").ToString() : "TRY";
                        dbInvoice.AllowanceCharge[i].BaseAmount = uInvoice.AllowanceCharge[i].BaseAmount != null ? UT.If0Null(uInvoice.AllowanceCharge[i].BaseAmount.Value) : 0;
                        dbInvoice.AllowanceCharge[i].BaseAmount_currencyID = uInvoice.AllowanceCharge[i].BaseAmount != null ? UT.IfNull(uInvoice.AllowanceCharge[i].BaseAmount.currencyID, "TRY").ToString() : "TRY";
                        dbInvoice.AllowanceCharge[i].ChargeIndicator = uInvoice.AllowanceCharge[i].ChargeIndicator != null ? (bool)UT.IfNull(uInvoice.AllowanceCharge[i].ChargeIndicator.Value, false) : false;
                        dbInvoice.AllowanceCharge[i].MultiplierFactorNumeric = uInvoice.AllowanceCharge[i].MultiplierFactorNumeric != null ? UT.If0Null(uInvoice.AllowanceCharge[i].MultiplierFactorNumeric.Value) : 0;
                    }

                }
                else
                {
                    dbInvoice.AllowanceCharge = new Invoice_AllowanceCharge[1];
                    dbInvoice.AllowanceCharge[0] = new Invoice_AllowanceCharge();
                }

            }
            if (uInvoice.DespatchDocumentReference != null)
            {
                if (uInvoice.DespatchDocumentReference.Length > 0)
                {
                    dbInvoice.DespatchDocumentReference = new Invoice_DespatchDocumentReference[uInvoice.DespatchDocumentReference.Length];
                    for (int i = 0; i < uInvoice.DespatchDocumentReference.Length; i++)
                    {
                        dbInvoice.DespatchDocumentReference[i] = new Invoice_DespatchDocumentReference();
                        dbInvoice.DespatchDocumentReference[i].ID = uInvoice.DespatchDocumentReference[i].ID != null ? UT.IfNull(uInvoice.DespatchDocumentReference[i].ID.Value, "").ToString() : "";
                        dbInvoice.DespatchDocumentReference[i].IssueDate = uInvoice.DespatchDocumentReference[i].ID != null ? (DateTime)UT.IfNull(uInvoice.DespatchDocumentReference[i].IssueDate.Value, (new DateTime(1900, 1, 1))) : (new DateTime(1900, 1, 1));

                    }
                }
            }

            // Additional document koymadik. Lazim degil sanki
            //if (uInvoice.AdditionalDocumentReference != null)
            //{
            //    if (uInvoice.AdditionalDocumentReference.Length > 0)
            //    {

            //    }
            //}
            if (uInvoice.PaymentMeans != null)
            {
                if (uInvoice.PaymentMeans.Length > 0)
                {
                    dbInvoice.PaymentMeans = new Invoice_PaymentMeans[uInvoice.PaymentMeans.Length];
                    for (int i = 0; i < uInvoice.PaymentMeans.Length; i++)
                    {
                        dbInvoice.PaymentMeans[i] = new Invoice_PaymentMeans();
                        dbInvoice.PaymentMeans[i].PaymentChannelCode = uInvoice.PaymentMeans[i].PaymentChannelCode != null ? UT.IfNull(uInvoice.PaymentMeans[i].PaymentChannelCode.Value, "").ToString() : "";
                        dbInvoice.PaymentMeans[i].PaymentMeansCode = uInvoice.PaymentMeans[i].PaymentMeansCode != null ? UT.IfNull(uInvoice.PaymentMeans[i].PaymentMeansCode.Value, "").ToString() : "";
                        dbInvoice.PaymentMeans[i].PaymentDueDate = uInvoice.PaymentMeans[i].PaymentDueDate != null ? (DateTime)UT.IfNull(uInvoice.PaymentMeans[i].PaymentDueDate.Value, (new DateTime(1900, 1, 1))) : (new DateTime(1900, 1, 1));
                        dbInvoice.PaymentMeans[i].InstructionNote = uInvoice.PaymentMeans[i].InstructionNote != null ? UT.IfNull(uInvoice.PaymentMeans[i].InstructionNote.Value, "").ToString() : "";
                        if (uInvoice.PaymentMeans[i].PayeeFinancialAccount != null)
                        {
                            dbInvoice.PaymentMeans[i].PayeeFinancialAccount_ID = uInvoice.PaymentMeans[i].PayeeFinancialAccount.ID != null ? UT.IfNull(uInvoice.PaymentMeans[i].PayeeFinancialAccount.ID.Value, "").ToString() : "";
                            dbInvoice.PaymentMeans[i].PayeeFinancialAccount_PaymentNote = uInvoice.PaymentMeans[i].PayeeFinancialAccount.PaymentNote != null ? UT.IfNull(uInvoice.PaymentMeans[i].PayeeFinancialAccount.PaymentNote.Value, "").ToString() : "";
                            dbInvoice.PaymentMeans[i].PayeeFinancialAccount_CurrencyCode = UT.IfNull(uInvoice.PaymentMeans[i].PayeeFinancialAccount.CurrencyCode, "TRY").ToString();
                        }
                    }
                }
            }

            if (uInvoice.PaymentTerms != null)
            {
                dbInvoice.PaymentTerms = new Invoice_PaymentTerms[1];
                dbInvoice.PaymentTerms[0] = new Invoice_PaymentTerms();
                dbInvoice.PaymentTerms[0].Amount = uInvoice.PaymentTerms.Amount != null ? UT.If0Null(uInvoice.PaymentTerms.Amount.Value) : 0;
                dbInvoice.PaymentTerms[0].Amount_currencyID = uInvoice.PaymentTerms.Amount != null ? UT.IfNull(uInvoice.PaymentTerms.Amount.currencyID, "TRY").ToString() : "TRY";
                dbInvoice.PaymentTerms[0].Note = uInvoice.PaymentTerms.Note != null ? UT.IfNull(uInvoice.PaymentTerms.Note.Value, "").ToString() : "";
                dbInvoice.PaymentTerms[0].PenaltySurchargePercent = uInvoice.PaymentTerms.PenaltySurchargePercent != null ? UT.If0Null(uInvoice.PaymentTerms.PenaltySurchargePercent.Value) : 0;
            }

            if (uInvoice.InvoiceLine != null)
            {
                if (uInvoice.InvoiceLine.Length > 0)
                {
                    dbInvoice.InvoiceLine = new InvoiceLine[uInvoice.InvoiceLine.Length];
                    for (int i = 0; i < uInvoice.InvoiceLine.Length; i++)
                    {
                        dbInvoice.InvoiceLine[i] = new InvoiceLine();
                        dbInvoice.InvoiceLine[i].ID = uInvoice.InvoiceLine[i].ID != null ? UT.IfNull(uInvoice.InvoiceLine[i].ID.Value, "").ToString() : "";
                        dbInvoice.InvoiceLine[i].InvoicedQuantity = uInvoice.InvoiceLine[i].InvoicedQuantity != null ? UT.If0Null(uInvoice.InvoiceLine[i].InvoicedQuantity.Value) : 0;
                        dbInvoice.InvoiceLine[i].InvoicedQuantity_unitCode = uInvoice.InvoiceLine[i].InvoicedQuantity != null ? UT.IfNull(uInvoice.InvoiceLine[i].InvoicedQuantity.unitCode, "NIU").ToString() : "NIU";
                        if (uInvoice.InvoiceLine[i].Item != null)
                        {
                            dbInvoice.InvoiceLine[i].Item_Name = uInvoice.InvoiceLine[i].Item.Name != null ? UT.IfNull(uInvoice.InvoiceLine[i].Item.Name.Value, "").ToString() : "";
                            dbInvoice.InvoiceLine[i].Item_ModelName = uInvoice.InvoiceLine[i].Item.ModelName != null ? UT.IfNull(uInvoice.InvoiceLine[i].Item.ModelName.Value, "").ToString() : "";
                            dbInvoice.InvoiceLine[i].Item_Description = uInvoice.InvoiceLine[i].Item.Description != null ? UT.IfNull(uInvoice.InvoiceLine[i].Item.Description.Value, "").ToString() : "";
                            dbInvoice.InvoiceLine[i].Item_BrandName = uInvoice.InvoiceLine[i].Item.BrandName != null ? UT.IfNull(uInvoice.InvoiceLine[i].Item.BrandName.Value, "").ToString() : "";
                            if (uInvoice.InvoiceLine[i].Item.BuyersItemIdentification != null)
                            {
                                dbInvoice.InvoiceLine[i].Item_BuyersItemIdentification_ID = uInvoice.InvoiceLine[i].Item.BuyersItemIdentification.ID != null ? UT.IfNull(uInvoice.InvoiceLine[i].Item.BuyersItemIdentification.ID.Value, "").ToString() : "";

                            }
                            if (uInvoice.InvoiceLine[i].Item.SellersItemIdentification != null)
                            {
                                dbInvoice.InvoiceLine[i].Item_SellersItemIdentification_ID = uInvoice.InvoiceLine[i].Item.SellersItemIdentification.ID != null ? UT.IfNull(uInvoice.InvoiceLine[i].Item.SellersItemIdentification.ID.Value, "").ToString() : "";

                            }
                            if (uInvoice.InvoiceLine[i].Item.ManufacturersItemIdentification != null)
                            {
                                dbInvoice.InvoiceLine[i].Item_ManufacturersItemIdentification_ID = uInvoice.InvoiceLine[i].Item.ManufacturersItemIdentification.ID != null ? UT.IfNull(uInvoice.InvoiceLine[i].Item.ManufacturersItemIdentification.ID.Value, "").ToString() : "";

                            }
                            if (uInvoice.InvoiceLine[i].Item.CommodityClassification != null)
                            {
                                if (uInvoice.InvoiceLine[i].Item.CommodityClassification.Length > 0)
                                {
                                    dbInvoice.InvoiceLine[i].Item_ItemClassificationCode = uInvoice.InvoiceLine[i].Item.CommodityClassification[0].ItemClassificationCode != null ? UT.IfNull(uInvoice.InvoiceLine[i].Item.CommodityClassification[0].ItemClassificationCode.Value, "").ToString() : "";
                                }

                            }
                        }

                        dbInvoice.InvoiceLine[i].LineExtensionAmount = uInvoice.InvoiceLine[i].LineExtensionAmount == null ? 0 : UT.If0Null(uInvoice.InvoiceLine[i].LineExtensionAmount.Value);
                        if (uInvoice.InvoiceLine[i].AllowanceCharge != null)
                        {
                            if (uInvoice.InvoiceLine[i].AllowanceCharge.Length > 0)
                            {
                                dbInvoice.InvoiceLine[i].AllowanceCharge_AllowanceChargeReason = uInvoice.InvoiceLine[i].AllowanceCharge[0].AllowanceChargeReason != null ? UT.IfNull(uInvoice.InvoiceLine[i].AllowanceCharge[0].AllowanceChargeReason.Value, "").ToString() : "";
                                dbInvoice.InvoiceLine[i].AllowanceCharge_Amount = 0;
                                dbInvoice.InvoiceLine[i].AllowanceCharge_BaseAmount = uInvoice.InvoiceLine[i].AllowanceCharge[0].BaseAmount != null ? UT.If0Null(uInvoice.InvoiceLine[i].AllowanceCharge[0].BaseAmount.Value) : 0;
                                dbInvoice.InvoiceLine[i].AllowanceCharge_ChargeIndicator = uInvoice.InvoiceLine[i].AllowanceCharge[0].ChargeIndicator != null ? (bool)UT.IfNull(uInvoice.InvoiceLine[i].AllowanceCharge[0].ChargeIndicator.Value, false) : false;
                                for (int j = 0; j < uInvoice.InvoiceLine[i].AllowanceCharge.Length; j++)
                                {
                                    dbInvoice.InvoiceLine[i].AllowanceCharge_Amount += uInvoice.InvoiceLine[i].AllowanceCharge[0].Amount != null ? UT.If0Null(uInvoice.InvoiceLine[i].AllowanceCharge[j].Amount.Value) : 0;
                                }
                            }

                        }
                        if (uInvoice.InvoiceLine[i].Note != null)
                        {
                            if (uInvoice.InvoiceLine[i].Note.Length > 0)
                            {
                                for (int j = 0; j < uInvoice.InvoiceLine[i].Note.Length; j++)
                                {
                                    dbInvoice.InvoiceLine[i].Note += (uInvoice.InvoiceLine[i].Note[j] != null ? UT.IfNull(uInvoice.InvoiceLine[i].Note[j].Value, "").ToString() : "") + " ";
                                }

                            }
                        }

                        if (uInvoice.InvoiceLine[i].Price != null)
                        {
                            dbInvoice.InvoiceLine[i].PriceAmount = uInvoice.InvoiceLine[i].Price.PriceAmount != null ? UT.If0Null(uInvoice.InvoiceLine[i].Price.PriceAmount.Value) : 0;
                            dbInvoice.InvoiceLine[i].currencyID = uInvoice.InvoiceLine[i].Price.PriceAmount != null ? UT.IfNull(uInvoice.InvoiceLine[i].Price.PriceAmount.currencyID, "TRY").ToString() : "TRY";
                        }


                        if (uInvoice.InvoiceLine[i].TaxTotal != null)
                        {
                            dbInvoice.InvoiceLine[i].TaxAmount = uInvoice.InvoiceLine[i].TaxTotal.TaxAmount != null ? UT.If0Null(uInvoice.InvoiceLine[i].TaxTotal.TaxAmount.Value) : 0;
                            if (uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal != null)
                            {
                                dbInvoice.InvoiceLine[i].TaxSubtotal = new InvoiceLine_TaxSubtotal[uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal.Length];
                                for (int j = 0; j < uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal.Length; j++)
                                {
                                    dbInvoice.InvoiceLine[i].TaxSubtotal[j] = new InvoiceLine_TaxSubtotal();
                                    dbInvoice.InvoiceLine[i].TaxSubtotal[j].Percent_ = uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal[j].Percent != null ? UT.If0Null(uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal[j].Percent.Value) : 0;
                                    dbInvoice.InvoiceLine[i].TaxSubtotal[j].CalculationSequenceNumeric = uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal[j].CalculationSequenceNumeric != null ? (int)UT.If0Null(uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal[j].CalculationSequenceNumeric.Value) : 0;
                                    dbInvoice.InvoiceLine[i].TaxSubtotal[j].currencyID = uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal[j].TaxAmount != null ? UT.IfNull(uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal[j].TaxAmount.currencyID, "TRY").ToString() : "TRY";
                                    dbInvoice.InvoiceLine[i].TaxSubtotal[j].TaxableAmount = uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal[j].TaxableAmount != null ? UT.If0Null(uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal[j].TaxableAmount.Value) : 0;
                                    dbInvoice.InvoiceLine[i].TaxSubtotal[j].TaxAmount = uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal[j].TaxAmount != null ? UT.If0Null(uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal[j].TaxAmount.Value) : 0;
                                    if (uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal[j].TaxCategory != null)
                                    {
                                        if (uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal[j].TaxCategory.TaxScheme != null)
                                        {
                                            dbInvoice.InvoiceLine[i].TaxSubtotal[j].TaxCategory_TaxScheme_Name = uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal[j].TaxCategory.TaxScheme.Name != null ? UT.IfNull(uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal[j].TaxCategory.TaxScheme.Name.Value, "").ToString() : "";
                                            dbInvoice.InvoiceLine[i].TaxSubtotal[j].TaxCategory_TaxScheme_TaxTypeCode = uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal[j].TaxCategory.TaxScheme.TaxTypeCode != null ? UT.IfNull(uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal[j].TaxCategory.TaxScheme.TaxTypeCode.Value, "").ToString() : "";

                                        }
                                        dbInvoice.InvoiceLine[i].TaxSubtotal[j].TaxCategory_TaxExemptionReason = uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal[j].TaxCategory.TaxExemptionReason != null ? UT.IfNull(uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal[j].TaxCategory.TaxExemptionReason.Value, "").ToString() : "";

                                    }
                                    dbInvoice.InvoiceLine[i].TaxSubtotal[j].PerUnitAmount = uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal[j].PerUnitAmount != null ? UT.If0Null(uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal[j].PerUnitAmount.Value) : 0;

                                }
                            }
                        }


                        if (uInvoice.InvoiceLine[i].WithholdingTaxTotal != null)
                        {
                            dbInvoice.InvoiceLine[i].WithholdingTaxAmount = uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxAmount != null ? UT.If0Null(uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxAmount.Value) : 0;
                            if (uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal != null)
                            {
                                dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal = new InvoiceLine_WithholdingTaxSubtotal[uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal.Length];
                                for (int j = 0; j < uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal.Length; j++)
                                {
                                    dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal[j] = new InvoiceLine_WithholdingTaxSubtotal();
                                    dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal[j].Percent_ = uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal[j].Percent != null ? UT.If0Null(uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal[j].Percent.Value) : 0;
                                    dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal[j].CalculationSequenceNumeric = uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal[j].CalculationSequenceNumeric != null ? (int)UT.If0Null(uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal[j].CalculationSequenceNumeric.Value) : 0;
                                    dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal[j].currencyID = uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal[j].TaxAmount != null ? UT.IfNull(uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal[j].TaxAmount.currencyID, "TRY").ToString() : "TRY";
                                    dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal[j].TaxableAmount = uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal[j].TaxableAmount != null ? UT.If0Null(uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal[j].TaxableAmount.Value) : 0;
                                    dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal[j].TaxAmount = uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal[j].TaxAmount != null ? UT.If0Null(uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal[j].TaxAmount.Value) : 0;
                                    if (uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal[j].TaxCategory != null)
                                    {
                                        if (uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal[j].TaxCategory.TaxScheme != null)
                                        {
                                            dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal[j].TaxCategory_TaxScheme_Name = uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal[j].TaxCategory.TaxScheme.Name != null ? UT.IfNull(uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal[j].TaxCategory.TaxScheme.Name.Value, "").ToString() : "";
                                            dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal[j].TaxCategory_TaxScheme_TaxTypeCode = uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal[j].TaxCategory.TaxScheme.TaxTypeCode != null ? UT.IfNull(uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal[j].TaxCategory.TaxScheme.TaxTypeCode.Value, "").ToString() : "";

                                        }
                                        dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal[j].TaxCategory_TaxExemptionReason = uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal[j].TaxCategory.TaxExemptionReason != null ? UT.IfNull(uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal[j].TaxCategory.TaxExemptionReason.Value, "").ToString() : "";

                                    }
                                    dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal[j].PerUnitAmount = uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal[j].PerUnitAmount != null ? UT.If0Null(uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal[j].PerUnitAmount.Value) : 0;

                                }
                            }
                        }

                    }
                }
            }

            if (uInvoice.ReceiptDocumentReference != null)
            {
                if (uInvoice.ReceiptDocumentReference.Length > 0)
                {
                    dbInvoice.ReceiptDocumentReference = new Invoice_ReceiptDocumentReference[uInvoice.ReceiptDocumentReference.Length];
                    for (int i = 0; i < uInvoice.ReceiptDocumentReference.Length; i++)
                    {
                        dbInvoice.ReceiptDocumentReference[i] = new Invoice_ReceiptDocumentReference();
                        dbInvoice.ReceiptDocumentReference[i].ID = uInvoice.ReceiptDocumentReference[i].ID != null ? UT.IfNull(uInvoice.ReceiptDocumentReference[i].ID.Value, "").ToString() : "";
                        dbInvoice.ReceiptDocumentReference[i].IssueDate = uInvoice.ReceiptDocumentReference[i].IssueDate != null ? (DateTime)UT.IfNull(uInvoice.ReceiptDocumentReference[i].IssueDate.Value, (new DateTime(1900, 1, 1))) : (new DateTime(1900, 1, 1));
                    }
                }
            }

            if (uInvoice.BillingReference != null)
            {
                if (uInvoice.BillingReference.Length > 0)
                {
                    dbInvoice.BillingReferences = new Invoice_BillingReference[uInvoice.BillingReference.Length];
                    for (int i = 0; i < uInvoice.BillingReference.Length; i++)
                    {
                        if (uInvoice.BillingReference[i].InvoiceDocumentReference != null)
                        {
                            dbInvoice.BillingReferences[i] = new Invoice_BillingReference();
                            dbInvoice.BillingReferences[i].ID = uInvoice.BillingReference[i].InvoiceDocumentReference.ID!=null? UT.IfNull( uInvoice.BillingReference[i].InvoiceDocumentReference.ID.Value,"").ToString():"";
                            dbInvoice.BillingReferences[i].IssueDate = uInvoice.BillingReference[i].InvoiceDocumentReference.IssueDate.Value;
                            dbInvoice.BillingReferences[i].DocumentTypeCode = uInvoice.BillingReference[i].InvoiceDocumentReference.DocumentTypeCode != null ? UT.IfNull(uInvoice.BillingReference[i].InvoiceDocumentReference.DocumentTypeCode.Value, "").ToString() : "IADE";
                            dbInvoice.BillingReferences[i].DocumentType = uInvoice.BillingReference[i].InvoiceDocumentReference.DocumentType != null ? UT.IfNull(uInvoice.BillingReference[i].InvoiceDocumentReference.DocumentType.Value, "").ToString() : "Fatura";
                        }
                }
            }
        }

            return dbInvoice;

        }

        public static Uyumsoft.InvoiceType Convert_DBInvoiceToUyumsoft(Invoice dbInvoice)
        {
            Uyumsoft.InvoiceType uInvoice = new Uyumsoft.InvoiceType();

            byte[] XSLTData;

            if (dbInvoice.XsltNo != 0)
            {
                System.IO.FileStream fs = new System.IO.FileStream(UT.GetMyDir() + "\\default.xslt", System.IO.FileMode.Open, System.IO.FileAccess.Read);

                XSLTData = new byte[(int)fs.Length];
                fs.Read(XSLTData, 0, (int)fs.Length);

                fs.Close();
            }
            else
            {

                System.Text.UTF8Encoding enc = new UTF8Encoding();
                XSLTData = enc.GetBytes(EFatura.getXSLTString(dbInvoice.XsltNo));
            }



            uInvoice.AdditionalDocumentReference = new Uyumsoft.DocumentReferenceType[1];

            uInvoice.AdditionalDocumentReference[0] = new Uyumsoft.DocumentReferenceType();
            uInvoice.AdditionalDocumentReference[0].ID = new Uyumsoft.IDType { Value = Guid.NewGuid().ToString() };
            uInvoice.AdditionalDocumentReference[0].IssueDate = new Uyumsoft.IssueDateType { Value = dbInvoice.IssueDate };
            uInvoice.AdditionalDocumentReference[0].Attachment = new Uyumsoft.AttachmentType { EmbeddedDocumentBinaryObject = new Uyumsoft.EmbeddedDocumentBinaryObjectType { filename = dbInvoice.ID + "_0001.xslt", characterSetCode = "UTF-8", encodingCode = "Base64", mimeCode = "application/xml", Value = XSLTData } };

            uInvoice.UBLVersionID = new Uyumsoft.UBLVersionIDType { Value = "2.0" };
            uInvoice.CustomizationID = new Uyumsoft.CustomizationIDType { Value = "TR1.0" };
            uInvoice.ProfileID = new Uyumsoft.ProfileIDType { Value = dbInvoice.ProfileID };
            uInvoice.CopyIndicator = new Uyumsoft.CopyIndicatorType { Value = false };
            uInvoice.UUID = new Uyumsoft.UUIDType { Value = dbInvoice.UUID };
            uInvoice.ID = new Uyumsoft.IDType() { Value = dbInvoice.ID };
            uInvoice.IssueDate = new Uyumsoft.IssueDateType { Value = dbInvoice.IssueDate };
            Uyumsoft.IssueTimeType issueTime = new Uyumsoft.IssueTimeType();
            issueTime.Value.AddHours((double)dbInvoice.IssueTime.Hour);
            issueTime.Value.AddMinutes((double)dbInvoice.IssueTime.Minute);
            issueTime.Value.AddSeconds((double)dbInvoice.IssueTime.Hour);
            uInvoice.IssueTime = new Uyumsoft.IssueTimeType { Value = issueTime.Value };
            uInvoice.InvoiceTypeCode = new Uyumsoft.InvoiceTypeCodeType { Value = dbInvoice.InvoiceTypeCode };
            if (dbInvoice.InvoiceTypeCode == "IADE")
            {
                uInvoice.BillingReference = new Uyumsoft.BillingReferenceType[1];

            }
            if (dbInvoice.Note != null)
            {
                if (dbInvoice.Note.Length > 0)
                {
                    uInvoice.Note = new Uyumsoft.NoteType[dbInvoice.Note.Length];
                    for (int i = 0; i < dbInvoice.Note.Length; i++)
                    {
                        uInvoice.Note[i] = new Uyumsoft.NoteType();
                        uInvoice.Note[i].Value = dbInvoice.Note[i].Note;
                    }
                }
                else
                {
                    uInvoice.Note = new Uyumsoft.NoteType[] { new Uyumsoft.NoteType { Value = "" } };
                }
            }
            else
            {
                uInvoice.Note = new Uyumsoft.NoteType[] { new Uyumsoft.NoteType { Value = "" } };
            }


            uInvoice.DocumentCurrencyCode = new Uyumsoft.DocumentCurrencyCodeType() { Value = getUyumsoftCurrencyType(dbInvoice.DocumentCurrencyCode) };
            uInvoice.TaxCurrencyCode = new Uyumsoft.TaxCurrencyCodeType() { Value = getUyumsoftCurrencyType(dbInvoice.TaxCurrencyCode) };
            uInvoice.PricingCurrencyCode = new Uyumsoft.PricingCurrencyCodeType() { Value = getUyumsoftCurrencyType(dbInvoice.PricingCurrencyCode) };
            if (dbInvoice.DocumentCurrencyCode == "TRY" || dbInvoice.PricingExchangeRate_CalculationRate == 0)
            {
                uInvoice.PricingExchangeRate = new Uyumsoft.ExchangeRateType() { CalculationRate = new Uyumsoft.CalculationRateType() { Value = 1 }, Date = new Uyumsoft.DateType1() { Value = uInvoice.IssueDate.Value }, SourceCurrencyCode = new Uyumsoft.SourceCurrencyCodeType() { Value = "TRY" }, TargetCurrencyCode = new Uyumsoft.TargetCurrencyCodeType() { Value = "TRY" } };

            }
            else
            {
                uInvoice.PricingExchangeRate = new Uyumsoft.ExchangeRateType() { CalculationRate = new Uyumsoft.CalculationRateType() { Value = (decimal)dbInvoice.PricingExchangeRate_CalculationRate }, Date = new Uyumsoft.DateType1() { Value = uInvoice.IssueDate.Value }, SourceCurrencyCode = new Uyumsoft.SourceCurrencyCodeType() { Value = dbInvoice.PricingExchangeRate_SourceCurrencyCode }, TargetCurrencyCode = new Uyumsoft.TargetCurrencyCodeType() { Value = dbInvoice.PricingExchangeRate_TargetCurrencyCode } };

            }
            uInvoice.PaymentCurrencyCode = new Uyumsoft.PaymentCurrencyCodeType() { Value = getUyumsoftCurrencyType(dbInvoice.PaymentCurrencyCode) };
            uInvoice.PaymentAlternativeCurrencyCode = new Uyumsoft.PaymentAlternativeCurrencyCodeType() { Value = getUyumsoftCurrencyType(dbInvoice.PaymentAlternativeCurrencyCode) };

            if (dbInvoice.InvoicePeriod_StartDate > (new DateTime(2014, 1, 1)))
            {
                uInvoice.InvoicePeriod = new Uyumsoft.PeriodType()
                {
                    StartDate = new Uyumsoft.StartDateType() { Value = dbInvoice.InvoicePeriod_StartDate },
                    EndDate = new Uyumsoft.EndDateType() { Value = dbInvoice.InvoicePeriod_EndDate }
                };
            }

            uInvoice.AccountingSupplierParty = Convert_DBInvoiceToUyumsoft_SupplierPartyType(dbInvoice);
            if (uInvoice.ProfileID.Value != "IHRACAT")
            {
                uInvoice.AccountingCustomerParty = Convert_DBInvoiceToUyumsoft_CustomerPartyType(dbInvoice);
            }
            else
            {
                uInvoice.AccountingCustomerParty = Convert_DBInvoiceToUyumsoft_Ihracat_CustomerPartyType(dbInvoice);
                uInvoice.BuyerCustomerParty = Convert_DBInvoiceToUyumsoft_Ihracat_BuyerCustomerParty(dbInvoice);
            }

            if (dbInvoice.InvoiceLine != null)
            {
                uInvoice.LineCountNumeric = new Uyumsoft.LineCountNumericType() { Value = dbInvoice.InvoiceLine.Length };
            }
            else
            {
                uInvoice.LineCountNumeric = new Uyumsoft.LineCountNumericType() { Value = 0 };
            }

            if (dbInvoice.AllowanceCharge != null)
            {
                if (dbInvoice.AllowanceCharge.Length > 0)
                {
                    uInvoice.AllowanceCharge = new Uyumsoft.AllowanceChargeType[dbInvoice.AllowanceCharge.Length];
                    for (int i = 0; i < dbInvoice.AllowanceCharge.Length; i++)
                    {
                        if (dbInvoice.AllowanceCharge[i].Amount_currencyID == "") dbInvoice.AllowanceCharge[i].Amount_currencyID = dbInvoice.DocumentCurrencyCode;
                        if (dbInvoice.AllowanceCharge[i].BaseAmount_currencyID == "") dbInvoice.AllowanceCharge[i].BaseAmount_currencyID = dbInvoice.DocumentCurrencyCode;

                        uInvoice.AllowanceCharge[i] = new Uyumsoft.AllowanceChargeType()
                        {

                            AllowanceChargeReason = new Uyumsoft.AllowanceChargeReasonType() { Value = dbInvoice.AllowanceCharge[i].AllowanceChargeReason },
                            Amount = new Uyumsoft.AmountType2() { Value = (decimal)dbInvoice.AllowanceCharge[i].Amount, currencyID = dbInvoice.AllowanceCharge[i].Amount_currencyID },
                            BaseAmount = new Uyumsoft.BaseAmountType() { Value = (decimal)dbInvoice.AllowanceCharge[i].BaseAmount, currencyID = dbInvoice.AllowanceCharge[i].BaseAmount_currencyID },
                            ChargeIndicator = new Uyumsoft.ChargeIndicatorType() { Value = dbInvoice.AllowanceCharge[i].ChargeIndicator },
                            MultiplierFactorNumeric = new Uyumsoft.MultiplierFactorNumericType() { Value = (decimal)dbInvoice.AllowanceCharge[i].MultiplierFactorNumeric }
                        };
                    }

                }
            }

            if (dbInvoice.DespatchDocumentReference != null)
            {
                if (dbInvoice.DespatchDocumentReference.Length > 0)
                {
                    uInvoice.DespatchDocumentReference = new Uyumsoft.DocumentReferenceType[dbInvoice.DespatchDocumentReference.Length];
                    for (int i = 0; i < dbInvoice.DespatchDocumentReference.Length; i++)
                    {
                        uInvoice.DespatchDocumentReference[i] = new Uyumsoft.DocumentReferenceType()
                        {
                            IssueDate = new Uyumsoft.IssueDateType() { Value = dbInvoice.DespatchDocumentReference[i].IssueDate },
                            ID = new Uyumsoft.IDType() { Value = dbInvoice.DespatchDocumentReference[i].ID }
                        };
                    }
                }
            }

            if (dbInvoice.OrderReference != null)
            {
                if (dbInvoice.OrderReference.Length > 0)
                {
                    uInvoice.OrderReference = new Uyumsoft.OrderReferenceType()
                    {
                        ID = new Uyumsoft.IDType() { Value = dbInvoice.OrderReference[0].ID },
                        IssueDate = new Uyumsoft.IssueDateType() { Value = dbInvoice.OrderReference[0].IssueDate }
                    };
                }
            }

            if (dbInvoice.PaymentMeans != null)
            {
                if (dbInvoice.PaymentMeans.Length > 0)
                {
                    uInvoice.PaymentMeans = new Uyumsoft.PaymentMeansType[dbInvoice.PaymentMeans.Length];
                    for (int i = 0; i < dbInvoice.PaymentMeans.Length; i++)
                    {
                        if (dbInvoice.PaymentMeans[i].PayeeFinancialAccount_CurrencyCode == "") dbInvoice.PaymentMeans[i].PayeeFinancialAccount_CurrencyCode = dbInvoice.DocumentCurrencyCode;
                        uInvoice.PaymentMeans[i] = new Uyumsoft.PaymentMeansType()
                        {
                            PaymentMeansCode = new Uyumsoft.PaymentMeansCodeType() { Value = dbInvoice.PaymentMeans[i].PaymentMeansCode },
                            PaymentDueDate = new Uyumsoft.PaymentDueDateType() { Value = dbInvoice.PaymentMeans[i].PaymentDueDate },
                            InstructionNote = new Uyumsoft.InstructionNoteType() { Value = dbInvoice.PaymentMeans[i].InstructionNote },
                            PaymentChannelCode = new Uyumsoft.PaymentChannelCodeType() { Value = dbInvoice.PaymentMeans[i].PaymentChannelCode },
                            PayeeFinancialAccount = new Uyumsoft.FinancialAccountType()
                            {
                                CurrencyCode = new Uyumsoft.CurrencyCodeType() { Value = getUyumsoftCurrencyType(dbInvoice.PaymentMeans[i].PayeeFinancialAccount_CurrencyCode) },
                                ID = new Uyumsoft.IDType() { Value = dbInvoice.PaymentMeans[i].PayeeFinancialAccount_ID },
                                PaymentNote = new Uyumsoft.PaymentNoteType() { Value = dbInvoice.PaymentMeans[i].PayeeFinancialAccount_PaymentNote }
                            }
                        };
                    }

                }
            }

            if (dbInvoice.PaymentTerms != null)
            {
                if (dbInvoice.PaymentTerms.Length > 0)
                {
                    if (dbInvoice.PaymentTerms[0].Amount_currencyID == "") dbInvoice.PaymentTerms[0].Amount_currencyID = dbInvoice.DocumentCurrencyCode;

                    uInvoice.PaymentTerms = new Uyumsoft.PaymentTermsType()
                    {
                        Amount = new Uyumsoft.AmountType2() { Value = (decimal)dbInvoice.PaymentTerms[0].Amount, currencyID = getUyumsoftCurrencyType(dbInvoice.PaymentTerms[0].Amount_currencyID) },
                        Note = new Uyumsoft.NoteType() { Value = dbInvoice.PaymentTerms[0].Note },
                        PenaltySurchargePercent = new Uyumsoft.PenaltySurchargePercentType() { Value = (decimal)dbInvoice.PaymentTerms[0].PenaltySurchargePercent }
                    };
                }
            }
            if (dbInvoice.ReceiptDocumentReference != null)
            {
                if (dbInvoice.ReceiptDocumentReference.Length > 0)
                {
                    uInvoice.ReceiptDocumentReference = new Uyumsoft.DocumentReferenceType[dbInvoice.ReceiptDocumentReference.Length];
                    for (int i = 0; i < dbInvoice.ReceiptDocumentReference.Length; i++)
                    {
                        uInvoice.ReceiptDocumentReference[i] = new Uyumsoft.DocumentReferenceType()
                        {
                            ID = new Uyumsoft.IDType() { Value = dbInvoice.ReceiptDocumentReference[i].ID },
                            IssueDate = new Uyumsoft.IssueDateType() { Value = dbInvoice.ReceiptDocumentReference[i].IssueDate }
                        };
                    }
                }
            }

            if (dbInvoice.BillingReferences != null)
            {
                if (dbInvoice.BillingReferences.Length > 0)
                {
                    uInvoice.BillingReference = new Uyumsoft.BillingReferenceType[dbInvoice.BillingReferences.Length];
                    for (int i = 0; i < dbInvoice.BillingReferences.Length; i++)
                    {
                        uInvoice.BillingReference[i] = new Uyumsoft.BillingReferenceType()
                        {
                            InvoiceDocumentReference=new Uyumsoft.DocumentReferenceType()
                            {
                                ID= new Uyumsoft.IDType() { Value= dbInvoice.BillingReferences[i].ID },
                                IssueDate=new Uyumsoft.IssueDateType() { Value = dbInvoice.BillingReferences[i].IssueDate },
                                DocumentTypeCode=new Uyumsoft.DocumentTypeCodeType() { Value="IADE"},
                                DocumentType = new Uyumsoft.DocumentTypeType() { Value = "Fatura" },
                            }
                        };
                    }

                }
            }

            if (dbInvoice.TaxSubtotal != null)
            {
                if (dbInvoice.TaxSubtotal.Length > 0)
                {
                    if (dbInvoice.TaxCurrencyCode == "") dbInvoice.TaxCurrencyCode = dbInvoice.DocumentCurrencyCode;
                    uInvoice.TaxTotal = new Uyumsoft.TaxTotalType[dbInvoice.TaxSubtotal.Length];
                    uInvoice.TaxTotal[0] = new Uyumsoft.TaxTotalType()
                    {
                        TaxAmount = new Uyumsoft.TaxAmountType() { Value = (decimal)dbInvoice.TaxAmount, currencyID = getUyumsoftCurrencyType(dbInvoice.TaxCurrencyCode) },
                        TaxSubtotal = new Uyumsoft.TaxSubtotalType[dbInvoice.TaxSubtotal.Length]
                    };

                    for (int i = 0; i < dbInvoice.TaxSubtotal.Length; i++)
                    {
                        uInvoice.TaxTotal[0].TaxSubtotal[i] = new Uyumsoft.TaxSubtotalType()
                        {
                            Percent = new Uyumsoft.PercentType1() { Value = (decimal)dbInvoice.TaxSubtotal[i].Percent_ },
                            TaxableAmount = new Uyumsoft.TaxableAmountType() { Value = (decimal)dbInvoice.TaxSubtotal[i].TaxableAmount, currencyID = getUyumsoftCurrencyType(dbInvoice.TaxCurrencyCode) },
                            TaxAmount = new Uyumsoft.TaxAmountType() { Value = (decimal)dbInvoice.TaxSubtotal[i].TaxAmount, currencyID = getUyumsoftCurrencyType(dbInvoice.TaxCurrencyCode) },
                        };

                        if (dbInvoice.TaxSubtotal[i].TaxCategory_TaxScheme_TaxTypeCode != "" || dbInvoice.TaxSubtotal[i].TaxCategory_TaxScheme_Name != "" || dbInvoice.TaxSubtotal[i].TaxCategory_TaxExemptionReason != "" || dbInvoice.TaxSubtotal[i].TaxCategory_TaxExemptionReasonCode != "")
                        {
                            uInvoice.TaxTotal[0].TaxSubtotal[i].TaxCategory = new Uyumsoft.TaxCategoryType();
                            if (!String.IsNullOrEmpty(dbInvoice.TaxSubtotal[i].TaxCategory_TaxExemptionReason))
                            {
                                uInvoice.TaxTotal[0].TaxSubtotal[i].TaxCategory.TaxExemptionReason = new Uyumsoft.TaxExemptionReasonType() { Value = dbInvoice.TaxSubtotal[i].TaxCategory_TaxExemptionReason };
                                uInvoice.TaxTotal[0].TaxSubtotal[i].TaxCategory.TaxExemptionReasonCode = new Uyumsoft.TaxExemptionReasonCodeType { Value = dbInvoice.TaxSubtotal[i].TaxCategory_TaxExemptionReasonCode };
                            }
                            if (dbInvoice.TaxSubtotal[i].TaxCategory_TaxScheme_TaxTypeCode != "" || dbInvoice.TaxSubtotal[i].TaxCategory_TaxScheme_Name != "")
                            {
                                uInvoice.TaxTotal[0].TaxSubtotal[i].TaxCategory.TaxScheme = new Uyumsoft.TaxSchemeType()
                                {
                                    TaxTypeCode = new Uyumsoft.TaxTypeCodeType() { Value = dbInvoice.TaxSubtotal[i].TaxCategory_TaxScheme_TaxTypeCode },
                                    Name = new Uyumsoft.NameType1() { Value = dbInvoice.TaxSubtotal[i].TaxCategory_TaxScheme_Name }
                                };
                            }
                        }
                    }

                }
            }

            if (dbInvoice.WithholdingTaxSubtotal != null)
            {
                if (dbInvoice.WithholdingTaxSubtotal.Length > 0)
                {
                    if (dbInvoice.TaxCurrencyCode == "") dbInvoice.TaxCurrencyCode = dbInvoice.DocumentCurrencyCode;
                    uInvoice.WithholdingTaxTotal = new Uyumsoft.TaxTotalType[dbInvoice.WithholdingTaxSubtotal.Length];
                    uInvoice.WithholdingTaxTotal[0] = new Uyumsoft.TaxTotalType()
                    {
                        TaxAmount = new Uyumsoft.TaxAmountType() { Value = (decimal)dbInvoice.WithholdingTaxAmount, currencyID = getUyumsoftCurrencyType(dbInvoice.TaxCurrencyCode) },
                        TaxSubtotal = new Uyumsoft.TaxSubtotalType[dbInvoice.WithholdingTaxSubtotal.Length]
                    };

                    for (int i = 0; i < dbInvoice.WithholdingTaxSubtotal.Length; i++)
                    {
                        uInvoice.WithholdingTaxTotal[0].TaxSubtotal[i] = new Uyumsoft.TaxSubtotalType()
                        {
                            Percent = new Uyumsoft.PercentType1() { Value = (decimal)dbInvoice.WithholdingTaxSubtotal[i].Percent_ },
                            TaxableAmount = new Uyumsoft.TaxableAmountType() { Value = (decimal)dbInvoice.WithholdingTaxSubtotal[i].TaxableAmount, currencyID = getUyumsoftCurrencyType(dbInvoice.TaxCurrencyCode) },
                            TaxAmount = new Uyumsoft.TaxAmountType() { Value = (decimal)dbInvoice.WithholdingTaxSubtotal[i].TaxAmount, currencyID = getUyumsoftCurrencyType(dbInvoice.TaxCurrencyCode) },
                        };

                        if (dbInvoice.WithholdingTaxSubtotal[i].TaxCategory_TaxScheme_TaxTypeCode != "" || dbInvoice.WithholdingTaxSubtotal[i].TaxCategory_TaxScheme_Name != "" || dbInvoice.WithholdingTaxSubtotal[i].TaxCategory_TaxExemptionReason != "" || dbInvoice.WithholdingTaxSubtotal[i].TaxCategory_TaxExemptionReasonCode != "")
                        {
                            uInvoice.WithholdingTaxTotal[0].TaxSubtotal[i].TaxCategory = new Uyumsoft.TaxCategoryType();

                            if (!String.IsNullOrEmpty(dbInvoice.WithholdingTaxSubtotal[i].TaxCategory_TaxExemptionReason))
                            {
                                uInvoice.WithholdingTaxTotal[0].TaxSubtotal[i].TaxCategory.TaxExemptionReason = new Uyumsoft.TaxExemptionReasonType() { Value = dbInvoice.WithholdingTaxSubtotal[i].TaxCategory_TaxExemptionReason };
                                uInvoice.WithholdingTaxTotal[0].TaxSubtotal[i].TaxCategory.TaxExemptionReasonCode = new Uyumsoft.TaxExemptionReasonCodeType { Value = dbInvoice.WithholdingTaxSubtotal[i].TaxCategory_TaxExemptionReasonCode };
                            }

                            if (dbInvoice.WithholdingTaxSubtotal[i].TaxCategory_TaxScheme_TaxTypeCode != "" || dbInvoice.WithholdingTaxSubtotal[i].TaxCategory_TaxScheme_Name != "")
                            {
                                uInvoice.WithholdingTaxTotal[0].TaxSubtotal[i].TaxCategory.TaxScheme = new Uyumsoft.TaxSchemeType()
                                {
                                    TaxTypeCode = new Uyumsoft.TaxTypeCodeType() { Value = dbInvoice.WithholdingTaxSubtotal[i].TaxCategory_TaxScheme_TaxTypeCode },
                                    Name = new Uyumsoft.NameType1() { Value = dbInvoice.WithholdingTaxSubtotal[i].TaxCategory_TaxScheme_Name }
                                };
                            }
                        }
                    }

                }
            }

            uInvoice.LegalMonetaryTotal = new Uyumsoft.MonetaryTotalType()
            {
                AllowanceTotalAmount = new Uyumsoft.AllowanceTotalAmountType() { currencyID = uInvoice.DocumentCurrencyCode.Value, Value = (decimal)dbInvoice.LegalMonetaryTotal_AllowanceTotalAmount },
                LineExtensionAmount = new Uyumsoft.LineExtensionAmountType() { currencyID = uInvoice.DocumentCurrencyCode.Value, Value = (decimal)dbInvoice.LegalMonetaryTotal_LineExtensionAmount },
                PayableAmount = new Uyumsoft.PayableAmountType() { currencyID = uInvoice.DocumentCurrencyCode.Value, Value = (decimal)dbInvoice.LegalMonetaryTotal_PayableAmount },
                PayableRoundingAmount = new Uyumsoft.PayableRoundingAmountType() { currencyID = uInvoice.DocumentCurrencyCode.Value, Value = (decimal)dbInvoice.LegalMonetaryTotal_PayableRoundingAmount },
                TaxExclusiveAmount = new Uyumsoft.TaxExclusiveAmountType() { currencyID = uInvoice.DocumentCurrencyCode.Value, Value = (decimal)dbInvoice.LegalMonetaryTotal_TaxExclusiveAmount },
                TaxInclusiveAmount = new Uyumsoft.TaxInclusiveAmountType() { currencyID = uInvoice.DocumentCurrencyCode.Value, Value = (decimal)dbInvoice.LegalMonetaryTotal_TaxInclusiveAmount },
                ChargeTotalAmount = new Uyumsoft.ChargeTotalAmountType() { currencyID = uInvoice.DocumentCurrencyCode.Value, Value = (decimal)dbInvoice.LegalMonetaryTotal_ChargeTotalAmount }
            };

            if (dbInvoice.InvoiceLine != null)
            {
                if (dbInvoice.InvoiceLine.Length > 0)
                {
                    uInvoice.InvoiceLine = new Uyumsoft.InvoiceLineType[dbInvoice.InvoiceLine.Length];
                    for (int i = 0; i < dbInvoice.InvoiceLine.Length; i++)
                    {
                        uInvoice.InvoiceLine[i] = new Uyumsoft.InvoiceLineType();
                        if (dbInvoice.ProfileID == "IHRACAT")
                        {
                            uInvoice.InvoiceLine[i].Delivery = new Uyumsoft.DeliveryType[1];
                            uInvoice.InvoiceLine[i].Delivery[0] = new Uyumsoft.DeliveryType()
                            {

                                DeliveryAddress = new Uyumsoft.AddressType()
                                {
                                    CityName = new Uyumsoft.CityNameType() { Value = dbInvoice.ACP_PostalAddress_CityName },
                                    CitySubdivisionName = new Uyumsoft.CitySubdivisionNameType() { Value = dbInvoice.ACP_PostalAddress_CitySubdivisionName },
                                    Room = new Uyumsoft.RoomType() { Value = dbInvoice.ACP_PostalAddress_Room },
                                    StreetName = new Uyumsoft.StreetNameType() { Value = dbInvoice.ACP_PostalAddress_StreetName },
                                    BuildingName = new Uyumsoft.BuildingNameType() { Value = dbInvoice.ACP_PostalAddress_BuildingName },
                                    BuildingNumber = new Uyumsoft.BuildingNumberType() { Value = dbInvoice.ACP_PostalAddress_BuildingNumber },
                                    PostalZone = new Uyumsoft.PostalZoneType() { Value = "" },
                                    Region = new Uyumsoft.RegionType() { Value = "" },
                                    Country = new Uyumsoft.CountryType()
                                    {
                                        Name = new Uyumsoft.NameType1() { Value = dbInvoice.ACP_PostalAddress_Country }
                                    }

                                },
                                Shipment = new Uyumsoft.ShipmentType()
                                {
                                    ID = new Uyumsoft.IDType() { Value = dbInvoice.InvoiceLine[i].ID },
                                    GoodsItem = new Uyumsoft.GoodsItemType[1],
                                    ShipmentStage = new Uyumsoft.ShipmentStageType[1],
                                    TransportHandlingUnit = new Uyumsoft.TransportHandlingUnitType[1]
                                },
                                DeliveryTerms = new Uyumsoft.DeliveryTermsType[1]
                            };

                            uInvoice.InvoiceLine[i].Delivery[0].Shipment.GoodsItem[0] = new Uyumsoft.GoodsItemType()
                            {
                                RequiredCustomsID = new Uyumsoft.RequiredCustomsIDType()
                                {
                                    Value = dbInvoice.InvoiceLine[i].GTIPNO
                                }
                            };
                            uInvoice.InvoiceLine[i].Delivery[0].Shipment.ShipmentStage[0] = new Uyumsoft.ShipmentStageType()
                            {
                                TransportModeCode = new Uyumsoft.TransportModeCodeType()
                                {
                                    Value = dbInvoice.InvoiceLine[i].TransportModeCode
                                }
                            };
                            uInvoice.InvoiceLine[i].Delivery[0].DeliveryTerms[0] = new Uyumsoft.DeliveryTermsType()
                            {
                                ID = new Uyumsoft.IDType()
                                {
                                    schemeID = "INCOTERMS",
                                    Value = dbInvoice.InvoiceLine[i].DeliveryTerms
                                }
                            };

                            if (dbInvoice.InvoiceLine[i].Packages != null)
                            {
                                uInvoice.InvoiceLine[i].Delivery[0].Shipment.TransportHandlingUnit[0] = new Uyumsoft.TransportHandlingUnitType()
                                {
                                    ActualPackage = new Uyumsoft.PackageType[dbInvoice.InvoiceLine[i].Packages.Length]
                                };
                                for (int j = 0; j < dbInvoice.InvoiceLine[i].Packages.Length; j++)
                                {
                                    uInvoice.InvoiceLine[i].Delivery[0].Shipment.TransportHandlingUnit[0].ActualPackage[j] = new Uyumsoft.PackageType()
                                    {
                                        ID = new Uyumsoft.IDType() { Value = dbInvoice.InvoiceLine[i].Packages[j].ID },
                                        Quantity = new Uyumsoft.QuantityType2() { Value = (decimal)dbInvoice.InvoiceLine[i].Packages[j].Quantity },
                                        PackagingTypeCode = new Uyumsoft.PackagingTypeCodeType() { Value = dbInvoice.InvoiceLine[i].Packages[j].PackagingTypeCode },

                                    };
                                }

                            }
                            dbInvoice.InvoiceLine[i].Item_Name = dbInvoice.InvoiceLine[i].ID + " - " + dbInvoice.InvoiceLine[i].Item_Name;
                            uInvoice.InvoiceLine[i].ID = new Uyumsoft.IDType() { Value = (i + 1).ToString() };
                        }
                        else
                        {
                            if (dbInvoice.InvoiceLine[i].ID != "") uInvoice.InvoiceLine[i].ID = new Uyumsoft.IDType() { Value = dbInvoice.InvoiceLine[i].ID };
                        }


                        if (dbInvoice.InvoiceLine[i].currencyID == "") dbInvoice.InvoiceLine[i].currencyID = dbInvoice.DocumentCurrencyCode;



                        string birim = dbInvoice.InvoiceLine[i].InvoicedQuantity_unitCode;

                        uInvoice.InvoiceLine[i].InvoicedQuantity = new Uyumsoft.InvoicedQuantityType() { Value = (decimal)dbInvoice.InvoiceLine[i].InvoicedQuantity, unitCode = birim };
                        if (dbInvoice.InvoiceLine[i].Note != "")
                        {
                            uInvoice.InvoiceLine[i].Note = new Uyumsoft.NoteType[1];
                            uInvoice.InvoiceLine[i].Note[0] = new Uyumsoft.NoteType() { Value = dbInvoice.InvoiceLine[i].Note };
                        }
                        uInvoice.InvoiceLine[i].Item = new Uyumsoft.ItemType();
                        if (dbInvoice.InvoiceLine[i].Item_Name != "") uInvoice.InvoiceLine[i].Item.Name = new Uyumsoft.NameType1() { Value = dbInvoice.InvoiceLine[i].Item_Name };
                        if (dbInvoice.InvoiceLine[i].Item_BrandName != "") uInvoice.InvoiceLine[i].Item.BrandName = new Uyumsoft.BrandNameType() { Value = dbInvoice.InvoiceLine[i].Item_BrandName };
                        if (dbInvoice.InvoiceLine[i].Item_Description != "") uInvoice.InvoiceLine[i].Item.Description = new Uyumsoft.DescriptionType() { Value = dbInvoice.InvoiceLine[i].Item_Description };
                        if (dbInvoice.InvoiceLine[i].Item_ModelName != "") uInvoice.InvoiceLine[i].Item.ModelName = new Uyumsoft.ModelNameType() { Value = dbInvoice.InvoiceLine[i].Item_ModelName };
                        if (dbInvoice.InvoiceLine[i].Item_ItemClassificationCode != "")
                        {
                            uInvoice.InvoiceLine[i].Item.CommodityClassification = new Uyumsoft.CommodityClassificationType[1];
                            uInvoice.InvoiceLine[i].Item.CommodityClassification[0] = new Uyumsoft.CommodityClassificationType() { ItemClassificationCode = new Uyumsoft.ItemClassificationCodeType() { Value = dbInvoice.InvoiceLine[i].Item_ItemClassificationCode } };
                        }
                        if (dbInvoice.InvoiceLine[i].Item_BuyersItemIdentification_ID != "") uInvoice.InvoiceLine[i].Item.BuyersItemIdentification = new Uyumsoft.ItemIdentificationType() { ID = new Uyumsoft.IDType() { Value = dbInvoice.InvoiceLine[i].Item_BuyersItemIdentification_ID } };
                        if (dbInvoice.InvoiceLine[i].Item_SellersItemIdentification_ID != "") uInvoice.InvoiceLine[i].Item.SellersItemIdentification = new Uyumsoft.ItemIdentificationType() { ID = new Uyumsoft.IDType() { Value = dbInvoice.InvoiceLine[i].Item_SellersItemIdentification_ID } };
                        if (dbInvoice.InvoiceLine[i].Item_ManufacturersItemIdentification_ID != "") uInvoice.InvoiceLine[i].Item.ManufacturersItemIdentification = new Uyumsoft.ItemIdentificationType() { ID = new Uyumsoft.IDType() { Value = dbInvoice.InvoiceLine[i].Item_ManufacturersItemIdentification_ID } };

                        if (dbInvoice.InvoiceLine[i].AllowanceCharge_Amount > 0)
                        {
                            uInvoice.InvoiceLine[i].AllowanceCharge = new Uyumsoft.AllowanceChargeType[1];
                            uInvoice.InvoiceLine[i].AllowanceCharge[0] = new Uyumsoft.AllowanceChargeType()
                            {
                                ChargeIndicator = new Uyumsoft.ChargeIndicatorType() { Value = dbInvoice.InvoiceLine[i].AllowanceCharge_ChargeIndicator },
                                MultiplierFactorNumeric = new Uyumsoft.MultiplierFactorNumericType() { Value = (decimal)dbInvoice.InvoiceLine[i].AllowanceCharge_MultiplierFactorNumeric },
                                Amount = new Uyumsoft.AmountType2() { Value = (decimal)dbInvoice.InvoiceLine[i].AllowanceCharge_Amount, currencyID = getUyumsoftCurrencyType(dbInvoice.InvoiceLine[i].currencyID) },
                                BaseAmount = new Uyumsoft.BaseAmountType() { Value = (decimal)dbInvoice.InvoiceLine[i].AllowanceCharge_BaseAmount, currencyID = getUyumsoftCurrencyType(dbInvoice.InvoiceLine[i].currencyID) }
                            };
                            if (dbInvoice.InvoiceLine[i].AllowanceCharge_AllowanceChargeReason != "")
                            {
                                uInvoice.InvoiceLine[i].AllowanceCharge[0].AllowanceChargeReason = new Uyumsoft.AllowanceChargeReasonType() { Value = dbInvoice.InvoiceLine[i].AllowanceCharge_AllowanceChargeReason };
                            }
                        }

                        uInvoice.InvoiceLine[i].LineExtensionAmount = new Uyumsoft.LineExtensionAmountType() { currencyID = getUyumsoftCurrencyType(dbInvoice.InvoiceLine[i].currencyID), Value = (decimal)dbInvoice.InvoiceLine[i].LineExtensionAmount };
                        uInvoice.InvoiceLine[i].Price = new Uyumsoft.PriceType() { PriceAmount = new Uyumsoft.PriceAmountType() { currencyID = getUyumsoftCurrencyType(dbInvoice.InvoiceLine[i].currencyID), Value = (decimal)dbInvoice.InvoiceLine[i].PriceAmount } };

                        if (dbInvoice.InvoiceLine[i].TaxSubtotal != null)
                        {
                            uInvoice.InvoiceLine[i].TaxTotal = new Uyumsoft.TaxTotalType() { TaxAmount = new Uyumsoft.TaxAmountType() { currencyID = getUyumsoftCurrencyType(dbInvoice.InvoiceLine[i].currencyID), Value = (decimal)dbInvoice.InvoiceLine[i].TaxAmount } };
                            if (dbInvoice.InvoiceLine[i].TaxSubtotal.Length > 0)
                            {
                                uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal = new Uyumsoft.TaxSubtotalType[dbInvoice.InvoiceLine[i].TaxSubtotal.Length];
                                for (int j = 0; j < dbInvoice.InvoiceLine[i].TaxSubtotal.Length; j++)
                                {
                                    uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal[j] = new Uyumsoft.TaxSubtotalType();
                                    if (dbInvoice.InvoiceLine[i].TaxSubtotal[j].currencyID == "") dbInvoice.InvoiceLine[i].TaxSubtotal[j].currencyID = dbInvoice.DocumentCurrencyCode;
                                    uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal[j].TaxableAmount = new Uyumsoft.TaxableAmountType() { Value = (decimal)dbInvoice.InvoiceLine[i].TaxSubtotal[j].TaxableAmount, currencyID = getUyumsoftCurrencyType(dbInvoice.InvoiceLine[i].TaxSubtotal[j].currencyID) };
                                    uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal[j].TaxAmount = new Uyumsoft.TaxAmountType() { Value = (decimal)dbInvoice.InvoiceLine[i].TaxSubtotal[j].TaxAmount, currencyID = getUyumsoftCurrencyType(dbInvoice.InvoiceLine[i].TaxSubtotal[j].currencyID) };
                                    if (dbInvoice.InvoiceLine[i].TaxSubtotal[j].TaxCategory_TaxScheme_TaxTypeCode != "" || dbInvoice.InvoiceLine[i].TaxSubtotal[j].TaxCategory_TaxScheme_Name != "" || dbInvoice.InvoiceLine[i].TaxSubtotal[j].TaxCategory_TaxExemptionReason != "" || dbInvoice.InvoiceLine[i].TaxSubtotal[j].TaxCategory_TaxExemptionReasonCode != "")
                                    {
                                        uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal[j].TaxCategory = new Uyumsoft.TaxCategoryType();
                                        if (dbInvoice.InvoiceLine[i].TaxSubtotal[j].TaxCategory_TaxExemptionReason != "") uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal[j].TaxCategory.TaxExemptionReason = new Uyumsoft.TaxExemptionReasonType() { Value = dbInvoice.InvoiceLine[i].TaxSubtotal[j].TaxCategory_TaxExemptionReason };
                                        if (dbInvoice.InvoiceLine[i].TaxSubtotal[j].TaxCategory_TaxExemptionReasonCode != "") uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal[j].TaxCategory.TaxExemptionReasonCode = new Uyumsoft.TaxExemptionReasonCodeType() { Value = dbInvoice.InvoiceLine[i].TaxSubtotal[j].TaxCategory_TaxExemptionReasonCode };
                                        if (dbInvoice.InvoiceLine[i].TaxSubtotal[j].TaxCategory_TaxScheme_TaxTypeCode != "" || dbInvoice.InvoiceLine[i].TaxSubtotal[j].TaxCategory_TaxScheme_Name != "")
                                        {
                                            uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal[j].TaxCategory.TaxScheme = new Uyumsoft.TaxSchemeType();
                                            if (dbInvoice.InvoiceLine[i].TaxSubtotal[j].TaxCategory_TaxScheme_TaxTypeCode != "") uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal[j].TaxCategory.TaxScheme.TaxTypeCode = new Uyumsoft.TaxTypeCodeType() { Value = dbInvoice.InvoiceLine[i].TaxSubtotal[j].TaxCategory_TaxScheme_TaxTypeCode };
                                            if (dbInvoice.InvoiceLine[i].TaxSubtotal[j].TaxCategory_TaxScheme_Name != "") uInvoice.InvoiceLine[i].TaxTotal.TaxSubtotal[j].TaxCategory.TaxScheme.Name = new Uyumsoft.NameType1() { Value = dbInvoice.InvoiceLine[i].TaxSubtotal[j].TaxCategory_TaxScheme_Name };
                                        }
                                    }
                                }
                            }
                        }

                        if (dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal != null)
                        {
                            uInvoice.InvoiceLine[i].WithholdingTaxTotal = new Uyumsoft.TaxTotalType[1];

                            uInvoice.InvoiceLine[i].WithholdingTaxTotal[0] = new Uyumsoft.TaxTotalType() { TaxAmount = new Uyumsoft.TaxAmountType() { currencyID = getUyumsoftCurrencyType(dbInvoice.InvoiceLine[i].currencyID), Value = (decimal)dbInvoice.InvoiceLine[i].WithholdingTaxAmount } };
                            if (dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal.Length > 0)
                            {
                                uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal = new Uyumsoft.TaxSubtotalType[dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal.Length];
                                for (int j = 0; j < dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal.Length; j++)
                                {
                                    uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal[j] = new Uyumsoft.TaxSubtotalType();
                                    if (dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal[j].currencyID == "") dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal[j].currencyID = dbInvoice.DocumentCurrencyCode;
                                    uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal[j].TaxableAmount = new Uyumsoft.TaxableAmountType() { Value = (decimal)dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal[j].TaxableAmount, currencyID = getUyumsoftCurrencyType(dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal[j].currencyID) };
                                    uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal[j].TaxAmount = new Uyumsoft.TaxAmountType() { Value = (decimal)dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal[j].TaxAmount, currencyID = getUyumsoftCurrencyType(dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal[j].currencyID) };
                                    if (dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal[j].TaxCategory_TaxScheme_TaxTypeCode != "" || dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal[j].TaxCategory_TaxScheme_Name != "" || dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal[j].TaxCategory_TaxExemptionReason != "" || dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal[j].TaxCategory_TaxExemptionReasonCode != "")
                                    {
                                        uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal[j].TaxCategory = new Uyumsoft.TaxCategoryType();
                                        if (dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal[j].TaxCategory_TaxExemptionReason != "") uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal[j].TaxCategory.TaxExemptionReason = new Uyumsoft.TaxExemptionReasonType() { Value = dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal[j].TaxCategory_TaxExemptionReason };
                                        if (dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal[j].TaxCategory_TaxExemptionReasonCode != "") uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal[j].TaxCategory.TaxExemptionReasonCode = new Uyumsoft.TaxExemptionReasonCodeType() { Value = dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal[j].TaxCategory_TaxExemptionReasonCode };

                                        if (dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal[j].TaxCategory_TaxScheme_TaxTypeCode != "" || dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal[j].TaxCategory_TaxScheme_Name != "")
                                        {
                                            uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal[j].TaxCategory.TaxScheme = new Uyumsoft.TaxSchemeType();
                                            if (dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal[j].TaxCategory_TaxScheme_TaxTypeCode != "") uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal[j].TaxCategory.TaxScheme.TaxTypeCode = new Uyumsoft.TaxTypeCodeType() { Value = dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal[j].TaxCategory_TaxScheme_TaxTypeCode };
                                            if (dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal[j].TaxCategory_TaxScheme_Name != "") uInvoice.InvoiceLine[i].WithholdingTaxTotal[0].TaxSubtotal[j].TaxCategory.TaxScheme.Name = new Uyumsoft.NameType1() { Value = dbInvoice.InvoiceLine[i].WithholdingTaxSubtotal[j].TaxCategory_TaxScheme_Name };
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


            return uInvoice;
        }

        private static Uyumsoft.SupplierPartyType Convert_DBInvoiceToUyumsoft_SupplierPartyType(Invoice dbInvoice)
        {
            Uyumsoft.SupplierPartyType ASP = new Uyumsoft.SupplierPartyType();
            ASP.Party = new Uyumsoft.PartyType();
            //ASP.Party.PartyName.Name.Value
            ASP.Party.PartyName = new Uyumsoft.PartyNameType { Name = new Uyumsoft.NameType1() { Value = dbInvoice.ASP_PartyName } };
            ASP.Party.WebsiteURI = new Uyumsoft.WebsiteURIType() { Value = dbInvoice.ASP_WebsiteURI };

            ASP.Party.PartyTaxScheme = new Uyumsoft.PartyTaxSchemeType()
            {
                TaxScheme = new Uyumsoft.TaxSchemeType()
                {
                    Name = new Uyumsoft.NameType1() { Value = dbInvoice.ASP_PartyTaxSchemeName }
                }
            };
            if (dbInvoice.ASP_PartyTaxSchemeTaxTypeCode != "") ASP.Party.PartyTaxScheme.TaxScheme.TaxTypeCode = new Uyumsoft.TaxTypeCodeType() { Value = dbInvoice.ASP_PartyTaxSchemeTaxTypeCode };

            if (dbInvoice.ASP_PartyIdentification1_ID != "")
            {
                ASP.Party.PartyIdentification = new Uyumsoft.PartyIdentificationType[ASP.Party.PartyIdentification != null ? ASP.Party.PartyIdentification.Length + 1 : 1];
                ASP.Party.PartyIdentification[ASP.Party.PartyIdentification.Length - 1] = new Uyumsoft.PartyIdentificationType();
                ASP.Party.PartyIdentification[ASP.Party.PartyIdentification.Length - 1].ID = new Uyumsoft.IDType { Value = dbInvoice.ASP_PartyIdentification1_ID, schemeID = dbInvoice.ASP_PartyIdentification1_schemeID };
            }

            if (dbInvoice.ASP_PartyIdentification2_ID != "")
            {
                ASP.Party.PartyIdentification = new Uyumsoft.PartyIdentificationType[ASP.Party.PartyIdentification != null ? ASP.Party.PartyIdentification.Length + 1 : 1];
                ASP.Party.PartyIdentification[ASP.Party.PartyIdentification.Length - 1] = new Uyumsoft.PartyIdentificationType();
                ASP.Party.PartyIdentification[ASP.Party.PartyIdentification.Length - 1].ID = new Uyumsoft.IDType { Value = dbInvoice.ASP_PartyIdentification2_ID, schemeID = dbInvoice.ASP_PartyIdentification2_schemeID };
            }

            if (dbInvoice.ASP_PartyIdentification3_ID != "")
            {
                ASP.Party.PartyIdentification = new Uyumsoft.PartyIdentificationType[ASP.Party.PartyIdentification != null ? ASP.Party.PartyIdentification.Length + 1 : 1];
                ASP.Party.PartyIdentification[ASP.Party.PartyIdentification.Length - 1] = new Uyumsoft.PartyIdentificationType();
                ASP.Party.PartyIdentification[ASP.Party.PartyIdentification.Length - 1].ID = new Uyumsoft.IDType { Value = dbInvoice.ASP_PartyIdentification3_ID, schemeID = dbInvoice.ASP_PartyIdentification3_schemeID };
            }

            if (dbInvoice.ASP_PartyIdentification4_ID != "")
            {
                ASP.Party.PartyIdentification = new Uyumsoft.PartyIdentificationType[ASP.Party.PartyIdentification != null ? ASP.Party.PartyIdentification.Length + 1 : 1];
                ASP.Party.PartyIdentification[ASP.Party.PartyIdentification.Length - 1] = new Uyumsoft.PartyIdentificationType();
                ASP.Party.PartyIdentification[ASP.Party.PartyIdentification.Length - 1].ID = new Uyumsoft.IDType { Value = dbInvoice.ASP_PartyIdentification4_ID, schemeID = dbInvoice.ASP_PartyIdentification4_schemeID };
            }

            if (dbInvoice.ASP_PartyIdentification5_ID != "")
            {
                ASP.Party.PartyIdentification = new Uyumsoft.PartyIdentificationType[ASP.Party.PartyIdentification != null ? ASP.Party.PartyIdentification.Length + 1 : 1];
                ASP.Party.PartyIdentification[ASP.Party.PartyIdentification.Length - 1] = new Uyumsoft.PartyIdentificationType();
                ASP.Party.PartyIdentification[ASP.Party.PartyIdentification.Length - 1].ID = new Uyumsoft.IDType { Value = dbInvoice.ASP_PartyIdentification5_ID, schemeID = dbInvoice.ASP_PartyIdentification5_schemeID };
            }

            ASP.Party.PostalAddress = new Uyumsoft.AddressType()
            {
                StreetName = new Uyumsoft.StreetNameType() { Value = dbInvoice.ASP_PostalAddress_StreetName },
                Room = new Uyumsoft.RoomType() { Value = dbInvoice.ASP_PostalAddress_Room },
                BuildingNumber = new Uyumsoft.BuildingNumberType() { Value = dbInvoice.ASP_PostalAddress_BuildingNumber },
                BuildingName = new Uyumsoft.BuildingNameType() { Value = dbInvoice.ASP_PostalAddress_BuildingName },
                CitySubdivisionName = new Uyumsoft.CitySubdivisionNameType() { Value = dbInvoice.ASP_PostalAddress_CitySubdivisionName },
                CityName = new Uyumsoft.CityNameType() { Value = dbInvoice.ASP_PostalAddress_CityName },
                Country = new Uyumsoft.CountryType() { Name = new Uyumsoft.NameType1() { Value = dbInvoice.ASP_PostalAddress_Country } }
            };

            ASP.Party.Contact = new Uyumsoft.ContactType()
            {
                ElectronicMail = new Uyumsoft.ElectronicMailType() { Value = dbInvoice.ASP_Contact_ElectronicMail },
                Telephone = new Uyumsoft.TelephoneType() { Value = dbInvoice.ASP_Contact_Telephone },
                Telefax = new Uyumsoft.TelefaxType() { Value = dbInvoice.ASP_Contact_Telefax },

            };
            if (dbInvoice.ASP_Person_FirstName != "")
            {
                ASP.Party.Person.FirstName = new Uyumsoft.FirstNameType() { Value = dbInvoice.ASP_Person_FirstName };
                ASP.Party.Person.FamilyName = new Uyumsoft.FamilyNameType() { Value = dbInvoice.ASP_Person_FamilyName };
                ASP.Party.Person.MiddleName = new Uyumsoft.MiddleNameType() { Value = dbInvoice.ASP_Person_MiddleName };
                ASP.Party.Person.NameSuffix = new Uyumsoft.NameSuffixType() { Value = dbInvoice.ASP_Person_NameSuffix };
                ASP.Party.Person.Title = new Uyumsoft.TitleType() { Value = dbInvoice.ASP_Person_Title };

            }
            ;


            if (dbInvoice.ASP_AgentParty_PartyName != "")
            {
                ASP.Party.AgentParty = new Uyumsoft.PartyType();
                ASP.Party.AgentParty.PartyName = new Uyumsoft.PartyNameType() { Name = new Uyumsoft.NameType1() { Value = dbInvoice.ASP_AgentParty_PartyName } };
                ASP.Party.AgentParty.WebsiteURI = new Uyumsoft.WebsiteURIType() { Value = dbInvoice.ASP_AgentParty_WebsiteURI };

                ASP.Party.AgentParty.PartyTaxScheme = new Uyumsoft.PartyTaxSchemeType()
                {
                    TaxScheme = new Uyumsoft.TaxSchemeType()
                    {
                        Name = new Uyumsoft.NameType1() { Value = dbInvoice.ASP_AgentParty_PartyTaxSchemeName }
                    }
                };
                if (dbInvoice.ASP_AgentParty_PartyTaxSchemeTaxTypeCode != "") ASP.Party.AgentParty.PartyTaxScheme.TaxScheme.TaxTypeCode = new Uyumsoft.TaxTypeCodeType() { Value = dbInvoice.ASP_AgentParty_PartyTaxSchemeTaxTypeCode };


                if (dbInvoice.ASP_AgentParty_PartyIdentification1_ID != "")
                {
                    ASP.Party.AgentParty.PartyIdentification = new Uyumsoft.PartyIdentificationType[ASP.Party.AgentParty.PartyIdentification.Length + 1];
                    ASP.Party.AgentParty.PartyIdentification[ASP.Party.AgentParty.PartyIdentification.Length - 1] = new Uyumsoft.PartyIdentificationType();
                    ASP.Party.AgentParty.PartyIdentification[ASP.Party.AgentParty.PartyIdentification.Length - 1].ID = new Uyumsoft.IDType { Value = dbInvoice.ASP_AgentParty_PartyIdentification1_ID, schemeID = dbInvoice.ASP_AgentParty_PartyIdentification1_schemeID };
                }

                if (dbInvoice.ASP_AgentParty_PartyIdentification2_ID != "")
                {
                    ASP.Party.AgentParty.PartyIdentification = new Uyumsoft.PartyIdentificationType[ASP.Party.AgentParty.PartyIdentification.Length + 1];
                    ASP.Party.AgentParty.PartyIdentification[ASP.Party.AgentParty.PartyIdentification.Length - 1] = new Uyumsoft.PartyIdentificationType();
                    ASP.Party.AgentParty.PartyIdentification[ASP.Party.AgentParty.PartyIdentification.Length - 1].ID = new Uyumsoft.IDType { Value = dbInvoice.ASP_AgentParty_PartyIdentification2_ID, schemeID = dbInvoice.ASP_AgentParty_PartyIdentification2_schemeID };
                }

                if (dbInvoice.ASP_AgentParty_PartyIdentification3_ID != "")
                {
                    ASP.Party.AgentParty.PartyIdentification = new Uyumsoft.PartyIdentificationType[ASP.Party.AgentParty.PartyIdentification.Length + 1];
                    ASP.Party.AgentParty.PartyIdentification[ASP.Party.AgentParty.PartyIdentification.Length - 1] = new Uyumsoft.PartyIdentificationType();
                    ASP.Party.AgentParty.PartyIdentification[ASP.Party.AgentParty.PartyIdentification.Length - 1].ID = new Uyumsoft.IDType { Value = dbInvoice.ASP_AgentParty_PartyIdentification3_ID, schemeID = dbInvoice.ASP_AgentParty_PartyIdentification3_schemeID };
                }

                if (dbInvoice.ASP_AgentParty_PartyIdentification4_ID != "")
                {
                    ASP.Party.AgentParty.PartyIdentification = new Uyumsoft.PartyIdentificationType[ASP.Party.AgentParty.PartyIdentification.Length + 1];
                    ASP.Party.AgentParty.PartyIdentification[ASP.Party.AgentParty.PartyIdentification.Length - 1] = new Uyumsoft.PartyIdentificationType();
                    ASP.Party.AgentParty.PartyIdentification[ASP.Party.AgentParty.PartyIdentification.Length - 1].ID = new Uyumsoft.IDType { Value = dbInvoice.ASP_AgentParty_PartyIdentification4_ID, schemeID = dbInvoice.ASP_AgentParty_PartyIdentification4_schemeID };
                }

                if (dbInvoice.ASP_AgentParty_PartyIdentification5_ID != "")
                {
                    ASP.Party.AgentParty.PartyIdentification = new Uyumsoft.PartyIdentificationType[ASP.Party.AgentParty.PartyIdentification.Length + 1];
                    ASP.Party.AgentParty.PartyIdentification[ASP.Party.AgentParty.PartyIdentification.Length - 1] = new Uyumsoft.PartyIdentificationType();
                    ASP.Party.AgentParty.PartyIdentification[ASP.Party.AgentParty.PartyIdentification.Length - 1].ID = new Uyumsoft.IDType { Value = dbInvoice.ASP_AgentParty_PartyIdentification5_ID, schemeID = dbInvoice.ASP_AgentParty_PartyIdentification5_schemeID };
                }

                ASP.Party.AgentParty.PostalAddress = new Uyumsoft.AddressType()
                {
                    StreetName = new Uyumsoft.StreetNameType() { Value = dbInvoice.ASP_AgentParty_PostalAddress_StreetName },
                    Room = new Uyumsoft.RoomType() { Value = dbInvoice.ASP_AgentParty_PostalAddress_Room },
                    BuildingNumber = new Uyumsoft.BuildingNumberType() { Value = dbInvoice.ASP_AgentParty_PostalAddress_BuildingNumber },
                    BuildingName = new Uyumsoft.BuildingNameType() { Value = dbInvoice.ASP_AgentParty_PostalAddress_BuildingName },
                    CitySubdivisionName = new Uyumsoft.CitySubdivisionNameType() { Value = dbInvoice.ASP_AgentParty_PostalAddress_CitySubdivisionName },
                    CityName = new Uyumsoft.CityNameType() { Value = dbInvoice.ASP_AgentParty_PostalAddress_CityName },
                    Country = new Uyumsoft.CountryType() { Name = new Uyumsoft.NameType1() { Value = dbInvoice.ASP_AgentParty_PostalAddress_Country } }
                };

                ASP.Party.AgentParty.Contact = new Uyumsoft.ContactType()
                {
                    ElectronicMail = new Uyumsoft.ElectronicMailType() { Value = dbInvoice.ASP_AgentParty_Contact_ElectronicMail },
                    Telephone = new Uyumsoft.TelephoneType() { Value = dbInvoice.ASP_AgentParty_Contact_Telephone },
                    Telefax = new Uyumsoft.TelefaxType() { Value = dbInvoice.ASP_AgentParty_Contact_Telefax },

                };

                if (dbInvoice.ASP_AgentParty_Person_FirstName != "")
                {
                    ASP.Party.AgentParty.Person.FirstName = new Uyumsoft.FirstNameType() { Value = dbInvoice.ASP_AgentParty_Person_FirstName };
                    ASP.Party.AgentParty.Person.FamilyName = new Uyumsoft.FamilyNameType() { Value = dbInvoice.ASP_AgentParty_Person_FamilyName };
                    ASP.Party.AgentParty.Person.MiddleName = new Uyumsoft.MiddleNameType() { Value = dbInvoice.ASP_AgentParty_Person_MiddleName };
                    ASP.Party.AgentParty.Person.NameSuffix = new Uyumsoft.NameSuffixType() { Value = dbInvoice.ASP_AgentParty_Person_NameSuffix };
                    ASP.Party.AgentParty.Person.Title = new Uyumsoft.TitleType() { Value = dbInvoice.ASP_AgentParty_Person_Title };
                }
                ;

            }

            return ASP;
        }

        private static Uyumsoft.CustomerPartyType Convert_DBInvoiceToUyumsoft_CustomerPartyType(Invoice dbInvoice)
        {
            Uyumsoft.CustomerPartyType ACP = new Uyumsoft.CustomerPartyType();
            ACP.Party = new Uyumsoft.PartyType();
            //ACP.Party.PartyName.Name.Value
            ACP.Party.PartyName = new Uyumsoft.PartyNameType { Name = new Uyumsoft.NameType1() { Value = dbInvoice.ACP_PartyName } };
            ACP.Party.WebsiteURI = new Uyumsoft.WebsiteURIType() { Value = dbInvoice.ACP_WebsiteURI };

            ACP.Party.PartyTaxScheme = new Uyumsoft.PartyTaxSchemeType()
            {
                TaxScheme = new Uyumsoft.TaxSchemeType()
                {
                    Name = new Uyumsoft.NameType1() { Value = dbInvoice.ACP_PartyTaxSchemeName }
                }
            };
            if (dbInvoice.ACP_PartyTaxSchemeTaxTypeCode != "") ACP.Party.PartyTaxScheme.TaxScheme.TaxTypeCode = new Uyumsoft.TaxTypeCodeType() { Value = dbInvoice.ACP_PartyTaxSchemeTaxTypeCode };

            if (dbInvoice.ACP_PartyIdentification1_ID != "")
            {
                ACP.Party.PartyIdentification = new Uyumsoft.PartyIdentificationType[ACP.Party.PartyIdentification != null ? ACP.Party.PartyIdentification.Length + 1 : 1];
                ACP.Party.PartyIdentification[ACP.Party.PartyIdentification.Length - 1] = new Uyumsoft.PartyIdentificationType();
                ACP.Party.PartyIdentification[ACP.Party.PartyIdentification.Length - 1].ID = new Uyumsoft.IDType { Value = dbInvoice.ACP_PartyIdentification1_ID, schemeID = dbInvoice.ACP_PartyIdentification1_schemeID };
            }

            if (dbInvoice.ACP_PartyIdentification2_ID != "")
            {
                ACP.Party.PartyIdentification = new Uyumsoft.PartyIdentificationType[ACP.Party.PartyIdentification != null ? ACP.Party.PartyIdentification.Length + 1 : 1];
                ACP.Party.PartyIdentification[ACP.Party.PartyIdentification.Length - 1] = new Uyumsoft.PartyIdentificationType();
                ACP.Party.PartyIdentification[ACP.Party.PartyIdentification.Length - 1].ID = new Uyumsoft.IDType { Value = dbInvoice.ACP_PartyIdentification2_ID, schemeID = dbInvoice.ACP_PartyIdentification2_schemeID };
            }

            if (dbInvoice.ACP_PartyIdentification3_ID != "")
            {
                ACP.Party.PartyIdentification = new Uyumsoft.PartyIdentificationType[ACP.Party.PartyIdentification != null ? ACP.Party.PartyIdentification.Length + 1 : 1];
                ACP.Party.PartyIdentification[ACP.Party.PartyIdentification.Length - 1] = new Uyumsoft.PartyIdentificationType();
                ACP.Party.PartyIdentification[ACP.Party.PartyIdentification.Length - 1].ID = new Uyumsoft.IDType { Value = dbInvoice.ACP_PartyIdentification3_ID, schemeID = dbInvoice.ACP_PartyIdentification3_schemeID };
            }

            if (dbInvoice.ACP_PartyIdentification4_ID != "")
            {
                ACP.Party.PartyIdentification = new Uyumsoft.PartyIdentificationType[ACP.Party.PartyIdentification != null ? ACP.Party.PartyIdentification.Length + 1 : 1];
                ACP.Party.PartyIdentification[ACP.Party.PartyIdentification.Length - 1] = new Uyumsoft.PartyIdentificationType();
                ACP.Party.PartyIdentification[ACP.Party.PartyIdentification.Length - 1].ID = new Uyumsoft.IDType { Value = dbInvoice.ACP_PartyIdentification4_ID, schemeID = dbInvoice.ACP_PartyIdentification4_schemeID };
            }

            if (dbInvoice.ACP_PartyIdentification5_ID != "")
            {
                ACP.Party.PartyIdentification = new Uyumsoft.PartyIdentificationType[ACP.Party.PartyIdentification != null ? ACP.Party.PartyIdentification.Length + 1 : 1];
                ACP.Party.PartyIdentification[ACP.Party.PartyIdentification.Length - 1] = new Uyumsoft.PartyIdentificationType();
                ACP.Party.PartyIdentification[ACP.Party.PartyIdentification.Length - 1].ID = new Uyumsoft.IDType { Value = dbInvoice.ACP_PartyIdentification5_ID, schemeID = dbInvoice.ACP_PartyIdentification5_schemeID };
            }

            ACP.Party.PostalAddress = new Uyumsoft.AddressType()
            {
                StreetName = new Uyumsoft.StreetNameType() { Value = dbInvoice.ACP_PostalAddress_StreetName },
                Room = new Uyumsoft.RoomType() { Value = dbInvoice.ACP_PostalAddress_Room },
                BuildingNumber = new Uyumsoft.BuildingNumberType() { Value = dbInvoice.ACP_PostalAddress_BuildingNumber },
                BuildingName = new Uyumsoft.BuildingNameType() { Value = dbInvoice.ACP_PostalAddress_BuildingName },
                CitySubdivisionName = new Uyumsoft.CitySubdivisionNameType() { Value = dbInvoice.ACP_PostalAddress_CitySubdivisionName },
                CityName = new Uyumsoft.CityNameType() { Value = dbInvoice.ACP_PostalAddress_CityName },
                Country = new Uyumsoft.CountryType() { Name = new Uyumsoft.NameType1() { Value = dbInvoice.ACP_PostalAddress_Country } }
            };

            ACP.Party.Contact = new Uyumsoft.ContactType()
            {
                ElectronicMail = new Uyumsoft.ElectronicMailType() { Value = dbInvoice.ACP_Contact_ElectronicMail },
                Telephone = new Uyumsoft.TelephoneType() { Value = dbInvoice.ACP_Contact_Telephone },
                Telefax = new Uyumsoft.TelefaxType() { Value = dbInvoice.ACP_Contact_Telefax },

            };
            if (dbInvoice.ACP_Person_FirstName != "")
            {
                ACP.Party.Person.FirstName = new Uyumsoft.FirstNameType() { Value = dbInvoice.ACP_Person_FirstName };
                ACP.Party.Person.FamilyName = new Uyumsoft.FamilyNameType() { Value = dbInvoice.ACP_Person_FamilyName };
                ACP.Party.Person.MiddleName = new Uyumsoft.MiddleNameType() { Value = dbInvoice.ACP_Person_MiddleName };
                ACP.Party.Person.NameSuffix = new Uyumsoft.NameSuffixType() { Value = dbInvoice.ACP_Person_NameSuffix };
                ACP.Party.Person.Title = new Uyumsoft.TitleType() { Value = dbInvoice.ACP_Person_Title };

            }
            ;


            if (dbInvoice.ACP_AgentParty_PartyName != "")
            {
                ACP.Party.AgentParty = new Uyumsoft.PartyType();
                ACP.Party.AgentParty.PartyName = new Uyumsoft.PartyNameType() { Name = new Uyumsoft.NameType1() { Value = dbInvoice.ACP_AgentParty_PartyName } };
                ACP.Party.AgentParty.WebsiteURI = new Uyumsoft.WebsiteURIType() { Value = dbInvoice.ACP_AgentParty_WebsiteURI };

                ACP.Party.AgentParty.PartyTaxScheme = new Uyumsoft.PartyTaxSchemeType()
                {
                    TaxScheme = new Uyumsoft.TaxSchemeType()
                    {
                        Name = new Uyumsoft.NameType1() { Value = dbInvoice.ACP_AgentParty_PartyTaxSchemeName }
                    }
                };
                if (dbInvoice.ACP_AgentParty_PartyTaxSchemeTaxTypeCode != "") ACP.Party.AgentParty.PartyTaxScheme.TaxScheme.TaxTypeCode = new Uyumsoft.TaxTypeCodeType() { Value = dbInvoice.ACP_AgentParty_PartyTaxSchemeTaxTypeCode };


                if (dbInvoice.ACP_AgentParty_PartyIdentification1_ID != "")
                {
                    ACP.Party.AgentParty.PartyIdentification = new Uyumsoft.PartyIdentificationType[ACP.Party.AgentParty.PartyIdentification.Length + 1];
                    ACP.Party.AgentParty.PartyIdentification[ACP.Party.AgentParty.PartyIdentification.Length - 1] = new Uyumsoft.PartyIdentificationType();
                    ACP.Party.AgentParty.PartyIdentification[ACP.Party.AgentParty.PartyIdentification.Length - 1].ID = new Uyumsoft.IDType { Value = dbInvoice.ACP_AgentParty_PartyIdentification1_ID, schemeID = dbInvoice.ACP_AgentParty_PartyIdentification1_schemeID };
                }

                if (dbInvoice.ACP_AgentParty_PartyIdentification2_ID != "")
                {
                    ACP.Party.AgentParty.PartyIdentification = new Uyumsoft.PartyIdentificationType[ACP.Party.AgentParty.PartyIdentification.Length + 1];
                    ACP.Party.AgentParty.PartyIdentification[ACP.Party.AgentParty.PartyIdentification.Length - 1] = new Uyumsoft.PartyIdentificationType();
                    ACP.Party.AgentParty.PartyIdentification[ACP.Party.AgentParty.PartyIdentification.Length - 1].ID = new Uyumsoft.IDType { Value = dbInvoice.ACP_AgentParty_PartyIdentification2_ID, schemeID = dbInvoice.ACP_AgentParty_PartyIdentification2_schemeID };
                }

                if (dbInvoice.ACP_AgentParty_PartyIdentification3_ID != "")
                {
                    ACP.Party.AgentParty.PartyIdentification = new Uyumsoft.PartyIdentificationType[ACP.Party.AgentParty.PartyIdentification.Length + 1];
                    ACP.Party.AgentParty.PartyIdentification[ACP.Party.AgentParty.PartyIdentification.Length - 1] = new Uyumsoft.PartyIdentificationType();
                    ACP.Party.AgentParty.PartyIdentification[ACP.Party.AgentParty.PartyIdentification.Length - 1].ID = new Uyumsoft.IDType { Value = dbInvoice.ACP_AgentParty_PartyIdentification3_ID, schemeID = dbInvoice.ACP_AgentParty_PartyIdentification3_schemeID };
                }

                if (dbInvoice.ACP_AgentParty_PartyIdentification4_ID != "")
                {
                    ACP.Party.AgentParty.PartyIdentification = new Uyumsoft.PartyIdentificationType[ACP.Party.AgentParty.PartyIdentification.Length + 1];
                    ACP.Party.AgentParty.PartyIdentification[ACP.Party.AgentParty.PartyIdentification.Length - 1] = new Uyumsoft.PartyIdentificationType();
                    ACP.Party.AgentParty.PartyIdentification[ACP.Party.AgentParty.PartyIdentification.Length - 1].ID = new Uyumsoft.IDType { Value = dbInvoice.ACP_AgentParty_PartyIdentification4_ID, schemeID = dbInvoice.ACP_AgentParty_PartyIdentification4_schemeID };
                }

                if (dbInvoice.ACP_AgentParty_PartyIdentification5_ID != "")
                {
                    ACP.Party.AgentParty.PartyIdentification = new Uyumsoft.PartyIdentificationType[ACP.Party.AgentParty.PartyIdentification.Length + 1];
                    ACP.Party.AgentParty.PartyIdentification[ACP.Party.AgentParty.PartyIdentification.Length - 1] = new Uyumsoft.PartyIdentificationType();
                    ACP.Party.AgentParty.PartyIdentification[ACP.Party.AgentParty.PartyIdentification.Length - 1].ID = new Uyumsoft.IDType { Value = dbInvoice.ACP_AgentParty_PartyIdentification5_ID, schemeID = dbInvoice.ACP_AgentParty_PartyIdentification5_schemeID };
                }

                ACP.Party.AgentParty.PostalAddress = new Uyumsoft.AddressType()
                {
                    StreetName = new Uyumsoft.StreetNameType() { Value = dbInvoice.ACP_AgentParty_PostalAddress_StreetName },
                    Room = new Uyumsoft.RoomType() { Value = dbInvoice.ACP_AgentParty_PostalAddress_Room },
                    BuildingNumber = new Uyumsoft.BuildingNumberType() { Value = dbInvoice.ACP_AgentParty_PostalAddress_BuildingNumber },
                    BuildingName = new Uyumsoft.BuildingNameType() { Value = dbInvoice.ACP_AgentParty_PostalAddress_BuildingName },
                    CitySubdivisionName = new Uyumsoft.CitySubdivisionNameType() { Value = dbInvoice.ACP_AgentParty_PostalAddress_CitySubdivisionName },
                    CityName = new Uyumsoft.CityNameType() { Value = dbInvoice.ACP_AgentParty_PostalAddress_CityName },
                    Country = new Uyumsoft.CountryType() { Name = new Uyumsoft.NameType1() { Value = dbInvoice.ACP_AgentParty_PostalAddress_Country } }
                };

                ACP.Party.AgentParty.Contact = new Uyumsoft.ContactType()
                {
                    ElectronicMail = new Uyumsoft.ElectronicMailType() { Value = dbInvoice.ACP_AgentParty_Contact_ElectronicMail },
                    Telephone = new Uyumsoft.TelephoneType() { Value = dbInvoice.ACP_AgentParty_Contact_Telephone },
                    Telefax = new Uyumsoft.TelefaxType() { Value = dbInvoice.ACP_AgentParty_Contact_Telefax },

                };

                if (dbInvoice.ACP_AgentParty_Person_FirstName != "")
                {
                    ACP.Party.AgentParty.Person.FirstName = new Uyumsoft.FirstNameType() { Value = dbInvoice.ACP_AgentParty_Person_FirstName };
                    ACP.Party.AgentParty.Person.FamilyName = new Uyumsoft.FamilyNameType() { Value = dbInvoice.ACP_AgentParty_Person_FamilyName };
                    ACP.Party.AgentParty.Person.MiddleName = new Uyumsoft.MiddleNameType() { Value = dbInvoice.ACP_AgentParty_Person_MiddleName };
                    ACP.Party.AgentParty.Person.NameSuffix = new Uyumsoft.NameSuffixType() { Value = dbInvoice.ACP_AgentParty_Person_NameSuffix };
                    ACP.Party.AgentParty.Person.Title = new Uyumsoft.TitleType() { Value = dbInvoice.ACP_AgentParty_Person_Title };
                }
                ;

            }

            return ACP;
        }


        private static Uyumsoft.CustomerPartyType Convert_DBInvoiceToUyumsoft_Ihracat_BuyerCustomerParty(Invoice dbInvoice)
        {
            Uyumsoft.CustomerPartyType ACP = new Uyumsoft.CustomerPartyType();
            ACP.Party = new Uyumsoft.PartyType();
            //ACP.Party.PartyName.Name.Value
            ACP.Party.PartyName = new Uyumsoft.PartyNameType { Name = new Uyumsoft.NameType1() { Value = dbInvoice.ACP_PartyName } };
            ACP.Party.WebsiteURI = new Uyumsoft.WebsiteURIType() { Value = dbInvoice.ACP_WebsiteURI };
            ACP.Party.PartyLegalEntity = new Uyumsoft.PartyLegalEntityType[1];
            ACP.Party.PartyLegalEntity[0] = new Uyumsoft.PartyLegalEntityType()
            {
                RegistrationName = new Uyumsoft.RegistrationNameType()
                {
                    Value = dbInvoice.ACP_PartyName
                }
            };

            ACP.Party.PartyTaxScheme = new Uyumsoft.PartyTaxSchemeType()
            {
                RegistrationName = new Uyumsoft.RegistrationNameType() { Value = dbInvoice.ACP_PartyName },
                CompanyID = new Uyumsoft.CompanyIDType() { Value = dbInvoice.ACP_PartyIdentification1_ID },
                TaxScheme = new Uyumsoft.TaxSchemeType()
                {
                    //Name = new Uyumsoft.NameType1() { Value = dbInvoice.ACP_PartyTaxSchemeName },
                    ID = new Uyumsoft.IDType() { Value = "VAT" },
                    TaxTypeCode = new Uyumsoft.TaxTypeCodeType() { Value = "VAT" }
                }
            };
            if (dbInvoice.ACP_PartyTaxSchemeTaxTypeCode != "") ACP.Party.PartyTaxScheme.TaxScheme.TaxTypeCode = new Uyumsoft.TaxTypeCodeType() { Value = dbInvoice.ACP_PartyTaxSchemeTaxTypeCode };

            ACP.Party.PartyIdentification = new Uyumsoft.PartyIdentificationType[1];
            ACP.Party.PartyIdentification[0] = new Uyumsoft.PartyIdentificationType()
            {
                ID = new Uyumsoft.IDType()
                {
                    schemeID = "PARTYTYPE",
                    Value = "EXPORT"
                }
            };

            ACP.Party.PostalAddress = new Uyumsoft.AddressType()
            {
                StreetName = new Uyumsoft.StreetNameType() { Value = dbInvoice.ACP_PostalAddress_StreetName },
                Room = new Uyumsoft.RoomType() { Value = dbInvoice.ACP_PostalAddress_Room },
                BuildingNumber = new Uyumsoft.BuildingNumberType() { Value = dbInvoice.ACP_PostalAddress_BuildingNumber },
                BuildingName = new Uyumsoft.BuildingNameType() { Value = dbInvoice.ACP_PostalAddress_BuildingName },
                CitySubdivisionName = new Uyumsoft.CitySubdivisionNameType() { Value = dbInvoice.ACP_PostalAddress_CitySubdivisionName },
                CityName = new Uyumsoft.CityNameType() { Value = dbInvoice.ACP_PostalAddress_CityName },
                Country = new Uyumsoft.CountryType() { Name = new Uyumsoft.NameType1() { Value = dbInvoice.ACP_PostalAddress_Country } }
            };



            return ACP;
        }

        private static Uyumsoft.CustomerPartyType Convert_DBInvoiceToUyumsoft_Ihracat_CustomerPartyType(Invoice dbInvoice)
        {
            Uyumsoft.CustomerPartyType ACP = new Uyumsoft.CustomerPartyType();
            ACP.Party = new Uyumsoft.PartyType();
            //ACP.Party.PartyName.Name.Value
            ACP.Party.PartyName = new Uyumsoft.PartyNameType { Name = new Uyumsoft.NameType1() { Value = "Gümrük ve Ticaret Bakanlığı" } };
            ACP.Party.WebsiteURI = new Uyumsoft.WebsiteURIType();


            ACP.Party.PartyIdentification = new Uyumsoft.PartyIdentificationType[1];
            ACP.Party.PartyIdentification[0] = new Uyumsoft.PartyIdentificationType() { ID = new Uyumsoft.IDType() { schemeID = "VKN", Value = "1460415308" } };


            ACP.Party.PostalAddress = new Uyumsoft.AddressType()
            {
                StreetName = new Uyumsoft.StreetNameType() { Value = "Üniversiteler Mahallesi Dumlupınar Bulvarı" },
                Room = new Uyumsoft.RoomType(),
                BuildingNumber = new Uyumsoft.BuildingNumberType() { Value = "151" },
                BuildingName = new Uyumsoft.BuildingNameType(),
                CitySubdivisionName = new Uyumsoft.CitySubdivisionNameType() { Value = "Çankaya" },
                CityName = new Uyumsoft.CityNameType() { Value = "Ankara" },
                Country = new Uyumsoft.CountryType() { Name = new Uyumsoft.NameType1() { Value = "Türkiye" } }
            };


            ACP.Party.PartyTaxScheme = new Uyumsoft.PartyTaxSchemeType()
            {
                TaxScheme = new Uyumsoft.TaxSchemeType()
                {
                    Name = new Uyumsoft.NameType1() { Value = "Ulus" }
                }
            };


            return ACP;
        }


        public static string getUyumsoftCurrencyType(string CurrencyCode)
        {
            string retCurr = "TRY";
            switch (CurrencyCode)
            {
                case "TRL":
                case "TRY":
                case "":
                case "TL":
                case "YTL":
                    retCurr = "TRY";
                    break;

                default:
                    retCurr = UT.UCaseEng(CurrencyCode);
                    break;
            }
            return retCurr;
        }



        private static DateTime FixIssueTime(DateTime IssueTime)
        {
            return new DateTime(1900, 1, 1, IssueTime.Hour, IssueTime.Minute, IssueTime.Second);
        }

        private static DateTime DateControl(DateTime d)
        {
            if (d < (new DateTime(1900, 1, 1)))
            {
                d = new DateTime(1900, 1, 1);
            }
            if (d > (new DateTime(2099, 12, 31)))
            {
                d = new DateTime(2099, 12, 31);
            }

            return d;
        }
    }
}
