using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loops
            //Loops can execute a block of code as long as a specified condition is reached.
            //Loops are handy because they save time, reduce errors, and they make code more readable.

            //1.While Loop
            //The while loop loops through a block of code as long as a specified condition is True:

            Console.WriteLine("while Loop:");
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            //2.Do/While Loop
            //The do/while loop is a variant of the while loop. 
            //This loop will execute the code block once, before checking if the condition is true, then it will repeat the loop as long as the condition is true.

            Console.WriteLine("Do/While Loop: ");
            int n = 0;
            do
            {
                Console.WriteLine(n);
                n++;
            }
            while (n < 5);


            //3.For Loop
            //When you know exactly how many times you want to loop through a block of code, use the for loop instead of a while loop:

            Console.WriteLine("do/while Loop");
            for (int j = 0; j <= 10; j = j + 2)
            {
                Console.WriteLine(j);
            }

            //4.Foreach Loop
            //There is also a foreach loop, which is used exclusively to loop through elements in an array:

            Console.WriteLine("Foreach Loop");

            string[] cars = {"Volvo", "BMW", "Ford", "Maza" };
            foreach (string g in cars)
            {
                Console.WriteLine(g);
            }

            //5.Break and Continue
            //Break
            //It was used to "jump out" of a switch statement.
            //The break statement can also be used to jump out of a loop.
            //This example jumps out of the loop when i is equal to 4:

            Console.WriteLine("Break: ");

            for (int h = 0; h < 10; h++)
            {
                if (h == 4)
                {
                    break;
                }
                Console.WriteLine(h);
            }

            //Continue
            //The continue statement breaks one iteration (in the loop), if a specified condition occurs, and continues with the next iteration in the loop.
            //This example skips the value of 4:

            Console.WriteLine("Continue: ");
            for (int h = 0; h < 10; h++)
            {
                if (h == 4)
                {
                    continue;
                }
                Console.WriteLine(h);
            }

            //Break and Continue in While Loop
            //You can also use break and continue in while loops:

            Console.WriteLine("Break in while Loop: ");

            int k = 0;
            while (k < 10)
            {
                Console.WriteLine(k);
                k++;
                if (k == 4)
                {
                    break;
                }
            }

            Console.WriteLine("Continue in while Loop: ");

            int a = 0;
            while (a < 10)
            {
                if (a == 4)
                {
                    a++;
                    continue;
                }
                Console.WriteLine(a);
                a++;
            }
        }
    }
}
