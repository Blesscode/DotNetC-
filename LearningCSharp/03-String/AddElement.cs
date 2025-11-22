using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _03_String
{
    internal class AddElement
    {
        public String StringAddLast(String s)
        {
            s = s + 's';
            return s;
        }
        public String StringAddFirst(String s)
        {
            s = 's'+s  ;
            return s;
        }
        public String StringAddMid(String s)
        {
            int index = s.Length / 2;
            s = s.Insert(index, "X");
            return s;
        }
        public StringBuilder StringBuilderAddLast(StringBuilder s)
        {
            s.Append("s");
            return s;
        }
        public StringBuilder StringBuilderAddFirst(StringBuilder s)
        {
            s.Insert(0,'s');
            return s;
        }
        public StringBuilder StringBuilderAddMid(StringBuilder s)
        {
            int length=s.Length;
            s.Insert(length/2, 's');
            return s;
        }
    }
}
