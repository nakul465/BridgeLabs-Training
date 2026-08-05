using System;
namespace EncapsulatioAndPolymorphism
{
    public interface IDiscountable
    {
        double ApplyDiscount();
        void GetDiscountDetails();
    }

    public abstract class FoodItem
    {
        private string itemName;
        private double price;
        private int quantity;

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                    price = value;
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value > 0)
                    quantity = value;
            }
        }

        public FoodItem(string itemName, double price, int quantity)
        {
            this.itemName = itemName;
            this.price = price;
            this.quantity = quantity;
        }

        public abstract double CalculateTotalPrice();

        public void GetItemDetails()
        {
            Console.WriteLine($"Item Name: {itemName}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Total Price: {CalculateTotalPrice()}");
        }
    }

    public class VegItem : FoodItem, IDiscountable
    {
        public VegItem(string itemName, double price, int quantity) : base(itemName, price, quantity)
        {
        }

        public override double CalculateTotalPrice()
        {
            return (Price * Quantity) + 20;
        }

        public double ApplyDiscount()
        {
            return CalculateTotalPrice() * 0.10;
        }

        public void GetDiscountDetails()
        {
            Console.WriteLine("Veg Item Discount: 10%");
        }
    }

    public class NonVegItem : FoodItem, IDiscountable
    {
        public NonVegItem(string itemName, double price, int quantity) : base(itemName, price, quantity)
        {
        }

        public override double CalculateTotalPrice()
        {
            return (Price * Quantity) + 50;
        }

        public double ApplyDiscount()
        {
            return CalculateTotalPrice() * 0.05;
        }

        public void GetDiscountDetails()
        {
            Console.WriteLine("Non-Veg Item Discount: 5%");
        }
    }
}

