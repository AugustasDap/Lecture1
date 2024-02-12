using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_2._12_Interfaces_and_IComparer
{
    internal class AudiCar : Car
    {
        public bool IsQuattro { get; set; }
        public override string Model { get; set; }
        public AudiCar(string model, int fuel, bool isQuattro) : base(fuel)
        {
            Model = model;
            IsQuattro = isQuattro;
        }
    }
}
