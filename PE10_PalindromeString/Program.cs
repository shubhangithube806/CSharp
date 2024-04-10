using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE10_PalindromeString
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString;

            Console.Write("Enter your string : ");
            myString = Console.ReadLine();

            char[] charArray = myString.ToCharArray();
            Array.Reverse(charArray);

            string reversedString = new string(charArray);

            if (myString == reversedString)
            {
                Console.WriteLine($"{myString} is palindrome string.");
            }
            else
            {
                Console.WriteLine($"{myString} is not palindrome string.");
            }

        }
    }
}
