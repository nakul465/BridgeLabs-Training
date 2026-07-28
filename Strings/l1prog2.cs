using System;
namespace Strings
{
	public class l1prog2
	{
		public static string l1pog2()
		{
			string s = Console.ReadLine();
			string ans = "";
			for(int i = s.Length-1; i >= 0; i--)
			{
				ans += s[i];
			}
			return ans;
		}
	}
}

