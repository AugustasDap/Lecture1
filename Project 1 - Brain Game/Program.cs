
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
        Console.WriteLine("Welcome to Brain War Game. Please make a selection:");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("1. Login");
        Console.WriteLine("2. Logout");
        Console.WriteLine("3. Rules");
        Console.WriteLine("4. Results/ Players");
        Console.WriteLine("5. Start game");
        Console.WriteLine("6. EXIT game");
        Console.WriteLine();
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
        string step1 = Console.ReadLine();
        Console.ResetColor();
        Console.WriteLine();
        GameMenuExplained(step1);

        string step2 = GameMenu();
        GameMenuExplained(step2);
    }



        public static void GameMenuExplained(string number)
        {
            switch (number)
            {
                case "1": //login
                Dictionary<string, string> participant = new Dictionary<string, string>();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Please write your name");
                string name = Console.ReadLine();
                Console.WriteLine("Please write your surname");
                string surname = Console.ReadLine();
                Console.ResetColor();
                ParticipantList(participant, name, surname);
                Console.WriteLine(); 
                


                break;

                case "2":
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Logout");
                Console.ResetColor();
                break;

                case "3":
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Rules");
                    Console.WriteLine("Here will be game rules");
                Console.ResetColor();
                break;

                case "4":
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Results/ Players");
                Console.ResetColor();
                break;

                case "5":
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Start game");
                Console.ResetColor();
                break;

                case "6":
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("EXIT game");
                Console.ResetColor();
                break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("error..");
                Console.ResetColor();
                break;
            }
        }

        public static string GameMenu()
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
        return input;
        }

        public static void ParticipantList(Dictionary<string, string> dict, string name, string surname) 
        {
            dict.Add(name, surname);
            if (dict.ContainsValue(surname) == false)
                {
                Console.WriteLine("User already exist");
            }
            else
            {
                Console.WriteLine($"Welcome to the game {name} {surname}");
            }
        }


}
