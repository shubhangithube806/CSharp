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
            int num, reverse = 0, reminder, initialNumber;

            Console.Write("Enter your number : ");
            num = Convert.ToInt32(Console.ReadLine());

            initialNumber = num;

            while (num > 0)
            {
                reminder = num % 10;
                reverse = (reverse * 10) + reminder;
                num = num / 10;
            }


            if (initialNumber == reverse)
            {
                Console.WriteLine($"{initialNumber} is palindrome number.");
            }
            else
            {
                Console.WriteLine($"{initialNumber} is not palindrome number.");
            }
        
        }
    }
}
