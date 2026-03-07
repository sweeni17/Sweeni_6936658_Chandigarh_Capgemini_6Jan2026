using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Bank_Management_System
{
    internal class BankAccount
    {
        int AccountNo;
        int PIN;
        string HolderName;
        protected int Balance;
        public BankAccount()
        {
            Console.WriteLine("Enter Account Holder Name: ");
            HolderName = Console.ReadLine();
            Console.WriteLine("Enter account number: ");
            AccountNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter PIN: ");
            PIN = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Balance: ");
            Balance = int.Parse(Console.ReadLine());
        }

        public BankAccount(int accNo, int pin, string name, int bal )
        {
            AccountNo = accNo;
            PIN = pin;
            HolderName = name;
            Balance = bal;
        }
        public void depositAmt(int deposit)
        {
            Console.WriteLine("Amount to be deposited: " + deposit);
            Balance += deposit;
            Console.WriteLine("Updated BAlance: " + Balance);
        }

        public void withdrawAmt(int withdraw)
        {
            Console.WriteLine("Amount to be withdrawn: " + withdraw);
            Balance -= withdraw;
            Console.WriteLine("Updated Balance: " + Balance);
        }

        public void DisplaySummary()
        {
            Console.WriteLine("-----------Account Summary------------");
            Console.WriteLine("Account Number        :   " + AccountNo);
            Console.WriteLine("Account Holder Name   :   " + HolderName);
            Console.WriteLine("Current Balance       :   " + Balance);
        }
    }

    class SavingsAccount : BankAccount
    {
        public int rate;
        public SavingsAccount() 
        {
            Console.WriteLine("enter the rate of interest: ");
            this.rate = int.Parse(Console.ReadLine());
        }
        public void Interest()
        {
            rate = (Balance * rate) / 100;
            Balance += rate;
            Console.WriteLine("Interest on the Amount: " + rate);
            Console.WriteLine("Updated Balance: "+ Balance);
        }
    }

    class CheckingAccount : BankAccount
    {
        private int transactionCount = 0;
        private int dailyTransactionLimit = 5;
        public CheckingAccount(int accNo, int pin, string name, int bal) : base( accNo, pin, name, bal)
        {
            
        }

        public void Deposit(int amount)
        {
            if (transactionCount < dailyTransactionLimit)
            {
                Balance += amount;
                transactionCount++;
                Console.WriteLine("Amount deposited: " + amount);
            }
        }
        public void withdraw(int amount)
        {
            if (transactionCount < dailyTransactionLimit)
            {
                if (Balance > amount)
                {
                    Balance -= amount;
                    transactionCount++;
                    Console.WriteLine("Amount Withdrawn: " + amount);
                }
            }
        }
    }
}
