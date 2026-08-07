using System;
using System.Text.RegularExpressions;
namespace RegExpression
{
	public class ValidSSN
	{
		public static bool IsValidSSN(string s)
		{
			string pattern = @"\d{3}-\d{2}-\d{4}";

			bool valid = Regex.IsMatch(s, pattern);

			return valid;
		}
	}
}

