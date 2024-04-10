using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P20_Interface
{
    //Interfaces
    //Another way to achieve abstraction in C#, is with interfaces.
    //An interface is a completely "abstract class".
    //Like abstract classes, interfaces cannot be used to create objects 
    //Interfaces can contain properties and methods, but not fields/variables
    //It is considered good practice to start with the letter "I" at the beginning of an interface
    //as it makes it easier for yourself and others to remember that it is an interface and not a class.
    //By default, members of an interface are abstract and public.
    //To access the interface methods, the interface must be "implemented" (kinda like inherited) by another class.
    //On implementation of an interface, you must override all of its methods
    //Interface methods do not have a body - the body is provided by the "implement" class
    //Do not have to use the override keyword when implementing an interface.

    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();
            myPig.animalSound();
            myPig.animalColor();
        }
    }

    interface IAnimal              //Good practice to start with letter "I" at the begining of an interface.
    {                              //Like abstract classes, interfaces cannot be used to create objects.
                                   //Interface methods do not have a body.
        void animalSound();       //Which can only contain abstract methods and properties (with empty bodies).
    }                             //By default, members of an interface are abstract and public.

    interface IPigColor
    {
        void animalColor();
    }


    //Multiple interfaces
    class Pig : IAnimal, IPigColor //To implement an interface, use the : symbol (just like with inheritance).
    {                              //To implement multiple interfaces, separate them with a comma.
        public void animalSound()                        //Do not have to use the ovveride keyword when implemeting an interface
        {
            Console.WriteLine("The pig says: Wee wee"); //Interface methods body is provided by the "implement" class.
        }

        public void animalColor()
        {
            Console.WriteLine("The pig color: Black");
        }
    }

    //Why And When To Use Interfaces?
    //1) To achieve security - hide certain details and only show the important details of an object (interface).
    //2) C# does not support "multiple inheritance" (a class can only inherit from one base class).
    //3) However, it can be achieved with interfaces, because the class can implement multiple interfaces.
    //4)Note: To implement multiple interfaces, separate them with a comma (see example below)
}
