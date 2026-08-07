using System;
using System.Text.RegularExpressions;
namespace RegExpression
{
	public class CensorWordsInString
	{
		public static string CensorBadWordsInString(string s)
		{
            string[] badWords = { "damn", "stupid" };
			string pattern = string.Join("|",badWords);
			string result = Regex.Replace(s, pattern, "****");
			return result;
		}
	}
}

