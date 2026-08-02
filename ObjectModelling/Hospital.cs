using System;
namespace ObjectModelling
{
    class Doctor
    {
        public string Name { get; set; }

        // Association with Patient
        public List<Patient> Patients { get; set; }

        public Doctor(string name)
        {
            Name = name;
            Patients = new List<Patient>();
        }

        public void Consult(Patient patient)
        {
            Console.WriteLine(
                $"Dr. {Name} is consulting Patient {patient.Name}"
            );

            if (!Patients.Contains(patient))
            {
                Patients.Add(patient);
            }

            if (!patient.Doctors.Contains(this))
            {
                patient.Doctors.Add(this);
            }
        }
    }

    class Patient
    {
        public string Name { get; set; }

        // Association with Doctor
        public List<Doctor> Doctors { get; set; }

        public Patient(string name)
        {
            Name = name;
            Doctors = new List<Doctor>();
        }

        public void ViewDoctors()
        {
            Console.WriteLine($"\nDoctors consulted by {Name}:");

            foreach (Doctor doctor in Doctors)
            {
                Console.WriteLine($"- Dr. {doctor.Name}");
            }
        }
    }

    class Hospital
    {
        public string Name { get; set; }

        public List<Doctor> Doctors { get; set; }
        public List<Patient> Patients { get; set; }

        public Hospital(string name)
        {
            Name = name;
            Doctors = new List<Doctor>();
            Patients = new List<Patient>();
        }

        public void AddDoctor(Doctor doctor)
        {
            Doctors.Add(doctor);
        }

        public void AddPatient(Patient patient)
        {
            Patients.Add(patient);
        }

        public void ViewDoctors()
        {
            Console.WriteLine($"\nDoctors in {Name}:");

            foreach (Doctor doctor in Doctors)
            {
                Console.WriteLine($"- Dr. {doctor.Name}");
            }
        }

        public void ViewPatients()
        {
            Console.WriteLine($"\nPatients in {Name}:");

            foreach (Patient patient in Patients)
            {
                Console.WriteLine($"- {patient.Name}");
            }
        }
    }

}

