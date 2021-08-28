using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
