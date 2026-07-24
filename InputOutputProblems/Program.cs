// See https://aka.ms/new-console-template for more information
using System.Runtime.ConstrainedExecution;

prob1();
prob2();
prob3();
prob4();
prob5();
prob6();
prob7();
prob8();
prob9();
prob10();
prob11();
prob12();
prob13();
prob14();
prob15();
prob16();


l2prob1();
l2prob2();
l2prob3();
l2prob4();
l2prob5();
l2prob6();
l2prob7();
l2prob8();
l2prob9();
l2prob10();
l2prob11();
l2prob12();


static void prob1()
{
    Console.WriteLine("Harry's age in 2024 is" + (2024 - 2000));
}
static void prob2()
{
    Console.WriteLine("Sam’s average mark in PCM is "+((94+95+96)/3.0));
}
static void prob3()
{
    Console.WriteLine("The distance 10.8Km in miles is " + (10.8 / 1.6));
}
static void prob4()
{
    Console.WriteLine("The Cost Price is INR 129 and Selling Price is INR 191\nThe Profit is INR"+(191 - 129) + "and the Profit Percentage is "+(((191-129)/129.0)*100));
}
static void prob5()
{
    Console.WriteLine("The Pen Per Student is "+14/3+ "and the remaining pen not distributed is "+14%3);
}
static void prob6()
{
    int fee = 125000;
    int disPe = 10;
    double discount = 125000 * (disPe / 100.0);
    Console.WriteLine("The discount amount is INR " + discount + "and final discounted fee is INR "+(fee-discount));
}
static void prob7()
{
    double vol =(4.0*3.14*6378*6378*6378/3.0);
    Console.WriteLine("The volume of earth in cubic kilometers is "+vol+ " and cubic miles is "+vol/(1.6*1.6*1.6));
}
static void prob8()
{
    int km = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("The total miles is "+(km/1.6)+ " mile for the given "+km+" km");
}
static void prob9()
{
    int fee = Convert.ToInt32(Console.ReadLine());
    int disPe = Convert.ToInt32(Console.ReadLine());
    double discount = fee * (disPe / 100.0);
    Console.WriteLine("The discount amount is INR " + discount + "and final discounted fee is INR " + (fee - discount));
}
static void prob10()
{
    double height = Convert.ToDouble(Console.ReadLine());
    double heightin = height / 2.54;
    Console.WriteLine(" Your Height in cm is " + height + " while in feet is " + heightin / 12.0 + " and inches is " + heightin);
}
static void prob11()
{
    float num1 = Convert.ToSingle(Console.ReadLine());
    float num2 = Convert.ToSingle(Console.ReadLine());
    Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers "+num1+" and "+num2+" is "+(num1+num2)+","+ (num1 - num2)+","+ (num1 * num2)+" and "+ (num1 / num2));
}
static void prob12()
{
    double bas = Convert.ToDouble(Console.ReadLine());
    double height = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("The area of the triangle is "+((bas*height)/2));
}
static void prob13()
{
    float perimeter = Convert.ToSingle(Console.ReadLine());
    Console.WriteLine("The length of the side is" + (perimeter / 4.0) + " whose perimeter is "+perimeter);
}
static void prob14()
{
    float dist = Convert.ToSingle(Console.ReadLine());
    Console.WriteLine("The Distance " + dist + "feet in yards is " + (dist / 3.0) + " while in miles is " + ((dist / 3.0)/1760.0));
}
static void prob15()
{
    float unitPrice = Convert.ToSingle(Console.ReadLine());
    int qty = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("The total purchase price is INR "+(unitPrice*qty)+ " if the quantity "+qty+" and the unit price is "+unitPrice);

}
static void prob16()
{
    int noOfStudents = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("The total no of possible hand shakes are "+((noOfStudents*(noOfStudents-1))/2));
}

//second pdf starts

static void l2prob1()
{
    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("The Quotient is " + (num1/num2) + " and Remainder is "+num1%num2+" of the two numebers "+num1+" and "+num2);
}
static void l2prob2()
{
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    int c = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("The results of Int Operations are "+(a + b * c)+","+(a * b + c) + "," + (c + a / b) + " and " + (a % b + c));
}
static void l2prob3()
{
    double a = Convert.ToDouble(Console.ReadLine());
    double b = Convert.ToDouble(Console.ReadLine());
    double c = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("The results of Double Operations are " + (a + b * c) + "," + (a * b + c) + "," + (c + a / b) + " and " + (a % b + c));
}
static void l2prob4()
{
    double cel = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("The " + cel + " Celcius is " + ((cel * 9 / 5) + 32) + "Farenheit");
}
static void l2prob5()
{
    double faren = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("The " + faren + " farenheit is " + ((faren-32)*5/9) + " Celcius");
}
static void l2prob6()
{
    double salary = Convert.ToDouble(Console.ReadLine());
    double bonus = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("The salary is INR " + salary + " and bonus is INR " + bonus + ". Hence Total Income is INR " + (salary + bonus));
}
static void l2prob7()
{
    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());
    int temp = num1;
    num1 = num2;
    num2 = temp;
    Console.WriteLine("The swapped numbers are "+num1+" and "+num2);
}
static void l2prob8()
{
    string name = Console.ReadLine();
    string fromCity = Console.ReadLine(), viaCity = Console.ReadLine(), toCity = Console.ReadLine() ;

    double distanceFromToVia = Convert.ToInt32(Console.ReadLine());
    int timeFromToVia = Convert.ToInt32(Console.ReadLine()); ; 
    double distanceViaToFinalCity = Convert.ToInt32(Console.ReadLine()); ;
    int timeViaToFinalCity = Convert.ToInt32(Console.ReadLine()); ; 


    double totalDistance = distanceFromToVia + distanceViaToFinalCity;
    int totalTime = timeFromToVia + timeViaToFinalCity;

    Console.WriteLine($"The Total Distance travelled by {name} from {fromCity} to {toCity} via {viaCity} is {totalDistance} km and the Total Time taken is {totalTime} minutes");


}
static void l2prob9()
{
    int side1 = Convert.ToInt32(Console.ReadLine());
    int side2 = Convert.ToInt32(Console.ReadLine());
    int side3 = Convert.ToInt32(Console.ReadLine());
    int per = side1 + side2 + side3;
    Console.WriteLine("The total number of rounds the athlete will run is"+(5/per)+ " to complete 5 km");
}
static void l2prob10()
{
    int noOfChocolates = Convert.ToInt32(Console.ReadLine());
    int noOfChildren = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("The number of chocolates each child gets is "+(noOfChocolates/noOfChildren)+ " and the number of remaining chocolates is "+(noOfChocolates%noOfChildren));
}
static void l2prob11()
{
    double principal = Convert.ToDouble(Console.ReadLine());
    double rate = Convert.ToDouble(Console.ReadLine());
    double time = Convert.ToDouble(Console.ReadLine());
    double si = principal * rate * time/100;
    Console.WriteLine("The Simple Interest is "+si+ " for Principal "+principal+ ", Rate of Interest "+rate+ "and Time "+time);
}
static void l2prob12()
{
    double weight = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("The weight of the person in pounds is "+weight+ " and in kg is "+weight*2.2);
}