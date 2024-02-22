using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE5_Reverse_The_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, numberForOutput, reminder;
            int reverse = 0;

            Console.Write("Enter your number: ");
            number = Convert.ToInt32(Console.ReadLine());

            numberForOutput = number;

            while (number > 0)
            {
                reminder = number % 10;
                reverse = (reverse * 10) + reminder;

                number = number / 10;
            }

            Console.WriteLine($"\nThe reverse number of {numberForOutput} is {reverse}.");
        }
    }
}
