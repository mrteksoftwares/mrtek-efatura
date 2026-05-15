using System;
using System.Data;
using System.Data.SqlClient;

namespace MrTEK_EFatura
{
	public partial class Invoice_PaymentMeans
	{
		public SqlTransaction trans;

		public int nID = 0;
		public int InvoiceID = 0;
		public string PaymentMeansCode = "";
		public DateTime PaymentDueDate = new DateTime(1900,1,1);
		public string PaymentChannelCode = "";
		public string InstructionNote = "";
		public string PayeeFinancialAccount_ID = "";
		public string PayeeFinancialAccount_CurrencyCode = "";
		public string PayeeFinancialAccount_PaymentNote = "";

		public bool Load()
		{
			SqlCommand cmd = new SqlCommand();
			SqlDataAdapter da;
			DataTable dt;
			cmd.Connection = DF.ActiveConn.dbConn;
			cmd.CommandText = "SELECT * FROM Invoice_PaymentMeans WHERE nID = " + this.nID;
			da = new SqlDataAdapter(cmd);
			dt = new DataTable();
			da.Fill(dt);
			if(dt.Rows.Count>0)
			{
				DataRow dr = dt.Rows[0];
				this.InvoiceID = (int)dr["InvoiceID"];
				this.PaymentMeansCode = dr["PaymentMeansCode"].ToString();
				this.PaymentDueDate = (DateTime)dr["PaymentDueDate"];
				this.PaymentChannelCode = dr["PaymentChannelCode"].ToString();
				this.InstructionNote = dr["InstructionNote"].ToString();
				this.PayeeFinancialAccount_ID = dr["PayeeFinancialAccount_ID"].ToString();
				this.PayeeFinancialAccount_CurrencyCode = dr["PayeeFinancialAccount_CurrencyCode"].ToString();
				this.PayeeFinancialAccount_PaymentNote = dr["PayeeFinancialAccount_PaymentNote"].ToString();
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
			cmd.Parameters.Add(new SqlParameter("@PaymentMeansCode", this.PaymentMeansCode.Substring(0,this.PaymentMeansCode.Length>50?50:this.PaymentMeansCode.Length )));
			cmd.Parameters.Add(new SqlParameter("@PaymentDueDate", this.PaymentDueDate));
			cmd.Parameters.Add(new SqlParameter("@PaymentChannelCode", this.PaymentChannelCode.Substring(0,this.PaymentChannelCode.Length>50?50:this.PaymentChannelCode.Length )));
			cmd.Parameters.Add(new SqlParameter("@InstructionNote", this.InstructionNote.Substring(0,this.InstructionNote.Length>255?255:this.InstructionNote.Length )));
			cmd.Parameters.Add(new SqlParameter("@PayeeFinancialAccount_ID", this.PayeeFinancialAccount_ID.Substring(0,this.PayeeFinancialAccount_ID.Length>50?50:this.PayeeFinancialAccount_ID.Length )));
			cmd.Parameters.Add(new SqlParameter("@PayeeFinancialAccount_CurrencyCode", this.PayeeFinancialAccount_CurrencyCode.Substring(0,this.PayeeFinancialAccount_CurrencyCode.Length>5?5:this.PayeeFinancialAccount_CurrencyCode.Length )));
			cmd.Parameters.Add(new SqlParameter("@PayeeFinancialAccount_PaymentNote", this.PayeeFinancialAccount_PaymentNote.Substring(0,this.PayeeFinancialAccount_PaymentNote.Length>255?255:this.PayeeFinancialAccount_PaymentNote.Length )));

			if (nID == 0)
			{
				cmd.CommandText = "INSERT INTO Invoice_PaymentMeans (InvoiceID, PaymentMeansCode, PaymentDueDate, PaymentChannelCode, InstructionNote, PayeeFinancialAccount_ID, PayeeFinancialAccount_CurrencyCode, PayeeFinancialAccount_PaymentNote) "; 
				cmd.CommandText += " VALUES (@InvoiceID, @PaymentMeansCode, @PaymentDueDate, @PaymentChannelCode, @InstructionNote, @PayeeFinancialAccount_ID, @PayeeFinancialAccount_CurrencyCode, @PayeeFinancialAccount_PaymentNote)"; 
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
				cmd.CommandText = "UPDATE Invoice_PaymentMeans SET InvoiceID=@InvoiceID, PaymentMeansCode=@PaymentMeansCode, PaymentDueDate=@PaymentDueDate, PaymentChannelCode=@PaymentChannelCode, InstructionNote=@InstructionNote, PayeeFinancialAccount_ID=@PayeeFinancialAccount_ID, PayeeFinancialAccount_CurrencyCode=@PayeeFinancialAccount_CurrencyCode, PayeeFinancialAccount_PaymentNote=@PayeeFinancialAccount_PaymentNote ";
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


