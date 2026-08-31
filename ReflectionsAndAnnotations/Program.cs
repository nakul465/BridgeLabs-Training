//// See https://aka.ms/new-console-template for more information
using ReflectionsAndAnnotations;
using System.Reflection;

//Console.WriteLine("Hello, World!");

//Calculator calculator = new Calculator();
//Type type = typeof(Calculator);

//MethodInfo method = type.GetMethod("Multiply",BindingFlags.NonPublic | BindingFlags.Instance);

//// Invoke the private method
//object result = method.Invoke(calculator,new object[] { 5, 4 });

//Console.WriteLine("Result: " + result);



//Type type1 = typeof(Student);

//object obj = Activator.CreateInstance(type1);

//Student student = (Student)obj;
//student.Display();






//MathOperations math = new MathOperations();

//Console.Write("Enter method name (Add/Subtract/Multiply): ");
//string methodName = Console.ReadLine();

//Console.Write("Enter first number: ");
//int a = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter second number: ");
//int b = Convert.ToInt32(Console.ReadLine());

//Type type2 = typeof(MathOperations);

//MethodInfo method2 = type2.GetMethod(methodName);

//if (method == null)
//{
//    Console.WriteLine("Method not found.");
//    return;
//}

//object result2 = method.Invoke(math,new object[] { a, b });

//Console.WriteLine("Result: " + result2);



//Type type3 = typeof(Student1);

//AuthorAttribute attribute =(AuthorAttribute)Attribute.GetCustomAttribute(type3,typeof(AuthorAttribute));

//if (attribute != null)
//{
//    Console.WriteLine("Author: " + attribute.Name);
//}
//else
//{
//    Console.WriteLine("Author attribute not found.");
//}



//Type type4 = typeof(Configuration);

//// Get the private static field
//FieldInfo field = type4.GetField("API_KEY",BindingFlags.NonPublic | BindingFlags.Static);

//// Modify the static field
//field.SetValue(null, "NEW_API_KEY_123");

//// Retrieve the modified value
//object value = field.GetValue(null);

//Console.WriteLine("API_KEY: " + value);

//Animal dog = new Dog();
//dog.MakeSound();

//LegacyAPI api = new LegacyAPI();
//api.OldFeature();
//api.NewFeature();

//User ram = new User("Nakulbbjcbjewbjbwejhcdbe");

//TaskManager tm = new TaskManager();
//tm.DisplayTaskInfo();

//Website web = new Website();
//web.DisplayBugReport();

MethodLib ml = new MethodLib();
ml.DisplayMethodLevels();