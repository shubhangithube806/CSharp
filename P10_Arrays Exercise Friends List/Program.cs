using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_Arrays_Exercise_Friends_List
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] positions = new string[5] { "first", "second", "third", "fourth", "fofth" };
            string[] friendList = new string[5];

            Console.WriteLine("Enter your 5 friends name: ");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter your {positions[i]} friends name : ");
                friendList[i] = Console.ReadLine();
            }

            Array.Sort(friendList);

            //Output
            Console.WriteLine($"\n\nYour friends names are as follows: ");
            foreach (string friends in friendList)
            {
                Console.WriteLine(friends);
            }
        }
    }
}
