// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    static void Main(string[] args)
    {
        static void Lesson()
        {
            // Class 1+2

            int number = 100;
            string name = "Rokas";
            //AddTen(ref number);
            AddNameLenght(ref number, name);
            Console.WriteLine(number);


            // Class 3

            int result;
            bool isValid = TryToMultiply(0, 8, out result);
            if (isValid)
            {
                Console.WriteLine("Nice");
            }
            else
            {
                Console.WriteLine("You can't multiply by 0");
            }
        }

        static void Task1()
        {
            int num1 = 10;
            int num2 = 20;
            Swap(ref num1, ref num2);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }

        static void Task2()
        {
            int num = 55;
            IncrementByN(ref num);
            Console.WriteLine(num);
        }

        static void Task3()
        {
            string name = " hippo ";
            TrimAndCapitalize(ref name);
            Console.WriteLine(name);
        }

        static void Task2x1() {


        GetUserData(out string name, out string lastName);
        Console.WriteLine("Hello " + name + " " + lastName);
    }
    }




    //Task 2.2
    static bool TryParse(int x)
    {
        while (true)
        {
            x = int.Parse(Console.ReadLine());
        }
       
    }


    // Task 2.1
    static void GetUserData(out string name, out string lastName)
    {
        Console.WriteLine("Your name?");
        name = Console.ReadLine();
        Console.WriteLine("Your last name?");
        lastName = Console.ReadLine();
    }


    // Task 1.3
    static void TrimAndCapitalize(ref string s)
    {
       s = s.Trim();
       s = char.ToUpper(s[0]) + s.Substring(1);             
    }

    // Task 1.2
    static void IncrementByN(ref int n) //prideti antra int ir incrementint
    {
        n = n + 25;
    }

    // Task 1.1
    static void Swap(ref int x, ref int y)
    {
        int originalx = x;
        x = y;
        y = originalx;
        //(x,y) = (y,x)

    }


    //Class 3
    static bool TryToMultiply(int a, int b, out int result)
    {
        result = a * b;
        if(a == 0 || b ==0) 
        {
            //Console.WriteLine("You can't multiply by 0")
            return false;
        }
        return true;
    }

    //Class 2
    static void AddNameLenght(ref int x, string name)
    {
        x += name.Length;
    }
    //Class 1
    static void AddTen(ref int x) 
    {
        x += 10;
    }
}
