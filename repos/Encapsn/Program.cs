namespace Encapsn
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Deposit(1000);
            Console.WriteLine("current balace : " + account.GetBalance());
            account.Withdraw(500);
            Console.WriteLine("amount after withrawal  : " + account.GetBalance());
          
        }
       
        
    }
}
