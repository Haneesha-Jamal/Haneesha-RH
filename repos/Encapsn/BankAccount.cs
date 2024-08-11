using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsn
{
     class BankAccount
    {
        private double balance;
        public void Deposit(double amount)
        {
            balance += amount;
        }
        public void Withdraw(double amount)
        {
            if(amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insuffient fund");
            }
           
        }
        public double GetBalance()
        {
            return balance;
        }
    }
}
