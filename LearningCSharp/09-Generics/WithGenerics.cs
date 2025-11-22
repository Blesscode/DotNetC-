using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Generics
{
    internal class WithGenerics
    {
        public void CommonDisplay<T>(T[] arr)
        {

            Console.WriteLine("Generic Method");
            foreach (T i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
