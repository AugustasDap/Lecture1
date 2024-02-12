using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_2._12_Interfaces_and_IComparer
{
    internal class Cat : IAnimal, IMammal
    {
        public void Eat()
        {
            Console.WriteLine("Cat is eating");
        }
        public void GiveBirth()
        {
            Console.WriteLine("Cat has kittens");
        }
    }
}
