using System;
using System.Reflection;

namespace Inheritance
{
	public interface Refuelable
	{
		public void Refuel();
	}


    public class Vehiclee
	{
		public int MaxSpeed;
		public string Model;

        public Vehiclee(int MaxSpeed, string Model)
		{
			this.MaxSpeed = MaxSpeed;
			this.Model = Model;
		}
	}


	class ElectricVehicle:Vehiclee
	{
        public ElectricVehicle(int MaxSpeed, string Model) : base(MaxSpeed, Model)
        {
        }

        public void charge()
		{
			Console.WriteLine($"{Model} car with MaxSpeed : {MaxSpeed} is fully charged");
		}
	}


	class PetrolVehicle:Vehiclee,Refuelable
	{
		public PetrolVehicle(int MaxSpeed, string Model) :base(MaxSpeed,Model)
		{
		}

        public void Refuel()
		{
            Console.WriteLine($"{Model} car with MaxSpeed : {MaxSpeed} is fully Refueled");
        }
    }
}

