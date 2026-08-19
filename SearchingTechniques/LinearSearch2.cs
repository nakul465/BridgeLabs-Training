using System;
namespace SearchingTechniques
{
	public class LinearSearch2
	{
		public static string FindWordinStringArray(string[] arr,string word)
		{
			foreach(string s in arr)
			{
				if (s.Contains(word)){
					return s;
				}
			}
			return "";
		}
	}
}

