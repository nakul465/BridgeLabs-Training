using System;
using System.Diagnostics;
using System.Xml.Linq;

namespace LinkedListPractice
{
	public class Movie
	{
		public string title;
		public string director;
		public int releaseYear;
		public double rating;
        public Movie next;
        public Movie prev;

		public Movie(string title,string director,int releaseYear,double rating)
		{
			this.title = title;
			this.director = director;
			this.releaseYear = releaseYear;
			this.rating = rating;
		}

        public static Movie AddAtStart(Movie head, Movie newMovie)
        {
            newMovie.next = head;
			head.prev = newMovie;
            return newMovie;
        }

        public static Movie AddAtEnd(Movie head, Movie newMovie)
        {
            Movie temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newMovie;
            newMovie.prev = temp.next;
            return head;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"title : {title}\ndirector : {director}\nroll : {releaseYear}\nreleaseYear : {releaseYear}\nrating : {rating}\n");
        }

        public static Movie AddAtPos(Movie head, Movie newMovie, int pos)
        {
            if (pos == 1) return AddAtStart(head, newMovie);
            int i = 1;
            Movie temp = head;
            while (temp.next != null && i < pos - 1)
            {
                temp = temp.next;
                i++;
            }
            if (temp.next == null)
            {
                temp.next = newMovie;
                newMovie.prev = temp.next;
            }
            else
            {
                Movie temp2 = temp.next;
                temp.next = newMovie;
                newMovie.prev = temp;
                newMovie.next = temp2;
                temp2.prev = newMovie;
            }
            return head;
        }

        public static Movie RemoveByTitle(Movie head,string title)
        {
            if (head.title == title)
            {
                Movie newHead = head.next;
                if (newHead != null)
                    newHead.prev = null;
                head.next = null;
                return newHead;
            }
            Movie temp = head;

            while (temp != null && temp.title != title)
            {
                temp = temp.next;
            }

            if(temp==null)
            {
                Console.WriteLine("Movie not found");
                return head;
            }
            else if (temp!=null && temp.title==title && temp.next==null)
            {
                Movie temp2 = temp.prev;
                temp.prev = null;
                temp2.next = null;
                return head;
            }
            else if(temp!=null && temp.title==title && temp.next != null)
            {
                Movie temp2 = temp.prev;
                temp2.next = temp.next;
                temp.next.prev = temp2;
                return head;
            }

            return head;
        }

        public static Movie FindByDirector(Movie head, string director)
        {
            Movie temp = head;
            while(temp!=null && temp.director!=director)
            {
                temp = temp.next;
            }
            if (temp == null)
            {
                Console.WriteLine("Movie not found");
                return head;
            }
            return temp;
        }

        public static Movie FindByRating(Movie head, int rating)
        {
            Movie temp = head;
            while (temp != null && temp.rating != rating)
            {
                temp = temp.next;
            }
            if (temp == null)
            {
                Console.WriteLine("Movie not found");
                return head;
            }
            return temp;
        }

        public static void DisplayAllMoviesForward(Movie head)
        {
            Movie temp = head;
            while (temp != null)
            {
                temp.DisplayDetails();
                temp = temp.next;
            }
        }

        public static void DisplayAllMoviesReverse(Movie head)
        {
            Movie temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            while (temp != null)
            {
                temp.DisplayDetails();
                temp = temp.prev;
            }
        }

        public static void UpdateRating(Movie head,string title,int rating)
        {
            Movie temp = head;
            while (temp != null && temp.title != title)
            {
                temp = temp.next;
            }
            if (temp == null)
            {
                Console.WriteLine("Movie not found");
            }
            temp.rating = rating;
        }
    }
}

