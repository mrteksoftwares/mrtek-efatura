using System;
using System.Data;
using System.Data.SqlClient;

namespace MrTEK_EFatura
{
	public partial class Invoice_PaymentTerms
	{
		public SqlTransaction trans;

		public int nID = 0;
		public int InvoiceID = 0;
		public string Note = "";
		public double PenaltySurchargePercent = 0;
		public double Amount = 0;
		public string Amount_currencyID = "";

		public bool Load()
		{
			SqlCommand cmd = new SqlCommand();
			SqlDataAdapter da;
			DataTable dt;
			cmd.Connection = DF.ActiveConn.dbConn;
			cmd.CommandText = "SELECT * FROM Invoice_PaymentTerms WHERE nID = " + this.nID;
			da = new SqlDataAdapter(cmd);
			dt = new DataTable();
			da.Fill(dt);
			if(dt.Rows.Count>0)
			{
				DataRow dr = dt.Rows[0];
				this.InvoiceID = (int)dr["InvoiceID"];
				this.Note = dr["Note"].ToString();
				this.PenaltySurchargePercent = (double)dr["PenaltySurchargePercent"];
				this.Amount = (double)dr["Amount"];
				this.Amount_currencyID = dr["Amount_currencyID"].ToString();
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
			cmd.Parameters.Add(new SqlParameter("@Note", this.Note.Substring(0,this.Note.Length>500?500:this.Note.Length )));
			cmd.Parameters.Add(new SqlParameter("@PenaltySurchargePercent", this.PenaltySurchargePercent));
			cmd.Parameters.Add(new SqlParameter("@Amount", this.Amount));
			cmd.Parameters.Add(new SqlParameter("@Amount_currencyID", this.Amount_currencyID.Substring(0,this.Amount_currencyID.Length>5?5:this.Amount_currencyID.Length )));

			if (nID == 0)
			{
				cmd.CommandText = "INSERT INTO Invoice_PaymentTerms (InvoiceID, Note, PenaltySurchargePercent, Amount, Amount_currencyID) "; 
				cmd.CommandText += " VALUES (@InvoiceID, @Note, @PenaltySurchargePercent, @Amount, @Amount_currencyID)"; 
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
				cmd.CommandText = "UPDATE Invoice_PaymentTerms SET InvoiceID=@InvoiceID, Note=@Note, PenaltySurchargePercent=@PenaltySurchargePercent, Amount=@Amount, Amount_currencyID=@Amount_currencyID ";
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


