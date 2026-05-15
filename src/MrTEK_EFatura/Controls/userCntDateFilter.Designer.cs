namespace MrTEK_EFatura
{
    partial class userCntDateFilter
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.chkTarih = new DevExpress.XtraEditors.CheckEdit();
            this.btnToday = new DevExpress.XtraEditors.SimpleButton();
            this.btnThisWeek = new DevExpress.XtraEditors.SimpleButton();
            this.btnThisMonth = new DevExpress.XtraEditors.SimpleButton();
            this.btnLast3Months = new DevExpress.XtraEditors.SimpleButton();
            this.btnLast6Months = new DevExpress.XtraEditors.SimpleButton();
            this.btnThisYear = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTarih.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(117, 5);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dateEdit1.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dateEdit1.Size = new System.Drawing.Size(123, 22);
            this.dateEdit1.TabIndex = 0;
            this.dateEdit1.EditValueChanged += new System.EventHandler(this.dateEdit1_EditValueChanged);
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(117, 36);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dateEdit2.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dateEdit2.Size = new System.Drawing.Size(123, 22);
            this.dateEdit2.TabIndex = 1;
            this.dateEdit2.EditValueChanged += new System.EventHandler(this.dateEdit1_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(89, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(20, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "T1:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(89, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "T2:";
            // 
            // chkTarih
            // 
            this.chkTarih.EditValue = true;
            this.chkTarih.EnterMoveNextControl = true;
            this.chkTarih.Location = new System.Drawing.Point(8, 18);
            this.chkTarih.Name = "chkTarih";
            this.chkTarih.Properties.Caption = "Tarih";
            this.chkTarih.Size = new System.Drawing.Size(75, 21);
            this.chkTarih.TabIndex = 10;
            this.chkTarih.CheckedChanged += new System.EventHandler(this.chkTarih_CheckedChanged);
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(246, 3);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(76, 26);
            this.btnToday.TabIndex = 12;
            this.btnToday.Text = "Bugun";
            this.btnToday.Click += new System.EventHandler(this.btnBugun_Click);
            // 
            // btnThisWeek
            // 
            this.btnThisWeek.Location = new System.Drawing.Point(328, 3);
            this.btnThisWeek.Name = "btnThisWeek";
            this.btnThisWeek.Size = new System.Drawing.Size(76, 26);
            this.btnThisWeek.TabIndex = 13;
            this.btnThisWeek.Text = "Bu hafta";
            this.btnThisWeek.Click += new System.EventHandler(this.btnThisWeek_Click);
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.Location = new System.Drawing.Point(410, 3);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(76, 26);
            this.btnThisMonth.TabIndex = 14;
            this.btnThisMonth.Text = "Bu ay";
            this.btnThisMonth.Click += new System.EventHandler(this.btnThisMonth_Click);
            // 
            // btnLast3Months
            // 
            this.btnLast3Months.Location = new System.Drawing.Point(246, 34);
            this.btnLast3Months.Name = "btnLast3Months";
            this.btnLast3Months.Size = new System.Drawing.Size(76, 26);
            this.btnLast3Months.TabIndex = 15;
            this.btnLast3Months.Text = "Son 3 ay";
            this.btnLast3Months.Click += new System.EventHandler(this.btnLast3Months_Click);
            // 
            // btnLast6Months
            // 
            this.btnLast6Months.Location = new System.Drawing.Point(328, 34);
            this.btnLast6Months.Name = "btnLast6Months";
            this.btnLast6Months.Size = new System.Drawing.Size(76, 26);
            this.btnLast6Months.TabIndex = 16;
            this.btnLast6Months.Text = "Son 6 ay";
            this.btnLast6Months.Click += new System.EventHandler(this.btnLast6Months_Click);
            // 
            // btnThisYear
            // 
            this.btnThisYear.Location = new System.Drawing.Point(410, 34);
            this.btnThisYear.Name = "btnThisYear";
            this.btnThisYear.Size = new System.Drawing.Size(76, 26);
            this.btnThisYear.TabIndex = 17;
            this.btnThisYear.Text = "Bu yil";
            this.btnThisYear.Click += new System.EventHandler(this.btnThisYear_Click);
            // 
            // userCntDateFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThisYear);
            this.Controls.Add(this.btnLast6Months);
            this.Controls.Add(this.btnLast3Months);
            this.Controls.Add(this.btnThisMonth);
            this.Controls.Add(this.btnThisWeek);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.chkTarih);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.dateEdit2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl2);
            this.Name = "userCntDateFilter";
            this.Size = new System.Drawing.Size(496, 66);
            this.Load += new System.EventHandler(this.userCntDateFilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkTarih.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit chkTarih;
        private DevExpress.XtraEditors.SimpleButton btnToday;
        private DevExpress.XtraEditors.SimpleButton btnThisWeek;
        private DevExpress.XtraEditors.SimpleButton btnThisMonth;
        private DevExpress.XtraEditors.SimpleButton btnLast3Months;
        private DevExpress.XtraEditors.SimpleButton btnLast6Months;
        private DevExpress.XtraEditors.SimpleButton btnThisYear;
    }
}
