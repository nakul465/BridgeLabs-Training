using System;
namespace Methods
{
	public class l2prob6
	{
        public static double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public static double ConvertCelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static double ConvertPoundsToKilograms(double pounds)
        {
            double pounds2kilograms = 0.453592;
            return pounds * pounds2kilograms;
        }

        public static double ConvertKilogramsToPounds(double kilograms)
        {
            double kilograms2pounds = 2.20462;
            return kilograms * kilograms2pounds;
        }

        public static double ConvertGallonsToLiters(double gallons)
        {
            double gallons2liters = 3.78541;
            return gallons * gallons2liters;
        }

        public static double ConvertLitersToGallons(double liters)
        {
            double liters2gallons = 0.264172;
            return liters * liters2gallons;
        }
    }
}

