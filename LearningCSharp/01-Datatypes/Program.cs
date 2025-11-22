using System;

namespace _01_Datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string vs String
            string s1 = "isha";
            String s2 = "shubh";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s1.GetType());
            Console.WriteLine(s2.GetType());
        }
    }
}
