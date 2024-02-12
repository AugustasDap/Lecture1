using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_2._12_Interfaces_and_IComparer
{
    internal class Bass : IAnimal, IFish
    {
        public void Eat()
        {
            Console.WriteLine("Bass is eating");
        }
        public void Swim()
        {
            Console.WriteLine("Bass is swimming");
        }
    }
}
