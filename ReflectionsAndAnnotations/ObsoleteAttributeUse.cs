using System;
namespace ReflectionsAndAnnotations
{
	public class LegacyAPI
	{
		[Obsolete("use new method instead")]
		public void OldFeature()
		{
			Console.WriteLine("Old Feature");
		}
		public void NewFeature()
		{
			Console.WriteLine("New Feature");
		}

	}
}

