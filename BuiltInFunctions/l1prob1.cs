using System;
namespace BuiltInFunctions
{
	public class l1prob1
	{
		public static void l1pob1()
		{
            DateTimeOffset utcTime = DateTimeOffset.UtcNow;

            Console.WriteLine("GMT Time : " + utcTime);

            TimeZoneInfo ist = TimeZoneInfo.FindSystemTimeZoneById("Asia/Kolkata");
            DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcTime, ist);
            Console.WriteLine("IST Time : " + istTime);

            TimeZoneInfo pst = TimeZoneInfo.FindSystemTimeZoneById("America/Los_Angeles");
            DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcTime, pst);
            Console.WriteLine("PST Time : " + pstTime);
        }
	}
}

