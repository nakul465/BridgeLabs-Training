using System;
namespace Collections
{
	public class NthElement
	{
		public static int NElement(List<int> list,int pos)
		{
			int len = list.Count;
			return list[len - pos];
		}
	}
}

