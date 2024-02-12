
using System;
using System.ComponentModel;
using System.Numerics;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    static void Main(string[] args)
    {
        //Task 1.1 random numbers
        /*
        Console.WriteLine("How many numbers to generate?");
        int count;
        int.TryParse(Console.ReadLine(), out count);
        Console.WriteLine("Number range?");
        int count2;
        int.TryParse(Console.ReadLine(), out count2);
        RandomNumber(count, count2);
        */

        //Task 1.2 random boolean
        /*
        for (int i = 0; i < 10; i++)
        {
            bool randomValue = RandomBoolean();
            Console.WriteLine($"Number {i + 1} - {randomValue}");
        }
        */

        //Task 1.3 random letter and random password
        /*
        Console.WriteLine("Random letters:");
        for (int i = 0; i < 10; i++)
        {
            char randomValue = RandomLetterCap();
            Console.WriteLine($"Letter {i + 1} - {randomValue}");
        }
        Console.WriteLine("Random password:");
        for (int i = 0; i < 8; i++)
        {
                char randomValue = RandomLetterCap();
                char randomValue2 = RandomLetterLow();
                Console.Write($"{randomValue}" + randomValue2);                         
        }
        Console.Write('\n');
        */

        //Task 1.4 random 1...6 and sum. Repeat 100 times
        /*
        Console.WriteLine("How many numbers to generate?");
        int count = int.Parse(Console.ReadLine());
        Console.WriteLine("Number range?");
        int count2 = int.Parse(Console.ReadLine());
        RandomSum(count, count2);
        */

        //Task 1.5 generate number, guess, generate new
        /*
        Console.WriteLine("Guess if number greater or less than 50");
        string answer = Console.ReadLine();
        int rand = Random100();
        ReturnResult(answer, rand);
        */

        //Generate100(); 1.5 but guesser





    }

        public static bool ReturnResult(string text, int number)
        {
        if (text == "greater" && number > 50)
            {
            Console.WriteLine("True " + number);
                return true;
            }
        else if (text == "less" &&  number < 50)
            {
            Console.WriteLine("True " + number);
            return true;
            }
        else if (text == "greater" && number < 50)
            {
            Console.WriteLine("The quessed number is too large " + number);
            return false;
            }
        else if (text == "less" && number > 50)
        {
            Console.WriteLine("The quessed number is too small " + number);
            return false;
        }
        return false;
        }

         public static int Random100()
         {
            Random random = new Random();
            int rand = random.Next(0, 101);
            return rand;
        }
        public static void Generate100()
        {
            Random random = new Random();
            int rand = random.Next(0, 101);
            int input;

            do
            {
                Console.WriteLine("Quess number");
                input = int.Parse(Console.ReadLine());
                if (input > rand) Console.WriteLine("nope.. go lower");
                if (input < rand) Console.WriteLine("nope.. go upper");

            } while (input != rand);
            Console.WriteLine("Yup, number was " + input);
        }

        public static void RandomSum(int number, int number2)
        {
            Random random = new Random();
            List<int> randList = new List<int>();
            for (int j=0; j<100; j++)
            {
                for (int i = 0; i < number; i++)
                {
                    int rnumber = random.Next(1, number2);
                    randList.Add(rnumber);
                    Console.WriteLine($"Number {i + 1} - {rnumber}");
                }
                int randListSum = randList.Sum();
                Console.WriteLine($"Number sum: {randListSum}");
            } 
        }
    
        public static void RandomNumber(int number, int number2) 
        {
            Random random = new Random();
        
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Number {i+1} - {random.Next(1, number2)}");
            }
        }

        public static bool RandomBoolean()
        {
            Random random = new Random();
            return random.Next(2) == 0;
        }

        public static char RandomLetterCap()
        {
            Random random = new Random();
            const string lettersCap = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return lettersCap[random.Next(lettersCap.Length)];        
        }

        public static char RandomLetterLow() 
        {
            Random random = new Random();
            const string lettersLow = "abcdefghijklmnopqrstuvwxyz";
            return lettersLow[random.Next(lettersLow.Length)];
        }
}