
using System.ComponentModel;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    static void Main(string[] args)
    {
        //Task 1.1 Print list members lenght
        /*
        List<string> list = new List<string>();
        list.Add("Vilnius");
        list.Add("Kaunas");
        list.Add("Klaipeda");
        list.Add("Taurage");
        list.Add("Siauliai");
        list.Add("Panevezys");
        PrintLenght(list);
        */

        //Task 1.2 generate 50 random numbers and calculate avg
        /*
        Console.WriteLine("Enter the number of random numbers to generate:");
        int count;
        if (int.TryParse(Console.ReadLine(), out count))
        {
            List<int> randomArray = GenRandArray(count);

            Console.WriteLine("Randomly generated array:");
            foreach (int num in randomArray)
            {
                Console.WriteLine(num);
            }
            double avg = CalculateAverage(randomArray);
            Console.WriteLine($"Average {avg}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        */

        //Task 1.3 accept list and return >10
        /*
        Console.WriteLine("Enter the number of random numbers to generate:");
        int count;
        if (int.TryParse(Console.ReadLine(), out count))
        {
            List<int> randomArray = GenRandArray(count);

            Console.WriteLine("Randomly generated array:");
            foreach (int num in randomArray)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Number(s) greater than 10:");
            ReturnGreater(randomArray);
            
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        */

        //Task 1.4
        /*
        List<string> wordList = new List<string>
        { "apple", "banana", "orange", "grape", "melon", "strawberry", "pineapple", "pear", "blueberry" };

        LettersAreEven(wordList);
        */
       
        
    }

    static void PrintLenght(List<string> list)
    {
        foreach (string item in list) 
        {
        Console.WriteLine($"{item} is lengt of {item.Length} letters");
        }
    }

    static List<int> GenRandArray(int number)
    {
        List<int> randList = new List<int>();
        Random random = new Random();
        for (int i = 0; i < number; i++)
        {
            randList.Add(random.Next(0, 101));
        }
        return randList;
    }
    public static double CalculateAverage(List<int> numbArray)
    {
        return numbArray.Average();        
    }

    public static void ReturnGreater(List<int> numbArray)
    {
        List<int> intList = new List<int>();
        foreach (var number in numbArray)
        {
            if (number > 10)
            {
                intList.Add(number);
                Console.WriteLine($"Number {number}");
            }
        }        
    }

    public static void LettersAreEven(List<string> wordList)
    {
        List<string> words = new List<string>();
        foreach (string word in wordList)
        {
            if (word.Length%2 == 0) //versti i asci ir tada skaiciuoti
            {
                words.Add(word);
                Console.WriteLine(word);
            }
        }
       

    }
}
