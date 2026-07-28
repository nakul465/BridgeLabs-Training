using System;
namespace Strings
{
	public class l1prob7
	{
		public static string l1pob7()
		{
			string str = Console.ReadLine();
			string ans = "";
			for(int i = 0; i < str.Length; i++)
			{
				char ch = str[i];
				if (ch >= 97)
				{
					ch = (char)(ch - 32);
				}
				else
				{
                    ch = (char)(ch + 32);
                }
				ans += ch;
			}
			return ans;
		}
	}
}

