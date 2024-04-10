using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15_AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruits mango = new Fruits();
            //mango.name = "Apple";                     //Default(private) - The code is only accessible within the same class.
            //mango.color = "Red";                      //private - The code is only accessible within the same class.
            mango.averageWeight = 0.5;                  //public - The code is accessible for all the classes.
            //mango.test = "good";                      //protected - The code is  accessible within the same class, or in a class that is inherited from that class
            mango.GetFruitInfo();
            //mango.GetSweetness();

            SweetFruits apple = new SweetFruits();

            apple.averageWeight = 0.2;
            apple.GetFruitInfo();
            apple.howMuchSweetness = "A lot";
            apple.GetSweetness();
        }
    }

    class Fruits         //Default (if not given) access modifier for class itself is "internal".
    {
        string name;            //Default (if not given) access modifier for class members is "private".

        private string color;   //private - The  The code is only accessible within the same class.

        public double averageWeight;  //public - The code is accessible for all the classes.

        protected string test;        //protected - The code is  accessible within the same class, or in a class that is inherited from that class


        public  void GetFruitInfo()
        {
            Console.WriteLine($"Fruit info is {name} - {color} - {averageWeight} - {test}");
        }
    }

    class SweetFruits : Fruits
    {
        public string howMuchSweetness;

        public void GetSweetness()
        {
            //Console.WriteLine($"This is get sweetness method. {name} - {color}");   //1. "name" - Default (if not given) -Default access modifier for class members is "private".
            //2. "color" - private - The code is only accessible within the same class.

            Console.WriteLine($"This is get sweetness method. {averageWeight} - {test}"); //protected - The code is  accessible within the same class, or in a class that is inherited from that class.
        }
    }
}
