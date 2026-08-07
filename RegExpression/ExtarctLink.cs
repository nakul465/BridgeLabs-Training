using System;
using System.Text.RegularExpressions;
namespace RegExpression
{
	public class ExtarctLink
	{
		public static void ExtarctsLink(string s)
		{
            string pattern = @"https?://[^\s]+";

            MatchCollection matches = Regex.Matches(s, pattern);

            foreach (Match m in matches)
            {
                Console.WriteLine(m.Value);
            }
        }
	}
}

