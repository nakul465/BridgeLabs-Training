using System;
using System.Reflection;

namespace ReflectionsAndAnnotations
{
    class Person
    {
        private int age;

        public void AccessPrivateField()
        {
            // Get the Type of Person
            Type type = typeof(Person);

            // Get the private field
            FieldInfo field = type.GetField("age",BindingFlags.NonPublic |BindingFlags.Instance);

            // Create an object of Person
            Person person = this;

            // Modify private field
            field.SetValue(person, 25);

            // Retrieve private field
            int value = (int)field.GetValue(person);

            Console.WriteLine("Age: " + value);
        }
    }
}

