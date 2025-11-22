using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OOPs
{
    //Interface : need interface keyword,no need for virtual,override in imple class
    //Abstract : need for abstract in class,method & override in impl class
    public interface MyInterface
    {
        void Display1();  
    }
    public abstract class AbstractClass{
        public abstract void Display2();
    }
    public class Child1 : MyInterface
    {
        public void Display1()
        {
            Console.WriteLine("Interface implemented");
        }
    }
    public class Child2 : AbstractClass
    {
        public  override void Display2()
        {
            Console.WriteLine("Abstract class implemented");
        }
    }
    internal class Abstraction
    {
        public void InterfaceImpl() { 
        //Interface
            MyInterface m1 =new Child1();
            m1.Display1();
        }

        //Abstraction
        public void AbstractClassImpl()
        {
            AbstractClass m2 = new Child2();
            m2.Display2();
        }
    }
}
