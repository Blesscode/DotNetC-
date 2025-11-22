using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //extendin a even method in integer
            int num = 2;
            Console.WriteLine(num.Even());

            //extension of pallen to string
            string s = "MOM";
            Console.WriteLine(s.IsPallen());
        }
    }
}
