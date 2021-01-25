using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 22;
            char gender = 'F';
            String name = "Sharayu";
            double d = 234.54;

            Console.WriteLine("Hello....This is .NET batch 2021");

            Console.WriteLine("My name is " +name+ "and my age is " +age);

            Console.WriteLine("My name is {0} and my age is {1} with my gender {2}", name,age,gender);

            Console.WriteLine($"My name is {name} and my age is {age} with my gender {gender} ");

            int empId;
            string city, empName;
            float sal;

            Console.WriteLine("Enter Employee Id:");
            empId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name and city of employee:");
            empName = Console.ReadLine();
            city = Console.ReadLine();

            Console.WriteLine("Enter salary:");
            sal = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Employee Details");
            Console.WriteLine("-------------------");
            Console.WriteLine($"The key id is {empId} and name is {empName} with city is {city} ");
            Console.WriteLine($"Salary is {sal}");

        }
    }
}
