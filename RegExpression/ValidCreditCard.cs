using System;
using System.Text.RegularExpressions;
namespace RegExpression
{
	public class ValidCreditCard
	{
		public static void ValidCreditCardNumber(string s)
		{
			string pattern = @"4\d{15}";
			bool valid = Regex.IsMatch(s, pattern);
			if(Regex.IsMatch(s, @"4\d{15}")){
				Console.WriteLine("Visa card");
			}else if(Regex.IsMatch(s, @"5\d{15}"))
			{
                Console.WriteLine("Master card");
			}
			else
			{
				Console.WriteLine("Invalid card");
			}

		}
	}
}

