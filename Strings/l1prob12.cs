using System;
namespace Strings
{
	public class l1prob12
	{
		public static string l1pob12()
		{
            string sentence = Console.ReadLine();
            string oldWord = Console.ReadLine();
            string newWord = Console.ReadLine();
            string result = sentence.Replace(oldWord, newWord);
            return result;
        }
	}
}

