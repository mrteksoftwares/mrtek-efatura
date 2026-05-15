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
                if (chkTarih.Checked)
                {
                    return dateEdit1.DateTime;
                }
                else
                {
                    return new DateTime(1899, 12, 30);
                }

            }
            set
            {
                dateEdit1.DateTime = value;
            }
        }
        public DateTime Date2
        {
            get
            {
                if (chkTarih.Checked)
                {
                    DateTime tarih2 = dateEdit2.DateTime;
                    tarih2 = tarih2.AddHours(23);
                    tarih2 = tarih2.AddMinutes(59);
                    tarih2 = tarih2.AddSeconds(59);
                    return tarih2;
                }
                else
                {
                    return new DateTime(2099, 12, 31);
                }

            }
            set
            {
                dateEdit2.DateTime = new DateTime(value.Year, value.Month, value.Day, 23, 59, 59);
            }
        }
        public bool DateFilter { get { return chkTarih.Checked; } set { chkTarih.Checked = value; } }

        public userCntDateFilter()
        {
            InitializeComponent();
        }

        private void userCntDateFilter_Load(object sender, EventArgs e)
        {
            chkTarih.Checked = true;
            setThisMonth();
        }


        public void setThisMonth()
        {
           
            dateEdit1.DateTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dateEdit2.DateTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month));

        }
        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

            if (DateTimeChanged != null)
                DateTimeChanged(this, new EventArgs());

        }



        public void setToday()
        {

            dateEdit1.DateTime = DateTime.Today;
            dateEdit2.DateTime = DateTime.Today;
        }


        public void setThisWeek()
        {


            dateEdit1.DateTime = DateTime.Today.AddDays(-1 * (int)(DateTime.Today.DayOfWeek - 1));
            dateEdit2.DateTime = DateTime.Today.AddDays(7 - (int)(DateTime.Today.DayOfWeek));
        }



        public void setThisYear()
        {

            dateEdit1.DateTime = new DateTime(DateTime.Today.Year, 1, 1);
            dateEdit2.DateTime = new DateTime(DateTime.Today.Year, 12, 31);
        }

        public void setLast6Months()
        {



            dateEdit1.DateTime = DateTime.Today.AddMonths(-6);
            dateEdit2.DateTime = DateTime.Today;
        }
        public void setLast3Months()
        {

            dateEdit1.DateTime = DateTime.Today.AddMonths(-3);
            dateEdit2.DateTime = DateTime.Today;
        }



        private void chkTarih_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTarih.Checked)
            {
                dateEdit1.Enabled = true;
                dateEdit2.Enabled = true;
                btnToday.Enabled = true;
                btnThisWeek.Enabled = true;
                btnThisMonth.Enabled = true;
                btnThisYear.Enabled = true;
                btnLast3Months.Enabled = true;
                btnLast6Months.Enabled = true;
            }
            else
            {
                dateEdit1.Enabled = false;
                dateEdit2.Enabled = false;
                btnToday.Enabled = false;
                btnThisWeek.Enabled = false;
                btnThisMonth.Enabled = false;
                btnThisYear.Enabled = false;
                btnLast3Months.Enabled = false;
                btnLast6Months.Enabled = false;
            }
        }


        private void btnBugun_Click(object sender, EventArgs e)
        {
            setToday();

        }

        private void btnThisYear_Click(object sender, EventArgs e)
        {
            setThisYear();
        }

        private void btnLast6Months_Click(object sender, EventArgs e)
        {
            setLast6Months();
        }

        private void btnLast3Months_Click(object sender, EventArgs e)
        {
            setLast3Months();
        }

        private void btnThisWeek_Click(object sender, EventArgs e)
        {
            setThisWeek();
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            setThisMonth();
        }


    }
}
