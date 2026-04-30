using System;

namespace AccountManagement
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

        public int GetAccountNumber()
        {
            return this.accountNumber;
        }

        public void SetAccountNumber(int accountNumber)
        {
            this.accountNumber = accountNumber;
        }

        public double GetBalance()
        {
            return this.balance;
        }

        public void SetBalance(double balance)
        {
            this.balance = balance;
        }

        public Customer GetCustomerOwner()
        {
            return this.customerOwner;
        }

        public void SetCustomerOwner(Customer customerOwner)
        {
            this.customerOwner = customerOwner;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }

            this.balance += amount;
            Console.WriteLine("Deposited: " + amount);
        }

        public void Deposit(double amount, string date)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }

            this.balance += amount;
            Console.WriteLine("Deposited: " + amount + " on " + date);
        }

        public virtual void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }

            if (amount > this.balance)
            {
                Console.WriteLine("Withdrawal amount exceeds balance.");
                return;
            }

            this.balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        }

        public virtual void PrintBalance()
        {
            Console.WriteLine("Current balance: " + this.balance);
        }

        public virtual void PrintAccountDetails()
        {
            Console.WriteLine("Account Number: " + this.accountNumber);
            Console.WriteLine("Owner Name: " + this.customerOwner.GetName());
            Console.WriteLine("Balance: " + this.balance);
        }
    }
}
