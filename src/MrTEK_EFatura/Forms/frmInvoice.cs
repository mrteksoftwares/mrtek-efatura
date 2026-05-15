using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MrTEK_EFatura
{
    public partial class frmInvoice : Form
    {
        public frmInvoice()
        {
            InitializeComponent();
            try
            {

                FirmConn.ConnectionString = DF.ActiveConn.dbConnStr;
                FirmConn.UserInfo_UserID = DF.ActiveConn.UserID;
                FirmConn.Open();

            }
            catch (System.Exception ex)
            {
                //UT.RaiseError(this.Name, "frmBaseForm", ex);
            }
        }
        public int InvoiceID { get; set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            try
            {
                tbInvoice.SelectCommand.Parameters["@InvoiceID"].Value = InvoiceID;
                UT.OpenTable(tbInvoice);
                Application.DoEvents();
                tbInvoiceLine.SelectCommand.Parameters["@InvoiceID"].Value = InvoiceID;
                UT.OpenTable(tbInvoiceLine);
                tbInvoice_TaxSubtotal.SelectCommand.Parameters["@InvoiceID"].Value = InvoiceID;
                UT.OpenTable(tbInvoice_TaxSubtotal);

                tbInvoice_WithholdingTaxSubtotal.SelectCommand.Parameters["@InvoiceID"].Value = InvoiceID;
                UT.OpenTable(tbInvoice_WithholdingTaxSubtotal);

                tbInvoice_AllowanceCharge.SelectCommand.Parameters["@InvoiceID"].Value = InvoiceID;
                UT.OpenTable(tbInvoice_AllowanceCharge);

                tbInvoice_OrderReference.SelectCommand.Parameters["@InvoiceID"].Value = InvoiceID;
                UT.OpenTable(tbInvoice_OrderReference);

                tbInvoice_DespatchDocumentReference.SelectCommand.Parameters["@InvoiceID"].Value = InvoiceID;
                UT.OpenTable(tbInvoice_DespatchDocumentReference);

                tbInvoice_PaymentMeans.SelectCommand.Parameters["@InvoiceID"].Value = InvoiceID;
                UT.OpenTable(tbInvoice_PaymentMeans);
                tbInvoice_PaymentTerms.SelectCommand.Parameters["@InvoiceID"].Value = InvoiceID;
                UT.OpenTable(tbInvoice_PaymentTerms);

                tbInvoice_ReceiptDocumentReference.SelectCommand.Parameters["@InvoiceID"].Value = InvoiceID;
                UT.OpenTable(tbInvoice_ReceiptDocumentReference);

                tbInvoice_BillingReference.SelectCommand.Parameters["@InvoiceID"].Value = InvoiceID;
                UT.OpenTable(tbInvoice_BillingReference);

                tbInvoice_Note.SelectCommand.Parameters["@InvoiceID"].Value = InvoiceID;
                UT.OpenTable(tbInvoice_Note);

                btnNewGuid.Enabled = false;
                if (tbInvoice.Rows.Count > 0)
                {
                    if (tbInvoice.Rows[0]["IOType"].ToString() == "0")
                    {
                        btnNewGuid.Enabled = true;
                    }
                    if (tbInvoice.Rows[0]["ProfileID"].ToString() == "TEMELFATURA" && tbInvoice.Rows[0]["InvoiceTypeCode"].ToString() == "IADE")
                    {
                        lblBillingReference.Visible = true;
                        grBillingReference.Visible = true;
                    }
                    else
                    {
                        lblBillingReference.Visible = false;
                        grBillingReference.Visible = false;
                    }
                }
                cboGridTransportModeCode.DataSource = SQ.getTransportModeCode();
                cboGridPackagingTypeCode.DataSource = SQ.getPackagingTypeCode();
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "frmInvoice_Load", ex);
            }
        }

        private void grInvoiceLineView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                int InvoiceLineID = 0;
                if (grInvoiceLineView.FocusedRowHandle >= 0)
                {
                    DataRow dr = grInvoiceLineView.GetDataRow(grInvoiceLineView.FocusedRowHandle);
                    InvoiceLineID = (int)dr["InvoiceLineID"];
                }
                tbInvoiceLine_TaxSubTotal.SelectCommand.Parameters["@InvoiceLineID"].Value = InvoiceLineID;

                UT.OpenTable(tbInvoiceLine_TaxSubTotal);

                tbInvoiceLine_WithholdingTaxSubTotal.SelectCommand.Parameters["@InvoiceLineID"].Value = InvoiceLineID;
                UT.OpenTable(tbInvoiceLine_WithholdingTaxSubTotal);

                tbInvoiceLine_Packages.SelectCommand.Parameters["@InvoiceLineID"].Value = InvoiceLineID;

                UT.OpenTable(tbInvoiceLine_Packages);

                btnLineTax_Save.Enabled = false;
                btnLineTax_Cancel.Enabled = false;
                btnLineTax_Edit.Enabled = true;
                grInvoiceLine_TaxSubTotalView.OptionsBehavior.Editable = false;
                grInvoiceLine_WithholdingTaxSubTotalView.OptionsBehavior.Editable = false;

                 btnIhracatPaketleriKaydet.Enabled = false;
                btnIhracatPaketleriVazgec.Enabled = false;
                btnIhracatPaketleriDegistir.Enabled = true;
                grInvoiceLine_PackagesView.OptionsBehavior.Editable = false;
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "grInvoiceLineView_FocusedRowChanged", ex);
            }
        }

        private void btnLineTax_Cancel_Click(object sender, EventArgs e)
        {
            grInvoiceLine.Enabled = true;
            grInvoiceLineView_FocusedRowChanged(null, null);
            btnLineTax_Save.Enabled = false;
            btnLineTax_Cancel.Enabled = false;
            btnLineTax_Edit.Enabled = true;
            grInvoiceLine_TaxSubTotalView.OptionsBehavior.Editable = false;
            grInvoiceLine_WithholdingTaxSubTotalView.OptionsBehavior.Editable = false;
        }

        private void btnLineTax_Edit_Click(object sender, EventArgs e)
        {
            grInvoiceLine.Enabled = false;
            btnLineTax_Save.Enabled = true;
            btnLineTax_Cancel.Enabled = true;
            btnLineTax_Edit.Enabled = false;
            grInvoiceLine_TaxSubTotalView.OptionsBehavior.Editable = true;
            grInvoiceLine_WithholdingTaxSubTotalView.OptionsBehavior.Editable = true;
        }

        private void btnLineTax_Save_Click(object sender, EventArgs e)
        {
            try
            {
                int InvoiceLineID = 0;
                if (grInvoiceLineView.FocusedRowHandle >= 0)
                {
                    DataRow dr = grInvoiceLineView.GetDataRow(grInvoiceLineView.FocusedRowHandle);
                    InvoiceLineID = (int)dr["InvoiceLineID"];
                }
                else
                {
                    MessageBox.Show("InvoiceLineID bulunamadi!");
                    return;
                }
                foreach (DataRow dr in tbInvoiceLine_TaxSubTotal.Rows)
                {
                    if (dr.RowState != DataRowState.Deleted)
                    {
                        dr["InvoiceLineID"] = InvoiceLineID;
                        dr.EndEdit();
                    }
                }
                foreach (DataRow dr in tbInvoiceLine_WithholdingTaxSubTotal.Rows)
                {
                    if (dr.RowState != DataRowState.Deleted)
                    {
                        dr["InvoiceLineID"] = InvoiceLineID;
                        dr.EndEdit();
                    }
                }

                tbInvoiceLine_TaxSubTotal.Save();
                tbInvoiceLine_WithholdingTaxSubTotal.Save();
                grInvoiceLine.Enabled = true;
                grInvoiceLineView_FocusedRowChanged(null, null);
                btnLineTax_Save.Enabled = false;
                btnLineTax_Cancel.Enabled = false;
                btnLineTax_Edit.Enabled = true;
                grInvoiceLine_TaxSubTotalView.OptionsBehavior.Editable = false;
                grInvoiceLine_WithholdingTaxSubTotalView.OptionsBehavior.Editable = false;

            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "", ex);
            }
        }

        private void tbInvoice_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            try
            {
                e.Row.EndEdit();
                if (e.Row["ProfileID"].ToString() =="TEMELFATURA" && e.Row["InvoiceTypeCode"].ToString() == "IADE") {
                    lblBillingReference.Visible = true;
                    grBillingReference.Visible = true;
                }
                else
                {
                    lblBillingReference.Visible = false;
                    grBillingReference.Visible = false;
                }
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "tbInvoice_ColumnChanged", ex);
            }
        }

        private void tbInvoiceLine_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            try
            {
                e.Row.EndEdit();
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "tbInvoiceLine_ColumnChanged", ex);
            }
        }

        private void tbInvoiceLine_TaxSubTotal_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            try
            {
                e.Row.EndEdit();
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "tbInvoiceLine_TaxSubTotal_ColumnChanged", ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                tbInvoice.Save();
                foreach (DataRow dr in tbInvoiceLine.Rows)
                {
                    if (dr.RowState != DataRowState.Deleted)
                    {
                        dr["InvoiceID"] = tbInvoice.Rows[0]["InvoiceID"];
                        dr.EndEdit();
                    }
                }

                tbInvoiceLine.Save();

                foreach (DataRow dr in tbInvoice_TaxSubtotal.Rows)
                {
                    if (dr.RowState != DataRowState.Deleted)
                    {
                        dr["InvoiceID"] = tbInvoice.Rows[0]["InvoiceID"];
                        dr.EndEdit();
                    }
                }

                tbInvoice_TaxSubtotal.Save();

                foreach (DataRow dr in tbInvoice_WithholdingTaxSubtotal.Rows)
                {
                    if (dr.RowState != DataRowState.Deleted)
                    {
                        dr["InvoiceID"] = tbInvoice.Rows[0]["InvoiceID"];
                        dr.EndEdit();
                    }
                }
                tbInvoice_WithholdingTaxSubtotal.Save();


                foreach (DataRow dr in tbInvoice_AllowanceCharge.Rows)
                {
                    if (dr.RowState != DataRowState.Deleted)
                    {
                        dr["InvoiceID"] = tbInvoice.Rows[0]["InvoiceID"];
                        dr.EndEdit();
                    }
                }
                tbInvoice_AllowanceCharge.Save();


                foreach (DataRow dr in tbInvoice_OrderReference.Rows)
                {
                    if (dr.RowState != DataRowState.Deleted)
                    {
                        dr["InvoiceID"] = tbInvoice.Rows[0]["InvoiceID"];
                        dr.EndEdit();
                    }
                }
                tbInvoice_OrderReference.Save();


                foreach (DataRow dr in tbInvoice_DespatchDocumentReference.Rows)
                {
                    if (dr.RowState != DataRowState.Deleted)
                    {
                        dr["InvoiceID"] = tbInvoice.Rows[0]["InvoiceID"];
                        dr.EndEdit();
                    }
                }
                tbInvoice_DespatchDocumentReference.Save();


                foreach (DataRow dr in tbInvoice_PaymentMeans.Rows)
                {
                    if (dr.RowState != DataRowState.Deleted)
                    {
                        dr["InvoiceID"] = tbInvoice.Rows[0]["InvoiceID"];
                        dr.EndEdit();
                    }
                }
                tbInvoice_PaymentMeans.Save();

                foreach (DataRow dr in tbInvoice_PaymentTerms.Rows)
                {
                    if (dr.RowState != DataRowState.Deleted)
                    {
                        dr["InvoiceID"] = tbInvoice.Rows[0]["InvoiceID"];
                        dr.EndEdit();
                    }
                }
                tbInvoice_PaymentTerms.Save();

                foreach (DataRow dr in tbInvoice_ReceiptDocumentReference.Rows)
                {
                    if (dr.RowState != DataRowState.Deleted)
                    {
                        dr["InvoiceID"] = tbInvoice.Rows[0]["InvoiceID"];
                        dr.EndEdit();
                    }
                }
                tbInvoice_ReceiptDocumentReference.Save();


                foreach (DataRow dr in tbInvoice_Note.Rows)
                {
                    if (dr.RowState != DataRowState.Deleted)
                    {
                        dr["InvoiceID"] = tbInvoice.Rows[0]["InvoiceID"];
                        dr.EndEdit();
                    }
                }
                tbInvoice_Note.Save();

                foreach (DataRow dr in tbInvoice_BillingReference.Rows)
                {
                    if (dr.RowState != DataRowState.Deleted)
                    {
                        dr["InvoiceID"] = tbInvoice.Rows[0]["InvoiceID"];
                        dr.EndEdit();
                    }
                }
                tbInvoice_BillingReference.Save();
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "", ex);
            }
        }

        private void btnShowXslt_Click(object sender, EventArgs e)
        {
            //try
            //{
            if (DF.Integrator == IntegratorType.Uyumsoft)
            {

                Uyumsoft.InvoiceType uInvoice = null;
                Invoice dbInvoice = new Invoice();
                dbInvoice.InvoiceID = InvoiceID;
                dbInvoice.LoadFull();

                if (dbInvoice.IOType == 1)
                {
                    Uyumsoft.IntegrationClient client = EFatura.createClient_Uyumsoft();
                    Uyumsoft.InvoiceResponse res = client.GetInboxInvoice(dbInvoice.UUID);
                    if (res.IsSucceded)
                    {
                        if (res.Value != null)
                        {
                            if (res.Value.Invoice != null)
                            {
                                uInvoice = res.Value.Invoice;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("fatura uyumsoft tan cekilemedi!");
                    }
                }
                else
                {
                    uInvoice = EFaturaConvertor.Convert_DBInvoiceToUyumsoft(dbInvoice);
                }

                if (uInvoice != null)
                {
                    frmInvoiceViewer f = new frmInvoiceViewer(uInvoice);
                    f.XsltNo = dbInvoice.XsltNo;
                    f.ShowDialog();
                }

            }

            //}
            //catch (System.Exception ex)
            //{
            //    UT.RaiseError(this.Name, "", ex);
            //}
        }

        private void grInvoice_Note_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && (e.Control || e.Shift))
            {
                if (grInvoice_NoteView.FocusedRowHandle < 0) return;
                if (MessageBox.Show("Satiri silmek istediginizden emin misini?", "Satir sil?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
                int rowIndex = grInvoice_NoteView.GetDataSourceRowIndex(grInvoice_NoteView.FocusedRowHandle);
                tbInvoice_Note.Rows[rowIndex].Delete();

            }
        }

        private void grInvoice_Note_EditorKeyDown(object sender, KeyEventArgs e)
        {
            grInvoice_Note_KeyDown(sender, e);
        }

        private void btnXMLIndir_Click(object sender, EventArgs e)
        {
            try
            {
                if (DF.Integrator == IntegratorType.Uyumsoft)
                {

                    Uyumsoft.InvoiceType uInvoice = null;
                    Invoice dbInvoice = new Invoice();
                    dbInvoice.InvoiceID = InvoiceID;
                    dbInvoice.LoadFull();

                    if (dbInvoice.IOType == 1)
                    {
                        Uyumsoft.IntegrationClient client = EFatura.createClient_Uyumsoft();
                        Uyumsoft.InvoiceResponse res = client.GetInboxInvoice(dbInvoice.UUID);
                        if (res.IsSucceded)
                        {
                            if (res.Value != null)
                            {
                                if (res.Value.Invoice != null)
                                {
                                    uInvoice = res.Value.Invoice;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("fatura uyumsoft tan cekilemedi!");
                        }
                    }
                    else
                    {
                        uInvoice = EFaturaConvertor.Convert_DBInvoiceToUyumsoft(dbInvoice);
                    }

                    if (uInvoice != null)
                    {
                        //frmInvoiceViewer f = new frmInvoiceViewer(uInvoice);
                        //f.ShowDialog();
                        string xml = "";
                        XmlSerializer serializer = new XmlSerializer(typeof(Uyumsoft.InvoiceType));
                        using (MemoryStream mstr = new MemoryStream())
                        {
                            serializer.Serialize(mstr, uInvoice, DF.InvoiceNamespaces);

                            xml = Encoding.UTF8.GetString(mstr.ToArray());

                        }
                        SaveFileDialog1.OverwritePrompt = true;
                        if (SaveFileDialog1.ShowDialog() != DialogResult.OK) return;

                        StreamWriter sw = new StreamWriter(SaveFileDialog1.FileName);
                        sw.Write(xml);
                        sw.Close();
                        if (MessageBox.Show("Dosyayi acmak istiyor musunuz?", "Dosyayi ac?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start(SaveFileDialog1.FileName);
                            // UT.Shell("Explorer.exe \"" + SaveFileDialog1.FileName + "\"", false);
                        }
                    }

                }

            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "", ex);
            }
        }

        private void btnNewGuid_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Yeni bir UUID verilecektir! Onayliyor musunuz?", "Yeni UUID?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes) return;
                tbInvoice.Rows[0]["UUID"] = Guid.NewGuid();
                tbInvoice.Rows[0].EndEdit();
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "btnNewGuid_Click", ex);
            }
        }

        private void tbInvoiceLine_WithholdingTaxSubTotal_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            try
            {
                e.Row.EndEdit();
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "tbInvoiceLine_WithholdingTaxSubTotal_ColumnChanged", ex);
            }
        }

        private void btnIhracatPaketleriDegistir_Click(object sender, EventArgs e)
        {
            grInvoiceLine.Enabled = false;
            btnIhracatPaketleriKaydet.Enabled = true;
            btnIhracatPaketleriVazgec.Enabled = true;
            btnIhracatPaketleriDegistir.Enabled = false;
            grInvoiceLine_PackagesView.OptionsBehavior.Editable = true;
        }

        private void btnIhracatPaketleriKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                int InvoiceLineID = 0;
                if (grInvoiceLineView.FocusedRowHandle >= 0)
                {
                    DataRow dr = grInvoiceLineView.GetDataRow(grInvoiceLineView.FocusedRowHandle);
                    InvoiceLineID = (int)dr["InvoiceLineID"];
                }
                else
                {
                    MessageBox.Show("InvoiceLineID bulunamadi!");
                    return;
                }
                foreach (DataRow dr in tbInvoiceLine_Packages.Rows)
                {
                    if (dr.RowState != DataRowState.Deleted)
                    {
                        dr["InvoiceLineID"] = InvoiceLineID;
                        dr.EndEdit();
                    }
                }


                tbInvoiceLine_Packages.Save();
                grInvoiceLine.Enabled = true;
                grInvoiceLineView_FocusedRowChanged(null, null);
                btnIhracatPaketleriKaydet.Enabled = false;
                btnIhracatPaketleriVazgec.Enabled = false;
                btnIhracatPaketleriDegistir.Enabled = true;
                grInvoiceLine_PackagesView.OptionsBehavior.Editable = false;
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "", ex);
            }
        }

        private void btnIhracatPaketleriVazgec_Click(object sender, EventArgs e)
        {
            grInvoiceLine.Enabled = true;
            grInvoiceLineView_FocusedRowChanged(null, null);
            btnIhracatPaketleriKaydet.Enabled = false;
            btnIhracatPaketleriVazgec.Enabled = false;
            btnIhracatPaketleriDegistir.Enabled = true;
            grInvoiceLine_PackagesView.OptionsBehavior.Editable = false;
        }

        private void ihracatBilgileriniAltSatırlaraKopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DF.ActiveConn.dbConn;

                if (grInvoiceLineView.FocusedRowHandle < 0) return;


                int rowIndex = grInvoiceLineView.GetDataSourceRowIndex(grInvoiceLineView.FocusedRowHandle);


                if (MessageBox.Show((tbInvoiceLine.Rows.Count-rowIndex-1).ToString() + " adet satir sectiginiz satir ile ihracat bilgileri kopyalanacak(Paketler dahil). Onayliyor musunuz?", "Onay?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;



                for(int i = rowIndex+1; i < tbInvoiceLine.Rows.Count; i++)
                {
                    tbInvoiceLine.Rows[i]["TransportModeCode"] = tbInvoiceLine.Rows[rowIndex]["TransportModeCode"];
                    tbInvoiceLine.Rows[i]["DeliveryTerms"] = tbInvoiceLine.Rows[rowIndex]["DeliveryTerms"];
                    cmd.CommandText = "SELECT COUNT(*) FROM InvoiceLine_Packages WHERE InvoiceLineID=" + tbInvoiceLine.Rows[i]["InvoiceLineID"].ToString();
                    if (cmd.ExecuteScalar().ToInt() == 0)
                    {
                        cmd.CommandText = "INSERT INTO InvoiceLine_Packages(InvoiceLineID,ID,Quantity,PackagingTypeCode) " +
                            " SELECT " + tbInvoiceLine.Rows[i]["InvoiceLineID"].ToString() + ",ID,Quantity,PackagingTypeCode FROM  InvoiceLine_Packages WHERE InvoiceLineID =" + tbInvoiceLine.Rows[rowIndex]["InvoiceLineID"].ToString();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        private void gTIPNOBoşOlanlarıGeçmişKayıtlardanBulDoldurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da;
                DataTable dtItems;
                cmd.Connection = DF.ActiveConn.dbConn;

                if (tbInvoiceLine.Rows.Count == 0)
                    return;

                cmd.Parameters.Clear();
                cmd.CommandText = @"SELECT * FROM Items
                                WHERE GTIPNO<>''
                            ";
                da = new SqlDataAdapter(cmd);
                dtItems = new DataTable();
                da.Fill(dtItems);

                if (dtItems.Rows.Count == 0)
                    return;

                int sayi = 0;
               // int rowIndex = grInvoiceLineView.GetDataSourceRowIndex(grInvoiceLineView.FocusedRowHandle);

                if (MessageBox.Show("Boş GTIPNO alanları geçmiş kayıtlardan bakılarak doldurulacak. Onayliyor musunuz?", "Onay?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                foreach(DataRow dr in tbInvoiceLine.Rows)
                {
                    if (dr["GTIPNO"].ToString().Trim() == "")
                    {
                        var item1 = dr["Item_Name"].ToString();
                        var bFound = false;

                        foreach (DataRow dr2 in dtItems.Rows)
                        {
                            var item2 = dr2["Item_Name"].ToString().Trim();
                            

                            if (item1 == item2)
                            {
                                dr["GTIPNO"] = dr2["GTIPNO"].ToString().Replace(".","").Replace("-","").Replace(" ","");
                                sayi++;
                                bFound = true;
                                break;
                            }
                        }

                        if (bFound == false)
                        {
                            foreach (DataRow dr2 in dtItems.Rows)
                            {
                                var item2 = dr2["Item_Name"].ToString().Trim();
                                                                
                                if (item1.StartsWith(item2))
                                {
                                    dr["GTIPNO"] = dr2["GTIPNO"].ToString().Replace(".", "").Replace("-", "").Replace(" ", "");
                                    sayi++;
                                    bFound = true;
                                    break;
                                }
                                
                            }
                        }

                        if (bFound == false)
                        {
                            foreach (DataRow dr2 in dtItems.Rows)
                            {
                                var item2 = dr2["Item_Name"].ToString().Trim();
                                if (item2.Substring(0, 1) == "*")
                                {
                                    item2 = item2.Replace("*", "");
                                    if (item1.Contains(item2))
                                    {
                                        dr["GTIPNO"] = dr2["GTIPNO"].ToString().Replace(".", "").Replace("-", "").Replace(" ", "");
                                        sayi++;
                                        bFound = true;
                                        break;
                                    }
                                }
                                
                            }
                        }
                    }
                }
                
                MessageBox.Show(sayi.ToString() + "  adet GTIPNO guncellendi");
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        private void paketSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbInvoiceLine_Packages.Rows.Count > 0)
                {
                    if (MessageBox.Show("Paket silinsin mi?", "Paket sil?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                    

                }
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.GetType().Name, MethodBase.GetCurrentMethod().Name, ex);
            }
        }

        private void tbInvoice_BillingReference_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            try
            {
                e.Row.EndEdit();
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "tbInvoice_BillingReference_ColumnChanged", ex);
            }
        }
    }
}
