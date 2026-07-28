using System;
namespace Strings
{
	public class l1prob11
	{
		public static bool l1pob11()
		{
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            s1 = s1.ToLower();
            s2 = s2.ToLower();

            if (s1.Length != s2.Length)
            {

                return false ;
            }

            int[] freq = new int[26];

            for (int i = 0; i < s1.Length; i++)
            {
                freq[s1[i] - 'a']++;
            }

            for (int i = 0; i < s2.Length; i++)
            {
                freq[s2[i] - 'a']--;
            }

            for (int i = 0; i < 26; i++)
            {
                if (freq[i] != 0)
                {
                    return false; ;
                }
            }

            return true;
        }
	}
}

