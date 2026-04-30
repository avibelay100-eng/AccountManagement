
namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer(123456789, "Avraham", 052775833);

            CheckingAccount a1 = new CheckingAccount(1001, 5000, c1, 2000);

            BankBranch b1 = new BankBranch(10, "Tel Aviv");

            b1.AddAccount(a1);

            a1.Deposit(1000);
            a1.Withdraw(6000);

            a1.PrintBalance();

            b1.PrintAccounts();
        }
    }
}
