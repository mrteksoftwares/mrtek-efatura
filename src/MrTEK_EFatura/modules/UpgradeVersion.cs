using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrTEK_EFatura
{
    public static class UP
    {
        public const string ProgramVersion = "1.0.7";

        public static bool versionControl()
        {

            try
            {
                string sActiveVersion = "";
                string msg = "";
                bool bVersionExecuted = false;
                bool bError = false;
                string sPrgVer = "";
                string sDBVer = "";
                System.Data.SqlClient.SqlConnection conn = DF.ActiveConn.dbConn;
            Tekrar:

                sActiveVersion = UT.GetVariant(DF.ActiveConn.dbConn,"Version");
                if (string.IsNullOrEmpty(sActiveVersion))
                    sActiveVersion = "0.0.0";
                switch (sActiveVersion)
                {
                    case "0.0.0":
                        UT.SetVariant(DF.ActiveConn.dbConn, "Version", "1.0.1");
                        bVersionExecuted = true;
                        if (bError == false)
                            goto Tekrar;

                        break;

                    case "1.0.1":
                        if (UT.RunVersionScriptFile(DF.ActiveConn.dbConn, "dbver_01.00.02.sql"))
                        {
                            UT.SetVariant(DF.ActiveConn.dbConn, "Version", "1.0.2");
                        }
                        else
                        {
                            msg = "Ver:1.0.2 versiyon geçişinde hata oluştu.";
                            bError = true;
                        }
                        bVersionExecuted = true;
                        if (bError == false)
                            goto Tekrar;

                        break;
                    case "1.0.2":
                        if (UT.RunVersionScriptFile(DF.ActiveConn.dbConn, "dbver_01.00.03.sql"))
                        {
                            UT.SetVariant(DF.ActiveConn.dbConn, "Version", "1.0.3");
                        }
                        else
                        {
                            msg = "Ver:1.0.3 versiyon geçişinde hata oluştu.";
                            bError = true;
                        }
                        bVersionExecuted = true;
                        if (bError == false)
                            goto Tekrar;

                        break;

                    case "1.0.3":
                        if (UT.RunVersionScriptFile(DF.ActiveConn.dbConn, "dbver_01.00.04.sql"))
                        {
                            UT.SetVariant(DF.ActiveConn.dbConn, "Version", "1.0.4");
                        }
                        else
                        {
                            msg = "Ver:1.0.4 versiyon geçişinde hata oluştu.";
                            bError = true;
                        }
                        bVersionExecuted = true;
                        if (bError == false)
                            goto Tekrar;

                        break;
                    case "1.0.4":
                        if (UT.RunVersionScriptFile(DF.ActiveConn.dbConn, "dbver_01.00.05.sql"))
                        {
                            UT.SetVariant(DF.ActiveConn.dbConn, "Version", "1.0.5");
                        }
                        else
                        {
                            msg = "Ver:1.0.5 versiyon geçişinde hata oluştu.";
                            bError = true;
                        }
                        bVersionExecuted = true;
                        if (bError == false)
                            goto Tekrar;

                        break;
                    case "1.0.5":
                        if (UT.RunVersionScriptFile(DF.ActiveConn.dbConn, "dbver_01.00.06.sql"))
                        {
                            UT.SetVariant(DF.ActiveConn.dbConn, "Version", "1.0.6");
                        }
                        else
                        {
                            msg = "Ver:1.0.6 versiyon geçişinde hata oluştu.";
                            bError = true;
                        }
                        bVersionExecuted = true;
                        if (bError == false)
                            goto Tekrar;

                        break;
                    case "1.0.6":
                        if (UT.RunVersionScriptFile(DF.ActiveConn.dbConn, "dbver_01.00.07.sql"))
                        {
                            UT.SetVariant(DF.ActiveConn.dbConn, "Version", "1.0.7");
                        }
                        else
                        {
                            msg = "Ver:1.0.7 versiyon geçişinde hata oluştu.";
                            bError = true;
                        }
                        bVersionExecuted = true;
                        if (bError == false)
                            goto Tekrar;

                        break;
                }


                if (bError)
                {
                    if (System.Windows.Forms.MessageBox.Show("DB ERROR:" + msg + Environment.NewLine + "Devam ederseniz veri bütünlüğünüz bozulabilir! Devam etmek istediğinizden emin misiniz?", "DB Uyari!", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Error) != System.Windows.Forms.DialogResult.Yes)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                sPrgVer = UT.VersionStrCorrect(ProgramVersion);
                sActiveVersion = UT.GetVariant(DF.ActiveConn.dbConn, "Version");
                sDBVer = UT.VersionStrCorrect(sActiveVersion);
                if (string.Compare(sPrgVer, sDBVer) < 0)
                {
                    if (sPrgVer.Substring(0, 2) != sDBVer.Substring(0, 2))
                    {
                        System.Windows.Forms.MessageBox.Show("Major versiyonlar farklı! Programı bu veri tabanında çalıştıramazsınız!");
                        return false;
                    }

                    if (System.Windows.Forms.MessageBox.Show("Version Error: Program Versiyon:" + ProgramVersion + "     Veri Tabanı Versiyonu:" + sActiveVersion + Environment.NewLine + "Program versiyonu yüklü olan veri tabanı versiyonundan küçük. Veri kaybı yaşayabilirsiniz. Lütfen programınızı yükseltiniz. Devam etmek istiyor musunuz?", "Kucuk versiyon!", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Error) != System.Windows.Forms.DialogResult.Yes)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }

        }
    }
}
