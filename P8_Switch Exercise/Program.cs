using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_Switch_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double marathiMarks = 85;
            double englishMarks = 98;
            double physicsMarks = 75;
            double chemistryMarks = 89;
            double mathematicsMarks = 67;
            double biologyMarks = 67;

            string mySubject;

            Console.Write("Enter your subject: ");
            mySubject = Console.ReadLine();

            switch (mySubject)
            {
                case "Marathi":
                    Console.WriteLine($"Your marathi marks is {marathiMarks}");
                    break;
                case "English":
                    Console.WriteLine($"Your english marks is {englishMarks}");
                    break;
                case "Physics":
                    Console.WriteLine($"Your physics marks is {physicsMarks}");
                    break;
                case "Chemistry":
                    Console.WriteLine($"Your chemistry marks is {chemistryMarks}");
                    break;
                case "Mathematics":
                    Console.WriteLine($"Your mathematics marks is {mathematicsMarks}");
                    break;
                case "Biology":
                    Console.WriteLine($"Your biology marks is {biologyMarks}");
                    break;

            }
        }
    }
}
