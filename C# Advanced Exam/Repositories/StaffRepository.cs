using C__Advanced_Exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced_Exam.Repositories
{
    public class StaffRepository
    {
        private readonly List<Staff> staff = new List<Staff>();

        public StaffRepository()
        {
            LoadStaffFromFile("C:\\Users\\Augustas\\source\\repos\\First\\C# Advanced Exam\\Data\\Staff.txt"); //staff file
        }

        public void LoadStaffFromFile(string filePath)
        {
            try
            {
                foreach (var item in File.ReadAllLines(filePath))
                {
                    string[] Array = item.Split(';');
                    staff.Add(new Staff
                    {
                        Id = Array[0],
                        Pin = int.Parse(Array[1]),
                    });
                }

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Error: {filePath} not found. No valid staff ID's loaded.");
            }
        }

        public Staff GetId(string id)
        {
            return staff.FirstOrDefault(x => x.Id == id);
        }

        public bool IsValidStaffId(string id)
        {
            return !string.IsNullOrEmpty(id) && staff.Any(x => x.Id == id);
        }

        public bool IsPinValid(string id, string pin)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(pin))
            {
                return false;
            }
            var emplyee = staff.FirstOrDefault(x => x.Id == id);
            if (emplyee != null)
            {
                return emplyee.Pin.ToString() == pin;
            }
            return false;

        }

    }
}
