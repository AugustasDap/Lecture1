
using Lesson_17_Class;
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
        //Task 1.1
        //Person person = new Person("Augustas", 25, 1.85);
        //person.Name = "Jonas";
        //Console.WriteLine(person.Name + " " + person.Age + " " + person.Height);

        //Task 1.2
        //School school = new School("Gimnazija", "Vilnius");
        //Console.WriteLine(school.Name + " is in " + school.City);

        //Task 2.1

        Book book = new Book("Metai", "Donelaitis", 1750);
        Console.WriteLine("Knyga " + book.Title + " parase " + book.Author + " " + book.Year + " metais");
        BrakeLine();
        //Task 2.2
        Book book2 = new Book("Hobitas", "Tolkienas", 1900, "Didzioji Britanija");
        Console.WriteLine("Knyga " + book2.Title + " parase " + book2.Author + " " + book2.Year + " metais. Salis: " + book2.CountryOfEdition);
        BrakeLine();
        //Task 2.3
        List<Book> books = new()
        {
            new("Vilnius", "Gediminas", 1323, "Lietuva"),
            new("Trakai", "Vytautas", 1223, "Lietuva"),
            new("Hamletas", "Gediminas", 1323, "Lietuva")
        };
        List<Book> result = BooksFiltered(books, "Gediminas");
        PrintList(result);
        BrakeLine();

        //Task 2.4
        List<string> products = new()
        {
            new("suris"),
            new("mesa"),
            new("vanduo"),
            new("sviestas")
        };

        Store store = new Store("Maxima", 1999, products);
        Store store2 = new Store("Norfa", 2003, products);
        List<Store> stores = new List<Store> { store, store2 };
        foreach (Store s in stores)
        {

            foreach (string product in s.Products)
            {
                Console.WriteLine(s.Name + " " + s.OpenYear + " - " + product);
            }
        }


    }


    static void PrintList2(List<Store> list)
    {
        foreach (Store item in list)
        {
            Console.WriteLine(item.Name + item.OpenYear + " " + item.Products);
        }
    }


    public static List<Book> BooksFiltered(List<Book> books, string author)
    {
        List<Book> filtered = new List<Book>();
        foreach (Book item in books)
        {
            if (item.Author == author)
            {
                filtered.Add(item);
            }
        }
        return filtered;
    }

    static void PrintList(List<Book> list)
    {
        foreach (Book item in list)
        {
            Console.WriteLine(item.Title);
        }
    }

    static void BrakeLine()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("**********************");
        Console.ResetColor();
    }


}