using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OOPs
{
    internal class Encapsulation
    {
        //private field
        private string _name;
        //public property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set {
                if (value >= 1) {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Age cannot be negative.");
                }
            }
        }


        public string Gender { get; set; }

        public override string ToString()
        {
            return $"Name = {Name} , Age ={Age}, Gender={Gender}";
        }
    

    }
}
