namespace Banking_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc;

            acc = new SavingAccount();
            acc.SetaccountNumber(1);

            acc.Deposit(1000);
            acc.DisplayBalance();

            acc.Withdraw(1200); 
            acc.DisplayBalance();

            Console.WriteLine("-------------");

            acc = new CurrentAccount();
            acc.SetaccountNumber(2);

            acc.Deposit(1000);
            acc.DisplayBalance();

            acc.Withdraw(1200); 
            acc.DisplayBalance();
        }
    }
}
