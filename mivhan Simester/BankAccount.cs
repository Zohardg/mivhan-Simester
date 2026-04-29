using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace בוחן_אמצע_סימסטר
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

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                this.balance += amount;
                Console.WriteLine("Deposited: " + amount);
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }


        public void Deposit(double amount, string date)
        {
            if (amount > 0)
            {
                this.balance += amount;
                Console.WriteLine("Deposited: " + amount + " on " + date);
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public virtual void Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (this.balance >= amount)
                {
                    this.balance -= amount;
                }
                else Console.WriteLine("Withdrawal amount exceeds balance.");

            }
            else Console.WriteLine("Withdrawal amount must be positive.");

        }

        public virtual void PrintBalance()
        {
            Console.WriteLine($"The current balance is: {this.balance}");
        }


    }
}
