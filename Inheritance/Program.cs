// See https://aka.ms/new-console-template for more information
using Inheritance;

Dog dog = new Dog("Tommy", 3);
Cat cat = new Cat("Kitty", 2);
Bird bird = new Bird("Tweety", 1);

dog.MakeSound();
cat.MakeSound();
bird.MakeSound();



Employee manager = new Manager("Rahul", 101, 85000, 10);
Employee developer = new Developer("Aman", 102, 70000, "C#");
Employee intern = new Intern("Rohan", 103, 20000, "6 Months");

manager.DisplayDetails();
developer.DisplayDetails();
intern.DisplayDetails();



Vehicle[] vehicles =
    {
        new Car(220, "Petrol", 5),
        new Truck(120, "Diesel", 10000),
        new Motorcycle(180, "Petrol", true)
    };

foreach (Vehicle vehicle in vehicles)
{
    vehicle.DisplayInfo();
}



Book book = new Author(
        "J.K. Rowling",
        "British author best known for the Harry Potter series.",
        "Harry Potter and the Philosopher's Stone",
        1997
    );

book.DisplayInfo();



Device thermostat = new Thermostat(101, "ON", "24°C");

thermostat.DisplayStatus();



Order[] orders =
    {
        new Order(101, "01-08-2026"),
        new ShippedOrder(102, "02-08-2026", 12345),
        new DeliveredOrder(103, "03-08-2026", 67890, "04-08-2026")
    };

foreach (Order order in orders)
{
    order.GetOrderStatus();
}



Course course = new Course("C# Basics", 30);

OnlineCourse onlineCourse =
    new OnlineCourse("C# Advanced", 40, "Udemy", true);

PaidOnlineCourse paidCourse =
    new PaidOnlineCourse("C# Masterclass", 50, "Coursera", true, 5000, 1000);

course.DisplayDetails();
onlineCourse.DisplayDetails();
paidCourse.DisplayDetails();



BankAccount[] accounts =
    {
        new SavingsAccount(101, 50000, 6.5),
        new CheckingAccount(102, 30000, 0, 10000),
        new FixedDepositAccount(103, 100000, 0, 0, 2)
    };

foreach (BankAccount account in accounts)
{
    account.DisplayAccountType();
}



Person[] people =
    {
        new Teacher("Rahul", 35, "Mathematics"),
        new Student("Aman", 18, "A"),
        new Staff("Ramesh", 45, "Administration")
    };

foreach (Person person in people)
{
    person.DisplayRole();
}



IWorker[] workers =
    {
        new Chef("Rahul", 101),
        new Waiter("Aman", 102)
    };

foreach (IWorker worker in workers)
{
    worker.PerformDuties();
}



Vehiclee[] vehicless =
    {
        new ElectricVehicle(200, "Tesla Model 3"),
        new PetrolVehicle(180, "Toyota Camry")
    };

((ElectricVehicle)vehicless[0]).charge();
((Refuelable)vehicless[1]).Refuel();