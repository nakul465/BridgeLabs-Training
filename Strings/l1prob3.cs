using System;
namespace Strings
{
	public class l1prob3
	{
		public static bool l1pob3()
		{
			string s = Console.ReadLine();
			for (int i = 0,j=s.Length-1; i < s.Length/2;i++,j--)
			{
				if (s[i] != s[j]) return false;
			}
			return true;
		}
	}
}

