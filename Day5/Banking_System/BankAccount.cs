using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_system
{
    internal class BankAccount
    {
        private int AccountNumber = 0;
        private int Balance = 0;

        public  void Deposit(int money)
        {
            if (money < 0) 
            {
                Console.WriteLine("Cannot deposit negative amount");
                return;
            }
            Balance += money;
        }
        public virtual void Withdraw(int money) 
        {
            if (money > Balance)
            {
                Console.WriteLine("Not enough money in the account");
            }
            else
            {
                Balance -= money;
            }
        }
        public void DisplayBalance()
        {
            Console.WriteLine("Current balance: " + Balance);
        }
        protected void SetBalance(int newBalance)
        {
            Balance = newBalance;
        }
        public int GetBalance() { return Balance; }
        public void SetaccountNumber(int accountNumber) 
        {
            AccountNumber = accountNumber;
        }
        public int GetaccountNumber()
        {
            return AccountNumber;
        }
    }
}
