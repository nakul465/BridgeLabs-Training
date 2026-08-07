using System;
using System.Text.RegularExpressions;
namespace RegExpression
{
	public class ExtractCapitalisedWords
	{
		public static void ExtractsCapitalisedWords(string s)
		{
			string pattern = @"[A-Z]\w+";
			MatchCollection matches = Regex.Matches(s, pattern);
			foreach(Match m in matches)
			{
				Console.WriteLine(m.Value);
			}
		}
	}
}

