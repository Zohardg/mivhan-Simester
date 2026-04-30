using System;

namespace AccountManagement
{
    public class BankBranch : IBankBranch
    {
        private int branchNumber;
        private string address;
        private CheckingAccount[] accounts;

        public BankBranch(int branchNumber, string address)
        {
            this.branchNumber = branchNumber;
            this.address = address;
            this.accounts = new CheckingAccount[20];
        }

        public int GetBranchNumber()
        {
            return this.branchNumber;
        }

        public void SetBranchNumber(int branchNumber)
        {
            this.branchNumber = branchNumber;
        }

        public string GetAddress()
        {
            return this.address;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }

        public void AddAccount(CheckingAccount account)
        {
            for (int i = 0; i < this.accounts.Length; i++)
            {
                if (this.accounts[i] == null)
                {
                    this.accounts[i] = account;
                    Console.WriteLine("Account added to branch.");
                    return;
                }
            }

            Console.WriteLine("The branch is full. Cannot add more accounts.");
        }

        public void PrintAccounts()
        {
            Console.WriteLine("Branch Number: " + this.branchNumber);
            Console.WriteLine("Address: " + this.address);
            Console.WriteLine("Accounts in branch:");

            for (int i = 0; i < this.accounts.Length; i++)
            {
                if (this.accounts[i] != null)
                {
                    this.accounts[i].PrintAccountDetails();
                }
            }
        }
    }
}
