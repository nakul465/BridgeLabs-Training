using System;
namespace Methods
{
	public class l3prob2
	{

        public static int noOfDigits(int num)
        {
            int ans = 0;
            while (num != 0)
            {
                ans++;
                num = num / 10;
            }
            return ans;
        }
        public static int[] digitsOfNumber(int num)
        {
            int n = noOfDigits(num);
            int [] ans = new int[n];
            for(int i = 0; i < n; i++)
            {
                ans[i] = num % 10;
                num = num / 10;
            }
            return ans;
        }
        public static bool isDuckNumber(int num)
        {
            int n = noOfDigits(num);
            for(int i = 0; i < n; i++)
            {
                if (num % 10 == 0) return true;
                num = num / 10;
            }
            return false;
        }
        public static bool isArmstrong(int num)
        {
            int[] digits = digitsOfNumber(num);
            double sum = 0;
            for(int i = 0; i < digits.Length; i++)
            {
                sum += Math.Pow(digits[i], digits.Length);
            }
            if (num == (int)sum) return true;
            return false;
        }
        public static void largest(int num)
        {
            int[] digits = digitsOfNumber(num);
            int largest = Int32.MinValue;
            int secondLargest = Int32.MinValue;

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] > largest)
                {
                    secondLargest = largest;
                    largest = digits[i];
                }
                else if (digits[i] > secondLargest && digits[i] != largest)
                {
                    secondLargest = digits[i];
                }
            }

            Console.WriteLine("Largest element: " + largest);
            Console.WriteLine("Second largest element: " + secondLargest);
        }
        public static void smallest(int num)
        {
            int[] digits = digitsOfNumber(num);
            int smallest = Int32.MaxValue;
            int secondSmallest = Int32.MaxValue;

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] < smallest)
                {
                    secondSmallest = smallest;
                    smallest = digits[i];
                }
                else if (digits[i] < secondSmallest && digits[i] != smallest)
                {
                    secondSmallest = digits[i];
                }
            }

            Console.WriteLine("Smallest element: " + smallest);
            Console.WriteLine("Second smallest element: " + secondSmallest);
        }
    }
}

