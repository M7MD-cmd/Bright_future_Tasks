using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_system
{
    internal class CurrentAccount : BankAccount
    {
        public override void Withdraw(int money)
        {
            Console.WriteLine("Overdraft allowed");

            int newBalance = GetBalance() - money;
            if (newBalance < -1000)
            {
                Console.WriteLine("You broke the limit");
                return;
            }
            else 
            {
                SetBalance(newBalance);
            }

            Console.WriteLine($"New Balance: {GetBalance()}");
        }
    }
}
