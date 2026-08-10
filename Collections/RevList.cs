using System;
namespace Collections
{
	public class RevList
	{
		public static void ReverseList(List<int> list)
		{
			for(int i = 0,j=list.Count-1; i < j; i++,j--)
			{
				int temp = list[i];
				list[i] = list[j];
				list[j] = temp;
			}
		}
	}
}

