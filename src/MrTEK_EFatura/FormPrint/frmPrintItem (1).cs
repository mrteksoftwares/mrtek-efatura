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
    public partial class frmPrintItem : Form
    {
        public string PrintScript = "";
        XtraReport1 xRep = new XtraReport1();
        public long ReportID;
        System.IO.MemoryStream ReportLayout = new System.IO.MemoryStream();
        public ArrayList Parameters =new ArrayList();
        public string FormCode = "";
        bool bShowSQLpanel = false;
        public object DataSource = null;
        bool bPrintFromDataSource = false;
        string ExternalFile = "";

        string RawFileName = "";

        public frmPrintItem()
        {
            InitializeComponent();
            LoadReportTypes();
        }

        public void FormNew(object DataSource_ = null)
        {
            xRep = new XtraReport1();

            ReportLayout = new System.IO.MemoryStream();
            DataSource = DataSource_;
            if ((DataSource != null))
            {
                bPrintFromDataSource = true;
                cmdSQL.Visible = false;
            }
            else
            {
                bPrintFromDataSource = false;
                LoadSQLPanel();
            }
            cboReportType.Properties.ReadOnly = false;


            this.ShowDialog();
        }

        public void FormEdit(object DataSource_ = null)
        {
            xRep = new XtraReport1();
            ReportLayout = new System.IO.MemoryStream();
            ExternalFile = "";
            DataSource = DataSource_;
            if ((DataSource != null))
            {
                bPrintFromDataSource = true;
                cmdSQL.Visible = false;
            }
            else
            {
                bPrintFromDataSource = false;
                LoadSQLPanel();

            }
            LoadForm();
            this.ShowDialog();
        }

        private void LoadForm()
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            System.Data.SqlClient.SqlDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                cmd.Connection = DF.ActiveConn.dbConn;
                cmd.CommandText = "SELECT * FROM PrintDesigns WHERE ReportID = '" + ReportID.ToString() + "'";
                dt = new DataTable();
                da = new System.Data.SqlClient.SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txtReportName.Text = UT.IfNull(dt.Rows[0]["ReportName"], "").ToString();
                    for (int i = 0; i <= cboReportType.Properties.Items.Count - 1; i++)
                    {
                        if ((int)((clsMember)cboReportType.Properties.Items[i]).valueMember == (int)UT.If0Null(dt.Rows[0]["ReportType"]))
                        {
                            cboReportType.SelectedIndex = i;
                            break; 
                        }
                    }
                    switch ((int)UT.If0Null(dt.Rows[0]["ReportType"]))
                    {
                        case 0:
                            if (Convert.IsDBNull(dt.Rows[0]["ReportData"]))
                            {
                                ReportLayout = new System.IO.MemoryStream();
                            }
                            else
                            {
                                byte[] b = null;
                                //Dim enc As New System.Text.UnicodeEncoding
                                b = (byte[])dt.Rows[0]["ReportData"];

                                ReportLayout = new System.IO.MemoryStream();
                                ReportLayout.Write(b, 0, b.Length);

                                if (ReportLayout.Length > 0)
                                {
                                    ((System.ComponentModel.ISupportInitialize)xRep).BeginInit();
                                    //xRep.SuspendLayout()

                                    xRep.LoadLayout(ReportLayout);
                                    ((System.ComponentModel.ISupportInitialize)xRep).EndInit();
                                }
                            }
                            break;
                        case 1:
                            //RAW PRINT
                            break;

                        case 2:
                            //EXTERNAL
                            byte[] b2;
                            System.Text.UTF8Encoding enc = new System.Text.UTF8Encoding();
                            b2 = (byte[])dt.Rows[0]["ReportData"];

                            if (Convert.IsDBNull(dt.Rows[0]["ReportData"]))
                            {
                                ExternalFile = "";
                            }
                            else
                            {
                                ExternalFile = enc.GetString(b2);
                            }

                            break;
                    }

                    FormCode = UT.IfNull(dt.Rows[0]["FormCode"], "").ToString();

                    if (Convert.IsDBNull(dt.Rows[0]["ReportSQL"]))
                    {
                        txtSQL.Text = PrintScript;
                    }
                    else
                    {
                        byte[] b = null;
                        System.Text.UTF8Encoding enc = new System.Text.UTF8Encoding();
                        b = (byte[])dt.Rows[0]["ReportSQL"];
                        txtSQL.Text = enc.GetString(b);
                    }
                }
                dt.Dispose();
                da.Dispose();


            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "LoadForm", ex);
            }


        }

        private void LoadSQLPanel()
        {
            try
            {
                txtParameters.Text = "";
                if ((Parameters != null))
                {
                    foreach (System.Data.SqlClient.SqlParameter pr in Parameters)
                    {
                        txtParameters.Text += pr.ParameterName + " = " + pr.Value.ToString() + Environment.NewLine;
                    }
                }
                txtSQL.Text = PrintScript;
            }
            catch (Exception ex)
            {
                UT.RaiseError(this.Name, "LoadSQLPanel", ex);
            }
        }

        private void LoadReportTypes()
        {
            try
            {
                cboReportType.Properties.Items.Clear();

                clsMember cMember = default(clsMember);
                cMember = new clsMember();
                cMember.displayMember = "FORM";
                cMember.valueMember = 0;
                cboReportType.Properties.Items.Add(cMember);

                cMember = new clsMember();
                cMember.displayMember = "RAW";
                cMember.valueMember = 1;
                cboReportType.Properties.Items.Add(cMember);
                cboReportType.SelectedIndex = 0;

                cMember = new clsMember();
                cMember.displayMember = "EXTERNAL";
                cMember.valueMember = 2;
                cboReportType.Properties.Items.Add(cMember);
                cboReportType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                UT.RaiseError(this.Name, "LoadReportTypes", ex);
            }

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            bool bFound = false;
            long ReportType = 0;
            //try
            //{
                cmd.Connection = DF.ActiveConn.dbConn;
                cmd.Parameters.Clear();
                txtReportName.Text = txtReportName.Text.Replace("'", " ");
                if (cboReportType.EditValue.GetType() == typeof(clsMember))
                {
                    ReportType = (int)((clsMember)cboReportType.EditValue).valueMember;
                }

                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ReportID", ReportID));

                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ReportName", txtReportName.Text));
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ReportData", SqlDbType.Image));
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@FormCode", FormCode));
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ReportType", ReportType));
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ReportSQL", SqlDbType.Image));
                cmd.Parameters["@ReportData"].Value = DBNull.Value;
                cmd.Parameters["@ReportSQL"].Value = DBNull.Value;

                cmd.CommandText = "SELECT COUNT(*) FROM PrintDesigns WHERE ReportID<>@ReportID AND FormCode=@FormCode AND ReportName=@ReportName ";

                if ((int)cmd.ExecuteScalar() > 0)
                {
                    bFound = true;
                }



                if (bFound)
                {
                    cmd.Dispose();
                    MessageBox.Show("Aynı raport isminden başka bir kayıt daha var. Lütfen rapor ismini değiştiriniz.");
                    return;
                }



                switch ((int)((clsMember)cboReportType.SelectedItem).valueMember)
                {
                    case 0:
                        ReportLayout = new System.IO.MemoryStream();
                        xRep.SaveLayout(ReportLayout);
                        cmd.Parameters["@ReportData"].Value = ReportLayout.ToArray();
                        break;
                    case 1:
                        //RAW Print
                        break;

                    case 2:
                        //External

                        byte[] b = null;
                        System.Text.UTF8Encoding enc1 = new System.Text.UTF8Encoding();
                        b = enc1.GetBytes(ExternalFile);
                        cmd.Parameters["@ReportData"].Value = b;

                        break;
                }



                System.Text.UTF8Encoding enc = new System.Text.UTF8Encoding();
                cmd.Parameters["@ReportSQL"].Value = enc.GetBytes(txtSQL.Text);
                if (ReportID == 0)
                {
                    cmd.CommandText = "INSERT INTO PrintDesigns (CreatedBy,CreatedDate,ModifiedBy ,ModifiedDate,FormCode,ReportName,ReportData,ReportSQL,ReportType) VALUES (" +  DF.ActiveConn.UserID + ",GETDATE()," + DF.ActiveConn.UserID + ",GETDATE(),@FormCode, @ReportName,@ReportData,@ReportSQL,@ReportType)";

                }
                else
                {
                    cmd.CommandText = "UPDATE PrintDesigns SET ModifiedBy = " + DF.ActiveConn.UserID + ",ReportName=@ReportName,ReportData=@ReportData,ReportSQL=@ReportSQL WHERE ReportID=@ReportID";
                }
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            //}
            //catch (Exception ex)
            //{
            //    UT.RaiseError(this.Name, "cmdSave_Click", ex);
            //}

        }

        private void cmdDesign_Click(object sender, EventArgs e)
        {
            try
            {
                //cboReportType.Properties.ReadOnly = true;

                switch ((int)((clsMember)cboReportType.SelectedItem).valueMember)
                {

                    case 1:

                        if (OpenFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;

                        RawFileName = OpenFileDialog1.FileName;
                        break;
                    case 2:
                        frmPrintExternalExe f = new frmPrintExternalExe();

                        f.externalFile = ExternalFile;

                        if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            ExternalFile = f.externalFile;
                        }
                        f.Dispose();
                        break;
                    default:
                        if (bPrintFromDataSource == false)
                        {
                            DesingFromScript();
                        }
                        else
                        {
                            DesingFromDataSource();
                        }
                        break;
                }
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "", ex);
            }
        }

        private void cmdSQL_Click(object sender, EventArgs e)
        {
            if (bShowSQLpanel)
            {
                bShowSQLpanel = false;
            }
            else
            {
                bShowSQLpanel = true;
            }

            ShowHideSQLPanel();
        }

        private void ShowHideSQLPanel()
        {

            try
            {
                if (bShowSQLpanel)
                {
                    if (UT.UCaseEng(DF.ActiveConn.UserName) != "ADMIN")
                    {
                        bShowSQLpanel = false;
                        return;
                    }
                    this.Height = 500;
                    panelSQL.Visible = true;
                }
                else
                {
                    this.Height = panelTop.Height + 30;
                    panelSQL.Visible = false;
                    //CenterMe();
                }
            }
            catch (Exception ex)
            {
                UT.RaiseError(this.Name, "ShowHideSQLPanel", ex);
            }
            

        }
        private void CenterMe()
        {
             this.Top = (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
             this.Left = (System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

        private void DesingFromDataSource()
        {

            try
            {


                xRep.DataSource = DataSource;

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
                            for (int i = 0; i <= xRep.Parameters.Count - 1; i++)
                            {
                                if (xRep.Parameters[i].Name == paramName)
                                {
                                    bFound = true;
                                    break; // TODO: might not be correct. Was : Exit For
                                }
                            }
                            if (bFound)
                            {
                                xRep.Parameters[paramName].Value = pr.Value;
                            }
                            else
                            {
                                xRep.Parameters.Add(item);
                            }

                        }
                    }
                }

                xRep.CreateDocument(true);


                xRep.showDesigner();
                

            }
            catch (Exception ex)
            {
                UT.RaiseError(this.Name, "DesingFromDataSource", ex);
            }
           
        }

        private void DesingFromScript()
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            System.Data.SqlClient.SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            bool bFound = false;

            try
            {
                cmd.Connection = DF.ActiveConn.dbConn;
                cmd.CommandText = txtSQL.Text;
                cmd.Parameters.Clear();
                if ((Parameters != null))
                {
                    foreach (System.Data.SqlClient.SqlParameter pr in Parameters)
                    {
                        if (pr.ParameterName.Trim()!="")
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
                if (cmd.CommandText.Trim()!="")
                {
                    da = new System.Data.SqlClient.SqlDataAdapter(cmd);
                    da.Fill(dt);
                    xRep.DataSource = dt;
                }
                xRep.CreateDocument();

                xRep.SaveLayout(UT.GetMyDir() + "\\lastdesing.rpx");

                xRep.showDesigner();
            }
            catch (Exception ex)
            {
                UT.RaiseError(this.Name, "DesingFromScript", ex);
            }
        }
    }
}
