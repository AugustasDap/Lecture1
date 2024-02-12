using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_2._7_Generic
{
    internal class Type<T1, T2>
    {
        public void GetType(T1 input)
        {
            Console.WriteLine($"Data type of input: {typeof(T1)}");
        }
        public void GetType(T2 input)
        {
            Console.WriteLine($"Data type of input: {typeof(T2)}");
        }
    }
}
