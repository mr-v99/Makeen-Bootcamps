using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3_interface
{
    internal class Rectangle : Resizable
    {
        public double width { get; set; }

        public Rectangle(double width)
        {
            this.width = width;
        }

        public string Resize(double factor,string option)
        {
            string result;
            if (option == "increase")
            {
                this.width+=factor;
             
                result = $"The Rectangle' size increased to {width*4}";
            }
            else if (option == "decrease")
            {
                this.width -= factor;
                result = $"The Rectangle' size decreased to {width * 4}";
            }
            else
            {
                result = "the option is invalid";
            }
            return result;
        }
    }
}
