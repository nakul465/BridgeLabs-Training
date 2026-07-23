using System;
namespace Day2
{
	public class Calculator
	{
		public static float Cal(float num1,float num2,char ch)
		{
			switch (ch)
			{
				case '+':
					return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
					return num1 * num2;
                case '/':
					if (num2 == 0) return -1;
                    return num1 / num2;
				default:
					return -1;
            }
        }
	}
}

