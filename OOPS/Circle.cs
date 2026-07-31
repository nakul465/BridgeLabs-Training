using System;
namespace OOPS
{
	public class Circle
	{
		double radius;
		public Circle()
		{
			this.radius = 1.0;
		}
        public Circle(double radius)
        {
			this.radius = radius;
        }
        public void Display()
        {
            Console.WriteLine("Radius = " + radius);
        }
    }
}

