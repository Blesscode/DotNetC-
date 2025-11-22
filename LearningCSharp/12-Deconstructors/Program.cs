using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Deconstructors
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Deconstruct(out String name,out int age)
        {
            name=Name;
            age=Age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*DECONSTRUCT : MAKE INDIVIDUAL VARIABLE OUT FROM OBJECT MEMBERS*/
            Student s1 = new Student
            {
                Name = "Isha",
                Age = 1
            };
            //var (a, b) = s1;
            (string n, int a) = s1;
            Console.WriteLine(n);
            Console.WriteLine(a);
        }
    }
}
