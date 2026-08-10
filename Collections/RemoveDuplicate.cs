using System;
namespace Collections
{
	public class RemoveDuplicate
	{
		public static List<int> RemoveeDuplicate(List<int> ls)
		{
			List<int> res = new List<int>();
			for(int i = 0 ; i < ls.Count - 1 ; i++)
			{
				if (res.IndexOf(ls[i]) == -1)
				{
					res.Add(ls[i]);
				}
			}
			return res;
		}
	}
}

