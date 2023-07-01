using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment2
{
    internal class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
       {
            this.name = name;
            this.age = age;
        }

         public void printNameAge()
        {
            Console.WriteLine($"your name is {name}, and your age is {age}");
        }

        public void printNameAge(int times)
        {
            for(int i = 0; i < times; i++)
            {
                Console.WriteLine($"your name is {name}, and your age is {age}");
            }
            
        }
    }
}
