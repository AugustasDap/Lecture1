
using Level_2._5_Accessibility;
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
        Person person = new Person("Petras", 33);
        //Console.WriteLine($"1. Name: {person.Name}, age: {person.Age}");
        Student student = new Student("Jonas", 33);

        Console.WriteLine(student.GetStudentId());
    }
}