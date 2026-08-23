using System;
namespace ReflectionsAndAnnotations
{
    class Student
    {
        public string name;
        public int age;

        public Student()
        {
            name = "Nakul";
            age = 21;
        }

        public void Display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }
}

