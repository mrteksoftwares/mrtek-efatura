namespace MrTEK_EDefter
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
            this.grDetailView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grSiparisler = new DevExpress.XtraGrid.GridControl();
            this.grSiparislerView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsip_RECno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSiparisNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsip_evrakno_seri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsip_evrakno_sira = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsip_tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsip_stok_kod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsto_isim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsip_miktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsip_b_fiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsip_tutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsip_teslim_miktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKalan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.carileriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cikisToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yardimToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.programHakkindaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programHakkindaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tbCariHesaplar = new NeoDAC.NeoTable(this.components);
            this.tbCariHesaplar_cari_kod = new System.Data.DataColumn();
            this.tbCariHesaplar_cari_unvan1 = new System.Data.DataColumn();
            this.tbCariHesaplar_cari_unvan2 = new System.Data.DataColumn();
            this.tbCariHesaplar_adr_adres_no = new System.Data.DataColumn();
            this.tbCariHesaplar_Adres = new System.Data.DataColumn();
            this.tbCariHesaplar_adr_ilce = new System.Data.DataColumn();
            this.tbCariHesaplar_adr_il = new System.Data.DataColumn();
            this.tbCariHesaplar_adr_tel_bolge_kodu = new System.Data.DataColumn();
            this.tbCariHesaplar_adr_tel_no1 = new System.Data.DataColumn();
            this.tbCariHesaplar_adr_tel_no2 = new System.Data.DataColumn();
            this.tbCariHesaplar_adr_tel_faxno = new System.Data.DataColumn();
            this.tbCariHesaplar_adr_tel_modem = new System.Data.DataColumn();
            this.dbConn = new NeoDAC.NeoConnection(this.components);
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcari_kod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcari_unvan1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcari_unvan2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_adres_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_ilce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_il = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_tel_bolge_kodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_tel_no1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_tel_no2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_tel_faxno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladr_tel_modem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.cmdYeniSiparis = new DevExpress.XtraEditors.SimpleButton();
            this.lblCallerIDONOFF = new DevExpress.XtraEditors.LabelControl();
            this.btnPrintForm = new DevExpress.XtraEditors.SimpleButton();
            this.userCntDateFilter1 = new MrTEK_EDefter.userCntDateFilter();
            this.cmdExcelExport = new DevExpress.XtraEditors.SimpleButton();
            this.cmdPrintGrid = new DevExpress.XtraEditors.SimpleButton();
            this.cmdListele = new DevExpress.XtraEditors.SimpleButton();
            this.txtBakiye = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtUnvan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCariKod = new DevExpress.XtraEditors.TextEdit();
            this.sqlCommand5 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand6 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand7 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand8 = new System.Data.SqlClient.SqlCommand();
            this.ExportDialog = new System.Windows.Forms.SaveFileDialog();
            this.neoTable1 = new NeoDAC.NeoTable(this.components);
            this.neoTable1_sip_RECno = new System.Data.DataColumn();
            this.neoTable1_SiparisNo = new System.Data.DataColumn();
            this.neoTable1_sip_evrakno_seri = new System.Data.DataColumn();
            this.neoTable1_sip_evrakno_sira = new System.Data.DataColumn();
            this.neoTable1_sip_tarih = new System.Data.DataColumn();
            this.neoTable1_sip_stok_kod = new System.Data.DataColumn();
            this.neoTable1_sto_isim = new System.Data.DataColumn();
            this.neoTable1_sip_miktar = new System.Data.DataColumn();
            this.neoTable1_sip_b_fiyat = new System.Data.DataColumn();
            this.neoTable1_sip_tutar = new System.Data.DataColumn();
            this.neoTable1_NetTutar = new System.Data.DataColumn();
            this.neoTable1_sip_teslim_miktar = new System.Data.DataColumn();
            this.neoTable1_Kalan = new System.Data.DataColumn();
            this.sqlCommand12 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand10 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand9 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand11 = new System.Data.SqlClient.SqlCommand();
            this.neoCommand1 = new NeoDAC.NeoCommand(this.components);
            this.panelCallerID = new DevExpress.XtraEditors.PanelControl();
            this.cmdCallerID_ClosePanel = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCallerID_AddOrder = new DevExpress.XtraEditors.SimpleButton();
            this.lstCallerIDList = new DevExpress.XtraEditors.ListBoxControl();
            this.tmrCallerIDCheck = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdCariDuzelt = new DevExpress.XtraEditors.SimpleButton();
            this.cmdYeniCari = new DevExpress.XtraEditors.SimpleButton();
            this.txtCariAdresNo = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grDetailView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grSiparisler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grSiparislerView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCariHesaplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnvan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neoTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCallerID)).BeginInit();
            this.panelCallerID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstCallerIDList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAdresNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grDetailView
            // 
            this.grDetailView.GridControl = this.grSiparisler;
            this.grDetailView.Name = "grDetailView";
            // 
            // grSiparisler
            // 
            this.grSiparisler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grSiparisler.Location = new System.Drawing.Point(0, 0);
            this.grSiparisler.MainView = this.grSiparislerView;
            this.grSiparisler.Name = "grSiparisler";
            this.grSiparisler.Size = new System.Drawing.Size(811, 417);
            this.grSiparisler.TabIndex = 2;
            this.grSiparisler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grSiparislerView,
            this.grDetailView});
            this.grSiparisler.DoubleClick += new System.EventHandler(this.grSiparisler_DoubleClick);
            // 
            // grSiparislerView
            // 
            this.grSiparislerView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsip_RECno,
            this.colSiparisNo,
            this.colsip_evrakno_seri,
            this.colsip_evrakno_sira,
            this.colsip_tarih,
            this.colsip_stok_kod,
            this.colsto_isim,
            this.colsip_miktar,
            this.colsip_b_fiyat,
            this.colsip_tutar,
            this.colNetTutar,
            this.colsip_teslim_miktar,
            this.colKalan});
            this.grSiparislerView.CustomizationFormBounds = new System.Drawing.Rectangle(1115, 556, 210, 194);
            this.grSiparislerView.GridControl = this.grSiparisler;
            this.grSiparislerView.GroupCount = 1;
            this.grSiparislerView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetTutar", this.colNetTutar, "{#,##0.00}")});
            this.grSiparislerView.Name = "grSiparislerView";
            this.grSiparislerView.OptionsBehavior.AutoExpandAllGroups = true;
            this.grSiparislerView.OptionsBehavior.Editable = false;
            this.grSiparislerView.OptionsLayout.LayoutVersion = "1.1";
            this.grSiparislerView.OptionsView.ColumnAutoWidth = false;
            this.grSiparislerView.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.grSiparislerView.OptionsView.ShowAutoFilterRow = true;
            this.grSiparislerView.OptionsView.ShowFooter = true;
            this.grSiparislerView.OptionsView.ShowGroupedColumns = true;
            this.grSiparislerView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSiparisNo, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colsip_tarih, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colsip_RECno
            // 
            this.colsip_RECno.FieldName = "sip_RECno";
            this.colsip_RECno.Name = "colsip_RECno";
            // 
            // colSiparisNo
            // 
            this.colSiparisNo.Caption = "Siparis No";
            this.colSiparisNo.FieldName = "SiparisNo";
            this.colSiparisNo.Name = "colSiparisNo";
            this.colSiparisNo.Visible = true;
            this.colSiparisNo.VisibleIndex = 0;
            this.colSiparisNo.Width = 109;
            // 
            // colsip_evrakno_seri
            // 
            this.colsip_evrakno_seri.Caption = "Sip.Seri";
            this.colsip_evrakno_seri.FieldName = "sip_evrakno_seri";
            this.colsip_evrakno_seri.Name = "colsip_evrakno_seri";
            this.colsip_evrakno_seri.Visible = true;
            this.colsip_evrakno_seri.VisibleIndex = 1;
            // 
            // colsip_evrakno_sira
            // 
            this.colsip_evrakno_sira.Caption = "Sip.Sira";
            this.colsip_evrakno_sira.FieldName = "sip_evrakno_sira";
            this.colsip_evrakno_sira.Name = "colsip_evrakno_sira";
            this.colsip_evrakno_sira.Visible = true;
            this.colsip_evrakno_sira.VisibleIndex = 2;
            // 
            // colsip_tarih
            // 
            this.colsip_tarih.Caption = "Tarih";
            this.colsip_tarih.FieldName = "sip_tarih";
            this.colsip_tarih.Name = "colsip_tarih";
            this.colsip_tarih.Visible = true;
            this.colsip_tarih.VisibleIndex = 3;
            // 
            // colsip_stok_kod
            // 
            this.colsip_stok_kod.Caption = "Stok Kod";
            this.colsip_stok_kod.FieldName = "sip_stok_kod";
            this.colsip_stok_kod.Name = "colsip_stok_kod";
            this.colsip_stok_kod.Visible = true;
            this.colsip_stok_kod.VisibleIndex = 4;
            // 
            // colsto_isim
            // 
            this.colsto_isim.Caption = "Stok Ismi";
            this.colsto_isim.FieldName = "sto_isim";
            this.colsto_isim.Name = "colsto_isim";
            this.colsto_isim.Visible = true;
            this.colsto_isim.VisibleIndex = 5;
            // 
            // colsip_miktar
            // 
            this.colsip_miktar.Caption = "Miktar";
            this.colsip_miktar.FieldName = "sip_miktar";
            this.colsip_miktar.Name = "colsip_miktar";
            this.colsip_miktar.Visible = true;
            this.colsip_miktar.VisibleIndex = 6;
            // 
            // colsip_b_fiyat
            // 
            this.colsip_b_fiyat.Caption = "Fiyat";
            this.colsip_b_fiyat.FieldName = "sip_b_fiyat";
            this.colsip_b_fiyat.Name = "colsip_b_fiyat";
            this.colsip_b_fiyat.Visible = true;
            this.colsip_b_fiyat.VisibleIndex = 7;
            // 
            // colsip_tutar
            // 
            this.colsip_tutar.Caption = "Tutar";
            this.colsip_tutar.DisplayFormat.FormatString = "#,##0.00";
            this.colsip_tutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colsip_tutar.FieldName = "sip_tutar";
            this.colsip_tutar.Name = "colsip_tutar";
            this.colsip_tutar.Visible = true;
            this.colsip_tutar.VisibleIndex = 8;
            // 
            // colNetTutar
            // 
            this.colNetTutar.Caption = "Net Tutar";
            this.colNetTutar.DisplayFormat.FormatString = "#,##0.00";
            this.colNetTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNetTutar.FieldName = "NetTutar";
            this.colNetTutar.GroupFormat.FormatString = "{0:#,##0.00}";
            this.colNetTutar.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNetTutar.Name = "colNetTutar";
            this.colNetTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetTutar", "{0:#,##0.00}")});
            this.colNetTutar.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colNetTutar.Visible = true;
            this.colNetTutar.VisibleIndex = 9;
            // 
            // colsip_teslim_miktar
            // 
            this.colsip_teslim_miktar.Caption = "Teslim Miktar";
            this.colsip_teslim_miktar.FieldName = "sip_teslim_miktar";
            this.colsip_teslim_miktar.Name = "colsip_teslim_miktar";
            this.colsip_teslim_miktar.Visible = true;
            this.colsip_teslim_miktar.VisibleIndex = 10;
            // 
            // colKalan
            // 
            this.colKalan.Caption = "Kalan";
            this.colKalan.FieldName = "Kalan";
            this.colKalan.Name = "colKalan";
            this.colKalan.Visible = true;
            this.colKalan.VisibleIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem1,
            this.yardimToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1314, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem1
            // 
            this.dosyaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carileriListeleToolStripMenuItem,
            this.toolStripMenuItem1,
            this.cikisToolStripMenuItem1});
            this.dosyaToolStripMenuItem1.Name = "dosyaToolStripMenuItem1";
            this.dosyaToolStripMenuItem1.Size = new System.Drawing.Size(62, 24);
            this.dosyaToolStripMenuItem1.Text = "Dosya";
            // 
            // carileriListeleToolStripMenuItem
            // 
            this.carileriListeleToolStripMenuItem.Name = "carileriListeleToolStripMenuItem";
            this.carileriListeleToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.carileriListeleToolStripMenuItem.Text = "Carileri listele";
            this.carileriListeleToolStripMenuItem.Click += new System.EventHandler(this.carileriListeleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 6);
            // 
            // cikisToolStripMenuItem1
            // 
            this.cikisToolStripMenuItem1.Name = "cikisToolStripMenuItem1";
            this.cikisToolStripMenuItem1.Size = new System.Drawing.Size(168, 24);
            this.cikisToolStripMenuItem1.Text = "Cikis";
            this.cikisToolStripMenuItem1.Click += new System.EventHandler(this.cikisToolStripMenuItem1_Click);
            // 
            // yardimToolStripMenuItem1
            // 
            this.yardimToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programHakkindaToolStripMenuItem1});
            this.yardimToolStripMenuItem1.Name = "yardimToolStripMenuItem1";
            this.yardimToolStripMenuItem1.Size = new System.Drawing.Size(68, 24);
            this.yardimToolStripMenuItem1.Text = "Yardim";
            // 
            // programHakkindaToolStripMenuItem1
            // 
            this.programHakkindaToolStripMenuItem1.Name = "programHakkindaToolStripMenuItem1";
            this.programHakkindaToolStripMenuItem1.Size = new System.Drawing.Size(198, 24);
            this.programHakkindaToolStripMenuItem1.Text = "Program hakkinda";
            this.programHakkindaToolStripMenuItem1.Click += new System.EventHandler(this.programHakkindaToolStripMenuItem1_Click);
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.cikisToolStripMenuItem.Text = "Cikis";
            // 
            // yardimToolStripMenuItem
            // 
            this.yardimToolStripMenuItem.Name = "yardimToolStripMenuItem";
            this.yardimToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.yardimToolStripMenuItem.Text = "Yardim";
            // 
            // programHakkindaToolStripMenuItem
            // 
            this.programHakkindaToolStripMenuItem.Name = "programHakkindaToolStripMenuItem";
            this.programHakkindaToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.programHakkindaToolStripMenuItem.Text = "Program hakkinda";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tbCariHesaplar;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(490, 520);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // tbCariHesaplar
            // 
            this.tbCariHesaplar.Columns.AddRange(new System.Data.DataColumn[] {
            this.tbCariHesaplar_cari_kod,
            this.tbCariHesaplar_cari_unvan1,
            this.tbCariHesaplar_cari_unvan2,
            this.tbCariHesaplar_adr_adres_no,
            this.tbCariHesaplar_Adres,
            this.tbCariHesaplar_adr_ilce,
            this.tbCariHesaplar_adr_il,
            this.tbCariHesaplar_adr_tel_bolge_kodu,
            this.tbCariHesaplar_adr_tel_no1,
            this.tbCariHesaplar_adr_tel_no2,
            this.tbCariHesaplar_adr_tel_faxno,
            this.tbCariHesaplar_adr_tel_modem});
            this.tbCariHesaplar.Connection = this.dbConn;
            this.tbCariHesaplar.CurrentRow = null;
            this.tbCariHesaplar.DataSourceLink = null;
            this.tbCariHesaplar.DeleteCommand = this.sqlCommand4;
            this.tbCariHesaplar.Filter = "";
            this.tbCariHesaplar.InsertCommand = this.sqlCommand2;
            this.tbCariHesaplar.LiveSave = false;
            this.tbCariHesaplar.MaxRecords = ((long)(0));
            this.tbCariHesaplar.Name = "tbCariHesaplar";
            this.tbCariHesaplar.ParentRelation_ChildColumns = null;
            this.tbCariHesaplar.ParentRelation_ParentColumns = null;
            this.tbCariHesaplar.ParentRelation_Table = null;
            this.tbCariHesaplar.Position = ((long)(-1));
            this.tbCariHesaplar.Quoted = false;
            this.tbCariHesaplar.SelectCommand = this.sqlCommand1;
            this.tbCariHesaplar.TableName = "neoTable1";
            this.tbCariHesaplar.Transaction = null;
            this.tbCariHesaplar.UpdateCommand = this.sqlCommand3;
            // 
            // tbCariHesaplar_cari_kod
            // 
            this.tbCariHesaplar_cari_kod.ColumnName = "cari_kod";
            // 
            // tbCariHesaplar_cari_unvan1
            // 
            this.tbCariHesaplar_cari_unvan1.ColumnName = "cari_unvan1";
            // 
            // tbCariHesaplar_cari_unvan2
            // 
            this.tbCariHesaplar_cari_unvan2.ColumnName = "cari_unvan2";
            // 
            // tbCariHesaplar_adr_adres_no
            // 
            this.tbCariHesaplar_adr_adres_no.ColumnName = "adr_adres_no";
            this.tbCariHesaplar_adr_adres_no.DataType = typeof(int);
            // 
            // tbCariHesaplar_Adres
            // 
            this.tbCariHesaplar_Adres.ColumnName = "Adres";
            // 
            // tbCariHesaplar_adr_ilce
            // 
            this.tbCariHesaplar_adr_ilce.ColumnName = "adr_ilce";
            // 
            // tbCariHesaplar_adr_il
            // 
            this.tbCariHesaplar_adr_il.ColumnName = "adr_il";
            // 
            // tbCariHesaplar_adr_tel_bolge_kodu
            // 
            this.tbCariHesaplar_adr_tel_bolge_kodu.ColumnName = "adr_tel_bolge_kodu";
            // 
            // tbCariHesaplar_adr_tel_no1
            // 
            this.tbCariHesaplar_adr_tel_no1.ColumnName = "adr_tel_no1";
            // 
            // tbCariHesaplar_adr_tel_no2
            // 
            this.tbCariHesaplar_adr_tel_no2.ColumnName = "adr_tel_no2";
            // 
            // tbCariHesaplar_adr_tel_faxno
            // 
            this.tbCariHesaplar_adr_tel_faxno.ColumnName = "adr_tel_faxno";
            // 
            // tbCariHesaplar_adr_tel_modem
            // 
            this.tbCariHesaplar_adr_tel_modem.ColumnName = "adr_tel_modem";
            // 
            // dbConn
            // 
            this.dbConn.ConnectionString = "Server=(local)\\SQL2008;Database=MikroDB_V15_TEST;User ID=sa;Password=;Trusted_Con" +
    "nection=True;";
            this.dbConn.Name = "dbConn";
            this.dbConn.UserInfo_AuthCodeFieldName = "AuthCode";
            this.dbConn.UserInfo_CanDeleteAuthCode = "";
            this.dbConn.UserInfo_CanReadAuthCode = "";
            this.dbConn.UserInfo_CanWriteAuthCode = "";
            this.dbConn.UserInfo_CreatedDateFieldName = "CreatedDate";
            this.dbConn.UserInfo_CreatedUserFieldName = "CreatedBy";
            this.dbConn.UserInfo_ModifiedDateFieldName = "ModifiedDate";
            this.dbConn.UserInfo_ModifiedUserFieldName = "ModifiedBy";
            this.dbConn.UserInfo_NewRecordAuthCode = "";
            this.dbConn.UserInfo_UserID = null;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = resources.GetString("sqlCommand1.CommandText");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcari_kod,
            this.colcari_unvan1,
            this.colcari_unvan2,
            this.coladr_adres_no,
            this.colAdres,
            this.coladr_ilce,
            this.coladr_il,
            this.coladr_tel_bolge_kodu,
            this.coladr_tel_no1,
            this.coladr_tel_no2,
            this.coladr_tel_faxno,
            this.coladr_tel_modem});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colcari_kod
            // 
            this.colcari_kod.Caption = "Cari Kod";
            this.colcari_kod.FieldName = "cari_kod";
            this.colcari_kod.Name = "colcari_kod";
            this.colcari_kod.Width = 105;
            // 
            // colcari_unvan1
            // 
            this.colcari_unvan1.Caption = "Unvan 1";
            this.colcari_unvan1.FieldName = "cari_unvan1";
            this.colcari_unvan1.Name = "colcari_unvan1";
            this.colcari_unvan1.Visible = true;
            this.colcari_unvan1.VisibleIndex = 0;
            this.colcari_unvan1.Width = 225;
            // 
            // colcari_unvan2
            // 
            this.colcari_unvan2.Caption = "Unvan 2";
            this.colcari_unvan2.FieldName = "cari_unvan2";
            this.colcari_unvan2.Name = "colcari_unvan2";
            // 
            // coladr_adres_no
            // 
            this.coladr_adres_no.Caption = "#AdrNo";
            this.coladr_adres_no.FieldName = "adr_adres_no";
            this.coladr_adres_no.Name = "coladr_adres_no";
            this.coladr_adres_no.Visible = true;
            this.coladr_adres_no.VisibleIndex = 1;
            // 
            // colAdres
            // 
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.Visible = true;
            this.colAdres.VisibleIndex = 2;
            this.colAdres.Width = 339;
            // 
            // coladr_ilce
            // 
            this.coladr_ilce.Caption = "Ilce";
            this.coladr_ilce.FieldName = "adr_ilce";
            this.coladr_ilce.Name = "coladr_ilce";
            this.coladr_ilce.Visible = true;
            this.coladr_ilce.VisibleIndex = 3;
            // 
            // coladr_il
            // 
            this.coladr_il.Caption = "Sehir";
            this.coladr_il.FieldName = "adr_il";
            this.coladr_il.Name = "coladr_il";
            this.coladr_il.Visible = true;
            this.coladr_il.VisibleIndex = 4;
            // 
            // coladr_tel_bolge_kodu
            // 
            this.coladr_tel_bolge_kodu.Caption = "Tel Kod";
            this.coladr_tel_bolge_kodu.FieldName = "adr_tel_bolge_kodu";
            this.coladr_tel_bolge_kodu.Name = "coladr_tel_bolge_kodu";
            this.coladr_tel_bolge_kodu.Visible = true;
            this.coladr_tel_bolge_kodu.VisibleIndex = 5;
            // 
            // coladr_tel_no1
            // 
            this.coladr_tel_no1.Caption = "Tel1";
            this.coladr_tel_no1.FieldName = "adr_tel_no1";
            this.coladr_tel_no1.Name = "coladr_tel_no1";
            this.coladr_tel_no1.Visible = true;
            this.coladr_tel_no1.VisibleIndex = 6;
            // 
            // coladr_tel_no2
            // 
            this.coladr_tel_no2.Caption = "Tel2";
            this.coladr_tel_no2.FieldName = "adr_tel_no2";
            this.coladr_tel_no2.Name = "coladr_tel_no2";
            this.coladr_tel_no2.Visible = true;
            this.coladr_tel_no2.VisibleIndex = 7;
            // 
            // coladr_tel_faxno
            // 
            this.coladr_tel_faxno.Caption = "Fax";
            this.coladr_tel_faxno.FieldName = "adr_tel_faxno";
            this.coladr_tel_faxno.Name = "coladr_tel_faxno";
            this.coladr_tel_faxno.Visible = true;
            this.coladr_tel_faxno.VisibleIndex = 8;
            // 
            // coladr_tel_modem
            // 
            this.coladr_tel_modem.Caption = "Modem";
            this.coladr_tel_modem.FieldName = "adr_tel_modem";
            this.coladr_tel_modem.Name = "coladr_tel_modem";
            this.coladr_tel_modem.Visible = true;
            this.coladr_tel_modem.VisibleIndex = 9;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 133);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(817, 448);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.grSiparisler);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(811, 417);
            this.xtraTabPage1.Text = "Siparisler";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.PageVisible = false;
            this.xtraTabPage2.Size = new System.Drawing.Size(811, 417);
            this.xtraTabPage2.Text = "Cari bilgiler";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(490, 28);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 583);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.xtraTabControl1);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(493, 28);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(821, 583);
            this.panelControl1.TabIndex = 4;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtCariAdresNo);
            this.panelControl2.Controls.Add(this.cmdYeniSiparis);
            this.panelControl2.Controls.Add(this.lblCallerIDONOFF);
            this.panelControl2.Controls.Add(this.btnPrintForm);
            this.panelControl2.Controls.Add(this.userCntDateFilter1);
            this.panelControl2.Controls.Add(this.cmdExcelExport);
            this.panelControl2.Controls.Add(this.cmdPrintGrid);
            this.panelControl2.Controls.Add(this.cmdListele);
            this.panelControl2.Controls.Add(this.txtBakiye);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.txtUnvan);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.txtCariKod);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(817, 131);
            this.panelControl2.TabIndex = 3;
            // 
            // cmdYeniSiparis
            // 
            this.cmdYeniSiparis.Location = new System.Drawing.Point(534, 76);
            this.cmdYeniSiparis.Name = "cmdYeniSiparis";
            this.cmdYeniSiparis.Size = new System.Drawing.Size(121, 37);
            this.cmdYeniSiparis.TabIndex = 13;
            this.cmdYeniSiparis.Text = "(+) Yeni Siparis";
            this.cmdYeniSiparis.Click += new System.EventHandler(this.cmdYeniSiparis_Click);
            // 
            // lblCallerIDONOFF
            // 
            this.lblCallerIDONOFF.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblCallerIDONOFF.Location = new System.Drawing.Point(784, 107);
            this.lblCallerIDONOFF.Name = "lblCallerIDONOFF";
            this.lblCallerIDONOFF.Size = new System.Drawing.Size(84, 16);
            this.lblCallerIDONOFF.TabIndex = 12;
            this.lblCallerIDONOFF.Text = "Caller ID: OFF";
            // 
            // btnPrintForm
            // 
            this.btnPrintForm.Image = global::MrTEK_EDefter.Properties.Resources.print_icon_32x32;
            this.btnPrintForm.Location = new System.Drawing.Point(561, 5);
            this.btnPrintForm.Name = "btnPrintForm";
            this.btnPrintForm.Size = new System.Drawing.Size(94, 46);
            this.btnPrintForm.TabIndex = 11;
            this.btnPrintForm.Text = "Yazdir";
            this.btnPrintForm.Click += new System.EventHandler(this.btnPrintForm_Click);
            // 
            // userCntDateFilter1
            // 
            this.userCntDateFilter1.Location = new System.Drawing.Point(5, 57);
            this.userCntDateFilter1.Name = "userCntDateFilter1";
            this.userCntDateFilter1.Size = new System.Drawing.Size(500, 66);
            this.userCntDateFilter1.TabIndex = 10;
            // 
            // cmdExcelExport
            // 
            this.cmdExcelExport.Image = global::MrTEK_EDefter.Properties.Resources.Excel_icon_32x32;
            this.cmdExcelExport.Location = new System.Drawing.Point(671, 5);
            this.cmdExcelExport.Name = "cmdExcelExport";
            this.cmdExcelExport.Size = new System.Drawing.Size(94, 46);
            this.cmdExcelExport.TabIndex = 9;
            this.cmdExcelExport.Text = "Excel";
            this.cmdExcelExport.Click += new System.EventHandler(this.cmdExcelExport_Click);
            // 
            // cmdPrintGrid
            // 
            this.cmdPrintGrid.Image = global::MrTEK_EDefter.Properties.Resources.GridView;
            this.cmdPrintGrid.Location = new System.Drawing.Point(771, 5);
            this.cmdPrintGrid.Name = "cmdPrintGrid";
            this.cmdPrintGrid.Size = new System.Drawing.Size(135, 46);
            this.cmdPrintGrid.TabIndex = 8;
            this.cmdPrintGrid.Text = "Liste Yazdir";
            this.cmdPrintGrid.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // cmdListele
            // 
            this.cmdListele.Image = global::MrTEK_EDefter.Properties.Resources.Actions_view_refresh_icon_32x32;
            this.cmdListele.Location = new System.Drawing.Point(420, 5);
            this.cmdListele.Name = "cmdListele";
            this.cmdListele.Size = new System.Drawing.Size(124, 46);
            this.cmdListele.TabIndex = 6;
            this.cmdListele.Text = "Listele (F5)";
            this.cmdListele.Click += new System.EventHandler(this.cmdListele_Click);
            // 
            // txtBakiye
            // 
            this.txtBakiye.EnterMoveNextControl = true;
            this.txtBakiye.Location = new System.Drawing.Point(301, 3);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Properties.ReadOnly = true;
            this.txtBakiye.Size = new System.Drawing.Size(113, 22);
            this.txtBakiye.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(259, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Bakiye";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 32);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Unvan";
            // 
            // txtUnvan
            // 
            this.txtUnvan.EnterMoveNextControl = true;
            this.txtUnvan.Location = new System.Drawing.Point(47, 29);
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.Properties.ReadOnly = true;
            this.txtUnvan.Size = new System.Drawing.Size(325, 22);
            this.txtUnvan.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(21, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Kod";
            // 
            // txtCariKod
            // 
            this.txtCariKod.EnterMoveNextControl = true;
            this.txtCariKod.Location = new System.Drawing.Point(47, 5);
            this.txtCariKod.Name = "txtCariKod";
            this.txtCariKod.Properties.ReadOnly = true;
            this.txtCariKod.Size = new System.Drawing.Size(173, 22);
            this.txtCariKod.TabIndex = 0;
            // 
            // sqlCommand5
            // 
            this.sqlCommand5.CommandText = "SELECT * FROM SIPHAR";
            // 
            // neoTable1
            // 
            this.neoTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.neoTable1_sip_RECno,
            this.neoTable1_SiparisNo,
            this.neoTable1_sip_evrakno_seri,
            this.neoTable1_sip_evrakno_sira,
            this.neoTable1_sip_tarih,
            this.neoTable1_sip_stok_kod,
            this.neoTable1_sto_isim,
            this.neoTable1_sip_miktar,
            this.neoTable1_sip_b_fiyat,
            this.neoTable1_sip_tutar,
            this.neoTable1_NetTutar,
            this.neoTable1_sip_teslim_miktar,
            this.neoTable1_Kalan});
            this.neoTable1.Connection = this.dbConn;
            this.neoTable1.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "sip_RECno"}, true)});
            this.neoTable1.CurrentRow = null;
            this.neoTable1.DataSourceLink = null;
            this.neoTable1.DeleteCommand = this.sqlCommand12;
            this.neoTable1.Filter = "";
            this.neoTable1.InsertCommand = this.sqlCommand10;
            this.neoTable1.LiveSave = false;
            this.neoTable1.MaxRecords = ((long)(0));
            this.neoTable1.Name = "neoTable1";
            this.neoTable1.ParentRelation_ChildColumns = null;
            this.neoTable1.ParentRelation_ParentColumns = null;
            this.neoTable1.ParentRelation_Table = null;
            this.neoTable1.Position = ((long)(-1));
            this.neoTable1.PrimaryKey = new System.Data.DataColumn[] {
        this.neoTable1_sip_RECno};
            this.neoTable1.Quoted = false;
            this.neoTable1.SelectCommand = this.sqlCommand9;
            this.neoTable1.TableName = "neoTable1";
            this.neoTable1.Transaction = null;
            this.neoTable1.UpdateCommand = this.sqlCommand11;
            // 
            // neoTable1_sip_RECno
            // 
            this.neoTable1_sip_RECno.AllowDBNull = false;
            this.neoTable1_sip_RECno.AutoIncrement = true;
            this.neoTable1_sip_RECno.ColumnName = "sip_RECno";
            this.neoTable1_sip_RECno.DataType = typeof(int);
            // 
            // neoTable1_SiparisNo
            // 
            this.neoTable1_SiparisNo.ColumnName = "SiparisNo";
            // 
            // neoTable1_sip_evrakno_seri
            // 
            this.neoTable1_sip_evrakno_seri.ColumnName = "sip_evrakno_seri";
            // 
            // neoTable1_sip_evrakno_sira
            // 
            this.neoTable1_sip_evrakno_sira.ColumnName = "sip_evrakno_sira";
            this.neoTable1_sip_evrakno_sira.DataType = typeof(int);
            // 
            // neoTable1_sip_tarih
            // 
            this.neoTable1_sip_tarih.ColumnName = "sip_tarih";
            this.neoTable1_sip_tarih.DataType = typeof(System.DateTime);
            // 
            // neoTable1_sip_stok_kod
            // 
            this.neoTable1_sip_stok_kod.ColumnName = "sip_stok_kod";
            // 
            // neoTable1_sto_isim
            // 
            this.neoTable1_sto_isim.ColumnName = "sto_isim";
            // 
            // neoTable1_sip_miktar
            // 
            this.neoTable1_sip_miktar.ColumnName = "sip_miktar";
            this.neoTable1_sip_miktar.DataType = typeof(double);
            // 
            // neoTable1_sip_b_fiyat
            // 
            this.neoTable1_sip_b_fiyat.ColumnName = "sip_b_fiyat";
            this.neoTable1_sip_b_fiyat.DataType = typeof(double);
            // 
            // neoTable1_sip_tutar
            // 
            this.neoTable1_sip_tutar.ColumnName = "sip_tutar";
            this.neoTable1_sip_tutar.DataType = typeof(double);
            // 
            // neoTable1_NetTutar
            // 
            this.neoTable1_NetTutar.ColumnName = "NetTutar";
            this.neoTable1_NetTutar.DataType = typeof(double);
            // 
            // neoTable1_sip_teslim_miktar
            // 
            this.neoTable1_sip_teslim_miktar.ColumnName = "sip_teslim_miktar";
            this.neoTable1_sip_teslim_miktar.DataType = typeof(double);
            // 
            // neoTable1_Kalan
            // 
            this.neoTable1_Kalan.ColumnName = "Kalan";
            this.neoTable1_Kalan.DataType = typeof(double);
            // 
            // sqlCommand9
            // 
            this.sqlCommand9.CommandText = resources.GetString("sqlCommand9.CommandText");
            // 
            // neoCommand1
            // 
            this.neoCommand1.CommandTimeout = 30;
            this.neoCommand1.Name = "neoCommand1";
            // 
            // panelCallerID
            // 
            this.panelCallerID.Controls.Add(this.cmdCallerID_ClosePanel);
            this.panelCallerID.Controls.Add(this.cmdCallerID_AddOrder);
            this.panelCallerID.Controls.Add(this.lstCallerIDList);
            this.panelCallerID.Location = new System.Drawing.Point(158, 137);
            this.panelCallerID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelCallerID.Name = "panelCallerID";
            this.panelCallerID.Size = new System.Drawing.Size(481, 415);
            this.panelCallerID.TabIndex = 12;
            this.panelCallerID.Visible = false;
            // 
            // cmdCallerID_ClosePanel
            // 
            this.cmdCallerID_ClosePanel.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdCallerID_ClosePanel.Location = new System.Drawing.Point(369, 345);
            this.cmdCallerID_ClosePanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdCallerID_ClosePanel.Name = "cmdCallerID_ClosePanel";
            this.cmdCallerID_ClosePanel.Size = new System.Drawing.Size(93, 50);
            this.cmdCallerID_ClosePanel.TabIndex = 3;
            this.cmdCallerID_ClosePanel.Text = "Vazgec";
            this.cmdCallerID_ClosePanel.Click += new System.EventHandler(this.cmdCallerID_ClosePanel_Click);
            // 
            // cmdCallerID_AddOrder
            // 
            this.cmdCallerID_AddOrder.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdCallerID_AddOrder.Location = new System.Drawing.Point(8, 354);
            this.cmdCallerID_AddOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdCallerID_AddOrder.Name = "cmdCallerID_AddOrder";
            this.cmdCallerID_AddOrder.Size = new System.Drawing.Size(136, 50);
            this.cmdCallerID_AddOrder.TabIndex = 1;
            this.cmdCallerID_AddOrder.Text = "(+) Siparis";
            this.cmdCallerID_AddOrder.Click += new System.EventHandler(this.cmdCallerID_AddOrder_Click);
            // 
            // lstCallerIDList
            // 
            this.lstCallerIDList.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstCallerIDList.Appearance.Options.UseFont = true;
            this.lstCallerIDList.ItemHeight = 50;
            this.lstCallerIDList.Location = new System.Drawing.Point(14, 20);
            this.lstCallerIDList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstCallerIDList.Name = "lstCallerIDList";
            this.lstCallerIDList.Size = new System.Drawing.Size(448, 326);
            this.lstCallerIDList.TabIndex = 0;
            // 
            // tmrCallerIDCheck
            // 
            this.tmrCallerIDCheck.Interval = 2000;
            this.tmrCallerIDCheck.Tick += new System.EventHandler(this.tmrCallerIDCheck_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 583);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdCariDuzelt);
            this.panel2.Controls.Add(this.cmdYeniCari);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 520);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 63);
            this.panel2.TabIndex = 2;
            // 
            // cmdCariDuzelt
            // 
            this.cmdCariDuzelt.Location = new System.Drawing.Point(158, 14);
            this.cmdCariDuzelt.Name = "cmdCariDuzelt";
            this.cmdCariDuzelt.Size = new System.Drawing.Size(121, 37);
            this.cmdCariDuzelt.TabIndex = 15;
            this.cmdCariDuzelt.Text = "Cari Duzelt";
            this.cmdCariDuzelt.Click += new System.EventHandler(this.cmdCariDuzelt_Click);
            // 
            // cmdYeniCari
            // 
            this.cmdYeniCari.Location = new System.Drawing.Point(12, 14);
            this.cmdYeniCari.Name = "cmdYeniCari";
            this.cmdYeniCari.Size = new System.Drawing.Size(121, 37);
            this.cmdYeniCari.TabIndex = 14;
            this.cmdYeniCari.Text = "(+) Yeni Cari";
            this.cmdYeniCari.Click += new System.EventHandler(this.cmdYeniCari_Click);
            // 
            // txtCariAdresNo
            // 
            this.txtCariAdresNo.EnterMoveNextControl = true;
            this.txtCariAdresNo.Location = new System.Drawing.Point(378, 29);
            this.txtCariAdresNo.Name = "txtCariAdresNo";
            this.txtCariAdresNo.Properties.ReadOnly = true;
            this.txtCariAdresNo.Size = new System.Drawing.Size(36, 22);
            this.txtCariAdresNo.TabIndex = 14;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 611);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelCallerID);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MrTEK Mikro Siparis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grDetailView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grSiparisler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grSiparislerView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCariHesaplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnvan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neoTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCallerID)).EndInit();
            this.panelCallerID.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstCallerIDList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAdresNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programHakkindaToolStripMenuItem;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yardimToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem programHakkindaToolStripMenuItem1;
        private NeoDAC.NeoConnection dbConn;
        private NeoDAC.NeoTable tbCariHesaplar;
        private System.Data.SqlClient.SqlCommand sqlCommand4;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl grSiparisler;
        private System.Data.SqlClient.SqlCommand sqlCommand8;
        private System.Data.SqlClient.SqlCommand sqlCommand6;
        private System.Data.SqlClient.SqlCommand sqlCommand5;
        private System.Data.SqlClient.SqlCommand sqlCommand7;
        private DevExpress.XtraGrid.Views.Grid.GridView grSiparislerView;
        private System.Windows.Forms.Splitter splitter1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton cmdListele;
        private DevExpress.XtraEditors.TextEdit txtBakiye;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtUnvan;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCariKod;
        private DevExpress.XtraEditors.SimpleButton cmdExcelExport;
        private DevExpress.XtraEditors.SimpleButton cmdPrintGrid;
        private System.Windows.Forms.SaveFileDialog ExportDialog;
        private NeoDAC.NeoTable neoTable1;
        private System.Data.SqlClient.SqlCommand sqlCommand12;
        private System.Data.SqlClient.SqlCommand sqlCommand10;
        private System.Data.SqlClient.SqlCommand sqlCommand9;
        private System.Data.SqlClient.SqlCommand sqlCommand11;
        private DevExpress.XtraGrid.Columns.GridColumn colcari_kod;
        private DevExpress.XtraGrid.Columns.GridColumn colcari_unvan1;
        private DevExpress.XtraGrid.Columns.GridColumn colcari_unvan2;
        private userCntDateFilter userCntDateFilter1;
        private DevExpress.XtraGrid.Views.Grid.GridView grDetailView;
        private System.Windows.Forms.ToolStripMenuItem carileriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private DevExpress.XtraEditors.SimpleButton btnPrintForm;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_adres_no;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_ilce;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_il;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_tel_bolge_kodu;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_tel_no1;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_tel_no2;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_tel_faxno;
        private DevExpress.XtraGrid.Columns.GridColumn coladr_tel_modem;
        private NeoDAC.NeoCommand neoCommand1;
        internal DevExpress.XtraEditors.PanelControl panelCallerID;
        internal DevExpress.XtraEditors.SimpleButton cmdCallerID_ClosePanel;
        internal DevExpress.XtraEditors.SimpleButton cmdCallerID_AddOrder;
        internal DevExpress.XtraEditors.ListBoxControl lstCallerIDList;
        private DevExpress.XtraEditors.LabelControl lblCallerIDONOFF;
        private System.Data.DataColumn tbCariHesaplar_cari_kod;
        private System.Data.DataColumn tbCariHesaplar_cari_unvan1;
        private System.Data.DataColumn tbCariHesaplar_cari_unvan2;
        private System.Data.DataColumn tbCariHesaplar_adr_adres_no;
        private System.Data.DataColumn tbCariHesaplar_Adres;
        private System.Data.DataColumn tbCariHesaplar_adr_ilce;
        private System.Data.DataColumn tbCariHesaplar_adr_il;
        private System.Data.DataColumn tbCariHesaplar_adr_tel_bolge_kodu;
        private System.Data.DataColumn tbCariHesaplar_adr_tel_no1;
        private System.Data.DataColumn tbCariHesaplar_adr_tel_no2;
        private System.Data.DataColumn tbCariHesaplar_adr_tel_faxno;
        private System.Data.DataColumn tbCariHesaplar_adr_tel_modem;
        private DevExpress.XtraGrid.Columns.GridColumn colsip_RECno;
        private DevExpress.XtraGrid.Columns.GridColumn colSiparisNo;
        private DevExpress.XtraGrid.Columns.GridColumn colsip_evrakno_seri;
        private DevExpress.XtraGrid.Columns.GridColumn colsip_evrakno_sira;
        private DevExpress.XtraGrid.Columns.GridColumn colsip_tarih;
        private DevExpress.XtraGrid.Columns.GridColumn colsip_stok_kod;
        private DevExpress.XtraGrid.Columns.GridColumn colsto_isim;
        private DevExpress.XtraGrid.Columns.GridColumn colsip_miktar;
        private DevExpress.XtraGrid.Columns.GridColumn colsip_b_fiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colsip_tutar;
        private DevExpress.XtraGrid.Columns.GridColumn colNetTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colsip_teslim_miktar;
        private DevExpress.XtraGrid.Columns.GridColumn colKalan;
        private DevExpress.XtraEditors.SimpleButton cmdYeniSiparis;
        private System.Data.DataColumn neoTable1_sip_RECno;
        private System.Data.DataColumn neoTable1_SiparisNo;
        private System.Data.DataColumn neoTable1_sip_evrakno_seri;
        private System.Data.DataColumn neoTable1_sip_evrakno_sira;
        private System.Data.DataColumn neoTable1_sip_tarih;
        private System.Data.DataColumn neoTable1_sip_stok_kod;
        private System.Data.DataColumn neoTable1_sto_isim;
        private System.Data.DataColumn neoTable1_sip_miktar;
        private System.Data.DataColumn neoTable1_sip_b_fiyat;
        private System.Data.DataColumn neoTable1_sip_tutar;
        private System.Data.DataColumn neoTable1_NetTutar;
        private System.Data.DataColumn neoTable1_sip_teslim_miktar;
        private System.Data.DataColumn neoTable1_Kalan;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.Timer tmrCallerIDCheck;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton cmdCariDuzelt;
        private DevExpress.XtraEditors.SimpleButton cmdYeniCari;
        private DevExpress.XtraEditors.TextEdit txtCariAdresNo;
    }
}