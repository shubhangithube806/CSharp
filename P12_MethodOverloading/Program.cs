using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method overloading -Intro
            //With method overloading, multiple methods can have the same name with different parameters:

            Intro("Pravin", "Gunjal", 27);

            Intro("Shubhangi Gunjal", 24);   //Method overloading  - Rule 1 - Change the number of parameter. 

            Intro(25, "Pradip Jathar");      //Method overloading  - Rule 2 - Change the position  of parameter. 

            Intro(22.5, "Swati Jathar");     //Method overloading  - Rule 3 - Change the data of parameter. --> (if you required same position). 
        }

        //Method (void Method - Method with no return value)

        //Method overload

        static void Intro(string firstName, string lastName, int age)
        {
            string fullName = firstName + " " + lastName;

            Console.WriteLine("Hii,");
            Console.WriteLine($"My name is {fullName}.");
            Console.WriteLine($"My age is {age}.\n");
        }

        //Method overloading - Rule 1 - Change the number of parameter.
        static void Intro(string fullName,int age)
        {
            Console.WriteLine("Rule 1 - Change the number of parameter.");
            Console.WriteLine("Hii,");
            Console.WriteLine($"My name is {fullName}.");
            Console.WriteLine($"My age is {age}.\n");
        }

        //Method overloading - Rule 2 - Change the position of parameter.
        static void Intro(int age, string fullName)
        {
            Console.WriteLine("Rule 2 - Change the position of parameter.");
            Console.WriteLine("Hii,");
            Console.WriteLine($"My name is {fullName}.");
            Console.WriteLine($"My age is {age}.\n");
        }

        //Method overloading - Rule 3 - Change the datatype of parameter if you required same position.
        static void Intro(double age, string fullName)
        {
            Console.WriteLine("Rule 3 - Change the datatype of parameter if you required same position.");
            Console.WriteLine("Hii,");
            Console.WriteLine($"My name is {fullName}.");
            Console.WriteLine($"My age is {age}.\n");
        }

    }
}
