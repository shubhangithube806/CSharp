using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_Loop_Exercise_While_Sum_Of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, n, sum = 0;
            Console.WriteLine("Enter your number : ");
            n = Convert.ToInt32(Console.ReadLine());

            while (i <= n)
            {
                sum += i;
                i++;
            }

            //Output

            Console.Write($"Sum of 1 to {n} is {sum}");

            Console.WriteLine();
        }

    }
}
