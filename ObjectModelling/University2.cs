using System;
namespace ObjectModelling
{
    class Student2
    {
        public string Name { get; set; }

        // Association with Course2
        public List<Course2> Courses { get; set; }

        public Student2(string name)
        {
            Name = name;
            Courses = new List<Course2>();
        }

        public void EnrollCourse(Course2 course)
        {
            if (!Courses.Contains(course))
            {
                Courses.Add(course);
                course.AddStudent(this);
            }

            Console.WriteLine($"{Name} enrolled in {course.Name}");
        }

        public void ViewCourses()
        {
            Console.WriteLine($"\nCourses enrolled by {Name}:");

            foreach (Course2 course in Courses)
            {
                Console.WriteLine($"- {course.Name}");
            }
        }
    }

    class Professor2
    {
        public string Name { get; set; }

        // Association with Course2
        public List<Course2> Courses { get; set; }

        public Professor2(string name)
        {
            Name = name;
            Courses = new List<Course2>();
        }

        public void AssignProfessor(Course2 course)
        {
            if (!Courses.Contains(course))
            {
                Courses.Add(course);
                course.Professor = this;
            }

            Console.WriteLine(
                $"Prof. {Name} assigned to {course.Name}"
            );
        }

        public void ViewCourses()
        {
            Console.WriteLine($"\nCourses taught by Prof. {Name}:");

            foreach (Course2 course in Courses)
            {
                Console.WriteLine($"- {course.Name}");
            }
        }
    }

    class Course2
    {
        public string Name { get; set; }

        // Association with Student2
        public List<Student2> Students { get; set; }

        // Aggregation with Professor2
        public Professor2 Professor { get; set; }

        public Course2(string name)
        {
            Name = name;
            Students = new List<Student2>();
        }

        public void AddStudent(Student2 student)
        {
            if (!Students.Contains(student))
            {
                Students.Add(student);
            }
        }

        public void ViewStudents()
        {
            Console.WriteLine($"\nStudents enrolled in {Name}:");

            foreach (Student2 student in Students)
            {
                Console.WriteLine($"- {student.Name}");
            }
        }

        public void ViewProfessor()
        {
            if (Professor != null)
            {
                Console.WriteLine(
                    $"Professor teaching {Name}: Prof. {Professor.Name}"
                );
            }
        }
    }

    class University2
    {
        public string Name { get; set; }

        public List<Student2> Students { get; set; }
        public List<Professor2> Professors { get; set; }
        public List<Course2> Courses { get; set; }

        public University2(string name)
        {
            Name = name;
            Students = new List<Student2>();
            Professors = new List<Professor2>();
            Courses = new List<Course2>();
        }

        public void AddStudent(Student2 student)
        {
            Students.Add(student);
        }

        public void AddProfessor(Professor2 professor)
        {
            Professors.Add(professor);
        }

        public void AddCourse(Course2 course)
        {
            Courses.Add(course);
        }
    }
}

