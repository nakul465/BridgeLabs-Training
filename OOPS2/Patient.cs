using System;
namespace OOPS2
{
	public class Patient
	{
        public static string HospitalName = "City Hospital";
        private static int totalPatients = 0;
        public readonly int PatientID;
        public string Name;
        public int Age;
        public string Ailment;

        public Patient(int PatientID, string Name, int Age, string Ailment)
        {
            this.PatientID = PatientID;
            this.Name = Name;
            this.Age = Age;
            this.Ailment = Ailment;

            totalPatients++;
        }

        public static void GetTotalPatients()
        {
            Console.WriteLine("Total Patients: " + totalPatients);
        }

        public void diplayDetails(Patient p1)
        {
            if (p1 is Patient)
            {
                Console.WriteLine("Hospital   : " + HospitalName);
                Console.WriteLine("Patient ID : " + PatientID);
                Console.WriteLine("Name       : " + Name);
                Console.WriteLine("Age        : " + Age);
                Console.WriteLine("Ailment    : " + Ailment);
            }
            else
            {
                Console.WriteLine("the object provided is not a Patient");
            }
        }
    }
}

