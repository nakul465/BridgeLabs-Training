using System;
namespace OOPS
{
	public class Person
	{
		string name;
		int age;
		string gender;
		public Person(string name,int age,string gender)
		{
			this.name = name;
			this.age = age;
			this.gender = gender;
		}
		public Person(Person p1)
		{
			this.name = p1.name;
			this.age = p1.age;
			this.gender = p1.gender;
		}
	}
}

