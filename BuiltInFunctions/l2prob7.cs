using System;
namespace BuiltInFunctions
{
	public class l2prob7
	{
		public l2prob7()
		{
			int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine($"GCD: {gcd(num1, num2)} \nLCM: {lcm(num1,num2)}");
        }
		public static int gcd(int num1,int num2)
		{
			if (num2 == 0) return num1;

			return gcd(num2, num1%num2);
		}
        public static int lcm(int num1, int num2)
        {
			return (num1 * num2) / gcd(num1, num2);
        }
    }
}

