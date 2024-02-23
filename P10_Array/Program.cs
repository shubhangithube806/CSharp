using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays are used to store multiple values in a single variable, instead of declaring separate variables for each value.
            //To declare an array, define the variable type with square brackets:
            //string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            //To create an array of integers, you could write:
            //int[] myNum = {10, 20, 30, 40};

            string[] cars = { "Volvo", "BMW", "Ford", "Ertica" };

            //1.Access the Elements of an Array
            Console.WriteLine("Access the Elements of an Array: ");
            Console.WriteLine(cars[0]);                 //You access an array element by referring to the index number.

            //2.Change an Array Element
            Console.WriteLine("Change an Array Element: ");
            cars[0] = "Nexon";
            Console.WriteLine(cars[0]);

            //3.Array Length
            Console.WriteLine("Array Length: ");
            Console.WriteLine(cars.Length);

            //4.Loop Through Arrays
            //You can loop through the array elements with the for loop, and use the Length property to specify how many times the loop should run.

            Console.WriteLine("Loop Through Arrays: ");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            //5.The foreach Loop
            Console.WriteLine("The foreach Loop: ");

            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            //6.Sort an Array
            //There are many array methods available, for example Sort(), which sorts an array alphabetically or in an ascending order:

            //Sort a string
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            //Sort an int
            int[] myNumber = { 5, 1, 8, 9 };
            Array.Sort(myNumber);
            foreach (int i in myNumber)
            {
                Console.WriteLine(i);
            }

            //7.System.Linq Namespace
            //Other useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace:

            int[] myNum = { 8, 1, 5, 7, 9 };

            Console.WriteLine(myNum.Max());   //returns the largest value
            Console.WriteLine(myNum.Min());   // returns the smallest value
            Console.WriteLine(myNum.Sum());   // returns the sum of elements
        }
    }
}
