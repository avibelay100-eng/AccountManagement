namespace ConsoleApp1
{
    public class BankAccount
    {
        protected int accountNumber;
        protected double balance;
        protected Customer customerOwner;

        public BankAccount(int accountNumber, double balance, Customer customerOwner)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.customerOwner = customerOwner;
        }
        // get/set
        public int GetAccountNumber() { return accountNumber; }
        public void SetAccountNumber(int accountNumber) { this.accountNumber = accountNumber; }

        public double GetBalance() { return balance; }
        public void SetBalance(double balance) { this.balance = balance; }

        public Customer GetCustomerOwner() { return customerOwner; }
        public void SetCustomerOwner(Customer customerOwner) { this.customerOwner = customerOwner; }
        
    
        public void Deposit(double amount)
        {
            this.balance += amount;
        }

        public void Deposit(double amount, int date)
        {
            this.balance += amount;
            Console.WriteLine($"Deposit of {amount} made on {date}");
        }

        public virtual void Withdraw(double amount)
        {
            if (balance < amount)
            {
                Console.WriteLine("Insufficient funds");
            }
            else
            {
                this.balance -= amount;
            }
        }
        public virtual void PrintBalance()
        {
            Console.WriteLine($"Account: {accountNumber}, Balance: {balance}");
        }
    }
}