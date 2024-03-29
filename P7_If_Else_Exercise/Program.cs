﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7_If_Else_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            float marathi, english, physics, chemistry, mathematics, biology, totalMarks, percentage;
            string message, result, grade;

            Console.WriteLine("Enter your subjects marks - ");

            Console.Write("\nMarathi: ");
            marathi = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnglish: ");
            english = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPhysics: ");
            physics = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nChemistry: ");
           chemistry = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nMathematcs: ");
            mathematics = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nbiology: ");
            biology = Convert.ToInt32(Console.ReadLine());

            totalMarks = marathi + english + physics + chemistry + mathematics + biology;
            percentage = totalMarks / 6;

            if (percentage > 90)
            {
                grade = "O";
            }
            else if (percentage > 80)
            {
                grade = "A+";
            }
            else if (percentage > 70)
            {
                grade = "A";
            }
            else if (percentage > 60)
            {
                grade = "B+";
            }
            else if (percentage > 50)
            {
                grade = "B";
            }
            else if (percentage >= 35)
            {
                grade = "C";
            }
            else
            {
                grade = "F";
            }

            message = (percentage >= 35) ? "Congradulations!" : "Sorry,";
            result = (percentage >= 35) ? "Pass" : "Fail";

            Console.ForegroundColor = (percentage >= 35) ? ConsoleColor.Green : ConsoleColor.Red;

            Console.Write($"\n{message} you are {result}. Your percentage is {percentage} and Your grade is {grade}.\n\n;");

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
