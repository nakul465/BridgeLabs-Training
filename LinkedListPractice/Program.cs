// See https://aka.ms/new-console-template for more information
using LinkedListPractice;

//Student s1 = new Student("nakul", 1 , 21, 'A');
//Student s2 = new Student("manish", 2, 22, 'B');
//Student s3 = new Student("luv", 3, 23, 'C');
//Student s4 = new Student("manan", 4, 24, 'D');
//Student s5 = new Student("mahakpreet", 5, 25, 'E');
//Student s6 = new Student("varun", 6, 26, 'F');

//Student head = s1;
//s1.next=s2;
//s2.next = s3;
//s3.next = s4;
//head = Student.AddAtEnd(head, s5);
//head = Student.AddAtStart(head, s6);

//head = Student.AddAtPos(head, s6, 5);
//Student temp = head;
//Student temp2 = Student.FindByRoll(head, 10);
//temp2.DisplayDetails();
//Student.DisplayAllStudentsDetails(head);
//while (temp != null)
//{
//    temp.DisplayDetails();
//    temp = temp.next;
//}
//Student.ChangeGrade(head, 3, 'W');
//s3.DisplayDetails();



//Movie m1 = new Movie("Harry Potter And the Philosophers Stone","J.K. Rowling",2001,5.0);
//Movie m2 = new Movie("Harry Potter And the Chamber of Secrets", "nakul", 2002, 4.9);
//Movie m3 = new Movie("Harry Potter And the Prisoner of Azkaban", "manish", 2004, 4.8);
//Movie m4 = new Movie("Harry Potter And Goblet of Fire", "manan", 2001, 5.0);
//Movie m5 = new Movie("Harry Potter And the Order of Phoenix", "J.K. Rowling", 2001, 5.0);

//m1.next = m2;
//m2.next = m3;
//m2.prev = m1;
//m3.next = m4;
//m3.prev = m2;
//m4.prev = m3;



Tasks t1 = new Tasks(1,"Eat",1,10);
Tasks t2 = new Tasks(2, "Sleep", 2, 11);
Tasks t3 = new Tasks(3, "Walk", 3, 12);
Tasks t4 = new Tasks(4, "Run", 4, 13);
Tasks t5 = new Tasks(5, "Study", 5, 14);

t1.next = t2;
t2.next = t3;
t3.next = t4;
t4.next = t1;

Tasks head = t1;
head = Tasks.AddAtStartOrEnd(head, t5);
head = Tasks.AddAtPos(head,t5, 3);
head = Tasks.RemveTaskByID(head, 5);
Tasks.DisplayAllTaskDetails(head);
Tasks temp = Tasks.SearchTasksByPriority(head, 4);
Tasks.DisplayDetails(temp);




Inventory inventory = new Inventory();
inventory.AddAtEnd(new Item("Laptop", 101, 5, 50000));
inventory.AddAtEnd(new Item("Mouse", 102, 20, 500));
inventory.AddAtStart(new Item("Keyboard", 103, 10, 1500));
inventory.AddAtPosition(new Item("Monitor", 104, 8, 12000), 2);

Console.WriteLine("Inventory:");
inventory.Display();

Console.WriteLine("\nUpdating quantity of Item 101:");
inventory.UpdateQuantity(101, 8);
inventory.Display();

Console.WriteLine("\nSearching by ID:");
Item item = inventory.SearchById(102);
if (item != null)
    Console.WriteLine($"Found: {item.itemName}, Price: {item.price}");

Console.WriteLine("\nSearching by Name:");
item = inventory.SearchByName("Laptop");
if (item != null)
    Console.WriteLine($"Found: {item.itemName}, ID: {item.itemId}");

Console.WriteLine($"\nTotal Inventory Value: {inventory.CalculateTotalValue()}");



Library library = new Library();

library.AddAtEnd(new Book("Harry Potter", "J.K. Rowling", "Fantasy", 101, true));
library.AddAtEnd(new Book("The Hobbit", "J.R.R. Tolkien", "Fantasy", 102, true));
library.AddAtStart(new Book("1984", "George Orwell", "Dystopian", 103, false));
library.AddAtPosition(new Book("Atomic Habits", "James Clear", "Self Help", 104, true), 2);

Console.WriteLine("Books in Forward Order:");
library.DisplayForward();

Console.WriteLine("\nBooks in Reverse Order:");
library.DisplayReverse();

Console.WriteLine("\nSearch by Title:");
Book book = library.SearchByTitle("The Hobbit");

if (book != null)
    Console.WriteLine($"Found: {book.title} by {book.author}");

Console.WriteLine("\nSearch by Author:");
book = library.SearchByAuthor("George Orwell");

if (book != null)
    Console.WriteLine($"Found: {book.title}");

Console.WriteLine("\nUpdating Availability:");
library.UpdateAvailability(101, false);
library.DisplayForward();

Console.WriteLine("\nRemoving Book 103:");
library.RemoveById(103);
library.DisplayForward();

Console.WriteLine($"\nTotal Books: {library.CountBooks()}");





RoundRobinScheduler scheduler = new RoundRobinScheduler();

List<Process> processes = new List<Process>();

Process p1 = new Process(1, 5, 1);
Process p2 = new Process(2, 8, 2);
Process p3 = new Process(3, 4, 1);
Process p4 = new Process(4, 6, 3);

processes.Add(p1);
processes.Add(p2);
processes.Add(p3);
processes.Add(p4);

scheduler.AddProcess(p1);
scheduler.AddProcess(p2);
scheduler.AddProcess(p3);
scheduler.AddProcess(p4);

Console.WriteLine("Initial Processes:");
scheduler.DisplayProcesses();

int quantum = 2;

Console.WriteLine($"\nTime Quantum: {quantum}");

Console.WriteLine("\nStarting Round Robin Scheduling:");

scheduler.Schedule(quantum);

Console.WriteLine("\nProcess Times:");

scheduler.DisplayAverageTimes(processes);



SocialMedia socialMedia = new SocialMedia();

socialMedia.AddUser(new User(1, "Nakul", 21));
socialMedia.AddUser(new User(2, "Manish", 22));
socialMedia.AddUser(new User(3, "Rahul", 21));
socialMedia.AddUser(new User(4, "Aman", 23));
socialMedia.AddUser(new User(5, "Karan", 22));

socialMedia.AddFriend(1, 2);
socialMedia.AddFriend(1, 3);
socialMedia.AddFriend(1, 4);
socialMedia.AddFriend(2, 3);
socialMedia.AddFriend(2, 4);
socialMedia.AddFriend(2, 5);

Console.WriteLine("Friends of Nakul:");
socialMedia.DisplayFriends(1);

Console.WriteLine("\nFriends of Manish:");
socialMedia.DisplayFriends(2);

Console.WriteLine("\nMutual Friends of Nakul and Manish:");
socialMedia.FindMutualFriends(1, 2);

Console.WriteLine("\nSearching by User ID:");
User user = socialMedia.SearchById(3);

if (user != null)
    Console.WriteLine($"Found: {user.name}");

Console.WriteLine("\nSearching by Name:");
user = socialMedia.SearchByName("Aman");

if (user != null)
    Console.WriteLine($"Found: ID {user.userId}, Name: {user.name}");

Console.WriteLine("\nFriend Counts:");
socialMedia.CountFriends();

Console.WriteLine("\nRemoving Friend Connection between Nakul and Aman:");
socialMedia.RemoveFriend(1, 4);

socialMedia.DisplayFriends(1);



TextEditor editor = new TextEditor();

editor.AddState("");
editor.AddState("Hello");
editor.AddState("Hello World");
editor.AddState("Hello World!");

Console.WriteLine("Current State:");
editor.DisplayCurrentState();

Console.WriteLine("\nUndo:");
editor.Undo();
editor.DisplayCurrentState();

Console.WriteLine("\nUndo:");
editor.Undo();
editor.DisplayCurrentState();

Console.WriteLine("\nRedo:");
editor.Redo();
editor.DisplayCurrentState();

Console.WriteLine("\nAdding new state after undo:");
editor.AddState("Hello Everyone");
editor.DisplayCurrentState();

Console.WriteLine("\nHistory:");
editor.DisplayHistory();



TicketReservation reservation = new TicketReservation();

reservation.AddTicket(
    new Ticket(101, "Nakul", "Avengers", 10, "6:00 PM")
);

reservation.AddTicket(
    new Ticket(102, "Manish", "Avatar", 15, "6:30 PM")
);

reservation.AddTicket(
    new Ticket(103, "Rahul", "Avengers", 20, "7:00 PM")
);

reservation.AddTicket(
    new Ticket(104, "Aman", "Interstellar", 25, "7:30 PM")
);

Console.WriteLine("All Tickets:");
reservation.DisplayTickets();

Console.WriteLine("\nSearch by Customer:");
Ticket ticket = reservation.SearchByCustomer("Manish");

if (ticket != null)
{
    Console.WriteLine(
        $"Found: {ticket.ticketId}, {ticket.customerName}, {ticket.movieName}"
    );
}

Console.WriteLine("\nSearch by Movie:");
ticket = reservation.SearchByMovie("Avengers");

if (ticket != null)
{
    Console.WriteLine(
        $"Found: {ticket.ticketId}, {ticket.customerName}, Seat: {ticket.seatNumber}"
    );
}

Console.WriteLine("\nRemoving Ticket 102:");
reservation.RemoveTicket(102);
reservation.DisplayTickets();

Console.WriteLine(
    $"\nTotal Booked Tickets: {reservation.TotalTickets()}"
);