using System;
using System.Text.RegularExpressions;
namespace RegExpression
{
	public class ValidateLicensePlate
	{
		public static bool IsValidLicensePlate(string plate)
		{
			string pattern = @"^[A-Z]{2}\d{4}$";
			bool result = Regex.IsMatch(plate, pattern);
			return result;
		}
	}
}

