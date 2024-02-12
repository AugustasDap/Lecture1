using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_2._2_Class_Methods
{
    internal class Numbers
    {
        public Numbers(List<int> numbers)
        {
            NumbersList = numbers;
        }

        public List<int> NumbersList { get; set; }
    }
}
