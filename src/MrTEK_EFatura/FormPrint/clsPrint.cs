using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace MrTEK_EFatura
{
    public static class clsPrint
    {

        public static clsReportDesing GetReportLayout(int ReportID)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            System.Data.SqlClient.SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            clsReportDesing cReportDesing = new clsReportDesing();


            try
            {
                cmd.Connection = DF.ActiveConn.dbConn;
                cmd.CommandText = "SELECT * FROM PrintDesigns WHERE ReportID = " + ReportID.ToString() + " ";
                dt = new DataTable();
                da = new System.Data.SqlClient.SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    if (Convert.IsDBNull(dt.Rows[0]["ReportData"]))
                    {
                        cReportDesing.ReportData = new System.IO.MemoryStream();
                    }
                    else
                    {
                        byte[] b = null;
                        b = (byte[])dt.Rows[0]["ReportData"];
                        cReportDesing.ReportData = new System.IO.MemoryStream();
                        cReportDesing.ReportData.Write(b, 0, b.Length);
                        cReportDesing.ReportDataByteArray = b;

                    }
                    if (Convert.IsDBNull(dt.Rows[0]["ReportSQL"]))
                    {
                        cReportDesing.ReportSQL = "";
                    }
                    else
                    {
                        byte[] b = null;
                        b = (byte[])dt.Rows[0]["ReportSQL"];
                        System.Text.UTF8Encoding enc = new System.Text.UTF8Encoding();
                        cReportDesing.ReportSQL = enc.GetString(b);
                    }
                    cReportDesing.ReportName = UT.IfNull(dt.Rows[0]["ReportName"], "").ToString();
                    cReportDesing.FormCode = UT.IfNull(dt.Rows[0]["FormCode"], "").ToString();
                    cReportDesing.ReportType = (int)UT.If0Null(dt.Rows[0]["ReportType"]);
                }
                dt.Dispose();
                da.Dispose();
                cmd.Dispose();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            return cReportDesing;
        }
    }

    public class clsReportDesing
    {
        public System.IO.MemoryStream ReportData = new System.IO.MemoryStream();
        public string ReportSQL = "";
        public string ReportName = "";
        public string FormCode = "";
        public byte[] ReportDataByteArray;
        public long ReportType = 0;
    }

}
