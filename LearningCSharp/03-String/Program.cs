using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _03_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String
            string s1 = "raja";
            String s3 = new string(new char[] { 'r','a','n','i'});
            //String Builder
            StringBuilder s2 = new StringBuilder("raja");
            StringBuilder sb3 = new StringBuilder(s3);

            //Length
            Console.WriteLine(new SizeOf().StringSize("MOM"));
            //Palindrome
            CodeQuestions obj1 = new CodeQuestions();
            Console.WriteLine(obj1.CheckPallinDrome("MOM"));

            Console.WriteLine(new CodeQuestions().CheckPallinDrome("SON"));

        }
    }
}
