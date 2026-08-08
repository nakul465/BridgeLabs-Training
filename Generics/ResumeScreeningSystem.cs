using System;
namespace Generics
{
    public abstract class JobRole
    {
        public string RoleName { get; set; }

        public JobRole(string roleName)
        {
            RoleName = roleName;
        }

        public abstract void DisplayRequirements();
    }

    public class SoftwareEngineer : JobRole
    {
        public SoftwareEngineer() : base("Software Engineer")
        {
        }

        public override void DisplayRequirements()
        {
            Console.WriteLine("Requirements: C#, Java, SQL and Data Structures.");
        }
    }

    public class DataScientist : JobRole
    {
        public DataScientist() : base("Data Scientist")
        {
        }

        public override void DisplayRequirements()
        {
            Console.WriteLine("Requirements: Python, Machine Learning, Statistics and SQL.");
        }
    }

    public class Resume<T> where T : JobRole
    {
        public string CandidateName { get; set; }
        public T JobRole { get; set; }
        public int Experience { get; set; }

        public Resume(string candidateName, T jobRole, int experience)
        {
            CandidateName = candidateName;
            JobRole = jobRole;
            Experience = experience;
        }

        public void DisplayResume()
        {
            Console.WriteLine($"Candidate: {CandidateName}");
            Console.WriteLine($"Role: {JobRole.RoleName}");
            Console.WriteLine($"Experience: {Experience} years");
        }
    }

    public class ResumeScreening
    {
        public void ScreenResume<T>(T resume) where T : JobRole
        {
            Console.WriteLine($"Screening resume for: {resume.RoleName}");
            resume.DisplayRequirements();
        }
    }
}

