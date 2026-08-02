// See https://aka.ms/new-console-template for more information
using ObjectModelling;
Book b1 = new Book("Harry Potter: The Prisoner of Azkaban", "J.K. Rowling");
Book b2 = new Book("Harry Potter and The Goblet of Fire", "J.K. Rowling");
Book b3 = new Book("Harry Potter and The Sorcerer's Stone", "J.K. Rowling");

Library l1 = new Library("Central Library");
Library l2 = new Library("City Library");

l1.AddBook(b1);
l1.AddBook(b2);

l2.AddBook(b2);
l2.AddBook(b3);

l1.DisplayBooks();
l2.DisplayBooks();
//now even if the library gets deleted the books still exists which shows aggregation



//Bank bank = new Bank("State Bank");

//Customer customer1 = new Customer("Nakul");
//Customer customer2 = new Customer("Rahul");

//bank.OpenAccount(customer1, 50000);
//bank.OpenAccount(customer1, 25000);
//bank.OpenAccount(customer2, 30000);

//customer1.ViewBalance();
//customer2.ViewBalance();

//Console.WriteLine("\nBank Customers:");

//foreach (Customer customer in bank.Customers)
//{
//    Console.WriteLine(customer.Name);
//}
//here bank contains customers but if a bank was closed still the customer will exist and it will have a account in other banks which shows assosiation



Company company = new Company("TechCorp");

company.AddDepartment("Development");
company.AddDepartment("HR");

company.AddEmployee("Development", "Nakul");
company.AddEmployee("Development", "Rahul");
company.AddEmployee("HR", "Aman");

company.DisplayCompany();
//when the company is deleted its departments and employees are also automatically deleted which represents a composition relationship


School school = new School("ABC School");

Student student1 = new Student("Nakul");
Student student2 = new Student("Rahul");
Student student3 = new Student("Aman");

Course java = new Course("Java");
Course csharp = new Course("C#");
Course database = new Course("Database");

school.AddStudent(student1);
school.AddStudent(student2);
school.AddStudent(student3);

student1.EnrollCourse(java);
student1.EnrollCourse(csharp);

student2.EnrollCourse(java);
student2.EnrollCourse(database);

student3.EnrollCourse(csharp);
student3.EnrollCourse(database);

school.ViewStudents();

student1.ViewCourses();
student2.ViewCourses();

java.ViewStudents();
csharp.ViewStudents();




Faculty faculty1 = new Faculty("Dr. Sharma");
Faculty faculty2 = new Faculty("Dr. Mehta");

University university = new University("ABC University");

// Composition: University has its Departments
university.AddDeppartment("Computer Science");
university.AddDeppartment("Electronics");
university.AddDeppartment("Mechanical");

// Aggregation: University receives existing Faculty objects
university.AddFaculty(faculty1);
university.AddFaculty(faculty2);

university.DisplayUniversity();



Hospital hospital = new Hospital("City Hospital");

Doctor doctor1 = new Doctor("Sharma");
Doctor doctor2 = new Doctor("Mehta");

Patient patient1 = new Patient("Nakul");
Patient patient2 = new Patient("Rahul");

hospital.AddDoctor(doctor1);
hospital.AddDoctor(doctor2);

hospital.AddPatient(patient1);
hospital.AddPatient(patient2);

doctor1.Consult(patient1);
doctor1.Consult(patient2);

doctor2.Consult(patient1);

hospital.ViewDoctors();
hospital.ViewPatients();

patient1.ViewDoctors();
patient2.ViewDoctors();


Product laptop = new Product("Laptop", 60000);
Product mouse = new Product("Mouse", 1500);
Product keyboard = new Product("Keyboard", 3000);

Cusstomer cusstomer = new Cusstomer("Nakul");

Order order1 = new Order(101);
Order order2 = new Order(102);

order1.AddProduct(laptop);
order1.AddProduct(mouse);

order2.AddProduct(keyboard);
order2.AddProduct(mouse);

cusstomer.PlaceOrder(order1);
cusstomer.PlaceOrder(order2);

cusstomer.ViewOrders();

order1.ViewOrder();
order2.ViewOrder();





//University2 university = new University2("ABC University");

//Student2 student1 = new Student2("Nakul");
//Student2 student2 = new Student2("Rahul");

//Professor2 professor1 = new Professor2("Sharma");
//Professor2 professor2 = new Professor2("Mehta");

//Course2 java = new Course2("Java");
//Course2 csharp = new Course2("C#");
//Course2 database = new Course2("Database");

//university.AddStudent(student1);
//university.AddStudent(student2);

//university.AddProfessor(professor1);
//university.AddProfessor(professor2);

//university.AddCourse(java);
//university.AddCourse(csharp);
//university.AddCourse(database);

//// Students enroll in courses
//student1.EnrollCourse(java);
//student1.EnrollCourse(csharp);

//student2.EnrollCourse(java);
//student2.EnrollCourse(database);

//// Professors are assigned to courses
//professor1.AssignProfessor(java);
//professor1.AssignProfessor(csharp);

//professor2.AssignProfessor(database);

//student1.ViewCourses();
//student2.ViewCourses();

//professor1.ViewCourses();
//professor2.ViewCourses();

//java.ViewStudents();
//java.ViewProfessor();

//csharp.ViewStudents();
//csharp.ViewProfessor();

//database.ViewStudents();
//database.ViewProfessor();





Studentt student = new Studentt("Nakul");

Subjectt maths = new Subjectt("Maths", 90);
Subjectt science = new Subjectt("Science", 85);

student.AddSubject(maths);
student.AddSubject(science);

student.ViewSubjects();

GradeCalculatorr calculator = new GradeCalculatorr();

calculator.CalculateGrade(student);




Customerr customer = new Customerr("Nakul");

Productt apples = new Productt("Apples", 3, 2);
Productt milk = new Productt("Milk", 2, 1);

customer.AddProduct(apples);
customer.AddProduct(milk);

customer.ViewProducts();

BillGeneratorr billGenerator = new BillGeneratorr();

billGenerator.GenerateBill(customer);