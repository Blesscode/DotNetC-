using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _03_String
{
    internal class SizeOf
    {
        public int StringSize(String s) {
            int length=s.Length;
            return length;
        }
        public int StringBuilderSize(StringBuilder s)
        {
            int length=s.Length;
            return length;
        }
    }
}
