using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrTEK_EFatura
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdDBOption_Click(object sender, EventArgs e)
        {
            try
            {
                

                frmDBOptions f = new frmDBOptions();
                f.ShowDialog();
                f.Dispose();
                if (DF.ActiveConn.StartConn() == false)
                {
                    MessageBox.Show("Sql Baglanti butonundan SQL baglanti ayarlarinizi yapin");
                }
               

              
            }
            catch (Exception ex)
            {
                UT.RaiseError(this.Name, "cmdDBOption_Click", ex);
            }

        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (DF.ActiveConn.dbConn.State != ConnectionState.Open)
                {
                    MessageBox.Show("Sql baglantisi yok! Kontrol ediniz!");
                    return;
                }
               
                DF.ActiveConn.dbConn = new SqlConnection(DF.ActiveConn.dbConnStr);
                DF.ActiveConn.dbConn.Open();
              
                
                if (DemoKontrol())
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Error : 56-57-73");
                    return;
                }

                if (!UP.versionControl()) return;

                loadInitialParameter();
               

            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "Login", ex);
            }
        }

        private void loadInitialParameter()
        {
            try
            {
                string sFileName = Application.ExecutablePath.Replace(".exe", ".ini").Replace(".EXE", ".ini");
                string sbuf = "";
                sbuf = UT.INIRead(sFileName, "INTEGRATOR", "Integrator", "");
                switch (sbuf)
                {
                    case "Uyumsoft":
                        DF.Integrator=IntegratorType.Uyumsoft;
                        break;
                    case "Finansbank":
                        DF.Integrator = IntegratorType.FinansBank;
                        break;
                    case "Innova":
                        DF.Integrator = IntegratorType.FinansBank;
                        break;
                }

                sbuf = UT.INIRead(sFileName, "SYNC", "SyncType", "0");
                string ticarisistem = UT.INIRead(sFileName, "SYNC", "TicariSistem", "");

              
                if (UT.IsNumeric(sbuf))
                {
                    switch (Convert.ToInt32(sbuf))
                    {
                        case 0: //stored procedure ticari
                            if (ticarisistem == "")
                            {
                                DF.Sync = SyncType.StoredProcedure_Ozel;
                            }
                            else if (ticarisistem == "LOGO")
                            {
                                DF.Sync = SyncType.StoredProcedure_Logo;
                            }
                            else if (ticarisistem == "MIKRO")
                            {
                                DF.Sync = SyncType.StoredProcedure_Mikro;
                            }
                            else if (ticarisistem == "ETA")
                            {
                                DF.Sync = SyncType.StoredProcedure_Eta;
                            }
                            break;

                        case 1:
                            DF.Sync = SyncType.CsvImport;
                            break;
                        case 2:
                            DF.Sync = SyncType.ExternalExe;
                            break;
                           
                    }
                   

                }

                DF.webServiceUrl = UT.INIRead(sFileName, "INTEGRATOR", "URL", "");
                DF.webServiceUserName = UT.INIRead(sFileName, "INTEGRATOR", "UserName", "");
                DF.webServicePassword = UT.INIRead(sFileName, "INTEGRATOR", "Password", "");
                DF.webServiceUserUrl = UT.INIRead(sFileName, "INTEGRATOR", "UserURL", "");
                DF.webServiceVKN = UT.INIRead(sFileName, "INTEGRATOR", "VKN", "");
                DF.EArsiveDefaultEmail = UT.INIRead(sFileName, "INTEGRATOR", "EArsivDefaultEmail", "");
                DF.Sync_ExternalExe = UT.INIRead(sFileName, "SYNC", "ExternalExe", "");

            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "", ex);
            }
        }
       
        private bool DemoKontrol()
        {
            try
            {
                return true;
                SqlCommand cmd = new SqlCommand();
                DateTime systime;
                DateTime demoson = new DateTime(2015, 3, 17);

                cmd.Connection = DF.ActiveConn.dbConn;
                cmd.CommandText = "SELECT GETDATE() ";
                systime = (DateTime)cmd.ExecuteScalar();
                if (systime > demoson)
                {
                    return false;
                }
                else
                {
                    int gun = (int)(demoson.ToOADate() - systime.ToOADate());
                    //MessageBox.Show("Demo sureniz " + gun.ToString() + " gun sonra bitecektir.");
                    return true;
                }
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "DemoKontrol", ex);
            }
            return false;
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                lblVer.Text = "Ver : " + UP.ProgramVersion;
                loadInitialParameter();

                //DF.ActiveConn.SystemType = UT.INIRead(sFileName, "SQLCONN", "SystemType", "");
                //if (DF.ActiveConn.SystemType.Trim() == "")
                //{
                //    MessageBox.Show("Sql Baglanti butonundan SQL baglanti ayarlarinizi yapin");
                //    return;
                //}
                //txtUserName.Text = Application.UserAppDataRegistry.GetValue("UserName", "a").ToString();
                if (DF.ActiveConn.StartConn() == false)
                {
                    MessageBox.Show("Sql Baglanti butonundan SQL baglanti ayarlarinizi kontrol ediniz.");
                }
                
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "frmLogin_Load", ex);
            }
        }

     
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Return)
                {
                    cmdLogin_Click(null, null);
                }
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "txtPassword_KeyDown", ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

      
    }
}
