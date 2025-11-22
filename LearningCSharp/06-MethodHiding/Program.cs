using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_MethodHiding
{
    class Parent { 
        public void Display()
        {
            Console.WriteLine("parent HINDING");
        }
        public virtual void Display2()
        {
            Console.WriteLine("parent OVERRIDE");
        }
        //virtual = not mandatory to override 
        //abstract = mandatory to override
        public virtual void Display3()
        {
            Console.WriteLine("parent Can be OVERRIDE not mandatory");
        }
    }
    class Child: Parent {
        public new void Display()
        {
            Console.WriteLine("child HIDING");
        }
        public override void Display2()
        {
            Console.WriteLine("child OVERRIDE");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //BASED ON REFERENCE TYPE TO CALL THE METHOD unlike override
            Parent parent = new Child();
            parent.Display(); //parent
            parent.Display2(); //child
            parent.Display3();



        }
    }
}
