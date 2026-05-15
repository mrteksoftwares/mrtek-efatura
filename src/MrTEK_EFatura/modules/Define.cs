using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MrTEK_EFatura
{
    public static class DF
    {
        public static clsActiveConn ActiveConn=new clsActiveConn();
        public static IntegratorType Integrator;
        public static SyncType Sync;
        public static String glb_InvoiceProfileID = "TEMELFATURA";
        public static String Param_InvoicePrefix = "REY";
        public static String Param_EArchivePrefix = "ERS";

        public static string webServiceUrl { get; set; }
        public static string webServiceUserName { get; set; }
        public static string webServicePassword { get; set; }
        public static string webServiceUserUrl { get; set; }
        public static string webServiceVKN{ get; set; }
        public static string EArsiveDefaultEmail { get; set; }
        public static string Sync_ExternalExe { get; set; }
        public static string INIFileName= Application.ExecutablePath.Replace(".exe", ".ini").Replace(".EXE", ".ini"); 

        private static XmlSerializerNamespaces _InvoiceNamespaces;
        public static XmlSerializerNamespaces InvoiceNamespaces
        {
            get
            {
                if (_InvoiceNamespaces == null)
                {
                    _InvoiceNamespaces = new XmlSerializerNamespaces();
                    _InvoiceNamespaces.Add("", "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2");
                    _InvoiceNamespaces.Add("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2");
                    _InvoiceNamespaces.Add("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
                    _InvoiceNamespaces.Add("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
                    _InvoiceNamespaces.Add("cctc", "urn:un:unece:uncefact:documentation:2");
                    _InvoiceNamespaces.Add("ds", "http://www.w3.org/2000/09/xmldsig#");
                    _InvoiceNamespaces.Add("qdt", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2");
                    _InvoiceNamespaces.Add("ubltr", "urn:oasis:names:specification:ubl:schema:xsd:TurkishCustomizationExtensionComponents");
                    _InvoiceNamespaces.Add("udt", "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2");
                    _InvoiceNamespaces.Add("xades", "http://uri.etsi.org/01903/v1.3.2#");
                    _InvoiceNamespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
                }
                return _InvoiceNamespaces;
            }
        }

    }

    public class ExportEventArgs : EventArgs
    {
        public ExportType exporttype { get; set; }
      
    }


    public enum ExportType
    {
        Excel = 1,
        ExcelXlsx = 2,
        Txt=3,
        Csv=4,
        Pdf=5,
        Html=6
    }

     public enum IntegratorType
    {
        Uyumsoft = 1,
        FinansBank = 2,
        Innova=3
    }

     public enum SyncType
     {
         StoredProcedure_Ozel = 100,
         StoredProcedure_Logo = 101,
         StoredProcedure_Mikro = 102,
         StoredProcedure_Eta = 103,
         CsvImport=200,
         ExternalExe=300

     }
}
