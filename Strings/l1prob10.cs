using System;
namespace Strings
{
	public class l1prob10
	{
		public static string l1pob10()
		{
			string str = Console.ReadLine();
			char ch = Convert.ToChar(Console.ReadLine());
			string ans = "";
			for(int i = 0; i < str.Length; i++)
			{
				if (str[i] == ch) continue;
				ans += str[i];
			}
			return ans;
		}
	}
}

