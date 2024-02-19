using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            //If Else


            //1.The if Statement
            //Use the if statement to specify a block of C# code to be executed if a condition is True.
            /* syntax
                     if(condition)
                    {
                        //block of code to be executed if the condition os True
                    } 
            */
            
            //Example 1
            if (20 > 16)
            {
                Console.WriteLine("20 is grater than 16");
            }

            //Example 2
            int x = 20;
            int y = 16;
            if (x > y)
            {
                Console.WriteLine("x is grater than y");
            }
            //2.The else Statement
            //Use the else statement to specify a block of code to be executed if the condition is False.
            /* syntax 
                 if (condition)
                 {
                    // block of code to be executed if the condition is True
                 } 
                 else 
                 {
                    // block of code to be executed if the condition is False
                 }
            */

            int time = 20;
            if (time < 15)
            {
                Console.WriteLine("Good day");
            }
            else
            {
                Console.WriteLine("Good evening");
            }

            //output is "Good evening"


            //3.The else if Statement
            //Use the else if statement to specify a new condition if the first condition is False.
            /* syntax
             if (condition 1)
             {
               // block of code to be executed if condition1 is True
            }
            else if (condition 2)
            {
              //block of code to be executed if the condition1 is false and condition2 is True
            }
            else 
            {
              //block of code to be executed if the condtion 1 and condition 2 is false
            }
            */

            int time1 = 20;
            if (time1 < 10)
            {
                Console.WriteLine("Good Morning");
            }
            else if (time1 < 15)
            {
                Console.WriteLine("Good Evening");
            }
            else
            {
                Console.WriteLine("Good Day");
            }
            //output is good evening


            //4.Short Hand If...Else (Ternary Operator)
            /* syntax
                    variable = (condition) ? expressionTrue : expressionFalse;
            */
            int time2 = 20;
            string result = (time2 < 10) ? "Good Day." : "Good Evening";
            Console.WriteLine(result);

        }
    }
}
