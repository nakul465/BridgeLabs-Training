using System;
namespace Generics
{
	public class WarehouseManagementSystem
	{
	}
	public abstract class WarehouseItem
	{
        public int ItemId { get; set; }
        public string Name { get; set; }

        public WarehouseItem(int itemId, string name)
        {
            ItemId = itemId;
            Name = name;
        }

        public abstract void DisplayDetails();
    }
	public class Electronics : WarehouseItem
    {
        public Electronics(int itemId, string name) : base(itemId,name)
        {
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Electronics: {ItemId} - {Name}");
        }
    }
    public class Groceries : WarehouseItem
    {
        public Groceries(int itemId, string name) : base(itemId, name)
        {
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Groceries: {ItemId} - {Name}");
        }
    }
    public class Furniture : WarehouseItem
    {
        public Furniture(int itemId, string name) : base(itemId, name)
        {
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Furniture: {ItemId} - {Name}");
        }
    }
	public class Storage<T> where T : WarehouseItem
	{
		List<T> items;
		public Storage()
		{
			items = new List<T>();
		}

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public void DisplayAllItems()
        {
            foreach (T item in items)
            {
                item.DisplayDetails();
            }
        }
    }
}

