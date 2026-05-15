using System;
using System.Data;
using System.Data.SqlClient;

namespace MrTEK_EFatura
{
	public partial class Invoice_Log
	{
		public SqlTransaction trans;

		public int LogID = 0;
		public int InvoiceID = 0;
		public string Message = "";

		public bool Load()
		{
			SqlCommand cmd = new SqlCommand();
			SqlDataAdapter da;
			DataTable dt;
			cmd.Connection = DF.ActiveConn.dbConn;
			cmd.CommandText = "SELECT * FROM Invoice_Log WHERE LogID = " + this.LogID;
			da = new SqlDataAdapter(cmd);
			dt = new DataTable();
			da.Fill(dt);
			if(dt.Rows.Count>0)
			{
				DataRow dr = dt.Rows[0];
				this.InvoiceID = (int)dr["InvoiceID"];
				this.Message = dr["Message"].ToString();
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
			cmd.Parameters.Add(new SqlParameter("@LogID", this.LogID));
			cmd.Parameters.Add(new SqlParameter("@InvoiceID", this.InvoiceID));
			cmd.Parameters.Add(new SqlParameter("@Message", this.Message.Substring(0,this.Message.Length>3000?3000:this.Message.Length )));

			if (LogID == 0)
			{
				cmd.CommandText = "INSERT INTO Invoice_Log (InvoiceID, Message) "; 
				cmd.CommandText += " VALUES (@InvoiceID, @Message)"; 
				cmd.CommandText += " SELECT SCOPE_IDENTITY()"; 
				this.LogID = (int)UT.If0Null(cmd.ExecuteScalar());
				if(this.LogID>0)
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
				cmd.CommandText = "UPDATE Invoice_Log SET InvoiceID=@InvoiceID, Message=@Message ";
				cmd.CommandText += "WHERE LogID = " + this.LogID;
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


