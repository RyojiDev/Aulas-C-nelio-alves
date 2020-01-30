using System;
using ExtensionMethods.Extensions;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2020,01,28,8,10,45);
            Console.WriteLine(dt.ElapsedTime());

            string s1 = "Good morning dear studentes!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
