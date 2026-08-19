using System;
using System.Text;

namespace SearchingTechniques
{
	public class StringBuilder1
	{
        static string ReverseString(string str)
        {
            StringBuilder sb = new StringBuilder(str);

            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            return sb.ToString();
        }
    }
}

