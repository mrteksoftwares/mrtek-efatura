
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
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

                client.Endpoint.EndpointBehaviors.Add(new MyEndpointBehavior());
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
                user.wsLogin(DF.webServiceUserName, DF.webServicePassword, "tr");

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

                                cmd.CommandText = @"
                                IF ((SELECT COUNT(*) FROM EFaturaMembers WHERE VKN=@VKN AND SystemCreateDate<>@SystemCreateDate)>0) BEGIN
	                                DELETE FROM EFaturaMembers WHERE VKN=@VKN
                                END	
                                IF ((SELECT COUNT(*) FROM EFaturaMembers WHERE VKN=@VKN AND PostboxAlias<>@PostboxAlias)>0) BEGIN
	                                INSERT INTO EFaturaMembers (VKN, FirmTitle, PostboxAlias, SenderboxAlias, SystemCreateDate, FirmCode)
                                    VALUES (@VKN, @FirmTitle, @PostboxAlias, @SenderboxAlias, @SystemCreateDate, '')
                                END	
                                
                ";
                                 

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
            try
            {
                if (DF.Integrator == IntegratorType.Uyumsoft)
                {
                    downloadIncomingInvoice_Uyumsoft(progressBar1);
                }
            }
            catch (System.Exception ex)
            {
                UT.RaiseError("EFatura", "downloadIncomingInvoice", ex);
            }
        }
        public enum InvoiceResponse
        {
            Approved = 1,
            Declined = 2,
            Return = 0
        }
        public static void approveDecline_IncomingInvoice(string UUID, InvoiceResponse response)
        {
            try
            {
                if (DF.Integrator == IntegratorType.Uyumsoft)
                {
                    approveDecline_IncomingInvoice_Uyumsoft(UUID, response);
                }
            }
            catch (System.Exception ex)
            {
                UT.RaiseError("EFatura", "downloadIncomingInvoice", ex);
            }
        }

        public static void approveDecline_IncomingInvoice_Uyumsoft(string UUID, InvoiceResponse response)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = DF.ActiveConn.dbConn;


                Uyumsoft.IntegrationClient client = createClient_Uyumsoft();

                Uyumsoft.DocumentResponseInfo[] d = new Uyumsoft.DocumentResponseInfo[1];

                d[0] = new Uyumsoft.DocumentResponseInfo();
                d[0].InvoiceId = UUID;
                switch (response)
                {
                    case InvoiceResponse.Approved:
                        d[0].ResponseStatus = Uyumsoft.DocumentResponseStatus.Approved;
                        break;
                    case InvoiceResponse.Declined:
                        d[0].ResponseStatus = Uyumsoft.DocumentResponseStatus.Declined;
                        break;
                    case InvoiceResponse.Return:
                        d[0].ResponseStatus = Uyumsoft.DocumentResponseStatus.Return;
                        break;
                }

                Uyumsoft.FlagResponse res = client.SendDocumentResponse(d);
                if (res.IsSucceded)
                {
                    //MessageBox.Show("Value:" + res.Value.ToString());
                    if (res.Value)
                    {
                        
                        int Status = 0 ;
                        string StatusDesc="";
                       switch( response){
                           case InvoiceResponse.Approved:
                               Status = (int)Uyumsoft.InvoiceStatus.Approved;
                               StatusDesc = Uyumsoft_InvoiceStatusDescription(Uyumsoft.InvoiceStatus.Approved);
                               break;
                           case InvoiceResponse.Declined:
                           case InvoiceResponse.Return:
                               Status = (int)Uyumsoft.InvoiceStatus.Declined;
                               StatusDesc = Uyumsoft_InvoiceStatusDescription(Uyumsoft.InvoiceStatus.Declined);
                               break;
                       }
                       cmd.CommandText = "UPDATE Invoice SET ModifiedBy=1,ModifiedDate=GETDATE() , Status=" + Status.ToString() + " , StatusDescription='" + StatusDesc + "' WHERE UUID='" + UUID + "'";
                       cmd.ExecuteNonQuery();

                    }
                }
                else
                {
                    MessageBox.Show(res.Message);
                }


            }
            catch (System.Exception ex)
            {
                UT.RaiseError("EFatura", "approveIncomingInvoice_Uyumsoft", ex);
            }
        }
        public static void syncOutgoingInvoices(System.Windows.Forms.ProgressBar progressBar1)
        {
            try
            {
                if (DF.Sync == SyncType.ExternalExe)
                {
                    
                    UT.Shell(DF.Sync_ExternalExe, true);
                }
                else if (DF.Sync == SyncType.CsvImport)
                {

                }
                else //stored procedure
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = DF.ActiveConn.dbConn;
                    cmd.CommandText = "EXEC dbo.spSYNC_EFaturalariCek";
                    cmd.ExecuteNonQuery();

                }

            }
            catch (System.Exception ex)
            {
                UT.RaiseError("EFatura", "syncOutgoingInvoices", ex);
            }
        }

        public static void downloadIncomingInvoice_Uyumsoft(System.Windows.Forms.ProgressBar progressBar1)
        {
            try
            {
                progressBar1.Value = 0;
                if (MessageBox.Show("Gelen faturalar indirilecektir. Onayliyor musunuz?", "Indir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                SqlCommand cmd = new SqlCommand();
                DateTime? startDate;
                cmd.Connection = DF.ActiveConn.dbConn;
                cmd.CommandText = "SELECT MAX(IssueDate) FROM Invoice WHERE IOType=1 ";
                startDate = (DateTime)UT.IfNull(cmd.ExecuteScalar(), (new DateTime(1900, 1, 1)));
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
                    Uyumsoft.InvoicesResponse response = new Uyumsoft.InvoicesResponse();
                    try
                    {
                        response = client.GetInboxInvoices(d);

                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.IndexOf("deserializing") >= 0)
                        {
                            MessageBox.Show("Gelen faturalar icerisinde bir veya bir kac fatura hatali XML kaydi ile gelmis." + Environment.NewLine +
                                "Tarih:" + d.ExecutionStartDate.ToString() + " - " + d.ExecutionEndDate.ToString() + Environment.NewLine +
                                "Sayfa (" + d.PageSize.ToString() + "):" + (d.PageIndex + 1).ToString() + "");
                            d.PageIndex++;
                        }
                        else
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }

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

                                    cmd.CommandText = "SELECT COUNT(*) FROM Invoice WHERE Deleted = 0 AND UUID='" + invoices[i].Invoice.UUID.Value + "'";
                                    if (UT.If0Null(cmd.ExecuteScalar()) > 0)
                                    {

                                    }
                                    else
                                    {

                                        Invoice dbInvoice = EFaturaConvertor.Convert_UyumsoftToDBInvoice(invoices[i]);
                                        if (dbInvoice.ProfileID == "TEMELFATURA")
                                        {
                                            dbInvoice.Status = (int)Uyumsoft.InvoiceStatus.Approved;
                                            dbInvoice.StatusDescription = Uyumsoft_InvoiceStatusDescription(Uyumsoft.InvoiceStatus.Approved);
                                        }
                                        dbInvoice.SaveFull();
                                    }

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
                                if (d.PageIndex == 4)
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
                progressBar1.Visible = false;
            }
            catch (System.Exception ex)
            {
                UT.RaiseError("EFatura", "downloadIncomingInvoice", ex);
            }
            progressBar1.Visible = false;
        }

        public static bool insertIncomeInvoice_Uyumsoft(Uyumsoft.InvoiceInfo invoice)
        {
            return true;
        }

        public static bool sendInvoice(int InvoiceID)
        {
            Invoice dbInvoice = new Invoice();
            dbInvoice.InvoiceID = InvoiceID;
            if (dbInvoice.LoadFull() == false) return false;
            if (DF.Integrator == IntegratorType.Uyumsoft)
            {
                return (sendInvoice_Uyumsoft(dbInvoice));
            }
            return false;
        }

        private static bool sendInvoice_Uyumsoft(Invoice dbInvoice)
        {
            try
            {
                string PostBox = "";
                if (dbInvoice.PostBox.Trim() == "" && dbInvoice.ACP_PartyTaxSchemeTaxTypeCode != "" && dbInvoice.ProfileID != "EARSIVFATURA")
                {
                    SqlCommand cmd = new SqlCommand();
                    SqlDataAdapter da;
                    DataTable dtEfatMember;
                    cmd.Connection = DF.ActiveConn.dbConn;
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new SqlParameter("@VKN", dbInvoice.ACP_PartyTaxSchemeTaxTypeCode));
                    cmd.CommandText = "SELECT TOP 1 PostboxAlias,bDefault FROM EFaturaMembers WHERE VKN=@VKN  ORDER BY bDefault DESC, EFaturaMemberID";
                    da = new SqlDataAdapter(cmd);
                    dtEfatMember = new DataTable();
                    da.Fill(dtEfatMember);
                    if (dtEfatMember.Rows.Count > 0)
                    {
                        PostBox = UT.IfNull(dtEfatMember.Rows[0]["PostboxAlias"], "").ToString();
                    }
                }
                else
                {
                    if(dbInvoice.PostBox.Trim() != "")
                    {
                        PostBox = dbInvoice.PostBox.Trim();
                    }
                }
                if(dbInvoice.ProfileID == "EARSIVFATURA")
                {
                    PostBox = "defaultpk";
                }
                bool ret = false;
                Uyumsoft.InvoiceInfo uInvoiceInfo = new Uyumsoft.InvoiceInfo();
                if (isTestPlatform())
                {
                    dbInvoice.ASP_PartyIdentification1_ID = "9000068418";
                    dbInvoice.ASP_PartyTaxSchemeTaxTypeCode= "9000068418";
                    if (dbInvoice.ProfileID != "EARSIVFATURA")
                    {
                        dbInvoice.ACP_PartyTaxSchemeTaxTypeCode = "9000068418";
                        dbInvoice.ACP_PartyIdentification1_ID = "9000068418";
                    }
                }
                uInvoiceInfo.Invoice = EFaturaConvertor.Convert_DBInvoiceToUyumsoft(dbInvoice);
                if (isTestPlatform() && dbInvoice.ProfileID != "EARSIVFATURA")
                {
                    uInvoiceInfo.TargetCustomer = new Uyumsoft.CustomerInfo() { Title = dbInvoice.ACP_PartyName, VknTckn = "9000068418", Alias = "defaultpk" };
                }
                else
                {
                    uInvoiceInfo.TargetCustomer = new Uyumsoft.CustomerInfo() { Title = dbInvoice.ACP_PartyName, VknTckn = dbInvoice.ACP_PartyTaxSchemeTaxTypeCode, Alias = PostBox };
                }
                
                uInvoiceInfo.LocalDocumentId = dbInvoice.ID;
                uInvoiceInfo.EArchiveInvoiceInfo = new Uyumsoft.EArchiveInvoiceInformation();
                uInvoiceInfo.EArchiveInvoiceInfo.DeliveryType = Uyumsoft.InvoiceDeliveryType.Electronic;
                if(dbInvoice.ProfileID == "EARSIVFATURA")
                {
                    if (uInvoiceInfo.Invoice.AccountingCustomerParty.Party.Contact.ElectronicMail.Value.Trim() == "")
                        uInvoiceInfo.Invoice.AccountingCustomerParty.Party.Contact.ElectronicMail.Value = DF.EArsiveDefaultEmail;
                }

                Uyumsoft.IntegrationClient client = createClient_Uyumsoft();
                
                Uyumsoft.InvoiceInfo[] uInvoiceInfoList = new Uyumsoft.InvoiceInfo[1];
                uInvoiceInfoList[0] = uInvoiceInfo;

                Uyumsoft.InvoiceIdentitiesResponse res = client.SendInvoice(uInvoiceInfoList);

                if (res.IsSucceded)
                {
                    if (res.Value != null)
                    {
                        if (res.Value.Length > 0)
                        {
                            ret = true;
                            //MessageBox.Show(res.Value[0].Id);
                            dbInvoice.LocalStatus = 1;
                            dbInvoice.Save();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Gonderim basarisiz. ID:" + dbInvoice.ID + Environment.NewLine + res.Message);

                }
                return ret;
            }
            catch (System.Exception ex)
            {
                UT.RaiseError("EFatura", "sendInvoice_Uyumsoft", ex);
            }
            return false;
        }

        public static bool isTestPlatform()
        {
            if (DF.webServiceUrl.IndexOf("test") > -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool checkInvoice(int InvoiceID)
        {
            Invoice dbInvoice = new Invoice();
            dbInvoice.InvoiceID = InvoiceID;
            if (dbInvoice.Load() == false) return false;
            if (DF.Integrator == IntegratorType.Uyumsoft)
            {
                return (checkInvoice_Uyumsoft(dbInvoice));
            }
            return false;
        }

        private static bool checkInvoice_Uyumsoft(Invoice dbInvoice)
        {
            try
            {

                Uyumsoft.IntegrationClient client = createClient_Uyumsoft();
                string[] sUUID = new string[1];
                sUUID[0] = dbInvoice.UUID;
                Uyumsoft.InvoiceStatusResponse res = client.QueryOutboxInvoiceStatus(sUUID);
                
                if (res.IsSucceded)
                {

                    if (res.Value != null)
                    {
                        if (res.Value.Length > 0)
                        {
                            
                            //MessageBox.Show(res.Value[0].Id);
                            dbInvoice.Status = (int)res.Value[0].Status;
                            dbInvoice.Message = UT.IfNull(res.Value[0].Message,"").ToString();
                            dbInvoice.StatusDescription = Uyumsoft_InvoiceStatusDescription(res.Value[0].Status);
                            dbInvoice.Save();

                            //Uyumsoft.InvoiceStatusWithLogResponse res= client.GetOutboxInvoiceStatusWithLogs(sUUID);
                            //res.Value[0].Logs[5].
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Gonderim basarisiz. ID:" + dbInvoice.ID + Environment.NewLine + res.Message);

                }

            }
            catch (System.Exception ex)
            {
                UT.RaiseError("EFatura", "checkInvoice_Uyumsoft", ex);
            }
            return false;
        }


        public static bool showInvoiceLog(int InvoiceID)
        {
            Invoice dbInvoice = new Invoice();
            dbInvoice.InvoiceID = InvoiceID;
            if (dbInvoice.Load() == false) return false;
            if (DF.Integrator == IntegratorType.Uyumsoft)
            {
                return (showInvoiceLog_Uyumsoft(dbInvoice));
            }
            return false;
        }

        private static bool showInvoiceLog_Uyumsoft(Invoice dbInvoice)
        {
            try
            {

                Uyumsoft.IntegrationClient client = createClient_Uyumsoft();
                string[] sUUID = new string[1];
                sUUID[0] = dbInvoice.UUID;
                Uyumsoft.InvoiceStatusWithLogResponse res = client.GetOutboxInvoiceStatusWithLogs(sUUID);

                if (res.IsSucceded)
                {

                    if (res.Value != null)
                    {
                        if (res.Value.Length > 0)
                        {
                            frmInvoiceLogViewer f = new frmInvoiceLogViewer();
                            f.ID = dbInvoice.ID;
                            f.UUID = dbInvoice.UUID;
                            if(res.Value[0].Logs!=null){
                                for (int i = 0; i < res.Value[0].Logs.Length; i++)
                                {
                                    f.Log +=(i+1).ToString() + " ) " + res.Value[0].Logs[i].CreateDateUtc.ToString("yyyy-MM-dd HH:mm:ss") + " // " + res.Value[0].Logs[i].Creator + " // LocalIP:" + res.Value[0].Logs[i].LocalIpAddress + " // RemoteIP:" + res.Value[0].Logs[i].RemoteIpAddress + Environment.NewLine;
                                    f.Log += res.Value[0].Logs[i].Message + Environment.NewLine;
                                    f.Log += "----------------------------------" + Environment.NewLine + Environment.NewLine;

                                }
                            }
                            f.ShowDialog();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Gonderim basarisiz. ID:" + dbInvoice.ID + Environment.NewLine + res.Message);

                }

            }
            catch (System.Exception ex)
            {
                UT.RaiseError("EFatura", "sendInvoice_Uyumsoft", ex);
            }
            return false;
        }


        public static string Uyumsoft_InvoiceStatusDescription(Uyumsoft.InvoiceStatus status)
        {
            //res.Value[0].Status
            //dbInvoice.StatusDescription
            switch (status)
            {
                case Uyumsoft.InvoiceStatus.Draft:
                    return "Taslak";
                case Uyumsoft.InvoiceStatus.Canceled:
                    return "Iptal edilmis";
                case Uyumsoft.InvoiceStatus.Queued:
                    return "Kuyrukta";
                case Uyumsoft.InvoiceStatus.Processing:
                    return "Islemde";
                case Uyumsoft.InvoiceStatus.SentToGib:
                    return "GIB e gitmis";
                case Uyumsoft.InvoiceStatus.Approved:
                    return "Onaylanmis";
                case Uyumsoft.InvoiceStatus.WaitingForAprovement:
                    return "Onay bekliyor";
                case Uyumsoft.InvoiceStatus.Declined:
                    return "Reddedilmis";
                case Uyumsoft.InvoiceStatus.Return:
                    return "Iade";
                case Uyumsoft.InvoiceStatus.EArchivedCanceled:
                    return "E-Arsiv Iptal";
                case Uyumsoft.InvoiceStatus.Error:
                    return "Hata";
                default:
                    return "";
            }
        }
        public static string getXSLTString(int XSLTNo)
        {
            try
            {
                string XsltFileName = "";
                if (XSLTNo >= 0 && XSLTNo <= 4)
                {
                    XsltFileName = UT.INIRead(DF.INIFileName, "EFATURA", "Xslt" + XSLTNo.ToString(), "");
                    if (XsltFileName.Trim() != "")
                    {
                        if (System.IO.File.Exists(XsltFileName) == false)
                        {
                            MessageBox.Show("'" + XsltFileName + "'" + Environment.NewLine + "Xslt dosyasi bulunamadi! Varsiyan XSLT kullanilacaktir.");
                            XsltFileName = "";
                        }
                    }
                }
                if (XsltFileName.Trim() != "")
                {
                    StreamReader sr = new StreamReader(XsltFileName);
                    string sbuf = "";
                    sbuf = sr.ReadToEnd();
                    sr.Close();
                    return sbuf;
                }
                else
                {
                    return Properties.Resources.xslt;
                }
            }
            catch (System.Exception ex)
            {
                UT.RaiseError("EFatura", "getXSLTString", ex);
            }
            return Properties.Resources.xslt;
        }

        public static string checkEFaturaMember_Uyumsoft(string vknTckn)
        {
            try
            {
                string postBoxAlias = "";

                Uyumsoft.IntegrationClient client = EFatura.createClient_Uyumsoft();
                Uyumsoft.PagedQueryContext p = new Uyumsoft.PagedQueryContext();
                Uyumsoft.UserAliassesResponse r = new Uyumsoft.UserAliassesResponse();
                r=client.GetUserAliasses(vknTckn);
                if (r.IsSucceded && r.Value!=null)
                {
                    postBoxAlias = r.Value.ReceiverboxAliases[0].Alias;
                    //Console.WriteLine(r.Value);
                }
                
                

                client.Close();
               
                return postBoxAlias;
            }
            catch (System.Exception ex)
            {
                //UT.RaiseError("EFatura", "downloadEFaturaMembers_Uyumsoft", ex);
            }
            return "";
        }
    }

    public class Finansbank
    {
        public FinansbankConn.connectorService conn { get; set; }
        public FinansbankUser.userService user { get; set; }

    }

    public class MyMessageInspector : IClientMessageInspector
    {
        public MyMessageInspector()
        {
        }

        public void AfterReceiveReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {
        }

        public object BeforeSendRequest(ref System.ServiceModel.Channels.Message request, IClientChannel channel)
        {
            //int index = request.Headers.FindHeader("SoftwareDefinitionId", "IntegrationClient");
            //if (index < 0)
            //{
            //    var header = MessageHeader.CreateHeader("SoftwareDefinitionId", "IntegrationClient", "329 01 00579");
            //    request.Headers.Add(header);
            //}
            //return null;
            int index = request.Headers.FindHeader("SoftwareDefinitionId", "IntegrationClient");
            if (index < 0)
            {
                var header = MessageHeader.CreateHeader("SoftwareDefinitionId", "IntegrationClient", "c8b4601a-b65d-483f-9885-7d7aaef59460");
                request.Headers.Add(header);
            }
            return null;
        }
    }

    public class MyEndpointBehavior : IEndpointBehavior
    {
        public void AddBindingParameters(ServiceEndpoint endpoint,
            BindingParameterCollection bindingParameters)
        {

        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint,
            ClientRuntime clientRuntime)
        {
            clientRuntime.MessageInspectors.Add(new MyMessageInspector());
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint,
            EndpointDispatcher endpointDispatcher)
        {

        }

        public void Validate(ServiceEndpoint endpoint)
        {

        }
    }
}
