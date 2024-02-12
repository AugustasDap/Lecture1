using Level_2._4_Abstractions;
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
        /*
        Square square = new Square(10, 20);
        Console.WriteLine("Square perimeter: " + square.GetPerimeter());
        Console.WriteLine("Square area: " + square.GetArea());
        BrakeLine();
        Triangle triangle = new Triangle(2, 3, 4);
        Console.WriteLine("Triangle perimeter: " + triangle.GetPerimeter());
        Console.WriteLine("Triangle area: " + triangle.GetArea());
        */

        //Task 1.2
        /*
        Animal dog = new Dog();
        dog.MakeNoise();
        Animal cat = new Cat();
        cat.MakeNoise();
        */

        //Task 1.3

        //List<int> squareHeight = new List<int>();
        //List<int> squareWidth = new List<int>();
        //List<int> triangleA = new List<int>();
        //List<int> triangleB = new List<int>();
        //List<int> triangleC = new List<int>();
        //for (int i = 1; i <= 5; i++)
        //{
        //    squareHeight.Add(i);
        //    squareWidth.Add(i);
        //    triangleA.Add(i);
        //    triangleB.Add(i);
        //    triangleC.Add(i);
        //}
        //foreach (int i in squareHeight)
        //{}

        Square square = new Square(2, 3);
        //Console.WriteLine($"Square with height {square.Height} and width {square.Width} area is {square.GetArea()}");
        //Console.WriteLine($"Square with height {square.Height} and width {square.Width} perimeter is {square.GetPerimeter()}");
        Triangle triangle = new Triangle(1, 2, 3);
        //Console.WriteLine($"Triangle with borders {triangle.BorderA}, {triangleB[i]} and {triangleC[i]} area is {triangle.GetArea()}");
        //Console.WriteLine($"Triangle with borders {triangleA[i]}, {triangleB[i]} and {triangleC[i]} perimeter is {triangle.GetPerimeter()}");
        //BrakeLine();
        List<GeometricShape> shapes = new List<GeometricShape>();
        shapes.Add(square);
        shapes.Add(triangle);
        foreach (GeometricShape shape in shapes)
        {
            Console.WriteLine($"{shape.GetType().Name} plotas {shape.GetArea()}");
            Console.WriteLine($"{shape.GetType().Name} perimetras {shape.GetPerimeter()}");
        }


        //Task 2.1







    }

    static void BrakeLine()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("**********************");
        Console.ResetColor();
    }

}