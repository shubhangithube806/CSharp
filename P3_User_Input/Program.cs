using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            //User Input

            //console.WriteLine() - is used to output(print) values
            //Console.ReadLine()  - is used to get user input

            //Example no.1
            //Type your username and press enter
            Console.WriteLine("Enter username:");

            //Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            //// Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);

            //Example no.2
            //The Console.ReadLine() method returns a string
            //You can convert any type explicitly(casting), by using one of the 'Convert.To' methods:

            Console.WriteLine("Enter your age:");

            int myAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your age is: " + myAge);











        }
    }
}
