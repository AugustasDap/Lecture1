using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_2._4_Abstractions
{
    internal class Dog : Animal
    {

        public override void MakeNoise()
        {
            Console.WriteLine("au au");
        }
    }
}
