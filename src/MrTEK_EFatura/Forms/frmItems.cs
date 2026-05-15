using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MrTEK_EFatura
{
    public partial class frmItems : MrTEK_EFatura.frmBaseForm
    {
        public frmItems()
        {
            InitializeComponent();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            try
            {
                MasterTable.Save();
               
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (System.Exception ex)
            {
                UT.RaiseError(this.Name, "", ex);
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            UT.OpenTable(MasterTable);
        }
    }
}
