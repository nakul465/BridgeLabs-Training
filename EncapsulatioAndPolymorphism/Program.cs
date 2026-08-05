// See https://aka.ms/new-console-template for more information
using EncapsulatioAndPolymorphism;


FullTimeEmployee emp1 =new FullTimeEmployee(50000, "Nakul", 101, 160, 200);
PartTimeEmployee emp2 = new PartTimeEmployee(0, "Rahul", 102, 80, 150);

emp1.AssignDepartment("IT");
emp2.AssignDepartment("HR");

Employee[] employees = { emp1, emp2 };

foreach (Employee employee in employees)
{
    employee.DisplayDetails();
    employee.CalculateSalary();
    Console.WriteLine();
}

Console.WriteLine("Department Details:");

emp1.GetDepartmentDetails();
emp2.GetDepartmentDetails();
////////////////////////////////////////////////////////////////////////////


Electronics electronics =new Electronics(101, "Laptop", 50000);
Clothing clothing = new Clothing(102, "Jacket", 5000);

Groceries groceries = new Groceries(103, "Rice", 2000);

List<Product> products = new List<Product>();

products.Add(electronics);
products.Add(clothing);
products.Add(groceries);


foreach (Product product in products)
{
    product.DisplayDetails();
    double discount = product.CalculateDiscount();
    double tax = 0;

    if (product is ITaxable taxableProduct)
    {
        tax = taxableProduct.CalculateTax();
        taxableProduct.GetTaxDetails();
    }

    double finalPrice = product.Price + tax - discount;

    Console.WriteLine($"Discount: {discount}");
    Console.WriteLine($"Tax: {tax}");
    Console.WriteLine($"Final Price: {finalPrice}");
}
////////////////////////////////////////////////////////////////////////////


Car car = new Car("PB01AB1234", "Car", 2000, "CAR123456");
Bike bike = new Bike("PB01CD5678", "Bike", 800, "BIKE789012");
Truck truck = new Truck("PB01EF9012", "Truck", 5000, "TRUCK345678");


List<Vehicle> vehicles = new List<Vehicle>();
vehicles.Add(car);
vehicles.Add(bike);
vehicles.Add(truck);

int days = 5;

foreach (Vehicle vehicle in vehicles)
{
    vehicle.DisplayDetails();

    double rentalCost = vehicle.CalculateRentalCost(days);
    Console.WriteLine($"Rental Cost for {days} days: {rentalCost}");

    if (vehicle is IInsurable insurableVehicle)
    {
        double insuranceCost = insurableVehicle.CalculateInsurance();
        Console.WriteLine($"Insurance Cost: {insuranceCost}");
        insurableVehicle.GetInsuranceDetails();
    }

    Console.WriteLine();
}
///////////////////////////////////////////////////////////////////////////////


Book book = new Book(101, "The Alchemist", "Paulo Coelho", "Nakul");
Magazine magazine = new Magazine(102, "Forbes", "Various", "Rahul");
DVD dvd = new DVD(103, "Inception", "Christopher Nolan", "Aman");

List<LibraryItem> items = new List<LibraryItem>();
items.Add(book);
items.Add(magazine);
items.Add(dvd);

foreach (LibraryItem item in items)
{
    item.GetItemDetails();

    if (item is IReservable reservable)
    {
        Console.WriteLine($"Available: {reservable.CheckAvailability()}");
        reservable.ReserveItem();
        Console.WriteLine($"Available after reservation: {reservable.CheckAvailability()}");
    }

    Console.WriteLine();
}
///////////////////////////////////////////////////////////////////////////////


VegItem vegItem = new VegItem("Paneer Tikka", 200, 2);
NonVegItem nonVegItem = new NonVegItem("Chicken Biryani", 300, 2);

List<FoodItem> foodItems = new List<FoodItem>();
foodItems.Add(vegItem);
foodItems.Add(nonVegItem);

foreach (FoodItem item in foodItems)
{
    item.GetItemDetails();

    if (item is IDiscountable discountable)
    {
        Console.WriteLine($"Discount: {discountable.ApplyDiscount()}");
        discountable.GetDiscountDetails();
    }

    Console.WriteLine();
}
//////////////////////////////////////////////////////////////////////////////////


InPatient inPatient = new InPatient(101, "Nakul", 21, 5, 3000, "Fever", "No previous history");
OutPatient outPatient = new OutPatient(102, "Rahul", 25, 1000, "Cold", "Allergy history");

inPatient.AddRecord("Temperature checked");
inPatient.AddRecord("Blood test completed");

outPatient.AddRecord("Consultation completed");
outPatient.AddRecord("Medicine prescribed");

List<Patient> patients = new List<Patient>();
patients.Add(inPatient);
patients.Add(outPatient);

foreach (Patient patient in patients)
{
    patient.GetPatientDetails();
    Console.WriteLine($"Calculated Bill: {patient.CalculateBill()}");

    if (patient is IMedicalRecord medicalRecord)
    {
        medicalRecord.ViewRecords();
    }

    Console.WriteLine();
}
//////////////////////////////////////////////////////////////////////////////////




RideCar car1 = new RideCar(101, "Nakul", 20, "Rajpura");
RideBike bike1 = new RideBike(102, "Rahul", 10, "Patiala");
RideAuto auto = new RideAuto(103, "Aman", 15, "Chandigarh");

car1.UpdateLocation("Chandigarh");
bike1.UpdateLocation("Rajpura");
auto.UpdateLocation("Patiala");

List<RideVehicle> vehicless = new List<RideVehicle>();
vehicless.Add(car1);
vehicless.Add(bike1);
vehicless.Add(auto);

double distance = 10;

foreach (RideVehicle vehicle in vehicless)
{
    vehicle.GetVehicleDetails();
    Console.WriteLine($"Distance: {distance} km");
    Console.WriteLine($"Fare: {vehicle.CalculateFare(distance)}");

    if (vehicle is IRideGPS gps)
    {
        gps.GetCurrentLocation();
    }

    Console.WriteLine();
}