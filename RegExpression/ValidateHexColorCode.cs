using System;
using System.Text.RegularExpressions;
namespace RegExpression
{
	public class ValidateHexColorCode
	{
		public static bool IsValidHexColorCode(string colorCode)
		{
			string pattern = @"^#[0-9A-Fa-f]{6}$";
			bool valid = Regex.IsMatch(colorCode, pattern);
			return valid;
		}
	}
}

