using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MrTEK_EFatura
{
    public partial class frmBaseForm : Form
    {
        #region PublicProperty
        public string FormCode { get; set; }
        public DevExpress.XtraGrid.GridControl DefaultListGrid { get; set; }

        public event EventHandler ExportButtonClick;
        public FormAuthInfo FormAuth = new FormAuthInfo();
        private bool _SelectionMode = false;
        public bool SelectionMode
        {
            get
            {
                return _SelectionMode;
            }
            set
            {
                _SelectionMode = value;
                if (value == true)
                {
                    cmdSave.Text = "Sec(F2)";
                    cmdDelete.Visible = false;
                    cmdNew.Visible = false;
                }
            }
        }
        public bool MultiSelect { get; set; }
        public List<object> SelectedIDs { get; set; }
        public bool bNoAction = false;
        #endregion

        public frmBaseForm()
        {
            InitializeComponent();
            if (DesignMode) return;

            try
            {

                FirmConn.ConnectionString = DF.ActiveConn.dbConnStr;
                FirmConn.UserInfo_UserID = 0;
                FirmConn.Open();

            }
            catch (System.Exception ex)
            {
                //UT.RaiseError(this.Name, "frmBaseForm", ex);
            }
        }

        private void frmBaseForm_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            try
            {
                if (MasterTable.Columns.Count > 0 && MasterTable.SelectCommand != null && MasterTable.SelectCommand.CommandText != "")
                {
                    UT.OpenTable(MasterTable);
                }


                if (SelectionMode)
                {
                    if (DefaultListGrid != null)
                    {
                        DevExpress.XtraGrid.Views.Grid.GridView grV = (DevExpress.XtraGrid.Views.Grid.GridView)DefaultListGrid.MainView;
                        grV.OptionsSelection.MultiSelect = MultiSelect;
                    }
                }
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "frmBaseForm_Load", ex);
            }

        }

        
        #region Export


        private void mnuExportHtml_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BaseForm_Export(ExportType.Html);
        }

        private void mnuExportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BaseForm_Export(ExportType.Excel);
        }

        private void mnuExportExcelXLSX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BaseForm_Export(ExportType.ExcelXlsx);
        }

        private void mnuExportTxt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BaseForm_Export(ExportType.Txt);
        }

        private void mnuExportCsv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BaseForm_Export(ExportType.Csv);
        }

        private void mnuExportPdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BaseForm_Export(ExportType.Pdf);
        }


        private void BaseForm_Export(ExportType exporttype)
        {

            try
            {
                ExportEventArgs args = new ExportEventArgs();
                args.exporttype = exporttype;

                EventHandler handler = ExportButtonClick;
                if (handler != null)
                {
                    handler(this, args);
                    return;
                }


                if (DefaultListGrid == null) return;
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
                            UT.RaiseError(this.Name, "BaseForm_Export_2", ex);
                        }


                    }

                }
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "BaseForm_Export", ex);
            }
        }
        #endregion

        private void frmBaseForm_Shown(object sender, EventArgs e)
        {
            if (DesignMode) return;


        }

        private void frmBaseForm_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F2)
                {
                    if (cmdSave.Enabled)
                    {
                        cmdSave.Focus();
                        SendKeys.Send("{ENTER}");
                    }
                }
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "frmBaseForm_KeyDown", ex);
            }
        }

        private void cmdPrintGrid_Click(object sender, EventArgs e)
        {
            try
            {
                if (DefaultListGrid == null) return;
                DefaultListGrid.MainView.ShowRibbonPrintPreview();
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "cmdPrintGrid_Click", ex);
            }
        }

        private void MasterTable_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            e.Row.EndEdit();
        }




    }
}
