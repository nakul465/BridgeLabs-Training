using System;
namespace Strings
{
	public class l1prob9
	{
		public static char l1pob9()
		{
			int[] freqArray = new int[26];
			string str = Console.ReadLine();
            if (string.IsNullOrEmpty(str))
                return '\0';
            str = str.ToLower();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    freqArray[str[i] - 'a']++;
                }
            }
            int maxFreq = freqArray[str[0] - 'a'], index = str[0] - 'a';
			for(int i = 0; i < freqArray.Length; i++)
			{
				if (freqArray[i] > maxFreq)
				{
					maxFreq = freqArray[i];
					index = i;
				}
			}
			return (char)(index + 'a');
		}
	}
}

