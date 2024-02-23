using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use the switch statement to select one of many code blocks to be executed.
            //The switch expression is evaluated once
            //The value of the expression is compared with the values of each case
            //If there is a match, the associated block of code is executed
            //Example

            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Looking forward");
                    break;
            }
            //Output is "Thursday" (day 4)
        }
    }
}
