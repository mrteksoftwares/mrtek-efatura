using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MrTEK_EFatura
{
    public partial class frmInvoiceLogViewer : Form
    {
        public frmInvoiceLogViewer()
        {
            InitializeComponent();
        }

        public string ID { get { return txtInvoiceID.Text; } set { txtInvoiceID.Text = value; } }
        public string UUID { get { return txtUUID.Text; } set { txtUUID.Text = value; } }
        public string Log { get { return memoEdit1.Text; } set { memoEdit1.Text = value; } }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
