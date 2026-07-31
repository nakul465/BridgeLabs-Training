using System;
namespace OOPS
{
	public class Book
	{
		public string title;
        public string author;
		public int price;
		public bool availability;
		public Book()
		{
            this.title = "Harry Potter";
            this.author = "J.K. Rowling";
            this.price = 599;
            this.availability = true;
        }
        public Book(string title,string author,int price)
		{
			this.title = title;
			this.author = author;
			this.price = price;
			this.availability = true;
		}
		public bool BorrowBook()
		{
			if (availability)
			{
				availability = false;
				Console.WriteLine("Book boorwed");
				return true;
			}
			else
			{
                Console.WriteLine("Book not available");
				return false;
            }
		}
	}
}

