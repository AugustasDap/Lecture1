using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_2._12_Interfaces_and_IComparer
{
    internal class BmwCar : Car
    {
        public bool IsXDrive { get; set; }
        public override string Model { get; set; }
        public BmwCar(string model, int fuel, bool isXDrive) : base(fuel)
        {
            Model = model;
            IsXDrive = isXDrive;
        }
    }
}
