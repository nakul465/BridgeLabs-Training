namespace ExpenseReportTest;
using Review_3_Assessment;
public class Tests
{
    ExpenseItem item1;
    ExpenseItem item2;
    [SetUp]
    public void Setup()
    {
        item1 = new ExpenseItem("e1","100","EUR","Travel","10/01/2018","cost of travelling from delhi to chandigarh");
        item2 = new ExpenseItem("e1", "1,500.00", "INR", "Accomodation", "11/01/2018", "cost of staying in chandigarh");
        ExpenseLedger<ExpenseItem> led1 = new ExpenseLedger<ExpenseItem>();
        led1.AddExpenseItem(item1);
        led1.AddExpenseItem(item2);
    }

    [Test]
    public void IsTheDateEnteredByUserValid()
    {
        Assert.That(item1.isValidDate(), Is.True);
    }

    [Test]
    public void IsExpenseInLimitGiven()
    {
        Assert.That(item2.isExpenseInLimit(), Is.True);
    }

    [Test]
    public void IsNormaliseAmountConerverting()
    {
        Assert.That(item1.NormaliseExpense(), Is.EqualTo(11000));
    }

    [Test]
    public void IsAmountEnteredByUserInCoorectFormat()
    {
        Assert.That(item2.isValidAmount(), Is.True);
    }
}
