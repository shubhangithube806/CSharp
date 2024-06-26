﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_MethodsExerciseIntroductionUsingMethodAndFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduction:");

            string[] skills = { "HTML", "CSS", "JavaScript", "C#" };
            string[] languages = { "Marathi", "Hindi", "English" };
            string[] strengths = { "self motivated", "punctual person" };
            string[] hobbies = { "spending time with friends", "watching reality shows", "cocking", "listening to music" };
            double[] allCGPA = { 9.45, 8.45, 7.45, 6.45 };

            Introduction("Shubhangi", "Gunjal", 24, "Sangamner", "Mumbai", "BSC", "Arts Science and commerce college, Rahuri", skills, languages, strengths, hobbies, allCGPA);

            Console.WriteLine();

        }

        static void Introduction(string firstName, string lastName, int age, string nativePlace, string currentLocation, string degreeName, string collegeName,
            string[] skills, string[] languages, string[] strengths, string[] hobbies, double[] allCGPA)
        {
            string fullName = firstName + " " + lastName;

            Console.Write("Hello everyone,");
            Console.Write($"My name is {fullName}.");
            Console.Write($"I am {age} year's old.");
            Console.Write($"I am from {nativePlace} currently living in {currentLocation}.");
            Console.Write($"I have completed my {degreeName} from {collegeName}.");

            StringArrayToText(skills, "skills");
            StringArrayToText(languages, "languages");
            StringArrayToText(strengths, "strengths");
            StringArrayToText(hobbies, "hobbies");

            Console.WriteLine($"My aggregate CGPA is {TotalCGPA(allCGPA)}");
        }

        static void StringArrayToText(string[] input, string name)
        {
            Console.Write($"\nMy {name} are ");

            for (int i = 0; i < input.Length; i++)
            {
                string lastText = (i == input.Length - 1) ? "." : ",";

                Console.Write($"{input[i]}{lastText}");
            }
        }
      
        static double TotalCGPA(double[] allCGPA)
        {
            Console.WriteLine("\nI have CGPA in each year as folllows, ");
            Console.WriteLine($"- First year CGPA is {allCGPA[0]}");
            Console.WriteLine($"- Second year CGPA is {allCGPA[1]}");
            Console.WriteLine($"- Third year CGPA is {allCGPA[2]}");
            Console.WriteLine($"- Fourth year CGPA is {allCGPA[3]}");

            double aggregateCGPA = (allCGPA[0] + allCGPA[1] + allCGPA[2] + allCGPA[3]) / 4;

            return aggregateCGPA;
        }


    }
}
