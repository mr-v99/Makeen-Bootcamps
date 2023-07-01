using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Part2
{
    internal class Cash: IPayment
    {
        public decimal amount { get; set; }

        public Cash(decimal amount)
        {
            this.amount = amount;
        }
        public void Pay()
        {
            Console.WriteLine($"a payment by Cash: {amount}" + " RO");
        }
    }
}
