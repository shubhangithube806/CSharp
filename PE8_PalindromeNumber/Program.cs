using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, reverse = 0,reminder, numForOutput;

            Console.Write("Enter your number : ");
            num = Convert.ToInt32(Console.ReadLine());

            numForOutput = num;

            while (num > 0)
            {
                reminder = num % 10;
                reverse = (reverse * 10) + reminder;
                num = num / 10;
            }
            if (numForOutput == reverse)
            {
                Console.WriteLine("This is palindrome number.");
            }
            else
            {
                Console.WriteLine("This is not palindrome number.");
            }





        }
    }
}
