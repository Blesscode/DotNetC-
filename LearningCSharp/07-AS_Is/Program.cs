using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_AS_Is
{
    class Parent
    {
        public void parentM()
        {
            Console.WriteLine("Parent specific meth");
        }
        public virtual void CommomM()
        {
            Console.WriteLine("commmon parent call");
        }

    }
    class Child : Parent
    {
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
            //FOR SAFE DOWNCASTING : 

            //1 IS[CHECK]: an object is of a specified type (or can be safely converted to it).
            Parent p = new Child();
            if (p is Child) //Child c=(child)p;
            {
                Child c = (Child)p;
                Console.WriteLine("Cast worked");
            }
            else
            {
                Console.WriteLine("Invalid cast");
            }

            //2 AS[STRAIGHT CONVERT]:
            /*
             as tries to cast an object to a type:

                    If cast is successful → returns the converted object
                    If cast fails → returns null (does NOT throw exception)
            */
            Parent p2 = new Child();
            Child c2 = p as Child;
            if (c2 != null)
                Console.WriteLine("Safe cast worked");
            else
                Console.WriteLine("Cast failed");
        }
    }
}
