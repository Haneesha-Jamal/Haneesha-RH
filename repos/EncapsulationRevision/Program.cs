using EncapsulationRevision;

class Program
{
    static void Main(string[] args)
    {
        BankAccount bankAccount = new BankAccount(20000);

        bankAccount.Deposit(5000);
        bankAccount.Withdraw(1000);

    }
}
