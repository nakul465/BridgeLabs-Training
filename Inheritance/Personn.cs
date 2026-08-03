using System;
namespace Inheritance
{
	public interface IWorker
	{
		public void PerformDuties();
    }


	public class Personn
	{
		public string name;
		public int id;

		public Personn(string name,int id)
		{
			this.name = name;
			this.id = id;
		}
    }


	public class Chef:Personn, IWorker
    {
		public Chef(string name, int id) :base(name,id)
		{
		}

        public void PerformDuties()
		{
			Console.WriteLine($"Chef {name} id: {id} cooks Food");
		}
    }


	public class Waiter : Personn, IWorker
    {
		public Waiter(string name, int id) : base(name, id)
		{
		}

        public void PerformDuties()
		{
            Console.WriteLine($"Waiter {name} id : {id} serves Food");
        }
    }
}

