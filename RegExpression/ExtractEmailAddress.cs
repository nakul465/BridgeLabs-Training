using System;
using System.Text.RegularExpressions;
namespace RegExpression
{
	public class ExtractEmailAddress
	{
		public static void ExtractsEmailAddress(string s)
		{
			string pattern = @"[^@\s]+@[^@\s]+\.[^@\s]+";
			MatchCollection match = Regex.Matches(s, pattern);
            foreach (Match m in match)
            {
                Console.WriteLine(m.Value);
            }
        }
	}
}

