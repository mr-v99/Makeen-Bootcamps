using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10
{
    internal class Patient
    {
        enum Day
        {

            Sunday = 1,
            Monday = 2,
            Tuesday = 3,
            Wednesday = 4,
            Thursday = 5,
            Friday = 6,
            Saturday = 7,

        }

        public string name { get; set; }
        public int age { get; set; }

        public string relationShip { get; set; }

        public bool firstVisit { get; set; }

        

        public Patient(string name, int age, string relationship, bool firstVisit) {
        
            this.name = name;
            this.age = age; 
            this.relationShip = relationship;
            this.firstVisit = firstVisit;

        }
   
    }
}
