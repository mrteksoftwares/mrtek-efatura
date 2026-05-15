using System;
using System.Data;
using System.Data.SqlClient;

namespace MrTEK_EFatura
{
	public partial class Invoice_BillingReference
	{
		public SqlTransaction trans;

		public int nID = 0;
		public int InvoiceID = 0;
		public string ID = "";
		public DateTime IssueDate = DateTime.MinValue;
		public string DocumentTypeCode = "";
		public string DocumentType = "";

		public bool Load()
		{
			SqlCommand cmd = new SqlCommand();
			SqlDataAdapter da;
			DataTable dt;
			cmd.Connection = DF.ActiveConn.dbConn;
			cmd.CommandText = "SELECT * FROM Invoice_BillingReference WHERE nID = " + this.nID;
			da = new SqlDataAdapter(cmd);
			dt = new DataTable();
			da.Fill(dt);
			if(dt.Rows.Count>0)
			{
				DataRow dr = dt.Rows[0];
				this.InvoiceID = (int)dr["InvoiceID"];
				this.ID = dr["ID"].ToString();
				this.IssueDate = dr["IssueDate"].ToDateTime();
				this.DocumentTypeCode = dr["DocumentTypeCode"].ToString();
				this.DocumentType = dr["DocumentType"].ToString();
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
			cmd.Parameters.Add(new SqlParameter("@DocumentTypeCode", this.DocumentTypeCode.Substring(0,this.DocumentTypeCode.Length>50?50:this.DocumentTypeCode.Length )));
			cmd.Parameters.Add(new SqlParameter("@DocumentType", this.DocumentType.Substring(0,this.DocumentType.Length>50?50:this.DocumentType.Length )));

			if (nID == 0)
			{
				cmd.CommandText = "INSERT INTO Invoice_BillingReference (InvoiceID, ID, IssueDate, DocumentTypeCode, DocumentType) "; 
				cmd.CommandText += " VALUES (@InvoiceID, @ID, @IssueDate, @DocumentTypeCode, @DocumentType)"; 
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
				cmd.CommandText = "UPDATE Invoice_BillingReference SET InvoiceID=@InvoiceID, ID=@ID, IssueDate=@IssueDate, DocumentTypeCode=@DocumentTypeCode, DocumentType=@DocumentType ";
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


