using System;
namespace EncapsulatioAndPolymorphism
{
    public interface IReservable
    {
        void ReserveItem();
        bool CheckAvailability();
    }

    public abstract class LibraryItem
    {
        private int itemId;
        private string title;
        private string author;

        public int ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public LibraryItem(int itemId, string title, string author)
        {
            this.itemId = itemId;
            this.title = title;
            this.author = author;
        }

        public abstract int GetLoanDuration();

        public void GetItemDetails()
        {
            Console.WriteLine($"Item ID: {itemId}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Loan Duration: {GetLoanDuration()} days");
        }
    }

    public class Book : LibraryItem, IReservable
    {
        private string borrowerName;
        private bool isAvailable;

        public Book(int itemId, string title, string author, string borrowerName) : base(itemId, title, author)
        {
            this.borrowerName = borrowerName;
            isAvailable = true;
        }

        public override int GetLoanDuration()
        {
            return 21;
        }

        public void ReserveItem()
        {
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine("Book reserved successfully.");
            }
            else
            {
                Console.WriteLine("Book is already reserved.");
            }
        }

        public bool CheckAvailability()
        {
            return isAvailable;
        }
    }

    public class Magazine : LibraryItem, IReservable
    {
        private string borrowerName;
        private bool isAvailable;

        public Magazine(int itemId, string title, string author, string borrowerName) : base(itemId, title, author)
        {
            this.borrowerName = borrowerName;
            isAvailable = true;
        }

        public override int GetLoanDuration()
        {
            return 7;
        }

        public void ReserveItem()
        {
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine("Magazine reserved successfully.");
            }
            else
            {
                Console.WriteLine("Magazine is already reserved.");
            }
        }

        public bool CheckAvailability()
        {
            return isAvailable;
        }
    }

    public class DVD : LibraryItem, IReservable
    {
        private string borrowerName;
        private bool isAvailable;

        public DVD(int itemId, string title, string author, string borrowerName) : base(itemId, title, author)
        {
            this.borrowerName = borrowerName;
            isAvailable = true;
        }

        public override int GetLoanDuration()
        {
            return 3;
        }

        public void ReserveItem()
        {
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine("DVD reserved successfully.");
            }
            else
            {
                Console.WriteLine("DVD is already reserved.");
            }
        }

        public bool CheckAvailability()
        {
            return isAvailable;
        }
    }
}

