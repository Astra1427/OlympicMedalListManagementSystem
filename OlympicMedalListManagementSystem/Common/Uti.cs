using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace OlympicMedalListManagementSystem.Common
{
    public static class Uti
    {
        public static Account LoggedAccount { get; set; }

        public static string GetVerificationCode(int length)
        {
            Random r = new Random();
            string code = "";
            for (int i = 0; i < length; i++)
            {
                if (r.Next(0, 2) == 0)
                {
                    //letter
                    code += (char)r.Next(65, 91);
                }
                else
                {
                    //digit
                    code += r.Next(0,10);
                }
            }
            return code;
        }

        public static DBEntities db = new DBEntities();


        public static string RtfToPlainText(string rtf)
        {
            FlowDocument flowDocument = new FlowDocument();
            TextRange textRange = new TextRange(flowDocument.ContentStart,flowDocument.ContentEnd);

            
            using (MemoryStream ms =new MemoryStream(Encoding.UTF8.GetBytes(rtf ?? string.Empty)))
            {
                textRange.Load(ms,dataFormat:DataFormats.Rtf);
            }
            return textRange.Text;
        }
        public static string ExtractImgHex(string s)
        {
            // I'm sure you could use regex here, but this works.
            // This assumes one picture per file; loops required otherwise
            int pictTagIdx = s.IndexOf("{\\pict\\");
            int startIndex = s.IndexOf(" ", pictTagIdx) + 1;
            int endIndex = s.IndexOf("}", startIndex);
            return s.Substring(startIndex, endIndex - startIndex);
        }

        public static byte[] ToBinary(string imageDataHex)
        {
            //this function taken entirely from:
            // http://www.codeproject.com/Articles/27431/Writing-Your-Own-RTF-Converter
            if (imageDataHex == null)
            {
                throw new ArgumentNullException("imageDataHex");
            }

            int hexDigits = imageDataHex.Length;
            int dataSize = hexDigits / 2;
            byte[] imageDataBinary = new byte[dataSize];

            StringBuilder hex = new StringBuilder(2);

            int dataPos = 0;
            for (int i = 0; i < hexDigits; i++)
            {
                char c = imageDataHex[i];
                if (char.IsWhiteSpace(c))
                {
                    continue;
                }
                hex.Append(imageDataHex[i]);
                if (hex.Length == 2)
                {
                    imageDataBinary[dataPos] = byte.Parse(hex.ToString(), System.Globalization.NumberStyles.HexNumber);
                    dataPos++;
                    hex.Remove(0, 2);
                }
            }
            return imageDataBinary;
        }
    }



}
