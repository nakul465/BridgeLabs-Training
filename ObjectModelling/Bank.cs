using System;
namespace ObjectModelling
{
    public class Customer
    {
        public string Name { get; set; }

        public List<double> Accounts { get; set; }

        public Customer(string name)
        {
            Name = name;
            Accounts = new List<double>();
        }

        public void ViewBalance()
        {
            Console.WriteLine($"Customer: {Name}");

            for (int i = 0; i < Accounts.Count; i++)
            {
                Console.WriteLine($"Account {i + 1}: ₹{Accounts[i]}");
            }
        }
    }
    public class Bank
    {
        public string BankName { get; set; }

        public List<Customer> Customers { get; set; }

        public Bank(string bankName)
        {
            BankName = bankName;
            Customers = new List<Customer>();
        }

        public void OpenAccount(Customer customer, double initialBalance)
        {
            if (!Customers.Contains(customer))
            {
                Customers.Add(customer);
            }

            customer.Accounts.Add(initialBalance);

            Console.WriteLine(
                $"Account opened for {customer.Name} with balance ₹{initialBalance}"
            );
        }

    }
}

