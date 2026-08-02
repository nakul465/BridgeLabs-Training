using System;
namespace ObjectModelling
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }

    class Order
    {
        public int OrderId { get; set; }

        // Aggregation with Product
        public List<Product> Products { get; set; }

        public Order(int orderId)
        {
            OrderId = orderId;
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void ViewOrder()
        {
            Console.WriteLine($"\nOrder ID: {OrderId}");
            Console.WriteLine("Products:");

            double total = 0;

            foreach (Product product in Products)
            {
                Console.WriteLine($"- {product.Name} : {product.Price}");
                total += product.Price;
            }

            Console.WriteLine($"Total: {total}");
        }
    }

    class Cusstomer
    {
        public string Name { get; set; }

        // Association with Order
        public List<Order> Orders { get; set; }

        public Cusstomer(string name)
        {
            Name = name;
            Orders = new List<Order>();
        }

        public void PlaceOrder(Order order)
        {
            Orders.Add(order);

            Console.WriteLine($"{Name} placed Order {order.OrderId}");
        }

        public void ViewOrders()
        {
            Console.WriteLine($"\nOrders placed by {Name}:");

            foreach (Order order in Orders)
            {
                Console.WriteLine($"- Order {order.OrderId}");
            }
        }
    }

}

