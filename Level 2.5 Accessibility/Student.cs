using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_2._5_Accessibility
{
    internal class Student : Person
    {
        private string StudentID = Guid.NewGuid().ToString(); //?????????

        public Student(string name, int age) : base(name, age) { } //????????

        public string GetStudentId()
        {
            return StudentID;
        }


    }
}
