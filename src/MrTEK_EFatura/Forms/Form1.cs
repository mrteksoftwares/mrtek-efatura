using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrTEK_EFatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DF.ActiveConn.dbConn.ChangeDatabase(txtDatabase.Text);
            txtCode.Text = "";
            //saveClass("Ledger");
            //saveClass("EntryHeader");
            //saveClass("EntryDetail");

            //saveClass("Invoice");
            //saveClass("Invoice_AllowanceCharge");
            //saveClass("Invoice_DespatchDocumentReference");
            //saveClass("Invoice_OrderReference");
            //saveClass("Invoice_PaymentMeans");
            //saveClass("Invoice_PaymentTerms");
            //saveClass("Invoice_ReceiptDocumentReference");
            //saveClass("Invoice_TaxSubtotal");
            //saveClass("Invoice_WithholdingTaxSubtotal");
            //saveClass("InvoiceLine");
            //saveClass("InvoiceLine_TaxSubtotal");
            //saveClass("InvoiceLine_WithholdingTaxSubtotal");
            //saveClass("Invoice_Note");
            //saveClass("Invoice_Log");
            //saveClass("InvoiceLine_Packages");
            


            saveClass("BankaHesapHareketleri");
            saveClass("Parameters");
            saveClass("Users");
            saveClass("SirketBankaHesaplari");
            saveClass("Sirket");
            MessageBox.Show("ok");
          
            //Uyumsoft.UnitCodeContentType.LN 
        }

        void saveClass(string tableName)
        {
            if (System.IO.Directory.Exists(UT.GetMyDir() + "\\classExport") == false)
            {
                System.IO.Directory.CreateDirectory(UT.GetMyDir() + "\\classExport");
            }
            string sbuf = makeClass(tableName);
            System.IO.StreamWriter sw = new System.IO.StreamWriter(UT.GetMyDir() + "\\classExport\\DB" + tableName + ".cs");
            sw.Write(sbuf);
            sw.Close();
        }
        string makeClass(string tableName)
        {
            string sCode = "";
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da;
            DataTable dt;
            cmd.Connection = DF.ActiveConn.dbConn;
            cmd.CommandText = "SELECT * FROM " + tableName;
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            sCode += "using System;" + Environment.NewLine;
            sCode += "using System.Data;" + Environment.NewLine;
            sCode += "using System.Data.SqlClient;" + Environment.NewLine;
            sCode += Environment.NewLine;
            sCode += "namespace MrTEK_EFatura" + Environment.NewLine;
            sCode += "{" + Environment.NewLine;
            sCode += "\tpublic partial class " + tableName + Environment.NewLine;
            sCode += "\t{" + Environment.NewLine;
            sCode += "\t\tpublic SqlTransaction trans;" + Environment.NewLine;
            sCode += Environment.NewLine;
            foreach (DataColumn dc in dt.Columns)
            {
                sCode += "\t\tpublic ";
                switch (dc.DataType.ToString())
                {
                    case "System.Int32":
                        sCode += "int " + dc.ColumnName + " = 0;";
                        break;
                    case "System.Double":
                        sCode += "double " + dc.ColumnName + " = 0;";
                        break;
                    case "System.DateTime":
                        sCode += "DateTime " + dc.ColumnName + " = new DateTime(1900,1,1);";
                        break;
                    case "System.String":
                        sCode += "string " + dc.ColumnName + " = \"\";";
                        break;

                    case "System.Boolean":
                        sCode += "bool " + dc.ColumnName + " = false;";
                        break;
                    default:
                        sCode += dc.DataType.ToString() + " " + dc.ColumnName + ";";
                        break;
                }

                //sCode += dc.ColumnName + " { get; set; }" + Environment.NewLine;
                sCode +=  Environment.NewLine;
            }
            sCode += Environment.NewLine;
            sCode += "\t\tpublic bool Load()" + Environment.NewLine;
            sCode += "\t\t{" + Environment.NewLine;
            sCode += "\t\t\tSqlCommand cmd = new SqlCommand();" + Environment.NewLine;
            sCode += "\t\t\tSqlDataAdapter da;" + Environment.NewLine;
            sCode += "\t\t\tDataTable dt;" + Environment.NewLine;
            sCode += "\t\t\tcmd.Connection = DF.ActiveConn.dbConn;" + Environment.NewLine;
            
            
            sCode += "\t\t\tcmd.CommandText = \"SELECT * FROM " + tableName + " WHERE " + dt.Columns[0].ColumnName + " = \" + this." + dt.Columns[0].ColumnName + ";" + Environment.NewLine;
            sCode += "\t\t\tda = new SqlDataAdapter(cmd);" + Environment.NewLine;
            sCode += "\t\t\tdt = new DataTable();" + Environment.NewLine;
            sCode += "\t\t\tda.Fill(dt);" + Environment.NewLine;
            sCode += "\t\t\tif(dt.Rows.Count>0)" + Environment.NewLine;
            sCode += "\t\t\t{" + Environment.NewLine;
            sCode += "\t\t\t\tDataRow dr = dt.Rows[0];" + Environment.NewLine;
            for(int i=1;i<dt.Columns.Count;i++){
                switch (dt.Columns[i].DataType.ToString())
                {
                    case "System.Int32":
                        sCode += "\t\t\t\tthis." + dt.Columns[i].ColumnName + " = (int)dr[\"" + dt.Columns[i].ColumnName + "\"];" + Environment.NewLine;
                        break;
                    case "System.Double":
                        sCode += "\t\t\t\tthis." + dt.Columns[i].ColumnName + " = (double)dr[\"" + dt.Columns[i].ColumnName + "\"];" + Environment.NewLine;
                        break;
                    case "System.DateTime":
                        sCode += "\t\t\t\tthis." + dt.Columns[i].ColumnName + " = (DateTime)dr[\"" + dt.Columns[i].ColumnName + "\"];" + Environment.NewLine;
                        break;
                    case "System.String":
                        sCode += "\t\t\t\tthis." + dt.Columns[i].ColumnName + " = dr[\"" + dt.Columns[i].ColumnName + "\"].ToString();" + Environment.NewLine;
                        break;
                    case "System.Boolean":
                        sCode += "\t\t\t\tthis." + dt.Columns[i].ColumnName + " = (bool)dr[\"" + dt.Columns[i].ColumnName + "\"];" + Environment.NewLine;
                        break;
                    default:
                        sCode += "\t\t\t\tthis." + dt.Columns[i].ColumnName + " = (" + dt.Columns[i].DataType.ToString() + ")dr[\"" + dt.Columns[i].ColumnName + "\"];" + Environment.NewLine;
                        break;
                }
             

            }

            sCode += "\t\t\t\treturn true;" + Environment.NewLine;
            sCode += "\t\t\t}else{" + Environment.NewLine;
            sCode += "\t\t\t\treturn false;" + Environment.NewLine;
            sCode += "\t\t\t}" + Environment.NewLine;

            sCode += "\t\t}" + Environment.NewLine;
            
            sCode += Environment.NewLine;
            sCode += "\t\tpublic bool Save()" + Environment.NewLine;
            sCode += "\t\t{" + Environment.NewLine;
            sCode += "\t\t\tSqlCommand cmd = new SqlCommand();" + Environment.NewLine;
            sCode += "\t\t\tSqlDataAdapter da;" + Environment.NewLine;
            sCode += "\t\t\tSystem.Data.DataTable dt;" + Environment.NewLine;
            sCode += "\t\t\tcmd.Connection = DF.ActiveConn.dbConn;" + Environment.NewLine;
            sCode += "\t\t\tif (this.trans != null) cmd.Transaction = trans;" + Environment.NewLine;
            sCode += "\t\t\tcmd.Parameters.Clear();" + Environment.NewLine;
            foreach(DataColumn dc in dt.Columns){
                if (dc.ColumnName == "CreatedDate" || dc.ColumnName == "CreatedBy" || dc.ColumnName == "ModifiedDate" || dc.ColumnName == "ModifiedBy")
                {

                }
                else
                {
                    if (dc.DataType.ToString() == "System.String")
                    {
                        int MaxLength = 0;
                        cmd.CommandText = "SELECT c.prec FROM syscolumns c INNER JOIN " +
                            " sysobjects t ON c.id=t.id " +
                            " WHERE t.name='" + tableName + "' AND c.name='" + dc.ColumnName + "'";
                        MaxLength = (int)UT.If0Null(cmd.ExecuteScalar());
                        sCode += "\t\t\tcmd.Parameters.Add(new SqlParameter(\"@" + dc.ColumnName + "\", this." + dc.ColumnName + ".Substring(0,this." + dc.ColumnName + ".Length>" + MaxLength.ToString() + "?" + MaxLength.ToString() + ":this." + dc.ColumnName + ".Length )));" + Environment.NewLine;
                        
                    }
                    else
                    {
                        sCode += "\t\t\tcmd.Parameters.Add(new SqlParameter(\"@" + dc.ColumnName + "\", this." + dc.ColumnName + "));" + Environment.NewLine;

                    }
                   
                }
                
            }
            sCode += Environment.NewLine;
            sCode += "\t\t\tif (" + dt.Columns[0].ColumnName + " == 0)" + Environment.NewLine;
            sCode += "\t\t\t{" + Environment.NewLine;
            sCode += "\t\t\t\tcmd.CommandText = \"INSERT INTO " + tableName + " ("; 
            for(int i=1;i<dt.Columns.Count;i++){
                //if (dt.Columns[i].ColumnName == "CreatedDate" || dt.Columns[i].ColumnName == "CreatedBy" || dt.Columns[i].ColumnName == "ModifiedDate" || dt.Columns[i].ColumnName == "ModifiedBy")
                //{

                //}
                //else
                //{
                    sCode += dt.Columns[i].ColumnName;
                    if (i < dt.Columns.Count - 1)
                    {
                        sCode += ", ";
                    }
                //}
            }
            sCode +=") \"; " + Environment.NewLine;
            sCode += "\t\t\t\tcmd.CommandText += \" VALUES ("; 
            for(int i=1;i<dt.Columns.Count;i++){
                if (dt.Columns[i].ColumnName == "CreatedDate" || dt.Columns[i].ColumnName == "CreatedBy" || dt.Columns[i].ColumnName == "ModifiedDate" || dt.Columns[i].ColumnName == "ModifiedBy")
                {
                    if (dt.Columns[i].ColumnName == "CreatedDate" || dt.Columns[i].ColumnName == "ModifiedDate")
                    {
                        sCode += "GETDATE()" ;
                    }
                    else
                    {
                        sCode += "\" + DF.ActiveConn.UserID + \""; 
                    }
                }
                else
                {
                    sCode += "@" + dt.Columns[i].ColumnName;
                }
                if(i<dt.Columns.Count-1){
                    sCode +=", ";
                }
            }
            sCode +=")\"; " + Environment.NewLine;
            sCode += "\t\t\t\tcmd.CommandText += \" SELECT SCOPE_IDENTITY()\"; " + Environment.NewLine;
            sCode += "\t\t\t\tthis." + dt.Columns[0].ColumnName + " = (int)UT.If0Null(cmd.ExecuteScalar());" + Environment.NewLine;
            sCode += "\t\t\t\tif(this." + dt.Columns[0].ColumnName + ">0)" + Environment.NewLine;
             sCode += "\t\t\t\t{" + Environment.NewLine;
            sCode += "\t\t\t\t\treturn true;" + Environment.NewLine;
            sCode += "\t\t\t\t}" + Environment.NewLine;
            sCode += "\t\t\t\telse" + Environment.NewLine;
             sCode += "\t\t\t\t{" + Environment.NewLine;
            sCode += "\t\t\t\t\treturn false;" + Environment.NewLine;
            sCode += "\t\t\t\t}" + Environment.NewLine;
            sCode += "\t\t\t}" + Environment.NewLine;
            sCode += "\t\t\telse" + Environment.NewLine;
            sCode += "\t\t\t{" + Environment.NewLine;
            sCode += "\t\t\t\tcmd.CommandText = \"UPDATE " + tableName + " SET ";
            for(int i=1;i<dt.Columns.Count;i++){
                if (dt.Columns[i].ColumnName == "CreatedDate" || dt.Columns[i].ColumnName == "CreatedBy" || dt.Columns[i].ColumnName == "ModifiedDate" || dt.Columns[i].ColumnName == "ModifiedBy")
                {
                    if (dt.Columns[i].ColumnName == "ModifiedDate")
                    {
                        sCode += dt.Columns[i].ColumnName + "=GETDATE()";
                        if (i < dt.Columns.Count - 1)
                        {
                            sCode += ", ";
                        }
                    }
                    else if (dt.Columns[i].ColumnName == "ModifiedBy")
                    {
                        sCode += dt.Columns[i].ColumnName + "=\" + DF.ActiveConn.UserID + \"";
                        if (i < dt.Columns.Count - 1)
                        {
                            sCode += ", ";
                        }
                    }
                }
                else
                {
                    sCode += dt.Columns[i].ColumnName + "=@" + dt.Columns[i].ColumnName;
                    if (i < dt.Columns.Count - 1)
                    {
                        sCode += ", ";
                    }
                }
               
            }
            sCode += " \";" + Environment.NewLine;
            sCode += "\t\t\t\tcmd.CommandText += \"WHERE " + dt.Columns[0].ColumnName + " = \" + this." + dt.Columns[0].ColumnName + ";" + Environment.NewLine;
            sCode += "\t\t\t\tif(cmd.ExecuteNonQuery()>0)" + Environment.NewLine;
            sCode += "\t\t\t\t{" + Environment.NewLine;
            sCode += "\t\t\t\t\treturn true;" + Environment.NewLine;
            sCode += "\t\t\t\t}" + Environment.NewLine;
            sCode += "\t\t\t\telse" + Environment.NewLine;
            sCode += "\t\t\t\t{" + Environment.NewLine;
            sCode += "\t\t\t\t\treturn false;" + Environment.NewLine;
            sCode += "\t\t\t\t}" + Environment.NewLine;

            sCode += "\t\t\t}" + Environment.NewLine;
            sCode += "\t\t}" + Environment.NewLine;
            sCode += "\t}" + Environment.NewLine;
            sCode += "}" + Environment.NewLine;
            sCode += Environment.NewLine;
            sCode += Environment.NewLine;
            return sCode;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            basa:
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            if (System.IO.File.Exists(saveFileDialog1.FileName))
            {
                DialogResult ret=MessageBox.Show("Dosya var! Uzerine yazilsin mi?","Uzerine yaz?",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
                if (ret == DialogResult.No) goto basa;
                if (ret == DialogResult.Cancel) return;
                System.IO.File.Delete(saveFileDialog1.FileName);
            }
            System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog1.FileName);
            sw.Write(txtCode.Text);
            sw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = "";
            string b = "";
            b = a.Substring(0,a.Length>50?50:a.Length);
            MessageBox.Show(b);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDatabase.Text = DF.ActiveConn.dbConn.Database;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Application.DoEvents();
                string csvFileName= UT.GetMyDir() + "\\efat_export.csv";
                string sbuf = "EFaturaMemberID;VKN;FirmTitle;PostboxAlias;SenderboxAlias;SystemCreateDate;FirmCode;bDefault;";
                SqlCommand cmd = new SqlCommand();
                
                cmd.Connection = DF.ActiveConn.dbConn;
                cmd.CommandText = @"SELECT EFaturaMemberID, VKN, FirmTitle, PostboxAlias, SenderboxAlias, SystemCreateDate, FirmCode, bDefault FROM EFaturaMembers ORDER BY EFaturaMemberID";
                DataTable dt=new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                progressBar1.Maximum = dt.Rows.Count;
                progressBar1.Value = 0;
                foreach(DataRow row in dt.Rows)
                {
                    string sline = "";
                    foreach(DataColumn col in dt.Columns)
                    {
                        sline += row[col.ColumnName].ToString() + ";";
                    }
                    sline += Environment.NewLine;
                    sbuf += sline;
                    progressBar1.Value++;
                    Application.DoEvents();
                }
                System.IO.StreamWriter sw = new System.IO.StreamWriter(csvFileName); //,(new System.Text.UTF8Encoding()));
                sw.Write(sbuf);
                sw.Close();
                MessageBox.Show("Bitti");
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "export", ex);
            }
        }
        public void importInvoice(string csvFileName)
        {
            try
            {
                Application.DoEvents();
               
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "importInvoice", ex);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 10)
            {
                string resp = EFatura.checkEFaturaMember_Uyumsoft(textBox1.Text);
                txtCode.Text += resp + Environment.NewLine;
            }
            else
            {
                txtCode.Text += "Hatali vknTckn" + Environment.NewLine;
            }
        }
    }
}
