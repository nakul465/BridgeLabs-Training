using System;
namespace OOPS2
{
	public class Book
	{
		public static string libraryName = "Books Hub";
		readonly long ISBN;
		string title;
		string author;
		public Book()
		{
			this.ISBN = 1234567;
			this.title = "Harry Potter";
			this.author = "J.K. Rowling";
		}
        public Book(string title,long ISBN,string author)
        {
            this.ISBN = ISBN;
            this.title = title;
            this.author = author;
        }
        public static void displayLib()
		{
			Console.WriteLine("the library name is " + libraryName);
		}
		public void displayDetails(Book b1)
		{
			if(b1 is Book)
			{
				Console.WriteLine("Author : "+author);
                Console.WriteLine("ISBN   : "+ISBN);
                Console.WriteLine("Title  : "+title);
			}
			else
			{
                Console.WriteLine("the object provided is not a book");
            }

		}
	}
}

