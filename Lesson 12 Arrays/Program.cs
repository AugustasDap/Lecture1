
using System.Text;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    static void Main(string[] args)
    {
        //Task 1.1. Return squared array
        //int[] originalArray = { 1, 2, 3, 4, 5, 6 };
        //int[] squareArray = SquaredArray(originalArray);
        //PrintArray(squareArray);

        //Task 1.2 Return sum of array numbersintintint
        //int[] originalArray2 = { 1, 2, 3, 4, 5, 6 };
        //int summedArray = SummedArray(originalArray2);

        //Task 1.3 finding largest of array counts
        //int[] originalArray3 = { 1, 33, 2, 4, 29, 6 };
        //int largest = LargestOfArray(originalArray2);

        //Task 1.4 flipping array back to front
        //int[] originalArray4 = { 1, 2, 3, 4, 5, 6 };
        //int[] reversedArray = BackToFront(originalArray4);

        //Task 2.1 text to letter column
        /*
        Console.WriteLine("Enter word");
        string word = Console.ReadLine();
        //char[] separated = Spelling(word);
        Spelling(word);
        */

        //Task 2.2 + 2.3 print first sentence letter
        Console.WriteLine("Enter sentence");
        string word = Console.ReadLine();
        //char[] firstLastLetter = FirstLastLetter(word);
        FirstLastLetter(word);
    }

    //Print
    public void PrintArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }

    //Task 1.1 square method and print
    public static int[] SquaredArray(int[] numbArray)
    {
        int[] squareArray = new int[numbArray.Length];
        for (int i = 0; i < numbArray.Length; i++)
        {
            squareArray[i] = numbArray[i] * numbArray[i];
            Console.WriteLine("Original array: " + numbArray[i] + ", squared " + squareArray[i]);
        }
        return squareArray;

    }

    //Task 1.2 sum of all array numbers
    public static int SummedArray(int[] numbArray)
    {
        int summedArray = 0;
        for (int i = 0; i < numbArray.Length; i++)
        {
            summedArray += numbArray[i];
            Console.WriteLine("Original array: " + numbArray[i] + " sum with previous " + summedArray);
        }
        return summedArray;
    }

    //Task 1.3 finding largest of array counts
    public static int LargestOfArray(int[] numbArray)
    {
        int largest = 0;
        for (int i = 0; i < numbArray.Length; i++)
        {
            if (largest < numbArray[i])
            {
                largest = numbArray[i];
            }
            Console.WriteLine("Original array: " + numbArray[i] + ", largest number " + largest);
        }

        return largest;
    }

    //Task 1.4 flipping array back to front
    public static int[] BackToFront(int[] numbArray)
    {
        int[] reversedArray = new int[numbArray.Length];
        for (int i = numbArray.Length - 1; i >= 0; i--)
        {
            reversedArray[i] = numbArray[i];
            Console.WriteLine(reversedArray[i]);
        }
        return reversedArray;
    }

    //Task 2.1 text to letter column
    //public static char[] Spelling(string textArray) //reikia, jei yra return
    public static void Spelling(string textArray)
    {
        char[] chars = textArray.ToCharArray();
        for (int i = 0; i < textArray.Length; i++)
        {
            Console.WriteLine("'" + chars[i] + "'");
        }
        //return chars; //nereikia jei void
    }

    //Task 2.2 + 2.3 print first and last letter
    //public static char[] FirstLastLetter(string textArray)
    public static void FirstLastLetter(string textArray)
    {
        char[] chars = textArray.ToCharArray();
        Console.WriteLine(chars[0]);
        Console.WriteLine(chars[textArray.Length - 1]);
        //return chars;
    }
}




