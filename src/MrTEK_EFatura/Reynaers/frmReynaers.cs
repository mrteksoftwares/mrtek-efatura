using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MrTEK_EFatura
{
    public partial class frmReynaers : Form
    {
        public frmReynaers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            btnClose.Enabled = false;
            button2.Enabled = false;
            Application.DoEvents();
            txtCode.Text = "";
            try
            {

                string sFileName = Application.ExecutablePath.Replace(".exe", ".ini").Replace(".EXE", ".ini");
                string ImportInvoicePath = UT.INIRead(sFileName, "IMPORT", "ImportInvoicePath", "");
                if (!System.IO.Directory.Exists(ImportInvoicePath))
                {
                    MessageBox.Show("Fatura klasoru bulunamadi!");
                    return;
                }

                if (DF.ActiveConn.StartConn() == false)
                {
                    MessageBox.Show("Sql Baglanti butonundan SQL baglanti ayarlarinizi kontrol ediniz.");
                    return;
                }
                string[] sFiles = System.IO.Directory.GetFiles(ImportInvoicePath, "*.csv");
                if (sFiles == null)
                {
                    MessageBox.Show("iceri alinacak dosya bulunamadi!");
                    return;
                }
                txtCode.Text = "Lutfen bekleyiniz " + sFiles.Length.ToString() + " adet faturanin aktarimi yapiliyor..." + Environment.NewLine;
                for (int i = 0; i < sFiles.Length; i++)
                {
                    txtCode.Text += "File " + (i + 1).ToString() + "/" + sFiles.Length.ToString() + " :" + sFiles[i] + Environment.NewLine;
                    if (importInvoice(sFiles[i]))
                    {
                        txtCode.Text += "Sonuc: Basarili." + Environment.NewLine;
                    }
                    else
                    {
                        txtCode.Text += "Sonuc: Basarisiz." + Environment.NewLine;
                    }
                    txtCode.Text += "-----------------------" + Environment.NewLine;
                    Application.DoEvents();
                }
                button1.Enabled = true;
                btnClose.Enabled = true;
                button2.Enabled = true;
                Application.DoEvents();

            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "button1_Click", ex);
            }
            txtCode.Text += "Aktarim islemleri sona erdi" + Environment.NewLine;
        }

        public bool importInvoice(string csvFileName)
        {
            try
            {
                Application.DoEvents();
                List<Invoice> InvoiceList = new List<Invoice>();
                int InvoiceIndex = -1;
                string HeaderStatus = "";
                StreamReader sr = new StreamReader(csvFileName, (new System.Text.UTF8Encoding()));
                string sFile = sr.ReadToEnd();
                double GenelNakitIskonto = 0;
                double AraToplam = 0;
                double KdvToplam = 0;
                double GenelToplam = 0;
                double GenelNakitIskontoOran = 0;
                string ProjecAciklama1 = "";
                string ProjecAciklama2 = "";
                string ProjecAciklama3 = "";

                sr.Close();
                sFile += Environment.NewLine;
                progressBar1.Value = 0;
                if (sFile.Split(Environment.NewLine.ToCharArray()).Length > 0)
                {
                    progressBar1.Maximum = sFile.Split(Environment.NewLine.ToCharArray()).Length;
                }
                for (int i = 0; i < sFile.Split(Environment.NewLine.ToCharArray()).Length; i++)
                {

                    Application.DoEvents();
                    string sLine = sFile.Split(Environment.NewLine.ToCharArray())[i];
                    if (sLine.Trim() != "")
                    {
                        if (sLine.Split(';').Length > 0)
                        {
                            if (sLine.Split(';')[0] == "HEADER")
                            {
                                if (sLine.Split(';')[1] == "INVOICE")
                                {
                                    HeaderStatus = "HEADERINVOICE";
                                    InvoiceIndex++;


                                    Invoice dbInvoice = new Invoice();
                                    //Invoice date
                                    string gun = sLine.Split(';')[15].Split('/')[0];
                                    string ay = sLine.Split(';')[15].Split('/')[1];
                                    string yil = sLine.Split(';')[15].Split('/')[2];
                                    if (yil.Length == 2) yil = "20" + yil;

                                    dbInvoice.IssueDate = new DateTime(Convert.ToInt32(yil), Convert.ToInt32(ay), Convert.ToInt32(gun));
                                    dbInvoice.IssueTime = new DateTime(dbInvoice.IssueDate.Year, dbInvoice.IssueDate.Month, dbInvoice.IssueDate.Day, 1, 0, 0);
                                    dbInvoice.UUID = Guid.NewGuid().ToString();
                                    dbInvoice.IntCode = sLine.Split(';')[14];
                                    dbInvoice.IOType = 0;
                                    dbInvoice.LocalStatus = 0;
                                    dbInvoice.Status = 0;
                                    dbInvoice.StatusDescription = "";

                                    dbInvoice.ProfileID = DF.glb_InvoiceProfileID;
                                    //if (dbInvoice.ProfileID == "TEMELFATURA")
                                    //{
                                    //    dbInvoice.Status = 5;
                                    //    dbInvoice.StatusDescription = "Onaylanmis";
                                    //}
                                    dbInvoice.InvoiceTypeCode = "SATIS";
                                    dbInvoice.ID = ""; // sonra kaydedilince verilecek. siradaki alalim diye.
                                    dbInvoice.DocumentCurrencyCode = paraBiriminiAyikla(sLine.Split(';')[28]);

                                    if (UT.IsNumeric(sLine.Split(';')[39]))
                                    {
                                        //if (convertDouble(sLine.Split(';')[39]) > 1)
                                        //{
                                        dbInvoice.PricingExchangeRate_CalculationRate = convertDouble(sLine.Split(';')[39]);
                                        dbInvoice.PricingExchangeRate_TargetCurrencyCode = "TRY";
                                        dbInvoice.PricingExchangeRate_Date = dbInvoice.IssueDate;
                                        dbInvoice.PricingExchangeRate_SourceCurrencyCode = dbInvoice.DocumentCurrencyCode;
                                        dbInvoice.PaymentExchangeRate_CalculationRate = dbInvoice.PricingExchangeRate_CalculationRate;
                                        dbInvoice.PaymentExchangeRate_Date = dbInvoice.IssueDate;
                                        dbInvoice.PaymentExchangeRate_SourceCurrencyCode = dbInvoice.DocumentCurrencyCode;
                                        dbInvoice.PaymentExchangeRate_TargetCurrencyCode = "TRY";

                                        //}
                                    }

                                    // Tedarikci firma bilgisi
                                    dbInvoice.ASP_PartyName = "REYNAERS ALÜMİNYUM ÜRETİM SAN. VE TİC. LTD. ŞTİ.";
                                    dbInvoice.ASP_PartyTaxSchemeName = "Bayrampaşa";
                                    dbInvoice.ASP_PartyTaxSchemeTaxTypeCode = "7350618308";
                                    dbInvoice.ASP_PartyIdentification1_ID = "7350618308";
                                    dbInvoice.ASP_PartyIdentification1_schemeID = "VKN";
                                    dbInvoice.ASP_PostalAddress_StreetName = "Esentepe Mah. 23 Temmuz Sok. No:5/1 Şişli";
                                    dbInvoice.ASP_PostalAddress_CitySubdivisionName = "Şişli";
                                    dbInvoice.ASP_PostalAddress_CityName = "ISTANBUL";
                                    dbInvoice.ASP_PostalAddress_Country = "TURKIYE";

                                    dbInvoice.ASP_Contact_ElectronicMail = "info@reynaers.com.tr";
                                    dbInvoice.ASP_Contact_Telephone = "+90 212 465 60 32";
                                    dbInvoice.ASP_Contact_Telefax = "+90 212 465 60 37";
                                    dbInvoice.ASP_WebsiteURI = "http://www.reynaers.com.tr";
                                    //-------------------

                                    // Musteri bilgileri
                                    dbInvoice.ACP_PartyName = (sLine.Split(';')[2].Trim() + " " + sLine.Split(';')[3].Trim()).Trim();
                                    dbInvoice.ACP_PartyIdentification1_schemeID = "VKN";

                                    if (sLine.Split(';')[43].Split('/').Length > 0)
                                    {
                                        dbInvoice.ACP_PartyTaxSchemeName = sLine.Split(';')[43].Split('/')[0].Trim();
                                        dbInvoice.ACP_PartyTaxSchemeTaxTypeCode = sLine.Split(';')[43].Split('/')[1].Replace(" ", "").Replace(".", "");
                                        dbInvoice.ACP_PartyIdentification1_ID = sLine.Split(';')[43].Split('/')[1].Replace(" ", "").Replace(".", ""); ;
                                    }

                                    dbInvoice.ACP_PostalAddress_StreetName = sLine.Split(';')[4] + " " + sLine.Split(';')[5];
                                    dbInvoice.ACP_PostalAddress_CitySubdivisionName = "";
                                    dbInvoice.ACP_PostalAddress_CityName = sLine.Split(';')[8];
                                    dbInvoice.ACP_PostalAddress_Country = "TURKIYE";
                                    var countryCode = sLine.Split(';')[9].Trim();
                                    if (countryCode != "")
                                    {
                                        switch (countryCode)
                                        {
                                            case "TR":
                                                dbInvoice.ACP_PostalAddress_Country = "Turkiye";
                                                break;
                                            case "AZ":
                                            case "AZB":
                                                dbInvoice.ACP_PostalAddress_Country = "Azerbaycan";
                                                break;
                                            case "IR":
                                                dbInvoice.ACP_PostalAddress_Country = "Iran";
                                                break;

                                            default:
                                                dbInvoice.ACP_PostalAddress_Country = countryCode;
                                                break;
                                        }

                                    }
                                    dbInvoice.PostBox = EFatura.checkEFaturaMember_Uyumsoft(dbInvoice.ACP_PartyIdentification1_ID);
                                    if (dbInvoice.PostBox.Length == 0 && countryCode == "TR")
                                    {
                                        dbInvoice.ProfileID = "EARSIVFATURA";
                                    }
                                    else
                                    {
                                        if (dbInvoice.PostBox.Length > 0)
                                        {
                                            dbInvoice.ProfileID = "TEMELFATURA";

                                        }
                                        else if (countryCode != "TR")
                                        {
                                            dbInvoice.ProfileID = "IHRACAT";
                                            dbInvoice.InvoiceTypeCode = "ISTISNA";
                                        }

                                    }

                                    txtCode.Text += Environment.NewLine + "---------------------------" + Environment.NewLine;
                                    txtCode.Text += "" + dbInvoice.ACP_PartyName + Environment.NewLine;
                                    txtCode.Text += "dbInvoice.PostBox:" + dbInvoice.PostBox + Environment.NewLine;
                                    txtCode.Text += "dbInvoice.ProfileID:" + dbInvoice.ProfileID + Environment.NewLine;
                                    txtCode.Text += "dbInvoice.InvoiceTypeCode:" + dbInvoice.InvoiceTypeCode + Environment.NewLine;
                                    txtCode.Text += "countryCode:" + countryCode + Environment.NewLine;
                                    txtCode.Text += "----------------------------" + Environment.NewLine;
                                    Application.DoEvents();
                                    
                                    //-------------
                                    if (sLine.Split(';')[10].Trim() != "")
                                    {
                                        dbInvoice.ACP_Contact_ElectronicMail = sLine.Split(';')[10].Trim();
                                    }
                                    if (sLine.Split(';')[11].Trim() != "")
                                    {
                                        dbInvoice.ACP_Contact_Telephone = sLine.Split(';')[11].Trim();
                                    }
                                    if (sLine.Split(';')[44].Trim() != "" && sLine.Split(';')[45].Trim() != "")
                                    {
                                        Invoice_DespatchDocumentReference DespatchDocumentReference = new Invoice_DespatchDocumentReference();
                                        string gun1 = sLine.Split(';')[45].Split('/')[0];
                                        string ay1 = sLine.Split(';')[45].Split('/')[1];
                                        string yil1 = sLine.Split(';')[45].Split('/')[2];
                                        if (yil1.Length == 2) yil1 = "20" + yil1;

                                        DespatchDocumentReference.ID = sLine.Split(';')[44];
                                        DespatchDocumentReference.IssueDate = new DateTime(Convert.ToInt32(yil1), Convert.ToInt32(ay1), Convert.ToInt32(gun1));
                                        dbInvoice.DespatchDocumentReference = new Invoice_DespatchDocumentReference[1];
                                        dbInvoice.DespatchDocumentReference[0] = DespatchDocumentReference;

                                    }

                                    GenelNakitIskontoOran = 0;
                                    GenelNakitIskonto = 0;
                                    if (UT.IsNumeric(sLine.Split(';')[47]))
                                    {
                                        GenelNakitIskonto = convertDouble(sLine.Split(';')[47]);

                                    }
                                    AraToplam = getPara(sLine.Split(';')[28]);
                                    KdvToplam = getPara(sLine.Split(';')[30]);
                                    GenelToplam = getPara(sLine.Split(';')[32]);
                                    if (GenelToplam == 0)
                                    {
                                        GenelToplam = AraToplam + KdvToplam;
                                    }
                                    if (AraToplam > 0)
                                    {
                                        GenelNakitIskontoOran = GenelNakitIskonto / (AraToplam + GenelNakitIskonto);
                                    }
                                    dbInvoice.LegalMonetaryTotal_LineExtensionAmount = AraToplam;
                                    dbInvoice.LegalMonetaryTotal_TaxExclusiveAmount = AraToplam;
                                    dbInvoice.LegalMonetaryTotal_TaxInclusiveAmount = GenelToplam;
                                    dbInvoice.LegalMonetaryTotal_PayableRoundingAmount = 0;
                                    dbInvoice.LegalMonetaryTotal_PayableAmount = GenelToplam;


                                    dbInvoice.Note = new Invoice_Note[8];
                                    for (int j = 0; j < dbInvoice.Note.Length; j++)
                                    {
                                        dbInvoice.Note[j] = new Invoice_Note();
                                    }
                                    //dbInvoice.Note[0].Note = "YALNIZ:" + sLine.Split(';')[38];
                                    dbInvoice.Note[0].Note = "Sistem fatura No:" + dbInvoice.IntCode;
                                    dbInvoice.Note[1].Note = "";
                                    if (dbInvoice.DocumentCurrencyCode != "TRY")
                                    {
                                        dbInvoice.Note[1].Note = dbInvoice.DocumentCurrencyCode + " Kur:" + dbInvoice.PricingExchangeRate_CalculationRate.ToString();
                                    }
                                    dbInvoice.Note[2].Note = "";  //reduction

                                    dbInvoice.Note[3].Note = "";
                                    if (GenelNakitIskonto > 0)
                                    {
                                        dbInvoice.Note[3].Note = "Cash reduction :" + GenelNakitIskontoOran.ToString() + "%     " + GenelNakitIskonto.ToString();

                                    }
                                    dbInvoice.Note[4].Note = sLine.Split(';')[42]; // "Fatura bedeli, teblig tarihinden itibaren 90 gün içinde ödenmediği takdirde %5 vade farkı uygulanır.";

                                    //--------- vergiler ------------------------------
                                    List<double> vergiOranlar = new List<double>();
                                    List<double> vergiMatrah = new List<double>();
                                    List<double> vergiTutarlar = new List<double>();
                                    //string sVergiOran1 = sLine.Split(';')[12].Replace("%", "").Replace(" ", "");
                                    //string sVergiOran2 = sLine.Split(';')[13].Replace("%", "").Replace(" ", "");
                                    //string sVergiOran3 = sLine.Split(';')[14].Replace("%", "").Replace(" ", "");
                                    //string sVergiTutar1 = sLine.Split(';')[15].Replace("%", "").Replace(" ", "");
                                    //string sVergiTutar2 = sLine.Split(';')[16].Replace("%", "").Replace(" ", "");
                                    //string sVergiTutar3 = sLine.Split(';')[17].Replace("%", "").Replace(" ", "");

                                    string sVergiOran1 = sLine.Split(';')[17].Replace("%", "").Replace(" ", "");
                                    string sVergiOran2 = sLine.Split(';')[18].Replace("%", "").Replace(" ", "");
                                    string sVergiOran3 = sLine.Split(';')[19].Replace("%", "").Replace(" ", "");
                                    string sVergiTutar1 = sLine.Split(';')[20].Replace("%", "").Replace(" ", "");
                                    string sVergiTutar2 = sLine.Split(';')[21].Replace("%", "").Replace(" ", "");
                                    string sVergiTutar3 = sLine.Split(';')[22].Replace("%", "").Replace(" ", "");

                                    if (UT.IsNumeric(sVergiOran1) && UT.IsNumeric(sVergiTutar1))
                                    {
                                        vergiOranlar.Add(convertDouble(sVergiOran1));
                                        vergiMatrah.Add(convertDouble(sVergiTutar1));
                                    }
                                    if (UT.IsNumeric(sVergiOran2) && UT.IsNumeric(sVergiTutar2))
                                    {
                                        vergiOranlar.Add(convertDouble(sVergiOran2));
                                        vergiMatrah.Add(convertDouble(sVergiTutar2));
                                    }
                                    if (UT.IsNumeric(sVergiOran3) && UT.IsNumeric(sVergiTutar3))
                                    {
                                        vergiOranlar.Add(convertDouble(sVergiOran3));
                                        vergiMatrah.Add(convertDouble(sVergiTutar3));
                                    }

                                    dbInvoice.TaxAmount = KdvToplam;
                                    if (vergiOranlar.Count > 0)
                                    {
                                        dbInvoice.TaxSubtotal = new Invoice_TaxSubtotal[1];
                                        for (int j = 0; j < vergiMatrah.Count; j++)
                                        {
                                            if (vergiOranlar[j] != 6)
                                            {
                                                dbInvoice.TaxSubtotal[dbInvoice.TaxSubtotal.Length - 1] = new Invoice_TaxSubtotal();
                                                dbInvoice.TaxSubtotal[dbInvoice.TaxSubtotal.Length - 1].CalculationSequenceNumeric = j + 1;
                                                dbInvoice.TaxSubtotal[dbInvoice.TaxSubtotal.Length - 1].TaxAmount = Math.Round(vergiMatrah[j] * vergiOranlar[j] / 100, 2);
                                                dbInvoice.TaxSubtotal[dbInvoice.TaxSubtotal.Length - 1].TaxableAmount = vergiMatrah[j];
                                                dbInvoice.TaxSubtotal[dbInvoice.TaxSubtotal.Length - 1].Percent_ = vergiOranlar[j];
                                                dbInvoice.TaxSubtotal[dbInvoice.TaxSubtotal.Length - 1].TaxCategory_TaxScheme_TaxTypeCode = "0015";
                                                dbInvoice.TaxSubtotal[dbInvoice.TaxSubtotal.Length - 1].TaxCategory_TaxScheme_Name = "KDV";

                                            }
                                            else
                                            {
                                                dbInvoice.TaxSubtotal[dbInvoice.TaxSubtotal.Length - 1] = new Invoice_TaxSubtotal();
                                                dbInvoice.TaxSubtotal[dbInvoice.TaxSubtotal.Length - 1].CalculationSequenceNumeric = j + 1;
                                                dbInvoice.TaxSubtotal[dbInvoice.TaxSubtotal.Length - 1].TaxAmount = Math.Round(vergiMatrah[j] * 20 / 100, 2);
                                                dbInvoice.TaxSubtotal[dbInvoice.TaxSubtotal.Length - 1].TaxableAmount = vergiMatrah[j];
                                                dbInvoice.TaxSubtotal[dbInvoice.TaxSubtotal.Length - 1].Percent_ = 20;
                                                dbInvoice.TaxSubtotal[dbInvoice.TaxSubtotal.Length - 1].TaxCategory_TaxScheme_TaxTypeCode = "0015";
                                                dbInvoice.TaxSubtotal[dbInvoice.TaxSubtotal.Length - 1].TaxCategory_TaxScheme_Name = "KDV";

                                            }

                                            if (vergiOranlar[j] == 6)
                                            {
                                                dbInvoice.InvoiceTypeCode = "TEVKIFAT";
                                                dbInvoice.WithholdingTaxSubtotal = new Invoice_WithholdingTaxSubtotal[1];

                                                //Array.Resize(ref dbInvoice.TaxSubtotal, dbInvoice.TaxSubtotal.GetUpperBound(0) + 2);

                                                dbInvoice.WithholdingTaxSubtotal[dbInvoice.WithholdingTaxSubtotal.Length - 1] = new Invoice_WithholdingTaxSubtotal();
                                                dbInvoice.WithholdingTaxSubtotal[dbInvoice.WithholdingTaxSubtotal.Length - 1].CalculationSequenceNumeric = j + 1;
                                                //dbInvoice.WithholdingTaxSubtotal[dbInvoice.WithholdingTaxSubtotal.Length - 1].TaxAmount = Math.Round(vergiMatrah[j] * vergiOranlar[j] / 100, 2);
                                                dbInvoice.WithholdingTaxSubtotal[dbInvoice.WithholdingTaxSubtotal.Length - 1].TaxAmount = Math.Round(vergiMatrah[j] * 14 / 100, 2);
                                                dbInvoice.WithholdingTaxSubtotal[dbInvoice.WithholdingTaxSubtotal.Length - 1].TaxableAmount = vergiMatrah[j];
                                                dbInvoice.WithholdingTaxSubtotal[dbInvoice.WithholdingTaxSubtotal.Length - 1].Percent_ = 70;
                                                dbInvoice.WithholdingTaxSubtotal[dbInvoice.WithholdingTaxSubtotal.Length - 1].TaxCategory_TaxScheme_TaxTypeCode = "619";   //619 BAKIR, ÇİNKO VE ALÜMİNYUM ÜRÜNLERİNİN TESLİMİ *GT 117- Bölüm (3.3.2)     5/10
                                                dbInvoice.WithholdingTaxSubtotal[dbInvoice.WithholdingTaxSubtotal.Length - 1].TaxCategory_TaxScheme_Name = "619 BAKIR, ÇİNKO VE ALÜMİNYUM ÜRÜNLERİNİN TESLİMİ *GT 117- Bölüm (3.3.2)     5/10";
                                                dbInvoice.WithholdingTaxAmount = dbInvoice.WithholdingTaxSubtotal[dbInvoice.WithholdingTaxSubtotal.Length - 1].TaxAmount;

                                                // icerisinde tevkifatli vergi varsa, fatura tipi tevkifatli oluyor
                                            }

                                            if (j >= 0 && j < vergiMatrah.Count - 1)
                                            {
                                                Array.Resize(ref dbInvoice.TaxSubtotal, dbInvoice.TaxSubtotal.GetUpperBound(0) + 2);
                                            }
                                        }

                                    }
                                    //----- end of vergiler --------------------------


                                    InvoiceList.Add(dbInvoice);

                                    // txtCode.Text += "Fatura: tarih:" + InvoiceList[InvoiceList.Count - 1].IssueDate.ToString("yyyy-MM-dd") + Environment.NewLine;

                                }
                                else
                                {
                                    HeaderStatus = "HEADERCREDITNOTE";
                                }
                            }

                            if ((sLine.Split(';')[0] == "ORDERINFO" || sLine.Split(';')[0] == "EXTRAINFO") && HeaderStatus == "HEADERINVOICE" && InvoiceList.Count > 0)
                            {
                                if (sLine.Split(';')[1].Trim() != "" && sLine.Split(';')[2].Trim() != "")
                                {
                                    Invoice_OrderReference OrderReference = new Invoice_OrderReference();
                                    string gun1 = sLine.Split(';')[2].Split('/')[0];
                                    string ay1 = sLine.Split(';')[2].Split('/')[1];
                                    string yil1 = sLine.Split(';')[2].Split('/')[2];
                                    if (yil1.Length == 2) yil1 = "20" + yil1;

                                    OrderReference.ID = sLine.Split(';')[1];
                                    OrderReference.IssueDate = new DateTime(Convert.ToInt32(yil1), Convert.ToInt32(ay1), Convert.ToInt32(gun1));
                                    if (InvoiceList[InvoiceList.Count - 1].OrderReference == null)
                                    {
                                        InvoiceList[InvoiceList.Count - 1].OrderReference = new Invoice_OrderReference[1];
                                    }
                                    else
                                    {
                                        Array.Resize(ref InvoiceList[InvoiceList.Count - 1].OrderReference, InvoiceList[InvoiceList.Count - 1].OrderReference.GetUpperBound(0) + 2);
                                    }
                                    InvoiceList[InvoiceList.Count - 1].OrderReference[InvoiceList[InvoiceList.Count - 1].OrderReference.Length - 1] = OrderReference;
                                    ProjecAciklama1 = sLine.Split(';').Length > 3 ? sLine.Split(';')[3].Trim() : "";
                                    ProjecAciklama2 = sLine.Split(';').Length > 4 ? "Proje No: " + sLine.Split(';')[4].Trim() : "";

                                    ProjecAciklama3 = sLine.Split(';').Length > 5 ? sLine.Split(';')[5].Trim() : "";
                                    ProjecAciklama3 += sLine.Split(';').Length > 6 ? sLine.Split(';')[6].Trim() : "";
                                    if (InvoiceList[InvoiceList.Count - 1].Note.Length >= 8)
                                    {
                                        // Array.Resize(ref InvoiceList[InvoiceList.Count - 1].Note, 5);
                                        InvoiceList[InvoiceList.Count - 1].Note[5] = new Invoice_Note() { Note = ProjecAciklama3 };
                                        InvoiceList[InvoiceList.Count - 1].Note[6] = new Invoice_Note() { Note = ProjecAciklama2 };
                                        InvoiceList[InvoiceList.Count - 1].Note[7] = new Invoice_Note() { Note = ProjecAciklama1 };

                                    }

                                }
                            }
                            if (sLine.Split(';')[0] == "REDUCTION")
                            {
                                if (sLine.Split(';').Length >= 6)
                                {
                                    if (InvoiceList[InvoiceList.Count - 1].Note[2].Note.Trim() != "")
                                    {
                                        InvoiceList[InvoiceList.Count - 1].Note[2].Note += " ,<br> ";
                                    }
                                    InvoiceList[InvoiceList.Count - 1].Note[2].Note += "Iskonto orani: " + sLine.Split(';')[2] + "    " + sLine.Split(';')[1] + " = " + sLine.Split(';')[3] + "%  " + sLine.Split(';')[4] + "    " + sLine.Split(';')[5];
                                }

                            }

                            sLine = sLine.Replace(Environment.NewLine, "");


                            if (sLine.Split(';')[0] == "LINES")
                            {
                                if (sLine.Split(';').Length < 12)
                                {
                                    txtCode.Text += "HATA: Satir Hatasi! Fatura No:" + InvoiceList[InvoiceList.Count - 1].IntCode;
                                    if (sLine.Split(';').Length >= 2)
                                    {
                                        txtCode.Text += "   Hatali Satir:" + sLine.Split(';')[1];
                                    }
                                    txtCode.Text += Environment.NewLine;
                                    InvoiceList[InvoiceList.Count - 1].Deleted = -1;
                                }
                                else
                                {
                                    //txtCode.Text += "Satir:" + sLine.Split(';')[1] + Environment.NewLine;
                                    InvoiceLine InvLine = new InvoiceLine();
                                    //InvLine.ID = sLine.Split(';')[2].Trim();
                                    //InvLine.ID = (InvoiceList.Count + 1).ToString();
                                    if(InvoiceList[InvoiceList.Count - 1].InvoiceLine == null)
                                    {
                                        InvLine.ID = "1";
                                    }
                                    else
                                    {
                                        InvLine.ID = (InvoiceList[InvoiceList.Count - 1].InvoiceLine.Length + 1).ToString();
                                    }
                                    
                                    InvLine.Item_SellersItemIdentification_ID = sLine.Split(';')[2].Trim();

                                    if (sLine.Split(';')[5].Trim() != "")
                                        InvLine.Item_Name = sLine.Split(';')[2].Trim() + " - " + sLine.Split(';')[5].Trim();
                                    else
                                        InvLine.Item_Name = sLine.Split(';')[2].Trim() + " - " + sLine.Split(';')[4].Trim();


                                    InvLine.Item_Description = sLine.Split(';')[2].Trim() + " - " + sLine.Split(';')[5].Trim();


                                    if (sLine.Split(';')[6].Trim() != "0")
                                    {
                                        InvLine.Note = sLine.Split(';')[6].Trim() + " x " + sLine.Split(';')[7].Trim();
                                    }
                                    double Uzunluk = 1;
                                    double Adet = 0;
                                    double Fiyat = 0;
                                    if (UT.IsNumeric(sLine.Split(';')[6].Trim())) Uzunluk = convertDouble(sLine.Split(';')[6].Trim());
                                    if (UT.IsNumeric(sLine.Split(';')[7].Trim())) Adet = convertDouble(sLine.Split(';')[7].Trim());
                                    if (UT.IsNumeric(sLine.Split(';')[8].Trim())) Fiyat = convertDouble(sLine.Split(';')[8].Trim());
                                    if (Uzunluk == 0) Uzunluk = 1;

                                    InvLine.InvoicedQuantity = Adet * Uzunluk;
                                    InvLine.InvoicedQuantity_unitCode = "NIU";

                                    if (sLine.Split(';').Length >= 18)
                                    {
                                        switch (UT.UCaseEng(sLine.Split(';')[17].Trim()))
                                        {
                                            case "LENGTH":
                                            case "LENGTE":
                                            case "LEN":
                                                InvLine.InvoicedQuantity_unitCode = "LN";
                                                break;
                                            case "PIECES":
                                            case "PIECE":
                                            case "PCS":
                                                InvLine.InvoicedQuantity_unitCode = "NIU";
                                                break;
                                            case "SETS":
                                            case "SET":
                                                InvLine.InvoicedQuantity_unitCode = "SET";
                                                break;
                                            case "METER":
                                            case "METRE":
                                            case "MT":
                                            case "MTR":
                                                InvLine.InvoicedQuantity_unitCode = "MTR";
                                                break;
                                            case "LM":
                                                InvLine.InvoicedQuantity_unitCode = "LM";
                                                break;
                                            default:
                                                InvLine.InvoicedQuantity_unitCode = "NIU";
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        InvLine.InvoicedQuantity_unitCode = "NIU";
                                    }


                                    //}

                                    InvLine.LineExtensionAmount = convertDouble(sLine.Split(';')[9].Trim()); // Math.Round(InvLine.InvoicedQuantity * InvLine.PriceAmount, 2);
                                    if (InvLine.InvoicedQuantity != 0)
                                    {
                                        Fiyat = Math.Round(InvLine.LineExtensionAmount / InvLine.InvoicedQuantity, 4);
                                    }
                                    InvLine.PriceAmount = Fiyat;
                                    // satirdaki indirimler
                                    if (UT.IsNumeric(sLine.Split(';')[10].Trim()))
                                    {
                                        if (sLine.Split(';').Length >= 17)
                                        {
                                            InvLine.AllowanceCharge_AllowanceChargeReason = "INDIRIM " + sLine.Split(';')[16].Trim() + ":%" + convertDouble(sLine.Split(';')[10].Trim());
                                        }
                                        else
                                        {
                                            InvLine.AllowanceCharge_AllowanceChargeReason = "INDIRIM " + convertDouble(sLine.Split(';')[10].Trim());
                                        }

                                        if (GenelNakitIskontoOran > 0)
                                        {
                                            InvLine.AllowanceCharge_AllowanceChargeReason += "  Nakit:%" + Math.Round(GenelNakitIskontoOran * 100, 2);
                                        }
                                        double SatirTutar = convertDouble(sLine.Split(';')[9].Trim());
                                        double SatirIndirimOran = convertDouble(sLine.Split(';')[10].Trim()) / 100;
                                        double SatirAraToplam = 0;
                                        SatirAraToplam = Math.Round(SatirTutar - (SatirIndirimOran * SatirTutar), 2);
                                        SatirAraToplam = SatirAraToplam - Math.Round((GenelNakitIskontoOran * SatirAraToplam), 2);
                                        InvLine.AllowanceCharge_ChargeIndicator = true;

                                        InvLine.AllowanceCharge_BaseAmount = SatirTutar;
                                        InvLine.AllowanceCharge_Amount = SatirTutar - SatirAraToplam;
                                        if (InvLine.AllowanceCharge_BaseAmount != 0)
                                        {
                                            InvLine.AllowanceCharge_MultiplierFactorNumeric = InvLine.AllowanceCharge_Amount / InvLine.AllowanceCharge_BaseAmount;
                                        }
                                        else
                                        {
                                            InvLine.AllowanceCharge_MultiplierFactorNumeric = 0;
                                        }


                                    }

                                    if (InvoiceList[InvoiceList.Count - 1].InvoiceLine == null)
                                    {
                                        InvoiceList[InvoiceList.Count - 1].InvoiceLine = new InvoiceLine[1];
                                    }
                                    else
                                    {
                                        Array.Resize(ref InvoiceList[InvoiceList.Count - 1].InvoiceLine, InvoiceList[InvoiceList.Count - 1].InvoiceLine.GetUpperBound(0) + 2);
                                    }

                                    InvoiceList[InvoiceList.Count - 1].InvoiceLine[InvoiceList[InvoiceList.Count - 1].InvoiceLine.Length - 1] = InvLine;
                                }
                            }

                        }
                    }
                    progressBar1.Value = i + 1;
                    Application.DoEvents();

                }



                // KAYIT BOLUMU
                int realizedInvoice = 0;

                for (int i = 0; i < InvoiceList.Count; i++)
                {
                    //if (eFaturaMukellefiMi(InvoiceList[i].ACP_PartyIdentification1_ID) == false)
                    //{
                    //    InvoiceList[i].Deleted = -1;
                    //}
                    if (InvoiceList[i].Deleted == 0)
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = DF.ActiveConn.dbConn;
                        cmd.Parameters.Clear();
                        cmd.Parameters.Add(new SqlParameter("@IntCode", InvoiceList[i].IntCode));
                        cmd.Parameters.Add(new SqlParameter("@IssueDate", InvoiceList[i].IssueDate));
                        cmd.CommandText = "SELECT COUNT(*) FROM Invoice WHERE Deleted = 0 AND IOType=0 AND IntCode=@IntCode AND YEAR(IssueDate)=YEAR(@IssueDate) ";
                        if ((int)cmd.ExecuteScalar() <= 0)
                        {
                            // genel indirimi duzenle
                            if (InvoiceList[i].InvoiceLine != null)
                            {
                                double TIndirim = 0;
                                double TBaseAmount = 0;
                                double TSatirTutar = 0;
                                for (int j = 0; j < InvoiceList[i].InvoiceLine.Length; j++)
                                {
                                    TSatirTutar += InvoiceList[i].InvoiceLine[j].LineExtensionAmount;
                                    TIndirim += InvoiceList[i].InvoiceLine[j].AllowanceCharge_Amount;
                                    TBaseAmount += InvoiceList[i].InvoiceLine[j].AllowanceCharge_BaseAmount;
                                }
                                if (TIndirim > 0)
                                {
                                    InvoiceList[i].AllowanceCharge = new Invoice_AllowanceCharge[1];
                                    InvoiceList[i].AllowanceCharge[0] = new Invoice_AllowanceCharge();
                                    InvoiceList[i].AllowanceCharge[0].AllowanceChargeReason = "INDIRIM";
                                    InvoiceList[i].AllowanceCharge[0].Amount = TIndirim;
                                    InvoiceList[i].AllowanceCharge[0].BaseAmount = TBaseAmount;
                                    InvoiceList[i].AllowanceCharge[0].ChargeIndicator = true;
                                }
                                InvoiceList[i].LegalMonetaryTotal_LineExtensionAmount = TSatirTutar;
                                InvoiceList[i].LegalMonetaryTotal_AllowanceTotalAmount = TIndirim;
                                if (InvoiceList[i].LegalMonetaryTotal_TaxInclusiveAmount == 0)
                                {
                                    InvoiceList[i].LegalMonetaryTotal_TaxInclusiveAmount = TSatirTutar;
                                }

                                if (InvoiceList[i].LegalMonetaryTotal_PayableAmount == 0)
                                {
                                    InvoiceList[i].LegalMonetaryTotal_PayableAmount = TSatirTutar;
                                }

                                if (InvoiceList[i].LegalMonetaryTotal_TaxExclusiveAmount == 0)
                                {
                                    InvoiceList[i].LegalMonetaryTotal_TaxExclusiveAmount = TSatirTutar;
                                }
                                InvoiceList[i].LineCountNumeric = InvoiceList[i].InvoiceLine.Length;
                            }

                            double TaxTotal = 0;
                            if (InvoiceList[i].TaxSubtotal != null)
                            {
                                for (int k = 0; k < InvoiceList[i].TaxSubtotal.Length; k++)
                                {
                                    if (InvoiceList[i].TaxSubtotal[k].TaxCategory_TaxScheme_TaxTypeCode == "0015")
                                    {
                                        TaxTotal += InvoiceList[i].TaxSubtotal[k].TaxAmount;
                                    }
                                }
                            }

                            InvoiceList[i].TaxAmount = TaxTotal;
                            InvoiceList[i].LegalMonetaryTotal_TaxExclusiveAmount = InvoiceList[i].LegalMonetaryTotal_TaxInclusiveAmount - TaxTotal;

                            string Para = InvoiceList[i].DocumentCurrencyCode;
                            string Kurus = "Kurus";
                            switch (Para)
                            {
                                case "TRY":
                                    Kurus = "Kurus";
                                    break;
                                case "USD":
                                    Kurus = "Cent";
                                    break;
                                case "EURO":
                                    Kurus = "EuroCent";
                                    break;
                                default:
                                    Kurus = "Kurus";
                                    break;
                            }


                            //cmd.CommandText = "SELECT dbo.fnYaziTura(" + UT.CommaToPoint(InvoiceList[i].LegalMonetaryTotal_TaxInclusiveAmount) + ",1,'" + Para + "','" + Kurus + "') as YaziTura ";
                            //InvoiceList[i].Note[0].Note = "YALNIZ :" + UT.IfNull(cmd.ExecuteScalar(), "").ToString();
                            //InvoiceList[i].Note[0].Note = "YALNIZ :" + sLine.Split(';')[38].Trim();

                            //InvoiceList[i].Note[1] = new Invoice_Note();
                            //InvoiceList[i].Note[1].Note = "Sistem fatura No:" + InvoiceList[i].IntCode;
                            //------------

                            InvoiceList[i].ID = newInvoiceID(InvoiceList[i].ProfileID, InvoiceList[i].IssueDate.Year);
                            txtCode.Text += "InvoiceList[i].ID = newInvoiceID :" + InvoiceList[i].ProfileID + " , " + InvoiceList[i].IssueDate.Year.ToString() + " , " + InvoiceList[i].ID + Environment.NewLine;
                            if (InvoiceList[i].SaveFull())
                            {
                                txtCode.Text += "Fatura No:" + InvoiceList[i].IntCode + " // ID:" + InvoiceList[i].ID + Environment.NewLine;
                                Application.DoEvents();
                                realizedInvoice++;
                            }
                            else
                            {
                                MessageBox.Show("Test");
                            }

                        }
                    }
                }
                txtCode.Text += "toplam fatura basarili:" + realizedInvoice.ToString() + Environment.NewLine;
                txtCode.Text += "hatali fatura: " + (InvoiceList.Count - realizedInvoice).ToString() + Environment.NewLine;
                Application.DoEvents();
                return true;
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "importInvoice", ex);
            }
            return false;
        }

        //private string eFaturaMukellefiMi(string TaxNumber)
        //{
        //    try
        //    {

        //        TaxNumber = TaxNumber.Replace(" ", "").Trim();
        //        string postBoxAlias = EFatura.checkEFaturaMember_Uyumsoft(TaxNumber);
        //        if (postBoxAlias.Length > 0)
        //        {
        //            return postBoxAlias;
        //        }
        //    }
        //    catch (System.Exception ex)
        //    {
        //        //UT.RaiseError(this.Name, "eFaturaMukelle11fiMi", ex);
        //    }
        //    return "";
        //}
       
        //private bool eF1111aturaMukellefiMi(string TaxNumber)
        //{
        //    try
        //    {

        //        // test icin tum faturalari cekebiliyoruz...
        //        string sbuf = "";
        //        string sFileName = Application.ExecutablePath.Replace(".exe", ".ini").Replace(".EXE", ".ini"); ;

        //        sbuf = UT.INIRead(sFileName, "IMPORT", "TESTAllInvoice", bool.TrueString);
        //        if (sbuf == bool.TrueString) return true;

        //        SqlCommand cmd = new SqlCommand();
        //        TaxNumber = TaxNumber.Replace(" ", "").Trim();
        //        cmd.Connection = DF.ActiveConn.dbConn;
        //        cmd.Parameters.Clear();
        //        cmd.Parameters.Add(new SqlParameter("@VKN", TaxNumber));

        //        cmd.CommandText = "SELECT COUNT(*) FROM EFaturaMembers WHERE VKN=@VKN";
        //        if ((int)cmd.ExecuteScalar() > 0)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch (System.Exception ex)
        //    {
        //        UT.RaiseError(this.Name, "eFatur111aMukellefiMi", ex);
        //    }
        //    return false;
        //}

        private double convertDouble(string text)
        {
            try
            {

                text = text.Trim();
                text = text.Replace(",", "");
                text = text.Replace(".", UT.DecimalPointer());
                if (text.Length > 1)
                {
                    if (text.Substring(0, 1) == ".")
                    {
                        text = "0" + text;
                    }
                }
                return Convert.ToDouble(text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Sayi cevrim hatasi:" + text + Environment.NewLine + ex.Message);
            }
            return 0;
        }
        public double getPara(string text)
        {
            string sPara = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= '0' && text[i] <= '9' || text[i] == ',' || text[i] == '.')
                {
                    sPara += text[i];
                }
            }
            if (UT.IsNumeric(sPara))
            {
                return convertDouble(sPara);
            }
            else
            {
                return 0;
            }

        }

        public string newInvoiceID(string profileID, int yil)
        {
            try
            {
                string sID = "";
                if (DF.Param_InvoicePrefix.Length < 3) DF.Param_InvoicePrefix = "REY";
                if (DF.Param_EArchivePrefix.Length < 3) DF.Param_EArchivePrefix = "ERS";

                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da;
                DataTable dt;
                cmd.Connection = DF.ActiveConn.dbConn;
                //EARSIVFATURA
                if (profileID == "EARSIVFATURA")
                {
                    cmd.CommandText = "SELECT TOP 1 ID FROM Invoice WHERE IOType=0 AND ID Like '" + DF.Param_EArchivePrefix + yil.ToString() + "%' ORDER BY ID DESC";
                }
                else
                {
                    cmd.CommandText = "SELECT TOP 1 ID FROM Invoice WHERE IOType=0 AND ID Like '" + DF.Param_InvoicePrefix + yil.ToString() + "%' ORDER BY ID DESC";
                }

                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    sID = UT.IfNull(dt.Rows[0]["ID"], "").ToString();
                }
                else
                {
                    if (profileID == "EARSIVFATURA")
                    {
                        sID = DF.Param_EArchivePrefix + yil.ToString() + "000000000";
                    }
                    else
                    {
                        sID = DF.Param_InvoicePrefix + yil.ToString() + "000000000";
                    }

                }
                long sonFatNo =Convert.ToInt64(sID.Substring(7));
                //sID = UT.IncBelgeNo(sID);
                sonFatNo++;
                sID = sID.Substring(0, 7) + sonFatNo.ToString("000000000");
                return sID;
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "newInvoiceID", ex);
            }
            return "";
        }
        public string paraBiriminiAyikla(string text)
        {
            string paraBirimi = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 'A' && text[i] <= 'Z' || text[i] >= 'a' && text[i] <= 'z')
                {
                    paraBirimi += text[i];
                }
            }
            paraBirimi = paraBirimi.ToUpper();
            switch (paraBirimi)
            {
                case "TL":
                case "TRL":
                    paraBirimi = "TRY";
                    break;
                default:
                    break;
            }

            return paraBirimi;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                loadOptions();
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "", ex);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                frmDBOptions f = new frmDBOptions();
                f.ShowDialog();
                f.Dispose();
                loadOptions();
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "", ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void loadOptions()
        {
            try
            {
                string sFileName = Application.ExecutablePath.Replace(".exe", ".ini").Replace(".EXE", ".ini"); ;
                DF.glb_InvoiceProfileID = UT.INIRead(sFileName, "INVOICE", "ProfileID", "TICARIFATURA");

            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "", ex);
            }
        }
    }
}
