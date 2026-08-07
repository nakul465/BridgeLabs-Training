using ClassLib1;

namespace Test1;

public class Tests
{
    private Class1 c;
    [SetUp]
    public void Setup()
    {
        c = new Class1();
    }

    [TestCase(2, 3, 5)]
    [TestCase(3, 3, 6)]
    [TestCase(5, 3, 8)]
    public void Test1(int a,int b,int expected)
    {
        double result = c.add(a, b);
        Assert.That(result, Is.EqualTo(expected));
    }
    [TestCase(12,false)]
    [TestCase(13, true)]
    [TestCase(111, false)]
    public void PrimeNumberChecker(int a,bool expected)
    {
        bool res=c.isPrime(a);
        Assert.That(expected, Is.EqualTo(res));
    }

}
