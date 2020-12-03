using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace VariousTest
{
    public static partial class GM
    {
        public static string FormatException(Exception ex)
        {
            if ( ex == null )
                return "";
            
            string retVal = ex.Message; // retVal = string.Format("{0}: {1}", ex.Source, ex.Message);
            for (Exception subEx = ex.InnerException; subEx != null; subEx = subEx.InnerException)
                retVal += string.Format("{0}{1}", Environment.NewLine, subEx.Message);  

            retVal += string.Format("{0}{0}{1}", Environment.NewLine, ex.ToString());

            return retVal;
        }

#region Message boxes
        public static void ShowErrorMessageBox(IWin32Window wndOwner, String text, Exception ex = null)
        {
            if (string.IsNullOrEmpty(text))
                text = "Error occured!";
            if (ex != null)
                text += string.Format("{0}{0}{1}", Environment.NewLine, FormatException(ex));

            MessageBox.Show(wndOwner, text, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public static void ShowInfoMessageBox(IWin32Window wndOwner, String text)
        {
            MessageBox.Show(wndOwner, text, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DialogResult ShowQuestionMessageBox(IWin32Window wndOwner, String text)
        {
            return MessageBox.Show(wndOwner, text, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
#endregion

#region DES crypting
        private static byte[] desKey = Encoding.ASCII.GetBytes("123456789012345678901234");
        private static byte[] desIV = Encoding.ASCII.GetBytes("12345678");
        public static string DESEncrypt(string data)
        {
            if ( string.IsNullOrEmpty(data) )
                return "";

            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, TripleDES.Create().CreateEncryptor(desKey, desIV), CryptoStreamMode.Write))
                {
                    byte[] buf = Encoding.Unicode.GetBytes(data);
                    cs.Write(buf, 0, buf.Length);
                } // !!! call ms.ToArray() till after closing cs, otherwise cs could be unflushed and ms contained uncomplete data
                return Convert.ToBase64String(ms.ToArray());  // do not use Convert.ToString because ms buffer can contain unreadable characters
            }
        } 
        public static string DESDecrypt(string data)
        {
            if ( string.IsNullOrEmpty(data) )
                return "";

			using ( MemoryStream ms = new MemoryStream() )
            {
			    using ( CryptoStream cs = new CryptoStream(ms, TripleDES.Create().CreateDecryptor(desKey, desIV), CryptoStreamMode.Write) )
                {
    			    byte[] pwdBuf = Convert.FromBase64String(data);
                    cs.Write(pwdBuf, 0, pwdBuf.Length);
                } // !!! call ms.ToArray() till after closing cs, otherwise cs could be unflushed and ms contained uncomplete data
                return Encoding.Unicode.GetString(ms.ToArray());
            }
        } 
#endregion

#region string extension
        public static string LStr(int length, string src)
		{
            return GM.LStr(length, src, ' ');
        }
        public static string LStr(int length, string src, char paddingChar)
		{
			if ( string.IsNullOrEmpty(src) )
				return new string(paddingChar, length);

			if (src.Length > length)
				return src.Substring(0, length);

			return src.PadRight(length, paddingChar);
		}
        public static string RStr(int length, string src)
        {
            return GM.RStr(length, src, ' ');
        }
        public static string RStr(int length, string src, char paddingChar)
		{
			if ( string.IsNullOrEmpty(src) )
				return new string(paddingChar, length);

			if (src.Length > length)
				return src.Substring(0, length);

			return src.PadLeft(length, paddingChar);
		}
#endregion

#region general helper methods
        public static void EnsureDTFromTo(ref DateTime from, ref DateTime to)
        {
            from = new DateTime(from.Year, from.Month, from.Day, 0, 0, 0);
            to = new DateTime(to.Year, to.Month, to.Day, 23, 59, 59);
        }

        public static decimal ParseDecimal(string s)
        {
            if ( s.Trim().Length < 1 )
                return 0m;

            string sep = System.Globalization.CultureInfo.InvariantCulture.NumberFormat.CurrencyDecimalSeparator;
            return decimal.Parse(s.Replace(",", sep).Replace(".", sep).Replace(" ", ""), System.Globalization.CultureInfo.InvariantCulture); // ensure decimal separator
        }
#endregion
    }
}
