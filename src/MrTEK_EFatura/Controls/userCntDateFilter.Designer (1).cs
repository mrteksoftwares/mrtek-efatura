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
            this.cbtnBugun = new DevExpress.XtraEditors.CheckButton();
            this.cbtnBuHafta = new DevExpress.XtraEditors.CheckButton();
            this.cbtnBuAy = new DevExpress.XtraEditors.CheckButton();
            this.cbtnBuYil = new DevExpress.XtraEditors.CheckButton();
            this.cbtnOzel = new DevExpress.XtraEditors.CheckButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.chkTarih = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkTarih.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Enabled = false;
            this.dateEdit1.Location = new System.Drawing.Point(120, 6);
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
            this.dateEdit2.Enabled = false;
            this.dateEdit2.Location = new System.Drawing.Point(120, 34);
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
            this.labelControl1.Location = new System.Drawing.Point(92, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(20, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "T1:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(92, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "T2:";
            // 
            // cbtnBugun
            // 
            this.cbtnBugun.Enabled = false;
            this.cbtnBugun.Location = new System.Drawing.Point(249, 5);
            this.cbtnBugun.Name = "cbtnBugun";
            this.cbtnBugun.Size = new System.Drawing.Size(76, 23);
            this.cbtnBugun.TabIndex = 5;
            this.cbtnBugun.Text = "Bugun";
            this.cbtnBugun.CheckedChanged += new System.EventHandler(this.cbtnBugun_CheckedChanged);
            // 
            // cbtnBuHafta
            // 
            this.cbtnBuHafta.Enabled = false;
            this.cbtnBuHafta.Location = new System.Drawing.Point(331, 5);
            this.cbtnBuHafta.Name = "cbtnBuHafta";
            this.cbtnBuHafta.Size = new System.Drawing.Size(76, 23);
            this.cbtnBuHafta.TabIndex = 6;
            this.cbtnBuHafta.Text = "Bu hafta";
            this.cbtnBuHafta.CheckedChanged += new System.EventHandler(this.cbtnBuHafta_CheckedChanged);
            // 
            // cbtnBuAy
            // 
            this.cbtnBuAy.Enabled = false;
            this.cbtnBuAy.Location = new System.Drawing.Point(413, 5);
            this.cbtnBuAy.Name = "cbtnBuAy";
            this.cbtnBuAy.Size = new System.Drawing.Size(76, 23);
            this.cbtnBuAy.TabIndex = 7;
            this.cbtnBuAy.Text = "Bu ay";
            this.cbtnBuAy.CheckedChanged += new System.EventHandler(this.cbtnBuAy_CheckedChanged);
            // 
            // cbtnBuYil
            // 
            this.cbtnBuYil.Enabled = false;
            this.cbtnBuYil.Location = new System.Drawing.Point(249, 34);
            this.cbtnBuYil.Name = "cbtnBuYil";
            this.cbtnBuYil.Size = new System.Drawing.Size(76, 23);
            this.cbtnBuYil.TabIndex = 8;
            this.cbtnBuYil.Text = "Bu yil";
            this.cbtnBuYil.CheckedChanged += new System.EventHandler(this.cbtnBuYil_CheckedChanged);
            // 
            // cbtnOzel
            // 
            this.cbtnOzel.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.cbtnOzel.Appearance.Options.UseFont = true;
            this.cbtnOzel.Enabled = false;
            this.cbtnOzel.Location = new System.Drawing.Point(331, 34);
            this.cbtnOzel.Name = "cbtnOzel";
            this.cbtnOzel.Size = new System.Drawing.Size(76, 23);
            this.cbtnOzel.TabIndex = 9;
            this.cbtnOzel.Text = "Özel";
            this.cbtnOzel.CheckedChanged += new System.EventHandler(this.cbtnOzel_CheckedChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Controls.Add(this.chkTarih);
            this.panelControl1.Controls.Add(this.cbtnOzel);
            this.panelControl1.Controls.Add(this.cbtnBuYil);
            this.panelControl1.Controls.Add(this.cbtnBuAy);
            this.panelControl1.Controls.Add(this.cbtnBuHafta);
            this.panelControl1.Controls.Add(this.cbtnBugun);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.dateEdit2);
            this.panelControl1.Controls.Add(this.dateEdit1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(500, 66);
            this.panelControl1.TabIndex = 10;
            // 
            // chkTarih
            // 
            this.chkTarih.EnterMoveNextControl = true;
            this.chkTarih.Location = new System.Drawing.Point(11, 21);
            this.chkTarih.Name = "chkTarih";
            this.chkTarih.Properties.Caption = "Tarih";
            this.chkTarih.Size = new System.Drawing.Size(75, 21);
            this.chkTarih.TabIndex = 10;
            this.chkTarih.CheckedChanged += new System.EventHandler(this.chkTarih_CheckedChanged);
            // 
            // userCntDateFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "userCntDateFilter";
            this.Size = new System.Drawing.Size(500, 66);
            this.Load += new System.EventHandler(this.userCntDateFilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkTarih.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckButton cbtnBugun;
        private DevExpress.XtraEditors.CheckButton cbtnBuHafta;
        private DevExpress.XtraEditors.CheckButton cbtnBuAy;
        private DevExpress.XtraEditors.CheckButton cbtnBuYil;
        private DevExpress.XtraEditors.CheckButton cbtnOzel;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.CheckEdit chkTarih;
    }
}
