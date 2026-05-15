using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MrTEK_EFatura
{

    public static class Extensions
    {
        public static string ToString(this object obj, int Len)
        {
            string i = "";

            try
            {
                i = Convert.ToString(obj);
            }
            catch { i = ""; }

            if (i.Length > Len)
                i = i.Substring(0, Len);

            return i;
        }

        public static int ToInt(this object obj)
        {
            int i = 0;

            try
            {
                if (obj == null) return 0;
                i = Convert.ToInt32(obj);
            }
            catch { i = 0; }

            return i;
        }

        public static decimal ToDecimal(this object obj)
        {
            decimal i = 0;

            try
            {
                if (obj == null) return 0;
                if (obj == DBNull.Value) return 0;
                i = Convert.ToDecimal(obj);
            }
            catch { i = 0; }

            return i;
        }

        public static double ToDouble(this object obj)
        {
            double i = 0;

            try
            {
                i = Convert.ToDouble(obj);
            }
            catch { i = 0; }

            return i;
        }

        public static string ToCommaPoint(this object obj)
        {
            double i = 0;

            try
            {
                i = Convert.ToDouble(obj);
            }
            catch { i = 0; }

            return UT.CommaToPoint( i);
        }


        public static bool ToBool(this object obj)
        {
            bool i = false;

            try
            {
                i = Convert.ToBoolean(obj);
            }
            catch { i = false; }

            return i;
        }

        public static DateTime ToDateTime(this object obj)
        {
            DateTime i = DateTime.Now;

            try
            {
                i = Convert.ToDateTime(obj);
            }
            catch { i = DateTime.Now; }

            return i;
        }

        public static string ToDesc(this Enum en)
        {
            Type type = en.GetType();

            MemberInfo[] memInfo = type.GetMember(en.ToString());

            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs != null && attrs.Length > 0)
                    return ((DescriptionAttribute)attrs[0]).Description;
            }

            return en.ToString();

        }

        public static string GetDesc(this Enum e)
        {
            Type t = e.GetType();

            MemberInfo[] meminfo = t.GetMember(e.ToString());

            if (meminfo != null && meminfo.Length > 0)
            {
                object[] attr = meminfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attr != null && attr.Length > 0)
                {
                    return ((DescriptionAttribute)attr[0]).Description;
                }
            }

            return e.ToString();
        }

        public static string ToTitleCase(this string str)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }

        public static string ToUpperLocal(this string str)
        {

            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToUpper(str);
        }

        public static string ToEngString(this object obj)
        {
            string i = "";

            try
            {
                i = Convert.ToString(obj);
            }
            catch { i = ""; }

            
            i = i.Replace("ı", "i");
            i = i.Replace("İ", "I");
            i = i.Replace("ş", "s");
            i = i.Replace("Ş", "S");
            i = i.Replace("ç", "c");
            i = i.Replace("Ç", "C");
            i = i.Replace("ğ", "g");
            i = i.Replace("Ğ", "G");
            i = i.Replace("ü", "u");
            i = i.Replace("Ü", "U");
            i = i.Replace("ö", "o");
            i = i.Replace("Ö", "O");

            return i;
        }

    }

}