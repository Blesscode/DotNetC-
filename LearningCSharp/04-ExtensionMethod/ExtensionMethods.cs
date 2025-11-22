using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _04_ExtensionMethod
{
    public static class ExtensionMethods
    {
        //this = for the data type which should be extended
        //here this int num  = this will be applied to System.Int32
        public static String Even(this int num)
        {
            if (num % 2 == 0)
            {
                return "even";
            }
            else
            {
                return "not even";
            }
        }
        public static String IsPallen(this String s)
        {
            int start = 0;
            int end = s.Length - 1;
            while (start <= end) {
                if (s[start] != s[end])
                {
                    return "Not Pallen";
                }
                start++;
                end--;
            }
            return "Is Pallen";
        }
    }
}
