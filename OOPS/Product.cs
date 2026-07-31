using System;
namespace OOPS
{
	public class Product
	{
		string productName;
		int price;
		static int totalProducts=0;
		public Product(string productName,int price)
		{
			this.productName = productName;
			this.price = price;
			totalProducts++;
		}
        public Product()
        {
            this.productName = "Pen";
            this.price = 20;
        }
		public static void totalPro()
		{
			Console.WriteLine("the total number of products are " + totalProducts);
		}
    }
}

