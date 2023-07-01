using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encaps
{
    internal class BankAccount
    {
        private const int MAXWITHDRAW = 1000;
        //private decimal balance;
        //private long actNum;

        //public decimal getBalance() { return balance; }

        public decimal balance { get; set; }
        //public long getActNum() { return actNum; }

        public long actNum { get; set; }
        public int getMaxWithdraw() { return MAXWITHDRAW; }

        //public void setBalance(decimal balance) { this.balance = balance; }

        //public void setActNum(long actNum) { this.actNum = actNum; }

        public void deposit(decimal amount)
        {
            this.balance += amount;
            log("valid");
        }
        
        public void withdraw(decimal amount)
        {
            if (MAXWITHDRAW < amount)
            {
                log("invalid");
            }
            else if (this.balance < amount)
            {
                log("invalid2");
            }
            else
            {
                balance-=amount;
                log("valid");
            }
        }
        public void log(string message)
        {
            DateTime timestamp = DateTime.Now;
            Console.WriteLine(timestamp);
            if (message == "valid")
            {
                Console.WriteLine("Success Transaction");
            }
            else if (message == "invalid")
            {
                Console.WriteLine("invalid transaction. reason: insufficient balance");
            }
            else if (message == "invalid2")
            {
                Console.WriteLine("invalid transaction. reason: exceed the withdraw limit 1000.");
            }

            Console.WriteLine($"Account#: {this.actNum}");
            Console.WriteLine($"Balance: {this.balance}");
        }
    }
}
