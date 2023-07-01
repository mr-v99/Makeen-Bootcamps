using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Part2
{
    internal class Visa : IPayment
    {
        public decimal amount { get; set; }

        public Visa(decimal amount)
        {
            this.amount = amount;
        }
        public void Pay()
        {
            Console.WriteLine($"a payment by Visa: {amount}" + " RO");
        }
    }
}
