using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MrTEK_EFatura
{
    public partial class frmPrintExternalExe : Form
    {
        public string externalFile = "";
        public frmPrintExternalExe()
        {
            InitializeComponent();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            externalFile = txtExternalFile.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmPrintExternalExe_Load(object sender, EventArgs e)
        {
            txtExternalFile.Text = externalFile;
        }
    }
}
