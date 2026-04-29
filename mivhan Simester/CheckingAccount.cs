using System;
using System.Collections.Generic;
using System.Text;

namespace בוחן_אמצע_סימסטר
{
    public class CheckingAccount : BankAccount
    {
        private double overdraftLimit;

        public CheckingAccount(int accountNumber, double balance, Customer customerOwner, double overdraftLimit)
            : base(accountNumber, balance, customerOwner)
        {
            this.overdraftLimit = overdraftLimit;
        }

        public override void Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (this.balance - amount >= overdraftLimit)
                {
                    this.balance -= amount;
                }
                else Console.WriteLine("Withdrawal amount exceeds overdraft limit.");

            }
            else Console.WriteLine("Withdrawal amount must be positive."); ;
        }

        public override void PrintBalance()
        {
            Console.WriteLine($"Overdraft Limit: {this.overdraftLimit}");
        }

        public void tostring()
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Owner: " + customerOwner);
            Console.WriteLine("Balance: " + balance);
            Console.WriteLine("Overdraft Limit: " + overdraftLimit);
            Console.WriteLine("--------------------");
        }

    }
}
