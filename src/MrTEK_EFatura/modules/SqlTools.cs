using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MrTEK_EFatura
{
    static class SQ
    {
        //public string Name { get {return "SQ";}}



        public static void createDBFunction_fnOnlyNumber(SqlConnection conn)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.Parameters.Clear();
                cmd.Parameters.Add(new SqlParameter("@strAlphaNumeric", ""));
                cmd.CommandText = "SET ANSI_NULLS ON";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT COUNT(*) FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnOnlyNumber]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT')";
                if ((int)cmd.ExecuteScalar() > 0)
                {
                    return;
                }

                cmd.CommandText = "CREATE FUNCTION [dbo].[fnOnlyNumber] ( @strAlphaNumeric nVARCHAR(50) )  " + Environment.NewLine +
                    " RETURNS nVARCHAR(50)  AS  " + Environment.NewLine +
                    " BEGIN " + Environment.NewLine +
                    " DECLARE @intAlpha INT " + Environment.NewLine +
                    " SET @intAlpha = PATINDEX('%[^0-9]%', @strAlphaNumeric) " + Environment.NewLine +
                    " BEGIN " + Environment.NewLine +
                    " WHILE @intAlpha > 0 " + Environment.NewLine +
                    " BEGIN " + Environment.NewLine +
                    " SET @strAlphaNumeric = STUFF(@strAlphaNumeric, @intAlpha, 1, '' )  " + Environment.NewLine +
                    " SET @intAlpha = PATINDEX('%[^0-9]%', @strAlphaNumeric ) " + Environment.NewLine +
                    " END  " + Environment.NewLine +
                    " END  " + Environment.NewLine +
                    " RETURN ISNULL(@strAlphaNumeric,0)  " + Environment.NewLine +
                    " END  " + Environment.NewLine +
                    " ";
                cmd.ExecuteNonQuery();

            }
            catch (System.Exception ex)
            {
                UT.RaiseError("SQ", "", ex);
            }
        }

        public static string getUserName(int UserID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlDataAdapter da;
                DataTable dt;
                cmd.Connection = DF.ActiveConn.dbConn;
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT * FROM Users WHERE UserID=" + UserID.ToString();
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return UT.IfNull(dt.Rows[0]["UserName"], "").ToString();

                }


            }
            catch (System.Exception ex)
            {
                UT.RaiseError("SQ", "getUserName", ex);
            }
            return "";
        }

        public static DataTable getPackagingTypeCode()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ID", typeof(string)));
            dt.Columns.Add(new DataColumn("Name", typeof(string)));


            DataRow dr;

            dr = dt.NewRow(); dr["ID"] = "1A"; dr["Name"] = "1A - Drum, steel"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "1B"; dr["Name"] = "1B - Drum, aluminium"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "1D"; dr["Name"] = "1D - Drum, plywood"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "1F"; dr["Name"] = "1F - Container, flexible"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "1G"; dr["Name"] = "1G - Drum, fibre"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "1W"; dr["Name"] = "1W - Drum, wooden"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "2C"; dr["Name"] = "2C - Barrel, wooden"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "3A"; dr["Name"] = "3A - Jerrican, steel"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "3H"; dr["Name"] = "3H - Jerrican, plastic"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "43"; dr["Name"] = "43 - Bag, super bulk"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "44"; dr["Name"] = "44 - Bag, polybag"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "4A"; dr["Name"] = "4A - Box, steel"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "4B"; dr["Name"] = "4B - Box, aluminium"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "4C"; dr["Name"] = "4C - Box, natural wood"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "4D"; dr["Name"] = "4D - Box, plywood"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "4F"; dr["Name"] = "4F - Box, reconstituted wood"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "4G"; dr["Name"] = "4G - Box, fibreboard"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "4H"; dr["Name"] = "4H - Box, plastic"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "5H"; dr["Name"] = "5H - Bag, woven plastic"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "5L"; dr["Name"] = "5L - Bag, textile"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "5M"; dr["Name"] = "5M - Bag, paper"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "6H"; dr["Name"] = "6H - Composite packaging, plastic receptacle"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "6P"; dr["Name"] = "6P - Composite packaging, glass receptacle"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "7A"; dr["Name"] = "7A - Case, car"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "7B"; dr["Name"] = "7B - Case, wooden"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "8A"; dr["Name"] = "8A - Pallet, wooden"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "8B"; dr["Name"] = "8B - Crate, wooden"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "8C"; dr["Name"] = "8C - Bundle, wooden"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "AA"; dr["Name"] = "AA - Intermediate bulk container, rigid plastic"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "AB"; dr["Name"] = "AB - Receptacle, fibre"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "AC"; dr["Name"] = "AC - Receptacle, paper"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "AD"; dr["Name"] = "AD - Receptacle, wooden"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "AE"; dr["Name"] = "AE - Aerosol"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "AF"; dr["Name"] = "AF - Pallet, modular, collars 80cms * 60cms"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "AG"; dr["Name"] = "AG - Pallet, shrinkwrapped"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "AH"; dr["Name"] = "AH - Pallet, 100cms * 110cms"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "AI"; dr["Name"] = "AI - Clamshell"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "AJ"; dr["Name"] = "AJ - Cone"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "AL"; dr["Name"] = "AL - Ball"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "AM"; dr["Name"] = "AM - Ampoule, non-protected"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "AP"; dr["Name"] = "AP - Ampoule, protected"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "AT"; dr["Name"] = "AT - Atomizer"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "AV"; dr["Name"] = "AV - Capsule"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "B4"; dr["Name"] = "B4 - Belt"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "BA"; dr["Name"] = "BA - Barrel"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "BB"; dr["Name"] = "BB - Bobbin"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "BC"; dr["Name"] = "BC - Bottlecrate / bottlerack"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "BD"; dr["Name"] = "BD - Board"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "BE"; dr["Name"] = "BE - Bundle"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "BF"; dr["Name"] = "BF - Balloon, non-protected"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "BG"; dr["Name"] = "BG - Bag"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "BH"; dr["Name"] = "BH - Bunch"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "BI"; dr["Name"] = "BI - Bin"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "BJ"; dr["Name"] = "BJ - Bucket"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "BK"; dr["Name"] = "BK - Basket"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "BL"; dr["Name"] = "BL - Bale, compressed"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "BM"; dr["Name"] = "BM - Basin"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "BN"; dr["Name"] = "BN - Bale, non-compressed"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "BO"; dr["Name"] = "BO - Bottle, non-protected, cylindrical"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "BP"; dr["Name"] = "BP - Balloon, protected"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "BQ"; dr["Name"] = "BQ - Bottle, protected cylindrical"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "BR"; dr["Name"] = "BR - Bar"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "BS"; dr["Name"] = "BS - Bottle, non-protected, bulbous"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "BT"; dr["Name"] = "BT - Bolt"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "BU"; dr["Name"] = "BU - Butt"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "BV"; dr["Name"] = "BV - Bottle, protected bulbous"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "BW"; dr["Name"] = "BW - Box, for liquids"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "BX"; dr["Name"] = "BX - Box"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "BY"; dr["Name"] = "BY - Board, in bundle/bunch/truss"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "BZ"; dr["Name"] = "BZ - Bars, in bundle/bunch/truss"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "CA"; dr["Name"] = "CA - Can, rectangular"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "CB"; dr["Name"] = "CB - Crate, beer"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "CC"; dr["Name"] = "CC - Churn"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "CD"; dr["Name"] = "CD - Can, with handle and spout"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "CE"; dr["Name"] = "CE - Creel"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "CF"; dr["Name"] = "CF - Coffer"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "CG"; dr["Name"] = "CG - Cage"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "CH"; dr["Name"] = "CH - Chest"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "CI"; dr["Name"] = "CI - Canister"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "CJ"; dr["Name"] = "CJ - Coffin"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "CK"; dr["Name"] = "CK - Cask"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "CL"; dr["Name"] = "CL - Coil"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "CM"; dr["Name"] = "CM - Card"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "CN"; dr["Name"] = "CN - Container, not otherwise specified as transport equipment"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "CO"; dr["Name"] = "CO - Carboy, non-protected"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "CP"; dr["Name"] = "CP - Carboy, protected"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "CQ"; dr["Name"] = "CQ - Cartridge"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "CR"; dr["Name"] = "CR - Crate"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "CS"; dr["Name"] = "CS - Case"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "CT"; dr["Name"] = "CT - Carton"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "CU"; dr["Name"] = "CU - Cup"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "CV"; dr["Name"] = "CV - Cover"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "CW"; dr["Name"] = "CW - Cage, roll"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "CX"; dr["Name"] = "CX - Can, cylindrical"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "CY"; dr["Name"] = "CY - Cylinder"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "CZ"; dr["Name"] = "CZ - Canvas"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "DA"; dr["Name"] = "DA - Crate, multiple layer, plastic"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "DB"; dr["Name"] = "DB - Crate, multiple layer, wooden"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "DC"; dr["Name"] = "DC - Crate, multiple layer, cardboard"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "DG"; dr["Name"] = "DG - Cage, Commonwealth Handling Equipment Pool (CHEP)"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "DH"; dr["Name"] = "DH - Box, Commonwealth Handling Equipment Pool (CHEP), Eurobox"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "DI"; dr["Name"] = "DI - Drum, iron"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "DJ"; dr["Name"] = "DJ - Demijohn, non-protected"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "DK"; dr["Name"] = "DK - Crate, bulk, cardboard"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "DL"; dr["Name"] = "DL - Crate, bulk, plastic"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "DM"; dr["Name"] = "DM - Crate, bulk, wooden"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "DN"; dr["Name"] = "DN - Dispenser"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "DP"; dr["Name"] = "DP - Demijohn, protected"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "DR"; dr["Name"] = "DR - Drum"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "DS"; dr["Name"] = "DS - Tray, one layer no cover, plastic"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "DT"; dr["Name"] = "DT - Tray, one layer no cover, wooden"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "DU"; dr["Name"] = "DU - Tray, one layer no cover, polystyrene"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "DV"; dr["Name"] = "DV - Tray, one layer no cover, cardboard"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "DW"; dr["Name"] = "DW - Tray, two layers no cover, plastic tray"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "DX"; dr["Name"] = "DX - Tray, two layers no cover, wooden"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "DY"; dr["Name"] = "DY - Tray, two layers no cover, cardboard"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "EC"; dr["Name"] = "EC - Bag, plastic"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "ED"; dr["Name"] = "ED - Case, with pallet base"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "EE"; dr["Name"] = "EE - Case, with pallet base, wooden"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "EF"; dr["Name"] = "EF - Case, with pallet base, cardboard"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "EG"; dr["Name"] = "EG - Case, with pallet base, plastic"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "EH"; dr["Name"] = "EH - Case, with pallet base, metal"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "EI"; dr["Name"] = "EI - Case, isothermic"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "EN"; dr["Name"] = "EN - Envelope"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "FB"; dr["Name"] = "FB - Flexibag"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "FC"; dr["Name"] = "FC - Crate, fruit"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "FD"; dr["Name"] = "FD - Crate, framed"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "FE"; dr["Name"] = "FE - Flexitank"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "FI"; dr["Name"] = "FI - Firkin"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "FL"; dr["Name"] = "FL - Flask"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "FO"; dr["Name"] = "FO - Footlocker"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "FP"; dr["Name"] = "FP - Filmpack"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "FR"; dr["Name"] = "FR - Frame"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "FT"; dr["Name"] = "FT - Foodtainer"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "FW"; dr["Name"] = "FW - Cart, flatbed"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "FX"; dr["Name"] = "FX - Bag, flexible container"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "GB"; dr["Name"] = "GB - Bottle, gas"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "GI"; dr["Name"] = "GI - Girder"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "GL"; dr["Name"] = "GL - Container, gallon"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "GR"; dr["Name"] = "GR - Receptacle, glass"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "GU"; dr["Name"] = "GU - Tray, containing horizontally stacked flat items"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "GY"; dr["Name"] = "GY - Bag, gunny"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "GZ"; dr["Name"] = "GZ - Girders, in bundle/bunch/truss"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "HA"; dr["Name"] = "HA - Basket, with handle, plastic"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "HB"; dr["Name"] = "HB - Basket, with handle, wooden"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "HC"; dr["Name"] = "HC - Basket, with handle, cardboard"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "HG"; dr["Name"] = "HG - Hogshead"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "HN"; dr["Name"] = "HN - Hanger"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "HR"; dr["Name"] = "HR - Hamper"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "IA"; dr["Name"] = "IA - Package, display, wooden"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "IB"; dr["Name"] = "IB - Package, display, cardboard"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "IC"; dr["Name"] = "IC - Package, display, plastic"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "ID"; dr["Name"] = "ID - Package, display, metal"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "IE"; dr["Name"] = "IE - Package, show"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "IF"; dr["Name"] = "IF - Package, flow"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "IG"; dr["Name"] = "IG - Package, paper wrapped"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "IH"; dr["Name"] = "IH - Drum, plastic"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "IK"; dr["Name"] = "IK - Package, cardboard, with bottle grip-holes"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "IL"; dr["Name"] = "IL - Tray, rigid, lidded stackable (CEN TS 14482:2002)"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "IN"; dr["Name"] = "IN - Ingot"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "IZ"; dr["Name"] = "IZ - Ingots, in bundle/bunch/truss"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "JB"; dr["Name"] = "JB - Bag, jumbo"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "JC"; dr["Name"] = "JC - Jerrican, rectangular"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "JG"; dr["Name"] = "JG - Jug"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "JR"; dr["Name"] = "JR - Jar"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "JT"; dr["Name"] = "JT - Jutebag"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "JY"; dr["Name"] = "JY - Jerrican, cylindrical"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "KG"; dr["Name"] = "KG - Keg"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "KI"; dr["Name"] = "KI - Kit"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "LE"; dr["Name"] = "LE - Luggage"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "LG"; dr["Name"] = "LG - Log"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "LT"; dr["Name"] = "LT - Lot"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "LU"; dr["Name"] = "LU - Lug"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "LV"; dr["Name"] = "LV - Liftvan"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "LZ"; dr["Name"] = "LZ - Logs, in bundle/bunch/truss"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "MA"; dr["Name"] = "MA - Crate, metal"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "MB"; dr["Name"] = "MB - Bag, multiply"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "MC"; dr["Name"] = "MC - Crate, milk"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "ME"; dr["Name"] = "ME - Container, metal"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "MR"; dr["Name"] = "MR - Receptacle, metal"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "MS"; dr["Name"] = "MS - Sack, multi-wall"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "MT"; dr["Name"] = "MT - Mat"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "MW"; dr["Name"] = "MW - Receptacle, plastic wrapped"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "MX"; dr["Name"] = "MX - Matchbox"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "NA"; dr["Name"] = "NA - Not available"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "NE"; dr["Name"] = "NE - Unpacked or unpackaged"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "NF"; dr["Name"] = "NF - Unpacked or unpackaged, single unit"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "NG"; dr["Name"] = "NG - Unpacked or unpackaged, multiple units"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "NS"; dr["Name"] = "NS - Nest"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "NT"; dr["Name"] = "NT - Net"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "NU"; dr["Name"] = "NU - Net, tube, plastic"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "NV"; dr["Name"] = "NV - Net, tube, textile"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "OA"; dr["Name"] = "OA - Pallet, CHEP 40 cm x 60 cm"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "OB"; dr["Name"] = "OB - Pallet, CHEP 80 cm x 120 cm"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "OC"; dr["Name"] = "OC - Pallet, CHEP 100 cm x 120 cm"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "OD"; dr["Name"] = "OD - Pallet, AS 4068-1993"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "OE"; dr["Name"] = "OE - Pallet, ISO T11"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "OF"; dr["Name"] = "OF - Platform, unspecified weight or dimension"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "OK"; dr["Name"] = "OK - Block"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "OT"; dr["Name"] = "OT - Octabin"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "OU"; dr["Name"] = "OU - Container, outer"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "P2"; dr["Name"] = "P2 - Pan"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "PA"; dr["Name"] = "PA - Packet"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "PB"; dr["Name"] = "PB - Pallet, box Combined open-ended box and pallet"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "PC"; dr["Name"] = "PC - Parcel"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "PD"; dr["Name"] = "PD - Pallet, modular, collars 80cms * 100cms"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "PE"; dr["Name"] = "PE - Pallet, modular, collars 80cms * 120cms"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "PF"; dr["Name"] = "PF - Pen"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "PG"; dr["Name"] = "PG - Plate"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "PH"; dr["Name"] = "PH - Pitcher"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "PI"; dr["Name"] = "PI - Pipe"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "PJ"; dr["Name"] = "PJ - Punnet"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "PK"; dr["Name"] = "PK - Package"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "PL"; dr["Name"] = "PL - Pail"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "PN"; dr["Name"] = "PN - Plank"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "PO"; dr["Name"] = "PO - Pouch"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "PP"; dr["Name"] = "PP - Piece"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "PR"; dr["Name"] = "PR - Receptacle, plastic"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "PT"; dr["Name"] = "PT - Pot"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "PU"; dr["Name"] = "PU - Tray"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "PV"; dr["Name"] = "PV - Pipes, in bundle/bunch/truss"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "PX"; dr["Name"] = "PX - Pallet"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "PY"; dr["Name"] = "PY - Plates, in bundle/bunch/truss"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "PZ"; dr["Name"] = "PZ - Planks, in bundle/bunch/truss"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "QA"; dr["Name"] = "QA - Drum, steel, non-removable head"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "QB"; dr["Name"] = "QB - Drum, steel, removable head"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "QC"; dr["Name"] = "QC - Drum, aluminium, non-removable head"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "QD"; dr["Name"] = "QD - Drum, aluminium, removable head"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "QF"; dr["Name"] = "QF - Drum, plastic, non-removable head"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "QG"; dr["Name"] = "QG - Drum, plastic, removable head"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "QH"; dr["Name"] = "QH - Barrel, wooden, bung type"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "QJ"; dr["Name"] = "QJ - Barrel, wooden, removable head"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "QK"; dr["Name"] = "QK - Jerrican, steel, non-removable head"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "QL"; dr["Name"] = "QL - Jerrican, steel, removable head"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "QM"; dr["Name"] = "QM - Jerrican, plastic, non-removable head"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "QN"; dr["Name"] = "QN - Jerrican, plastic, removable head"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "QP"; dr["Name"] = "QP - Box, wooden, natural wood, ordinary"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "QQ"; dr["Name"] = "QQ - Box, wooden, natural wood, with sift proof walls"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "QR"; dr["Name"] = "QR - Box, plastic, expanded"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "QS"; dr["Name"] = "QS - Box, plastic, solid"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "RD"; dr["Name"] = "RD - Rod"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "RG"; dr["Name"] = "RG - Ring"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "RJ"; dr["Name"] = "RJ - Rack, clothing hanger"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "RK"; dr["Name"] = "RK - Rack"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "RL"; dr["Name"] = "RL - Reel"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "RO"; dr["Name"] = "RO - Roll"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "RT"; dr["Name"] = "RT - Rednet"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "RZ"; dr["Name"] = "RZ - Rods, in bundle/bunch/truss"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "SA"; dr["Name"] = "SA - Sack"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "SB"; dr["Name"] = "SB - Slab"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "SC"; dr["Name"] = "SC - Crate, shallow"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "SD"; dr["Name"] = "SD - Spindle"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "SE"; dr["Name"] = "SE - Sea-chest"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "SH"; dr["Name"] = "SH - Sachet"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "SI"; dr["Name"] = "SI - Skid"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "SK"; dr["Name"] = "SK - Case, skeleton"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "SL"; dr["Name"] = "SL - Slipsheet"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "SM"; dr["Name"] = "SM - Sheetmetal"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "SO"; dr["Name"] = "SO - Spool"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "SP"; dr["Name"] = "SP - Sheet, plastic wrapping"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "SS"; dr["Name"] = "SS - Case, steel"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "ST"; dr["Name"] = "ST - Sheet"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "SU"; dr["Name"] = "SU - Suitcase"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "SV"; dr["Name"] = "SV - Envelope, steel"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "SW"; dr["Name"] = "SW - Shrinkwrapped"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "SX"; dr["Name"] = "SX - Set"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "SY"; dr["Name"] = "SY - Sleeve"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "SZ"; dr["Name"] = "SZ - Sheets, in bundle/bunch/truss"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "T1"; dr["Name"] = "T1 - Tablet"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "TB"; dr["Name"] = "TB - Tub"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "TC"; dr["Name"] = "TC - Tea-chest"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "TD"; dr["Name"] = "TD - Tube, collapsible"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "TE"; dr["Name"] = "TE - Tyre"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "TG"; dr["Name"] = "TG - Tank container, generic"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "TI"; dr["Name"] = "TI - Tierce"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "TK"; dr["Name"] = "TK - Tank, rectangular"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "TL"; dr["Name"] = "TL - Tub, with lid"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "TN"; dr["Name"] = "TN - Tin"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "TO"; dr["Name"] = "TO - Tun"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "TR"; dr["Name"] = "TR - Trunk"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "TS"; dr["Name"] = "TS - Truss"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "TT"; dr["Name"] = "TT - Bag, tote"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "TU"; dr["Name"] = "TU - Tube"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "TV"; dr["Name"] = "TV - Tube, with nozzle"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "TW"; dr["Name"] = "TW - Pallet, triwall"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "TY"; dr["Name"] = "TY - Tank, cylindrical"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "TZ"; dr["Name"] = "TZ - Tubes, in bundle/bunch/truss"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "UC"; dr["Name"] = "UC - Uncaged"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "UN"; dr["Name"] = "UN - Unit"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "VA"; dr["Name"] = "VA - Vat"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "VG"; dr["Name"] = "VG - Bulk, gas (at 1031 mbar and 15°C)"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "VI"; dr["Name"] = "VI - Vial"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "VK"; dr["Name"] = "VK - Vanpack"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "VL"; dr["Name"] = "VL - Bulk, liquid"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "VO"; dr["Name"] = "VO - Bulk, solid, large particles (nodules)"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "VP"; dr["Name"] = "VP - Vacuum-packed"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "VQ"; dr["Name"] = "VQ - Bulk, liquefied gas (at abnormal temperature/pressure)"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "VN"; dr["Name"] = "VN - Vehicle"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "VR"; dr["Name"] = "VR - Bulk, solid, granular particles (grains)"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "VS"; dr["Name"] = "VS - Bulk, scrap metal"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "VY"; dr["Name"] = "VY - Bulk, solid, fine particles (powders)"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "WA"; dr["Name"] = "WA - Intermediate bulk container"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "WB"; dr["Name"] = "WB - Wickerbottle"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "WC"; dr["Name"] = "WC - Intermediate bulk container, steel"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "WD"; dr["Name"] = "WD - Intermediate bulk container, aluminium"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "WF"; dr["Name"] = "WF - Intermediate bulk container, metal"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "WG"; dr["Name"] = "WG - Intermediate bulk container, steel, pressurised > 10 kpa"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "WH"; dr["Name"] = "WH - Intermediate bulk container, aluminium, pressurised > 10 kpa"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "WJ"; dr["Name"] = "WJ - Intermediate bulk container, metal, pressure 10 kpa"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "WK"; dr["Name"] = "WK - Intermediate bulk container, steel, liquid"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "WL"; dr["Name"] = "WL - Intermediate bulk container, aluminium, liquid"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "WM"; dr["Name"] = "WM - Intermediate bulk container, metal, liquid"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "WN"; dr["Name"] = "WN - Intermediate bulk container, woven plastic, without coat/liner"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "WP"; dr["Name"] = "WP - Intermediate bulk container, woven plastic, coated"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "WQ"; dr["Name"] = "WQ - Intermediate bulk container, woven plastic, with liner"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "WR"; dr["Name"] = "WR - Intermediate bulk container, woven plastic, coated and liner"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "WS"; dr["Name"] = "WS - Intermediate bulk container, plastic film"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "WT"; dr["Name"] = "WT - Intermediate bulk container, textile with out coat/liner"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "WU"; dr["Name"] = "WU - Intermediate bulk container, natural wood, with inner liner"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "WV"; dr["Name"] = "WV - Intermediate bulk container, textile, coated"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "WW"; dr["Name"] = "WW - Intermediate bulk container, textile, with liner"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "WX"; dr["Name"] = "WX - Intermediate bulk container, textile, coated and liner"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "WY"; dr["Name"] = "WY - Intermediate bulk container, plywood, with inner liner"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "WZ"; dr["Name"] = "WZ - Intermediate bulk container, reconstituted wood, with inner liner"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "XA"; dr["Name"] = "XA - Bag, woven plastic, without inner coat/liner"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "XB"; dr["Name"] = "XB - Bag, woven plastic, sift proof"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "XC"; dr["Name"] = "XC - Bag, woven plastic, water resistant"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "XD"; dr["Name"] = "XD - Bag, plastics film"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "XF"; dr["Name"] = "XF - Bag, textile, without inner coat/liner"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "XG"; dr["Name"] = "XG - Bag, textile, sift proof"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "XH"; dr["Name"] = "XH - Bag, textile, water resistant"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "XJ"; dr["Name"] = "XJ - Bag, paper, multi-wall"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "XK"; dr["Name"] = "XK - Bag, paper, multi-wall, water resistant"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "YA"; dr["Name"] = "YA - Composite packaging, plastic receptacle in steel drum"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "YB"; dr["Name"] = "YB - Composite packaging, plastic receptacle in steel crate box"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "YC"; dr["Name"] = "YC - Composite packaging, plastic receptacle in aluminium drum"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "YD"; dr["Name"] = "YD - Composite packaging, plastic receptacle in aluminium crate"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "YF"; dr["Name"] = "YF - Composite packaging, plastic receptacle in wooden box"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "YG"; dr["Name"] = "YG - Composite packaging, plastic receptacle in plywood drum"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "YH"; dr["Name"] = "YH - Composite packaging, plastic receptacle in plywood box"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "YJ"; dr["Name"] = "YJ - Composite packaging, plastic receptacle in fibre drum"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "YK"; dr["Name"] = "YK - Composite packaging, plastic receptacle in fibreboard box"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "YL"; dr["Name"] = "YL - Composite packaging, plastic receptacle in plastic drum"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "YM"; dr["Name"] = "YM - Composite packaging, plastic receptacle in solid plastic box"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "YN"; dr["Name"] = "YN - Composite packaging, glass receptacle in steel drum"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "YP"; dr["Name"] = "YP - Composite packaging, glass receptacle in steel crate box"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "YQ"; dr["Name"] = "YQ - Composite packaging, glass receptacle in aluminium drum"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "YR"; dr["Name"] = "YR - Composite packaging, glass receptacle in aluminium crate"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "YS"; dr["Name"] = "YS - Composite packaging, glass receptacle in wooden box"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "YT"; dr["Name"] = "YT - Composite packaging, glass receptacle in plywood drum"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "YV"; dr["Name"] = "YV - Composite packaging, glass receptacle in wickerwork hamper"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "YW"; dr["Name"] = "YW - Composite packaging, glass receptacle in fibre drum"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "YX"; dr["Name"] = "YX - Composite packaging, glass receptacle in fibreboard box"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "YY"; dr["Name"] = "YY - Composite packaging, glass receptacle in expandable plastic pack"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "YZ"; dr["Name"] = "YZ - Composite packaging, glass receptacle in solid plastic pack"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "ZA"; dr["Name"] = "ZA - Intermediate bulk container, paper, multi-wall"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "ZB"; dr["Name"] = "ZB - Bag, large"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "ZC"; dr["Name"] = "ZC - Intermediate bulk container, paper, multi-wall, water resistant"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "ZD"; dr["Name"] = "ZD - Intermediate bulk container, rigid plastic, with structural equipment, solids"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "ZF"; dr["Name"] = "ZF - Intermediate bulk container, rigid plastic, freestanding, solids"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "ZG"; dr["Name"] = "ZG - Intermediate bulk container, rigid plastic, with structural equipment, pressurised"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "ZH"; dr["Name"] = "ZH - Intermediate bulk container, rigid plastic, freestanding, pressurised"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "ZJ"; dr["Name"] = "ZJ - Intermediate bulk container, rigid plastic, with structural equipment, liquids"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "ZK"; dr["Name"] = "ZK - Intermediate bulk container, rigid plastic, freestanding, liquids"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "ZL"; dr["Name"] = "ZL - Intermediate bulk container, composite, rigid plastic, solids"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "ZM"; dr["Name"] = "ZM - Intermediate bulk container, composite, flexible plastic, solids"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "ZN"; dr["Name"] = "ZN - Intermediate bulk container, composite, rigid plastic, pressurised"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "ZP"; dr["Name"] = "ZP - Intermediate bulk container, composite, flexible plastic, pressurised"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "ZQ"; dr["Name"] = "ZQ - Intermediate bulk container, composite, rigid plastic, liquids"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "ZR"; dr["Name"] = "ZR - Intermediate bulk container, composite, flexible plastic, liquids"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "ZS"; dr["Name"] = "ZS - Intermediate bulk container, composite"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "ZT"; dr["Name"] = "ZT - Intermediate bulk container, fibreboard"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "ZU"; dr["Name"] = "ZU - Intermediate bulk container, flexible"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "ZV"; dr["Name"] = "ZV - Intermediate bulk container, metal, other than steel"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "ZW"; dr["Name"] = "ZW - Intermediate bulk container, natural wood"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "ZX"; dr["Name"] = "ZX - Intermediate bulk container, plywood"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "ZY"; dr["Name"] = "ZY - Intermediate bulk container, reconstituted wood"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "ZZ"; dr["Name"] = "ZZ - Mutually defined"; dt.Rows.Add(dr);




            return dt;
        }


        public static DataTable getTransportModeCode()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ID", typeof(string)));
            dt.Columns.Add(new DataColumn("Name", typeof(string)));


            DataRow dr;

            dr = dt.NewRow(); dr["ID"] = ""; dr["Name"] = " "; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "0"; dr["Name"] = "0 - Transport mode not specified"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "1"; dr["Name"] = "1 - Maritime transport"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "2"; dr["Name"] = "2 - Rail transport"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "3"; dr["Name"] = "3 - Road transport"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "4"; dr["Name"] = "4 - Air transport"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "5"; dr["Name"] = "5 - Mail"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "6"; dr["Name"] = "6 - Multimodal transport"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "7"; dr["Name"] = "7 - Fixed transport installations"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "8"; dr["Name"] = "8 - Inland water transport"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr["ID"] = "9"; dr["Name"] = "9 - Transport mode not applicable"; dt.Rows.Add(dr);

        

            return dt;
        }
    }

    public struct FormAuthInfo
    {
        public bool CanRead;
        public bool CanWrite;
        public bool CanDelete;
        public bool CanPrintGrid;
        public bool CanPrintForm;
        public bool CanUnlock;
        public bool CanChangeOldValues;
        public bool CanSeePrice;
        public bool CanExport;
        public bool CanExportExcel;
        public bool CanExportTxt;
        public bool CanExportCsv;
        public bool CanExportPdf;
        public bool CanExportHtml;
    }

}
