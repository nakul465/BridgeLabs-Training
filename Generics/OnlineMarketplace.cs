using System;
namespace Generics
{
    public abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }

    public class Product<T> : Product where T : class
    {
        public T Category { get; set; }

        public Product(string name, double price, T category) : base(name, price)
        {
            Category = category;
        }
    }

    public class BookCategory
    {
        public string Genre { get; set; }

        public BookCategory(string genre)
        {
            Genre = genre;
        }
    }

    public class ClothingCategory
    {
        public string Type { get; set; }

        public ClothingCategory(string type)
        {
            Type = type;
        }
    }

    public class Marketplace
    {
        public void ApplyDiscount<T>(T product, double percentage) where T : Product
        {
            product.Price = product.Price - (product.Price * percentage / 100);
        }
    }
}

