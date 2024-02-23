using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_Loop_Exercise_for_each_characters_of_name
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            foreach (char c in name)
            {
                Console.WriteLine(c);
            }
        }
    }
}
