using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    internal class BankAccount
    {
        public string Number { get; private set; }

        public string Owner { get; private set; }

        public float Balance { get; private set; }

        public BankAccount(string numer, string owner, float initialBalance)
        {
            Number = numer;
            Owner = owner;
            Balance = initialBalance;
        }

        public void MakeDeposit(float amount)
        {
            Balance += amount;
        }

        public void MakeWithdrawal(float amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            } else
            {
                Console.WriteLine("Unzureichender Saldo!");
            }
        }


        public void PrintBalance() 
        {
            Console.WriteLine($"Der Kontostand von {Owner} beträgt: {Balance} Euro."); 
        }
    }
}
