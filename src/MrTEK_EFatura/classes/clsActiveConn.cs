using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace MrTEK_EFatura
{
    public class clsActiveConn
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Name { get { return "clsActiveConn"; } }
       

        private SqlConnection _dbConn = new SqlConnection();
        public SqlConnection dbConn
        {
            get { return _dbConn; }
            set { _dbConn = value; }
        }

        private string _dbConnStr;
        public string dbConnStr
        {
            get { return _dbConnStr; }
            set { _dbConnStr = value; }

        }

        private string mvar_SystemType;
        public string SystemType
        {
            get { return mvar_SystemType; }
            set { mvar_SystemType = value; }
        }
        public bool StartConn()
        {

            try
            {
                string sFileName = Application.ExecutablePath.Replace(".exe", ".ini").Replace(".EXE", ".ini");

               

                string server, database, sqluser, sqlpassword;
                bool ntauth;

                server = UT.INIRead(sFileName, "SQLCONN", "Server", "");
                if (server == "") return false;
                database = UT.INIRead(sFileName, "SQLCONN", "Database", "");
                string sbuf = UT.INIRead(sFileName, "SQLCONN", "NTAuth", "True");
                ntauth = sbuf == "True" ? true : false;
                sqluser = UT.INIRead(sFileName, "SQLCONN", "DBUserName", "sa");
                sqlpassword = UT.INIRead(sFileName, "SQLCONN", "DBPassword", "");
                if (server == "" || database == "") { return false; };
               
                _dbConnStr = UT.CreateConnectionString(server, database, ntauth, sqluser, sqlpassword);
                _dbConn = new SqlConnection(_dbConnStr);
                _dbConn.Open();
                if (_dbConn.State != ConnectionState.Open)
                {
                    return false;
                }

                


                return true;
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "", ex);
            }
            return false;
        }

        //private List<SqlConnection> _dbConnList=new List<SqlConnection>();
        //public List<SqlConnection> dbConnList
        //{
        //    get { return _dbConnList; }
        //    set { _dbConnList = value; }
        //}

    
        
    }
}
