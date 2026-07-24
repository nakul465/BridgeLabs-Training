// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
prob1();
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
prob2(num1,num2);
double cel= Convert.ToDouble(Console.ReadLine());
prob3(cel);
int radius= Convert.ToInt32(Console.ReadLine());
prob4(radius);
int height= Convert.ToInt32(Console.ReadLine());
prob5(radius, height);
double principal = Convert.ToDouble(Console.ReadLine());
double rate = Convert.ToDouble(Console.ReadLine());
double time = Convert.ToDouble(Console.ReadLine());
prob6(principal, rate, time);
double length = Convert.ToDouble(Console.ReadLine());
double width = Convert.ToDouble(Console.ReadLine());
prob7(length, width);
double bas = Convert.ToDouble(Console.ReadLine());
double exp = Convert.ToDouble(Console.ReadLine());
prob8(bas, exp);
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
int n3 = Convert.ToInt32(Console.ReadLine());
prob9(n1, n2, n3);
int km = Convert.ToInt32(Console.ReadLine());
prob10(km);






static void prob1(){
    Console.WriteLine("Welcome to Bridgelabz!");
}
static void prob2(int num1,int num2)
{
    Console.WriteLine(num1 + num2);
}
static void prob3(double cel)
{
    Console.WriteLine((double)(cel * 9 / 5) + 32);
}
static void prob4(int radius)
{
    Console.WriteLine(3.14 * radius * radius);
}
static void prob5(int radius, int height)
{
    Console.WriteLine(3.14 * radius * radius * height);
}
static void prob6(double principal,double rate,double time)
{
    Console.WriteLine(principal * rate * time / 100);
}
static void prob7(double length,double width)
{
    Console.WriteLine(2 * (length + width));
}
static void prob8(double bas,double exp)
{
    Console.WriteLine(Math.Pow(bas,exp));
}
static void prob9(int num1,int num2,int num3)
{
    Console.WriteLine((num1 + num2 + num3) / 3);
}
static void prob10(int km)
{
    Console.WriteLine(km * 0.621371);
}

