using System;
namespace OOPS2
{
	public class BankAccount
	{
		public static string bankName="HDFC Bank";
		string accHolderName;
        readonly int accountNumber;
		public static int noOfAcc = 0;
        public double Balance;
        public BankAccount()
		{
			this.accHolderName = "Ram";
			this.accountNumber = 1;
            this.Balance = 0;
            noOfAcc++;
		}
        public BankAccount(string accHolderName,int accountNumber,double Balance)
        {
            this.accHolderName = accHolderName;
            this.accountNumber = accountNumber;
            this.Balance = Balance;
            noOfAcc++;
        }
        public void getTotalAccounts()
		{
			Console.WriteLine($"There are total {noOfAcc} number of accounts in the bank {bankName}");
		}
        public void DisplayDetails(BankAccount b1)
        {
            if(b1 is BankAccount)
            {
                Console.WriteLine("Bank Name      : " + bankName);
                Console.WriteLine("Account Number : " + accountNumber);
                Console.WriteLine("Account Holder : " + accHolderName);
                Console.WriteLine("Balance        : " + Balance);
            }
            else
            {
                Console.WriteLine("the object is not a bank account");
            }

        }
    }
}

