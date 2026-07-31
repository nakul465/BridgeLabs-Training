using System;
using System.Xml.Linq;

namespace OOPS2
{
	public class Product
	{
		public static double discount = 10.0;
		string productName;
		double price;
		int qty;
		readonly int productID;
		public Product()
		{
			this.productName = "Cookie";
			this.price = 20.0;
			this.qty = 10;
			this.productID = 0;

        }
        public Product(string productName,double price,int qty,int productID)
        {
            this.productName = productName;
            this.price = price;
            this.qty = qty;
			this.productID = productID;
        }
        public static void UpdateDiscount(double disc)
		{
			discount = disc;
		}
        public void diplayDetails(Product p1)
        {
            if (p1 is Product)
            {
                Console.WriteLine("Product Name         : " + productName);
                Console.WriteLine("Product ID           : " + productID);
                Console.WriteLine("Qty  : " + qty);
                Console.WriteLine("Final Price  : " + (qty*price)*((100-discount)/100));
            }
            else
            {
                Console.WriteLine("the object provided is not a Product");
            }
        }
    }
}

