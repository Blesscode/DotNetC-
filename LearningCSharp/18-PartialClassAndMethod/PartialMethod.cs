using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_PartialClassAndMethod
{
    /*Use version C# 9+ */
   public partial class Student{
        public partial void Greetings();
        public partial void Attendance();
    }
    public partial class Student
    {
        public partial void Greetings()
        {
            Console.WriteLine("Hello students");
        }
    }

    internal class PartialMethod
    {
        /*
         A partial method lets you:

                Declare the method in one part
                Optionally implement it in another file
         If implementation is missing, the compiler:
                Removes the method call
                Does NOT give an error
                Does NOT generate unnecessary IL code
         
         */
        public void PartialMethodImpl() { 
            Student s = new Student();
            s.Greetings();
        }
    }

}
