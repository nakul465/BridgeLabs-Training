using System;
namespace ObjectModelling
{
    class Faculty
    {
        public string Name { get; set; }
        public Faculty(string name)
        {
            Name = name;
        }
    }

    class Deppartment
    {
        public string Name { get; set; }
        public Deppartment(string name)
        {
            Name = name;
        }
    }

    class University
    {
        public string Name { get; set; }
        private List<Deppartment> deppartments;
        private List<Faculty> faculties;

        public University(string name)
        {
            Name = name;
            deppartments = new List<Deppartment>();
            faculties = new List<Faculty>();
        }

        public void AddDeppartment(string deppartmentName)
        {
            Deppartment deppartment = new Deppartment(deppartmentName);
            deppartments.Add(deppartment);
        }

        public void AddFaculty(Faculty faculty)
        {
            faculties.Add(faculty);
        }

        public void DisplayUniversity()
        {
            Console.WriteLine($"\nUniversity: {Name}");

            Console.WriteLine("\nDeppartments:");

            foreach (Deppartment deppartment in deppartments)
            {
                Console.WriteLine($"- {deppartment.Name}");
            }

            Console.WriteLine("\nFaculty:");

            foreach (Faculty faculty in faculties)
            {
                Console.WriteLine($"- {faculty.Name}");
            }
        }
    }

}


