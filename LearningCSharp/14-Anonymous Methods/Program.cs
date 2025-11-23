using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _14_Anonymous_Methods
{
    internal class Program
    {
        //1. DELEGATE
        public delegate void MyDelegate(string msg);
        static void Main(string[] args)
        {
            /*
             1. NO NAME
             2. INLINE
             3. USE DELEGATE KEYWORD
             */
            Console.WriteLine("Anonymous method:methods without a name, created using the delegate keyword.\r\nThey let you write inline methods without needing to define them separately ");

            //2. METHOD
            /*
             old: DELEGATE=METHOD
             NOW: DELEGATE=DELEGATE/ANONYMOUS METHOD
             */
            MyDelegate d = delegate (string msg) { 
                Console.WriteLine(msg); 
            };
            d("Hello Isha");
    }
    }
}
