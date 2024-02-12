using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_2._7_Generic
{
    internal class Pair<T1, T2>
    {
        private T1 first;
        private T2 second;

        public Pair(T1 first, T2 second)
        {
            this.first = first;
            this.second = second;
        }

        public T1 First
        {
            get { return first; }
            set { first = value; PrintFirst(); }
        }

        public T2 Second
        {
            get { return second; }
            set { second = value; PrintSecond(); }
        }

        public void PrintFirst()
        {
            Console.WriteLine($"Value of First (T): {first}");
        }
        public void PrintSecond()
        {
            Console.WriteLine($"Value of Second (T): {second}");
        }

        public void SetFirst(T1 newValue)
        {
            first = newValue;
            PrintFirst();
        }

        public void SetSecond(T2 newValue)
        {
            second = newValue;
            PrintSecond();
        }
    }
}
