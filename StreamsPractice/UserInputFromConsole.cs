using System;
namespace StreamsPractice
{
	public class UserInputFromConsole
	{
        static void SaveUserDetails(string fileName)
        {
            try
            {
                using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
                {
                    Console.Write("Enter your name: ");
                    string name = reader.ReadLine();

                    Console.Write("Enter your age: ");
                    int age = Convert.ToInt32(reader.ReadLine());

                    Console.Write("Enter your favorite programming language: ");
                    string language = reader.ReadLine();

                    using (StreamWriter writer = new StreamWriter(fileName))
                    {
                        writer.WriteLine($"Name: {name}");
                        writer.WriteLine($"Age: {age}");
                        writer.WriteLine($"Favorite Language: {language}");
                    }
                }

                Console.WriteLine("User details saved successfully.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid age. Please enter a number.");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"File error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}

