using System;
using System.Data;
using System.Data.SqlClient;

namespace MrTEK_EFatura
{
	public partial class InvoiceLine
	{
		public SqlTransaction trans;

		public int InvoiceLineID = 0;
		public int InvoiceID = 0;
		public string ID = "";
		public string Note = "";
		public double InvoicedQuantity = 0;
		public string InvoicedQuantity_unitCode = "";
		public double LineExtensionAmount = 0;
		public string currencyID = "";
		public bool AllowanceCharge_ChargeIndicator = false;
		public string AllowanceCharge_AllowanceChargeReason = "";
		public double AllowanceCharge_Amount = 0;
		public double AllowanceCharge_BaseAmount = 0;
		public double AllowanceCharge_MultiplierFactorNumeric = 0;
		public string Item_Name = "";
		public string Item_Description = "";
		public string Item_BrandName = "";
		public string Item_ModelName = "";
		public string Item_ItemClassificationCode = "";
		public string Item_BuyersItemIdentification_ID = "";
		public string Item_SellersItemIdentification_ID = "";
		public string Item_ManufacturersItemIdentification_ID = "";
		public double PriceAmount = 0;
		public double TaxAmount = 0;
		public double WithholdingTaxAmount = 0;
		public string GTIPNO = "";
		public string TransportModeCode = "";
		public string DeliveryTerms = "";

		public bool Load()
		{
			SqlCommand cmd = new SqlCommand();
			SqlDataAdapter da;
			DataTable dt;
			cmd.Connection = DF.ActiveConn.dbConn;
			cmd.CommandText = "SELECT * FROM InvoiceLine WHERE InvoiceLineID = " + this.InvoiceLineID.ToString();
			da = new SqlDataAdapter(cmd);
			dt = new DataTable();
			da.Fill(dt);
			if(dt.Rows.Count>0)
			{
				DataRow dr = dt.Rows[0];
				this.InvoiceID = (int)dr["InvoiceID"];
				this.ID = dr["ID"].ToString();
				this.Note = dr["Note"].ToString();
				this.InvoicedQuantity = (double)dr["InvoicedQuantity"];
				this.InvoicedQuantity_unitCode = dr["InvoicedQuantity_unitCode"].ToString();
				this.LineExtensionAmount = (double)dr["LineExtensionAmount"];
				this.currencyID = dr["currencyID"].ToString();
				this.AllowanceCharge_ChargeIndicator = (bool)dr["AllowanceCharge_ChargeIndicator"];
				this.AllowanceCharge_AllowanceChargeReason = dr["AllowanceCharge_AllowanceChargeReason"].ToString();
				this.AllowanceCharge_Amount = (double)dr["AllowanceCharge_Amount"];
				this.AllowanceCharge_BaseAmount = (double)dr["AllowanceCharge_BaseAmount"];
				this.AllowanceCharge_MultiplierFactorNumeric = (double)dr["AllowanceCharge_MultiplierFactorNumeric"];
				this.Item_Name = dr["Item_Name"].ToString();
				this.Item_Description = dr["Item_Description"].ToString();
				this.Item_BrandName = dr["Item_BrandName"].ToString();
				this.Item_ModelName = dr["Item_ModelName"].ToString();
				this.Item_ItemClassificationCode = dr["Item_ItemClassificationCode"].ToString();
				this.Item_BuyersItemIdentification_ID = dr["Item_BuyersItemIdentification_ID"].ToString();
				this.Item_SellersItemIdentification_ID = dr["Item_SellersItemIdentification_ID"].ToString();
				this.Item_ManufacturersItemIdentification_ID = dr["Item_ManufacturersItemIdentification_ID"].ToString();
				this.PriceAmount = (double)dr["PriceAmount"];
				this.TaxAmount = (double)dr["TaxAmount"];
				this.WithholdingTaxAmount = (double)dr["WithholdingTaxAmount"];
				this.GTIPNO = dr["GTIPNO"].ToString();
				this.TransportModeCode = dr["TransportModeCode"].ToString();
				this.DeliveryTerms = dr["DeliveryTerms"].ToString();
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
			cmd.Parameters.Add(new SqlParameter("@InvoiceLineID", this.InvoiceLineID));
			cmd.Parameters.Add(new SqlParameter("@InvoiceID", this.InvoiceID));
			cmd.Parameters.Add(new SqlParameter("@ID", this.ID.Substring(0,this.ID.Length>50?50:this.ID.Length )));
			cmd.Parameters.Add(new SqlParameter("@Note", this.Note.Substring(0,this.Note.Length>255?255:this.Note.Length )));
			cmd.Parameters.Add(new SqlParameter("@InvoicedQuantity", this.InvoicedQuantity));
			cmd.Parameters.Add(new SqlParameter("@InvoicedQuantity_unitCode", this.InvoicedQuantity_unitCode.Substring(0,this.InvoicedQuantity_unitCode.Length>5?5:this.InvoicedQuantity_unitCode.Length )));
			cmd.Parameters.Add(new SqlParameter("@LineExtensionAmount", this.LineExtensionAmount));
			cmd.Parameters.Add(new SqlParameter("@currencyID", this.currencyID.Substring(0,this.currencyID.Length>5?5:this.currencyID.Length )));
			cmd.Parameters.Add(new SqlParameter("@AllowanceCharge_ChargeIndicator", this.AllowanceCharge_ChargeIndicator));
			cmd.Parameters.Add(new SqlParameter("@AllowanceCharge_AllowanceChargeReason", this.AllowanceCharge_AllowanceChargeReason.Substring(0,this.AllowanceCharge_AllowanceChargeReason.Length>255?255:this.AllowanceCharge_AllowanceChargeReason.Length )));
			cmd.Parameters.Add(new SqlParameter("@AllowanceCharge_Amount", this.AllowanceCharge_Amount));
			cmd.Parameters.Add(new SqlParameter("@AllowanceCharge_BaseAmount", this.AllowanceCharge_BaseAmount));
			cmd.Parameters.Add(new SqlParameter("@AllowanceCharge_MultiplierFactorNumeric", this.AllowanceCharge_MultiplierFactorNumeric));
			cmd.Parameters.Add(new SqlParameter("@Item_Name", this.Item_Name.Substring(0,this.Item_Name.Length>255?255:this.Item_Name.Length )));
			cmd.Parameters.Add(new SqlParameter("@Item_Description", this.Item_Description.Substring(0,this.Item_Description.Length>255?255:this.Item_Description.Length )));
			cmd.Parameters.Add(new SqlParameter("@Item_BrandName", this.Item_BrandName.Substring(0,this.Item_BrandName.Length>255?255:this.Item_BrandName.Length )));
			cmd.Parameters.Add(new SqlParameter("@Item_ModelName", this.Item_ModelName.Substring(0,this.Item_ModelName.Length>255?255:this.Item_ModelName.Length )));
			cmd.Parameters.Add(new SqlParameter("@Item_ItemClassificationCode", this.Item_ItemClassificationCode.Substring(0,this.Item_ItemClassificationCode.Length>255?255:this.Item_ItemClassificationCode.Length )));
			cmd.Parameters.Add(new SqlParameter("@Item_BuyersItemIdentification_ID", this.Item_BuyersItemIdentification_ID.Substring(0,this.Item_BuyersItemIdentification_ID.Length>255?255:this.Item_BuyersItemIdentification_ID.Length )));
			cmd.Parameters.Add(new SqlParameter("@Item_SellersItemIdentification_ID", this.Item_SellersItemIdentification_ID.Substring(0,this.Item_SellersItemIdentification_ID.Length>255?255:this.Item_SellersItemIdentification_ID.Length )));
			cmd.Parameters.Add(new SqlParameter("@Item_ManufacturersItemIdentification_ID", this.Item_ManufacturersItemIdentification_ID.Substring(0,this.Item_ManufacturersItemIdentification_ID.Length>255?255:this.Item_ManufacturersItemIdentification_ID.Length )));
			cmd.Parameters.Add(new SqlParameter("@PriceAmount", this.PriceAmount));
			cmd.Parameters.Add(new SqlParameter("@TaxAmount", this.TaxAmount));
			cmd.Parameters.Add(new SqlParameter("@WithholdingTaxAmount", this.WithholdingTaxAmount));
			cmd.Parameters.Add(new SqlParameter("@GTIPNO", this.GTIPNO.Substring(0,this.GTIPNO.Length>50?50:this.GTIPNO.Length )));
			cmd.Parameters.Add(new SqlParameter("@TransportModeCode", this.TransportModeCode.Substring(0,this.TransportModeCode.Length>10?10:this.TransportModeCode.Length )));
			cmd.Parameters.Add(new SqlParameter("@DeliveryTerms", this.DeliveryTerms.Substring(0,this.DeliveryTerms.Length>10?10:this.DeliveryTerms.Length )));

			if (InvoiceLineID == 0)
			{
				cmd.CommandText = "INSERT INTO InvoiceLine (InvoiceID, ID, Note, InvoicedQuantity, InvoicedQuantity_unitCode, LineExtensionAmount, currencyID, AllowanceCharge_ChargeIndicator, AllowanceCharge_AllowanceChargeReason, AllowanceCharge_Amount, AllowanceCharge_BaseAmount, AllowanceCharge_MultiplierFactorNumeric, Item_Name, Item_Description, Item_BrandName, Item_ModelName, Item_ItemClassificationCode, Item_BuyersItemIdentification_ID, Item_SellersItemIdentification_ID, Item_ManufacturersItemIdentification_ID, PriceAmount, TaxAmount, WithholdingTaxAmount, GTIPNO, TransportModeCode, DeliveryTerms) "; 
				cmd.CommandText += " VALUES (@InvoiceID, @ID, @Note, @InvoicedQuantity, @InvoicedQuantity_unitCode, @LineExtensionAmount, @currencyID, @AllowanceCharge_ChargeIndicator, @AllowanceCharge_AllowanceChargeReason, @AllowanceCharge_Amount, @AllowanceCharge_BaseAmount, @AllowanceCharge_MultiplierFactorNumeric, @Item_Name, @Item_Description, @Item_BrandName, @Item_ModelName, @Item_ItemClassificationCode, @Item_BuyersItemIdentification_ID, @Item_SellersItemIdentification_ID, @Item_ManufacturersItemIdentification_ID, @PriceAmount, @TaxAmount, @WithholdingTaxAmount, @GTIPNO, @TransportModeCode, @DeliveryTerms)"; 
				cmd.CommandText += " SELECT SCOPE_IDENTITY()"; 
				this.InvoiceLineID = (int)UT.If0Null(cmd.ExecuteScalar());
				if(this.InvoiceLineID>0)
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
				cmd.CommandText = "UPDATE InvoiceLine SET InvoiceID=@InvoiceID, ID=@ID, Note=@Note, InvoicedQuantity=@InvoicedQuantity, InvoicedQuantity_unitCode=@InvoicedQuantity_unitCode, LineExtensionAmount=@LineExtensionAmount, currencyID=@currencyID, AllowanceCharge_ChargeIndicator=@AllowanceCharge_ChargeIndicator, AllowanceCharge_AllowanceChargeReason=@AllowanceCharge_AllowanceChargeReason, AllowanceCharge_Amount=@AllowanceCharge_Amount, AllowanceCharge_BaseAmount=@AllowanceCharge_BaseAmount, AllowanceCharge_MultiplierFactorNumeric=@AllowanceCharge_MultiplierFactorNumeric, Item_Name=@Item_Name, Item_Description=@Item_Description, Item_BrandName=@Item_BrandName, Item_ModelName=@Item_ModelName, Item_ItemClassificationCode=@Item_ItemClassificationCode, Item_BuyersItemIdentification_ID=@Item_BuyersItemIdentification_ID, Item_SellersItemIdentification_ID=@Item_SellersItemIdentification_ID, Item_ManufacturersItemIdentification_ID=@Item_ManufacturersItemIdentification_ID, PriceAmount=@PriceAmount, TaxAmount=@TaxAmount, WithholdingTaxAmount=@WithholdingTaxAmount, GTIPNO=@GTIPNO, TransportModeCode=@TransportModeCode, DeliveryTerms=@DeliveryTerms ";
				cmd.CommandText += "WHERE InvoiceLineID = " + this.InvoiceLineID;
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


