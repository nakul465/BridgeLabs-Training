using System;
using Microsoft.VisualBasic.FileIO;

namespace Inheritance
{
	public class Vehicle
	{
		public int MaxSpeed;
		public string FuelType;

        public Vehicle(int MaxSpeed, string FuelType)
		{
            this.MaxSpeed = MaxSpeed;
            this.FuelType = FuelType;
		}

		public virtual void DisplayInfo()
		{
			Console.WriteLine($"\nMaxSpeed : {MaxSpeed}\nFuelType : {FuelType}");
		}

    }


	class Car : Vehicle
	{
        int SeatCapacity;

        public Car(int MaxSpeed, string FuelType, int SeatCapacity) : base(MaxSpeed,FuelType)
        {
            this.SeatCapacity = SeatCapacity;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"\nMaxSpeed : {MaxSpeed}\nFuelType : {FuelType}\nSeatCapacity : {SeatCapacity}");
        }

    }


	class Truck : Vehicle
    {
        int PayloadCapacity;

        public Truck(int MaxSpeed, string FuelType, int PayloadCapacity) : base(MaxSpeed, FuelType)
        {
            this.PayloadCapacity = PayloadCapacity;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"\nMaxSpeed : {MaxSpeed}\nFuelType : {FuelType}\nPayloadCapacity : {PayloadCapacity}");
        }

    }


	class Motorcycle : Vehicle
    {
        bool HasSidecar;

        public Motorcycle(int MaxSpeed, string FuelType, bool HasSidecar) : base(MaxSpeed, FuelType)
        {
            this.HasSidecar = HasSidecar;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"\nMaxSpeed : {MaxSpeed}\nFuelType : {FuelType}\nHasSidecar : {HasSidecar}");
        }

    }


}

