namespace MrTEK_EFatura
{
    partial class frmItems
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItem_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItem_Description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGTIPNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand3 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand4 = new System.Data.SqlClient.SqlCommand();
            this.MasterTable_ItemID = new System.Data.DataColumn();
            this.MasterTable_Item_Name = new System.Data.DataColumn();
            this.MasterTable_Item_Description = new System.Data.DataColumn();
            this.MasterTable_GTIPNO = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MasterTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBaseBottom)).BeginInit();
            this.panelBaseBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelBaseBottomRight)).BeginInit();
            this.panelBaseBottomRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FirmConn
            // 
            this.FirmConn.ConnectionString = "Server=(local)\\SQL2008;Database=MrTEK_EFatura;User ID=sa;Password=;Trusted_Connec" +
    "tion=True;";
            // 
            // MasterTable
            // 
            this.MasterTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.MasterTable_ItemID,
            this.MasterTable_Item_Name,
            this.MasterTable_Item_Description,
            this.MasterTable_GTIPNO});
            this.MasterTable.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "ItemID"}, true)});
            this.MasterTable.DataSourceLink = this.MasterLink;
            this.MasterTable.DeleteCommand = this.sqlCommand4;
            this.MasterTable.InsertCommand = this.sqlCommand2;
            this.MasterTable.PrimaryKey = new System.Data.DataColumn[] {
        this.MasterTable_ItemID};
            this.MasterTable.SelectCommand = this.sqlCommand1;
            this.MasterTable.UpdateCommand = this.sqlCommand3;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Visible = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Visible = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.MasterTable;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(698, 429);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemID,
            this.colItem_Name,
            this.colItem_Description,
            this.colGTIPNO});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsLayout.LayoutVersion = "1.1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colItemID
            // 
            this.colItemID.FieldName = "ItemID";
            this.colItemID.Name = "colItemID";
            // 
            // colItem_Name
            // 
            this.colItem_Name.FieldName = "Item_Name";
            this.colItem_Name.Name = "colItem_Name";
            this.colItem_Name.Visible = true;
            this.colItem_Name.VisibleIndex = 0;
            this.colItem_Name.Width = 239;
            // 
            // colItem_Description
            // 
            this.colItem_Description.FieldName = "Item_Description";
            this.colItem_Description.Name = "colItem_Description";
            this.colItem_Description.Visible = true;
            this.colItem_Description.VisibleIndex = 1;
            this.colItem_Description.Width = 219;
            // 
            // colGTIPNO
            // 
            this.colGTIPNO.FieldName = "GTIPNO";
            this.colGTIPNO.Name = "colGTIPNO";
            this.colGTIPNO.Visible = true;
            this.colGTIPNO.VisibleIndex = 2;
            this.colGTIPNO.Width = 222;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandText = "SELECT * FROM Items WHERE 1=1\r\n";
            // 
            // sqlCommand2
            // 
            this.sqlCommand2.CommandText = "INSERT INTO Items (\r\nItem_Name , Item_Description , GTIPNO)\r\n VALUES (\r\n@Item_Nam" +
    "e , @Item_Description , @GTIPNO)\r\nSELECT @PRIMARYFIELD_ItemID = SCOPE_IDENTITY()" +
    " \r\n";
            // 
            // sqlCommand3
            // 
            this.sqlCommand3.CommandText = "UPDATE Items SET \r\nItem_Name = @Item_Name , Item_Description = @Item_Description " +
    ", GTIPNO = @GTIPNO\r\nWHERE ItemID = @ItemID";
            // 
            // sqlCommand4
            // 
            this.sqlCommand4.CommandText = "DELETE FROM Items WHERE ItemID = @ItemID";
            // 
            // MasterTable_ItemID
            // 
            this.MasterTable_ItemID.AllowDBNull = false;
            this.MasterTable_ItemID.AutoIncrement = true;
            this.MasterTable_ItemID.ColumnName = "ItemID";
            this.MasterTable_ItemID.DataType = typeof(int);
            // 
            // MasterTable_Item_Name
            // 
            this.MasterTable_Item_Name.ColumnName = "Item_Name";
            // 
            // MasterTable_Item_Description
            // 
            this.MasterTable_Item_Description.ColumnName = "Item_Description";
            // 
            // MasterTable_GTIPNO
            // 
            this.MasterTable_GTIPNO.ColumnName = "GTIPNO";
            // 
            // frmItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(698, 472);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmItems";
            this.Text = "Items";
            this.Load += new System.EventHandler(this.frmItems_Load);
            this.Controls.SetChildIndex(this.panelBaseBottom, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.MasterTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBaseBottom)).EndInit();
            this.panelBaseBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelBaseBottomRight)).EndInit();
            this.panelBaseBottomRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataColumn MasterTable_ItemID;
        private System.Data.DataColumn MasterTable_Item_Name;
        private System.Data.DataColumn MasterTable_Item_Description;
        private System.Data.DataColumn MasterTable_GTIPNO;
        private System.Data.SqlClient.SqlCommand sqlCommand4;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Data.SqlClient.SqlCommand sqlCommand3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colItemID;
        private DevExpress.XtraGrid.Columns.GridColumn colItem_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colItem_Description;
        private DevExpress.XtraGrid.Columns.GridColumn colGTIPNO;
    }
}
