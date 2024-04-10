using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P19_Abstraction
{

    //Abstraction
    //Data abstraction is the process of hiding certain details and showing only essential information to the user.
    //Abstraction can be achieved with either abstract classes or interfaces
    //The abstract keyword is used for define classes and methods:

    //1.Abstract class: 
    //Abstract class is a restricted class that cannot be used to create objects
    //To access Abstract class, it must be inherited from another class
    //An abstract class can have both abstract and regular methods:

    //2.Abstract method:
    //Abstract method can only be used in an abstract class.
    // It does not have a body.
    //The body is provided by the derived (Child) class (inherited from).
    //You must have to provide body.
    //Base class and derived class has method with same name.
    //Use abstract keyword for base class method and override keyword for derived class method.
    class Program
    {
        static void Main(string[] args)
        {
            //Birds bird = new Birds();        //Abstract class is a restricted class that cannot be used to create objects

            Peacock myPeacock = new Peacock();
            myPeacock.birdsSound();
            myPeacock.color();
        }
    }

    abstract class Birds                      //An abstract class can have both abstract and regular methods:
    {
        public abstract void birdsSound();   //Abstract method can only be used in an abstract class.
                                             // Abstract method  does not have a body, it's  body is provided by the derived (Child) class (inherited from). 
        public void color()                 //Regular method
        {
            Console.WriteLine("A color of Peacock is metallic blue and green.");
        }
    }
        class Peacock : Birds              //To access Abstract class, it must be inherited from another class
        {
            public override void birdsSound()       //Abstract method body is provided by the derived class (inherited from).
            {
                Console.WriteLine("The Peacock says : meow meow");
            }

        }
}
