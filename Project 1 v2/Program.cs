
using System;
using System.ComponentModel;
using System.Numerics;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{


    public static void Main(string[] args)
    {
        string currentUser = null;
        string input = "";
        Dictionary<string, int> participantScore = new Dictionary<string, int>();
        participantScore.Add("Juozas Maljorka", 0);
        participantScore.Add("Ponas Nevidonas", 4);
        do
        {
            if (currentUser == null)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Please write your name");
                string name = Console.ReadLine();
                Console.WriteLine("Please write your surname");
                string surname = Console.ReadLine();
                Console.ResetColor();
                string fullName = name + " " + surname;
                currentUser = fullName;
                ParticipantListAdd(participantScore, fullName);
                Console.WriteLine();
            }
            Console.Clear();
            Console.WriteLine($"{currentUser}, please make your selection:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1. Logout");
            Console.WriteLine("2. Rules");
            Console.WriteLine("3. Results/ Players");
            Console.WriteLine("4. Start game");
            Console.WriteLine("5. EXIT game");
            Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            input = Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine();
            switch (input)
            {
                case "1": //Logout
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    LogOut(ref currentUser);
                    Console.ResetColor();
                    break;
                case "2": //Rules
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Rules();
                    Console.ResetColor();
                    break;
                case "3": //Results/ Players
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    PrintPeople(participantScore);
                    Console.ResetColor();
                    break;
                case "4": //Start game
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Quiz(participantScore, currentUser);
                    Console.ResetColor();
                    break;
                case "5": //EXIT game
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("B Y E");
                    Console.ResetColor();
                    break;
                default: //Error
                    Console.ForegroundColor = ConsoleColor.Red;
                    Error();
                    Console.ResetColor();
                    break;
            }

        }
        while (input != "5");

    }

    public static void PrintPeople(Dictionary<string, int> dict)
    {
        string input = "";
        do
        {
            Console.Clear();

            foreach (var item in dict.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"User {item.Key} score {item.Value}");
            }
            Console.WriteLine("Type q to exit the Game Rules window");
            input = Console.ReadLine();
            Console.Clear();
        }
        while (input != "q");


    }
    private static void Rules()
    {
        string input = "";
        do
        {
            Console.Clear();
            Console.WriteLine("Congratulations on joining the Brain War Game.\n" +
            "Try to answer as many questions, as you can.\n" +
            "Each question add +1 point to your score\n\" +" +
            "Let's go and good luck");
            Console.WriteLine();
            Console.WriteLine("Type q to exit the Game Rules window");
            input = Console.ReadLine();
            Console.Clear();
        }
        while (input != "q");
    }
    public static void GameMenu()
    {
        Console.WriteLine("Please make a selection:");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("2. Logout");
        Console.WriteLine("3. Rules");
        Console.WriteLine("4. Results/ Players");
        Console.WriteLine("5. Start game");
        Console.WriteLine("6. EXIT game");
        Console.WriteLine();
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
        string input = Console.ReadLine();
        Console.ResetColor();

    }
    public static void ParticipantListAdd(Dictionary<string, int> dict, string name)
    {

        if (dict.ContainsKey(name))
        {
            Console.WriteLine("User already exist");
        }
        else
        {
            dict.Add(name, 0);
            Console.WriteLine($"Welcome to Brain War Game {name}");
        }
    }
    public static void LogOut(ref string name)
    {
        string input = "";
        do
        {
            name = null;
            Console.Clear();
            Console.WriteLine($"{name} was logged out");
            Console.WriteLine();
            Console.WriteLine("Type q to exit window");
            input = Console.ReadLine();
            Console.Clear();
        }
        while (input != "q");


    }
    public static void AddResult(Dictionary<string, int> dict, string name, int quantity)
    {
        dict[name] = quantity;
    }
    public static void Quiz(Dictionary<string, int> participantScore, string currentUser)
    {
        string inputas = "";
        do
        {
            Console.Clear();
            Dictionary<string, string> questions = new Dictionary<string, string>();
            questions.Add("Whas is the capital of Lithuania?", "Vilnius");
            questions.Add("City near Baltic sea?", "Klaipeda");
            questions.Add("2+2?", "4");

            int totalQuestions = questions.Count;
            int result = 0;

            foreach (var question in questions)
            {
                Console.WriteLine($"Question: {question.Key}");
                string answer = Console.ReadLine();
                if (answer == question.Value)
                {
                    Console.WriteLine("Yes, +1 point");
                    result++;

                }
                else
                {
                    Console.WriteLine("No, no points");
                }
            }
            AddResult(participantScore, currentUser, result);
            Console.WriteLine("That's it");
            Console.WriteLine();
            Console.WriteLine("Type q to exit the Game Rules window");
            inputas = Console.ReadLine();
            Console.Clear();
        }
        while (inputas != "q");
    }
    public static void Error()
    {
        string input = "";
        do
        {
            Console.Clear();
            Console.WriteLine("error..");
            Console.WriteLine();
            Console.WriteLine("Type q to exit the Game Rules window");
            input = Console.ReadLine();
            Console.Clear();
        }
        while (input != "q");

    }
}
