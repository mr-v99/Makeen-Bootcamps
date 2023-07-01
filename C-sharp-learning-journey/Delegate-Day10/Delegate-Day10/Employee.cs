using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Day10
{
    internal class Employee
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public  char gender { get; set; }
        public  decimal TotalSales { get; set; }

        public Employee(int id, string name, char gender, decimal totalSales)
        {
            this.Id = id;
            this.Name = name;
            this.gender = gender;
            this.TotalSales = totalSales;
            
        }

     
    }
}
