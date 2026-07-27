using System;
namespace Methods
{
	public class l2prob9
	{
        public static void CheckNumbers()
        {
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (IsPositive(numbers[i]))
                {
                    Console.Write(numbers[i] + " is Positive and ");

                    if (IsEven(numbers[i]))
                        Console.WriteLine("Even");
                    else
                        Console.WriteLine("Odd");
                }
                else
                {
                    Console.WriteLine(numbers[i] + " is Negative");
                }
            }

            Console.WriteLine();

            int result = Compare(numbers[0], numbers[numbers.Length - 1]);

            if (result == 1)
                Console.WriteLine("First element is Greater than the Last element.");
            else if (result == 0)
                Console.WriteLine("First element is Equal to the Last element.");
            else
                Console.WriteLine("First element is Less than the Last element.");
        }

        public static bool IsPositive(int num)
        {
            return num >= 0;
        }

        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        public static int Compare(int num1, int num2)
        {
            if (num1 > num2)
                return 1;
            else if (num1 == num2)
                return 0;
            else
                return -1;
        }
    }
}

