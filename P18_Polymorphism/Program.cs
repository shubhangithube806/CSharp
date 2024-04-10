using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18_Polymorphism
{
    //Polymorphism
    //Polymorphism means "many forms"
    //It occurs when we have many classes that are related to each other by inheritance.
    //there are two main types of polymorphism in c#:
    //1.Compile_Time Polymorphism - Method Overloading
    //2.Runtime Polymorphism - Overriding Methods
    class Program
    {
        static void Main(string[] args)
        {
            //1.Compile_Time Polymorphism - Method Overloading
            Console.WriteLine("1.Compile_Time Polymorphism - Method Overloading");

            Calculator calculator = new Calculator();

            int sum1 = calculator.Add(3, 5, 10);
            Console.WriteLine(sum1);

            double sum2 = calculator.Add(7, 15, 35);   //Method Overload - Rule 1 - Change the no. of parameter. 
            Console.WriteLine(sum2);

            double sum3 = calculator.Add(16, 8, 6);    //Method Overload - Rule 2 - Change the position of parameter.
            Console.WriteLine(sum3);

            double sum4 = calculator.Add(3.14,9.81);   //Method Overload - Rule 3 - Change the data type of parameter.
            Console.WriteLine(sum4);

            Console.WriteLine("\n");



            //2.Runtime Polymorphism - Overriding Methods
            Console.WriteLine(" //2.Runtime Polymorphism - Overriding Methods");

            Shape shape1 = new Shape();
            shape1.Draw();

            Shape shape2 = new Circle();        //We can use class construtor to create object of base class but we can not use base class constructor to create object of child class.
            shape2.Draw();

            Shape shape3 = new Triangle();
            shape3.Draw();
        }
    }



    //1.Compile_Time Polymorphism - Method Overloading
    //Compile_Time Polymorphism is achieve through Method Overloading.
    // Method Overloading allows you to define multiple mothods with the same name but different parameter lists
    //The compiler determines the appropriate method to call based on the number and types of arguments provided during the method call. 
    class Calculator
    {
        public int Add(int a, int b, int c)
        {
            return a + b;
        }

        public double Add(int a, double b)         //Method Overload - Rule 1 - Change the no. of parameter.
        {
            return a + b;
        }

        public double Add(double b, int a)          //Method Overload - Rule 2 - Change the position of parameter.
        {
            return a + b;
        }

        public double Add(double a, double b)            //Method Overload - Rule 3 - Change the data type of parameter.
        {
            return a + b;
        }
    }


    //2.Runtime Polymorphism - Overriding Methods
    //Runtime Polymorphism is achieve through Method Overriding .
    //Inheritance allowes a derived (child) class to provide a specific implementation of a method that is already defined in it's base (parent) class.
    //To perform method overriding in c# , you nedd to use virtual keyword with base method and override keyword with derived class method.

    class Shape
    {
        public virtual void Draw()                   //To perform method overriding in c# ,use virtual keyword with base class method. 
        {
            Console.WriteLine("Draw a shape.");  
        }
    }

    class Circle : Shape
    {
        public virtual void Draw()                   //To perform method overriding in c# ,use ovveride keyword with derived class method. 
        {
            Console.WriteLine("Draw a circle.");
        }
    }

    class Triangle : Circle
    {
        public virtual void Draw()                   //To perform method overriding in c# ,use ovveride keyword with derived class method. 
        {
            Console.WriteLine("Draw a triangle.");
        }
    }

}
