using System;
namespace OOPS
{
	public class Vehicle
	{
		string vehicleType;
		string OwnerName;
		static int registrationFee=1000;
		public Vehicle()
		{
			this.vehicleType = "Car";
			this.OwnerName = "Ram";
		}
		public Vehicle(string vehicleType,string ownerName)
        {
            this.vehicleType = vehicleType;
            this.OwnerName = ownerName;
        }
		public void displayDetails()
		{
			Console.WriteLine("Vehicle Type     : "+vehicleType);
            Console.WriteLine("Owner Name       : " + OwnerName);
            Console.WriteLine("Registartion Fee : " + registrationFee);
        }
		public void updateRegistrationFee(int fee)
		{
			registrationFee = fee;
		}

    }
}

