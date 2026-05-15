using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;

namespace MrTEK_EFatura
{
    public partial class frmInvoiceViewer : Form
    {
        private string saveAsXslt_FileName = "";
        private string saveAsXslt_Data = "";

        public int XsltNo = 0;
        public frmInvoiceViewer()
        {

            InitializeComponent();
        }
        public frmInvoiceViewer(Uyumsoft.InvoiceType uInvoice)
        {

            InitializeComponent();
            dataGridView1.Columns.Add("Guid", "");
            dataGridView1.Columns.Add("Fatura Numarası", "");
            dataGridView1.Columns.Add("Alıcı", "");
            dataGridView1.Columns.Add("Alıcı VKN", "");
            //for (int i = 0; i < invoices.Length; i++)
            //{
            //    InvoiceType invoice = invoices[i];
            //    if (i==0)
            ShowInvoice(uInvoice);

            var row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            row.Cells[0].Value = uInvoice.UUID.Value.ToString();
            row.Cells[1].Value = uInvoice.ID != null ? UT.IfNull(uInvoice.ID.Value, "").ToString() : "";
            row.Cells[2].Value = uInvoice.AccountingCustomerParty.Party.PartyName.Name.Value.ToString();
            row.Cells[3].Value = uInvoice.AccountingCustomerParty.Party.PartyIdentification[0].ID.Value.ToString();
            row.Tag = uInvoice;
            dataGridView1.Rows.Add(row);
            //}
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Rows[0].Selected = true;
            //dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

        }


        bool directPrint = false;
        string sprinterName = "";
        public void FormPrint(string _sprinterName = "")
        {
            directPrint = true;
            sprinterName = _sprinterName;
            this.ShowDialog();
        }


        public void ShowInvoice(Uyumsoft.InvoiceType invoice)
        {
            var xslt = string.Empty;
            if (invoice.AdditionalDocumentReference != null)
            {
                Uyumsoft.DocumentReferenceType doc = invoice.AdditionalDocumentReference[0];
                Uyumsoft.AttachmentType attacment = doc.Attachment;

                string fileName = "";
                if (attacment != null)
                {
                    fileName = attacment.EmbeddedDocumentBinaryObject != null ? UT.IfNull(attacment.EmbeddedDocumentBinaryObject.filename, "").ToString() : "";
                    saveAsXslt_FileName = fileName;
                }

                if (Path.GetExtension(fileName) == ".xslt" && attacment.EmbeddedDocumentBinaryObject.Value != null)
                {

                    using (var stream = new MemoryStream(attacment.EmbeddedDocumentBinaryObject.Value))
                    {
                        stream.Seek(0, SeekOrigin.Begin);

                        using (var reader = new StreamReader(stream))
                        {


                            xslt = reader.ReadToEnd();
                            saveAsXslt_Data = xslt;
                            xslt = xslt.Replace("n1:Invoice", "InvoiceType");

                            XmlSerializer serializer = new XmlSerializer(typeof(Uyumsoft.InvoiceType));
                            using (MemoryStream mstr = new MemoryStream())
                            {
                                serializer.Serialize(mstr, invoice, DF.InvoiceNamespaces);

                                string xml = Encoding.UTF8.GetString(mstr.ToArray());
                                webBrowser1.DocumentText = TransformXMLToHTML(xml, xslt);
                            }
                        }
                    }
                }
            }
            else
            {
                xslt = EFatura.getXSLTString(XsltNo);
                saveAsXslt_Data = xslt;
                saveAsXslt_FileName = "LocalDefaultXSLT.xslt";
                XmlSerializer serializer = new XmlSerializer(typeof(Uyumsoft.InvoiceType));
                using (MemoryStream mstr = new MemoryStream())
                {
                    bool xsltYok = true;
                    if (invoice.AdditionalDocumentReference != null)
                    {
                        if (invoice.AdditionalDocumentReference.Length > 0)
                        {
                            if (invoice.AdditionalDocumentReference[0].Attachment != null && invoice.AdditionalDocumentReference[0].ID != null)
                            {
                                xsltYok = false;
                            }
                        }
                    }

                    if (xsltYok)
                    {
                        byte[] XSLTData;
                        System.Text.UTF8Encoding enc = new UTF8Encoding();
                        XSLTData = enc.GetBytes(EFatura.getXSLTString(XsltNo));
                        invoice.AdditionalDocumentReference = new Uyumsoft.DocumentReferenceType[1];

                        invoice.AdditionalDocumentReference[0] = new Uyumsoft.DocumentReferenceType();
                        invoice.AdditionalDocumentReference[0].ID = new Uyumsoft.IDType { Value = Guid.NewGuid().ToString() };
                        invoice.AdditionalDocumentReference[0].IssueDate = new Uyumsoft.IssueDateType { Value = invoice.IssueDate.Value };
                        invoice.AdditionalDocumentReference[0].Attachment = new Uyumsoft.AttachmentType { EmbeddedDocumentBinaryObject = new Uyumsoft.EmbeddedDocumentBinaryObjectType { filename = invoice.ID + "_0001.xslt", characterSetCode = "UTF-8", encodingCode = "Base64", mimeCode = "application/xml", Value = XSLTData } };

                    }


                    serializer.Serialize(mstr, invoice, DF.InvoiceNamespaces);

                    string xml = Encoding.UTF8.GetString(mstr.ToArray());
                    webBrowser1.DocumentText = TransformXMLToHTML(xml, xslt);
                }

            }
        }

        public static string TransformXMLToHTML(string inputXml, string xsltString)
        {
            try
            {
                XslCompiledTransform transform = new XslCompiledTransform();
                using (XmlReader reader = XmlReader.Create(new StringReader(xsltString)))
                {
                    transform.Load(reader);
                }
                StringWriter results = new StringWriter();
                using (XmlReader reader = XmlReader.Create(new StringReader(inputXml)))
                {
                    transform.Transform(reader, null, results);
                }
                return results.ToString();
            }
            catch (System.Exception ex)
            {
                UT.RaiseError("frmInvoiceViewer", "", ex);
            }
            return "";
        }

        private Uyumsoft.IntegrationClient CreateClient()
        {
            var client = EFatura.createClient_Uyumsoft();

            return client;
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.ShowPrintPreviewDialog();
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "btnPrint_Click", ex);
            }
        }

        private void frmInvoiceViewer_Shown(object sender, EventArgs e)
        {
            if (directPrint)
            {
                webBrowser1.Print();
                this.Close();
            }

        }

        private void btnDownloadXslt_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.FileName = saveAsXslt_FileName;
                if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
                if (File.Exists(saveFileDialog1.FileName))
                {
                    if (MessageBox.Show("Dosya zaten var. Uzerine yazilsin mi?", "Uzerine yaz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
                }
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(saveAsXslt_Data);
                sw.Close();
                MessageBox.Show("OK");
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "btnDownloadXslt_Click", ex);
            }
        }

    }
}
