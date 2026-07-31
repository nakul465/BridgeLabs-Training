using System;
using System.Diagnostics;
using System.Xml.Linq;

namespace OOPS2
{
	public class Vehicle
	{
        public static double RegistrationFee = 5000;
        public readonly string RegistrationNumber;
        public string OwnerName;
        public string VehicleType;

        public Vehicle(string RegistrationNumber, string OwnerName, string VehicleType)
        {
            this.RegistrationNumber = RegistrationNumber;
            this.OwnerName = OwnerName;
            this.VehicleType = VehicleType;
        }

        public static void UpdateRegistrationFee(double newFee)
        {
            RegistrationFee = newFee;
        }

        public void DisplayDetails()
        {

        }
        public void diplayDetails(Vehicle v1)
        {
            if (v1 is Vehicle)
            {
                Console.WriteLine("Registration Number : " + RegistrationNumber);
                Console.WriteLine("Owner Name          : " + OwnerName);
                Console.WriteLine("Vehicle Type        : " + VehicleType);
                Console.WriteLine("Registration Fee    : " + RegistrationFee);
            }
            else
            {
                Console.WriteLine("the object provided is not a Vehicle");
            }
        }
    }
}

