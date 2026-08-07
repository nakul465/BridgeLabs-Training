using System;
using System.Text.RegularExpressions;
namespace RegExpression
{
	public class ExtractDates
	{
		public static void ExtractsDates(string s)
		{
			string pattern = @"[0-9]{2}/[0-9]{2}/[0-9]{4}";
			MatchCollection matches = Regex.Matches(s, pattern);
			foreach(Match m in matches)
			{
				Console.WriteLine(m.Value);
			}
;		}
	}
}

