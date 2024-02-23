using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_FactorialOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //4! = 4*3*2*1 = 24 This is factorial

            int i, fact = 1, number;

            Console.Write("Enter your number : ");
            number = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine($"The factorial of {number} is {fact}.");

            Console.WriteLine();

        }
    }
}
