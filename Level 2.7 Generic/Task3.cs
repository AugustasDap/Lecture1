using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_2._7_Generic
{
    internal class Task3
    {
        public static void ShowValues<T1, T2>(T1 value1, T2 value2)
        {
            Console.WriteLine($"Value1: {value1.GetType()}");
            Console.WriteLine($"Value2: {value2.GetType()}");
        }

    }
}
