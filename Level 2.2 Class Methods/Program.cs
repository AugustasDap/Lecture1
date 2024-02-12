
using Level_2._2_Class_Methods;
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

        //Task 1.4 library

        Library library = new Library();
        library.AddBook("book1");
        library.AddBook("book2");
        library.AddBook("book3");
        library.AddBook("book4");
        library.AddBook("book5");
        library.DisplayBooks();
        BrakeLine();
        library.RemoveBook("book5");
        library.DisplayBooks();

        //Task 1.5 replace

    }

    static void BrakeLine()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("**********************");
        Console.ResetColor();
    }

}
