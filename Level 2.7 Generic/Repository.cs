using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_2._7_Generic
{
    internal class Repository<T>
    {
        private List<T> _list = new List<T>();

        public void AddItem(T item)
        {
            _list.Add(item);
        }

        public void RemoveItem(T item)
        {
            _list.Remove(item);
        }

        public void Print(T item)
        {
            Console.WriteLine("---------------------------");
            foreach (T item2 in _list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
        }
    }
}
