using System;
namespace Methods
{
	public class l3prob8
	{
        public static string GetMonthName(int month)
        {
            string[] months =
            {
                "January", "February", "March",
                "April", "May", "June",
                "July", "August", "September",
                "October", "November", "December"
            };

            return months[month - 1];
        }

        public static bool IsLeapYear(int year)
        {
            if (year % 400 == 0)
                return true;

            if (year % 100 == 0)
                return false;

            if (year % 4 == 0)
                return true;

            return false;
        }

        public static int GetDaysInMonth(int month, int year)
        {
            int[] days =
            {
                31, 28, 31,
                30, 31, 30,
                31, 31, 30,
                31, 30, 31
            };

            if (month == 2 && IsLeapYear(year))
            {
                return 29;
            }

            return days[month - 1];
        }

        public static int GetFirstDay(int day, int month, int year)
        {
            int y0 = year - (14 - month) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = month + 12 * ((14 - month) / 12) - 2;
            int d0 = (day + x + (31 * m0) / 12) % 7;

            return d0;
        }

        public static void DisplayCalendar(int month, int year)
        {
            string monthName = GetMonthName(month);
            int days = GetDaysInMonth(month, year);

            Console.WriteLine("      " + monthName + " " + year);
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
            int firstDay = GetFirstDay(1, month, year);

            for (int i = 0; i < firstDay; i++)
            {
                Console.Write("    ");
            }

            for (int date = 1; date <= days; date++)
            {
                Console.Write($"{date,3} ");

                if ((date + firstDay) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
        }
    }
}


