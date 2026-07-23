using System;
namespace Day2
{
	public class CmToInches
	{
		public static double CmToInch(int height)
		{
			return height / 2.54;
		}
        public static double CmToFeet(int height)
        {
            return (height / 2.54)/12;
        }
    }
}

