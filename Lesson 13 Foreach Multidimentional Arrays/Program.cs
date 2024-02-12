
using System.ComponentModel;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    static void Main(string[] args)
    {
        //Lesson
        /*
         int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7, 8, };
         foreach (var i in numbers1)
         {
             Console.WriteLine($"{i}");
         }
        */

        //********************
        /*
              //                  [row, column]
              int[,] matrix = new int[3, 3];
              matrix[0, 0] = 1;
              matrix[0, 1] = 2;
              matrix[0, 2] = 3;

              matrix[1, 0] = 4;
              matrix[1, 1] = 5;
              matrix[1, 2] = 6;

              matrix[2, 0] = 7;
              matrix[2, 1] = 8;
              matrix[2, 2] = 9;

              for (int i = 0; i < matrix.GetLength(0); i++) //rows
              {
                  for (int j = 0; j < matrix.GetLength(1); j++) //colum
                  {
                      Console.Write(matrix[i, j]+"\t"); //PadRight(10) only with text or ToString().PadRight(2)
                  }
                  Console.WriteLine();
              }
        */

        //Task 1.1 return avg of array
        /*
               int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
               CalculateAverage(numbers1);
        */

        //Task 1.2 return positive numbers
        /*
        int[] numbers2 = { 1, -2, 3, 4, -5, 6, 7, -8 };
        ReturnPositive(numbers2);
        */

        //Task 1.3 accept payment and calculate vat
        /*
        double[] numbers3 = { 2.3, 5.6, 9.9, 5.5, 6.99, 5.55 };
        CalculateVat(numbers3);
        */

        //Task 1.4 accept sentence, return array of words
        /*
        Console.WriteLine("Enter sentence");
        ReturnArray(Console.ReadLine());
        */

        //Task 1.5 make deck of cards
        //string[] symbol = { "Spades", "Hearts", "Diamonds", "Clubs" };


        //Task 2.1 create 
        Console.WriteLine("Enter matrix x");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter matrix y");
        int y = int.Parse(Console.ReadLine());
        CreateMatrix(x, y);


    }
    public static int[] CreateArray()
    {
        int[] num;
        Console.WriteLine("Enter values (separated with ,)");
        string input = Console.ReadLine();
        num = Array.ConvertAll(input.Split(','), int.Parse);
        //int[] array = new int[num.Length];
        //for (int i = 0; i < num.Length; i++)
        //{
        //    //array[i] = num[i];
        //    Console.WriteLine(num[i]);
        //}
        return num;

    }

    public static void CreateMatrix(int number1, int number2) //int[] number3
    {
        //int[] ints = CreateArray();
        int[] num;
        Console.WriteLine("Enter values (separated with ,)");
        string input = Console.ReadLine();
        num = Array.ConvertAll(input.Split(','), int.Parse);

        int[,] matrix = new int[number1, number2];
        //for (int i = 0; i < number1; i++)
        //{
        //    for (int j = 0; j < number2; j++)
        //    {
        //        table[i, j] = i + j;
        //    }
        //}
        int k = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            //matrix[i, 0] = num[i];
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = num[k++];
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

    }

    public static void CalculateAverage (int[] numbArray)
    {
        int sumArray = 0;
        foreach (var number in numbArray)
        {
            sumArray += number;            
        }
        int avg = sumArray / numbArray.Length;
        Console.WriteLine($"Suma: {sumArray}. Viso skaiciu: {numbArray.Length}");
        Console.WriteLine($"Vidurkis: {avg}");
    }

    public static void ReturnPositive(int[] numbArray)
    {
        foreach (var number in numbArray)
        {
            if (number >= 0)
            {
                Console.WriteLine(number);
            }         
        }
    }

    public static void CalculateVat(double[] numbArray)
    {
        double sum = 0;
        foreach (var number in numbArray)
        {
            sum += number;
        }
        double vat = sum / 1.15;
        Console.WriteLine($"Sum with VAT {sum}. VAT to pay {vat}");
    }

    public static void ReturnArray(string text)
    {
        string[] words = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries); //can be '!' '.' 
        string[] result = new string[words.Length];
        int index = 0;
        foreach (string word in words)
        {
            if (word.Length >= 5)
            {
                result[index] = word;
                index++;                
            }            
        }
        string[] filteredArray = new string[index];
        Array.Copy(result, filteredArray, index);
        foreach (string word in filteredArray)
        {
            Console.WriteLine(word);
        }
    }


}
