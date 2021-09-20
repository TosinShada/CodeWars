using System;
using System.Text;

namespace CodeWars
{
    public class EightKyu
    {
        public static bool lovefunc(int flower1, int flower2)
        {
            return (flower1 + flower2) % 2 == 1;
        }
        public static int SquareDigits(int n)
        {
            string result = "";
            string digits = n.ToString();
            foreach (char c in digits)
            {
                int i = c - '0';
                int square = i * i;
                result += square;
            }
            return int.Parse(result);
        }

        public static int Opposite(int number)
        {
            return Math.Sign(number) < 0 ? Math.Abs(number) : number * -1;
        }

        public static string RepeatStr(int n, string s)
        {
            StringBuilder strings = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                strings.Append(s);
            }
            return strings.ToString();
        }
    }

}
