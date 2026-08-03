using System;
namespace Inheritance
{
	public class BankAccount
	{
        public int AccountNumber;
        public double Balance;

        public BankAccount(int AccountNumber, double Balance)
		{
            this.AccountNumber = AccountNumber;
            this.Balance = Balance;
        }

        public virtual void DisplayAccountType()
        {
            Console.WriteLine($"The Account {AccountNumber} has balance {Balance}");
        }

    }


	public class SavingsAccount: BankAccount
    {
        public double interestRate;

        public SavingsAccount(int AccountNumber, double Balance, double interestRate) : base(AccountNumber, Balance)
        {
            this.interestRate = interestRate;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine($"The Account {AccountNumber} with balance {Balance} is a SavingsAccount with interest rate : {interestRate}");
        }
    }


    public class CheckingAccount: BankAccount
    {
        public double WithdrawalLimit;

        public CheckingAccount(int AccountNumber, double Balance, double interestRate, double WithdrawalLimit) : base(AccountNumber, Balance)
        {
            this.WithdrawalLimit = WithdrawalLimit;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine($"The Account {AccountNumber} with balance {Balance} is a CheckingAccount with WithdrawalLimit : {WithdrawalLimit}");
        }
    }


    public class FixedDepositAccount: BankAccount
    {
        public double Duration;

        public FixedDepositAccount(int AccountNumber, double Balance, double interestRate, double WithdrawalLimit, double Duration) : base(AccountNumber, Balance)
        {
            this.Duration = Duration;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine($"The Account {AccountNumber} with balance {Balance} is a FixedDepositAccount with Duration : {Duration}");
        }
    }
}

