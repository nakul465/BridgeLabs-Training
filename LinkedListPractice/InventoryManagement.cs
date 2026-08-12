using System;
namespace LinkedListPractice
{
    public class Item
    {
        public string itemName;
        public int itemId;
        public int quantity;
        public double price;
        public Item next;
        public Item(string itemName, int itemId, int quantity, double price)
        {
            this.itemName = itemName;
            this.itemId = itemId;
            this.quantity = quantity;
            this.price = price;
            this.next = null;
        }
    }
    public class Inventory
    {
        private Item head;
        public void AddAtStart(Item newItem)
        {
            newItem.next = head;
            head = newItem;
        }
        public void AddAtEnd(Item newItem)
        {
            if (head == null)
            {
                head = newItem;
                return;
            }
            Item temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newItem;
        }
        public void AddAtPosition(Item newItem, int position)
        {
            if (position == 1)
            {
                AddAtStart(newItem);
                return;
            }
            if (head == null)
            {
                Console.WriteLine("Invalid position");
                return;
            }
            Item temp = head;
            int i = 1;
            while (temp.next != null && i < position - 1)
            {
                temp = temp.next;
                i++;
            }
            if (i != position - 1)
            {
                Console.WriteLine("Invalid position");
                return;
            }
            newItem.next = temp.next;
            temp.next = newItem;
        }
        public void RemoveById(int itemId)
        {
            if (head == null)
            {
                Console.WriteLine("Inventory is empty");
                return;
            }
            if (head.itemId == itemId)
            {
                head = head.next;
                return;
            }
            Item temp = head;
            while (temp.next != null && temp.next.itemId != itemId)
            {
                temp = temp.next;
            }
            if (temp.next == null)
            {
                Console.WriteLine("Item not found");
                return;
            }
            temp.next = temp.next.next;
        }
        public void UpdateQuantity(int itemId, int newQuantity)
        {
            Item temp = head;
            while (temp != null)
            {
                if (temp.itemId == itemId)
                {
                    temp.quantity = newQuantity;
                    return;
                }
                temp = temp.next;
            }
            Console.WriteLine("Item not found");
        }
        public Item SearchById(int itemId)
        {
            Item temp = head;
            while (temp != null)
            {
                if (temp.itemId == itemId)
                    return temp;
                temp = temp.next;
            }
            return null;
        }
        public Item SearchByName(string itemName)
        {
            Item temp = head;
            while (temp != null)
            {
                if (temp.itemName == itemName)
                    return temp;
                temp = temp.next;
            }
            return null;
        }
        public double CalculateTotalValue()
        {
            double total = 0;
            Item temp = head;
            while (temp != null)
            {
                total += temp.price * temp.quantity;
                temp = temp.next;
            }
            return total;
        }
        public void Display()
        {
            Item temp = head;
            while (temp != null)
            {
                Console.WriteLine($"ID: {temp.itemId}, Name: {temp.itemName}, Quantity: {temp.quantity}, Price: {temp.price}");
                temp = temp.next;
            }
        }
    }
}

