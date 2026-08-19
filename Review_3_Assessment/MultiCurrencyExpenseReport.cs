using System;
using System.Text.RegularExpressions;
namespace Review_3_Assessment
{
	public class ExpenseItem
	{
        public static List<string> allowedCurrency = new List<string> {"INR","USD","EUR"};
        public string EmployeeId { get; set; }
        public string Amount { get; set; }
        public string Currency { get; set; }
        public string Category { get; set; }
        public string Date { get; set; }
        public string Note { get; set; }
        static Dictionary<string, decimal> limit = new Dictionary<string, decimal> { { "Travel",1000},{"Accomodation",2000},{"Vacation",3000 } };

        public ExpenseItem(string freeText)
        {
            string[] arr = freeText.Split('|');
            string[] emp = arr[0].Split(':');
            EmployeeId = emp[1];
            string[] amt = arr[1].Split(':');
            amt = amt[1].Split(' ');
            Amount = amt[0];
            Currency = amt[1];
            string[] cat = arr[2].Split(':');
            Category = cat[1];
            string[] dat = arr[3].Split(':');
            Date = dat[1];
            string[] not = arr[4].Split(':');
            Note = not[1];
        }

        public ExpenseItem(string EmployeeId, string Amount, string Currency, string Category, string Date, string Note)
        {
            this.EmployeeId = EmployeeId;
            this.Amount = Amount;
            this.Currency = Currency;
            this.Category = Category;
            this.Date = Date;
            this.Note = Note;
        }

        public decimal NormaliseExpense()
        {
            string pattern = string.Join('|', allowedCurrency);
            bool isValid = Regex.IsMatch(Currency,pattern);
            if (!isValid)
            {
                Console.WriteLine("Invalid Currency code");
                return -1;
            }
            if (Currency == "INR") return Convert.ToDecimal(Amount);
            else if (Currency == "USD") return Convert.ToDecimal(Amount) * 96.00m;
            else if (Currency == "EUR") return Convert.ToDecimal(Amount) * 110.00m;
            return -1;
        }

        public bool isValidDate()
        {
            string pattern = @"^[0-9]{2}/[0-9]{2}/[0-9]{4}$";
            bool isValid = Regex.IsMatch( Date ,pattern);
            return isValid;
        }

        public bool isValidAmount()
        {
            if (Convert.ToDecimal(Amount) <= 999) return true;
            string pattern = @"^\d{1,2},\d{3}\.?\d{2}?$";
            bool isValid = Regex.IsMatch(Amount, pattern);
            return isValid;
        }

        public bool isExpenseInLimit()
        {
            decimal li = limit[Category];
            if (NormaliseExpense() <= li) return true;
            return false;
        }
    }

	public class ExpenseLedger<T> where T:ExpenseItem
	{
        public static decimal spendingThreshhold = 10000.00m;
        static Dictionary<string, decimal> limit = new Dictionary<string, decimal> { { "Travel", 1000 }, { "Accomodation", 2000 }, { "Vacation", 3000 } };

        List<T> ls;
        Dictionary<string, decimal> totalExpenses;

        public ExpenseLedger()
        {
            ls = new List<T>();
            totalExpenses = new Dictionary<string, decimal>();
        }

        public void AddExpenseItem(T item)
        {
            ls.Add(item);
            if (totalExpenses.ContainsKey(item.EmployeeId))
            {
                totalExpenses[item.EmployeeId] += item.NormaliseExpense();
            }
            else
            {
                totalExpenses[item.EmployeeId] = item.NormaliseExpense();
            }
        }
        
        public void itemsWithExceedingLimits()
        {
            var list = ls.Where(n => n.NormaliseExpense() > limit[n.Category]).GroupBy(n => new {n.EmployeeId,n.Date,n.Category});
            foreach(T item in list)
            {
                Console.WriteLine($"EmployeeID: {item.EmployeeId} , Category : {item.Category} , Expense : {item.NormaliseExpense()}");
            }
        }

        public void EmployeeWithExceedingThreshholdLimits()
        {
            var list = totalExpenses.Where(n => n.Value > spendingThreshhold);
            foreach (KeyValuePair<string,decimal> k in list)
            {
                Console.WriteLine($"EmployeeID: {k.Key} , Expense : {k.Value}");
            }
        }
    }
}

