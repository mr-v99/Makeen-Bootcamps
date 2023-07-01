using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session6
{
    internal class Person
    {
        private string fname;
        private string lname;
        private int age;
        private double salary;
        private string relationshipState;

        public string getFname() { return fname; }
        public string getLname() { return lname; }

        public int getAge() { return age; }
        public double getSalary() { return salary;}

        public string getRelationshipState() { return relationshipState;}

        public void setFname(string fname) { this.fname = fname;}

        public void setLname(string lname) { this.lname = lname; }

        public void setAge(int age) {  this.age = age;}

        public void setSalary(double salary) { this.salary = salary; }

        public void setRelationshipState(string relationshipState) {  this.relationshipState = relationshipState;}

        public string printData()
        {
            string info = $"The full name: {fname} {lname}" +
                $"\nThe age: {age}\nThe salary: {salary} RO" +
                $"\nThe relationship state: {relationshipState}";

            return info;
        }

        public int calAge(int year) {

            return DateTime.Today.Year - year;

        }
        
    }
}
