// See https://aka.ms/new-console-template for more information

using System.ComponentModel.DataAnnotations;

internal class Program
{
    static void Main(string[] args)
    {
        //int sum = Sum(1, 2);
        //Console.WriteLine(sum);

        //bool isLegal = IsOfLegalAge(1999);//use of method CalculateAge in method IsOfLegalAge
        //Console.WriteLine(isLegal); 

        //Console.WriteLine(CalculateAge(1978));//use of method CalculateAge

        //Recursion(5);//use of recursion

        //// Task 1.1 - check password lenght (8 is true)
        //Console.WriteLine("Enter password");
        //bool result = IsPasswordValid(Console.ReadLine());
        //Console.WriteLine(result);

        //// Task 1.2 - chack email for @ and .
        //Console.WriteLine("Enter valid email");
        //bool validEmail = IsEmailValid(Console.ReadLine());
        //Console.WriteLine(validEmail);

        //// Task 1.3 - convert $ to EUR
        //Console.WriteLine("Enter amount in $ you want to convert to EUR");
        //double value = ConvertToEuros(double.Parse(Console.ReadLine()));
        //Console.WriteLine(value + " EUR");

        ////Task 2.1 print name and second name in one line
        //Console.WriteLine("Enter your name");
        //string firstName = Console.ReadLine();
        //Console.WriteLine("Enter your last name");
        //string lastName = Console.ReadLine();
        //string allNames = GetInitials(firstName) + " " + GetInitials(lastName);
        //Console.WriteLine(allNames);

        ////Task 2.2 calculate cylinder volume
        //Console.WriteLine("Enter cylinder radius");
        //double cylRadius = double.Parse(Console.ReadLine());
        //Console.WriteLine("Enter cylinder height");
        //double cylHeight = double.Parse(Console.ReadLine());
        //double cylVol = CalculateCylinderVolume(cylRadius, cylHeight);
        //Console.WriteLine($"Cylinder volume is {cylVol} m3");

        ////Task 2.3 even or odd
        //Console.WriteLine("Write number to know if it's even or odd");
        //int inp = int.Parse(Console.ReadLine());
        //bool oddEven = IsNumberEven(inp);
        //if (oddEven == true)
        //{
        //    Console.WriteLine($"{inp} is even");
        //}
        //else Console.WriteLine($"{inp} is odd");

        ////Task 2.4 rectangular area
        //Console.WriteLine("Enter rectangular length, cm");
        //double recLength = double.Parse(Console.ReadLine());
        //Console.WriteLine("Enter rectangular width, cm");
        //double recWidth = double.Parse(Console.ReadLine());
        //double recArea = CalculateRectangleArea(recLength, recWidth);
        //Console.WriteLine($"Area of rectangular with {recLength} cm length and {recWidth} cm width is {recArea} cm2");
    }

    //Task 2.4
    public static double CalculateRectangleArea (double length, double width)
    {
        return length * width;
    }

    //Task 2.3
    public static bool IsNumberEven (int number)
    {
        return number % 2 == 0;
    }

    //Task 2.2
    public static double CalculateCylinderVolume (double radius, double height)
    {
        return Math.PI * radius * radius * height;
    }

    //Task 2.1
    public static string GetInitials(string name)
    {
        return name;
    }

    //Task 1.3
    public static double ConvertToEuros(double value)
    {
        return value = value * 0.92;
    }
    //Task 1.2
    public static bool IsEmailValid(string email)
    {
        return email.Contains("@") && email.Contains(".");
    }
    //Task 1.1
    public static bool IsPasswordValid(string password)
    {
        return password.Length >= 8;
    }


    //paskaitos metodai
    public static void Recursion(int number)
    {
        if (number == 0)
        {
            return; //ending recursion when conditions are reached
        }
        Console.WriteLine(number);
        Recursion(number - 1);
    }
    public static bool IsOfLegalAge(int yearOfBirth)
    {
        return CalculateAge(yearOfBirth) <= 18;

    }
    public static int CalculateAge(int yarOfBirth)
    {
        return DateTime.Now.Year - yarOfBirth;
    }
    public static int Sum(int x, int y)
    {
        return x + y;
    }



}

