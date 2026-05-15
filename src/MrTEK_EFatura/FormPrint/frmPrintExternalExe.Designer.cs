namespace MrTEK_EFatura
{
    partial class frmPrintExternalExe
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.PanelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.cmdSave = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCancel = new DevExpress.XtraEditors.SimpleButton();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtExternalFile = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.PanelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
            this.PanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl3)).BeginInit();
            this.PanelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtExternalFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).BeginInit();
            this.PanelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelControl1
            // 
            this.PanelControl1.Controls.Add(this.PanelControl3);
            this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelControl1.Location = new System.Drawing.Point(0, 67);
            this.PanelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(579, 62);
            this.PanelControl1.TabIndex = 5;
            // 
            // PanelControl3
            // 
            this.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl3.Controls.Add(this.cmdSave);
            this.PanelControl3.Controls.Add(this.cmdCancel);
            this.PanelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelControl3.Location = new System.Drawing.Point(371, 2);
            this.PanelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelControl3.Name = "PanelControl3";
            this.PanelControl3.Size = new System.Drawing.Size(206, 58);
            this.PanelControl3.TabIndex = 1;
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(6, 6);
            this.cmdSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(92, 36);
            this.cmdSave.TabIndex = 1;
            this.cmdSave.Text = "Tamam";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(105, 6);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(92, 36);
            this.cmdCancel.TabIndex = 2;
            this.cmdCancel.Text = "Vazgec";
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // LabelControl1
            // 
            this.LabelControl1.Location = new System.Drawing.Point(5, 5);
            this.LabelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(107, 16);
            this.LabelControl1.TabIndex = 7;
            this.LabelControl1.Text = "External Exe Name";
            // 
            // txtExternalFile
            // 
            this.txtExternalFile.EnterMoveNextControl = true;
            this.txtExternalFile.Location = new System.Drawing.Point(5, 28);
            this.txtExternalFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExternalFile.Name = "txtExternalFile";
            this.txtExternalFile.Size = new System.Drawing.Size(488, 22);
            this.txtExternalFile.TabIndex = 6;
            // 
            // LabelControl2
            // 
            this.LabelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelControl2.Location = new System.Drawing.Point(8, 59);
            this.LabelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(57, 17);
            this.LabelControl2.TabIndex = 3;
            this.LabelControl2.Text = "Example:";
            // 
            // PanelControl2
            // 
            this.PanelControl2.Appearance.BackColor = System.Drawing.SystemColors.Info;
            this.PanelControl2.Appearance.Options.UseBackColor = true;
            this.PanelControl2.Controls.Add(this.LabelControl6);
            this.PanelControl2.Controls.Add(this.LabelControl7);
            this.PanelControl2.Controls.Add(this.LabelControl4);
            this.PanelControl2.Controls.Add(this.LabelControl3);
            this.PanelControl2.Controls.Add(this.LabelControl2);
            this.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelControl2.Location = new System.Drawing.Point(0, 129);
            this.PanelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelControl2.Name = "PanelControl2";
            this.PanelControl2.Size = new System.Drawing.Size(579, 148);
            this.PanelControl2.TabIndex = 8;
            // 
            // LabelControl6
            // 
            this.LabelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelControl6.Location = new System.Drawing.Point(10, 36);
            this.LabelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LabelControl6.Name = "LabelControl6";
            this.LabelControl6.Size = new System.Drawing.Size(202, 17);
            this.LabelControl6.TabIndex = 7;
            this.LabelControl6.Text = "(path) ExeName [FieldName]";
            // 
            // LabelControl7
            // 
            this.LabelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelControl7.Location = new System.Drawing.Point(10, 12);
            this.LabelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LabelControl7.Name = "LabelControl7";
            this.LabelControl7.Size = new System.Drawing.Size(42, 17);
            this.LabelControl7.TabIndex = 6;
            this.LabelControl7.Text = "Usage:";
            // 
            // LabelControl4
            // 
            this.LabelControl4.Location = new System.Drawing.Point(8, 106);
            this.LabelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(425, 16);
            this.LabelControl4.TabIndex = 5;
            this.LabelControl4.Text = "* [InvoiceID] is a fieldname in result data. Field name must be between []";
            // 
            // LabelControl3
            // 
            this.LabelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelControl3.Location = new System.Drawing.Point(8, 82);
            this.LabelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(505, 17);
            this.LabelControl3.TabIndex = 4;
            this.LabelControl3.Text = "C:\\Program Files\\Piconn\\PiconnCevahir\\ProbarMercury.exe [InvoiceID]";
            // 
            // frmPrintExternalExe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 277);
            this.Controls.Add(this.PanelControl1);
            this.Controls.Add(this.LabelControl1);
            this.Controls.Add(this.txtExternalFile);
            this.Controls.Add(this.PanelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPrintExternalExe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "External Exe/Script";
            this.Load += new System.EventHandler(this.frmPrintExternalExe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
            this.PanelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl3)).EndInit();
            this.PanelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtExternalFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).EndInit();
            this.PanelControl2.ResumeLayout(false);
            this.PanelControl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        internal DevExpress.XtraEditors.PanelControl PanelControl3;
        internal DevExpress.XtraEditors.SimpleButton cmdSave;
        internal DevExpress.XtraEditors.SimpleButton cmdCancel;
        internal DevExpress.XtraEditors.LabelControl LabelControl1;
        internal DevExpress.XtraEditors.TextEdit txtExternalFile;
        internal DevExpress.XtraEditors.LabelControl LabelControl2;
        internal DevExpress.XtraEditors.PanelControl PanelControl2;
        internal DevExpress.XtraEditors.LabelControl LabelControl6;
        internal DevExpress.XtraEditors.LabelControl LabelControl7;
        internal DevExpress.XtraEditors.LabelControl LabelControl4;
        internal DevExpress.XtraEditors.LabelControl LabelControl3;
    }
}