using System;
namespace OOPS
{
	public class BankAccount
	{
		public int accountNumber;
		protected string accountHolder;
		private int balance;
		public BankAccount()
		{
			this.accountNumber = 1;
			this.accountHolder = "Ram";
			this.balance = 0;
		}
        public BankAccount(int accountNumber,string accountHolder,int balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = balance;
        }
		public int getBalance()
		{
			return balance;
		}
        public void Deposit(int amount)
        {
			if (amount < 0)
			{
				Console.WriteLine("Invalid amount");
				return;
			}
			this.balance += amount;
        }
        public void Withdraw(int amount)
        {
			if (amount < 0)
			{
                Console.WriteLine("Invalid amount");
            }else if (amount > this.balance)
			{
				Console.WriteLine("Insufficient Funds");
			}
            this.balance -= amount;
        }
    }
	public class SavingsAccount : BankAccount
	{
        public SavingsAccount(int accountNumber, string accountHolder, int balance)
            : base(accountNumber, accountHolder, balance)
        {
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Account Number: " + accountNumber);   
            Console.WriteLine("Account Holder: " + accountHolder);   
        }
    }
}

