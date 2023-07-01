using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Part2
{
    internal class MasterCard : IPayment
    {
        public decimal amount { get; set; }

        public MasterCard(decimal amount)
        {
            this.amount = amount;
        }
        public void Pay()
        {
            Console.WriteLine($"a payment by MasterCard: {amount}"+" RO");
        }
    }
}
