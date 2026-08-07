using System;
using System.Text.RegularExpressions;
namespace RegExpression
{
	public class ValidateUserName
	{
		public static bool IsValidUserName(string userName)
		{
            string pattern = @"^(?=.{5,15}$)[A-Za-z]\w+$";
            bool valid = Regex.IsMatch(userName, pattern);
			return valid;
		}
	}
}

