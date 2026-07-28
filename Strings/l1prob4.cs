using System;
namespace Strings
{
	public class l1prob4
	{
		public static string l1pob4()
		{
			int[] frequency = new int[26];
			string s = Console.ReadLine();
			for(int i = 0; i < s.Length; i++)
			{
				frequency[s[i] - 'a']++;
			}
			string ans = "";
            for (int i = 0; i < s.Length; i++)
            {
				if (frequency[s[i] - 'a'] > 1) continue;
				ans += s[i];
            }
			return ans;
        }
	}
}

