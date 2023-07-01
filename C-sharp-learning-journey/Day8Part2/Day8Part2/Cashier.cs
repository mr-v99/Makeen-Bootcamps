using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8Part2
{
    internal class Cashier
    {
        public IPayment payment { get; set; }

        public Cashier(IPayment payment)
        {
            this.payment = payment;
        }

        public void checkout()
        {
            payment.Pay();
        }
    }
}
