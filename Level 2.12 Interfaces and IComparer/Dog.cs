using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_2._12_Interfaces_and_IComparer
{
    internal class Dog : IAnimal, IMammal, IComparable<Dog>
    {
        public int Size { get; set; }
        public void Eat()
        {
            Console.WriteLine("Dog is eating");
        }
        public void GiveBirth()
        {
            Console.WriteLine("Dog has puppies");
        }
        public int CompareTo(Dog other)
        {
            return Size.CompareTo(other.Size);
        }
    }
}
