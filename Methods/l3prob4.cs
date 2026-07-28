using System;
namespace Methods
{
	public class l3prob4
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

        public static int[] ReverseArray(int[] digits)
        {
            int[] reversed = new int[digits.Length];

            for (int i = 0; i < digits.Length; i++)
            {
                reversed[i] = digits[digits.Length - 1 - i];
            }

            return reversed;
        }

        public static bool CompareArrays(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
                return false;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                    return false;
            }

            return true;
        }

        public static bool IsPalindrome(int number, int[] digits)
        {
            int[] reversed = ReverseArray(digits);

            return CompareArrays(digits, reversed);
        }

        public static bool IsDuckNumber(int[] digits)
        {
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] == 0)
                    return true;
            }

            return false;
        }
    }
}

