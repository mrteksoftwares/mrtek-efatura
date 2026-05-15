
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrTEK_EFatura
{
    public static class EFatura
    {
        public static Uyumsoft.IntegrationClient createClient_Uyumsoft()
        {
            try
            {

                if (DF.webServiceUrl == "")
                {
                    MessageBox.Show("Web servis url alani bos! Lutfen ayarlar bolumunden duzeltiniz!");
                    return null;
                }

                System.ServiceModel.BasicHttpBinding myBinding = new System.ServiceModel.BasicHttpBinding();
                System.ServiceModel.EndpointAddress myEndpoint = new System.ServiceModel.EndpointAddress(DF.webServiceUrl);

                myBinding.Security = new System.ServiceModel.BasicHttpSecurity();
                myBinding.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.TransportWithMessageCredential;
                myBinding.Security.Transport = new System.ServiceModel.HttpTransportSecurity();
                myBinding.Security.Transport.ClientCredentialType = System.ServiceModel.HttpClientCredentialType.None;

                myBinding.MaxBufferPoolSize = 20000000;
                myBinding.MaxBufferSize = 20000000;
                myBinding.MaxReceivedMessageSize = 20000000;
                myBinding.SendTimeout = new TimeSpan(12, 50, 50);
                myBinding.ReceiveTimeout = new TimeSpan(12, 50, 50);
                myBinding.ReaderQuotas = new System.Xml.XmlDictionaryReaderQuotas();
                myBinding.ReaderQuotas.MaxDepth = 32;
                myBinding.ReaderQuotas.MaxArrayLength = 20000000;
                myBinding.ReaderQuotas.MaxStringContentLength = 20000000;
                myBinding.ReaderQuotas.MaxBytesPerRead = 20000000;

                Uyumsoft.IntegrationClient client = new Uyumsoft.IntegrationClient(myBinding, myEndpoint);
                client.ClientCredentials.UserName.UserName = DF.webServiceUserName;
                client.ClientCredentials.UserName.Password = DF.webServicePassword;
                //client.Open();
                return client;
            }
            catch (System.Exception ex)
            {
                UT.RaiseError("EFatura", "createClient_Uyumsoft", ex);
            }
            return null;
        }

        public static Finansbank createClient_Finansbank()
        {
            try
            {

                if (DF.webServiceUrl == "")
                {
                    MessageBox.Show("Web servis url alani bos! Lutfen ayarlar bolumunden duzeltiniz!");
                    return null;
                }

               

                FinansbankConn.connectorService conn = new FinansbankConn.connectorService();
                conn.Url = DF.webServiceUrl; 
                FinansbankUser.userService user = new FinansbankUser.userService();
                user.Url = DF.webServiceUserUrl;
                user.CookieContainer = new System.Net.CookieContainer();
                conn.CookieContainer = user.CookieContainer;
                user.wsLogin(DF.webServiceUserName, DF.webServicePassword,"tr");

                Finansbank fin = new Finansbank();
                fin.conn = conn;
                fin.user = user;

                //FinansbankUser.UserService us ;
                //Finansbank.ConnectorService cs;

                //us.CookieContainer = new System.Net.CookieContainer();
                //cs.CookieContainer = us.CookieContainer;
                //us.wsLogin(userName, password, "tr");
                //cs.belgeGonder();
                //us.logout();
                return fin;
            }
            catch (System.Exception ex)
            {
                UT.RaiseError("EFatura", "createClient_Finansbank", ex);
            }
            return null;
        }



        public static bool downloadEFaturaMembers_Uyumsoft()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da;
                DataTable dtEFaturaMembers;
                cmd.Connection = DF.ActiveConn.dbConn;
                cmd.CommandText = "SELECT * FROM EFaturaMembers";
                da = new SqlDataAdapter(cmd);
                dtEFaturaMembers = new DataTable();
                da.Fill(dtEFaturaMembers);

                Uyumsoft.IntegrationClient client = EFatura.createClient_Uyumsoft();
                Uyumsoft.PagedQueryContext p = new Uyumsoft.PagedQueryContext();
                Uyumsoft.SystemUsersResponse r = new Uyumsoft.SystemUsersResponse();
                bool bDur = false;
                int savecount = 0;

                p.PageSize = 20;
                p.PageIndex = 0;
                //pbStatus.Value = 0;
                do
                {
                    r = client.GetEInvoiceUsers(p);
                    if (r.IsSucceded)
                    {
                        for (int i = 0; i < r.Value.Items.Count(); i++)
                        {
                            bool bFound = false;
                            foreach (DataRow dr in dtEFaturaMembers.Rows)
                            {
                                if (dr["VKN"].ToString() == r.Value.Items[i].Identifier && dr["PostboxAlias"].ToString() == r.Value.Items[i].PostboxAlias && dr["SenderboxAlias"].ToString() == r.Value.Items[i].SenderboxAlias)
                                {
                                    bFound = true;
                                }
                            }
                            if (!bFound)
                            {
                                cmd.Parameters.Clear();
                                cmd.Parameters.Add(new SqlParameter("@VKN", r.Value.Items[i].Identifier));
                                cmd.Parameters.Add(new SqlParameter("@FirmTitle", r.Value.Items[i].Title ?? ""));
                                cmd.Parameters.Add(new SqlParameter("@PostboxAlias", r.Value.Items[i].PostboxAlias ?? ""));
                                cmd.Parameters.Add(new SqlParameter("@SenderboxAlias", r.Value.Items[i].SenderboxAlias ?? ""));
                                cmd.Parameters.Add(new SqlParameter("@SystemCreateDate", r.Value.Items[i].SystemCreateDate ?? ""));

                                cmd.CommandText = "INSERT INTO EFaturaMembers (VKN, FirmTitle, PostboxAlias, SenderboxAlias, SystemCreateDate, FirmCode) " + Environment.NewLine;
                                cmd.CommandText += " VALUES (@VKN, @FirmTitle, @PostboxAlias, @SenderboxAlias, @SystemCreateDate, '')";
                                cmd.ExecuteNonQuery();
                                savecount++;
                            }
                        }
                        p.PageIndex++;
                        if (p.PageIndex >= r.Value.TotalPages)
                        {
                            break;
                        }

                    }

                } while (!bDur);

                client.Close();
                UT.SetVariant(DF.ActiveConn.dbConn, "EFaturaMemberLastDownload", (new DateTime()).ToString("yyyy-MM-dd"));
                MessageBox.Show(savecount.ToString() + " adet kayit indirildi.");
                return true;
            }
            catch (System.Exception ex)
            {
                UT.RaiseError("EFatura", "downloadEFaturaMembers_Uyumsoft", ex);
            }
            return false;
        }


        public static void runStoredProcedure_spSYNC_MukellefleriIsaretle()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DF.ActiveConn.dbConn;
                cmd.CommandText = "exec dbo.spSYNC_MukellefleriIsaretle";
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                UT.RaiseError("EFatura", "runStoredProcedure_spSYNC_MukellefleriIsaretle", ex);
            }
        }

        public static void runStoredProcedure_spSYNC_EFaturalariCek()
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DF.ActiveConn.dbConn;
                cmd.CommandText = "exec dbo.spSYNC_EFaturalariCek";
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                UT.RaiseError("EFatura", "runStoredProcedure_spSYNC_EFaturalariCek", ex);
            }
        }

        public static void downloadIncomingInvoice(System.Windows.Forms.ProgressBar progressBar1)
        {
            //try
            //{
                if (DF.Integrator == IntegratorType.Uyumsoft)
                {
                    downloadIncomingInvoice_Uyumsoft(progressBar1);
                }
            //}
            //catch (System.Exception ex)
            //{
            //    UT.RaiseError("EFatura", "downloadIncomingInvoice", ex);
            //}
        }

        public static void downloadIncomingInvoice_Uyumsoft(System.Windows.Forms.ProgressBar progressBar1)
        {
            //try
            //{
                progressBar1.Value = 0;
                if (MessageBox.Show("Gelen faturalar indirilecektir. Onayliyor musunuz?", "Indir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                SqlCommand cmd = new SqlCommand();
                DateTime? startDate;
                cmd.Connection = DF.ActiveConn.dbConn;
                cmd.CommandText = "SELECT MAX(IssueDate) FROM Invoice WHERE IOType=1 ";
                startDate = (DateTime)UT.IfNull(cmd.ExecuteScalar(),(new DateTime(1900,1,1)));
                if (DF.webServiceUserName == "Uyumsoft")
                {
                    startDate = DateTime.Today.AddDays(-7);
                }
                else
                {
                    startDate = startDate.Value.AddMonths(-1);
                }
                Uyumsoft.IntegrationClient client = createClient_Uyumsoft();
                Uyumsoft.InboxInvoiceQueryModel d = new Uyumsoft.InboxInvoiceQueryModel();
                bool bDur = false;
                int totalCount = 0;


                d.ExecutionStartDate = startDate;
                d.ExecutionEndDate = DateTime.Today.AddDays(1);


                d.PageIndex = 0;
                d.PageSize = 20;
                d.OnlyNewestInvoices = false;
                d.SetTaken = false;

                do
                {
                    Uyumsoft.InvoicesResponse response = client.GetInboxInvoices(d);
                    if (response.IsSucceded)
                    {
                        if (response.Value != null)
                        {
                            progressBar1.Maximum = response.Value.TotalCount;
                        }
                        
                        if (response.Value.Items != null)
                        {
                            if (response.Value.Items.Length > 0)
                            {
                                Uyumsoft.InvoiceInfo[] invoices = response.Value.Items;
                                for (int i = 0; i < invoices.Length; i++)
                                {
                                    insertIncomeInvoice_Uyumsoft(invoices[i]);

                                    progressBar1.Value = response.Value.PageIndex * response.Value.PageSize + i;
                                    Application.DoEvents();
                                }
                                totalCount += response.Value.Items.Length;
                                if (response.Value.TotalPages == response.Value.PageIndex + 1)
                                {
                                    bDur = true;
                                    break;
                                }
                            }
                            else
                            {
                                bDur = true;
                                break;
                            }
                            d.PageIndex++;
                            if (DF.webServiceUserName == "Uyumsoft")
                            {
                                if (d.PageIndex == 2)
                                {
                                    bDur = true;
                                }
                            }
                        }
                        else
                        {
                            bDur = true;
                        }
                    }
                    Application.DoEvents();
                } while (bDur == false);

            //}
            //catch (System.Exception ex)
            //{
            //    UT.RaiseError("EFatura", "downloadIncomingInvoice", ex);
            //}
        }

        public static bool insertIncomeInvoice_Uyumsoft(Uyumsoft.InvoiceInfo invoice)
        {
            return true;
        }
    }

    public class Finansbank
    {
        public FinansbankConn.connectorService conn { get; set; }
        public FinansbankUser.userService user { get; set; }

    }
}
