using System;
namespace Methods
{
	public class l3prob6
	{
        public static int[] FindFactors(int number)
        {
            int count = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    count++;
            }

            int[] factors = new int[count];

            int index = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors[index] = i;
                    index++;
                }
            }

            return factors;
        }


        public static int GreatestFactor(int[] factors)
        {
            int greatest = factors[0];

            for (int i = 0; i < factors.Length; i++)
            {
                if (factors[i] > greatest)
                    greatest = factors[i];
            }

            return greatest;
        }

        public static int SumOfFactors(int[] factors)
        {
            int sum = 0;

            for (int i = 0; i < factors.Length; i++)
            {
                sum += factors[i];
            }

            return sum;
        }

        public static long ProductOfFactors(int[] factors)
        {
            long product = 1;

            for (int i = 0; i < factors.Length; i++)
            {
                product *= factors[i];
            }

            return product;
        }

        public static double ProductOfCubeFactors(int[] factors)
        {
            double product = 1;

            for (int i = 0; i < factors.Length; i++)
            {
                product *= Math.Pow(factors[i], 3);
            }

            return product;
        }

        public static bool IsPerfectNumber(int number, int[] factors)
        {
            int sum = 0;

            for (int i = 0; i < factors.Length; i++)
            {
                if (factors[i] != number)
                    sum += factors[i];
            }

            return sum == number;
        }

        public static bool IsAbundantNumber(int number, int[] factors)
        {
            int sum = 0;

            for (int i = 0; i < factors.Length; i++)
            {
                if (factors[i] != number)
                    sum += factors[i];
            }

            return sum > number;
        }

        public static bool IsDeficientNumber(int number, int[] factors)
        {
            int sum = 0;

            for (int i = 0; i < factors.Length; i++)
            {
                if (factors[i] != number)
                    sum += factors[i];
            }

            return sum < number;
        }

        public static bool IsStrongNumber(int number)
        {
            int temp = number;
            int sum = 0;

            while (temp > 0)
            {
                int digit = temp % 10;

                int factorial = 1;

                for (int i = 1; i <= digit; i++)
                {
                    factorial *= i;
                }

                sum += factorial;
                temp /= 10;
            }

            return sum == number;
        }
    }
}

