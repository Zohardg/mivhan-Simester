using System;
using System.Collections.Generic;
using System.Text;

namespace בוחן_אמצע_סימסטר
{
    public class BankBranch : IBankBranch
    {
        private int branchNumber;
        private string address;
        CheckingAccount[] accounts = new CheckingAccount[20];

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
                    return;
                }
            }
        }

        public void PrintAccounts()
        {
            Console.WriteLine("Branch Number: " + branchNumber);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Accounts:");
            for (int i = 0; i < 20; i++)
            {
                if (accounts[i] != null)
                {
                    accounts[i].tostring();
                }
            }
        }

    }
}
