using System;
namespace Collections
{
	public class FreqOfElements
	{
		public static void FreqElements(List<String> ls)
		{
			Dictionary<string, int> map = new Dictionary<string, int>();
			foreach(string s in ls)
			{
				if (map.ContainsKey(s))
				{
					map[s]++;
				}
				else
				{
					map[s] = 1;
				}
			}
			foreach(KeyValuePair<string,int> entry in map)
			{
				Console.WriteLine($"{entry.Key} : {entry.Value}");
			}
		}
	}
}

