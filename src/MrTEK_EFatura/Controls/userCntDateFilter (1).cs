using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MrTEK_EFatura
{
    public partial class userCntDateFilter : UserControl
    {
        public delegate void DateTimeChange_EventHandler(object sender, EventArgs e);

        public event DateTimeChange_EventHandler DateTimeChanged;

        public DateTime Date1
        {
            get
            {
                return dateEdit1.DateTime;
            }
        }
        public  DateTime Date2
        {
            get
            {
                DateTime tarih2 = dateEdit2.DateTime;
                tarih2 = tarih2.AddHours(23);
                tarih2 = tarih2.AddMinutes(59);
                tarih2 = tarih2.AddSeconds(59);
                return tarih2;
            }
        }
        public bool DateFilter { get { return chkTarih.Checked; } }

        public userCntDateFilter()
        {
            InitializeComponent();
        }

        private void userCntDateFilter_Load(object sender, EventArgs e)
        {
            cbtnBuAy.Checked = true;
        }

        private void cbtnBuAy_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cbtnBuAy.Checked)
            {
                dateEdit1.Properties.ReadOnly = true;
                dateEdit2.Properties.ReadOnly = true;
                
                cbtnBugun.Checked = false;
                cbtnBuHafta.Checked = false;
                //cbtnBuAy.Checked = false;
                cbtnBuYil.Checked = false;
                cbtnOzel.Checked = false;
                if (DateTimeChanged != null)
                    DateTimeChanged(this, new EventArgs());

                dateEdit1.DateTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                dateEdit2.DateTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));
            }
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (cbtnOzel.Checked)
            {
                if (DateTimeChanged != null)
                    DateTimeChanged(this, new EventArgs());
            }
        }

        private void cbtnBugun_CheckedChanged(object sender, EventArgs e)
        {

            if (cbtnBugun.Checked)
            {
                dateEdit1.Properties.ReadOnly = true;
                dateEdit2.Properties.ReadOnly = true;
                
                //cbtnBugun.Checked = false;
                cbtnBuHafta.Checked = false;
                cbtnBuAy.Checked = false;
                cbtnBuYil.Checked = false;
                cbtnOzel.Checked = false;
                if (DateTimeChanged != null)
                    DateTimeChanged(this, new EventArgs());
                dateEdit1.DateTime = DateTime.Today;
                dateEdit2.DateTime = DateTime.Today; 
            }
        }

        private void cbtnBuHafta_CheckedChanged(object sender, EventArgs e)
        {

            if (cbtnBuHafta.Checked)
            {
                dateEdit1.Properties.ReadOnly = true;
                dateEdit2.Properties.ReadOnly = true;
               
                cbtnBugun.Checked = false;
                //cbtnBuHafta.Checked = false;
                cbtnBuAy.Checked = false;
                cbtnBuYil.Checked = false;
                cbtnOzel.Checked = false;
                if (DateTimeChanged != null)
                    DateTimeChanged(this, new EventArgs());
                dateEdit1.DateTime = DateTime.Today.AddDays(-1 * (int)(DateTime.Today.DayOfWeek - 1));
                dateEdit2.DateTime = DateTime.Today.AddDays(7 - (int)(DateTime.Today.DayOfWeek));
            }
        }

        private void cbtnBuYil_CheckedChanged(object sender, EventArgs e)
        {

            if (cbtnBuYil.Checked)
            {
                dateEdit1.Properties.ReadOnly = true;
                dateEdit2.Properties.ReadOnly = true;
              
                cbtnBugun.Checked = false;
                cbtnBuHafta.Checked = false;
                cbtnBuAy.Checked = false;
                //cbtnBuYil.Checked = false;
                cbtnOzel.Checked = false;
                if (DateTimeChanged != null)
                    DateTimeChanged(this, new EventArgs());
                dateEdit1.DateTime = new DateTime(DateTime.Today.Year, 1, 1);
                dateEdit2.DateTime = new DateTime(DateTime.Today.Year, 12, 31);
            }
        }

        private void cbtnOzel_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtnOzel.Checked)
            {
                
                
                cbtnBugun.Checked = false;
                cbtnBuHafta.Checked = false;
                cbtnBuAy.Checked = false;
                cbtnBuYil.Checked = false;
                //cbtnOzel.Checked = false;
                //if (DateTimeChanged != null)
                //    DateTimeChanged(this, new EventArgs());
                dateEdit1.Properties.ReadOnly = false;
                dateEdit2.Properties.ReadOnly = false;
            }
        }

        private void chkTarih_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTarih.Checked)
            {
                dateEdit1.Enabled = true;
                dateEdit2.Enabled = true;
                cbtnBugun.Enabled = true;
                cbtnBuHafta.Enabled = true;
                cbtnBuAy.Enabled = true;
                cbtnBuYil.Enabled = true;
                cbtnOzel.Enabled = true;
            }
            else
            {
                dateEdit1.Enabled = false;
                dateEdit2.Enabled = false;
                cbtnBugun.Enabled = false;
                cbtnBuHafta.Enabled = false;
                cbtnBuAy.Enabled = false;
                cbtnBuYil.Enabled = false;
                cbtnOzel.Enabled = false;
            }
        }


    }
}
