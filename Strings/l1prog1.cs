using System;
namespace Strings
{
	public class l1prog1
	{
		public static void l1pog1()
		{
			string s = Console.ReadLine();
			int len = s.Length;
			int vowelCount = 0;
			int consonentCount = 0;
			for(int i = 0; i < len; i++)
			{
				if (s[i]=='a'|| s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
				{
					vowelCount++;
				}
				else
				{
					consonentCount++;
				}
			}
			Console.WriteLine($"The number of vowels and consonets in the string are {vowelCount}  and {consonentCount}");
		}
	}
}

