using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace _09_Generics
{
    internal class GenericConstraints
    {
        /*Set constration on class identified by T and where*/
        public class Parent { }
        public interface IParent { }

        //1. Must be a class
        public class test<T> where T : class { }
        //2. Must have a parameterless constructor
        public class test2<T> where T : new() { }
        //3. Must inherit a base class
        public class test3<T> where T : Parent { }
        //4. Must implement an interface
        public class test4<T> where T : IParent { }
    }
}
