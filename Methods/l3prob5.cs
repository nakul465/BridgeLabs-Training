using System;
namespace Methods
{
	public class l3prob5
	{
        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        public static bool IsNeonNumber(int number)
        {
            int square = number * number;
            int sum = 0;

            while (square > 0)
            {
                sum += square % 10;
                square /= 10;
            }

            return sum == number;
        }

        public static bool IsSpyNumber(int number)
        {
            int temp = number;
            int sum = 0;
            int product = 1;

            while (temp > 0)
            {
                int digit = temp % 10;

                sum += digit;
                product *= digit;

                temp /= 10;
            }

            return sum == product;
        }

        public static bool IsAutomorphic(int number)
        {
            int square = number * number;

            return square.ToString().EndsWith(number.ToString());
        }

        public static bool IsBuzzNumber(int number)
        {
            return number % 7 == 0 || number % 10 == 7;
        }
    }
}

