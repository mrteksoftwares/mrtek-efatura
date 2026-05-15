using System;
using System.Data;
using System.Data.SqlClient;

namespace MrTEK_EFatura
{
	public partial class Invoice_ReceiptDocumentReference
	{
		public SqlTransaction trans;

		public int nID = 0;
		public int InvoiceID = 0;
		public string ID = "";
		public DateTime IssueDate = new DateTime(1900,1,1);

		public bool Load()
		{
			SqlCommand cmd = new SqlCommand();
			SqlDataAdapter da;
			DataTable dt;
			cmd.Connection = DF.ActiveConn.dbConn;
			cmd.CommandText = "SELECT * FROM Invoice_ReceiptDocumentReference WHERE nID = " + this.nID;
			da = new SqlDataAdapter(cmd);
			dt = new DataTable();
			da.Fill(dt);
			if(dt.Rows.Count>0)
			{
				DataRow dr = dt.Rows[0];
				this.InvoiceID = (int)dr["InvoiceID"];
				this.ID = dr["ID"].ToString();
				this.IssueDate = (DateTime)dr["IssueDate"];
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
			cmd.Parameters.Add(new SqlParameter("@InvoiceID", this.InvoiceID));
			cmd.Parameters.Add(new SqlParameter("@ID", this.ID.Substring(0,this.ID.Length>50?50:this.ID.Length )));
			cmd.Parameters.Add(new SqlParameter("@IssueDate", this.IssueDate));

			if (nID == 0)
			{
				cmd.CommandText = "INSERT INTO Invoice_ReceiptDocumentReference (InvoiceID, ID, IssueDate) "; 
				cmd.CommandText += " VALUES (@InvoiceID, @ID, @IssueDate)"; 
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
				cmd.CommandText = "UPDATE Invoice_ReceiptDocumentReference SET InvoiceID=@InvoiceID, ID=@ID, IssueDate=@IssueDate ";
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


