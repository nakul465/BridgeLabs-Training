using System;
namespace ObjectModelling
{
    class Student
    {
        public string Name { get; set; }

        // Association with Course
        public List<Course> Courses { get; set; }

        public Student(string name)
        {
            Name = name;
            Courses = new List<Course>();
        }

        public void EnrollCourse(Course course)
        {
            if (!Courses.Contains(course))
            {
                Courses.Add(course);
                course.AddStudent(this);
            }
        }

        public void ViewCourses()
        {
            Console.WriteLine($"\nCourses enrolled by {Name}:");

            foreach (Course course in Courses)
            {
                Console.WriteLine($"- {course.Name}");
            }
        }
    }

    class Course
    {
        public string Name { get; set; }

        // Association with Student
        public List<Student> Students { get; set; }

        public Course(string name)
        {
            Name = name;
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            if (!Students.Contains(student))
            {
                Students.Add(student);
            }
        }

        public void ViewStudents()
        {
            Console.WriteLine($"\nStudents enrolled in {Name}:");

            foreach (Student student in Students)
            {
                Console.WriteLine($"- {student.Name}");
            }
        }
    }

    class School
    {
        public string Name { get; set; }

        // Aggregation with Student
        public List<Student> Students { get; set; }

        public School(string name)
        {
            Name = name;
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            if (!Students.Contains(student))
            {
                Students.Add(student);
            }
        }

        public void ViewStudents()
        {
            Console.WriteLine($"\nStudents in {Name}:");

            foreach (Student student in Students)
            {
                Console.WriteLine($"- {student.Name}");
            }
        }
    }
}


