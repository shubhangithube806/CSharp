using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_MethodOverloadingExerciseAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            int addition1 = AdditonMethod(3, 5, 7);
            double addition2 = AdditionMethod(6, 5.7);
            double addition3 = AdditionMethod(2.5, 8);
            double addition4 = AdditionMethod(4.3, 6.5);

            Console.WriteLine("\nAddition of 3 integer numbers : " + addition1);
            Console.WriteLine("\nAddition of 1 integer and 1 double number : " + addition2);
            Console.WriteLine("\nAddition of 1 double number and 1 integer number : " + addition3);
            Console.WriteLine("\nAddition of 2 double mumbers : " + addition4);

            Console.WriteLine();
        }

        static int AdditonMethod(int x, int y, int z)
        {
            return x + y + z;
        }

        //Method overload - Rule 1 - Change the number of parameter.
        static double AdditionMethod(double x, int y)
        {
            return x + y;
        }

        //Method overload - Rule 2 - Change the position of parameter.
        static double AdditionMethod(int x, double y)
        {
            return x + y;
        }

        //Method overload - Rule 1 - Change the datatype of parameter.
        static double AdditionMethod(double x, double y)
        {
            return x + y;
        }
    }
}
