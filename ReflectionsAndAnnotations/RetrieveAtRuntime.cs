using System;
namespace ReflectionsAndAnnotations
{
    [AttributeUsage(AttributeTargets.Class)]
    class AuthorAttribute : Attribute
    {
        public string Name { get; }

        public AuthorAttribute(string name)
        {
            Name = name;
        }
    }

    [Author("Nakul Arora")]
    class Student1
    {
        public void Display()
        {
            Console.WriteLine("Student class");
        }
    }

}

