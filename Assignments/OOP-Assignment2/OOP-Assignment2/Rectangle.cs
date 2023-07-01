using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment2
{
    internal class Rectangle
    {
        double length;
        double width;

        public Rectangle()
        {
            this.length = 5;
            this.width = 5;
        }
        public double getArea()
        {
            return length * width;
        }

        public double getArea(double length, double width)
        {
            return length * width;
        }



    }
}
