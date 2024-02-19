using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_Data_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Types
            //A data type specifies the size and type of variable values.
            // The most common data types are:

            //1.int  (Stores whole numbers from -2,147,483,648 to 2,147,483,647)
            int myNum = 100000;
            Console.WriteLine(myNum);

            //2.long  (Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,8070)
            long num = 15000000000000L;  //End the value with 'L'
            Console.WriteLine(num);

            //3.float  (Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits)
            //Number with decimal 9.99 or 3.14515
            float num1 = 5.75F;         //End the value with 'F'
            Console.WriteLine(num1);

            //4.double  (Stores fractional numbers. Sufficient for storing 15 decimal digits)
            double num2 = 19.98D;       // End the value with 'D'
            Console.WriteLine(num2);

            //5.bool  (Stores true or false values)
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun); //Output True
            Console.WriteLine(isFishTasty); //Output False

            //6.char  (Stores a single character/letter, surrounded by single quotes)
            char myGrade = 'A';
            Console.WriteLine(myGrade);

            //7.string (Stores a sequence of characters, surrounded by double quotes)
            string myText = "Hello Pravin";
            Console.WriteLine(myText);


            //Type Casting
            //Type casting is when you assign a value of one data type to another type.

            //Two types of casting
            //1.Implicit Casting(automatically) -converting a smaller type to a larger type size
            //char -> int -> long -> float -> double
            int myInt = 9;
            double myDouble = myInt;      //Automatic casting:int to double

            Console.WriteLine(myInt);    //Outputs 9
            Console.WriteLine(myDouble); //Outputs 9


            //2.Explicit Casting(manually) - converting a larger type to a smaller size type
            // double -> float -> long -> int -> char
            //Explicit casting must be done manually by placing the type in parentheses in front of the value:
            double myDouble1 = 9.57;
            int myInt1 = (int)myDouble1; // Manual casting: double to int

            Console.WriteLine(myDouble1); //Outputs 9.57
            Console.WriteLine(myInt1);    //Outputs 9

            //Type Conversion Methods
            //It is also possible to convert data types explicitly by using built-in methods, such as
            //Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long):

            int myInt2 = 10;
            double myDouble2 = 5.78;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt2));   //convert int to string

            Console.WriteLine(Convert.ToDouble(myInt2));   //convert int to double

            Console.WriteLine(Convert.ToInt32(myDouble2)); //convert double to int

            Console.WriteLine(Convert.ToString(myBool));   //convert bool to string


        }
    }
}
