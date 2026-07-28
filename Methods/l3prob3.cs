using System;
namespace Methods
{
	public class l3prob3
	{

        public static int CountDigits(int number)
        {
            int count = 0;

            while (number > 0)
            {
                count++;
                number /= 10;
            }

            return count;
        }

        public static int[] StoreDigits(int number)
        {
            int count = CountDigits(number);
            int[] digits = new int[count];

            for (int i = count - 1; i >= 0; i--)
            {
                digits[i] = number % 10;
                number /= 10;
            }

            return digits;
        }

        public static int SumOfDigits(int[] digits)
        {
            int sum = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                sum += digits[i];
            }

            return sum;
        }

        public static double SumOfSquares(int[] digits)
        {
            double sum = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                sum += Math.Pow(digits[i], 2);
            }

            return sum;
        }

        public static bool IsHarshadNumber(int number, int[] digits)
        {
            int sum = SumOfDigits(digits);

            return number % sum == 0;
        }

        public static int[,] DigitFrequency(int[] digits)
        {
            int[,] frequency = new int[10, 2];

            for (int i = 0; i < 10; i++)
            {
                frequency[i, 0] = i;
            }

            for (int i = 0; i < digits.Length; i++)
            {
                frequency[digits[i], 1]++;
            }

            return frequency;
        }
    }
}

