using System;
namespace EncapsulatioAndPolymorphism
{
    public interface IInsurable
    {
        double CalculateInsurance();
        void GetInsuranceDetails();
    }

    public abstract class Vehicle
    {
        private string vehicleNumber;
        private string type;
        private double rentalRate;

        public string VehicleNumber
        {
            get { return vehicleNumber; }
            set { vehicleNumber = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public double RentalRate
        {
            get { return rentalRate; }
            set { if (value >= 0) rentalRate = value; }
        }

        public Vehicle(string vehicleNumber, string type, double rentalRate)
        {
            this.vehicleNumber = vehicleNumber;
            this.type = type;
            this.rentalRate = rentalRate;
        }

        public abstract double CalculateRentalCost(int days);

        public void DisplayDetails()
        {
            Console.WriteLine($"Vehicle Number: {vehicleNumber}");
            Console.WriteLine($"Vehicle Type: {type}");
            Console.WriteLine($"Rental Rate: {rentalRate} per day");
        }
    }

    public class Car : Vehicle, IInsurable
    {
        private string insurancePolicyNumber;

        public Car(string vehicleNumber, string type, double rentalRate, string insurancePolicyNumber) : base(vehicleNumber, type, rentalRate)
        {
            this.insurancePolicyNumber = insurancePolicyNumber;
        }

        public override double CalculateRentalCost(int days)
        {
            return (RentalRate * days) * 1.10;
        }

        public double CalculateInsurance()
        {
            return 500;
        }

        public void GetInsuranceDetails()
        {
            Console.WriteLine($"Insurance Type: Comprehensive");
            Console.WriteLine($"Policy Number: {insurancePolicyNumber}");
        }
    }

    public class Bike : Vehicle, IInsurable
    {
        private string insurancePolicyNumber;

        public Bike(string vehicleNumber, string type, double rentalRate, string insurancePolicyNumber) : base(vehicleNumber, type, rentalRate)
        {
            this.insurancePolicyNumber = insurancePolicyNumber;
        }

        public override double CalculateRentalCost(int days)
        {
            return (RentalRate * days) * 1.05;
        }

        public double CalculateInsurance()
        {
            return 200;
        }

        public void GetInsuranceDetails()
        {
            Console.WriteLine($"Insurance Type: Basic");
            Console.WriteLine($"Policy Number: {insurancePolicyNumber}");
        }
    }

    public class Truck : Vehicle, IInsurable
    {
        private string insurancePolicyNumber;

        public Truck(string vehicleNumber, string type, double rentalRate, string insurancePolicyNumber) : base(vehicleNumber, type, rentalRate)
        {
            this.insurancePolicyNumber = insurancePolicyNumber;
        }

        public override double CalculateRentalCost(int days)
        {
            return (RentalRate * days) * 1.20;
        }

        public double CalculateInsurance()
        {
            return 1000;
        }

        public void GetInsuranceDetails()
        {
            Console.WriteLine($"Insurance Type: Commercial");
            Console.WriteLine($"Policy Number: {insurancePolicyNumber}");
        }
    }
}

