using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MrTEK_EDefter
{
    public partial class frmMain : Form
    {
        object clr1;

        bool _useCallerID = false;
        private bool useCallerID
        {
            get { return _useCallerID; }
            set
            {
                _useCallerID = value;
                if (value)
                {
                    tmrCallerIDCheck.Enabled = true;
                }
                else
                {
                    tmrCallerIDCheck.Enabled = false;
                }
            }
        }
        public frmMain()
        {
            InitializeComponent();
        }



        private void programHakkindaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAbout f = new frmAbout();
            f.ShowDialog();
        }

        private void cikisToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                if (!InitializeConnection()) return;

                gridView1.RestoreLayoutFromRegistry("HKEY_CURRENT_USER\\Software\\MrTEK_EDefter\\frmMain\\" + gridView1.Name + gridView1.OptionsLayout.LayoutVersion, DevExpress.Utils.OptionsLayoutBase.FullLayout);
                grSiparislerView.RestoreLayoutFromRegistry("HKEY_CURRENT_USER\\Software\\MrTEK_EDefter\\frmMain\\" + grSiparislerView.Name + grSiparislerView.OptionsLayout.LayoutVersion, DevExpress.Utils.OptionsLayoutBase.FullLayout);


                userCntDateFilter1.chkTarih.Checked = true;
                carileriListeleToolStripMenuItem_Click(null, null);
                CallerIDActivate();
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "frmMain_Load", ex);
            }
        }

        private bool InitializeConnection()
        {
            try
            {
                dbConn.ConnectionString = DF.ActiveConn.dbConnStr;
                dbConn.Open();
               // dbConn.ChangeDatabase(DF.ActiveConn.dbConn.Database);


                if (dbConn.State == ConnectionState.Open)
                {
                    return true;

                }
                else
                {
                    return false;
                }
                //dbConn.ConnectionString = DF.ActiveConn.dbConnStr;
                //dbConn.Open();
                //if (dbConn.State != ConnectionState.Open) return false;
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "InitializeConnection", ex);
            }
            return false;
        }

        private void cmdListele_Click(object sender, EventArgs e)
        {
            grSiparisler.DataSource = Listele_SiparisHareket();

        }
        

        private DataTable Listele_SiparisHareket()
        {
            try
            {
                if (gridView1.FocusedRowHandle < 0) return new DataTable();
                DataRow drCari = gridView1.GetDataRow(gridView1.FocusedRowHandle);



                DateTime Tarih1 = new DateTime(1900, 1, 1);
                DateTime Tarih2 = new DateTime(DateTime.Today.Year, 12, 31);
                if (userCntDateFilter1.chkTarih.Checked)
                {
                    Tarih1 = userCntDateFilter1.Date1;
                    Tarih2 = userCntDateFilter1.Date2;
                }

                Tarih2 = Tarih2.AddHours(23);
                Tarih2 = Tarih2.AddMinutes(59);
                Tarih2 = Tarih2.AddSeconds(59);

                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da;
                DataTable dt;
                cmd.Connection = DF.ActiveConn.dbConn;
                cmd.Parameters.Clear();

                cmd.Parameters.Add(new SqlParameter("@CariKod", drCari["cari_kod"].ToString()));
                cmd.Parameters.Add(new SqlParameter("@Tarih1", Tarih1));
                cmd.Parameters.Add(new SqlParameter("@Tarih2", Tarih2));
                cmd.CommandText = "SELECT SIP.sip_RECno,SIP.sip_evrakno_seri + '-' + CAST(SIP.sip_evrakno_sira as VARCHAR(20)) as SiparisNo, SIP.sip_evrakno_seri,SIP.sip_evrakno_sira, " + Environment.NewLine;
                cmd.CommandText += " SIP.sip_tarih, SIP.sip_stok_kod " + Environment.NewLine;
                cmd.CommandText += " , STO.sto_isim ,SIP.sip_miktar, SIP.sip_b_fiyat , SIP.sip_tutar, dbo.fn_SiparisNetTutar ( sip_tutar, sip_iskonto_1, sip_iskonto_2, sip_iskonto_3, sip_iskonto_4, sip_iskonto_5, sip_iskonto_6, " + Environment.NewLine;
                cmd.CommandText += " sip_masraf_1, sip_masraf_2, sip_masraf_3, sip_masraf_4, sip_vergi, sip_masvergi, sip_Otv_Vergi, sip_otvtutari, sip_vergisiz_fl, " + Environment.NewLine;
                cmd.CommandText += " 2,sip_doviz_kuru,sip_alt_doviz_kuru) as NetTutar , SIP.sip_teslim_miktar " + Environment.NewLine;
                cmd.CommandText += " , SIP.sip_miktar - SIP.sip_teslim_miktar as Kalan " + Environment.NewLine;
                cmd.CommandText += " FROM SIPARISLER SIP INNER JOIN " + Environment.NewLine;
                cmd.CommandText += " STOKLAR STO ON SIP.sip_stok_kod = STO.sto_kod " + Environment.NewLine;
                cmd.CommandText += " WHERE (SIP.sip_tip=0) AND (SIP.sip_cins=0) AND SIP.sip_musteri_kod=@CariKod AND SIP.sip_tarih BETWEEN @Tarih1 AND @Tarih2 " + Environment.NewLine;
                cmd.CommandText += " ORDER BY SIP.sip_tarih , SIP.sip_evrakno_seri ,SIP.sip_evrakno_sira" + Environment.NewLine;



                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);



                return dt;


            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "Listele_Hareket", ex);
            }
            return new DataTable();
        }





        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                cmdListele_Click(null, null);
            }
            if (e.KeyCode == Keys.N && e.Control && e.Alt)
            {
                string sbuf = Microsoft.VisualBasic.Interaction.InputBox("Test telefon no giriniz", "Test CallerID", "");
                if (sbuf.Trim() == "") return;
                showCallerIDPanel(sbuf, "2", false);
            }
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {
            try
            {
                switch (xtraTabControl1.SelectedTabPageIndex)
                {
                    case 0:
                        grSiparislerView.ShowPrintPreview();
                        break;



                }
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "cmdPrint_Click", ex);
            }
        }

        private void cmdExcelExport_Click(object sender, EventArgs e)
        {
            try
            {
                ExportDialog.DefaultExt = "xls";
                ExportDialog.Filter = "Excel Files (*.xls)|*.xls|All Files (*.*)|*.*";


                switch (xtraTabControl1.SelectedTabPageIndex)
                {
                    case 0:
                        if (ExportDialog.ShowDialog() != DialogResult.OK) return;

                        if (System.IO.File.Exists(ExportDialog.FileName))
                        {
                            if (MessageBox.Show(ExportDialog.FileName + Environment.NewLine + "Dosya zaten var! Üzerine yazmak istiyor musunuz?", "Uzerine yaz?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes) return;

                        }
                        grSiparislerView.ExportToXls(ExportDialog.FileName);
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
                UT.RaiseError(this.Name, "cmdExcelExport_Click", ex);
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {

                gridView1.SaveLayoutToRegistry("HKEY_CURRENT_USER\\Software\\MrTEK_EDefter\\frmMain\\" + gridView1.Name + gridView1.OptionsLayout.LayoutVersion, DevExpress.Utils.OptionsLayoutBase.FullLayout);
                grSiparislerView.SaveLayoutToRegistry("HKEY_CURRENT_USER\\Software\\MrTEK_EDefter\\frmMain\\" + grSiparislerView.Name + grSiparislerView.OptionsLayout.LayoutVersion, DevExpress.Utils.OptionsLayoutBase.FullLayout);

            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "frmMain_FormClosed", ex);
            }
        }



        private void frmMain_Shown(object sender, EventArgs e)
        {
            try
            {

            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "frmMain_Shown", ex);
            }
        }



        private void btnPrintForm_Click(object sender, EventArgs e)
        {



            //try
            //{

            //    frmPrint f = new frmPrint();

            //    switch (xtraTabControl1.SelectedTabPageIndex)
            //    {
            //        case 0:
            //            f.DataSource = Listele_Hareket();
            //            f.FormCode = "CariHareket";
            //            break;
            //        case 1:
            //            f.FormCode = "AlisSatisHareket";
            //            DataTable Alislar = Listele_FaturaAlis();
            //            DataTable Satislar = Listele_FaturaSatis();
            //            foreach (DataRow dr in Satislar.Rows)
            //            {
            //                DataRow newdr = Alislar.NewRow();
            //                foreach (DataColumn dc in Alislar.Columns)
            //                {
            //                    if (Satislar.Columns.Contains(dc.ColumnName))
            //                    {
            //                        newdr[dc.ColumnName] = dr[dc.ColumnName];
            //                    }
            //                }
            //                Alislar.Rows.Add(newdr);
            //            }
            //            f.DataSource = Alislar;
            //            break;
            //    }

            //    f.ShowDialog();
            //}
            //catch (System.Exception ex)
            //{
            //    UT.RaiseError(this.Name, "cmdPrint_Click", ex);
            //}
        }

        private void showBakiye(string cariKod)
        {
            try
            {
                //qwerty
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "showBakiye", ex);
            }
        }


        private void CallerIDActivate()
        {
            try
            {
                string sFileName = Application.ExecutablePath.Replace(".exe", ".ini").Replace(".EXE", ".ini"); ;

                string sbuf = UT.INIRead(sFileName, "OTHER", "UseCallerID_Type1", "True");
                bool useCallerID_Type1 = false;
                useCallerID_Type1 = sbuf == "True" ? true : false;
                if (useCallerID_Type1 == false) return;

                useCallerID = true;
                clr1 = new Axcidv5callerid.AxCIDv5();
                this.Controls.Add((Axcidv5callerid.AxCIDv5)clr1);
                ((Axcidv5callerid.AxCIDv5)clr1).Location = new System.Drawing.Point(165, 303);
                ((Axcidv5callerid.AxCIDv5)clr1).Name = "AxCIDv51";
                ((Axcidv5callerid.AxCIDv5)clr1).Size = new System.Drawing.Size(26, 26);
                ((Axcidv5callerid.AxCIDv5)clr1).TabIndex = 2;
                ((Axcidv5callerid.AxCIDv5)clr1).OnCallerID += new Axcidv5callerid.ICIDv5Events_OnCallerIDEventHandler(this.AxCIDv51_OnCallerID);


                ((Axcidv5callerid.AxCIDv5)clr1).Hide();
                ((Axcidv5callerid.AxCIDv5)clr1).Start();


                //clr1 = new Axcidv5callerid.AxCIDv5();
                //this.Controls.Add(clr1);
                //clr1.Location = new System.Drawing.Point(165, 303);
                //clr1.Name = "AxCIDv51";
                //clr1.Size = new System.Drawing.Size(26, 26);
                //clr1.TabIndex = 2;
                //clr1.OnCallerID += new Axcidv5callerid.ICIDv5Events_OnCallerIDEventHandler(this.AxCIDv51_OnCallerID);
                //clr1.Hide();
                //clr1.Start();
                //axCIDv51.Start();
                tmrCallerIDCheck.Enabled = true;
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "CallerIDActivate", ex);
            }
        }

        private void AxCIDv51_OnCallerID(object sender, Axcidv5callerid.ICIDv5Events_OnCallerIDEvent e)
        {
            showCallerIDPanel(e.phoneNumber, e.line, false);

        }

        void showCallerIDPanel(string number, string line, bool bJustShow)
        {

            try
            {
                panelCallerID.Parent = this;
                panelCallerID.Left = this.Width - panelCallerID.Width - 20;
                panelCallerID.Top = 0;
                panelCallerID.BringToFront();
                panelCallerID.Visible = true;
                if (!bJustShow)
                {
                    clsCallerIDList cCallerIDList = new clsCallerIDList();
                    cCallerIDList.number = number;
                    cCallerIDList.line = line;
                    cCallerIDList.tarih = DateTime.Now;

                    cCallerIDList = FindCurrent_FromCallerID(cCallerIDList);
                    lstCallerIDList.Items.Insert(0, cCallerIDList);
                    lstCallerIDList.SelectedIndex = 0;

                    int i = 0;
                    while (i < lstCallerIDList.Items.Count - 1)
                    {
                        System.TimeSpan diffResult = DateTime.Now - ((clsCallerIDList)lstCallerIDList.Items[i]).tarih;
                        if (diffResult.TotalMinutes >= 1)
                        {
                            lstCallerIDList.Items.RemoveAt(i);
                        }
                        else
                        {
                            i++;
                        }
                    }


                }


            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "showCallerIDPanel", ex);
            }

        }

        clsCallerIDList FindCurrent_FromCallerID(clsCallerIDList c)
        {
            try
            {
                string telno=c.number;
                bool bRemoveZero=false;
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da;
                DataTable dt;
Basa:
                cmd.Connection = DF.ActiveConn.dbConn;
                cmd.CommandText="SELECT * FROM (SELECT C.cari_kod, C.cari_unvan1, C.cari_unvan2 , CA.adr_adres_no , " + Environment.NewLine  + 
                 " dbo.fnOnlyNumber(CA.adr_tel_ulke_kodu + ' ' +  CA.adr_tel_bolge_kodu + ' ' + CA.adr_tel_no1) as Tel1, dbo.fnOnlyNumber(CA.adr_tel_ulke_kodu + ' ' +  CA.adr_tel_bolge_kodu + ' ' + CA.adr_tel_no2) as Tel2, dbo.fnOnlyNumber(CA.adr_tel_ulke_kodu + ' ' +  CA.adr_tel_bolge_kodu + ' ' + CA.adr_tel_faxno) as FaxNo, dbo.fnOnlyNumber(CA.adr_tel_ulke_kodu + ' ' +  CA.adr_tel_bolge_kodu + ' ' + CA.adr_tel_modem) as Modem  FROM CARI_HESAPLAR C INNER JOIN " + Environment.NewLine +
                    " CARI_HESAP_ADRESLERI CA ON CA.adr_cari_kod = C.cari_kod ) X " + Environment.NewLine + 
                    " WHERE X.Tel1 + ' ' + X.Tel2 + ' ' + X.FaxNo + ' ' + X.Modem Like '%" + telno + "%' ";
                da=new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count>0){
                     c.cari_kod =UT.IfNull(dt.Rows[0]["cari_kod"],"").ToString();
                     c.cari_unvan1 =UT.IfNull(dt.Rows[0]["cari_unvan1"],"").ToString();
                    c.adresNo=(int)UT.If0Null(dt.Rows[0]["adr_adres_no"]);
                }else{
                    if(bRemoveZero==false){
                       if(telno.Substring(0,1)=="0"){
                           telno=telno.Substring(1,telno.Length-1);
                           bRemoveZero=true;
                           goto Basa;
                       }
                    }

                }
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "FindCurrent_FromCallerID", ex);
            }
            return c;
        }
        class clsCallerIDList
        {
            public string number = "";
            public string line = "";
            public DateTime tarih;
            public string cari_kod = "";
            public string cari_unvan1 = "";
            public int adresNo = 1;
            public override string ToString()
            {
                string sbuf = "";
                if (cari_unvan1.Trim() == "") sbuf = "**Yeni**"; else sbuf = cari_unvan1 + " /#adrNo:" + adresNo.ToString();

                return number + "/L:" + line + "    " + tarih.ToString("HH:mm:ss") + " M:" + sbuf;
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            //cmdListele_Click(null, null);
            cmdCariDuzelt_Click(null, null);
        }

        private void cmdCallerID_ClosePanel_Click(object sender, EventArgs e)
        {
            panelCallerID.Visible = false;
        }

        private void carileriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                UT.OpenTable(tbCariHesaplar);
                gridView1_FocusedRowChanged(null, null);
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "", ex);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtCariKod.Text = "";
                txtUnvan.Text = "";
                txtBakiye.Text = "";
                txtCariAdresNo.Text = "1";
                double bakiye = 0;
                if (gridView1.FocusedRowHandle < 0) return;
                DataRow drCari = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                txtCariKod.Text = drCari["cari_kod"].ToString();
                txtUnvan.Text = drCari["cari_unvan1"].ToString();
                txtCariAdresNo.Text = drCari["adr_adres_no"].ToString();
               
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DF.ActiveConn.dbConn;
                cmd.CommandText = "SELECT dbo.fn_CariHesapBakiye('',0,'" + txtCariKod.Text + "','','',0,0) ";
                bakiye = UT.If0Null( cmd.ExecuteScalar());
               txtBakiye.Text =String.Format("{0:#,##0.00}", bakiye);

            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "gridView1_FocusedRowChanged", ex);
            }
        }

        
        private void tmrCallerIDCheck_Tick(object sender, EventArgs e)
        {
            try
            {
                if (useCallerID)
                {
                    string sbuf = ((Axcidv5callerid.AxCIDv5)clr1).Command("devicemodel");
                    if (sbuf.Trim() == "")
                    {

                        lblCallerIDONOFF.Text = "CallerID : OFF";
                        lblCallerIDONOFF.ForeColor = Color.Gray;
                    }
                    else
                    {
                        lblCallerIDONOFF.Text = "CallerID : ON  Model:" + sbuf;
                        lblCallerIDONOFF.ForeColor = Color.Blue;

                    }
                }

            }
            catch (System.Exception ex)
            {
                lblCallerIDONOFF.Text = "CallerID : ERROR";
                lblCallerIDONOFF.ForeColor = Color.Gray;
                //tmrCallerIDCheck.Enabled = false;
                //UT.RaiseError(this.Name, "tmrCallerIDCheck_Tick", ex, false);
            }
        }

        private void cmdYeniSiparis_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCariKod.Text.Trim() == "") return;
                int AdresNo = 1;
                if (UT.IsNumeric(txtCariAdresNo.Text))
                {
                    AdresNo =Convert.ToInt32( txtCariAdresNo.Text);
                         
                }
                frmSiparis f = new frmSiparis();
                f.YeniSiparis(txtCariKod.Text, txtUnvan.Text, AdresNo);
                if (f.DialogResult == DialogResult.OK)
                {
                    cmdListele_Click(null, null);
                }
                f.Dispose();
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "cmdYeniSiparis_Click", ex);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            CallerIDActivate();
        }

        private void grSiparisler_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (grSiparislerView.FocusedRowHandle < 0) return;
                DataRow dr = grSiparislerView.GetDataRow(grSiparislerView.FocusedRowHandle);
                if (dr == null) return;
                frmSiparis f = new frmSiparis();
                f.EditSiparis(dr["sip_evrakno_seri"].ToString(), (int)UT.If0Null(dr["sip_evrakno_sira"]));
                if (f.DialogResult == DialogResult.OK)
                {
                    cmdListele_Click(null, null);
                }
                f.Dispose();
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "", ex);
            }
        }

        private void cmdCariDuzelt_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCariKod.Text == "") return;

                frmCariKart f = new frmCariKart();
                f.EditCariKart(txtCariKod.Text);
                if (f.DialogResult == DialogResult.OK)
                {
                    UT.OpenTable(tbCariHesaplar);
                }
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "cmdCariDuzelt_Click", ex);
            }
        }

        private void cmdYeniCari_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCariKod.Text == "") return;

                frmCariKart f = new frmCariKart();
                f.YeniCariKart("");
                if (f.DialogResult == DialogResult.OK)
                {
                    UT.OpenTable(tbCariHesaplar);
                }
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "cmdYeniCari_Click", ex);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            cmdListele_Click(null, null);
        }

        private void cmdCallerID_AddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstCallerIDList.SelectedIndex <0) return;
                clsCallerIDList c = (clsCallerIDList)lstCallerIDList.SelectedItem;
                if (c.cari_kod == "")
                {
                    if (MessageBox.Show("Yeni cari acmak istediginizden emin misiniz?", "Yeni cari", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
                    frmCariKart fcari = new frmCariKart();
                    fcari.YeniCariKart(c.number);
                    if (fcari.DialogResult != DialogResult.OK) return;
                    c.cari_kod = fcari.cari_kod;
                    c.cari_unvan1 = fcari.cari_unvan1;
                    c.adresNo = 1;
                    UT.OpenTable(tbCariHesaplar);
                }

                frmSiparis f = new frmSiparis();
                f.YeniSiparis(c.cari_kod, c.cari_unvan1, c.adresNo);
                if (f.DialogResult == DialogResult.OK)
                {
                    cmdListele_Click(null, null);
                }
                f.Dispose();
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "cmdCallerID_AddOrder_Click", ex);
            }
        }


    }


}
