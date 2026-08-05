using System;
namespace EncapsulatioAndPolymorphism
{
    public interface ILoanable
    {
        void ApplyForLoan();
        bool CalculateLoanEligibility();
    }

    public abstract class BankAccount
    {
        private string accountNumber;
        private string holderName;
        private double balance;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string HolderName
        {
            get { return holderName; }
            set { holderName = value; }
        }

        public double Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        public BankAccount(string accountNumber, string holderName, double balance)
        {
            this.accountNumber = accountNumber;
            this.holderName = holderName;
            this.balance = balance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}");
            }
            else
            {
                Console.WriteLine("Insufficient balance or invalid amount.");
            }
        }

        public abstract double CalculateInterest();

        public void DisplayDetails()
        {
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Holder Name: {holderName}");
            Console.WriteLine($"Balance: {balance}");
        }
    }

    public class SavingsAccount : BankAccount, ILoanable
    {
        public SavingsAccount(string accountNumber, string holderName, double balance) : base(accountNumber, holderName, balance)
        {
        }

        public override double CalculateInterest()
        {
            return Balance * 0.05;
        }

        public void ApplyForLoan()
        {
            Console.WriteLine("Savings Account loan application submitted.");
        }

        public bool CalculateLoanEligibility()
        {
            return Balance >= 10000;
        }
    }

    public class CurrentAccount : BankAccount, ILoanable
    {
        public CurrentAccount(string accountNumber, string holderName, double balance) : base(accountNumber, holderName, balance)
        {
        }

        public override double CalculateInterest()
        {
            return Balance * 0.02;
        }

        public void ApplyForLoan()
        {
            Console.WriteLine("Current Account loan application submitted.");
        }

        public bool CalculateLoanEligibility()
        {
            return Balance >= 50000;
        }
    }
}

