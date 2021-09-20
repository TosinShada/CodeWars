using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class SixKyu
    {
        public static string EncryptThis(string input)
        {
            if (input.Length < 1) return "";
            string rtn = "";
            foreach (string s in input.Split(" "))
            {
                rtn += (int)(s[0]);
                if (s.Length > 1) rtn += s[s.Length - 1];
                if (s.Length > 3) rtn += s.Substring(2, s.Length - 3);
                if (s.Length > 2) rtn += s[1];
                rtn += " ";
            }
            return rtn.Trim();
        }
    }
}
