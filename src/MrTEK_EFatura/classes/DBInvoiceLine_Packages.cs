using System;
using System.Data;
using System.Data.SqlClient;

namespace MrTEK_EFatura
{
	public partial class InvoiceLine_Packages
	{
		public SqlTransaction trans;

		public int nID = 0;
		public int InvoiceLineID = 0;
		public string ID = "";
		public double Quantity = 0;
		public string PackagingTypeCode = "";

		public bool Load()
		{
			SqlCommand cmd = new SqlCommand();
			SqlDataAdapter da;
			DataTable dt;
			cmd.Connection = DF.ActiveConn.dbConn;
			cmd.CommandText = "SELECT * FROM InvoiceLine_Packages WHERE nID = " + this.nID.ToString();
			da = new SqlDataAdapter(cmd);
			dt = new DataTable();
			da.Fill(dt);
			if(dt.Rows.Count>0)
			{
				DataRow dr = dt.Rows[0];
				this.InvoiceLineID = (int)dr["InvoiceLineID"];
				this.ID = dr["ID"].ToString();
				this.Quantity = (double)dr["Quantity"];
				this.PackagingTypeCode = dr["PackagingTypeCode"].ToString();
				return true;
			}else{
				return false;
			}
		}

		public bool Save()
		{
			SqlCommand cmd = new SqlCommand();
			SqlDataAdapter da;
			System.Data.DataTable dt;
			cmd.Connection = DF.ActiveConn.dbConn;
			if (this.trans != null) cmd.Transaction = trans;
			cmd.Parameters.Clear();
			cmd.Parameters.Add(new SqlParameter("@nID", this.nID));
			cmd.Parameters.Add(new SqlParameter("@InvoiceLineID", this.InvoiceLineID));
			cmd.Parameters.Add(new SqlParameter("@ID", this.ID.Substring(0,this.ID.Length>50?50:this.ID.Length )));
			cmd.Parameters.Add(new SqlParameter("@Quantity", this.Quantity));
			cmd.Parameters.Add(new SqlParameter("@PackagingTypeCode", this.PackagingTypeCode.Substring(0,this.PackagingTypeCode.Length>50?50:this.PackagingTypeCode.Length )));

			if (nID == 0)
			{
				cmd.CommandText = "INSERT INTO InvoiceLine_Packages (InvoiceLineID, ID, Quantity, PackagingTypeCode) "; 
				cmd.CommandText += " VALUES (@InvoiceLineID, @ID, @Quantity, @PackagingTypeCode)"; 
				cmd.CommandText += " SELECT SCOPE_IDENTITY()"; 
				this.nID = (int)UT.If0Null(cmd.ExecuteScalar());
				if(this.nID>0)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				cmd.CommandText = "UPDATE InvoiceLine_Packages SET InvoiceLineID=@InvoiceLineID, ID=@ID, Quantity=@Quantity, PackagingTypeCode=@PackagingTypeCode ";
				cmd.CommandText += "WHERE nID = " + this.nID;
				if(cmd.ExecuteNonQuery()>0)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}
	}
}


