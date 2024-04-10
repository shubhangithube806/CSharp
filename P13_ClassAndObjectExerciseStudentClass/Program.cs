using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ClassAndObjectExerciseStudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student shubhangi = new Student();
            shubhangi.firstName = "Shubhangi";
            shubhangi.lastName = "Gunjal";
            shubhangi.birthYear = 1999;
            shubhangi.rollNo = 24;
            shubhangi.city = "Sangamner";
            shubhangi.weight = 45;

            shubhangi.GetStudentInfo();

            Student pravin = new Student();
            pravin.firstName = "Pravin";
            pravin.lastName = "Gunjal";
            pravin.birthYear = 1994;
            pravin.rollNo = 30;
            pravin.city = "Mumbai";
            pravin.weight = 67;

            pravin.GetStudentInfo();

            Student pradip = new Student();
            pradip.firstName = "Pradip";
            pradip.lastName = "Jathar";
            pradip.birthYear = 1999;
            pradip.rollNo = 28;
            pradip.city = "Pune";
            pradip.weight = 65;

            pradip.GetStudentInfo();

            Student swati = new Student();
            swati.firstName = "Swati";
            swati.lastName = "Jathar";
            swati.birthYear = 2001;
            swati.rollNo = 34;
            swati.city = "Malevadi";
            swati.weight = 47;

            swati.GetStudentInfo();

        }
    }

    class Student
    {
        //Fields

        public string firstName;        //variable

        public string lastName;         //variable

        public int birthYear;           //variable

        public int rollNo;               //variable

        public string city;              //variable

        public double weight;            //variable


        //Methods
        public void GetStudentInfo()        //method
        {
            string fullName = firstName + " " + lastName;

            Console.WriteLine($"My name is {fullName}. My age is {StudentAge()} and my weight is {weight}. I am from {city}. My roll no. is {rollNo}.");

            Console.WriteLine();
        }

        public int StudentAge()             //method
        {
            int age = 2024 - birthYear;

            return age;
        }

    }
}
