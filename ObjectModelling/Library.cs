using System;
namespace ObjectModelling
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void DisplayBook()
        {
            Console.WriteLine($"Title : {Title}");
            Console.WriteLine($"Author: {Author}");
        }
    }

    public class Library
	{
        public string LibraryName { get; set; }

        private List<Book> books = new List<Book>();

        public Library(string libraryName)
        {
            LibraryName = libraryName;
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void DisplayBooks()
        {
            Console.WriteLine($"Library: {LibraryName}");

            foreach (Book book in books)
            {
                Console.WriteLine($"- {book.Title} by {book.Author}");
            }
        }
    }
	
}

