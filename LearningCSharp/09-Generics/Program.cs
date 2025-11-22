using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _09_Generics
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            /*
             DEF : PROVIDE COMMON GROUND FOR DIFF DATA TYPES 
             */
            int[] arr = { 1,2,3};
            long[] arr2 = { 100000000, 12 };
            string[] arr3 = { "abc", "bfjdm" };

            //without generics
            withoutGenerics obj = new withoutGenerics();
            obj.IntDisplay(arr);
            obj.LongDisplay(arr2);
            obj.StringDisplay(arr3);

            //with generics
            WithGenerics obj2 = new WithGenerics();
            obj2.CommonDisplay(arr);
            obj2.CommonDisplay(arr2);
            obj2.CommonDisplay(arr3);

            //Use case of genrics
            /*
             1. Generic Classes,interfaces: You can define classes that are generic, meaning they can operate on different data types. Common examples include List<T>, Dictionary<TKey, TValue>, Queue<T>, and Stack<T>
             2. Generic Methods: Methods can also be generic, allowing them to accept and return values of a type specified at the time of the method call.
             3. Constraints: Generics allow you to apply constraints to type parameters, restricting the types that can be used. This ensures that the generic code can safely perform operations on the types it receives. Examples of constraints include where T : class (reference type), where T : struct (value type), where T : new() (type with a parameterless constructor), and where T : IMyInterface (type implementing a specific interface).
             4. Collections : It makes the ArrayList that accept every type = not safe to List<T> = binding to a specific type making it =safe
             */

            //Generic class
            GenericClass<int> student1 = new GenericClass<int>();
            student1.SetName(1);
            GenericClass<String> student2 = new GenericClass<String>();
            student2.SetName("Isha");


        }
    }
}
