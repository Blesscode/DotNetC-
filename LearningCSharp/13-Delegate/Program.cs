using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Delegate
{
    internal class Program
    {
        public delegate void DelegateForMyMeth(string name);
        public void MyMeth(string name)
        {
            Console.WriteLine("My method :"+name);
        }
        
        static void Main(string[] args)
        {
            //is a ref to method use to call a method afterwards

            Console.WriteLine("Calling meth using delegate");
            //1. assign the meth to the delegate
            Program obj=new Program();
            DelegateForMyMeth d = obj.MyMeth;
            d("Isha");

            //Multicaste delegate : calls more than 1 method using that same delegate
            Console.WriteLine("Multicaste delegate");
            MultiCastDelegate obj2 = new MultiCastDelegate();
            obj2.MulticasteDelegateWorking();
        }
    }
}
