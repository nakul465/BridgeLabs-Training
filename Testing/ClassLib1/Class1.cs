namespace ClassLib1;
public class Class1
{
    public double add(double num1,double num2)
    {
        return num1 + num2;
    }
    public double subt(double num1, double num2)
    {
        return num1 - num2;
    }
    public double multiply(double num1, double num2)
    {
        return num1 * num2;
    }
    public double divide(double num1, double num2)
    {
        return num1 / num2;
    }
    public bool isPrime(int num)
    {
        if (num <= 0) return false;
        if (num <= 3) return true;
        for(int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}

