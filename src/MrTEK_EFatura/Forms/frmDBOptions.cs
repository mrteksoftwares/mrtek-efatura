using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.SqlClient;

namespace MrTEK_EFatura
{
    public partial class frmDBOptions : Form
    {
        public frmDBOptions()
        {
            InitializeComponent();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {

                string sbuf = "";
                UT.INIWrite(DF.INIFileName, "SQLCONN", "Server", txtServer.Text);
                UT.INIWrite(DF.INIFileName, "SQLCONN", "Database", txtDatabase.Text);
                UT.INIWrite(DF.INIFileName, "SQLCONN", "NTAuth", chkNTAuth.Checked.ToString());
                UT.INIWrite(DF.INIFileName, "SQLCONN", "DBUserName", txtSqlUser.Text);
                UT.INIWrite(DF.INIFileName, "SQLCONN", "DBPassword", txtSqlPassword.Text);




                UT.INIWrite(DF.INIFileName, "INTEGRATOR", "Integrator", rgEntegrator.Properties.Items[rgEntegrator.SelectedIndex].Value.ToString());
                UT.INIWrite(DF.INIFileName, "INTEGRATOR", "UserName", txtWebService_UserName.Text);
                UT.INIWrite(DF.INIFileName, "INTEGRATOR", "Password", txtWebService_Password.Text);
                UT.INIWrite(DF.INIFileName, "INTEGRATOR", "URL", txtWebService_URL.Text);
                UT.INIWrite(DF.INIFileName, "INTEGRATOR", "UserURL", txtWebServiceUser_URL.Text);
                UT.INIWrite(DF.INIFileName, "INTEGRATOR", "VKN", txtWebServiceVKN.Text);
                UT.INIWrite(DF.INIFileName, "INTEGRATOR", "EArsivDefaultEmail", txtEArsivDefaultEmail.Text);

                UT.INIWrite(DF.INIFileName, "SYNC", "SyncType", rgSyncType.SelectedIndex.ToString());
                UT.INIWrite(DF.INIFileName, "SYNC", "ExternalExe", txtExternalExePath.Text);
                UT.INIWrite(DF.INIFileName, "SYNC", "TicariSistem", rgTicariSistem.Properties.Items[rgTicariSistem.SelectedIndex].Value.ToString());
                UT.INIWrite(DF.INIFileName, "SYNC", "spOzel_PARAM1", txtSync_spOzel_Param1.Text);
                UT.INIWrite(DF.INIFileName, "SYNC", "spOzel_PARAM2", txtSync_spOzel_Param2.Text);
                UT.INIWrite(DF.INIFileName, "SYNC", "spOzel_PARAM3", txtSync_spOzel_Param3.Text);
                UT.INIWrite(DF.INIFileName, "SYNC", "spOzel_PARAM4", txtSync_spOzel_Param4.Text);
                UT.INIWrite(DF.INIFileName, "SYNC", "spOzel_PARAM5", txtSync_spOzel_Param5.Text);
                UT.INIWrite(DF.INIFileName, "SYNC", "spLogo_MASTERDB", txtSync_spLogo_MasterDB.Text);
                UT.INIWrite(DF.INIFileName, "SYNC", "spLogo_LOGODB", txtSync_spLogo_LogoDB.Text);
                UT.INIWrite(DF.INIFileName, "SYNC", "spLogo_FIRMNO", txtSync_spLogo_FirmNo.Text);
                UT.INIWrite(DF.INIFileName, "SYNC", "spLogo_PERIOD", txtSync_spLogo_Period.Text);
                UT.INIWrite(DF.INIFileName, "SYNC", "spLogo_DEPONO", txtSync_spLogo_DepoNo.Text);
                UT.INIWrite(DF.INIFileName, "SYNC", "spMikro_MASTERDB", txtSync_spMikro_MasterDB.Text);
                UT.INIWrite(DF.INIFileName, "SYNC", "spMikro_FIRMANO", txtSync_spMikro_FirmaNo.Text);
                UT.INIWrite(DF.INIFileName, "SYNC", "spMikro_SUBENO", txtSync_spMikro_SubeNo.Text);
                UT.INIWrite(DF.INIFileName, "SYNC", "spMikro_DEPONO", txtSync_spMikro_DepoNo.Text);
                UT.INIWrite(DF.INIFileName, "SYNC", "spEta_MASTERDB", txtSync_spEta_MasterDB.Text);
                UT.INIWrite(DF.INIFileName, "SYNC", "spEta_DEPKOD", txtSync_spEta_DEPKOD.Text);
                UT.INIWrite(DF.INIFileName, "SYNC", "spEta_FATFTNO", txtSync_spEta_FATFTNO.Text);


                UT.INIWrite(DF.INIFileName, "EFATURA", "Xslt0", txtXSLT0.Text);
                UT.INIWrite(DF.INIFileName, "EFATURA", "Xslt1", txtXSLT1.Text);
                UT.INIWrite(DF.INIFileName, "EFATURA", "Xslt2", txtXSLT2.Text);
                UT.INIWrite(DF.INIFileName, "EFATURA", "Xslt3", txtXSLT3.Text);
                UT.INIWrite(DF.INIFileName, "EFATURA", "Xslt4", txtXSLT4.Text);

                UT.INIWrite(DF.INIFileName, "IMPORT", "ImportInvoicePath", txtImportInvoicePath.Text);

                UT.INIWrite(DF.INIFileName, "INVOICE", "ProfileID", cboInvoiceProfileID.Text);

                
                DialogResult = DialogResult.OK;

            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "cmdSave_Click", ex);
            }
        }

        private void cmdSqlTest_Click(object sender, EventArgs e)
        {
            try
            {
                dbconnTest(txtDatabase.Text);
                //foreach (string line in txtDatabase.Text.Split(Environment.NewLine.ToCharArray()))
                //{
                //    string dbName = line.Trim();
                //    if (dbName != "")
                //    {
                //        dbconnTest()
                //        MessageBox.Show("Test:" + dbName);
                //    }

                //}
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "cmdSqlTest_Click", ex);
            }
        }

        private void dbconnTest(string databaseName)
        {
            try
            {
                string connstr = UT.CreateConnectionString(txtServer.Text, databaseName, chkNTAuth.Checked, txtSqlUser.Text, txtSqlPassword.Text);


                SqlConnection conn = new SqlConnection(connstr);

                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    MessageBox.Show("Baglanti basarili :-)");
                }
                else
                {
                    MessageBox.Show("baglanti basarisiz!");
                }
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "dbconnTest", ex);
            }
        }



        public bool AddDatabase(System.Data.SqlClient.SqlConnection conn, string DatabaseName)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    return false;
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                System.Data.SqlClient.SqlDataAdapter da = null;
                DataTable dt = null;
                bool bBulundu = false;

                string sFilePath1 = "";
                string sFilePath = "";

                cmd.Connection = conn;
                cmd.CommandText = "SELECT COUNT(*) FROM sysdatabases WHERE name like '" + DatabaseName + "'";

                if ((int)cmd.ExecuteScalar() > 0)
                {
                    bBulundu = true;
                }

                if (bBulundu)
                {
                    MessageBox.Show("Bu veri tabani zaten var!");
                    return false;
                }

                if (bBulundu == false)
                {
                    cmd.CommandText = "select top 1 filename from sysfiles";
                    da = new System.Data.SqlClient.SqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);
                    sFilePath1 = "";
                    if (dt.Rows.Count > 0)
                    {
                        sFilePath1 = UT.IfNull(dt.Rows[0]["filename"], "").ToString();

                    }

                    sFilePath = System.IO.Path.GetDirectoryName(sFilePath1);
                    sFilePath = Interaction.InputBox("Veri tabanin duracagi klasor", "DB Folder", sFilePath);
                    if (string.IsNullOrEmpty(Strings.Trim(sFilePath)))
                    {
                        MessageBox.Show("Klasor hatali. Veri tabani olusturma basarisiz!");
                        return false;
                    }
                    //If IO.Directory.Exists(sFilePath) = False Then
                    //    MsgBox("Klasor bulunamadi!")
                    //    GoTo Basa
                    //End If
                    cmd.CommandText = "CREATE DATABASE [" + DatabaseName + "]  ON (NAME = N'" + DatabaseName + "_Data', FILENAME = N'" + sFilePath + "\\" + DatabaseName + ".MDF' , SIZE = 10, FILEGROWTH = 10%) LOG ON (NAME = N'" + DatabaseName + "_Log', FILENAME = N'" + sFilePath + "\\" + DatabaseName + "_Log.LDF' , SIZE = 1, FILEGROWTH = 10%) COLLATE Turkish_CI_AS" + Constants.vbNewLine;
                    //cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'autoclose', N'false'" & vbNewLine
                    //cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'bulkcopy', N'false'" & vbNewLine
                    //cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'trunc. log', N'false'" & vbNewLine
                    //cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'torn page detection', N'true'" & vbNewLine
                    //cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'read only', N'false'" & vbNewLine
                    //cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'dbo use', N'false'" & vbNewLine
                    //cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'single', N'false'" & vbNewLine
                    //cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'autoshrink', N'true'" & vbNewLine
                    //cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'ANSI null default', N'false'" & vbNewLine
                    //cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'recursive triggers', N'false'" & vbNewLine
                    //cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'ANSI nulls', N'false'" & vbNewLine
                    //cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'concat null yields null', N'false'" & vbNewLine
                    //cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'cursor close on commit', N'false'" & vbNewLine
                    //cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'default to local cursor', N'false'" & vbNewLine
                    //cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'quoted identifier', N'false'" & vbNewLine
                    //cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'ANSI warnings', N'false'" & vbNewLine
                    //cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'auto create statistics', N'true'" & vbNewLine
                    //cmd.CommandText &= "exec sp_dboption N'" & DatabaseName & "', N'auto update statistics', N'true'" & vbNewLine


                    cmd.ExecuteNonQuery();

                    cmd.Connection.ChangeDatabase(DatabaseName);
                    if (UT.RunVersionScriptFile(cmd.Connection, "dbcreate_script.sql") == false)
                    {
                        MessageBox.Show("Veri tabanı script hatası oluştu. Sistem yöneticiniz ile görüşünüz.");
                        return false;
                    }


                }

                cmd.Dispose();
                return true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        private void cmdCreateDB_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
            try
            {
                string connstr = UT.CreateConnectionString(txtServer.Text, "master", chkNTAuth.Checked, txtSqlUser.Text, txtSqlPassword.Text);

                conn.ConnectionString = connstr;
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                    cmd.Connection = conn;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@dbname", txtDatabase.Text.Trim()));

                    cmd.CommandText = "SELECT COUNT(*) FROM sysdatabases where name =@dbname ";
                    if ((int)cmd.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Bu veritabani ismi zaten kullaniliyor. Lutfen baska bir isim giriniz!");
                        return;
                    }

                    if (AddDatabase(conn, txtDatabase.Text.Trim()))
                    {
                        MessageBox.Show("Veri tabani olusturuldu.");

                    }
                    else
                    {
                    }

                    return;
                }
            }
            catch (Exception ex)
            {
                UT.RaiseError(this.Name, "cmdCreateDB_Click", ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void chkNTAuth_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNTAuth.Checked)
            {
                txtSqlUser.ReadOnly = true;
                txtSqlPassword.ReadOnly = true;
            }
            else
            {
                txtSqlUser.ReadOnly = false;
                txtSqlPassword.ReadOnly = false;
            }
        }

        private void frmDBOptions_Load(object sender, EventArgs e)
        {
            try
            {
                
                txtServer.Text = UT.INIRead(DF.INIFileName, "SQLCONN", "Server", "(local)");
                txtDatabase.Text = UT.INIRead(DF.INIFileName, "SQLCONN", "Database", "");
                string sbuf = UT.INIRead(DF.INIFileName, "SQLCONN", "NTAuth", "True");
                chkNTAuth.Checked = sbuf == "True" ? true : false;
                txtSqlUser.Text = UT.INIRead(DF.INIFileName, "SQLCONN", "DBUserName", "sa");
                txtSqlPassword.Text = UT.INIRead(DF.INIFileName, "SQLCONN", "DBPassword", "");

                sbuf = UT.INIRead(DF.INIFileName, "SYNC", "SyncType", "0");
                rgSyncType.SelectedIndex = 0;
                if (UT.IsNumeric(sbuf))
                {
                    try
                    {
                        rgSyncType.SelectedIndex = Convert.ToInt32(sbuf);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

                switch (UT.INIRead(DF.INIFileName, "SYNC", "TicariSistem", ""))
                {
                    case "":
                        rgTicariSistem.SelectedIndex = 0;
                        break;
                    case "LOGO":
                        rgTicariSistem.SelectedIndex = 1;
                        break;
                    case "MIKRO":
                        rgTicariSistem.SelectedIndex = 2;
                        break;
                    case "ETA":
                        rgTicariSistem.SelectedIndex = 3;
                        break;
                    default:
                        rgTicariSistem.SelectedIndex = 0;
                        break;
                }

                txtExternalExePath.Text = UT.INIRead(DF.INIFileName, "SYNC", "ExternalExe", "");
                rgEntegrator.SelectedIndex = 0;
                sbuf = UT.INIRead(DF.INIFileName, "INTEGRATOR", "Integrator", "");
                switch (sbuf)
                {
                    case "Uyumsoft":
                        rgEntegrator.SelectedIndex = 0;
                        break;
                    case "Finansbank":
                        rgEntegrator.SelectedIndex = 1;
                        break;
                    case "Innova":
                        rgEntegrator.SelectedIndex = 2;
                        break;
                }

                txtWebService_UserName.Text = UT.INIRead(DF.INIFileName, "INTEGRATOR", "UserName", "");
                txtWebService_Password.Text = UT.INIRead(DF.INIFileName, "INTEGRATOR", "Password", "");
                txtWebService_URL.Text = UT.INIRead(DF.INIFileName, "INTEGRATOR", "URL", "");
                txtWebServiceUser_URL.Text = UT.INIRead(DF.INIFileName, "INTEGRATOR", "UserURL", "");
                txtWebServiceVKN.Text = UT.INIRead(DF.INIFileName, "INTEGRATOR", "VKN", "");
                txtEArsivDefaultEmail.Text = UT.INIRead(DF.INIFileName, "INTEGRATOR", "EArsivDefaultEmail", "");

                txtSync_spOzel_Param1.Text = UT.INIRead(DF.INIFileName, "SYNC", "spOzel_PARAM1", "");
                txtSync_spOzel_Param2.Text = UT.INIRead(DF.INIFileName, "SYNC", "spOzel_PARAM2", "");
                txtSync_spOzel_Param3.Text = UT.INIRead(DF.INIFileName, "SYNC", "spOzel_PARAM3", "");
                txtSync_spOzel_Param4.Text = UT.INIRead(DF.INIFileName, "SYNC", "spOzel_PARAM4", "");
                txtSync_spOzel_Param5.Text = UT.INIRead(DF.INIFileName, "SYNC", "spOzel_PARAM5", "");
                txtSync_spLogo_MasterDB.Text = UT.INIRead(DF.INIFileName, "SYNC", "spLogo_MASTERDB", "LOGODB");
                txtSync_spLogo_LogoDB.Text = UT.INIRead(DF.INIFileName, "SYNC", "spLogo_LOGODB", "LOGODB");
                txtSync_spLogo_FirmNo.Text = UT.INIRead(DF.INIFileName, "SYNC", "spLogo_FIRMNO", "001");
                txtSync_spLogo_Period.Text = UT.INIRead(DF.INIFileName, "SYNC", "spLogo_PERIOD", "01");
                txtSync_spLogo_DepoNo.Text = UT.INIRead(DF.INIFileName, "SYNC", "spLogo_DEPONO", "1");
                txtSync_spMikro_MasterDB.Text = UT.INIRead(DF.INIFileName, "SYNC", "spMikro_MASTERDB", "MikroDB_V15");
                txtSync_spMikro_FirmaNo.Text = UT.INIRead(DF.INIFileName, "SYNC", "spMikro_FIRMANO", "0");
                txtSync_spMikro_SubeNo.Text = UT.INIRead(DF.INIFileName, "SYNC", "spMikro_SUBENO", "0");
                txtSync_spMikro_DepoNo.Text = UT.INIRead(DF.INIFileName, "SYNC", "spMikro_DEPONO", "1");
                txtSync_spEta_MasterDB.Text = UT.INIRead(DF.INIFileName, "SYNC", "spEta_MASTERDB", "ETA_MASTERV8");
                txtSync_spEta_DEPKOD.Text = UT.INIRead(DF.INIFileName, "SYNC", "spEta_DEPKOD", "D-01");
                txtSync_spEta_FATFTNO.Text = UT.INIRead(DF.INIFileName, "SYNC", "spEta_FATFTNO", "3,4,5,6");

                txtXSLT0.Text = UT.INIRead(DF.INIFileName, "EFATURA", "Xslt0", "");
                txtXSLT1.Text = UT.INIRead(DF.INIFileName, "EFATURA", "Xslt1", "");
                txtXSLT2.Text = UT.INIRead(DF.INIFileName, "EFATURA", "Xslt2", "");
                txtXSLT3.Text = UT.INIRead(DF.INIFileName, "EFATURA", "Xslt3", "");
                txtXSLT4.Text = UT.INIRead(DF.INIFileName, "EFATURA", "Xslt4", "");

                txtImportInvoicePath.Text = UT.INIRead(DF.INIFileName, "IMPORT", "ImportInvoicePath", "");
                cboInvoiceProfileID.Text = UT.INIRead(DF.INIFileName, "INVOICE", "ProfileID", "");

              


                //sbuf = UT.INIRead(DF.INIFileName, "OTHER", "Param_EntryNumberZero", "False");
                //chkParam_EntryNumberZero.Checked = sbuf == "True" ? true : false;

            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "frmDBOptions_Load", ex);
            }
        }

        private void rgSyncType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtExternalExePath.Visible = false;
            lblExternalExePath.Visible = false;
            gbTicariSistem.Visible = false;
            switch (rgSyncType.SelectedIndex)
            {
                case 0:
                    gbTicariSistem.Visible = true;
                    break;
                case 2:
                    txtExternalExePath.Visible = true;
                    lblExternalExePath.Visible = true;
                    break;
            }

        }

        private void btnCreateDB_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
            try
            {
                string connstr = UT.CreateConnectionString(txtServer.Text, "master", chkNTAuth.Checked, txtSqlUser.Text, txtSqlPassword.Text);

                conn.ConnectionString = connstr;
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                    cmd.Connection = conn;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@dbname", txtDatabase.Text.Trim()));

                    cmd.CommandText = "SELECT COUNT(*) FROM sysdatabases where name =@dbname ";
                    if ((int)cmd.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Bu veritabani ismi zaten kullaniliyor. Lutfen baska bir isim giriniz!");
                        return;
                    }

                    if (AddDatabase(conn, txtDatabase.Text.Trim()))
                    {
                        MessageBox.Show("Veri tabani olusturuldu.");

                    }
                    else
                    {
                    }

                    return;
                }
            }
            catch (Exception ex)
            {
                UT.RaiseError(this.Name, "cmdCreateDB_Click", ex);
            }
        }

        private void btnCreateSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Senkron stored procedure yeniden yaratilacaktir. Onayliyor musunuz?", "Yeniden Stored Procedure Yarat?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop) != DialogResult.Yes) return;

                string SqlScript = "";
                string connstr = UT.CreateConnectionString(txtServer.Text, txtDatabase.Text, chkNTAuth.Checked, txtSqlUser.Text, txtSqlPassword.Text);


                SqlConnection conn = new SqlConnection(connstr);

                conn.Open();
                if (conn.State != ConnectionState.Open)
                {
                    MessageBox.Show("baglanti basarisiz!");
                    return;
                }
                switch (rgTicariSistem.SelectedIndex)
                {
                    case 0:
                        SqlScript = get_OzelSpScript();
                        break;
                    case 1:
                        SqlScript = get_LogoSpScript();
                        break;
                    case 2:
                        SqlScript = get_MikroSpScript();
                        break;
                    case 3:
                        SqlScript = get_EtaSpScript();
                        break;
                    default:
                        break;
                }
                if (UT.RunVersionScript(conn, SqlScript) == false)
                {
                    MessageBox.Show("Veri tabanı script hatası oluştu. Sistem yöneticiniz ile görüşünüz.");
                    return;
                }
                else
                {
                    MessageBox.Show("Esitleme stored procedure basari ile yeniden olusturuldu.");
                }

            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "btnCreateSP_Click", ex);
            }
        }

        string get_OzelSpScript()
        {
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(UT.GetMyDir() + "\\dbScripts\\dbcreateScript_StoredProcedure_Ozel.sql");
                string sbuf = sr.ReadToEnd();
                sr.Close();

                //--- replace lere geciyoruz...
                sbuf = sbuf.Replace("#PARAM1#", txtSync_spOzel_Param1.Text);
                sbuf = sbuf.Replace("#PARAM2#", txtSync_spOzel_Param2.Text);
                sbuf = sbuf.Replace("#PARAM3#", txtSync_spOzel_Param3.Text);
                sbuf = sbuf.Replace("#PARAM4#", txtSync_spOzel_Param4.Text);
                sbuf = sbuf.Replace("#PARAM5#", txtSync_spOzel_Param5.Text);

                return sbuf;

            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "get_OzelSpScript", ex);
            }
            return "";
        }

        string get_LogoSpScript()
        {
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(UT.GetMyDir() + "\\dbScripts\\dbcreateScript_StoredProcedure_Logo.sql");
                string sbuf = sr.ReadToEnd();
                sr.Close();

                //--- replace lere geciyoruz...
                sbuf = sbuf.Replace("#MASTERDB#", txtSync_spLogo_MasterDB.Text);
                sbuf = sbuf.Replace("#LOGODB#", txtSync_spLogo_LogoDB.Text);
                sbuf = sbuf.Replace("#FIRMNO#", txtSync_spLogo_FirmNo.Text);
                sbuf = sbuf.Replace("#PERIOD#", txtSync_spLogo_Period.Text);
                sbuf = sbuf.Replace("#DEPONO#", txtSync_spLogo_DepoNo.Text);

                return sbuf;

            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "get_LogoSpScript", ex);
            }
            return "";
        }
        string get_MikroSpScript()
        {
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(UT.GetMyDir() + "\\dbScripts\\dbcreateScript_StoredProcedure_Mikro.sql");
                string sbuf = sr.ReadToEnd();
                sr.Close();

                //--- replace lere geciyoruz...
                sbuf = sbuf.Replace("#MASTERDB#", txtSync_spMikro_MasterDB.Text);
                sbuf = sbuf.Replace("#FIRMANO#", txtSync_spMikro_FirmaNo.Text);
                sbuf = sbuf.Replace("#SUBENO#", txtSync_spMikro_SubeNo.Text);
                sbuf = sbuf.Replace("#DEPONO#", txtSync_spMikro_DepoNo.Text);

                return sbuf;

            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "get_MikroSpScript", ex);
            }
            return "";
        }

        string get_EtaSpScript()
        {
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(UT.GetMyDir() + "\\dbScripts\\dbcreateScript_StoredProcedure_Mikro.sql");
                string sbuf = sr.ReadToEnd();
                sr.Close();

                //--- replace lere geciyoruz...
                sbuf = sbuf.Replace("#MASTERDB#", txtSync_spEta_MasterDB.Text);
                sbuf = sbuf.Replace("#FATFTNO#", txtSync_spEta_FATFTNO.Text);
                sbuf = sbuf.Replace("#DEPKOD#", txtSync_spEta_DEPKOD.Text);

                return sbuf;

            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "get_EtaSpScript", ex);
            }
            return "";
        }

        private void rgEntegrator_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rgEntegrator.SelectedIndex == 1)
            {
                lblWebServiceUser_URL.Visible = true;
                txtWebServiceUser_URL.Visible = true;
                lblWebServiceVKN_URL.Visible = true;
                txtWebServiceVKN.Visible = true;
            }
            else
            {
                lblWebServiceUser_URL.Visible = false;
                txtWebServiceUser_URL.Visible = false;
                lblWebServiceVKN_URL.Visible = false;
                txtWebServiceVKN.Visible = false;

            }
        }

    }
}
