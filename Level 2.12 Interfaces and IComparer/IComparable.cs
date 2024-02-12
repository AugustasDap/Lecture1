using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_2._12_Interfaces_and_IComparer
{
    public interface IComparable<T>
    {
        int CompareTo(T other);
    }
}
