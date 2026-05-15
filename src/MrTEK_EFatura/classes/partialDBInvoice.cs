using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrTEK_EFatura
{
    public partial class Invoice
    {

        public Invoice_AllowanceCharge[] AllowanceCharge;
        public Invoice_DespatchDocumentReference[] DespatchDocumentReference;
        public Invoice_OrderReference[] OrderReference;
        public Invoice_PaymentMeans[] PaymentMeans;
        public Invoice_PaymentTerms[] PaymentTerms;
        public Invoice_ReceiptDocumentReference[] ReceiptDocumentReference;
        public Invoice_TaxSubtotal[] TaxSubtotal;
        public Invoice_WithholdingTaxSubtotal[] WithholdingTaxSubtotal;
        public Invoice_Note[] Note;
        public InvoiceLine[] InvoiceLine;
        public Invoice_BillingReference[] BillingReferences;

        public bool SaveFull()
        {
            SqlTransaction trans = DF.ActiveConn.dbConn.BeginTransaction(); ;
            //try
            //{
            this.trans = trans;
            if (this.Save() == false) goto rollback;
            if (this.AllowanceCharge != null)
            {
                for (int i = 0; i < this.AllowanceCharge.Length; i++)
                {
                    this.AllowanceCharge[i].InvoiceID = this.InvoiceID;
                    this.AllowanceCharge[i].trans = trans;
                    this.AllowanceCharge[i].Save();
                }
            }

            if (this.DespatchDocumentReference != null)
            {
                for (int i = 0; i < this.DespatchDocumentReference.Length; i++)
                {
                    this.DespatchDocumentReference[i].InvoiceID = this.InvoiceID;
                    this.DespatchDocumentReference[i].trans = trans;
                    this.DespatchDocumentReference[i].Save();
                }
            }

            if (this.OrderReference != null)
            {
                for (int i = 0; i < this.OrderReference.Length; i++)
                {
                    this.OrderReference[i].InvoiceID = this.InvoiceID;
                    this.OrderReference[i].trans = trans;
                    this.OrderReference[i].Save();
                }
            }

            if (this.PaymentMeans != null)
            {
                for (int i = 0; i < this.PaymentMeans.Length; i++)
                {
                    this.PaymentMeans[i].InvoiceID = this.InvoiceID;
                    this.PaymentMeans[i].trans = trans;
                    this.PaymentMeans[i].Save();
                }
            }

            if (this.PaymentTerms != null)
            {
                for (int i = 0; i < this.PaymentTerms.Length; i++)
                {
                    this.PaymentTerms[i].InvoiceID = this.InvoiceID;
                    this.PaymentTerms[i].trans = trans;
                    this.PaymentTerms[i].Save();
                }
            }

            if (this.ReceiptDocumentReference != null)
            {
                for (int i = 0; i < this.ReceiptDocumentReference.Length; i++)
                {
                    this.ReceiptDocumentReference[i].InvoiceID = this.InvoiceID;
                    this.ReceiptDocumentReference[i].trans = trans;
                    this.ReceiptDocumentReference[i].Save();
                }
            }

            if (this.TaxSubtotal != null)
            {
                for (int i = 0; i < this.TaxSubtotal.Length; i++)
                {
                    this.TaxSubtotal[i].InvoiceID = this.InvoiceID;
                    this.TaxSubtotal[i].trans = trans;
                    this.TaxSubtotal[i].Save();
                }
            }

            if (this.WithholdingTaxSubtotal != null)
            {
                for (int i = 0; i < this.WithholdingTaxSubtotal.Length; i++)
                {
                    this.WithholdingTaxSubtotal[i].InvoiceID = this.InvoiceID;
                    this.WithholdingTaxSubtotal[i].trans = trans;
                    this.WithholdingTaxSubtotal[i].Save();
                }
            }

            if (this.Note != null)
            {
                for (int i = 0; i < this.Note.Length; i++)
                {
                    this.Note[i].InvoiceID = this.InvoiceID;
                    this.Note[i].trans = trans;
                    this.Note[i].Save();
                }
            }


            if (this.BillingReferences != null)
            {
                for (int i = 0; i < this.BillingReferences.Length; i++)
                {
                    this.BillingReferences[i].InvoiceID = this.InvoiceID;
                    this.BillingReferences[i].trans = trans;
                    this.BillingReferences[i].Save();
                }
            }

            if (this.InvoiceLine != null)
            {
                for (int i = 0; i < this.InvoiceLine.Length; i++)
                {
                    this.InvoiceLine[i].InvoiceID = this.InvoiceID;
                    this.InvoiceLine[i].trans = trans;
                    this.InvoiceLine[i].SaveFull();
                }
            }

            trans.Commit();
            return true;
            //}
            //catch (System.Exception ex)
            //{
            //    trans.Rollback();
            //    System.Windows.Forms.MessageBox.Show(ex.Message + Environment.NewLine + "Islemler geri alindi!");
            //    UT.RaiseError("Invoice", "SaveFull", ex,false);
            //}
            //return false;
            rollback:
            trans.Rollback();
            System.Windows.Forms.MessageBox.Show("Hata olustu! Islemler geri alindi!");
            return false;
        }

        public bool LoadFull()
        {
            //try
            //{


            if (this.InvoiceID == 0) return false;
            if (this.Load() == false) return false;

            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da;
            DataTable dt;
            cmd.Connection = DF.ActiveConn.dbConn;

            cmd.CommandText = "SELECT nID FROM Invoice_AllowanceCharge WHERE InvoiceID = " + this.InvoiceID.ToString();
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.AllowanceCharge = new Invoice_AllowanceCharge[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    this.AllowanceCharge[i] = new Invoice_AllowanceCharge();
                    this.AllowanceCharge[i].nID = (int)dt.Rows[i]["nID"];
                    if (this.AllowanceCharge[i].Load() == false) return false;
                }
            }
            dt.Dispose();
            da.Dispose();

            cmd.CommandText = "SELECT nID FROM Invoice_DespatchDocumentReference WHERE InvoiceID = " + this.InvoiceID.ToString();
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.DespatchDocumentReference = new Invoice_DespatchDocumentReference[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    this.DespatchDocumentReference[i] = new Invoice_DespatchDocumentReference();
                    this.DespatchDocumentReference[i].nID = (int)dt.Rows[i]["nID"];
                    if (this.DespatchDocumentReference[i].Load() == false) return false;
                }
            }
            dt.Dispose();
            da.Dispose();

            cmd.CommandText = "SELECT nID FROM Invoice_DespatchDocumentReference WHERE InvoiceID = " + this.InvoiceID.ToString();
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.DespatchDocumentReference = new Invoice_DespatchDocumentReference[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    this.DespatchDocumentReference[i] = new Invoice_DespatchDocumentReference();
                    this.DespatchDocumentReference[i].nID = (int)dt.Rows[i]["nID"];
                    if (this.DespatchDocumentReference[i].Load() == false) return false;
                }
            }
            dt.Dispose();
            da.Dispose();


            cmd.CommandText = "SELECT nID FROM Invoice_OrderReference WHERE InvoiceID = " + this.InvoiceID.ToString();
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.OrderReference = new Invoice_OrderReference[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    this.OrderReference[i] = new Invoice_OrderReference();
                    this.OrderReference[i].nID = (int)dt.Rows[i]["nID"];
                    if (this.OrderReference[i].Load() == false) return false;
                }
            }
            dt.Dispose();
            da.Dispose();


            cmd.CommandText = "SELECT nID FROM Invoice_PaymentMeans WHERE InvoiceID = " + this.InvoiceID.ToString();
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.PaymentMeans = new Invoice_PaymentMeans[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    this.PaymentMeans[i] = new Invoice_PaymentMeans();
                    this.PaymentMeans[i].nID = (int)dt.Rows[i]["nID"];
                    if (this.PaymentMeans[i].Load() == false) return false;
                }
            }
            dt.Dispose();
            da.Dispose();


            cmd.CommandText = "SELECT nID FROM Invoice_PaymentTerms WHERE InvoiceID = " + this.InvoiceID.ToString();
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.PaymentTerms = new Invoice_PaymentTerms[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    this.PaymentTerms[i] = new Invoice_PaymentTerms();
                    this.PaymentTerms[i].nID = (int)dt.Rows[i]["nID"];
                    if (this.PaymentTerms[i].Load() == false) return false;
                }
            }
            dt.Dispose();
            da.Dispose();

            cmd.CommandText = "SELECT nID FROM Invoice_ReceiptDocumentReference WHERE InvoiceID = " + this.InvoiceID.ToString();
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.ReceiptDocumentReference = new Invoice_ReceiptDocumentReference[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    this.ReceiptDocumentReference[i] = new Invoice_ReceiptDocumentReference();
                    this.ReceiptDocumentReference[i].nID = (int)dt.Rows[i]["nID"];
                    if (this.ReceiptDocumentReference[i].Load() == false) return false;
                }
            }
            dt.Dispose();
            da.Dispose();

            if (this.Note != null)
            {
                for (int i = 0; i < this.Note.Length; i++)
                {
                    this.Note[i].InvoiceID = this.InvoiceID;
                    this.Note[i].trans = trans;
                    this.Note[i].Save();
                }
            }

            cmd.CommandText = "SELECT nID FROM Invoice_Note WHERE InvoiceID = " + this.InvoiceID.ToString();
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.Note = new Invoice_Note[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    this.Note[i] = new Invoice_Note();
                    this.Note[i].nID = (int)dt.Rows[i]["nID"];
                    if (this.Note[i].Load() == false) return false;
                }
            }
            dt.Dispose();
            da.Dispose();


            cmd.CommandText = "SELECT nID FROM Invoice_TaxSubtotal WHERE InvoiceID = " + this.InvoiceID.ToString();
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.TaxSubtotal = new Invoice_TaxSubtotal[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    this.TaxSubtotal[i] = new Invoice_TaxSubtotal();
                    this.TaxSubtotal[i].nID = (int)dt.Rows[i]["nID"];
                    if (this.TaxSubtotal[i].Load() == false) return false;
                }
            }
            dt.Dispose();
            da.Dispose();


            cmd.CommandText = "SELECT nID FROM Invoice_WithholdingTaxSubtotal WHERE InvoiceID = " + this.InvoiceID.ToString();
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.WithholdingTaxSubtotal = new Invoice_WithholdingTaxSubtotal[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    this.WithholdingTaxSubtotal[i] = new Invoice_WithholdingTaxSubtotal();
                    this.WithholdingTaxSubtotal[i].nID = (int)dt.Rows[i]["nID"];
                    if (this.WithholdingTaxSubtotal[i].Load() == false) return false;
                }
            }
            dt.Dispose();
            da.Dispose();

            cmd.CommandText = "SELECT nID FROM Invoice_BillingReference WHERE InvoiceID = " + this.InvoiceID.ToString();
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.BillingReferences = new Invoice_BillingReference[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    this.BillingReferences[i] = new Invoice_BillingReference();
                    this.BillingReferences[i].nID = (int)dt.Rows[i]["nID"];
                    if (this.BillingReferences[i].Load() == false) return false;
                }
            }
            dt.Dispose();
            da.Dispose();



            cmd.CommandText = "SELECT InvoiceLineID FROM InvoiceLine WHERE InvoiceID = " + this.InvoiceID.ToString();
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.InvoiceLine = new InvoiceLine[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    this.InvoiceLine[i] = new InvoiceLine();
                    this.InvoiceLine[i].InvoiceLineID = (int)dt.Rows[i]["InvoiceLineID"];
                    if (this.InvoiceLine[i].Load() == false) return false;

                    cmd.CommandText = "SELECT nID FROM InvoiceLine_TaxSubtotal WHERE  InvoiceLineID = " + this.InvoiceLine[i].InvoiceLineID.ToString();
                    da = new SqlDataAdapter(cmd);
                    DataTable dt2 = new DataTable();
                    da.Fill(dt2);
                    if (dt2.Rows.Count > 0)
                    {
                        this.InvoiceLine[i].TaxSubtotal = new InvoiceLine_TaxSubtotal[dt2.Rows.Count];
                        for (int j = 0; j < dt2.Rows.Count; j++)
                        {
                            this.InvoiceLine[i].TaxSubtotal[j] = new InvoiceLine_TaxSubtotal();
                            this.InvoiceLine[i].TaxSubtotal[j].nID = (int)dt2.Rows[j]["nID"];
                            this.InvoiceLine[i].TaxSubtotal[j].Load();
                        }

                    }

                    dt2.Dispose();



                    cmd.CommandText = "SELECT nID FROM InvoiceLine_WithholdingTaxSubtotal WHERE  InvoiceLineID = " + this.InvoiceLine[i].InvoiceLineID.ToString();
                    da = new SqlDataAdapter(cmd);
                    dt2 = new DataTable();
                    da.Fill(dt2);
                    if (dt2.Rows.Count > 0)
                    {
                        this.InvoiceLine[i].WithholdingTaxSubtotal = new InvoiceLine_WithholdingTaxSubtotal[dt2.Rows.Count];
                        for (int j = 0; j < dt2.Rows.Count; j++)
                        {
                            this.InvoiceLine[i].WithholdingTaxSubtotal[j] = new InvoiceLine_WithholdingTaxSubtotal();
                            this.InvoiceLine[i].WithholdingTaxSubtotal[j].nID = (int)dt2.Rows[j]["nID"];
                            this.InvoiceLine[i].WithholdingTaxSubtotal[j].Load();
                        }

                    }

                    dt2.Dispose();


                    cmd.CommandText = "SELECT nID FROM InvoiceLine_Packages WHERE  InvoiceLineID = " + this.InvoiceLine[i].InvoiceLineID.ToString();
                    da = new SqlDataAdapter(cmd);
                    dt2 = new DataTable();
                    da.Fill(dt2);
                    if (dt2.Rows.Count > 0)
                    {
                        this.InvoiceLine[i].Packages = new InvoiceLine_Packages[dt2.Rows.Count];
                        for (int j = 0; j < dt2.Rows.Count; j++)
                        {
                            this.InvoiceLine[i].Packages[j] = new InvoiceLine_Packages();
                            this.InvoiceLine[i].Packages[j].nID = (int)dt2.Rows[j]["nID"];
                            this.InvoiceLine[i].Packages[j].Load();
                        }

                    }

                    dt2.Dispose();
                }
            }
            dt.Dispose();
            da.Dispose();

            return true;
            //}
            //catch (System.Exception ex)
            //{
            //    UT.RaiseError("Invoice", "LoadFull", ex);
            //}
            //return false;
        }
    }

    public partial class InvoiceLine
    {
        public InvoiceLine_TaxSubtotal[] TaxSubtotal;
        public InvoiceLine_WithholdingTaxSubtotal[] WithholdingTaxSubtotal;
        public InvoiceLine_Packages[] Packages;

        public bool SaveFull()
        {
            //SqlTransaction trans = DF.ActiveConn.dbConn.BeginTransaction();
            //this.trans = trans;
            if (this.Save() == false) goto rollback;

            if (this.TaxSubtotal != null)
            {
                if (this.TaxSubtotal.Length > 0)
                {
                    for (int i = 0; i < this.TaxSubtotal.Length; i++)
                    {
                        this.TaxSubtotal[i].trans = this.trans;
                        this.TaxSubtotal[i].InvoiceLineID = this.InvoiceLineID;
                        this.TaxSubtotal[i].Save();
                    }
                }
            }
            if (this.WithholdingTaxSubtotal != null)
            {
                if (this.WithholdingTaxSubtotal.Length > 0)
                {
                    for (int i = 0; i < this.WithholdingTaxSubtotal.Length; i++)
                    {
                        this.WithholdingTaxSubtotal[i].trans = this.trans;
                        this.WithholdingTaxSubtotal[i].InvoiceLineID = this.InvoiceLineID;
                        this.WithholdingTaxSubtotal[i].Save();
                    }
                }
            }

            if (this.Packages != null)
            {
                if (this.Packages.Length > 0)
                {
                    for (int i = 0; i < this.Packages.Length; i++)
                    {
                        this.Packages[i].trans = this.trans;
                        this.Packages[i].InvoiceLineID = this.InvoiceLineID;
                        this.Packages[i].Save();
                    }
                }
            }

            //trans.Commit();
            return true;
            rollback:
            //trans.Rollback();
            System.Windows.Forms.MessageBox.Show("Hata olustu! Islemler geri alindi!");
            return false;
        }
    }

}
