using System;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = "Hello World";
            string resp = SixKyu.EncryptThis(num);
            Console.Write("Answer: " + resp);
            Console.ReadKey();
        }
    }
}
