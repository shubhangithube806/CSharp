using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE7_SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        { 
            int num, sum = 0, reminder, numForOutput;

            Console.Write("Enter your number : ");
            num = Convert.ToInt32(Console.ReadLine());

            numForOutput = num;

            while (num > 0)
            {
                reminder = num % 10;
                sum = sum + reminder;
                num = num / 10;
            }

            Console.WriteLine($"The sum of {numForOutput} is {sum}.");
        }
    }
}
