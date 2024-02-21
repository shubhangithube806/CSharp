using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE1_Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            int addition, num1, num2;
            

            Console.Write("Enter your first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            addition = num1 + num2;

            Console.WriteLine($"Addition of {num1} and {num2} is {addition}.");
        }
    }
}
