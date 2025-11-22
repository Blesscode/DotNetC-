using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Upcasting_Downcasting
{
    class Parent { 
        public void parentM()
        {
            Console.WriteLine("Parent specific meth");
        }
        public virtual void CommomM() 
        {
            Console.WriteLine("commmon parent call");
        }

    }
    class Child:Parent {
        public void ChildM()
        {
            Console.WriteLine("Child specific meth");
        }
        public override void CommomM()
        {
            Console.WriteLine("commmon child call");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Upcasting : child to parent [for override],safe from runtime error
            Parent p = new Child();
            p.CommomM();

            //Downcasting : parent to child  [for acessing child spefific methods],risk of runtime error
            //Child c=(Child)new Parent(); compile time safe,runtime error : since parent does not have child reference
            Parent p2= new Child();
            Child c=(Child)p2; //since parent had child reference so we typecasted , hence escaped the runtime error
            c.ChildM();
        }
    }
}
