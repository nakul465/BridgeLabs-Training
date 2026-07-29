using System;
namespace BuiltInFunctions
{
	public class l2prob8
	{
		public l2prob8()
		{
            double faren = Convert.ToDouble(Console.ReadLine());
            double cel= Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine($"The temp {faren} F in celcius is {FahrenheitToCelsius(faren)}");
            Console.WriteLine($"The temp {cel} C in farenheit is {CelsiusToFahrenheit(faren)}");
        }
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }
}

