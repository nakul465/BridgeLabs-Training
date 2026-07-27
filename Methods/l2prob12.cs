using System;
namespace Methods
{
	public class l2prob12
	{
        public static int[] Generate4DigitRandomArray()
        {
            int size = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(1000, 10000); 
            }

            return numbers;
        }

        public static double[] FindAverageMinMax(int[] numbers)
        {
            int sum = 0;
            int min = numbers[0];
            int max = numbers[0];

            foreach (int num in numbers)
            {
                sum += num;
                min = Math.Min(min, num);
                max = Math.Max(max, num);
            }

            double average = (double)sum / numbers.Length;

            return new double[] { average, min, max };
        }
    }
}

