using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operators
            //Operators are used to perform operations on variables and values.

            //1.Arithmetic Operators
            //Used to perform common mathematical operations:

            Console.WriteLine("1.Arithmetic Operators: ");

            //1)Addition (+) Operator:
            int x = 5;
            int y = 6;
            Console.WriteLine(x + y);

            //2)Subtraction (-) Operator:
            int z = 15;
            int g = 10;
            Console.WriteLine(z - g);

            //3)Multiplication (*) Operator:
            int a = 6;
            int b = 4;
            Console.WriteLine(a * b);

            //4)Division (/) Operator:
            int C = 20;
            int d = 5;
            Console.WriteLine(C / d);

            //5)Modulus (%) Operator (Returns the division remainder):
            int e = 27;
            int f = 5;
            Console.WriteLine(e % f);

            //6)Increment (++) Operator:
            int h = 5;
            h++;
            Console.WriteLine(h);

            //7)Decrement (--) Operator (Decreases the value of a variable by 1	):
            int j = 5;
            j--;
            Console.WriteLine(j);

            //2.Assignment Operators
            //Assignment operators are used to assign values to variables.

            Console.WriteLine("2.Assignment Operators: ");

            //1)Assignment (=) Operators:
            int k = 19;
            Console.WriteLine("Assignment: " + k);

            //2)Addition (+=) assignment:
            int x1 = 10;
            x1 += 5;
            Console.WriteLine("Addition: " + x1);

            //3)Substration (-=) assignment:
            int x2 = 10;
            x2 -= 5;
            Console.WriteLine("Substration: " + x2);

            //4)Multiplication (*=) assigment:
            int x3 = 6;
            x3 *= 2;
            Console.WriteLine("Multiplication : " + x3);

            //5)Division (/=) assignment:
            int x4 = 10;
            x4 /= 2;
            Console.WriteLine("Division: " + x4);

            //6)Modulus (%=) assignment:
            int x5 = 18;
            x5 %= 7;
            Console.WriteLine("Modulus: " + x5);

            //7)Bitwise And (&=) assignment:
            int x6 = 6;
            x6 &= 2;
            Console.WriteLine("Bitwise And: " + x6);

            //8)Bitwise OR (|=) assignment:
            int x7 = 6;
            x7 |= 2;
            Console.WriteLine("Bitwise OR: " + x7);

            //9)Bitwise Exclusive OR (XOR) (^=) assignment:
            int x8 = 6;
            x8 ^= 2;
            Console.WriteLine("Bitwise Exclusive OR: " + x8);

            //10)Right shift (>>=) assignment:
            int x9 = 6;
            x9 >>= 2;
            Console.WriteLine("Right shift: " + x9);

            //11)Left shift (<<=) assinment:
            int x10 = 6;
            x10 <<= 2;
            Console.WriteLine("Left shift: " + x10);

            //3.Comparison Operators
            //Comparison operators are used to compare two values (or variables).
            //The return value of a comparison is either True or False.

            Console.WriteLine("3.Comparison Operators: ");
            int n = 15;
            int m = 10;
            //1)Equal to (==)
            Console.WriteLine(n == m);

            //2)Not equal (!=)
            Console.WriteLine(n != m);

            //3)Greater than (>)
            Console.WriteLine(n > m);

            //4)Less than (<)
            Console.WriteLine(n < m);

            //5.Greater than or equal to (>=)
            Console.WriteLine(n >= m);

            //6.Less than or equal to (<=)
            Console.WriteLine(n <= m);

            //4.Logical Operators
            //Logical operators are used to determine the logic between variables or values:
            //As with comparison operators, you can also test for True or False values with logical operators.

            Console.WriteLine("4.Logical Operators: ");
            int A = 6;

            //1)Logic and (&&) (Returns True if both statements are true)
            Console.WriteLine(A > 5 && A < 10);

            //2)Logical or (||) (Returns True if one of the statements is true)
            Console.WriteLine(A > 5 || A < 10);

            //3)Logical not (!) (Reverse the result, returns False if the result is true)
            Console.WriteLine(!(A > 5 && A < 10));










        }

    }
}
