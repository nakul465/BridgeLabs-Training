using System;
namespace LinkedListPractice
{
    public class Book
    {
        public string title;
        public string author;
        public string genre;
        public int bookId;
        public bool isAvailable;
        public Book next;
        public Book prev;

        public Book(string title, string author, string genre, int bookId, bool isAvailable)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.bookId = bookId;
            this.isAvailable = isAvailable;
            this.next = null;
            this.prev = null;
        }
    }

    public class Library
    {
        private Book head;
        private Book tail;

        public void AddAtStart(Book newBook)
        {
            if (head == null)
            {
                head = newBook;
                tail = newBook;
                return;
            }

            newBook.next = head;
            head.prev = newBook;
            head = newBook;
        }

        public void AddAtEnd(Book newBook)
        {
            if (head == null)
            {
                head = newBook;
                tail = newBook;
                return;
            }

            newBook.prev = tail;
            tail.next = newBook;
            tail = newBook;
        }

        public void AddAtPosition(Book newBook, int position)
        {
            if (position == 1)
            {
                AddAtStart(newBook);
                return;
            }

            if (head == null)
            {
                Console.WriteLine("Invalid position");
                return;
            }

            Book temp = head;
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

            if (temp.next == null)
            {
                AddAtEnd(newBook);
                return;
            }

            Book nextBook = temp.next;

            newBook.prev = temp;
            newBook.next = nextBook;
            temp.next = newBook;
            nextBook.prev = newBook;
        }

        public void RemoveById(int bookId)
        {
            if (head == null)
            {
                Console.WriteLine("Library is empty");
                return;
            }

            Book temp = head;

            while (temp != null && temp.bookId != bookId)
            {
                temp = temp.next;
            }

            if (temp == null)
            {
                Console.WriteLine("Book not found");
                return;
            }

            if (temp == head)
            {
                head = head.next;

                if (head != null)
                    head.prev = null;
                else
                    tail = null;

                temp.next = null;
                return;
            }

            if (temp == tail)
            {
                tail = tail.prev;
                tail.next = null;
                temp.prev = null;
                return;
            }

            temp.prev.next = temp.next;
            temp.next.prev = temp.prev;

            temp.prev = null;
            temp.next = null;
        }

        public Book SearchByTitle(string title)
        {
            Book temp = head;

            while (temp != null)
            {
                if (temp.title == title)
                    return temp;

                temp = temp.next;
            }

            return null;
        }

        public Book SearchByAuthor(string author)
        {
            Book temp = head;

            while (temp != null)
            {
                if (temp.author == author)
                    return temp;

                temp = temp.next;
            }

            return null;
        }

        public void UpdateAvailability(int bookId, bool status)
        {
            Book temp = head;

            while (temp != null)
            {
                if (temp.bookId == bookId)
                {
                    temp.isAvailable = status;
                    return;
                }

                temp = temp.next;
            }

            Console.WriteLine("Book not found");
        }

        public void DisplayForward()
        {
            Book temp = head;

            while (temp != null)
            {
                Console.WriteLine($"ID: {temp.bookId}, Title: {temp.title}, Author: {temp.author}, Genre: {temp.genre}, Available: {temp.isAvailable}");
                temp = temp.next;
            }
        }

        public void DisplayReverse()
        {
            Book temp = tail;

            while (temp != null)
            {
                Console.WriteLine($"ID: {temp.bookId}, Title: {temp.title}, Author: {temp.author}, Genre: {temp.genre}, Available: {temp.isAvailable}");
                temp = temp.prev;
            }
        }

        public int CountBooks()
        {
            int count = 0;
            Book temp = head;

            while (temp != null)
            {
                count++;
                temp = temp.next;
            }

            return count;
        }
    }
}

