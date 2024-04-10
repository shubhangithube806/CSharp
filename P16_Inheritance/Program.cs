using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16_Inheritance
{
    class Program
    {
        //Inheritance
        //it is possible to inherit fields and methods from one class to another.
        //Derived Class (child) - the class that inherits from another class
        // Base Class(parent) - the class being inherited from
        //To inherit from a class, use the : symbol.
        //sealed Keyword - If you don't want other classes to inherit from a class, use the sealed keyword: 
        static void Main(string[] args)
        {
            Flowers rose = new Flowers();
            rose.name = "Rose";
            rose.color = "Pink";
            rose.shape = "open-cupped";
            rose.GetFlowerInfo();

            FragranceFlower mogra = new FragranceFlower();
            mogra.name = "Mogra";
            mogra.color = "White";
            mogra.shape = "star-shaped";
            mogra.fragrance = "Calm";
            mogra.GetFragrance();
            mogra.GetFlowerInfo();                 //we can access the members of parent class in child class
        }
    }

    // Flowers - Base Class (parent) - the class being inherited from
    class Flowers
    {
        public string name;
        public string color;
        public string shape;

        public void GetFlowerInfo()
        {
            Console.WriteLine($"{name} - {color} - {shape}");
        }
    }

    //FragranceFlower - Derived class (child) - the class that inherits from another class

    class FragranceFlower : Flowers      //To inherit from a class, use the : symbol.
    {
        public string fragrance;

        public void GetFragrance()
        {
            Console.WriteLine($"{name} - {color} - {shape} - {fragrance}");
        }
    }


        //Type of Inheritance - 


        //1.Single Inheritance
        //  C# supports Single Inheritance, meaning a class can inherit from only one base class.
        // Example

        class BaseClass
        {
            //Base class members
        }

        class DerivedClass : BaseClass  // single inheritance
        {
            //Derived class members
        }


        //2. Multiple Interface Inheritance
        //While C# supports only single class interface, it allows a class to implement multiple interfaces
        //This is a form of multiple inheritance through interface
        //Providing a way to share method signatures between classes without thecomplexities associated with multiple class interface
        //Example:

        interface IFirstInterface
        {
            //interface members
        }

        interface ISecondInterface
        {
            //Interface members
        }

        class MyClass : IFirstInterface, ISecondInterface    //Multiple Interface Inheritance
        {
            //Class members implementing both interfaces
        }


        //3.Multilevel Inheritance
        //In Multilevel Inheritance, a class can inherit from another class , and then another class can inherit from the second class.
        //This forms a chain of inheritance.
        //Example :

        class Grandparent
        {
            //Grandparent class members
        }

        class Parent : Grandparent   //Multilevel inheritance - Level 1
        {
            //Parent class members
        }

        class Child : Parent        //Multilevel inheritance - Level 2
        {
            //Child class members
        }


        //4.Hierarchical Inheritance
        //In hierarchical inheritance, multiple classes derived from a single base class.
        //Each derived class is a specialization of the common base class.
        //Example : 

        class BaseClass1
        {
            //Base class members
        }

        class DerivedClass1 : BaseClass1
        {
           //Derived class 1 members
        }

        class DerivedClass2 : DerivedClass1   //Hierarchical Inheritance - 1 Base (parent) class and 2 or more Derived (child) class
        {
            //Derived Class 2 members
        }

        //5. Hybrid Inheritance
        // Hybrid Inheritance is a combination of any two or more types of Inheritance
        //It is a directly supported in c#, but you can achieve it by combining single inheritance, multiple interface inheritance, multilevel inheritance, or hierarchial inheritance as needed.

        //Note : C# does not support multiple class inheritance, known as "multiple inheritance".
        //To avoid the diamond problem and maintain a simpler and more predictable language design.

        
    }
