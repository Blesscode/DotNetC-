using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _16_Expression_bodied_Members
{
    internal class PropertiesAndConstructor
    {
        public PropertiesAndConstructor(int age) => Age = age;
        private int age;
        public int Age
        {
            get => age;
            set=> age =(value>18)?value:-1;
        } //not <18
       
    }
}
