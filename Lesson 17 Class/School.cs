using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17_Class
{
    internal class School
    {
        public School(string name, string city)
        {
            Name = name;
            City = city;
        }

        public School(string name, string city, int numberOfStudents) : this(name, city)
        {
            NumberOfStudents = numberOfStudents;
        }

        public string Name { get; set; }
        public string City { get; set; }
        public int NumberOfStudents { get; set; }
    }
}
