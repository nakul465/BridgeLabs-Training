using Review_3_Assessment;
ExpenseItem item1 = new ExpenseItem("e1", "100", "EUR", "Travel", "10/01/2018", "cost of travelling from delhi to chandigarh");
ExpenseItem item2 = new ExpenseItem("e1", "100000", "INR", "Accomodation", "11/01/2018", "cost of staying in chandigarh");
ExpenseItem item3 = new ExpenseItem("e2", "10000", "EUR", "Travel", "10/01/2018", "cost of travelling from delhi to chandigarh");
ExpenseItem item4 = new ExpenseItem("e2", "100000", "INR", "Accomodation", "11/01/2018", "cost of staying in chandigarh");
ExpenseLedger<ExpenseItem> led1 = new ExpenseLedger<ExpenseItem>();
led1.AddExpenseItem(item1);
led1.AddExpenseItem(item2);
led1.AddExpenseItem(item3);
led1.AddExpenseItem(item4);

led1.EmployeeWithExceedingThreshholdLimits();
//string s = "EMP:jdoe|AMT:1,250.00 USD|CATEGORY:Travel|DATE:14/08/2026|NOTE:Flight to client site (approved by mgr)";
//ExpenseItem item1 = new ExpenseItem(s);
//Console.WriteLine(item1.NormaliseExpense());
//Console.WriteLine(item1.isValidDate());
//Console.WriteLine(item1.isValidAmount());