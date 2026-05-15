using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace MrTEK_EFatura
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
    
        }

        public void showDesigner(){
            this.ShowRibbonDesignerDialog();
        }
        public void showPreviewDialog()
        {
            this.ShowRibbonPreviewDialog();
        }
        public void PrintForm()
        {
            this.Print();
        }
        public void PrintForm(string PrinterName)
        {
            this.Print(PrinterName);
        }
    }
}
