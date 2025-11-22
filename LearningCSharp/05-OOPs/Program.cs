using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OOPs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*****************ENCASULATION**********************
            Encapsulation obj1= new Encapsulation();
            obj1.Name = "Isha";
            obj1.Age = 1;
            obj1.Gender = "F";

            //Object Initializer (Without Constructor)
            Encapsulation obj2 = new Encapsulation
            {
                Name="Isha",
                Age = 2,
                Gender = "F"
            };

           Console.WriteLine( obj1.ToString());
            Console.WriteLine(obj2.ToString());


            //INHERITANCE
            Inheritance obj3 = new Inheritance();
            obj3.CompileTime();
            obj3.RunTime();

            //ABSTRACTION
            Abstraction obj4 = new Abstraction();
            obj4.AbstractClassImpl();
            obj4.InterfaceImpl();
        }
    }
}
