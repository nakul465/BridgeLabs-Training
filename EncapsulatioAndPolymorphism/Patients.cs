using System;
namespace EncapsulatioAndPolymorphism
{
    public interface IMedicalRecord
    {
        void AddRecord(string record);
        void ViewRecords();
    }

    public abstract class Patient
    {
        private int patientId;
        private string name;
        private int age;

        public int PatientId
        {
            get { return patientId; }
            set { patientId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Patient(int patientId, string name, int age)
        {
            this.patientId = patientId;
            this.name = name;
            this.age = age;
        }

        public abstract double CalculateBill();

        public void GetPatientDetails()
        {
            Console.WriteLine($"Patient ID: {patientId}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Bill: {CalculateBill()}");
        }
    }

    public class InPatient : Patient, IMedicalRecord
    {
        private string diagnosis;
        private string medicalHistory;
        private List<string> records = new List<string>();

        public int DaysAdmitted { get; set; }
        public double DailyCharge { get; set; }

        public InPatient(int patientId, string name, int age, int daysAdmitted, double dailyCharge, string diagnosis, string medicalHistory) : base(patientId, name, age)
        {
            DaysAdmitted = daysAdmitted;
            DailyCharge = dailyCharge;
            this.diagnosis = diagnosis;
            this.medicalHistory = medicalHistory;
        }

        public override double CalculateBill()
        {
            return DaysAdmitted * DailyCharge;
        }

        public void AddRecord(string record)
        {
            records.Add(record);
        }

        public void ViewRecords()
        {
            Console.WriteLine($"Diagnosis: {diagnosis}");
            Console.WriteLine($"Medical History: {medicalHistory}");

            foreach (string record in records)
            {
                Console.WriteLine($"Record: {record}");
            }
        }
    }

    public class OutPatient : Patient, IMedicalRecord
    {
        private string diagnosis;
        private string medicalHistory;
        private List<string> records = new List<string>();

        public double ConsultationFee { get; set; }

        public OutPatient(int patientId, string name, int age, double consultationFee, string diagnosis, string medicalHistory) : base(patientId, name, age)
        {
            ConsultationFee = consultationFee;
            this.diagnosis = diagnosis;
            this.medicalHistory = medicalHistory;
        }

        public override double CalculateBill()
        {
            return ConsultationFee;
        }

        public void AddRecord(string record)
        {
            records.Add(record);
        }

        public void ViewRecords()
        {
            Console.WriteLine($"Diagnosis: {diagnosis}");
            Console.WriteLine($"Medical History: {medicalHistory}");

            foreach (string record in records)
            {
                Console.WriteLine($"Record: {record}");
            }
        }
    }
}

