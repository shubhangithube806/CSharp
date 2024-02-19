using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables

            //Variables are containers for storing data values.
            //Defferent types of variables are:
            //1.int-    stores integers (whole numbers), without decimals, such as 123 or -123
            //2.double- stores floating point numbers, with decimals, such as 19.99 or -19.99
            //3.char-   stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
            //4.string-   stores text, such as "Hello World". String values are surrounded by double quotes
            //5.bool-     stores values with two states: true or false

            //syntax : type variableName = value

            string name = "Shubhangi";    //Create variable that should store text and asign value
            Console.WriteLine(name);

            int myNum = 25;               //Create variable that should store number and asign value
            Console.WriteLine(myNum);

            int num;                        //declare a variable 
            num = 35;                       //assigning the value
            Console.WriteLine(num);

            int number = 15;
            number = 20;                  //number is now 20
            Console.WriteLine(number);

            //Other Data Type
            int firstNum = 5;
            double myDoubleNum = 5.99D;
            Char myLetter = 'A';
            bool myBool = true;
            string myText = "Hello";


            //Constants
            //This will declare the variable as "constant", which means unchangeable and read-only:
            // You cannot declare a constant variable without assigning the value.

            const double PI = 3.14D;
            //PI = 5.67  this cause error
            //area of sphere is 4PIr^2
            Console.WriteLine("Area of sphere with radius 3m is "+ 4 * PI * 3 * 3 + " meter square");

            //Display Variables
            //The WriteLine() method is often used to display variable values to the console window.
            //To combine both text and a variable, use the + character:

            string myName = "Pravin";
            Console.WriteLine("Hello " + myName); //To combine text and variable use + character

            string firstName = "Shubhangi ";
            string lastName = "Gunjal";
            string fullName = firstName + lastName; //Adding a variable to another variable
            Console.WriteLine(fullName);

            int x = 10;
            int y = 15;
            Console.WriteLine(x + y);                //Print the value of x + y

            //Multiple Variables
            //To declare more than one variable of the same type, use a comma-separated list:
            int a = 5, b = 10, c = 6;
            Console.WriteLine(a + b + c);

            //You can also assign the same value to multiple variables in one line:
            int d, e, f;
            d = e = f = 10;
            Console.WriteLine(d + e + f);

            //Identifiers
            //Names can contain letters, digits and the underscore character(_)
            //Names must begin with a letter or underscore
            //Names should start with a lowercase letter and it cannot contain whitespace
            //Names are case sensitive("myVar" and "myvar" are different variables)
            //Reserved words(like C# keywords, such as int or double) cannot be used as names




        }

    }
}
