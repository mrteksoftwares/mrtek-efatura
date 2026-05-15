namespace MrTEK_EFatura
{
    partial class frmPrintItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintItem));
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.GroupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtSQL = new DevExpress.XtraEditors.MemoEdit();
            this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtParameters = new DevExpress.XtraEditors.MemoEdit();
            this.panelSQL = new DevExpress.XtraEditors.PanelControl();
            this.cboReportType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtReportName = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdSQL = new DevExpress.XtraEditors.SimpleButton();
            this.PanelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.cmdSave = new DevExpress.XtraEditors.SimpleButton();
            this.cmdCancel = new DevExpress.XtraEditors.SimpleButton();
            this.cmdDesign = new DevExpress.XtraEditors.SimpleButton();
            this.PanelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelTop = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl2)).BeginInit();
            this.GroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSQL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).BeginInit();
            this.GroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtParameters.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSQL)).BeginInit();
            this.panelSQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboReportType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).BeginInit();
            this.PanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReportName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl3)).BeginInit();
            this.PanelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).BeginInit();
            this.PanelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // GroupControl2
            // 
            this.GroupControl2.Controls.Add(this.txtSQL);
            this.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupControl2.Location = new System.Drawing.Point(2, 104);
            this.GroupControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupControl2.Name = "GroupControl2";
            this.GroupControl2.Size = new System.Drawing.Size(713, 312);
            this.GroupControl2.TabIndex = 8;
            this.GroupControl2.Text = "SQL Sorgu";
            // 
            // txtSQL
            // 
            this.txtSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSQL.Location = new System.Drawing.Point(2, 24);
            this.txtSQL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSQL.Properties.Appearance.Options.UseFont = true;
            this.txtSQL.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSQL.Properties.WordWrap = false;
            this.txtSQL.Size = new System.Drawing.Size(709, 286);
            this.txtSQL.TabIndex = 5;
            // 
            // GroupControl1
            // 
            this.GroupControl1.Controls.Add(this.txtParameters);
            this.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupControl1.Location = new System.Drawing.Point(2, 2);
            this.GroupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupControl1.Name = "GroupControl1";
            this.GroupControl1.Size = new System.Drawing.Size(713, 102);
            this.GroupControl1.TabIndex = 7;
            this.GroupControl1.Text = "Parametreler";
            // 
            // txtParameters
            // 
            this.txtParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtParameters.Location = new System.Drawing.Point(2, 24);
            this.txtParameters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtParameters.Name = "txtParameters";
            this.txtParameters.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParameters.Properties.Appearance.Options.UseFont = true;
            this.txtParameters.Properties.ReadOnly = true;
            this.txtParameters.Properties.WordWrap = false;
            this.txtParameters.Size = new System.Drawing.Size(709, 76);
            this.txtParameters.TabIndex = 6;
            // 
            // panelSQL
            // 
            this.panelSQL.Controls.Add(this.GroupControl2);
            this.panelSQL.Controls.Add(this.GroupControl1);
            this.panelSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSQL.Location = new System.Drawing.Point(0, 121);
            this.panelSQL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSQL.Name = "panelSQL";
            this.panelSQL.Size = new System.Drawing.Size(717, 418);
            this.panelSQL.TabIndex = 8;
            // 
            // cboReportType
            // 
            this.cboReportType.EnterMoveNextControl = true;
            this.cboReportType.Location = new System.Drawing.Point(443, 21);
            this.cboReportType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboReportType.Name = "cboReportType";
            this.cboReportType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboReportType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboReportType.Size = new System.Drawing.Size(117, 22);
            this.cboReportType.TabIndex = 1;
            // 
            // LabelControl2
            // 
            this.LabelControl2.Location = new System.Drawing.Point(443, 4);
            this.LabelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(27, 16);
            this.LabelControl2.TabIndex = 1;
            this.LabelControl2.Text = "Turu";
            // 
            // PanelControl1
            // 
            this.PanelControl1.Controls.Add(this.cboReportType);
            this.PanelControl1.Controls.Add(this.LabelControl2);
            this.PanelControl1.Controls.Add(this.txtReportName);
            this.PanelControl1.Controls.Add(this.LabelControl1);
            this.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelControl1.Location = new System.Drawing.Point(2, 2);
            this.PanelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelControl1.Name = "PanelControl1";
            this.PanelControl1.Size = new System.Drawing.Size(713, 55);
            this.PanelControl1.TabIndex = 2;
            // 
            // txtReportName
            // 
            this.txtReportName.EnterMoveNextControl = true;
            this.txtReportName.Location = new System.Drawing.Point(2, 21);
            this.txtReportName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReportName.Name = "txtReportName";
            this.txtReportName.Size = new System.Drawing.Size(434, 22);
            this.txtReportName.TabIndex = 0;
            // 
            // LabelControl1
            // 
            this.LabelControl1.Location = new System.Drawing.Point(7, 2);
            this.LabelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(62, 16);
            this.LabelControl1.TabIndex = 0;
            this.LabelControl1.Text = "Rapor Ismi";
            // 
            // cmdSQL
            // 
            this.cmdSQL.Location = new System.Drawing.Point(105, 7);
            this.cmdSQL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdSQL.Name = "cmdSQL";
            this.cmdSQL.Size = new System.Drawing.Size(63, 36);
            this.cmdSQL.TabIndex = 4;
            this.cmdSQL.Text = "SQL";
            this.cmdSQL.Click += new System.EventHandler(this.cmdSQL_Click);
            // 
            // PanelControl3
            // 
            this.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PanelControl3.Controls.Add(this.cmdSave);
            this.PanelControl3.Controls.Add(this.cmdCancel);
            this.PanelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelControl3.Location = new System.Drawing.Point(505, 2);
            this.PanelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelControl3.Name = "PanelControl3";
            this.PanelControl3.Size = new System.Drawing.Size(206, 58);
            this.PanelControl3.TabIndex = 0;
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(6, 6);
            this.cmdSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(92, 36);
            this.cmdSave.TabIndex = 1;
            this.cmdSave.Text = "Kaydet";
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
            // 
            // cmdDesign
            // 
            this.cmdDesign.Location = new System.Drawing.Point(6, 7);
            this.cmdDesign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdDesign.Name = "cmdDesign";
            this.cmdDesign.Size = new System.Drawing.Size(92, 36);
            this.cmdDesign.TabIndex = 3;
            this.cmdDesign.Text = "Tasarla";
            this.cmdDesign.Click += new System.EventHandler(this.cmdDesign_Click);
            // 
            // PanelControl2
            // 
            this.PanelControl2.Controls.Add(this.cmdSQL);
            this.PanelControl2.Controls.Add(this.PanelControl3);
            this.PanelControl2.Controls.Add(this.cmdDesign);
            this.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControl2.Location = new System.Drawing.Point(2, 57);
            this.PanelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelControl2.Name = "PanelControl2";
            this.PanelControl2.Size = new System.Drawing.Size(713, 62);
            this.PanelControl2.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.PanelControl2);
            this.panelTop.Controls.Add(this.PanelControl1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(717, 121);
            this.panelTop.TabIndex = 7;
            // 
            // frmPrintItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 539);
            this.Controls.Add(this.panelSQL);
            this.Controls.Add(this.panelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrintItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tasarim";
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl2)).EndInit();
            this.GroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSQL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControl1)).EndInit();
            this.GroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtParameters.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelSQL)).EndInit();
            this.panelSQL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboReportType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl1)).EndInit();
            this.PanelControl1.ResumeLayout(false);
            this.PanelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReportName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl3)).EndInit();
            this.PanelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelControl2)).EndInit();
            this.PanelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        internal DevExpress.XtraEditors.GroupControl GroupControl2;
        internal DevExpress.XtraEditors.MemoEdit txtSQL;
        internal DevExpress.XtraEditors.GroupControl GroupControl1;
        internal DevExpress.XtraEditors.MemoEdit txtParameters;
        internal DevExpress.XtraEditors.PanelControl panelSQL;
        internal DevExpress.XtraEditors.ComboBoxEdit cboReportType;
        internal DevExpress.XtraEditors.LabelControl LabelControl2;
        internal DevExpress.XtraEditors.PanelControl PanelControl1;
        internal DevExpress.XtraEditors.TextEdit txtReportName;
        internal DevExpress.XtraEditors.LabelControl LabelControl1;
        internal DevExpress.XtraEditors.SimpleButton cmdSQL;
        internal DevExpress.XtraEditors.PanelControl PanelControl3;
        internal DevExpress.XtraEditors.SimpleButton cmdSave;
        internal DevExpress.XtraEditors.SimpleButton cmdCancel;
        internal DevExpress.XtraEditors.SimpleButton cmdDesign;
        internal DevExpress.XtraEditors.PanelControl PanelControl2;
        internal DevExpress.XtraEditors.PanelControl panelTop;
    }
}