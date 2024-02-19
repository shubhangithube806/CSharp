using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Variables_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Area of Square (A = side * side)
            int a = 2;
            Console.WriteLine("1.Area of square is " + a * a);

            //2.Area of Triagle (A = 1/2 * base * height)
            int b = 10;
            int h = 4;
            Console.WriteLine("2.Area of Triagle is " + 0.5 * b * h);

            //3.Area of Circle (A = pi *r^2)
            int r = 4;
            const double pi = 3.14;
            Console.WriteLine("3.Area of Circle is " + pi * r * r);

            //4. Area of Rectangle (A = length * width)
            int l = 12;
            int w = 4;
            Console.WriteLine("4. Area of Rectangle is " + l * w);

        }
    }
}
