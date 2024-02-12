using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_2._7_Generic
{
    internal class Validation2
    {
        public static void Validate<T>(T item, string paramName)
        {
            if (item == null) throw new ArgumentNullException(paramName, $"{paramName} cannot be null.");
        }
    }
}
