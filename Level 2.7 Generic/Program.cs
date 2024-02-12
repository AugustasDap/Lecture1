using Level_2._7_Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Reflection.Emit;
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
        Print<string>("ozonas");
        Print("ozonas");
        Print(1234);
        Print(true);
        //Print(new List<int> { 1, 2, 3 });
        //Print(new int[] { 1, 2, 5 });

        //Repository<int> repository = new Repository<int>();
        //var repository = new Repository<int>();
        //repository.AddItem(1234);
        var repository = new Repository<string>();
        repository.AddItem("ozonas");
        repository.AddItem("murma");
        repository.AddItem("kate");
        repository.AddItem("pele");
        */

        //Task 1 validation

        Validation<string> validator = new Validation<string>();

        string input = null;
        try
        {
            validator.Validate(input, nameof(input));
            Console.WriteLine("Validation passed!");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine($"Validation failed: {ex.Message}");
        }
        BrakeLine();

        //Task 2 validation modified
        string input2 = "ozonas";
        try
        {
            Validation2.Validate(input2, nameof(input2));
            Console.WriteLine("Validation passed!");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine($"Validation failed: {ex.Message}");
        }
        BrakeLine();

        //Task 3 get type
        Task3.ShowValues("ozonas", 5);
        string stringValue = "ozonas";
        double intValue = 5.5;
        Task3.ShowValues(stringValue, intValue);
        BrakeLine();

        //Task 4 extend to delete an item from array
        var selfMadeList = new MySelfMadeList<int>();
        for (int i = 0; i < 5; i++)
        {
            selfMadeList.AddElement(i);
        }
        selfMadeList.PrintList();
        selfMadeList.RemoveElement(0);
        Console.WriteLine($"Removing");
        selfMadeList.PrintList();
        BrakeLine();

        //Task 2-1 two T, print, change values
        Pair<int, string> myPair = new Pair<int, string>(10, "Hello");
        Console.WriteLine("Initial values:");
        myPair.PrintFirst();
        myPair.PrintSecond();

        myPair.First = 20;
        myPair.Second = "World";

        myPair.SetFirst(30);
        myPair.SetSecond("Universe");
        BrakeLine();

        //Task 2-2 four side geometric figure
        FourSideGeometricFigure rectangle = new FourSideGeometricFigure("Rectangle", 5, 10);
        Console.WriteLine($"The area of the {rectangle.Name} is: {rectangle.GetArea()}");
        Console.WriteLine(rectangle); //overrided
        Generator<FourSideGeometricFigure> figureGenerator = new Generator<FourSideGeometricFigure>();
        figureGenerator.Show(rectangle);
        BrakeLine();

        //Task 2-3 get type info
        Type<int, string> typeInstance = new Type<int, string>();
        int intValue2 = 5;
        string stringValue2 = "Hello";
        typeInstance.GetType(intValue2);
        typeInstance.GetType(stringValue2);
        BrakeLine();

        //Task 2-4 sport teams
        SportLeague<string> footballLeague = new SportLeague<string>("Football");
        try
        {
            footballLeague.AddTeam("Team A", "Football");
            footballLeague.AddTeam("Team B", "Football");
            footballLeague.AddTeam("Team C", "Football");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        footballLeague.PrintTeams();

        SportLeague<string> basketballLeague = new SportLeague<string>("Basketball");
        try
        {
            footballLeague.AddTeam("Team X", "Basketball");
            footballLeague.AddTeam("Team Y", "Basketball");
            footballLeague.AddTeam("Team Z", "Football");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        basketballLeague.PrintTeams();
        BrakeLine();

    }
    static void BrakeLine()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("*********");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("*********");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("*********");
        Console.ResetColor();
    }
    public static void Print<T>(T item)
    {
        Console.WriteLine(item);
    }
}
