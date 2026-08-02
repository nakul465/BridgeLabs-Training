using System;
namespace ObjectModelling
{
    class Productt
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public Productt(string name, double price, double quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double GetTotal()
        {
            return Price * Quantity;
        }
    }

    class Customerr
    {
        public string Name { get; set; }

        // Composition
        public List<Productt> Products { get; set; }

        public Customerr(string name)
        {
            Name = name;
            Products = new List<Productt>();
        }

        public void AddProduct(Productt product)
        {
            Products.Add(product);
        }

        public void ViewProducts()
        {
            Console.WriteLine($"Customer: {Name}");

            foreach (Productt product in Products)
            {
                Console.WriteLine(
                    $"{product.Name} - {product.Quantity} x ${product.Price}"
                );
            }
        }
    }

    class BillGeneratorr
    {
        public void GenerateBill(Customerr customer)
        {
            double total = 0;

            Console.WriteLine($"\nBill for {customer.Name}:");

            foreach (Productt product in customer.Products)
            {
                double productTotal = product.GetTotal();

                Console.WriteLine(
                    $"{product.Name}: ${productTotal}"
                );

                total += productTotal;
            }

            Console.WriteLine($"Total Bill: ${total}");
        }
    }

}

