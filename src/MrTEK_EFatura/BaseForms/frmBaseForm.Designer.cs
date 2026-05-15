namespace MrTEK_EFatura
{
    partial class frmBaseForm
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
            this.FirmConn = new NeoDAC.NeoConnection(this.components);
            this.MasterTable = new NeoDAC.NeoTable(this.components);
            this.MasterLink = new NeoDAC.NeoLink(this.components);
            this.panelBaseBottom = new DevExpress.XtraEditors.PanelControl();
            this.cmdPrintGrid = new DevExpress.XtraEditors.SimpleButton();
            this.cmdExport = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.mnuExportExcel = new DevExpress.XtraBars.BarButtonItem();
            this.mnuExportExcelXLSX = new DevExpress.XtraBars.BarButtonItem();
            this.mnuExportTxt = new DevExpress.XtraBars.BarButtonItem();
            this.mnuExportCsv = new DevExpress.XtraBars.BarButtonItem();
            this.mnuExportPdf = new DevExpress.XtraBars.BarButtonItem();
            this.mnuExportHtml = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelBaseBottomRight = new DevExpress.XtraEditors.PanelControl();
            this.cmdDelete = new DevExpress.XtraEditors.SimpleButton();
            this.cmdNew = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCancel = new DevExpress.XtraEditors.SimpleButton();
            this.cmdSave = new DevExpress.XtraEditors.SimpleButton();
            this.cmdPrint = new DevExpress.XtraEditors.SimpleButton();
            this.ExportDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.MasterTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBaseBottom)).BeginInit();
            this.panelBaseBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBaseBottomRight)).BeginInit();
            this.panelBaseBottomRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirmConn
            // 
            this.FirmConn.ConnectionString = "Server=(local);Database=sarchem;User ID=sa;Password=;Trusted_Connection=True;";
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
            // MasterTable
            // 
            this.MasterTable.Connection = this.FirmConn;
            this.MasterTable.CurrentRow = null;
            this.MasterTable.DataSourceLink = null;
            this.MasterTable.DeleteCommand = null;
            this.MasterTable.Filter = "";
            this.MasterTable.InsertCommand = null;
            this.MasterTable.LiveSave = false;
            this.MasterTable.MaxRecords = ((long)(0));
            this.MasterTable.Name = "MasterTable";
            this.MasterTable.ParentRelation_ChildColumns = null;
            this.MasterTable.ParentRelation_ParentColumns = null;
            this.MasterTable.ParentRelation_Table = null;
            this.MasterTable.Position = ((long)(-1));
            this.MasterTable.Quoted = false;
            this.MasterTable.SelectCommand = null;
            this.MasterTable.TableName = "neoTable1";
            this.MasterTable.Transaction = null;
            this.MasterTable.UpdateCommand = null;
            this.MasterTable.ColumnChanged += new System.Data.DataColumnChangeEventHandler(this.MasterTable_ColumnChanged);
            // 
            // MasterLink
            // 
            this.MasterLink.Name = "MasterLink";
            // 
            // panelBaseBottom
            // 
            this.panelBaseBottom.Controls.Add(this.cmdPrintGrid);
            this.panelBaseBottom.Controls.Add(this.cmdExport);
            this.panelBaseBottom.Controls.Add(this.panelBaseBottomRight);
            this.panelBaseBottom.Controls.Add(this.cmdPrint);
            this.panelBaseBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBaseBottom.Location = new System.Drawing.Point(0, 528);
            this.panelBaseBottom.Name = "panelBaseBottom";
            this.panelBaseBottom.Size = new System.Drawing.Size(930, 53);
            this.panelBaseBottom.TabIndex = 0;
            // 
            // cmdPrintGrid
            // 
            this.cmdPrintGrid.Location = new System.Drawing.Point(125, 7);
            this.cmdPrintGrid.Name = "cmdPrintGrid";
            this.cmdPrintGrid.Size = new System.Drawing.Size(114, 37);
            this.cmdPrintGrid.TabIndex = 5;
            this.cmdPrintGrid.Text = "Listeyi yaz";
            this.cmdPrintGrid.Visible = false;
            this.cmdPrintGrid.Click += new System.EventHandler(this.cmdPrintGrid_Click);
            // 
            // cmdExport
            // 
            this.cmdExport.DropDownControl = this.popupMenu1;
            this.cmdExport.Location = new System.Drawing.Point(245, 7);
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.Size = new System.Drawing.Size(107, 37);
            this.cmdExport.TabIndex = 4;
            this.cmdExport.Text = "Export";
            this.cmdExport.Visible = false;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuExportExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuExportExcelXLSX),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuExportTxt),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuExportCsv),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuExportPdf),
            new DevExpress.XtraBars.LinkPersistInfo(this.mnuExportHtml)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // mnuExportExcel
            // 
            this.mnuExportExcel.Caption = "Excel (XLS)";
            this.mnuExportExcel.Id = 0;
            this.mnuExportExcel.Name = "mnuExportExcel";
            this.mnuExportExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuExportExcel_ItemClick);
            // 
            // mnuExportExcelXLSX
            // 
            this.mnuExportExcelXLSX.Caption = "Excel (XLSX)";
            this.mnuExportExcelXLSX.Id = 1;
            this.mnuExportExcelXLSX.Name = "mnuExportExcelXLSX";
            this.mnuExportExcelXLSX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuExportExcelXLSX_ItemClick);
            // 
            // mnuExportTxt
            // 
            this.mnuExportTxt.Caption = "Txt";
            this.mnuExportTxt.Id = 2;
            this.mnuExportTxt.Name = "mnuExportTxt";
            this.mnuExportTxt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuExportTxt_ItemClick);
            // 
            // mnuExportCsv
            // 
            this.mnuExportCsv.Caption = "Csv";
            this.mnuExportCsv.Id = 3;
            this.mnuExportCsv.Name = "mnuExportCsv";
            this.mnuExportCsv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuExportCsv_ItemClick);
            // 
            // mnuExportPdf
            // 
            this.mnuExportPdf.Caption = "Pdf";
            this.mnuExportPdf.Id = 4;
            this.mnuExportPdf.Name = "mnuExportPdf";
            this.mnuExportPdf.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuExportPdf_ItemClick);
            // 
            // mnuExportHtml
            // 
            this.mnuExportHtml.Caption = "Html";
            this.mnuExportHtml.Id = 5;
            this.mnuExportHtml.Name = "mnuExportHtml";
            this.mnuExportHtml.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuExportHtml_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mnuExportExcel,
            this.mnuExportExcelXLSX,
            this.mnuExportTxt,
            this.mnuExportCsv,
            this.mnuExportPdf,
            this.mnuExportHtml});
            this.barManager1.MaxItemId = 6;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(930, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 581);
            this.barDockControlBottom.Size = new System.Drawing.Size(930, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 581);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(930, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 581);
            // 
            // panelBaseBottomRight
            // 
            this.panelBaseBottomRight.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelBaseBottomRight.Controls.Add(this.cmdDelete);
            this.panelBaseBottomRight.Controls.Add(this.cmdNew);
            this.panelBaseBottomRight.Controls.Add(this.cmdCancel);
            this.panelBaseBottomRight.Controls.Add(this.cmdSave);
            this.panelBaseBottomRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBaseBottomRight.Location = new System.Drawing.Point(419, 2);
            this.panelBaseBottomRight.Name = "panelBaseBottomRight";
            this.panelBaseBottomRight.Size = new System.Drawing.Size(509, 49);
            this.panelBaseBottomRight.TabIndex = 1;
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(126, 5);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(97, 37);
            this.cmdDelete.TabIndex = 3;
            this.cmdDelete.Text = "Sil";
            this.cmdDelete.Visible = false;
            // 
            // cmdNew
            // 
            this.cmdNew.Location = new System.Drawing.Point(14, 5);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(97, 37);
            this.cmdNew.TabIndex = 2;
            this.cmdNew.Text = "Yeni";
            this.cmdNew.Visible = false;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(395, 5);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(97, 37);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "Vazgec";
            this.cmdCancel.Visible = false;
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(288, 5);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(97, 37);
            this.cmdSave.TabIndex = 0;
            this.cmdSave.Text = "Kaydet (F2)";
            this.cmdSave.Visible = false;
            // 
            // cmdPrint
            // 
            this.cmdPrint.Location = new System.Drawing.Point(5, 7);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(114, 37);
            this.cmdPrint.TabIndex = 2;
            this.cmdPrint.Text = "Yazdir (Ctrl+P)";
            this.cmdPrint.Visible = false;
            // 
            // frmBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 581);
            this.Controls.Add(this.panelBaseBottom);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.Name = "frmBaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaseForm";
            this.Load += new System.EventHandler(this.frmBaseForm_Load);
            this.Shown += new System.EventHandler(this.frmBaseForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBaseForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.MasterTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBaseBottom)).EndInit();
            this.panelBaseBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBaseBottomRight)).EndInit();
            this.panelBaseBottomRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public  NeoDAC.NeoConnection FirmConn;
        public NeoDAC.NeoTable MasterTable;
        public NeoDAC.NeoLink MasterLink;
        public DevExpress.XtraEditors.PanelControl panelBaseBottom;
        public DevExpress.XtraEditors.DropDownButton cmdExport;
        public DevExpress.XtraBars.PopupMenu popupMenu1;
        public DevExpress.XtraBars.BarButtonItem mnuExportExcel;
        public DevExpress.XtraBars.BarButtonItem mnuExportExcelXLSX;
        public DevExpress.XtraBars.BarButtonItem mnuExportTxt;
        public DevExpress.XtraBars.BarButtonItem mnuExportCsv;
        public DevExpress.XtraBars.BarButtonItem mnuExportPdf;
        public DevExpress.XtraBars.BarButtonItem mnuExportHtml;
        public DevExpress.XtraBars.BarManager barManager1;
        public DevExpress.XtraBars.BarDockControl barDockControlTop;
        public DevExpress.XtraBars.BarDockControl barDockControlBottom;
        public DevExpress.XtraBars.BarDockControl barDockControlLeft;
        public DevExpress.XtraBars.BarDockControl barDockControlRight;
        public DevExpress.XtraEditors.PanelControl panelBaseBottomRight;
        public DevExpress.XtraEditors.SimpleButton cmdDelete;
        public DevExpress.XtraEditors.SimpleButton cmdNew;
        public DevExpress.XtraEditors.SimpleButton cmdCancel;
        public DevExpress.XtraEditors.SimpleButton cmdSave;
        public DevExpress.XtraEditors.SimpleButton cmdPrint;
        public DevExpress.XtraEditors.SimpleButton cmdPrintGrid;
        private System.Windows.Forms.SaveFileDialog ExportDialog;
    }
}