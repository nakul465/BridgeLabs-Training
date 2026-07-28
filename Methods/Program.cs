// See https://aka.ms/new-console-template for more information
using System;
using Methods;

//l3prob1.l3pob1();

static void l1prob1()
{
    double principal = Convert.ToDouble(Console.ReadLine());
    double rate = Convert.ToDouble(Console.ReadLine());
    double time = Convert.ToDouble(Console.ReadLine());
    double si = principal * rate * time / 100.0;
    Console.WriteLine($" The Simple Interest is {si} for Principal {principal}, Rate of Interest {rate} and Time {time}");
}

static void l1prob2(){
    int noOfStudents = Convert.ToInt32(Console.ReadLine());
    int noOfHandshakes = (noOfStudents*(noOfStudents-1))/2;
    Console.WriteLine("max no of Handshkes: " + noOfHandshakes);
}

static void l1prob3()
{
    int noOfStudents = Convert.ToInt32(Console.ReadLine());
    int noOfHandshakes = (noOfStudents * (noOfStudents - 1)) / 2;
    Console.WriteLine("max no of Handshkes: " + noOfHandshakes);
}

static void l1prob4()
{
    int side1 = Convert.ToInt32(Console.ReadLine());
    int side2 = Convert.ToInt32(Console.ReadLine());
    int side3 = Convert.ToInt32(Console.ReadLine());
    int perimeter = side1 + side2 + side3;
    Console.WriteLine("No of rounds to complete 5km are "+(5/perimeter));
}

static int l1prob5()
{
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0)
    {
        return 1;
    }
    else if (num < 0)
    {
        return -1;
    }
    else
    {
        return 0;
    }
}

static void l1prob6()
{
    int day = Convert.ToInt32(Console.ReadLine());
    int month = Convert.ToInt32(Console.ReadLine());
    if ((month == 3 && day >= 20) || (month > 3 && month < 6) || (month == 6 && day <= 20))
    {
        Console.WriteLine("Spring season");
    }
    else
    {
        Console.WriteLine("Not a Spring season");
    }
}

static int l1prob7()
{
    int num = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    for(int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

static int[] l1prob8()
{
    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());
    int num3 = Convert.ToInt32(Console.ReadLine());
    int greatest = 0;
    int smallest = 0;
    if(num1>num2 && num1 > num3)
    {
        greatest = num1;
    }
    else if (num2 > num1 && num2 > num3)
    {
        greatest = num2;
    }
    else
    {
        greatest = num3;
    }

    if (num1 < num2 && num1 < num3)
    {
        smallest = num1;
    }
    else if (num2 < num1 && num2 < num3)
    {
        smallest = num2;
    }
    else
    {
        smallest = num3;
    }
    return new int[] { smallest, greatest };
}

static int[] l1prob9()
{
    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());
    return new int[] { num1/num2, num1%num2 };
}

static int[] l1prob10()
{
    int numPfChoc = Convert.ToInt32(Console.ReadLine());
    int numOfChild = Convert.ToInt32(Console.ReadLine());
    return new int[] { numPfChoc / numOfChild, numPfChoc % numOfChild };
}

static double l1prob11()
{
    double temp = Convert.ToDouble(Console.ReadLine());
    double windSpeed = Convert.ToDouble(Console.ReadLine());
    double windChill = 35.74 + 0.6215 * temp + (0.4275 * temp - 35.75) * windSpeed * 0.16;
    return windChill;
}

static double[] l1prob12()
{
    double deg = Convert.ToDouble(Console.ReadLine());
    double rad =deg*(Math.PI/180);
    return new double[] {Math.Sin(rad),Math.Cos(rad),Math.Tan(rad)};
}


