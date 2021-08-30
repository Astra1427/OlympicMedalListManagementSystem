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

    }



}
