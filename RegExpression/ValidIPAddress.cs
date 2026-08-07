using System;
using System.Text.RegularExpressions;
namespace RegExpression
{
	public class ValidIPAddress
	{
		public static bool isValidIPAddress(string s)
		{
			string pattern = @"[0-2]?[]";
			bool valid = Regex.IsMatch(s, pattern);
			return false;
		}
	}
}

