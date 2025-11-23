using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Lambda_Expressions
{
    internal class Program
    {
        public delegate void MyDelegate();
        static void Main(string[] args)
        {
            //are a shorter, cleaner syntax for writing anonymous methods
            //(parameters) => expression_or_block

            /*
             inp=<T> o/p=void => ACTION<T>                      [Perform an operation]
            inp=<T>  o/p=<T>  => Fuction<inp <T>,o/p <T>>       [Compute and return data]
            inp=<T>  o/p=bool => Predicate<T>                   [Testing conditions]


             */

            /*
                OLD1= DELEGATE=METHOD 
                OLD2= DELEGATE=ANONYMOUS
                OLD3= DELEGATE=LAMDA
                NOW=  RETURN TYPE=LAMMDA EXPRESSION
                                    LAMBDA EXPRESSION = (INP_PARAMETER){METHOD STATEMENTS};
             */

            MyDelegate d= () =>
            {
                Console.WriteLine("message from DELEGATE TO lamda ");

            };
            d();
            Action<string> Message = (msg) =>
            {
                Console.WriteLine("message from RETURN TYPE TO lamda ");
                Console.WriteLine(msg);
            };
            Message("From Isha");
        }
    }
}
