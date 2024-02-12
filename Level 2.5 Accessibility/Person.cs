using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_2._5_Accessibility
{
    internal class Person
    {
        private string name; //field
        protected int age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        protected string Name
        {
            get { return name; } //properties
            set { name = value; }
        }

        protected int Age
        {
            get { return age; }
            set { age = value; }
        }
        protected void PrintInfo()
        {
            Console.WriteLine($"2. Name: {name}, age: {age}");
        }
    }
}
