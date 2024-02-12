using System.Text;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    static void Main(string[] args)
    {
        //task 1
        //int a = 10;
        //int b = 5;
        //int c = 18;

        //int max = a;
        //if (b > max)
        //    max = b;
        //if (c > max)
        //    max = c; //b>>c
        //Console.WriteLine("The maximum value is: " + max);


        //task 2
        //string firstName = "John";
        //    string lastName = "Doe";
        //    string fullName = firstName + " " + lastName; //need space
        //    Console.WriteLine("Full Name: " + fullName);

        //task 3
        //int counter = 1; //was 0
        //while (counter <= 10) 
        //{
        //    Console.WriteLine("Count: " + counter);
        //    counter++; //was --
        //}

        //task 4
        //int i = 1; //was 5
        //while (i<=5) //was (i>0)
        //{
        //    Console.WriteLine(i);
        //    i++;
        //}

        //task 5
        //string name1 = "John";
        //string name2 = "john";

        //if (string.Equals(name1, name2, StringComparison.OrdinalIgnoreCase)) //(name1.Equals(name2))
        //{
        //    Console.WriteLine("Names are the same.");
        //}
        //else
        //{
        //    Console.WriteLine("Names are different.");
        //}

        //task 6.1 //write text in reverse
        Console.WriteLine("Enter text:");
        string textToReverse = Console.ReadLine();
        string reversed = InvertString(textToReverse);
        Console.WriteLine(reversed.ToString());
    }

    public static string InvertString (string text)
    {
        StringBuilder stringBuilder = new StringBuilder(text.Length);
        for (int i = text.Length - 1; i >= 0; i--)
        {
            stringBuilder.Append(text[i]);
        }
        return stringBuilder.ToString();
    }
}