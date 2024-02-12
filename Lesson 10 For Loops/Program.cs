using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;

internal class Program
{
    static void Main(string[] args)
    {
        static void Lesson ()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("1 loop = " + i);
            }

            int sum = 0;
            for (int j = 10; j >= 0; j--)
            {
                sum += j;
            }
            Console.WriteLine("2 loop = " + sum);

            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("+");
                }
                Console.WriteLine();
            }
        }

        static void Task1 () //all even till 100

        {
            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine("Lyginis " + i);
            }
        }

        static void Task2 () // sum of number 1...n
        {
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int j = 0; j <= n; j++)
            {
                sum += j;

            }
            Console.WriteLine("Sum: " + sum);
        }

        static void Task3BAD () //1.3.1 n squares of integers
        {

            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());
            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(n);
                    }
                    Console.WriteLine();
                }
                Console.Write("");
                Console.WriteLine();
            }
        }
      
        static void Task3 () // 1.3.2 good one

        {
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());
            int sq = 0;
            for (int j = 0; j <= n; j++)
            {
                sq = j * j;
                Console.WriteLine($"Square of {j} is {sq}");
            }
        }

        static void Task4 () //avg of all from 1 to n

        {
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int j = 1; j <= n; j++)
            {
                sum += j;
            }
            int avg = sum / n;
            Console.WriteLine($"Sum is {sum}");
            Console.WriteLine("Avg: " + avg);
        }

        static void Task5 () //column of n height

        {
        Console.WriteLine("Enter number");
        int n = int.Parse(Console.ReadLine());
        for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("*");
                }
        }

        static void Task6 () //divisable by 3
        {
            for (int i = 3; i <= 100; i += 3)
            {
                int div = i / 3;
                Console.WriteLine($"Number {i} is divisable by 3 - {div} (without reminder)");
            }
        }
        

    }
}