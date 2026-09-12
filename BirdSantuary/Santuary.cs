using System;
namespace BirdSantuary
{ 
	public enum Gender{
		MALE = 0,
		FEMALE = 1
	}

	public interface IFlyable
	{
		public void Fly(); 
	}

	public interface IRunabale
	{
		public void Run();
    }

	public interface ISwimable
	{
		public void Swim();
    }

	public abstract class Bird 
	{
		public int Id { get; }
		public Gender Gender { get; }
        public string Type { get; }
        public bool CanFly { get; set; }
        public bool CanSwim { get; set; }
        public bool CanRun { get; set; }

		public Bird(int id,string type,Gender gender)
		{
			Gender = gender;
			Id = id;
			Type = type;
		}

        public override bool Equals(object? obj)
		{
			return obj is Bird bird && bird.Id == Id;
		}

		public override int GetHashCode()
		{
			return Id.GetHashCode();
		}
	}

	public class Duck : Bird,ISwimable,IFlyable
	{
		public Duck(int id,string type ,Gender gender):base(id,type,gender)
		{
			CanFly = true;
			CanSwim = true;
			CanRun = true;
		}
		public void Fly()
		{
			Console.WriteLine("A Duck can fly");
		}

        public void Swim()
        {
            Console.WriteLine("A Duck can Swim");
        }
    }

    public class Ostrich : Bird,IRunabale
    {
        public Ostrich(int id, string type, Gender gender) : base(id, type, gender)
        {
            CanFly = false;
            CanSwim = false;
            CanRun = true;
        }
		public void Run()
		{
            Console.WriteLine("An Ostrich can Run");
        }
    }

    public class Sparrow : Bird,IFlyable
    {
        public Sparrow(int id, string type, Gender gender) : base(id, type, gender)
        {
            CanFly = true;
            CanSwim = false;
			CanRun = false;
        }
        public void Fly()
        {
            Console.WriteLine("A Duck can fly");
        }
    }
    public class Santuary
	{
		Dictionary<int, string> removedBirds;
		public HashSet<Bird> birds;
		public Santuary()
		{
			removedBirds = new();
			birds = new HashSet<Bird>();
		}

		public void Add(Bird bird)
		{
            birds.Add(bird);
        }

        public void Remove(Bird bird,string reason)
        {
			if (birds.Contains(bird))
			{
				birds.Remove(bird);
				removedBirds[bird.Id] = reason;
			}
			else
			{
				Console.WriteLine("bird doesn't exist");
			}
        }

		public void DisplayBirds()
		{
			foreach(Bird b in birds)
			{
				Console.WriteLine($"{b.Id}");
			}
		}

		public void DisplayRemovedBirds()
		{
			foreach(KeyValuePair<int ,string> pair in removedBirds)
			{
				Console.WriteLine($"Bird {pair.Key} removed due to : {pair.Value}");
			}
		}
    }
}

