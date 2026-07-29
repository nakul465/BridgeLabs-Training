using System;
namespace BuiltInFunctions
{
	public class l2prob5
	{
		public static void l2pob5()
		{
			string s = Console.ReadLine();
			if (isPalindrome(s)) Console.WriteLine("the string is Palindrome");
			else Console.WriteLine("the string is not Palindrome");
        }
		public static bool isPalindrome(string s)
		{
			for(int i = 0,j=s.Length-1; i < j; i++, j--)
			{
				if (s[i] != s[j]) return false;
			}
			return true;
		}
	}
}

