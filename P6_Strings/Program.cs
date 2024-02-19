using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Strings
            //Strings are used for storing text.
            //A string variable contains a collection of characters surrounded by double quotes:

            //Create a variable of type string and assign it a value:
            string name = "Shubhangi";
            Console.WriteLine(name);

            //String Length
            string txt = "shubhangipravingunjal";
            Console.WriteLine("The length of the txt string is: " + txt.Length);

            //Other methods
            string txt1 = "Hello World";

            Console.WriteLine(txt1.ToLower());

            Console.WriteLine(txt1.ToUpper());

            //String Concatenation:
            //1.Using + operator
            //The + operator can be used between strings to combine them. This is called concatenation:
            string firstName = "Shubhangi";
            string lastName = "Gunjal";
            string name1 = firstName + lastName;
            Console.WriteLine(name1);

            //2.string.Concat()
            string firstName1 = "Shubhangi";
            string lastName1 = "Gunjal";
            string name2 = string.Concat(firstName1, lastName1);
            Console.WriteLine(name2);

            //3.Adding Numbers and String

            //If you add two numbers, the result will be a number:
            int x = 10;
            int y = 15;
            int z = x + y;            //z will be 30(an integer/number)
            Console.WriteLine(z);

            //If you add two strings, the result will be a string concatenation:
            string a = "10";
            string b = "15";
            string c = a + b;        //c will be 1050 (a string)
            Console.WriteLine(c);


            //String Interpolation
            //Another option of string concatenation, is string interpolation
            //It substitutes values of variables into placeholders in a string. 
            //You do not have to worry about spaces, like with concatenation:
            string firstName2 = "Shubhangi";
            string lastName2 = "Gunjal";
            string name3 = $"My full name is: {firstName2} {lastName2}";
            Console.WriteLine(name3);

            //Access Strings
            //You can access the characters in a string by referring to its index number inside square brackets [].

            string myString = "Shubhangi";

            Console.WriteLine(myString[0]);    //prints the first character in myString:  The output is "s"
            Console.WriteLine(myString[1]);    //output is "h"

            Console.WriteLine(myString.IndexOf("b"));  //output is 3

            //Substring()
            //which extracts the characters from a string, starting from the specified character position/index, and returns a new 
            //string. This method is often used together with IndexOf() to get the specific character position:

            //Full name
            string name4 = "Shubhangi Gunjal";

            //Location of the letter G
            int locatn = name4.IndexOf("G");

            //Get last name
            string lastName4 = name4.Substring(locatn);

            //Print the result
            Console.WriteLine(lastName4);


            //Special Characters
            //Strings - Special Characters
            //Because strings must be written within quotes

            //The sequence \'  inserts a single quote in a string:
            string text = "It\'s alright.";
            Console.WriteLine(text);

            //The sequence \"  inserts a double quote in a string:
            string text1 = "I im so \"impress\" on you";
            Console.WriteLine(text1);

            //The sequence \\  inserts a single backslash in a string:
            string text3 = "A book \\ A table";
            Console.WriteLine(text3);


            //Other usefull escape charecters in c# are:
            //  \n for new line
            //  \t for tab
            // \b for backspace

        }
    }
}
