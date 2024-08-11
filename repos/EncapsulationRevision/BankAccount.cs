using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationRevision
{
    public  class BankAccount
    {
        private decimal _balance; // private data here encapsulation proccessing

        public BankAccount(decimal initialbalance) 
        {
            _balance = initialbalance;
        }

        public void Deposit(decimal amount)
        {
            _balance += amount;
            Console.WriteLine($"Desposited : {amount}, new balance : {_balance} ");
        }

        public void Withdraw(decimal amounted)
        {
            if(amounted <= _balance)
            {
                Console.WriteLine($"Withdraw {amounted} ,  new balance {_balance}");
            }
            else
            {
                Console.WriteLine("Insufficient amount");
            }
        }
    }
}
