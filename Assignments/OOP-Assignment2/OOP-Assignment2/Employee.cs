using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment2
{
    internal class Employee
    {
        string name;
        int age;
        double salary;

        public void printData()
        {
            Console.WriteLine($"Your name is {name}, and your age is {age}," +
                "and your salary is {salary}");
        }
        public void printData(int times)
        {
            for(int i = 0; i < times; i++)
            {
                Console.WriteLine($"Your name is {name}, and your age is {age}," +
                "and your salary is {salary}");
            }  
            
        }
    }
}
