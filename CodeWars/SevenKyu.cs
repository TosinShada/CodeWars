using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    class SevenKyu
    {
        public static long FindNextSquare(long num)
        {
            double root = Math.Sqrt(num);
            return root % 1 == 0 ? (long)Math.Pow(root + 1, 2) : -1;
        }
    }
}
