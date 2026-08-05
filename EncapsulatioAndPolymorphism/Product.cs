using System;
namespace EncapsulatioAndPolymorphism
{
    public interface ITaxable
    {
        double CalculateTax();
        void GetTaxDetails();
    }

    public abstract class Product
    {
        private int productId;
        private string name;
        private double price;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                    price = value;
                else
                    Console.WriteLine("Price cannot be negative.");
            }
        }

        public Product(int productId, string name, double price)
        {
            this.productId = productId;
            this.name = name;
            this.price = price;
        }

        public abstract double CalculateDiscount();

        public void DisplayDetails()
        {
            Console.WriteLine($"Product ID: {productId}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Price: {price}");
        }
    }


    public class Electronics : Product, ITaxable
    {
        public Electronics(int productId, string name, double price): base(productId, name, price)
        {
        }

        public override double CalculateDiscount()
        {
            return Price * 0.10;
        }

        public double CalculateTax()
        {
            return Price * 0.18;
        }

        public void GetTaxDetails()
        {
            Console.WriteLine("Electronics Tax: 18%");
        }
    }


    public class Clothing : Product, ITaxable
    {
        public Clothing(int productId, string name, double price) : base(productId, name, price)
        {
        }

        public override double CalculateDiscount()
        {
            return Price * 0.20;
        }

        public double CalculateTax()
        {
            return Price * 0.05;
        }

        public void GetTaxDetails()
        {
            Console.WriteLine("Clothing Tax: 5%");
        }
    }


    public class Groceries : Product
    {
        public Groceries(int productId, string name, double price) : base(productId, name, price)
        {
        }

        public override double CalculateDiscount()
        {
            return Price * 0.05;
        }
    }
}

