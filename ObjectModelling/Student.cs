using System;
namespace ObjectModelling
{
    class Subjectt
    {
        public string Name { get; set; }
        public int Marks { get; set; }

        public Subjectt(string name, int marks)
        {
            Name = name;
            Marks = marks;
        }
    }

    class Studentt
    {
        public string Name { get; set; }

        // Aggregation
        public List<Subjectt> Subjects { get; set; }

        public Studentt(string name)
        {
            Name = name;
            Subjects = new List<Subjectt>();
        }

        public void AddSubject(Subjectt subject)
        {
            Subjects.Add(subject);
        }

        public void ViewSubjects()
        {
            Console.WriteLine($"Student: {Name}");

            foreach (Subjectt subject in Subjects)
            {
                Console.WriteLine($"{subject.Name}: {subject.Marks}");
            }
        }
    }

    class GradeCalculatorr
    {
        public void CalculateGrade(Studentt student)
        {
            int total = 0;

            foreach (Subjectt subject in student.Subjects)
            {
                total += subject.Marks;
            }

            double average = (double)total / student.Subjects.Count;

            Console.WriteLine($"\nStudent: {student.Name}");
            Console.WriteLine($"Average Marks: {average}");

            if (average >= 90)
                Console.WriteLine("Grade: A");
            else if (average >= 80)
                Console.WriteLine("Grade: B");
            else if (average >= 70)
                Console.WriteLine("Grade: C");
            else if (average >= 60)
                Console.WriteLine("Grade: D");
            else
                Console.WriteLine("Grade: F");
        }
    }
}

