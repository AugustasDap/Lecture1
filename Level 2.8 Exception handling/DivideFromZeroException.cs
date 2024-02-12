using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_2._8_Exception_handling
{
    public class DivideFromZeroException : Exception
    {
        public DivideFromZeroException(string message) : base(message)
        {
        }
    }
}
