// See https://aka.ms/new-console-template for more information
using Day2;

int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CmToInches.CmToInch(num));
Console.WriteLine(CmToInches.CmToFeet(num));
float FirstNum = Convert.ToSingle(Console.ReadLine());
float SecondNum = Convert.ToSingle(Console.ReadLine());
char Operator = Convert.ToChar(Console.ReadLine());
Console.WriteLine(Calculator.Cal(FirstNum, SecondNum, Operator));
Console.WriteLine(SumOfDigitsOfANumber.SumOfDigits(num));
FizzBuzz.FizzBuz(num);
Console.WriteLine(GreatestFactor.GreatestFacto(num));
FactorsOfNum.Factors(num);
Console.WriteLine(AnglesOfATriangle.AnglesOfATriangl(10, 70, 110));



//level1 practice progams

l1prob1();
l1prob2();
l1prob3();
l1prob4();
l1prob5();
l1prob6();
l1prob7();
l1prob8();
l1prob9();
l1prob10();
l1prob11();
l1prob12();
l1prob13();
l1prob14();
l1prob15();
l1prob16();
l1prob17();
l1prob18();




static void l1prob1()
{
    int num = Convert.ToInt32(Console.ReadLine());
    if (num % 5 == 0) Console.WriteLine("Is the number "+num+" divisible by 5? Yes");
    else Console.WriteLine("Is the number " + num + " divisible by 5? No");
}
static void l1prob2()
{
    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());
    int num3 = Convert.ToInt32(Console.ReadLine());
    if (num1 < num2 && num1 < num3) Console.WriteLine("is the first no smallest? Yes");
    else Console.WriteLine("is the first no. smallest? No");
}
static void l1prob3()
{
    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());
    int num3 = Convert.ToInt32(Console.ReadLine());
    if (num1 >= num2 && num1>=num3)
    {
        Console.WriteLine("Is the first number the largest? Yes");
        Console.WriteLine("Is the Second number the largest? No");
        Console.WriteLine("Is the Third number the largest? No");
    }
    else if(num2>=num1 && num2 >= num3)
    {
        Console.WriteLine("Is the first number the largest? No");
        Console.WriteLine("Is the Second number the largest? Yes");
        Console.WriteLine("Is the Third number the largest? No");
    }
    else
    {
        Console.WriteLine("Is the first number the largest? No");
        Console.WriteLine("Is the Second number the largest? No");
        Console.WriteLine("Is the Third number the largest? Yes");
    }
}
static void l1prob4()
{
    int num = Convert.ToInt32(Console.ReadLine());
    if (num >= 0)
    {
        int sum = ((num * (num + 1)) / 2);
        Console.WriteLine($"The sum of {num} natural numbers is {sum}");
    }
    else
    {
        Console.WriteLine($"The number {num} is not a natural number");
    }
}
static void l1prob5()
{
    int age= Convert.ToInt32(Console.ReadLine());
    if (age >= 18)
    {
        Console.WriteLine("the person can vote");
    }
    else
    {
        Console.WriteLine("the person can not vote");
    }
}
static void l1prob6()
{
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0)
    {
        Console.WriteLine("Positive");
    }else if (num < 0)
    {
        Console.WriteLine("Negative");
    }
    else
    {
        Console.WriteLine("Zero");
    }
}
static void l1prob7()
{
    int day = Convert.ToInt32(Console.ReadLine());
    int month = Convert.ToInt32(Console.ReadLine());
    if((month==3 && day >=20)||(month>3&& month<6)||(month==6&&day<=20))
    {
        Console.WriteLine("Spring season");
    }
    else
    {
        Console.WriteLine("Not a Spring season");
    }
}
static void l1prob8()
{
    int num = Convert.ToInt32(Console.ReadLine());
    while (num >= 1)
    {
        Console.WriteLine((num--) + " ");
    }

}
static void l1prob9()
{
    int num = Convert.ToInt32(Console.ReadLine());
    for(int i = num; i > 0; i--)
    {
        Console.WriteLine(i + " ");
    }
}
static void l1prob10()
{
    double sum = 0;
    while (true)
    {
        double n = Convert.ToDouble(Console.ReadLine());
        if (n == 0) break;
        sum += n;
    }
    Console.WriteLine(sum);
}
static void l1prob11()
{
    double sum = 0;
    while (true)
    {
        double n = Convert.ToDouble(Console.ReadLine());
        if (n <= 0 ) break;
        sum += n;
    }
    Console.WriteLine(sum);
}
static void l1prob12()
{
    int num = Convert.ToInt32(Console.ReadLine());
    int wsum = 0;
    if (num >= 0)
    {
        int sum = ((num * (num + 1)) / 2);
        while (num > 0)
        {
            wsum += num;
            num--;
        }
        if (sum == wsum)
        {
            Console.WriteLine("the sum came out to be same");
        }
    }
    else
    {
        Console.WriteLine($"The number {num} is not a natural number");
    }
}
static void l1prob13()
{
    int num = Convert.ToInt32(Console.ReadLine());
    int wsum = 0;
    if (num >= 0)
    {
        int sum = ((num * (num + 1)) / 2);
        for(int i = 0; i <= num; i++)
        {
            wsum += i;
        }
        if (sum == wsum)
        {
            Console.WriteLine("the sum came out to be same");
        }
    }
    else
    {
        Console.WriteLine($"The number {num} is not a natural number");
    }
}
static void l1prob14()
{
    int num = Convert.ToInt32(Console.ReadLine());
    int ans = 1;
    int copy = num;
    while (copy > 0)
    {
        ans *= copy;
        copy--;
    }
    Console.WriteLine($"the Factorial of the number {num} is {ans}");
}
static void l1prob15()
{
    int num = Convert.ToInt32(Console.ReadLine());
    int ans = 1;
    for (int i = 1; i <= num; i++)
    {
        ans *= i;
    }
    Console.WriteLine($"the Factorial of the number {num} is {ans}");
}
static void l1prob16()
{
    int num = Convert.ToInt32(Console.ReadLine());
    for(int i = 0; i <= num; i++)
    {
        if(i%2==0) Console.WriteLine($"The number {i} is Even");
        else Console.WriteLine($"The number {i} is Odd");
    }
}
static void l1prob17()
{
    int salary = Convert.ToInt32(Console.ReadLine());
    int yearsOfSer = Convert.ToInt32(Console.ReadLine());
    if (yearsOfSer > 5)
    {
        Console.WriteLine($"The bonus for this employee is {.05 * salary}");
    }
    else
    {
        Console.WriteLine("No bonus");
    }
}
static void l1prob18()
{
    int num = Convert.ToInt32(Console.ReadLine());
    for(int i = 6; i <= 9; i++)
    {
        Console.WriteLine($"{num} X {i} = {num*i}");
    }
}


//some l2 problems are solved by making a seperate file for each question rest are here
//prob0 -> LeapYearOrNot.cs
static bool l2prob1(int num)
{
    if (num < 2) return false;
    if (num <= 3) return true;
    for (int i = 2; i * i <= num; i++)
    {
        if (num % i == 0)
        {
            return false;
        }
    }
    return true;
}
static void l2prob2()
{
    int phy = Convert.ToInt32(Console.ReadLine());
    int chem = Convert.ToInt32(Console.ReadLine());
    int maths = Convert.ToInt32(Console.ReadLine());
    double avg = (phy + maths + chem) / 3.0;
    char grade = 'z';
    if (avg >= 80) grade = 'A';
    else if (avg >= 70) grade = 'B';
    else if (avg >= 60) grade = 'C';
    else if (avg >= 50) grade = 'D';
    else if (avg >= 40) grade = 'E';
    else grade = 'R';
    Console.WriteLine($"The average marks obtained by the student is {avg}  and the grade obtained is {grade}");

}
//prob2->FizzBuzz.cs
static void l2prob3()
{
    int num = Convert.ToInt32(Console.ReadLine());
    int i = 0;
    while (i <= num)
    {
        if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("FizzBuzz");
        else if (i % 3 == 0) Console.WriteLine("Fizz");
        else if (i % 5 == 0) Console.WriteLine("Buzz");
        else Console.WriteLine(i);
        i++;
    }
}
static void l2prob4()
{
    double weight = Convert.ToDouble(Console.ReadLine());
    double height = Convert.ToDouble(Console.ReadLine())/100.0;
    double bmi = weight / (height * height);
    string status="";
    if (bmi >= 40.0) status = "Obese";
    else if (bmi >= 25) status = "Overweight";
    else if (bmi <= 18.5) status = "Normal";
    else status = "UnderWeight";
    Console.WriteLine($"the bmi of the person of weight {weight}kg and height {height}m is {bmi} and his status is {status} ");
}
static void l2prob5()
{
    int age1 = Convert.ToInt32(Console.ReadLine());
    int age2 = Convert.ToInt32(Console.ReadLine());
    int age3 = Convert.ToInt32(Console.ReadLine());
    double height1 = Convert.ToDouble(Console.ReadLine());
    double height2 = Convert.ToDouble(Console.ReadLine());
    double height3 = Convert.ToDouble(Console.ReadLine());
    if (age1 <= age2 && age1 <= age3)
    {
        Console.WriteLine("Amar is youngest");
    }
    else if (age2 <= age1 && age2 <= age3)
    {
        Console.WriteLine("Akbar is youngest");
    }
    else
    {
        Console.WriteLine("Anthony is youngest");
    }
    if (height1 >= height2 && height1 >= height3)
    {
        Console.WriteLine("Amar is tallest");
    }
    else if (height2 >= height1 && height2 >= height3)
    {
        Console.WriteLine("Akbar is tallest");
    }
    else
    {
        Console.WriteLine("Anthony is tallest");
    }
}
static void l2prob6()
{
    int num = Convert.ToInt32(Console.ReadLine());
    for(int i = num - 1; i > 0; i++)
    {
        if (num % i == 0)
        {
            Console.WriteLine($"The graetest factor of {num} is {i}");
            break;
        }
    }
}
//prob7->power.cs
//prob8->FactorsOfNum.cs
static void l2prob9()
{
    int num = Convert.ToInt32(Console.ReadLine());
    for(int i = 100; i > 0; i--)
    {
        if (num % i == 0) Console.WriteLine($"{i} is a mutiple of the number {num}");
    }
}


//level3 practice problems
 static void l3prob1()
{
    int num = Convert.ToInt32(Console.ReadLine());
    int copy = num;
    int sum = 0;
    while (copy > 0)
    {
        int lastDigit = num % 10;
        sum += (int)Math.Pow(lastDigit, 3);
        copy /= 10;
    }
    if (sum == num) Console.WriteLine($"The no {num} is armstrong");

}

static void l3prob2()
{
    int num = Convert.ToInt32(Console.ReadLine());
    int ans = 0;
    while (num > 0)
    {
        ans++;
        num /= 10;
    }
    Console.WriteLine($"the total no of digits in the number {num} is {ans}");
}

static void l3prob3()
{
    int num = Convert.ToInt32(Console.ReadLine());
    int copy = num;
    int sum = 0;
    while (copy > 0)
    {
        int lastDigit = num % 10;
        sum += lastDigit;
        copy /= 10;
    }
    if (num%sum==0) Console.WriteLine($"The number {num} is a Harshad number");
    else Console.WriteLine($"The number {num} is not a Harshad number");
}

static void l3prob4()
{
    int num = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    for(int i = 1; i < num; i++)
    {
        if (num % i == 0) sum += i;
    }
    if (num < sum) Console.WriteLine($"The number {num} is a Abundant number");
    else Console.WriteLine($"The number {num} is not a abundant number");
}

//prob6->Calculator.cs