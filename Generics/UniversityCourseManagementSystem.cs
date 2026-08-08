using System;
namespace Generics
{
    public abstract class CourseType
    {
        public string EvaluationType { get; set; }

        public CourseType(string evaluationType)
        {
            EvaluationType = evaluationType;
        }

        public abstract void DisplayEvaluation();
    }

    public class ExamCourse : CourseType
    {
        public ExamCourse() : base("Exam")
        {
        }

        public override void DisplayEvaluation()
        {
            Console.WriteLine("Evaluation is based on examination.");
        }
    }

    public class AssignmentCourse : CourseType
    {
        public AssignmentCourse() : base("Assignment")
        {
        }

        public override void DisplayEvaluation()
        {
            Console.WriteLine("Evaluation is based on assignments.");
        }
    }

    public class Course<T> where T : CourseType
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public T CourseType { get; set; }

        public Course(int courseId, string courseName, T courseType)
        {
            CourseId = courseId;
            CourseName = courseName;
            CourseType = courseType;
        }

        public void DisplayCourse()
        {
            Console.WriteLine($"Course ID: {CourseId}, Course Name: {CourseName}, Evaluation: {CourseType.EvaluationType}");
            CourseType.DisplayEvaluation();
        }
    }
}

