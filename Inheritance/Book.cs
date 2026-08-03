using System;
namespace Inheritance
{
	public class Book
	{
		public string Title;
		public int PublicationYear;
        public Book(string Title, int PublicationYear)
		{
			this.Title = Title;
			this.PublicationYear = PublicationYear;
		}
		public virtual void DisplayInfo()
		{
			Console.WriteLine($"\nTitle : {Title}\nPublicationYear : {PublicationYear}");
		}

    }
	class Author:Book
	{
		public string name;
		public string bio;
		public Author(string name,string bio, string Title, int PublicationYear):base(Title,PublicationYear)
		{
			this.name = name;
			this.bio = bio;
		}
        public override void DisplayInfo()
        {
            Console.WriteLine($"\nTitle : {Title}\nPublicationYear : {PublicationYear}\nAuthor : {name}\nBio : {bio}");
        }
    }
}

