using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5
{
    internal class Person
    {
        public int id;
        public string firstName;
        public string lastName;
        public bool isMarried;
        public string job;
        public string address;
        public int age;

        public Person(int id, string firstName, string lastName, bool isMarried, string job, string address, int age)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.isMarried = isMarried;
            this.job = job;
            this.address = address;
            this.age = age;
        }

        public Person(int id, string firstName, bool isMarried, int age)
        {
            this.id = id;
            this.lastName = "";
            this.firstName = firstName;
            this.isMarried = isMarried;
            this.job = "job seeker";
            this.address = "Oman";
            this.age = age;
        }
    }
}
