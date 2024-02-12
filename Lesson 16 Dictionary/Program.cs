
using System;
using System.ComponentModel;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    static void Main(string[] args)
    {

        //Lesson 
        /*
        Dictionary<string, int> ageOfPeople = new Dictionary<string, int>();

        ageOfPeople.Add("Rokas", 24);
        ageOfPeople.Add("Tomas", 28);
        ageOfPeople.Add("Jonas", 33);

        Console.WriteLine($"Rokas age is {ageOfPeople["Rokas"]}");

        if(ageOfPeople.ContainsKey("Jonas"))
        {
            Console.WriteLine($"Jonas age is {ageOfPeople["Jonas"]}");
        }
        else
        {
            Console.WriteLine("We don't have Jonas");
        }

        Console.WriteLine("1---------------------------------");

        PrintPeopleAndAge(ageOfPeople);

        Console.WriteLine("2---------------------------------");

        ageOfPeople.Remove("Rokas");
        PrintPeopleAndAge(ageOfPeople);

        Console.WriteLine("3---------------------------------");

        RemoveByValue(ageOfPeople, 24);
        PrintPeopleAndAge(ageOfPeople);
        */

        // Task 1.1 print names and age
        /*
        Dictionary<string, int> ageOfPeople = new Dictionary<string, int>();
        ageOfPeople.Add("Darius", 24);
        ageOfPeople.Add("Petras", 28);
        ageOfPeople.Add("Miglė", 33);
        PrintPeopleAndAge(ageOfPeople);
        */

        //Task 1.2 print capital of entered country
        /*
        Dictionary<string, string> capitalOf = new Dictionary<string, string>();
        capitalOf.Add("LT", "Vilnius");
        capitalOf.Add("LV", "Riga");
        capitalOf.Add("EE", "Tallin");
        capitalOf.Add("PL", "Warsaw");
        Console.WriteLine("Enter country");
        ReturnCapital(capitalOf);
        */

        //Task 1.3 existing fruits and user input
        /*
        Dictionary<string, int> fruit = new Dictionary<string, int>();
        fruit.Add("Apple", 1);
        fruit.Add("Banana", 5);
        fruit.Add("Blueberry", 6);
        fruit.Add("Raspberry", 2);
        PrintFruitAndQuantity(fruit);
        Console.WriteLine();
        Console.WriteLine("What to update, fruit or qty?");
        string input = Console.ReadLine();
        
        if (input == "fruit") //keisim vaisiu
        {
            Console.WriteLine();
            Console.WriteLine("What fruit to add?");
            string inputFruit = Console.ReadLine();
            Console.WriteLine("Quantity?");
            int inputQty = int.Parse(Console.ReadLine());
            AddNewFruit(fruit, inputFruit, inputQty);
            Console.WriteLine();
            PrintFruitAndQuantity(fruit);
        }
        else if (input == "qty") //keiciam kieki
        {
            Console.WriteLine();
            Console.WriteLine("What fruit to update?");
            string inputFruit = Console.ReadLine();
            Console.WriteLine("Updated quantity?");
            int inputQty = int.Parse(Console.ReadLine());
            AddNewQuantity(fruit, inputFruit, inputQty);
            Console.WriteLine();
            PrintFruitAndQuantity(fruit);
        }
        else 
        {
            Console.WriteLine("Error. Can't identify input");
        }
        */

        //Task 2.1 city and population
        /*
        Dictionary<string, int> population = new Dictionary<string, int>();
        population.Add("Vilnius", 600000);
        population.Add("Kaunas", 500000);
        population.Add("Šiauliai", 200000);
        population.Add("Panevėžys", 250000);
        population.Add("Klaipėda", 350000);
        EnterNameGetPopulation(population);
        */

    }
    public static void PrintPeopleAndAge(Dictionary<string, int> dict)
    {
        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key} age value {item.Value}");
        }
    }

    public static void RemoveByValue(Dictionary<string, int> dict, int valueToRemove)
    {
        if(!dict.ContainsValue(valueToRemove))
        {
            return; //end this method
        }
        foreach (var item in dict)
        {
           if (item.Value == valueToRemove)
            {
                dict.Remove(item.Key);
            }
        }
    }

    public static string ReturnCapital(Dictionary<string, string>dict)
        {
            string input = Console.ReadLine();

        if (dict.ContainsKey(input))
        {
            Console.WriteLine($"{input} capital is {dict[input]}");
        }
        else
        {
            Console.WriteLine("Error, the capital not found");
        }
  
            return dict[input];
         }

    public static void PrintFruitAndQuantity(Dictionary<string, int> dict)
    {
        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key} - {item.Value} unit(-s)");
        }
    }

    public static void AddNewQuantity(Dictionary<string, int> dict, string fruit, int quantity)
    {
        dict[fruit] = quantity;
    }
    public static void AddNewFruit(Dictionary<string, int> dict, string fruit, int quantity)
    {
        dict.Add(fruit, quantity);
    }

    public static void PrintCityAndPopulation(Dictionary<string, int> dict)
    {
        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key} population is {item.Value} ppl");
        }
    }

    public static void EnterNameGetPopulation(Dictionary<string, int> dict)
    {
        Console.WriteLine("Enter city");
        string city = Console.ReadLine();
        if (dict.ContainsKey(city))
            {
            Console.WriteLine();
            Console.WriteLine($"{city} population is {dict[city]} ppl");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"Have no data for {city}. Here is what I have:");
            Console.WriteLine();
            PrintCityAndPopulation(dict);
        }
    }
}