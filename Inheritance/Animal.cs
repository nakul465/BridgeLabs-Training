using System;
namespace Inheritance
{
	public class Animal
	{
		public string name;
		public int age;
		public Animal(string name,int age)
		{
            this.name = name;
            this.age = age;
		}
		public virtual void MakeSound()
		{
			Console.WriteLine("Animal Makes a Sound");
		}
	}
	class Dog : Animal
	{
        public Dog(string name,int age):base(name,age)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine("Dog Barks");
        }
    }
	class Cat : Animal
	{
        public Cat(string name, int age) : base(name, age)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }
	class Bird : Animal
	{
        public Bird(string name, int age) : base(name, age)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine("Bird chirps");
        }
    }
}

