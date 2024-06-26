﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Classes and Objects");

            //Multiple objects
            Car myObj1 = new Car();             //object
            Car myObj2 = new Car();
            Console.WriteLine(myObj1.model);
            Console.WriteLine(myObj2.color);

            Car myObj = new Car();
            myObj.weight = 500;
            myObj.maxSpeed = 200;
            Console.WriteLine(myObj.weight);
            Console.WriteLine(myObj.maxSpeed);

            myObj.CarMethod();      //Call the method

            Console.WriteLine("\n");
        }

        class Car                           //Class
        {
            //The public keyword is an accss modifier.
            //Used for classes, attributes, methods and constructors, making them accessible by any other class.

            //Class members
            //Fields and methods inside classes are often referred to as "Class Members"

            public string model = "BMW";            // Field
            public string color = "Black";

            //You can also leave the fields blank, and modify them when creating the object.
            public double weight;
            public int maxSpeed;

            public void CarMethod()
            {
                Console.Write($"\nThe model of car is {model} and it's cplor is {color}.");
                Console.WriteLine($" The weight of the car is {weight} and maximum speed of car is {maxSpeed}.");
            }
        }
    }
}
