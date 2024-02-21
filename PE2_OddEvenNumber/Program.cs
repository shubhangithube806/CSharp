using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE2_OddEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Please enter your number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is even number.");
            }
            else
            {
                Console.WriteLine($"{num} is odd number.");
            }
        }
    }
}
