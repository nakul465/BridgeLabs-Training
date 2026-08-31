using System;
using System.Reflection;

namespace ReflectionsAndAnnotations
{
	class MaximumLength : Attribute
	{
        public int length;
        public MaximumLength(int length)
		{
            this.length = length;
		}
	}
	public class User
	{
		[MaximumLength(15)]
		public string username;
		public User(string username)
		{
			Type type = typeof(User);
			var field = type.GetField("username");
			this.username = username;
			var attribute = field!.GetCustomAttribute<MaximumLength>();

            if (username.Length > attribute.length)
			{
				throw new ArgumentException($"Username cannot exceed {attribute.length} characters.");
            }
		}
	}
}

