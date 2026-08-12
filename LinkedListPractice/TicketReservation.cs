using System;
namespace LinkedListPractice
{
    using System;

    public class Ticket
    {
        public int ticketId;
        public string customerName;
        public string movieName;
        public int seatNumber;
        public string bookingTime;
        public Ticket next;

        public Ticket(int ticketId, string customerName, string movieName, int seatNumber, string bookingTime)
        {
            this.ticketId = ticketId;
            this.customerName = customerName;
            this.movieName = movieName;
            this.seatNumber = seatNumber;
            this.bookingTime = bookingTime;
            this.next = null;
        }
    }

    public class TicketReservation
    {
        private Ticket tail;
        private int count;

        public void AddTicket(Ticket newTicket)
        {
            if (tail == null)
            {
                tail = newTicket;
                newTicket.next = newTicket;
            }
            else
            {
                newTicket.next = tail.next;
                tail.next = newTicket;
                tail = newTicket;
            }

            count++;
        }

        public void RemoveTicket(int ticketId)
        {
            if (tail == null)
            {
                Console.WriteLine("No tickets booked");
                return;
            }

            Ticket current = tail.next;
            Ticket previous = tail;

            do
            {
                if (current.ticketId == ticketId)
                {
                    if (current == tail && current == tail.next)
                    {
                        tail = null;
                    }
                    else
                    {
                        previous.next = current.next;

                        if (current == tail)
                            tail = previous;
                    }

                    current.next = null;
                    count--;
                    return;
                }

                previous = current;
                current = current.next;

            } while (current != tail.next);

            Console.WriteLine("Ticket not found");
        }

        public void DisplayTickets()
        {
            if (tail == null)
            {
                Console.WriteLine("No tickets booked");
                return;
            }

            Ticket current = tail.next;

            do
            {
                Console.WriteLine(
                    $"Ticket ID: {current.ticketId}, " +
                    $"Customer: {current.customerName}, " +
                    $"Movie: {current.movieName}, " +
                    $"Seat: {current.seatNumber}, " +
                    $"Booking Time: {current.bookingTime}"
                );

                current = current.next;

            } while (current != tail.next);
        }

        public Ticket SearchByCustomer(string customerName)
        {
            if (tail == null)
                return null;

            Ticket current = tail.next;

            do
            {
                if (current.customerName == customerName)
                    return current;

                current = current.next;

            } while (current != tail.next);

            return null;
        }

        public Ticket SearchByMovie(string movieName)
        {
            if (tail == null)
                return null;

            Ticket current = tail.next;

            do
            {
                if (current.movieName == movieName)
                    return current;

                current = current.next;

            } while (current != tail.next);

            return null;
        }

        public int TotalTickets()
        {
            return count;
        }
    }
}

