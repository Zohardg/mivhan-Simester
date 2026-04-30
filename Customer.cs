using System;

namespace AccountManagement
{
    public class CheckingAccount : BankAccount
    {
        private double overdraftLimit;

        public CheckingAccount(int accountNumber, double balance, Customer customerOwner, double overdraftLimit)
            : base(accountNumber, balance, customerOwner)
        {
            this.overdraftLimit = overdraftLimit;
        }

        public double GetOverdraftLimit()
        {
            return this.overdraftLimit;
        }

        public void SetOverdraftLimit(double overdraftLimit)
        {
            this.overdraftLimit = overdraftLimit;
        }

        public override void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }

            if (this.balance - amount < -this.overdraftLimit)
            {
                Console.WriteLine("Withdrawal amount exceeds overdraft limit.");
                return;
            }

            this.balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        }

        public override void PrintBalance()
        {
            Console.WriteLine("Current balance: " + this.balance);
            Console.WriteLine("Allowed overdraft: " + this.overdraftLimit);
        }

        public override void PrintAccountDetails()
        {
            Console.WriteLine("Account Number: " + this.accountNumber);
            Console.WriteLine("Owner Name: " + this.customerOwner.GetName());
            Console.WriteLine("Balance: " + this.balance);
            Console.WriteLine("Allowed overdraft: " + this.overdraftLimit);
            Console.WriteLine("--------------------");
        }
    }
}
