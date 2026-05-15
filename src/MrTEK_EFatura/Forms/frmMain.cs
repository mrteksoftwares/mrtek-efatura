//using MrTEK_EFatura.Uyumsoft;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrTEK_EFatura
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            try
            {

                FirmConn.ConnectionString = DF.ActiveConn.dbConnStr;
                FirmConn.UserInfo_UserID = DF.ActiveConn.UserID;
                FirmConn.Open();
                UT.generateCreateModifiedMenu("Main", grEFaturaMembers, "", "");
                UT.generateCreateModifiedMenu("Main", grGelenKutusu, "", "");
                UT.generateCreateModifiedMenu("Main", grGidenKutusu, "", "");
                UT.generateCreateModifiedMenu("Main", grGonderilmisler, "", "");

            }
            catch (System.Exception ex)
            {
                //UT.RaiseError(this.Name, "frmBaseForm", ex);
            }
        }

        private void List_GelenKutusu()
        {
            try
            {
                //userCntDateFilter1.da
                tbInvoice_GelenKutusu.SelectCommand.Parameters["@FormDate1"].Value = userCntDateFilter1.Date1;
                tbInvoice_GelenKutusu.SelectCommand.Parameters["@FormDate2"].Value = userCntDateFilter1.Date2;
                UT.OpenTable(tbInvoice_GelenKutusu);


            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "", ex);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                userCntDateFilter1.DateFilter = true;
                userCntDateFilter1.setThisYear();
                
                lblStatus_Server.Text = DF.ActiveConn.dbConn.DataSource;
                lblStatus_Database.Text = DF.ActiveConn.dbConn.Database;
                lblStatus_ProgramVersion.Text = UP.ProgramVersion;
                UT.LoadFormGrids(this);
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "", ex);
            }
        }










        //private void btnSync_Click(object sender, EventArgs e)
        //{

        //}

        private bool runStoredProcedure()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DF.ActiveConn.dbConn;
                cmd.CommandText = "exec dbo.spSYNC_MukellefleriIsaretle";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "exec dbo.spSYNC_EFaturalariCek";
                cmd.ExecuteNonQuery();

            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "runStoredProcedure", ex);
            }
            return false;
        }
        private bool runExpternalExe()
        {
            try
            {
                string sFileName = Application.ExecutablePath.Replace(".exe", ".ini").Replace(".EXE", ".ini"); ;
                string ExternalExeFileName = UT.INIRead(sFileName, "SYNC", "ExternalExe", "");
                if (ExternalExeFileName.Trim() == "")
                {
                    MessageBox.Show("External exe yolu tanimlanmamis. Lutfen acilista ayarlara girip EXE dosya yolunu belirtiniz.");
                    return false;
                }
                UT.Shell(ExternalExeFileName, true);

                return true;
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "runExpternalExe", ex);
            }
            return false;
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.T && e.Control && e.Alt)
            {
                Form1 f = new Form1();
                f.Show();
            }
            if (e.KeyCode == Keys.F9)
            {
                cmdPrintXSLTSingle_Click(null, null);
            }
        }

        private void btnDownloadEFaturaMukellef_Click(object sender, EventArgs e)
        {
            try
            {
                showHideWait(true);
                lblStatus.Text = "Efatura mukellefleri indiriliyor...";
                Application.DoEvents();
                if (DF.Integrator == IntegratorType.Uyumsoft)
                {
                    EFatura.downloadEFaturaMembers_Uyumsoft();
                }

                showHideWait(false);
                btnListeleEFaturaMukellefleri_Click(null, null);
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "DownloadEFaturaMukellef", ex);
            }
        }

        void showHideWait(bool bShow)
        {
            panelWait.Parent = this;
            panelWait.SendToBack();
            panelWait.Dock = DockStyle.Fill;

            panelWait.Visible = bShow;
            if (bShow)
            {
                panelTop.Visible = false;
                xtraTabControl1.Visible = false;
                progressBar1.Value = 0;
                progressBar1.Visible = true;
            }
            else
            {
                panelTop.Visible = true;
                xtraTabControl1.Visible = true;
                xtraTabControl1.BringToFront();
                progressBar1.Visible = false;
            }

            panelBottom.BringToFront();
            Application.DoEvents();
        }
        private void grGelenKutusu_DoubleClick(object sender, EventArgs e)
        {
            //try
            //{
            if (grGelenKutusuView.FocusedRowHandle < 0) return;
            frmInvoice f = new frmInvoice();
            f.InvoiceID = (int)grGelenKutusuView.GetDataRow(grGelenKutusuView.FocusedRowHandle)["InvoiceID"];
            if (f.ShowDialog() == DialogResult.OK)
            {
                List_GelenKutusu();
            }
            //}
            //catch (System.Exception ex)
            //{
            //    UT.RaiseError(this.Name, "grGelenKutusu_DoubleClick", ex);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            frmItems f = new frmItems();
            
            if (f.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("merhaba dunya");
            }
        }

        private void btnDownloadIncomingInvoice_Click(object sender, EventArgs e)
        {
            try
            {

                showHideWait(true);

                EFatura.downloadIncomingInvoice(progressBar1);

                showHideWait(false);
                List_GelenKutusu();
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "btnDownloadIncomingInvoice_Click", ex);
            }
            showHideWait(false);
        }

        private void btnSyncOutgoingInvoice_Click(object sender, EventArgs e)
        {

            try
            {
                frmReynaers f = new frmReynaers();
                f.ShowDialog();
                f.Dispose();
                //showHideWait(true);

                //EFatura.syncOutgoingInvoices(progressBar1);

                //showHideWait(false);

                //if (DF.Sync == SyncType.ExternalExe)
                //{
                //    runExpternalExe();
                //    return;
                //}
                //if (DF.Sync == SyncType.StoredProcedure_Eta || DF.Sync == SyncType.StoredProcedure_Logo || DF.Sync == SyncType.StoredProcedure_Mikro)
                //{
                //    runStoredProcedure();
                //    return;
                //}
                List_GidenKutusu();


            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "btnSyncOutgoingInvoice_Click", ex);
            }
        }

        private void List_GidenKutusu()
        {
            try
            {
                tbInvoice_GidenKutusu.SelectCommand.Parameters["@FormDate1"].Value = userCntDateFilter1.Date1;
                tbInvoice_GidenKutusu.SelectCommand.Parameters["@FormDate2"].Value = userCntDateFilter1.Date2;
                UT.OpenTable(tbInvoice_GidenKutusu);
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "", ex);
            }
        }

        private void List_Gonderilmisler()
        {

            try
            {
                tbInvoice_Gonderilmisler.SelectCommand.Parameters["@FormDate1"].Value = userCntDateFilter1.Date1;
                tbInvoice_Gonderilmisler.SelectCommand.Parameters["@FormDate2"].Value = userCntDateFilter1.Date2;
                UT.OpenTable(tbInvoice_Gonderilmisler);
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "", ex);
            }
        }

        private void grGidenKutusu_DoubleClick(object sender, EventArgs e)
        {
            //try
            //{
            if (grGidenKutusuView.FocusedRowHandle < 0) return;
            frmInvoice f = new frmInvoice();
            f.InvoiceID = (int)grGidenKutusuView.GetDataRow(grGidenKutusuView.FocusedRowHandle)["InvoiceID"];
            if (f.ShowDialog() == DialogResult.OK)
            {
                List_GelenKutusu();
            }
            //}
            //catch (System.Exception ex)
            //{
            //    UT.RaiseError(this.Name, "grGelenKutusu_DoubleClick", ex);
            //}
        }

        private void grGonderilmisler_DoubleClick(object sender, EventArgs e)
        {
            //try
            //{
            if (grGonderilmislerView.FocusedRowHandle < 0) return;
            frmInvoice f = new frmInvoice();
            f.InvoiceID = (int)grGonderilmislerView.GetDataRow(grGonderilmislerView.FocusedRowHandle)["InvoiceID"];
            if (f.ShowDialog() == DialogResult.OK)
            {
                List_GelenKutusu();
            }
            //}
            //catch (System.Exception ex)
            //{
            //    UT.RaiseError(this.Name, "grGelenKutusu_DoubleClick", ex);
            //}
        }

        private void faturayiAcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grGidenKutusu_DoubleClick(null, null);

        }

        private void gonderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (grGidenKutusuView.FocusedRowHandle < 0) return;
                int InvoiceID = (int)grGidenKutusuView.GetDataRow(grGidenKutusuView.FocusedRowHandle)["InvoiceID"];
                EFatura.sendInvoice(InvoiceID);
                List_GidenKutusu();
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "gonderToolStripMenuItem_Click", ex);
            }
        }

        private void btnEFaturaMembers_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Kaydetmek istiyor musunuz?", "Kaydet?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                tbEFaturaMembers.Save();
                UT.OpenTable(tbEFaturaMembers);
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "btnEFaturaMembers_Save_Click", ex);
            }
        }

        private void btnEFaturaMembers_Cancel_Click(object sender, EventArgs e)
        {
            btnListeleEFaturaMukellefleri_Click(null, null);
        }

        private void btnListeleEFaturaMukellefleri_Click(object sender, EventArgs e)
        {
            try
            {
                UT.OpenTable(tbEFaturaMembers);
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "btnListeleEFaturaMukellefleri_Click", ex);
            }
        }



        private void btnGidecekFaturalariGonder_Click(object sender, EventArgs e)
        {
            try
            {
                if (grGidenKutusuView.RowCount == 0) return;
                if (MessageBox.Show(grGidenKutusuView.RowCount.ToString() + " adet fatura gonderilecektir. Onayliyor musunuz", "Fatura gonder?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes) return;

                for (int i = 0; i < grGidenKutusuView.RowCount; i++)
                {
                    int InvoiceID = (int)grGidenKutusuView.GetDataRow(i)["InvoiceID"];
                    EFatura.sendInvoice(InvoiceID);
                }
                List_GidenKutusu();

            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "btnGidecekFaturalariGonder_Click", ex);
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (grGidenKutusuView.FocusedRowHandle < 0) return;
                if (MessageBox.Show("Fatura silmek istediginizden emin misiniz?", "Fatura sil?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DF.ActiveConn.dbConn;
                cmd.CommandText = "UPDATE Invoice SET ModifiedBy=1,ModifiedDate=GETDATE(),Deleted = InvoiceID WHERE InvoiceID=" + grGidenKutusuView.GetDataRow(grGidenKutusuView.FocusedRowHandle)["InvoiceID"].ToString();
                cmd.ExecuteNonQuery();
                List_GidenKutusu();
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "silToolStripMenuItem_Click", ex);
            }
        }


        #region Export


        private void mnuExportHtml_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportGrids(ExportType.Html);
        }

        private void mnuExportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportGrids(ExportType.Excel);
        }

        private void mnuExportExcelXLSX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportGrids(ExportType.ExcelXlsx);
        }

        private void mnuExportTxt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportGrids(ExportType.Txt);
        }

        private void mnuExportCsv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportGrids(ExportType.Csv);
        }

        private void mnuExportPdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportGrids(ExportType.Pdf);
        }


        private void ExportGrids(ExportType exporttype)
        {

            try
            {
                DevExpress.XtraGrid.GridControl DefaultListGrid = null;
                switch (xtraTabControl1.SelectedTabPageIndex)
                {
                    case 0:
                        DefaultListGrid = grGelenKutusu;
                        break;
                    case 1:
                        DefaultListGrid = grGidenKutusu;
                        break;
                    case 2:
                        DefaultListGrid = grGonderilmisler;
                        break;
                    case 4:
                        DefaultListGrid = grEFaturaMembers;
                        break;
                    default:
                        return;

                }




                switch (exporttype)
                {
                    case ExportType.Csv:
                        ExportDialog.DefaultExt = "csv";
                        ExportDialog.Filter = "CSV Files (*.CSV)|*.CSV|All Files (*.*)|*.*";
                        break;
                    case ExportType.Excel:
                        ExportDialog.DefaultExt = "xls";
                        ExportDialog.Filter = "Excel Files (*.xls)|*.xls|All Files (*.*)|*.*";
                        break;
                    case ExportType.ExcelXlsx:
                        ExportDialog.DefaultExt = "xlsx";
                        ExportDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
                        break;
                    case ExportType.Txt:
                        ExportDialog.DefaultExt = "txt";
                        ExportDialog.Filter = "Text Files (*.TXT)|*.TXT|All Files (*.*)|*.*";
                        break;
                    case ExportType.Pdf:
                        ExportDialog.DefaultExt = "pdf";
                        ExportDialog.Filter = "Acrobat Reader Files (*.PDF)|*.pdf|All Files (*.*)|*.*";
                        break;
                    case ExportType.Html:
                        ExportDialog.DefaultExt = "htm";
                        ExportDialog.Filter = "HTML Files (*.HTM)|*.HTM|All Files (*.*)|*.*";
                        break;
                }

                if (ExportDialog.ShowDialog() != DialogResult.OK) return;

                if (System.IO.File.Exists(ExportDialog.FileName))
                {
                    if (MessageBox.Show(ExportDialog.FileName + Environment.NewLine + "Dosya zaten var! Üzerine yazmak istiyor musunuz?", "Uzerine yaz?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes) return;

                }

                switch (exporttype)
                {
                    case ExportType.Csv:
                        DefaultListGrid.MainView.ExportToCsv(ExportDialog.FileName);
                        break;
                    case ExportType.Excel:
                        DefaultListGrid.MainView.ExportToXls(ExportDialog.FileName);
                        break;
                    case ExportType.ExcelXlsx:
                        DefaultListGrid.MainView.ExportToXlsx(ExportDialog.FileName);
                        break;
                    case ExportType.Txt:
                        DefaultListGrid.MainView.ExportToText(ExportDialog.FileName);
                        break;
                    case ExportType.Pdf:
                        DefaultListGrid.MainView.ExportToPdf(ExportDialog.FileName);
                        break;
                    case ExportType.Html:
                        DefaultListGrid.MainView.ExportToHtml(ExportDialog.FileName);
                        break;
                }
                if (System.IO.File.Exists(ExportDialog.FileName))
                {
                    if (MessageBox.Show("Dosyayi acmak ister misiniz?", "Dosya ac?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            ProcessStartInfo startinfo = new ProcessStartInfo(ExportDialog.FileName);
                            Process p = new Process();
                            p.StartInfo = startinfo;
                            p.Start();
                        }
                        catch (System.Exception ex)
                        {
                            UT.RaiseError(this.Name, "ExportClick", ex);
                        }


                    }

                }
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "ExportGrids", ex);
            }
        }
        #endregion

        private void onaylaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (grGelenKutusuView.FocusedRowHandle < 0) return;
                if (grGelenKutusuView.GetDataRow(grGelenKutusuView.FocusedRowHandle)["InvoiceTypeCode"].ToString() == "TEMELFATURA")
                {
                    MessageBox.Show("Fatura temel fatura. Onay gerekmiyor.");
                    return;
                }
                if (MessageBox.Show("Fatura onaylansin mi?", "Onayla?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                string UUID = grGelenKutusuView.GetDataRow(grGelenKutusuView.FocusedRowHandle)["UUID"].ToString();
                EFatura.approveDecline_IncomingInvoice(UUID, EFatura.InvoiceResponse.Approved);
                List_GelenKutusu();

            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "onaylaToolStripMenuItem_Click", ex);
            }
        }

        private void reddetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (grGelenKutusuView.FocusedRowHandle < 0) return;
                if (grGelenKutusuView.GetDataRow(grGelenKutusuView.FocusedRowHandle)["InvoiceTypeCode"].ToString() == "TEMELFATURA")
                {
                    MessageBox.Show("Fatura temel fatura. Onay gerekmiyor.");
                    return;
                }
                if (MessageBox.Show("Fatura reddilsin mi?", "Reddet?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                string UUID = grGelenKutusuView.GetDataRow(grGelenKutusuView.FocusedRowHandle)["UUID"].ToString();
                EFatura.approveDecline_IncomingInvoice(UUID, EFatura.InvoiceResponse.Declined);
                List_GelenKutusu();

            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "onaylaToolStripMenuItem_Click", ex);
            }
        }

        private void cmdPrintXSLTSingle_Click(object sender, EventArgs e)
        {
            try
            {
                int InvoiceID = 0;
                switch (xtraTabControl1.SelectedTabPageIndex)
                {
                    case 0:
                        if (grGelenKutusuView.FocusedRowHandle < 0) return;

                        InvoiceID = (int)grGelenKutusuView.GetDataRow(grGelenKutusuView.FocusedRowHandle)["InvoiceID"];

                        break;
                    case 1:
                        if (grGidenKutusuView.FocusedRowHandle < 0) return;

                        InvoiceID = (int)grGidenKutusuView.GetDataRow(grGidenKutusuView.FocusedRowHandle)["InvoiceID"];

                        break;
                    case 2:
                        if (grGonderilmislerView.FocusedRowHandle < 0) return;

                        InvoiceID = (int)grGonderilmislerView.GetDataRow(grGonderilmislerView.FocusedRowHandle)["InvoiceID"];

                        break;
                    default:
                        return;
                        break;
                }

                if (InvoiceID <= 0) return;
                xsltPrint(InvoiceID, true);
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "cmdPrintXSLTSingle_Click", ex);
            }
        }

        private void xsltPrint(int InvoiceID, bool bshow)
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
                        frmInvoiceViewer f = new frmInvoiceViewer(uInvoice);
                        f.XsltNo = dbInvoice.XsltNo;
                        if (bshow)
                        {
                            f.ShowDialog();
                        }
                        else
                        {
                            f.FormPrint();
                        }

                    }

                }

            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "", ex);
            }
        }

        private void cmdGeneralPrint_Click(object sender, EventArgs e)
        {
            try
            {
                string PrintScript = "SELECT * FROM Invoice WHERE InvoiceID=@InvoiceID ";

                frmPrint f = new frmPrint();
                f.Parameters = new System.Collections.ArrayList();
                f.Parameters.Add(new SqlParameter("@FormDate1", userCntDateFilter1.Date1));
                f.Parameters.Add(new SqlParameter("@FormDate2", userCntDateFilter1.Date2));
                f.FormCode = "000001";
                f.PrintScript = PrintScript;
                f.ShowDialog();

            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "", ex);
            }
        }

        private void cmdPrintXSLTMulti_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> InvoiceList = new List<int>();
                DevExpress.XtraGrid.Views.Grid.GridView grw;
                switch (xtraTabControl1.SelectedTabPageIndex)
                {
                    case 0:
                        grw = grGelenKutusuView;
                        break;
                    case 1:
                        grw = grGidenKutusuView;
                        break;
                    case 2:
                        grw = grGonderilmislerView;
                        break;
                    default:
                        return;
                }
                if (grw.SelectedRowsCount == 0) return;
                if (MessageBox.Show(grw.SelectedRowsCount.ToString() + " adet fatura varsayilan yazicidan yazdirilacaktir. Onayliyor musunuz?", "Toplu yazdir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
                foreach (int i in grw.GetSelectedRows())
                {
                    int InvoiceID = (int)grw.GetDataRow(i)["InvoiceID"];
                    if (InvoiceID > 0)
                    {
                        xsltPrint(InvoiceID, false);
                    }
                }


            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "cmdPrintXSLTSingle_Click", ex);
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                UT.SaveFormGrids(this);
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "frmMain_FormClosed", ex);
            }
        }

        private void programHakkindaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAbout f = new frmAbout();
                f.ShowDialog();
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "programHakkindaToolStripMenuItem_Click", ex);
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuGonderilmisSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (grGonderilmislerView.FocusedRowHandle < 0) return;
                if (MessageBox.Show("Fatura silmek istediginizden emin misiniz?", "Fatura sil?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DF.ActiveConn.dbConn;
                cmd.CommandText = "UPDATE Invoice SET ModifiedBy=1,ModifiedDate=GETDATE(),Deleted = InvoiceID WHERE InvoiceID=" + grGonderilmislerView.GetDataRow(grGonderilmislerView.FocusedRowHandle)["InvoiceID"].ToString();
                cmd.ExecuteNonQuery();
                List_Gonderilmisler();
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "silToolStripMenuItem_Click", ex);
            }
        }

        private void mnuGonderilmis_Gerial_Click(object sender, EventArgs e)
        {
            try
            {
                if (grGonderilmislerView.FocusedRowHandle < 0) return;
                if (MessageBox.Show("Faturayi geri almak istediginizden emin misiniz?", "Fatura geri al?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DF.ActiveConn.dbConn;
                cmd.CommandText = "UPDATE Invoice SET ModifiedBy=1,ModifiedDate=GETDATE(),LocalStatus = 0,UUID='" + Guid.NewGuid().ToString() + "' WHERE InvoiceID=" + grGonderilmislerView.GetDataRow(grGonderilmislerView.FocusedRowHandle)["InvoiceID"].ToString();
                cmd.ExecuteNonQuery();
                List_Gonderilmisler();
                List_GidenKutusu();
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "silToolStripMenuItem_Click", ex);
            }
        }

        private void gonderilmisGibiİsaretleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (grGidenKutusuView.FocusedRowHandle < 0) return;
                if (MessageBox.Show("Fatura gonderilmis olarak isaretlenecektir, emin misiniz?", "Gonderildi olarak isaretle?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DF.ActiveConn.dbConn;
                cmd.CommandText = "UPDATE Invoice SET ModifiedBy=1,ModifiedDate=GETDATE(),LocalStatus = 2 WHERE InvoiceID=" + grGidenKutusuView.GetDataRow(grGidenKutusuView.FocusedRowHandle)["InvoiceID"].ToString();
                cmd.ExecuteNonQuery();
                List_GidenKutusu();
                List_Gonderilmisler();
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "silToolStripMenuItem_Click", ex);
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            try
            {
                if (grGonderilmislerView.RowCount == 0) return;
               

                showHideWait(true);
                if (grGonderilmislerView.RowCount > 0) progressBar1.Maximum = grGonderilmislerView.RowCount;

                for (int i = 0; i < grGonderilmislerView.RowCount; i++)
                {
                    int InvoiceID = (int)grGonderilmislerView.GetDataRow(i)["InvoiceID"];
                    int LocalStatus = (int)grGonderilmislerView.GetDataRow(i)["LocalStatus"];
                    if (LocalStatus==1)
                        EFatura.checkInvoice(InvoiceID);
                    progressBar1.Value = i + 1;
                    Application.DoEvents();
                }

                List_Gonderilmisler();

            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "btnUpdateStatus_Click", ex);
            }
            showHideWait(false);
        }

        private void conMenuGelen_Opening(object sender, CancelEventArgs e)
        {
            try
            {
                //ProfileID
                onaylaToolStripMenuItem.Enabled = false;
                reddetToolStripMenuItem.Enabled = false;
                if (grGelenKutusuView.FocusedRowHandle < 0) return;

                if (grGelenKutusuView.GetDataRow(grGelenKutusuView.FocusedRowHandle)["Status"].ToString() == "0" && grGelenKutusuView.GetDataRow(grGelenKutusuView.FocusedRowHandle)["ProfileID"].ToString() == "TICARIFATURA")
                {
                    onaylaToolStripMenuItem.Enabled = true;
                    reddetToolStripMenuItem.Enabled = true;
                }
                
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "conMenuGelen_Opening", ex);
            }
        }

        private void btnRefreshAll_Click(object sender, EventArgs e)
        {
            List_GelenKutusu();
            List_GidenKutusu();
            List_Gonderilmisler();
            btnListeleEFaturaMukellefleri_Click(null, null);
        }

        private void logGoruntuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (grGonderilmislerView.FocusedRowHandle < 0) return;

                EFatura.showInvoiceLog((int)grGonderilmislerView.GetDataRow(grGonderilmislerView.FocusedRowHandle)["InvoiceID"]);
           
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "logGoruntuleToolStripMenuItem_Click", ex);
            }
        }

        private void conMenuExport_XLSX_Click(object sender, EventArgs e)
        {

        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            frmItems f = new frmItems();

            f.ShowDialog();
            
        }

        private void grGidenKutusu_Click(object sender, EventArgs e)
        {

        }
    }
}
