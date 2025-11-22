using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Generics
{
    internal class withoutGenerics
    {
        public void IntDisplay(int[] arr)
        {
            Console.WriteLine("Int specific iteration");
            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }
        }
        public void LongDisplay(long[] arr)
        {
            Console.WriteLine("Long specific iteration");
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }
        public void StringDisplay(string[] arr)
        {
            Console.WriteLine("String specific iteration");
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
