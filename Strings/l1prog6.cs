using System;
namespace Strings
{
	public class l1prog6
	{
		public static int l1pog6()
		{
			string str = Console.ReadLine();
			string subStr = Console.ReadLine();
			int index = 0;
			int ans = 0;
			while (str.IndexOf(subStr, index) != -1)
			{
				index = str.IndexOf(subStr, index)+subStr.Length;
				ans++;
			}
			return ans;
		}
	}
}

