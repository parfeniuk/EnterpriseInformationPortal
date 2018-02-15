using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;


namespace Base2BaseWeb.UI.Helpers
{
    public static class ConvertToString
    {
        public static string ConvertFromUtf8(string encodedString)
        {
            //byte[] data = System.Text.Encoding.UTF8.GetBytes(encodedString);
            //string decodedString = System.Text.Encoding.UTF8.GetString(data);
            //return decodedString;
            //string utf8String = "AcciÃ³n";
            string propEncodeString = string.Empty;

            byte[] utf8_Bytes = new byte[encodedString.Length];
            for (int i = 0; i < encodedString.Length; ++i)
            {
                utf8_Bytes[i] = (byte)encodedString[i];
            }

            propEncodeString = Encoding.UTF8.GetString(utf8_Bytes, 0, utf8_Bytes.Length);
            return propEncodeString;
        }
    }
}
