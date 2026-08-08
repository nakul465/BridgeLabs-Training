// See https://aka.ms/new-console-template for more information
using Generics;


Storage<WarehouseItem> st = new Storage<WarehouseItem>();
st.AddItem(new Groceries(1, "Milk"));
st.AddItem(new Groceries(2, "Bread"));
st.AddItem(new Electronics(3, "Laptop"));
st.AddItem(new Electronics(4, "Mobile"));
st.AddItem(new Furniture(5, "Chair"));
st.AddItem(new Furniture(6, "Sofa"));

st.DisplayAllItems();



Product<BookCategory> book = new Product<BookCategory>("C# Programming", 1000, new BookCategory("Programming"));

Product<ClothingCategory> clothing = new Product<ClothingCategory>("T-Shirt", 500, new ClothingCategory("Casual"));

Marketplace marketplace = new Marketplace();

marketplace.ApplyDiscount(book, 10);
marketplace.ApplyDiscount(clothing, 20);

Console.WriteLine($"Book Price: {book.Price}");
Console.WriteLine($"Clothing Price: {clothing.Price}");



Course<ExamCourse> examCourse = new Course<ExamCourse>(101, "Data Structures", new ExamCourse());

Course<AssignmentCourse> assignmentCourse = new Course<AssignmentCourse>(102, "Software Engineering", new AssignmentCourse());

examCourse.DisplayCourse();
assignmentCourse.DisplayCourse();

List<Course<ExamCourse>> examCourses = new List<Course<ExamCourse>>();
examCourses.Add(examCourse);

List<Course<AssignmentCourse>> assignmentCourses = new List<Course<AssignmentCourse>>();
assignmentCourses.Add(assignmentCourse);



Meal<VegetarianMeal> vegetarian = new Meal<VegetarianMeal>(new VegetarianMeal());

Meal<VeganMeal> vegan = new Meal<VeganMeal>(new VeganMeal());

MealGenerator generator = new MealGenerator();

generator.ValidateAndGenerate(new VegetarianMeal());
generator.ValidateAndGenerate(new VeganMeal());
generator.ValidateAndGenerate(new KetoMeal());
generator.ValidateAndGenerate(new HighProteinMeal());



Resume<SoftwareEngineer> resume1 = new Resume<SoftwareEngineer>("Nakul",new SoftwareEngineer(),2);

Resume<DataScientist> resume2 = new Resume<DataScientist>("Rahul",new DataScientist(),3);

resume1.DisplayResume();
Console.WriteLine();

resume2.DisplayResume();
Console.WriteLine();

List<Resume<SoftwareEngineer>> softwareResumes = new List<Resume<SoftwareEngineer>>();
softwareResumes.Add(resume1);

List<Resume<DataScientist>> dataScienceResumes = new List<Resume<DataScientist>>();
dataScienceResumes.Add(resume2);

foreach (Resume<SoftwareEngineer> resume in softwareResumes)
{
    resume.DisplayResume();
}

foreach (Resume<DataScientist> resume in dataScienceResumes)
{
    resume.DisplayResume();
}