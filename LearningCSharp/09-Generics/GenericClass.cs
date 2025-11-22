using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Generics
{
    internal class GenericClass<T>
    {

            private T Name;
            public void SetName(T Name)
            {
                this.Name = Name;
            }
            public T GetName()
            {
                return this.Name;
            }
  
    }
}
