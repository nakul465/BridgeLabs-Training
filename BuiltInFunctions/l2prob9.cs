using System;
namespace BuiltInFunctions
{
	public class l2prob9
	{
		public static void  l2pob9()
		{
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Result = " + Add(num1, num2));
                    break;

                case 2:
                    Console.WriteLine("Result = " + Subtract(num1, num2));
                    break;

                case 3:
                    Console.WriteLine("Result = " + Multiply(num1, num2));
                    break;

                case 4:
                    if (num2 != 0)
                        Console.WriteLine("Result = " + Divide(num1, num2));
                    else
                        Console.WriteLine("Division by zero is not possible.");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}

