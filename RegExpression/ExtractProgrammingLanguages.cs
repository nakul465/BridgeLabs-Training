using System;
using System.Text.RegularExpressions;
namespace RegExpression
{
	public class ExtractProgrammingLanguages
	{
		public static void ExtractProgrammingLanguagesNames(string s)
		{
			string[] lang = { "Java", "Python", "JavaScript", "Go" };
			string pattern = @"\b(" +string.Join('|', lang)+@")\b";
			MatchCollection matches = Regex.Matches(s, pattern);
			foreach(Match m in matches)
			{
				Console.WriteLine(m.Value);
			}
		}
	}
}

