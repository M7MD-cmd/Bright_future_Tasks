using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_system
{
    internal class SavingAccount : BankAccount
    {
        public override void Withdraw(int money)
        {
            if (money > 1000)
            {
                Console.WriteLine("Cannot withdraw more than 1000 at once");
            }
            else
            {
                base.Withdraw(money);
            }
        }
    }
}
