using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4_Divisibility
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Enter your number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Check if it is divisible by: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 % num2 == 0)
            {
                Console.WriteLine($"{num1} is divisible by {num2}.");
            }
            else
            {
                Console.WriteLine($"{num1} is not divisible by {num2}.");
            }
        }
    }
}
