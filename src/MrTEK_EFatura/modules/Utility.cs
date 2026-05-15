using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Collections;
using System.IO;
using System.Net;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Data.SqlClient;

namespace MrTEK_EFatura
{
    public static class UT
    {

        public static bool OpenTable(NeoDAC.NeoTable bufTable1)
        {
            if (bufTable1 == null)
                return false;
            if (bufTable1.Active)
            {
                bufTable1.Close();
            }

            bufTable1.Open();
            return true;
        }

        public static System.Data.SqlClient.SqlConnection ConnectSQL_ConnStr(string ConnectionString, bool bShowError = true)
        {
            System.Data.SqlClient.SqlConnection functionReturnValue = null;


            functionReturnValue = new System.Data.SqlClient.SqlConnection();

            functionReturnValue.ConnectionString = ConnectionString;

            functionReturnValue.Open();
            return functionReturnValue;

        }

        public static string CreateConnectionString(string Server, string Database, bool NTAuth, string DBUserName, string DBPassword, bool SQLNative = false, string ApplicationName = "MrTEK_EFatura")
        {
            if (NTAuth)
            {
                return "Server=" + Server + ";Database=" + Database + ";Trusted_Connection=Yes;Application Name=" + ApplicationName + ";";
            }
            else
            {
                return "Server=" + Server + ";Database=" + Database + ";User ID=" + DBUserName + ";Password=" + DBPassword + ";Trusted_Connection=False;Application Name=" + ApplicationName + ";";
            }
        }

        public static System.Data.SqlClient.SqlConnection ConnectSQL(string IniFileName = "Database.ini", string IniSection = "SQLCONN", string ApplicationName = "MrTEK_EFatura")
        {
            System.Data.SqlClient.SqlConnection functionReturnValue = null;


            functionReturnValue = new System.Data.SqlClient.SqlConnection();
            string sFileName = null;

            //Dim crp As New Crypto("MessageBox")
            string sbuf = null;
            string Server = null;
            string Database = null;
            bool NTAuth = false;
            string DBUserName = null;
            string DBPassword = "";
            bool SQLNative = false;
            if (IniFileName.IndexOf('\\') > 0)
            {
                sFileName = IniFileName;
            }
            else
            {
                sFileName = GetMyDir() + '\\' + IniFileName;
            }

            Server = INIRead(sFileName, IniSection, "Server", "(local)");
            Database = INIRead(sFileName, IniSection, "Database", "");
            sbuf = INIRead(sFileName, IniSection, "NTAuth", "False");
            NTAuth = Convert.ToBoolean(sbuf);
            sbuf = INIRead(sFileName, IniSection, "SQLNative", "False");
            SQLNative = Convert.ToBoolean(sbuf);
            DBUserName = INIRead(sFileName, IniSection, "DBUserName", "sa");
            DBPassword = INIRead(sFileName, IniSection, "DBPassword", "");

            if (string.IsNullOrEmpty(Server) | string.IsNullOrEmpty(Database))
            {
                return new System.Data.SqlClient.SqlConnection();
            }
            return ConnectSQL_ConnStr(CreateConnectionString(Server, Database, NTAuth, DBUserName, DBPassword, SQLNative, ApplicationName), false);


        }

        //public static string pConnectionString(string IniFileName = "Database.ini", string IniSection = "SQLCONN", string ApplicationName = "PiconnCevahir", string sDatabase = "")
        //{
        //    string functionReturnValue = null;

        //    string sFileName = null;

        //    string sbuf = null;
        //    string Server = null;
        //    string Database = null;
        //    bool NTAuth = false;
        //    string DBUserName = null;
        //    string DBPassword = "";
        //    bool SQLNative = false;
        //    if (IniFileName.IndexOf('\\')>0)
        //    {
        //        sFileName = IniFileName;
        //    }
        //    else
        //    {
        //        sFileName = GetMyDir() + "\\" + IniFileName;
        //    }

        //    Server = INIRead(sFileName, IniSection, "Server", "(local)");
        //    if (string.IsNullOrEmpty(sDatabase))
        //    {
        //        Database = INIRead(sFileName, IniSection, "Database", "");
        //    }
        //    else
        //    {
        //        Database = sDatabase;
        //    }
        //    sbuf = INIRead(sFileName, IniSection, "NTAuth", "False");
        //    NTAuth = Convert.ToBoolean(sbuf);
        //    sbuf = INIRead(sFileName, IniSection, "SQLNative", "False");
        //    SQLNative = Convert.ToBoolean(sbuf);
        //    DBUserName = INIRead(sFileName, IniSection, "DBUserName", "sa");
        //    sbuf = INIRead(sFileName, IniSection, "DBPassword", "");
        //    if (!string.IsNullOrEmpty(sbuf.Trim()))
        //    {
        //        DBPassword = sbuf;
        //        // crp.Decrypt(sbuf)
        //    }

        //    if (string.IsNullOrEmpty(Server) | string.IsNullOrEmpty(Database))
        //    {
        //        return "";
        //    }
        //    return CreateConnectionString(Server, Database, NTAuth, DBUserName, DBPassword, SQLNative, ApplicationName);


        //}

        public static bool RunVersionScriptFile(System.Data.SqlClient.SqlConnection conn, string ScriptFileName)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            string SQL = "";
            string subSQL = "";
            int i = 0;
            System.IO.StreamReader sr = null;
            string FileName = GetMyDir() + "\\dbscripts\\" + ScriptFileName;

            try
            {
                if (System.IO.File.Exists(FileName) == false)
                {
                    Interaction.MsgBox(FileName + " bulunamadı.");
                    return false;
                }
                sr = new System.IO.StreamReader(FileName);
                SQL = sr.ReadToEnd();
                sr.Close();
                sr.Dispose();
                if (string.IsNullOrEmpty(Strings.Trim(SQL)))
                {
                    Interaction.MsgBox(FileName + " script boş.");
                    return false;
                }
                i = 0;
                SQL += Constants.vbNewLine + Constants.vbNewLine;
                cmd.Connection = conn;
                try
                {
                    subSQL = Strings.Split(SQL, "GO" + Constants.vbNewLine)[i];
                }
                catch (Exception ex)
                {
                    subSQL = "";
                }
                if (string.IsNullOrEmpty(subSQL))
                    subSQL = SQL;

                while (!string.IsNullOrEmpty(subSQL))
                {
                    cmd.CommandText = subSQL;
                    cmd.ExecuteNonQuery();
                    i += 1;
                    try
                    {
                        subSQL = Strings.Split(SQL, "GO" + Constants.vbNewLine)[i];
                    }
                    catch (Exception ex)
                    {
                        subSQL = "";
                    }
                }


                cmd.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("(RunVersionScriptFile) FileName:" + ScriptFileName + Constants.vbNewLine + ex.Message);
                return false;
            }

        }

        public static bool RunVersionScript(System.Data.SqlClient.SqlConnection conn, string SQL)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            string subSQL = "";
            int i = 0;
           
            try
            {
                
                if (string.IsNullOrEmpty(Strings.Trim(SQL)))
                {
                    MessageBox.Show("SQL Script boş!");
                    return false;
                }
                i = 0;
                SQL += Constants.vbNewLine + Constants.vbNewLine;
                cmd.Connection = conn;
                try
                {
                    subSQL = Strings.Split(SQL, "GO" + Constants.vbNewLine)[i];
                }
                catch (Exception ex)
                {
                    subSQL = "";
                }
                if (string.IsNullOrEmpty(subSQL))
                    subSQL = SQL;

                while (!string.IsNullOrEmpty(subSQL))
                {
                    cmd.CommandText = subSQL;
                    cmd.ExecuteNonQuery();
                    i += 1;
                    try
                    {
                        subSQL = Strings.Split(SQL, "GO" + Constants.vbNewLine)[i];
                    }
                    catch (Exception ex)
                    {
                        subSQL = "";
                    }
                }


                cmd.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("(RunVersionScript) " + Constants.vbNewLine + ex.Message);
                return false;
            }

        }



        public static string VersionStrCorrect(string Ver)
        {
            string sbuf = "";
            string ch = "";
            int i = 0;
            if (string.IsNullOrEmpty(Strings.Trim(Ver)))
                return "";
            if (Strings.Mid(Ver, Strings.Len(Ver), 1) != ".")
                Ver += ".";
            i = 0;
            while (!string.IsNullOrEmpty(Strings.Split(Ver, ".")[i]))
            {
                ch = Strings.Split(Ver, ".")[i];
                if (Information.IsNumeric(ch))
                {
                    sbuf += Strings.Format(Convert.ToInt32(ch), "0000") + ".";
                }
                else
                {
                    sbuf += ch + ".";
                }
                i += 1;
            }
            if (!string.IsNullOrEmpty(Strings.Trim(sbuf)))
            {
                if (Strings.Mid(sbuf, Strings.Len(sbuf), 1) == ".")
                {
                    sbuf = Strings.Mid(sbuf, 1, Strings.Len(sbuf) - 1);
                }
            }
            return sbuf;

        }

        public static string VersionStrCorrect2Digit(string Ver)
        {
            string sbuf = "";
            string ch = "";
            int i = 0;
            if (string.IsNullOrEmpty(Strings.Trim(Ver)))
                return "";
            if (Strings.Mid(Ver, Strings.Len(Ver), 1) != ".")
                Ver += ".";
            i = 0;
            while (!string.IsNullOrEmpty(Strings.Split(Ver, ".")[i]))
            {
                ch = Strings.Split(Ver, ".")[i];
                if (Information.IsNumeric(ch))
                {
                    sbuf += Strings.Format(Convert.ToInt32(ch), "00") + ".";
                }
                else
                {
                    sbuf += ch + ".";
                }
                i += 1;
            }
            if (!string.IsNullOrEmpty(Strings.Trim(sbuf)))
            {
                if (Strings.Mid(sbuf, Strings.Len(sbuf), 1) == ".")
                {
                    sbuf = Strings.Mid(sbuf, 1, Strings.Len(sbuf) - 1);
                }
            }
            return sbuf;

        }

        [DllImport("kernel32", EntryPoint = "WritePrivateProfileStringW", CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]
        #region "API Calls"
        // standard API declarations for INI access
        // changing only "As Long" to "As Int32" (As Integer would work also)
        private static extern Int32 WritePrivateProfileString(string lpApplicationName, string lpKeyName, string lpString, string lpFileName);
        [DllImport("kernel32", EntryPoint = "GetPrivateProfileStringW", CharSet = CharSet.Unicode, SetLastError = true, ExactSpelling = true)]

        private static extern Int32 GetPrivateProfileString(string lpApplicationName, string lpKeyName, string lpDefault, string lpReturnedString, Int32 nSize, string lpFileName);
        #endregion

        public static string Space(int n)
        {
            string s = "";
            for (int i = 0; i < n; i++)
            {
                s += " ";
            }
            return s;
        }
        public static string INIRead(string INIPath, string SectionName, string KeyName, string DefaultValue = "")
        {
            string functionReturnValue = null;
            // primary version of call gets single value given all parameters
            Int32 n = default(Int32);
            string sData = null;
            sData = Space(1024);
            // allocate some room 
            n = GetPrivateProfileString(SectionName, KeyName, DefaultValue, sData, sData.Length, INIPath);
            // return whatever it gave us
            if (n > 0)
            {
                functionReturnValue = sData.Substring(0, n);
            }
            else
            {
                functionReturnValue = "";
            }
            return functionReturnValue;
        }


        public static void INIWrite(string INIPath, string SectionName, string KeyName, string TheValue)
        {
            WritePrivateProfileString(SectionName, KeyName, TheValue, INIPath);
        }

        // delete single line from section
        public static void INIDelete(string INIPath, string SectionName, string KeyName)
        {
            WritePrivateProfileString(SectionName, KeyName, null, INIPath);
        }

        public static void INIDelete(string INIPath, string SectionName)
        {
            // delete section from INI file
            WritePrivateProfileString(SectionName, null, null, INIPath);
        }

        public static void RaiseError(string ModuleName, string FunctionName, Exception ex, bool bShowError = true)
        {
            
            string FileName;
            System.IO.StreamWriter sw;
            if (!System.IO.Directory.Exists(GetMyDir() + "\\Log"))
            {
                System.IO.Directory.CreateDirectory(GetMyDir() + "\\Log");
            }
            FileName = GetMyDir() + "\\Log\\Err_" + DateTime.Today.ToString("yyyyMMdd") + ".log";
            sw = System.IO.File.AppendText(FileName);
            sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " User:" + (DF.ActiveConn != null ? DF.ActiveConn.UserName : "") + " Module:" + ModuleName + "    Function:" + FunctionName);
            sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " Err:" + ex.Message);

            sw.WriteLine("");
            sw.Close();
            sw.Dispose();
            if (bShowError)
            {
                MessageBox.Show("İşlem sırasında hata oluştu!" + Environment.NewLine + "Modül : " + ModuleName + Environment.NewLine + "Fonksiyon : " + FunctionName + Environment.NewLine + "Hata : " + ex.Message, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static object IfNull(object Value, object Response)
        {

            if (Value == null)
            {
                return Response;
            }
            else
            {
                if (Convert.IsDBNull(Value))
                {
                    return Response;
                }
                else
                {
                    return Value;
                }
            }

        }

        public static double If0Null(object Value)
        {

            if (Value == null)
            {
                return 0;
            }
            else
            {
                if (Convert.IsDBNull(Value))
                {
                    return 0;
                }
                else
                {
                    return Convert.ToDouble(Value);
                }
            }

        }

        public static Guid IfNullGuid(object Value)
        {
            if ((Value != null))
            {
                if (!Information.IsDBNull(Value))
                {
                    try
                    {
                        if (Value is System.Guid)
                        {
                            return (System.Guid)Value;
                        }
                        else
                        {
                            return new Guid(Value.ToString());
                        }


                    }
                    catch (Exception ex)
                    {
                        return Guid.Empty;
                    }

                }

            }
            return Guid.Empty;
        }

        public static string CommaToPoint(double Value)
        {

            return Convert.ToString(Value).Replace(",", ".");
        }

        public static string CommaToPointStr(string Value)
        {
            string sbuf = null;
            sbuf = Value;
            if (DecimalPointer() == ",")
            {
                sbuf = sbuf.Replace(".", "");
                sbuf = sbuf.Replace(",", ".");
            }
            else if (DecimalPointer() == ".")
            {
                sbuf = sbuf.Replace(",", "");
            }
            return sbuf;
        }

        public static string DecimalPointer()
        {
            string functionReturnValue = null;
            double a = 0;
            string bufStr = null;
            a = 1.1;
            bufStr = Convert.ToString(a);
            functionReturnValue = "";
            if (bufStr.IndexOf(",") > 0)
            {
                functionReturnValue = ",";
            }
            if (bufStr.IndexOf(".") > 0)
            {
                functionReturnValue = ".";
            }
            return functionReturnValue;
        }

        public static bool IsNumeric(this string s)
        {
            float output;
            return float.TryParse(s, out output);
        }

        public static string OnlyNumber(string text)
        {

            string sBuf = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (IsNumeric(text.Substring(i, 1)) | text.Substring(i, 1) == "." | text.Substring(i, 1) == ",")
                {
                    sBuf = sBuf + text.Substring(i, 1);
                }
            }
            return sBuf;
        }

        public static string sStartDate(System.DateTime Tarih)
        {
            return "CONVERT(DATETIME, '" + Tarih.Year + "-" + Tarih.Month + "-" + Tarih.Day + " 00:00:00', 102)";
        }

        public static string sEndDate(System.DateTime Tarih)
        {
            return "CONVERT(DATETIME, '" + Tarih.Year + "-" + Tarih.Month + "-" + Tarih.Day + " 23:59:59', 102)";
        }

        public static string SQLDateTime(System.DateTime Tarih)
        {
            if (Tarih.Year == 1)
            {
                return "CONVERT(DATETIME, '1899-12-30 00:00:00', 102)";
            }
            else
            {
                return "CONVERT(DATETIME, '" + Tarih.Year + "-" + Tarih.Month + "-" + Tarih.Day + " " + Tarih.Hour + ":" + Tarih.Minute + ":" + Tarih.Second + "', 102)";
            }

        }

        public static string IncBelgeNo(string startValue)
        {
            string sNum="";
            string numberFormat="";
            int num=0;
            
            for(int i=startValue.Length-1;i>=0;i--){
                if(!(startValue[i]>='0' && startValue[i] <='9')){

                   break;
                }else{
                    sNum =startValue[i] + sNum;
                }
            }
            if(sNum.Length>0){
                for(int i=0;i<sNum.Length;i++)numberFormat +="0";
                num=Convert.ToInt32(sNum);
                num++;
                string result="";
                if(sNum.Length<startValue.Length){
                    result=startValue.Substring(0,startValue.Length-sNum.Length);
                }
                result = result + num.ToString(numberFormat);
                return result;
            }else{
                return  startValue + "1";
            }

        }

        private static string IncBelgeNoSonraki(string harf, bool turkce, bool ingilizce)
        {
            string functionReturnValue = null;

            switch (harf)
            {
                case "Ç":
                    functionReturnValue = "D";
                    break;
                case "ç":
                    functionReturnValue = "d";
                    break;
                case "ı":
                    functionReturnValue = "i";
                    break;
                case "İ":
                    functionReturnValue = "J";
                    break;
                case "ğ":
                    functionReturnValue = "h";
                    break;
                case "Ğ":
                    functionReturnValue = "H";
                    break;
                case "ü":
                    functionReturnValue = "v";
                    break;
                case "Ü":
                    functionReturnValue = "V";
                    break;
                case "ş":
                    functionReturnValue = "t";
                    break;
                case "Ş":
                    functionReturnValue = "T";
                    break;
                case "ö":
                    functionReturnValue = "p";
                    break;
                case "Ö":
                    functionReturnValue = "P";
                    break;
                case "p":
                    if (ingilizce == true)
                    {
                        functionReturnValue = "q";
                    }
                    else
                    {
                        functionReturnValue = "r";
                    }
                    break;
                case "P":
                    if (ingilizce == true)
                    {
                        functionReturnValue = "Q";
                    }
                    else
                    {
                        functionReturnValue = "R";
                    }
                    break;
                case "v":
                    if (ingilizce == true)
                    {
                        functionReturnValue = "w";
                    }
                    else
                    {
                        functionReturnValue = "y";
                    }
                    break;
                case "V":
                    if (ingilizce == true)
                    {
                        functionReturnValue = "W";
                    }
                    else
                    {
                        functionReturnValue = "Y";
                    }
                    break;
                case "w":
                    if (ingilizce == true)
                    {
                        functionReturnValue = "x";
                    }
                    else
                    {
                        functionReturnValue = "y";
                    }
                    break;
                case "W":
                    if (ingilizce == true)
                    {
                        functionReturnValue = "X";
                    }
                    else
                    {
                        functionReturnValue = "Y";
                    }
                    break;
                case "c":
                    if (turkce == true)
                    {
                        functionReturnValue = "ç";
                    }
                    else
                    {
                        functionReturnValue = "d";
                    }
                    break;
                case "C":
                    if (turkce == true)
                    {
                        functionReturnValue = "Ç";
                    }
                    else
                    {
                        functionReturnValue = "D";
                    }
                    break;
                case "h":
                    if (turkce == true)
                    {
                        functionReturnValue = "ı";
                    }
                    else
                    {
                        functionReturnValue = "i";
                    }
                    break;
                case "I":
                    if (turkce == true)
                    {
                        functionReturnValue = "İ";
                    }
                    else
                    {
                        functionReturnValue = "J";
                    }
                    break;
                case "g":
                    if (turkce == true)
                    {
                        functionReturnValue = "ğ";
                    }
                    else
                    {
                        functionReturnValue = "h";
                    }
                    break;
                case "G":
                    if (turkce == true)
                    {
                        functionReturnValue = "Ğ";
                    }
                    else
                    {
                        functionReturnValue = "H";
                    }
                    break;
                case "o":
                    if (turkce == true)
                    {
                        functionReturnValue = "ö";
                    }
                    else
                    {
                        functionReturnValue = "p";
                    }
                    break;
                case "O":
                    if (turkce == true)
                    {
                        functionReturnValue = "Ö";
                    }
                    else
                    {
                        functionReturnValue = "P";
                    }
                    break;
                case "s":
                    if (turkce == true)
                    {
                        functionReturnValue = "ş";
                    }
                    else
                    {
                        functionReturnValue = "t";
                    }
                    break;
                case "S":
                    if (turkce == true)
                    {
                        functionReturnValue = "Ş";
                    }
                    else
                    {
                        functionReturnValue = "T";
                    }
                    break;
                case "u":
                    if (turkce == true)
                    {
                        functionReturnValue = "ü";
                    }
                    else
                    {
                        functionReturnValue = "v";
                    }
                    break;
                case "U":
                    if (turkce == true)
                    {
                        functionReturnValue = "Ü";
                    }
                    else
                    {
                        functionReturnValue = "V";
                    }
                    break;
                case "z":
                    functionReturnValue = "a";
                    break;
                case "Z":
                    functionReturnValue = "A";
                    break;
                case "9":
                    functionReturnValue = "0";
                    break;
                default:
                    if (((byte)harf[0] > 64 & (byte)harf[0] < 91) | ((byte)harf[0] > 96 & (byte)harf[0] < 123) | ((byte)harf[0] > 47 & (byte)harf[0] < 57))
                    {
                        functionReturnValue = Convert.ToChar((byte)harf[0] + 1).ToString();
                    }
                    else
                    {
                        functionReturnValue = '\0'.ToString();
                    }
                    break;
            }
            return functionReturnValue;


        }

        public static string GetMyDir()
        {
            string functionReturnValue = null;
            System.IO.FileInfo fi = null;
            System.IO.DirectoryInfo di = null;
            System.Diagnostics.Process pc = null;
            try
            {
                pc = System.Diagnostics.Process.GetCurrentProcess();
                fi = new System.IO.FileInfo(pc.MainModule.FileName);
                di = fi.Directory;
                functionReturnValue = di.FullName;
            }
            finally
            {
                fi = null;
                di = null;
                pc = null;
            }
            return functionReturnValue;
        }

        public static bool WriteLog(string sMsg)
        {
            // ERROR: Not supported in C#: OnErrorStatement

            System.IO.StreamWriter fs = null;
            string sFileName = null;
            if (System.IO.Directory.Exists(GetMyDir() + "\\Log") == false)
            {
                System.IO.Directory.CreateDirectory(GetMyDir() + "\\Log");
            }
            sFileName = GetMyDir() + "\\Log\\Log_" + DateTime.Now.ToString("yyyyMMdd") + ".log";
            fs = System.IO.File.AppendText(sFileName);
            fs.WriteLine(DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss") + " " + sMsg);
            fs.Close();
            return true;

        }

        public static byte[] StrToByteArray(string str)
        {
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            return encoding.GetBytes(str);
        }
        //StrToByteArray

        public static bool SetParam(ref ArrayList Parameters, string ParamName, object ParamValue)
        {
            bool bFound = false;
            System.Data.SqlClient.SqlParameter pr = new System.Data.SqlClient.SqlParameter();
            foreach (System.Data.SqlClient.SqlParameter pr_loopVariable in Parameters)
            {
                pr = pr_loopVariable;
                if (pr.ParameterName == ParamName)
                {
                    bFound = true;
                    break; // TODO: might not be correct. Was : Exit For
                }
            }
            if (bFound)
            {
                pr.Value = ParamValue;
            }
            return bFound;
        }


        public static double ProcessCommand(string command)
        {
            VBCodeProvider MyProvider = new VBCodeProvider();
            //Create a new VB Code Compiler
            System.CodeDom.Compiler.CompilerParameters cp = new System.CodeDom.Compiler.CompilerParameters();
            //Create a new Compiler parameter object.
            double ret = 0;
            cp.GenerateExecutable = false;
            //Don't create an object on disk
            cp.GenerateInMemory = true;
            //But do create one in memory.
            //If cp.OutputAssembly is used with a VBCodeProvider, it seems to want to read before it is executed.  
            //See C# CodeBank example for explanation of why it was used.


            string TempModuleSource = "'Option Strict On" + Environment.NewLine + "Imports System" + Environment.NewLine + "Imports System.Math" + Environment.NewLine + "Namespace ns " + Environment.NewLine + "Public Class class1" + Environment.NewLine + "Public  Function Evaluate()" + Environment.NewLine + "Return " + command + Environment.NewLine + "End Function" + Environment.NewLine + "End Class" + Environment.NewLine + "End Namespace";
            //Create a compiler output results object and compile the source code.
            System.CodeDom.Compiler.CompilerResults cr = MyProvider.CompileAssemblyFromSource(cp, TempModuleSource);
            if (cr.Errors.Count > 0)
            {
                //If the expression passed is invalid or "", the compiler will generate errors.
                //Throw New ArgumentOutOfRangeException("Invalid Expression - please use something VB could evaluate")
                return 0;

            }
            else
            {
                //Find our Evaluate method.
                MethodInfo methInfo = cr.CompiledAssembly.GetType("ns.class1").GetMethod("Evaluate");
                //Invoke it on nothing, so that we can get the return value
                ret = Convert.ToDouble(methInfo.Invoke(null, null));
                if (double.IsNaN(ret) | double.IsInfinity(ret) | double.IsNegativeInfinity(ret) | double.IsPositiveInfinity(ret))
                {
                    ret = 0;
                }
                return ret;
            }
        }





        public static string UCaseEng(string sText)
        {
            string sbuf = "";

            string ch = "";
            for (int i = 0; i < sText.Length; i++)
            {
                ch = sText.Substring(i, 1);
                switch (ch)
                {
                    case "ş":
                    case "Ş":
                        ch = "S";
                        break;
                    case "i":
                    case "ı":
                    case "İ":
                        ch = "I";
                        break;
                    case "ç":
                    case "Ç":
                        ch = "C";
                        break;
                    case "ö":
                    case "Ö":
                        ch = "O";
                        break;
                    case "ü":
                    case "Ü":
                        ch = "U";
                        break;
                    case "ğ":
                    case "Ğ":
                        ch = "G";

                        break;
                }
                sbuf += ch.ToUpper();
            }
            return sbuf;
        }

        public static string GetVariant(System.Data.SqlClient.SqlConnection conn, string VariantName)
        {
            string VariantValue = "";
            try
            {
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                System.Data.SqlClient.SqlDataAdapter da = null;
                DataTable dt = null;

                cmd.Connection = conn;
                cmd.CommandText = "SELECT VariantValue FROM Variants WHERE VariantName =@VariantName";
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@VariantName", VariantName));
                da = new System.Data.SqlClient.SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    VariantValue = dt.Rows[0]["VariantValue"].ToString();
                }
                dt.Dispose();
                da.Dispose();
                cmd.Dispose();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return VariantValue;
        }

        public static bool SetVariant(System.Data.SqlClient.SqlConnection conn, string VariantName, string VariantValue)
        {
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();


            try
            {
                cmd.Connection = conn;
                cmd.Parameters.Clear();
                if (VariantName.Length > 100) VariantName = VariantName.Substring(1, 100);
                if (VariantValue.Length > 255) VariantValue = VariantValue.Substring(1, 255);

                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@VariantName", VariantName));
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@VariantValue", VariantValue));

                cmd.CommandText = "IF EXISTS(SELECT * FROM Variants WHERE VariantName =@VariantName) BEGIN " + Environment.NewLine;
                cmd.CommandText += "    UPDATE Variants SET VariantValue=@VariantValue WHERE VariantName =@VariantName " + Environment.NewLine;
                cmd.CommandText += " END ELSE BEGIN " + Environment.NewLine;
                cmd.CommandText += "INSERT INTO Variants(VariantName,VariantValue) VALUES (" + Environment.NewLine;
                cmd.CommandText += "@VariantName,@VariantValue) " + Environment.NewLine;
                cmd.CommandText += " END " + Environment.NewLine;

                cmd.ExecuteNonQuery();

                cmd.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }


        }

        public static string GetSQLTypeVB(string sSQLType)
        {
            switch (sSQLType)
            {
                case "name":
                case "varchar":
                case "nchar":
                case "char":
                case "ntext":
                case "nvarchar":
                case "text":
                    return "System.String";
                case "bigint":
                case "int":
                    return "System.Int64";
                case "binary":
                case "varbinary":
                case "image":
                case "sql_variant":
                case "timestamp":
                    return "System.Object";
                case "datetime":
                case "smalldatetime":
                    return "System.DateTime";
                case "decimal":
                case "float":
                case "money":
                case "numeric":
                case "real":
                case "smallmoney":
                    return "System.Double";
                case "smallint":
                    return "System.Int32";
                case "tinyint":
                    return "System.Byte";
                case "bit":
                    return "System.Boolean";
                case "uniqueidentifier":

                    return "System.Guid";
                default:
                    return "System.String";
            }

        }

        public static Type GetSQLTypeToVBType(string sSQLType)
        {

            return Type.GetType(GetSQLTypeVB(sSQLType));
        }

        public static SqlDbType GetSqlDBTypeFromString(string sSqlType)
        {
            sSqlType = UCaseEng(sSqlType);
            switch (sSqlType)
            {
                case "BIGINT":
                    return SqlDbType.BigInt;
                case "BINARY":
                    return SqlDbType.Binary;
                case "BIT":
                    return SqlDbType.Bit;
                case "CHAR":
                    return SqlDbType.Char;
                case "DATE":
                    return SqlDbType.Date;
                case "DATETIME":
                    return SqlDbType.DateTime;
                case "DATETIME2":
                    return SqlDbType.DateTime2;
                case "DATETIMEOFFSET":
                    return SqlDbType.DateTimeOffset;
                case "DECIMAL":
                    return SqlDbType.Decimal;
                case "FLOAT":
                    return SqlDbType.Float;
                case "IMAGE":
                    return SqlDbType.Image;
                case "INT":
                    return SqlDbType.Int;
                case "MONEY":
                    return SqlDbType.Money;
                case "NCHAR":
                    return SqlDbType.NChar;
                case "NTEXT":
                    return SqlDbType.NText;
                case "NVARCHAR":
                    return SqlDbType.NVarChar;
                case "REAL":
                    return SqlDbType.Real;
                case "SMALLDATETIME":
                    return SqlDbType.SmallDateTime;
                case "SMALLINT":
                    return SqlDbType.SmallInt;
                case "SMALLMONEY":
                    return SqlDbType.SmallMoney;
                case "STRUCTURED":
                    return SqlDbType.Structured;
                case "TEXT":
                    return SqlDbType.Text;
                case "TIME":
                    return SqlDbType.Time;
                case "TIMESTAMP":
                    return SqlDbType.Timestamp;
                case "TINYINT":
                    return SqlDbType.TinyInt;
                case "UDT":
                    return SqlDbType.Udt;
                case "UNIQUEIDENTIFIER":
                    return SqlDbType.UniqueIdentifier;
                case "VARBINARY":
                    return SqlDbType.VarBinary;
                case "VARCHAR":
                    return SqlDbType.VarChar;
                case "VARIANT":
                    return SqlDbType.Variant;
                case "XML":
                    return SqlDbType.Xml;
                default:
                    return SqlDbType.NVarChar;
            }
        }

        public static SqlDbType GetTypeToSqlDbType(System.Type type)
        {
            switch (type.ToString())
            {
                case "System.String":
                    return SqlDbType.NVarChar;
                case "System.Char":
                    return SqlDbType.Char;
                case "System.Int16":
                    return SqlDbType.SmallInt;
                case "System.Byte":
                    return SqlDbType.TinyInt;
                case "System.Int64":
                case "System.Int32":
                    return SqlDbType.Int;
                case "System.Boolean":
                    return SqlDbType.Bit;
                case "System.Guid":
                    return SqlDbType.UniqueIdentifier;
                case "System.Double":
                    return SqlDbType.Float;
                case "System.Object":
                    return SqlDbType.VarBinary;
                default:
                    return SqlDbType.NVarChar;
            }
        }

        //public static double If0Null(object Value)
        //{
        //    if ((Value != null))
        //    {
        //        if (!Convert.IsDBNull(Value))
        //        {
        //            if (Information.IsNumeric(Value) == false)
        //            {
        //                return Convert.ToDouble(0);
        //            }
        //            if (Value == System.Double.NaN | Value == System.Double.NegativeInfinity | Value == System.Double.PositiveInfinity)
        //            {
        //                return Convert.ToDouble(0);
        //            }
        //        }

        //    }
        //    return Convert.ToDouble(IfNull(Value, 0));

        //}

        //public static Guid IfNullGuid(object Value)
        //{
        //    if ((Value != null))
        //    {
        //        if (!Convert.IsDBNull(Value))
        //        {
        //            try
        //            {
        //                if (Value is System.Guid)
        //                {
        //                    return (System.Guid)Value;
        //                }
        //                else
        //                {
        //                    return new Guid(Value.ToString());
        //                }


        //            }
        //            catch (Exception ex)
        //            {
        //                return Guid.Empty;
        //            }

        //        }

        //    }
        //    return Guid.Empty;
        //}

        //public static string IfNullGuidSQL(object Value)
        //{
        //    if ((Value != null))
        //    {
        //        if (!Convert.IsDBNull(Value))
        //        {
        //            if (Value is System.Guid)
        //            {
        //                return "'" + ((System.Guid)Value).ToString() + "'";
        //            }

        //        }

        //    }
        //    return "NULL";
        //}

        //public static bool IsNullGuid(object Value)
        //{
        //    if (Value == null)
        //        return true;
        //    if (Convert.IsDBNull(Value))
        //        return true;
        //    if (!Value is System.Guid)
        //        return true;
        //    // "00000000-0000-0000-0000-000000000000"

        //    if (string.IsNullOrEmpty(((Guid)Value).ToString()) | ((Guid)Value).ToString() == Guid.Empty.ToString())
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }

        //}


        public static DataColumn NewDataColumn(string ColumnName, System.Type dataType, string Caption = "")
        {
            try
            {
                DataColumn dc = new DataColumn(ColumnName, dataType);
                if (string.IsNullOrEmpty(Caption))
                {
                    dc.Caption = ColumnName;
                }
                else
                {
                    dc.Caption = Caption;
                }

                return dc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return new DataColumn();
        }

        public static bool saveSetting(string Section, string Key, object Value)
        {
            try
            {
                return SaveRegHKLM(Application.ProductName, Section, Key, Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public static object getSetting(string Section,string Key, string  defaultValue="")
        {
            try
            {
                
                return GetRegHKLM(Application.ProductName,Section, Key, defaultValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return defaultValue;
        }

        public static bool SaveRegHKLM(string AppName, string Section,string Key, object Value)
        {
            try
            {
                RegistryKey regKey = default(RegistryKey);

                //regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", true);

                regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);

                if (regKey.OpenSubKey(AppName) == null)
                {
                    regKey.CreateSubKey(AppName);

                }

                if (regKey.OpenSubKey(AppName, true).OpenSubKey(Section) == null)
                {
                    regKey.OpenSubKey(AppName, true).CreateSubKey(Section);
                }
                regKey.OpenSubKey(AppName, true).OpenSubKey(Section,true).SetValue(Key, Value);
                regKey.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public static object GetRegHKLM(string AppName, string Section,string Key, string DefaultValue = "")
        {
            try
            {
                RegistryKey regKey = default(RegistryKey);
                object value = null;
                //regKey = Registry.LocalMachine.OpenSubKey("SOFTWARE", true);
                regKey = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);
                if (regKey.OpenSubKey(AppName) == null)
                {
                    regKey.CreateSubKey(AppName);

                }
                if (regKey.OpenSubKey(AppName, true).OpenSubKey(Section) == null)
                {
                    regKey.OpenSubKey(AppName, true).CreateSubKey(Section);
                }

                value = regKey.OpenSubKey(AppName, true).OpenSubKey(Section,true).GetValue(Key);
                regKey.Close();
                if (value == null) return DefaultValue;
                return value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return DefaultValue;
        }

        public static string Str2Hex(string text)
        {
            byte[] data = Convert.FromBase64String(text);
            string sbuf = BitConverter.ToString(data);
            sbuf = sbuf.Replace("-", "");
            return sbuf;
        }

        public static string Hex2Str(string hextext)
        {
            byte[] b = new byte[(hextext.Length / 2)];
            string result = null;
            for (Int32 i = 0; i <= b.GetUpperBound(0); i++)
            {
                b[i] = byte.Parse(hextext.Substring(i * 2, 2), System.Globalization.NumberStyles.HexNumber);
            }
            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            result = enc.GetString(b);
            return result;
        }

        public static bool GridExport(typePiconnExport tExport, SaveFileDialog SaveFileDialog1, DevExpress.XtraGrid.Views.Grid.GridView GridView1)
        {
            bool functionReturnValue = false;

            try
            {
                SaveFileDialog1.FileName = "";
                switch (tExport)
                {
                    case typePiconnExport.XLS:
                        SaveFileDialog1.DefaultExt = "xls";
                        SaveFileDialog1.Filter = "Excel Files (*.xls)|*.xls|All Files (*.*)|*.*";
                        break;
                    case typePiconnExport.XLSX:
                        SaveFileDialog1.DefaultExt = "xlsx";
                        SaveFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
                        break;
                    case typePiconnExport.PDF:
                        SaveFileDialog1.DefaultExt = "pdf";
                        SaveFileDialog1.Filter = "Acrobat Reader Files (*.PDF)|*.pdf|All Files (*.*)|*.*";
                        break;
                    case typePiconnExport.TXT:
                        SaveFileDialog1.DefaultExt = "txt";
                        SaveFileDialog1.Filter = "Text Files (*.TXT)|*.TXT|All Files (*.*)|*.*";
                        break;
                    case typePiconnExport.CSV:
                        SaveFileDialog1.DefaultExt = "csv";
                        SaveFileDialog1.Filter = "CSV Files (*.CSV)|*.CSV|All Files (*.*)|*.*";
                        break;
                    case typePiconnExport.HTML:
                        SaveFileDialog1.DefaultExt = "htm";
                        SaveFileDialog1.Filter = "HTML Files (*.HTM)|*.HTM|All Files (*.*)|*.*";
                        break;
                }
                if (SaveFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return functionReturnValue;
                if (System.IO.File.Exists(SaveFileDialog1.FileName))
                {
                    if (MessageBox.Show(SaveFileDialog1.FileName + Environment.NewLine + "Dosya zaten var! Üzerine yazmak istiyor musunuz?", "Üzerine yaz?", MessageBoxButtons.YesNoCancel) != DialogResult.Yes)
                        return functionReturnValue;
                }
                switch (tExport)
                {
                    case typePiconnExport.XLS:
                        GridView1.ExportToXls(SaveFileDialog1.FileName);
                        break;
                    case typePiconnExport.XLSX:
                        GridView1.ExportToXlsx(SaveFileDialog1.FileName);
                        break;
                    case typePiconnExport.PDF:
                        GridView1.ExportToPdf(SaveFileDialog1.FileName);
                        break;
                    case typePiconnExport.TXT:
                        DevExpress.XtraPrinting.TextExportOptions s = new DevExpress.XtraPrinting.TextExportOptions();
                        s.Separator = '\t'.ToString();
                        GridView1.ExportToText(SaveFileDialog1.FileName, s);
                        break;
                    case typePiconnExport.CSV:
                        DevExpress.XtraPrinting.TextExportOptions s1 = new DevExpress.XtraPrinting.TextExportOptions();
                        s1.Separator = ";";
                        GridView1.ExportToText(SaveFileDialog1.FileName, s1);
                        break;
                    case typePiconnExport.HTML:
                        GridView1.ExportToHtml(SaveFileDialog1.FileName);
                        break;
                }
            Cikis:
                if (MessageBox.Show("Dosyayı Açmak ister misiniz", "Ac?", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                {
                    try
                    {
                        Shell("Explorer.exe " + '"' + SaveFileDialog1.FileName + '"', false);
                        
                    }
                    catch (Exception ex)
                    {
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
            return functionReturnValue;
        }

        public static void Shell(string FileName, bool wait)
        {
            // Start the child process.
            Process p = new Process();
            // Redirect the output stream of the child process.
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = FileName;
            p.Start();

            string output = p.StandardOutput.ReadToEnd();
            if (wait)
            {
                p.WaitForExit();
            }
           
           
        }

        public static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        public static void SaveFormGrids(Form f)
        {
            try
            {
                var grids = GetAllControlsRecusrvive<DevExpress.XtraGrid.GridControl>(f);
                if (grids != null)
                {
                    string regPath = Application.UserAppDataRegistry.Name;
                    if (HasProperty(f, "FormCode"))
                    {
                        regPath += "\\Form_" + ((frmBaseForm)f).FormCode;
                    }
                    else
                    {
                        regPath += "\\" + f.Name;
                    }

                    for (int i = 0; i < grids.Count; i++)
                    {
                        DevExpress.XtraGrid.GridControl grid = grids[i];
                        if (grid.MainView != null)
                        {
                            DevExpress.Utils.OptionsLayoutBase d = new DevExpress.Utils.OptionsLayoutBase();
                            //d.LayoutVersion = grid.MainView.OptionsLayout.LayoutVersion;
                            grid.MainView.SaveLayoutToRegistry(regPath + "\\" + grid.Name);
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                UT.RaiseError("Utility", "SaveFormGrids", ex);
            }
        }

        public static void LoadFormGrids(Form f)
        {
            try
            {
                var grids = GetAllControlsRecusrvive<DevExpress.XtraGrid.GridControl>(f);
                if (grids != null)
                {
                    string regPath = Application.UserAppDataRegistry.Name;
                    if (HasProperty(f, "FormCode"))
                    {
                        regPath += "\\Form_" + ((frmBaseForm)f).FormCode;
                    }
                    else
                    {
                        regPath += "\\" + f.Name;
                    }

                    for (int i = 0; i < grids.Count; i++)
                    {
                        DevExpress.XtraGrid.GridControl grid = grids[i];
                        if (grid.MainView != null)
                        {
                            DevExpress.Utils.OptionsLayoutBase opt = new DevExpress.Utils.OptionsLayoutBase();
                            DevExpress.Utils.OptionsLayoutBase d=new DevExpress.Utils.OptionsLayoutBase();
                            //d.LayoutVersion = grid.MainView.OptionsLayout.LayoutVersion;
                            grid.MainView.RestoreLayoutFromRegistry(regPath + "\\" + grid.Name);
                            ((DevExpress.XtraGrid.Views.Grid.GridView)grid.MainView).ActiveFilter.Clear();

                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                UT.RaiseError("Utility", "SaveFormGrids", ex);
            }
        }

        public static IList<T> GetAllControlsRecusrvive<T>(Control control) where T : Control
        {
            var rtn = new List<T>();
            foreach (Control item in control.Controls)
            {
                var ctr = item as T;
                if (ctr != null)
                {
                    rtn.Add(ctr);
                }
                else
                {
                    rtn.AddRange(GetAllControlsRecusrvive<T>(item));
                }

            }
            return rtn;
        }

        private static object FindControlByType(Form f)
        {
            throw new NotImplementedException();
        }

        public static bool HasMethod(this object objectToCheck, string methodName)
        {
            var type = objectToCheck.GetType();
            return type.GetMethod(methodName) != null;
        }

        public static bool HasProperty(this object obj, string propertyName)
        {
            return obj.GetType().GetProperty(propertyName) != null;
        }


        public static void generateCreateModifiedMenu(string FormCode, DevExpress.XtraGrid.GridControl grid, string tableName, string IDFieldName, string IDFieldNameGrid = "")
        {
            try
            {
                System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
                System.Windows.Forms.ToolStripMenuItem MenuItem_RecordInfo = new ToolStripMenuItem("Kayit bilgisi");
                System.Windows.Forms.ToolStripSeparator MenuItemSeparator = new ToolStripSeparator();

                MenuItem_RecordInfo.Click += new System.EventHandler(MenuItem_Click);
                if (grid.ContextMenuStrip != null)
                {
                    contextMenuStrip1 = grid.ContextMenuStrip;
                    contextMenuStrip1.Items.Add(MenuItemSeparator);
                }
                else
                {
                    contextMenuStrip1 = new ContextMenuStrip();
                    grid.ContextMenuStrip = contextMenuStrip1;
                }

                grid.MainView.MouseUp += new MouseEventHandler(gridView1_MouseUp);

                //contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(contextMenuStrip1_Opening);

                clsTableRecordInfo rec = new clsTableRecordInfo();
                rec.tableName = tableName;
                rec.IDFieldName = IDFieldName;
                rec.IDFieldNameGrid = IDFieldNameGrid;
                grid.Tag = rec;

                System.Windows.Forms.ToolStripSeparator MenuItemSeparator2 = new ToolStripSeparator();
                System.Windows.Forms.ToolStripMenuItem MenuItem_PrintGrid = new ToolStripMenuItem("Listeyi yazdir");
                System.Windows.Forms.ToolStripSeparator MenuItemSeparator3 = new ToolStripSeparator();
                System.Windows.Forms.ToolStripMenuItem MenuItem_Export = new ToolStripMenuItem("Export");
                System.Windows.Forms.ToolStripMenuItem MenuItem_ExportXLS = new ToolStripMenuItem("Excel(Xls)");
                System.Windows.Forms.ToolStripMenuItem MenuItem_ExportXLSX = new ToolStripMenuItem("Excel(Xlsx)");
                System.Windows.Forms.ToolStripMenuItem MenuItem_ExportCsv = new ToolStripMenuItem("Csv");
                System.Windows.Forms.ToolStripMenuItem MenuItem_ExportTxt = new ToolStripMenuItem("Txt");
                System.Windows.Forms.ToolStripMenuItem MenuItem_ExportPdf = new ToolStripMenuItem("Pdf");
                System.Windows.Forms.ToolStripMenuItem MenuItem_ExportHtml = new ToolStripMenuItem("Html");

                MenuItem_PrintGrid.Click += new System.EventHandler(MenuItem_PrintGrid_Click);
                MenuItem_ExportXLS.Click += new System.EventHandler(MenuItem_ExportXLS_Click);
                MenuItem_ExportXLSX.Click += new System.EventHandler(MenuItem_ExportXLSX_Click);
                MenuItem_ExportCsv.Click += new System.EventHandler(MenuItem_ExportCsv_Click);
                MenuItem_ExportTxt.Click += new System.EventHandler(MenuItem_ExportTxt_Click);
                MenuItem_ExportPdf.Click += new System.EventHandler(MenuItem_ExportPdf_Click);
                MenuItem_ExportHtml.Click += new System.EventHandler(MenuItem_ExportHtml_Click);

                contextMenuStrip1.Items.Add(MenuItem_PrintGrid);
                contextMenuStrip1.Items.Add(MenuItemSeparator2);
                //contextMenuStrip1.Items.Add(MenuItem_Export);
                //MenuItem_Export.DropDown = new ToolStripDropDown();
                //MenuItem_Export.DropDown.OwnerItem = MenuItem_Export;
                //MenuItem_Export.DropDown.Items.Add(MenuItem_ExportXLS);
                //MenuItem_Export.DropDown.Items.Add(MenuItem_ExportXLSX);
                //MenuItem_Export.DropDown.Items.Add(MenuItem_ExportCsv);
                //MenuItem_Export.DropDown.Items.Add(MenuItem_ExportTxt);
                //MenuItem_Export.DropDown.Items.Add(MenuItem_ExportPdf);
                //MenuItem_Export.DropDown.Items.Add(MenuItem_ExportHtml);


                contextMenuStrip1.Items.Add(MenuItem_ExportXLS);
                contextMenuStrip1.Items.Add(MenuItem_ExportXLSX);
                contextMenuStrip1.Items.Add(MenuItem_ExportCsv);
                contextMenuStrip1.Items.Add(MenuItem_ExportTxt);
                contextMenuStrip1.Items.Add(MenuItem_ExportPdf);
                contextMenuStrip1.Items.Add(MenuItem_ExportHtml);

                if (tableName != "")
                {
                    contextMenuStrip1.Items.Add(MenuItemSeparator3);
                    contextMenuStrip1.Items.Add(MenuItem_RecordInfo);
                }


                // export ve yazdirma, yetki kontrolu

               



            }
            catch (Exception ex)
            {
                UT.RaiseError("UT", "generateCreateModifiedMenu", ex);
            }
        }

        public static void MenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolStripMenuItem MenuItem = (System.Windows.Forms.ToolStripMenuItem)sender;
            System.Windows.Forms.ContextMenuStrip contextMenuStrip1 = (System.Windows.Forms.ContextMenuStrip)MenuItem.GetCurrentParent();
            DevExpress.XtraGrid.GridControl grid = (DevExpress.XtraGrid.GridControl)contextMenuStrip1.SourceControl;
            if (grid.Tag == null) return;

            clsTableRecordInfo rec = (clsTableRecordInfo)grid.Tag;

            DevExpress.XtraGrid.Views.Grid.GridView view = (DevExpress.XtraGrid.Views.Grid.GridView)grid.MainView;
            if (view.FocusedRowHandle < 0) return;
            if (!view.IsDataRow(view.FocusedRowHandle)) return;
            object ID;
            if (rec.IDFieldNameGrid != "")
            {
                ID = view.GetDataRow(view.FocusedRowHandle)[rec.IDFieldNameGrid];
            }
            else
            {
                ID = view.GetDataRow(view.FocusedRowHandle)[rec.IDFieldName];
            }



            string info = "";
            info = "" + rec.tableName + "." + rec.IDFieldName + Environment.NewLine;
            info += "----------------------------------------------" + Environment.NewLine;
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            cmd.Connection = DF.ActiveConn.dbConn;
            cmd.Parameters.Add(new SqlParameter("@ID", ID));
            cmd.CommandText = "SELECT * FROM " + rec.tableName + " WHERE " + rec.IDFieldName + " = @ID";
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                //if (dt.Columns.Contains("CreatedBy"))
                //{
                //    info += "Olusturan :\t" + SQ.getUserName((int)UT.If0Null(dt.Rows[0]["CreatedBy"])) + Environment.NewLine;
                //}
                if (dt.Columns.Contains("CreatedDate"))
                {
                    info += "Olusturma T. :\t" + ((DateTime)UT.IfNull(dt.Rows[0]["CreatedDate"], new DateTime(1900, 1, 1))).ToString("yyyy-MM-dd HH:mm:ss") + Environment.NewLine;
                }

                //if (dt.Columns.Contains("ModifiedBy"))
                //{
                //    info += "Degistiren :\t" + SQ.getUserName((int)UT.If0Null(dt.Rows[0]["ModifiedBy"])) + Environment.NewLine;
                //}
                if (dt.Columns.Contains("ModifiedDate"))
                {
                    info += "Degistirme T. :\t" + ((DateTime)UT.IfNull(dt.Rows[0]["ModifiedDate"], new DateTime(1900, 1, 1))).ToString("yyyy-MM-dd HH:mm:ss") + Environment.NewLine;
                }
            }
            MessageBox.Show(info, "Kayit bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private static void gridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DevExpress.XtraGrid.Views.Grid.GridView view = (DevExpress.XtraGrid.Views.Grid.GridView)sender;
                DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hitInfo = view.CalcHitInfo(e.Location);
                if (view.GridControl.ContextMenuStrip == null) return;
                System.Windows.Forms.ContextMenuStrip contextMenuStrip1 = view.GridControl.ContextMenuStrip;

                if (!hitInfo.InRowCell)
                    contextMenuStrip1.Visible = false;
                else
                    contextMenuStrip1.Visible = true;
            }
        }

        public static void MenuItem_ExportXLS_Click(object sender, EventArgs e)
        {
            Menu_Export(sender, ExportType.Excel);
        }
        public static void MenuItem_ExportXLSX_Click(object sender, EventArgs e)
        {
            Menu_Export(sender, ExportType.ExcelXlsx);
        }

        public static void MenuItem_ExportCsv_Click(object sender, EventArgs e)
        {
            Menu_Export(sender, ExportType.Csv);
        }

        public static void MenuItem_ExportTxt_Click(object sender, EventArgs e)
        {
            Menu_Export(sender, ExportType.Txt);
        }

        public static void MenuItem_ExportPdf_Click(object sender, EventArgs e)
        {
            Menu_Export(sender, ExportType.Pdf);
        }

        public static void MenuItem_ExportHtml_Click(object sender, EventArgs e)
        {
            Menu_Export(sender, ExportType.Html);
        }

        public static void MenuItem_PrintGrid_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolStripMenuItem MenuItem = (System.Windows.Forms.ToolStripMenuItem)sender;
            System.Windows.Forms.ContextMenuStrip contextMenuStrip1 = (System.Windows.Forms.ContextMenuStrip)MenuItem.GetCurrentParent();
            DevExpress.XtraGrid.GridControl grid = (DevExpress.XtraGrid.GridControl)contextMenuStrip1.SourceControl;
            grid.MainView.ShowRibbonPrintPreview();

        }


        private static void Menu_Export(object sender, ExportType exporttype)
        {

            try
            {
                System.Windows.Forms.SaveFileDialog ExportDialog = new SaveFileDialog();
                System.Windows.Forms.ToolStripMenuItem MenuItem = (System.Windows.Forms.ToolStripMenuItem)sender;
                System.Windows.Forms.ContextMenuStrip contextMenuStrip1 = (System.Windows.Forms.ContextMenuStrip)MenuItem.GetCurrentParent();
                DevExpress.XtraGrid.GridControl grid = (DevExpress.XtraGrid.GridControl)contextMenuStrip1.SourceControl;

                if (grid == null) return;
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
                        grid.MainView.ExportToCsv(ExportDialog.FileName);
                        break;
                    case ExportType.Excel:
                        grid.MainView.ExportToXls(ExportDialog.FileName);
                        break;
                    case ExportType.ExcelXlsx:
                        grid.MainView.ExportToXlsx(ExportDialog.FileName);
                        break;
                    case ExportType.Txt:
                        grid.MainView.ExportToText(ExportDialog.FileName);
                        break;
                    case ExportType.Pdf:
                        grid.MainView.ExportToPdf(ExportDialog.FileName);
                        break;
                    case ExportType.Html:
                        grid.MainView.ExportToHtml(ExportDialog.FileName);
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
                            UT.RaiseError("UT", "Menu_Export", ex);
                        }


                    }

                }
            }
            catch (System.Exception ex)
            {
                UT.RaiseError("UT", "Menu_Export", ex);
            }
        }

        private class clsTableRecordInfo
        {
            public string tableName = "";
            public string IDFieldName = "";
            public string IDFieldNameGrid = "";

        }
    }
    public enum typePiconnExport
    {
        XLS = 1,
        XLSX = 2,
        PDF = 3,
        TXT = 4,
        CSV = 5,
        HTML = 6
    }
}
