using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MrTEK_EFatura
{

    public partial class frmPrint : Form
    {
        public string FormCode = "";

        public string PrintScript = "";
        public ArrayList Parameters = new ArrayList();
        public object DataSource = null;
        bool bPrintFromDataSource = false;
        bool bInvisiblePrint = false;

        string PrinterName = "";
        int DefaultReportDesignID;

        public frmPrint()
        {
            InitializeComponent();
        }

        private void RefreshList()
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            System.Data.SqlClient.SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            int oldRow = 0;

            try
            {


                oldRow = GridView1.FocusedRowHandle;
                cmd.Connection = DF.ActiveConn.dbConn;
                cmd.CommandText = "SELECT ReportID, ReportName,bDefault, CASE bDefault WHEN 1 THEN '*' ELSE '' END as sDefault,CASE ReportType WHEN 0 THEN 'FORM' WHEN 1 THEN 'RAW' WHEN 2 THEN 'EXTERNAL' ELSE '' END as sReportType,ReportType FROM  PrintDesigns  WHERE FormCode = @FormCode ";
                if (DefaultReportDesignID > 0)
                {
                    cmd.CommandText += " AND ReportID='" + DefaultReportDesignID.ToString() + "' ";
                }
                else
                {
                    if (bInvisiblePrint)
                    {
                        cmd.CommandText += " AND bDefault=1 ";
                    }
                }

                cmd.CommandText += "ORDER BY ReportName";

                cmd.Parameters.Clear();


                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@FormCode", FormCode));
                da = new System.Data.SqlClient.SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                GridControl1.DataSource = dt;
                if (oldRow >= 0 & GridView1.RowCount > 0)
                {
                    if (oldRow > GridView1.RowCount - 1)
                    {
                        GridView1.FocusedRowHandle = GridView1.RowCount - 1;
                    }
                    else
                    {
                        GridView1.FocusedRowHandle = oldRow;
                    }
                }
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "RefreshList", ex);
            }
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            RefreshList();
            this.Text = "Yazdir - [" + FormCode + "]";
        }

        private void mnuNewReport_Click(object sender, EventArgs e)
        {
            try
            {
                frmPrintItem f = new frmPrintItem();
                f.FormCode = FormCode;
                f.Parameters = Parameters;
                f.PrintScript = PrintScript;
                f.FormNew(DataSource);
                if (f.DialogResult == DialogResult.OK)
                {
                    RefreshList();
                    if (((DataTable)GridControl1.DataSource).Rows.Count == 1)
                    {
                        mnuSetDefault_Click(null, null);
                    }
                }

            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "mnuNewReport_Click", ex);
            }
        }

        private void mnuEditReport_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = null;
                dr = GridView1.GetFocusedDataRow();
                if (dr == null) return;

                frmPrintItem f = new frmPrintItem();
                f.ReportID = (int)dr["ReportID"];
                f.PrintScript = "";
                f.Parameters = Parameters;
                f.FormEdit(DataSource);
                if (f.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    RefreshList();
                }
                f.Dispose();
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "mnuEditReport_Click", ex);
            }
        }

        private void mnuDeleteReport_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = null;
                dr = GridView1.GetFocusedDataRow();
                if (dr == null) return;
                if (MessageBox.Show("Rapor tasarımını silmek istediğinizden emin misiniz?", "Tasarimi sil?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) != DialogResult.Yes) return;
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.Connection = DF.ActiveConn.dbConn;

                cmd.CommandText = "DELETE FROM PrintDesigns WHERE ReportID=" + dr["ReportID"].ToString();
                cmd.ExecuteNonQuery();
                RefreshList();

                cmd.Dispose();
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "mnuDeleteReport_Click", ex);
            }
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void conMenuPrint_Click(object sender, EventArgs e)
        {
            cmdPrint_Click(null, null);
        }

        private void conMenuEdit_Click(object sender, EventArgs e)
        {
            mnuEditReport_Click(null, null);
        }

        private void conMenuSetDefault_Click(object sender, EventArgs e)
        {
            mnuSetDefault_Click(null, null);
        }

        private void mnuSetDefault_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = null;
                dr = GridView1.GetFocusedDataRow();
                if (dr == null)
                    return;
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.Connection = DF.ActiveConn.dbConn;
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@FormCode", FormCode));
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ReportID", dr["ReportID"]));

                cmd.CommandText = "UPDATE PrintDesigns SET bDefault=0 WHERE FormCode = @FormCode ";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "UPDATE PrintDesigns SET bDefault=1 WHERE ReportID=@ReportID";
                cmd.ExecuteNonQuery();
                RefreshList();
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "mnuSetDefault_Click", ex);
            }
        }

        private void conMenuNewReport_Click(object sender, EventArgs e)
        {
            mnuNewReport_Click(null, null);
        }

        private void mnuPrint_Click(object sender, EventArgs e)
        {
            cmdPrint_Click(null, null);
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            if (DataSource==null )
            {
                PrintFromScript();
            }
            else
            {
                PrintFromDataSource();
            }

        }


        private void PrintFromScript()
        {
            DataRow dr = null;
            clsReportDesing cReportDesing = new clsReportDesing();
            dr = GridView1.GetFocusedDataRow();
            if (dr == null)
                return;
            try
            {
                cReportDesing = clsPrint.GetReportLayout((int)UT.If0Null(dr["ReportID"]));
                switch (cReportDesing.ReportType)
                {
                    case 0:
                        PrintFromScript_Form(cReportDesing);
                        break;
                    case 1:
                        //Raw
                        break;

                    case 2:
                        //External
                        PrintFromScript_External(cReportDesing);
                        break;
                }
            }
            catch (Exception ex)
            {
                UT.RaiseError(this.Name, "PrintFromScript", ex);
            }

        }

        private void PrintFromDataSource()
        {
            DataRow dr = null;
            clsReportDesing cReportDesing = new clsReportDesing();
            dr = GridView1.GetFocusedDataRow();
            if (dr == null)
                return;
            try
            {
                cReportDesing = clsPrint.GetReportLayout((int)UT.If0Null(dr["ReportID"]));
                switch (cReportDesing.ReportType)
                {
                    case 0:
                        //form
                        PrintFromDataSource_Form(cReportDesing);
                        break;
                    case 1:
                        //Raw
                        break;

                    case 2:
                        //External
                        break;

                }
            }
            catch (Exception ex)
            {
                UT.RaiseError(this.Name, "PrintFromDataSource", ex);
            }

        }


        private void PrintFromScript_Form(clsReportDesing cReportDesing)
        {

            XtraReport1 xrep = new XtraReport1();

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            System.Data.SqlClient.SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            bool bFound = false;


            try
            {


                if (cReportDesing.ReportData.Length > 0)
                {
                    xrep.LoadLayout(cReportDesing.ReportData);
                }
                if (cReportDesing.ReportSQL.Trim() != "")
                {
                    cmd.Connection = DF.ActiveConn.dbConn;
                    cmd.CommandText = cReportDesing.ReportSQL;
                    cmd.Parameters.Clear();
                    if ((Parameters != null))
                    {
                        foreach (System.Data.SqlClient.SqlParameter pr in Parameters)
                        {
                            if (pr.ParameterName.Trim() == "")
                            {
                                if (pr.ParameterName.Substring(0, 1) != "@")
                                {
                                    pr.ParameterName = "@" + pr.ParameterName;
                                }
                            }
                            bFound = false;
                            foreach (System.Data.SqlClient.SqlParameter pr2 in cmd.Parameters)
                            {
                                if (pr.ParameterName == pr2.ParameterName)
                                {
                                    bFound = true;
                                    break; // TODO: might not be correct. Was : Exit For
                                }
                            }

                            if (bFound == false)
                            {
                                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter(pr.ParameterName, pr.Value));

                            }

                        }
                    }
                    if (cmd.Parameters.Contains("@FormDate1") == false)
                    {
                        cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@FormDate1", DateTime.Today));

                    }
                    if (cmd.Parameters.Contains("@FormDate2") == false)
                    {
                        cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@FormDate2", DateTime.Today));

                    }

                    da = new System.Data.SqlClient.SqlDataAdapter(cmd);
                    da.Fill(dt);
                    xrep.DataSource = dt;
                }
                else
                {
                    xrep.DataSource = new DataTable();
                }
                xrep.ShowPrintMarginsWarning = false;
                xrep.ShowPrintStatusDialog = false;
                xrep.CreateDocument();
                if (bInvisiblePrint == false)
                {
                    if (PrinterName.Trim() == "")
                    {
                        xrep.showPreviewDialog();
                    }
                    else
                    {
                        xrep.PrintForm(PrinterName);
                    }

                }
                else
                {
                    if (PrinterName.Trim() == "")
                    {
                        xrep.PrintForm();
                    }
                    else
                    {
                        xrep.PrintForm(PrinterName);
                    }
                }
            }
            catch (Exception ex)
            {
                UT.RaiseError(this.Name, "PrintFromScript_Form", ex);
            }
        }

        private void PrintFromDataSource_Form(clsReportDesing cReportDesing)
        {
            XtraReport1 xrep = new XtraReport1();

            try
            {
                if (cReportDesing.ReportData.Length > 0)
                {
                    xrep.LoadLayout(cReportDesing.ReportData);
                }

                xrep.DataSource = DataSource;
                if (DataSource is NeoDAC.NeoTable)
                {
                    if ((((NeoDAC.NeoTable)DataSource).SelectCommand != null))
                    {
                        foreach (System.Data.SqlClient.SqlParameter pr in ((NeoDAC.NeoTable)DataSource).SelectCommand.Parameters)
                        {
                            DevExpress.XtraReports.Parameters.Parameter item = new DevExpress.XtraReports.Parameters.Parameter();
                            string paramName = pr.ParameterName.Replace("@", "");
                            bool bFound = false;
                            item.Name = paramName;
                            item.Value = pr.Value;
                            for (int i = 0; i <= xrep.Parameters.Count - 1; i++)
                            {
                                if (xrep.Parameters[i].Name == paramName)
                                {
                                    bFound = true;
                                    break; // TODO: might not be correct. Was : Exit For
                                }
                            }
                            if (bFound)
                            {
                                xrep.Parameters[paramName].Value = pr.Value;
                            }
                            else
                            {
                                xrep.Parameters.Add(item);
                            }

                        }
                    }
                }

                xrep.ShowPrintMarginsWarning = false;
                xrep.ShowPrintStatusDialog = false;
                xrep.CreateDocument();
                if (bInvisiblePrint == false)
                {
                    xrep.showPreviewDialog();
                }
                else
                {
                    if (string.IsNullOrEmpty(PrinterName))
                    {
                        xrep.PrintForm();
                    }
                    else
                    {
                        xrep.PrintForm(PrinterName);
                    }
                }
            }
            catch (Exception ex)
            {
                UT.RaiseError(this.Name, "PrintFromDataSource_Form", ex);
            }
        }


        private void PrintFromScript_External(clsReportDesing cReportDesing)
        {

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            System.Data.SqlClient.SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            bool bFound = false;
            string ExternalFile = "";

            try
            {


                if (cReportDesing.ReportDataByteArray.Length == 0)
                {
                    return;
                }
                System.Text.UTF8Encoding enc = new System.Text.UTF8Encoding();
                ExternalFile = enc.GetString(cReportDesing.ReportDataByteArray);
                if (ExternalFile.Trim() == "") return;

                if (cReportDesing.ReportSQL.Trim() != "")
                {
                    cmd.Connection = DF.ActiveConn.dbConn;
                    cmd.CommandText = cReportDesing.ReportSQL;
                    cmd.Parameters.Clear();
                    if ((Parameters != null))
                    {
                        foreach (System.Data.SqlClient.SqlParameter pr in Parameters)
                        {
                            if (pr.ParameterName.Trim() != "")
                            {
                                if (pr.ParameterName.Substring(0, 1) != "@")
                                {
                                    pr.ParameterName = "@" + pr.ParameterName;
                                }
                            }
                            bFound = false;
                            foreach (System.Data.SqlClient.SqlParameter pr2 in cmd.Parameters)
                            {
                                if (pr.ParameterName == pr2.ParameterName)
                                {
                                    bFound = true;
                                    break; // TODO: might not be correct. Was : Exit For
                                }
                            }

                            if (bFound == false)
                            {
                                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter(pr.ParameterName, pr.Value));

                            }

                        }
                    }
                    if (cmd.Parameters.Contains("@FormDate1") == false)
                    {
                        cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@FormDate1", DateTime.Today));

                    }
                    if (cmd.Parameters.Contains("@FormDate2") == false)
                    {
                        cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@FormDate2", DateTime.Today));

                    }

                    da = new System.Data.SqlClient.SqlDataAdapter(cmd);
                    da.Fill(dt);
                    da.Dispose();
                }
                else
                {
                    dt = new DataTable();
                }

                string ExecExternalFile = "";
                foreach (DataRow dr in dt.Rows)
                {
                    ExecExternalFile = ExternalFile;
                    foreach (DataColumn dc in dt.Columns)
                    {
                        if (dc.DataType.ToString() == "System.Guid")
                        {
                            ExecExternalFile = ExecExternalFile.Replace("[" + dc.ColumnName + "]", UT.IfNullGuid(dr[dc.ColumnName]).ToString());
                        }
                        else
                        {
                            ExecExternalFile = ExecExternalFile.Replace("[" + dc.ColumnName + "]", UT.IfNull(dr[dc.ColumnName], "").ToString());
                        }

                    }
                    UT.Shell(ExecExternalFile, true);
                }
                dt.Dispose();

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                UT.RaiseError(this.Name, "PrintFromScript_External", ex);
            }
        }

        private void PrintFromDataSource_External(clsReportDesing cReportDesing)
        {
            string ExternalFile = "";

            try
            {

                if (cReportDesing.ReportDataByteArray.Length == 0)
                {
                    return;
                }
                System.Text.UTF8Encoding enc = new System.Text.UTF8Encoding();
                ExternalFile = enc.GetString(cReportDesing.ReportDataByteArray);
                if (ExternalFile.Trim() == "") return;


                if (DataSource is NeoDAC.NeoTable)
                {
                    string ExecExternalFile = "";
                    foreach (DataRow dr in ((NeoDAC.NeoTable)DataSource).Rows)
                    {
                        ExecExternalFile = ExternalFile;
                        foreach (DataColumn dc in ((NeoDAC.NeoTable)DataSource).Columns)
                        {
                            ExecExternalFile = ExecExternalFile.Replace("[" + dc.ColumnName + "]", dr[dc.ColumnName].ToString());
                        }
                        if ((((NeoDAC.NeoTable)DataSource).SelectCommand != null))
                        {
                            foreach (System.Data.SqlClient.SqlParameter pr in ((NeoDAC.NeoTable)DataSource).SelectCommand.Parameters)
                            {
                                ExecExternalFile = ExecExternalFile.Replace("[" + pr.ParameterName + "]", UT.IfNull(pr.Value, "").ToString());

                            }
                        }

                        UT.Shell(ExecExternalFile, true);

                    }

                }
                else if (DataSource is DataTable)
                {
                    string ExecExternalFile = "";
                    foreach (DataRow dr in ((DataTable)DataSource).Rows)
                    {
                        ExecExternalFile = ExternalFile;
                        foreach (DataColumn dc in ((DataTable)DataSource).Columns)
                        {
                            ExecExternalFile = ExecExternalFile.Replace("[" + dc.ColumnName + "]", UT.IfNull(dr[dc.ColumnName], "").ToString());
                        }
                        UT.Shell(ExecExternalFile, true);
                    }
                }

            }
            catch (Exception ex)
            {
                UT.RaiseError(this.Name, "PrintFromDataSource_External", ex);
            }
        }

        private void conMenuDelete_Click(object sender, EventArgs e)
        {
            mnuDeleteReport_Click(null, null);
        }

        private void GridControl1_DoubleClick(object sender, EventArgs e)
        {
            cmdPrint_Click(null, null);
        }

        private XtraReport1 PrepareForExport()
        {
            DataRow dr = null;
            dr = GridView1.GetFocusedDataRow();
            if (dr == null)
                return null;

            XtraReport1 xrep = new XtraReport1();
            clsReportDesing cReportDesing = new clsReportDesing();
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            System.Data.SqlClient.SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            bool bFound = false;
            try
            {
                cReportDesing = clsPrint.GetReportLayout((int)UT.If0Null(dr["ReportID"]));
                if (cReportDesing.ReportData.Length > 0)
                {
                    xrep.LoadLayout(cReportDesing.ReportData);
                }
                if (cReportDesing.ReportSQL.Trim() != "")
                {
                    cmd.Connection = DF.ActiveConn.dbConn;
                    cmd.CommandText = cReportDesing.ReportSQL;
                    cmd.Parameters.Clear();
                    if ((Parameters != null))
                    {
                        foreach (System.Data.SqlClient.SqlParameter pr in Parameters)
                        {
                            if (pr.ParameterName.Trim() != "")
                            {
                                if (pr.ParameterName.Substring(0, 1) != "@")
                                {
                                    pr.ParameterName = "@" + pr.ParameterName;
                                }
                            }
                            bFound = false;
                            foreach (System.Data.SqlClient.SqlParameter pr2 in cmd.Parameters)
                            {
                                if (pr.ParameterName == pr2.ParameterName)
                                {
                                    bFound = true;
                                    break;
                                }
                            }

                            if (bFound == false)
                            {
                                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter(pr.ParameterName, pr.Value));

                            }

                        }
                    }
                    da = new System.Data.SqlClient.SqlDataAdapter(cmd);
                    da.Fill(dt);
                    xrep.DataSource = dt;
                }
                else
                {
                    xrep.DataSource = new DataTable();
                }
                xrep.ShowPrintMarginsWarning = false;
                xrep.CreateDocument();
                return xrep;
            }
            catch (Exception ex)
            {
                UT.RaiseError(this.Name, "PrepareForExport", ex);
                return null;
            }
        }
        private void mnuExportExcel_Click(System.Object sender, System.EventArgs e)
        {
            XtraReport1 xrep = default(XtraReport1);
            xrep = PrepareForExport();
            if (xrep == null)
                return;
            dlgExport.DefaultExt = "Xls";
            dlgExport.Filter = "Excel Files (*.XLS)|*.XLS|Tüm dosyalar (*.*)|*.*";
            dlgExport.FileName = FormCode;

            if (dlgExport.ShowDialog() != DialogResult.OK) return;
            xrep.ExportToXls(dlgExport.FileName);
        }

        private void mnuExportHTML_Click(object sender, System.EventArgs e)
        {
            XtraReport1 xrep = default(XtraReport1);
            xrep = PrepareForExport();
            if (xrep == null)
                return;
            dlgExport.DefaultExt = "HTM";
            dlgExport.Filter = "HTML Files (*.HTM)|*.HTM|Tüm dosyalar (*.*)|*.*";
            dlgExport.FileName = FormCode;

            if (dlgExport.ShowDialog() != DialogResult.OK) return;
            xrep.ExportToHtml(dlgExport.FileName);
        }

        private void mnuExportCSV_Click(object sender, System.EventArgs e)
        {
            XtraReport1 xrep = default(XtraReport1);
            xrep = PrepareForExport();
            if (xrep == null)
                return;
            dlgExport.DefaultExt = "CSV";
            dlgExport.Filter = "CSV Files (*.CSV)|*.CSV|Tüm dosyalar (*.*)|*.*";
            dlgExport.FileName = FormCode;

            if (dlgExport.ShowDialog() != DialogResult.OK)
                return;
            DevExpress.XtraPrinting.CsvExportOptions s = new DevExpress.XtraPrinting.CsvExportOptions();
            s.Separator = ";";
            xrep.ExportToCsv(dlgExport.FileName, s);
        }

        private void mnuExportTEXT_Click(object sender, System.EventArgs e)
        {
            XtraReport1 xrep = default(XtraReport1);
            xrep = PrepareForExport();
            if (xrep == null)
                return;
            dlgExport.DefaultExt = "TXT";
            dlgExport.Filter = "Text Files (*.TXT)|*.TXT|Tüm dosyalar (*.*)|*.*";
            dlgExport.FileName = FormCode;
            if (dlgExport.ShowDialog() != DialogResult.OK)
                return;
            DevExpress.XtraPrinting.TextExportOptions s = new DevExpress.XtraPrinting.TextExportOptions();
            s.Separator = "\t";
            xrep.ExportToText(dlgExport.FileName, s);
        }

        private void mnuExportPDF_Click(object sender, System.EventArgs e)
        {
            XtraReport1 xrep = default(XtraReport1);
            xrep = PrepareForExport();
            if (xrep == null)
                return;
            dlgExport.DefaultExt = "PDF";
            dlgExport.Filter = "Acrobat Files (*.PDF)|*.PDF|Tüm dosyalar (*.*)|*.*";
            dlgExport.FileName = FormCode;

            if (dlgExport.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
            xrep.ExportToPdf(dlgExport.FileName);
        }

        private void mnuExportRTF_Click(object sender, System.EventArgs e)
        {
            XtraReport1 xrep = default(XtraReport1);
            xrep = PrepareForExport();
            if (xrep == null)
                return;
            dlgExport.DefaultExt = "RTF";
            dlgExport.Filter = "Rich Text Files (*.RTF)|*.RTF|Tüm dosyalar (*.*)|*.*";
            dlgExport.FileName = FormCode;
            if (dlgExport.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
            xrep.ExportToRtf(dlgExport.FileName);

        }

        private void mnuExportMHT_Click(object sender, System.EventArgs e)
        {
            XtraReport1 xrep = default(XtraReport1);
            xrep = PrepareForExport();
            if (xrep == null)
                return;
            dlgExport.DefaultExt = "MHT";
            dlgExport.Filter = "MHT Files (*.MHT)|*.MHT|Tüm dosyalar (*.*)|*.*";
            dlgExport.FileName = FormCode;

            if (dlgExport.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
            xrep.ExportToMht(dlgExport.FileName);
        }

        private void mnuExportImage_Click(object sender, System.EventArgs e)
        {
            XtraReport1 xrep = default(XtraReport1);
            xrep = PrepareForExport();
            if (xrep == null)
                return;
            dlgExport.DefaultExt = "jpg";
            dlgExport.Filter = "JPEG (*.jpg;*.jpeg;*.jpe;*.jfif)|*.jpg;*.jpeg;*.jpe;*.jfif|Bitmap (*.bmp)|*.BMP|GIF (*.gif)|*.gif|TIFF (*.tif;*.tiff)|*.tif;*.tiff|PNG (*.png)|*.png|Tüm dosyalar (*.*)|*.*";
            //dlgExport.Filter &= "Bitmap (*.bmp)|*.BMP|GIF (*.gif)|*.gif|TIFF (*.tif;*.tiff)|*.tif;*.tiff|PNG (*.png)|*.png|Tüm dosyalar (*.*)|*.*"
            dlgExport.FileName = FormCode;


            if (dlgExport.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
            xrep.ExportToImage(dlgExport.FileName);
        }

        private void frmPrint_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                cmdClose_Click(null, null);
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuDesingExport_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                DataRow dr = null;
                dr = GridView1.GetFocusedDataRow();
                if (dr == null)
                    return;

                clsReportDesing cReportDesing = new clsReportDesing();
                cReportDesing = clsPrint.GetReportLayout((int)UT.If0Null(dr["ReportID"]));
                System.Xml.XmlDocument xml1 = new System.Xml.XmlDocument();
                System.Xml.XmlNode mNode = null;
                System.Xml.XmlNode pNode = null;
                System.Xml.XmlDeclaration en = xml1.CreateXmlDeclaration("1.0", "UTF-8", null);
                xml1.AppendChild(en);


                mNode = xml1.CreateElement("ReportDesingExport");

                pNode = xml1.CreateElement("FormCode");
                pNode.InnerText = cReportDesing.FormCode;
                mNode.AppendChild(pNode);

                pNode = xml1.CreateElement("ReportName");
                pNode.InnerText = cReportDesing.ReportName;
                mNode.AppendChild(pNode);

                pNode = xml1.CreateElement("ReportSQL");
                pNode.InnerText = cReportDesing.ReportSQL;
                mNode.AppendChild(pNode);

                pNode = xml1.CreateElement("ReportData");
                if ((cReportDesing.ReportData != null))
                {
                    System.Text.UTF8Encoding enc = new System.Text.UTF8Encoding();
                    pNode.InnerText = enc.GetString(cReportDesing.ReportData.ToArray());
                }
                mNode.AppendChild(pNode);

                xml1.AppendChild(mNode);


                dlgDesingExport.FileName = UT.IfNull(dr["ReportName"], "") + ".xml";
                if (dlgDesingExport.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;
                xml1.Save(dlgDesingExport.FileName);
            }
            catch (Exception ex)
            {
                UT.RaiseError(this.Name, "mnuDesingExport_Click", ex);
            }
        }

        private void mnuDesingImport_Click(object sender, System.EventArgs e)
        {

            try
            {

                clsReportDesing cReportDesing = new clsReportDesing();

                System.Xml.XmlDocument xml1 = new System.Xml.XmlDocument();


                if (dlgDesingImport.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;
                xml1.Load(dlgDesingImport.FileName);

              
                if ((xml1.SelectSingleNode("/ReportDesingExport") != null))
                {
                    if ((xml1.SelectSingleNode("/ReportDesingExport/FormCode") != null))
                    {
                        cReportDesing.FormCode = xml1.SelectSingleNode("/ReportDesingExport/FormCode").InnerText;
                    }
                    if ((xml1.SelectSingleNode("/ReportDesingExport/ReportName") != null))
                    {
                        cReportDesing.ReportName = xml1.SelectSingleNode("/ReportDesingExport/ReportName").InnerText;
                    }
                    if ((xml1.SelectSingleNode("/ReportDesingExport/ReportSQL") != null))
                    {
                        cReportDesing.ReportSQL = xml1.SelectSingleNode("/ReportDesingExport/ReportSQL").InnerText;
                    }

                    if ((xml1.SelectSingleNode("/ReportDesingExport/ReportData") != null))
                    {
                        if (xml1.SelectSingleNode("/ReportDesingExport/ReportData").InnerText.Trim()!="")
                        {
                            System.Text.UTF8Encoding enc1 = new System.Text.UTF8Encoding();
                            byte[] b = null;
                            b = enc1.GetBytes(xml1.SelectSingleNode("/ReportDesingExport/ReportData").InnerText);
                            cReportDesing.ReportData = new System.IO.MemoryStream();
                            cReportDesing.ReportData.Write(b, 0, b.Length);
                        }
                    }
                }
                if (this.FormCode != cReportDesing.FormCode)
                {
                    if (MessageBox.Show("Bu tasarim baska bir form icin tasarlanmis. Yinede iceri almak istiyor musunuz?", "Farkli form?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                }
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                System.Data.SqlClient.SqlDataAdapter da = null;
                DataTable dt = null;
                bool bFound = false;
                string sReportName = cReportDesing.ReportName;
                cmd.Connection = DF.ActiveConn.dbConn;
            Basa:
                bFound = false;
                cmd.Parameters.Clear();

                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ReportName", sReportName));
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ReportData", SqlDbType.Image));
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@FormCode", this.FormCode));
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ReportSQL", SqlDbType.Image));
                cmd.Parameters["@ReportData"].Value = DBNull.Value;
                cmd.Parameters["@ReportSQL"].Value = DBNull.Value;
                cmd.CommandText = "SELECT ReportID FROM PrintDesigns WHERE FormCode=@FormCode AND ReportName=@ReportName ";
                dt = new DataTable();
                da = new System.Data.SqlClient.SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    bFound = true;
                }
                dt.Dispose();
                da.Dispose();


                if (bFound)
                {
                    sReportName = Microsoft.VisualBasic.Interaction.InputBox("'" + sReportName + "' " + "rapor isminden başka bir kayıt var. Yeni bir isim giriniz.", "Yeni rapor ismi", sReportName);


                    if (sReportName.Trim()=="")
                    {
                        MessageBox.Show("Rapor ismi girmediniz. Rapor içeri alınamadı!");
                        return;
                    }
                    goto Basa;
                }
                cmd.Parameters["@ReportData"].Value = cReportDesing.ReportData.ToArray();
                System.Text.UTF8Encoding enc = new System.Text.UTF8Encoding();
                cmd.Parameters["@ReportSQL"].Value = enc.GetBytes(cReportDesing.ReportSQL);


                cmd.CommandText = "INSERT INTO PrintDesigns (CreatedBy,CreatedDate,ModifiedBy ,ModifiedDate,FormCode,ReportName,ReportData,ReportSQL) VALUES (" + DF.ActiveConn.UserID.ToString() + ",GETDATE()," + DF.ActiveConn.UserID.ToString() + ",GETDATE(),@FormCode, @ReportName,@ReportData,@ReportSQL)";

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                RefreshList();
            }
            catch (Exception ex)
            {
                UT.RaiseError(this.Name, "mnuDesingImport_Click", ex);
            }
        }
    }




}
