using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace _17_Anonymous_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             LET YOU CREATE OBJS WITHOUT A CLASS

            FEATURES:
                - NON CHANGABLE VALUES
                - CANNOT DEFINE METHODS FOR THESE OBJS LIKE CLASS HAS METHODS
                - CAN USE ONLY INSIDE A SPECIFIC METHOD
                - READ ONLY PROPERTY
                - USED IN LINQ WITH TEMPORARY DATA REQUIRED
                - CREATE USING : VAR+{}

             */

            var Student = new { Name = "Isha", Age = 1 };
            Console.WriteLine(Student.Name);
            Console.WriteLine(Student.Age);
            Console.WriteLine(Student.GetType());//>f__AnonymousType0`2[System.String,System.Int32]


        }
    }
}
