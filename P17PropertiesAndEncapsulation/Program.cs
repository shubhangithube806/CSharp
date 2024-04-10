using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P17PropertiesAndEncapsulation
{

    //Encapsulation
    //The meaning of Encapsulation, is to make sure that "sensitive" data is hidden from users.
    // To achieve this, you must:
    //Declare class variables/attributes as private
    //provide public get and set methods, through properties, to access and update the value of a private field.

    //Properties
    //Aproperty is like a combination of a variable and a mothod, and it has two methods : a get and a set method:

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Shubhangi";
            employee.LastName = "Gunjal";
            //employee.FullName = "Shubhangi Gunjal";      // Full name has only get method , so it is read only property. You can not set value to FullName.
            employee.Age = 24;
            //employee.salary = 30000.40;                  // You can not access the private variable salary in other class.
            employee.Salary = 30000.40;                    //To get or set value private variable salary, use Salart Property.

            Console.WriteLine($"My first name is {employee.FirstName} and last name is {employee.LastName}.");
            Console.WriteLine($"My full name is {employee.FullName}.");                                        //Full name has only get method , so it is read-only property. so you can only access its value.
            //Console.WriteLine($"My age is {employee.Age}.");                                                 //Age has only set method , so it is write-only property. you can not get value to Age.
           // Console.WriteLine($"My salary is {employee.salary}.");                                           //You can not access the private variable salary in other class
            Console.WriteLine($"My Salary is {employee.Salary}");                                              //To get or set value to private variable salary, use Salary property.
        }
    }

    class Employee
    {
        private double salary;                  //For Encapsulation - declare fields/variables as private

        public double Salary                    //For Encapsulation - provide public get and set methods, through properties, to access and update the value of a private field.
        {
            get { return salary; }

            set { salary = value; }
        }

        public string FirstName { get; set; }               //Normal properties

        public string LastName { get; set; }                //Normal properties

        public string FullName
        {                                                   //read-only (if you only use the get method)
            get
            {
                string fullname = $"{FirstName} {LastName}";
                return fullname;
            }
        }

        public int Age
        {
            set { }                                        //write-only (if you only use the set method)
        }
    }

    //Why Encapsulation?
    //Better control of class members (reduce the possibility of yourself (or others) to mess up the code)
    //Fields can be be made read-only (if only use the get method), or write-only (if you only use the set method)
    //Flexible: the programer can change one part of the code without affecting other parts
    //Increased security of data
}
