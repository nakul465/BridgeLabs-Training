using System;
using System.Reflection;

namespace ReflectionsAndAnnotations
{
	public class ImportantMethod:Attribute
	{
		public string level ;
		public ImportantMethod()
		{
			level = "high";
		}
	}

	public class MethodLib
	{
		[ImportantMethod(level="low")]
		public void Method1()
		{

		}

        [ImportantMethod]
        public void Method2()
        {

        }

        public void Method3()
        {

        }

		public void DisplayMethodLevels()
		{
			Type type = typeof(MethodLib);
			var methods = type.GetMethods();
			foreach(var method in methods)
			{
				var attribute = method.GetCustomAttribute<ImportantMethod>();

                if(attribute != null)
				{
					Console.WriteLine($"{method.Name} Level : {attribute.level}");
				}
			}
		}
    }
}

