using System;
namespace CSVDataHandling
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Marks { get; set; }
    }

    public class ReadAndWriteCsvFile
    {

        static void ReadCsv(string filePath)
        {
            using StreamReader reader = new StreamReader(filePath);
            reader.ReadLine();

            string? line;

            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(',');

                Student student = new Student
                {
                    Id = int.Parse(data[0]),
                    Name = data[1],
                    Age = int.Parse(data[2]),
                    Marks = double.Parse(data[3])
                };

                Console.WriteLine($"ID: {student.Id}, " +$"Name: {student.Name}, " +$"Age: {student.Age}, " +$"Marks: {student.Marks}"
                );
            }
        }

        static void WriteEmployeesToCsv(string filePath)
        {
            using StreamWriter writer = new StreamWriter(filePath);
            writer.WriteLine("ID,Name,Department,Salary");

            writer.WriteLine("101,Nakul,IT,60000");
            writer.WriteLine("102,Rahul,HR,50000");
            writer.WriteLine("103,Ananya,Finance,70000");
            writer.WriteLine("104,Aman,IT,65000");
            writer.WriteLine("105,Simran,Marketing,55000");

            Console.WriteLine("Employee data written successfully.");
        }
    }
}

