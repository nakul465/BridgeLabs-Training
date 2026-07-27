using System;
namespace Methods
{
	public class l2prob3
	{
        public static bool IsLeapYear()
        {

            int year = Convert.ToInt32(Console.ReadLine());
            if (year < 1582)
            {
                Console.WriteLine("No formula to calculate for this year");
                return false;
            }
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }
    }
}

