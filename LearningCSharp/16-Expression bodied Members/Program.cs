using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _16_Expression_bodied_Members
{
    internal class Program
    {

        public int Add(int a, int b) => a + b;
        static void Main(string[] args)
        {
            /*
             allow methods, properties,constructor and other members to be written using a single expression with the => operator.
             */
            Console.WriteLine("Methods");
            new Program().Add(2, 3);


        }
    }
}
