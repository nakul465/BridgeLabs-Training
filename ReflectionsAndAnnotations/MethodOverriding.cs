using System;
namespace ReflectionsAndAnnotations
{
	public class Animal
	{
		[Obsolete("Use make sound instead")]
		public void MakeSound()
		{
			Console.WriteLine("Animal Makes sound");
		}
	}
	public class Dog : Animal
	{
		public void MakeSound()
		{
			Console.WriteLine("Dog Barks");
		}
	}
}

