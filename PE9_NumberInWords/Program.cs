using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE9_NumberInWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, reminder = 0;
            string text = "";

            string[] numberText = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

            Console.Write("Enter your number : ");
            num = Convert.ToInt32(Console.ReadLine());

            while (num > 0)
            {
                reminder = num % 10;
                text = numberText[reminder] + " " + text;
                num = num / 10;
            }

            Console.WriteLine(text);
           
        }
    }
}
