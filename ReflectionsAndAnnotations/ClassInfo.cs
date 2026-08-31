using System;
using System.Reflection;

namespace ReflectionsAndAnnotations
{
    class Person1
    {
        public string name;
        private int age;

        public Person1()
        {
        }

        public Person1(string name)
        {
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine(name);
        }

        private void SetAge(int age)
        {
            this.age = age;
        }

        public void DisplayFields()
        {
            Type type = typeof(Person);

            FieldInfo[] fields = type.GetFields(
                BindingFlags.Public |
                BindingFlags.NonPublic |
                BindingFlags.Instance |
                BindingFlags.Static
            );

            foreach (FieldInfo field in fields)
            {
                Console.WriteLine(field.Name);
            }
        }

        public void DisplayMethods()
        {
            Type type = typeof(Person);

            MethodInfo[] methods = type.GetMethods(
                BindingFlags.Public |
                BindingFlags.NonPublic |
                BindingFlags.Instance |
                BindingFlags.Static
            );

            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }
        }

        public void DisplayConstructors()
        {
            Type type = typeof(Person);

            ConstructorInfo[] constructors = type.GetConstructors(
                BindingFlags.Public |
                BindingFlags.NonPublic |
                BindingFlags.Instance |
                BindingFlags.Static
            );

            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor);
            }
        }
    }

}

