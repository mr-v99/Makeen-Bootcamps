using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session4
{
    public class Employee
    {
        public const double TAX = 0.08;
        public string fname;
        public string lname;
        public double wage;
        public double loggedHours;
    
    public void greeting()
        {
            Console.WriteLine($"hello {fname} {lname}");
        }

        public int add(out int x)
        {
            x= x + 1;
            return 1;
        }

    }
}
