using System;
using System.Text.RegularExpressions;
namespace RegExpression
{
	public class ExtractCurrency
	{
		public static void ExtractCurrencyValues(string s)
		{
			string pattern = @"[$₹]?\d+\.?\d+";

			MatchCollection matches = Regex.Matches(s,pattern);

			foreach(Match m in matches)
			{
				Console.WriteLine(m.Value);
			}
		}
	}
}

