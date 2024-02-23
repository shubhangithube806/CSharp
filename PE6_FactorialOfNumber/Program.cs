using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE6_FactorialOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, factorial = 1;

            Console.Write("Enter your number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine($"Factorial of number {num} is {factorial}.");
        }
    }
}
