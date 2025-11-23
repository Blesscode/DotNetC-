using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Delegate
{
    internal class MultiCastDelegate
    {
        public delegate void MyMultiCasteDelegate(int i);
        public void MyMeth2(int i) {
            Console.WriteLine("Multicaste Degelate2 "+i);
        }
        public void MyMeth3(int i) {
            Console.WriteLine("Multicaste Degelate 3 " + i);
        }
        public void MulticasteDelegateWorking()
        {
            MyMultiCasteDelegate d = MyMeth2;
            d = d + MyMeth3;
            d(2);
        }
    }
}
