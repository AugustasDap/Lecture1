using Level_2._8_Exception_handling;
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
        //Task 1 System.Convert.ToDouble
        string[] values = { "10.5", "not a number", "123456789012345678901234567890" };

        foreach (string value in values)
        {
            try
            {
                double convertedValue = Convert.ToDouble(value);
                Console.WriteLine($"Converted '{value}' to {convertedValue}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error converting '{value}' to double: Format exception occurred - {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Error converting '{value}' to double: Overflow exception occurred - {ex.Message}");
            }
        }
        BrakeLine();

        //Task 2 try/catch exception
        int[] arr = { 1, 2, 3, 4, 5 };
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
        try
        {
            Console.WriteLine(arr[7]);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Error trying to print. Index Out Of Range Exception - {ex.Message}");
        }
        BrakeLine();

        //Task 3 find errors and write try/catch
        int[] arr2 = { 19, 0, 75, 52 };

        for (int i = 0; i < arr2.Length; i++)
        {
            try
            {
                if (arr2[i] == 0 || arr2[i + 1] == 0)
                {
                    throw new DivideFromZeroException($"Zero in operation");
                }

                Console.WriteLine(arr2[i] / arr2[i + 1]);
            }
            catch (DivideFromZeroException ex)
            {
                Console.WriteLine($"{ex.Message}"); ;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error trying to print - {ex.Message}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Error trying to print - {ex.Message}");
            }

        }
        BrakeLine();

        //Task 4 read file and throw exceptions
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
}