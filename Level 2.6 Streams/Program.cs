
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
        //Task 1.1 read sample1.txt and print to console
        /*
        string content = File.ReadAllText("C:\\Users\\Augustas\\source\\repos\\First\\Level 2.6 Streams\\sample1.txt");
        Console.WriteLine(content);
        BrakeLine();
        */

        //Task 1.2 write List content to the file
        /*
        List<string> list = new List<string>
        {
            "Hello",
            "This",
            "Is",
            "A",
            "Sample",
            "List"
        };

        string filePath = "C:\\Users\\Augustas\\source\\repos\\First\\Level 2.6 Streams\\sample2.txt";

        try
        {
            File.WriteAllLines("C:\\Users\\Augustas\\source\\repos\\First\\Level 2.6 Streams\\sample2.txt", list);
            Console.WriteLine("Content loaded");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        BrakeLine();
        */

        //Task 1.3. Copy file File.Copy()
        /*
        string sourceFilePath = "C:\\Users\\Augustas\\source\\repos\\First\\Level 2.6 Streams\\sample2.txt";
        string destinationFilePath = "C:\\Users\\Augustas\\Desktop\\sample2_copy.txt";
        try
        {
            File.Copy(sourceFilePath, destinationFilePath); //jei trecias demuo  true - leidzia neistrynus vykdyti
            Console.WriteLine("File copied");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        BrakeLine();
        */

        //Task 2.1 read file, count characters File.ReadLine()
        /*
        string filePathCount = "C:\\Users\\Augustas\\source\\repos\\First\\Level 2.6 Streams\\sample3.txt";
        try
        {
            using (StreamReader reader = new StreamReader("C:\\Users\\Augustas\\source\\repos\\First\\Level 2.6 Streams\\sample3.txt"))
            {
                int lineNumber = 1;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int charCount = line.Length;
                    Console.WriteLine($"Line {lineNumber} has {charCount} characters.");
                    lineNumber++;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        BrakeLine();
        */

        //Task 2.2 write using StreamWriter
        /*
        string filePath = "C:\\Users\\Augustas\\source\\repos\\First\\Level 2.6 Streams\\sample4.txt";
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Lorem ipsum");
                writer.WriteLine(123456);
                writer.WriteLine("Ipsum ipsum");
                Console.WriteLine("Content has been written to the file.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        BrakeLine();
        */

        //Task 2.3 write binary data BinaryWrite BinaryRead

        string filePath = "C:\\Users\\Augustas\\source\\repos\\First\\Level 2.6 Streams\\sample4.txt";

        try
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {

                writer.Write(14);
                writer.Write(3.14);
                writer.Write(true);
                writer.Write("Hello, Binary World!");
                Console.WriteLine("Binary data has been written to the file.");
                BrakeLine();
            }

            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                int intValue = reader.ReadInt32();
                double doubleValue = reader.ReadDouble();
                bool boolValue = reader.ReadBoolean();
                string stringValue = reader.ReadString();

                Console.WriteLine($"Read integer: {intValue}");
                Console.WriteLine($"Read double: {doubleValue}");
                Console.WriteLine($"Read boolean: {boolValue}");
                Console.WriteLine($"Read string: {stringValue}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        BrakeLine();

    }


    static void BrakeLine()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("**********************");
        Console.ResetColor();
    }
}