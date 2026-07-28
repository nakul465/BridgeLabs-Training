using System;
namespace Strings
{
	public class l1prob8
	{
		public static void l1pob8()
		{
			string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
			int i = 0;
            if (s1 == s2)
            {
                Console.WriteLine("both strings are equal");
                return;
            }
            while (i < s1.Length && i < s2.Length)
			{
				if (s1[i] > s2[i])
				{
                    Console.WriteLine($"{s2} comes before {s1} in lexicographical order");
                    return;
                }else if (s1[i] < s2[i])
                {
                    Console.WriteLine($"{s1} comes before {s2} in lexicographical order");
                    return;
                }
				i++;
            }
            if (s1.Length > s2.Length)
            {
                Console.WriteLine($"{s2} comes before {s1} in lexicographical order");
            }
            else
            {
                Console.WriteLine($"{s1} comes before {s2} in lexicographical order");
            }
			
        }
	}
}

