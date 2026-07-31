using System;
namespace OOPS
{
	public class Library
	{
		public long ISBN;
		protected string title;
		private string author;
		public Library(long isbn, string title,string author)
		{
			this.ISBN = isbn;
			this.title = title;
			this.author = author;
		}
        public Library()
        {
            this.ISBN = 12345678;
            this.title = "Harry Potter";
			this.author = "J.K. Rowling";
        }
		public string Auth
		{
			get
			{
				return author;
			}
			set
			{
				author = value;
			}
		}
    }
	public class EBook:Library
	{
        public EBook(long ISBN, string title, string author)
    : base(ISBN, title, author)
        {
        }
        public void DisplayDetails()
        {
            Console.WriteLine("ISBN   : " + ISBN);  
            Console.WriteLine("Title  : " + title); 
            Console.WriteLine("Author : " + Auth); 
        }
    }
}

