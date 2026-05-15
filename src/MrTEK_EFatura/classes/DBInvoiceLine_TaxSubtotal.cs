using System;
using System.Data;
using System.Data.SqlClient;

namespace MrTEK_EFatura
{
	public partial class InvoiceLine_TaxSubtotal
	{
		public SqlTransaction trans;

		public int nID = 0;
		public int InvoiceLineID = 0;
		public double TaxableAmount = 0;
		public string currencyID = "";
		public double TaxAmount = 0;
		public double PerUnitAmount = 0;
		public int CalculationSequenceNumeric = 0;
		public double Percent_ = 0;
		public string TaxCategory_TaxScheme_Name = "";
		public string TaxCategory_TaxScheme_TaxTypeCode = "";
		public string TaxCategory_TaxExemptionReason = "";
		public string TaxCategory_TaxExemptionReasonCode = "";

		public bool Load()
		{
			SqlCommand cmd = new SqlCommand();
			SqlDataAdapter da;
			DataTable dt;
			cmd.Connection = DF.ActiveConn.dbConn;
			cmd.CommandText = "SELECT * FROM InvoiceLine_TaxSubtotal WHERE nID = " + this.nID;
			da = new SqlDataAdapter(cmd);
			dt = new DataTable();
			da.Fill(dt);
			if(dt.Rows.Count>0)
			{
				DataRow dr = dt.Rows[0];
				this.InvoiceLineID = (int)dr["InvoiceLineID"];
				this.TaxableAmount = (double)dr["TaxableAmount"];
				this.currencyID = dr["currencyID"].ToString();
				this.TaxAmount = (double)dr["TaxAmount"];
				this.PerUnitAmount = (double)dr["PerUnitAmount"];
				this.CalculationSequenceNumeric = (int)dr["CalculationSequenceNumeric"];
				this.Percent_ = (double)dr["Percent_"];
				this.TaxCategory_TaxScheme_Name = dr["TaxCategory_TaxScheme_Name"].ToString();
				this.TaxCategory_TaxScheme_TaxTypeCode = dr["TaxCategory_TaxScheme_TaxTypeCode"].ToString();
				this.TaxCategory_TaxExemptionReason = dr["TaxCategory_TaxExemptionReason"].ToString();
				this.TaxCategory_TaxExemptionReasonCode = dr["TaxCategory_TaxExemptionReasonCode"].ToString();
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
			cmd.Parameters.Add(new SqlParameter("@TaxableAmount", this.TaxableAmount));
			cmd.Parameters.Add(new SqlParameter("@currencyID", this.currencyID.Substring(0,this.currencyID.Length>5?5:this.currencyID.Length )));
			cmd.Parameters.Add(new SqlParameter("@TaxAmount", this.TaxAmount));
			cmd.Parameters.Add(new SqlParameter("@PerUnitAmount", this.PerUnitAmount));
			cmd.Parameters.Add(new SqlParameter("@CalculationSequenceNumeric", this.CalculationSequenceNumeric));
			cmd.Parameters.Add(new SqlParameter("@Percent_", this.Percent_));
			cmd.Parameters.Add(new SqlParameter("@TaxCategory_TaxScheme_Name", this.TaxCategory_TaxScheme_Name.Substring(0,this.TaxCategory_TaxScheme_Name.Length>255?255:this.TaxCategory_TaxScheme_Name.Length )));
			cmd.Parameters.Add(new SqlParameter("@TaxCategory_TaxScheme_TaxTypeCode", this.TaxCategory_TaxScheme_TaxTypeCode.Substring(0,this.TaxCategory_TaxScheme_TaxTypeCode.Length>15?15:this.TaxCategory_TaxScheme_TaxTypeCode.Length )));
			cmd.Parameters.Add(new SqlParameter("@TaxCategory_TaxExemptionReason", this.TaxCategory_TaxExemptionReason.Substring(0,this.TaxCategory_TaxExemptionReason.Length>255?255:this.TaxCategory_TaxExemptionReason.Length )));
			cmd.Parameters.Add(new SqlParameter("@TaxCategory_TaxExemptionReasonCode", this.TaxCategory_TaxExemptionReasonCode.Substring(0,this.TaxCategory_TaxExemptionReasonCode.Length>50?50:this.TaxCategory_TaxExemptionReasonCode.Length )));

			if (nID == 0)
			{
				cmd.CommandText = "INSERT INTO InvoiceLine_TaxSubtotal (InvoiceLineID, TaxableAmount, currencyID, TaxAmount, PerUnitAmount, CalculationSequenceNumeric, Percent_, TaxCategory_TaxScheme_Name, TaxCategory_TaxScheme_TaxTypeCode, TaxCategory_TaxExemptionReason, TaxCategory_TaxExemptionReasonCode) "; 
				cmd.CommandText += " VALUES (@InvoiceLineID, @TaxableAmount, @currencyID, @TaxAmount, @PerUnitAmount, @CalculationSequenceNumeric, @Percent_, @TaxCategory_TaxScheme_Name, @TaxCategory_TaxScheme_TaxTypeCode, @TaxCategory_TaxExemptionReason, @TaxCategory_TaxExemptionReasonCode)"; 
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
				cmd.CommandText = "UPDATE InvoiceLine_TaxSubtotal SET InvoiceLineID=@InvoiceLineID, TaxableAmount=@TaxableAmount, currencyID=@currencyID, TaxAmount=@TaxAmount, PerUnitAmount=@PerUnitAmount, CalculationSequenceNumeric=@CalculationSequenceNumeric, Percent_=@Percent_, TaxCategory_TaxScheme_Name=@TaxCategory_TaxScheme_Name, TaxCategory_TaxScheme_TaxTypeCode=@TaxCategory_TaxScheme_TaxTypeCode, TaxCategory_TaxExemptionReason=@TaxCategory_TaxExemptionReason, TaxCategory_TaxExemptionReasonCode=@TaxCategory_TaxExemptionReasonCode ";
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


