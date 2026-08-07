using System;
using System.Text.RegularExpressions;
namespace RegExpression
{
	public class ReplaceSpaces
	{
		public static string ReplaceAllSpaces(string s)
		{
			string pattern = @"\s+";
			string result = Regex.Replace(s, pattern, @" ");
			return result;
		}
	}
}

