using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _05_OOPs
{
    internal class Animal 
    {
        public Animal() {
            Console.WriteLine("Parent Default Constructor: " );
        }
        public Animal(bool pet)
        {
            Console.WriteLine("Parent pet present Constructor: ");
        }
        public Animal(string name):this(true)
        {
            Console.WriteLine("Parent Constructor: " + name);
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("Can make sound");
        }
        public virtual void IsAnimal()
        {
            Console.WriteLine("yes");
        }
    }
    internal class Dog : Animal
    {
        public Dog() : base("TomDog")
        {
            Console.WriteLine("Child Constructor");
        }
        public Dog(String name)
        {
            Console.WriteLine("new dog");
        }
        public override void MakeSound() {
            Console.WriteLine("Bark");
        }
        public void Eats()
        {
            Console.WriteLine("dog food");
        }
    }
    internal class Inheritance
    {
        //compile time
        public void CompileTime()
        {
            Animal a1 = new Animal();
            Animal a2 = new Animal(true);
            Animal a3 = new Animal("Sheru");

            Dog dog = new Dog();
            Dog dog2 = new Dog("john");

        }
        //run time
        public void RunTime()
        {
            Animal a1 = new Animal();
            a1.IsAnimal();
            a1.MakeSound();
            Animal a2 = new Animal(true);
            a2.IsAnimal();
            a2.MakeSound();
            Animal a3 = new Animal("Sheru");
            a3.IsAnimal();
            a3.MakeSound();


            Dog dog = new Dog();
            dog.MakeSound();
            dog.IsAnimal();
            dog.Eats();
            Dog dog2 = new Dog("john");
            dog2.MakeSound();
            dog2.IsAnimal();
            dog2.Eats();

            Animal an = new Dog();
            an.MakeSound(); //child
            an.IsAnimal();
            //an.Eats();

            Animal an2 = new Dog("john");
            an2.MakeSound(); //child
            an2.IsAnimal();

            /*
             USE CASE OF BELOW : ACCESS THE CHILD PRIVATE/SPECIFIC METHOD USING PARENT [DOWNCASTING]
             USE CASE OF UPCASTING[SAVE FROM RUNTIME ERROR] : OVERRIDING, WHERE YOU WANT CHILD METHOD TO RUN WITH PARENT REFERENCE
             */
            //runtime error resolve:
            //Dog dn =(Dog) new Animal();
            Animal anz = new Dog();//upcasting
            Dog dn = (Dog)anz;//downcasting

        }
    }
}
