using System;
namespace Strings
{
	public class l1prob5
	{
		public static string l1pob5()
		{
			string s = Console.ReadLine();
			string[] words = s.Split(' ');
			string largest = words[0];
			foreach(string i in words)
			{
				if (i.Length > largest.Length) largest = i;
			}
			return largest;
		}
	}
}

