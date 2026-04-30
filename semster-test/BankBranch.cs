
namespace ConsoleApp1
{
    public class BankBranch : IBankBranch // סניף בנק
    {
        private int branchNumber; // מספר סניף
        private string address; // כתובת
        private CheckingAccount[] accounts = new CheckingAccount[20];

        public int GetBranchNumber() { return branchNumber; }
        public void SetBranchNumber(int branchNumber) { this.branchNumber = branchNumber; }

        public string GetAddress() { return address; }
        public void SetAddress(string address) { this.address = address; }

        public CheckingAccount[] GetAccounts() { return accounts; }
        private void SetAccounts(CheckingAccount[] accounts) { this.accounts = accounts; }

        public BankBranch(int branchNumber, string address)
        {
            this.branchNumber = branchNumber;
            this.address = address;
        }

        public void AddAccount(CheckingAccount account)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    accounts[i] = account;
                    Console.WriteLine("Account added successfully.");
                    return;
                }
                else if (accounts[i] == account)
                {
                    Console.WriteLine("Existing account! can't adding...");
                    return;
                }
            }
        }

        public void PrintAccounts()
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] != null)
                {
                    accounts[i].PrintBalance();
                }
            }
        }
    }
}