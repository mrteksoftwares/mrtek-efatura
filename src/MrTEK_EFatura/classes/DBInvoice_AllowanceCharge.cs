using System;
using System.Data;
using System.Data.SqlClient;

namespace MrTEK_EFatura
{
	public partial class Invoice_AllowanceCharge
	{
		public SqlTransaction trans;

		public int nID = 0;
		public int InvoiceID = 0;
		public bool ChargeIndicator = false;
		public string AllowanceChargeReason = "";
		public double MultiplierFactorNumeric = 0;
		public double Amount = 0;
		public string Amount_currencyID = "";
		public double BaseAmount = 0;
		public string BaseAmount_currencyID = "";

		public bool Load()
		{
			SqlCommand cmd = new SqlCommand();
			SqlDataAdapter da;
			DataTable dt;
			cmd.Connection = DF.ActiveConn.dbConn;
			cmd.CommandText = "SELECT * FROM Invoice_AllowanceCharge WHERE nID = " + this.nID;
			da = new SqlDataAdapter(cmd);
			dt = new DataTable();
			da.Fill(dt);
			if(dt.Rows.Count>0)
			{
				DataRow dr = dt.Rows[0];
				this.InvoiceID = (int)dr["InvoiceID"];
				this.ChargeIndicator = (bool)dr["ChargeIndicator"];
				this.AllowanceChargeReason = dr["AllowanceChargeReason"].ToString();
				this.MultiplierFactorNumeric = (double)dr["MultiplierFactorNumeric"];
				this.Amount = (double)dr["Amount"];
				this.Amount_currencyID = dr["Amount_currencyID"].ToString();
				this.BaseAmount = (double)dr["BaseAmount"];
				this.BaseAmount_currencyID = dr["BaseAmount_currencyID"].ToString();
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
			cmd.Parameters.Add(new SqlParameter("@ChargeIndicator", this.ChargeIndicator));
			cmd.Parameters.Add(new SqlParameter("@AllowanceChargeReason", this.AllowanceChargeReason.Substring(0,this.AllowanceChargeReason.Length>255?255:this.AllowanceChargeReason.Length )));
			cmd.Parameters.Add(new SqlParameter("@MultiplierFactorNumeric", this.MultiplierFactorNumeric));
			cmd.Parameters.Add(new SqlParameter("@Amount", this.Amount));
			cmd.Parameters.Add(new SqlParameter("@Amount_currencyID", this.Amount_currencyID.Substring(0,this.Amount_currencyID.Length>5?5:this.Amount_currencyID.Length )));
			cmd.Parameters.Add(new SqlParameter("@BaseAmount", this.BaseAmount));
			cmd.Parameters.Add(new SqlParameter("@BaseAmount_currencyID", this.BaseAmount_currencyID.Substring(0,this.BaseAmount_currencyID.Length>5?5:this.BaseAmount_currencyID.Length )));

			if (nID == 0)
			{
				cmd.CommandText = "INSERT INTO Invoice_AllowanceCharge (InvoiceID, ChargeIndicator, AllowanceChargeReason, MultiplierFactorNumeric, Amount, Amount_currencyID, BaseAmount, BaseAmount_currencyID) "; 
				cmd.CommandText += " VALUES (@InvoiceID, @ChargeIndicator, @AllowanceChargeReason, @MultiplierFactorNumeric, @Amount, @Amount_currencyID, @BaseAmount, @BaseAmount_currencyID)"; 
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
				cmd.CommandText = "UPDATE Invoice_AllowanceCharge SET InvoiceID=@InvoiceID, ChargeIndicator=@ChargeIndicator, AllowanceChargeReason=@AllowanceChargeReason, MultiplierFactorNumeric=@MultiplierFactorNumeric, Amount=@Amount, Amount_currencyID=@Amount_currencyID, BaseAmount=@BaseAmount, BaseAmount_currencyID=@BaseAmount_currencyID ";
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


