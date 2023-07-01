using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session5
{
    internal class Calculator
    {
        public int add(int x, int y) => x + y;
        public double add(double x, double y) => x + y;
        public String add(String x, String y) => x + y;

        public string evenOrOdd(int x) => (x % 2 == 0)? "even" : "odd";
    }
}
