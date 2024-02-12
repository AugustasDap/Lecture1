using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_2._9_Extension_Methods
{
    public static class Extension
    {
        //T1
        public static bool IsPositive(this int number)
        {
            return number > 0;
        }

        public static bool IsNegative(this int number)
        {
            return number < 0;
        }

        //T2
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        //T3
        public static bool IsGreaterThan(this int number, int compareTo)
        {
            return number > compareTo;
        }

        //T4
        public static bool ContainsSpaces(this string input)
        {
            return input.Contains(" ");
        }

        //T5
        public static string GenerateEmailAddress(this string fullname, int yearOfBirth, string domain)
        {
            string email = $"{fullname.ToLower().Replace(" ", ".")}{yearOfBirth}@{domain}";
            return email;
        }

        //T6
        public static T FindAndReturnIfEqual<T>(this List<T> list, T itemToFind)
        {
            foreach (T item in list)
            {
                if (EqualityComparer<T>.Default.Equals(item, itemToFind))
                {
                    return item;
                }
            }
            return default;
        }

        //T7
        public static List<T> EveryOtherWord<T>(this List<T> list)
        {
            List<T> result = new List<T>();
            for (int i = 0; i < list.Count; i += 2)
            {
                result.Add(list[i]);
            }
            return result;
        }

        //T8
        public static List<string> ReadEverySecondLine(this string filePath)
        {
            List<string> everySecondLine = new List<string>();
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                for (int i = 1; i < lines.Length; i += 2)
                {
                    everySecondLine.Add(lines[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            return everySecondLine;
        }

        public static List<string> ReadAllButSecondLine(this string filePath)
        {
            List<string> allButSecondLine = new List<string>();
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                for (int i = 0; i < lines.Length; i++)
                {
                    if (i != 1)
                    {
                        allButSecondLine.Add(lines[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            return allButSecondLine;
        }
    }
}
