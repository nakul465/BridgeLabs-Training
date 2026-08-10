using System;
namespace Collections
{
	public class RotateList
	{
		public static void RotateeList(List<int> list,int pos)
		{
			int len = list.Count-1;
			for(int i = 0; i < pos; i++)
			{
				int a = list[len];
				list.RemoveAt(len);
				list.Insert(0,a);
			}
		}
	}
}

