using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment2
{
    internal class Product
    {
        string name;
        double price;
        int quantity;

        public double getTotal()
        {
            return price * quantity;
        }

        public Product(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public double getTotal(double price, int quantuty)
        {
            return price * quantity;
        }
    }
}
