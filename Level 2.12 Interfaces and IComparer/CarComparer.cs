using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_2._12_Interfaces_and_IComparer
{
    public class CarComparer : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            return x.Fuel.CompareTo(y.Fuel);
        }
    }
}
