using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_Constructors
{
    //Constructors
    //1.Constructors is a special method that is used to initialize (create) object.
    //2.Constructors always called when the object is created.
    //3.Constructors can be used to set initial values for field.
    //4.Constructors name must match to the class name.
    //5.Constructors can not have return type (like void or int).
    //6.Constructors can also take parameters, which is used to initialze the fields.
    //7.Just like other method , constructor can be overloaded by using different numbers of parameter.
    //8.All classes have constructors by default : if you do not create a class constructor yourself, C# create one for you.

    class Program
    {
        static void Main(string[] args)
        {
            Car ford = new Car("Figo", "Black", 2010, 1016);     //1.Constructor is aspecial method that is used to initialize (creat) object.
                                                                 //2.Constructor always called when the object is crated.

            Console.WriteLine($"{ford.model} - {ford.color} - {ford.year} - {ford.weight} kg");

            Car tata = new Car("Safari", 2017);                 //Car Constructor 2nd overload.

            Console.WriteLine($"{tata.model} - {tata.year}");

            Console.WriteLine();
        }
    }

    class Car
    {
        public string model;            //Fields

        public string color;

        public int year;

        public int weight;

        public Car(string modelName, string modelColor, int modelYear, int modelWeight) //4.Constructor name must match the class name.
        {                                                                               //5.Constructor can have return type (like void or int).
            model = modelName;
            color = modelColor;
            year = modelYear;
            weight = modelWeight;                                                       //6.Constructor can be used to set initial values for fields.
        }

        public Car(string modelName, int modelYear)                                     //7.Just like other methods, Constructro can be overloaded by using different numbers of parameters.
        {
            model = modelName;
            year = modelYear;
        }
    }
}
